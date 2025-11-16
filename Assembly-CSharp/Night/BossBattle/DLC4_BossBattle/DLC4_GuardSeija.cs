using System;
using Common.Audio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000A3 RID: 163
	public class DLC4_GuardSeija : DLC4_GuardController
	{
		// Token: 0x060010F8 RID: 4344 RVA: 0x000D7DEC File Offset: 0x000D5FEC
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_GuardSeija()
		{
			Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_GuardSeija");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr);
			DLC4_GuardSeija.NativeFieldInfoPtr_SHINMYOUMARU_GUARD_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "SHINMYOUMARU_GUARD_ID");
			DLC4_GuardSeija.NativeFieldInfoPtr_PUT_ON_ANIM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "PUT_ON_ANIM");
			DLC4_GuardSeija.NativeFieldInfoPtr_TAKE_OFF_ANIM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "TAKE_OFF_ANIM");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_SingleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_SingleMultiplier");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_SeijaBowBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_SeijaBowBullet");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_SeijaBowBullet2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_SeijaBowBullet2");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_BulletLaunchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_BulletLaunchHeight");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_UltimateSkillReverseNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_UltimateSkillReverseNum");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_UltimateSkillReverseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_UltimateSkillReverseDuration");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_StealthBlanket");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanketOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_StealthBlanketOffset");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanketDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_StealthBlanketDuration");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanketCoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_StealthBlanketCoolDown");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_BoomBalloonVFX");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonSpawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_BalloonSpawnOffset");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonBombOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_BalloonBombOffset");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_BoomBalloonDelay");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonFlyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_BoomBalloonFlyTime");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_BoomBalloonRemaining");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_BlanketSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_BlanketSfx");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonLiftSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_BalloonLiftSfx");
			DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonBoomSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "m_BalloonBoomSfx");
			DLC4_GuardSeija.NativeFieldInfoPtr_blanketAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "blanketAnimator");
			DLC4_GuardSeija.NativeFieldInfoPtr_currentBlanketStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "currentBlanketStatus");
			DLC4_GuardSeija.NativeFieldInfoPtr_normalAttackCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "normalAttackCoroutine");
			DLC4_GuardSeija.NativeFieldInfoPtr_stealthBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "stealthBlanket");
			DLC4_GuardSeija.NativeFieldInfoPtr_stealthBlanketRemainingCoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "stealthBlanketRemainingCoolDown");
			DLC4_GuardSeija.NativeFieldInfoPtr_stealthBlanketRemainingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "stealthBlanketRemainingDuration");
			DLC4_GuardSeija.NativeMethodInfoPtr_SetIgnoreStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666275);
			DLC4_GuardSeija.NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666276);
			DLC4_GuardSeija.NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666277);
			DLC4_GuardSeija.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666278);
			DLC4_GuardSeija.NativeMethodInfoPtr_GetPower_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666279);
			DLC4_GuardSeija.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666280);
			DLC4_GuardSeija.NativeMethodInfoPtr_NormalShootBow_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666281);
			DLC4_GuardSeija.NativeMethodInfoPtr_ShootBow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666282);
			DLC4_GuardSeija.NativeMethodInfoPtr_TargetEnemyPosition_Private_Nullable_1_Vector2_Single_byref_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666283);
			DLC4_GuardSeija.NativeMethodInfoPtr_GetTargetEnemyPosition_Private_Static_Vector2_Single_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666284);
			DLC4_GuardSeija.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666285);
			DLC4_GuardSeija.NativeMethodInfoPtr_SetReverse_Private_IEnumerator_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666286);
			DLC4_GuardSeija.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666287);
			DLC4_GuardSeija.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666288);
			DLC4_GuardSeija.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666289);
			DLC4_GuardSeija.NativeMethodInfoPtr__OnUpdate_b__31_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666290);
			DLC4_GuardSeija.NativeMethodInfoPtr__GetPower_b__32_0_Private_Boolean_DLC4_GuardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666291);
			DLC4_GuardSeija.NativeMethodInfoPtr__GetPower_b__32_1_Private_Boolean_DLC4_GuardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666292);
			DLC4_GuardSeija.NativeMethodInfoPtr__TargetEnemyPosition_b__36_0_Private_Single_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, 100666293);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x000D81C8 File Offset: 0x000D63C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 50003, RefRangeEnd = 50006, XrefRangeStart = 49972, XrefRangeEnd = 50003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIgnoreStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr_SetIgnoreStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x000D81FC File Offset: 0x000D63FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50006, XrefRangeEnd = 50007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuardControllerEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardSeija.NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000D8238 File Offset: 0x000D6438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50007, XrefRangeEnd = 50012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CouldAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardSeija.NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x000D8280 File Offset: 0x000D6480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50012, XrefRangeEnd = 50028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardSeija.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x000D82BC File Offset: 0x000D64BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 50046, RefRangeEnd = 50049, XrefRangeStart = 50028, XrefRangeEnd = 50046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPower()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr_GetPower_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x000D82F8 File Offset: 0x000D64F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50049, XrefRangeEnd = 50057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NormalAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardSeija.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x000D8334 File Offset: 0x000D6534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50057, XrefRangeEnd = 50062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator NormalShootBow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr_NormalShootBow_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x000D8374 File Offset: 0x000D6574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50095, RefRangeEnd = 50096, XrefRangeStart = 50062, XrefRangeEnd = 50095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShootBow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr_ShootBow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000D83A8 File Offset: 0x000D65A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50124, RefRangeEnd = 50125, XrefRangeStart = 50096, XrefRangeEnd = 50124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<Vector2> TargetEnemyPosition(float bulletSpeed, out DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bulletSpeed;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr2;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr_TargetEnemyPosition_Private_Nullable_1_Vector2_Single_byref_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			enemy = ((intPtr3 == 0) ? null : new DLC4_FlandreEnemyCharacterController(intPtr3));
			return new Nullable<Vector2>(pointer);
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x000D8410 File Offset: 0x000D6610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50127, RefRangeEnd = 50128, XrefRangeStart = 50125, XrefRangeEnd = 50127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetTargetEnemyPosition(float bulletSpeed, DLC4_FlandreEnemyCharacterController enemy)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bulletSpeed;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr_GetTargetEnemyPosition_Private_Static_Vector2_Single_DLC4_FlandreEnemyCharacterController_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x000D8460 File Offset: 0x000D6660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50128, XrefRangeEnd = 50133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator SkillAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardSeija.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000D84AC File Offset: 0x000D66AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50133, XrefRangeEnd = 50139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetReverse(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr_SetReverse_Private_IEnumerator_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x000D84FC File Offset: 0x000D66FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50139, XrefRangeEnd = 50141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardSeija.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x000D8538 File Offset: 0x000D6738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50141, XrefRangeEnd = 50146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardSeija.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x000D8574 File Offset: 0x000D6774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_GuardSeija() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x000D85B0 File Offset: 0x000D67B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50146, XrefRangeEnd = 50147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnUpdate_b__31_0(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr__OnUpdate_b__31_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x000D8600 File Offset: 0x000D6800
		[CallerCount(0)]
		public unsafe bool _GetPower_b__32_0(DLC4_GuardController guard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr__GetPower_b__32_0_Private_Boolean_DLC4_GuardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x000D8650 File Offset: 0x000D6850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50147, XrefRangeEnd = 50150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetPower_b__32_1(DLC4_GuardController guard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr__GetPower_b__32_1_Private_Boolean_DLC4_GuardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x000D86A0 File Offset: 0x000D68A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50150, XrefRangeEnd = 50154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _TargetEnemyPosition_b__36_0(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.NativeMethodInfoPtr__TargetEnemyPosition_b__36_0_Private_Single_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0000AC96 File Offset: 0x00008E96
		public DLC4_GuardSeija(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000D86F0 File Offset: 0x000D68F0
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x0000AC9F File Offset: 0x00008E9F
		public unsafe static int SHINMYOUMARU_GUARD_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_GuardSeija.NativeFieldInfoPtr_SHINMYOUMARU_GUARD_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_GuardSeija.NativeFieldInfoPtr_SHINMYOUMARU_GUARD_ID, (void*)(&value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000D870C File Offset: 0x000D690C
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x0000ACAD File Offset: 0x00008EAD
		public unsafe static string PUT_ON_ANIM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_GuardSeija.NativeFieldInfoPtr_PUT_ON_ANIM, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_GuardSeija.NativeFieldInfoPtr_PUT_ON_ANIM, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x000D872C File Offset: 0x000D692C
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x0000ACBF File Offset: 0x00008EBF
		public unsafe static string TAKE_OFF_ANIM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_GuardSeija.NativeFieldInfoPtr_TAKE_OFF_ANIM, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_GuardSeija.NativeFieldInfoPtr_TAKE_OFF_ANIM, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x000D874C File Offset: 0x000D694C
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x0000ACD1 File Offset: 0x00008ED1
		public unsafe float m_SingleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_SingleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_SingleMultiplier)) = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x000D8774 File Offset: 0x000D6974
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public DLC4_GuardController.TeamBulletProperty m_SeijaBowBullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_SeijaBowBullet);
				return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_SeijaBowBullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x000D87A4 File Offset: 0x000D69A4
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x0000AD1A File Offset: 0x00008F1A
		public DLC4_GuardController.TeamBulletProperty m_SeijaBowBullet2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_SeijaBowBullet2);
				return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_SeijaBowBullet2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x000D87D4 File Offset: 0x000D69D4
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x0000AD48 File Offset: 0x00008F48
		public unsafe float m_BulletLaunchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BulletLaunchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BulletLaunchHeight)) = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x000D87FC File Offset: 0x000D69FC
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x0000AD63 File Offset: 0x00008F63
		public unsafe int m_UltimateSkillReverseNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_UltimateSkillReverseNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_UltimateSkillReverseNum)) = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x000D8824 File Offset: 0x000D6A24
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x0000AD7E File Offset: 0x00008F7E
		public unsafe float m_UltimateSkillReverseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_UltimateSkillReverseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_UltimateSkillReverseDuration)) = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x000D884C File Offset: 0x000D6A4C
		// (set) Token: 0x06001120 RID: 4384 RVA: 0x0000AD99 File Offset: 0x00008F99
		public unsafe GameObject m_StealthBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x000D887C File Offset: 0x000D6A7C
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		public unsafe Vector2 m_StealthBlanketOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanketOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanketOffset)) = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x000D88A4 File Offset: 0x000D6AA4
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x0000ADD3 File Offset: 0x00008FD3
		public unsafe float m_StealthBlanketDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanketDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanketDuration)) = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x000D88CC File Offset: 0x000D6ACC
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x0000ADEE File Offset: 0x00008FEE
		public unsafe float m_StealthBlanketCoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanketCoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_StealthBlanketCoolDown)) = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x000D88F4 File Offset: 0x000D6AF4
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x0000AE09 File Offset: 0x00009009
		public VFXPrefab m_BoomBalloonVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x000D8924 File Offset: 0x000D6B24
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0000AE37 File Offset: 0x00009037
		public unsafe Vector2 m_BalloonSpawnOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonSpawnOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonSpawnOffset)) = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x000D894C File Offset: 0x000D6B4C
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0000AE52 File Offset: 0x00009052
		public unsafe Vector2 m_BalloonBombOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonBombOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonBombOffset)) = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x000D8974 File Offset: 0x000D6B74
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x0000AE6D File Offset: 0x0000906D
		public unsafe float m_BoomBalloonDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonDelay)) = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x000D899C File Offset: 0x000D6B9C
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x0000AE88 File Offset: 0x00009088
		public unsafe float m_BoomBalloonFlyTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonFlyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonFlyTime)) = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x000D89C4 File Offset: 0x000D6BC4
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x0000AEA3 File Offset: 0x000090A3
		public unsafe float m_BoomBalloonRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonRemaining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BoomBalloonRemaining)) = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x000D89EC File Offset: 0x000D6BEC
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x0000AEBE File Offset: 0x000090BE
		public GlobalAudioManager.DelayAudioClip m_BlanketSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BlanketSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BlanketSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x000D8A1C File Offset: 0x000D6C1C
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x0000AEEC File Offset: 0x000090EC
		public GlobalAudioManager.DelayAudioClip m_BalloonLiftSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonLiftSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonLiftSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x000D8A4C File Offset: 0x000D6C4C
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x0000AF1A File Offset: 0x0000911A
		public GlobalAudioManager.DelayAudioClip m_BalloonBoomSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonBoomSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_m_BalloonBoomSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x000D8A7C File Offset: 0x000D6C7C
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x0000AF48 File Offset: 0x00009148
		public unsafe Animator blanketAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_blanketAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_blanketAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x000D8AAC File Offset: 0x000D6CAC
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x0000AF67 File Offset: 0x00009167
		public unsafe DLC4_GuardSeija.BlanketStatus currentBlanketStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_currentBlanketStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_currentBlanketStatus)) = value;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x000D8AD4 File Offset: 0x000D6CD4
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x0000AF82 File Offset: 0x00009182
		public unsafe Coroutine normalAttackCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_normalAttackCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_normalAttackCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x000D8B04 File Offset: 0x000D6D04
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x0000AFA1 File Offset: 0x000091A1
		public unsafe GameObject stealthBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_stealthBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_stealthBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x000D8B34 File Offset: 0x000D6D34
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x0000AFC0 File Offset: 0x000091C0
		public unsafe float stealthBlanketRemainingCoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_stealthBlanketRemainingCoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_stealthBlanketRemainingCoolDown)) = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x000D8B5C File Offset: 0x000D6D5C
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x0000AFDB File Offset: 0x000091DB
		public unsafe float stealthBlanketRemainingDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_stealthBlanketRemainingDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.NativeFieldInfoPtr_stealthBlanketRemainingDuration)) = value;
			}
		}

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeFieldInfoPtr_SHINMYOUMARU_GUARD_ID;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeFieldInfoPtr_PUT_ON_ANIM;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeFieldInfoPtr_TAKE_OFF_ANIM;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleMultiplier;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeFieldInfoPtr_m_SeijaBowBullet;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeFieldInfoPtr_m_SeijaBowBullet2;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeFieldInfoPtr_m_BulletLaunchHeight;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeFieldInfoPtr_m_UltimateSkillReverseNum;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeFieldInfoPtr_m_UltimateSkillReverseDuration;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeFieldInfoPtr_m_StealthBlanket;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeFieldInfoPtr_m_StealthBlanketOffset;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeFieldInfoPtr_m_StealthBlanketDuration;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeFieldInfoPtr_m_StealthBlanketCoolDown;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr_m_BoomBalloonVFX;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeFieldInfoPtr_m_BalloonSpawnOffset;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeFieldInfoPtr_m_BalloonBombOffset;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeFieldInfoPtr_m_BoomBalloonDelay;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeFieldInfoPtr_m_BoomBalloonFlyTime;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeFieldInfoPtr_m_BoomBalloonRemaining;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeFieldInfoPtr_m_BlanketSfx;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeFieldInfoPtr_m_BalloonLiftSfx;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeFieldInfoPtr_m_BalloonBoomSfx;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeFieldInfoPtr_blanketAnimator;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeFieldInfoPtr_currentBlanketStatus;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeFieldInfoPtr_normalAttackCoroutine;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeFieldInfoPtr_stealthBlanket;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeFieldInfoPtr_stealthBlanketRemainingCoolDown;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeFieldInfoPtr_stealthBlanketRemainingDuration;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnoreStatus_Private_Void_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_GetPower_Public_Single_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_NormalShootBow_Private_IEnumerator_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_ShootBow_Private_Void_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_TargetEnemyPosition_Private_Nullable_1_Vector2_Single_byref_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetEnemyPosition_Private_Static_Vector2_Single_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_SetReverse_Private_IEnumerator_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__31_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr__GetPower_b__32_0_Private_Boolean_DLC4_GuardController_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr__GetPower_b__32_1_Private_Boolean_DLC4_GuardController_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr__TargetEnemyPosition_b__36_0_Private_Single_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x0200059D RID: 1437
		public enum BlanketStatus
		{
			// Token: 0x04005B1E RID: 23326
			Idle,
			// Token: 0x04005B1F RID: 23327
			Triggered,
			// Token: 0x04005B20 RID: 23328
			CoolDown
		}

		// Token: 0x0200059E RID: 1438
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardSeija+<NormalShootBow>d__34")]
		public sealed class _NormalShootBow_d__34 : Il2CppSystem.Object
		{
			// Token: 0x06008B15 RID: 35605 RVA: 0x00265A58 File Offset: 0x00263C58
			// Note: this type is marked as 'beforefieldinit'.
			static _NormalShootBow_d__34()
			{
				Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "<NormalShootBow>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr);
				DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, "<>1__state");
				DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, "<>2__current");
				DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, "<>4__this");
				DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr__isLevel2_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, "<isLevel2>5__2");
				DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr__wait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, "<wait>5__3");
				DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, "<i>5__4");
				DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, 100666294);
				DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, 100666295);
				DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, 100666296);
				DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, 100666297);
				DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, 100666298);
				DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr, 100666299);
			}

			// Token: 0x06008B16 RID: 35606 RVA: 0x00265B74 File Offset: 0x00263D74
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NormalShootBow_d__34(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardSeija._NormalShootBow_d__34>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B17 RID: 35607 RVA: 0x00265BBC File Offset: 0x00263DBC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B18 RID: 35608 RVA: 0x00265BF0 File Offset: 0x00263DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49883, XrefRangeEnd = 49891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E98 RID: 11928
			// (get) Token: 0x06008B19 RID: 35609 RVA: 0x00265C2C File Offset: 0x00263E2C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B1A RID: 35610 RVA: 0x00265C6C File Offset: 0x00263E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49891, XrefRangeEnd = 49897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E99 RID: 11929
			// (get) Token: 0x06008B1B RID: 35611 RVA: 0x00265CA0 File Offset: 0x00263EA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._NormalShootBow_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B1C RID: 35612 RVA: 0x0004ABA4 File Offset: 0x00048DA4
			public _NormalShootBow_d__34(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E92 RID: 11922
			// (get) Token: 0x06008B1D RID: 35613 RVA: 0x00265CE0 File Offset: 0x00263EE0
			// (set) Token: 0x06008B1E RID: 35614 RVA: 0x0004ABAD File Offset: 0x00048DAD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E93 RID: 11923
			// (get) Token: 0x06008B1F RID: 35615 RVA: 0x00265D08 File Offset: 0x00263F08
			// (set) Token: 0x06008B20 RID: 35616 RVA: 0x0004ABC8 File Offset: 0x00048DC8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E94 RID: 11924
			// (get) Token: 0x06008B21 RID: 35617 RVA: 0x00265D38 File Offset: 0x00263F38
			// (set) Token: 0x06008B22 RID: 35618 RVA: 0x0004ABE7 File Offset: 0x00048DE7
			public unsafe DLC4_GuardSeija __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardSeija>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E95 RID: 11925
			// (get) Token: 0x06008B23 RID: 35619 RVA: 0x00265D68 File Offset: 0x00263F68
			// (set) Token: 0x06008B24 RID: 35620 RVA: 0x0004AC06 File Offset: 0x00048E06
			public unsafe bool _isLevel2_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr__isLevel2_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr__isLevel2_5__2)) = value;
				}
			}

			// Token: 0x17002E96 RID: 11926
			// (get) Token: 0x06008B25 RID: 35621 RVA: 0x00265D90 File Offset: 0x00263F90
			// (set) Token: 0x06008B26 RID: 35622 RVA: 0x0004AC21 File Offset: 0x00048E21
			public unsafe WaitForSeconds _wait_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr__wait_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr__wait_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E97 RID: 11927
			// (get) Token: 0x06008B27 RID: 35623 RVA: 0x00265DC0 File Offset: 0x00263FC0
			// (set) Token: 0x06008B28 RID: 35624 RVA: 0x0004AC40 File Offset: 0x00048E40
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._NormalShootBow_d__34.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04005B21 RID: 23329
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005B22 RID: 23330
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005B23 RID: 23331
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B24 RID: 23332
			private static readonly IntPtr NativeFieldInfoPtr__isLevel2_5__2;

			// Token: 0x04005B25 RID: 23333
			private static readonly IntPtr NativeFieldInfoPtr__wait_5__3;

			// Token: 0x04005B26 RID: 23334
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04005B27 RID: 23335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005B28 RID: 23336
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B29 RID: 23337
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005B2A RID: 23338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005B2B RID: 23339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B2C RID: 23340
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200059F RID: 1439
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardSeija+<>c__DisplayClass35_0")]
		public new sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x06008B29 RID: 35625 RVA: 0x00265DE8 File Offset: 0x00263FE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass35_0>.NativeClassPtr);
				DLC4_GuardSeija.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				DLC4_GuardSeija.__c__DisplayClass35_0.NativeFieldInfoPtr_targetEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass35_0>.NativeClassPtr, "targetEnemy");
				DLC4_GuardSeija.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass35_0>.NativeClassPtr, 100666300);
				DLC4_GuardSeija.__c__DisplayClass35_0.NativeMethodInfoPtr__ShootBow_b__0_Internal_Void_DLC4_BulletSeijaBow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass35_0>.NativeClassPtr, 100666301);
				DLC4_GuardSeija.__c__DisplayClass35_0.NativeMethodInfoPtr__ShootBow_b__1_Internal_Void_DLC4_BulletTeamParabolic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass35_0>.NativeClassPtr, 100666302);
			}

			// Token: 0x06008B2A RID: 35626 RVA: 0x00265E78 File Offset: 0x00264078
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B2B RID: 35627 RVA: 0x00265EB4 File Offset: 0x002640B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49897, XrefRangeEnd = 49899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShootBow_b__0(DLC4_BulletSeijaBow x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass35_0.NativeMethodInfoPtr__ShootBow_b__0_Internal_Void_DLC4_BulletSeijaBow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B2C RID: 35628 RVA: 0x00265EF8 File Offset: 0x002640F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49899, XrefRangeEnd = 49908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShootBow_b__1(DLC4_BulletTeamParabolic x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass35_0.NativeMethodInfoPtr__ShootBow_b__1_Internal_Void_DLC4_BulletTeamParabolic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B2D RID: 35629 RVA: 0x0004AC5B File Offset: 0x00048E5B
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E9A RID: 11930
			// (get) Token: 0x06008B2E RID: 35630 RVA: 0x00265F3C File Offset: 0x0026413C
			// (set) Token: 0x06008B2F RID: 35631 RVA: 0x0004AC64 File Offset: 0x00048E64
			public unsafe DLC4_GuardSeija __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardSeija>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E9B RID: 11931
			// (get) Token: 0x06008B30 RID: 35632 RVA: 0x00265F6C File Offset: 0x0026416C
			// (set) Token: 0x06008B31 RID: 35633 RVA: 0x0004AC83 File Offset: 0x00048E83
			public Nullable<Vector2> targetEnemy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass35_0.NativeFieldInfoPtr_targetEnemy);
					return new Nullable<Vector2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector2>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass35_0.NativeFieldInfoPtr_targetEnemy), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector2>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005B2D RID: 23341
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B2E RID: 23342
			private static readonly IntPtr NativeFieldInfoPtr_targetEnemy;

			// Token: 0x04005B2F RID: 23343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B30 RID: 23344
			private static readonly IntPtr NativeMethodInfoPtr__ShootBow_b__0_Internal_Void_DLC4_BulletSeijaBow_0;

			// Token: 0x04005B31 RID: 23345
			private static readonly IntPtr NativeMethodInfoPtr__ShootBow_b__1_Internal_Void_DLC4_BulletTeamParabolic_0;
		}

		// Token: 0x020005A0 RID: 1440
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardSeija+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x06008B32 RID: 35634 RVA: 0x00265F9C File Offset: 0x0026419C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_0>.NativeClassPtr);
				DLC4_GuardSeija.__c__DisplayClass38_0.NativeFieldInfoPtr_bombPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_0>.NativeClassPtr, "bombPosition");
				DLC4_GuardSeija.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				DLC4_GuardSeija.__c__DisplayClass38_0.NativeFieldInfoPtr_bowBulletWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_0>.NativeClassPtr, "bowBulletWait");
				DLC4_GuardSeija.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_0>.NativeClassPtr, 100666303);
				DLC4_GuardSeija.__c__DisplayClass38_0.NativeMethodInfoPtr__SkillAttack_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_0>.NativeClassPtr, 100666304);
			}

			// Token: 0x06008B33 RID: 35635 RVA: 0x0026602C File Offset: 0x0026422C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B34 RID: 35636 RVA: 0x00266068 File Offset: 0x00264268
			[CallerCount(0)]
			public unsafe Vector3 _SkillAttack_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_0.NativeMethodInfoPtr__SkillAttack_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008B35 RID: 35637 RVA: 0x0004ACB1 File Offset: 0x00048EB1
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E9C RID: 11932
			// (get) Token: 0x06008B36 RID: 35638 RVA: 0x002660A4 File Offset: 0x002642A4
			// (set) Token: 0x06008B37 RID: 35639 RVA: 0x0004ACBA File Offset: 0x00048EBA
			public unsafe Vector3 bombPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_0.NativeFieldInfoPtr_bombPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_0.NativeFieldInfoPtr_bombPosition)) = value;
				}
			}

			// Token: 0x17002E9D RID: 11933
			// (get) Token: 0x06008B38 RID: 35640 RVA: 0x002660CC File Offset: 0x002642CC
			// (set) Token: 0x06008B39 RID: 35641 RVA: 0x0004ACD5 File Offset: 0x00048ED5
			public unsafe DLC4_GuardSeija __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardSeija>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E9E RID: 11934
			// (get) Token: 0x06008B3A RID: 35642 RVA: 0x002660FC File Offset: 0x002642FC
			// (set) Token: 0x06008B3B RID: 35643 RVA: 0x0004ACF4 File Offset: 0x00048EF4
			public unsafe WaitForSeconds bowBulletWait
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_0.NativeFieldInfoPtr_bowBulletWait);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_0.NativeFieldInfoPtr_bowBulletWait), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B32 RID: 23346
			private static readonly IntPtr NativeFieldInfoPtr_bombPosition;

			// Token: 0x04005B33 RID: 23347
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B34 RID: 23348
			private static readonly IntPtr NativeFieldInfoPtr_bowBulletWait;

			// Token: 0x04005B35 RID: 23349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B36 RID: 23350
			private static readonly IntPtr NativeMethodInfoPtr__SkillAttack_b__0_Internal_Vector3_0;
		}

		// Token: 0x020005A1 RID: 1441
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardSeija+<>c__DisplayClass38_1")]
		public sealed class __c__DisplayClass38_1 : Il2CppSystem.Object
		{
			// Token: 0x06008B3C RID: 35644 RVA: 0x0026612C File Offset: 0x0026432C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_1()
			{
				Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "<>c__DisplayClass38_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1>.NativeClassPtr);
				DLC4_GuardSeija.__c__DisplayClass38_1.NativeFieldInfoPtr_targetEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1>.NativeClassPtr, "targetEnemy");
				DLC4_GuardSeija.__c__DisplayClass38_1.NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC4_GuardSeija.__c__DisplayClass38_1.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1>.NativeClassPtr, "<>9__2");
				DLC4_GuardSeija.__c__DisplayClass38_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1>.NativeClassPtr, 100666305);
				DLC4_GuardSeija.__c__DisplayClass38_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1>.NativeClassPtr, 100666306);
				DLC4_GuardSeija.__c__DisplayClass38_1.NativeMethodInfoPtr__SkillAttack_b__2_Internal_Void_DLC4_BulletTeamParabolic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1>.NativeClassPtr, 100666307);
			}

			// Token: 0x06008B3D RID: 35645 RVA: 0x002661D0 File Offset: 0x002643D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B3E RID: 35646 RVA: 0x0026620C File Offset: 0x0026440C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49929, XrefRangeEnd = 49934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008B3F RID: 35647 RVA: 0x0026624C File Offset: 0x0026444C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49934, XrefRangeEnd = 49941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SkillAttack_b__2(DLC4_BulletTeamParabolic x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_1.NativeMethodInfoPtr__SkillAttack_b__2_Internal_Void_DLC4_BulletTeamParabolic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B40 RID: 35648 RVA: 0x0004AD13 File Offset: 0x00048F13
			public __c__DisplayClass38_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E9F RID: 11935
			// (get) Token: 0x06008B41 RID: 35649 RVA: 0x00266290 File Offset: 0x00264490
			// (set) Token: 0x06008B42 RID: 35650 RVA: 0x0004AD1C File Offset: 0x00048F1C
			public unsafe DLC4_FlandreEnemyCharacterController targetEnemy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.NativeFieldInfoPtr_targetEnemy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.NativeFieldInfoPtr_targetEnemy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EA0 RID: 11936
			// (get) Token: 0x06008B43 RID: 35651 RVA: 0x002662C0 File Offset: 0x002644C0
			// (set) Token: 0x06008B44 RID: 35652 RVA: 0x0004AD3B File Offset: 0x00048F3B
			public unsafe DLC4_GuardSeija.__c__DisplayClass38_0 field_Public___c__DisplayClass38_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardSeija.__c__DisplayClass38_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EA1 RID: 11937
			// (get) Token: 0x06008B45 RID: 35653 RVA: 0x002662F0 File Offset: 0x002644F0
			// (set) Token: 0x06008B46 RID: 35654 RVA: 0x0004AD5A File Offset: 0x00048F5A
			public unsafe Action<DLC4_BulletTeamParabolic> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DLC4_BulletTeamParabolic>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B37 RID: 23351
			private static readonly IntPtr NativeFieldInfoPtr_targetEnemy;

			// Token: 0x04005B38 RID: 23352
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_0;

			// Token: 0x04005B39 RID: 23353
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04005B3A RID: 23354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B3B RID: 23355
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04005B3C RID: 23356
			private static readonly IntPtr NativeMethodInfoPtr__SkillAttack_b__2_Internal_Void_DLC4_BulletTeamParabolic_0;

			// Token: 0x02000FB6 RID: 4022
			[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardSeija+<>c__DisplayClass38_1+<<SkillAttack>g__SkillShoot|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601156B RID: 71019 RVA: 0x003FD3A8 File Offset: 0x003FB5A8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique()
				{
					Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1>.NativeClassPtr, "<<SkillAttack>g__SkillShoot|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr);
					DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>1__state");
					DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>2__current");
					DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>4__this");
					DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<i>5__2");
					DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100666308);
					DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100666309);
					DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100666310);
					DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100666311);
					DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100666312);
					DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100666313);
				}

				// Token: 0x0601156C RID: 71020 RVA: 0x003FD49C File Offset: 0x003FB69C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601156D RID: 71021 RVA: 0x003FD4E4 File Offset: 0x003FB6E4
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601156E RID: 71022 RVA: 0x003FD518 File Offset: 0x003FB718
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49908, XrefRangeEnd = 49923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005A26 RID: 23078
				// (get) Token: 0x0601156F RID: 71023 RVA: 0x003FD554 File Offset: 0x003FB754
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011570 RID: 71024 RVA: 0x003FD594 File Offset: 0x003FB794
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49923, XrefRangeEnd = 49929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005A27 RID: 23079
				// (get) Token: 0x06011571 RID: 71025 RVA: 0x003FD5C8 File Offset: 0x003FB7C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011572 RID: 71026 RVA: 0x00096C85 File Offset: 0x00094E85
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A22 RID: 23074
				// (get) Token: 0x06011573 RID: 71027 RVA: 0x003FD608 File Offset: 0x003FB808
				// (set) Token: 0x06011574 RID: 71028 RVA: 0x00096C8E File Offset: 0x00094E8E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A23 RID: 23075
				// (get) Token: 0x06011575 RID: 71029 RVA: 0x003FD630 File Offset: 0x003FB830
				// (set) Token: 0x06011576 RID: 71030 RVA: 0x00096CA9 File Offset: 0x00094EA9
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A24 RID: 23076
				// (get) Token: 0x06011577 RID: 71031 RVA: 0x003FD660 File Offset: 0x003FB860
				// (set) Token: 0x06011578 RID: 71032 RVA: 0x00096CC8 File Offset: 0x00094EC8
				public unsafe DLC4_GuardSeija.__c__DisplayClass38_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardSeija.__c__DisplayClass38_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A25 RID: 23077
				// (get) Token: 0x06011579 RID: 71033 RVA: 0x003FD690 File Offset: 0x003FB890
				// (set) Token: 0x0601157A RID: 71034 RVA: 0x00096CE7 File Offset: 0x00094EE7
				public unsafe int _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija.__c__DisplayClass38_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400AF40 RID: 44864
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AF41 RID: 44865
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AF42 RID: 44866
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AF43 RID: 44867
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400AF44 RID: 44868
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AF45 RID: 44869
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF46 RID: 44870
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AF47 RID: 44871
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AF48 RID: 44872
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF49 RID: 44873
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020005A2 RID: 1442
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardSeija+<SkillAttack>d__38")]
		public sealed class _SkillAttack_d__38 : Il2CppSystem.Object
		{
			// Token: 0x06008B47 RID: 35655 RVA: 0x00266320 File Offset: 0x00264520
			// Note: this type is marked as 'beforefieldinit'.
			static _SkillAttack_d__38()
			{
				Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "<SkillAttack>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr);
				DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr, "<>1__state");
				DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr, "<>2__current");
				DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr, "<>4__this");
				DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr, "<>8__1");
				DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr, 100666314);
				DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr, 100666315);
				DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr, 100666316);
				DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr, 100666317);
				DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr, 100666318);
				DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr, 100666319);
			}

			// Token: 0x06008B48 RID: 35656 RVA: 0x00266414 File Offset: 0x00264614
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SkillAttack_d__38(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardSeija._SkillAttack_d__38>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B49 RID: 35657 RVA: 0x0026645C File Offset: 0x0026465C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B4A RID: 35658 RVA: 0x00266490 File Offset: 0x00264690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49941, XrefRangeEnd = 49954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002EA6 RID: 11942
			// (get) Token: 0x06008B4B RID: 35659 RVA: 0x002664CC File Offset: 0x002646CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B4C RID: 35660 RVA: 0x0026650C File Offset: 0x0026470C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49954, XrefRangeEnd = 49960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002EA7 RID: 11943
			// (get) Token: 0x06008B4D RID: 35661 RVA: 0x00266540 File Offset: 0x00264740
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SkillAttack_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B4E RID: 35662 RVA: 0x0004AD79 File Offset: 0x00048F79
			public _SkillAttack_d__38(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EA2 RID: 11938
			// (get) Token: 0x06008B4F RID: 35663 RVA: 0x00266580 File Offset: 0x00264780
			// (set) Token: 0x06008B50 RID: 35664 RVA: 0x0004AD82 File Offset: 0x00048F82
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002EA3 RID: 11939
			// (get) Token: 0x06008B51 RID: 35665 RVA: 0x002665A8 File Offset: 0x002647A8
			// (set) Token: 0x06008B52 RID: 35666 RVA: 0x0004AD9D File Offset: 0x00048F9D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EA4 RID: 11940
			// (get) Token: 0x06008B53 RID: 35667 RVA: 0x002665D8 File Offset: 0x002647D8
			// (set) Token: 0x06008B54 RID: 35668 RVA: 0x0004ADBC File Offset: 0x00048FBC
			public unsafe DLC4_GuardSeija __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardSeija>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EA5 RID: 11941
			// (get) Token: 0x06008B55 RID: 35669 RVA: 0x00266608 File Offset: 0x00264808
			// (set) Token: 0x06008B56 RID: 35670 RVA: 0x0004ADDB File Offset: 0x00048FDB
			public unsafe DLC4_GuardSeija.__c__DisplayClass38_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardSeija.__c__DisplayClass38_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SkillAttack_d__38.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B3D RID: 23357
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005B3E RID: 23358
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005B3F RID: 23359
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B40 RID: 23360
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005B41 RID: 23361
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005B42 RID: 23362
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B43 RID: 23363
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005B44 RID: 23364
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005B45 RID: 23365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B46 RID: 23366
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020005A3 RID: 1443
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardSeija+<SetReverse>d__39")]
		public sealed class _SetReverse_d__39 : Il2CppSystem.Object
		{
			// Token: 0x06008B57 RID: 35671 RVA: 0x00266638 File Offset: 0x00264838
			// Note: this type is marked as 'beforefieldinit'.
			static _SetReverse_d__39()
			{
				Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardSeija>.NativeClassPtr, "<SetReverse>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr);
				DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr, "<>1__state");
				DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr, "<>2__current");
				DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr_enemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr, "enemy");
				DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr, "<>4__this");
				DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr, 100666320);
				DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr, 100666321);
				DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr, 100666322);
				DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr, 100666323);
				DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr, 100666324);
				DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr, 100666325);
			}

			// Token: 0x06008B58 RID: 35672 RVA: 0x0026672C File Offset: 0x0026492C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetReverse_d__39(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardSeija._SetReverse_d__39>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B59 RID: 35673 RVA: 0x00266774 File Offset: 0x00264974
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B5A RID: 35674 RVA: 0x002667A8 File Offset: 0x002649A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49960, XrefRangeEnd = 49966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002EAC RID: 11948
			// (get) Token: 0x06008B5B RID: 35675 RVA: 0x002667E4 File Offset: 0x002649E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B5C RID: 35676 RVA: 0x00266824 File Offset: 0x00264A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49966, XrefRangeEnd = 49972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002EAD RID: 11949
			// (get) Token: 0x06008B5D RID: 35677 RVA: 0x00266858 File Offset: 0x00264A58
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardSeija._SetReverse_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B5E RID: 35678 RVA: 0x0004ADFA File Offset: 0x00048FFA
			public _SetReverse_d__39(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EA8 RID: 11944
			// (get) Token: 0x06008B5F RID: 35679 RVA: 0x00266898 File Offset: 0x00264A98
			// (set) Token: 0x06008B60 RID: 35680 RVA: 0x0004AE03 File Offset: 0x00049003
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002EA9 RID: 11945
			// (get) Token: 0x06008B61 RID: 35681 RVA: 0x002668C0 File Offset: 0x00264AC0
			// (set) Token: 0x06008B62 RID: 35682 RVA: 0x0004AE1E File Offset: 0x0004901E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EAA RID: 11946
			// (get) Token: 0x06008B63 RID: 35683 RVA: 0x002668F0 File Offset: 0x00264AF0
			// (set) Token: 0x06008B64 RID: 35684 RVA: 0x0004AE3D File Offset: 0x0004903D
			public unsafe DLC4_FlandreEnemyCharacterController enemy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr_enemy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr_enemy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EAB RID: 11947
			// (get) Token: 0x06008B65 RID: 35685 RVA: 0x00266920 File Offset: 0x00264B20
			// (set) Token: 0x06008B66 RID: 35686 RVA: 0x0004AE5C File Offset: 0x0004905C
			public unsafe DLC4_GuardSeija __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardSeija>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardSeija._SetReverse_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B47 RID: 23367
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005B48 RID: 23368
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005B49 RID: 23369
			private static readonly IntPtr NativeFieldInfoPtr_enemy;

			// Token: 0x04005B4A RID: 23370
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B4B RID: 23371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005B4C RID: 23372
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B4D RID: 23373
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005B4E RID: 23374
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005B4F RID: 23375
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B50 RID: 23376
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
