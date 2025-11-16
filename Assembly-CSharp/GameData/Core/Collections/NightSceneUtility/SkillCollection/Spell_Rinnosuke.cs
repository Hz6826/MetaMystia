using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200027F RID: 639
	public class Spell_Rinnosuke : SpellBase
	{
		// Token: 0x0600509B RID: 20635 RVA: 0x001B1430 File Offset: 0x001AF630
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Rinnosuke()
		{
			Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Rinnosuke");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr);
			Spell_Rinnosuke.NativeFieldInfoPtr_giveItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr, "giveItemId");
			Spell_Rinnosuke.NativeFieldInfoPtr_removeInfoAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr, "removeInfoAmount");
			Spell_Rinnosuke.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr, 100679515);
			Spell_Rinnosuke.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr, 100679516);
			Spell_Rinnosuke.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr, 100679517);
			Spell_Rinnosuke.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr, 100679518);
			Spell_Rinnosuke.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr, 100679519);
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x001B14EC File Offset: 0x001AF6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202977, XrefRangeEnd = 202979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Rinnosuke.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x001B1530 File Offset: 0x001AF730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202979, XrefRangeEnd = 202984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Rinnosuke.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600509E RID: 20638 RVA: 0x001B158C File Offset: 0x001AF78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202984, XrefRangeEnd = 202989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Rinnosuke.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x001B15E8 File Offset: 0x001AF7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202989, XrefRangeEnd = 202990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Rinnosuke() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x001B1624 File Offset: 0x001AF824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202990, XrefRangeEnd = 202998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Int32_PDM_0(int i)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x0002AB9A File Offset: 0x00028D9A
		public Spell_Rinnosuke(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x060050A2 RID: 20642 RVA: 0x001B1664 File Offset: 0x001AF864
		// (set) Token: 0x060050A3 RID: 20643 RVA: 0x0002ABA3 File Offset: 0x00028DA3
		public unsafe int giveItemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke.NativeFieldInfoPtr_giveItemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke.NativeFieldInfoPtr_giveItemId)) = value;
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x060050A4 RID: 20644 RVA: 0x001B168C File Offset: 0x001AF88C
		// (set) Token: 0x060050A5 RID: 20645 RVA: 0x0002ABBE File Offset: 0x00028DBE
		public unsafe int removeInfoAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke.NativeFieldInfoPtr_removeInfoAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke.NativeFieldInfoPtr_removeInfoAmount)) = value;
			}
		}

		// Token: 0x04003690 RID: 13968
		private static readonly IntPtr NativeFieldInfoPtr_giveItemId;

		// Token: 0x04003691 RID: 13969
		private static readonly IntPtr NativeFieldInfoPtr_removeInfoAmount;

		// Token: 0x04003692 RID: 13970
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003693 RID: 13971
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003694 RID: 13972
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003695 RID: 13973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003696 RID: 13974
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_PDM_0;

		// Token: 0x02000BAC RID: 2988
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rinnosuke+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600DAA2 RID: 55970 RVA: 0x003519C8 File Offset: 0x0034FBC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Rinnosuke.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rinnosuke.__c>.NativeClassPtr);
				Spell_Rinnosuke.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rinnosuke.__c>.NativeClassPtr, "<>9");
				Spell_Rinnosuke.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rinnosuke.__c>.NativeClassPtr, "<>9__3_0");
				Spell_Rinnosuke.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke.__c>.NativeClassPtr, 100679521);
				Spell_Rinnosuke.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke.__c>.NativeClassPtr, 100679522);
			}

			// Token: 0x0600DAA3 RID: 55971 RVA: 0x00351A44 File Offset: 0x0034FC44
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rinnosuke.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAA4 RID: 55972 RVA: 0x00351A80 File Offset: 0x0034FC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202913, XrefRangeEnd = 202921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnNegativeBuffExecute_b__3_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DAA5 RID: 55973 RVA: 0x00074E66 File Offset: 0x00073066
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004714 RID: 18196
			// (get) Token: 0x0600DAA6 RID: 55974 RVA: 0x00351ACC File Offset: 0x0034FCCC
			// (set) Token: 0x0600DAA7 RID: 55975 RVA: 0x00074E6F File Offset: 0x0007306F
			public unsafe static Spell_Rinnosuke.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Rinnosuke.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rinnosuke.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Rinnosuke.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004715 RID: 18197
			// (get) Token: 0x0600DAA8 RID: 55976 RVA: 0x00351AF4 File Offset: 0x0034FCF4
			// (set) Token: 0x0600DAA9 RID: 55977 RVA: 0x00074E81 File Offset: 0x00073081
			public unsafe static Func<int, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Rinnosuke.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Rinnosuke.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C17 RID: 35863
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008C18 RID: 35864
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04008C19 RID: 35865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C1A RID: 35866
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_0_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000BAD RID: 2989
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rinnosuke+<OnNegativeBuffExecute>d__3")]
		public sealed class _OnNegativeBuffExecute_d__3 : Object
		{
			// Token: 0x0600DAAA RID: 55978 RVA: 0x00351B1C File Offset: 0x0034FD1C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__3()
			{
				Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr, "<OnNegativeBuffExecute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr);
				Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr, "<>1__state");
				Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr, "<>2__current");
				Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr, "<>4__this");
				Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679523);
				Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679524);
				Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679525);
				Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679526);
				Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679527);
				Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679528);
			}

			// Token: 0x0600DAAB RID: 55979 RVA: 0x00351BFC File Offset: 0x0034FDFC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__3(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rinnosuke._OnNegativeBuffExecute_d__3>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAAC RID: 55980 RVA: 0x00351C44 File Offset: 0x0034FE44
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAAD RID: 55981 RVA: 0x00351C78 File Offset: 0x0034FE78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202921, XrefRangeEnd = 202960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004719 RID: 18201
			// (get) Token: 0x0600DAAE RID: 55982 RVA: 0x00351CB4 File Offset: 0x0034FEB4
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAAF RID: 55983 RVA: 0x00351CF4 File Offset: 0x0034FEF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202960, XrefRangeEnd = 202966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700471A RID: 18202
			// (get) Token: 0x0600DAB0 RID: 55984 RVA: 0x00351D28 File Offset: 0x0034FF28
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAB1 RID: 55985 RVA: 0x00074E93 File Offset: 0x00073093
			public _OnNegativeBuffExecute_d__3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004716 RID: 18198
			// (get) Token: 0x0600DAB2 RID: 55986 RVA: 0x00351D68 File Offset: 0x0034FF68
			// (set) Token: 0x0600DAB3 RID: 55987 RVA: 0x00074E9C File Offset: 0x0007309C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004717 RID: 18199
			// (get) Token: 0x0600DAB4 RID: 55988 RVA: 0x00351D90 File Offset: 0x0034FF90
			// (set) Token: 0x0600DAB5 RID: 55989 RVA: 0x00074EB7 File Offset: 0x000730B7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004718 RID: 18200
			// (get) Token: 0x0600DAB6 RID: 55990 RVA: 0x00351DC0 File Offset: 0x0034FFC0
			// (set) Token: 0x0600DAB7 RID: 55991 RVA: 0x00074ED6 File Offset: 0x000730D6
			public unsafe Spell_Rinnosuke __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rinnosuke>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C1B RID: 35867
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C1C RID: 35868
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C1D RID: 35869
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C1E RID: 35870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C1F RID: 35871
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C20 RID: 35872
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C21 RID: 35873
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C22 RID: 35874
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C23 RID: 35875
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BAE RID: 2990
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rinnosuke+<OnPositiveBuffExecute>d__4")]
		public sealed class _OnPositiveBuffExecute_d__4 : Object
		{
			// Token: 0x0600DAB8 RID: 55992 RVA: 0x00351DF0 File Offset: 0x0034FFF0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__4()
			{
				Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rinnosuke>.NativeClassPtr, "<OnPositiveBuffExecute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr);
				Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr, "<>1__state");
				Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr, "<>2__current");
				Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr, "<>4__this");
				Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679529);
				Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679530);
				Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679531);
				Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679532);
				Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679533);
				Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679534);
			}

			// Token: 0x0600DAB9 RID: 55993 RVA: 0x00351ED0 File Offset: 0x003500D0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rinnosuke._OnPositiveBuffExecute_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DABA RID: 55994 RVA: 0x00351F18 File Offset: 0x00350118
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DABB RID: 55995 RVA: 0x00351F4C File Offset: 0x0035014C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202966, XrefRangeEnd = 202971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700471E RID: 18206
			// (get) Token: 0x0600DABC RID: 55996 RVA: 0x00351F88 File Offset: 0x00350188
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DABD RID: 55997 RVA: 0x00351FC8 File Offset: 0x003501C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202971, XrefRangeEnd = 202977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700471F RID: 18207
			// (get) Token: 0x0600DABE RID: 55998 RVA: 0x00351FFC File Offset: 0x003501FC
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DABF RID: 55999 RVA: 0x00074EF5 File Offset: 0x000730F5
			public _OnPositiveBuffExecute_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700471B RID: 18203
			// (get) Token: 0x0600DAC0 RID: 56000 RVA: 0x0035203C File Offset: 0x0035023C
			// (set) Token: 0x0600DAC1 RID: 56001 RVA: 0x00074EFE File Offset: 0x000730FE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700471C RID: 18204
			// (get) Token: 0x0600DAC2 RID: 56002 RVA: 0x00352064 File Offset: 0x00350264
			// (set) Token: 0x0600DAC3 RID: 56003 RVA: 0x00074F19 File Offset: 0x00073119
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700471D RID: 18205
			// (get) Token: 0x0600DAC4 RID: 56004 RVA: 0x00352094 File Offset: 0x00350294
			// (set) Token: 0x0600DAC5 RID: 56005 RVA: 0x00074F38 File Offset: 0x00073138
			public unsafe Spell_Rinnosuke __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rinnosuke>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rinnosuke._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C24 RID: 35876
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C25 RID: 35877
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C26 RID: 35878
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C27 RID: 35879
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C28 RID: 35880
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C29 RID: 35881
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C2A RID: 35882
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C2B RID: 35883
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C2C RID: 35884
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
