using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200026B RID: 619
	public class Spell_Koishi : SpellBase
	{
		// Token: 0x06004D1B RID: 19739 RVA: 0x001A89A4 File Offset: 0x001A6BA4
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Koishi()
		{
			Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Koishi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr);
			Spell_Koishi.NativeFieldInfoPtr_hiddenEyePic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "hiddenEyePic");
			Spell_Koishi.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "negativeDuration");
			Spell_Koishi.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "positiveDuration");
			Spell_Koishi.NativeFieldInfoPtr_rewardPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "rewardPower");
			Spell_Koishi.NativeFieldInfoPtr_negativePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "negativePower");
			Spell_Koishi.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "rewardSFX");
			Spell_Koishi.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "punishmentSFX");
			Spell_Koishi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, 100678785);
			Spell_Koishi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, 100678786);
			Spell_Koishi.NativeMethodInfoPtr_KoishiSpecialOrder_Private_OrderBase_GuestGroupController_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, 100678787);
			Spell_Koishi.NativeMethodInfoPtr_OverrideFinalEval_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, 100678788);
			Spell_Koishi.NativeMethodInfoPtr_WhenGuestSpawn_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, 100678789);
			Spell_Koishi.NativeMethodInfoPtr_OnBuffEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, 100678790);
			Spell_Koishi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, 100678791);
			Spell_Koishi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, 100678792);
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x001A8B00 File Offset: 0x001A6D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198053, XrefRangeEnd = 198055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Koishi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x001A8B44 File Offset: 0x001A6D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198055, XrefRangeEnd = 198061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Koishi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x001A8BA0 File Offset: 0x001A6DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198061, XrefRangeEnd = 198095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestsManager.OrderBase KoishiSpecialOrder(GuestGroupController guestGroup, out string orderGenerationMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.NativeMethodInfoPtr_KoishiSpecialOrder_Private_OrderBase_GuestGroupController_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			orderGenerationMessage = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr4) : null;
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x001A8C0C File Offset: 0x001A6E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198095, XrefRangeEnd = 198155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestGroupController.EvaluationResult OverrideFinalEval(GuestGroupController.EvaluationResult lastResult, GuestGroupController thisGuest, bool oldComboProtect, out string message, out bool comboProtect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lastResult;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.NativeMethodInfoPtr_OverrideFinalEval_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x001A8CA0 File Offset: 0x001A6EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198155, XrefRangeEnd = 198180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WhenGuestSpawn(GuestGroupController group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.NativeMethodInfoPtr_WhenGuestSpawn_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x001A8CE4 File Offset: 0x001A6EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198180, XrefRangeEnd = 198236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBuffEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.NativeMethodInfoPtr_OnBuffEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x001A8D18 File Offset: 0x001A6F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198236, XrefRangeEnd = 198242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Koishi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x001A8D74 File Offset: 0x001A6F74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Koishi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x000280EF File Offset: 0x000262EF
		public Spell_Koishi(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06004D25 RID: 19749 RVA: 0x001A8DB0 File Offset: 0x001A6FB0
		// (set) Token: 0x06004D26 RID: 19750 RVA: 0x000280F8 File Offset: 0x000262F8
		public unsafe Sprite hiddenEyePic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_hiddenEyePic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_hiddenEyePic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06004D27 RID: 19751 RVA: 0x001A8DE0 File Offset: 0x001A6FE0
		// (set) Token: 0x06004D28 RID: 19752 RVA: 0x00028117 File Offset: 0x00026317
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06004D29 RID: 19753 RVA: 0x001A8E08 File Offset: 0x001A7008
		// (set) Token: 0x06004D2A RID: 19754 RVA: 0x00028132 File Offset: 0x00026332
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06004D2B RID: 19755 RVA: 0x001A8E30 File Offset: 0x001A7030
		// (set) Token: 0x06004D2C RID: 19756 RVA: 0x0002814D File Offset: 0x0002634D
		public unsafe GameObject rewardPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_rewardPower);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_rewardPower), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06004D2D RID: 19757 RVA: 0x001A8E60 File Offset: 0x001A7060
		// (set) Token: 0x06004D2E RID: 19758 RVA: 0x0002816C File Offset: 0x0002636C
		public unsafe GameObject negativePower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_negativePower);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_negativePower), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06004D2F RID: 19759 RVA: 0x001A8E90 File Offset: 0x001A7090
		// (set) Token: 0x06004D30 RID: 19760 RVA: 0x0002818B File Offset: 0x0002638B
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06004D31 RID: 19761 RVA: 0x001A8EC0 File Offset: 0x001A70C0
		// (set) Token: 0x06004D32 RID: 19762 RVA: 0x000281AA File Offset: 0x000263AA
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034A8 RID: 13480
		private static readonly IntPtr NativeFieldInfoPtr_hiddenEyePic;

		// Token: 0x040034A9 RID: 13481
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x040034AA RID: 13482
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x040034AB RID: 13483
		private static readonly IntPtr NativeFieldInfoPtr_rewardPower;

		// Token: 0x040034AC RID: 13484
		private static readonly IntPtr NativeFieldInfoPtr_negativePower;

		// Token: 0x040034AD RID: 13485
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x040034AE RID: 13486
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x040034AF RID: 13487
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040034B0 RID: 13488
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040034B1 RID: 13489
		private static readonly IntPtr NativeMethodInfoPtr_KoishiSpecialOrder_Private_OrderBase_GuestGroupController_byref_String_0;

		// Token: 0x040034B2 RID: 13490
		private static readonly IntPtr NativeMethodInfoPtr_OverrideFinalEval_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0;

		// Token: 0x040034B3 RID: 13491
		private static readonly IntPtr NativeMethodInfoPtr_WhenGuestSpawn_Private_Void_GuestGroupController_0;

		// Token: 0x040034B4 RID: 13492
		private static readonly IntPtr NativeMethodInfoPtr_OnBuffEnd_Private_Void_0;

		// Token: 0x040034B5 RID: 13493
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040034B6 RID: 13494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B3C RID: 2876
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Koishi+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4CA RID: 54474 RVA: 0x00340300 File Offset: 0x0033E500
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass8_0>.NativeClassPtr);
				Spell_Koishi.__c__DisplayClass8_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass8_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Koishi.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				Spell_Koishi.__c__DisplayClass8_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass8_0>.NativeClassPtr, "<>9__4");
				Spell_Koishi.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass8_0>.NativeClassPtr, 100678793);
				Spell_Koishi.__c__DisplayClass8_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass8_0>.NativeClassPtr, 100678794);
				Spell_Koishi.__c__DisplayClass8_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_ParticleSystemRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass8_0>.NativeClassPtr, 100678795);
				Spell_Koishi.__c__DisplayClass8_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass8_0>.NativeClassPtr, 100678796);
			}

			// Token: 0x0600D4CB RID: 54475 RVA: 0x003403B8 File Offset: 0x0033E5B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4CC RID: 54476 RVA: 0x003403F4 File Offset: 0x0033E5F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197870, XrefRangeEnd = 197891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c__DisplayClass8_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4CD RID: 54477 RVA: 0x00340438 File Offset: 0x0033E638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197891, XrefRangeEnd = 197898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__4(ParticleSystemRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c__DisplayClass8_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_ParticleSystemRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4CE RID: 54478 RVA: 0x0034047C File Offset: 0x0033E67C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197898, XrefRangeEnd = 197909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c__DisplayClass8_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4CF RID: 54479 RVA: 0x00071EC5 File Offset: 0x000700C5
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700453C RID: 17724
			// (get) Token: 0x0600D4D0 RID: 54480 RVA: 0x003404C0 File Offset: 0x0033E6C0
			// (set) Token: 0x0600D4D1 RID: 54481 RVA: 0x00071ECE File Offset: 0x000700CE
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass8_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass8_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700453D RID: 17725
			// (get) Token: 0x0600D4D2 RID: 54482 RVA: 0x003404F0 File Offset: 0x0033E6F0
			// (set) Token: 0x0600D4D3 RID: 54483 RVA: 0x00071EED File Offset: 0x000700ED
			public unsafe Spell_Koishi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Koishi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700453E RID: 17726
			// (get) Token: 0x0600D4D4 RID: 54484 RVA: 0x00340520 File Offset: 0x0033E720
			// (set) Token: 0x0600D4D5 RID: 54485 RVA: 0x00071F0C File Offset: 0x0007010C
			public unsafe Action<ParticleSystemRenderer> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass8_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSystemRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass8_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008891 RID: 34961
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008892 RID: 34962
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008893 RID: 34963
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04008894 RID: 34964
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008895 RID: 34965
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008896 RID: 34966
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_ParticleSystemRenderer_0;

			// Token: 0x04008897 RID: 34967
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000B3D RID: 2877
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Koishi+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D4D6 RID: 54486 RVA: 0x00340550 File Offset: 0x0033E750
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr);
				Spell_Koishi.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, "<>9");
				Spell_Koishi.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, "<>9__8_1");
				Spell_Koishi.__c.NativeFieldInfoPtr___9__8_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, "<>9__8_5");
				Spell_Koishi.__c.NativeFieldInfoPtr___9__8_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, "<>9__8_3");
				Spell_Koishi.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, "<>9__10_1");
				Spell_Koishi.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, "<>9__11_0");
				Spell_Koishi.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, "<>9__12_0");
				Spell_Koishi.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, 100678798);
				Spell_Koishi.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_1_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, 100678799);
				Spell_Koishi.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_3_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, 100678800);
				Spell_Koishi.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_5_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, 100678801);
				Spell_Koishi.__c.NativeMethodInfoPtr__OverrideFinalEval_b__10_1_Internal_IEnumerable_1_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, 100678802);
				Spell_Koishi.__c.NativeMethodInfoPtr__WhenGuestSpawn_b__11_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, 100678803);
				Spell_Koishi.__c.NativeMethodInfoPtr__OnBuffEnd_b__12_0_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr, 100678804);
			}

			// Token: 0x0600D4D7 RID: 54487 RVA: 0x00340694 File Offset: 0x0033E894
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Koishi.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4D8 RID: 54488 RVA: 0x003406D0 File Offset: 0x0033E8D0
			[CallerCount(0)]
			public unsafe bool _OnNegativeBuffExecute_b__8_1(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_1_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4D9 RID: 54489 RVA: 0x00340720 File Offset: 0x0033E920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197909, XrefRangeEnd = 197926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__8_3(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_3_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4DA RID: 54490 RVA: 0x00340764 File Offset: 0x0033E964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197926, XrefRangeEnd = 197928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__8_5(string y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_5_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D4DB RID: 54491 RVA: 0x003407AC File Offset: 0x0033E9AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197928, XrefRangeEnd = 197930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _OverrideFinalEval_b__10_1(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c.NativeMethodInfoPtr__OverrideFinalEval_b__10_1_Internal_IEnumerable_1_Int32_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600D4DC RID: 54492 RVA: 0x003407FC File Offset: 0x0033E9FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197930, XrefRangeEnd = 197932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _WhenGuestSpawn_b__11_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c.NativeMethodInfoPtr__WhenGuestSpawn_b__11_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D4DD RID: 54493 RVA: 0x00340844 File Offset: 0x0033EA44
			[CallerCount(0)]
			public unsafe bool _OnBuffEnd_b__12_0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c.NativeMethodInfoPtr__OnBuffEnd_b__12_0_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4DE RID: 54494 RVA: 0x00071F2B File Offset: 0x0007012B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700453F RID: 17727
			// (get) Token: 0x0600D4DF RID: 54495 RVA: 0x00340894 File Offset: 0x0033EA94
			// (set) Token: 0x0600D4E0 RID: 54496 RVA: 0x00071F34 File Offset: 0x00070134
			public unsafe static Spell_Koishi.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Koishi.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Koishi.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Koishi.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004540 RID: 17728
			// (get) Token: 0x0600D4E1 RID: 54497 RVA: 0x003408BC File Offset: 0x0033EABC
			// (set) Token: 0x0600D4E2 RID: 54498 RVA: 0x00071F46 File Offset: 0x00070146
			public unsafe static Func<GuestGroupController, bool> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004541 RID: 17729
			// (get) Token: 0x0600D4E3 RID: 54499 RVA: 0x003408E4 File Offset: 0x0033EAE4
			// (set) Token: 0x0600D4E4 RID: 54500 RVA: 0x00071F58 File Offset: 0x00070158
			public unsafe static Func<string, string> __9__8_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__8_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__8_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004542 RID: 17730
			// (get) Token: 0x0600D4E5 RID: 54501 RVA: 0x0034090C File Offset: 0x0033EB0C
			// (set) Token: 0x0600D4E6 RID: 54502 RVA: 0x00071F6A File Offset: 0x0007016A
			public unsafe static Action<GuestGroupController> __9__8_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__8_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__8_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004543 RID: 17731
			// (get) Token: 0x0600D4E7 RID: 54503 RVA: 0x00340934 File Offset: 0x0033EB34
			// (set) Token: 0x0600D4E8 RID: 54504 RVA: 0x00071F7C File Offset: 0x0007017C
			public unsafe static Func<NormalGuest, IEnumerable<int>> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004544 RID: 17732
			// (get) Token: 0x0600D4E9 RID: 54505 RVA: 0x0034095C File Offset: 0x0033EB5C
			// (set) Token: 0x0600D4EA RID: 54506 RVA: 0x00071F8E File Offset: 0x0007018E
			public unsafe static Func<string, string> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004545 RID: 17733
			// (get) Token: 0x0600D4EB RID: 54507 RVA: 0x00340984 File Offset: 0x0033EB84
			// (set) Token: 0x0600D4EC RID: 54508 RVA: 0x00071FA0 File Offset: 0x000701A0
			public unsafe static Func<GuestGroupController, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Koishi.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008898 RID: 34968
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008899 RID: 34969
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x0400889A RID: 34970
			private static readonly IntPtr NativeFieldInfoPtr___9__8_5;

			// Token: 0x0400889B RID: 34971
			private static readonly IntPtr NativeFieldInfoPtr___9__8_3;

			// Token: 0x0400889C RID: 34972
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x0400889D RID: 34973
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400889E RID: 34974
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x0400889F RID: 34975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088A0 RID: 34976
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_1_Internal_Boolean_GuestGroupController_0;

			// Token: 0x040088A1 RID: 34977
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_3_Internal_Void_GuestGroupController_0;

			// Token: 0x040088A2 RID: 34978
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_5_Internal_String_String_0;

			// Token: 0x040088A3 RID: 34979
			private static readonly IntPtr NativeMethodInfoPtr__OverrideFinalEval_b__10_1_Internal_IEnumerable_1_Int32_NormalGuest_0;

			// Token: 0x040088A4 RID: 34980
			private static readonly IntPtr NativeMethodInfoPtr__WhenGuestSpawn_b__11_0_Internal_String_String_0;

			// Token: 0x040088A5 RID: 34981
			private static readonly IntPtr NativeMethodInfoPtr__OnBuffEnd_b__12_0_Internal_Boolean_GuestGroupController_0;
		}

		// Token: 0x02000B3E RID: 2878
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Koishi+<OnNegativeBuffExecute>d__8")]
		public sealed class _OnNegativeBuffExecute_d__8 : Il2CppSystem.Object
		{
			// Token: 0x0600D4ED RID: 54509 RVA: 0x003409AC File Offset: 0x0033EBAC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__8()
			{
				Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "<OnNegativeBuffExecute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr);
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, "<>1__state");
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, "<>2__current");
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, "spellExecutionContext");
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, "<>4__this");
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, "<>8__1");
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100678805);
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100678806);
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100678807);
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100678808);
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100678809);
				Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100678810);
			}

			// Token: 0x0600D4EE RID: 54510 RVA: 0x00340AB4 File Offset: 0x0033ECB4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__8(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Koishi._OnNegativeBuffExecute_d__8>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4EF RID: 54511 RVA: 0x00340AFC File Offset: 0x0033ECFC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4F0 RID: 54512 RVA: 0x00340B30 File Offset: 0x0033ED30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197932, XrefRangeEnd = 197997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700454B RID: 17739
			// (get) Token: 0x0600D4F1 RID: 54513 RVA: 0x00340B6C File Offset: 0x0033ED6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4F2 RID: 54514 RVA: 0x00340BAC File Offset: 0x0033EDAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197997, XrefRangeEnd = 198003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700454C RID: 17740
			// (get) Token: 0x0600D4F3 RID: 54515 RVA: 0x00340BE0 File Offset: 0x0033EDE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4F4 RID: 54516 RVA: 0x00071FB2 File Offset: 0x000701B2
			public _OnNegativeBuffExecute_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004546 RID: 17734
			// (get) Token: 0x0600D4F5 RID: 54517 RVA: 0x00340C20 File Offset: 0x0033EE20
			// (set) Token: 0x0600D4F6 RID: 54518 RVA: 0x00071FBB File Offset: 0x000701BB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004547 RID: 17735
			// (get) Token: 0x0600D4F7 RID: 54519 RVA: 0x00340C48 File Offset: 0x0033EE48
			// (set) Token: 0x0600D4F8 RID: 54520 RVA: 0x00071FD6 File Offset: 0x000701D6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004548 RID: 17736
			// (get) Token: 0x0600D4F9 RID: 54521 RVA: 0x00340C78 File Offset: 0x0033EE78
			// (set) Token: 0x0600D4FA RID: 54522 RVA: 0x00071FF5 File Offset: 0x000701F5
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004549 RID: 17737
			// (get) Token: 0x0600D4FB RID: 54523 RVA: 0x00340CA8 File Offset: 0x0033EEA8
			// (set) Token: 0x0600D4FC RID: 54524 RVA: 0x00072014 File Offset: 0x00070214
			public unsafe Spell_Koishi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Koishi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700454A RID: 17738
			// (get) Token: 0x0600D4FD RID: 54525 RVA: 0x00340CD8 File Offset: 0x0033EED8
			// (set) Token: 0x0600D4FE RID: 54526 RVA: 0x00072033 File Offset: 0x00070233
			public unsafe Spell_Koishi.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Koishi.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088A6 RID: 34982
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088A7 RID: 34983
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088A8 RID: 34984
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040088A9 RID: 34985
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088AA RID: 34986
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040088AB RID: 34987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088AC RID: 34988
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088AD RID: 34989
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088AE RID: 34990
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088AF RID: 34991
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088B0 RID: 34992
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B3F RID: 2879
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Koishi+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4FF RID: 54527 RVA: 0x00340D08 File Offset: 0x0033EF08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass10_0>.NativeClassPtr);
				Spell_Koishi.__c__DisplayClass10_0.NativeFieldInfoPtr_thisGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass10_0>.NativeClassPtr, "thisGuest");
				Spell_Koishi.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass10_0>.NativeClassPtr, 100678811);
				Spell_Koishi.__c__DisplayClass10_0.NativeMethodInfoPtr__OverrideFinalEval_b__0_Internal_IEnumerable_1_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass10_0>.NativeClassPtr, 100678812);
			}

			// Token: 0x0600D500 RID: 54528 RVA: 0x00340D70 File Offset: 0x0033EF70
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D501 RID: 54529 RVA: 0x00340DAC File Offset: 0x0033EFAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 198004, RefRangeEnd = 198005, XrefRangeStart = 198003, XrefRangeEnd = 198004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _OverrideFinalEval_b__0(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c__DisplayClass10_0.NativeMethodInfoPtr__OverrideFinalEval_b__0_Internal_IEnumerable_1_Int32_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600D502 RID: 54530 RVA: 0x00072052 File Offset: 0x00070252
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700454D RID: 17741
			// (get) Token: 0x0600D503 RID: 54531 RVA: 0x00340DFC File Offset: 0x0033EFFC
			// (set) Token: 0x0600D504 RID: 54532 RVA: 0x0007205B File Offset: 0x0007025B
			public unsafe GuestGroupController thisGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass10_0.NativeFieldInfoPtr_thisGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass10_0.NativeFieldInfoPtr_thisGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088B1 RID: 34993
			private static readonly IntPtr NativeFieldInfoPtr_thisGuest;

			// Token: 0x040088B2 RID: 34994
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088B3 RID: 34995
			private static readonly IntPtr NativeMethodInfoPtr__OverrideFinalEval_b__0_Internal_IEnumerable_1_Int32_NormalGuest_0;
		}

		// Token: 0x02000B40 RID: 2880
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Koishi+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D505 RID: 54533 RVA: 0x00340E2C File Offset: 0x0033F02C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass13_0>.NativeClassPtr);
				Spell_Koishi.__c__DisplayClass13_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass13_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Koishi.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				Spell_Koishi.__c__DisplayClass13_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass13_0>.NativeClassPtr, "<>9__2");
				Spell_Koishi.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass13_0>.NativeClassPtr, 100678813);
				Spell_Koishi.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass13_0>.NativeClassPtr, 100678814);
				Spell_Koishi.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_ParticleSystemRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass13_0>.NativeClassPtr, 100678815);
				Spell_Koishi.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass13_0>.NativeClassPtr, 100678816);
			}

			// Token: 0x0600D506 RID: 54534 RVA: 0x00340EE4 File Offset: 0x0033F0E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Koishi.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D507 RID: 54535 RVA: 0x00340F20 File Offset: 0x0033F120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198005, XrefRangeEnd = 198026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D508 RID: 54536 RVA: 0x00340F64 File Offset: 0x0033F164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198026, XrefRangeEnd = 198033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(ParticleSystemRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_ParticleSystemRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D509 RID: 54537 RVA: 0x00340FA8 File Offset: 0x0033F1A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198033, XrefRangeEnd = 198035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D50A RID: 54538 RVA: 0x0007207A File Offset: 0x0007027A
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700454E RID: 17742
			// (get) Token: 0x0600D50B RID: 54539 RVA: 0x00340FE8 File Offset: 0x0033F1E8
			// (set) Token: 0x0600D50C RID: 54540 RVA: 0x00072083 File Offset: 0x00070283
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass13_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass13_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700454F RID: 17743
			// (get) Token: 0x0600D50D RID: 54541 RVA: 0x00341018 File Offset: 0x0033F218
			// (set) Token: 0x0600D50E RID: 54542 RVA: 0x000720A2 File Offset: 0x000702A2
			public unsafe Spell_Koishi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Koishi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004550 RID: 17744
			// (get) Token: 0x0600D50F RID: 54543 RVA: 0x00341048 File Offset: 0x0033F248
			// (set) Token: 0x0600D510 RID: 54544 RVA: 0x000720C1 File Offset: 0x000702C1
			public unsafe Action<ParticleSystemRenderer> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass13_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSystemRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi.__c__DisplayClass13_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088B4 RID: 34996
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040088B5 RID: 34997
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088B6 RID: 34998
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040088B7 RID: 34999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088B8 RID: 35000
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x040088B9 RID: 35001
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_ParticleSystemRenderer_0;

			// Token: 0x040088BA RID: 35002
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0;
		}

		// Token: 0x02000B41 RID: 2881
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Koishi+<OnPositiveBuffExecute>d__13")]
		public sealed class _OnPositiveBuffExecute_d__13 : Il2CppSystem.Object
		{
			// Token: 0x0600D511 RID: 54545 RVA: 0x00341078 File Offset: 0x0033F278
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__13()
			{
				Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Koishi>.NativeClassPtr, "<OnPositiveBuffExecute>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr);
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, "<>1__state");
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, "<>2__current");
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, "spellExecutionContext");
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, "<>4__this");
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, "<>8__1");
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678817);
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678818);
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678819);
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678820);
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678821);
				Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678822);
			}

			// Token: 0x0600D512 RID: 54546 RVA: 0x00341180 File Offset: 0x0033F380
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Koishi._OnPositiveBuffExecute_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D513 RID: 54547 RVA: 0x003411C8 File Offset: 0x0033F3C8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D514 RID: 54548 RVA: 0x003411FC File Offset: 0x0033F3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198035, XrefRangeEnd = 198047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004556 RID: 17750
			// (get) Token: 0x0600D515 RID: 54549 RVA: 0x00341238 File Offset: 0x0033F438
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D516 RID: 54550 RVA: 0x00341278 File Offset: 0x0033F478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198047, XrefRangeEnd = 198053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004557 RID: 17751
			// (get) Token: 0x0600D517 RID: 54551 RVA: 0x003412AC File Offset: 0x0033F4AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D518 RID: 54552 RVA: 0x000720E0 File Offset: 0x000702E0
			public _OnPositiveBuffExecute_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004551 RID: 17745
			// (get) Token: 0x0600D519 RID: 54553 RVA: 0x003412EC File Offset: 0x0033F4EC
			// (set) Token: 0x0600D51A RID: 54554 RVA: 0x000720E9 File Offset: 0x000702E9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004552 RID: 17746
			// (get) Token: 0x0600D51B RID: 54555 RVA: 0x00341314 File Offset: 0x0033F514
			// (set) Token: 0x0600D51C RID: 54556 RVA: 0x00072104 File Offset: 0x00070304
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004553 RID: 17747
			// (get) Token: 0x0600D51D RID: 54557 RVA: 0x00341344 File Offset: 0x0033F544
			// (set) Token: 0x0600D51E RID: 54558 RVA: 0x00072123 File Offset: 0x00070323
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004554 RID: 17748
			// (get) Token: 0x0600D51F RID: 54559 RVA: 0x00341374 File Offset: 0x0033F574
			// (set) Token: 0x0600D520 RID: 54560 RVA: 0x00072142 File Offset: 0x00070342
			public unsafe Spell_Koishi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Koishi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004555 RID: 17749
			// (get) Token: 0x0600D521 RID: 54561 RVA: 0x003413A4 File Offset: 0x0033F5A4
			// (set) Token: 0x0600D522 RID: 54562 RVA: 0x00072161 File Offset: 0x00070361
			public unsafe Spell_Koishi.__c__DisplayClass13_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Koishi.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Koishi._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088BB RID: 35003
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088BC RID: 35004
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088BD RID: 35005
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040088BE RID: 35006
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088BF RID: 35007
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040088C0 RID: 35008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088C1 RID: 35009
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088C2 RID: 35010
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088C3 RID: 35011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088C4 RID: 35012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088C5 RID: 35013
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
