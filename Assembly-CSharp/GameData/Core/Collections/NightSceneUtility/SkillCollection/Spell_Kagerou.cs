using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000265 RID: 613
	public class Spell_Kagerou : SpellBase
	{
		// Token: 0x06004BDF RID: 19423 RVA: 0x001A59A0 File Offset: 0x001A3BA0
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Kagerou()
		{
			Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Kagerou");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr);
			Spell_Kagerou.NativeFieldInfoPtr_MEATED_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "MEATED_TAG");
			Spell_Kagerou.NativeFieldInfoPtr_MOUNTGAINDELICOUS_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "MOUNTGAINDELICOUS_TAG");
			Spell_Kagerou.NativeFieldInfoPtr_FULLFILLED_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "FULLFILLED_TAG");
			Spell_Kagerou.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "positiveDuration");
			Spell_Kagerou.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "negativeDuration");
			Spell_Kagerou.NativeFieldInfoPtr_meatVFXDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "meatVFXDuration");
			Spell_Kagerou.NativeFieldInfoPtr_beastarVFXDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "beastarVFXDuration");
			Spell_Kagerou.NativeFieldInfoPtr_rewardWolfDanceVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "rewardWolfDanceVFX");
			Spell_Kagerou.NativeFieldInfoPtr_rewardMeatVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "rewardMeatVFX");
			Spell_Kagerou.NativeFieldInfoPtr_rewardBeastarVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "rewardBeastarVFX");
			Spell_Kagerou.NativeFieldInfoPtr_rewardBeastarVFXOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "rewardBeastarVFXOffset");
			Spell_Kagerou.NativeFieldInfoPtr_punishmentVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "punishmentVFX");
			Spell_Kagerou.NativeFieldInfoPtr_punishmentDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "punishmentDuration");
			Spell_Kagerou.NativeFieldInfoPtr_cardArriveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "cardArriveDuration");
			Spell_Kagerou.NativeFieldInfoPtr_punishmentAnimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "punishmentAnimDuration");
			Spell_Kagerou.NativeFieldInfoPtr_shakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "shakeDuration");
			Spell_Kagerou.NativeFieldInfoPtr_shakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "shakeFadeDuration");
			Spell_Kagerou.NativeFieldInfoPtr_wolfDanceSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "wolfDanceSfx");
			Spell_Kagerou.NativeFieldInfoPtr_meatLoveSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "meatLoveSfx");
			Spell_Kagerou.NativeFieldInfoPtr_cardDropSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "cardDropSfx");
			Spell_Kagerou.NativeFieldInfoPtr_redEyeShineSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "redEyeShineSfx");
			Spell_Kagerou.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678589);
			Spell_Kagerou.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678590);
			Spell_Kagerou.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678591);
			Spell_Kagerou.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678592);
			Spell_Kagerou.NativeMethodInfoPtr_WolfLikeTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678593);
			Spell_Kagerou.NativeMethodInfoPtr_WolfHateTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678594);
			Spell_Kagerou.NativeMethodInfoPtr_OnPositiveBuffEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678595);
			Spell_Kagerou.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678596);
			Spell_Kagerou.NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678597);
			Spell_Kagerou.NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_1_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678598);
			Spell_Kagerou.NativeMethodInfoPtr__OnPositiveBuffEnd_b__27_0_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, 100678599);
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x001A5C50 File Offset: 0x001A3E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196361, XrefRangeEnd = 196363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kagerou.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x001A5C94 File Offset: 0x001A3E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196363, XrefRangeEnd = 196368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kagerou.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x001A5CF0 File Offset: 0x001A3EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196368, XrefRangeEnd = 196374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kagerou.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x001A5D4C File Offset: 0x001A3F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196374, XrefRangeEnd = 196398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGuestSpawn(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x001A5D90 File Offset: 0x001A3F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196398, XrefRangeEnd = 196401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> WolfLikeTags(Il2CppStructArray<int> originalTags, GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalTags);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.NativeMethodInfoPtr_WolfLikeTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x001A5DF4 File Offset: 0x001A3FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196401, XrefRangeEnd = 196404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> WolfHateTags(Il2CppStructArray<int> originalTags, GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalTags);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.NativeMethodInfoPtr_WolfHateTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06004BE6 RID: 19430 RVA: 0x001A5E58 File Offset: 0x001A4058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196404, XrefRangeEnd = 196424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPositiveBuffEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.NativeMethodInfoPtr_OnPositiveBuffEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x001A5E8C File Offset: 0x001A408C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Kagerou() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x001A5EC8 File Offset: 0x001A40C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196424, XrefRangeEnd = 196450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__23_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x001A5F08 File Offset: 0x001A4108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196450, XrefRangeEnd = 196474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__23_1(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_1_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x001A5F4C File Offset: 0x001A414C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196474, XrefRangeEnd = 196498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffEnd_b__27_0(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.NativeMethodInfoPtr__OnPositiveBuffEnd_b__27_0_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x0002719F File Offset: 0x0002539F
		public Spell_Kagerou(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06004BEC RID: 19436 RVA: 0x001A5F90 File Offset: 0x001A4190
		// (set) Token: 0x06004BED RID: 19437 RVA: 0x000271A8 File Offset: 0x000253A8
		public unsafe static int MEATED_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Kagerou.NativeFieldInfoPtr_MEATED_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Kagerou.NativeFieldInfoPtr_MEATED_TAG, (void*)(&value));
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06004BEE RID: 19438 RVA: 0x001A5FAC File Offset: 0x001A41AC
		// (set) Token: 0x06004BEF RID: 19439 RVA: 0x000271B6 File Offset: 0x000253B6
		public unsafe static int MOUNTGAINDELICOUS_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Kagerou.NativeFieldInfoPtr_MOUNTGAINDELICOUS_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Kagerou.NativeFieldInfoPtr_MOUNTGAINDELICOUS_TAG, (void*)(&value));
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x001A5FC8 File Offset: 0x001A41C8
		// (set) Token: 0x06004BF1 RID: 19441 RVA: 0x000271C4 File Offset: 0x000253C4
		public unsafe static int FULLFILLED_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Kagerou.NativeFieldInfoPtr_FULLFILLED_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Kagerou.NativeFieldInfoPtr_FULLFILLED_TAG, (void*)(&value));
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x001A5FE4 File Offset: 0x001A41E4
		// (set) Token: 0x06004BF3 RID: 19443 RVA: 0x000271D2 File Offset: 0x000253D2
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06004BF4 RID: 19444 RVA: 0x001A600C File Offset: 0x001A420C
		// (set) Token: 0x06004BF5 RID: 19445 RVA: 0x000271ED File Offset: 0x000253ED
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06004BF6 RID: 19446 RVA: 0x001A6034 File Offset: 0x001A4234
		// (set) Token: 0x06004BF7 RID: 19447 RVA: 0x00027208 File Offset: 0x00025408
		public unsafe float meatVFXDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_meatVFXDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_meatVFXDuration)) = value;
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x001A605C File Offset: 0x001A425C
		// (set) Token: 0x06004BF9 RID: 19449 RVA: 0x00027223 File Offset: 0x00025423
		public unsafe float beastarVFXDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_beastarVFXDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_beastarVFXDuration)) = value;
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06004BFA RID: 19450 RVA: 0x001A6084 File Offset: 0x001A4284
		// (set) Token: 0x06004BFB RID: 19451 RVA: 0x0002723E File Offset: 0x0002543E
		public unsafe GameObject rewardWolfDanceVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_rewardWolfDanceVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_rewardWolfDanceVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x001A60B4 File Offset: 0x001A42B4
		// (set) Token: 0x06004BFD RID: 19453 RVA: 0x0002725D File Offset: 0x0002545D
		public unsafe GameObject rewardMeatVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_rewardMeatVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_rewardMeatVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x06004BFE RID: 19454 RVA: 0x001A60E4 File Offset: 0x001A42E4
		// (set) Token: 0x06004BFF RID: 19455 RVA: 0x0002727C File Offset: 0x0002547C
		public unsafe GameObject rewardBeastarVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_rewardBeastarVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_rewardBeastarVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x06004C00 RID: 19456 RVA: 0x001A6114 File Offset: 0x001A4314
		// (set) Token: 0x06004C01 RID: 19457 RVA: 0x0002729B File Offset: 0x0002549B
		public unsafe Vector2 rewardBeastarVFXOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_rewardBeastarVFXOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_rewardBeastarVFXOffset)) = value;
			}
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06004C02 RID: 19458 RVA: 0x001A613C File Offset: 0x001A433C
		// (set) Token: 0x06004C03 RID: 19459 RVA: 0x000272B6 File Offset: 0x000254B6
		public unsafe GameObject punishmentVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_punishmentVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_punishmentVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06004C04 RID: 19460 RVA: 0x001A616C File Offset: 0x001A436C
		// (set) Token: 0x06004C05 RID: 19461 RVA: 0x000272D5 File Offset: 0x000254D5
		public unsafe float punishmentDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_punishmentDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_punishmentDuration)) = value;
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06004C06 RID: 19462 RVA: 0x001A6194 File Offset: 0x001A4394
		// (set) Token: 0x06004C07 RID: 19463 RVA: 0x000272F0 File Offset: 0x000254F0
		public unsafe float cardArriveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_cardArriveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_cardArriveDuration)) = value;
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06004C08 RID: 19464 RVA: 0x001A61BC File Offset: 0x001A43BC
		// (set) Token: 0x06004C09 RID: 19465 RVA: 0x0002730B File Offset: 0x0002550B
		public unsafe float punishmentAnimDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_punishmentAnimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_punishmentAnimDuration)) = value;
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x001A61E4 File Offset: 0x001A43E4
		// (set) Token: 0x06004C0B RID: 19467 RVA: 0x00027326 File Offset: 0x00025526
		public unsafe float shakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_shakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_shakeDuration)) = value;
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x001A620C File Offset: 0x001A440C
		// (set) Token: 0x06004C0D RID: 19469 RVA: 0x00027341 File Offset: 0x00025541
		public unsafe float shakeFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_shakeFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_shakeFadeDuration)) = value;
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06004C0E RID: 19470 RVA: 0x001A6234 File Offset: 0x001A4434
		// (set) Token: 0x06004C0F RID: 19471 RVA: 0x0002735C File Offset: 0x0002555C
		public SpellBase.DelayAudioClip wolfDanceSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_wolfDanceSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_wolfDanceSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06004C10 RID: 19472 RVA: 0x001A6264 File Offset: 0x001A4464
		// (set) Token: 0x06004C11 RID: 19473 RVA: 0x0002738A File Offset: 0x0002558A
		public SpellBase.DelayAudioClip meatLoveSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_meatLoveSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_meatLoveSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06004C12 RID: 19474 RVA: 0x001A6294 File Offset: 0x001A4494
		// (set) Token: 0x06004C13 RID: 19475 RVA: 0x000273B8 File Offset: 0x000255B8
		public SpellBase.DelayAudioClip cardDropSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_cardDropSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_cardDropSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06004C14 RID: 19476 RVA: 0x001A62C4 File Offset: 0x001A44C4
		// (set) Token: 0x06004C15 RID: 19477 RVA: 0x000273E6 File Offset: 0x000255E6
		public SpellBase.DelayAudioClip redEyeShineSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_redEyeShineSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.NativeFieldInfoPtr_redEyeShineSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040033FD RID: 13309
		private static readonly IntPtr NativeFieldInfoPtr_MEATED_TAG;

		// Token: 0x040033FE RID: 13310
		private static readonly IntPtr NativeFieldInfoPtr_MOUNTGAINDELICOUS_TAG;

		// Token: 0x040033FF RID: 13311
		private static readonly IntPtr NativeFieldInfoPtr_FULLFILLED_TAG;

		// Token: 0x04003400 RID: 13312
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x04003401 RID: 13313
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003402 RID: 13314
		private static readonly IntPtr NativeFieldInfoPtr_meatVFXDuration;

		// Token: 0x04003403 RID: 13315
		private static readonly IntPtr NativeFieldInfoPtr_beastarVFXDuration;

		// Token: 0x04003404 RID: 13316
		private static readonly IntPtr NativeFieldInfoPtr_rewardWolfDanceVFX;

		// Token: 0x04003405 RID: 13317
		private static readonly IntPtr NativeFieldInfoPtr_rewardMeatVFX;

		// Token: 0x04003406 RID: 13318
		private static readonly IntPtr NativeFieldInfoPtr_rewardBeastarVFX;

		// Token: 0x04003407 RID: 13319
		private static readonly IntPtr NativeFieldInfoPtr_rewardBeastarVFXOffset;

		// Token: 0x04003408 RID: 13320
		private static readonly IntPtr NativeFieldInfoPtr_punishmentVFX;

		// Token: 0x04003409 RID: 13321
		private static readonly IntPtr NativeFieldInfoPtr_punishmentDuration;

		// Token: 0x0400340A RID: 13322
		private static readonly IntPtr NativeFieldInfoPtr_cardArriveDuration;

		// Token: 0x0400340B RID: 13323
		private static readonly IntPtr NativeFieldInfoPtr_punishmentAnimDuration;

		// Token: 0x0400340C RID: 13324
		private static readonly IntPtr NativeFieldInfoPtr_shakeDuration;

		// Token: 0x0400340D RID: 13325
		private static readonly IntPtr NativeFieldInfoPtr_shakeFadeDuration;

		// Token: 0x0400340E RID: 13326
		private static readonly IntPtr NativeFieldInfoPtr_wolfDanceSfx;

		// Token: 0x0400340F RID: 13327
		private static readonly IntPtr NativeFieldInfoPtr_meatLoveSfx;

		// Token: 0x04003410 RID: 13328
		private static readonly IntPtr NativeFieldInfoPtr_cardDropSfx;

		// Token: 0x04003411 RID: 13329
		private static readonly IntPtr NativeFieldInfoPtr_redEyeShineSfx;

		// Token: 0x04003412 RID: 13330
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003413 RID: 13331
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003414 RID: 13332
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003415 RID: 13333
		private static readonly IntPtr NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0;

		// Token: 0x04003416 RID: 13334
		private static readonly IntPtr NativeMethodInfoPtr_WolfLikeTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0;

		// Token: 0x04003417 RID: 13335
		private static readonly IntPtr NativeMethodInfoPtr_WolfHateTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0;

		// Token: 0x04003418 RID: 13336
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffEnd_Private_Void_0;

		// Token: 0x04003419 RID: 13337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400341A RID: 13338
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_0_Private_Void_Int32_0;

		// Token: 0x0400341B RID: 13339
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_1_Private_Void_GuestGroupController_0;

		// Token: 0x0400341C RID: 13340
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffEnd_b__27_0_Private_Void_GuestGroupController_0;

		// Token: 0x02000B23 RID: 2851
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kagerou+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D341 RID: 54081 RVA: 0x0033B7EC File Offset: 0x003399EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<Spell_Kagerou.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kagerou.__c__DisplayClass22_0>.NativeClassPtr);
				Spell_Kagerou.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				Spell_Kagerou.__c__DisplayClass22_0.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou.__c__DisplayClass22_0>.NativeClassPtr, "modifier");
				Spell_Kagerou.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou.__c__DisplayClass22_0>.NativeClassPtr, 100678600);
				Spell_Kagerou.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou.__c__DisplayClass22_0>.NativeClassPtr, 100678601);
			}

			// Token: 0x0600D342 RID: 54082 RVA: 0x0033B868 File Offset: 0x00339A68
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kagerou.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D343 RID: 54083 RVA: 0x0033B8A4 File Offset: 0x00339AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196251, XrefRangeEnd = 196253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D344 RID: 54084 RVA: 0x00071269 File Offset: 0x0006F469
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044BD RID: 17597
			// (get) Token: 0x0600D345 RID: 54085 RVA: 0x0033B8D8 File Offset: 0x00339AD8
			// (set) Token: 0x0600D346 RID: 54086 RVA: 0x00071272 File Offset: 0x0006F472
			public unsafe Spell_Kagerou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kagerou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044BE RID: 17598
			// (get) Token: 0x0600D347 RID: 54087 RVA: 0x0033B908 File Offset: 0x00339B08
			// (set) Token: 0x0600D348 RID: 54088 RVA: 0x00071291 File Offset: 0x0006F491
			public EventManager.EvalModifier modifier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.__c__DisplayClass22_0.NativeFieldInfoPtr_modifier);
					return new EventManager.EvalModifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.EvalModifier>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou.__c__DisplayClass22_0.NativeFieldInfoPtr_modifier), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.EvalModifier>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040087A1 RID: 34721
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087A2 RID: 34722
			private static readonly IntPtr NativeFieldInfoPtr_modifier;

			// Token: 0x040087A3 RID: 34723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087A4 RID: 34724
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_0;
		}

		// Token: 0x02000B24 RID: 2852
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kagerou+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D349 RID: 54089 RVA: 0x0033B938 File Offset: 0x00339B38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr);
				Spell_Kagerou.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr, "<>9");
				Spell_Kagerou.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr, "<>9__22_1");
				Spell_Kagerou.__c.NativeFieldInfoPtr___9__22_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr, "<>9__22_2");
				Spell_Kagerou.__c.NativeFieldInfoPtr___9__23_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr, "<>9__23_2");
				Spell_Kagerou.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr, 100678603);
				Spell_Kagerou.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_1_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr, 100678604);
				Spell_Kagerou.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_2_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr, 100678605);
				Spell_Kagerou.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_2_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr, 100678606);
			}

			// Token: 0x0600D34A RID: 54090 RVA: 0x0033BA04 File Offset: 0x00339C04
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kagerou.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D34B RID: 54091 RVA: 0x0033BA40 File Offset: 0x00339C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196253, XrefRangeEnd = 196265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__22_1(int remainingTime, string buffDescription)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref remainingTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_1_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D34C RID: 54092 RVA: 0x0033BA98 File Offset: 0x00339C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196265, XrefRangeEnd = 196268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnNegativeBuffExecute_b__22_2(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_2_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D34D RID: 54093 RVA: 0x0033BAE8 File Offset: 0x00339CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196268, XrefRangeEnd = 196271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__23_2(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_2_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D34E RID: 54094 RVA: 0x000712BF File Offset: 0x0006F4BF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044BF RID: 17599
			// (get) Token: 0x0600D34F RID: 54095 RVA: 0x0033BB38 File Offset: 0x00339D38
			// (set) Token: 0x0600D350 RID: 54096 RVA: 0x000712C8 File Offset: 0x0006F4C8
			public unsafe static Spell_Kagerou.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Kagerou.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kagerou.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Kagerou.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044C0 RID: 17600
			// (get) Token: 0x0600D351 RID: 54097 RVA: 0x0033BB60 File Offset: 0x00339D60
			// (set) Token: 0x0600D352 RID: 54098 RVA: 0x000712DA File Offset: 0x0006F4DA
			public unsafe static Func<int, string, string> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Kagerou.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Kagerou.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044C1 RID: 17601
			// (get) Token: 0x0600D353 RID: 54099 RVA: 0x0033BB88 File Offset: 0x00339D88
			// (set) Token: 0x0600D354 RID: 54100 RVA: 0x000712EC File Offset: 0x0006F4EC
			public unsafe static Predicate<GuestGroupController> __9__22_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Kagerou.__c.NativeFieldInfoPtr___9__22_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Kagerou.__c.NativeFieldInfoPtr___9__22_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044C2 RID: 17602
			// (get) Token: 0x0600D355 RID: 54101 RVA: 0x0033BBB0 File Offset: 0x00339DB0
			// (set) Token: 0x0600D356 RID: 54102 RVA: 0x000712FE File Offset: 0x0006F4FE
			public unsafe static Predicate<GuestGroupController> __9__23_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Kagerou.__c.NativeFieldInfoPtr___9__23_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Kagerou.__c.NativeFieldInfoPtr___9__23_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087A5 RID: 34725
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040087A6 RID: 34726
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x040087A7 RID: 34727
			private static readonly IntPtr NativeFieldInfoPtr___9__22_2;

			// Token: 0x040087A8 RID: 34728
			private static readonly IntPtr NativeFieldInfoPtr___9__23_2;

			// Token: 0x040087A9 RID: 34729
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087AA RID: 34730
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_1_Internal_String_Int32_String_0;

			// Token: 0x040087AB RID: 34731
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_2_Internal_Boolean_GuestGroupController_0;

			// Token: 0x040087AC RID: 34732
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__23_2_Internal_Boolean_GuestGroupController_0;
		}

		// Token: 0x02000B25 RID: 2853
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kagerou+<OnNegativeBuffExecute>d__22")]
		public sealed class _OnNegativeBuffExecute_d__22 : Il2CppSystem.Object
		{
			// Token: 0x0600D357 RID: 54103 RVA: 0x0033BBD8 File Offset: 0x00339DD8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__22()
			{
				Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "<OnNegativeBuffExecute>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr);
				Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>1__state");
				Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>2__current");
				Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>4__this");
				Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>8__1");
				Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100678607);
				Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100678608);
				Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100678609);
				Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100678610);
				Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100678611);
				Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100678612);
			}

			// Token: 0x0600D358 RID: 54104 RVA: 0x0033BCCC File Offset: 0x00339ECC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kagerou._OnNegativeBuffExecute_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D359 RID: 54105 RVA: 0x0033BD14 File Offset: 0x00339F14
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D35A RID: 54106 RVA: 0x0033BD48 File Offset: 0x00339F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196271, XrefRangeEnd = 196317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044C7 RID: 17607
			// (get) Token: 0x0600D35B RID: 54107 RVA: 0x0033BD84 File Offset: 0x00339F84
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D35C RID: 54108 RVA: 0x0033BDC4 File Offset: 0x00339FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196317, XrefRangeEnd = 196323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044C8 RID: 17608
			// (get) Token: 0x0600D35D RID: 54109 RVA: 0x0033BDF8 File Offset: 0x00339FF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D35E RID: 54110 RVA: 0x00071310 File Offset: 0x0006F510
			public _OnNegativeBuffExecute_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044C3 RID: 17603
			// (get) Token: 0x0600D35F RID: 54111 RVA: 0x0033BE38 File Offset: 0x0033A038
			// (set) Token: 0x0600D360 RID: 54112 RVA: 0x00071319 File Offset: 0x0006F519
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044C4 RID: 17604
			// (get) Token: 0x0600D361 RID: 54113 RVA: 0x0033BE60 File Offset: 0x0033A060
			// (set) Token: 0x0600D362 RID: 54114 RVA: 0x00071334 File Offset: 0x0006F534
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044C5 RID: 17605
			// (get) Token: 0x0600D363 RID: 54115 RVA: 0x0033BE90 File Offset: 0x0033A090
			// (set) Token: 0x0600D364 RID: 54116 RVA: 0x00071353 File Offset: 0x0006F553
			public unsafe Spell_Kagerou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kagerou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044C6 RID: 17606
			// (get) Token: 0x0600D365 RID: 54117 RVA: 0x0033BEC0 File Offset: 0x0033A0C0
			// (set) Token: 0x0600D366 RID: 54118 RVA: 0x00071372 File Offset: 0x0006F572
			public unsafe Spell_Kagerou.__c__DisplayClass22_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kagerou.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087AD RID: 34733
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087AE RID: 34734
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087AF RID: 34735
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087B0 RID: 34736
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040087B1 RID: 34737
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087B2 RID: 34738
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087B3 RID: 34739
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087B4 RID: 34740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087B5 RID: 34741
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087B6 RID: 34742
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B26 RID: 2854
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kagerou+<OnPositiveBuffExecute>d__23")]
		public sealed class _OnPositiveBuffExecute_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600D367 RID: 54119 RVA: 0x0033BEF0 File Offset: 0x0033A0F0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__23()
			{
				Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kagerou>.NativeClassPtr, "<OnPositiveBuffExecute>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr);
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, "<>1__state");
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, "<>2__current");
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, "<>4__this");
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, "spellExecutionContext");
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr__beastStar_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, "<beastStar>5__2");
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100678613);
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100678614);
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100678615);
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100678616);
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100678617);
				Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr, 100678618);
			}

			// Token: 0x0600D368 RID: 54120 RVA: 0x0033BFF8 File Offset: 0x0033A1F8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kagerou._OnPositiveBuffExecute_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D369 RID: 54121 RVA: 0x0033C040 File Offset: 0x0033A240
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D36A RID: 54122 RVA: 0x0033C074 File Offset: 0x0033A274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196323, XrefRangeEnd = 196355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044CE RID: 17614
			// (get) Token: 0x0600D36B RID: 54123 RVA: 0x0033C0B0 File Offset: 0x0033A2B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D36C RID: 54124 RVA: 0x0033C0F0 File Offset: 0x0033A2F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196355, XrefRangeEnd = 196361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044CF RID: 17615
			// (get) Token: 0x0600D36D RID: 54125 RVA: 0x0033C124 File Offset: 0x0033A324
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D36E RID: 54126 RVA: 0x00071391 File Offset: 0x0006F591
			public _OnPositiveBuffExecute_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044C9 RID: 17609
			// (get) Token: 0x0600D36F RID: 54127 RVA: 0x0033C164 File Offset: 0x0033A364
			// (set) Token: 0x0600D370 RID: 54128 RVA: 0x0007139A File Offset: 0x0006F59A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044CA RID: 17610
			// (get) Token: 0x0600D371 RID: 54129 RVA: 0x0033C18C File Offset: 0x0033A38C
			// (set) Token: 0x0600D372 RID: 54130 RVA: 0x000713B5 File Offset: 0x0006F5B5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CB RID: 17611
			// (get) Token: 0x0600D373 RID: 54131 RVA: 0x0033C1BC File Offset: 0x0033A3BC
			// (set) Token: 0x0600D374 RID: 54132 RVA: 0x000713D4 File Offset: 0x0006F5D4
			public unsafe Spell_Kagerou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kagerou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CC RID: 17612
			// (get) Token: 0x0600D375 RID: 54133 RVA: 0x0033C1EC File Offset: 0x0033A3EC
			// (set) Token: 0x0600D376 RID: 54134 RVA: 0x000713F3 File Offset: 0x0006F5F3
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CD RID: 17613
			// (get) Token: 0x0600D377 RID: 54135 RVA: 0x0033C21C File Offset: 0x0033A41C
			// (set) Token: 0x0600D378 RID: 54136 RVA: 0x00071412 File Offset: 0x0006F612
			public unsafe GameObject _beastStar_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr__beastStar_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kagerou._OnPositiveBuffExecute_d__23.NativeFieldInfoPtr__beastStar_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087B7 RID: 34743
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087B8 RID: 34744
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087B9 RID: 34745
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087BA RID: 34746
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040087BB RID: 34747
			private static readonly IntPtr NativeFieldInfoPtr__beastStar_5__2;

			// Token: 0x040087BC RID: 34748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087BD RID: 34749
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087BE RID: 34750
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087BF RID: 34751
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087C0 RID: 34752
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087C1 RID: 34753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
