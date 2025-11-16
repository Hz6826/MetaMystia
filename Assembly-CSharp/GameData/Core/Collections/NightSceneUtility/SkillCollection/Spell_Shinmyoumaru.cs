using System;
using Common.CharacterUtility;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.Input;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000285 RID: 645
	public class Spell_Shinmyoumaru : SpellBase
	{
		// Token: 0x0600513E RID: 20798 RVA: 0x001B31E8 File Offset: 0x001B13E8
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Shinmyoumaru()
		{
			Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Shinmyoumaru");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr);
			Spell_Shinmyoumaru.NativeFieldInfoPtr_SEKIBANKI_HEAD_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "SEKIBANKI_HEAD_ID");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_SEKIBANKI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "SEKIBANKI_ID");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_firstMalletMultiplierRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "firstMalletMultiplierRate");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_otherMalletMultiplierRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "otherMalletMultiplierRate");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "negativeDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_sizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "sizeMultiplier");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_sekibankiSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "sekibankiSpeedMultiplier");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_sekibankiSpeedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "sekibankiSpeedDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "walletVFX");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFXSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "walletVFXSprite");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFXBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "walletVFXBG");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFXCoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "walletVFXCoin");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_waitForWalletTapTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "waitForWalletTapTime");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiMystiaVFX");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiBowlDropFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiBowlDropFX");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiBowlDropDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiBowlDropDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiBowlDisappearDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiBowlDisappearDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaWaitToJumpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiMystiaWaitToJumpDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaSpawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiMystiaSpawnOffset");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaRotatePerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiMystiaRotatePerTime");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaFlyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiMystiaFlyDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiNewBowlVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiNewBowlVFX");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiEnlargeEnergyVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiEnlargeEnergyVFX");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiLandSmokeVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiLandSmokeVFX");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiEnlargeEnergyOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiEnlargeEnergyOffset");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaWaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiMystiaWaitDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaSpawnDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiMystiaSpawnDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaWaitToLandDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiMystiaWaitToLandDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaLandDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiMystiaLandDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaDisappearDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "daiMystiaDisappearDuration");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_walletSpawnSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "walletSpawnSfx");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_walletHitSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "walletHitSfx");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_coinSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "coinSfx");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_bowlDropSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "bowlDropSfx");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_mystyJumpSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "mystyJumpSfx");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_dynamaxSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "dynamaxSfx");
			Spell_Shinmyoumaru.NativeFieldInfoPtr_landSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "landSfx");
			Spell_Shinmyoumaru.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, 100679730);
			Spell_Shinmyoumaru.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, 100679731);
			Spell_Shinmyoumaru.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, 100679732);
			Spell_Shinmyoumaru.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, 100679733);
			Spell_Shinmyoumaru.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, 100679734);
			Spell_Shinmyoumaru.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_1_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, 100679735);
			Spell_Shinmyoumaru.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, 100679736);
			Spell_Shinmyoumaru.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_4_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, 100679737);
			Spell_Shinmyoumaru.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, 100679738);
			Spell_Shinmyoumaru.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_6_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, 100679739);
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x001B35C4 File Offset: 0x001B17C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205054, XrefRangeEnd = 205056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Shinmyoumaru.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x001B3608 File Offset: 0x001B1808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205056, XrefRangeEnd = 205061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Shinmyoumaru.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x001B3664 File Offset: 0x001B1864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205061, XrefRangeEnd = 205066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Shinmyoumaru.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x001B36C0 File Offset: 0x001B18C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205066, XrefRangeEnd = 205067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Shinmyoumaru() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x001B36FC File Offset: 0x001B18FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205067, XrefRangeEnd = 205081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__39_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x001B3730 File Offset: 0x001B1930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205081, XrefRangeEnd = 205089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _OnPositiveBuffExecute_b__39_1(int num, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref num;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_1_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x001B3788 File Offset: 0x001B1988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205089, XrefRangeEnd = 205104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x001B37BC File Offset: 0x001B19BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205104, XrefRangeEnd = 205120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__39_4(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_4_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x001B37FC File Offset: 0x001B19FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205120, XrefRangeEnd = 205122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__39_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x001B3830 File Offset: 0x001B1A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205122, XrefRangeEnd = 205131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _OnPositiveBuffExecute_b__39_6(int currentTime, string des)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(des);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_6_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x0002B277 File Offset: 0x00029477
		public Spell_Shinmyoumaru(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x0600514A RID: 20810 RVA: 0x001B3888 File Offset: 0x001B1A88
		// (set) Token: 0x0600514B RID: 20811 RVA: 0x0002B280 File Offset: 0x00029480
		public unsafe static int SEKIBANKI_HEAD_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Shinmyoumaru.NativeFieldInfoPtr_SEKIBANKI_HEAD_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Shinmyoumaru.NativeFieldInfoPtr_SEKIBANKI_HEAD_ID, (void*)(&value));
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x0600514C RID: 20812 RVA: 0x001B38A4 File Offset: 0x001B1AA4
		// (set) Token: 0x0600514D RID: 20813 RVA: 0x0002B28E File Offset: 0x0002948E
		public unsafe static int SEKIBANKI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Shinmyoumaru.NativeFieldInfoPtr_SEKIBANKI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Shinmyoumaru.NativeFieldInfoPtr_SEKIBANKI_ID, (void*)(&value));
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x0600514E RID: 20814 RVA: 0x001B38C0 File Offset: 0x001B1AC0
		// (set) Token: 0x0600514F RID: 20815 RVA: 0x0002B29C File Offset: 0x0002949C
		public unsafe float firstMalletMultiplierRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_firstMalletMultiplierRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_firstMalletMultiplierRate)) = value;
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06005150 RID: 20816 RVA: 0x001B38E8 File Offset: 0x001B1AE8
		// (set) Token: 0x06005151 RID: 20817 RVA: 0x0002B2B7 File Offset: 0x000294B7
		public unsafe float otherMalletMultiplierRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_otherMalletMultiplierRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_otherMalletMultiplierRate)) = value;
			}
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06005152 RID: 20818 RVA: 0x001B3910 File Offset: 0x001B1B10
		// (set) Token: 0x06005153 RID: 20819 RVA: 0x0002B2D2 File Offset: 0x000294D2
		public unsafe float negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06005154 RID: 20820 RVA: 0x001B3938 File Offset: 0x001B1B38
		// (set) Token: 0x06005155 RID: 20821 RVA: 0x0002B2ED File Offset: 0x000294ED
		public unsafe float sizeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_sizeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_sizeMultiplier)) = value;
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x001B3960 File Offset: 0x001B1B60
		// (set) Token: 0x06005157 RID: 20823 RVA: 0x0002B308 File Offset: 0x00029508
		public unsafe float sekibankiSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_sekibankiSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_sekibankiSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06005158 RID: 20824 RVA: 0x001B3988 File Offset: 0x001B1B88
		// (set) Token: 0x06005159 RID: 20825 RVA: 0x0002B323 File Offset: 0x00029523
		public unsafe int sekibankiSpeedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_sekibankiSpeedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_sekibankiSpeedDuration)) = value;
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x0600515A RID: 20826 RVA: 0x001B39B0 File Offset: 0x001B1BB0
		// (set) Token: 0x0600515B RID: 20827 RVA: 0x0002B33E File Offset: 0x0002953E
		public unsafe GameObject walletVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x0600515C RID: 20828 RVA: 0x001B39E0 File Offset: 0x001B1BE0
		// (set) Token: 0x0600515D RID: 20829 RVA: 0x0002B35D File Offset: 0x0002955D
		public unsafe GameObject walletVFXSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFXSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFXSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x0600515E RID: 20830 RVA: 0x001B3A10 File Offset: 0x001B1C10
		// (set) Token: 0x0600515F RID: 20831 RVA: 0x0002B37C File Offset: 0x0002957C
		public unsafe GameObject walletVFXBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFXBG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFXBG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06005160 RID: 20832 RVA: 0x001B3A40 File Offset: 0x001B1C40
		// (set) Token: 0x06005161 RID: 20833 RVA: 0x0002B39B File Offset: 0x0002959B
		public unsafe GameObject walletVFXCoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFXCoin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletVFXCoin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06005162 RID: 20834 RVA: 0x001B3A70 File Offset: 0x001B1C70
		// (set) Token: 0x06005163 RID: 20835 RVA: 0x0002B3BA File Offset: 0x000295BA
		public unsafe float waitForWalletTapTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_waitForWalletTapTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_waitForWalletTapTime)) = value;
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06005164 RID: 20836 RVA: 0x001B3A98 File Offset: 0x001B1C98
		// (set) Token: 0x06005165 RID: 20837 RVA: 0x0002B3D5 File Offset: 0x000295D5
		public unsafe GameObject daiMystiaVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06005166 RID: 20838 RVA: 0x001B3AC8 File Offset: 0x001B1CC8
		// (set) Token: 0x06005167 RID: 20839 RVA: 0x0002B3F4 File Offset: 0x000295F4
		public unsafe GameObject daiBowlDropFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiBowlDropFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiBowlDropFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06005168 RID: 20840 RVA: 0x001B3AF8 File Offset: 0x001B1CF8
		// (set) Token: 0x06005169 RID: 20841 RVA: 0x0002B413 File Offset: 0x00029613
		public unsafe float daiBowlDropDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiBowlDropDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiBowlDropDuration)) = value;
			}
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x0600516A RID: 20842 RVA: 0x001B3B20 File Offset: 0x001B1D20
		// (set) Token: 0x0600516B RID: 20843 RVA: 0x0002B42E File Offset: 0x0002962E
		public unsafe float daiBowlDisappearDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiBowlDisappearDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiBowlDisappearDuration)) = value;
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x001B3B48 File Offset: 0x001B1D48
		// (set) Token: 0x0600516D RID: 20845 RVA: 0x0002B449 File Offset: 0x00029649
		public unsafe float daiMystiaWaitToJumpDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaWaitToJumpDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaWaitToJumpDuration)) = value;
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x0600516E RID: 20846 RVA: 0x001B3B70 File Offset: 0x001B1D70
		// (set) Token: 0x0600516F RID: 20847 RVA: 0x0002B464 File Offset: 0x00029664
		public unsafe float daiMystiaSpawnOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaSpawnOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaSpawnOffset)) = value;
			}
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06005170 RID: 20848 RVA: 0x001B3B98 File Offset: 0x001B1D98
		// (set) Token: 0x06005171 RID: 20849 RVA: 0x0002B47F File Offset: 0x0002967F
		public unsafe float daiMystiaRotatePerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaRotatePerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaRotatePerTime)) = value;
			}
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06005172 RID: 20850 RVA: 0x001B3BC0 File Offset: 0x001B1DC0
		// (set) Token: 0x06005173 RID: 20851 RVA: 0x0002B49A File Offset: 0x0002969A
		public unsafe float daiMystiaFlyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaFlyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaFlyDuration)) = value;
			}
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06005174 RID: 20852 RVA: 0x001B3BE8 File Offset: 0x001B1DE8
		// (set) Token: 0x06005175 RID: 20853 RVA: 0x0002B4B5 File Offset: 0x000296B5
		public unsafe GameObject daiNewBowlVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiNewBowlVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiNewBowlVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x001B3C18 File Offset: 0x001B1E18
		// (set) Token: 0x06005177 RID: 20855 RVA: 0x0002B4D4 File Offset: 0x000296D4
		public unsafe GameObject daiEnlargeEnergyVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiEnlargeEnergyVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiEnlargeEnergyVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06005178 RID: 20856 RVA: 0x001B3C48 File Offset: 0x001B1E48
		// (set) Token: 0x06005179 RID: 20857 RVA: 0x0002B4F3 File Offset: 0x000296F3
		public unsafe GameObject daiLandSmokeVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiLandSmokeVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiLandSmokeVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x0600517A RID: 20858 RVA: 0x001B3C78 File Offset: 0x001B1E78
		// (set) Token: 0x0600517B RID: 20859 RVA: 0x0002B512 File Offset: 0x00029712
		public unsafe float daiEnlargeEnergyOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiEnlargeEnergyOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiEnlargeEnergyOffset)) = value;
			}
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x0600517C RID: 20860 RVA: 0x001B3CA0 File Offset: 0x001B1EA0
		// (set) Token: 0x0600517D RID: 20861 RVA: 0x0002B52D File Offset: 0x0002972D
		public unsafe float daiMystiaWaitDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaWaitDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaWaitDuration)) = value;
			}
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x0600517E RID: 20862 RVA: 0x001B3CC8 File Offset: 0x001B1EC8
		// (set) Token: 0x0600517F RID: 20863 RVA: 0x0002B548 File Offset: 0x00029748
		public unsafe float daiMystiaSpawnDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaSpawnDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaSpawnDuration)) = value;
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06005180 RID: 20864 RVA: 0x001B3CF0 File Offset: 0x001B1EF0
		// (set) Token: 0x06005181 RID: 20865 RVA: 0x0002B563 File Offset: 0x00029763
		public unsafe float daiMystiaWaitToLandDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaWaitToLandDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaWaitToLandDuration)) = value;
			}
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06005182 RID: 20866 RVA: 0x001B3D18 File Offset: 0x001B1F18
		// (set) Token: 0x06005183 RID: 20867 RVA: 0x0002B57E File Offset: 0x0002977E
		public unsafe float daiMystiaLandDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaLandDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaLandDuration)) = value;
			}
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x001B3D40 File Offset: 0x001B1F40
		// (set) Token: 0x06005185 RID: 20869 RVA: 0x0002B599 File Offset: 0x00029799
		public unsafe float daiMystiaDisappearDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaDisappearDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_daiMystiaDisappearDuration)) = value;
			}
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06005186 RID: 20870 RVA: 0x001B3D68 File Offset: 0x001B1F68
		// (set) Token: 0x06005187 RID: 20871 RVA: 0x0002B5B4 File Offset: 0x000297B4
		public SpellBase.DelayAudioClip walletSpawnSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletSpawnSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletSpawnSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06005188 RID: 20872 RVA: 0x001B3D98 File Offset: 0x001B1F98
		// (set) Token: 0x06005189 RID: 20873 RVA: 0x0002B5E2 File Offset: 0x000297E2
		public SpellBase.DelayAudioClip walletHitSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletHitSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_walletHitSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x0600518A RID: 20874 RVA: 0x001B3DC8 File Offset: 0x001B1FC8
		// (set) Token: 0x0600518B RID: 20875 RVA: 0x0002B610 File Offset: 0x00029810
		public SpellBase.DelayAudioClip coinSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_coinSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_coinSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x0600518C RID: 20876 RVA: 0x001B3DF8 File Offset: 0x001B1FF8
		// (set) Token: 0x0600518D RID: 20877 RVA: 0x0002B63E File Offset: 0x0002983E
		public SpellBase.DelayAudioClip bowlDropSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_bowlDropSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_bowlDropSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x0600518E RID: 20878 RVA: 0x001B3E28 File Offset: 0x001B2028
		// (set) Token: 0x0600518F RID: 20879 RVA: 0x0002B66C File Offset: 0x0002986C
		public SpellBase.DelayAudioClip mystyJumpSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_mystyJumpSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_mystyJumpSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x001B3E58 File Offset: 0x001B2058
		// (set) Token: 0x06005191 RID: 20881 RVA: 0x0002B69A File Offset: 0x0002989A
		public SpellBase.DelayAudioClip dynamaxSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_dynamaxSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_dynamaxSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06005192 RID: 20882 RVA: 0x001B3E88 File Offset: 0x001B2088
		// (set) Token: 0x06005193 RID: 20883 RVA: 0x0002B6C8 File Offset: 0x000298C8
		public SpellBase.DelayAudioClip landSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_landSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.NativeFieldInfoPtr_landSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040036EF RID: 14063
		private static readonly IntPtr NativeFieldInfoPtr_SEKIBANKI_HEAD_ID;

		// Token: 0x040036F0 RID: 14064
		private static readonly IntPtr NativeFieldInfoPtr_SEKIBANKI_ID;

		// Token: 0x040036F1 RID: 14065
		private static readonly IntPtr NativeFieldInfoPtr_firstMalletMultiplierRate;

		// Token: 0x040036F2 RID: 14066
		private static readonly IntPtr NativeFieldInfoPtr_otherMalletMultiplierRate;

		// Token: 0x040036F3 RID: 14067
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x040036F4 RID: 14068
		private static readonly IntPtr NativeFieldInfoPtr_sizeMultiplier;

		// Token: 0x040036F5 RID: 14069
		private static readonly IntPtr NativeFieldInfoPtr_sekibankiSpeedMultiplier;

		// Token: 0x040036F6 RID: 14070
		private static readonly IntPtr NativeFieldInfoPtr_sekibankiSpeedDuration;

		// Token: 0x040036F7 RID: 14071
		private static readonly IntPtr NativeFieldInfoPtr_walletVFX;

		// Token: 0x040036F8 RID: 14072
		private static readonly IntPtr NativeFieldInfoPtr_walletVFXSprite;

		// Token: 0x040036F9 RID: 14073
		private static readonly IntPtr NativeFieldInfoPtr_walletVFXBG;

		// Token: 0x040036FA RID: 14074
		private static readonly IntPtr NativeFieldInfoPtr_walletVFXCoin;

		// Token: 0x040036FB RID: 14075
		private static readonly IntPtr NativeFieldInfoPtr_waitForWalletTapTime;

		// Token: 0x040036FC RID: 14076
		private static readonly IntPtr NativeFieldInfoPtr_daiMystiaVFX;

		// Token: 0x040036FD RID: 14077
		private static readonly IntPtr NativeFieldInfoPtr_daiBowlDropFX;

		// Token: 0x040036FE RID: 14078
		private static readonly IntPtr NativeFieldInfoPtr_daiBowlDropDuration;

		// Token: 0x040036FF RID: 14079
		private static readonly IntPtr NativeFieldInfoPtr_daiBowlDisappearDuration;

		// Token: 0x04003700 RID: 14080
		private static readonly IntPtr NativeFieldInfoPtr_daiMystiaWaitToJumpDuration;

		// Token: 0x04003701 RID: 14081
		private static readonly IntPtr NativeFieldInfoPtr_daiMystiaSpawnOffset;

		// Token: 0x04003702 RID: 14082
		private static readonly IntPtr NativeFieldInfoPtr_daiMystiaRotatePerTime;

		// Token: 0x04003703 RID: 14083
		private static readonly IntPtr NativeFieldInfoPtr_daiMystiaFlyDuration;

		// Token: 0x04003704 RID: 14084
		private static readonly IntPtr NativeFieldInfoPtr_daiNewBowlVFX;

		// Token: 0x04003705 RID: 14085
		private static readonly IntPtr NativeFieldInfoPtr_daiEnlargeEnergyVFX;

		// Token: 0x04003706 RID: 14086
		private static readonly IntPtr NativeFieldInfoPtr_daiLandSmokeVFX;

		// Token: 0x04003707 RID: 14087
		private static readonly IntPtr NativeFieldInfoPtr_daiEnlargeEnergyOffset;

		// Token: 0x04003708 RID: 14088
		private static readonly IntPtr NativeFieldInfoPtr_daiMystiaWaitDuration;

		// Token: 0x04003709 RID: 14089
		private static readonly IntPtr NativeFieldInfoPtr_daiMystiaSpawnDuration;

		// Token: 0x0400370A RID: 14090
		private static readonly IntPtr NativeFieldInfoPtr_daiMystiaWaitToLandDuration;

		// Token: 0x0400370B RID: 14091
		private static readonly IntPtr NativeFieldInfoPtr_daiMystiaLandDuration;

		// Token: 0x0400370C RID: 14092
		private static readonly IntPtr NativeFieldInfoPtr_daiMystiaDisappearDuration;

		// Token: 0x0400370D RID: 14093
		private static readonly IntPtr NativeFieldInfoPtr_walletSpawnSfx;

		// Token: 0x0400370E RID: 14094
		private static readonly IntPtr NativeFieldInfoPtr_walletHitSfx;

		// Token: 0x0400370F RID: 14095
		private static readonly IntPtr NativeFieldInfoPtr_coinSfx;

		// Token: 0x04003710 RID: 14096
		private static readonly IntPtr NativeFieldInfoPtr_bowlDropSfx;

		// Token: 0x04003711 RID: 14097
		private static readonly IntPtr NativeFieldInfoPtr_mystyJumpSfx;

		// Token: 0x04003712 RID: 14098
		private static readonly IntPtr NativeFieldInfoPtr_dynamaxSfx;

		// Token: 0x04003713 RID: 14099
		private static readonly IntPtr NativeFieldInfoPtr_landSfx;

		// Token: 0x04003714 RID: 14100
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003715 RID: 14101
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003716 RID: 14102
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003717 RID: 14103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003718 RID: 14104
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_0_Private_Void_0;

		// Token: 0x04003719 RID: 14105
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_1_Private_String_Int32_String_0;

		// Token: 0x0400371A RID: 14106
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x0400371B RID: 14107
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_4_Private_Void_Int32_0;

		// Token: 0x0400371C RID: 14108
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_5_Private_Void_0;

		// Token: 0x0400371D RID: 14109
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_6_Private_String_Int32_String_0;

		// Token: 0x02000BCD RID: 3021
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Shinmyoumaru+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC75 RID: 56437 RVA: 0x003571DC File Offset: 0x003553DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "controller");
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_continueRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "continueRotate");
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_jumpToPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "jumpToPosition");
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_skinSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "skinSprite");
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_alphaDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "alphaDic");
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "targetPosition");
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "transform");
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr___9__20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "<>9__20");
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr___9__21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "<>9__21");
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679740);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679741);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679742);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679743);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679744);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679745);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679746);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679747);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679748);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679749);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679750);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__12_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679751);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__13_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679752);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679753);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__15_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679754);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__19_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679755);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679756);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__20_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679757);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__21_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679758);
				Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, 100679759);
			}

			// Token: 0x0600DC76 RID: 56438 RVA: 0x00357460 File Offset: 0x00355660
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC77 RID: 56439 RVA: 0x0035749C File Offset: 0x0035569C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204586, XrefRangeEnd = 204591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DC78 RID: 56440 RVA: 0x003574DC File Offset: 0x003556DC
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC79 RID: 56441 RVA: 0x00357518 File Offset: 0x00355718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204591, XrefRangeEnd = 204594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC7A RID: 56442 RVA: 0x0035755C File Offset: 0x0035575C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__3(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC7B RID: 56443 RVA: 0x003575A0 File Offset: 0x003557A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204594, XrefRangeEnd = 204597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__4(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC7C RID: 56444 RVA: 0x003575E4 File Offset: 0x003557E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__5(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC7D RID: 56445 RVA: 0x00357628 File Offset: 0x00355828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204597, XrefRangeEnd = 204600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__6(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC7E RID: 56446 RVA: 0x0035766C File Offset: 0x0035586C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__7(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC7F RID: 56447 RVA: 0x003576B0 File Offset: 0x003558B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204600, XrefRangeEnd = 204603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__8(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC80 RID: 56448 RVA: 0x003576F4 File Offset: 0x003558F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__9(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC81 RID: 56449 RVA: 0x00357738 File Offset: 0x00355938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204603, XrefRangeEnd = 204616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__12(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__12_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC82 RID: 56450 RVA: 0x0035777C File Offset: 0x0035597C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204616, XrefRangeEnd = 204628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__13(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__13_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC83 RID: 56451 RVA: 0x003577C0 File Offset: 0x003559C0
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__14()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC84 RID: 56452 RVA: 0x003577FC File Offset: 0x003559FC
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__15()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__15_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC85 RID: 56453 RVA: 0x00357838 File Offset: 0x00355A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204628, XrefRangeEnd = 204636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__19(int a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__19_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DC86 RID: 56454 RVA: 0x00357890 File Offset: 0x00355A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204636, XrefRangeEnd = 204654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__17(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC87 RID: 56455 RVA: 0x003578D0 File Offset: 0x00355AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204654, XrefRangeEnd = 204656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__20()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__20_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC88 RID: 56456 RVA: 0x00357904 File Offset: 0x00355B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204656, XrefRangeEnd = 204665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__21(int currentTime, string des)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(des);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__21_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DC89 RID: 56457 RVA: 0x0035795C File Offset: 0x00355B5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204665, XrefRangeEnd = 204667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC8A RID: 56458 RVA: 0x00075CA1 File Offset: 0x00073EA1
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047A9 RID: 18345
			// (get) Token: 0x0600DC8B RID: 56459 RVA: 0x00357990 File Offset: 0x00355B90
			// (set) Token: 0x0600DC8C RID: 56460 RVA: 0x00075CAA File Offset: 0x00073EAA
			public unsafe CharacterControllerUnit controller
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_controller);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047AA RID: 18346
			// (get) Token: 0x0600DC8D RID: 56461 RVA: 0x003579C0 File Offset: 0x00355BC0
			// (set) Token: 0x0600DC8E RID: 56462 RVA: 0x00075CC9 File Offset: 0x00073EC9
			public unsafe Spell_Shinmyoumaru __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Shinmyoumaru>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047AB RID: 18347
			// (get) Token: 0x0600DC8F RID: 56463 RVA: 0x003579F0 File Offset: 0x00355BF0
			// (set) Token: 0x0600DC90 RID: 56464 RVA: 0x00075CE8 File Offset: 0x00073EE8
			public unsafe bool continueRotate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_continueRotate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_continueRotate)) = value;
				}
			}

			// Token: 0x170047AC RID: 18348
			// (get) Token: 0x0600DC91 RID: 56465 RVA: 0x00357A18 File Offset: 0x00355C18
			// (set) Token: 0x0600DC92 RID: 56466 RVA: 0x00075D03 File Offset: 0x00073F03
			public unsafe Vector3 jumpToPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_jumpToPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_jumpToPosition)) = value;
				}
			}

			// Token: 0x170047AD RID: 18349
			// (get) Token: 0x0600DC93 RID: 56467 RVA: 0x00357A40 File Offset: 0x00355C40
			// (set) Token: 0x0600DC94 RID: 56468 RVA: 0x00075D1E File Offset: 0x00073F1E
			public unsafe CharacterSpriteSetCompact skinSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_skinSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_skinSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047AE RID: 18350
			// (get) Token: 0x0600DC95 RID: 56469 RVA: 0x00357A70 File Offset: 0x00355C70
			// (set) Token: 0x0600DC96 RID: 56470 RVA: 0x00075D3D File Offset: 0x00073F3D
			public unsafe Dictionary<SpriteRenderer, float> alphaDic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_alphaDic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SpriteRenderer, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_alphaDic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047AF RID: 18351
			// (get) Token: 0x0600DC97 RID: 56471 RVA: 0x00357AA0 File Offset: 0x00355CA0
			// (set) Token: 0x0600DC98 RID: 56472 RVA: 0x00075D5C File Offset: 0x00073F5C
			public unsafe Vector3 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x170047B0 RID: 18352
			// (get) Token: 0x0600DC99 RID: 56473 RVA: 0x00357AC8 File Offset: 0x00355CC8
			// (set) Token: 0x0600DC9A RID: 56474 RVA: 0x00075D77 File Offset: 0x00073F77
			public unsafe Transform transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047B1 RID: 18353
			// (get) Token: 0x0600DC9B RID: 56475 RVA: 0x00357AF8 File Offset: 0x00355CF8
			// (set) Token: 0x0600DC9C RID: 56476 RVA: 0x00075D96 File Offset: 0x00073F96
			public unsafe Action __9__20
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr___9__20);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr___9__20), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047B2 RID: 18354
			// (get) Token: 0x0600DC9D RID: 56477 RVA: 0x00357B28 File Offset: 0x00355D28
			// (set) Token: 0x0600DC9E RID: 56478 RVA: 0x00075DB5 File Offset: 0x00073FB5
			public unsafe Func<int, string, string> __9__21
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr___9__21);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.NativeFieldInfoPtr___9__21), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D36 RID: 36150
			private static readonly IntPtr NativeFieldInfoPtr_controller;

			// Token: 0x04008D37 RID: 36151
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D38 RID: 36152
			private static readonly IntPtr NativeFieldInfoPtr_continueRotate;

			// Token: 0x04008D39 RID: 36153
			private static readonly IntPtr NativeFieldInfoPtr_jumpToPosition;

			// Token: 0x04008D3A RID: 36154
			private static readonly IntPtr NativeFieldInfoPtr_skinSprite;

			// Token: 0x04008D3B RID: 36155
			private static readonly IntPtr NativeFieldInfoPtr_alphaDic;

			// Token: 0x04008D3C RID: 36156
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04008D3D RID: 36157
			private static readonly IntPtr NativeFieldInfoPtr_transform;

			// Token: 0x04008D3E RID: 36158
			private static readonly IntPtr NativeFieldInfoPtr___9__20;

			// Token: 0x04008D3F RID: 36159
			private static readonly IntPtr NativeFieldInfoPtr___9__21;

			// Token: 0x04008D40 RID: 36160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D41 RID: 36161
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008D42 RID: 36162
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Vector3_0;

			// Token: 0x04008D43 RID: 36163
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D44 RID: 36164
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D45 RID: 36165
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D46 RID: 36166
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D47 RID: 36167
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D48 RID: 36168
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D49 RID: 36169
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D4A RID: 36170
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D4B RID: 36171
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__12_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D4C RID: 36172
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__13_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D4D RID: 36173
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_Internal_Vector3_0;

			// Token: 0x04008D4E RID: 36174
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__15_Internal_Vector3_0;

			// Token: 0x04008D4F RID: 36175
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__19_Internal_String_Int32_String_0;

			// Token: 0x04008D50 RID: 36176
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_Internal_Void_Int32_0;

			// Token: 0x04008D51 RID: 36177
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__20_Internal_Void_0;

			// Token: 0x04008D52 RID: 36178
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__21_Internal_String_Int32_String_0;

			// Token: 0x04008D53 RID: 36179
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x02001040 RID: 4160
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Shinmyoumaru+<>c__DisplayClass38_0+<<OnNegativeBuffExecute>g__Round|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011CAE RID: 72878 RVA: 0x00412C18 File Offset: 0x00410E18
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique()
				{
					Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Round|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr);
					Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr__rotate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<rotate>5__2");
					Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679760);
					Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679761);
					Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679762);
					Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679763);
					Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679764);
					Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100679765);
				}

				// Token: 0x06011CAF RID: 72879 RVA: 0x00412D0C File Offset: 0x00410F0C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CB0 RID: 72880 RVA: 0x00412D54 File Offset: 0x00410F54
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CB1 RID: 72881 RVA: 0x00412D88 File Offset: 0x00410F88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204570, XrefRangeEnd = 204580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CAF RID: 23727
				// (get) Token: 0x06011CB2 RID: 72882 RVA: 0x00412DC4 File Offset: 0x00410FC4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CB3 RID: 72883 RVA: 0x00412E04 File Offset: 0x00411004
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204580, XrefRangeEnd = 204586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CB0 RID: 23728
				// (get) Token: 0x06011CB4 RID: 72884 RVA: 0x00412E38 File Offset: 0x00411038
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CB5 RID: 72885 RVA: 0x0009A9D5 File Offset: 0x00098BD5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CAB RID: 23723
				// (get) Token: 0x06011CB6 RID: 72886 RVA: 0x00412E78 File Offset: 0x00411078
				// (set) Token: 0x06011CB7 RID: 72887 RVA: 0x0009A9DE File Offset: 0x00098BDE
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CAC RID: 23724
				// (get) Token: 0x06011CB8 RID: 72888 RVA: 0x00412EA0 File Offset: 0x004110A0
				// (set) Token: 0x06011CB9 RID: 72889 RVA: 0x0009A9F9 File Offset: 0x00098BF9
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CAD RID: 23725
				// (get) Token: 0x06011CBA RID: 72890 RVA: 0x00412ED0 File Offset: 0x004110D0
				// (set) Token: 0x06011CBB RID: 72891 RVA: 0x0009AA18 File Offset: 0x00098C18
				public unsafe Spell_Shinmyoumaru.__c__DisplayClass38_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Shinmyoumaru.__c__DisplayClass38_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CAE RID: 23726
				// (get) Token: 0x06011CBC RID: 72892 RVA: 0x00412F00 File Offset: 0x00411100
				// (set) Token: 0x06011CBD RID: 72893 RVA: 0x0009AA37 File Offset: 0x00098C37
				public unsafe int _rotate_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr__rotate_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr__rotate_5__2)) = value;
					}
				}

				// Token: 0x0400B3D8 RID: 46040
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B3D9 RID: 46041
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B3DA RID: 46042
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B3DB RID: 46043
				private static readonly IntPtr NativeFieldInfoPtr__rotate_5__2;

				// Token: 0x0400B3DC RID: 46044
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B3DD RID: 46045
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3DE RID: 46046
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B3DF RID: 46047
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B3E0 RID: 46048
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3E1 RID: 46049
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BCE RID: 3022
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Shinmyoumaru+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DC9F RID: 56479 RVA: 0x00357B58 File Offset: 0x00355D58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr);
				Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr, "<>9");
				Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__38_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr, "<>9__38_10");
				Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__38_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr, "<>9__38_11");
				Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__38_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr, "<>9__38_16");
				Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__39_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr, "<>9__39_3");
				Spell_Shinmyoumaru.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr, 100679767);
				Spell_Shinmyoumaru.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_10_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr, 100679768);
				Spell_Shinmyoumaru.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_11_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr, 100679769);
				Spell_Shinmyoumaru.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_16_Internal_Boolean_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr, 100679770);
				Spell_Shinmyoumaru.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_3_Internal_Boolean_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr, 100679771);
			}

			// Token: 0x0600DCA0 RID: 56480 RVA: 0x00357C4C File Offset: 0x00355E4C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Shinmyoumaru.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCA1 RID: 56481 RVA: 0x00357C88 File Offset: 0x00355E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204667, XrefRangeEnd = 204673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__38_10(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_10_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCA2 RID: 56482 RVA: 0x00357CCC File Offset: 0x00355ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204673, XrefRangeEnd = 204679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__38_11(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_11_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCA3 RID: 56483 RVA: 0x00357D10 File Offset: 0x00355F10
			[CallerCount(0)]
			public unsafe bool _OnNegativeBuffExecute_b__38_16(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_16_Internal_Boolean_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DCA4 RID: 56484 RVA: 0x00357D60 File Offset: 0x00355F60
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__39_3(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_3_Internal_Boolean_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DCA5 RID: 56485 RVA: 0x00075DD4 File Offset: 0x00073FD4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047B3 RID: 18355
			// (get) Token: 0x0600DCA6 RID: 56486 RVA: 0x00357DB0 File Offset: 0x00355FB0
			// (set) Token: 0x0600DCA7 RID: 56487 RVA: 0x00075DDD File Offset: 0x00073FDD
			public unsafe static Spell_Shinmyoumaru.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Shinmyoumaru.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047B4 RID: 18356
			// (get) Token: 0x0600DCA8 RID: 56488 RVA: 0x00357DD8 File Offset: 0x00355FD8
			// (set) Token: 0x0600DCA9 RID: 56489 RVA: 0x00075DEF File Offset: 0x00073FEF
			public unsafe static Action<SpriteRenderer> __9__38_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__38_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__38_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047B5 RID: 18357
			// (get) Token: 0x0600DCAA RID: 56490 RVA: 0x00357E00 File Offset: 0x00356000
			// (set) Token: 0x0600DCAB RID: 56491 RVA: 0x00075E01 File Offset: 0x00074001
			public unsafe static Action<SpriteRenderer> __9__38_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__38_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__38_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047B6 RID: 18358
			// (get) Token: 0x0600DCAC RID: 56492 RVA: 0x00357E28 File Offset: 0x00356028
			// (set) Token: 0x0600DCAD RID: 56493 RVA: 0x00075E13 File Offset: 0x00074013
			public unsafe static Func<PartnerBase, bool> __9__38_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__38_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__38_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047B7 RID: 18359
			// (get) Token: 0x0600DCAE RID: 56494 RVA: 0x00357E50 File Offset: 0x00356050
			// (set) Token: 0x0600DCAF RID: 56495 RVA: 0x00075E25 File Offset: 0x00074025
			public unsafe static Func<PartnerBase, bool> __9__39_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__39_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Shinmyoumaru.__c.NativeFieldInfoPtr___9__39_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D54 RID: 36180
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D55 RID: 36181
			private static readonly IntPtr NativeFieldInfoPtr___9__38_10;

			// Token: 0x04008D56 RID: 36182
			private static readonly IntPtr NativeFieldInfoPtr___9__38_11;

			// Token: 0x04008D57 RID: 36183
			private static readonly IntPtr NativeFieldInfoPtr___9__38_16;

			// Token: 0x04008D58 RID: 36184
			private static readonly IntPtr NativeFieldInfoPtr___9__39_3;

			// Token: 0x04008D59 RID: 36185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D5A RID: 36186
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_10_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D5B RID: 36187
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_11_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008D5C RID: 36188
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__38_16_Internal_Boolean_PartnerBase_0;

			// Token: 0x04008D5D RID: 36189
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__39_3_Internal_Boolean_PartnerBase_0;
		}

		// Token: 0x02000BCF RID: 3023
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Shinmyoumaru+<OnNegativeBuffExecute>d__38")]
		public sealed class _OnNegativeBuffExecute_d__38 : Il2CppSystem.Object
		{
			// Token: 0x0600DCB0 RID: 56496 RVA: 0x00357E78 File Offset: 0x00356078
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__38()
			{
				Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "<OnNegativeBuffExecute>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr);
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<>1__state");
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<>2__current");
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<>4__this");
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<>8__1");
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<player>5__2");
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__localScale_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<localScale>5__3");
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__oldScale_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<oldScale>5__4");
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__daiMysty_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, "<daiMysty>5__5");
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679772);
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679773);
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679774);
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679775);
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679776);
				Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr, 100679777);
			}

			// Token: 0x0600DCB1 RID: 56497 RVA: 0x00357FBC File Offset: 0x003561BC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__38(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCB2 RID: 56498 RVA: 0x00358004 File Offset: 0x00356204
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCB3 RID: 56499 RVA: 0x00358038 File Offset: 0x00356238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204679, XrefRangeEnd = 204981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047C0 RID: 18368
			// (get) Token: 0x0600DCB4 RID: 56500 RVA: 0x00358074 File Offset: 0x00356274
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCB5 RID: 56501 RVA: 0x003580B4 File Offset: 0x003562B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204981, XrefRangeEnd = 204987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047C1 RID: 18369
			// (get) Token: 0x0600DCB6 RID: 56502 RVA: 0x003580E8 File Offset: 0x003562E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCB7 RID: 56503 RVA: 0x00075E37 File Offset: 0x00074037
			public _OnNegativeBuffExecute_d__38(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047B8 RID: 18360
			// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x00358128 File Offset: 0x00356328
			// (set) Token: 0x0600DCB9 RID: 56505 RVA: 0x00075E40 File Offset: 0x00074040
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047B9 RID: 18361
			// (get) Token: 0x0600DCBA RID: 56506 RVA: 0x00358150 File Offset: 0x00356350
			// (set) Token: 0x0600DCBB RID: 56507 RVA: 0x00075E5B File Offset: 0x0007405B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047BA RID: 18362
			// (get) Token: 0x0600DCBC RID: 56508 RVA: 0x00358180 File Offset: 0x00356380
			// (set) Token: 0x0600DCBD RID: 56509 RVA: 0x00075E7A File Offset: 0x0007407A
			public unsafe Spell_Shinmyoumaru __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Shinmyoumaru>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047BB RID: 18363
			// (get) Token: 0x0600DCBE RID: 56510 RVA: 0x003581B0 File Offset: 0x003563B0
			// (set) Token: 0x0600DCBF RID: 56511 RVA: 0x00075E99 File Offset: 0x00074099
			public unsafe Spell_Shinmyoumaru.__c__DisplayClass38_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Shinmyoumaru.__c__DisplayClass38_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047BC RID: 18364
			// (get) Token: 0x0600DCC0 RID: 56512 RVA: 0x003581E0 File Offset: 0x003563E0
			// (set) Token: 0x0600DCC1 RID: 56513 RVA: 0x00075EB8 File Offset: 0x000740B8
			public unsafe WorkScenePlayerInputGenerator _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047BD RID: 18365
			// (get) Token: 0x0600DCC2 RID: 56514 RVA: 0x00358210 File Offset: 0x00356410
			// (set) Token: 0x0600DCC3 RID: 56515 RVA: 0x00075ED7 File Offset: 0x000740D7
			public unsafe Vector3 _localScale_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__localScale_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__localScale_5__3)) = value;
				}
			}

			// Token: 0x170047BE RID: 18366
			// (get) Token: 0x0600DCC4 RID: 56516 RVA: 0x00358238 File Offset: 0x00356438
			// (set) Token: 0x0600DCC5 RID: 56517 RVA: 0x00075EF2 File Offset: 0x000740F2
			public unsafe Vector3 _oldScale_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__oldScale_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__oldScale_5__4)) = value;
				}
			}

			// Token: 0x170047BF RID: 18367
			// (get) Token: 0x0600DCC6 RID: 56518 RVA: 0x00358260 File Offset: 0x00356460
			// (set) Token: 0x0600DCC7 RID: 56519 RVA: 0x00075F0D File Offset: 0x0007410D
			public unsafe GameObject _daiMysty_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__daiMysty_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnNegativeBuffExecute_d__38.NativeFieldInfoPtr__daiMysty_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D5E RID: 36190
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D5F RID: 36191
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D60 RID: 36192
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D61 RID: 36193
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008D62 RID: 36194
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04008D63 RID: 36195
			private static readonly IntPtr NativeFieldInfoPtr__localScale_5__3;

			// Token: 0x04008D64 RID: 36196
			private static readonly IntPtr NativeFieldInfoPtr__oldScale_5__4;

			// Token: 0x04008D65 RID: 36197
			private static readonly IntPtr NativeFieldInfoPtr__daiMysty_5__5;

			// Token: 0x04008D66 RID: 36198
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D67 RID: 36199
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D68 RID: 36200
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D69 RID: 36201
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D6A RID: 36202
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D6B RID: 36203
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BD0 RID: 3024
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Shinmyoumaru+<OnPositiveBuffExecute>d__39")]
		public sealed class _OnPositiveBuffExecute_d__39 : Il2CppSystem.Object
		{
			// Token: 0x0600DCC8 RID: 56520 RVA: 0x00358290 File Offset: 0x00356490
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__39()
			{
				Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Shinmyoumaru>.NativeClassPtr, "<OnPositiveBuffExecute>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr);
				Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr, "<>1__state");
				Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr, "<>2__current");
				Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr, "<>4__this");
				Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr, 100679778);
				Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr, 100679779);
				Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr, 100679780);
				Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr, 100679781);
				Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr, 100679782);
				Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr, 100679783);
			}

			// Token: 0x0600DCC9 RID: 56521 RVA: 0x00358370 File Offset: 0x00356570
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__39(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCCA RID: 56522 RVA: 0x003583B8 File Offset: 0x003565B8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCCB RID: 56523 RVA: 0x003583EC File Offset: 0x003565EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204987, XrefRangeEnd = 205048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047C5 RID: 18373
			// (get) Token: 0x0600DCCC RID: 56524 RVA: 0x00358428 File Offset: 0x00356628
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCCD RID: 56525 RVA: 0x00358468 File Offset: 0x00356668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205048, XrefRangeEnd = 205054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047C6 RID: 18374
			// (get) Token: 0x0600DCCE RID: 56526 RVA: 0x0035849C File Offset: 0x0035669C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCCF RID: 56527 RVA: 0x00075F2C File Offset: 0x0007412C
			public _OnPositiveBuffExecute_d__39(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047C2 RID: 18370
			// (get) Token: 0x0600DCD0 RID: 56528 RVA: 0x003584DC File Offset: 0x003566DC
			// (set) Token: 0x0600DCD1 RID: 56529 RVA: 0x00075F35 File Offset: 0x00074135
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047C3 RID: 18371
			// (get) Token: 0x0600DCD2 RID: 56530 RVA: 0x00358504 File Offset: 0x00356704
			// (set) Token: 0x0600DCD3 RID: 56531 RVA: 0x00075F50 File Offset: 0x00074150
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047C4 RID: 18372
			// (get) Token: 0x0600DCD4 RID: 56532 RVA: 0x00358534 File Offset: 0x00356734
			// (set) Token: 0x0600DCD5 RID: 56533 RVA: 0x00075F6F File Offset: 0x0007416F
			public unsafe Spell_Shinmyoumaru __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Shinmyoumaru>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Shinmyoumaru._OnPositiveBuffExecute_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D6C RID: 36204
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D6D RID: 36205
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D6E RID: 36206
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D6F RID: 36207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D70 RID: 36208
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D71 RID: 36209
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D72 RID: 36210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D73 RID: 36211
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D74 RID: 36212
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
