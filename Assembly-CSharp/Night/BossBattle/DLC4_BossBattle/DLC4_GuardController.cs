using System;
using Common.Audio;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200009E RID: 158
	public class DLC4_GuardController : MonoBehaviour
	{
		// Token: 0x06001007 RID: 4103 RVA: 0x000D492C File Offset: 0x000D2B2C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_GuardController()
		{
			Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_GuardController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr);
			DLC4_GuardController.NativeFieldInfoPtr_ENEMY_LAYER_MASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "ENEMY_LAYER_MASK");
			DLC4_GuardController.NativeFieldInfoPtr_m_NormalAttackInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "m_NormalAttackInterval");
			DLC4_GuardController.NativeFieldInfoPtr_m_AttackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "m_AttackRange");
			DLC4_GuardController.NativeFieldInfoPtr_m_FirstAttackWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "m_FirstAttackWait");
			DLC4_GuardController.NativeFieldInfoPtr_audioLoopedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "audioLoopedObjects");
			DLC4_GuardController.NativeFieldInfoPtr_currentHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "currentHealth");
			DLC4_GuardController.NativeFieldInfoPtr_flagObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "flagObject");
			DLC4_GuardController.NativeFieldInfoPtr_isUsingSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "isUsingSkill");
			DLC4_GuardController.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "level");
			DLC4_GuardController.NativeFieldInfoPtr_level2VFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "level2VFX");
			DLC4_GuardController.NativeFieldInfoPtr_onDisposeLeaveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "onDisposeLeaveCallback");
			DLC4_GuardController.NativeFieldInfoPtr_onLoseLeaveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "onLoseLeaveCallback");
			DLC4_GuardController.NativeFieldInfoPtr_onSkillEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "onSkillEnd");
			DLC4_GuardController.NativeFieldInfoPtr_skillAttackCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "skillAttackCoroutine");
			DLC4_GuardController.NativeFieldInfoPtr_skillVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "skillVFX");
			DLC4_GuardController.NativeFieldInfoPtr_waitToShootTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "waitToShootTime");
			DLC4_GuardController.NativeFieldInfoPtr__PoolId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<PoolId>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__GuardType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<GuardType>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__Controller_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<Controller>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__CurrentGuardStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<CurrentGuardStatus>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__TablePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<TablePosition>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__ShouldBeIgnore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<ShouldBeIgnore>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__MaxHp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<MaxHp>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__TargetAttackEnemy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<TargetAttackEnemy>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__AllShootBullet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<AllShootBullet>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<Dlc4BossBattleManager>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__CanHurtByMelee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<CanHurtByMelee>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__CanHurtByBullet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<CanHurtByBullet>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr__ExtraAttackSpeedMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<ExtraAttackSpeedMultiplier>k__BackingField");
			DLC4_GuardController.NativeFieldInfoPtr_m_GuardBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "m_GuardBuffs");
			DLC4_GuardController.NativeFieldInfoPtr_m_GuardBuffTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "m_GuardBuffTypes");
			DLC4_GuardController.NativeMethodInfoPtr_get_MaxLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666132);
			DLC4_GuardController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666133);
			DLC4_GuardController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666134);
			DLC4_GuardController.NativeMethodInfoPtr_Initialize_Public_Void_DLC4_BossBattleManager_Int32_Int32_GuestGroupController_Vector2_Vector3Int_Action_GuardType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666135);
			DLC4_GuardController.NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666136);
			DLC4_GuardController.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666137);
			DLC4_GuardController.NativeMethodInfoPtr_SpawnBullet_Public_T_TeamBulletProperty_Action_1_T_Nullable_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666138);
			DLC4_GuardController.NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666139);
			DLC4_GuardController.NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666140);
			DLC4_GuardController.NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_DelayAudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666141);
			DLC4_GuardController.NativeMethodInfoPtr_PlayAudioLooped_Protected_GameObject_LoopedBGMPackage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666142);
			DLC4_GuardController.NativeMethodInfoPtr_CouldAttack_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666143);
			DLC4_GuardController.NativeMethodInfoPtr_NormalAttack_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666144);
			DLC4_GuardController.NativeMethodInfoPtr_SkillAttack_Protected_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666145);
			DLC4_GuardController.NativeMethodInfoPtr_UseSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666146);
			DLC4_GuardController.NativeMethodInfoPtr_StartSkillAttack_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666147);
			DLC4_GuardController.NativeMethodInfoPtr_Recover_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666148);
			DLC4_GuardController.NativeMethodInfoPtr_GetBuffTime_Protected_Boolean_GuardBuffType_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666149);
			DLC4_GuardController.NativeMethodInfoPtr_AddBuff_Public_Void_GuardBuffType_Single_Action_Func_1_GameObject_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666150);
			DLC4_GuardController.NativeMethodInfoPtr_RemoveBuff_Public_Void_GuardBuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666151);
			DLC4_GuardController.NativeMethodInfoPtr_OnHurt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666152);
			DLC4_GuardController.NativeMethodInfoPtr_Lose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666153);
			DLC4_GuardController.NativeMethodInfoPtr_TryRepellController_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666154);
			DLC4_GuardController.NativeMethodInfoPtr_OnLoseExtraEffect_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666155);
			DLC4_GuardController.NativeMethodInfoPtr_DisPose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666156);
			DLC4_GuardController.NativeMethodInfoPtr_EndSkillVFX_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666157);
			DLC4_GuardController.NativeMethodInfoPtr_OnDispose_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666158);
			DLC4_GuardController.NativeMethodInfoPtr_TryReleaseGuard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666159);
			DLC4_GuardController.NativeMethodInfoPtr_get_PoolId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666160);
			DLC4_GuardController.NativeMethodInfoPtr_set_PoolId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666161);
			DLC4_GuardController.NativeMethodInfoPtr_get_GuardType_Public_get_GuardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666162);
			DLC4_GuardController.NativeMethodInfoPtr_set_GuardType_Private_set_Void_GuardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666163);
			DLC4_GuardController.NativeMethodInfoPtr_get_Controller_Public_get_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666164);
			DLC4_GuardController.NativeMethodInfoPtr_set_Controller_Private_set_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666165);
			DLC4_GuardController.NativeMethodInfoPtr_get_CurrentGuardStatus_Public_get_GuardStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666166);
			DLC4_GuardController.NativeMethodInfoPtr_set_CurrentGuardStatus_Private_set_Void_GuardStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666167);
			DLC4_GuardController.NativeMethodInfoPtr_get_TablePosition_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666168);
			DLC4_GuardController.NativeMethodInfoPtr_set_TablePosition_Private_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666169);
			DLC4_GuardController.NativeMethodInfoPtr_get_CurrentLine_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666170);
			DLC4_GuardController.NativeMethodInfoPtr_get_ShouldBeIgnore_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666171);
			DLC4_GuardController.NativeMethodInfoPtr_set_ShouldBeIgnore_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666172);
			DLC4_GuardController.NativeMethodInfoPtr_get_MaxHp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666173);
			DLC4_GuardController.NativeMethodInfoPtr_set_MaxHp_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666174);
			DLC4_GuardController.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666175);
			DLC4_GuardController.NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666176);
			DLC4_GuardController.NativeMethodInfoPtr_RefreshHealthDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666177);
			DLC4_GuardController.NativeMethodInfoPtr_get_Level_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666178);
			DLC4_GuardController.NativeMethodInfoPtr_set_Level_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666179);
			DLC4_GuardController.NativeMethodInfoPtr_get_TargetAttackEnemy_Public_get_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666180);
			DLC4_GuardController.NativeMethodInfoPtr_set_TargetAttackEnemy_Public_set_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666181);
			DLC4_GuardController.NativeMethodInfoPtr_get_AllShootBullet_Public_get_List_1_DLC4_BulletTeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666182);
			DLC4_GuardController.NativeMethodInfoPtr_set_AllShootBullet_Private_set_Void_List_1_DLC4_BulletTeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666183);
			DLC4_GuardController.NativeMethodInfoPtr_get_Dlc4BossBattleManager_Public_get_DLC4_BossBattleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666184);
			DLC4_GuardController.NativeMethodInfoPtr_set_Dlc4BossBattleManager_Private_set_Void_DLC4_BossBattleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666185);
			DLC4_GuardController.NativeMethodInfoPtr_get_SpawnPoint_Protected_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666186);
			DLC4_GuardController.NativeMethodInfoPtr_get_GuestManager_Protected_get_GuestsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666187);
			DLC4_GuardController.NativeMethodInfoPtr_CouldAttackBase_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666188);
			DLC4_GuardController.NativeMethodInfoPtr_get_CanNotContinueToFight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666189);
			DLC4_GuardController.NativeMethodInfoPtr_get_CanHurtByMelee_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666190);
			DLC4_GuardController.NativeMethodInfoPtr_set_CanHurtByMelee_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666191);
			DLC4_GuardController.NativeMethodInfoPtr_get_CanMeleeAttackEffective_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666192);
			DLC4_GuardController.NativeMethodInfoPtr_get_CanHurtByBullet_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666193);
			DLC4_GuardController.NativeMethodInfoPtr_set_CanHurtByBullet_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666194);
			DLC4_GuardController.NativeMethodInfoPtr_get_CanRemoteAttackEffective_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666195);
			DLC4_GuardController.NativeMethodInfoPtr_get_ExtraAttackSpeedMultiplier_Public_get_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666196);
			DLC4_GuardController.NativeMethodInfoPtr_get_ExtraAttackSpeed_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666197);
			DLC4_GuardController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666198);
			DLC4_GuardController.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666199);
			DLC4_GuardController.NativeMethodInfoPtr__Initialize_b__20_0_Private_Void_Action_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666200);
			DLC4_GuardController.NativeMethodInfoPtr__CouldAttack_b__28_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666201);
			DLC4_GuardController.NativeMethodInfoPtr__StartSkillAttack_b__32_0_Private_Void_ParticleSystemRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, 100666202);
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x000D5154 File Offset: 0x000D3354
		public unsafe static int MaxLevel
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_MaxLevel_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x000D5184 File Offset: 0x000D3384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48837, XrefRangeEnd = 48916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000D51B8 File Offset: 0x000D33B8
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000D51EC File Offset: 0x000D33EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48959, RefRangeEnd = 48961, XrefRangeStart = 48916, XrefRangeEnd = 48959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, int poolId, int maxHp, GuestGroupController controller, Vector2 position, Vector3Int tablePosition, Action onLoseCallback, GuestGuardMapping.GuardType guardType, Action onDisposeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dlc4BossBattleManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poolId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxHp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tablePosition;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onLoseCallback);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guardType;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onDisposeCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_Initialize_Public_Void_DLC4_BossBattleManager_Int32_Int32_GuestGroupController_Vector2_Vector3Int_Action_GuardType_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x000D52B0 File Offset: 0x000D34B0
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGuardControllerEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardController.NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x000D52EC File Offset: 0x000D34EC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardController.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000D5328 File Offset: 0x000D3528
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 48968, RefRangeEnd = 48981, XrefRangeStart = 48961, XrefRangeEnd = 48968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SpawnBullet<T>(DLC4_GuardController.TeamBulletProperty bulletProperty, Action<T> afterSpawn = null, Nullable<Vector2> overridePosition = null) where T : DLC4_BulletTeam
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bulletProperty));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterSpawn);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overridePosition));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.MethodInfoStoreGeneric_SpawnBullet_Public_T_TeamBulletProperty_Action_1_T_Nullable_1_Vector2_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000D53A0 File Offset: 0x000D35A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48981, XrefRangeEnd = 48983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAudio(AudioClip audioClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x000D53E4 File Offset: 0x000D35E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48983, XrefRangeEnd = 48985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAudioDelayed(AudioClip audioClip, float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClip);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_AudioClip_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x000D5434 File Offset: 0x000D3634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48986, RefRangeEnd = 48988, XrefRangeStart = 48985, XrefRangeEnd = 48986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAudioDelayed(GlobalAudioManager.DelayAudioClip delayAudioClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(delayAudioClip));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_DelayAudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000D547C File Offset: 0x000D367C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48988, XrefRangeEnd = 48996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject PlayAudioLooped(LoopedBGMPackage loopedBGMPackage, string label = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loopedBGMPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_PlayAudioLooped_Protected_GameObject_LoopedBGMPackage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000D54E0 File Offset: 0x000D36E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48996, XrefRangeEnd = 49007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CouldAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardController.NativeMethodInfoPtr_CouldAttack_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000D5528 File Offset: 0x000D3728
		[CallerCount(0)]
		public unsafe virtual void NormalAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardController.NativeMethodInfoPtr_NormalAttack_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x000D5564 File Offset: 0x000D3764
		[CallerCount(0)]
		public unsafe virtual IEnumerator SkillAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardController.NativeMethodInfoPtr_SkillAttack_Protected_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x000D55B0 File Offset: 0x000D37B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49014, RefRangeEnd = 49015, XrefRangeStart = 49007, XrefRangeEnd = 49014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UseSkill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_UseSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000D55E4 File Offset: 0x000D37E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49015, XrefRangeEnd = 49020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartSkillAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_StartSkillAttack_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x000D5624 File Offset: 0x000D3824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49021, RefRangeEnd = 49022, XrefRangeStart = 49020, XrefRangeEnd = 49021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recover(int hp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_Recover_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x000D5664 File Offset: 0x000D3864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49022, XrefRangeEnd = 49032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBuffTime(GuardBuff.GuardBuffType buffType, out float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buffType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_GetBuffTime_Protected_Boolean_GuardBuffType_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000D56BC File Offset: 0x000D38BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49053, RefRangeEnd = 49055, XrefRangeStart = 49032, XrefRangeEnd = 49053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBuff(GuardBuff.GuardBuffType buffType, float duration, Action onBuffEnd = null, Func<GameObject> onBuffEffectCreate = null, Action<GameObject> onBuffEffectEnd = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buffType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffEnd);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffEffectCreate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffEffectEnd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_AddBuff_Public_Void_GuardBuffType_Single_Action_Func_1_GameObject_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000D5740 File Offset: 0x000D3940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49055, XrefRangeEnd = 49075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBuff(GuardBuff.GuardBuffType buffType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buffType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_RemoveBuff_Public_Void_GuardBuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000D5780 File Offset: 0x000D3980
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 49078, RefRangeEnd = 49083, XrefRangeStart = 49075, XrefRangeEnd = 49078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHurt(int damage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_OnHurt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x000D57C0 File Offset: 0x000D39C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49083, XrefRangeEnd = 49085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_Lose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000D57F4 File Offset: 0x000D39F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49086, RefRangeEnd = 49087, XrefRangeStart = 49085, XrefRangeEnd = 49086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryRepellController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_TryRepellController_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000D5828 File Offset: 0x000D3A28
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnLoseExtraEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardController.NativeMethodInfoPtr_OnLoseExtraEffect_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000D5864 File Offset: 0x000D3A64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 49164, RefRangeEnd = 49167, XrefRangeStart = 49087, XrefRangeEnd = 49164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisPose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_DisPose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000D5898 File Offset: 0x000D3A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49175, RefRangeEnd = 49177, XrefRangeStart = 49167, XrefRangeEnd = 49175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSkillVFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_EndSkillVFX_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000D58CC File Offset: 0x000D3ACC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardController.NativeMethodInfoPtr_OnDispose_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000D5908 File Offset: 0x000D3B08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49192, RefRangeEnd = 49193, XrefRangeStart = 49177, XrefRangeEnd = 49192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryReleaseGuard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_TryReleaseGuard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x000D593C File Offset: 0x000D3B3C
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x000D5978 File Offset: 0x000D3B78
		public unsafe int PoolId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_PoolId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_PoolId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x000D59B8 File Offset: 0x000D3BB8
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x000D59F4 File Offset: 0x000D3BF4
		public unsafe GuestGuardMapping.GuardType GuardType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_GuardType_Public_get_GuardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_GuardType_Private_set_Void_GuardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x000D5A34 File Offset: 0x000D3C34
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x000D5A74 File Offset: 0x000D3C74
		public unsafe GuestGroupController Controller
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_Controller_Public_get_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49193, XrefRangeEnd = 49194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_Controller_Private_set_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x000D5AB8 File Offset: 0x000D3CB8
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x000D5AF4 File Offset: 0x000D3CF4
		public unsafe DLC4_GuardController.GuardStatus CurrentGuardStatus
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 49194, RefRangeEnd = 49208, XrefRangeStart = 49194, XrefRangeEnd = 49194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_CurrentGuardStatus_Public_get_GuardStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_CurrentGuardStatus_Private_set_Void_GuardStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x000D5B34 File Offset: 0x000D3D34
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x000D5B70 File Offset: 0x000D3D70
		public unsafe Vector3Int TablePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_TablePosition_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_TablePosition_Private_set_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x000D5BB0 File Offset: 0x000D3DB0
		public unsafe int CurrentLine
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 49208, RefRangeEnd = 49210, XrefRangeStart = 49208, XrefRangeEnd = 49208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_CurrentLine_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x000D5BEC File Offset: 0x000D3DEC
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x000D5C28 File Offset: 0x000D3E28
		public unsafe bool ShouldBeIgnore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_ShouldBeIgnore_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_ShouldBeIgnore_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x000D5C68 File Offset: 0x000D3E68
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x000D5CA4 File Offset: 0x000D3EA4
		public unsafe int MaxHp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49210, RefRangeEnd = 49211, XrefRangeStart = 49210, XrefRangeEnd = 49210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_MaxHp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_MaxHp_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x000D5CE4 File Offset: 0x000D3EE4
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x000D5D20 File Offset: 0x000D3F20
		public unsafe float CurrentHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 49214, RefRangeEnd = 49218, XrefRangeStart = 49211, XrefRangeEnd = 49214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000D5D60 File Offset: 0x000D3F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49218, XrefRangeEnd = 49220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshHealthDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_RefreshHealthDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x000D5D94 File Offset: 0x000D3F94
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x000D5DD0 File Offset: 0x000D3FD0
		public unsafe int Level
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_Level_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 49237, RefRangeEnd = 49241, XrefRangeStart = 49220, XrefRangeEnd = 49237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_Level_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x000D5E10 File Offset: 0x000D4010
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x000D5E50 File Offset: 0x000D4050
		public unsafe DLC4_FlandreEnemyCharacterController TargetAttackEnemy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_TargetAttackEnemy_Public_get_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_TargetAttackEnemy_Public_set_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x000D5E94 File Offset: 0x000D4094
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x000D5ED4 File Offset: 0x000D40D4
		public unsafe List<DLC4_BulletTeam> AllShootBullet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_AllShootBullet_Public_get_List_1_DLC4_BulletTeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DLC4_BulletTeam>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49241, XrefRangeEnd = 49242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_AllShootBullet_Private_set_Void_List_1_DLC4_BulletTeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x000D5F18 File Offset: 0x000D4118
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x000D5F58 File Offset: 0x000D4158
		public unsafe DLC4_BossBattleManager Dlc4BossBattleManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_Dlc4BossBattleManager_Public_get_DLC4_BossBattleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattleManager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_Dlc4BossBattleManager_Private_set_Void_DLC4_BossBattleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x000D5F9C File Offset: 0x000D419C
		public unsafe virtual Vector2 SpawnPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49242, XrefRangeEnd = 49244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardController.NativeMethodInfoPtr_get_SpawnPoint_Protected_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x000D5FE4 File Offset: 0x000D41E4
		public unsafe GuestsManager GuestManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_GuestManager_Protected_get_GuestsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr3) : null;
			}
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000D6024 File Offset: 0x000D4224
		[CallerCount(0)]
		public unsafe bool CouldAttackBase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_CouldAttackBase_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x000D6060 File Offset: 0x000D4260
		public unsafe bool CanNotContinueToFight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 49244, RefRangeEnd = 49246, XrefRangeStart = 49244, XrefRangeEnd = 49244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_CanNotContinueToFight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x000D609C File Offset: 0x000D429C
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x000D60D8 File Offset: 0x000D42D8
		public unsafe int CanHurtByMelee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_CanHurtByMelee_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_CanHurtByMelee_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x000D6118 File Offset: 0x000D4318
		public unsafe bool CanMeleeAttackEffective
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_CanMeleeAttackEffective_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x000D6154 File Offset: 0x000D4354
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x000D6190 File Offset: 0x000D4390
		public unsafe int CanHurtByBullet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_CanHurtByBullet_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_set_CanHurtByBullet_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x000D61D0 File Offset: 0x000D43D0
		public unsafe bool CanRemoteAttackEffective
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49247, RefRangeEnd = 49248, XrefRangeStart = 49246, XrefRangeEnd = 49247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_CanRemoteAttackEffective_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x000D620C File Offset: 0x000D440C
		public unsafe List<float> ExtraAttackSpeedMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_ExtraAttackSpeedMultiplier_Public_get_List_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr3) : null;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x000D624C File Offset: 0x000D444C
		public unsafe float ExtraAttackSpeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49248, XrefRangeEnd = 49267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr_get_ExtraAttackSpeed_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x000D6288 File Offset: 0x000D4488
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 49284, RefRangeEnd = 49291, XrefRangeStart = 49267, XrefRangeEnd = 49284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x000D62C4 File Offset: 0x000D44C4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 49328, RefRangeEnd = 49336, XrefRangeStart = 49291, XrefRangeEnd = 49328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_GuardController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x000D6300 File Offset: 0x000D4500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49336, XrefRangeEnd = 49337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__20_0(Action onFinish, GuestGroupController _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr__Initialize_b__20_0_Private_Void_Action_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x000D6354 File Offset: 0x000D4554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49337, XrefRangeEnd = 49340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CouldAttack_b__28_0(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr__CouldAttack_b__28_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x000D63A4 File Offset: 0x000D45A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49340, XrefRangeEnd = 49347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _StartSkillAttack_b__32_0(ParticleSystemRenderer x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.NativeMethodInfoPtr__StartSkillAttack_b__32_0_Private_Void_ParticleSystemRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0000A4B7 File Offset: 0x000086B7
		public DLC4_GuardController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x000D63E8 File Offset: 0x000D45E8
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x0000A4C0 File Offset: 0x000086C0
		public unsafe static int ENEMY_LAYER_MASK
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_GuardController.NativeFieldInfoPtr_ENEMY_LAYER_MASK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_GuardController.NativeFieldInfoPtr_ENEMY_LAYER_MASK, (void*)(&value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x000D6404 File Offset: 0x000D4604
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x0000A4CE File Offset: 0x000086CE
		public unsafe float m_NormalAttackInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_m_NormalAttackInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_m_NormalAttackInterval)) = value;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x000D642C File Offset: 0x000D462C
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x0000A4E9 File Offset: 0x000086E9
		public unsafe float m_AttackRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_m_AttackRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_m_AttackRange)) = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x000D6454 File Offset: 0x000D4654
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x0000A504 File Offset: 0x00008704
		public unsafe float m_FirstAttackWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_m_FirstAttackWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_m_FirstAttackWait)) = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x000D647C File Offset: 0x000D467C
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x0000A51F File Offset: 0x0000871F
		public unsafe List<GameObject> audioLoopedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_audioLoopedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_audioLoopedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x000D64AC File Offset: 0x000D46AC
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x0000A53E File Offset: 0x0000873E
		public unsafe float currentHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_currentHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_currentHealth)) = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x000D64D4 File Offset: 0x000D46D4
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x0000A559 File Offset: 0x00008759
		public unsafe GameObject flagObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_flagObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_flagObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x000D6504 File Offset: 0x000D4704
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x0000A578 File Offset: 0x00008778
		public unsafe bool isUsingSkill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_isUsingSkill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_isUsingSkill)) = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x000D652C File Offset: 0x000D472C
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x0000A593 File Offset: 0x00008793
		public unsafe int level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x000D6554 File Offset: 0x000D4754
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x0000A5AE File Offset: 0x000087AE
		public unsafe ParticleSystem level2VFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_level2VFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_level2VFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x000D6584 File Offset: 0x000D4784
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x0000A5CD File Offset: 0x000087CD
		public unsafe Action onDisposeLeaveCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_onDisposeLeaveCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_onDisposeLeaveCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x000D65B4 File Offset: 0x000D47B4
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x0000A5EC File Offset: 0x000087EC
		public unsafe Action onLoseLeaveCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_onLoseLeaveCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_onLoseLeaveCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x000D65E4 File Offset: 0x000D47E4
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x0000A60B File Offset: 0x0000880B
		public unsafe Action onSkillEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_onSkillEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_onSkillEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x000D6614 File Offset: 0x000D4814
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x0000A62A File Offset: 0x0000882A
		public unsafe Coroutine skillAttackCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_skillAttackCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_skillAttackCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x000D6644 File Offset: 0x000D4844
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x0000A649 File Offset: 0x00008849
		public unsafe ParticleSystem skillVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_skillVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_skillVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x000D6674 File Offset: 0x000D4874
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x0000A668 File Offset: 0x00008868
		public unsafe float waitToShootTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_waitToShootTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_waitToShootTime)) = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x000D669C File Offset: 0x000D489C
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x0000A683 File Offset: 0x00008883
		public unsafe int _PoolId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__PoolId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__PoolId_k__BackingField)) = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x000D66C4 File Offset: 0x000D48C4
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x0000A69E File Offset: 0x0000889E
		public unsafe GuestGuardMapping.GuardType _GuardType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__GuardType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__GuardType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x000D66EC File Offset: 0x000D48EC
		// (set) Token: 0x06001075 RID: 4213 RVA: 0x0000A6B9 File Offset: 0x000088B9
		public unsafe GuestGroupController _Controller_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__Controller_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__Controller_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x000D671C File Offset: 0x000D491C
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x0000A6D8 File Offset: 0x000088D8
		public unsafe DLC4_GuardController.GuardStatus _CurrentGuardStatus_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__CurrentGuardStatus_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__CurrentGuardStatus_k__BackingField)) = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x000D6744 File Offset: 0x000D4944
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x0000A6F3 File Offset: 0x000088F3
		public unsafe Vector3Int _TablePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__TablePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__TablePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x000D676C File Offset: 0x000D496C
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x0000A70E File Offset: 0x0000890E
		public unsafe bool _ShouldBeIgnore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__ShouldBeIgnore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__ShouldBeIgnore_k__BackingField)) = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x000D6794 File Offset: 0x000D4994
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x0000A729 File Offset: 0x00008929
		public unsafe int _MaxHp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__MaxHp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__MaxHp_k__BackingField)) = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x000D67BC File Offset: 0x000D49BC
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x0000A744 File Offset: 0x00008944
		public unsafe DLC4_FlandreEnemyCharacterController _TargetAttackEnemy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__TargetAttackEnemy_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__TargetAttackEnemy_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x000D67EC File Offset: 0x000D49EC
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x0000A763 File Offset: 0x00008963
		public unsafe List<DLC4_BulletTeam> _AllShootBullet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__AllShootBullet_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC4_BulletTeam>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__AllShootBullet_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x000D681C File Offset: 0x000D4A1C
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x0000A782 File Offset: 0x00008982
		public unsafe DLC4_BossBattleManager _Dlc4BossBattleManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x000D684C File Offset: 0x000D4A4C
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x0000A7A1 File Offset: 0x000089A1
		public unsafe int _CanHurtByMelee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__CanHurtByMelee_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__CanHurtByMelee_k__BackingField)) = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x000D6874 File Offset: 0x000D4A74
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x0000A7BC File Offset: 0x000089BC
		public unsafe int _CanHurtByBullet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__CanHurtByBullet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__CanHurtByBullet_k__BackingField)) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x000D689C File Offset: 0x000D4A9C
		// (set) Token: 0x06001089 RID: 4233 RVA: 0x0000A7D7 File Offset: 0x000089D7
		public unsafe List<float> _ExtraAttackSpeedMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__ExtraAttackSpeedMultiplier_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr__ExtraAttackSpeedMultiplier_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x000D68CC File Offset: 0x000D4ACC
		// (set) Token: 0x0600108B RID: 4235 RVA: 0x0000A7F6 File Offset: 0x000089F6
		public unsafe List<GuardBuff> m_GuardBuffs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_m_GuardBuffs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GuardBuff>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_m_GuardBuffs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x000D68FC File Offset: 0x000D4AFC
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x0000A815 File Offset: 0x00008A15
		public unsafe HashSet<GuardBuff.GuardBuffType> m_GuardBuffTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_m_GuardBuffTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GuardBuff.GuardBuffType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.NativeFieldInfoPtr_m_GuardBuffTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeFieldInfoPtr_ENEMY_LAYER_MASK;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalAttackInterval;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr_m_AttackRange;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAttackWait;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeFieldInfoPtr_audioLoopedObjects;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeFieldInfoPtr_currentHealth;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeFieldInfoPtr_flagObject;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeFieldInfoPtr_isUsingSkill;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeFieldInfoPtr_level2VFX;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeFieldInfoPtr_onDisposeLeaveCallback;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeFieldInfoPtr_onLoseLeaveCallback;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeFieldInfoPtr_onSkillEnd;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeFieldInfoPtr_skillAttackCoroutine;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeFieldInfoPtr_skillVFX;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeFieldInfoPtr_waitToShootTime;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr__PoolId_k__BackingField;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeFieldInfoPtr__GuardType_k__BackingField;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeFieldInfoPtr__Controller_k__BackingField;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeFieldInfoPtr__CurrentGuardStatus_k__BackingField;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr__TablePosition_k__BackingField;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeFieldInfoPtr__ShouldBeIgnore_k__BackingField;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr__MaxHp_k__BackingField;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeFieldInfoPtr__TargetAttackEnemy_k__BackingField;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeFieldInfoPtr__AllShootBullet_k__BackingField;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeFieldInfoPtr__CanHurtByMelee_k__BackingField;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeFieldInfoPtr__CanHurtByBullet_k__BackingField;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeFieldInfoPtr__ExtraAttackSpeedMultiplier_k__BackingField;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeFieldInfoPtr_m_GuardBuffs;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeFieldInfoPtr_m_GuardBuffTypes;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxLevel_Public_Static_get_Int32_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DLC4_BossBattleManager_Int32_Int32_GuestGroupController_Vector2_Vector3Int_Action_GuardType_Action_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_SpawnBullet_Public_T_TeamBulletProperty_Action_1_T_Nullable_1_Vector2_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_AudioClip_Single_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_DelayAudioClip_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_PlayAudioLooped_Protected_GameObject_LoopedBGMPackage_String_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_CouldAttack_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_NormalAttack_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_SkillAttack_Protected_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_UseSkill_Public_Void_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_StartSkillAttack_Private_IEnumerator_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_Recover_Public_Void_Int32_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffTime_Protected_Boolean_GuardBuffType_byref_Single_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_AddBuff_Public_Void_GuardBuffType_Single_Action_Func_1_GameObject_Action_1_GameObject_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBuff_Public_Void_GuardBuffType_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_OnHurt_Public_Void_Int32_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_Lose_Private_Void_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_TryRepellController_Public_Void_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_OnLoseExtraEffect_Protected_Virtual_New_Void_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_DisPose_Public_Void_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_EndSkillVFX_Protected_Void_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_New_Void_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_TryReleaseGuard_Public_Void_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_get_PoolId_Public_get_Int32_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_set_PoolId_Private_set_Void_Int32_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_get_GuardType_Public_get_GuardType_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_set_GuardType_Private_set_Void_GuardType_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_get_Controller_Public_get_GuestGroupController_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_set_Controller_Private_set_Void_GuestGroupController_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGuardStatus_Public_get_GuardStatus_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGuardStatus_Private_set_Void_GuardStatus_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_get_TablePosition_Public_get_Vector3Int_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_set_TablePosition_Private_set_Void_Vector3Int_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLine_Public_get_Int32_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldBeIgnore_Public_get_Boolean_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldBeIgnore_Protected_set_Void_Boolean_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxHp_Public_get_Int32_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxHp_Private_set_Void_Int32_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_RefreshHealthDisplay_Private_Void_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_Int32_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_set_Level_Public_set_Void_Int32_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetAttackEnemy_Public_get_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetAttackEnemy_Public_set_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_get_AllShootBullet_Public_get_List_1_DLC4_BulletTeam_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_set_AllShootBullet_Private_set_Void_List_1_DLC4_BulletTeam_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_get_Dlc4BossBattleManager_Public_get_DLC4_BossBattleManager_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_set_Dlc4BossBattleManager_Private_set_Void_DLC4_BossBattleManager_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_get_SpawnPoint_Protected_Virtual_New_get_Vector2_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestManager_Protected_get_GuestsManager_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_CouldAttackBase_Private_Boolean_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_get_CanNotContinueToFight_Public_get_Boolean_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_get_CanHurtByMelee_Public_get_Int32_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_set_CanHurtByMelee_Public_set_Void_Int32_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_get_CanMeleeAttackEffective_Public_get_Boolean_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_get_CanHurtByBullet_Public_get_Int32_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_set_CanHurtByBullet_Public_set_Void_Int32_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRemoteAttackEffective_Public_get_Boolean_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraAttackSpeedMultiplier_Public_get_List_1_Single_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraAttackSpeed_Private_get_Single_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__20_0_Private_Void_Action_GuestGroupController_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr__CouldAttack_b__28_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr__StartSkillAttack_b__32_0_Private_Void_ParticleSystemRenderer_0;

		// Token: 0x0200058A RID: 1418
		[Serializable]
		public sealed class TeamBulletProperty : ValueType
		{
			// Token: 0x06008A96 RID: 35478 RVA: 0x00264408 File Offset: 0x00262608
			// Note: this type is marked as 'beforefieldinit'.
			static TeamBulletProperty()
			{
				Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "TeamBulletProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr);
				DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_Bullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, "m_Bullet");
				DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, "m_Damage");
				DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, "m_Speed");
				DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_MaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, "m_MaxDuration");
			}

			// Token: 0x06008A97 RID: 35479 RVA: 0x0004A7D5 File Offset: 0x000489D5
			public TeamBulletProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008A98 RID: 35480 RVA: 0x0004A7DE File Offset: 0x000489DE
			public TeamBulletProperty() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr))
			{
			}

			// Token: 0x17002E70 RID: 11888
			// (get) Token: 0x06008A99 RID: 35481 RVA: 0x00264484 File Offset: 0x00262684
			// (set) Token: 0x06008A9A RID: 35482 RVA: 0x0004A7F0 File Offset: 0x000489F0
			public unsafe DLC4_BulletTeam m_Bullet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_Bullet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BulletTeam>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_Bullet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E71 RID: 11889
			// (get) Token: 0x06008A9B RID: 35483 RVA: 0x002644B4 File Offset: 0x002626B4
			// (set) Token: 0x06008A9C RID: 35484 RVA: 0x0004A80F File Offset: 0x00048A0F
			public unsafe int m_Damage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_Damage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_Damage)) = value;
				}
			}

			// Token: 0x17002E72 RID: 11890
			// (get) Token: 0x06008A9D RID: 35485 RVA: 0x002644DC File Offset: 0x002626DC
			// (set) Token: 0x06008A9E RID: 35486 RVA: 0x0004A82A File Offset: 0x00048A2A
			public unsafe float m_Speed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_Speed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_Speed)) = value;
				}
			}

			// Token: 0x17002E73 RID: 11891
			// (get) Token: 0x06008A9F RID: 35487 RVA: 0x00264504 File Offset: 0x00262704
			// (set) Token: 0x06008AA0 RID: 35488 RVA: 0x0004A845 File Offset: 0x00048A45
			public unsafe float m_MaxDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_MaxDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.TeamBulletProperty.NativeFieldInfoPtr_m_MaxDuration)) = value;
				}
			}

			// Token: 0x04005AC5 RID: 23237
			private static readonly IntPtr NativeFieldInfoPtr_m_Bullet;

			// Token: 0x04005AC6 RID: 23238
			private static readonly IntPtr NativeFieldInfoPtr_m_Damage;

			// Token: 0x04005AC7 RID: 23239
			private static readonly IntPtr NativeFieldInfoPtr_m_Speed;

			// Token: 0x04005AC8 RID: 23240
			private static readonly IntPtr NativeFieldInfoPtr_m_MaxDuration;
		}

		// Token: 0x0200058B RID: 1419
		public enum GuardStatus
		{
			// Token: 0x04005ACA RID: 23242
			Idle,
			// Token: 0x04005ACB RID: 23243
			Fight,
			// Token: 0x04005ACC RID: 23244
			Defeated,
			// Token: 0x04005ACD RID: 23245
			Disposed
		}

		// Token: 0x0200058C RID: 1420
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardController+<StartSkillAttack>d__32")]
		public sealed class _StartSkillAttack_d__32 : Il2CppSystem.Object
		{
			// Token: 0x06008AA1 RID: 35489 RVA: 0x0026452C File Offset: 0x0026272C
			// Note: this type is marked as 'beforefieldinit'.
			static _StartSkillAttack_d__32()
			{
				Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<StartSkillAttack>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr);
				DLC4_GuardController._StartSkillAttack_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr, "<>1__state");
				DLC4_GuardController._StartSkillAttack_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr, "<>2__current");
				DLC4_GuardController._StartSkillAttack_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr, "<>4__this");
				DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr, 100666203);
				DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr, 100666204);
				DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr, 100666205);
				DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr, 100666206);
				DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr, 100666207);
				DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr, 100666208);
			}

			// Token: 0x06008AA2 RID: 35490 RVA: 0x0026460C File Offset: 0x0026280C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StartSkillAttack_d__32(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardController._StartSkillAttack_d__32>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008AA3 RID: 35491 RVA: 0x00264654 File Offset: 0x00262854
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008AA4 RID: 35492 RVA: 0x00264688 File Offset: 0x00262888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48809, XrefRangeEnd = 48831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E77 RID: 11895
			// (get) Token: 0x06008AA5 RID: 35493 RVA: 0x002646C4 File Offset: 0x002628C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008AA6 RID: 35494 RVA: 0x00264704 File Offset: 0x00262904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48831, XrefRangeEnd = 48837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E78 RID: 11896
			// (get) Token: 0x06008AA7 RID: 35495 RVA: 0x00264738 File Offset: 0x00262938
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController._StartSkillAttack_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008AA8 RID: 35496 RVA: 0x0004A860 File Offset: 0x00048A60
			public _StartSkillAttack_d__32(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E74 RID: 11892
			// (get) Token: 0x06008AA9 RID: 35497 RVA: 0x00264778 File Offset: 0x00262978
			// (set) Token: 0x06008AAA RID: 35498 RVA: 0x0004A869 File Offset: 0x00048A69
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController._StartSkillAttack_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController._StartSkillAttack_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E75 RID: 11893
			// (get) Token: 0x06008AAB RID: 35499 RVA: 0x002647A0 File Offset: 0x002629A0
			// (set) Token: 0x06008AAC RID: 35500 RVA: 0x0004A884 File Offset: 0x00048A84
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController._StartSkillAttack_d__32.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController._StartSkillAttack_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E76 RID: 11894
			// (get) Token: 0x06008AAD RID: 35501 RVA: 0x002647D0 File Offset: 0x002629D0
			// (set) Token: 0x06008AAE RID: 35502 RVA: 0x0004A8A3 File Offset: 0x00048AA3
			public unsafe DLC4_GuardController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController._StartSkillAttack_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController._StartSkillAttack_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005ACE RID: 23246
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005ACF RID: 23247
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005AD0 RID: 23248
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005AD1 RID: 23249
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005AD2 RID: 23250
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005AD3 RID: 23251
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005AD4 RID: 23252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005AD5 RID: 23253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005AD6 RID: 23254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200058D RID: 1421
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardController+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x06008AAF RID: 35503 RVA: 0x00264800 File Offset: 0x00262A00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass34_0>.NativeClassPtr);
				DLC4_GuardController.__c__DisplayClass34_0.NativeFieldInfoPtr_buffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass34_0>.NativeClassPtr, "buffType");
				DLC4_GuardController.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass34_0>.NativeClassPtr, 100666209);
				DLC4_GuardController.__c__DisplayClass34_0.NativeMethodInfoPtr__GetBuffTime_b__0_Internal_Boolean_GuardBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass34_0>.NativeClassPtr, 100666210);
			}

			// Token: 0x06008AB0 RID: 35504 RVA: 0x00264868 File Offset: 0x00262A68
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008AB1 RID: 35505 RVA: 0x002648A4 File Offset: 0x00262AA4
			[CallerCount(0)]
			public unsafe bool _GetBuffTime_b__0(GuardBuff x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.__c__DisplayClass34_0.NativeMethodInfoPtr__GetBuffTime_b__0_Internal_Boolean_GuardBuff_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008AB2 RID: 35506 RVA: 0x0004A8C2 File Offset: 0x00048AC2
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E79 RID: 11897
			// (get) Token: 0x06008AB3 RID: 35507 RVA: 0x002648F4 File Offset: 0x00262AF4
			// (set) Token: 0x06008AB4 RID: 35508 RVA: 0x0004A8CB File Offset: 0x00048ACB
			public unsafe GuardBuff.GuardBuffType buffType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.__c__DisplayClass34_0.NativeFieldInfoPtr_buffType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.__c__DisplayClass34_0.NativeFieldInfoPtr_buffType)) = value;
				}
			}

			// Token: 0x04005AD7 RID: 23255
			private static readonly IntPtr NativeFieldInfoPtr_buffType;

			// Token: 0x04005AD8 RID: 23256
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005AD9 RID: 23257
			private static readonly IntPtr NativeMethodInfoPtr__GetBuffTime_b__0_Internal_Boolean_GuardBuff_0;
		}

		// Token: 0x0200058E RID: 1422
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardController+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x06008AB5 RID: 35509 RVA: 0x0026491C File Offset: 0x00262B1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass35_0>.NativeClassPtr);
				DLC4_GuardController.__c__DisplayClass35_0.NativeFieldInfoPtr_buffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass35_0>.NativeClassPtr, "buffType");
				DLC4_GuardController.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass35_0>.NativeClassPtr, 100666211);
				DLC4_GuardController.__c__DisplayClass35_0.NativeMethodInfoPtr__AddBuff_b__0_Internal_Boolean_GuardBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass35_0>.NativeClassPtr, 100666212);
			}

			// Token: 0x06008AB6 RID: 35510 RVA: 0x00264984 File Offset: 0x00262B84
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008AB7 RID: 35511 RVA: 0x002649C0 File Offset: 0x00262BC0
			[CallerCount(0)]
			public unsafe bool _AddBuff_b__0(GuardBuff x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.__c__DisplayClass35_0.NativeMethodInfoPtr__AddBuff_b__0_Internal_Boolean_GuardBuff_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008AB8 RID: 35512 RVA: 0x0004A8E6 File Offset: 0x00048AE6
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E7A RID: 11898
			// (get) Token: 0x06008AB9 RID: 35513 RVA: 0x00264A10 File Offset: 0x00262C10
			// (set) Token: 0x06008ABA RID: 35514 RVA: 0x0004A8EF File Offset: 0x00048AEF
			public unsafe GuardBuff.GuardBuffType buffType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.__c__DisplayClass35_0.NativeFieldInfoPtr_buffType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.__c__DisplayClass35_0.NativeFieldInfoPtr_buffType)) = value;
				}
			}

			// Token: 0x04005ADA RID: 23258
			private static readonly IntPtr NativeFieldInfoPtr_buffType;

			// Token: 0x04005ADB RID: 23259
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005ADC RID: 23260
			private static readonly IntPtr NativeMethodInfoPtr__AddBuff_b__0_Internal_Boolean_GuardBuff_0;
		}

		// Token: 0x0200058F RID: 1423
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardController+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x06008ABB RID: 35515 RVA: 0x00264A38 File Offset: 0x00262C38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass36_0>.NativeClassPtr);
				DLC4_GuardController.__c__DisplayClass36_0.NativeFieldInfoPtr_buffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass36_0>.NativeClassPtr, "buffType");
				DLC4_GuardController.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass36_0>.NativeClassPtr, 100666213);
				DLC4_GuardController.__c__DisplayClass36_0.NativeMethodInfoPtr__RemoveBuff_b__0_Internal_Boolean_GuardBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass36_0>.NativeClassPtr, 100666214);
			}

			// Token: 0x06008ABC RID: 35516 RVA: 0x00264AA0 File Offset: 0x00262CA0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardController.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008ABD RID: 35517 RVA: 0x00264ADC File Offset: 0x00262CDC
			[CallerCount(0)]
			public unsafe bool _RemoveBuff_b__0(GuardBuff x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.__c__DisplayClass36_0.NativeMethodInfoPtr__RemoveBuff_b__0_Internal_Boolean_GuardBuff_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008ABE RID: 35518 RVA: 0x0004A90A File Offset: 0x00048B0A
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E7B RID: 11899
			// (get) Token: 0x06008ABF RID: 35519 RVA: 0x00264B2C File Offset: 0x00262D2C
			// (set) Token: 0x06008AC0 RID: 35520 RVA: 0x0004A913 File Offset: 0x00048B13
			public unsafe GuardBuff.GuardBuffType buffType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.__c__DisplayClass36_0.NativeFieldInfoPtr_buffType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardController.__c__DisplayClass36_0.NativeFieldInfoPtr_buffType)) = value;
				}
			}

			// Token: 0x04005ADD RID: 23261
			private static readonly IntPtr NativeFieldInfoPtr_buffType;

			// Token: 0x04005ADE RID: 23262
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005ADF RID: 23263
			private static readonly IntPtr NativeMethodInfoPtr__RemoveBuff_b__0_Internal_Boolean_GuardBuff_0;
		}

		// Token: 0x02000590 RID: 1424
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008AC1 RID: 35521 RVA: 0x00264B54 File Offset: 0x00262D54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_GuardController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardController.__c>.NativeClassPtr);
				DLC4_GuardController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController.__c>.NativeClassPtr, "<>9");
				DLC4_GuardController.__c.NativeFieldInfoPtr___9__119_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardController.__c>.NativeClassPtr, "<>9__119_0");
				DLC4_GuardController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController.__c>.NativeClassPtr, 100666216);
				DLC4_GuardController.__c.NativeMethodInfoPtr__get_ExtraAttackSpeed_b__119_0_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardController.__c>.NativeClassPtr, 100666217);
			}

			// Token: 0x06008AC2 RID: 35522 RVA: 0x00264BD0 File Offset: 0x00262DD0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008AC3 RID: 35523 RVA: 0x00264C0C File Offset: 0x00262E0C
			[CallerCount(0)]
			public unsafe float _get_ExtraAttackSpeed_b__119_0(float a, float b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardController.__c.NativeMethodInfoPtr__get_ExtraAttackSpeed_b__119_0_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008AC4 RID: 35524 RVA: 0x0004A92E File Offset: 0x00048B2E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E7C RID: 11900
			// (get) Token: 0x06008AC5 RID: 35525 RVA: 0x00264C64 File Offset: 0x00262E64
			// (set) Token: 0x06008AC6 RID: 35526 RVA: 0x0004A937 File Offset: 0x00048B37
			public unsafe static DLC4_GuardController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E7D RID: 11901
			// (get) Token: 0x06008AC7 RID: 35527 RVA: 0x00264C8C File Offset: 0x00262E8C
			// (set) Token: 0x06008AC8 RID: 35528 RVA: 0x0004A949 File Offset: 0x00048B49
			public unsafe static Func<float, float, float> __9__119_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardController.__c.NativeFieldInfoPtr___9__119_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardController.__c.NativeFieldInfoPtr___9__119_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005AE0 RID: 23264
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005AE1 RID: 23265
			private static readonly IntPtr NativeFieldInfoPtr___9__119_0;

			// Token: 0x04005AE2 RID: 23266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005AE3 RID: 23267
			private static readonly IntPtr NativeMethodInfoPtr__get_ExtraAttackSpeed_b__119_0_Internal_Single_Single_Single_0;
		}

		// Token: 0x02000591 RID: 1425
		private sealed class MethodInfoStoreGeneric_SpawnBullet_Public_T_TeamBulletProperty_Action_1_T_Nullable_1_Vector2_0<T>
		{
			// Token: 0x04005AE4 RID: 23268
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DLC4_GuardController.NativeMethodInfoPtr_SpawnBullet_Public_T_TeamBulletProperty_Action_1_T_Nullable_1_Vector2_0, Il2CppClassPointerStore<DLC4_GuardController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
