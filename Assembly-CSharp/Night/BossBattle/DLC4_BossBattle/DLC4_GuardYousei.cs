using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000A5 RID: 165
	public class DLC4_GuardYousei : DLC4_GuardController
	{
		// Token: 0x06001171 RID: 4465 RVA: 0x000D92B4 File Offset: 0x000D74B4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_GuardYousei()
		{
			Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_GuardYousei");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr);
			DLC4_GuardYousei.NativeFieldInfoPtr_m_RecoverHealthPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr, "m_RecoverHealthPerSec");
			DLC4_GuardYousei.NativeFieldInfoPtr_m_BaseBulletProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr, "m_BaseBulletProperty");
			DLC4_GuardYousei.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr, 100666351);
			DLC4_GuardYousei.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr, 100666352);
			DLC4_GuardYousei.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr, 100666353);
			DLC4_GuardYousei.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr, 100666354);
			DLC4_GuardYousei.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr, 100666355);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x000D9370 File Offset: 0x000D7570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50336, XrefRangeEnd = 50339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NormalAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYousei.NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x000D93AC File Offset: 0x000D75AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50339, XrefRangeEnd = 50341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYousei.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000D93E8 File Offset: 0x000D75E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50341, XrefRangeEnd = 50345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator SkillAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYousei.NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x000D9434 File Offset: 0x000D7634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GuardYousei.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000D9470 File Offset: 0x000D7670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_GuardYousei() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYousei.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0000B233 File Offset: 0x00009433
		public DLC4_GuardYousei(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x000D94AC File Offset: 0x000D76AC
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x0000B23C File Offset: 0x0000943C
		public unsafe int m_RecoverHealthPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYousei.NativeFieldInfoPtr_m_RecoverHealthPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYousei.NativeFieldInfoPtr_m_RecoverHealthPerSec)) = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x000D94D4 File Offset: 0x000D76D4
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x0000B257 File Offset: 0x00009457
		public DLC4_GuardController.TeamBulletProperty m_BaseBulletProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYousei.NativeFieldInfoPtr_m_BaseBulletProperty);
				return new DLC4_GuardController.TeamBulletProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYousei.NativeFieldInfoPtr_m_BaseBulletProperty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardController.TeamBulletProperty>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeFieldInfoPtr_m_RecoverHealthPerSec;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseBulletProperty;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_NormalAttack_Protected_Virtual_Void_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_SkillAttack_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005AA RID: 1450
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_GuardYousei+<SkillAttack>d__4")]
		public sealed class _SkillAttack_d__4 : Object
		{
			// Token: 0x06008BA5 RID: 35749 RVA: 0x00267398 File Offset: 0x00265598
			// Note: this type is marked as 'beforefieldinit'.
			static _SkillAttack_d__4()
			{
				Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_GuardYousei>.NativeClassPtr, "<SkillAttack>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr);
				DLC4_GuardYousei._SkillAttack_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr, "<>1__state");
				DLC4_GuardYousei._SkillAttack_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr, "<>2__current");
				DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr, 100666356);
				DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr, 100666357);
				DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr, 100666358);
				DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr, 100666359);
				DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr, 100666360);
				DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr, 100666361);
			}

			// Token: 0x06008BA6 RID: 35750 RVA: 0x00267464 File Offset: 0x00265664
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SkillAttack_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GuardYousei._SkillAttack_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BA7 RID: 35751 RVA: 0x002674AC File Offset: 0x002656AC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BA8 RID: 35752 RVA: 0x002674E0 File Offset: 0x002656E0
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002EC3 RID: 11971
			// (get) Token: 0x06008BA9 RID: 35753 RVA: 0x0026751C File Offset: 0x0026571C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008BAA RID: 35754 RVA: 0x0026755C File Offset: 0x0026575C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50330, XrefRangeEnd = 50336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002EC4 RID: 11972
			// (get) Token: 0x06008BAB RID: 35755 RVA: 0x00267590 File Offset: 0x00265790
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GuardYousei._SkillAttack_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008BAC RID: 35756 RVA: 0x0004B0C4 File Offset: 0x000492C4
			public _SkillAttack_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EC1 RID: 11969
			// (get) Token: 0x06008BAD RID: 35757 RVA: 0x002675D0 File Offset: 0x002657D0
			// (set) Token: 0x06008BAE RID: 35758 RVA: 0x0004B0CD File Offset: 0x000492CD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYousei._SkillAttack_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYousei._SkillAttack_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002EC2 RID: 11970
			// (get) Token: 0x06008BAF RID: 35759 RVA: 0x002675F8 File Offset: 0x002657F8
			// (set) Token: 0x06008BB0 RID: 35760 RVA: 0x0004B0E8 File Offset: 0x000492E8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYousei._SkillAttack_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GuardYousei._SkillAttack_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005B71 RID: 23409
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005B72 RID: 23410
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005B73 RID: 23411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005B74 RID: 23412
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B75 RID: 23413
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005B76 RID: 23414
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005B77 RID: 23415
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005B78 RID: 23416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
