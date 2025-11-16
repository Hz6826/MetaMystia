using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200009D RID: 157
	public class DLC4_GuardAya : DLC4_GuardController
	{
		// Token: 0x06000FFC RID: 4092 RVA: 0x000D4730 File Offset: 0x000D2930
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_GuardAya()
		{
			Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_GuardAya");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr);
			DLC4_GuardAya.NativeFieldInfoPtr_m_Level1Bullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, "m_Level1Bullet");
			DLC4_GuardAya.NativeFieldInfoPtr_m_Level2Bullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, "m_Level2Bullet");
			DLC4_GuardAya.NativeFieldInfoPtr_m_UltimateSkillBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, "m_UltimateSkillBullet");
			DLC4_GuardAya.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, 100666118);
			DLC4_GuardAya.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, 100666119);
			DLC4_GuardAya.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, 100666120);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x000D47D8 File Offset: 0x000D29D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48788, XrefRangeEnd = 48803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NormalAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardAya.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x000D4814 File Offset: 0x000D2A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48803, XrefRangeEnd = 48808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator SkillAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardAya.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000D4860 File Offset: 0x000D2A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48808, XrefRangeEnd = 48809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_GuardAya() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0000A424 File Offset: 0x00008624
		public DLC4_GuardAya(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x000D489C File Offset: 0x000D2A9C
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x0000A42D File Offset: 0x0000862D
		public DLC4_GuardAya.AyaBullet m_Level1Bullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.NativeFieldInfoPtr_m_Level1Bullet);
				return new DLC4_GuardAya.AyaBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.NativeFieldInfoPtr_m_Level1Bullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x000D48CC File Offset: 0x000D2ACC
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x0000A45B File Offset: 0x0000865B
		public DLC4_GuardAya.AyaBullet m_Level2Bullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.NativeFieldInfoPtr_m_Level2Bullet);
				return new DLC4_GuardAya.AyaBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.NativeFieldInfoPtr_m_Level2Bullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x000D48FC File Offset: 0x000D2AFC
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x0000A489 File Offset: 0x00008689
		public DLC4_GuardController.TeamBulletProperty m_UltimateSkillBullet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.NativeFieldInfoPtr_m_UltimateSkillBullet);
				return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.NativeFieldInfoPtr_m_UltimateSkillBullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeFieldInfoPtr_m_Level1Bullet;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeFieldInfoPtr_m_Level2Bullet;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeFieldInfoPtr_m_UltimateSkillBullet;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000585 RID: 1413
		[Serializable]
		public sealed class AyaBullet : ValueType
		{
			// Token: 0x06008A71 RID: 35441 RVA: 0x00263DBC File Offset: 0x00261FBC
			// Note: this type is marked as 'beforefieldinit'.
			static AyaBullet()
			{
				Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, "AyaBullet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr);
				DLC4_GuardAya.AyaBullet.NativeFieldInfoPtr_m_BaseBulletProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr, "m_BaseBulletProperty");
				DLC4_GuardAya.AyaBullet.NativeFieldInfoPtr_m_AyaBulletProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr, "m_AyaBulletProperty");
			}

			// Token: 0x06008A72 RID: 35442 RVA: 0x0004A699 File Offset: 0x00048899
			public AyaBullet(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008A73 RID: 35443 RVA: 0x0004A6A2 File Offset: 0x000488A2
			public AyaBullet() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr))
			{
			}

			// Token: 0x17002E66 RID: 11878
			// (get) Token: 0x06008A74 RID: 35444 RVA: 0x00263E10 File Offset: 0x00262010
			// (set) Token: 0x06008A75 RID: 35445 RVA: 0x0004A6B4 File Offset: 0x000488B4
			public DLC4_GuardController.TeamBulletProperty m_BaseBulletProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.AyaBullet.NativeFieldInfoPtr_m_BaseBulletProperty);
					return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.AyaBullet.NativeFieldInfoPtr_m_BaseBulletProperty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002E67 RID: 11879
			// (get) Token: 0x06008A76 RID: 35446 RVA: 0x00263E40 File Offset: 0x00262040
			// (set) Token: 0x06008A77 RID: 35447 RVA: 0x0004A6E2 File Offset: 0x000488E2
			public unsafe DLC4_GuardAya.AyaBulletProperty m_AyaBulletProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.AyaBullet.NativeFieldInfoPtr_m_AyaBulletProperty);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.AyaBullet.NativeFieldInfoPtr_m_AyaBulletProperty)) = value;
				}
			}

			// Token: 0x04005AAD RID: 23213
			private static readonly IntPtr NativeFieldInfoPtr_m_BaseBulletProperty;

			// Token: 0x04005AAE RID: 23214
			private static readonly IntPtr NativeFieldInfoPtr_m_AyaBulletProperty;
		}

		// Token: 0x02000586 RID: 1414
		[Serializable]
		[StructLayout(2)]
		public struct AyaBulletProperty
		{
			// Token: 0x06008A78 RID: 35448 RVA: 0x00263E68 File Offset: 0x00262068
			// Note: this type is marked as 'beforefieldinit'.
			static AyaBulletProperty()
			{
				Il2CppClassPointerStore<DLC4_GuardAya.AyaBulletProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, "AyaBulletProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardAya.AyaBulletProperty>.NativeClassPtr);
				DLC4_GuardAya.AyaBulletProperty.NativeFieldInfoPtr_m_FrozenMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya.AyaBulletProperty>.NativeClassPtr, "m_FrozenMultiplier");
				DLC4_GuardAya.AyaBulletProperty.NativeFieldInfoPtr_m_FrozenDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya.AyaBulletProperty>.NativeClassPtr, "m_FrozenDuration");
				DLC4_GuardAya.AyaBulletProperty.NativeFieldInfoPtr_m_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya.AyaBulletProperty>.NativeClassPtr, "m_Radius");
			}

			// Token: 0x06008A79 RID: 35449 RVA: 0x0004A6FD File Offset: 0x000488FD
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardAya.AyaBulletProperty>.NativeClassPtr, ref this));
			}

			// Token: 0x04005AAF RID: 23215
			private static readonly IntPtr NativeFieldInfoPtr_m_FrozenMultiplier;

			// Token: 0x04005AB0 RID: 23216
			private static readonly IntPtr NativeFieldInfoPtr_m_FrozenDuration;

			// Token: 0x04005AB1 RID: 23217
			private static readonly IntPtr NativeFieldInfoPtr_m_Radius;

			// Token: 0x04005AB2 RID: 23218
			[FieldOffset(0)]
			public float m_FrozenMultiplier;

			// Token: 0x04005AB3 RID: 23219
			[FieldOffset(4)]
			public int m_FrozenDuration;

			// Token: 0x04005AB4 RID: 23220
			[FieldOffset(8)]
			public float m_Radius;
		}

		// Token: 0x02000587 RID: 1415
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardAya+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06008A7A RID: 35450 RVA: 0x00263ED0 File Offset: 0x002620D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DLC4_GuardAya.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardAya.__c__DisplayClass3_0>.NativeClassPtr);
				DLC4_GuardAya.__c__DisplayClass3_0.NativeFieldInfoPtr_shootBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya.__c__DisplayClass3_0>.NativeClassPtr, "shootBullet");
				DLC4_GuardAya.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya.__c__DisplayClass3_0>.NativeClassPtr, 100666121);
				DLC4_GuardAya.__c__DisplayClass3_0.NativeMethodInfoPtr__NormalAttack_b__0_Internal_Void_DLC4_BulletAyaWind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya.__c__DisplayClass3_0>.NativeClassPtr, 100666122);
			}

			// Token: 0x06008A7B RID: 35451 RVA: 0x00263F38 File Offset: 0x00262138
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardAya.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A7C RID: 35452 RVA: 0x00263F74 File Offset: 0x00262174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48759, XrefRangeEnd = 48761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NormalAttack_b__0(DLC4_BulletAyaWind x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya.__c__DisplayClass3_0.NativeMethodInfoPtr__NormalAttack_b__0_Internal_Void_DLC4_BulletAyaWind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A7D RID: 35453 RVA: 0x0004A70F File Offset: 0x0004890F
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E68 RID: 11880
			// (get) Token: 0x06008A7E RID: 35454 RVA: 0x00263FB8 File Offset: 0x002621B8
			// (set) Token: 0x06008A7F RID: 35455 RVA: 0x0004A718 File Offset: 0x00048918
			public DLC4_GuardAya.AyaBullet shootBullet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.__c__DisplayClass3_0.NativeFieldInfoPtr_shootBullet);
					return new DLC4_GuardAya.AyaBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya.__c__DisplayClass3_0.NativeFieldInfoPtr_shootBullet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardAya.AyaBullet>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005AB5 RID: 23221
			private static readonly IntPtr NativeFieldInfoPtr_shootBullet;

			// Token: 0x04005AB6 RID: 23222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005AB7 RID: 23223
			private static readonly IntPtr NativeMethodInfoPtr__NormalAttack_b__0_Internal_Void_DLC4_BulletAyaWind_0;
		}

		// Token: 0x02000588 RID: 1416
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardAya+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06008A80 RID: 35456 RVA: 0x00263FE8 File Offset: 0x002621E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_GuardAya.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardAya.__c>.NativeClassPtr);
				DLC4_GuardAya.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya.__c>.NativeClassPtr, "<>9");
				DLC4_GuardAya.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya.__c>.NativeClassPtr, "<>9__4_0");
				DLC4_GuardAya.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya.__c>.NativeClassPtr, 100666124);
				DLC4_GuardAya.__c.NativeMethodInfoPtr__SkillAttack_b__4_0_Internal_Void_DLC4_BulletAyaTornado_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya.__c>.NativeClassPtr, 100666125);
			}

			// Token: 0x06008A81 RID: 35457 RVA: 0x00264064 File Offset: 0x00262264
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardAya.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A82 RID: 35458 RVA: 0x002640A0 File Offset: 0x002622A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48761, XrefRangeEnd = 48763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SkillAttack_b__4_0(DLC4_BulletAyaTornado x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya.__c.NativeMethodInfoPtr__SkillAttack_b__4_0_Internal_Void_DLC4_BulletAyaTornado_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A83 RID: 35459 RVA: 0x0004A746 File Offset: 0x00048946
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E69 RID: 11881
			// (get) Token: 0x06008A84 RID: 35460 RVA: 0x002640E4 File Offset: 0x002622E4
			// (set) Token: 0x06008A85 RID: 35461 RVA: 0x0004A74F File Offset: 0x0004894F
			public unsafe static DLC4_GuardAya.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardAya.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardAya.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardAya.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E6A RID: 11882
			// (get) Token: 0x06008A86 RID: 35462 RVA: 0x0026410C File Offset: 0x0026230C
			// (set) Token: 0x06008A87 RID: 35463 RVA: 0x0004A761 File Offset: 0x00048961
			public unsafe static Action<DLC4_BulletAyaTornado> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_GuardAya.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DLC4_BulletAyaTornado>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_GuardAya.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005AB8 RID: 23224
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005AB9 RID: 23225
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04005ABA RID: 23226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005ABB RID: 23227
			private static readonly IntPtr NativeMethodInfoPtr__SkillAttack_b__4_0_Internal_Void_DLC4_BulletAyaTornado_0;
		}

		// Token: 0x02000589 RID: 1417
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardAya+<SkillAttack>d__4")]
		public sealed class _SkillAttack_d__4 : Object
		{
			// Token: 0x06008A88 RID: 35464 RVA: 0x00264134 File Offset: 0x00262334
			// Note: this type is marked as 'beforefieldinit'.
			static _SkillAttack_d__4()
			{
				Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardAya>.NativeClassPtr, "<SkillAttack>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr);
				DLC4_GuardAya._SkillAttack_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr, "<>1__state");
				DLC4_GuardAya._SkillAttack_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr, "<>2__current");
				DLC4_GuardAya._SkillAttack_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr, "<>4__this");
				DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr, 100666126);
				DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr, 100666127);
				DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr, 100666128);
				DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr, 100666129);
				DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr, 100666130);
				DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr, 100666131);
			}

			// Token: 0x06008A89 RID: 35465 RVA: 0x00264214 File Offset: 0x00262414
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SkillAttack_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardAya._SkillAttack_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A8A RID: 35466 RVA: 0x0026425C File Offset: 0x0026245C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A8B RID: 35467 RVA: 0x00264290 File Offset: 0x00262490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48763, XrefRangeEnd = 48782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E6E RID: 11886
			// (get) Token: 0x06008A8C RID: 35468 RVA: 0x002642CC File Offset: 0x002624CC
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008A8D RID: 35469 RVA: 0x0026430C File Offset: 0x0026250C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48782, XrefRangeEnd = 48788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E6F RID: 11887
			// (get) Token: 0x06008A8E RID: 35470 RVA: 0x00264340 File Offset: 0x00262540
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardAya._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008A8F RID: 35471 RVA: 0x0004A773 File Offset: 0x00048973
			public _SkillAttack_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E6B RID: 11883
			// (get) Token: 0x06008A90 RID: 35472 RVA: 0x00264380 File Offset: 0x00262580
			// (set) Token: 0x06008A91 RID: 35473 RVA: 0x0004A77C File Offset: 0x0004897C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya._SkillAttack_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya._SkillAttack_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E6C RID: 11884
			// (get) Token: 0x06008A92 RID: 35474 RVA: 0x002643A8 File Offset: 0x002625A8
			// (set) Token: 0x06008A93 RID: 35475 RVA: 0x0004A797 File Offset: 0x00048997
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya._SkillAttack_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya._SkillAttack_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E6D RID: 11885
			// (get) Token: 0x06008A94 RID: 35476 RVA: 0x002643D8 File Offset: 0x002625D8
			// (set) Token: 0x06008A95 RID: 35477 RVA: 0x0004A7B6 File Offset: 0x000489B6
			public unsafe DLC4_GuardAya __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya._SkillAttack_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_GuardAya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardAya._SkillAttack_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005ABC RID: 23228
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005ABD RID: 23229
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005ABE RID: 23230
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005ABF RID: 23231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005AC0 RID: 23232
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005AC1 RID: 23233
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005AC2 RID: 23234
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005AC3 RID: 23235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005AC4 RID: 23236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
