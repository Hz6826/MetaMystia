using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000081 RID: 129
	public class DLC4_SunFlowerGiantBullet : DLC4_BulletTeamLinear
	{
		// Token: 0x06000D4B RID: 3403 RVA: 0x000CAD00 File Offset: 0x000C8F00
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_SunFlowerGiantBullet()
		{
			Il2CppClassPointerStore<DLC4_SunFlowerGiantBullet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_SunFlowerGiantBullet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_SunFlowerGiantBullet>.NativeClassPtr);
			DLC4_SunFlowerGiantBullet.NativeFieldInfoPtr__OnHitEnemy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SunFlowerGiantBullet>.NativeClassPtr, "<OnHitEnemy>k__BackingField");
			DLC4_SunFlowerGiantBullet.NativeMethodInfoPtr_get_OnHitEnemy_Private_get_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SunFlowerGiantBullet>.NativeClassPtr, 100665547);
			DLC4_SunFlowerGiantBullet.NativeMethodInfoPtr_set_OnHitEnemy_Public_set_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SunFlowerGiantBullet>.NativeClassPtr, 100665548);
			DLC4_SunFlowerGiantBullet.NativeMethodInfoPtr_AfterHitEnemy_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SunFlowerGiantBullet>.NativeClassPtr, 100665549);
			DLC4_SunFlowerGiantBullet.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SunFlowerGiantBullet>.NativeClassPtr, 100665550);
			DLC4_SunFlowerGiantBullet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SunFlowerGiantBullet>.NativeClassPtr, 100665551);
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x000CADA8 File Offset: 0x000C8FA8
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x000CADE8 File Offset: 0x000C8FE8
		public unsafe Action<Vector2> OnHitEnemy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_SunFlowerGiantBullet.NativeMethodInfoPtr_get_OnHitEnemy_Private_get_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Vector2>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_SunFlowerGiantBullet.NativeMethodInfoPtr_set_OnHitEnemy_Public_set_Void_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000CAE2C File Offset: 0x000C902C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44147, XrefRangeEnd = 44152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterHitEnemy(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_SunFlowerGiantBullet.NativeMethodInfoPtr_AfterHitEnemy_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000CAE7C File Offset: 0x000C907C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43868, RefRangeEnd = 43869, XrefRangeStart = 43868, XrefRangeEnd = 43869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_SunFlowerGiantBullet.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x000CAEB8 File Offset: 0x000C90B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_SunFlowerGiantBullet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_SunFlowerGiantBullet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_SunFlowerGiantBullet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00008ECF File Offset: 0x000070CF
		public DLC4_SunFlowerGiantBullet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x000CAEF4 File Offset: 0x000C90F4
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x00008ED8 File Offset: 0x000070D8
		public unsafe Action<Vector2> _OnHitEnemy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SunFlowerGiantBullet.NativeFieldInfoPtr__OnHitEnemy_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SunFlowerGiantBullet.NativeFieldInfoPtr__OnHitEnemy_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr__OnHitEnemy_k__BackingField;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_get_OnHitEnemy_Private_get_Action_1_Vector2_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_set_OnHitEnemy_Public_set_Void_Action_1_Vector2_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_AfterHitEnemy_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
