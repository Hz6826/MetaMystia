using System;
using Common.Audio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000A4 RID: 164
	public class DLC4_GuardShinmyoumaru : DLC4_GuardController
	{
		// Token: 0x06001145 RID: 4421 RVA: 0x000D8B84 File Offset: 0x000D6D84
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_GuardShinmyoumaru()
		{
			Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_GuardShinmyoumaru");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr);
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_AURABURSTING_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "AURABURSTING_TAG");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_Level1Bullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_Level1Bullet");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_Level2Bullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_Level2Bullet");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_UltimateSkillDurationForSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_UltimateSkillDurationForSelf");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_AttackSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_AttackSpeedMultiplier");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffBaseTimeForTeammate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaBuffBaseTimeForTeammate");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffAtLeastCostP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaBuffAtLeastCostP");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffAtLeastCostPPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaBuffAtLeastCostPPercentage");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffCostPPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaBuffCostPPerSec");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffUIDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaBuffUIDisplay");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffUIDisplayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaBuffUIDisplayOffset");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikara = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaNoChikara");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaNoChikaraOffset");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraWaitToEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaNoChikaraWaitToEnable");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaNoChikaraSfx");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraWalletSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaNoChikaraWalletSfx");
			DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraWalletBoomSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "m_YuushaNoChikaraWalletBoomSfx");
			DLC4_GuardShinmyoumaru.NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, 100666326);
			DLC4_GuardShinmyoumaru.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, 100666327);
			DLC4_GuardShinmyoumaru.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, 100666328);
			DLC4_GuardShinmyoumaru.NativeMethodInfoPtr_SetTargetGuardYuuSha_Private_Void_DLC4_GuardController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, 100666329);
			DLC4_GuardShinmyoumaru.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, 100666330);
			DLC4_GuardShinmyoumaru.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, 100666331);
			DLC4_GuardShinmyoumaru.NativeMethodInfoPtr__SkillAttack_b__19_0_Private_Boolean_DLC4_GuardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, 100666332);
			DLC4_GuardShinmyoumaru.NativeMethodInfoPtr__SkillAttack_b__19_1_Private_Boolean_DLC4_GuardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, 100666333);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x000D8DA8 File Offset: 0x000D6FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50252, XrefRangeEnd = 50254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CouldAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardShinmyoumaru.NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x000D8DF0 File Offset: 0x000D6FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50254, XrefRangeEnd = 50293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NormalAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardShinmyoumaru.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x000D8E2C File Offset: 0x000D702C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50293, XrefRangeEnd = 50298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator SkillAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardShinmyoumaru.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x000D8E78 File Offset: 0x000D7078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50326, RefRangeEnd = 50328, XrefRangeStart = 50298, XrefRangeEnd = 50326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetGuardYuuSha(DLC4_GuardController guard, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guard);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.NativeMethodInfoPtr_SetTargetGuardYuuSha_Private_Void_DLC4_GuardController_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x000D8EC8 File Offset: 0x000D70C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50328, XrefRangeEnd = 50330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardShinmyoumaru.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x000D8F04 File Offset: 0x000D7104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_GuardShinmyoumaru() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000D8F40 File Offset: 0x000D7140
		[CallerCount(0)]
		public unsafe bool _SkillAttack_b__19_0(DLC4_GuardController guard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.NativeMethodInfoPtr__SkillAttack_b__19_0_Private_Boolean_DLC4_GuardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x000D8F90 File Offset: 0x000D7190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SkillAttack_b__19_1(DLC4_GuardController guard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.NativeMethodInfoPtr__SkillAttack_b__19_1_Private_Boolean_DLC4_GuardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public DLC4_GuardShinmyoumaru(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x000D8FE0 File Offset: 0x000D71E0
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x0000AFFF File Offset: 0x000091FF
		public unsafe static int AURABURSTING_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_AURABURSTING_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_AURABURSTING_TAG, (void*)(&value));
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x000D8FFC File Offset: 0x000D71FC
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0000B00D File Offset: 0x0000920D
		public DLC4_GuardShinmyoumaru.ShinmyoumaruBullet m_Level1Bullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_Level1Bullet);
				return new DLC4_GuardShinmyoumaru.ShinmyoumaruBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_Level1Bullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x000D902C File Offset: 0x000D722C
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x0000B03B File Offset: 0x0000923B
		public DLC4_GuardShinmyoumaru.ShinmyoumaruBullet m_Level2Bullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_Level2Bullet);
				return new DLC4_GuardShinmyoumaru.ShinmyoumaruBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_Level2Bullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x000D905C File Offset: 0x000D725C
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x0000B069 File Offset: 0x00009269
		public unsafe int m_UltimateSkillDurationForSelf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_UltimateSkillDurationForSelf);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_UltimateSkillDurationForSelf)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x000D9084 File Offset: 0x000D7284
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x0000B084 File Offset: 0x00009284
		public unsafe float m_AttackSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_AttackSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_AttackSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x000D90AC File Offset: 0x000D72AC
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x0000B09F File Offset: 0x0000929F
		public unsafe float m_YuushaBuffBaseTimeForTeammate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffBaseTimeForTeammate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffBaseTimeForTeammate)) = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x000D90D4 File Offset: 0x000D72D4
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0000B0BA File Offset: 0x000092BA
		public unsafe int m_YuushaBuffAtLeastCostP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffAtLeastCostP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffAtLeastCostP)) = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x000D90FC File Offset: 0x000D72FC
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x0000B0D5 File Offset: 0x000092D5
		public unsafe float m_YuushaBuffAtLeastCostPPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffAtLeastCostPPercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffAtLeastCostPPercentage)) = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x000D9124 File Offset: 0x000D7324
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x0000B0F0 File Offset: 0x000092F0
		public unsafe int m_YuushaBuffCostPPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffCostPPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffCostPPerSec)) = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x000D914C File Offset: 0x000D734C
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x0000B10B File Offset: 0x0000930B
		public VFXPrefab m_YuushaBuffUIDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffUIDisplay);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffUIDisplay), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x000D917C File Offset: 0x000D737C
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0000B139 File Offset: 0x00009339
		public unsafe Vector2 m_YuushaBuffUIDisplayOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffUIDisplayOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaBuffUIDisplayOffset)) = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x000D91A4 File Offset: 0x000D73A4
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x0000B154 File Offset: 0x00009354
		public VFXPrefab m_YuushaNoChikara
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikara);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikara), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x000D91D4 File Offset: 0x000D73D4
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x0000B182 File Offset: 0x00009382
		public unsafe Vector2 m_YuushaNoChikaraOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraOffset)) = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x000D91FC File Offset: 0x000D73FC
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0000B19D File Offset: 0x0000939D
		public unsafe float m_YuushaNoChikaraWaitToEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraWaitToEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraWaitToEnable)) = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x000D9224 File Offset: 0x000D7424
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0000B1B8 File Offset: 0x000093B8
		public unsafe AudioClip m_YuushaNoChikaraSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x000D9254 File Offset: 0x000D7454
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0000B1D7 File Offset: 0x000093D7
		public GlobalAudioManager.DelayAudioClip m_YuushaNoChikaraWalletSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraWalletSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraWalletSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x000D9284 File Offset: 0x000D7484
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x0000B205 File Offset: 0x00009405
		public GlobalAudioManager.DelayAudioClip m_YuushaNoChikaraWalletBoomSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraWalletBoomSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.NativeFieldInfoPtr_m_YuushaNoChikaraWalletBoomSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeFieldInfoPtr_AURABURSTING_TAG;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeFieldInfoPtr_m_Level1Bullet;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeFieldInfoPtr_m_Level2Bullet;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeFieldInfoPtr_m_UltimateSkillDurationForSelf;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_m_AttackSpeedMultiplier;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaBuffBaseTimeForTeammate;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaBuffAtLeastCostP;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaBuffAtLeastCostPPercentage;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaBuffCostPPerSec;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaBuffUIDisplay;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaBuffUIDisplayOffset;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaNoChikara;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaNoChikaraOffset;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaNoChikaraWaitToEnable;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaNoChikaraSfx;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaNoChikaraWalletSfx;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeFieldInfoPtr_m_YuushaNoChikaraWalletBoomSfx;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetGuardYuuSha_Private_Void_DLC4_GuardController_Single_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr__SkillAttack_b__19_0_Private_Boolean_DLC4_GuardController_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr__SkillAttack_b__19_1_Private_Boolean_DLC4_GuardController_0;

		// Token: 0x020005A4 RID: 1444
		[Serializable]
		public sealed class ShinmyoumaruBullet : ValueType
		{
			// Token: 0x06008B67 RID: 35687 RVA: 0x00266950 File Offset: 0x00264B50
			// Note: this type is marked as 'beforefieldinit'.
			static ShinmyoumaruBullet()
			{
				Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "ShinmyoumaruBullet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr);
				DLC4_GuardShinmyoumaru.ShinmyoumaruBullet.NativeFieldInfoPtr_m_BaseBulletProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr, "m_BaseBulletProperty");
				DLC4_GuardShinmyoumaru.ShinmyoumaruBullet.NativeFieldInfoPtr_m_ShinmyoumaruBulletProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr, "m_ShinmyoumaruBulletProperty");
			}

			// Token: 0x06008B68 RID: 35688 RVA: 0x0004AE7B File Offset: 0x0004907B
			public ShinmyoumaruBullet(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008B69 RID: 35689 RVA: 0x0004AE84 File Offset: 0x00049084
			public ShinmyoumaruBullet() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr))
			{
			}

			// Token: 0x17002EAE RID: 11950
			// (get) Token: 0x06008B6A RID: 35690 RVA: 0x002669A4 File Offset: 0x00264BA4
			// (set) Token: 0x06008B6B RID: 35691 RVA: 0x0004AE96 File Offset: 0x00049096
			public DLC4_GuardController.TeamBulletProperty m_BaseBulletProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBullet.NativeFieldInfoPtr_m_BaseBulletProperty);
					return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBullet.NativeFieldInfoPtr_m_BaseBulletProperty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002EAF RID: 11951
			// (get) Token: 0x06008B6C RID: 35692 RVA: 0x002669D4 File Offset: 0x00264BD4
			// (set) Token: 0x06008B6D RID: 35693 RVA: 0x0004AEC4 File Offset: 0x000490C4
			public DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty m_ShinmyoumaruBulletProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBullet.NativeFieldInfoPtr_m_ShinmyoumaruBulletProperty);
					return new DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBullet.NativeFieldInfoPtr_m_ShinmyoumaruBulletProperty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005B51 RID: 23377
			private static readonly IntPtr NativeFieldInfoPtr_m_BaseBulletProperty;

			// Token: 0x04005B52 RID: 23378
			private static readonly IntPtr NativeFieldInfoPtr_m_ShinmyoumaruBulletProperty;
		}

		// Token: 0x020005A5 RID: 1445
		[Serializable]
		public sealed class ShinmyoumaruBulletProperty : ValueType
		{
			// Token: 0x06008B6E RID: 35694 RVA: 0x00266A04 File Offset: 0x00264C04
			// Note: this type is marked as 'beforefieldinit'.
			static ShinmyoumaruBulletProperty()
			{
				Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "ShinmyoumaruBulletProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr);
				DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr_m_StunDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr, "m_StunDuration");
				DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr_m_CanGetP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr, "m_CanGetP");
				DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr_m_PGetNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr, "m_PGetNum");
				DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr__TargetEnemy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr, "<TargetEnemy>k__BackingField");
				DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeMethodInfoPtr_get_TargetEnemy_Public_get_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr, 100666334);
				DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeMethodInfoPtr_set_TargetEnemy_Public_set_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr, 100666335);
			}

			// Token: 0x17002EB4 RID: 11956
			// (get) Token: 0x06008B6F RID: 35695 RVA: 0x00266AA8 File Offset: 0x00264CA8
			// (set) Token: 0x06008B70 RID: 35696 RVA: 0x00266AEC File Offset: 0x00264CEC
			public unsafe DLC4_FlandreEnemyCharacterController TargetEnemy
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeMethodInfoPtr_get_TargetEnemy_Public_get_DLC4_FlandreEnemyCharacterController_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr3) : null;
				}
				[CallerCount(18)]
				[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeMethodInfoPtr_set_TargetEnemy_Public_set_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008B71 RID: 35697 RVA: 0x0004AEF2 File Offset: 0x000490F2
			public ShinmyoumaruBulletProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008B72 RID: 35698 RVA: 0x0004AEFB File Offset: 0x000490FB
			public ShinmyoumaruBulletProperty() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr))
			{
			}

			// Token: 0x17002EB0 RID: 11952
			// (get) Token: 0x06008B73 RID: 35699 RVA: 0x00266B34 File Offset: 0x00264D34
			// (set) Token: 0x06008B74 RID: 35700 RVA: 0x0004AF0D File Offset: 0x0004910D
			public unsafe float m_StunDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr_m_StunDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr_m_StunDuration)) = value;
				}
			}

			// Token: 0x17002EB1 RID: 11953
			// (get) Token: 0x06008B75 RID: 35701 RVA: 0x00266B5C File Offset: 0x00264D5C
			// (set) Token: 0x06008B76 RID: 35702 RVA: 0x0004AF28 File Offset: 0x00049128
			public unsafe bool m_CanGetP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr_m_CanGetP);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr_m_CanGetP)) = value;
				}
			}

			// Token: 0x17002EB2 RID: 11954
			// (get) Token: 0x06008B77 RID: 35703 RVA: 0x00266B84 File Offset: 0x00264D84
			// (set) Token: 0x06008B78 RID: 35704 RVA: 0x0004AF43 File Offset: 0x00049143
			public unsafe int m_PGetNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr_m_PGetNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr_m_PGetNum)) = value;
				}
			}

			// Token: 0x17002EB3 RID: 11955
			// (get) Token: 0x06008B79 RID: 35705 RVA: 0x00266BAC File Offset: 0x00264DAC
			// (set) Token: 0x06008B7A RID: 35706 RVA: 0x0004AF5E File Offset: 0x0004915E
			public unsafe DLC4_FlandreEnemyCharacterController _TargetEnemy_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr__TargetEnemy_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty.NativeFieldInfoPtr__TargetEnemy_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B53 RID: 23379
			private static readonly IntPtr NativeFieldInfoPtr_m_StunDuration;

			// Token: 0x04005B54 RID: 23380
			private static readonly IntPtr NativeFieldInfoPtr_m_CanGetP;

			// Token: 0x04005B55 RID: 23381
			private static readonly IntPtr NativeFieldInfoPtr_m_PGetNum;

			// Token: 0x04005B56 RID: 23382
			private static readonly IntPtr NativeFieldInfoPtr__TargetEnemy_k__BackingField;

			// Token: 0x04005B57 RID: 23383
			private static readonly IntPtr NativeMethodInfoPtr_get_TargetEnemy_Public_get_DLC4_FlandreEnemyCharacterController_0;

			// Token: 0x04005B58 RID: 23384
			private static readonly IntPtr NativeMethodInfoPtr_set_TargetEnemy_Public_set_Void_DLC4_FlandreEnemyCharacterController_0;
		}

		// Token: 0x020005A6 RID: 1446
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardShinmyoumaru+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x06008B7B RID: 35707 RVA: 0x00266BDC File Offset: 0x00264DDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass18_0>.NativeClassPtr);
				DLC4_GuardShinmyoumaru.__c__DisplayClass18_0.NativeFieldInfoPtr_shootBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass18_0>.NativeClassPtr, "shootBullet");
				DLC4_GuardShinmyoumaru.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass18_0>.NativeClassPtr, 100666336);
				DLC4_GuardShinmyoumaru.__c__DisplayClass18_0.NativeMethodInfoPtr__NormalAttack_b__1_Internal_Void_DLC4_BulletMagicWallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass18_0>.NativeClassPtr, 100666337);
			}

			// Token: 0x06008B7C RID: 35708 RVA: 0x00266C44 File Offset: 0x00264E44
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B7D RID: 35709 RVA: 0x00266C80 File Offset: 0x00264E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50154, XrefRangeEnd = 50157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NormalAttack_b__1(DLC4_BulletMagicWallet x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.__c__DisplayClass18_0.NativeMethodInfoPtr__NormalAttack_b__1_Internal_Void_DLC4_BulletMagicWallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B7E RID: 35710 RVA: 0x0004AF7D File Offset: 0x0004917D
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EB5 RID: 11957
			// (get) Token: 0x06008B7F RID: 35711 RVA: 0x00266CC4 File Offset: 0x00264EC4
			// (set) Token: 0x06008B80 RID: 35712 RVA: 0x0004AF86 File Offset: 0x00049186
			public DLC4_GuardShinmyoumaru.ShinmyoumaruBullet shootBullet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.__c__DisplayClass18_0.NativeFieldInfoPtr_shootBullet);
					return new DLC4_GuardShinmyoumaru.ShinmyoumaruBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.__c__DisplayClass18_0.NativeFieldInfoPtr_shootBullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBullet>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005B59 RID: 23385
			private static readonly IntPtr NativeFieldInfoPtr_shootBullet;

			// Token: 0x04005B5A RID: 23386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B5B RID: 23387
			private static readonly IntPtr NativeMethodInfoPtr__NormalAttack_b__1_Internal_Void_DLC4_BulletMagicWallet_0;
		}

		// Token: 0x020005A7 RID: 1447
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardShinmyoumaru+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008B81 RID: 35713 RVA: 0x00266CF4 File Offset: 0x00264EF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c>.NativeClassPtr);
				DLC4_GuardShinmyoumaru.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c>.NativeClassPtr, "<>9");
				DLC4_GuardShinmyoumaru.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c>.NativeClassPtr, "<>9__18_0");
				DLC4_GuardShinmyoumaru.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c>.NativeClassPtr, 100666339);
				DLC4_GuardShinmyoumaru.__c.NativeMethodInfoPtr__NormalAttack_b__18_0_Internal_Single_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c>.NativeClassPtr, 100666340);
			}

			// Token: 0x06008B82 RID: 35714 RVA: 0x00266D70 File Offset: 0x00264F70
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B83 RID: 35715 RVA: 0x00266DAC File Offset: 0x00264FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NormalAttack_b__18_0(DLC4_FlandreEnemyCharacterController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.__c.NativeMethodInfoPtr__NormalAttack_b__18_0_Internal_Single_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008B84 RID: 35716 RVA: 0x0004AFB4 File Offset: 0x000491B4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EB6 RID: 11958
			// (get) Token: 0x06008B85 RID: 35717 RVA: 0x00266DFC File Offset: 0x00264FFC
			// (set) Token: 0x06008B86 RID: 35718 RVA: 0x0004AFBD File Offset: 0x000491BD
			public unsafe static DLC4_GuardShinmyoumaru.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardShinmyoumaru.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardShinmyoumaru.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardShinmyoumaru.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EB7 RID: 11959
			// (get) Token: 0x06008B87 RID: 35719 RVA: 0x00266E24 File Offset: 0x00265024
			// (set) Token: 0x06008B88 RID: 35720 RVA: 0x0004AFCF File Offset: 0x000491CF
			public unsafe static Func<DLC4_FlandreEnemyCharacterController, float> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardShinmyoumaru.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC4_FlandreEnemyCharacterController, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardShinmyoumaru.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B5C RID: 23388
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005B5D RID: 23389
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04005B5E RID: 23390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B5F RID: 23391
			private static readonly IntPtr NativeMethodInfoPtr__NormalAttack_b__18_0_Internal_Single_DLC4_FlandreEnemyCharacterController_0;
		}

		// Token: 0x020005A8 RID: 1448
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardShinmyoumaru+<SkillAttack>d__19")]
		public sealed class _SkillAttack_d__19 : Il2CppSystem.Object
		{
			// Token: 0x06008B89 RID: 35721 RVA: 0x00266E4C File Offset: 0x0026504C
			// Note: this type is marked as 'beforefieldinit'.
			static _SkillAttack_d__19()
			{
				Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "<SkillAttack>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr);
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, "<>1__state");
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, "<>2__current");
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, "<>4__this");
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr__costP_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, "<costP>5__2");
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr__allNearByTeammate_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, "<allNearByTeammate>5__3");
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, 100666341);
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, 100666342);
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, 100666343);
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, 100666344);
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, 100666345);
				DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr, 100666346);
			}

			// Token: 0x06008B8A RID: 35722 RVA: 0x00266F54 File Offset: 0x00265154
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SkillAttack_d__19(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru._SkillAttack_d__19>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B8B RID: 35723 RVA: 0x00266F9C File Offset: 0x0026519C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B8C RID: 35724 RVA: 0x00266FD0 File Offset: 0x002651D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50157, XrefRangeEnd = 50219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002EBD RID: 11965
			// (get) Token: 0x06008B8D RID: 35725 RVA: 0x0026700C File Offset: 0x0026520C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B8E RID: 35726 RVA: 0x0026704C File Offset: 0x0026524C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50219, XrefRangeEnd = 50225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002EBE RID: 11966
			// (get) Token: 0x06008B8F RID: 35727 RVA: 0x00267080 File Offset: 0x00265280
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B90 RID: 35728 RVA: 0x0004AFE1 File Offset: 0x000491E1
			public _SkillAttack_d__19(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EB8 RID: 11960
			// (get) Token: 0x06008B91 RID: 35729 RVA: 0x002670C0 File Offset: 0x002652C0
			// (set) Token: 0x06008B92 RID: 35730 RVA: 0x0004AFEA File Offset: 0x000491EA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002EB9 RID: 11961
			// (get) Token: 0x06008B93 RID: 35731 RVA: 0x002670E8 File Offset: 0x002652E8
			// (set) Token: 0x06008B94 RID: 35732 RVA: 0x0004B005 File Offset: 0x00049205
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EBA RID: 11962
			// (get) Token: 0x06008B95 RID: 35733 RVA: 0x00267118 File Offset: 0x00265318
			// (set) Token: 0x06008B96 RID: 35734 RVA: 0x0004B024 File Offset: 0x00049224
			public unsafe DLC4_GuardShinmyoumaru __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardShinmyoumaru>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EBB RID: 11963
			// (get) Token: 0x06008B97 RID: 35735 RVA: 0x00267148 File Offset: 0x00265348
			// (set) Token: 0x06008B98 RID: 35736 RVA: 0x0004B043 File Offset: 0x00049243
			public unsafe int _costP_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr__costP_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr__costP_5__2)) = value;
				}
			}

			// Token: 0x17002EBC RID: 11964
			// (get) Token: 0x06008B99 RID: 35737 RVA: 0x00267170 File Offset: 0x00265370
			// (set) Token: 0x06008B9A RID: 35738 RVA: 0x0004B05E File Offset: 0x0004925E
			public unsafe IEnumerable<DLC4_GuardController> _allNearByTeammate_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr__allNearByTeammate_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<DLC4_GuardController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru._SkillAttack_d__19.NativeFieldInfoPtr__allNearByTeammate_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B60 RID: 23392
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005B61 RID: 23393
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005B62 RID: 23394
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B63 RID: 23395
			private static readonly IntPtr NativeFieldInfoPtr__costP_5__2;

			// Token: 0x04005B64 RID: 23396
			private static readonly IntPtr NativeFieldInfoPtr__allNearByTeammate_5__3;

			// Token: 0x04005B65 RID: 23397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005B66 RID: 23398
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B67 RID: 23399
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005B68 RID: 23400
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005B69 RID: 23401
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B6A RID: 23402
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020005A9 RID: 1449
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardShinmyoumaru+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x06008B9B RID: 35739 RVA: 0x002671A0 File Offset: 0x002653A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass20_0>.NativeClassPtr);
				DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeFieldInfoPtr_guard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass20_0>.NativeClassPtr, "guard");
				DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass20_0>.NativeClassPtr, 100666347);
				DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeMethodInfoPtr__SetTargetGuardYuuSha_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass20_0>.NativeClassPtr, 100666348);
				DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeMethodInfoPtr__SetTargetGuardYuuSha_b__1_Internal_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass20_0>.NativeClassPtr, 100666349);
				DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeMethodInfoPtr__SetTargetGuardYuuSha_b__2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass20_0>.NativeClassPtr, 100666350);
			}

			// Token: 0x06008B9C RID: 35740 RVA: 0x00267244 File Offset: 0x00265444
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B9D RID: 35741 RVA: 0x00267280 File Offset: 0x00265480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50225, XrefRangeEnd = 50229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetTargetGuardYuuSha_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeMethodInfoPtr__SetTargetGuardYuuSha_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B9E RID: 35742 RVA: 0x002672B4 File Offset: 0x002654B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50229, XrefRangeEnd = 50241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameObject _SetTargetGuardYuuSha_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeMethodInfoPtr__SetTargetGuardYuuSha_b__1_Internal_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}

			// Token: 0x06008B9F RID: 35743 RVA: 0x002672F4 File Offset: 0x002654F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50241, XrefRangeEnd = 50252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetTargetGuardYuuSha_b__2(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeMethodInfoPtr__SetTargetGuardYuuSha_b__2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BA0 RID: 35744 RVA: 0x0004B07D File Offset: 0x0004927D
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EBF RID: 11967
			// (get) Token: 0x06008BA1 RID: 35745 RVA: 0x00267338 File Offset: 0x00265538
			// (set) Token: 0x06008BA2 RID: 35746 RVA: 0x0004B086 File Offset: 0x00049286
			public unsafe DLC4_GuardController guard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeFieldInfoPtr_guard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeFieldInfoPtr_guard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EC0 RID: 11968
			// (get) Token: 0x06008BA3 RID: 35747 RVA: 0x00267368 File Offset: 0x00265568
			// (set) Token: 0x06008BA4 RID: 35748 RVA: 0x0004B0A5 File Offset: 0x000492A5
			public unsafe DLC4_GuardShinmyoumaru __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardShinmyoumaru>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardShinmyoumaru.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B6B RID: 23403
			private static readonly IntPtr NativeFieldInfoPtr_guard;

			// Token: 0x04005B6C RID: 23404
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B6D RID: 23405
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B6E RID: 23406
			private static readonly IntPtr NativeMethodInfoPtr__SetTargetGuardYuuSha_b__0_Internal_Void_0;

			// Token: 0x04005B6F RID: 23407
			private static readonly IntPtr NativeMethodInfoPtr__SetTargetGuardYuuSha_b__1_Internal_GameObject_0;

			// Token: 0x04005B70 RID: 23408
			private static readonly IntPtr NativeMethodInfoPtr__SetTargetGuardYuuSha_b__2_Internal_Void_GameObject_0;
		}
	}
}
