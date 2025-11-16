using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200007C RID: 124
	public class DLC4_BulletMedicineAcidPool : DLC4_BulletTeam
	{
		// Token: 0x06000CF3 RID: 3315 RVA: 0x000C99CC File Offset: 0x000C7BCC
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletMedicineAcidPool()
		{
			Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletMedicineAcidPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr);
			DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr_exist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, "exist");
			DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr_flandreInAcidPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, "flandreInAcidPool");
			DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr_lerpCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, "lerpCoroutine");
			DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoolDuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, "<PoolDuration>k__BackingField");
			DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoolFrozenMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, "<PoolFrozenMultiplier>k__BackingField");
			DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoisonDamage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, "<PoisonDamage>k__BackingField");
			DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoisonDuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, "<PoisonDuration>k__BackingField");
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_get_PoolDuration_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665493);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_set_PoolDuration_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665494);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_get_PoolFrozenMultiplier_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665495);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_set_PoolFrozenMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665496);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_get_PoisonDamage_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665497);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_set_PoisonDamage_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665498);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_get_PoisonDuration_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665499);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_set_PoisonDuration_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665500);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665501);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_OnBulletEnable_Public_Void_Single_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665502);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_ClearPool_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665503);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665504);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_RemoveHitEnemyFromAcidList_Private_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665505);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_PoisonEnemy_Private_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665506);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_Frozen_Private_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665507);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665508);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665509);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665510);
			DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr__OnDispose_b__26_0_Private_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, 100665511);
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x000C9C04 File Offset: 0x000C7E04
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x000C9C40 File Offset: 0x000C7E40
		public unsafe float PoolDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_get_PoolDuration_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_set_PoolDuration_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x000C9C80 File Offset: 0x000C7E80
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x000C9CBC File Offset: 0x000C7EBC
		public unsafe float PoolFrozenMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_get_PoolFrozenMultiplier_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_set_PoolFrozenMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x000C9CFC File Offset: 0x000C7EFC
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x000C9D38 File Offset: 0x000C7F38
		public unsafe int PoisonDamage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_get_PoisonDamage_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_set_PoisonDamage_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x000C9D78 File Offset: 0x000C7F78
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x000C9DB4 File Offset: 0x000C7FB4
		public unsafe int PoisonDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_get_PoisonDuration_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_set_PoisonDuration_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000C9DF4 File Offset: 0x000C7FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43942, XrefRangeEnd = 43958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000C9E28 File Offset: 0x000C8028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43958, XrefRangeEnd = 43966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBulletEnable(float poolDuration, int poisonDamage, int poisonDuration, float frozenMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref poolDuration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poisonDamage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poisonDuration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frozenMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_OnBulletEnable_Public_Void_Single_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000C9E90 File Offset: 0x000C8090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43966, XrefRangeEnd = 43971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ClearPool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_ClearPool_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x000C9ED0 File Offset: 0x000C80D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43971, XrefRangeEnd = 43988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000C9F20 File Offset: 0x000C8120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43988, XrefRangeEnd = 43992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveHitEnemyFromAcidList(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_RemoveHitEnemyFromAcidList_Private_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x000C9F64 File Offset: 0x000C8164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43992, XrefRangeEnd = 43993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoisonEnemy(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_PoisonEnemy_Private_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000C9FA8 File Offset: 0x000C81A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43993, XrefRangeEnd = 43994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Frozen(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_Frozen_Private_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000C9FEC File Offset: 0x000C81EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43994, XrefRangeEnd = 44009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x000CA028 File Offset: 0x000C8228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44009, XrefRangeEnd = 44012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x000CA064 File Offset: 0x000C8264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44012, XrefRangeEnd = 44021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletMedicineAcidPool() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000CA0A0 File Offset: 0x000C82A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44021, XrefRangeEnd = 44037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnDispose_b__26_0(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool.NativeMethodInfoPtr__OnDispose_b__26_0_Private_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00008C5C File Offset: 0x00006E5C
		public DLC4_BulletMedicineAcidPool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x000CA0E4 File Offset: 0x000C82E4
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00008C65 File Offset: 0x00006E65
		public unsafe bool exist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr_exist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr_exist)) = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x000CA10C File Offset: 0x000C830C
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00008C80 File Offset: 0x00006E80
		public unsafe List<DLC4_FlandreEnemyCharacterController> flandreInAcidPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr_flandreInAcidPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC4_FlandreEnemyCharacterController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr_flandreInAcidPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x000CA13C File Offset: 0x000C833C
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00008C9F File Offset: 0x00006E9F
		public unsafe Coroutine lerpCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr_lerpCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr_lerpCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x000CA16C File Offset: 0x000C836C
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00008CBE File Offset: 0x00006EBE
		public unsafe float _PoolDuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoolDuration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoolDuration_k__BackingField)) = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x000CA194 File Offset: 0x000C8394
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00008CD9 File Offset: 0x00006ED9
		public unsafe float _PoolFrozenMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoolFrozenMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoolFrozenMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x000CA1BC File Offset: 0x000C83BC
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00008CF4 File Offset: 0x00006EF4
		public unsafe int _PoisonDamage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoisonDamage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoisonDamage_k__BackingField)) = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x000CA1E4 File Offset: 0x000C83E4
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x00008D0F File Offset: 0x00006F0F
		public unsafe int _PoisonDuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoisonDuration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool.NativeFieldInfoPtr__PoisonDuration_k__BackingField)) = value;
			}
		}

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeFieldInfoPtr_exist;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeFieldInfoPtr_flandreInAcidPool;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeFieldInfoPtr_lerpCoroutine;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeFieldInfoPtr__PoolDuration_k__BackingField;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeFieldInfoPtr__PoolFrozenMultiplier_k__BackingField;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeFieldInfoPtr__PoisonDamage_k__BackingField;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeFieldInfoPtr__PoisonDuration_k__BackingField;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_get_PoolDuration_Private_get_Single_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_set_PoolDuration_Private_set_Void_Single_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_get_PoolFrozenMultiplier_Private_get_Single_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_set_PoolFrozenMultiplier_Private_set_Void_Single_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_get_PoisonDamage_Private_get_Int32_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_set_PoisonDamage_Private_set_Void_Int32_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_get_PoisonDuration_Private_get_Int32_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_set_PoisonDuration_Private_set_Void_Int32_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_OnBulletEnable_Public_Void_Single_Int32_Int32_Single_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_ClearPool_Private_IEnumerator_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_RemoveHitEnemyFromAcidList_Private_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_PoisonEnemy_Private_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_Frozen_Private_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr__OnDispose_b__26_0_Private_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x02000547 RID: 1351
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_BulletMedicineAcidPool+<ClearPool>d__21")]
		public sealed class _ClearPool_d__21 : Il2CppSystem.Object
		{
			// Token: 0x0600871C RID: 34588 RVA: 0x0025A0DC File Offset: 0x002582DC
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearPool_d__21()
			{
				Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool>.NativeClassPtr, "<ClearPool>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr);
				DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr, "<>1__state");
				DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr, "<>2__current");
				DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr, "<>4__this");
				DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr, 100665512);
				DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr, 100665513);
				DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr, 100665514);
				DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr, 100665515);
				DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr, 100665516);
				DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr, 100665517);
			}

			// Token: 0x0600871D RID: 34589 RVA: 0x0025A1BC File Offset: 0x002583BC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClearPool_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletMedicineAcidPool._ClearPool_d__21>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600871E RID: 34590 RVA: 0x0025A204 File Offset: 0x00258404
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600871F RID: 34591 RVA: 0x0025A238 File Offset: 0x00258438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43931, XrefRangeEnd = 43936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002D54 RID: 11604
			// (get) Token: 0x06008720 RID: 34592 RVA: 0x0025A274 File Offset: 0x00258474
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008721 RID: 34593 RVA: 0x0025A2B4 File Offset: 0x002584B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43936, XrefRangeEnd = 43942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002D55 RID: 11605
			// (get) Token: 0x06008722 RID: 34594 RVA: 0x0025A2E8 File Offset: 0x002584E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008723 RID: 34595 RVA: 0x00048B01 File Offset: 0x00046D01
			public _ClearPool_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D51 RID: 11601
			// (get) Token: 0x06008724 RID: 34596 RVA: 0x0025A328 File Offset: 0x00258528
			// (set) Token: 0x06008725 RID: 34597 RVA: 0x00048B0A File Offset: 0x00046D0A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002D52 RID: 11602
			// (get) Token: 0x06008726 RID: 34598 RVA: 0x0025A350 File Offset: 0x00258550
			// (set) Token: 0x06008727 RID: 34599 RVA: 0x00048B25 File Offset: 0x00046D25
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D53 RID: 11603
			// (get) Token: 0x06008728 RID: 34600 RVA: 0x0025A380 File Offset: 0x00258580
			// (set) Token: 0x06008729 RID: 34601 RVA: 0x00048B44 File Offset: 0x00046D44
			public unsafe DLC4_BulletMedicineAcidPool __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BulletMedicineAcidPool>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineAcidPool._ClearPool_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040058A7 RID: 22695
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040058A8 RID: 22696
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040058A9 RID: 22697
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040058AA RID: 22698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040058AB RID: 22699
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040058AC RID: 22700
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040058AD RID: 22701
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040058AE RID: 22702
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040058AF RID: 22703
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
