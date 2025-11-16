using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000080 RID: 128
	public class DLC4_BulletYukaSpark : DLC4_BulletTeam
	{
		// Token: 0x06000D40 RID: 3392 RVA: 0x000CAAA8 File Offset: 0x000C8CA8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletYukaSpark()
		{
			Il2CppClassPointerStore<DLC4_BulletYukaSpark>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletYukaSpark");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletYukaSpark>.NativeClassPtr);
			DLC4_BulletYukaSpark.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletYukaSpark>.NativeClassPtr, "m_Collider");
			DLC4_BulletYukaSpark.NativeFieldInfoPtr__StunDuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletYukaSpark>.NativeClassPtr, "<StunDuration>k__BackingField");
			DLC4_BulletYukaSpark.NativeMethodInfoPtr_get_StunDuration_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletYukaSpark>.NativeClassPtr, 100665542);
			DLC4_BulletYukaSpark.NativeMethodInfoPtr_set_StunDuration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletYukaSpark>.NativeClassPtr, 100665543);
			DLC4_BulletYukaSpark.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletYukaSpark>.NativeClassPtr, 100665544);
			DLC4_BulletYukaSpark.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletYukaSpark>.NativeClassPtr, 100665545);
			DLC4_BulletYukaSpark.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletYukaSpark>.NativeClassPtr, 100665546);
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x000CAB64 File Offset: 0x000C8D64
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x000CABA0 File Offset: 0x000C8DA0
		public unsafe float StunDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletYukaSpark.NativeMethodInfoPtr_get_StunDuration_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletYukaSpark.NativeMethodInfoPtr_set_StunDuration_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x000CABE0 File Offset: 0x000C8DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44143, XrefRangeEnd = 44145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletYukaSpark.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x000CAC30 File Offset: 0x000C8E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44145, XrefRangeEnd = 44147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletYukaSpark.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x000CAC6C File Offset: 0x000C8E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletYukaSpark() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletYukaSpark>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletYukaSpark.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00008E8C File Offset: 0x0000708C
		public DLC4_BulletYukaSpark(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x000CACA8 File Offset: 0x000C8EA8
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x00008E95 File Offset: 0x00007095
		public unsafe Collider2D m_Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletYukaSpark.NativeFieldInfoPtr_m_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletYukaSpark.NativeFieldInfoPtr_m_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x000CACD8 File Offset: 0x000C8ED8
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00008EB4 File Offset: 0x000070B4
		public unsafe float _StunDuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletYukaSpark.NativeFieldInfoPtr__StunDuration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletYukaSpark.NativeFieldInfoPtr__StunDuration_k__BackingField)) = value;
			}
		}

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr__StunDuration_k__BackingField;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_get_StunDuration_Private_get_Single_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_set_StunDuration_Public_set_Void_Single_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
