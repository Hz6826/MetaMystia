using System;
using Common.Audio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Night.BossBattle.DLC4_BossBattle;
using UnityEngine;

// Token: 0x0200000E RID: 14
public class DLC4_PleasedFlandreCharacterController : DLC4_FlandreEnemyCharacterController
{
	// Token: 0x060000CA RID: 202 RVA: 0x000A18A4 File Offset: 0x0009FAA4
	// Note: this type is marked as 'beforefieldinit'.
	static DLC4_PleasedFlandreCharacterController()
	{
		Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DLC4_PleasedFlandreCharacterController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr);
		DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_PARAMETER_THROW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, "PARAMETER_THROW");
		DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_ShootInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, "m_ShootInterval");
		DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_StarBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, "m_StarBullet");
		DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_BulletSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, "m_BulletSpawnPoint");
		DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_BulletSpawnSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, "m_BulletSpawnSfx");
		DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_throwManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, "throwManager");
		DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_waitToShootTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, "waitToShootTime");
		DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, 100663391);
		DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, 100663392);
		DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_Shoot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, 100663393);
		DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_SpawnBullet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, 100663394);
		DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_PlayThrowAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, 100663395);
		DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, 100663396);
		DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr, 100663397);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x000A19EC File Offset: 0x0009FBEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3547, XrefRangeEnd = 3562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, Action afterAttackingFinishCallback, Action afterCompletelyDeadCallback, DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dlc4BossBattleManager);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAttackingFinishCallback);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCompletelyDeadCallback);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attackConditionCheck);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000CC RID: 204 RVA: 0x000A1A70 File Offset: 0x0009FC70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3562, XrefRangeEnd = 3564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000CD RID: 205 RVA: 0x000A1AAC File Offset: 0x0009FCAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3564, XrefRangeEnd = 3569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Shoot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_Shoot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000CE RID: 206 RVA: 0x000A1AE0 File Offset: 0x0009FCE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnBullet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_SpawnBullet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000CF RID: 207 RVA: 0x000A1B14 File Offset: 0x0009FD14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3569, XrefRangeEnd = 3573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayThrowAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_PlayThrowAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x000A1B48 File Offset: 0x0009FD48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3573, XrefRangeEnd = 3576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x000A1B84 File Offset: 0x0009FD84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLC4_PleasedFlandreCharacterController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_PleasedFlandreCharacterController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_PleasedFlandreCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0000256F File Offset: 0x0000076F
	public DLC4_PleasedFlandreCharacterController(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060000D3 RID: 211 RVA: 0x000A1BC0 File Offset: 0x0009FDC0
	// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002578 File Offset: 0x00000778
	public unsafe static string PARAMETER_THROW
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_PARAMETER_THROW, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_PARAMETER_THROW, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060000D5 RID: 213 RVA: 0x000A1BE0 File Offset: 0x0009FDE0
	// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000258A File Offset: 0x0000078A
	public unsafe float m_ShootInterval
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_ShootInterval);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_ShootInterval)) = value;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060000D7 RID: 215 RVA: 0x000A1C08 File Offset: 0x0009FE08
	// (set) Token: 0x060000D8 RID: 216 RVA: 0x000025A5 File Offset: 0x000007A5
	public DLC4_FlandreEnemyCharacterController.FlandreBullet m_StarBullet
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_StarBullet);
			return new DLC4_FlandreEnemyCharacterController.FlandreBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_StarBullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_FlandreEnemyCharacterController.FlandreBullet>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060000D9 RID: 217 RVA: 0x000A1C38 File Offset: 0x0009FE38
	// (set) Token: 0x060000DA RID: 218 RVA: 0x000025D3 File Offset: 0x000007D3
	public unsafe Transform m_BulletSpawnPoint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_BulletSpawnPoint);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_BulletSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060000DB RID: 219 RVA: 0x000A1C68 File Offset: 0x0009FE68
	// (set) Token: 0x060000DC RID: 220 RVA: 0x000025F2 File Offset: 0x000007F2
	public GlobalAudioManager.DelayAudioClip m_BulletSpawnSfx
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_BulletSpawnSfx);
			return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_m_BulletSpawnSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060000DD RID: 221 RVA: 0x000A1C98 File Offset: 0x0009FE98
	// (set) Token: 0x060000DE RID: 222 RVA: 0x00002620 File Offset: 0x00000820
	public unsafe ThrowState throwManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_throwManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThrowState>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_throwManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060000DF RID: 223 RVA: 0x000A1CC8 File Offset: 0x0009FEC8
	// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000263F File Offset: 0x0000083F
	public unsafe float waitToShootTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_waitToShootTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_PleasedFlandreCharacterController.NativeFieldInfoPtr_waitToShootTime)) = value;
		}
	}

	// Token: 0x04000082 RID: 130
	private static readonly IntPtr NativeFieldInfoPtr_PARAMETER_THROW;

	// Token: 0x04000083 RID: 131
	private static readonly IntPtr NativeFieldInfoPtr_m_ShootInterval;

	// Token: 0x04000084 RID: 132
	private static readonly IntPtr NativeFieldInfoPtr_m_StarBullet;

	// Token: 0x04000085 RID: 133
	private static readonly IntPtr NativeFieldInfoPtr_m_BulletSpawnPoint;

	// Token: 0x04000086 RID: 134
	private static readonly IntPtr NativeFieldInfoPtr_m_BulletSpawnSfx;

	// Token: 0x04000087 RID: 135
	private static readonly IntPtr NativeFieldInfoPtr_throwManager;

	// Token: 0x04000088 RID: 136
	private static readonly IntPtr NativeFieldInfoPtr_waitToShootTime;

	// Token: 0x04000089 RID: 137
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0;

	// Token: 0x0400008A RID: 138
	private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

	// Token: 0x0400008B RID: 139
	private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Void_0;

	// Token: 0x0400008C RID: 140
	private static readonly IntPtr NativeMethodInfoPtr_SpawnBullet_Private_Void_0;

	// Token: 0x0400008D RID: 141
	private static readonly IntPtr NativeMethodInfoPtr_PlayThrowAnimation_Private_Void_0;

	// Token: 0x0400008E RID: 142
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x0400008F RID: 143
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
