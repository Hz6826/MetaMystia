using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200028A RID: 650
	public class Spell_TotetsuYuuma : SpellBase
	{
		// Token: 0x06005232 RID: 21042 RVA: 0x001B571C File Offset: 0x001B391C
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_TotetsuYuuma()
		{
			Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_TotetsuYuuma");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr);
			Spell_TotetsuYuuma.NativeFieldInfoPtr_positiveDurationSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "positiveDurationSec");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowedIngredientsNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "swallowedIngredientsNum");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowedBevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "swallowedBevNum");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowedCookerNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "swallowedCookerNum");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_picOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "picOffset");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_positivePicOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "positivePicOffset");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "swallowAnim");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_trackTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "trackTable");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_yuumaSmokeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "yuumaSmokeObject");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_energyVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "energyVfx");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_yuumaPositiveSmokeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "yuumaPositiveSmokeObject");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "rewardSFX");
			Spell_TotetsuYuuma.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "punishmentSFX");
			Spell_TotetsuYuuma.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, 100679923);
			Spell_TotetsuYuuma.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, 100679924);
			Spell_TotetsuYuuma.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, 100679925);
			Spell_TotetsuYuuma.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, 100679926);
			Spell_TotetsuYuuma.NativeMethodInfoPtr_YuumaOverrideOrderGeneration_Private_OrderBase_GuestGroupController_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, 100679927);
			Spell_TotetsuYuuma.NativeMethodInfoPtr_OnBuffEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, 100679928);
			Spell_TotetsuYuuma.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, 100679929);
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x001B58DC File Offset: 0x001B3ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206207, XrefRangeEnd = 206209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_TotetsuYuuma.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x001B5920 File Offset: 0x001B3B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206209, XrefRangeEnd = 206215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_TotetsuYuuma.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x001B597C File Offset: 0x001B3B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206215, XrefRangeEnd = 206221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_TotetsuYuuma.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x001B59D8 File Offset: 0x001B3BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206221, XrefRangeEnd = 206232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGuestSpawn(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x001B5A1C File Offset: 0x001B3C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206232, XrefRangeEnd = 206252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestsManager.OrderBase YuumaOverrideOrderGeneration(GuestGroupController guestGroup, out string orderGenerationMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.NativeMethodInfoPtr_YuumaOverrideOrderGeneration_Private_OrderBase_GuestGroupController_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			orderGenerationMessage = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr4) : null;
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x001B5A88 File Offset: 0x001B3C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206252, XrefRangeEnd = 206289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBuffEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.NativeMethodInfoPtr_OnBuffEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x001B5ABC File Offset: 0x001B3CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206289, XrefRangeEnd = 206290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_TotetsuYuuma() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x0002BE54 File Offset: 0x0002A054
		public Spell_TotetsuYuuma(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x0600523B RID: 21051 RVA: 0x001B5AF8 File Offset: 0x001B3CF8
		// (set) Token: 0x0600523C RID: 21052 RVA: 0x0002BE5D File Offset: 0x0002A05D
		public unsafe int positiveDurationSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_positiveDurationSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_positiveDurationSec)) = value;
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x0600523D RID: 21053 RVA: 0x001B5B20 File Offset: 0x001B3D20
		// (set) Token: 0x0600523E RID: 21054 RVA: 0x0002BE78 File Offset: 0x0002A078
		public unsafe Vector2Int swallowedIngredientsNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowedIngredientsNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowedIngredientsNum)) = value;
			}
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x0600523F RID: 21055 RVA: 0x001B5B48 File Offset: 0x001B3D48
		// (set) Token: 0x06005240 RID: 21056 RVA: 0x0002BE93 File Offset: 0x0002A093
		public unsafe Vector2Int swallowedBevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowedBevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowedBevNum)) = value;
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06005241 RID: 21057 RVA: 0x001B5B70 File Offset: 0x001B3D70
		// (set) Token: 0x06005242 RID: 21058 RVA: 0x0002BEAE File Offset: 0x0002A0AE
		public unsafe int swallowedCookerNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowedCookerNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowedCookerNum)) = value;
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06005243 RID: 21059 RVA: 0x001B5B98 File Offset: 0x001B3D98
		// (set) Token: 0x06005244 RID: 21060 RVA: 0x0002BEC9 File Offset: 0x0002A0C9
		public unsafe Vector2 picOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_picOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_picOffset)) = value;
			}
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06005245 RID: 21061 RVA: 0x001B5BC0 File Offset: 0x001B3DC0
		// (set) Token: 0x06005246 RID: 21062 RVA: 0x0002BEE4 File Offset: 0x0002A0E4
		public unsafe Vector2 positivePicOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_positivePicOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_positivePicOffset)) = value;
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06005247 RID: 21063 RVA: 0x001B5BE8 File Offset: 0x001B3DE8
		// (set) Token: 0x06005248 RID: 21064 RVA: 0x0002BEFF File Offset: 0x0002A0FF
		public unsafe GameObject swallowAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_swallowAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06005249 RID: 21065 RVA: 0x001B5C18 File Offset: 0x001B3E18
		// (set) Token: 0x0600524A RID: 21066 RVA: 0x0002BF1E File Offset: 0x0002A11E
		public unsafe GameObject trackTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_trackTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_trackTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x0600524B RID: 21067 RVA: 0x001B5C48 File Offset: 0x001B3E48
		// (set) Token: 0x0600524C RID: 21068 RVA: 0x0002BF3D File Offset: 0x0002A13D
		public unsafe GameObject yuumaSmokeObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_yuumaSmokeObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_yuumaSmokeObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x0600524D RID: 21069 RVA: 0x001B5C78 File Offset: 0x001B3E78
		// (set) Token: 0x0600524E RID: 21070 RVA: 0x0002BF5C File Offset: 0x0002A15C
		public unsafe GameObject energyVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_energyVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_energyVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x0600524F RID: 21071 RVA: 0x001B5CA8 File Offset: 0x001B3EA8
		// (set) Token: 0x06005250 RID: 21072 RVA: 0x0002BF7B File Offset: 0x0002A17B
		public unsafe GameObject yuumaPositiveSmokeObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_yuumaPositiveSmokeObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_yuumaPositiveSmokeObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06005251 RID: 21073 RVA: 0x001B5CD8 File Offset: 0x001B3ED8
		// (set) Token: 0x06005252 RID: 21074 RVA: 0x0002BF9A File Offset: 0x0002A19A
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06005253 RID: 21075 RVA: 0x001B5D08 File Offset: 0x001B3F08
		// (set) Token: 0x06005254 RID: 21076 RVA: 0x0002BFB9 File Offset: 0x0002A1B9
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003773 RID: 14195
		private static readonly IntPtr NativeFieldInfoPtr_positiveDurationSec;

		// Token: 0x04003774 RID: 14196
		private static readonly IntPtr NativeFieldInfoPtr_swallowedIngredientsNum;

		// Token: 0x04003775 RID: 14197
		private static readonly IntPtr NativeFieldInfoPtr_swallowedBevNum;

		// Token: 0x04003776 RID: 14198
		private static readonly IntPtr NativeFieldInfoPtr_swallowedCookerNum;

		// Token: 0x04003777 RID: 14199
		private static readonly IntPtr NativeFieldInfoPtr_picOffset;

		// Token: 0x04003778 RID: 14200
		private static readonly IntPtr NativeFieldInfoPtr_positivePicOffset;

		// Token: 0x04003779 RID: 14201
		private static readonly IntPtr NativeFieldInfoPtr_swallowAnim;

		// Token: 0x0400377A RID: 14202
		private static readonly IntPtr NativeFieldInfoPtr_trackTable;

		// Token: 0x0400377B RID: 14203
		private static readonly IntPtr NativeFieldInfoPtr_yuumaSmokeObject;

		// Token: 0x0400377C RID: 14204
		private static readonly IntPtr NativeFieldInfoPtr_energyVfx;

		// Token: 0x0400377D RID: 14205
		private static readonly IntPtr NativeFieldInfoPtr_yuumaPositiveSmokeObject;

		// Token: 0x0400377E RID: 14206
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x0400377F RID: 14207
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x04003780 RID: 14208
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003781 RID: 14209
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003782 RID: 14210
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003783 RID: 14211
		private static readonly IntPtr NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0;

		// Token: 0x04003784 RID: 14212
		private static readonly IntPtr NativeMethodInfoPtr_YuumaOverrideOrderGeneration_Private_OrderBase_GuestGroupController_byref_String_0;

		// Token: 0x04003785 RID: 14213
		private static readonly IntPtr NativeMethodInfoPtr_OnBuffEnd_Private_Void_0;

		// Token: 0x04003786 RID: 14214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE1 RID: 3041
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_TotetsuYuuma+<>c__DisplayClass14_0")]
		public new sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDC6 RID: 56774 RVA: 0x0035B23C File Offset: 0x0035943C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr);
				Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr, "spellExecutionContext");
				Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr_lockedCookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr, "lockedCookController");
				Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr_eatingGameObejctCooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr, "eatingGameObejctCooker");
				Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr, "<>9__4");
				Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr, 100679930);
				Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr, 100679931);
				Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr, 100679932);
				Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr, 100679933);
			}

			// Token: 0x0600DDC7 RID: 56775 RVA: 0x0035B31C File Offset: 0x0035951C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDC8 RID: 56776 RVA: 0x0035B358 File Offset: 0x00359558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205851, XrefRangeEnd = 205865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDC9 RID: 56777 RVA: 0x0035B39C File Offset: 0x0035959C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205865, XrefRangeEnd = 205869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDCA RID: 56778 RVA: 0x0035B3D8 File Offset: 0x003595D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205869, XrefRangeEnd = 205905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDCB RID: 56779 RVA: 0x00076764 File Offset: 0x00074964
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004816 RID: 18454
			// (get) Token: 0x0600DDCC RID: 56780 RVA: 0x0035B40C File Offset: 0x0035960C
			// (set) Token: 0x0600DDCD RID: 56781 RVA: 0x0007676D File Offset: 0x0007496D
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004817 RID: 18455
			// (get) Token: 0x0600DDCE RID: 56782 RVA: 0x0035B43C File Offset: 0x0035963C
			// (set) Token: 0x0600DDCF RID: 56783 RVA: 0x0007678C File Offset: 0x0007498C
			public unsafe Spell_TotetsuYuuma __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_TotetsuYuuma>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004818 RID: 18456
			// (get) Token: 0x0600DDD0 RID: 56784 RVA: 0x0035B46C File Offset: 0x0035966C
			// (set) Token: 0x0600DDD1 RID: 56785 RVA: 0x000767AB File Offset: 0x000749AB
			public unsafe List<CookController> lockedCookController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr_lockedCookController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CookController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr_lockedCookController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004819 RID: 18457
			// (get) Token: 0x0600DDD2 RID: 56786 RVA: 0x0035B49C File Offset: 0x0035969C
			// (set) Token: 0x0600DDD3 RID: 56787 RVA: 0x000767CA File Offset: 0x000749CA
			public unsafe List<GameObject> eatingGameObejctCooker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr_eatingGameObejctCooker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr_eatingGameObejctCooker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700481A RID: 18458
			// (get) Token: 0x0600DDD4 RID: 56788 RVA: 0x0035B4CC File Offset: 0x003596CC
			// (set) Token: 0x0600DDD5 RID: 56789 RVA: 0x000767E9 File Offset: 0x000749E9
			public unsafe Func<Vector3> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E06 RID: 36358
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008E07 RID: 36359
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E08 RID: 36360
			private static readonly IntPtr NativeFieldInfoPtr_lockedCookController;

			// Token: 0x04008E09 RID: 36361
			private static readonly IntPtr NativeFieldInfoPtr_eatingGameObejctCooker;

			// Token: 0x04008E0A RID: 36362
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04008E0B RID: 36363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E0C RID: 36364
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0;

			// Token: 0x04008E0D RID: 36365
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Vector3_0;

			// Token: 0x04008E0E RID: 36366
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000BE2 RID: 3042
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_TotetsuYuuma+<>c__DisplayClass14_1")]
		public sealed class __c__DisplayClass14_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DDD6 RID: 56790 RVA: 0x0035B4FC File Offset: 0x003596FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_1()
			{
				Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "<>c__DisplayClass14_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_1>.NativeClassPtr);
				Spell_TotetsuYuuma.__c__DisplayClass14_1.NativeFieldInfoPtr_controller1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_1>.NativeClassPtr, "controller1");
				Spell_TotetsuYuuma.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_1>.NativeClassPtr, 100679934);
				Spell_TotetsuYuuma.__c__DisplayClass14_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_1>.NativeClassPtr, 100679935);
			}

			// Token: 0x0600DDD7 RID: 56791 RVA: 0x0035B564 File Offset: 0x00359764
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDD8 RID: 56792 RVA: 0x0035B5A0 File Offset: 0x003597A0
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass14_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDD9 RID: 56793 RVA: 0x00076808 File Offset: 0x00074A08
			public __c__DisplayClass14_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700481B RID: 18459
			// (get) Token: 0x0600DDDA RID: 56794 RVA: 0x0035B5DC File Offset: 0x003597DC
			// (set) Token: 0x0600DDDB RID: 56795 RVA: 0x00076811 File Offset: 0x00074A11
			public unsafe Vector2 controller1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_1.NativeFieldInfoPtr_controller1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_1.NativeFieldInfoPtr_controller1)) = value;
				}
			}

			// Token: 0x04008E0F RID: 36367
			private static readonly IntPtr NativeFieldInfoPtr_controller1;

			// Token: 0x04008E10 RID: 36368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E11 RID: 36369
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0;
		}

		// Token: 0x02000BE3 RID: 3043
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_TotetsuYuuma+<>c__DisplayClass14_2")]
		public sealed class __c__DisplayClass14_2 : Il2CppSystem.Object
		{
			// Token: 0x0600DDDC RID: 56796 RVA: 0x0035B604 File Offset: 0x00359804
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_2()
			{
				Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "<>c__DisplayClass14_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_2>.NativeClassPtr);
				Spell_TotetsuYuuma.__c__DisplayClass14_2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_2>.NativeClassPtr, "x");
				Spell_TotetsuYuuma.__c__DisplayClass14_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_2>.NativeClassPtr, 100679936);
				Spell_TotetsuYuuma.__c__DisplayClass14_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_2>.NativeClassPtr, 100679937);
			}

			// Token: 0x0600DDDD RID: 56797 RVA: 0x0035B66C File Offset: 0x0035986C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass14_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass14_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDDE RID: 56798 RVA: 0x0035B6A8 File Offset: 0x003598A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205905, XrefRangeEnd = 205909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass14_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDDF RID: 56799 RVA: 0x0007682C File Offset: 0x00074A2C
			public __c__DisplayClass14_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700481C RID: 18460
			// (get) Token: 0x0600DDE0 RID: 56800 RVA: 0x0035B6DC File Offset: 0x003598DC
			// (set) Token: 0x0600DDE1 RID: 56801 RVA: 0x00076835 File Offset: 0x00074A35
			public unsafe GameObject x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_2.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass14_2.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E12 RID: 36370
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008E13 RID: 36371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E14 RID: 36372
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0;
		}

		// Token: 0x02000BE4 RID: 3044
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_TotetsuYuuma+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DDE2 RID: 56802 RVA: 0x0035B70C File Offset: 0x0035990C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr);
				Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr, "<>9");
				Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr, "<>9__14_0");
				Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9__14_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr, "<>9__14_5");
				Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9__14_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr, "<>9__14_6");
				Spell_TotetsuYuuma.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr, 100679939);
				Spell_TotetsuYuuma.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Internal_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr, 100679940);
				Spell_TotetsuYuuma.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_5_Internal_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr, 100679941);
				Spell_TotetsuYuuma.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_6_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr, 100679942);
			}

			// Token: 0x0600DDE3 RID: 56803 RVA: 0x0035B7D8 File Offset: 0x003599D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDE4 RID: 56804 RVA: 0x0035B814 File Offset: 0x00359A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__14_0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Internal_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDE5 RID: 56805 RVA: 0x0035B858 File Offset: 0x00359A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205909, XrefRangeEnd = 205911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__14_5(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_5_Internal_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDE6 RID: 56806 RVA: 0x0035B89C File Offset: 0x00359A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205911, XrefRangeEnd = 205930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__14_6(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_6_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDE7 RID: 56807 RVA: 0x00076854 File Offset: 0x00074A54
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700481D RID: 18461
			// (get) Token: 0x0600DDE8 RID: 56808 RVA: 0x0035B8E0 File Offset: 0x00359AE0
			// (set) Token: 0x0600DDE9 RID: 56809 RVA: 0x0007685D File Offset: 0x00074A5D
			public unsafe static Spell_TotetsuYuuma.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_TotetsuYuuma.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700481E RID: 18462
			// (get) Token: 0x0600DDEA RID: 56810 RVA: 0x0035B908 File Offset: 0x00359B08
			// (set) Token: 0x0600DDEB RID: 56811 RVA: 0x0007686F File Offset: 0x00074A6F
			public unsafe static Action<CookController> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CookController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700481F RID: 18463
			// (get) Token: 0x0600DDEC RID: 56812 RVA: 0x0035B930 File Offset: 0x00359B30
			// (set) Token: 0x0600DDED RID: 56813 RVA: 0x00076881 File Offset: 0x00074A81
			public unsafe static Action<CookController> __9__14_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9__14_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CookController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9__14_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004820 RID: 18464
			// (get) Token: 0x0600DDEE RID: 56814 RVA: 0x0035B958 File Offset: 0x00359B58
			// (set) Token: 0x0600DDEF RID: 56815 RVA: 0x00076893 File Offset: 0x00074A93
			public unsafe static Action<GameObject> __9__14_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9__14_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_TotetsuYuuma.__c.NativeFieldInfoPtr___9__14_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E15 RID: 36373
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E16 RID: 36374
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04008E17 RID: 36375
			private static readonly IntPtr NativeFieldInfoPtr___9__14_5;

			// Token: 0x04008E18 RID: 36376
			private static readonly IntPtr NativeFieldInfoPtr___9__14_6;

			// Token: 0x04008E19 RID: 36377
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E1A RID: 36378
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Internal_Void_CookController_0;

			// Token: 0x04008E1B RID: 36379
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_5_Internal_Void_CookController_0;

			// Token: 0x04008E1C RID: 36380
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_6_Internal_Void_GameObject_0;
		}

		// Token: 0x02000BE5 RID: 3045
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_TotetsuYuuma+<OnNegativeBuffExecute>d__14")]
		public sealed class _OnNegativeBuffExecute_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600DDF0 RID: 56816 RVA: 0x0035B980 File Offset: 0x00359B80
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__14()
			{
				Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "<OnNegativeBuffExecute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr);
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>1__state");
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>2__current");
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, "spellExecutionContext");
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>4__this");
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr__eatingSprite_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<eatingSprite>5__2");
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679943);
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679944);
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679945);
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679946);
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679947);
				Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100679948);
			}

			// Token: 0x0600DDF1 RID: 56817 RVA: 0x0035BA88 File Offset: 0x00359C88
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDF2 RID: 56818 RVA: 0x0035BAD0 File Offset: 0x00359CD0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDF3 RID: 56819 RVA: 0x0035BB04 File Offset: 0x00359D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205930, XrefRangeEnd = 205982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004826 RID: 18470
			// (get) Token: 0x0600DDF4 RID: 56820 RVA: 0x0035BB40 File Offset: 0x00359D40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDF5 RID: 56821 RVA: 0x0035BB80 File Offset: 0x00359D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205982, XrefRangeEnd = 205988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004827 RID: 18471
			// (get) Token: 0x0600DDF6 RID: 56822 RVA: 0x0035BBB4 File Offset: 0x00359DB4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDF7 RID: 56823 RVA: 0x000768A5 File Offset: 0x00074AA5
			public _OnNegativeBuffExecute_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004821 RID: 18465
			// (get) Token: 0x0600DDF8 RID: 56824 RVA: 0x0035BBF4 File Offset: 0x00359DF4
			// (set) Token: 0x0600DDF9 RID: 56825 RVA: 0x000768AE File Offset: 0x00074AAE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004822 RID: 18466
			// (get) Token: 0x0600DDFA RID: 56826 RVA: 0x0035BC1C File Offset: 0x00359E1C
			// (set) Token: 0x0600DDFB RID: 56827 RVA: 0x000768C9 File Offset: 0x00074AC9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004823 RID: 18467
			// (get) Token: 0x0600DDFC RID: 56828 RVA: 0x0035BC4C File Offset: 0x00359E4C
			// (set) Token: 0x0600DDFD RID: 56829 RVA: 0x000768E8 File Offset: 0x00074AE8
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004824 RID: 18468
			// (get) Token: 0x0600DDFE RID: 56830 RVA: 0x0035BC7C File Offset: 0x00359E7C
			// (set) Token: 0x0600DDFF RID: 56831 RVA: 0x00076907 File Offset: 0x00074B07
			public unsafe Spell_TotetsuYuuma __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_TotetsuYuuma>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004825 RID: 18469
			// (get) Token: 0x0600DE00 RID: 56832 RVA: 0x0035BCAC File Offset: 0x00359EAC
			// (set) Token: 0x0600DE01 RID: 56833 RVA: 0x00076926 File Offset: 0x00074B26
			public unsafe List<GameObject> _eatingSprite_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr__eatingSprite_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr__eatingSprite_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E1D RID: 36381
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E1E RID: 36382
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E1F RID: 36383
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008E20 RID: 36384
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E21 RID: 36385
			private static readonly IntPtr NativeFieldInfoPtr__eatingSprite_5__2;

			// Token: 0x04008E22 RID: 36386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E23 RID: 36387
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E24 RID: 36388
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E25 RID: 36389
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E26 RID: 36390
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E27 RID: 36391
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BE6 RID: 3046
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_TotetsuYuuma+<>c__DisplayClass15_0")]
		public new sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE02 RID: 56834 RVA: 0x0035BCDC File Offset: 0x00359EDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr);
				Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr, "spellExecutionContext");
				Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr, "<>9__4");
				Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr, 100679949);
				Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr, 100679950);
				Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr, 100679951);
				Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr, 100679952);
				Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr, 100679953);
			}

			// Token: 0x0600DE03 RID: 56835 RVA: 0x0035BDA8 File Offset: 0x00359FA8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE04 RID: 56836 RVA: 0x0035BDE4 File Offset: 0x00359FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205988, XrefRangeEnd = 206002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE05 RID: 56837 RVA: 0x0035BE28 File Offset: 0x0035A028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206002, XrefRangeEnd = 206008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE06 RID: 56838 RVA: 0x0035BE64 File Offset: 0x0035A064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206008, XrefRangeEnd = 206018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE07 RID: 56839 RVA: 0x0035BEA4 File Offset: 0x0035A0A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206018, XrefRangeEnd = 206029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE08 RID: 56840 RVA: 0x00076945 File Offset: 0x00074B45
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004828 RID: 18472
			// (get) Token: 0x0600DE09 RID: 56841 RVA: 0x0035BEE8 File Offset: 0x0035A0E8
			// (set) Token: 0x0600DE0A RID: 56842 RVA: 0x0007694E File Offset: 0x00074B4E
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004829 RID: 18473
			// (get) Token: 0x0600DE0B RID: 56843 RVA: 0x0035BF18 File Offset: 0x0035A118
			// (set) Token: 0x0600DE0C RID: 56844 RVA: 0x0007696D File Offset: 0x00074B6D
			public unsafe Spell_TotetsuYuuma __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_TotetsuYuuma>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700482A RID: 18474
			// (get) Token: 0x0600DE0D RID: 56845 RVA: 0x0035BF48 File Offset: 0x0035A148
			// (set) Token: 0x0600DE0E RID: 56846 RVA: 0x0007698C File Offset: 0x00074B8C
			public unsafe Func<Vector3> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass15_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E28 RID: 36392
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008E29 RID: 36393
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E2A RID: 36394
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04008E2B RID: 36395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E2C RID: 36396
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008E2D RID: 36397
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Vector3_0;

			// Token: 0x04008E2E RID: 36398
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_Int32_0;

			// Token: 0x04008E2F RID: 36399
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000BE7 RID: 3047
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_TotetsuYuuma+<>c__DisplayClass15_1")]
		public sealed class __c__DisplayClass15_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DE0F RID: 56847 RVA: 0x0035BF78 File Offset: 0x0035A178
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_1()
			{
				Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "<>c__DisplayClass15_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_1>.NativeClassPtr);
				Spell_TotetsuYuuma.__c__DisplayClass15_1.NativeFieldInfoPtr_controller1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_1>.NativeClassPtr, "controller1");
				Spell_TotetsuYuuma.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_1>.NativeClassPtr, 100679954);
				Spell_TotetsuYuuma.__c__DisplayClass15_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_1>.NativeClassPtr, 100679955);
			}

			// Token: 0x0600DE10 RID: 56848 RVA: 0x0035BFE0 File Offset: 0x0035A1E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_TotetsuYuuma.__c__DisplayClass15_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE11 RID: 56849 RVA: 0x0035C01C File Offset: 0x0035A21C
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma.__c__DisplayClass15_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE12 RID: 56850 RVA: 0x000769AB File Offset: 0x00074BAB
			public __c__DisplayClass15_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700482B RID: 18475
			// (get) Token: 0x0600DE13 RID: 56851 RVA: 0x0035C058 File Offset: 0x0035A258
			// (set) Token: 0x0600DE14 RID: 56852 RVA: 0x000769B4 File Offset: 0x00074BB4
			public unsafe Vector2 controller1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass15_1.NativeFieldInfoPtr_controller1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma.__c__DisplayClass15_1.NativeFieldInfoPtr_controller1)) = value;
				}
			}

			// Token: 0x04008E30 RID: 36400
			private static readonly IntPtr NativeFieldInfoPtr_controller1;

			// Token: 0x04008E31 RID: 36401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E32 RID: 36402
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Vector3_0;
		}

		// Token: 0x02000BE8 RID: 3048
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_TotetsuYuuma+<OnPositiveBuffExecute>d__15")]
		public sealed class _OnPositiveBuffExecute_d__15 : Il2CppSystem.Object
		{
			// Token: 0x0600DE15 RID: 56853 RVA: 0x0035C080 File Offset: 0x0035A280
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__15()
			{
				Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_TotetsuYuuma>.NativeClassPtr, "<OnPositiveBuffExecute>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr);
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>1__state");
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>2__current");
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, "spellExecutionContext");
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>4__this");
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>8__1");
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr__eatingSprite_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<eatingSprite>5__2");
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679956);
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679957);
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679958);
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679959);
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679960);
				Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100679961);
			}

			// Token: 0x0600DE16 RID: 56854 RVA: 0x0035C19C File Offset: 0x0035A39C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE17 RID: 56855 RVA: 0x0035C1E4 File Offset: 0x0035A3E4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE18 RID: 56856 RVA: 0x0035C218 File Offset: 0x0035A418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206029, XrefRangeEnd = 206201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004832 RID: 18482
			// (get) Token: 0x0600DE19 RID: 56857 RVA: 0x0035C254 File Offset: 0x0035A454
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE1A RID: 56858 RVA: 0x0035C294 File Offset: 0x0035A494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206201, XrefRangeEnd = 206207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004833 RID: 18483
			// (get) Token: 0x0600DE1B RID: 56859 RVA: 0x0035C2C8 File Offset: 0x0035A4C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE1C RID: 56860 RVA: 0x000769CF File Offset: 0x00074BCF
			public _OnPositiveBuffExecute_d__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700482C RID: 18476
			// (get) Token: 0x0600DE1D RID: 56861 RVA: 0x0035C308 File Offset: 0x0035A508
			// (set) Token: 0x0600DE1E RID: 56862 RVA: 0x000769D8 File Offset: 0x00074BD8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700482D RID: 18477
			// (get) Token: 0x0600DE1F RID: 56863 RVA: 0x0035C330 File Offset: 0x0035A530
			// (set) Token: 0x0600DE20 RID: 56864 RVA: 0x000769F3 File Offset: 0x00074BF3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700482E RID: 18478
			// (get) Token: 0x0600DE21 RID: 56865 RVA: 0x0035C360 File Offset: 0x0035A560
			// (set) Token: 0x0600DE22 RID: 56866 RVA: 0x00076A12 File Offset: 0x00074C12
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700482F RID: 18479
			// (get) Token: 0x0600DE23 RID: 56867 RVA: 0x0035C390 File Offset: 0x0035A590
			// (set) Token: 0x0600DE24 RID: 56868 RVA: 0x00076A31 File Offset: 0x00074C31
			public unsafe Spell_TotetsuYuuma __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_TotetsuYuuma>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004830 RID: 18480
			// (get) Token: 0x0600DE25 RID: 56869 RVA: 0x0035C3C0 File Offset: 0x0035A5C0
			// (set) Token: 0x0600DE26 RID: 56870 RVA: 0x00076A50 File Offset: 0x00074C50
			public unsafe Spell_TotetsuYuuma.__c__DisplayClass15_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_TotetsuYuuma.__c__DisplayClass15_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004831 RID: 18481
			// (get) Token: 0x0600DE27 RID: 56871 RVA: 0x0035C3F0 File Offset: 0x0035A5F0
			// (set) Token: 0x0600DE28 RID: 56872 RVA: 0x00076A6F File Offset: 0x00074C6F
			public unsafe List<GameObject> _eatingSprite_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr__eatingSprite_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_TotetsuYuuma._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr__eatingSprite_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E33 RID: 36403
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E34 RID: 36404
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E35 RID: 36405
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008E36 RID: 36406
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E37 RID: 36407
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008E38 RID: 36408
			private static readonly IntPtr NativeFieldInfoPtr__eatingSprite_5__2;

			// Token: 0x04008E39 RID: 36409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E3A RID: 36410
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E3B RID: 36411
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E3C RID: 36412
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E3D RID: 36413
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E3E RID: 36414
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
