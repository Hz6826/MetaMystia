using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000082 RID: 130
	public class DLC4_SunFlowerSmallBullet : DLC4_BulletTeamLinear
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x000CAF24 File Offset: 0x000C9124
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_SunFlowerSmallBullet()
		{
			Il2CppClassPointerStore<DLC4_SunFlowerSmallBullet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_SunFlowerSmallBullet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_SunFlowerSmallBullet>.NativeClassPtr);
			DLC4_SunFlowerSmallBullet.NativeFieldInfoPtr__IgnoreEnemy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SunFlowerSmallBullet>.NativeClassPtr, "<IgnoreEnemy>k__BackingField");
			DLC4_SunFlowerSmallBullet.NativeMethodInfoPtr_get_IgnoreEnemy_Private_get_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SunFlowerSmallBullet>.NativeClassPtr, 100665552);
			DLC4_SunFlowerSmallBullet.NativeMethodInfoPtr_set_IgnoreEnemy_Public_set_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SunFlowerSmallBullet>.NativeClassPtr, 100665553);
			DLC4_SunFlowerSmallBullet.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SunFlowerSmallBullet>.NativeClassPtr, 100665554);
			DLC4_SunFlowerSmallBullet.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SunFlowerSmallBullet>.NativeClassPtr, 100665555);
			DLC4_SunFlowerSmallBullet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SunFlowerSmallBullet>.NativeClassPtr, 100665556);
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x000CAFCC File Offset: 0x000C91CC
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x000CB00C File Offset: 0x000C920C
		public unsafe DLC4_FlandreEnemyCharacterController IgnoreEnemy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_SunFlowerSmallBullet.NativeMethodInfoPtr_get_IgnoreEnemy_Private_get_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_SunFlowerSmallBullet.NativeMethodInfoPtr_set_IgnoreEnemy_Public_set_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x000CB050 File Offset: 0x000C9250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44152, XrefRangeEnd = 44158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_SunFlowerSmallBullet.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000CB0A0 File Offset: 0x000C92A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43868, RefRangeEnd = 43869, XrefRangeStart = 43868, XrefRangeEnd = 43869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_SunFlowerSmallBullet.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000CB0DC File Offset: 0x000C92DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_SunFlowerSmallBullet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_SunFlowerSmallBullet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_SunFlowerSmallBullet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00008EF7 File Offset: 0x000070F7
		public DLC4_SunFlowerSmallBullet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x000CB118 File Offset: 0x000C9318
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00008F00 File Offset: 0x00007100
		public unsafe DLC4_FlandreEnemyCharacterController _IgnoreEnemy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SunFlowerSmallBullet.NativeFieldInfoPtr__IgnoreEnemy_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SunFlowerSmallBullet.NativeFieldInfoPtr__IgnoreEnemy_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreEnemy_k__BackingField;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreEnemy_Private_get_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreEnemy_Public_set_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
