using System;
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
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x0200031B RID: 795
	public class PartnerBossInfoFuto : PartnerBossInfo
	{
		// Token: 0x06005E48 RID: 24136 RVA: 0x001D7F70 File Offset: 0x001D6170
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerBossInfoFuto()
		{
			Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerBossInfoFuto");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr);
			PartnerBossInfoFuto.NativeFieldInfoPtr_throwFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "throwFood");
			PartnerBossInfoFuto.NativeFieldInfoPtr_throwSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "throwSFX");
			PartnerBossInfoFuto.NativeFieldInfoPtr_hitSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "hitSFX");
			PartnerBossInfoFuto.NativeFieldInfoPtr_launchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "launchSpeed");
			PartnerBossInfoFuto.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "launchHeight");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireNum");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireInterval");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireDuration");
			PartnerBossInfoFuto.NativeFieldInfoPtr_burnDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "burnDuration");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireRadius");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireEffect");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireExplosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireExplosion");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireExplosionTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireExplosionTray");
			PartnerBossInfoFuto.NativeFieldInfoPtr_firePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "firePlayer");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireEnergy");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireSpawnSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireSpawnSFX");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireContinueSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireContinueSFX");
			PartnerBossInfoFuto.NativeFieldInfoPtr_fireExplosionSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "fireExplosionSFX");
			PartnerBossInfoFuto.NativeFieldInfoPtr_playerBurntSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "playerBurntSFX");
			PartnerBossInfoFuto.NativeMethodInfoPtr_get_PartnerDeliverType_Public_Virtual_get_DeliverType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, 100682642);
			PartnerBossInfoFuto.NativeMethodInfoPtr_get_AdditionalDataRequirement_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, 100682643);
			PartnerBossInfoFuto.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, 100682644);
			PartnerBossInfoFuto.NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, 100682645);
			PartnerBossInfoFuto.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, 100682646);
			PartnerBossInfoFuto.NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, 100682647);
			PartnerBossInfoFuto.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, 100682648);
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06005E49 RID: 24137 RVA: 0x001D81A8 File Offset: 0x001D63A8
		public unsafe override PartnerInfoBase.DeliverType PartnerDeliverType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoFuto.NativeMethodInfoPtr_get_PartnerDeliverType_Public_Virtual_get_DeliverType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06005E4A RID: 24138 RVA: 0x001D81F0 File Offset: 0x001D63F0
		public unsafe override int AdditionalDataRequirement
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoFuto.NativeMethodInfoPtr_get_AdditionalDataRequirement_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x001D8238 File Offset: 0x001D6438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234303, XrefRangeEnd = 234321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoFuto.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x001D82BC File Offset: 0x001D64BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234321, XrefRangeEnd = 234342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BossSpecialAbilityPreLoad(PartnerBase currentPartner, EventManager eventManager, PartnerManager manager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPartner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoFuto.NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x001D8340 File Offset: 0x001D6540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234342, XrefRangeEnd = 234350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &doNotCostIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoFuto.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x001D83C8 File Offset: 0x001D65C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234350, XrefRangeEnd = 234355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetBossSpecialSkill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoFuto.NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x001D840C File Offset: 0x001D660C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerBossInfoFuto() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x00033600 File Offset: 0x00031800
		public PartnerBossInfoFuto(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x06005E51 RID: 24145 RVA: 0x001D8448 File Offset: 0x001D6648
		// (set) Token: 0x06005E52 RID: 24146 RVA: 0x00033609 File Offset: 0x00031809
		public unsafe GameObject throwFood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_throwFood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_throwFood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06005E53 RID: 24147 RVA: 0x001D8478 File Offset: 0x001D6678
		// (set) Token: 0x06005E54 RID: 24148 RVA: 0x00033628 File Offset: 0x00031828
		public unsafe AudioClip throwSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_throwSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_throwSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x06005E55 RID: 24149 RVA: 0x001D84A8 File Offset: 0x001D66A8
		// (set) Token: 0x06005E56 RID: 24150 RVA: 0x00033647 File Offset: 0x00031847
		public unsafe AudioClip hitSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_hitSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_hitSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x06005E57 RID: 24151 RVA: 0x001D84D8 File Offset: 0x001D66D8
		// (set) Token: 0x06005E58 RID: 24152 RVA: 0x00033666 File Offset: 0x00031866
		public unsafe float launchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_launchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_launchSpeed)) = value;
			}
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x06005E59 RID: 24153 RVA: 0x001D8500 File Offset: 0x001D6700
		// (set) Token: 0x06005E5A RID: 24154 RVA: 0x00033681 File Offset: 0x00031881
		public unsafe float launchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_launchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_launchHeight)) = value;
			}
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x06005E5B RID: 24155 RVA: 0x001D8528 File Offset: 0x001D6728
		// (set) Token: 0x06005E5C RID: 24156 RVA: 0x0003369C File Offset: 0x0003189C
		public unsafe int fireNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireNum)) = value;
			}
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06005E5D RID: 24157 RVA: 0x001D8550 File Offset: 0x001D6750
		// (set) Token: 0x06005E5E RID: 24158 RVA: 0x000336B7 File Offset: 0x000318B7
		public unsafe int fireInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireInterval)) = value;
			}
		}

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x06005E5F RID: 24159 RVA: 0x001D8578 File Offset: 0x001D6778
		// (set) Token: 0x06005E60 RID: 24160 RVA: 0x000336D2 File Offset: 0x000318D2
		public unsafe int fireDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireDuration)) = value;
			}
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x06005E61 RID: 24161 RVA: 0x001D85A0 File Offset: 0x001D67A0
		// (set) Token: 0x06005E62 RID: 24162 RVA: 0x000336ED File Offset: 0x000318ED
		public unsafe int burnDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_burnDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_burnDuration)) = value;
			}
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x06005E63 RID: 24163 RVA: 0x001D85C8 File Offset: 0x001D67C8
		// (set) Token: 0x06005E64 RID: 24164 RVA: 0x00033708 File Offset: 0x00031908
		public unsafe float fireRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireRadius)) = value;
			}
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06005E65 RID: 24165 RVA: 0x001D85F0 File Offset: 0x001D67F0
		// (set) Token: 0x06005E66 RID: 24166 RVA: 0x00033723 File Offset: 0x00031923
		public unsafe GameObject fireEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06005E67 RID: 24167 RVA: 0x001D8620 File Offset: 0x001D6820
		// (set) Token: 0x06005E68 RID: 24168 RVA: 0x00033742 File Offset: 0x00031942
		public unsafe GameObject fireExplosion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireExplosion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireExplosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06005E69 RID: 24169 RVA: 0x001D8650 File Offset: 0x001D6850
		// (set) Token: 0x06005E6A RID: 24170 RVA: 0x00033761 File Offset: 0x00031961
		public unsafe GameObject fireExplosionTray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireExplosionTray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireExplosionTray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06005E6B RID: 24171 RVA: 0x001D8680 File Offset: 0x001D6880
		// (set) Token: 0x06005E6C RID: 24172 RVA: 0x00033780 File Offset: 0x00031980
		public unsafe GameObject firePlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_firePlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_firePlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06005E6D RID: 24173 RVA: 0x001D86B0 File Offset: 0x001D68B0
		// (set) Token: 0x06005E6E RID: 24174 RVA: 0x0003379F File Offset: 0x0003199F
		public unsafe GameObject fireEnergy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireEnergy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireEnergy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x06005E6F RID: 24175 RVA: 0x001D86E0 File Offset: 0x001D68E0
		// (set) Token: 0x06005E70 RID: 24176 RVA: 0x000337BE File Offset: 0x000319BE
		public unsafe AudioClip fireSpawnSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireSpawnSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireSpawnSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x06005E71 RID: 24177 RVA: 0x001D8710 File Offset: 0x001D6910
		// (set) Token: 0x06005E72 RID: 24178 RVA: 0x000337DD File Offset: 0x000319DD
		public unsafe AudioClip fireContinueSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireContinueSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireContinueSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x001D8740 File Offset: 0x001D6940
		// (set) Token: 0x06005E74 RID: 24180 RVA: 0x000337FC File Offset: 0x000319FC
		public unsafe AudioClip fireExplosionSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireExplosionSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_fireExplosionSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06005E75 RID: 24181 RVA: 0x001D8770 File Offset: 0x001D6970
		// (set) Token: 0x06005E76 RID: 24182 RVA: 0x0003381B File Offset: 0x00031A1B
		public unsafe AudioClip playerBurntSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_playerBurntSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.NativeFieldInfoPtr_playerBurntSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E63 RID: 15971
		private static readonly IntPtr NativeFieldInfoPtr_throwFood;

		// Token: 0x04003E64 RID: 15972
		private static readonly IntPtr NativeFieldInfoPtr_throwSFX;

		// Token: 0x04003E65 RID: 15973
		private static readonly IntPtr NativeFieldInfoPtr_hitSFX;

		// Token: 0x04003E66 RID: 15974
		private static readonly IntPtr NativeFieldInfoPtr_launchSpeed;

		// Token: 0x04003E67 RID: 15975
		private static readonly IntPtr NativeFieldInfoPtr_launchHeight;

		// Token: 0x04003E68 RID: 15976
		private static readonly IntPtr NativeFieldInfoPtr_fireNum;

		// Token: 0x04003E69 RID: 15977
		private static readonly IntPtr NativeFieldInfoPtr_fireInterval;

		// Token: 0x04003E6A RID: 15978
		private static readonly IntPtr NativeFieldInfoPtr_fireDuration;

		// Token: 0x04003E6B RID: 15979
		private static readonly IntPtr NativeFieldInfoPtr_burnDuration;

		// Token: 0x04003E6C RID: 15980
		private static readonly IntPtr NativeFieldInfoPtr_fireRadius;

		// Token: 0x04003E6D RID: 15981
		private static readonly IntPtr NativeFieldInfoPtr_fireEffect;

		// Token: 0x04003E6E RID: 15982
		private static readonly IntPtr NativeFieldInfoPtr_fireExplosion;

		// Token: 0x04003E6F RID: 15983
		private static readonly IntPtr NativeFieldInfoPtr_fireExplosionTray;

		// Token: 0x04003E70 RID: 15984
		private static readonly IntPtr NativeFieldInfoPtr_firePlayer;

		// Token: 0x04003E71 RID: 15985
		private static readonly IntPtr NativeFieldInfoPtr_fireEnergy;

		// Token: 0x04003E72 RID: 15986
		private static readonly IntPtr NativeFieldInfoPtr_fireSpawnSFX;

		// Token: 0x04003E73 RID: 15987
		private static readonly IntPtr NativeFieldInfoPtr_fireContinueSFX;

		// Token: 0x04003E74 RID: 15988
		private static readonly IntPtr NativeFieldInfoPtr_fireExplosionSFX;

		// Token: 0x04003E75 RID: 15989
		private static readonly IntPtr NativeFieldInfoPtr_playerBurntSFX;

		// Token: 0x04003E76 RID: 15990
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerDeliverType_Public_Virtual_get_DeliverType_0;

		// Token: 0x04003E77 RID: 15991
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalDataRequirement_Protected_Virtual_get_Int32_0;

		// Token: 0x04003E78 RID: 15992
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003E79 RID: 15993
		private static readonly IntPtr NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003E7A RID: 15994
		private static readonly IntPtr NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0;

		// Token: 0x04003E7B RID: 15995
		private static readonly IntPtr NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_String_0;

		// Token: 0x04003E7C RID: 15996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D3C RID: 3388
		[ObfuscatedName("GameData.Profile.PartnerBossInfoFuto+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F37F RID: 62335 RVA: 0x0039A380 File Offset: 0x00398580
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0>.NativeClassPtr);
				PartnerBossInfoFuto.__c__DisplayClass23_0.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0>.NativeClassPtr, "partnerManager");
				PartnerBossInfoFuto.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				PartnerBossInfoFuto.__c__DisplayClass23_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0>.NativeClassPtr, "eventManager");
				PartnerBossInfoFuto.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0>.NativeClassPtr, 100682649);
				PartnerBossInfoFuto.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_Coroutine_Sprite_Vector3_Vector3_Transform_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0>.NativeClassPtr, 100682650);
				PartnerBossInfoFuto.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Sprite_Vector3_Vector3_Transform_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0>.NativeClassPtr, 100682651);
			}

			// Token: 0x0600F380 RID: 62336 RVA: 0x0039A424 File Offset: 0x00398624
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F381 RID: 62337 RVA: 0x0039A460 File Offset: 0x00398660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233988, XrefRangeEnd = 233997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Coroutine Method_Internal_Coroutine_Sprite_Vector3_Vector3_Transform_PDM_0(Sprite sprite, Vector3 target, Vector3 position, Transform effectField)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectField);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_Coroutine_Sprite_Vector3_Vector3_Transform_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}

			// Token: 0x0600F382 RID: 62338 RVA: 0x0039A4E0 File Offset: 0x003986E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233997, XrefRangeEnd = 234004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Sprite_Vector3_Vector3_Transform_PDM_0(Sprite sprite, Vector3 target, Vector3 position, Transform effectField)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectField);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Sprite_Vector3_Vector3_Transform_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F383 RID: 62339 RVA: 0x00082B9C File Offset: 0x00080D9C
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F28 RID: 20264
			// (get) Token: 0x0600F384 RID: 62340 RVA: 0x0039A560 File Offset: 0x00398760
			// (set) Token: 0x0600F385 RID: 62341 RVA: 0x00082BA5 File Offset: 0x00080DA5
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F29 RID: 20265
			// (get) Token: 0x0600F386 RID: 62342 RVA: 0x0039A590 File Offset: 0x00398790
			// (set) Token: 0x0600F387 RID: 62343 RVA: 0x00082BC4 File Offset: 0x00080DC4
			public unsafe PartnerBossInfoFuto __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoFuto>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F2A RID: 20266
			// (get) Token: 0x0600F388 RID: 62344 RVA: 0x0039A5C0 File Offset: 0x003987C0
			// (set) Token: 0x0600F389 RID: 62345 RVA: 0x00082BE3 File Offset: 0x00080DE3
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B1D RID: 39709
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x04009B1E RID: 39710
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009B1F RID: 39711
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009B20 RID: 39712
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B21 RID: 39713
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Coroutine_Sprite_Vector3_Vector3_Transform_PDM_0;

			// Token: 0x04009B22 RID: 39714
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Sprite_Vector3_Vector3_Transform_PDM_0;

			// Token: 0x02001092 RID: 4242
			[ObfuscatedName("GameData.Profile.PartnerBossInfoFuto+<>c__DisplayClass23_0+<<OnPartnerLoad>g__Throw|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique : Il2CppSystem.Object
			{
				// Token: 0x06012104 RID: 73988 RVA: 0x0041FC94 File Offset: 0x0041DE94
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique()
				{
					Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0>.NativeClassPtr, "<<OnPartnerLoad>g__Throw|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr);
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "<>1__state");
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "<>2__current");
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "sprite");
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "target");
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "<>4__this");
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_effectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "effectField");
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "position");
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr__sellableObject_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "<sellableObject>5__2");
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682652);
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682653);
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682654);
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682655);
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682656);
					PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682657);
				}

				// Token: 0x06012105 RID: 73989 RVA: 0x0041FDD8 File Offset: 0x0041DFD8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012106 RID: 73990 RVA: 0x0041FE20 File Offset: 0x0041E020
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012107 RID: 73991 RVA: 0x0041FE54 File Offset: 0x0041E054
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233943, XrefRangeEnd = 233982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E51 RID: 24145
				// (get) Token: 0x06012108 RID: 73992 RVA: 0x0041FE90 File Offset: 0x0041E090
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012109 RID: 73993 RVA: 0x0041FED0 File Offset: 0x0041E0D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233982, XrefRangeEnd = 233988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E52 RID: 24146
				// (get) Token: 0x0601210A RID: 73994 RVA: 0x0041FF04 File Offset: 0x0041E104
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601210B RID: 73995 RVA: 0x0009CEDC File Offset: 0x0009B0DC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E49 RID: 24137
				// (get) Token: 0x0601210C RID: 73996 RVA: 0x0041FF44 File Offset: 0x0041E144
				// (set) Token: 0x0601210D RID: 73997 RVA: 0x0009CEE5 File Offset: 0x0009B0E5
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E4A RID: 24138
				// (get) Token: 0x0601210E RID: 73998 RVA: 0x0041FF6C File Offset: 0x0041E16C
				// (set) Token: 0x0601210F RID: 73999 RVA: 0x0009CF00 File Offset: 0x0009B100
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E4B RID: 24139
				// (get) Token: 0x06012110 RID: 74000 RVA: 0x0041FF9C File Offset: 0x0041E19C
				// (set) Token: 0x06012111 RID: 74001 RVA: 0x0009CF1F File Offset: 0x0009B11F
				public unsafe Sprite sprite
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_sprite);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E4C RID: 24140
				// (get) Token: 0x06012112 RID: 74002 RVA: 0x0041FFCC File Offset: 0x0041E1CC
				// (set) Token: 0x06012113 RID: 74003 RVA: 0x0009CF3E File Offset: 0x0009B13E
				public unsafe Vector3 target
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_target);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_target)) = value;
					}
				}

				// Token: 0x17005E4D RID: 24141
				// (get) Token: 0x06012114 RID: 74004 RVA: 0x0041FFF4 File Offset: 0x0041E1F4
				// (set) Token: 0x06012115 RID: 74005 RVA: 0x0009CF59 File Offset: 0x0009B159
				public unsafe PartnerBossInfoFuto.__c__DisplayClass23_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoFuto.__c__DisplayClass23_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E4E RID: 24142
				// (get) Token: 0x06012116 RID: 74006 RVA: 0x00420024 File Offset: 0x0041E224
				// (set) Token: 0x06012117 RID: 74007 RVA: 0x0009CF78 File Offset: 0x0009B178
				public unsafe Transform effectField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_effectField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_effectField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E4F RID: 24143
				// (get) Token: 0x06012118 RID: 74008 RVA: 0x00420054 File Offset: 0x0041E254
				// (set) Token: 0x06012119 RID: 74009 RVA: 0x0009CF97 File Offset: 0x0009B197
				public unsafe Vector3 position
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_position);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_position)) = value;
					}
				}

				// Token: 0x17005E50 RID: 24144
				// (get) Token: 0x0601211A RID: 74010 RVA: 0x0042007C File Offset: 0x0041E27C
				// (set) Token: 0x0601211B RID: 74011 RVA: 0x0009CFB2 File Offset: 0x0009B1B2
				public unsafe GameObject _sellableObject_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr__sellableObject_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr__sellableObject_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B70A RID: 46858
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B70B RID: 46859
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B70C RID: 46860
				private static readonly IntPtr NativeFieldInfoPtr_sprite;

				// Token: 0x0400B70D RID: 46861
				private static readonly IntPtr NativeFieldInfoPtr_target;

				// Token: 0x0400B70E RID: 46862
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B70F RID: 46863
				private static readonly IntPtr NativeFieldInfoPtr_effectField;

				// Token: 0x0400B710 RID: 46864
				private static readonly IntPtr NativeFieldInfoPtr_position;

				// Token: 0x0400B711 RID: 46865
				private static readonly IntPtr NativeFieldInfoPtr__sellableObject_5__2;

				// Token: 0x0400B712 RID: 46866
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B713 RID: 46867
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B714 RID: 46868
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B715 RID: 46869
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B716 RID: 46870
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B717 RID: 46871
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D3D RID: 3389
		[ObfuscatedName("GameData.Profile.PartnerBossInfoFuto+<>c__DisplayClass23_1")]
		public sealed class __c__DisplayClass23_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F38A RID: 62346 RVA: 0x0039A5F0 File Offset: 0x003987F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_1()
			{
				Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "<>c__DisplayClass23_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_1>.NativeClassPtr);
				PartnerBossInfoFuto.__c__DisplayClass23_1.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_1>.NativeClassPtr, "sprite");
				PartnerBossInfoFuto.__c__DisplayClass23_1.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_1>.NativeClassPtr, "target");
				PartnerBossInfoFuto.__c__DisplayClass23_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_1>.NativeClassPtr, 100682658);
				PartnerBossInfoFuto.__c__DisplayClass23_1.NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_1>.NativeClassPtr, 100682659);
				PartnerBossInfoFuto.__c__DisplayClass23_1.NativeMethodInfoPtr__OnPartnerLoad_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_1>.NativeClassPtr, 100682660);
			}

			// Token: 0x0600F38B RID: 62347 RVA: 0x0039A680 File Offset: 0x00398880
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass23_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F38C RID: 62348 RVA: 0x0039A6BC File Offset: 0x003988BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__2(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_1.NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F38D RID: 62349 RVA: 0x0039A700 File Offset: 0x00398900
			[CallerCount(0)]
			public unsafe Vector3 _OnPartnerLoad_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass23_1.NativeMethodInfoPtr__OnPartnerLoad_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F38E RID: 62350 RVA: 0x00082C02 File Offset: 0x00080E02
			public __c__DisplayClass23_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F2B RID: 20267
			// (get) Token: 0x0600F38F RID: 62351 RVA: 0x0039A73C File Offset: 0x0039893C
			// (set) Token: 0x0600F390 RID: 62352 RVA: 0x00082C0B File Offset: 0x00080E0B
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_1.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_1.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F2C RID: 20268
			// (get) Token: 0x0600F391 RID: 62353 RVA: 0x0039A76C File Offset: 0x0039896C
			// (set) Token: 0x0600F392 RID: 62354 RVA: 0x00082C2A File Offset: 0x00080E2A
			public unsafe Vector3 target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_1.NativeFieldInfoPtr_target);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass23_1.NativeFieldInfoPtr_target)) = value;
				}
			}

			// Token: 0x04009B23 RID: 39715
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x04009B24 RID: 39716
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04009B25 RID: 39717
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B26 RID: 39718
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_SpriteRenderer_0;

			// Token: 0x04009B27 RID: 39719
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__3_Internal_Vector3_0;
		}

		// Token: 0x02000D3E RID: 3390
		[ObfuscatedName("GameData.Profile.PartnerBossInfoFuto+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F393 RID: 62355 RVA: 0x0039A794 File Offset: 0x00398994
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0>.NativeClassPtr);
				PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr_currentPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0>.NativeClassPtr, "currentPartner");
				PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0>.NativeClassPtr, "manager");
				PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0>.NativeClassPtr, "eventManager");
				PartnerBossInfoFuto.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0>.NativeClassPtr, 100682661);
				PartnerBossInfoFuto.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0>.NativeClassPtr, 100682662);
			}

			// Token: 0x0600F394 RID: 62356 RVA: 0x0039A838 File Offset: 0x00398A38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F395 RID: 62357 RVA: 0x0039A874 File Offset: 0x00398A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234126, XrefRangeEnd = 234131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F396 RID: 62358 RVA: 0x00082C45 File Offset: 0x00080E45
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F2D RID: 20269
			// (get) Token: 0x0600F397 RID: 62359 RVA: 0x0039A8B4 File Offset: 0x00398AB4
			// (set) Token: 0x0600F398 RID: 62360 RVA: 0x00082C4E File Offset: 0x00080E4E
			public unsafe PartnerBossInfoFuto __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoFuto>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F2E RID: 20270
			// (get) Token: 0x0600F399 RID: 62361 RVA: 0x0039A8E4 File Offset: 0x00398AE4
			// (set) Token: 0x0600F39A RID: 62362 RVA: 0x00082C6D File Offset: 0x00080E6D
			public unsafe PartnerBase currentPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr_currentPartner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr_currentPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F2F RID: 20271
			// (get) Token: 0x0600F39B RID: 62363 RVA: 0x0039A914 File Offset: 0x00398B14
			// (set) Token: 0x0600F39C RID: 62364 RVA: 0x00082C8C File Offset: 0x00080E8C
			public unsafe PartnerManager manager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr_manager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr_manager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F30 RID: 20272
			// (get) Token: 0x0600F39D RID: 62365 RVA: 0x0039A944 File Offset: 0x00398B44
			// (set) Token: 0x0600F39E RID: 62366 RVA: 0x00082CAB File Offset: 0x00080EAB
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B28 RID: 39720
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009B29 RID: 39721
			private static readonly IntPtr NativeFieldInfoPtr_currentPartner;

			// Token: 0x04009B2A RID: 39722
			private static readonly IntPtr NativeFieldInfoPtr_manager;

			// Token: 0x04009B2B RID: 39723
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009B2C RID: 39724
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B2D RID: 39725
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001093 RID: 4243
			[ObfuscatedName("GameData.Profile.PartnerBossInfoFuto+<>c__DisplayClass24_0+<<BossSpecialAbilityPreLoad>g__SpawnFire|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601211C RID: 74012 RVA: 0x004200AC File Offset: 0x0041E2AC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique()
				{
					Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0>.NativeClassPtr, "<<BossSpecialAbilityPreLoad>g__SpawnFire|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr);
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, "<>1__state");
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, "<>2__current");
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, "<>4__this");
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, "<>8__1");
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr__wait_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, "<wait>5__2");
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr__firePosition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, "<firePosition>5__3");
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, 100682663);
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, 100682664);
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, 100682665);
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, 100682666);
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, 100682667);
					PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr, 100682668);
				}

				// Token: 0x0601211D RID: 74013 RVA: 0x004201C8 File Offset: 0x0041E3C8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601211E RID: 74014 RVA: 0x00420210 File Offset: 0x0041E410
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601211F RID: 74015 RVA: 0x00420244 File Offset: 0x0041E444
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234004, XrefRangeEnd = 234120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E59 RID: 24153
				// (get) Token: 0x06012120 RID: 74016 RVA: 0x00420280 File Offset: 0x0041E480
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012121 RID: 74017 RVA: 0x004202C0 File Offset: 0x0041E4C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234120, XrefRangeEnd = 234126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E5A RID: 24154
				// (get) Token: 0x06012122 RID: 74018 RVA: 0x004202F4 File Offset: 0x0041E4F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012123 RID: 74019 RVA: 0x0009CFD1 File Offset: 0x0009B1D1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E53 RID: 24147
				// (get) Token: 0x06012124 RID: 74020 RVA: 0x00420334 File Offset: 0x0041E534
				// (set) Token: 0x06012125 RID: 74021 RVA: 0x0009CFDA File Offset: 0x0009B1DA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E54 RID: 24148
				// (get) Token: 0x06012126 RID: 74022 RVA: 0x0042035C File Offset: 0x0041E55C
				// (set) Token: 0x06012127 RID: 74023 RVA: 0x0009CFF5 File Offset: 0x0009B1F5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E55 RID: 24149
				// (get) Token: 0x06012128 RID: 74024 RVA: 0x0042038C File Offset: 0x0041E58C
				// (set) Token: 0x06012129 RID: 74025 RVA: 0x0009D014 File Offset: 0x0009B214
				public unsafe PartnerBossInfoFuto.__c__DisplayClass24_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoFuto.__c__DisplayClass24_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E56 RID: 24150
				// (get) Token: 0x0601212A RID: 74026 RVA: 0x004203BC File Offset: 0x0041E5BC
				// (set) Token: 0x0601212B RID: 74027 RVA: 0x0009D033 File Offset: 0x0009B233
				public unsafe PartnerBossInfoFuto.__c__DisplayClass24_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoFuto.__c__DisplayClass24_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E57 RID: 24151
				// (get) Token: 0x0601212C RID: 74028 RVA: 0x004203EC File Offset: 0x0041E5EC
				// (set) Token: 0x0601212D RID: 74029 RVA: 0x0009D052 File Offset: 0x0009B252
				public unsafe WaitForSeconds _wait_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr__wait_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr__wait_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E58 RID: 24152
				// (get) Token: 0x0601212E RID: 74030 RVA: 0x0042041C File Offset: 0x0041E61C
				// (set) Token: 0x0601212F RID: 74031 RVA: 0x0009D071 File Offset: 0x0009B271
				public unsafe IEnumerable<Vector2> _firePosition_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr__firePosition_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector2>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaIE1VeObObUnique.NativeFieldInfoPtr__firePosition_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B718 RID: 46872
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B719 RID: 46873
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B71A RID: 46874
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B71B RID: 46875
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B71C RID: 46876
				private static readonly IntPtr NativeFieldInfoPtr__wait_5__2;

				// Token: 0x0400B71D RID: 46877
				private static readonly IntPtr NativeFieldInfoPtr__firePosition_5__3;

				// Token: 0x0400B71E RID: 46878
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B71F RID: 46879
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B720 RID: 46880
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B721 RID: 46881
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B722 RID: 46882
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B723 RID: 46883
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D3F RID: 3391
		[ObfuscatedName("GameData.Profile.PartnerBossInfoFuto+<>c__DisplayClass24_1")]
		public sealed class __c__DisplayClass24_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F39F RID: 62367 RVA: 0x0039A974 File Offset: 0x00398B74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_1()
			{
				Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "<>c__DisplayClass24_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr);
				PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr_playerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr, "playerTransform");
				PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr_fireDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr, "fireDic");
				PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr, "CS$<>8__locals1");
				PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr, "<>9__3");
				PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr, "<>9__5");
				PartnerBossInfoFuto.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr, 100682669);
				PartnerBossInfoFuto.__c__DisplayClass24_1.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__3_Internal_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr, 100682670);
				PartnerBossInfoFuto.__c__DisplayClass24_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr, 100682671);
				PartnerBossInfoFuto.__c__DisplayClass24_1.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__5_Internal_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr, 100682672);
			}

			// Token: 0x0600F3A0 RID: 62368 RVA: 0x0039AA54 File Offset: 0x00398C54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3A1 RID: 62369 RVA: 0x0039AA90 File Offset: 0x00398C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234265, XrefRangeEnd = 234266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BossSpecialAbilityPreLoad_b__3(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__3_Internal_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3A2 RID: 62370 RVA: 0x0039AADC File Offset: 0x00398CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234266, XrefRangeEnd = 234271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F3A3 RID: 62371 RVA: 0x0039AB1C File Offset: 0x00398D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234271, XrefRangeEnd = 234272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BossSpecialAbilityPreLoad_b__5(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__5_Internal_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3A4 RID: 62372 RVA: 0x00082CCA File Offset: 0x00080ECA
			public __c__DisplayClass24_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F31 RID: 20273
			// (get) Token: 0x0600F3A5 RID: 62373 RVA: 0x0039AB68 File Offset: 0x00398D68
			// (set) Token: 0x0600F3A6 RID: 62374 RVA: 0x00082CD3 File Offset: 0x00080ED3
			public unsafe Transform playerTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr_playerTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr_playerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F32 RID: 20274
			// (get) Token: 0x0600F3A7 RID: 62375 RVA: 0x0039AB98 File Offset: 0x00398D98
			// (set) Token: 0x0600F3A8 RID: 62376 RVA: 0x00082CF2 File Offset: 0x00080EF2
			public unsafe List<ValueTuple<Vector3, GameObject>> fireDic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr_fireDic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<Vector3, GameObject>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr_fireDic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F33 RID: 20275
			// (get) Token: 0x0600F3A9 RID: 62377 RVA: 0x0039ABC8 File Offset: 0x00398DC8
			// (set) Token: 0x0600F3AA RID: 62378 RVA: 0x00082D11 File Offset: 0x00080F11
			public unsafe PartnerBossInfoFuto.__c__DisplayClass24_0 field_Public___c__DisplayClass24_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoFuto.__c__DisplayClass24_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F34 RID: 20276
			// (get) Token: 0x0600F3AB RID: 62379 RVA: 0x0039ABF8 File Offset: 0x00398DF8
			// (set) Token: 0x0600F3AC RID: 62380 RVA: 0x00082D30 File Offset: 0x00080F30
			public unsafe Func<Vector2, bool> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F35 RID: 20277
			// (get) Token: 0x0600F3AD RID: 62381 RVA: 0x0039AC28 File Offset: 0x00398E28
			// (set) Token: 0x0600F3AE RID: 62382 RVA: 0x00082D4F File Offset: 0x00080F4F
			public unsafe Func<Vector3, bool> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B2E RID: 39726
			private static readonly IntPtr NativeFieldInfoPtr_playerTransform;

			// Token: 0x04009B2F RID: 39727
			private static readonly IntPtr NativeFieldInfoPtr_fireDic;

			// Token: 0x04009B30 RID: 39728
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0;

			// Token: 0x04009B31 RID: 39729
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04009B32 RID: 39730
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x04009B33 RID: 39731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B34 RID: 39732
			private static readonly IntPtr NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__3_Internal_Boolean_Vector2_0;

			// Token: 0x04009B35 RID: 39733
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009B36 RID: 39734
			private static readonly IntPtr NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__5_Internal_Boolean_Vector3_0;

			// Token: 0x02001094 RID: 4244
			[ObfuscatedName("GameData.Profile.PartnerBossInfoFuto+<>c__DisplayClass24_1+<<BossSpecialAbilityPreLoad>g__FireCheck|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012130 RID: 74032 RVA: 0x0042044C File Offset: 0x0041E64C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1>.NativeClassPtr, "<<BossSpecialAbilityPreLoad>g__FireCheck|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<time>5__2");
					PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682673);
					PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682674);
					PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682675);
					PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682676);
					PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682677);
					PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100682678);
				}

				// Token: 0x06012131 RID: 74033 RVA: 0x00420540 File Offset: 0x0041E740
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012132 RID: 74034 RVA: 0x00420588 File Offset: 0x0041E788
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012133 RID: 74035 RVA: 0x004205BC File Offset: 0x0041E7BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234131, XrefRangeEnd = 234259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E5F RID: 24159
				// (get) Token: 0x06012134 RID: 74036 RVA: 0x004205F8 File Offset: 0x0041E7F8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012135 RID: 74037 RVA: 0x00420638 File Offset: 0x0041E838
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234259, XrefRangeEnd = 234265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E60 RID: 24160
				// (get) Token: 0x06012136 RID: 74038 RVA: 0x0042066C File Offset: 0x0041E86C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012137 RID: 74039 RVA: 0x0009D090 File Offset: 0x0009B290
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E5B RID: 24155
				// (get) Token: 0x06012138 RID: 74040 RVA: 0x004206AC File Offset: 0x0041E8AC
				// (set) Token: 0x06012139 RID: 74041 RVA: 0x0009D099 File Offset: 0x0009B299
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E5C RID: 24156
				// (get) Token: 0x0601213A RID: 74042 RVA: 0x004206D4 File Offset: 0x0041E8D4
				// (set) Token: 0x0601213B RID: 74043 RVA: 0x0009D0B4 File Offset: 0x0009B2B4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E5D RID: 24157
				// (get) Token: 0x0601213C RID: 74044 RVA: 0x00420704 File Offset: 0x0041E904
				// (set) Token: 0x0601213D RID: 74045 RVA: 0x0009D0D3 File Offset: 0x0009B2D3
				public unsafe PartnerBossInfoFuto.__c__DisplayClass24_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoFuto.__c__DisplayClass24_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E5E RID: 24158
				// (get) Token: 0x0601213E RID: 74046 RVA: 0x00420734 File Offset: 0x0041E934
				// (set) Token: 0x0601213F RID: 74047 RVA: 0x0009D0F2 File Offset: 0x0009B2F2
				public unsafe float _time_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__time_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__time_5__2)) = value;
					}
				}

				// Token: 0x0400B724 RID: 46884
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B725 RID: 46885
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B726 RID: 46886
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B727 RID: 46887
				private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

				// Token: 0x0400B728 RID: 46888
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B729 RID: 46889
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B72A RID: 46890
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B72B RID: 46891
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B72C RID: 46892
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B72D RID: 46893
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D40 RID: 3392
		[ObfuscatedName("GameData.Profile.PartnerBossInfoFuto+<>c__DisplayClass24_2")]
		public sealed class __c__DisplayClass24_2 : Il2CppSystem.Object
		{
			// Token: 0x0600F3AF RID: 62383 RVA: 0x0039AC58 File Offset: 0x00398E58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_2()
			{
				Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "<>c__DisplayClass24_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2>.NativeClassPtr);
				PartnerBossInfoFuto.__c__DisplayClass24_2.NativeFieldInfoPtr_burnVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2>.NativeClassPtr, "burnVFX");
				PartnerBossInfoFuto.__c__DisplayClass24_2.NativeFieldInfoPtr_field_Public___c__DisplayClass24_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2>.NativeClassPtr, "CS$<>8__locals2");
				PartnerBossInfoFuto.__c__DisplayClass24_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2>.NativeClassPtr, 100682679);
				PartnerBossInfoFuto.__c__DisplayClass24_2.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2>.NativeClassPtr, 100682680);
				PartnerBossInfoFuto.__c__DisplayClass24_2.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2>.NativeClassPtr, 100682681);
			}

			// Token: 0x0600F3B0 RID: 62384 RVA: 0x0039ACE8 File Offset: 0x00398EE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3B1 RID: 62385 RVA: 0x0039AD24 File Offset: 0x00398F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234289, XrefRangeEnd = 234298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BossSpecialAbilityPreLoad_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_2.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3B2 RID: 62386 RVA: 0x0039AD58 File Offset: 0x00398F58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234298, XrefRangeEnd = 234303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_2.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F3B3 RID: 62387 RVA: 0x00082D6E File Offset: 0x00080F6E
			public __c__DisplayClass24_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F36 RID: 20278
			// (get) Token: 0x0600F3B4 RID: 62388 RVA: 0x0039AD98 File Offset: 0x00398F98
			// (set) Token: 0x0600F3B5 RID: 62389 RVA: 0x00082D77 File Offset: 0x00080F77
			public unsafe GameObject burnVFX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_2.NativeFieldInfoPtr_burnVFX);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_2.NativeFieldInfoPtr_burnVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F37 RID: 20279
			// (get) Token: 0x0600F3B6 RID: 62390 RVA: 0x0039ADC8 File Offset: 0x00398FC8
			// (set) Token: 0x0600F3B7 RID: 62391 RVA: 0x00082D96 File Offset: 0x00080F96
			public unsafe PartnerBossInfoFuto.__c__DisplayClass24_1 field_Public___c__DisplayClass24_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_2.NativeFieldInfoPtr_field_Public___c__DisplayClass24_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoFuto.__c__DisplayClass24_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_2.NativeFieldInfoPtr_field_Public___c__DisplayClass24_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B37 RID: 39735
			private static readonly IntPtr NativeFieldInfoPtr_burnVFX;

			// Token: 0x04009B38 RID: 39736
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass24_1_0;

			// Token: 0x04009B39 RID: 39737
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B3A RID: 39738
			private static readonly IntPtr NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__7_Internal_Void_0;

			// Token: 0x04009B3B RID: 39739
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001095 RID: 4245
			[ObfuscatedName("GameData.Profile.PartnerBossInfoFuto+<>c__DisplayClass24_2+<<BossSpecialAbilityPreLoad>g__FireBurnFollow|6>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012140 RID: 74048 RVA: 0x0042075C File Offset: 0x0041E95C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2>.NativeClassPtr, "<<BossSpecialAbilityPreLoad>g__FireBurnFollow|6>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682682);
					PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682683);
					PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682684);
					PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682685);
					PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682686);
					PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682687);
				}

				// Token: 0x06012141 RID: 74049 RVA: 0x0042083C File Offset: 0x0041EA3C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012142 RID: 74050 RVA: 0x00420884 File Offset: 0x0041EA84
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012143 RID: 74051 RVA: 0x004208B8 File Offset: 0x0041EAB8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234272, XrefRangeEnd = 234283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E64 RID: 24164
				// (get) Token: 0x06012144 RID: 74052 RVA: 0x004208F4 File Offset: 0x0041EAF4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012145 RID: 74053 RVA: 0x00420934 File Offset: 0x0041EB34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234283, XrefRangeEnd = 234289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E65 RID: 24165
				// (get) Token: 0x06012146 RID: 74054 RVA: 0x00420968 File Offset: 0x0041EB68
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012147 RID: 74055 RVA: 0x0009D10D File Offset: 0x0009B30D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E61 RID: 24161
				// (get) Token: 0x06012148 RID: 74056 RVA: 0x004209A8 File Offset: 0x0041EBA8
				// (set) Token: 0x06012149 RID: 74057 RVA: 0x0009D116 File Offset: 0x0009B316
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E62 RID: 24162
				// (get) Token: 0x0601214A RID: 74058 RVA: 0x004209D0 File Offset: 0x0041EBD0
				// (set) Token: 0x0601214B RID: 74059 RVA: 0x0009D131 File Offset: 0x0009B331
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E63 RID: 24163
				// (get) Token: 0x0601214C RID: 74060 RVA: 0x00420A00 File Offset: 0x0041EC00
				// (set) Token: 0x0601214D RID: 74061 RVA: 0x0009D150 File Offset: 0x0009B350
				public unsafe PartnerBossInfoFuto.__c__DisplayClass24_2 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoFuto.__c__DisplayClass24_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoFuto.__c__DisplayClass24_2.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B72E RID: 46894
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B72F RID: 46895
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B730 RID: 46896
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B731 RID: 46897
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B732 RID: 46898
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B733 RID: 46899
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B734 RID: 46900
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B735 RID: 46901
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B736 RID: 46902
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D41 RID: 3393
		[ObfuscatedName("GameData.Profile.PartnerBossInfoFuto+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F3B8 RID: 62392 RVA: 0x0039ADF8 File Offset: 0x00398FF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerBossInfoFuto.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoFuto>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoFuto.__c>.NativeClassPtr);
				PartnerBossInfoFuto.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c>.NativeClassPtr, "<>9");
				PartnerBossInfoFuto.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c>.NativeClassPtr, "<>9__24_1");
				PartnerBossInfoFuto.__c.NativeFieldInfoPtr___9__24_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoFuto.__c>.NativeClassPtr, "<>9__24_4");
				PartnerBossInfoFuto.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c>.NativeClassPtr, 100682689);
				PartnerBossInfoFuto.__c.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__24_1_Internal_Vector2_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c>.NativeClassPtr, 100682690);
				PartnerBossInfoFuto.__c.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__24_4_Internal_Vector3_ValueTuple_2_Vector3_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoFuto.__c>.NativeClassPtr, 100682691);
			}

			// Token: 0x0600F3B9 RID: 62393 RVA: 0x0039AE9C File Offset: 0x0039909C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoFuto.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3BA RID: 62394 RVA: 0x0039AED8 File Offset: 0x003990D8
			[CallerCount(0)]
			public unsafe Vector2 _BossSpecialAbilityPreLoad_b__24_1(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__24_1_Internal_Vector2_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3BB RID: 62395 RVA: 0x0039AF24 File Offset: 0x00399124
			[CallerCount(0)]
			public unsafe Vector3 _BossSpecialAbilityPreLoad_b__24_4(ValueTuple<Vector3, GameObject> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoFuto.__c.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__24_4_Internal_Vector3_ValueTuple_2_Vector3_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3BC RID: 62396 RVA: 0x00082DB5 File Offset: 0x00080FB5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F38 RID: 20280
			// (get) Token: 0x0600F3BD RID: 62397 RVA: 0x0039AF78 File Offset: 0x00399178
			// (set) Token: 0x0600F3BE RID: 62398 RVA: 0x00082DBE File Offset: 0x00080FBE
			public unsafe static PartnerBossInfoFuto.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoFuto.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoFuto.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoFuto.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F39 RID: 20281
			// (get) Token: 0x0600F3BF RID: 62399 RVA: 0x0039AFA0 File Offset: 0x003991A0
			// (set) Token: 0x0600F3C0 RID: 62400 RVA: 0x00082DD0 File Offset: 0x00080FD0
			public unsafe static Func<Vector2Int, Vector2> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoFuto.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, Vector2>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoFuto.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F3A RID: 20282
			// (get) Token: 0x0600F3C1 RID: 62401 RVA: 0x0039AFC8 File Offset: 0x003991C8
			// (set) Token: 0x0600F3C2 RID: 62402 RVA: 0x00082DE2 File Offset: 0x00080FE2
			public unsafe static Func<ValueTuple<Vector3, GameObject>, Vector3> __9__24_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoFuto.__c.NativeFieldInfoPtr___9__24_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Vector3, GameObject>, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoFuto.__c.NativeFieldInfoPtr___9__24_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B3C RID: 39740
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009B3D RID: 39741
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x04009B3E RID: 39742
			private static readonly IntPtr NativeFieldInfoPtr___9__24_4;

			// Token: 0x04009B3F RID: 39743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B40 RID: 39744
			private static readonly IntPtr NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__24_1_Internal_Vector2_Vector2Int_0;

			// Token: 0x04009B41 RID: 39745
			private static readonly IntPtr NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__24_4_Internal_Vector3_ValueTuple_2_Vector3_GameObject_0;
		}
	}
}
