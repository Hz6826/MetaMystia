using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000A2 RID: 162
	public class DLC4_GuardMedicine : DLC4_GuardController
	{
		// Token: 0x060010D7 RID: 4311 RVA: 0x000D7750 File Offset: 0x000D5950
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_GuardMedicine()
		{
			Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_GuardMedicine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr);
			DLC4_GuardMedicine.NativeFieldInfoPtr_PRD_MEDICINE_POISON_LV1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "PRD_MEDICINE_POISON_LV1");
			DLC4_GuardMedicine.NativeFieldInfoPtr_PRD_MEDICINE_POISON_LV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "PRD_MEDICINE_POISON_LV2");
			DLC4_GuardMedicine.NativeFieldInfoPtr_m_Level1Bullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "m_Level1Bullet");
			DLC4_GuardMedicine.NativeFieldInfoPtr_m_Level2Bullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "m_Level2Bullet");
			DLC4_GuardMedicine.NativeFieldInfoPtr_m_UltimateSkillBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "m_UltimateSkillBullet");
			DLC4_GuardMedicine.NativeFieldInfoPtr_m_UltimateSkillAcidPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "m_UltimateSkillAcidPool");
			DLC4_GuardMedicine.NativeFieldInfoPtr_m_DieEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "m_DieEffect");
			DLC4_GuardMedicine.NativeFieldInfoPtr_m_DieVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "m_DieVFX");
			DLC4_GuardMedicine.NativeFieldInfoPtr_m_LaunchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "m_LaunchHeight");
			DLC4_GuardMedicine.NativeFieldInfoPtr_m_DieSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "m_DieSfx");
			DLC4_GuardMedicine.NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666255);
			DLC4_GuardMedicine.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666256);
			DLC4_GuardMedicine.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666257);
			DLC4_GuardMedicine.NativeMethodInfoPtr_TargetEnemyPosition_Private_Vector2_Func_1_Boolean_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666258);
			DLC4_GuardMedicine.NativeMethodInfoPtr_OnLoseExtraEffect_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666259);
			DLC4_GuardMedicine.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666260);
			DLC4_GuardMedicine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666261);
			DLC4_GuardMedicine.NativeMethodInfoPtr__CouldAttack_b__10_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666262);
			DLC4_GuardMedicine.NativeMethodInfoPtr__SkillAttack_b__12_0_Private_Void_DLC4_BulletMedicineGiantPoisonBottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666263);
			DLC4_GuardMedicine.NativeMethodInfoPtr__OnLoseExtraEffect_b__14_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666264);
			DLC4_GuardMedicine.NativeMethodInfoPtr__OnLoseExtraEffect_b__14_1_Private_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, 100666265);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x000D7924 File Offset: 0x000D5B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49772, XrefRangeEnd = 49807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CouldAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardMedicine.NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x000D796C File Offset: 0x000D5B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49807, XrefRangeEnd = 49830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NormalAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardMedicine.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x000D79A8 File Offset: 0x000D5BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49830, XrefRangeEnd = 49835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator SkillAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardMedicine.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x000D79F4 File Offset: 0x000D5BF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49846, RefRangeEnd = 49848, XrefRangeStart = 49835, XrefRangeEnd = 49846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 TargetEnemyPosition(Func<bool> extraAttackCheck, Vector2 targetEnemyPosition, float bulletSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(extraAttackCheck);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetEnemyPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bulletSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine.NativeMethodInfoPtr_TargetEnemyPosition_Private_Vector2_Func_1_Boolean_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x000D7A60 File Offset: 0x000D5C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49848, XrefRangeEnd = 49872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnLoseExtraEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardMedicine.NativeMethodInfoPtr_OnLoseExtraEffect_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000D7A9C File Offset: 0x000D5C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49872, XrefRangeEnd = 49874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardMedicine.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x000D7AD8 File Offset: 0x000D5CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_GuardMedicine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x000D7B14 File Offset: 0x000D5D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49874, XrefRangeEnd = 49878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CouldAttack_b__10_0(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine.NativeMethodInfoPtr__CouldAttack_b__10_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x000D7B64 File Offset: 0x000D5D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49878, XrefRangeEnd = 49880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SkillAttack_b__12_0(DLC4_BulletMedicineGiantPoisonBottle x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine.NativeMethodInfoPtr__SkillAttack_b__12_0_Private_Void_DLC4_BulletMedicineGiantPoisonBottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x000D7BA8 File Offset: 0x000D5DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49880, XrefRangeEnd = 49882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnLoseExtraEffect_b__14_0(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine.NativeMethodInfoPtr__OnLoseExtraEffect_b__14_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000D7BF8 File Offset: 0x000D5DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49882, XrefRangeEnd = 49883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnLoseExtraEffect_b__14_1(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine.NativeMethodInfoPtr__OnLoseExtraEffect_b__14_1_Private_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0000AB2E File Offset: 0x00008D2E
		public DLC4_GuardMedicine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x000D7C3C File Offset: 0x000D5E3C
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x0000AB37 File Offset: 0x00008D37
		public unsafe static string PRD_MEDICINE_POISON_LV1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_GuardMedicine.NativeFieldInfoPtr_PRD_MEDICINE_POISON_LV1, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_GuardMedicine.NativeFieldInfoPtr_PRD_MEDICINE_POISON_LV1, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x000D7C5C File Offset: 0x000D5E5C
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x0000AB49 File Offset: 0x00008D49
		public unsafe static string PRD_MEDICINE_POISON_LV2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_GuardMedicine.NativeFieldInfoPtr_PRD_MEDICINE_POISON_LV2, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_GuardMedicine.NativeFieldInfoPtr_PRD_MEDICINE_POISON_LV2, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x000D7C7C File Offset: 0x000D5E7C
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x0000AB5B File Offset: 0x00008D5B
		public DLC4_GuardMedicine.MedicineBullet m_Level1Bullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_Level1Bullet);
				return new DLC4_GuardMedicine.MedicineBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBullet>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_Level1Bullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBullet>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x000D7CAC File Offset: 0x000D5EAC
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x0000AB89 File Offset: 0x00008D89
		public DLC4_GuardMedicine.MedicineBullet m_Level2Bullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_Level2Bullet);
				return new DLC4_GuardMedicine.MedicineBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBullet>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_Level2Bullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBullet>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x000D7CDC File Offset: 0x000D5EDC
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x0000ABB7 File Offset: 0x00008DB7
		public DLC4_GuardController.TeamBulletProperty m_UltimateSkillBullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_UltimateSkillBullet);
				return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_UltimateSkillBullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x000D7D0C File Offset: 0x000D5F0C
		// (set) Token: 0x060010EF RID: 4335 RVA: 0x0000ABE5 File Offset: 0x00008DE5
		public DLC4_GuardMedicine.MedicinePoolBullet m_UltimateSkillAcidPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_UltimateSkillAcidPool);
				return new DLC4_GuardMedicine.MedicinePoolBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicinePoolBullet>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_UltimateSkillAcidPool), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicinePoolBullet>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x000D7D3C File Offset: 0x000D5F3C
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x0000AC13 File Offset: 0x00008E13
		public unsafe DLC4_GuardMedicine.MedicineAcidPoolProperty m_DieEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_DieEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_DieEffect)) = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x000D7D64 File Offset: 0x000D5F64
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x0000AC2E File Offset: 0x00008E2E
		public VFXPrefab m_DieVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_DieVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_DieVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x000D7D94 File Offset: 0x000D5F94
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x0000AC5C File Offset: 0x00008E5C
		public unsafe float m_LaunchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_LaunchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_LaunchHeight)) = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x000D7DBC File Offset: 0x000D5FBC
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x0000AC77 File Offset: 0x00008E77
		public unsafe AudioClip m_DieSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_DieSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.NativeFieldInfoPtr_m_DieSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeFieldInfoPtr_PRD_MEDICINE_POISON_LV1;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeFieldInfoPtr_PRD_MEDICINE_POISON_LV2;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeFieldInfoPtr_m_Level1Bullet;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeFieldInfoPtr_m_Level2Bullet;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeFieldInfoPtr_m_UltimateSkillBullet;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeFieldInfoPtr_m_UltimateSkillAcidPool;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeFieldInfoPtr_m_DieEffect;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeFieldInfoPtr_m_DieVFX;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeFieldInfoPtr_m_LaunchHeight;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeFieldInfoPtr_m_DieSfx;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_CouldAttack_Protected_Virtual_Boolean_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_TargetEnemyPosition_Private_Vector2_Func_1_Boolean_Vector2_Single_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_OnLoseExtraEffect_Protected_Virtual_Void_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr__CouldAttack_b__10_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr__SkillAttack_b__12_0_Private_Void_DLC4_BulletMedicineGiantPoisonBottle_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr__OnLoseExtraEffect_b__14_0_Private_Boolean_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr__OnLoseExtraEffect_b__14_1_Private_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x02000597 RID: 1431
		[Serializable]
		public sealed class MedicineBullet : ValueType
		{
			// Token: 0x06008AED RID: 35565 RVA: 0x002653DC File Offset: 0x002635DC
			// Note: this type is marked as 'beforefieldinit'.
			static MedicineBullet()
			{
				Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBullet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "MedicineBullet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBullet>.NativeClassPtr);
				DLC4_GuardMedicine.MedicineBullet.NativeFieldInfoPtr_m_BaseBulletProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBullet>.NativeClassPtr, "m_BaseBulletProperty");
				DLC4_GuardMedicine.MedicineBullet.NativeFieldInfoPtr_m_MedicineBulletProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBullet>.NativeClassPtr, "m_MedicineBulletProperty");
			}

			// Token: 0x06008AEE RID: 35566 RVA: 0x0004AA29 File Offset: 0x00048C29
			public MedicineBullet(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008AEF RID: 35567 RVA: 0x0004AA32 File Offset: 0x00048C32
			public MedicineBullet() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBullet>.NativeClassPtr))
			{
			}

			// Token: 0x17002E87 RID: 11911
			// (get) Token: 0x06008AF0 RID: 35568 RVA: 0x00265430 File Offset: 0x00263630
			// (set) Token: 0x06008AF1 RID: 35569 RVA: 0x0004AA44 File Offset: 0x00048C44
			public DLC4_GuardController.TeamBulletProperty m_BaseBulletProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.MedicineBullet.NativeFieldInfoPtr_m_BaseBulletProperty);
					return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.MedicineBullet.NativeFieldInfoPtr_m_BaseBulletProperty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002E88 RID: 11912
			// (get) Token: 0x06008AF2 RID: 35570 RVA: 0x00265460 File Offset: 0x00263660
			// (set) Token: 0x06008AF3 RID: 35571 RVA: 0x0004AA72 File Offset: 0x00048C72
			public unsafe DLC4_GuardMedicine.MedicineBulletProperty m_MedicineBulletProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.MedicineBullet.NativeFieldInfoPtr_m_MedicineBulletProperty);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.MedicineBullet.NativeFieldInfoPtr_m_MedicineBulletProperty)) = value;
				}
			}

			// Token: 0x04005AFC RID: 23292
			private static readonly IntPtr NativeFieldInfoPtr_m_BaseBulletProperty;

			// Token: 0x04005AFD RID: 23293
			private static readonly IntPtr NativeFieldInfoPtr_m_MedicineBulletProperty;
		}

		// Token: 0x02000598 RID: 1432
		[Serializable]
		public sealed class MedicinePoolBullet : ValueType
		{
			// Token: 0x06008AF4 RID: 35572 RVA: 0x00265488 File Offset: 0x00263688
			// Note: this type is marked as 'beforefieldinit'.
			static MedicinePoolBullet()
			{
				Il2CppClassPointerStore<DLC4_GuardMedicine.MedicinePoolBullet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "MedicinePoolBullet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicinePoolBullet>.NativeClassPtr);
				DLC4_GuardMedicine.MedicinePoolBullet.NativeFieldInfoPtr_m_BaseBulletProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicinePoolBullet>.NativeClassPtr, "m_BaseBulletProperty");
				DLC4_GuardMedicine.MedicinePoolBullet.NativeFieldInfoPtr_m_MedicineAcidPoolProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicinePoolBullet>.NativeClassPtr, "m_MedicineAcidPoolProperty");
			}

			// Token: 0x06008AF5 RID: 35573 RVA: 0x0004AA8D File Offset: 0x00048C8D
			public MedicinePoolBullet(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008AF6 RID: 35574 RVA: 0x0004AA96 File Offset: 0x00048C96
			public MedicinePoolBullet() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicinePoolBullet>.NativeClassPtr))
			{
			}

			// Token: 0x17002E89 RID: 11913
			// (get) Token: 0x06008AF7 RID: 35575 RVA: 0x002654DC File Offset: 0x002636DC
			// (set) Token: 0x06008AF8 RID: 35576 RVA: 0x0004AAA8 File Offset: 0x00048CA8
			public DLC4_GuardController.TeamBulletProperty m_BaseBulletProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.MedicinePoolBullet.NativeFieldInfoPtr_m_BaseBulletProperty);
					return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.MedicinePoolBullet.NativeFieldInfoPtr_m_BaseBulletProperty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002E8A RID: 11914
			// (get) Token: 0x06008AF9 RID: 35577 RVA: 0x0026550C File Offset: 0x0026370C
			// (set) Token: 0x06008AFA RID: 35578 RVA: 0x0004AAD6 File Offset: 0x00048CD6
			public unsafe DLC4_GuardMedicine.MedicineAcidPoolProperty m_MedicineAcidPoolProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.MedicinePoolBullet.NativeFieldInfoPtr_m_MedicineAcidPoolProperty);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine.MedicinePoolBullet.NativeFieldInfoPtr_m_MedicineAcidPoolProperty)) = value;
				}
			}

			// Token: 0x04005AFE RID: 23294
			private static readonly IntPtr NativeFieldInfoPtr_m_BaseBulletProperty;

			// Token: 0x04005AFF RID: 23295
			private static readonly IntPtr NativeFieldInfoPtr_m_MedicineAcidPoolProperty;
		}

		// Token: 0x02000599 RID: 1433
		[Serializable]
		[StructLayout(2)]
		public struct MedicineBulletProperty
		{
			// Token: 0x06008AFB RID: 35579 RVA: 0x00265534 File Offset: 0x00263734
			// Note: this type is marked as 'beforefieldinit'.
			static MedicineBulletProperty()
			{
				Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBulletProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "MedicineBulletProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBulletProperty>.NativeClassPtr);
				DLC4_GuardMedicine.MedicineBulletProperty.NativeFieldInfoPtr_m_PoisonRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBulletProperty>.NativeClassPtr, "m_PoisonRate");
				DLC4_GuardMedicine.MedicineBulletProperty.NativeFieldInfoPtr_m_PoisonDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBulletProperty>.NativeClassPtr, "m_PoisonDamage");
				DLC4_GuardMedicine.MedicineBulletProperty.NativeFieldInfoPtr_m_PoisonDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBulletProperty>.NativeClassPtr, "m_PoisonDuration");
			}

			// Token: 0x06008AFC RID: 35580 RVA: 0x0004AAF1 File Offset: 0x00048CF1
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineBulletProperty>.NativeClassPtr, ref this));
			}

			// Token: 0x04005B00 RID: 23296
			private static readonly IntPtr NativeFieldInfoPtr_m_PoisonRate;

			// Token: 0x04005B01 RID: 23297
			private static readonly IntPtr NativeFieldInfoPtr_m_PoisonDamage;

			// Token: 0x04005B02 RID: 23298
			private static readonly IntPtr NativeFieldInfoPtr_m_PoisonDuration;

			// Token: 0x04005B03 RID: 23299
			[FieldOffset(0)]
			public float m_PoisonRate;

			// Token: 0x04005B04 RID: 23300
			[FieldOffset(4)]
			public int m_PoisonDamage;

			// Token: 0x04005B05 RID: 23301
			[FieldOffset(8)]
			public int m_PoisonDuration;
		}

		// Token: 0x0200059A RID: 1434
		[Serializable]
		[StructLayout(2)]
		public struct MedicineAcidPoolProperty
		{
			// Token: 0x06008AFD RID: 35581 RVA: 0x0026559C File Offset: 0x0026379C
			// Note: this type is marked as 'beforefieldinit'.
			static MedicineAcidPoolProperty()
			{
				Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineAcidPoolProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "MedicineAcidPoolProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineAcidPoolProperty>.NativeClassPtr);
				DLC4_GuardMedicine.MedicineAcidPoolProperty.NativeFieldInfoPtr_m_PoisonDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineAcidPoolProperty>.NativeClassPtr, "m_PoisonDamage");
				DLC4_GuardMedicine.MedicineAcidPoolProperty.NativeFieldInfoPtr_m_PoisonDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineAcidPoolProperty>.NativeClassPtr, "m_PoisonDuration");
				DLC4_GuardMedicine.MedicineAcidPoolProperty.NativeFieldInfoPtr_m_PoolDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineAcidPoolProperty>.NativeClassPtr, "m_PoolDuration");
				DLC4_GuardMedicine.MedicineAcidPoolProperty.NativeFieldInfoPtr_m_PoolRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineAcidPoolProperty>.NativeClassPtr, "m_PoolRadius");
				DLC4_GuardMedicine.MedicineAcidPoolProperty.NativeFieldInfoPtr_m_PoolFrozenMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineAcidPoolProperty>.NativeClassPtr, "m_PoolFrozenMultiplier");
			}

			// Token: 0x06008AFE RID: 35582 RVA: 0x0004AB03 File Offset: 0x00048D03
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicineAcidPoolProperty>.NativeClassPtr, ref this));
			}

			// Token: 0x04005B06 RID: 23302
			private static readonly IntPtr NativeFieldInfoPtr_m_PoisonDamage;

			// Token: 0x04005B07 RID: 23303
			private static readonly IntPtr NativeFieldInfoPtr_m_PoisonDuration;

			// Token: 0x04005B08 RID: 23304
			private static readonly IntPtr NativeFieldInfoPtr_m_PoolDuration;

			// Token: 0x04005B09 RID: 23305
			private static readonly IntPtr NativeFieldInfoPtr_m_PoolRadius;

			// Token: 0x04005B0A RID: 23306
			private static readonly IntPtr NativeFieldInfoPtr_m_PoolFrozenMultiplier;

			// Token: 0x04005B0B RID: 23307
			[FieldOffset(0)]
			public int m_PoisonDamage;

			// Token: 0x04005B0C RID: 23308
			[FieldOffset(4)]
			public int m_PoisonDuration;

			// Token: 0x04005B0D RID: 23309
			[FieldOffset(8)]
			public int m_PoolDuration;

			// Token: 0x04005B0E RID: 23310
			[FieldOffset(12)]
			public float m_PoolRadius;

			// Token: 0x04005B0F RID: 23311
			[FieldOffset(16)]
			public float m_PoolFrozenMultiplier;
		}

		// Token: 0x0200059B RID: 1435
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardMedicine+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008AFF RID: 35583 RVA: 0x0026562C File Offset: 0x0026382C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_GuardMedicine.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardMedicine.__c>.NativeClassPtr);
				DLC4_GuardMedicine.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.__c>.NativeClassPtr, "<>9");
				DLC4_GuardMedicine.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine.__c>.NativeClassPtr, "<>9__10_1");
				DLC4_GuardMedicine.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine.__c>.NativeClassPtr, 100666267);
				DLC4_GuardMedicine.__c.NativeMethodInfoPtr__CouldAttack_b__10_1_Internal_Single_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine.__c>.NativeClassPtr, 100666268);
			}

			// Token: 0x06008B00 RID: 35584 RVA: 0x002656A8 File Offset: 0x002638A8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardMedicine.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B01 RID: 35585 RVA: 0x002656E4 File Offset: 0x002638E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CouldAttack_b__10_1(DLC4_FlandreEnemyCharacterController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine.__c.NativeMethodInfoPtr__CouldAttack_b__10_1_Internal_Single_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008B02 RID: 35586 RVA: 0x0004AB15 File Offset: 0x00048D15
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E8B RID: 11915
			// (get) Token: 0x06008B03 RID: 35587 RVA: 0x00265734 File Offset: 0x00263934
			// (set) Token: 0x06008B04 RID: 35588 RVA: 0x0004AB1E File Offset: 0x00048D1E
			public unsafe static DLC4_GuardMedicine.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardMedicine.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardMedicine.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardMedicine.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E8C RID: 11916
			// (get) Token: 0x06008B05 RID: 35589 RVA: 0x0026575C File Offset: 0x0026395C
			// (set) Token: 0x06008B06 RID: 35590 RVA: 0x0004AB30 File Offset: 0x00048D30
			public unsafe static Func<DLC4_FlandreEnemyCharacterController, float> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardMedicine.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC4_FlandreEnemyCharacterController, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardMedicine.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B10 RID: 23312
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005B11 RID: 23313
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04005B12 RID: 23314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005B13 RID: 23315
			private static readonly IntPtr NativeMethodInfoPtr__CouldAttack_b__10_1_Internal_Single_DLC4_FlandreEnemyCharacterController_0;
		}

		// Token: 0x0200059C RID: 1436
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardMedicine+<SkillAttack>d__12")]
		public sealed class _SkillAttack_d__12 : Il2CppSystem.Object
		{
			// Token: 0x06008B07 RID: 35591 RVA: 0x00265784 File Offset: 0x00263984
			// Note: this type is marked as 'beforefieldinit'.
			static _SkillAttack_d__12()
			{
				Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardMedicine>.NativeClassPtr, "<SkillAttack>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr);
				DLC4_GuardMedicine._SkillAttack_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr, "<>1__state");
				DLC4_GuardMedicine._SkillAttack_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr, "<>2__current");
				DLC4_GuardMedicine._SkillAttack_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr, "<>4__this");
				DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr, 100666269);
				DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr, 100666270);
				DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr, 100666271);
				DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr, 100666272);
				DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr, 100666273);
				DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr, 100666274);
			}

			// Token: 0x06008B08 RID: 35592 RVA: 0x00265864 File Offset: 0x00263A64
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SkillAttack_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardMedicine._SkillAttack_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B09 RID: 35593 RVA: 0x002658AC File Offset: 0x00263AAC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B0A RID: 35594 RVA: 0x002658E0 File Offset: 0x00263AE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49746, XrefRangeEnd = 49766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E90 RID: 11920
			// (get) Token: 0x06008B0B RID: 35595 RVA: 0x0026591C File Offset: 0x00263B1C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B0C RID: 35596 RVA: 0x0026595C File Offset: 0x00263B5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49766, XrefRangeEnd = 49772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E91 RID: 11921
			// (get) Token: 0x06008B0D RID: 35597 RVA: 0x00265990 File Offset: 0x00263B90
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardMedicine._SkillAttack_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B0E RID: 35598 RVA: 0x0004AB42 File Offset: 0x00048D42
			public _SkillAttack_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E8D RID: 11917
			// (get) Token: 0x06008B0F RID: 35599 RVA: 0x002659D0 File Offset: 0x00263BD0
			// (set) Token: 0x06008B10 RID: 35600 RVA: 0x0004AB4B File Offset: 0x00048D4B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine._SkillAttack_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine._SkillAttack_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E8E RID: 11918
			// (get) Token: 0x06008B11 RID: 35601 RVA: 0x002659F8 File Offset: 0x00263BF8
			// (set) Token: 0x06008B12 RID: 35602 RVA: 0x0004AB66 File Offset: 0x00048D66
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine._SkillAttack_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine._SkillAttack_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E8F RID: 11919
			// (get) Token: 0x06008B13 RID: 35603 RVA: 0x00265A28 File Offset: 0x00263C28
			// (set) Token: 0x06008B14 RID: 35604 RVA: 0x0004AB85 File Offset: 0x00048D85
			public unsafe DLC4_GuardMedicine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine._SkillAttack_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardMedicine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardMedicine._SkillAttack_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B14 RID: 23316
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005B15 RID: 23317
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005B16 RID: 23318
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005B17 RID: 23319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005B18 RID: 23320
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B19 RID: 23321
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005B1A RID: 23322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005B1B RID: 23323
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B1C RID: 23324
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
