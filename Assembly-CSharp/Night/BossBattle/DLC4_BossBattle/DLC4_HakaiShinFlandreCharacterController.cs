using System;
using System.Runtime.InteropServices;
using Common.Audio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.Tiles;
using NightScene.UI.HUDUtility;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200009C RID: 156
	public class DLC4_HakaiShinFlandreCharacterController : DLC4_FlandreEnemyCharacterController
	{
		// Token: 0x06000FBE RID: 4030 RVA: 0x000D3C64 File Offset: 0x000D1E64
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_HakaiShinFlandreCharacterController()
		{
			Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_HakaiShinFlandreCharacterController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr);
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_PARAMETER_THROW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "PARAMETER_THROW");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_SecondTargetDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_SecondTargetDamage");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_ThirdTargetDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_ThirdTargetDamage");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_FourthTargetDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_FourthTargetDamage");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_FifthTargetDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_FifthTargetDamage");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_ShootInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_ShootInterval");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_RainInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_RainInterval");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_StarRainNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_StarRainNum");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_StarBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_StarBullet");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_Doppelgangers_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_Doppelgangers_Id");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_DoppelgangerVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_DoppelgangerVFX");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_BatFogWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_BatFogWait");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_SpawnVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_SpawnVFX");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_AttackVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_AttackVFX");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_AttackVFXOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_AttackVFXOffset");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_RainParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_RainParticleSystem");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_SpawnRainAudioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_SpawnRainAudioClip");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_DieSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_DieSfx");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_AttackSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "m_AttackSfx");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_hasInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "hasInitialized");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_hpContextInUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "hpContextInUI");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_throwManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "throwManager");
			DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_waitToShootTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "waitToShootTime");
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666071);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666072);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_Shoot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666073);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_SpawnBullet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666074);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_StarRain_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666075);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_OnCurrentHPChangeCallback_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666076);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_PlayThrowAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666077);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_OnAttack_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666078);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_HitAndPlayVfx_Private_Void_Int32_QuakeProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666079);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_Die_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666080);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_WhenHakaiShinDie_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666081);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_SpawnSpirit_Private_IEnumerator_Transform_Vector3_FlandreTypeIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666082);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666083);
			DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, 100666084);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x000D3F78 File Offset: 0x000D2178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48546, XrefRangeEnd = 48567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, Action afterAttackingFinishCallback, Action afterCompletelyDeadCallback, DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dlc4BossBattleManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAttackingFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCompletelyDeadCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attackConditionCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x000D3FFC File Offset: 0x000D21FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48567, XrefRangeEnd = 48569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000D4038 File Offset: 0x000D2238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48569, XrefRangeEnd = 48574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_Shoot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000D406C File Offset: 0x000D226C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48605, RefRangeEnd = 48606, XrefRangeStart = 48574, XrefRangeEnd = 48605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnBullet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_SpawnBullet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000D40A0 File Offset: 0x000D22A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48606, XrefRangeEnd = 48611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StarRain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_StarRain_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x000D40E0 File Offset: 0x000D22E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48611, XrefRangeEnd = 48612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCurrentHPChangeCallback(int hpAfterChange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hpAfterChange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_OnCurrentHPChangeCallback_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000D412C File Offset: 0x000D232C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48612, XrefRangeEnd = 48616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayThrowAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_PlayThrowAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000D4160 File Offset: 0x000D2360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48616, XrefRangeEnd = 48712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_OnAttack_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000D419C File Offset: 0x000D239C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 48721, RefRangeEnd = 48725, XrefRangeStart = 48712, XrefRangeEnd = 48721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HitAndPlayVfx(int deskCode, DLC4_HakaiShinFlandreCharacterController.QuakeProperty quakeProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quakeProperty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_HitAndPlayVfx_Private_Void_Int32_QuakeProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000D41E8 File Offset: 0x000D23E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48725, XrefRangeEnd = 48743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_Die_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000D4224 File Offset: 0x000D2424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48743, XrefRangeEnd = 48748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WhenHakaiShinDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_WhenHakaiShinDie_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000D4264 File Offset: 0x000D2464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48754, RefRangeEnd = 48755, XrefRangeStart = 48748, XrefRangeEnd = 48754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SpawnSpirit(Transform vfx, Vector3 target, FlandreTypeIndex id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vfx);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_SpawnSpirit_Private_IEnumerator_Transform_Vector3_FlandreTypeIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000D42D0 File Offset: 0x000D24D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48755, XrefRangeEnd = 48759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000D430C File Offset: 0x000D250C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_HakaiShinFlandreCharacterController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0000A113 File Offset: 0x00008313
		public DLC4_HakaiShinFlandreCharacterController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x000D4348 File Offset: 0x000D2548
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x0000A11C File Offset: 0x0000831C
		public unsafe static string PARAMETER_THROW
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_PARAMETER_THROW, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_PARAMETER_THROW, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x000D4368 File Offset: 0x000D2568
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x0000A12E File Offset: 0x0000832E
		public unsafe DLC4_HakaiShinFlandreCharacterController.QuakeProperty m_SecondTargetDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_SecondTargetDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_SecondTargetDamage)) = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x000D4390 File Offset: 0x000D2590
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x0000A149 File Offset: 0x00008349
		public unsafe DLC4_HakaiShinFlandreCharacterController.QuakeProperty m_ThirdTargetDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_ThirdTargetDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_ThirdTargetDamage)) = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x000D43B8 File Offset: 0x000D25B8
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x0000A164 File Offset: 0x00008364
		public unsafe DLC4_HakaiShinFlandreCharacterController.QuakeProperty m_FourthTargetDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_FourthTargetDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_FourthTargetDamage)) = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x000D43E0 File Offset: 0x000D25E0
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x0000A17F File Offset: 0x0000837F
		public unsafe DLC4_HakaiShinFlandreCharacterController.QuakeProperty m_FifthTargetDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_FifthTargetDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_FifthTargetDamage)) = value;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x000D4408 File Offset: 0x000D2608
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x0000A19A File Offset: 0x0000839A
		public unsafe float m_ShootInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_ShootInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_ShootInterval)) = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x000D4430 File Offset: 0x000D2630
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x0000A1B5 File Offset: 0x000083B5
		public unsafe float m_RainInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_RainInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_RainInterval)) = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x000D4458 File Offset: 0x000D2658
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x0000A1D0 File Offset: 0x000083D0
		public unsafe float m_StarRainNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_StarRainNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_StarRainNum)) = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x000D4480 File Offset: 0x000D2680
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x0000A1EB File Offset: 0x000083EB
		public DLC4_FlandreEnemyCharacterController.FlandreBullet m_StarBullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_StarBullet);
				return new DLC4_FlandreEnemyCharacterController.FlandreBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_StarBullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x000D44B0 File Offset: 0x000D26B0
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0000A219 File Offset: 0x00008419
		public unsafe Il2CppStructArray<FlandreTypeIndex> m_Doppelgangers_Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_Doppelgangers_Id);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<FlandreTypeIndex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_Doppelgangers_Id), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x000D44E0 File Offset: 0x000D26E0
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0000A238 File Offset: 0x00008438
		public VFXPrefab m_DoppelgangerVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_DoppelgangerVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_DoppelgangerVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x000D4510 File Offset: 0x000D2710
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0000A266 File Offset: 0x00008466
		public unsafe float m_BatFogWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_BatFogWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_BatFogWait)) = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x000D4538 File Offset: 0x000D2738
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x0000A281 File Offset: 0x00008481
		public VFXPrefab m_SpawnVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_SpawnVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_SpawnVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x000D4568 File Offset: 0x000D2768
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x0000A2AF File Offset: 0x000084AF
		public VFXPrefab m_AttackVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_AttackVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_AttackVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x000D4598 File Offset: 0x000D2798
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x0000A2DD File Offset: 0x000084DD
		public unsafe Vector2 m_AttackVFXOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_AttackVFXOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_AttackVFXOffset)) = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x000D45C0 File Offset: 0x000D27C0
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x0000A2F8 File Offset: 0x000084F8
		public unsafe ParticleSystem m_RainParticleSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_RainParticleSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_RainParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x000D45F0 File Offset: 0x000D27F0
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x0000A317 File Offset: 0x00008517
		public GlobalAudioManager.DelayAudioClip m_SpawnRainAudioClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_SpawnRainAudioClip);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_SpawnRainAudioClip), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x000D4620 File Offset: 0x000D2820
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x0000A345 File Offset: 0x00008545
		public GlobalAudioManager.DelayAudioClip m_DieSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_DieSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_DieSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000D4650 File Offset: 0x000D2850
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x0000A373 File Offset: 0x00008573
		public GlobalAudioManager.DelayAudioClip m_AttackSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_AttackSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_m_AttackSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x000D4680 File Offset: 0x000D2880
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x0000A3A1 File Offset: 0x000085A1
		public unsafe bool hasInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_hasInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_hasInitialized)) = value;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x000D46A8 File Offset: 0x000D28A8
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x0000A3BC File Offset: 0x000085BC
		public IncomeControllerFlandre.FlandreBossHPContext hpContextInUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_hpContextInUI);
				return new IncomeControllerFlandre.FlandreBossHPContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_hpContextInUI), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x000D46D8 File Offset: 0x000D28D8
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x0000A3EA File Offset: 0x000085EA
		public unsafe ThrowState throwManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_throwManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThrowState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_throwManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x000D4708 File Offset: 0x000D2908
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x0000A409 File Offset: 0x00008609
		public unsafe float waitToShootTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_waitToShootTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.NativeFieldInfoPtr_waitToShootTime)) = value;
			}
		}

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeFieldInfoPtr_PARAMETER_THROW;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondTargetDamage;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeFieldInfoPtr_m_ThirdTargetDamage;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr_m_FourthTargetDamage;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeFieldInfoPtr_m_FifthTargetDamage;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeFieldInfoPtr_m_ShootInterval;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeFieldInfoPtr_m_RainInterval;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr_m_StarRainNum;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeFieldInfoPtr_m_StarBullet;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr_m_Doppelgangers_Id;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr_m_DoppelgangerVFX;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_m_BatFogWait;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_m_SpawnVFX;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_m_AttackVFX;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_m_AttackVFXOffset;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_m_RainParticleSystem;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr_m_SpawnRainAudioClip;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_m_DieSfx;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeFieldInfoPtr_m_AttackSfx;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr_hasInitialized;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_hpContextInUI;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_throwManager;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_waitToShootTime;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Private_Void_0;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr_SpawnBullet_Private_Void_0;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr_StarRain_Private_IEnumerator_0;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr_OnCurrentHPChangeCallback_Protected_Virtual_Void_Int32_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr_PlayThrowAnimation_Private_Void_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_OnAttack_Protected_Virtual_Void_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_HitAndPlayVfx_Private_Void_Int32_QuakeProperty_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_Die_Protected_Virtual_Void_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_WhenHakaiShinDie_Private_IEnumerator_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_SpawnSpirit_Private_IEnumerator_Transform_Vector3_FlandreTypeIndex_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200057C RID: 1404
		[Serializable]
		[StructLayout(2)]
		public struct QuakeProperty
		{
			// Token: 0x06008A0D RID: 35341 RVA: 0x00262B7C File Offset: 0x00260D7C
			// Note: this type is marked as 'beforefieldinit'.
			static QuakeProperty()
			{
				Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.QuakeProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "QuakeProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.QuakeProperty>.NativeClassPtr);
				DLC4_HakaiShinFlandreCharacterController.QuakeProperty.NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.QuakeProperty>.NativeClassPtr, "damage");
				DLC4_HakaiShinFlandreCharacterController.QuakeProperty.NativeFieldInfoPtr_vfxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.QuakeProperty>.NativeClassPtr, "vfxScale");
				DLC4_HakaiShinFlandreCharacterController.QuakeProperty.NativeFieldInfoPtr_vfxWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.QuakeProperty>.NativeClassPtr, "vfxWait");
			}

			// Token: 0x06008A0E RID: 35342 RVA: 0x0004A378 File Offset: 0x00048578
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.QuakeProperty>.NativeClassPtr, ref this));
			}

			// Token: 0x04005A6E RID: 23150
			private static readonly IntPtr NativeFieldInfoPtr_damage;

			// Token: 0x04005A6F RID: 23151
			private static readonly IntPtr NativeFieldInfoPtr_vfxScale;

			// Token: 0x04005A70 RID: 23152
			private static readonly IntPtr NativeFieldInfoPtr_vfxWait;

			// Token: 0x04005A71 RID: 23153
			[FieldOffset(0)]
			public int damage;

			// Token: 0x04005A72 RID: 23154
			[FieldOffset(4)]
			public float vfxScale;

			// Token: 0x04005A73 RID: 23155
			[FieldOffset(8)]
			public float vfxWait;
		}

		// Token: 0x0200057D RID: 1405
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_HakaiShinFlandreCharacterController+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x06008A0F RID: 35343 RVA: 0x00262BE4 File Offset: 0x00260DE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0>.NativeClassPtr);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0>.NativeClassPtr, "target");
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0>.NativeClassPtr, 100666085);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0.NativeMethodInfoPtr__StarRain_b__0_Internal_Void_DLC4_BulletFlandreHakaiShin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0>.NativeClassPtr, 100666086);
			}

			// Token: 0x06008A10 RID: 35344 RVA: 0x00262C4C File Offset: 0x00260E4C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A11 RID: 35345 RVA: 0x00262C88 File Offset: 0x00260E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48427, XrefRangeEnd = 48430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StarRain_b__0(DLC4_BulletFlandreHakaiShin x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0.NativeMethodInfoPtr__StarRain_b__0_Internal_Void_DLC4_BulletFlandreHakaiShin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A12 RID: 35346 RVA: 0x0004A38A File Offset: 0x0004858A
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E47 RID: 11847
			// (get) Token: 0x06008A13 RID: 35347 RVA: 0x00262CCC File Offset: 0x00260ECC
			// (set) Token: 0x06008A14 RID: 35348 RVA: 0x0004A393 File Offset: 0x00048593
			public KeyValuePair<int, TileManager.GuestTableData> target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0.NativeFieldInfoPtr_target);
					return new KeyValuePair<int, TileManager.GuestTableData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<int, TileManager.GuestTableData>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass27_0.NativeFieldInfoPtr_target), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<int, TileManager.GuestTableData>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005A74 RID: 23156
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04005A75 RID: 23157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A76 RID: 23158
			private static readonly IntPtr NativeMethodInfoPtr__StarRain_b__0_Internal_Void_DLC4_BulletFlandreHakaiShin_0;
		}

		// Token: 0x0200057E RID: 1406
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_HakaiShinFlandreCharacterController+<StarRain>d__27")]
		public sealed class _StarRain_d__27 : Il2CppSystem.Object
		{
			// Token: 0x06008A15 RID: 35349 RVA: 0x00262CFC File Offset: 0x00260EFC
			// Note: this type is marked as 'beforefieldinit'.
			static _StarRain_d__27()
			{
				Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "<StarRain>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr);
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, "<>1__state");
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, "<>2__current");
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, "<>4__this");
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr__wait_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, "<wait>5__2");
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, "<i>5__3");
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, 100666087);
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, 100666088);
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, 100666089);
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, 100666090);
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, 100666091);
				DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr, 100666092);
			}

			// Token: 0x06008A16 RID: 35350 RVA: 0x00262E04 File Offset: 0x00261004
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StarRain_d__27(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._StarRain_d__27>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A17 RID: 35351 RVA: 0x00262E4C File Offset: 0x0026104C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A18 RID: 35352 RVA: 0x00262E80 File Offset: 0x00261080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48430, XrefRangeEnd = 48460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E4D RID: 11853
			// (get) Token: 0x06008A19 RID: 35353 RVA: 0x00262EBC File Offset: 0x002610BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008A1A RID: 35354 RVA: 0x00262EFC File Offset: 0x002610FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48460, XrefRangeEnd = 48466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E4E RID: 11854
			// (get) Token: 0x06008A1B RID: 35355 RVA: 0x00262F30 File Offset: 0x00261130
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008A1C RID: 35356 RVA: 0x0004A3C1 File Offset: 0x000485C1
			public _StarRain_d__27(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E48 RID: 11848
			// (get) Token: 0x06008A1D RID: 35357 RVA: 0x00262F70 File Offset: 0x00261170
			// (set) Token: 0x06008A1E RID: 35358 RVA: 0x0004A3CA File Offset: 0x000485CA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E49 RID: 11849
			// (get) Token: 0x06008A1F RID: 35359 RVA: 0x00262F98 File Offset: 0x00261198
			// (set) Token: 0x06008A20 RID: 35360 RVA: 0x0004A3E5 File Offset: 0x000485E5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E4A RID: 11850
			// (get) Token: 0x06008A21 RID: 35361 RVA: 0x00262FC8 File Offset: 0x002611C8
			// (set) Token: 0x06008A22 RID: 35362 RVA: 0x0004A404 File Offset: 0x00048604
			public unsafe DLC4_HakaiShinFlandreCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_HakaiShinFlandreCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E4B RID: 11851
			// (get) Token: 0x06008A23 RID: 35363 RVA: 0x00262FF8 File Offset: 0x002611F8
			// (set) Token: 0x06008A24 RID: 35364 RVA: 0x0004A423 File Offset: 0x00048623
			public unsafe WaitForSeconds _wait_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr__wait_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr__wait_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E4C RID: 11852
			// (get) Token: 0x06008A25 RID: 35365 RVA: 0x00263028 File Offset: 0x00261228
			// (set) Token: 0x06008A26 RID: 35366 RVA: 0x0004A442 File Offset: 0x00048642
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._StarRain_d__27.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04005A77 RID: 23159
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005A78 RID: 23160
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005A79 RID: 23161
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A7A RID: 23162
			private static readonly IntPtr NativeFieldInfoPtr__wait_5__2;

			// Token: 0x04005A7B RID: 23163
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04005A7C RID: 23164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005A7D RID: 23165
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A7E RID: 23166
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005A7F RID: 23167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005A80 RID: 23168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A81 RID: 23169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200057F RID: 1407
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_HakaiShinFlandreCharacterController+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x06008A27 RID: 35367 RVA: 0x00263050 File Offset: 0x00261250
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0>.NativeClassPtr);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0>.NativeClassPtr, "targetPosition");
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0>.NativeClassPtr, 100666093);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0.NativeMethodInfoPtr__OnAttack_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0>.NativeClassPtr, 100666094);
			}

			// Token: 0x06008A28 RID: 35368 RVA: 0x002630CC File Offset: 0x002612CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A29 RID: 35369 RVA: 0x00263108 File Offset: 0x00261308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48466, XrefRangeEnd = 48467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnAttack_b__0(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0.NativeMethodInfoPtr__OnAttack_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008A2A RID: 35370 RVA: 0x0004A45D File Offset: 0x0004865D
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E4F RID: 11855
			// (get) Token: 0x06008A2B RID: 35371 RVA: 0x0026315C File Offset: 0x0026135C
			// (set) Token: 0x06008A2C RID: 35372 RVA: 0x0004A466 File Offset: 0x00048666
			public unsafe Vector3Int targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x17002E50 RID: 11856
			// (get) Token: 0x06008A2D RID: 35373 RVA: 0x00263184 File Offset: 0x00261384
			// (set) Token: 0x06008A2E RID: 35374 RVA: 0x0004A481 File Offset: 0x00048681
			public unsafe DLC4_HakaiShinFlandreCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_HakaiShinFlandreCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A82 RID: 23170
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04005A83 RID: 23171
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A84 RID: 23172
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A85 RID: 23173
			private static readonly IntPtr NativeMethodInfoPtr__OnAttack_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0;
		}

		// Token: 0x02000580 RID: 1408
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_HakaiShinFlandreCharacterController+<>c__DisplayClass30_1")]
		public sealed class __c__DisplayClass30_1 : Il2CppSystem.Object
		{
			// Token: 0x06008A2F RID: 35375 RVA: 0x002631B4 File Offset: 0x002613B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_1()
			{
				Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "<>c__DisplayClass30_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1>.NativeClassPtr);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeFieldInfoPtr_deskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1>.NativeClassPtr, "deskCode");
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1>.NativeClassPtr, 100666095);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeMethodInfoPtr__OnAttack_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1>.NativeClassPtr, 100666096);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeMethodInfoPtr__OnAttack_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1>.NativeClassPtr, 100666097);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeMethodInfoPtr__OnAttack_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1>.NativeClassPtr, 100666098);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeMethodInfoPtr__OnAttack_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1>.NativeClassPtr, 100666099);
			}

			// Token: 0x06008A30 RID: 35376 RVA: 0x0026326C File Offset: 0x0026146C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A31 RID: 35377 RVA: 0x002632A8 File Offset: 0x002614A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48467, XrefRangeEnd = 48468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnAttack_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeMethodInfoPtr__OnAttack_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A32 RID: 35378 RVA: 0x002632DC File Offset: 0x002614DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48468, XrefRangeEnd = 48469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnAttack_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeMethodInfoPtr__OnAttack_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A33 RID: 35379 RVA: 0x00263310 File Offset: 0x00261510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48469, XrefRangeEnd = 48470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnAttack_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeMethodInfoPtr__OnAttack_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A34 RID: 35380 RVA: 0x00263344 File Offset: 0x00261544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48470, XrefRangeEnd = 48471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnAttack_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeMethodInfoPtr__OnAttack_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A35 RID: 35381 RVA: 0x0004A4A0 File Offset: 0x000486A0
			public __c__DisplayClass30_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E51 RID: 11857
			// (get) Token: 0x06008A36 RID: 35382 RVA: 0x00263378 File Offset: 0x00261578
			// (set) Token: 0x06008A37 RID: 35383 RVA: 0x0004A4A9 File Offset: 0x000486A9
			public unsafe int deskCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeFieldInfoPtr_deskCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeFieldInfoPtr_deskCode)) = value;
				}
			}

			// Token: 0x17002E52 RID: 11858
			// (get) Token: 0x06008A38 RID: 35384 RVA: 0x002633A0 File Offset: 0x002615A0
			// (set) Token: 0x06008A39 RID: 35385 RVA: 0x0004A4C4 File Offset: 0x000486C4
			public unsafe DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0 field_Public___c__DisplayClass30_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass30_1.NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A86 RID: 23174
			private static readonly IntPtr NativeFieldInfoPtr_deskCode;

			// Token: 0x04005A87 RID: 23175
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass30_0_0;

			// Token: 0x04005A88 RID: 23176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A89 RID: 23177
			private static readonly IntPtr NativeMethodInfoPtr__OnAttack_b__3_Internal_Void_0;

			// Token: 0x04005A8A RID: 23178
			private static readonly IntPtr NativeMethodInfoPtr__OnAttack_b__4_Internal_Void_0;

			// Token: 0x04005A8B RID: 23179
			private static readonly IntPtr NativeMethodInfoPtr__OnAttack_b__5_Internal_Void_0;

			// Token: 0x04005A8C RID: 23180
			private static readonly IntPtr NativeMethodInfoPtr__OnAttack_b__6_Internal_Void_0;
		}

		// Token: 0x02000581 RID: 1409
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_HakaiShinFlandreCharacterController+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008A3A RID: 35386 RVA: 0x002633D0 File Offset: 0x002615D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c>.NativeClassPtr);
				DLC4_HakaiShinFlandreCharacterController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c>.NativeClassPtr, "<>9");
				DLC4_HakaiShinFlandreCharacterController.__c.NativeFieldInfoPtr___9__30_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c>.NativeClassPtr, "<>9__30_1");
				DLC4_HakaiShinFlandreCharacterController.__c.NativeFieldInfoPtr___9__30_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c>.NativeClassPtr, "<>9__30_2");
				DLC4_HakaiShinFlandreCharacterController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c>.NativeClassPtr, 100666101);
				DLC4_HakaiShinFlandreCharacterController.__c.NativeMethodInfoPtr__OnAttack_b__30_1_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c>.NativeClassPtr, 100666102);
				DLC4_HakaiShinFlandreCharacterController.__c.NativeMethodInfoPtr__OnAttack_b__30_2_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c>.NativeClassPtr, 100666103);
			}

			// Token: 0x06008A3B RID: 35387 RVA: 0x00263474 File Offset: 0x00261674
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A3C RID: 35388 RVA: 0x002634B0 File Offset: 0x002616B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48471, XrefRangeEnd = 48472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnAttack_b__30_1(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c.NativeMethodInfoPtr__OnAttack_b__30_1_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008A3D RID: 35389 RVA: 0x00263504 File Offset: 0x00261704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48472, XrefRangeEnd = 48473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnAttack_b__30_2(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c.NativeMethodInfoPtr__OnAttack_b__30_2_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008A3E RID: 35390 RVA: 0x0004A4E3 File Offset: 0x000486E3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E53 RID: 11859
			// (get) Token: 0x06008A3F RID: 35391 RVA: 0x00263558 File Offset: 0x00261758
			// (set) Token: 0x06008A40 RID: 35392 RVA: 0x0004A4EC File Offset: 0x000486EC
			public unsafe static DLC4_HakaiShinFlandreCharacterController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_HakaiShinFlandreCharacterController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_HakaiShinFlandreCharacterController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_HakaiShinFlandreCharacterController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E54 RID: 11860
			// (get) Token: 0x06008A41 RID: 35393 RVA: 0x00263580 File Offset: 0x00261780
			// (set) Token: 0x06008A42 RID: 35394 RVA: 0x0004A4FE File Offset: 0x000486FE
			public unsafe static Func<KeyValuePair<int, TileManager.GuestTableData>, int> __9__30_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_HakaiShinFlandreCharacterController.__c.NativeFieldInfoPtr___9__30_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TileManager.GuestTableData>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_HakaiShinFlandreCharacterController.__c.NativeFieldInfoPtr___9__30_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E55 RID: 11861
			// (get) Token: 0x06008A43 RID: 35395 RVA: 0x002635A8 File Offset: 0x002617A8
			// (set) Token: 0x06008A44 RID: 35396 RVA: 0x0004A510 File Offset: 0x00048710
			public unsafe static Func<KeyValuePair<int, TileManager.GuestTableData>, int> __9__30_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_HakaiShinFlandreCharacterController.__c.NativeFieldInfoPtr___9__30_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TileManager.GuestTableData>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_HakaiShinFlandreCharacterController.__c.NativeFieldInfoPtr___9__30_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A8D RID: 23181
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005A8E RID: 23182
			private static readonly IntPtr NativeFieldInfoPtr___9__30_1;

			// Token: 0x04005A8F RID: 23183
			private static readonly IntPtr NativeFieldInfoPtr___9__30_2;

			// Token: 0x04005A90 RID: 23184
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A91 RID: 23185
			private static readonly IntPtr NativeMethodInfoPtr__OnAttack_b__30_1_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0;

			// Token: 0x04005A92 RID: 23186
			private static readonly IntPtr NativeMethodInfoPtr__OnAttack_b__30_2_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0;
		}

		// Token: 0x02000582 RID: 1410
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_HakaiShinFlandreCharacterController+<WhenHakaiShinDie>d__33")]
		public sealed class _WhenHakaiShinDie_d__33 : Il2CppSystem.Object
		{
			// Token: 0x06008A45 RID: 35397 RVA: 0x002635D0 File Offset: 0x002617D0
			// Note: this type is marked as 'beforefieldinit'.
			static _WhenHakaiShinDie_d__33()
			{
				Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "<WhenHakaiShinDie>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr);
				DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr, "<>1__state");
				DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr, "<>2__current");
				DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr, "<>4__this");
				DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr__currentPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr, "<currentPosition>5__2");
				DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr, 100666104);
				DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr, 100666105);
				DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr, 100666106);
				DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr, 100666107);
				DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr, 100666108);
				DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr, 100666109);
			}

			// Token: 0x06008A46 RID: 35398 RVA: 0x002636C4 File Offset: 0x002618C4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WhenHakaiShinDie_d__33(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A47 RID: 35399 RVA: 0x0026370C File Offset: 0x0026190C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A48 RID: 35400 RVA: 0x00263740 File Offset: 0x00261940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48473, XrefRangeEnd = 48508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E5A RID: 11866
			// (get) Token: 0x06008A49 RID: 35401 RVA: 0x0026377C File Offset: 0x0026197C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008A4A RID: 35402 RVA: 0x002637BC File Offset: 0x002619BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48508, XrefRangeEnd = 48519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E5B RID: 11867
			// (get) Token: 0x06008A4B RID: 35403 RVA: 0x002637F0 File Offset: 0x002619F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008A4C RID: 35404 RVA: 0x0004A522 File Offset: 0x00048722
			public _WhenHakaiShinDie_d__33(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E56 RID: 11862
			// (get) Token: 0x06008A4D RID: 35405 RVA: 0x00263830 File Offset: 0x00261A30
			// (set) Token: 0x06008A4E RID: 35406 RVA: 0x0004A52B File Offset: 0x0004872B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E57 RID: 11863
			// (get) Token: 0x06008A4F RID: 35407 RVA: 0x00263858 File Offset: 0x00261A58
			// (set) Token: 0x06008A50 RID: 35408 RVA: 0x0004A546 File Offset: 0x00048746
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E58 RID: 11864
			// (get) Token: 0x06008A51 RID: 35409 RVA: 0x00263888 File Offset: 0x00261A88
			// (set) Token: 0x06008A52 RID: 35410 RVA: 0x0004A565 File Offset: 0x00048765
			public unsafe DLC4_HakaiShinFlandreCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_HakaiShinFlandreCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E59 RID: 11865
			// (get) Token: 0x06008A53 RID: 35411 RVA: 0x002638B8 File Offset: 0x00261AB8
			// (set) Token: 0x06008A54 RID: 35412 RVA: 0x0004A584 File Offset: 0x00048784
			public unsafe Vector3 _currentPosition_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr__currentPosition_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._WhenHakaiShinDie_d__33.NativeFieldInfoPtr__currentPosition_5__2)) = value;
				}
			}

			// Token: 0x04005A93 RID: 23187
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005A94 RID: 23188
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005A95 RID: 23189
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A96 RID: 23190
			private static readonly IntPtr NativeFieldInfoPtr__currentPosition_5__2;

			// Token: 0x04005A97 RID: 23191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005A98 RID: 23192
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A99 RID: 23193
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005A9A RID: 23194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005A9B RID: 23195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A9C RID: 23196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000583 RID: 1411
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_HakaiShinFlandreCharacterController+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x06008A55 RID: 35413 RVA: 0x002638E0 File Offset: 0x00261AE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0>.NativeClassPtr);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0>.NativeClassPtr, "target");
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0>.NativeClassPtr, 100666110);
				DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0.NativeMethodInfoPtr__SpawnSpirit_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0>.NativeClassPtr, 100666111);
			}

			// Token: 0x06008A56 RID: 35414 RVA: 0x00263948 File Offset: 0x00261B48
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A57 RID: 35415 RVA: 0x00263984 File Offset: 0x00261B84
			[CallerCount(0)]
			public unsafe Vector3 _SpawnSpirit_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0.NativeMethodInfoPtr__SpawnSpirit_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008A58 RID: 35416 RVA: 0x0004A59F File Offset: 0x0004879F
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E5C RID: 11868
			// (get) Token: 0x06008A59 RID: 35417 RVA: 0x002639C0 File Offset: 0x00261BC0
			// (set) Token: 0x06008A5A RID: 35418 RVA: 0x0004A5A8 File Offset: 0x000487A8
			public unsafe Vector3 target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0.NativeFieldInfoPtr_target);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0.NativeFieldInfoPtr_target)) = value;
				}
			}

			// Token: 0x04005A9D RID: 23197
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04005A9E RID: 23198
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A9F RID: 23199
			private static readonly IntPtr NativeMethodInfoPtr__SpawnSpirit_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000584 RID: 1412
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_HakaiShinFlandreCharacterController+<SpawnSpirit>d__34")]
		public sealed class _SpawnSpirit_d__34 : Il2CppSystem.Object
		{
			// Token: 0x06008A5B RID: 35419 RVA: 0x002639E8 File Offset: 0x00261BE8
			// Note: this type is marked as 'beforefieldinit'.
			static _SpawnSpirit_d__34()
			{
				Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController>.NativeClassPtr, "<SpawnSpirit>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr);
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, "<>1__state");
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, "<>2__current");
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, "target");
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, "<>4__this");
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr_vfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, "vfx");
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, "id");
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, "<>8__1");
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, 100666112);
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, 100666113);
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, 100666114);
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, 100666115);
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, 100666116);
				DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr, 100666117);
			}

			// Token: 0x06008A5C RID: 35420 RVA: 0x00263B18 File Offset: 0x00261D18
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SpawnSpirit_d__34(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A5D RID: 35421 RVA: 0x00263B60 File Offset: 0x00261D60
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A5E RID: 35422 RVA: 0x00263B94 File Offset: 0x00261D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48519, XrefRangeEnd = 48540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E64 RID: 11876
			// (get) Token: 0x06008A5F RID: 35423 RVA: 0x00263BD0 File Offset: 0x00261DD0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008A60 RID: 35424 RVA: 0x00263C10 File Offset: 0x00261E10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48540, XrefRangeEnd = 48546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E65 RID: 11877
			// (get) Token: 0x06008A61 RID: 35425 RVA: 0x00263C44 File Offset: 0x00261E44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008A62 RID: 35426 RVA: 0x0004A5C3 File Offset: 0x000487C3
			public _SpawnSpirit_d__34(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E5D RID: 11869
			// (get) Token: 0x06008A63 RID: 35427 RVA: 0x00263C84 File Offset: 0x00261E84
			// (set) Token: 0x06008A64 RID: 35428 RVA: 0x0004A5CC File Offset: 0x000487CC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E5E RID: 11870
			// (get) Token: 0x06008A65 RID: 35429 RVA: 0x00263CAC File Offset: 0x00261EAC
			// (set) Token: 0x06008A66 RID: 35430 RVA: 0x0004A5E7 File Offset: 0x000487E7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E5F RID: 11871
			// (get) Token: 0x06008A67 RID: 35431 RVA: 0x00263CDC File Offset: 0x00261EDC
			// (set) Token: 0x06008A68 RID: 35432 RVA: 0x0004A606 File Offset: 0x00048806
			public unsafe Vector3 target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr_target);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr_target)) = value;
				}
			}

			// Token: 0x17002E60 RID: 11872
			// (get) Token: 0x06008A69 RID: 35433 RVA: 0x00263D04 File Offset: 0x00261F04
			// (set) Token: 0x06008A6A RID: 35434 RVA: 0x0004A621 File Offset: 0x00048821
			public unsafe DLC4_HakaiShinFlandreCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_HakaiShinFlandreCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E61 RID: 11873
			// (get) Token: 0x06008A6B RID: 35435 RVA: 0x00263D34 File Offset: 0x00261F34
			// (set) Token: 0x06008A6C RID: 35436 RVA: 0x0004A640 File Offset: 0x00048840
			public unsafe Transform vfx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr_vfx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr_vfx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E62 RID: 11874
			// (get) Token: 0x06008A6D RID: 35437 RVA: 0x00263D64 File Offset: 0x00261F64
			// (set) Token: 0x06008A6E RID: 35438 RVA: 0x0004A65F File Offset: 0x0004885F
			public unsafe FlandreTypeIndex id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17002E63 RID: 11875
			// (get) Token: 0x06008A6F RID: 35439 RVA: 0x00263D8C File Offset: 0x00261F8C
			// (set) Token: 0x06008A70 RID: 35440 RVA: 0x0004A67A File Offset: 0x0004887A
			public unsafe DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_HakaiShinFlandreCharacterController.__c__DisplayClass34_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_HakaiShinFlandreCharacterController._SpawnSpirit_d__34.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005AA0 RID: 23200
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005AA1 RID: 23201
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005AA2 RID: 23202
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04005AA3 RID: 23203
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005AA4 RID: 23204
			private static readonly IntPtr NativeFieldInfoPtr_vfx;

			// Token: 0x04005AA5 RID: 23205
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04005AA6 RID: 23206
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005AA7 RID: 23207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005AA8 RID: 23208
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005AA9 RID: 23209
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005AAA RID: 23210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005AAB RID: 23211
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005AAC RID: 23212
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
