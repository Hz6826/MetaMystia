using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000074 RID: 116
	public class DLC4_BulletAyaWind : DLC4_BulletTeamLinear
	{
		// Token: 0x06000C69 RID: 3177 RVA: 0x000C7A80 File Offset: 0x000C5C80
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletAyaWind()
		{
			Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletAyaWind");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr);
			DLC4_BulletAyaWind.NativeFieldInfoPtr_particleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr, "particleSystem");
			DLC4_BulletAyaWind.NativeFieldInfoPtr__AyaBulletProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr, "<AyaBulletProperty>k__BackingField");
			DLC4_BulletAyaWind.NativeMethodInfoPtr_get_AyaBulletProperty_Private_get_AyaBulletProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr, 100665410);
			DLC4_BulletAyaWind.NativeMethodInfoPtr_set_AyaBulletProperty_Public_set_Void_AyaBulletProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr, 100665411);
			DLC4_BulletAyaWind.NativeMethodInfoPtr_OnBulletEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr, 100665412);
			DLC4_BulletAyaWind.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr, 100665413);
			DLC4_BulletAyaWind.NativeMethodInfoPtr_AfterHit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr, 100665414);
			DLC4_BulletAyaWind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr, 100665415);
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000C7B50 File Offset: 0x000C5D50
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x000C7B8C File Offset: 0x000C5D8C
		public unsafe DLC4_GuardAya.AyaBulletProperty AyaBulletProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaWind.NativeMethodInfoPtr_get_AyaBulletProperty_Private_get_AyaBulletProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaWind.NativeMethodInfoPtr_set_AyaBulletProperty_Public_set_Void_AyaBulletProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000C7BCC File Offset: 0x000C5DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43441, RefRangeEnd = 43442, XrefRangeStart = 43425, XrefRangeEnd = 43441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBulletEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaWind.NativeMethodInfoPtr_OnBulletEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000C7C00 File Offset: 0x000C5E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43442, XrefRangeEnd = 43477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletAyaWind.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x000C7C50 File Offset: 0x000C5E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43477, XrefRangeEnd = 43489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AfterHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaWind.NativeMethodInfoPtr_AfterHit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000C7C84 File Offset: 0x000C5E84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletAyaWind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaWind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x000088CC File Offset: 0x00006ACC
		public DLC4_BulletAyaWind(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x000C7CC0 File Offset: 0x000C5EC0
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x000088D5 File Offset: 0x00006AD5
		public unsafe ParticleSystem particleSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaWind.NativeFieldInfoPtr_particleSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaWind.NativeFieldInfoPtr_particleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000C7CF0 File Offset: 0x000C5EF0
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x000088F4 File Offset: 0x00006AF4
		public unsafe DLC4_GuardAya.AyaBulletProperty _AyaBulletProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaWind.NativeFieldInfoPtr__AyaBulletProperty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaWind.NativeFieldInfoPtr__AyaBulletProperty_k__BackingField)) = value;
			}
		}

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeFieldInfoPtr_particleSystem;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeFieldInfoPtr__AyaBulletProperty_k__BackingField;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_get_AyaBulletProperty_Private_get_AyaBulletProperty_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_set_AyaBulletProperty_Public_set_Void_AyaBulletProperty_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_OnBulletEnable_Public_Void_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_AfterHit_Private_Void_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000542 RID: 1346
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_BulletAyaWind+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x060086EB RID: 34539 RVA: 0x002597A4 File Offset: 0x002579A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DLC4_BulletAyaWind.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BulletAyaWind>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletAyaWind.__c__DisplayClass6_0>.NativeClassPtr);
				DLC4_BulletAyaWind.__c__DisplayClass6_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaWind.__c__DisplayClass6_0>.NativeClassPtr, "position");
				DLC4_BulletAyaWind.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletAyaWind.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				DLC4_BulletAyaWind.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaWind.__c__DisplayClass6_0>.NativeClassPtr, 100665416);
				DLC4_BulletAyaWind.__c__DisplayClass6_0.NativeMethodInfoPtr__OnHit_b__0_Internal_Boolean_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletAyaWind.__c__DisplayClass6_0>.NativeClassPtr, 100665417);
			}

			// Token: 0x060086EC RID: 34540 RVA: 0x00259820 File Offset: 0x00257A20
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletAyaWind.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaWind.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060086ED RID: 34541 RVA: 0x0025985C File Offset: 0x00257A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43424, XrefRangeEnd = 43425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnHit_b__0(DLC4_FlandreEnemyCharacterController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletAyaWind.__c__DisplayClass6_0.NativeMethodInfoPtr__OnHit_b__0_Internal_Boolean_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060086EE RID: 34542 RVA: 0x00048981 File Offset: 0x00046B81
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D41 RID: 11585
			// (get) Token: 0x060086EF RID: 34543 RVA: 0x002598AC File Offset: 0x00257AAC
			// (set) Token: 0x060086F0 RID: 34544 RVA: 0x0004898A File Offset: 0x00046B8A
			public unsafe Vector2 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaWind.__c__DisplayClass6_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaWind.__c__DisplayClass6_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17002D42 RID: 11586
			// (get) Token: 0x060086F1 RID: 34545 RVA: 0x002598D4 File Offset: 0x00257AD4
			// (set) Token: 0x060086F2 RID: 34546 RVA: 0x000489A5 File Offset: 0x00046BA5
			public unsafe DLC4_BulletAyaWind __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaWind.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BulletAyaWind>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletAyaWind.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005887 RID: 22663
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04005888 RID: 22664
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005889 RID: 22665
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400588A RID: 22666
			private static readonly IntPtr NativeMethodInfoPtr__OnHit_b__0_Internal_Boolean_DLC4_FlandreEnemyCharacterController_0;
		}
	}
}
