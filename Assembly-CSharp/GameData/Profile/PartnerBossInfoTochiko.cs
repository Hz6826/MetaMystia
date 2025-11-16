using System;
using Common.CharacterUtility;
using DayScene.Input;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x0200031D RID: 797
	public class PartnerBossInfoTochiko : PartnerBossInfo
	{
		// Token: 0x06005E88 RID: 24200 RVA: 0x001D8B48 File Offset: 0x001D6D48
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerBossInfoTochiko()
		{
			Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerBossInfoTochiko");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr);
			PartnerBossInfoTochiko.NativeFieldInfoPtr_MAX_THUNDER_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "MAX_THUNDER_NUM");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "thunderWarning");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "thunderEffect");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_notEffectiveEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "notEffectiveEffect");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_teleportEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "teleportEffect");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "thunderInterval");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "thunderDelay");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "thunderRadius");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_stunDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "stunDuration");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "blinkDuration");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_teleportRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "teleportRate");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "thunderSFX");
			PartnerBossInfoTochiko.NativeFieldInfoPtr_hitAunnSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "hitAunnSFX");
			PartnerBossInfoTochiko.NativeMethodInfoPtr_MoveCharacter_Public_Virtual_Void_AStarInputGeneratorComponent_TileManager_Vector3Int_Vector3_CharacterRotation_Action_PartnerManager_Boolean_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, 100682712);
			PartnerBossInfoTochiko.NativeMethodInfoPtr_ExternalStop_Public_Virtual_Void_AStarInputGeneratorComponent_PartnerManager_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, 100682713);
			PartnerBossInfoTochiko.NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, 100682714);
			PartnerBossInfoTochiko.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, 100682715);
			PartnerBossInfoTochiko.NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, 100682716);
			PartnerBossInfoTochiko.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, 100682717);
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x001D8CF4 File Offset: 0x001D6EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234669, XrefRangeEnd = 234735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveCharacter(AStarInputGeneratorComponent controlledCharacter, TileManager tileManager, Vector3Int dest, Vector3 extraOffset, DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation, Action onArrivalCallback, PartnerManager manager, bool useCollision, ref Il2CppSystem.Object additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlledCharacter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tileManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onArrivalRotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onArrivalCallback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCollision;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoTochiko.NativeMethodInfoPtr_MoveCharacter_Public_Virtual_Void_AStarInputGeneratorComponent_TileManager_Vector3Int_Vector3_CharacterRotation_Action_PartnerManager_Boolean_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			additionalData = ((intPtr4 == 0) ? null : new Il2CppSystem.Object(intPtr4));
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x001D8DDC File Offset: 0x001D6FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234735, XrefRangeEnd = 234744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExternalStop(AStarInputGeneratorComponent controlledCharacter, PartnerManager manager, ref Il2CppSystem.Object partnerMovementAdditionData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlledCharacter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(partnerMovementAdditionData);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoTochiko.NativeMethodInfoPtr_ExternalStop_Public_Virtual_Void_AStarInputGeneratorComponent_PartnerManager_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			partnerMovementAdditionData = ((intPtr4 == 0) ? null : new Il2CppSystem.Object(intPtr4));
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x001D8E64 File Offset: 0x001D7064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234744, XrefRangeEnd = 234764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BossSpecialAbilityPreLoad(PartnerBase currentPartner, EventManager eventManager, PartnerManager manager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPartner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoTochiko.NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x001D8EE8 File Offset: 0x001D70E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234764, XrefRangeEnd = 234769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &doNotCostIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoTochiko.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x001D8F70 File Offset: 0x001D7170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234769, XrefRangeEnd = 234774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetBossSpecialSkill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoTochiko.NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x001D8FB4 File Offset: 0x001D71B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234774, XrefRangeEnd = 234775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerBossInfoTochiko() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x000338D2 File Offset: 0x00031AD2
		public PartnerBossInfoTochiko(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06005E90 RID: 24208 RVA: 0x001D8FF0 File Offset: 0x001D71F0
		// (set) Token: 0x06005E91 RID: 24209 RVA: 0x000338DB File Offset: 0x00031ADB
		public unsafe static int MAX_THUNDER_NUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoTochiko.NativeFieldInfoPtr_MAX_THUNDER_NUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoTochiko.NativeFieldInfoPtr_MAX_THUNDER_NUM, (void*)(&value));
			}
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06005E92 RID: 24210 RVA: 0x001D900C File Offset: 0x001D720C
		// (set) Token: 0x06005E93 RID: 24211 RVA: 0x000338E9 File Offset: 0x00031AE9
		public unsafe GameObject thunderWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06005E94 RID: 24212 RVA: 0x001D903C File Offset: 0x001D723C
		// (set) Token: 0x06005E95 RID: 24213 RVA: 0x00033908 File Offset: 0x00031B08
		public unsafe GameObject thunderEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06005E96 RID: 24214 RVA: 0x001D906C File Offset: 0x001D726C
		// (set) Token: 0x06005E97 RID: 24215 RVA: 0x00033927 File Offset: 0x00031B27
		public unsafe GameObject notEffectiveEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_notEffectiveEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_notEffectiveEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06005E98 RID: 24216 RVA: 0x001D909C File Offset: 0x001D729C
		// (set) Token: 0x06005E99 RID: 24217 RVA: 0x00033946 File Offset: 0x00031B46
		public unsafe GameObject teleportEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_teleportEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_teleportEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06005E9A RID: 24218 RVA: 0x001D90CC File Offset: 0x001D72CC
		// (set) Token: 0x06005E9B RID: 24219 RVA: 0x00033965 File Offset: 0x00031B65
		public unsafe int thunderInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderInterval)) = value;
			}
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06005E9C RID: 24220 RVA: 0x001D90F4 File Offset: 0x001D72F4
		// (set) Token: 0x06005E9D RID: 24221 RVA: 0x00033980 File Offset: 0x00031B80
		public unsafe int thunderDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderDelay)) = value;
			}
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06005E9E RID: 24222 RVA: 0x001D911C File Offset: 0x001D731C
		// (set) Token: 0x06005E9F RID: 24223 RVA: 0x0003399B File Offset: 0x00031B9B
		public unsafe int thunderRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderRadius)) = value;
			}
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x06005EA0 RID: 24224 RVA: 0x001D9144 File Offset: 0x001D7344
		// (set) Token: 0x06005EA1 RID: 24225 RVA: 0x000339B6 File Offset: 0x00031BB6
		public unsafe int stunDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_stunDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_stunDuration)) = value;
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06005EA2 RID: 24226 RVA: 0x001D916C File Offset: 0x001D736C
		// (set) Token: 0x06005EA3 RID: 24227 RVA: 0x000339D1 File Offset: 0x00031BD1
		public unsafe float blinkDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_blinkDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_blinkDuration)) = value;
			}
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x06005EA4 RID: 24228 RVA: 0x001D9194 File Offset: 0x001D7394
		// (set) Token: 0x06005EA5 RID: 24229 RVA: 0x000339EC File Offset: 0x00031BEC
		public unsafe float teleportRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_teleportRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_teleportRate)) = value;
			}
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06005EA6 RID: 24230 RVA: 0x001D91BC File Offset: 0x001D73BC
		// (set) Token: 0x06005EA7 RID: 24231 RVA: 0x00033A07 File Offset: 0x00031C07
		public unsafe AudioClip thunderSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_thunderSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06005EA8 RID: 24232 RVA: 0x001D91EC File Offset: 0x001D73EC
		// (set) Token: 0x06005EA9 RID: 24233 RVA: 0x00033A26 File Offset: 0x00031C26
		public unsafe AudioClip hitAunnSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_hitAunnSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.NativeFieldInfoPtr_hitAunnSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E87 RID: 16007
		private static readonly IntPtr NativeFieldInfoPtr_MAX_THUNDER_NUM;

		// Token: 0x04003E88 RID: 16008
		private static readonly IntPtr NativeFieldInfoPtr_thunderWarning;

		// Token: 0x04003E89 RID: 16009
		private static readonly IntPtr NativeFieldInfoPtr_thunderEffect;

		// Token: 0x04003E8A RID: 16010
		private static readonly IntPtr NativeFieldInfoPtr_notEffectiveEffect;

		// Token: 0x04003E8B RID: 16011
		private static readonly IntPtr NativeFieldInfoPtr_teleportEffect;

		// Token: 0x04003E8C RID: 16012
		private static readonly IntPtr NativeFieldInfoPtr_thunderInterval;

		// Token: 0x04003E8D RID: 16013
		private static readonly IntPtr NativeFieldInfoPtr_thunderDelay;

		// Token: 0x04003E8E RID: 16014
		private static readonly IntPtr NativeFieldInfoPtr_thunderRadius;

		// Token: 0x04003E8F RID: 16015
		private static readonly IntPtr NativeFieldInfoPtr_stunDuration;

		// Token: 0x04003E90 RID: 16016
		private static readonly IntPtr NativeFieldInfoPtr_blinkDuration;

		// Token: 0x04003E91 RID: 16017
		private static readonly IntPtr NativeFieldInfoPtr_teleportRate;

		// Token: 0x04003E92 RID: 16018
		private static readonly IntPtr NativeFieldInfoPtr_thunderSFX;

		// Token: 0x04003E93 RID: 16019
		private static readonly IntPtr NativeFieldInfoPtr_hitAunnSFX;

		// Token: 0x04003E94 RID: 16020
		private static readonly IntPtr NativeMethodInfoPtr_MoveCharacter_Public_Virtual_Void_AStarInputGeneratorComponent_TileManager_Vector3Int_Vector3_CharacterRotation_Action_PartnerManager_Boolean_byref_Object_0;

		// Token: 0x04003E95 RID: 16021
		private static readonly IntPtr NativeMethodInfoPtr_ExternalStop_Public_Virtual_Void_AStarInputGeneratorComponent_PartnerManager_byref_Object_0;

		// Token: 0x04003E96 RID: 16022
		private static readonly IntPtr NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003E97 RID: 16023
		private static readonly IntPtr NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0;

		// Token: 0x04003E98 RID: 16024
		private static readonly IntPtr NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_String_0;

		// Token: 0x04003E99 RID: 16025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D46 RID: 3398
		[ObfuscatedName("GameData.Profile.PartnerBossInfoTochiko+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F3E1 RID: 62433 RVA: 0x0039B4E8 File Offset: 0x003996E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr);
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, "startPosition");
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_controlledCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, "controlledCharacter");
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_mainRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, "mainRenderer");
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_faceRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, "faceRenderer");
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, "targetPosition");
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_onArrivalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, "onArrivalRotation");
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_onArrivalCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, "onArrivalCallback");
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, 100682718);
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, 100682719);
				PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeMethodInfoPtr__MoveCharacter_b__5_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, 100682720);
			}

			// Token: 0x0600F3E2 RID: 62434 RVA: 0x0039B5F0 File Offset: 0x003997F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3E3 RID: 62435 RVA: 0x0039B62C File Offset: 0x0039982C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234567, XrefRangeEnd = 234572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F3E4 RID: 62436 RVA: 0x0039B66C File Offset: 0x0039986C
			[CallerCount(0)]
			public unsafe Vector3 _MoveCharacter_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeMethodInfoPtr__MoveCharacter_b__5_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3E5 RID: 62437 RVA: 0x00082ED7 File Offset: 0x000810D7
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F42 RID: 20290
			// (get) Token: 0x0600F3E6 RID: 62438 RVA: 0x0039B6A8 File Offset: 0x003998A8
			// (set) Token: 0x0600F3E7 RID: 62439 RVA: 0x00082EE0 File Offset: 0x000810E0
			public unsafe PartnerBossInfoTochiko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoTochiko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F43 RID: 20291
			// (get) Token: 0x0600F3E8 RID: 62440 RVA: 0x0039B6D8 File Offset: 0x003998D8
			// (set) Token: 0x0600F3E9 RID: 62441 RVA: 0x00082EFF File Offset: 0x000810FF
			public unsafe Vector3 startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x17004F44 RID: 20292
			// (get) Token: 0x0600F3EA RID: 62442 RVA: 0x0039B700 File Offset: 0x00399900
			// (set) Token: 0x0600F3EB RID: 62443 RVA: 0x00082F1A File Offset: 0x0008111A
			public unsafe AStarInputGeneratorComponent controlledCharacter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_controlledCharacter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_controlledCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F45 RID: 20293
			// (get) Token: 0x0600F3EC RID: 62444 RVA: 0x0039B730 File Offset: 0x00399930
			// (set) Token: 0x0600F3ED RID: 62445 RVA: 0x00082F39 File Offset: 0x00081139
			public unsafe SpriteRenderer mainRenderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_mainRenderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_mainRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F46 RID: 20294
			// (get) Token: 0x0600F3EE RID: 62446 RVA: 0x0039B760 File Offset: 0x00399960
			// (set) Token: 0x0600F3EF RID: 62447 RVA: 0x00082F58 File Offset: 0x00081158
			public unsafe SpriteRenderer faceRenderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_faceRenderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_faceRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F47 RID: 20295
			// (get) Token: 0x0600F3F0 RID: 62448 RVA: 0x0039B790 File Offset: 0x00399990
			// (set) Token: 0x0600F3F1 RID: 62449 RVA: 0x00082F77 File Offset: 0x00081177
			public unsafe Vector3 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x17004F48 RID: 20296
			// (get) Token: 0x0600F3F2 RID: 62450 RVA: 0x0039B7B8 File Offset: 0x003999B8
			// (set) Token: 0x0600F3F3 RID: 62451 RVA: 0x00082F92 File Offset: 0x00081192
			public unsafe DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_onArrivalRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_onArrivalRotation)) = value;
				}
			}

			// Token: 0x17004F49 RID: 20297
			// (get) Token: 0x0600F3F4 RID: 62452 RVA: 0x0039B7E0 File Offset: 0x003999E0
			// (set) Token: 0x0600F3F5 RID: 62453 RVA: 0x00082FAD File Offset: 0x000811AD
			public unsafe Action onArrivalCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_onArrivalCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.NativeFieldInfoPtr_onArrivalCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B51 RID: 39761
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009B52 RID: 39762
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x04009B53 RID: 39763
			private static readonly IntPtr NativeFieldInfoPtr_controlledCharacter;

			// Token: 0x04009B54 RID: 39764
			private static readonly IntPtr NativeFieldInfoPtr_mainRenderer;

			// Token: 0x04009B55 RID: 39765
			private static readonly IntPtr NativeFieldInfoPtr_faceRenderer;

			// Token: 0x04009B56 RID: 39766
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04009B57 RID: 39767
			private static readonly IntPtr NativeFieldInfoPtr_onArrivalRotation;

			// Token: 0x04009B58 RID: 39768
			private static readonly IntPtr NativeFieldInfoPtr_onArrivalCallback;

			// Token: 0x04009B59 RID: 39769
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B5A RID: 39770
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009B5B RID: 39771
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacter_b__5_Internal_Vector3_0;

			// Token: 0x02001097 RID: 4247
			[ObfuscatedName("GameData.Profile.PartnerBossInfoTochiko+<>c__DisplayClass13_0+<<MoveCharacter>g__OnBlinkDelay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012160 RID: 74080 RVA: 0x00420D8C File Offset: 0x0041EF8C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique()
				{
					Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0>.NativeClassPtr, "<<MoveCharacter>g__OnBlinkDelay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr);
					PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>1__state");
					PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>2__current");
					PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>4__this");
					PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__startEffect_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<startEffect>5__2");
					PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100682721);
					PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100682722);
					PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100682723);
					PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100682724);
					PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100682725);
					PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100682726);
				}

				// Token: 0x06012161 RID: 74081 RVA: 0x00420E80 File Offset: 0x0041F080
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012162 RID: 74082 RVA: 0x00420EC8 File Offset: 0x0041F0C8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012163 RID: 74083 RVA: 0x00420EFC File Offset: 0x0041F0FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234506, XrefRangeEnd = 234561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E71 RID: 24177
				// (get) Token: 0x06012164 RID: 74084 RVA: 0x00420F38 File Offset: 0x0041F138
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012165 RID: 74085 RVA: 0x00420F78 File Offset: 0x0041F178
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234561, XrefRangeEnd = 234567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E72 RID: 24178
				// (get) Token: 0x06012166 RID: 74086 RVA: 0x00420FAC File Offset: 0x0041F1AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012167 RID: 74087 RVA: 0x0009D20F File Offset: 0x0009B40F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E6D RID: 24173
				// (get) Token: 0x06012168 RID: 74088 RVA: 0x00420FEC File Offset: 0x0041F1EC
				// (set) Token: 0x06012169 RID: 74089 RVA: 0x0009D218 File Offset: 0x0009B418
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E6E RID: 24174
				// (get) Token: 0x0601216A RID: 74090 RVA: 0x00421014 File Offset: 0x0041F214
				// (set) Token: 0x0601216B RID: 74091 RVA: 0x0009D233 File Offset: 0x0009B433
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E6F RID: 24175
				// (get) Token: 0x0601216C RID: 74092 RVA: 0x00421044 File Offset: 0x0041F244
				// (set) Token: 0x0601216D RID: 74093 RVA: 0x0009D252 File Offset: 0x0009B452
				public unsafe PartnerBossInfoTochiko.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoTochiko.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E70 RID: 24176
				// (get) Token: 0x0601216E RID: 74094 RVA: 0x00421074 File Offset: 0x0041F274
				// (set) Token: 0x0601216F RID: 74095 RVA: 0x0009D271 File Offset: 0x0009B471
				public unsafe GameObject _startEffect_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__startEffect_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__startEffect_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B742 RID: 46914
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B743 RID: 46915
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B744 RID: 46916
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B745 RID: 46917
				private static readonly IntPtr NativeFieldInfoPtr__startEffect_5__2;

				// Token: 0x0400B746 RID: 46918
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B747 RID: 46919
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B748 RID: 46920
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B749 RID: 46921
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B74A RID: 46922
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B74B RID: 46923
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D47 RID: 3399
		[ObfuscatedName("GameData.Profile.PartnerBossInfoTochiko+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F3F6 RID: 62454 RVA: 0x0039B810 File Offset: 0x00399A10
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr);
				PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, "<>9");
				PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, "<>9__13_1");
				PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, "<>9__13_2");
				PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, "<>9__13_3");
				PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, "<>9__13_4");
				PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, "<>9__13_6");
				PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, "<>9__13_7");
				PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, "<>9__14_0");
				PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, "<>9__14_1");
				PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, 100682728);
				PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_1_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, 100682729);
				PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_2_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, 100682730);
				PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_3_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, 100682731);
				PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_4_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, 100682732);
				PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_6_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, 100682733);
				PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_7_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, 100682734);
				PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__ExternalStop_b__14_0_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, 100682735);
				PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__ExternalStop_b__14_1_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr, 100682736);
			}

			// Token: 0x0600F3F7 RID: 62455 RVA: 0x0039B9A4 File Offset: 0x00399BA4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3F8 RID: 62456 RVA: 0x0039B9E0 File Offset: 0x00399BE0
			[CallerCount(0)]
			public unsafe float _MoveCharacter_b__13_1(float a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_1_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3F9 RID: 62457 RVA: 0x0039BA2C File Offset: 0x00399C2C
			[CallerCount(0)]
			public unsafe float _MoveCharacter_b__13_2(float a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_2_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3FA RID: 62458 RVA: 0x0039BA78 File Offset: 0x00399C78
			[CallerCount(0)]
			public unsafe float _MoveCharacter_b__13_3(float a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_3_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3FB RID: 62459 RVA: 0x0039BAC4 File Offset: 0x00399CC4
			[CallerCount(0)]
			public unsafe float _MoveCharacter_b__13_4(float a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_4_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3FC RID: 62460 RVA: 0x0039BB10 File Offset: 0x00399D10
			[CallerCount(0)]
			public unsafe float _MoveCharacter_b__13_6(float a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_6_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3FD RID: 62461 RVA: 0x0039BB5C File Offset: 0x00399D5C
			[CallerCount(0)]
			public unsafe float _MoveCharacter_b__13_7(float a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__MoveCharacter_b__13_7_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3FE RID: 62462 RVA: 0x0039BBA8 File Offset: 0x00399DA8
			[CallerCount(0)]
			public unsafe float _ExternalStop_b__14_0(float a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__ExternalStop_b__14_0_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3FF RID: 62463 RVA: 0x0039BBF4 File Offset: 0x00399DF4
			[CallerCount(0)]
			public unsafe float _ExternalStop_b__14_1(float a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c.NativeMethodInfoPtr__ExternalStop_b__14_1_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F400 RID: 62464 RVA: 0x00082FCC File Offset: 0x000811CC
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F4A RID: 20298
			// (get) Token: 0x0600F401 RID: 62465 RVA: 0x0039BC40 File Offset: 0x00399E40
			// (set) Token: 0x0600F402 RID: 62466 RVA: 0x00082FD5 File Offset: 0x000811D5
			public unsafe static PartnerBossInfoTochiko.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoTochiko.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F4B RID: 20299
			// (get) Token: 0x0600F403 RID: 62467 RVA: 0x0039BC68 File Offset: 0x00399E68
			// (set) Token: 0x0600F404 RID: 62468 RVA: 0x00082FE7 File Offset: 0x000811E7
			public unsafe static Func<float, float> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F4C RID: 20300
			// (get) Token: 0x0600F405 RID: 62469 RVA: 0x0039BC90 File Offset: 0x00399E90
			// (set) Token: 0x0600F406 RID: 62470 RVA: 0x00082FF9 File Offset: 0x000811F9
			public unsafe static Func<float, float> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F4D RID: 20301
			// (get) Token: 0x0600F407 RID: 62471 RVA: 0x0039BCB8 File Offset: 0x00399EB8
			// (set) Token: 0x0600F408 RID: 62472 RVA: 0x0008300B File Offset: 0x0008120B
			public unsafe static Func<float, float> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F4E RID: 20302
			// (get) Token: 0x0600F409 RID: 62473 RVA: 0x0039BCE0 File Offset: 0x00399EE0
			// (set) Token: 0x0600F40A RID: 62474 RVA: 0x0008301D File Offset: 0x0008121D
			public unsafe static Func<float, float> __9__13_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F4F RID: 20303
			// (get) Token: 0x0600F40B RID: 62475 RVA: 0x0039BD08 File Offset: 0x00399F08
			// (set) Token: 0x0600F40C RID: 62476 RVA: 0x0008302F File Offset: 0x0008122F
			public unsafe static Func<float, float> __9__13_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F50 RID: 20304
			// (get) Token: 0x0600F40D RID: 62477 RVA: 0x0039BD30 File Offset: 0x00399F30
			// (set) Token: 0x0600F40E RID: 62478 RVA: 0x00083041 File Offset: 0x00081241
			public unsafe static Func<float, float> __9__13_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__13_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F51 RID: 20305
			// (get) Token: 0x0600F40F RID: 62479 RVA: 0x0039BD58 File Offset: 0x00399F58
			// (set) Token: 0x0600F410 RID: 62480 RVA: 0x00083053 File Offset: 0x00081253
			public unsafe static Func<float, float> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F52 RID: 20306
			// (get) Token: 0x0600F411 RID: 62481 RVA: 0x0039BD80 File Offset: 0x00399F80
			// (set) Token: 0x0600F412 RID: 62482 RVA: 0x00083065 File Offset: 0x00081265
			public unsafe static Func<float, float> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoTochiko.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B5C RID: 39772
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009B5D RID: 39773
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04009B5E RID: 39774
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x04009B5F RID: 39775
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x04009B60 RID: 39776
			private static readonly IntPtr NativeFieldInfoPtr___9__13_4;

			// Token: 0x04009B61 RID: 39777
			private static readonly IntPtr NativeFieldInfoPtr___9__13_6;

			// Token: 0x04009B62 RID: 39778
			private static readonly IntPtr NativeFieldInfoPtr___9__13_7;

			// Token: 0x04009B63 RID: 39779
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04009B64 RID: 39780
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04009B65 RID: 39781
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B66 RID: 39782
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacter_b__13_1_Internal_Single_Single_0;

			// Token: 0x04009B67 RID: 39783
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacter_b__13_2_Internal_Single_Single_0;

			// Token: 0x04009B68 RID: 39784
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacter_b__13_3_Internal_Single_Single_0;

			// Token: 0x04009B69 RID: 39785
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacter_b__13_4_Internal_Single_Single_0;

			// Token: 0x04009B6A RID: 39786
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacter_b__13_6_Internal_Single_Single_0;

			// Token: 0x04009B6B RID: 39787
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacter_b__13_7_Internal_Single_Single_0;

			// Token: 0x04009B6C RID: 39788
			private static readonly IntPtr NativeMethodInfoPtr__ExternalStop_b__14_0_Internal_Single_Single_0;

			// Token: 0x04009B6D RID: 39789
			private static readonly IntPtr NativeMethodInfoPtr__ExternalStop_b__14_1_Internal_Single_Single_0;
		}

		// Token: 0x02000D48 RID: 3400
		[ObfuscatedName("GameData.Profile.PartnerBossInfoTochiko+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F413 RID: 62483 RVA: 0x0039BDA8 File Offset: 0x00399FA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0>.NativeClassPtr);
				PartnerBossInfoTochiko.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				PartnerBossInfoTochiko.__c__DisplayClass15_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0>.NativeClassPtr, "eventManager");
				PartnerBossInfoTochiko.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0>.NativeClassPtr, 100682737);
				PartnerBossInfoTochiko.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0>.NativeClassPtr, 100682738);
			}

			// Token: 0x0600F414 RID: 62484 RVA: 0x0039BE24 File Offset: 0x0039A024
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F415 RID: 62485 RVA: 0x0039BE60 File Offset: 0x0039A060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234658, XrefRangeEnd = 234663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F416 RID: 62486 RVA: 0x00083077 File Offset: 0x00081277
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F53 RID: 20307
			// (get) Token: 0x0600F417 RID: 62487 RVA: 0x0039BEA0 File Offset: 0x0039A0A0
			// (set) Token: 0x0600F418 RID: 62488 RVA: 0x00083080 File Offset: 0x00081280
			public unsafe PartnerBossInfoTochiko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoTochiko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F54 RID: 20308
			// (get) Token: 0x0600F419 RID: 62489 RVA: 0x0039BED0 File Offset: 0x0039A0D0
			// (set) Token: 0x0600F41A RID: 62490 RVA: 0x0008309F File Offset: 0x0008129F
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B6E RID: 39790
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009B6F RID: 39791
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009B70 RID: 39792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B71 RID: 39793
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001098 RID: 4248
			[ObfuscatedName("GameData.Profile.PartnerBossInfoTochiko+<>c__DisplayClass15_0+<<BossSpecialAbilityPreLoad>g__SpawnThunder|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012170 RID: 74096 RVA: 0x004210A4 File Offset: 0x0041F2A4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique()
				{
					Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0>.NativeClassPtr, "<<BossSpecialAbilityPreLoad>g__SpawnThunder|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr);
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, "<>1__state");
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, "<>2__current");
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, "<>4__this");
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, "<>8__1");
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__wait_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, "<wait>5__2");
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__waitForDelay_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, "<waitForDelay>5__3");
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__waitForThunder_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, "<waitForThunder>5__4");
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__successfulHit_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, "<successfulHit>5__5");
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__maxThunderNum_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, "<maxThunderNum>5__6");
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__thunderPosition_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, "<thunderPosition>5__7");
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, 100682739);
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, 100682740);
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, 100682741);
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, 100682742);
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, 100682743);
					PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr, 100682744);
				}

				// Token: 0x06012171 RID: 74097 RVA: 0x00421210 File Offset: 0x0041F410
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012172 RID: 74098 RVA: 0x00421258 File Offset: 0x0041F458
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012173 RID: 74099 RVA: 0x0042128C File Offset: 0x0041F48C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234572, XrefRangeEnd = 234652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E7D RID: 24189
				// (get) Token: 0x06012174 RID: 74100 RVA: 0x004212C8 File Offset: 0x0041F4C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012175 RID: 74101 RVA: 0x00421308 File Offset: 0x0041F508
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234652, XrefRangeEnd = 234658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E7E RID: 24190
				// (get) Token: 0x06012176 RID: 74102 RVA: 0x0042133C File Offset: 0x0041F53C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012177 RID: 74103 RVA: 0x0009D290 File Offset: 0x0009B490
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E73 RID: 24179
				// (get) Token: 0x06012178 RID: 74104 RVA: 0x0042137C File Offset: 0x0041F57C
				// (set) Token: 0x06012179 RID: 74105 RVA: 0x0009D299 File Offset: 0x0009B499
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E74 RID: 24180
				// (get) Token: 0x0601217A RID: 74106 RVA: 0x004213A4 File Offset: 0x0041F5A4
				// (set) Token: 0x0601217B RID: 74107 RVA: 0x0009D2B4 File Offset: 0x0009B4B4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E75 RID: 24181
				// (get) Token: 0x0601217C RID: 74108 RVA: 0x004213D4 File Offset: 0x0041F5D4
				// (set) Token: 0x0601217D RID: 74109 RVA: 0x0009D2D3 File Offset: 0x0009B4D3
				public unsafe PartnerBossInfoTochiko.__c__DisplayClass15_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoTochiko.__c__DisplayClass15_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E76 RID: 24182
				// (get) Token: 0x0601217E RID: 74110 RVA: 0x00421404 File Offset: 0x0041F604
				// (set) Token: 0x0601217F RID: 74111 RVA: 0x0009D2F2 File Offset: 0x0009B4F2
				public unsafe PartnerBossInfoTochiko.__c__DisplayClass15_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoTochiko.__c__DisplayClass15_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E77 RID: 24183
				// (get) Token: 0x06012180 RID: 74112 RVA: 0x00421434 File Offset: 0x0041F634
				// (set) Token: 0x06012181 RID: 74113 RVA: 0x0009D311 File Offset: 0x0009B511
				public unsafe WaitForSeconds _wait_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__wait_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__wait_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E78 RID: 24184
				// (get) Token: 0x06012182 RID: 74114 RVA: 0x00421464 File Offset: 0x0041F664
				// (set) Token: 0x06012183 RID: 74115 RVA: 0x0009D330 File Offset: 0x0009B530
				public unsafe WaitForSeconds _waitForDelay_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__waitForDelay_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__waitForDelay_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E79 RID: 24185
				// (get) Token: 0x06012184 RID: 74116 RVA: 0x00421494 File Offset: 0x0041F694
				// (set) Token: 0x06012185 RID: 74117 RVA: 0x0009D34F File Offset: 0x0009B54F
				public unsafe WaitForSeconds _waitForThunder_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__waitForThunder_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__waitForThunder_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E7A RID: 24186
				// (get) Token: 0x06012186 RID: 74118 RVA: 0x004214C4 File Offset: 0x0041F6C4
				// (set) Token: 0x06012187 RID: 74119 RVA: 0x0009D36E File Offset: 0x0009B56E
				public unsafe bool _successfulHit_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__successfulHit_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__successfulHit_5__5)) = value;
					}
				}

				// Token: 0x17005E7B RID: 24187
				// (get) Token: 0x06012188 RID: 74120 RVA: 0x004214EC File Offset: 0x0041F6EC
				// (set) Token: 0x06012189 RID: 74121 RVA: 0x0009D389 File Offset: 0x0009B589
				public unsafe int _maxThunderNum_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__maxThunderNum_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__maxThunderNum_5__6)) = value;
					}
				}

				// Token: 0x17005E7C RID: 24188
				// (get) Token: 0x0601218A RID: 74122 RVA: 0x00421514 File Offset: 0x0041F714
				// (set) Token: 0x0601218B RID: 74123 RVA: 0x0009D3A4 File Offset: 0x0009B5A4
				public unsafe Il2CppStructArray<Vector2Int> _thunderPosition_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__thunderPosition_5__7);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaBoWaVeInWaObObUnique.NativeFieldInfoPtr__thunderPosition_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B74C RID: 46924
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B74D RID: 46925
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B74E RID: 46926
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B74F RID: 46927
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B750 RID: 46928
				private static readonly IntPtr NativeFieldInfoPtr__wait_5__2;

				// Token: 0x0400B751 RID: 46929
				private static readonly IntPtr NativeFieldInfoPtr__waitForDelay_5__3;

				// Token: 0x0400B752 RID: 46930
				private static readonly IntPtr NativeFieldInfoPtr__waitForThunder_5__4;

				// Token: 0x0400B753 RID: 46931
				private static readonly IntPtr NativeFieldInfoPtr__successfulHit_5__5;

				// Token: 0x0400B754 RID: 46932
				private static readonly IntPtr NativeFieldInfoPtr__maxThunderNum_5__6;

				// Token: 0x0400B755 RID: 46933
				private static readonly IntPtr NativeFieldInfoPtr__thunderPosition_5__7;

				// Token: 0x0400B756 RID: 46934
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B757 RID: 46935
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B758 RID: 46936
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B759 RID: 46937
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B75A RID: 46938
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B75B RID: 46939
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D49 RID: 3401
		[ObfuscatedName("GameData.Profile.PartnerBossInfoTochiko+<>c__DisplayClass15_1")]
		public sealed class __c__DisplayClass15_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F41B RID: 62491 RVA: 0x0039BF00 File Offset: 0x0039A100
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_1()
			{
				Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoTochiko>.NativeClassPtr, "<>c__DisplayClass15_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr);
				PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr_focusPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr, "focusPosition");
				PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr_playerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr, "playerTransform");
				PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr, "CS$<>8__locals1");
				PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr, "<>9__3");
				PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr, 100682745);
				PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__1_Internal_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr, 100682746);
				PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__2_Internal_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr, 100682747);
				PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr, 100682748);
			}

			// Token: 0x0600F41C RID: 62492 RVA: 0x0039BFCC File Offset: 0x0039A1CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoTochiko.__c__DisplayClass15_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F41D RID: 62493 RVA: 0x0039C008 File Offset: 0x0039A208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234663, XrefRangeEnd = 234665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BossSpecialAbilityPreLoad_b__1(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__1_Internal_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F41E RID: 62494 RVA: 0x0039C048 File Offset: 0x0039A248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234665, XrefRangeEnd = 234666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BossSpecialAbilityPreLoad_b__2(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__2_Internal_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F41F RID: 62495 RVA: 0x0039C094 File Offset: 0x0039A294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234666, XrefRangeEnd = 234669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BossSpecialAbilityPreLoad_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F420 RID: 62496 RVA: 0x000830BE File Offset: 0x000812BE
			public __c__DisplayClass15_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F55 RID: 20309
			// (get) Token: 0x0600F421 RID: 62497 RVA: 0x0039C0C8 File Offset: 0x0039A2C8
			// (set) Token: 0x0600F422 RID: 62498 RVA: 0x000830C7 File Offset: 0x000812C7
			public unsafe List<Vector3> focusPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr_focusPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr_focusPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F56 RID: 20310
			// (get) Token: 0x0600F423 RID: 62499 RVA: 0x0039C0F8 File Offset: 0x0039A2F8
			// (set) Token: 0x0600F424 RID: 62500 RVA: 0x000830E6 File Offset: 0x000812E6
			public unsafe Transform playerTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr_playerTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr_playerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F57 RID: 20311
			// (get) Token: 0x0600F425 RID: 62501 RVA: 0x0039C128 File Offset: 0x0039A328
			// (set) Token: 0x0600F426 RID: 62502 RVA: 0x00083105 File Offset: 0x00081305
			public unsafe PartnerBossInfoTochiko.__c__DisplayClass15_0 field_Public___c__DisplayClass15_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoTochiko.__c__DisplayClass15_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F58 RID: 20312
			// (get) Token: 0x0600F427 RID: 62503 RVA: 0x0039C158 File Offset: 0x0039A358
			// (set) Token: 0x0600F428 RID: 62504 RVA: 0x00083124 File Offset: 0x00081324
			public unsafe Action __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoTochiko.__c__DisplayClass15_1.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B72 RID: 39794
			private static readonly IntPtr NativeFieldInfoPtr_focusPosition;

			// Token: 0x04009B73 RID: 39795
			private static readonly IntPtr NativeFieldInfoPtr_playerTransform;

			// Token: 0x04009B74 RID: 39796
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0;

			// Token: 0x04009B75 RID: 39797
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04009B76 RID: 39798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B77 RID: 39799
			private static readonly IntPtr NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__1_Internal_Void_Vector2Int_0;

			// Token: 0x04009B78 RID: 39800
			private static readonly IntPtr NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__2_Internal_Boolean_Vector3_0;

			// Token: 0x04009B79 RID: 39801
			private static readonly IntPtr NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__3_Internal_Void_0;
		}
	}
}
