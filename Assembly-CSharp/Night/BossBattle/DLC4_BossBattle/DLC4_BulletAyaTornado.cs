using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000073 RID: 115
	public class DLC4_BulletAyaTornado : DLC4_BulletTeamLinear
	{
		// Token: 0x06000C55 RID: 3157 RVA: 0x000C7674 File Offset: 0x000C5874
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletAyaTornado()
		{
			Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletAyaTornado");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr);
			DLC4_BulletAyaTornado.NativeFieldInfoPtr_arrived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, "arrived");
			DLC4_BulletAyaTornado.NativeFieldInfoPtr_onWindDispose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, "onWindDispose");
			DLC4_BulletAyaTornado.NativeFieldInfoPtr_particleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, "particleSystem");
			DLC4_BulletAyaTornado.NativeFieldInfoPtr_waitCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, "waitCoroutine");
			DLC4_BulletAyaTornado.NativeFieldInfoPtr_windHitEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, "windHitEnemy");
			DLC4_BulletAyaTornado.NativeMethodInfoPtr_OnBulletEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, 100665396);
			DLC4_BulletAyaTornado.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, 100665397);
			DLC4_BulletAyaTornado.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, 100665398);
			DLC4_BulletAyaTornado.NativeMethodInfoPtr_WaitAndChangeSpeed_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, 100665399);
			DLC4_BulletAyaTornado.NativeMethodInfoPtr_AfterHit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, 100665400);
			DLC4_BulletAyaTornado.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, 100665401);
			DLC4_BulletAyaTornado.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, 100665402);
			DLC4_BulletAyaTornado.NativeMethodInfoPtr__OnUpdate_b__6_0_Private_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, 100665403);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x000C77A8 File Offset: 0x000C59A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43344, RefRangeEnd = 43345, XrefRangeStart = 43320, XrefRangeEnd = 43344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBulletEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado.NativeMethodInfoPtr_OnBulletEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000C77DC File Offset: 0x000C59DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43345, XrefRangeEnd = 43376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletAyaTornado.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000C7818 File Offset: 0x000C5A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43376, XrefRangeEnd = 43387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletAyaTornado.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x000C7868 File Offset: 0x000C5A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43387, XrefRangeEnd = 43392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitAndChangeSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado.NativeMethodInfoPtr_WaitAndChangeSpeed_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000C78A8 File Offset: 0x000C5AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43392, XrefRangeEnd = 43411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AfterHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado.NativeMethodInfoPtr_AfterHit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000C78DC File Offset: 0x000C5ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43411, XrefRangeEnd = 43416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletAyaTornado.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x000C7918 File Offset: 0x000C5B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43416, XrefRangeEnd = 43417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletAyaTornado() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x000C7954 File Offset: 0x000C5B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43418, XrefRangeEnd = 43424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnUpdate_b__6_0(DLC4_FlandreEnemyCharacterController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado.NativeMethodInfoPtr__OnUpdate_b__6_0_Private_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0000882C File Offset: 0x00006A2C
		public DLC4_BulletAyaTornado(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x000C7998 File Offset: 0x000C5B98
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00008835 File Offset: 0x00006A35
		public unsafe bool arrived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado.NativeFieldInfoPtr_arrived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado.NativeFieldInfoPtr_arrived)) = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000C79C0 File Offset: 0x000C5BC0
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00008850 File Offset: 0x00006A50
		public unsafe Action onWindDispose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado.NativeFieldInfoPtr_onWindDispose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado.NativeFieldInfoPtr_onWindDispose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x000C79F0 File Offset: 0x000C5BF0
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x0000886F File Offset: 0x00006A6F
		public unsafe ParticleSystem particleSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado.NativeFieldInfoPtr_particleSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado.NativeFieldInfoPtr_particleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x000C7A20 File Offset: 0x000C5C20
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x0000888E File Offset: 0x00006A8E
		public unsafe Coroutine waitCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado.NativeFieldInfoPtr_waitCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado.NativeFieldInfoPtr_waitCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x000C7A50 File Offset: 0x000C5C50
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x000088AD File Offset: 0x00006AAD
		public unsafe HashSet<DLC4_FlandreEnemyCharacterController> windHitEnemy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado.NativeFieldInfoPtr_windHitEnemy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<DLC4_FlandreEnemyCharacterController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado.NativeFieldInfoPtr_windHitEnemy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeFieldInfoPtr_arrived;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeFieldInfoPtr_onWindDispose;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeFieldInfoPtr_particleSystem;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeFieldInfoPtr_waitCoroutine;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeFieldInfoPtr_windHitEnemy;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_OnBulletEnable_Public_Void_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_WaitAndChangeSpeed_Private_IEnumerator_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_AfterHit_Private_Void_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__6_0_Private_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x02000541 RID: 1345
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_BulletAyaTornado+<WaitAndChangeSpeed>d__8")]
		public sealed class _WaitAndChangeSpeed_d__8 : Il2CppSystem.Object
		{
			// Token: 0x060086DB RID: 34523 RVA: 0x00259494 File Offset: 0x00257694
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitAndChangeSpeed_d__8()
			{
				Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BulletAyaTornado>.NativeClassPtr, "<WaitAndChangeSpeed>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr);
				DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr, "<>1__state");
				DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr, "<>2__current");
				DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr, "<>4__this");
				DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr__currentSpeed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr, "<currentSpeed>5__2");
				DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr, 100665404);
				DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr, 100665405);
				DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr, 100665406);
				DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr, 100665407);
				DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr, 100665408);
				DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr, 100665409);
			}

			// Token: 0x060086DC RID: 34524 RVA: 0x00259588 File Offset: 0x00257788
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitAndChangeSpeed_d__8(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060086DD RID: 34525 RVA: 0x002595D0 File Offset: 0x002577D0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060086DE RID: 34526 RVA: 0x00259604 File Offset: 0x00257804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43309, XrefRangeEnd = 43314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002D3F RID: 11583
			// (get) Token: 0x060086DF RID: 34527 RVA: 0x00259640 File Offset: 0x00257840
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060086E0 RID: 34528 RVA: 0x00259680 File Offset: 0x00257880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43314, XrefRangeEnd = 43320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002D40 RID: 11584
			// (get) Token: 0x060086E1 RID: 34529 RVA: 0x002596B4 File Offset: 0x002578B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060086E2 RID: 34530 RVA: 0x00048904 File Offset: 0x00046B04
			public _WaitAndChangeSpeed_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D3B RID: 11579
			// (get) Token: 0x060086E3 RID: 34531 RVA: 0x002596F4 File Offset: 0x002578F4
			// (set) Token: 0x060086E4 RID: 34532 RVA: 0x0004890D File Offset: 0x00046B0D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002D3C RID: 11580
			// (get) Token: 0x060086E5 RID: 34533 RVA: 0x0025971C File Offset: 0x0025791C
			// (set) Token: 0x060086E6 RID: 34534 RVA: 0x00048928 File Offset: 0x00046B28
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D3D RID: 11581
			// (get) Token: 0x060086E7 RID: 34535 RVA: 0x0025974C File Offset: 0x0025794C
			// (set) Token: 0x060086E8 RID: 34536 RVA: 0x00048947 File Offset: 0x00046B47
			public unsafe DLC4_BulletAyaTornado __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BulletAyaTornado>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D3E RID: 11582
			// (get) Token: 0x060086E9 RID: 34537 RVA: 0x0025977C File Offset: 0x0025797C
			// (set) Token: 0x060086EA RID: 34538 RVA: 0x00048966 File Offset: 0x00046B66
			public unsafe float _currentSpeed_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr__currentSpeed_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaTornado._WaitAndChangeSpeed_d__8.NativeFieldInfoPtr__currentSpeed_5__2)) = value;
				}
			}

			// Token: 0x0400587D RID: 22653
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400587E RID: 22654
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400587F RID: 22655
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005880 RID: 22656
			private static readonly IntPtr NativeFieldInfoPtr__currentSpeed_5__2;

			// Token: 0x04005881 RID: 22657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005882 RID: 22658
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005883 RID: 22659
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005884 RID: 22660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005885 RID: 22661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005886 RID: 22662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
