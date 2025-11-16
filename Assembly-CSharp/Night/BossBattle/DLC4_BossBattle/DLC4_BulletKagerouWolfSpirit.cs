using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200007B RID: 123
	public class DLC4_BulletKagerouWolfSpirit : DLC4_BulletTeamParabolic
	{
		// Token: 0x06000CE9 RID: 3305 RVA: 0x000C9768 File Offset: 0x000C7968
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletKagerouWolfSpirit()
		{
			Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletKagerouWolfSpirit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr);
			DLC4_BulletKagerouWolfSpirit.NativeFieldInfoPtr__ExplodeRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr, "<ExplodeRange>k__BackingField");
			DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr_get_ExplodeRange_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr, 100665484);
			DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr_set_ExplodeRange_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr, 100665485);
			DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr, 100665486);
			DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr, 100665487);
			DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr, 100665488);
			DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr, 100665489);
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x000C9824 File Offset: 0x000C7A24
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x000C9860 File Offset: 0x000C7A60
		public unsafe float ExplodeRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr_get_ExplodeRange_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr_set_ExplodeRange_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000C98A0 File Offset: 0x000C7AA0
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x000C98F0 File Offset: 0x000C7AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43903, XrefRangeEnd = 43931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000C992C File Offset: 0x000C7B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43868, RefRangeEnd = 43869, XrefRangeStart = 43868, XrefRangeEnd = 43869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000C9968 File Offset: 0x000C7B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletKagerouWolfSpirit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletKagerouWolfSpirit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00008C38 File Offset: 0x00006E38
		public DLC4_BulletKagerouWolfSpirit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x000C99A4 File Offset: 0x000C7BA4
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00008C41 File Offset: 0x00006E41
		public unsafe float _ExplodeRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletKagerouWolfSpirit.NativeFieldInfoPtr__ExplodeRange_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletKagerouWolfSpirit.NativeFieldInfoPtr__ExplodeRange_k__BackingField)) = value;
			}
		}

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr__ExplodeRange_k__BackingField;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_get_ExplodeRange_Private_get_Single_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_set_ExplodeRange_Public_set_Void_Single_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000546 RID: 1350
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_BulletKagerouWolfSpirit+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x06008713 RID: 34579 RVA: 0x00259F24 File Offset: 0x00258124
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0>.NativeClassPtr);
				DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0>.NativeClassPtr, "position");
				DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0>.NativeClassPtr, 100665490);
				DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeMethodInfoPtr__OnDispose_b__0_Internal_Boolean_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0>.NativeClassPtr, 100665491);
				DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeMethodInfoPtr__OnDispose_b__1_Internal_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0>.NativeClassPtr, 100665492);
			}

			// Token: 0x06008714 RID: 34580 RVA: 0x00259FB4 File Offset: 0x002581B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008715 RID: 34581 RVA: 0x00259FF0 File Offset: 0x002581F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43900, XrefRangeEnd = 43902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnDispose_b__0(DLC4_FlandreEnemyCharacterController enemy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeMethodInfoPtr__OnDispose_b__0_Internal_Boolean_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008716 RID: 34582 RVA: 0x0025A040 File Offset: 0x00258240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43902, XrefRangeEnd = 43903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnDispose_b__1(DLC4_FlandreEnemyCharacterController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeMethodInfoPtr__OnDispose_b__1_Internal_Void_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008717 RID: 34583 RVA: 0x00048ABE File Offset: 0x00046CBE
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D4F RID: 11599
			// (get) Token: 0x06008718 RID: 34584 RVA: 0x0025A084 File Offset: 0x00258284
			// (set) Token: 0x06008719 RID: 34585 RVA: 0x00048AC7 File Offset: 0x00046CC7
			public unsafe Vector2 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17002D50 RID: 11600
			// (get) Token: 0x0600871A RID: 34586 RVA: 0x0025A0AC File Offset: 0x002582AC
			// (set) Token: 0x0600871B RID: 34587 RVA: 0x00048AE2 File Offset: 0x00046CE2
			public unsafe DLC4_BulletKagerouWolfSpirit __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BulletKagerouWolfSpirit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletKagerouWolfSpirit.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040058A2 RID: 22690
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x040058A3 RID: 22691
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040058A4 RID: 22692
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040058A5 RID: 22693
			private static readonly IntPtr NativeMethodInfoPtr__OnDispose_b__0_Internal_Boolean_DLC4_FlandreEnemyCharacterController_0;

			// Token: 0x040058A6 RID: 22694
			private static readonly IntPtr NativeMethodInfoPtr__OnDispose_b__1_Internal_Void_DLC4_FlandreEnemyCharacterController_0;
		}
	}
}
