using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000093 RID: 147
	public class DLC4_FlandreEnemyCharacterController : MonoBehaviour
	{
		// Token: 0x06000ED9 RID: 3801 RVA: 0x000D0848 File Offset: 0x000CEA48
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_FlandreEnemyCharacterController()
		{
			Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_FlandreEnemyCharacterController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr);
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_IDLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "PARAMETER_IDLE");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_MOVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "PARAMETER_MOVE");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_ATTACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "PARAMETER_ATTACK");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_STUN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "PARAMETER_STUN");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_DIE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "PARAMETER_DIE");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_EnemyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_EnemyId");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_PivotPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_PivotPoint");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_SpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_SpriteRenderer");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_Rigidbody2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_Rigidbody2D");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_Animator");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_MaxHealth");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_AttackPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_AttackPower");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_BaseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_BaseSpeed");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_AttackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_AttackRange");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_DropPPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_DropPPoint");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_BatFogVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "m_BatFogVFX");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_OnFlandreCompletelyDied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "OnFlandreCompletelyDied");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_ActiveCoroutineList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "ActiveCoroutineList");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_attackConditionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "attackConditionCheck");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_attackManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "attackManager");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_attackMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "attackMultiplier");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_currentHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "currentHealth");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_dieManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "dieManager");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_enemyCurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "enemyCurrentState");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_idleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "idleManager");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_isStuned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "isStuned");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_moveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "moveDirection");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_moveManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "moveManager");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_onHurtCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "onHurtCallback");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_poisonDamageStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "poisonDamageStorage");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_poisonProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "poisonProgress");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_poisonVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "poisonVFX");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "speedMultiplier");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_speedMultiplierBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "speedMultiplierBuffer");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_StateDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "StateDictionary");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_stunManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "stunManager");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__MoveTargetY_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<MoveTargetY>k__BackingField");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__SuperArmor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<SuperArmor>k__BackingField");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__IsMoving_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<IsMoving>k__BackingField");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__IsAttacking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<IsAttacking>k__BackingField");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__IsDead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<IsDead>k__BackingField");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__RefreshNextWaveType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<RefreshNextWaveType>k__BackingField");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__CurrentState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<CurrentState>k__BackingField");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<Dlc4BossBattleManager>k__BackingField");
			DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__TargetGuestFortification_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<TargetGuestFortification>k__BackingField");
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_Id_Public_get_FlandreTypeIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665905);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_Rigidbody2D_Public_get_Rigidbody2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665906);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_Animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665907);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_MaxHealth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665908);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665909);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_CurrentHealth_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665910);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_DropPPoint_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665911);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_MoveDirection_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665912);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_MoveDirection_Private_set_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665913);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_MoveTargetY_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665914);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_MoveTargetY_Private_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665915);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentLine_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665916);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665917);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_SuperArmor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665918);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_SuperArmor_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665919);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665920);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_IsMoving_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665921);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665922);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_IsAttacking_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665923);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665924);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665925);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_IsStuned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665926);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CanBeFrozen_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665927);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_RefreshNextWaveType_Public_get_RefreshNextWaveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665928);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_RefreshNextWaveType_Public_set_Void_RefreshNextWaveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665929);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentState_Public_get_CharacterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665930);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_CurrentState_Private_set_Void_CharacterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665931);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665932);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_Dlc4BossBattleManager_Public_get_DLC4_BossBattleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665933);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_Dlc4BossBattleManager_Private_set_Void_DLC4_BossBattleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665934);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentPower_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665935);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_TargetGuestFortification_Protected_get_DLC4_GuardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665936);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_TargetGuestFortification_Protected_set_Void_DLC4_GuardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665937);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665938);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665939);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SetSpeedMultiplierBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665940);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_GetFlandreNameInConsole_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665941);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665942);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SpeedCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665943);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PoisonDamage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665944);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665945);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SetCurrentState_Public_Void_CharacterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665946);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_CanAttack_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665947);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Attack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665948);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_OnAttack_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665949);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_OnCurrentHPChangeCallback_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665950);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_OnHurt_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665951);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_CalculateRemainingHealth_Protected_Virtual_New_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665952);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Kill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665953);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_ChangeSpeed_Public_Void_Int32_Single_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665954);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SetPoison_Public_Void_Int32_Int32_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665955);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_StopPoisonVFX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665956);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_BeginStun_Public_Void_Single_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665957);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_ChangePower_Public_Void_Single_Single_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665958);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_RegisterCoroutine_Public_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665959);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SetTargetPositionY_Public_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665960);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SetMoveDirectionX_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665961);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_StartRegisterBuff_Private_Void_Single_Action_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665962);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_RegisterTimedBuffInternal_Private_IEnumerator_Guid_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665963);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_RegisterCoroutineInternal_Private_IEnumerator_Guid_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665964);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Die_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665965);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PlayIdleAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665966);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PlayMoveAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665967);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PlayAttackAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665968);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PlayStunAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665969);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PlayDieAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665970);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665971);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665972);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665973);
			DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr__BeginStun_b__121_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, 100665974);
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x000D1174 File Offset: 0x000CF374
		public unsafe FlandreTypeIndex Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_Id_Public_get_FlandreTypeIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x000D11B0 File Offset: 0x000CF3B0
		public unsafe Rigidbody2D Rigidbody2D
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_Rigidbody2D_Public_get_Rigidbody2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr3) : null;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x000D11F0 File Offset: 0x000CF3F0
		public unsafe Animator Animator
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_Animator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x000D1230 File Offset: 0x000CF430
		public unsafe int MaxHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_MaxHealth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x000D126C File Offset: 0x000CF46C
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x000D12A8 File Offset: 0x000CF4A8
		public unsafe int CurrentHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_CurrentHealth_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x000D12E8 File Offset: 0x000CF4E8
		public unsafe int DropPPoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 47610, RefRangeEnd = 47613, XrefRangeStart = 47610, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_DropPPoint_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x000D1324 File Offset: 0x000CF524
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x000D1360 File Offset: 0x000CF560
		public unsafe Vector2Int MoveDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_MoveDirection_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47613, XrefRangeEnd = 47615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_MoveDirection_Private_set_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x000D13A0 File Offset: 0x000CF5A0
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x000D13D8 File Offset: 0x000CF5D8
		public unsafe Nullable<int> MoveTargetY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_MoveTargetY_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<int>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_MoveTargetY_Private_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x000D1420 File Offset: 0x000CF620
		public unsafe int CurrentLine
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 47621, RefRangeEnd = 47637, XrefRangeStart = 47615, XrefRangeEnd = 47621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentLine_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x000D145C File Offset: 0x000CF65C
		public unsafe Vector2 CurrentPosition
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 47638, RefRangeEnd = 47644, XrefRangeStart = 47637, XrefRangeEnd = 47638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x000D1498 File Offset: 0x000CF698
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x000D14D4 File Offset: 0x000CF6D4
		public unsafe bool SuperArmor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_SuperArmor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_SuperArmor_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x000D1514 File Offset: 0x000CF714
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x000D1550 File Offset: 0x000CF750
		public unsafe bool IsMoving
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_IsMoving_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x000D1590 File Offset: 0x000CF790
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x000D15CC File Offset: 0x000CF7CC
		public unsafe bool IsAttacking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_IsAttacking_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x000D160C File Offset: 0x000CF80C
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x000D1648 File Offset: 0x000CF848
		public unsafe bool IsDead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x000D1688 File Offset: 0x000CF888
		public unsafe bool IsStuned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_IsStuned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x000D16C4 File Offset: 0x000CF8C4
		public unsafe virtual bool CanBeFrozen
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CanBeFrozen_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000D170C File Offset: 0x000CF90C
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x000D1748 File Offset: 0x000CF948
		public unsafe DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.RefreshNextWaveType RefreshNextWaveType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_RefreshNextWaveType_Public_get_RefreshNextWaveType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_RefreshNextWaveType_Public_set_Void_RefreshNextWaveType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x000D1788 File Offset: 0x000CF988
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x000D17C4 File Offset: 0x000CF9C4
		public unsafe DLC4_FlandreEnemyCharacterController.CharacterState CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentState_Public_get_CharacterState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_CurrentState_Private_set_Void_CharacterState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x000D1804 File Offset: 0x000CFA04
		public unsafe float CurrentSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x000D1840 File Offset: 0x000CFA40
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x000D1880 File Offset: 0x000CFA80
		public unsafe DLC4_BossBattleManager Dlc4BossBattleManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_Dlc4BossBattleManager_Public_get_DLC4_BossBattleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_Dlc4BossBattleManager_Private_set_Void_DLC4_BossBattleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x000D18C4 File Offset: 0x000CFAC4
		public unsafe int CurrentPower
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47644, XrefRangeEnd = 47668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_CurrentPower_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x000D1900 File Offset: 0x000CFB00
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x000D1940 File Offset: 0x000CFB40
		public unsafe DLC4_GuardController TargetGuestFortification
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_get_TargetGuestFortification_Protected_get_DLC4_GuardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC4_GuardController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47668, XrefRangeEnd = 47669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_set_TargetGuestFortification_Protected_set_Void_DLC4_GuardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000D1984 File Offset: 0x000CFB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47669, XrefRangeEnd = 47671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000D19B8 File Offset: 0x000CFBB8
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x000D19EC File Offset: 0x000CFBEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 47713, RefRangeEnd = 47716, XrefRangeStart = 47671, XrefRangeEnd = 47713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpeedMultiplierBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SetSpeedMultiplierBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x000D1A20 File Offset: 0x000CFC20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47723, RefRangeEnd = 47724, XrefRangeStart = 47716, XrefRangeEnd = 47723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFlandreNameInConsole()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_GetFlandreNameInConsole_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x000D1A58 File Offset: 0x000CFC58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 47870, RefRangeEnd = 47874, XrefRangeStart = 47724, XrefRangeEnd = 47870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, Action afterAttackingFinishCallback, Action afterCompletelyDeadCallback, DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dlc4BossBattleManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAttackingFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCompletelyDeadCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attackConditionCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x000D1ADC File Offset: 0x000CFCDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47896, RefRangeEnd = 47897, XrefRangeStart = 47874, XrefRangeEnd = 47896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpeedCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SpeedCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x000D1B10 File Offset: 0x000CFD10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47940, RefRangeEnd = 47941, XrefRangeStart = 47897, XrefRangeEnd = 47940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoisonDamage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PoisonDamage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x000D1B44 File Offset: 0x000CFD44
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000D1B80 File Offset: 0x000CFD80
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 47945, RefRangeEnd = 47953, XrefRangeStart = 47941, XrefRangeEnd = 47945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentState(DLC4_FlandreEnemyCharacterController.CharacterState nextState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nextState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SetCurrentState_Public_Void_CharacterState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x000D1BC0 File Offset: 0x000CFDC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47958, RefRangeEnd = 47959, XrefRangeStart = 47953, XrefRangeEnd = 47958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_CanAttack_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x000D1C08 File Offset: 0x000CFE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47959, XrefRangeEnd = 47969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Attack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x000D1C3C File Offset: 0x000CFE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47969, XrefRangeEnd = 48001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_OnAttack_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000D1C78 File Offset: 0x000CFE78
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCurrentHPChangeCallback(int hpAfterChange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hpAfterChange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_OnCurrentHPChangeCallback_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x000D1CC4 File Offset: 0x000CFEC4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 48002, RefRangeEnd = 48009, XrefRangeStart = 48001, XrefRangeEnd = 48002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHurt(int damage, bool showMercy = false, bool internalInjury = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showMercy;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalInjury;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_OnHurt_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x000D1D20 File Offset: 0x000CFF20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48010, RefRangeEnd = 48011, XrefRangeStart = 48009, XrefRangeEnd = 48010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateRemainingHealth(int damage, bool showMercy = false, bool internalInjury = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showMercy;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalInjury;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_CalculateRemainingHealth_Protected_Virtual_New_Void_Int32_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x000D1D88 File Offset: 0x000CFF88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48013, RefRangeEnd = 48015, XrefRangeStart = 48011, XrefRangeEnd = 48013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Kill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x000D1DBC File Offset: 0x000CFFBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 48030, RefRangeEnd = 48036, XrefRangeStart = 48015, XrefRangeEnd = 48030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSpeed(int bulletId, float multiplier, float duration, Action onBuffEnd = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bulletId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiplier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffEnd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_ChangeSpeed_Public_Void_Int32_Single_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x000D1E2C File Offset: 0x000D002C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 48089, RefRangeEnd = 48092, XrefRangeStart = 48036, XrefRangeEnd = 48089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPoison(int bulletId, int poisonDamage, float duration, Action onBuffEnd = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bulletId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poisonDamage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffEnd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SetPoison_Public_Void_Int32_Int32_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x000D1E9C File Offset: 0x000D009C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48097, RefRangeEnd = 48099, XrefRangeStart = 48092, XrefRangeEnd = 48097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPoisonVFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_StopPoisonVFX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000D1ED0 File Offset: 0x000D00D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 48108, RefRangeEnd = 48115, XrefRangeStart = 48099, XrefRangeEnd = 48108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginStun(float duration, out Action interruptCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_BeginStun_Public_Void_Single_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			interruptCallback = ((intPtr4 == 0) ? null : new Action(intPtr4));
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000D1F30 File Offset: 0x000D0130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48131, RefRangeEnd = 48132, XrefRangeStart = 48115, XrefRangeEnd = 48131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePower(float multiplier, float duration, out Action interruptCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_ChangePower_Public_Void_Single_Single_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			interruptCallback = ((intPtr4 == 0) ? null : new Action(intPtr4));
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x000D1FA0 File Offset: 0x000D01A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48132, XrefRangeEnd = 48156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCoroutine(IEnumerator enumerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_RegisterCoroutine_Public_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x000D1FE4 File Offset: 0x000D01E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48156, XrefRangeEnd = 48163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetPositionY(Nullable<int> targetPositionY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(targetPositionY));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SetTargetPositionY_Public_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000D202C File Offset: 0x000D022C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48163, XrefRangeEnd = 48165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMoveDirectionX(bool targetPositionX)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPositionX;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_SetMoveDirectionX_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x000D206C File Offset: 0x000D026C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48190, RefRangeEnd = 48192, XrefRangeStart = 48165, XrefRangeEnd = 48190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartRegisterBuff(float duration, Action onBuffEnd, out Action interruptCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffEnd);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_StartRegisterBuff_Private_Void_Single_Action_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			interruptCallback = ((intPtr4 == 0) ? null : new Action(intPtr4));
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x000D20E0 File Offset: 0x000D02E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48192, XrefRangeEnd = 48197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RegisterTimedBuffInternal(Guid guid, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_RegisterTimedBuffInternal_Private_IEnumerator_Guid_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x000D213C File Offset: 0x000D033C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48197, XrefRangeEnd = 48203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RegisterCoroutineInternal(Guid guid, Coroutine coroutine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_RegisterCoroutineInternal_Private_IEnumerator_Guid_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x000D219C File Offset: 0x000D039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48203, XrefRangeEnd = 48211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Die_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000D21D8 File Offset: 0x000D03D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48211, XrefRangeEnd = 48215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayIdleAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PlayIdleAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000D220C File Offset: 0x000D040C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48215, XrefRangeEnd = 48219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMoveAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PlayMoveAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000D2240 File Offset: 0x000D0440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48219, XrefRangeEnd = 48223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAttackAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PlayAttackAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000D2274 File Offset: 0x000D0474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48223, XrefRangeEnd = 48227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStunAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PlayStunAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000D22A8 File Offset: 0x000D04A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48227, XrefRangeEnd = 48231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayDieAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_PlayDieAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x000D22DC File Offset: 0x000D04DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48270, RefRangeEnd = 48271, XrefRangeStart = 48231, XrefRangeEnd = 48270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x000D2310 File Offset: 0x000D0510
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 48292, RefRangeEnd = 48297, XrefRangeStart = 48271, XrefRangeEnd = 48292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x000D234C File Offset: 0x000D054C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 48306, RefRangeEnd = 48311, XrefRangeStart = 48297, XrefRangeEnd = 48306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_FlandreEnemyCharacterController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000D2388 File Offset: 0x000D0588
		[CallerCount(0)]
		public unsafe void _BeginStun_b__121_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.NativeMethodInfoPtr__BeginStun_b__121_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00009AC2 File Offset: 0x00007CC2
		public DLC4_FlandreEnemyCharacterController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000D23BC File Offset: 0x000D05BC
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00009ACB File Offset: 0x00007CCB
		public unsafe static string PARAMETER_IDLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_IDLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_IDLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x000D23DC File Offset: 0x000D05DC
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x00009ADD File Offset: 0x00007CDD
		public unsafe static string PARAMETER_MOVE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_MOVE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_MOVE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x000D23FC File Offset: 0x000D05FC
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x00009AEF File Offset: 0x00007CEF
		public unsafe static string PARAMETER_ATTACK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_ATTACK, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_ATTACK, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x000D241C File Offset: 0x000D061C
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00009B01 File Offset: 0x00007D01
		public unsafe static string PARAMETER_STUN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_STUN, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_STUN, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x000D243C File Offset: 0x000D063C
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x00009B13 File Offset: 0x00007D13
		public unsafe static string PARAMETER_DIE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_DIE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_PARAMETER_DIE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x000D245C File Offset: 0x000D065C
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00009B25 File Offset: 0x00007D25
		public unsafe FlandreTypeIndex m_EnemyId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_EnemyId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_EnemyId)) = value;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000D2484 File Offset: 0x000D0684
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00009B40 File Offset: 0x00007D40
		public unsafe Transform m_PivotPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_PivotPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_PivotPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000D24B4 File Offset: 0x000D06B4
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x00009B5F File Offset: 0x00007D5F
		public unsafe SpriteRenderer m_SpriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_SpriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_SpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x000D24E4 File Offset: 0x000D06E4
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x00009B7E File Offset: 0x00007D7E
		public unsafe Rigidbody2D m_Rigidbody2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_Rigidbody2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_Rigidbody2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x000D2514 File Offset: 0x000D0714
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x00009B9D File Offset: 0x00007D9D
		public unsafe Animator m_Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x000D2544 File Offset: 0x000D0744
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x00009BBC File Offset: 0x00007DBC
		public unsafe int m_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_MaxHealth)) = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x000D256C File Offset: 0x000D076C
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x00009BD7 File Offset: 0x00007DD7
		public unsafe int m_AttackPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_AttackPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_AttackPower)) = value;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x000D2594 File Offset: 0x000D0794
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x00009BF2 File Offset: 0x00007DF2
		public unsafe float m_BaseSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_BaseSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_BaseSpeed)) = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x000D25BC File Offset: 0x000D07BC
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00009C0D File Offset: 0x00007E0D
		public unsafe float m_AttackRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_AttackRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_AttackRange)) = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000D25E4 File Offset: 0x000D07E4
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00009C28 File Offset: 0x00007E28
		public unsafe int m_DropPPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_DropPPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_DropPPoint)) = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000D260C File Offset: 0x000D080C
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00009C43 File Offset: 0x00007E43
		public VFXPrefab m_BatFogVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_BatFogVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_m_BatFogVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000D263C File Offset: 0x000D083C
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00009C71 File Offset: 0x00007E71
		public unsafe Action<DLC4_FlandreEnemyCharacterController> OnFlandreCompletelyDied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_OnFlandreCompletelyDied);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DLC4_FlandreEnemyCharacterController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_OnFlandreCompletelyDied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000D266C File Offset: 0x000D086C
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x00009C90 File Offset: 0x00007E90
		public unsafe Dictionary<Guid, Action> ActiveCoroutineList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_ActiveCoroutineList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Guid, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_ActiveCoroutineList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x000D269C File Offset: 0x000D089C
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00009CAF File Offset: 0x00007EAF
		public unsafe DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_attackConditionCheck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController.AttackConditionCheck>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_attackConditionCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000D26CC File Offset: 0x000D08CC
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x00009CCE File Offset: 0x00007ECE
		public unsafe AttackState attackManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_attackManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttackState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_attackManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x000D26FC File Offset: 0x000D08FC
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00009CED File Offset: 0x00007EED
		public unsafe List<float> attackMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_attackMultiplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_attackMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x000D272C File Offset: 0x000D092C
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00009D0C File Offset: 0x00007F0C
		public unsafe int currentHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_currentHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_currentHealth)) = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x000D2754 File Offset: 0x000D0954
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00009D27 File Offset: 0x00007F27
		public unsafe DieState dieManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_dieManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DieState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_dieManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000D2784 File Offset: 0x000D0984
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00009D46 File Offset: 0x00007F46
		public unsafe DLC4_FlandreEnemyState enemyCurrentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_enemyCurrentState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_enemyCurrentState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x000D27B4 File Offset: 0x000D09B4
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x00009D65 File Offset: 0x00007F65
		public unsafe IdleState idleManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_idleManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdleState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_idleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x000D27E4 File Offset: 0x000D09E4
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x00009D84 File Offset: 0x00007F84
		public unsafe int isStuned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_isStuned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_isStuned)) = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x000D280C File Offset: 0x000D0A0C
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x00009D9F File Offset: 0x00007F9F
		public unsafe Vector2Int moveDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_moveDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_moveDirection)) = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x000D2834 File Offset: 0x000D0A34
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x00009DBA File Offset: 0x00007FBA
		public unsafe MoveState moveManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_moveManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_moveManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x000D2864 File Offset: 0x000D0A64
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x00009DD9 File Offset: 0x00007FD9
		public unsafe Action<int> onHurtCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_onHurtCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_onHurtCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x000D2894 File Offset: 0x000D0A94
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x00009DF8 File Offset: 0x00007FF8
		public unsafe Dictionary<int, DLC4_FlandreEnemyCharacterController.MultiplierModifier> poisonDamageStorage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_poisonDamageStorage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DLC4_FlandreEnemyCharacterController.MultiplierModifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_poisonDamageStorage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x000D28C4 File Offset: 0x000D0AC4
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x00009E17 File Offset: 0x00008017
		public unsafe float poisonProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_poisonProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_poisonProgress)) = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x000D28EC File Offset: 0x000D0AEC
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x00009E32 File Offset: 0x00008032
		public unsafe ParticleSystem poisonVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_poisonVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_poisonVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x000D291C File Offset: 0x000D0B1C
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x00009E51 File Offset: 0x00008051
		public unsafe Dictionary<int, DLC4_FlandreEnemyCharacterController.MultiplierModifier> speedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_speedMultiplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DLC4_FlandreEnemyCharacterController.MultiplierModifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_speedMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x000D294C File Offset: 0x000D0B4C
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x00009E70 File Offset: 0x00008070
		public unsafe float speedMultiplierBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_speedMultiplierBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_speedMultiplierBuffer)) = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x000D2974 File Offset: 0x000D0B74
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00009E8B File Offset: 0x0000808B
		public unsafe Dictionary<DLC4_FlandreEnemyCharacterController.CharacterState, DLC4_FlandreEnemyState> StateDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_StateDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DLC4_FlandreEnemyCharacterController.CharacterState, DLC4_FlandreEnemyState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_StateDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x000D29A4 File Offset: 0x000D0BA4
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00009EAA File Offset: 0x000080AA
		public unsafe StunState stunManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_stunManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StunState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr_stunManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x000D29D4 File Offset: 0x000D0BD4
		// (set) Token: 0x06000F6A RID: 3946 RVA: 0x00009EC9 File Offset: 0x000080C9
		public Nullable<int> _MoveTargetY_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__MoveTargetY_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__MoveTargetY_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x000D2A04 File Offset: 0x000D0C04
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x00009EF7 File Offset: 0x000080F7
		public unsafe bool _SuperArmor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__SuperArmor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__SuperArmor_k__BackingField)) = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x000D2A2C File Offset: 0x000D0C2C
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x00009F12 File Offset: 0x00008112
		public unsafe bool _IsMoving_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__IsMoving_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__IsMoving_k__BackingField)) = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x000D2A54 File Offset: 0x000D0C54
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00009F2D File Offset: 0x0000812D
		public unsafe bool _IsAttacking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__IsAttacking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__IsAttacking_k__BackingField)) = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x000D2A7C File Offset: 0x000D0C7C
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x00009F48 File Offset: 0x00008148
		public unsafe bool _IsDead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__IsDead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__IsDead_k__BackingField)) = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x000D2AA4 File Offset: 0x000D0CA4
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00009F63 File Offset: 0x00008163
		public unsafe DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.RefreshNextWaveType _RefreshNextWaveType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__RefreshNextWaveType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__RefreshNextWaveType_k__BackingField)) = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x000D2ACC File Offset: 0x000D0CCC
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x00009F7E File Offset: 0x0000817E
		public unsafe DLC4_FlandreEnemyCharacterController.CharacterState _CurrentState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__CurrentState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__CurrentState_k__BackingField)) = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x000D2AF4 File Offset: 0x000D0CF4
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x00009F99 File Offset: 0x00008199
		public unsafe DLC4_BossBattleManager _Dlc4BossBattleManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x000D2B24 File Offset: 0x000D0D24
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x00009FB8 File Offset: 0x000081B8
		public unsafe DLC4_GuardController _TargetGuestFortification_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__TargetGuestFortification_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.NativeFieldInfoPtr__TargetGuestFortification_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeFieldInfoPtr_PARAMETER_IDLE;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeFieldInfoPtr_PARAMETER_MOVE;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeFieldInfoPtr_PARAMETER_ATTACK;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeFieldInfoPtr_PARAMETER_STUN;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeFieldInfoPtr_PARAMETER_DIE;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeFieldInfoPtr_m_EnemyId;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeFieldInfoPtr_m_PivotPoint;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteRenderer;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeFieldInfoPtr_m_Rigidbody2D;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeFieldInfoPtr_m_Animator;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxHealth;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeFieldInfoPtr_m_AttackPower;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseSpeed;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeFieldInfoPtr_m_AttackRange;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeFieldInfoPtr_m_DropPPoint;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeFieldInfoPtr_m_BatFogVFX;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeFieldInfoPtr_OnFlandreCompletelyDied;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeFieldInfoPtr_ActiveCoroutineList;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeFieldInfoPtr_attackConditionCheck;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_attackManager;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_attackMultiplier;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr_currentHealth;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr_dieManager;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr_enemyCurrentState;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr_idleManager;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeFieldInfoPtr_isStuned;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeFieldInfoPtr_moveDirection;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr_moveManager;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr_onHurtCallback;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeFieldInfoPtr_poisonDamageStorage;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_poisonProgress;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr_poisonVFX;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr_speedMultiplierBuffer;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr_StateDictionary;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr_stunManager;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr__MoveTargetY_k__BackingField;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr__SuperArmor_k__BackingField;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr__IsMoving_k__BackingField;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr__IsAttacking_k__BackingField;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr__IsDead_k__BackingField;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr__RefreshNextWaveType_k__BackingField;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr__CurrentState_k__BackingField;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr__TargetGuestFortification_k__BackingField;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_FlandreTypeIndex_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_get_Rigidbody2D_Public_get_Rigidbody2D_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_get_Animator_Public_get_Animator_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxHealth_Public_get_Int32_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHealth_Public_get_Int32_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHealth_Private_set_Void_Int32_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_get_DropPPoint_Public_get_Int32_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveDirection_Public_get_Vector2Int_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveDirection_Private_set_Void_Vector2Int_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveTargetY_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveTargetY_Private_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLine_Public_get_Int32_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_get_Vector2_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_get_SuperArmor_Public_get_Boolean_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_set_SuperArmor_Protected_set_Void_Boolean_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMoving_Public_set_Void_Boolean_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAttacking_Public_set_Void_Boolean_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStuned_Public_get_Boolean_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeFrozen_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_get_RefreshNextWaveType_Public_get_RefreshNextWaveType_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_set_RefreshNextWaveType_Public_set_Void_RefreshNextWaveType_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Public_get_CharacterState_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentState_Private_set_Void_CharacterState_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSpeed_Public_get_Single_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_get_Dlc4BossBattleManager_Public_get_DLC4_BossBattleManager_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_set_Dlc4BossBattleManager_Private_set_Void_DLC4_BossBattleManager_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPower_Protected_get_Int32_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetGuestFortification_Protected_get_DLC4_GuardController_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetGuestFortification_Protected_set_Void_DLC4_GuardController_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeedMultiplierBuffer_Private_Void_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_GetFlandreNameInConsole_Public_String_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_SpeedCheck_Private_Void_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_PoisonDamage_Private_Void_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentState_Public_Void_CharacterState_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_CanAttack_Public_Virtual_New_Boolean_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Public_Void_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_OnAttack_Protected_Virtual_New_Void_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_OnCurrentHPChangeCallback_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_OnHurt_Public_Void_Int32_Boolean_Boolean_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRemainingHealth_Protected_Virtual_New_Void_Int32_Boolean_Boolean_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Void_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSpeed_Public_Void_Int32_Single_Single_Action_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_SetPoison_Public_Void_Int32_Int32_Single_Action_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_StopPoisonVFX_Private_Void_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_BeginStun_Public_Void_Single_byref_Action_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_ChangePower_Public_Void_Single_Single_byref_Action_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCoroutine_Public_Void_IEnumerator_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetPositionY_Public_Void_Nullable_1_Int32_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_SetMoveDirectionX_Public_Void_Boolean_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_StartRegisterBuff_Private_Void_Single_Action_byref_Action_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTimedBuffInternal_Private_IEnumerator_Guid_Single_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCoroutineInternal_Private_IEnumerator_Guid_Coroutine_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_Die_Protected_Virtual_New_Void_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_PlayIdleAnimation_Private_Void_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_PlayMoveAnimation_Private_Void_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_PlayAttackAnimation_Private_Void_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_PlayStunAnimation_Private_Void_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_PlayDieAnimation_Private_Void_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr__BeginStun_b__121_0_Private_Void_0;

		// Token: 0x0200056D RID: 1389
		public sealed class AttackConditionCheck : MulticastDelegate
		{
			// Token: 0x06008959 RID: 35161 RVA: 0x0026092C File Offset: 0x0025EB2C
			// Note: this type is marked as 'beforefieldinit'.
			static AttackConditionCheck()
			{
				Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.AttackConditionCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "AttackConditionCheck");
				DLC4_FlandreEnemyCharacterController.AttackConditionCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.AttackConditionCheck>.NativeClassPtr, 100665975);
				DLC4_FlandreEnemyCharacterController.AttackConditionCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_Single_Int32_Vector2_byref_DLC4_GuardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.AttackConditionCheck>.NativeClassPtr, 100665976);
				DLC4_FlandreEnemyCharacterController.AttackConditionCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_Single_Int32_Vector2_byref_DLC4_GuardController_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.AttackConditionCheck>.NativeClassPtr, 100665977);
				DLC4_FlandreEnemyCharacterController.AttackConditionCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_DLC4_GuardController_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.AttackConditionCheck>.NativeClassPtr, 100665978);
			}

			// Token: 0x0600895A RID: 35162 RVA: 0x002609A0 File Offset: 0x0025EBA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 47506, RefRangeEnd = 47507, XrefRangeStart = 47500, XrefRangeEnd = 47506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttackConditionCheck(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.AttackConditionCheck>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.AttackConditionCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600895B RID: 35163 RVA: 0x002609FC File Offset: 0x0025EBFC
			[CallerCount(0)]
			public unsafe bool Invoke(bool moveDirection, float attackRange, int currentLine, Vector2 position, out DLC4_GuardController guestFortification)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref moveDirection;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attackRange;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentLine;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.AttackConditionCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_Single_Int32_Vector2_byref_DLC4_GuardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				guestFortification = ((intPtr4 == 0) ? null : new DLC4_GuardController(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600895C RID: 35164 RVA: 0x00260A94 File Offset: 0x0025EC94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47507, XrefRangeEnd = 47520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(bool moveDirection, float attackRange, int currentLine, Vector2 position, out DLC4_GuardController guestFortification, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref moveDirection;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attackRange;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentLine;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.AttackConditionCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_Single_Int32_Vector2_byref_DLC4_GuardController_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				guestFortification = ((intPtr4 == 0) ? null : new DLC4_GuardController(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x0600895D RID: 35165 RVA: 0x00260B54 File Offset: 0x0025ED54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47520, XrefRangeEnd = 47522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out DLC4_GuardController guestFortification, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.AttackConditionCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_DLC4_GuardController_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				guestFortification = ((intPtr4 == 0) ? null : new DLC4_GuardController(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600895E RID: 35166 RVA: 0x00049DE8 File Offset: 0x00047FE8
			public AttackConditionCheck(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040059FD RID: 23037
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040059FE RID: 23038
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_Single_Int32_Vector2_byref_DLC4_GuardController_0;

			// Token: 0x040059FF RID: 23039
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_Single_Int32_Vector2_byref_DLC4_GuardController_AsyncCallback_Object_0;

			// Token: 0x04005A00 RID: 23040
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_DLC4_GuardController_IAsyncResult_0;
		}

		// Token: 0x0200056E RID: 1390
		public enum CharacterState
		{
			// Token: 0x04005A02 RID: 23042
			Idle,
			// Token: 0x04005A03 RID: 23043
			Move,
			// Token: 0x04005A04 RID: 23044
			Attack,
			// Token: 0x04005A05 RID: 23045
			Stun,
			// Token: 0x04005A06 RID: 23046
			Die,
			// Token: 0x04005A07 RID: 23047
			Throw,
			// Token: 0x04005A08 RID: 23048
			Jump
		}

		// Token: 0x0200056F RID: 1391
		[Serializable]
		public sealed class FlandreBullet : ValueType
		{
			// Token: 0x0600895F RID: 35167 RVA: 0x00260BC4 File Offset: 0x0025EDC4
			// Note: this type is marked as 'beforefieldinit'.
			static FlandreBullet()
			{
				Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "FlandreBullet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr);
				DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_Bullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr, "m_Bullet");
				DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr, "m_Damage");
				DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr, "m_Speed");
				DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_MaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr, "m_MaxDuration");
			}

			// Token: 0x06008960 RID: 35168 RVA: 0x00049DF1 File Offset: 0x00047FF1
			public FlandreBullet(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008961 RID: 35169 RVA: 0x00049DFA File Offset: 0x00047FFA
			public FlandreBullet() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr))
			{
			}

			// Token: 0x17002E0C RID: 11788
			// (get) Token: 0x06008962 RID: 35170 RVA: 0x00260C40 File Offset: 0x0025EE40
			// (set) Token: 0x06008963 RID: 35171 RVA: 0x00049E0C File Offset: 0x0004800C
			public unsafe DLC4_BulletEnemy m_Bullet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_Bullet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BulletEnemy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_Bullet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E0D RID: 11789
			// (get) Token: 0x06008964 RID: 35172 RVA: 0x00260C70 File Offset: 0x0025EE70
			// (set) Token: 0x06008965 RID: 35173 RVA: 0x00049E2B File Offset: 0x0004802B
			public unsafe int m_Damage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_Damage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_Damage)) = value;
				}
			}

			// Token: 0x17002E0E RID: 11790
			// (get) Token: 0x06008966 RID: 35174 RVA: 0x00260C98 File Offset: 0x0025EE98
			// (set) Token: 0x06008967 RID: 35175 RVA: 0x00049E46 File Offset: 0x00048046
			public unsafe float m_Speed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_Speed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_Speed)) = value;
				}
			}

			// Token: 0x17002E0F RID: 11791
			// (get) Token: 0x06008968 RID: 35176 RVA: 0x00260CC0 File Offset: 0x0025EEC0
			// (set) Token: 0x06008969 RID: 35177 RVA: 0x00049E61 File Offset: 0x00048061
			public unsafe float m_MaxDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_MaxDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.FlandreBullet.NativeFieldInfoPtr_m_MaxDuration)) = value;
				}
			}

			// Token: 0x04005A09 RID: 23049
			private static readonly IntPtr NativeFieldInfoPtr_m_Bullet;

			// Token: 0x04005A0A RID: 23050
			private static readonly IntPtr NativeFieldInfoPtr_m_Damage;

			// Token: 0x04005A0B RID: 23051
			private static readonly IntPtr NativeFieldInfoPtr_m_Speed;

			// Token: 0x04005A0C RID: 23052
			private static readonly IntPtr NativeFieldInfoPtr_m_MaxDuration;
		}

		// Token: 0x02000570 RID: 1392
		public sealed class MultiplierModifier : ValueType
		{
			// Token: 0x0600896A RID: 35178 RVA: 0x00260CE8 File Offset: 0x0025EEE8
			// Note: this type is marked as 'beforefieldinit'.
			static MultiplierModifier()
			{
				Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "MultiplierModifier");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr);
				DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeFieldInfoPtr_onBuffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr, "onBuffEnd");
				DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeFieldInfoPtr__RemainingDuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr, "<RemainingDuration>k__BackingField");
				DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeFieldInfoPtr__Multiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr, "<Multiplier>k__BackingField");
				DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr, 100665979);
				DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr_get_RemainingDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr, 100665980);
				DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr_set_RemainingDuration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr, 100665981);
				DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr, 100665982);
				DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr_OnBuffEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr, 100665983);
				DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr_SetNewAction_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr, 100665984);
			}

			// Token: 0x0600896B RID: 35179 RVA: 0x00260DC8 File Offset: 0x0025EFC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47522, XrefRangeEnd = 47523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MultiplierModifier(float duration, float multiplier, Action onBuffEnd) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref duration;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiplier;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffEnd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E13 RID: 11795
			// (get) Token: 0x0600896C RID: 35180 RVA: 0x00260E34 File Offset: 0x0025F034
			// (set) Token: 0x0600896D RID: 35181 RVA: 0x00260E78 File Offset: 0x0025F078
			public unsafe float RemainingDuration
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr_get_RemainingDuration_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(40)]
				[CachedScanResults(RefRangeStart = 47523, RefRangeEnd = 47563, XrefRangeStart = 47523, XrefRangeEnd = 47523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr_set_RemainingDuration_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17002E14 RID: 11796
			// (get) Token: 0x0600896E RID: 35182 RVA: 0x00260EBC File Offset: 0x0025F0BC
			public unsafe float Multiplier
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600896F RID: 35183 RVA: 0x00260F00 File Offset: 0x0025F100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47563, XrefRangeEnd = 47564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnBuffEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr_OnBuffEnd_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008970 RID: 35184 RVA: 0x00260F38 File Offset: 0x0025F138
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 2767, RefRangeEnd = 2776, XrefRangeStart = 2767, XrefRangeEnd = 2776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNewAction(Action onBuffEnd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onBuffEnd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeMethodInfoPtr_SetNewAction_Public_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008971 RID: 35185 RVA: 0x00049E7C File Offset: 0x0004807C
			public MultiplierModifier(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008972 RID: 35186 RVA: 0x00049E85 File Offset: 0x00048085
			public MultiplierModifier() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.MultiplierModifier>.NativeClassPtr))
			{
			}

			// Token: 0x17002E10 RID: 11792
			// (get) Token: 0x06008973 RID: 35187 RVA: 0x00260F80 File Offset: 0x0025F180
			// (set) Token: 0x06008974 RID: 35188 RVA: 0x00049E97 File Offset: 0x00048097
			public unsafe Action onBuffEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeFieldInfoPtr_onBuffEnd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeFieldInfoPtr_onBuffEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E11 RID: 11793
			// (get) Token: 0x06008975 RID: 35189 RVA: 0x00260FB0 File Offset: 0x0025F1B0
			// (set) Token: 0x06008976 RID: 35190 RVA: 0x00049EB6 File Offset: 0x000480B6
			public unsafe float _RemainingDuration_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeFieldInfoPtr__RemainingDuration_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeFieldInfoPtr__RemainingDuration_k__BackingField)) = value;
				}
			}

			// Token: 0x17002E12 RID: 11794
			// (get) Token: 0x06008977 RID: 35191 RVA: 0x00260FD8 File Offset: 0x0025F1D8
			// (set) Token: 0x06008978 RID: 35192 RVA: 0x00049ED1 File Offset: 0x000480D1
			public unsafe float _Multiplier_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeFieldInfoPtr__Multiplier_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.MultiplierModifier.NativeFieldInfoPtr__Multiplier_k__BackingField)) = value;
				}
			}

			// Token: 0x04005A0D RID: 23053
			private static readonly IntPtr NativeFieldInfoPtr_onBuffEnd;

			// Token: 0x04005A0E RID: 23054
			private static readonly IntPtr NativeFieldInfoPtr__RemainingDuration_k__BackingField;

			// Token: 0x04005A0F RID: 23055
			private static readonly IntPtr NativeFieldInfoPtr__Multiplier_k__BackingField;

			// Token: 0x04005A10 RID: 23056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Action_0;

			// Token: 0x04005A11 RID: 23057
			private static readonly IntPtr NativeMethodInfoPtr_get_RemainingDuration_Public_get_Single_0;

			// Token: 0x04005A12 RID: 23058
			private static readonly IntPtr NativeMethodInfoPtr_set_RemainingDuration_Public_set_Void_Single_0;

			// Token: 0x04005A13 RID: 23059
			private static readonly IntPtr NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0;

			// Token: 0x04005A14 RID: 23060
			private static readonly IntPtr NativeMethodInfoPtr_OnBuffEnd_Public_Void_0;

			// Token: 0x04005A15 RID: 23061
			private static readonly IntPtr NativeMethodInfoPtr_SetNewAction_Public_Void_Action_0;
		}

		// Token: 0x02000571 RID: 1393
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_FlandreEnemyCharacterController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008979 RID: 35193 RVA: 0x00261000 File Offset: 0x0025F200
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr);
				DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr, "<>9");
				DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__97_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr, "<>9__97_0");
				DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__104_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr, "<>9__104_0");
				DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__104_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr, "<>9__104_1");
				DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__108_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr, "<>9__108_0");
				DLC4_FlandreEnemyCharacterController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr, 100665986);
				DLC4_FlandreEnemyCharacterController.__c.NativeMethodInfoPtr__get_CurrentPower_b__97_0_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr, 100665987);
				DLC4_FlandreEnemyCharacterController.__c.NativeMethodInfoPtr__SetSpeedMultiplierBuffer_b__104_0_Internal_Single_MultiplierModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr, 100665988);
				DLC4_FlandreEnemyCharacterController.__c.NativeMethodInfoPtr__SetSpeedMultiplierBuffer_b__104_1_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr, 100665989);
				DLC4_FlandreEnemyCharacterController.__c.NativeMethodInfoPtr__PoisonDamage_b__108_0_Internal_Single_KeyValuePair_2_Int32_MultiplierModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr, 100665990);
			}

			// Token: 0x0600897A RID: 35194 RVA: 0x002610F4 File Offset: 0x0025F2F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600897B RID: 35195 RVA: 0x00261130 File Offset: 0x0025F330
			[CallerCount(0)]
			public unsafe float _get_CurrentPower_b__97_0(float a, float b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c.NativeMethodInfoPtr__get_CurrentPower_b__97_0_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600897C RID: 35196 RVA: 0x00261188 File Offset: 0x0025F388
			[CallerCount(0)]
			public unsafe float _SetSpeedMultiplierBuffer_b__104_0(DLC4_FlandreEnemyCharacterController.MultiplierModifier x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c.NativeMethodInfoPtr__SetSpeedMultiplierBuffer_b__104_0_Internal_Single_MultiplierModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600897D RID: 35197 RVA: 0x002611DC File Offset: 0x0025F3DC
			[CallerCount(0)]
			public unsafe float _SetSpeedMultiplierBuffer_b__104_1(float a, float b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c.NativeMethodInfoPtr__SetSpeedMultiplierBuffer_b__104_1_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600897E RID: 35198 RVA: 0x00261234 File Offset: 0x0025F434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47564, XrefRangeEnd = 47565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _PoisonDamage_b__108_0(KeyValuePair<int, DLC4_FlandreEnemyCharacterController.MultiplierModifier> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c.NativeMethodInfoPtr__PoisonDamage_b__108_0_Internal_Single_KeyValuePair_2_Int32_MultiplierModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600897F RID: 35199 RVA: 0x00049EEC File Offset: 0x000480EC
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E15 RID: 11797
			// (get) Token: 0x06008980 RID: 35200 RVA: 0x00261288 File Offset: 0x0025F488
			// (set) Token: 0x06008981 RID: 35201 RVA: 0x00049EF5 File Offset: 0x000480F5
			public unsafe static DLC4_FlandreEnemyCharacterController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E16 RID: 11798
			// (get) Token: 0x06008982 RID: 35202 RVA: 0x002612B0 File Offset: 0x0025F4B0
			// (set) Token: 0x06008983 RID: 35203 RVA: 0x00049F07 File Offset: 0x00048107
			public unsafe static Func<float, float, float> __9__97_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__97_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__97_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E17 RID: 11799
			// (get) Token: 0x06008984 RID: 35204 RVA: 0x002612D8 File Offset: 0x0025F4D8
			// (set) Token: 0x06008985 RID: 35205 RVA: 0x00049F19 File Offset: 0x00048119
			public unsafe static Func<DLC4_FlandreEnemyCharacterController.MultiplierModifier, float> __9__104_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__104_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC4_FlandreEnemyCharacterController.MultiplierModifier, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__104_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E18 RID: 11800
			// (get) Token: 0x06008986 RID: 35206 RVA: 0x00261300 File Offset: 0x0025F500
			// (set) Token: 0x06008987 RID: 35207 RVA: 0x00049F2B File Offset: 0x0004812B
			public unsafe static Func<float, float, float> __9__104_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__104_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__104_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E19 RID: 11801
			// (get) Token: 0x06008988 RID: 35208 RVA: 0x00261328 File Offset: 0x0025F528
			// (set) Token: 0x06008989 RID: 35209 RVA: 0x00049F3D File Offset: 0x0004813D
			public unsafe static Func<KeyValuePair<int, DLC4_FlandreEnemyCharacterController.MultiplierModifier>, float> __9__108_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__108_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, DLC4_FlandreEnemyCharacterController.MultiplierModifier>, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreEnemyCharacterController.__c.NativeFieldInfoPtr___9__108_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A16 RID: 23062
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005A17 RID: 23063
			private static readonly IntPtr NativeFieldInfoPtr___9__97_0;

			// Token: 0x04005A18 RID: 23064
			private static readonly IntPtr NativeFieldInfoPtr___9__104_0;

			// Token: 0x04005A19 RID: 23065
			private static readonly IntPtr NativeFieldInfoPtr___9__104_1;

			// Token: 0x04005A1A RID: 23066
			private static readonly IntPtr NativeFieldInfoPtr___9__108_0;

			// Token: 0x04005A1B RID: 23067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A1C RID: 23068
			private static readonly IntPtr NativeMethodInfoPtr__get_CurrentPower_b__97_0_Internal_Single_Single_Single_0;

			// Token: 0x04005A1D RID: 23069
			private static readonly IntPtr NativeMethodInfoPtr__SetSpeedMultiplierBuffer_b__104_0_Internal_Single_MultiplierModifier_0;

			// Token: 0x04005A1E RID: 23070
			private static readonly IntPtr NativeMethodInfoPtr__SetSpeedMultiplierBuffer_b__104_1_Internal_Single_Single_Single_0;

			// Token: 0x04005A1F RID: 23071
			private static readonly IntPtr NativeMethodInfoPtr__PoisonDamage_b__108_0_Internal_Single_KeyValuePair_2_Int32_MultiplierModifier_0;
		}

		// Token: 0x02000572 RID: 1394
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_FlandreEnemyCharacterController+<>c__DisplayClass106_0")]
		public sealed class __c__DisplayClass106_0 : Il2CppSystem.Object
		{
			// Token: 0x0600898A RID: 35210 RVA: 0x00261350 File Offset: 0x0025F550
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass106_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<>c__DisplayClass106_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0>.NativeClassPtr);
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeFieldInfoPtr_afterCompletelyDeadCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0>.NativeClassPtr, "afterCompletelyDeadCallback");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0>.NativeClassPtr, 100665991);
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0>.NativeClassPtr, 100665992);
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeMethodInfoPtr__Initialize_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0>.NativeClassPtr, 100665993);
			}

			// Token: 0x0600898B RID: 35211 RVA: 0x002613E0 File Offset: 0x0025F5E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass106_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600898C RID: 35212 RVA: 0x0026141C File Offset: 0x0025F61C
			[CallerCount(0)]
			public unsafe void _Initialize_b__0(DLC4_FlandreEnemyCharacterController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600898D RID: 35213 RVA: 0x00261460 File Offset: 0x0025F660
			[CallerCount(0)]
			public unsafe void _Initialize_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeMethodInfoPtr__Initialize_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600898E RID: 35214 RVA: 0x00049F4F File Offset: 0x0004814F
			public __c__DisplayClass106_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E1A RID: 11802
			// (get) Token: 0x0600898F RID: 35215 RVA: 0x00261494 File Offset: 0x0025F694
			// (set) Token: 0x06008990 RID: 35216 RVA: 0x00049F58 File Offset: 0x00048158
			public unsafe Action afterCompletelyDeadCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeFieldInfoPtr_afterCompletelyDeadCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeFieldInfoPtr_afterCompletelyDeadCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E1B RID: 11803
			// (get) Token: 0x06008991 RID: 35217 RVA: 0x002614C4 File Offset: 0x0025F6C4
			// (set) Token: 0x06008992 RID: 35218 RVA: 0x00049F77 File Offset: 0x00048177
			public unsafe DLC4_FlandreEnemyCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass106_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A20 RID: 23072
			private static readonly IntPtr NativeFieldInfoPtr_afterCompletelyDeadCallback;

			// Token: 0x04005A21 RID: 23073
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A22 RID: 23074
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A23 RID: 23075
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_DLC4_FlandreEnemyCharacterController_0;

			// Token: 0x04005A24 RID: 23076
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__1_Internal_Void_0;
		}

		// Token: 0x02000573 RID: 1395
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_FlandreEnemyCharacterController+<>c__DisplayClass122_0")]
		public sealed class __c__DisplayClass122_0 : Il2CppSystem.Object
		{
			// Token: 0x06008993 RID: 35219 RVA: 0x002614F4 File Offset: 0x0025F6F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass122_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<>c__DisplayClass122_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0>.NativeClassPtr);
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0>.NativeClassPtr, "multiplier");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0>.NativeClassPtr, 100665994);
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0.NativeMethodInfoPtr__ChangePower_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0>.NativeClassPtr, 100665995);
			}

			// Token: 0x06008994 RID: 35220 RVA: 0x00261570 File Offset: 0x0025F770
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass122_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008995 RID: 35221 RVA: 0x002615AC File Offset: 0x0025F7AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47565, XrefRangeEnd = 47569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ChangePower_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0.NativeMethodInfoPtr__ChangePower_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008996 RID: 35222 RVA: 0x00049F96 File Offset: 0x00048196
			public __c__DisplayClass122_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E1C RID: 11804
			// (get) Token: 0x06008997 RID: 35223 RVA: 0x002615E0 File Offset: 0x0025F7E0
			// (set) Token: 0x06008998 RID: 35224 RVA: 0x00049F9F File Offset: 0x0004819F
			public unsafe DLC4_FlandreEnemyCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E1D RID: 11805
			// (get) Token: 0x06008999 RID: 35225 RVA: 0x00261610 File Offset: 0x0025F810
			// (set) Token: 0x0600899A RID: 35226 RVA: 0x00049FBE File Offset: 0x000481BE
			public unsafe float multiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0.NativeFieldInfoPtr_multiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass122_0.NativeFieldInfoPtr_multiplier)) = value;
				}
			}

			// Token: 0x04005A25 RID: 23077
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A26 RID: 23078
			private static readonly IntPtr NativeFieldInfoPtr_multiplier;

			// Token: 0x04005A27 RID: 23079
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A28 RID: 23080
			private static readonly IntPtr NativeMethodInfoPtr__ChangePower_b__0_Internal_Void_0;
		}

		// Token: 0x02000574 RID: 1396
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_FlandreEnemyCharacterController+<>c__DisplayClass123_0")]
		public sealed class __c__DisplayClass123_0 : Il2CppSystem.Object
		{
			// Token: 0x0600899B RID: 35227 RVA: 0x00261638 File Offset: 0x0025F838
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass123_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<>c__DisplayClass123_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0>.NativeClassPtr);
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0>.NativeClassPtr, "guid");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0>.NativeClassPtr, "coroutine");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0>.NativeClassPtr, 100665996);
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0>.NativeClassPtr, 100665997);
			}

			// Token: 0x0600899C RID: 35228 RVA: 0x002616C8 File Offset: 0x0025F8C8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass123_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600899D RID: 35229 RVA: 0x00261704 File Offset: 0x0025F904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47569, XrefRangeEnd = 47576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600899E RID: 35230 RVA: 0x00049FD9 File Offset: 0x000481D9
			public __c__DisplayClass123_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E1E RID: 11806
			// (get) Token: 0x0600899F RID: 35231 RVA: 0x00261738 File Offset: 0x0025F938
			// (set) Token: 0x060089A0 RID: 35232 RVA: 0x00049FE2 File Offset: 0x000481E2
			public unsafe DLC4_FlandreEnemyCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E1F RID: 11807
			// (get) Token: 0x060089A1 RID: 35233 RVA: 0x00261768 File Offset: 0x0025F968
			// (set) Token: 0x060089A2 RID: 35234 RVA: 0x0004A001 File Offset: 0x00048201
			public unsafe Guid guid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeFieldInfoPtr_guid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeFieldInfoPtr_guid)) = value;
				}
			}

			// Token: 0x17002E20 RID: 11808
			// (get) Token: 0x060089A3 RID: 35235 RVA: 0x00261790 File Offset: 0x0025F990
			// (set) Token: 0x060089A4 RID: 35236 RVA: 0x0004A01C File Offset: 0x0004821C
			public unsafe Coroutine coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass123_0.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A29 RID: 23081
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A2A RID: 23082
			private static readonly IntPtr NativeFieldInfoPtr_guid;

			// Token: 0x04005A2B RID: 23083
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04005A2C RID: 23084
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A2D RID: 23085
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000575 RID: 1397
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_FlandreEnemyCharacterController+<>c__DisplayClass126_0")]
		public sealed class __c__DisplayClass126_0 : Il2CppSystem.Object
		{
			// Token: 0x060089A5 RID: 35237 RVA: 0x002617C0 File Offset: 0x0025F9C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass126_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<>c__DisplayClass126_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0>.NativeClassPtr);
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0>.NativeClassPtr, "guid");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr_onBuffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0>.NativeClassPtr, "onBuffEnd");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0>.NativeClassPtr, "coroutine");
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0>.NativeClassPtr, 100665998);
				DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0>.NativeClassPtr, 100665999);
			}

			// Token: 0x060089A6 RID: 35238 RVA: 0x00261864 File Offset: 0x0025FA64
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass126_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060089A7 RID: 35239 RVA: 0x002618A0 File Offset: 0x0025FAA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47576, XrefRangeEnd = 47583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060089A8 RID: 35240 RVA: 0x0004A03B File Offset: 0x0004823B
			public __c__DisplayClass126_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E21 RID: 11809
			// (get) Token: 0x060089A9 RID: 35241 RVA: 0x002618D4 File Offset: 0x0025FAD4
			// (set) Token: 0x060089AA RID: 35242 RVA: 0x0004A044 File Offset: 0x00048244
			public unsafe DLC4_FlandreEnemyCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E22 RID: 11810
			// (get) Token: 0x060089AB RID: 35243 RVA: 0x00261904 File Offset: 0x0025FB04
			// (set) Token: 0x060089AC RID: 35244 RVA: 0x0004A063 File Offset: 0x00048263
			public unsafe Guid guid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr_guid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr_guid)) = value;
				}
			}

			// Token: 0x17002E23 RID: 11811
			// (get) Token: 0x060089AD RID: 35245 RVA: 0x0026192C File Offset: 0x0025FB2C
			// (set) Token: 0x060089AE RID: 35246 RVA: 0x0004A07E File Offset: 0x0004827E
			public unsafe Action onBuffEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr_onBuffEnd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr_onBuffEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E24 RID: 11812
			// (get) Token: 0x060089AF RID: 35247 RVA: 0x0026195C File Offset: 0x0025FB5C
			// (set) Token: 0x060089B0 RID: 35248 RVA: 0x0004A09D File Offset: 0x0004829D
			public unsafe Coroutine coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController.__c__DisplayClass126_0.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A2E RID: 23086
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A2F RID: 23087
			private static readonly IntPtr NativeFieldInfoPtr_guid;

			// Token: 0x04005A30 RID: 23088
			private static readonly IntPtr NativeFieldInfoPtr_onBuffEnd;

			// Token: 0x04005A31 RID: 23089
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04005A32 RID: 23090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A33 RID: 23091
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000576 RID: 1398
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_FlandreEnemyCharacterController+<RegisterTimedBuffInternal>d__127")]
		public sealed class _RegisterTimedBuffInternal_d__127 : Il2CppSystem.Object
		{
			// Token: 0x060089B1 RID: 35249 RVA: 0x0026198C File Offset: 0x0025FB8C
			// Note: this type is marked as 'beforefieldinit'.
			static _RegisterTimedBuffInternal_d__127()
			{
				Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<RegisterTimedBuffInternal>d__127");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr);
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, "<>1__state");
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, "<>2__current");
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, "duration");
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, "<>4__this");
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, "guid");
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, 100666000);
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, 100666001);
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, 100666002);
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, 100666003);
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, 100666004);
				DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr, 100666005);
			}

			// Token: 0x060089B2 RID: 35250 RVA: 0x00261A94 File Offset: 0x0025FC94
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RegisterTimedBuffInternal_d__127(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060089B3 RID: 35251 RVA: 0x00261ADC File Offset: 0x0025FCDC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060089B4 RID: 35252 RVA: 0x00261B10 File Offset: 0x0025FD10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47583, XrefRangeEnd = 47589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E2A RID: 11818
			// (get) Token: 0x060089B5 RID: 35253 RVA: 0x00261B4C File Offset: 0x0025FD4C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060089B6 RID: 35254 RVA: 0x00261B8C File Offset: 0x0025FD8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47589, XrefRangeEnd = 47595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E2B RID: 11819
			// (get) Token: 0x060089B7 RID: 35255 RVA: 0x00261BC0 File Offset: 0x0025FDC0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060089B8 RID: 35256 RVA: 0x0004A0BC File Offset: 0x000482BC
			public _RegisterTimedBuffInternal_d__127(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E25 RID: 11813
			// (get) Token: 0x060089B9 RID: 35257 RVA: 0x00261C00 File Offset: 0x0025FE00
			// (set) Token: 0x060089BA RID: 35258 RVA: 0x0004A0C5 File Offset: 0x000482C5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E26 RID: 11814
			// (get) Token: 0x060089BB RID: 35259 RVA: 0x00261C28 File Offset: 0x0025FE28
			// (set) Token: 0x060089BC RID: 35260 RVA: 0x0004A0E0 File Offset: 0x000482E0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E27 RID: 11815
			// (get) Token: 0x060089BD RID: 35261 RVA: 0x00261C58 File Offset: 0x0025FE58
			// (set) Token: 0x060089BE RID: 35262 RVA: 0x0004A0FF File Offset: 0x000482FF
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17002E28 RID: 11816
			// (get) Token: 0x060089BF RID: 35263 RVA: 0x00261C80 File Offset: 0x0025FE80
			// (set) Token: 0x060089C0 RID: 35264 RVA: 0x0004A11A File Offset: 0x0004831A
			public unsafe DLC4_FlandreEnemyCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E29 RID: 11817
			// (get) Token: 0x060089C1 RID: 35265 RVA: 0x00261CB0 File Offset: 0x0025FEB0
			// (set) Token: 0x060089C2 RID: 35266 RVA: 0x0004A139 File Offset: 0x00048339
			public unsafe Guid guid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr_guid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterTimedBuffInternal_d__127.NativeFieldInfoPtr_guid)) = value;
				}
			}

			// Token: 0x04005A34 RID: 23092
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005A35 RID: 23093
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005A36 RID: 23094
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04005A37 RID: 23095
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A38 RID: 23096
			private static readonly IntPtr NativeFieldInfoPtr_guid;

			// Token: 0x04005A39 RID: 23097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005A3A RID: 23098
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A3B RID: 23099
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005A3C RID: 23100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005A3D RID: 23101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A3E RID: 23102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000577 RID: 1399
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_FlandreEnemyCharacterController+<RegisterCoroutineInternal>d__128")]
		public sealed class _RegisterCoroutineInternal_d__128 : Il2CppSystem.Object
		{
			// Token: 0x060089C3 RID: 35267 RVA: 0x00261CD8 File Offset: 0x0025FED8
			// Note: this type is marked as 'beforefieldinit'.
			static _RegisterCoroutineInternal_d__128()
			{
				Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController>.NativeClassPtr, "<RegisterCoroutineInternal>d__128");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr);
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, "<>1__state");
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, "<>2__current");
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, "coroutine");
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, "<>4__this");
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, "guid");
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, 100666006);
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, 100666007);
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, 100666008);
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, 100666009);
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, 100666010);
				DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr, 100666011);
			}

			// Token: 0x060089C4 RID: 35268 RVA: 0x00261DE0 File Offset: 0x0025FFE0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RegisterCoroutineInternal_d__128(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060089C5 RID: 35269 RVA: 0x00261E28 File Offset: 0x00260028
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060089C6 RID: 35270 RVA: 0x00261E5C File Offset: 0x0026005C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47595, XrefRangeEnd = 47597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E31 RID: 11825
			// (get) Token: 0x060089C7 RID: 35271 RVA: 0x00261E98 File Offset: 0x00260098
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060089C8 RID: 35272 RVA: 0x00261ED8 File Offset: 0x002600D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47597, XrefRangeEnd = 47603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E32 RID: 11826
			// (get) Token: 0x060089C9 RID: 35273 RVA: 0x00261F0C File Offset: 0x0026010C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060089CA RID: 35274 RVA: 0x0004A154 File Offset: 0x00048354
			public _RegisterCoroutineInternal_d__128(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E2C RID: 11820
			// (get) Token: 0x060089CB RID: 35275 RVA: 0x00261F4C File Offset: 0x0026014C
			// (set) Token: 0x060089CC RID: 35276 RVA: 0x0004A15D File Offset: 0x0004835D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E2D RID: 11821
			// (get) Token: 0x060089CD RID: 35277 RVA: 0x00261F74 File Offset: 0x00260174
			// (set) Token: 0x060089CE RID: 35278 RVA: 0x0004A178 File Offset: 0x00048378
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E2E RID: 11822
			// (get) Token: 0x060089CF RID: 35279 RVA: 0x00261FA4 File Offset: 0x002601A4
			// (set) Token: 0x060089D0 RID: 35280 RVA: 0x0004A197 File Offset: 0x00048397
			public unsafe Coroutine coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E2F RID: 11823
			// (get) Token: 0x060089D1 RID: 35281 RVA: 0x00261FD4 File Offset: 0x002601D4
			// (set) Token: 0x060089D2 RID: 35282 RVA: 0x0004A1B6 File Offset: 0x000483B6
			public unsafe DLC4_FlandreEnemyCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E30 RID: 11824
			// (get) Token: 0x060089D3 RID: 35283 RVA: 0x00262004 File Offset: 0x00260204
			// (set) Token: 0x060089D4 RID: 35284 RVA: 0x0004A1D5 File Offset: 0x000483D5
			public unsafe Guid guid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr_guid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyCharacterController._RegisterCoroutineInternal_d__128.NativeFieldInfoPtr_guid)) = value;
				}
			}

			// Token: 0x04005A3F RID: 23103
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005A40 RID: 23104
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005A41 RID: 23105
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04005A42 RID: 23106
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A43 RID: 23107
			private static readonly IntPtr NativeFieldInfoPtr_guid;

			// Token: 0x04005A44 RID: 23108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005A45 RID: 23109
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A46 RID: 23110
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005A47 RID: 23111
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005A48 RID: 23112
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A49 RID: 23113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
