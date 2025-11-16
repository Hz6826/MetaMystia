using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000077 RID: 119
	public class DLC4_BulletTeam : DLC4_BulletBase
	{
		// Token: 0x06000CAA RID: 3242 RVA: 0x000C88C4 File Offset: 0x000C6AC4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletTeam()
		{
			Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletTeam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr);
			DLC4_BulletTeam.NativeFieldInfoPtr_ENEMY_LAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, "ENEMY_LAYER");
			DLC4_BulletTeam.NativeFieldInfoPtr_spawnSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, "spawnSfx");
			DLC4_BulletTeam.NativeFieldInfoPtr_hitSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, "hitSfx");
			DLC4_BulletTeam.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, "collider");
			DLC4_BulletTeam.NativeFieldInfoPtr_Shooter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, "Shooter");
			DLC4_BulletTeam.NativeMethodInfoPtr_get_BulletShooterType_Public_Virtual_get_BulletType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665449);
			DLC4_BulletTeam.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665450);
			DLC4_BulletTeam.NativeMethodInfoPtr_Initialize_Public_Void_DLC4_GuardController_TeamBulletProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665451);
			DLC4_BulletTeam.NativeMethodInfoPtr_StunEnemy_Protected_Void_DLC4_FlandreEnemyCharacterController_Single_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665452);
			DLC4_BulletTeam.NativeMethodInfoPtr_DecelerationEnemy_Protected_Void_DLC4_FlandreEnemyCharacterController_Single_Single_Boolean_BulletTypeIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665453);
			DLC4_BulletTeam.NativeMethodInfoPtr_DecelerationEnemyEnvironment_Protected_Void_DLC4_FlandreEnemyCharacterController_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665454);
			DLC4_BulletTeam.NativeMethodInfoPtr_PoisonEnemy_Protected_Void_DLC4_FlandreEnemyCharacterController_Int32_Single_BulletTypeIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665455);
			DLC4_BulletTeam.NativeMethodInfoPtr_OnHit_Protected_Virtual_New_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665456);
			DLC4_BulletTeam.NativeMethodInfoPtr_AfterHitEnemy_Protected_Virtual_New_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665457);
			DLC4_BulletTeam.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665458);
			DLC4_BulletTeam.NativeMethodInfoPtr_PlaySpawnSFX_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665459);
			DLC4_BulletTeam.NativeMethodInfoPtr_PlayHitSFX_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665460);
			DLC4_BulletTeam.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665461);
			DLC4_BulletTeam.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr, 100665462);
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x000C8A70 File Offset: 0x000C6C70
		public unsafe override DLC4_BulletBase.BulletType BulletShooterType
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeam.NativeMethodInfoPtr_get_BulletShooterType_Public_Virtual_get_BulletType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000C8AB8 File Offset: 0x000C6CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43693, XrefRangeEnd = 43702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeam.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x000C8AFC File Offset: 0x000C6CFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43720, RefRangeEnd = 43721, XrefRangeStart = 43702, XrefRangeEnd = 43720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DLC4_GuardController shooter, DLC4_GuardController.TeamBulletProperty bullet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shooter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bullet));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeam.NativeMethodInfoPtr_Initialize_Public_Void_DLC4_GuardController_TeamBulletProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x000C8B58 File Offset: 0x000C6D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43721, XrefRangeEnd = 43723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StunEnemy(DLC4_FlandreEnemyCharacterController enemy, float duration, out Action interruptCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeam.NativeMethodInfoPtr_StunEnemy_Protected_Void_DLC4_FlandreEnemyCharacterController_Single_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			interruptCallback = ((intPtr4 == 0) ? null : new Action(intPtr4));
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000C8BCC File Offset: 0x000C6DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43723, XrefRangeEnd = 43724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecelerationEnemy(DLC4_FlandreEnemyCharacterController enemy, float multiplier, float duration, bool checkCanBeFrozen, BulletTypeIndex bulletId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiplier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCanBeFrozen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bulletId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeam.NativeMethodInfoPtr_DecelerationEnemy_Protected_Void_DLC4_FlandreEnemyCharacterController_Single_Single_Boolean_BulletTypeIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x000C8C48 File Offset: 0x000C6E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43724, XrefRangeEnd = 43725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecelerationEnemyEnvironment(DLC4_FlandreEnemyCharacterController enemy, float multiplier, float duration, bool checkCanBeFrozen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiplier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCanBeFrozen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeam.NativeMethodInfoPtr_DecelerationEnemyEnvironment_Protected_Void_DLC4_FlandreEnemyCharacterController_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000C8CB4 File Offset: 0x000C6EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43727, RefRangeEnd = 43728, XrefRangeStart = 43725, XrefRangeEnd = 43727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoisonEnemy(DLC4_FlandreEnemyCharacterController enemy, int damage, float duration, BulletTypeIndex bulletId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bulletId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeam.NativeMethodInfoPtr_PoisonEnemy_Protected_Void_DLC4_FlandreEnemyCharacterController_Int32_Single_BulletTypeIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000C8D20 File Offset: 0x000C6F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43742, RefRangeEnd = 43743, XrefRangeStart = 43728, XrefRangeEnd = 43742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeam.NativeMethodInfoPtr_OnHit_Protected_Virtual_New_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000C8D70 File Offset: 0x000C6F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43745, RefRangeEnd = 43746, XrefRangeStart = 43743, XrefRangeEnd = 43745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AfterHitEnemy(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeam.NativeMethodInfoPtr_AfterHitEnemy_Protected_Virtual_New_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000C8DC0 File Offset: 0x000C6FC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 43760, RefRangeEnd = 43764, XrefRangeStart = 43746, XrefRangeEnd = 43760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeam.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000C8DFC File Offset: 0x000C6FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43764, XrefRangeEnd = 43772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaySpawnSFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeam.NativeMethodInfoPtr_PlaySpawnSFX_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000C8E30 File Offset: 0x000C7030
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 43780, RefRangeEnd = 43788, XrefRangeStart = 43772, XrefRangeEnd = 43780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayHitSFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeam.NativeMethodInfoPtr_PlayHitSFX_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x000C8E64 File Offset: 0x000C7064
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 43794, RefRangeEnd = 43805, XrefRangeStart = 43788, XrefRangeEnd = 43794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeam.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000C8EA0 File Offset: 0x000C70A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletTeam() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletTeam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeam.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00008A88 File Offset: 0x00006C88
		public DLC4_BulletTeam(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x000C8EDC File Offset: 0x000C70DC
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00008A91 File Offset: 0x00006C91
		public unsafe static int ENEMY_LAYER
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_BulletTeam.NativeFieldInfoPtr_ENEMY_LAYER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_BulletTeam.NativeFieldInfoPtr_ENEMY_LAYER, (void*)(&value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x000C8EF8 File Offset: 0x000C70F8
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00008A9F File Offset: 0x00006C9F
		public unsafe AudioClip spawnSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeam.NativeFieldInfoPtr_spawnSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeam.NativeFieldInfoPtr_spawnSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x000C8F28 File Offset: 0x000C7128
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x00008ABE File Offset: 0x00006CBE
		public unsafe AudioClip hitSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeam.NativeFieldInfoPtr_hitSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeam.NativeFieldInfoPtr_hitSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x000C8F58 File Offset: 0x000C7158
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00008ADD File Offset: 0x00006CDD
		public unsafe Collider2D collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeam.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeam.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x000C8F88 File Offset: 0x000C7188
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00008AFC File Offset: 0x00006CFC
		public unsafe DLC4_GuardController Shooter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeam.NativeFieldInfoPtr_Shooter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeam.NativeFieldInfoPtr_Shooter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeFieldInfoPtr_ENEMY_LAYER;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeFieldInfoPtr_spawnSfx;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeFieldInfoPtr_hitSfx;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeFieldInfoPtr_Shooter;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_get_BulletShooterType_Public_Virtual_get_BulletType_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DLC4_GuardController_TeamBulletProperty_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_StunEnemy_Protected_Void_DLC4_FlandreEnemyCharacterController_Single_byref_Action_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_DecelerationEnemy_Protected_Void_DLC4_FlandreEnemyCharacterController_Single_Single_Boolean_BulletTypeIndex_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_DecelerationEnemyEnvironment_Protected_Void_DLC4_FlandreEnemyCharacterController_Single_Single_Boolean_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_PoisonEnemy_Protected_Void_DLC4_FlandreEnemyCharacterController_Int32_Single_BulletTypeIndex_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Virtual_New_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_AfterHitEnemy_Protected_Virtual_New_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_PlaySpawnSFX_Protected_Void_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_PlayHitSFX_Protected_Void_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
