using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000263 RID: 611
	public class Spell_Flandre_Intro : SpellBase
	{
		// Token: 0x06004BB7 RID: 19383 RVA: 0x001A52A0 File Offset: 0x001A34A0
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Flandre_Intro()
		{
			Il2CppClassPointerStore<Spell_Flandre_Intro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Flandre_Intro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Flandre_Intro>.NativeClassPtr);
			Spell_Flandre_Intro.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro>.NativeClassPtr, 100678530);
			Spell_Flandre_Intro.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro>.NativeClassPtr, 100678531);
			Spell_Flandre_Intro.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro>.NativeClassPtr, 100678532);
			Spell_Flandre_Intro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro>.NativeClassPtr, 100678533);
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x001A5320 File Offset: 0x001A3520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195918, XrefRangeEnd = 195920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Flandre_Intro.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x001A5364 File Offset: 0x001A3564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195920, XrefRangeEnd = 195924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Flandre_Intro.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x001A53C0 File Offset: 0x001A35C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195924, XrefRangeEnd = 195928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Flandre_Intro.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x001A541C File Offset: 0x001A361C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Flandre_Intro() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Flandre_Intro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x00026FE0 File Offset: 0x000251E0
		public Spell_Flandre_Intro(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040033E7 RID: 13287
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040033E8 RID: 13288
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040033E9 RID: 13289
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040033EA RID: 13290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B19 RID: 2841
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Flandre_Intro+<OnNegativeBuffExecute>d__1")]
		public sealed class _OnNegativeBuffExecute_d__1 : Object
		{
			// Token: 0x0600D2CC RID: 53964 RVA: 0x0033A0D4 File Offset: 0x003382D4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__1()
			{
				Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Flandre_Intro>.NativeClassPtr, "<OnNegativeBuffExecute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr);
				Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr, "<>1__state");
				Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr, "<>2__current");
				Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr, 100678534);
				Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr, 100678535);
				Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr, 100678536);
				Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr, 100678537);
				Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr, 100678538);
				Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr, 100678539);
			}

			// Token: 0x0600D2CD RID: 53965 RVA: 0x0033A1A0 File Offset: 0x003383A0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Flandre_Intro._OnNegativeBuffExecute_d__1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2CE RID: 53966 RVA: 0x0033A1E8 File Offset: 0x003383E8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2CF RID: 53967 RVA: 0x0033A21C File Offset: 0x0033841C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195905, XrefRangeEnd = 195906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700449D RID: 17565
			// (get) Token: 0x0600D2D0 RID: 53968 RVA: 0x0033A258 File Offset: 0x00338458
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D2D1 RID: 53969 RVA: 0x0033A298 File Offset: 0x00338498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195906, XrefRangeEnd = 195912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700449E RID: 17566
			// (get) Token: 0x0600D2D2 RID: 53970 RVA: 0x0033A2CC File Offset: 0x003384CC
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D2D3 RID: 53971 RVA: 0x00070F05 File Offset: 0x0006F105
			public _OnNegativeBuffExecute_d__1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700449B RID: 17563
			// (get) Token: 0x0600D2D4 RID: 53972 RVA: 0x0033A30C File Offset: 0x0033850C
			// (set) Token: 0x0600D2D5 RID: 53973 RVA: 0x00070F0E File Offset: 0x0006F10E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700449C RID: 17564
			// (get) Token: 0x0600D2D6 RID: 53974 RVA: 0x0033A334 File Offset: 0x00338534
			// (set) Token: 0x0600D2D7 RID: 53975 RVA: 0x00070F29 File Offset: 0x0006F129
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Flandre_Intro._OnNegativeBuffExecute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400875A RID: 34650
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400875B RID: 34651
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400875C RID: 34652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400875D RID: 34653
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400875E RID: 34654
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400875F RID: 34655
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008760 RID: 34656
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008761 RID: 34657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B1A RID: 2842
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Flandre_Intro+<OnPositiveBuffExecute>d__2")]
		public sealed class _OnPositiveBuffExecute_d__2 : Object
		{
			// Token: 0x0600D2D8 RID: 53976 RVA: 0x0033A364 File Offset: 0x00338564
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__2()
			{
				Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Flandre_Intro>.NativeClassPtr, "<OnPositiveBuffExecute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr);
				Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr, "<>1__state");
				Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr, "<>2__current");
				Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr, 100678540);
				Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr, 100678541);
				Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr, 100678542);
				Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr, 100678543);
				Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr, 100678544);
				Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr, 100678545);
			}

			// Token: 0x0600D2D9 RID: 53977 RVA: 0x0033A430 File Offset: 0x00338630
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Flandre_Intro._OnPositiveBuffExecute_d__2>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2DA RID: 53978 RVA: 0x0033A478 File Offset: 0x00338678
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2DB RID: 53979 RVA: 0x0033A4AC File Offset: 0x003386AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044A1 RID: 17569
			// (get) Token: 0x0600D2DC RID: 53980 RVA: 0x0033A4E8 File Offset: 0x003386E8
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D2DD RID: 53981 RVA: 0x0033A528 File Offset: 0x00338728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195912, XrefRangeEnd = 195918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044A2 RID: 17570
			// (get) Token: 0x0600D2DE RID: 53982 RVA: 0x0033A55C File Offset: 0x0033875C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D2DF RID: 53983 RVA: 0x00070F48 File Offset: 0x0006F148
			public _OnPositiveBuffExecute_d__2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700449F RID: 17567
			// (get) Token: 0x0600D2E0 RID: 53984 RVA: 0x0033A59C File Offset: 0x0033879C
			// (set) Token: 0x0600D2E1 RID: 53985 RVA: 0x00070F51 File Offset: 0x0006F151
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044A0 RID: 17568
			// (get) Token: 0x0600D2E2 RID: 53986 RVA: 0x0033A5C4 File Offset: 0x003387C4
			// (set) Token: 0x0600D2E3 RID: 53987 RVA: 0x00070F6C File Offset: 0x0006F16C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Flandre_Intro._OnPositiveBuffExecute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008762 RID: 34658
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008763 RID: 34659
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008764 RID: 34660
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008765 RID: 34661
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008766 RID: 34662
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008767 RID: 34663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008768 RID: 34664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008769 RID: 34665
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
