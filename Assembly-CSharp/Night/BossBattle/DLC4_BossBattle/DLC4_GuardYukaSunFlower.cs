using System;
using Common.Audio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000A7 RID: 167
	public class DLC4_GuardYukaSunFlower : DLC4_GuardController
	{
		// Token: 0x060011BB RID: 4539 RVA: 0x000DA0A4 File Offset: 0x000D82A4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_GuardYukaSunFlower()
		{
			Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_GuardYukaSunFlower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr);
			DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_sunflowerAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "sunflowerAnimator");
			DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_m_SunflowerSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "m_SunflowerSpawn");
			DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_m_SunflowerSunSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "m_SunflowerSunSpawn");
			DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_m_SunflowerPPointSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "m_SunflowerPPointSpawn");
			DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_AttackDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "AttackDirection");
			DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_hasSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "hasSpawned");
			DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_spawnCorotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "spawnCorotine");
			DLC4_GuardYukaSunFlower.NativeFieldInfoPtr__YukaParent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "<YukaParent>k__BackingField");
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_get_YukaParent_Private_get_DLC4_GuardYuka_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666388);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_set_YukaParent_Public_set_Void_DLC4_GuardYuka_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666389);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_get_BigBullet_Private_get_TeamBulletProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666390);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_get_SmallBullet_Private_get_TeamBulletProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666391);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_get_SpawnPoint_Protected_Virtual_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666392);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666393);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_SpawnP_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666394);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666395);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666396);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_SmallBulletAttack_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666397);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_Disappear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666398);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666399);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666400);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666401);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr__OnGuardControllerEnable_b__17_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666402);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr__SpawnP_b__18_0_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666403);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr__CouldAttack_b__19_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666404);
			DLC4_GuardYukaSunFlower.NativeMethodInfoPtr__CouldAttack_b__19_1_Private_Single_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, 100666405);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x000DA2DC File Offset: 0x000D84DC
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x000DA31C File Offset: 0x000D851C
		public unsafe DLC4_GuardYuka YukaParent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_get_YukaParent_Private_get_DLC4_GuardYuka_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC4_GuardYuka>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_set_YukaParent_Public_set_Void_DLC4_GuardYuka_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x000DA360 File Offset: 0x000D8560
		public unsafe DLC4_GuardController.TeamBulletProperty BigBullet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_get_BigBullet_Private_get_TeamBulletProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC4_GuardController.TeamBulletProperty(pointer);
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x000DA398 File Offset: 0x000D8598
		public unsafe DLC4_GuardController.TeamBulletProperty SmallBullet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_get_SmallBullet_Private_get_TeamBulletProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC4_GuardController.TeamBulletProperty(pointer);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x000DA3D0 File Offset: 0x000D85D0
		public unsafe override Vector2 SpawnPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50614, XrefRangeEnd = 50616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_get_SpawnPoint_Protected_Virtual_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000DA418 File Offset: 0x000D8618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50616, XrefRangeEnd = 50625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuardControllerEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x000DA454 File Offset: 0x000D8654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50625, XrefRangeEnd = 50630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SpawnP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_SpawnP_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x000DA494 File Offset: 0x000D8694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50630, XrefRangeEnd = 50656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CouldAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000DA4DC File Offset: 0x000D86DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50656, XrefRangeEnd = 50685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NormalAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x000DA518 File Offset: 0x000D8718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50685, XrefRangeEnd = 50713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SmallBulletAttack(Vector2 parentPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref parentPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_SmallBulletAttack_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x000DA558 File Offset: 0x000D8758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50713, XrefRangeEnd = 50725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disappear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_Disappear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000DA58C File Offset: 0x000D878C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50725, XrefRangeEnd = 50729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator SkillAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x000DA5D8 File Offset: 0x000D87D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50729, XrefRangeEnd = 50734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYukaSunFlower.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x000DA614 File Offset: 0x000D8814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50734, XrefRangeEnd = 50753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_GuardYukaSunFlower() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000DA650 File Offset: 0x000D8850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50753, XrefRangeEnd = 50761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuardControllerEnable_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr__OnGuardControllerEnable_b__17_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000DA684 File Offset: 0x000D8884
		[CallerCount(0)]
		public unsafe Vector3 _SpawnP_b__18_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr__SpawnP_b__18_0_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x000DA6C0 File Offset: 0x000D88C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50761, XrefRangeEnd = 50763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CouldAttack_b__19_0(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr__CouldAttack_b__19_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x000DA710 File Offset: 0x000D8910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50763, XrefRangeEnd = 50764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _CouldAttack_b__19_1(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.NativeMethodInfoPtr__CouldAttack_b__19_1_Private_Single_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0000B557 File Offset: 0x00009757
		public DLC4_GuardYukaSunFlower(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x000DA760 File Offset: 0x000D8960
		// (set) Token: 0x060011D0 RID: 4560 RVA: 0x0000B560 File Offset: 0x00009760
		public unsafe Animator sunflowerAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_sunflowerAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_sunflowerAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x000DA790 File Offset: 0x000D8990
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x0000B57F File Offset: 0x0000977F
		public unsafe AudioClip m_SunflowerSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_m_SunflowerSpawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_m_SunflowerSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000DA7C0 File Offset: 0x000D89C0
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x0000B59E File Offset: 0x0000979E
		public GlobalAudioManager.DelayAudioClip m_SunflowerSunSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_m_SunflowerSunSpawn);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_m_SunflowerSunSpawn), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000DA7F0 File Offset: 0x000D89F0
		// (set) Token: 0x060011D6 RID: 4566 RVA: 0x0000B5CC File Offset: 0x000097CC
		public GlobalAudioManager.DelayAudioClip m_SunflowerPPointSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_m_SunflowerPPointSpawn);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_m_SunflowerPPointSpawn), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x000DA820 File Offset: 0x000D8A20
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x0000B5FA File Offset: 0x000097FA
		public unsafe Il2CppStructArray<Vector2> AttackDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_AttackDirection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_AttackDirection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x000DA850 File Offset: 0x000D8A50
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x0000B619 File Offset: 0x00009819
		public unsafe bool hasSpawned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_hasSpawned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_hasSpawned)) = value;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x000DA878 File Offset: 0x000D8A78
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x0000B634 File Offset: 0x00009834
		public unsafe Coroutine spawnCorotine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_spawnCorotine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr_spawnCorotine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x000DA8A8 File Offset: 0x000D8AA8
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x0000B653 File Offset: 0x00009853
		public unsafe DLC4_GuardYuka _YukaParent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr__YukaParent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardYuka>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.NativeFieldInfoPtr__YukaParent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeFieldInfoPtr_sunflowerAnimator;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeFieldInfoPtr_m_SunflowerSpawn;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeFieldInfoPtr_m_SunflowerSunSpawn;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr_m_SunflowerPPointSpawn;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr_AttackDirection;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr_hasSpawned;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeFieldInfoPtr_spawnCorotine;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr__YukaParent_k__BackingField;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_get_YukaParent_Private_get_DLC4_GuardYuka_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_set_YukaParent_Public_set_Void_DLC4_GuardYuka_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_get_BigBullet_Private_get_TeamBulletProperty_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_get_SmallBullet_Private_get_TeamBulletProperty_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_get_SpawnPoint_Protected_Virtual_get_Vector2_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_OnGuardControllerEnable_Protected_Virtual_Void_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_SpawnP_Private_IEnumerator_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_SmallBulletAttack_Private_Void_Vector2_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_Disappear_Public_Void_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr__OnGuardControllerEnable_b__17_0_Private_Void_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr__SpawnP_b__18_0_Private_Vector3_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr__CouldAttack_b__19_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr__CouldAttack_b__19_1_Private_Single_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x020005AD RID: 1453
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardYukaSunFlower+<SpawnP>d__18")]
		public sealed class _SpawnP_d__18 : Il2CppSystem.Object
		{
			// Token: 0x06008BCB RID: 35787 RVA: 0x00267AD0 File Offset: 0x00265CD0
			// Note: this type is marked as 'beforefieldinit'.
			static _SpawnP_d__18()
			{
				Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "<SpawnP>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr);
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, "<>1__state");
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, "<>2__current");
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, "<>4__this");
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__wait1_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, "<wait1>5__2");
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__wait2_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, "<wait2>5__3");
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__wait3_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, "<wait3>5__4");
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__sun_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, "<sun>5__5");
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, 100666406);
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, 100666407);
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, 100666408);
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, 100666409);
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, 100666410);
				DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr, 100666411);
			}

			// Token: 0x06008BCC RID: 35788 RVA: 0x00267C00 File Offset: 0x00265E00
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SpawnP_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SpawnP_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BCD RID: 35789 RVA: 0x00267C48 File Offset: 0x00265E48
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BCE RID: 35790 RVA: 0x00267C7C File Offset: 0x00265E7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50531, XrefRangeEnd = 50577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002ED5 RID: 11989
			// (get) Token: 0x06008BCF RID: 35791 RVA: 0x00267CB8 File Offset: 0x00265EB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008BD0 RID: 35792 RVA: 0x00267CF8 File Offset: 0x00265EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50577, XrefRangeEnd = 50583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002ED6 RID: 11990
			// (get) Token: 0x06008BD1 RID: 35793 RVA: 0x00267D2C File Offset: 0x00265F2C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008BD2 RID: 35794 RVA: 0x0004B1D4 File Offset: 0x000493D4
			public _SpawnP_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002ECE RID: 11982
			// (get) Token: 0x06008BD3 RID: 35795 RVA: 0x00267D6C File Offset: 0x00265F6C
			// (set) Token: 0x06008BD4 RID: 35796 RVA: 0x0004B1DD File Offset: 0x000493DD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002ECF RID: 11983
			// (get) Token: 0x06008BD5 RID: 35797 RVA: 0x00267D94 File Offset: 0x00265F94
			// (set) Token: 0x06008BD6 RID: 35798 RVA: 0x0004B1F8 File Offset: 0x000493F8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ED0 RID: 11984
			// (get) Token: 0x06008BD7 RID: 35799 RVA: 0x00267DC4 File Offset: 0x00265FC4
			// (set) Token: 0x06008BD8 RID: 35800 RVA: 0x0004B217 File Offset: 0x00049417
			public unsafe DLC4_GuardYukaSunFlower __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardYukaSunFlower>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ED1 RID: 11985
			// (get) Token: 0x06008BD9 RID: 35801 RVA: 0x00267DF4 File Offset: 0x00265FF4
			// (set) Token: 0x06008BDA RID: 35802 RVA: 0x0004B236 File Offset: 0x00049436
			public unsafe WaitForSeconds _wait1_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__wait1_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__wait1_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ED2 RID: 11986
			// (get) Token: 0x06008BDB RID: 35803 RVA: 0x00267E24 File Offset: 0x00266024
			// (set) Token: 0x06008BDC RID: 35804 RVA: 0x0004B255 File Offset: 0x00049455
			public unsafe WaitForSeconds _wait2_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__wait2_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__wait2_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ED3 RID: 11987
			// (get) Token: 0x06008BDD RID: 35805 RVA: 0x00267E54 File Offset: 0x00266054
			// (set) Token: 0x06008BDE RID: 35806 RVA: 0x0004B274 File Offset: 0x00049474
			public unsafe WaitForSeconds _wait3_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__wait3_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__wait3_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ED4 RID: 11988
			// (get) Token: 0x06008BDF RID: 35807 RVA: 0x00267E84 File Offset: 0x00266084
			// (set) Token: 0x06008BE0 RID: 35808 RVA: 0x0004B293 File Offset: 0x00049493
			public unsafe GameObject _sun_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__sun_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SpawnP_d__18.NativeFieldInfoPtr__sun_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B88 RID: 23432
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005B89 RID: 23433
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005B8A RID: 23434
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B8B RID: 23435
			private static readonly IntPtr NativeFieldInfoPtr__wait1_5__2;

			// Token: 0x04005B8C RID: 23436
			private static readonly IntPtr NativeFieldInfoPtr__wait2_5__3;

			// Token: 0x04005B8D RID: 23437
			private static readonly IntPtr NativeFieldInfoPtr__wait3_5__4;

			// Token: 0x04005B8E RID: 23438
			private static readonly IntPtr NativeFieldInfoPtr__sun_5__5;

			// Token: 0x04005B8F RID: 23439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005B90 RID: 23440
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B91 RID: 23441
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005B92 RID: 23442
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005B93 RID: 23443
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B94 RID: 23444
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020005AE RID: 1454
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardYukaSunFlower+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x06008BE1 RID: 35809 RVA: 0x00267EB4 File Offset: 0x002660B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass20_0>.NativeClassPtr);
				DLC4_GuardYukaSunFlower.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				DLC4_GuardYukaSunFlower.__c__DisplayClass20_0.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass20_0>.NativeClassPtr, "direction");
				DLC4_GuardYukaSunFlower.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass20_0>.NativeClassPtr, 100666412);
				DLC4_GuardYukaSunFlower.__c__DisplayClass20_0.NativeMethodInfoPtr__NormalAttack_b__0_Internal_Void_DLC4_SunFlowerGiantBullet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass20_0>.NativeClassPtr, 100666413);
			}

			// Token: 0x06008BE2 RID: 35810 RVA: 0x00267F30 File Offset: 0x00266130
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BE3 RID: 35811 RVA: 0x00267F6C File Offset: 0x0026616C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50583, XrefRangeEnd = 50602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NormalAttack_b__0(DLC4_SunFlowerGiantBullet x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.__c__DisplayClass20_0.NativeMethodInfoPtr__NormalAttack_b__0_Internal_Void_DLC4_SunFlowerGiantBullet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BE4 RID: 35812 RVA: 0x0004B2B2 File Offset: 0x000494B2
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002ED7 RID: 11991
			// (get) Token: 0x06008BE5 RID: 35813 RVA: 0x00267FB0 File Offset: 0x002661B0
			// (set) Token: 0x06008BE6 RID: 35814 RVA: 0x0004B2BB File Offset: 0x000494BB
			public unsafe DLC4_GuardYukaSunFlower __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardYukaSunFlower>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ED8 RID: 11992
			// (get) Token: 0x06008BE7 RID: 35815 RVA: 0x00267FE0 File Offset: 0x002661E0
			// (set) Token: 0x06008BE8 RID: 35816 RVA: 0x0004B2DA File Offset: 0x000494DA
			public unsafe Vector2 direction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass20_0.NativeFieldInfoPtr_direction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass20_0.NativeFieldInfoPtr_direction)) = value;
				}
			}

			// Token: 0x04005B95 RID: 23445
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B96 RID: 23446
			private static readonly IntPtr NativeFieldInfoPtr_direction;

			// Token: 0x04005B97 RID: 23447
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B98 RID: 23448
			private static readonly IntPtr NativeMethodInfoPtr__NormalAttack_b__0_Internal_Void_DLC4_SunFlowerGiantBullet_0;
		}

		// Token: 0x020005AF RID: 1455
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardYukaSunFlower+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x06008BE9 RID: 35817 RVA: 0x00268008 File Offset: 0x00266208
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_0>.NativeClassPtr);
				DLC4_GuardYukaSunFlower.__c__DisplayClass21_0.NativeFieldInfoPtr_parentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_0>.NativeClassPtr, "parentPosition");
				DLC4_GuardYukaSunFlower.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				DLC4_GuardYukaSunFlower.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_0>.NativeClassPtr, 100666414);
			}

			// Token: 0x06008BEA RID: 35818 RVA: 0x00268070 File Offset: 0x00266270
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BEB RID: 35819 RVA: 0x0004B2F5 File Offset: 0x000494F5
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002ED9 RID: 11993
			// (get) Token: 0x06008BEC RID: 35820 RVA: 0x002680AC File Offset: 0x002662AC
			// (set) Token: 0x06008BED RID: 35821 RVA: 0x0004B2FE File Offset: 0x000494FE
			public unsafe Vector2 parentPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass21_0.NativeFieldInfoPtr_parentPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass21_0.NativeFieldInfoPtr_parentPosition)) = value;
				}
			}

			// Token: 0x17002EDA RID: 11994
			// (get) Token: 0x06008BEE RID: 35822 RVA: 0x002680D4 File Offset: 0x002662D4
			// (set) Token: 0x06008BEF RID: 35823 RVA: 0x0004B319 File Offset: 0x00049519
			public unsafe DLC4_GuardYukaSunFlower __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardYukaSunFlower>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B99 RID: 23449
			private static readonly IntPtr NativeFieldInfoPtr_parentPosition;

			// Token: 0x04005B9A RID: 23450
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B9B RID: 23451
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005B0 RID: 1456
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardYukaSunFlower+<>c__DisplayClass21_1")]
		public sealed class __c__DisplayClass21_1 : Il2CppSystem.Object
		{
			// Token: 0x06008BF0 RID: 35824 RVA: 0x00268104 File Offset: 0x00266304
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_1()
			{
				Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "<>c__DisplayClass21_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_1>.NativeClassPtr);
				DLC4_GuardYukaSunFlower.__c__DisplayClass21_1.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_1>.NativeClassPtr, "direction");
				DLC4_GuardYukaSunFlower.__c__DisplayClass21_1.NativeFieldInfoPtr_field_Public___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC4_GuardYukaSunFlower.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_1>.NativeClassPtr, 100666415);
				DLC4_GuardYukaSunFlower.__c__DisplayClass21_1.NativeMethodInfoPtr__SmallBulletAttack_b__0_Internal_Void_DLC4_SunFlowerSmallBullet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_1>.NativeClassPtr, 100666416);
			}

			// Token: 0x06008BF1 RID: 35825 RVA: 0x00268180 File Offset: 0x00266380
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower.__c__DisplayClass21_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BF2 RID: 35826 RVA: 0x002681BC File Offset: 0x002663BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50602, XrefRangeEnd = 50608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SmallBulletAttack_b__0(DLC4_SunFlowerSmallBullet x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower.__c__DisplayClass21_1.NativeMethodInfoPtr__SmallBulletAttack_b__0_Internal_Void_DLC4_SunFlowerSmallBullet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BF3 RID: 35827 RVA: 0x0004B338 File Offset: 0x00049538
			public __c__DisplayClass21_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EDB RID: 11995
			// (get) Token: 0x06008BF4 RID: 35828 RVA: 0x00268200 File Offset: 0x00266400
			// (set) Token: 0x06008BF5 RID: 35829 RVA: 0x0004B341 File Offset: 0x00049541
			public unsafe Vector2 direction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass21_1.NativeFieldInfoPtr_direction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass21_1.NativeFieldInfoPtr_direction)) = value;
				}
			}

			// Token: 0x17002EDC RID: 11996
			// (get) Token: 0x06008BF6 RID: 35830 RVA: 0x00268228 File Offset: 0x00266428
			// (set) Token: 0x06008BF7 RID: 35831 RVA: 0x0004B35C File Offset: 0x0004955C
			public unsafe DLC4_GuardYukaSunFlower.__c__DisplayClass21_0 field_Public___c__DisplayClass21_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass21_1.NativeFieldInfoPtr_field_Public___c__DisplayClass21_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardYukaSunFlower.__c__DisplayClass21_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower.__c__DisplayClass21_1.NativeFieldInfoPtr_field_Public___c__DisplayClass21_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B9C RID: 23452
			private static readonly IntPtr NativeFieldInfoPtr_direction;

			// Token: 0x04005B9D RID: 23453
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass21_0_0;

			// Token: 0x04005B9E RID: 23454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B9F RID: 23455
			private static readonly IntPtr NativeMethodInfoPtr__SmallBulletAttack_b__0_Internal_Void_DLC4_SunFlowerSmallBullet_0;
		}

		// Token: 0x020005B1 RID: 1457
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardYukaSunFlower+<SkillAttack>d__23")]
		public sealed class _SkillAttack_d__23 : Il2CppSystem.Object
		{
			// Token: 0x06008BF8 RID: 35832 RVA: 0x00268258 File Offset: 0x00266458
			// Note: this type is marked as 'beforefieldinit'.
			static _SkillAttack_d__23()
			{
				Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower>.NativeClassPtr, "<SkillAttack>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr);
				DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr, "<>1__state");
				DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr, "<>2__current");
				DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr, 100666417);
				DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr, 100666418);
				DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr, 100666419);
				DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr, 100666420);
				DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr, 100666421);
				DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr, 100666422);
			}

			// Token: 0x06008BF9 RID: 35833 RVA: 0x00268324 File Offset: 0x00266524
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SkillAttack_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYukaSunFlower._SkillAttack_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BFA RID: 35834 RVA: 0x0026836C File Offset: 0x0026656C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BFB RID: 35835 RVA: 0x002683A0 File Offset: 0x002665A0
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002EDF RID: 11999
			// (get) Token: 0x06008BFC RID: 35836 RVA: 0x002683DC File Offset: 0x002665DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008BFD RID: 35837 RVA: 0x0026841C File Offset: 0x0026661C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50608, XrefRangeEnd = 50614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002EE0 RID: 12000
			// (get) Token: 0x06008BFE RID: 35838 RVA: 0x00268450 File Offset: 0x00266650
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008BFF RID: 35839 RVA: 0x0004B37B File Offset: 0x0004957B
			public _SkillAttack_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EDD RID: 11997
			// (get) Token: 0x06008C00 RID: 35840 RVA: 0x00268490 File Offset: 0x00266690
			// (set) Token: 0x06008C01 RID: 35841 RVA: 0x0004B384 File Offset: 0x00049584
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002EDE RID: 11998
			// (get) Token: 0x06008C02 RID: 35842 RVA: 0x002684B8 File Offset: 0x002666B8
			// (set) Token: 0x06008C03 RID: 35843 RVA: 0x0004B39F File Offset: 0x0004959F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYukaSunFlower._SkillAttack_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005BA0 RID: 23456
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005BA1 RID: 23457
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005BA2 RID: 23458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005BA3 RID: 23459
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005BA4 RID: 23460
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005BA5 RID: 23461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005BA6 RID: 23462
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005BA7 RID: 23463
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
