using System;
using Common.Audio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000A1 RID: 161
	public class DLC4_GuardKagerou : DLC4_GuardController
	{
		// Token: 0x060010A7 RID: 4263 RVA: 0x000D6E5C File Offset: 0x000D505C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_GuardKagerou()
		{
			Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_GuardKagerou");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr);
			DLC4_GuardKagerou.NativeFieldInfoPtr_MEAT_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "MEAT_TAG");
			DLC4_GuardKagerou.NativeFieldInfoPtr_PRD_KAGEROU_REPULSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "PRD_KAGEROU_REPULSE");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_Damage");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_RepulseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_RepulseRate");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_RepulseDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_RepulseDistance");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_PowerUpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_PowerUpDuration");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_PowerUpAttackMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_PowerUpAttackMultiplier");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_UltimateSkillBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_UltimateSkillBullet");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_UltimateSkillBulletExplodeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_UltimateSkillBulletExplodeRange");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_UltimateSkillBulletLaunchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_UltimateSkillBulletLaunchHeight");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfClaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_WolfClaw");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfClawPowerUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_WolfClawPowerUp");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfDance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_WolfDance");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_BeastarVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_BeastarVFX");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_BeastarBuffUIDisplayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_BeastarBuffUIDisplayOffset");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfClawSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_WolfClawSfx");
			DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfDanceSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "m_WolfDanceSfx");
			DLC4_GuardKagerou.NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666232);
			DLC4_GuardKagerou.NativeMethodInfoPtr_Eat_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666233);
			DLC4_GuardKagerou.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666234);
			DLC4_GuardKagerou.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666235);
			DLC4_GuardKagerou.NativeMethodInfoPtr_TargetEnemyPosition_Private_Vector2_Vector2_Single_byref_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666236);
			DLC4_GuardKagerou.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666237);
			DLC4_GuardKagerou.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666238);
			DLC4_GuardKagerou.NativeMethodInfoPtr__Eat_b__18_0_Private_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666239);
			DLC4_GuardKagerou.NativeMethodInfoPtr__Eat_b__18_1_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666240);
			DLC4_GuardKagerou.NativeMethodInfoPtr__NormalAttack_b__19_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666241);
			DLC4_GuardKagerou.NativeMethodInfoPtr__SkillAttack_b__20_0_Private_Void_DLC4_BulletKagerouWolfSpirit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666242);
			DLC4_GuardKagerou.NativeMethodInfoPtr__TargetEnemyPosition_b__21_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, 100666243);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x000D70D0 File Offset: 0x000D52D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49548, XrefRangeEnd = 49559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuardControllerEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardKagerou.NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000D710C File Offset: 0x000D530C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49559, XrefRangeEnd = 49587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestGroupController.EvaluationResult Eat(GuestGroupController.EvaluationResult result, GuestGroupController thisGuest, bool oldComboProtect, out string message, out bool comboProtect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.NativeMethodInfoPtr_Eat_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000D71A0 File Offset: 0x000D53A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49587, XrefRangeEnd = 49667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NormalAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardKagerou.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000D71DC File Offset: 0x000D53DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49667, XrefRangeEnd = 49672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator SkillAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardKagerou.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000D7228 File Offset: 0x000D5428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49717, RefRangeEnd = 49718, XrefRangeStart = 49672, XrefRangeEnd = 49717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 TargetEnemyPosition(Vector2 targetEnemyPosition, float bulletSpeed, out DLC4_FlandreEnemyCharacterController targetEnemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetEnemyPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bulletSpeed;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.NativeMethodInfoPtr_TargetEnemyPosition_Private_Vector2_Vector2_Single_byref_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			targetEnemy = ((intPtr4 == 0) ? null : new DLC4_FlandreEnemyCharacterController(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000D72A4 File Offset: 0x000D54A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49718, XrefRangeEnd = 49719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardKagerou.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x000D72E0 File Offset: 0x000D54E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_GuardKagerou() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x000D731C File Offset: 0x000D551C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49719, XrefRangeEnd = 49731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject _Eat_b__18_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.NativeMethodInfoPtr__Eat_b__18_0_Private_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x000D735C File Offset: 0x000D555C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49731, XrefRangeEnd = 49742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Eat_b__18_1(GameObject beastStar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beastStar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.NativeMethodInfoPtr__Eat_b__18_1_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x000D73A0 File Offset: 0x000D55A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _NormalAttack_b__19_0(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.NativeMethodInfoPtr__NormalAttack_b__19_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x000D73F0 File Offset: 0x000D55F0
		[CallerCount(0)]
		public unsafe void _SkillAttack_b__20_0(DLC4_BulletKagerouWolfSpirit x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.NativeMethodInfoPtr__SkillAttack_b__20_0_Private_Void_DLC4_BulletKagerouWolfSpirit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x000D7434 File Offset: 0x000D5634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49742, XrefRangeEnd = 49746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _TargetEnemyPosition_b__21_0(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.NativeMethodInfoPtr__TargetEnemyPosition_b__21_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0000A8EB File Offset: 0x00008AEB
		public DLC4_GuardKagerou(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x000D7484 File Offset: 0x000D5684
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		public unsafe static int MEAT_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_GuardKagerou.NativeFieldInfoPtr_MEAT_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_GuardKagerou.NativeFieldInfoPtr_MEAT_TAG, (void*)(&value));
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x000D74A0 File Offset: 0x000D56A0
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x0000A902 File Offset: 0x00008B02
		public unsafe static string PRD_KAGEROU_REPULSE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_GuardKagerou.NativeFieldInfoPtr_PRD_KAGEROU_REPULSE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_GuardKagerou.NativeFieldInfoPtr_PRD_KAGEROU_REPULSE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x000D74C0 File Offset: 0x000D56C0
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x0000A914 File Offset: 0x00008B14
		public unsafe int m_Damage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_Damage)) = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x000D74E8 File Offset: 0x000D56E8
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0000A92F File Offset: 0x00008B2F
		public unsafe float m_RepulseRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_RepulseRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_RepulseRate)) = value;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x000D7510 File Offset: 0x000D5710
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x0000A94A File Offset: 0x00008B4A
		public unsafe float m_RepulseDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_RepulseDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_RepulseDistance)) = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x000D7538 File Offset: 0x000D5738
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x0000A965 File Offset: 0x00008B65
		public unsafe int m_PowerUpDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_PowerUpDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_PowerUpDuration)) = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x000D7560 File Offset: 0x000D5760
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x0000A980 File Offset: 0x00008B80
		public unsafe float m_PowerUpAttackMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_PowerUpAttackMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_PowerUpAttackMultiplier)) = value;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x000D7588 File Offset: 0x000D5788
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x0000A99B File Offset: 0x00008B9B
		public DLC4_GuardController.TeamBulletProperty m_UltimateSkillBullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_UltimateSkillBullet);
				return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_UltimateSkillBullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x000D75B8 File Offset: 0x000D57B8
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x0000A9C9 File Offset: 0x00008BC9
		public unsafe float m_UltimateSkillBulletExplodeRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_UltimateSkillBulletExplodeRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_UltimateSkillBulletExplodeRange)) = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x000D75E0 File Offset: 0x000D57E0
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x0000A9E4 File Offset: 0x00008BE4
		public unsafe float m_UltimateSkillBulletLaunchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_UltimateSkillBulletLaunchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_UltimateSkillBulletLaunchHeight)) = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x000D7608 File Offset: 0x000D5808
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x0000A9FF File Offset: 0x00008BFF
		public VFXPrefab m_WolfClaw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfClaw);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfClaw), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x000D7638 File Offset: 0x000D5838
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x0000AA2D File Offset: 0x00008C2D
		public VFXPrefab m_WolfClawPowerUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfClawPowerUp);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfClawPowerUp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x000D7668 File Offset: 0x000D5868
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0000AA5B File Offset: 0x00008C5B
		public VFXPrefab m_WolfDance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfDance);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfDance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x000D7698 File Offset: 0x000D5898
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x0000AA89 File Offset: 0x00008C89
		public VFXPrefab m_BeastarVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_BeastarVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_BeastarVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x000D76C8 File Offset: 0x000D58C8
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x0000AAB7 File Offset: 0x00008CB7
		public unsafe Vector2 m_BeastarBuffUIDisplayOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_BeastarBuffUIDisplayOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_BeastarBuffUIDisplayOffset)) = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x000D76F0 File Offset: 0x000D58F0
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x0000AAD2 File Offset: 0x00008CD2
		public GlobalAudioManager.DelayAudioClip m_WolfClawSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfClawSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfClawSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x000D7720 File Offset: 0x000D5920
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x0000AB00 File Offset: 0x00008D00
		public GlobalAudioManager.DelayAudioClip m_WolfDanceSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfDanceSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.NativeFieldInfoPtr_m_WolfDanceSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeFieldInfoPtr_MEAT_TAG;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeFieldInfoPtr_PRD_KAGEROU_REPULSE;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeFieldInfoPtr_m_Damage;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeFieldInfoPtr_m_RepulseRate;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeFieldInfoPtr_m_RepulseDistance;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeFieldInfoPtr_m_PowerUpDuration;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeFieldInfoPtr_m_PowerUpAttackMultiplier;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeFieldInfoPtr_m_UltimateSkillBullet;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeFieldInfoPtr_m_UltimateSkillBulletExplodeRange;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeFieldInfoPtr_m_UltimateSkillBulletLaunchHeight;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeFieldInfoPtr_m_WolfClaw;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeFieldInfoPtr_m_WolfClawPowerUp;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeFieldInfoPtr_m_WolfDance;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeFieldInfoPtr_m_BeastarVFX;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeFieldInfoPtr_m_BeastarBuffUIDisplayOffset;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr_m_WolfClawSfx;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeFieldInfoPtr_m_WolfDanceSfx;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_Eat_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_TargetEnemyPosition_Private_Vector2_Vector2_Single_byref_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr__Eat_b__18_0_Private_GameObject_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr__Eat_b__18_1_Private_Void_GameObject_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr__NormalAttack_b__19_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr__SkillAttack_b__20_0_Private_Void_DLC4_BulletKagerouWolfSpirit_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr__TargetEnemyPosition_b__21_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x02000594 RID: 1428
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardKagerou+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x06008AD1 RID: 35537 RVA: 0x00264EA8 File Offset: 0x002630A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<DLC4_GuardKagerou.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardKagerou.__c__DisplayClass19_0>.NativeClassPtr);
				DLC4_GuardKagerou.__c__DisplayClass19_0.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou.__c__DisplayClass19_0>.NativeClassPtr, "targetPosition");
				DLC4_GuardKagerou.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou.__c__DisplayClass19_0>.NativeClassPtr, 100666244);
				DLC4_GuardKagerou.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou.__c__DisplayClass19_0>.NativeClassPtr, 100666245);
			}

			// Token: 0x06008AD2 RID: 35538 RVA: 0x00264F10 File Offset: 0x00263110
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardKagerou.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008AD3 RID: 35539 RVA: 0x00264F4C File Offset: 0x0026314C
			[CallerCount(0)]
			public unsafe Vector3 Method_Internal_Vector3_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008AD4 RID: 35540 RVA: 0x0004A976 File Offset: 0x00048B76
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E7F RID: 11903
			// (get) Token: 0x06008AD5 RID: 35541 RVA: 0x00264F88 File Offset: 0x00263188
			// (set) Token: 0x06008AD6 RID: 35542 RVA: 0x0004A97F File Offset: 0x00048B7F
			public unsafe Vector3 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.__c__DisplayClass19_0.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou.__c__DisplayClass19_0.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x04005AEC RID: 23276
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04005AED RID: 23277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005AEE RID: 23278
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Vector3_0;
		}

		// Token: 0x02000595 RID: 1429
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardKagerou+<SkillAttack>d__20")]
		public sealed class _SkillAttack_d__20 : Il2CppSystem.Object
		{
			// Token: 0x06008AD7 RID: 35543 RVA: 0x00264FB0 File Offset: 0x002631B0
			// Note: this type is marked as 'beforefieldinit'.
			static _SkillAttack_d__20()
			{
				Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "<SkillAttack>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr);
				DLC4_GuardKagerou._SkillAttack_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr, "<>1__state");
				DLC4_GuardKagerou._SkillAttack_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr, "<>2__current");
				DLC4_GuardKagerou._SkillAttack_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr, "<>4__this");
				DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr, 100666246);
				DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr, 100666247);
				DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr, 100666248);
				DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr, 100666249);
				DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr, 100666250);
				DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr, 100666251);
			}

			// Token: 0x06008AD8 RID: 35544 RVA: 0x00265090 File Offset: 0x00263290
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SkillAttack_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardKagerou._SkillAttack_d__20>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008AD9 RID: 35545 RVA: 0x002650D8 File Offset: 0x002632D8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008ADA RID: 35546 RVA: 0x0026510C File Offset: 0x0026330C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49516, XrefRangeEnd = 49542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E83 RID: 11907
			// (get) Token: 0x06008ADB RID: 35547 RVA: 0x00265148 File Offset: 0x00263348
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008ADC RID: 35548 RVA: 0x00265188 File Offset: 0x00263388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49542, XrefRangeEnd = 49548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E84 RID: 11908
			// (get) Token: 0x06008ADD RID: 35549 RVA: 0x002651BC File Offset: 0x002633BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou._SkillAttack_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008ADE RID: 35550 RVA: 0x0004A99A File Offset: 0x00048B9A
			public _SkillAttack_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E80 RID: 11904
			// (get) Token: 0x06008ADF RID: 35551 RVA: 0x002651FC File Offset: 0x002633FC
			// (set) Token: 0x06008AE0 RID: 35552 RVA: 0x0004A9A3 File Offset: 0x00048BA3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou._SkillAttack_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou._SkillAttack_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E81 RID: 11905
			// (get) Token: 0x06008AE1 RID: 35553 RVA: 0x00265224 File Offset: 0x00263424
			// (set) Token: 0x06008AE2 RID: 35554 RVA: 0x0004A9BE File Offset: 0x00048BBE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou._SkillAttack_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou._SkillAttack_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E82 RID: 11906
			// (get) Token: 0x06008AE3 RID: 35555 RVA: 0x00265254 File Offset: 0x00263454
			// (set) Token: 0x06008AE4 RID: 35556 RVA: 0x0004A9DD File Offset: 0x00048BDD
			public unsafe DLC4_GuardKagerou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou._SkillAttack_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardKagerou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardKagerou._SkillAttack_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005AEF RID: 23279
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005AF0 RID: 23280
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005AF1 RID: 23281
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005AF2 RID: 23282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005AF3 RID: 23283
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005AF4 RID: 23284
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005AF5 RID: 23285
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005AF6 RID: 23286
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005AF7 RID: 23287
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000596 RID: 1430
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardKagerou+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008AE5 RID: 35557 RVA: 0x00265284 File Offset: 0x00263484
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_GuardKagerou.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardKagerou>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardKagerou.__c>.NativeClassPtr);
				DLC4_GuardKagerou.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou.__c>.NativeClassPtr, "<>9");
				DLC4_GuardKagerou.__c.NativeFieldInfoPtr___9__21_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardKagerou.__c>.NativeClassPtr, "<>9__21_1");
				DLC4_GuardKagerou.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou.__c>.NativeClassPtr, 100666253);
				DLC4_GuardKagerou.__c.NativeMethodInfoPtr__TargetEnemyPosition_b__21_1_Internal_Single_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardKagerou.__c>.NativeClassPtr, 100666254);
			}

			// Token: 0x06008AE6 RID: 35558 RVA: 0x00265300 File Offset: 0x00263500
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardKagerou.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008AE7 RID: 35559 RVA: 0x0026533C File Offset: 0x0026353C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _TargetEnemyPosition_b__21_1(DLC4_FlandreEnemyCharacterController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardKagerou.__c.NativeMethodInfoPtr__TargetEnemyPosition_b__21_1_Internal_Single_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008AE8 RID: 35560 RVA: 0x0004A9FC File Offset: 0x00048BFC
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E85 RID: 11909
			// (get) Token: 0x06008AE9 RID: 35561 RVA: 0x0026538C File Offset: 0x0026358C
			// (set) Token: 0x06008AEA RID: 35562 RVA: 0x0004AA05 File Offset: 0x00048C05
			public unsafe static DLC4_GuardKagerou.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardKagerou.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardKagerou.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardKagerou.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E86 RID: 11910
			// (get) Token: 0x06008AEB RID: 35563 RVA: 0x002653B4 File Offset: 0x002635B4
			// (set) Token: 0x06008AEC RID: 35564 RVA: 0x0004AA17 File Offset: 0x00048C17
			public unsafe static Func<DLC4_FlandreEnemyCharacterController, float> __9__21_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardKagerou.__c.NativeFieldInfoPtr___9__21_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC4_FlandreEnemyCharacterController, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardKagerou.__c.NativeFieldInfoPtr___9__21_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005AF8 RID: 23288
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005AF9 RID: 23289
			private static readonly IntPtr NativeFieldInfoPtr___9__21_1;

			// Token: 0x04005AFA RID: 23290
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005AFB RID: 23291
			private static readonly IntPtr NativeMethodInfoPtr__TargetEnemyPosition_b__21_1_Internal_Single_DLC4_FlandreEnemyCharacterController_0;
		}
	}
}
