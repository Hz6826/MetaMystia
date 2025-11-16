using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200007F RID: 127
	public class DLC4_BulletMagicWallet : DLC4_BulletTeam
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x000CA674 File Offset: 0x000C8874
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletMagicWallet()
		{
			Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletMagicWallet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr);
			DLC4_BulletMagicWallet.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, "m_Offset");
			DLC4_BulletMagicWallet.NativeFieldInfoPtr_m_SpawnVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, "m_SpawnVFX");
			DLC4_BulletMagicWallet.NativeFieldInfoPtr_m_DisappearVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, "m_DisappearVFX");
			DLC4_BulletMagicWallet.NativeFieldInfoPtr_followCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, "followCoroutine");
			DLC4_BulletMagicWallet.NativeFieldInfoPtr_TargetEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, "TargetEnemy");
			DLC4_BulletMagicWallet.NativeFieldInfoPtr__MagicWalletProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, "<MagicWalletProperty>k__BackingField");
			DLC4_BulletMagicWallet.NativeMethodInfoPtr_get_MagicWalletProperty_Private_get_ShinmyoumaruBulletProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, 100665528);
			DLC4_BulletMagicWallet.NativeMethodInfoPtr_set_MagicWalletProperty_Public_set_Void_ShinmyoumaruBulletProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, 100665529);
			DLC4_BulletMagicWallet.NativeMethodInfoPtr_OnBulletEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, 100665530);
			DLC4_BulletMagicWallet.NativeMethodInfoPtr_FollowEnemy_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, 100665531);
			DLC4_BulletMagicWallet.NativeMethodInfoPtr_Attack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, 100665532);
			DLC4_BulletMagicWallet.NativeMethodInfoPtr_Miss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, 100665533);
			DLC4_BulletMagicWallet.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, 100665534);
			DLC4_BulletMagicWallet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, 100665535);
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x000CA7BC File Offset: 0x000C89BC
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x000CA7F4 File Offset: 0x000C89F4
		public unsafe DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty MagicWalletProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet.NativeMethodInfoPtr_get_MagicWalletProperty_Private_get_ShinmyoumaruBulletProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44076, XrefRangeEnd = 44077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet.NativeMethodInfoPtr_set_MagicWalletProperty_Public_set_Void_ShinmyoumaruBulletProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x000CA83C File Offset: 0x000C8A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44094, RefRangeEnd = 44095, XrefRangeStart = 44077, XrefRangeEnd = 44094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBulletEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet.NativeMethodInfoPtr_OnBulletEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x000CA870 File Offset: 0x000C8A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44095, XrefRangeEnd = 44100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FollowEnemy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet.NativeMethodInfoPtr_FollowEnemy_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x000CA8B0 File Offset: 0x000C8AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44100, XrefRangeEnd = 44139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet.NativeMethodInfoPtr_Attack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x000CA8E4 File Offset: 0x000C8AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44139, XrefRangeEnd = 44140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Miss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet.NativeMethodInfoPtr_Miss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x000CA918 File Offset: 0x000C8B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44140, XrefRangeEnd = 44143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletMagicWallet.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x000CA954 File Offset: 0x000C8B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletMagicWallet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00008DA0 File Offset: 0x00006FA0
		public DLC4_BulletMagicWallet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x000CA990 File Offset: 0x000C8B90
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00008DA9 File Offset: 0x00006FA9
		public unsafe Vector2 m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x000CA9B8 File Offset: 0x000C8BB8
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00008DC4 File Offset: 0x00006FC4
		public VFXPrefab m_SpawnVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr_m_SpawnVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr_m_SpawnVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x000CA9E8 File Offset: 0x000C8BE8
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x00008DF2 File Offset: 0x00006FF2
		public VFXPrefab m_DisappearVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr_m_DisappearVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr_m_DisappearVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x000CAA18 File Offset: 0x000C8C18
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00008E20 File Offset: 0x00007020
		public unsafe Coroutine followCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr_followCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr_followCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x000CAA48 File Offset: 0x000C8C48
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x00008E3F File Offset: 0x0000703F
		public unsafe DLC4_FlandreEnemyCharacterController TargetEnemy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr_TargetEnemy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr_TargetEnemy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x000CAA78 File Offset: 0x000C8C78
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x00008E5E File Offset: 0x0000705E
		public DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty _MagicWalletProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr__MagicWalletProperty_k__BackingField);
				return new DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet.NativeFieldInfoPtr__MagicWalletProperty_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeFieldInfoPtr_m_SpawnVFX;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeFieldInfoPtr_m_DisappearVFX;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeFieldInfoPtr_followCoroutine;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeFieldInfoPtr_TargetEnemy;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeFieldInfoPtr__MagicWalletProperty_k__BackingField;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_get_MagicWalletProperty_Private_get_ShinmyoumaruBulletProperty_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_set_MagicWalletProperty_Public_set_Void_ShinmyoumaruBulletProperty_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_OnBulletEnable_Public_Void_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_FollowEnemy_Private_IEnumerator_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Public_Void_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_Miss_Public_Void_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000548 RID: 1352
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_BulletMagicWallet+<FollowEnemy>d__10")]
		public sealed class _FollowEnemy_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600872A RID: 34602 RVA: 0x0025A3B0 File Offset: 0x002585B0
			// Note: this type is marked as 'beforefieldinit'.
			static _FollowEnemy_d__10()
			{
				Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BulletMagicWallet>.NativeClassPtr, "<FollowEnemy>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr);
				DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr, "<>1__state");
				DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr, "<>2__current");
				DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr, "<>4__this");
				DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr, 100665536);
				DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr, 100665537);
				DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr, 100665538);
				DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr, 100665539);
				DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr, 100665540);
				DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr, 100665541);
			}

			// Token: 0x0600872B RID: 34603 RVA: 0x0025A490 File Offset: 0x00258690
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FollowEnemy_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletMagicWallet._FollowEnemy_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600872C RID: 34604 RVA: 0x0025A4D8 File Offset: 0x002586D8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600872D RID: 34605 RVA: 0x0025A50C File Offset: 0x0025870C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44066, XrefRangeEnd = 44070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002D59 RID: 11609
			// (get) Token: 0x0600872E RID: 34606 RVA: 0x0025A548 File Offset: 0x00258748
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600872F RID: 34607 RVA: 0x0025A588 File Offset: 0x00258788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44070, XrefRangeEnd = 44076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002D5A RID: 11610
			// (get) Token: 0x06008730 RID: 34608 RVA: 0x0025A5BC File Offset: 0x002587BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008731 RID: 34609 RVA: 0x00048B63 File Offset: 0x00046D63
			public _FollowEnemy_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D56 RID: 11606
			// (get) Token: 0x06008732 RID: 34610 RVA: 0x0025A5FC File Offset: 0x002587FC
			// (set) Token: 0x06008733 RID: 34611 RVA: 0x00048B6C File Offset: 0x00046D6C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002D57 RID: 11607
			// (get) Token: 0x06008734 RID: 34612 RVA: 0x0025A624 File Offset: 0x00258824
			// (set) Token: 0x06008735 RID: 34613 RVA: 0x00048B87 File Offset: 0x00046D87
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D58 RID: 11608
			// (get) Token: 0x06008736 RID: 34614 RVA: 0x0025A654 File Offset: 0x00258854
			// (set) Token: 0x06008737 RID: 34615 RVA: 0x00048BA6 File Offset: 0x00046DA6
			public unsafe DLC4_BulletMagicWallet __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BulletMagicWallet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMagicWallet._FollowEnemy_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040058B0 RID: 22704
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040058B1 RID: 22705
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040058B2 RID: 22706
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040058B3 RID: 22707
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040058B4 RID: 22708
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040058B5 RID: 22709
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040058B6 RID: 22710
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040058B7 RID: 22711
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040058B8 RID: 22712
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
