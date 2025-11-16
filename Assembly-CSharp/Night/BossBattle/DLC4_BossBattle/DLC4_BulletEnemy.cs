using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000076 RID: 118
	public class DLC4_BulletEnemy : DLC4_BulletBase
	{
		// Token: 0x06000C9A RID: 3226 RVA: 0x000C8518 File Offset: 0x000C6718
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletEnemy()
		{
			Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletEnemy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr);
			DLC4_BulletEnemy.NativeFieldInfoPtr_hitSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, "hitSfx");
			DLC4_BulletEnemy.NativeFieldInfoPtr_CurrentLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, "CurrentLine");
			DLC4_BulletEnemy.NativeFieldInfoPtr_Shooter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, "Shooter");
			DLC4_BulletEnemy.NativeMethodInfoPtr_get_BulletShooterType_Public_Virtual_get_BulletType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, 100665441);
			DLC4_BulletEnemy.NativeMethodInfoPtr_Initialize_Public_Void_DLC4_FlandreEnemyCharacterController_FlandreBullet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, 100665442);
			DLC4_BulletEnemy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, 100665443);
			DLC4_BulletEnemy.NativeMethodInfoPtr_OnExtraUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, 100665444);
			DLC4_BulletEnemy.NativeMethodInfoPtr_OnHit_Protected_Virtual_New_Void_DLC4_GuardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, 100665445);
			DLC4_BulletEnemy.NativeMethodInfoPtr_PlayHitSfx_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, 100665446);
			DLC4_BulletEnemy.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, 100665447);
			DLC4_BulletEnemy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr, 100665448);
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x000C8624 File Offset: 0x000C6824
		public unsafe override DLC4_BulletBase.BulletType BulletShooterType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletEnemy.NativeMethodInfoPtr_get_BulletShooterType_Public_Virtual_get_BulletType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000C866C File Offset: 0x000C686C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43563, RefRangeEnd = 43564, XrefRangeStart = 43560, XrefRangeEnd = 43563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DLC4_FlandreEnemyCharacterController shooter, DLC4_FlandreEnemyCharacterController.FlandreBullet bullet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shooter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bullet));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletEnemy.NativeMethodInfoPtr_Initialize_Public_Void_DLC4_FlandreEnemyCharacterController_FlandreBullet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000C86C8 File Offset: 0x000C68C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43564, XrefRangeEnd = 43565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletEnemy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x000C8704 File Offset: 0x000C6904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43565, XrefRangeEnd = 43592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnExtraUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletEnemy.NativeMethodInfoPtr_OnExtraUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x000C8740 File Offset: 0x000C6940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43592, XrefRangeEnd = 43600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnHit(DLC4_GuardController guard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletEnemy.NativeMethodInfoPtr_OnHit_Protected_Virtual_New_Void_DLC4_GuardController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000C8790 File Offset: 0x000C6990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43600, XrefRangeEnd = 43605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayHitSfx()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletEnemy.NativeMethodInfoPtr_PlayHitSfx_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000C87C4 File Offset: 0x000C69C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43605, XrefRangeEnd = 43609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletEnemy.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000C8800 File Offset: 0x000C6A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletEnemy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletEnemy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletEnemy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00008A26 File Offset: 0x00006C26
		public DLC4_BulletEnemy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x000C883C File Offset: 0x000C6A3C
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x00008A2F File Offset: 0x00006C2F
		public unsafe AudioClip hitSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletEnemy.NativeFieldInfoPtr_hitSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletEnemy.NativeFieldInfoPtr_hitSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x000C886C File Offset: 0x000C6A6C
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x00008A4E File Offset: 0x00006C4E
		public unsafe int CurrentLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletEnemy.NativeFieldInfoPtr_CurrentLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletEnemy.NativeFieldInfoPtr_CurrentLine)) = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000C8894 File Offset: 0x000C6A94
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00008A69 File Offset: 0x00006C69
		public unsafe DLC4_FlandreEnemyCharacterController Shooter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletEnemy.NativeFieldInfoPtr_Shooter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletEnemy.NativeFieldInfoPtr_Shooter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_hitSfx;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr_CurrentLine;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeFieldInfoPtr_Shooter;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_get_BulletShooterType_Public_Virtual_get_BulletType_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DLC4_FlandreEnemyCharacterController_FlandreBullet_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_OnExtraUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Virtual_New_Void_DLC4_GuardController_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_PlayHitSfx_Protected_Void_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
