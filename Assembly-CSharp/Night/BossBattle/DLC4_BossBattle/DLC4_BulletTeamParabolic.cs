using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000079 RID: 121
	public class DLC4_BulletTeamParabolic : DLC4_BulletTeam
	{
		// Token: 0x06000CCB RID: 3275 RVA: 0x000C911C File Offset: 0x000C731C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletTeamParabolic()
		{
			Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletTeamParabolic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr);
			DLC4_BulletTeamParabolic.NativeFieldInfoPtr_AvailableLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, "AvailableLine");
			DLC4_BulletTeamParabolic.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, "launchHeight");
			DLC4_BulletTeamParabolic.NativeFieldInfoPtr_lerpCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, "lerpCoroutine");
			DLC4_BulletTeamParabolic.NativeFieldInfoPtr_TargetEnemyPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, "TargetEnemyPosition");
			DLC4_BulletTeamParabolic.NativeMethodInfoPtr_OnParabolicBulletEnable_Public_Void_Single_Vector2_Nullable_1_Int32_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, 100665466);
			DLC4_BulletTeamParabolic.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, 100665467);
			DLC4_BulletTeamParabolic.NativeMethodInfoPtr_LerpParabolic_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, 100665468);
			DLC4_BulletTeamParabolic.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, 100665469);
			DLC4_BulletTeamParabolic.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, 100665470);
			DLC4_BulletTeamParabolic.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, 100665471);
			DLC4_BulletTeamParabolic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, 100665472);
			DLC4_BulletTeamParabolic.NativeMethodInfoPtr_Method_Private_Vector3_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, 100665473);
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x000C923C File Offset: 0x000C743C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 43848, RefRangeEnd = 43853, XrefRangeStart = 43839, XrefRangeEnd = 43848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParabolicBulletEnable(float launchHeight, Vector2 targetPosition, Nullable<int> availableLine, bool modifyAngle = false, float extraDamageMultiplier = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref launchHeight;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(availableLine));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifyAngle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraDamageMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamParabolic.NativeMethodInfoPtr_OnParabolicBulletEnable_Public_Void_Single_Vector2_Nullable_1_Int32_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000C92BC File Offset: 0x000C74BC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeamParabolic.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x000C92F8 File Offset: 0x000C74F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43853, XrefRangeEnd = 43858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpParabolic(bool rotate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamParabolic.NativeMethodInfoPtr_LerpParabolic_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x000C9344 File Offset: 0x000C7544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43858, XrefRangeEnd = 43864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeamParabolic.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000C9394 File Offset: 0x000C7594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43864, XrefRangeEnd = 43866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeamParabolic.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x000C93D0 File Offset: 0x000C75D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43868, RefRangeEnd = 43869, XrefRangeStart = 43866, XrefRangeEnd = 43868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeamParabolic.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000C940C File Offset: 0x000C760C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletTeamParabolic() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamParabolic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000C9448 File Offset: 0x000C7648
		[CallerCount(0)]
		public unsafe Vector3 Method_Private_Vector3_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamParabolic.NativeMethodInfoPtr_Method_Private_Vector3_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00008B52 File Offset: 0x00006D52
		public DLC4_BulletTeamParabolic(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000C9484 File Offset: 0x000C7684
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00008B5B File Offset: 0x00006D5B
		public Nullable<int> AvailableLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic.NativeFieldInfoPtr_AvailableLine);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic.NativeFieldInfoPtr_AvailableLine), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x000C94B4 File Offset: 0x000C76B4
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x00008B89 File Offset: 0x00006D89
		public unsafe float launchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic.NativeFieldInfoPtr_launchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic.NativeFieldInfoPtr_launchHeight)) = value;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x000C94DC File Offset: 0x000C76DC
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x00008BA4 File Offset: 0x00006DA4
		public unsafe Coroutine lerpCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic.NativeFieldInfoPtr_lerpCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic.NativeFieldInfoPtr_lerpCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000C950C File Offset: 0x000C770C
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00008BC3 File Offset: 0x00006DC3
		public unsafe Vector2 TargetEnemyPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic.NativeFieldInfoPtr_TargetEnemyPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic.NativeFieldInfoPtr_TargetEnemyPosition)) = value;
			}
		}

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeFieldInfoPtr_AvailableLine;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeFieldInfoPtr_launchHeight;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeFieldInfoPtr_lerpCoroutine;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeFieldInfoPtr_TargetEnemyPosition;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_OnParabolicBulletEnable_Public_Void_Single_Vector2_Nullable_1_Int32_Boolean_Single_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_LerpParabolic_Private_IEnumerator_Boolean_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Vector3_PDM_0;

		// Token: 0x02000545 RID: 1349
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_BulletTeamParabolic+<LerpParabolic>d__6")]
		public sealed class _LerpParabolic_d__6 : Il2CppSystem.Object
		{
			// Token: 0x06008703 RID: 34563 RVA: 0x00259C14 File Offset: 0x00257E14
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpParabolic_d__6()
			{
				Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BulletTeamParabolic>.NativeClassPtr, "<LerpParabolic>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr);
				DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr, "<>1__state");
				DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr, "<>2__current");
				DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr, "<>4__this");
				DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr_rotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr, "rotate");
				DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr, 100665474);
				DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr, 100665475);
				DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr, 100665476);
				DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr, 100665477);
				DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr, 100665478);
				DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr, 100665479);
			}

			// Token: 0x06008704 RID: 34564 RVA: 0x00259D08 File Offset: 0x00257F08
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpParabolic_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletTeamParabolic._LerpParabolic_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008705 RID: 34565 RVA: 0x00259D50 File Offset: 0x00257F50
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008706 RID: 34566 RVA: 0x00259D84 File Offset: 0x00257F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43821, XrefRangeEnd = 43833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002D4D RID: 11597
			// (get) Token: 0x06008707 RID: 34567 RVA: 0x00259DC0 File Offset: 0x00257FC0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008708 RID: 34568 RVA: 0x00259E00 File Offset: 0x00258000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43833, XrefRangeEnd = 43839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002D4E RID: 11598
			// (get) Token: 0x06008709 RID: 34569 RVA: 0x00259E34 File Offset: 0x00258034
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600870A RID: 34570 RVA: 0x00048A41 File Offset: 0x00046C41
			public _LerpParabolic_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D49 RID: 11593
			// (get) Token: 0x0600870B RID: 34571 RVA: 0x00259E74 File Offset: 0x00258074
			// (set) Token: 0x0600870C RID: 34572 RVA: 0x00048A4A File Offset: 0x00046C4A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002D4A RID: 11594
			// (get) Token: 0x0600870D RID: 34573 RVA: 0x00259E9C File Offset: 0x0025809C
			// (set) Token: 0x0600870E RID: 34574 RVA: 0x00048A65 File Offset: 0x00046C65
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D4B RID: 11595
			// (get) Token: 0x0600870F RID: 34575 RVA: 0x00259ECC File Offset: 0x002580CC
			// (set) Token: 0x06008710 RID: 34576 RVA: 0x00048A84 File Offset: 0x00046C84
			public unsafe DLC4_BulletTeamParabolic __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BulletTeamParabolic>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D4C RID: 11596
			// (get) Token: 0x06008711 RID: 34577 RVA: 0x00259EFC File Offset: 0x002580FC
			// (set) Token: 0x06008712 RID: 34578 RVA: 0x00048AA3 File Offset: 0x00046CA3
			public unsafe bool rotate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr_rotate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamParabolic._LerpParabolic_d__6.NativeFieldInfoPtr_rotate)) = value;
				}
			}

			// Token: 0x04005898 RID: 22680
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005899 RID: 22681
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400589A RID: 22682
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400589B RID: 22683
			private static readonly IntPtr NativeFieldInfoPtr_rotate;

			// Token: 0x0400589C RID: 22684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400589D RID: 22685
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400589E RID: 22686
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400589F RID: 22687
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040058A0 RID: 22688
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040058A1 RID: 22689
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
