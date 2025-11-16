using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000282 RID: 642
	public class Spell_Satori : SpellBase
	{
		// Token: 0x060050DF RID: 20703 RVA: 0x001B1FFC File Offset: 0x001B01FC
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Satori()
		{
			Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Satori");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr);
			Spell_Satori.NativeFieldInfoPtr_targetIdInUnityEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr, "targetIdInUnityEditor");
			Spell_Satori.NativeFieldInfoPtr_positiveCardBanIdInChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr, "positiveCardBanIdInChallenge");
			Spell_Satori.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr, 100679616);
			Spell_Satori.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr, 100679617);
			Spell_Satori.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr, 100679618);
			Spell_Satori.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr, 100679619);
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x001B20A4 File Offset: 0x001B02A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203683, XrefRangeEnd = 203685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Satori.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x001B20E8 File Offset: 0x001B02E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203685, XrefRangeEnd = 203690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Satori.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x001B2144 File Offset: 0x001B0344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203690, XrefRangeEnd = 203696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Satori.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x001B21A0 File Offset: 0x001B03A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Satori() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x0002AE65 File Offset: 0x00029065
		public Spell_Satori(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x060050E5 RID: 20709 RVA: 0x001B21DC File Offset: 0x001B03DC
		// (set) Token: 0x060050E6 RID: 20710 RVA: 0x0002AE6E File Offset: 0x0002906E
		public unsafe int targetIdInUnityEditor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori.NativeFieldInfoPtr_targetIdInUnityEditor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori.NativeFieldInfoPtr_targetIdInUnityEditor)) = value;
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x060050E7 RID: 20711 RVA: 0x001B2204 File Offset: 0x001B0404
		// (set) Token: 0x060050E8 RID: 20712 RVA: 0x0002AE89 File Offset: 0x00029089
		public unsafe Il2CppStructArray<int> positiveCardBanIdInChallenge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori.NativeFieldInfoPtr_positiveCardBanIdInChallenge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori.NativeFieldInfoPtr_positiveCardBanIdInChallenge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036B6 RID: 14006
		private static readonly IntPtr NativeFieldInfoPtr_targetIdInUnityEditor;

		// Token: 0x040036B7 RID: 14007
		private static readonly IntPtr NativeFieldInfoPtr_positiveCardBanIdInChallenge;

		// Token: 0x040036B8 RID: 14008
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040036B9 RID: 14009
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040036BA RID: 14010
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040036BB RID: 14011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BBA RID: 3002
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Satori+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600DB65 RID: 56165 RVA: 0x00353F40 File Offset: 0x00352140
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Satori.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Satori.__c>.NativeClassPtr);
				Spell_Satori.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori.__c>.NativeClassPtr, "<>9");
				Spell_Satori.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori.__c>.NativeClassPtr, "<>9__3_0");
				Spell_Satori.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori.__c>.NativeClassPtr, "<>9__4_0");
				Spell_Satori.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori.__c>.NativeClassPtr, 100679621);
				Spell_Satori.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori.__c>.NativeClassPtr, 100679622);
				Spell_Satori.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori.__c>.NativeClassPtr, 100679623);
			}

			// Token: 0x0600DB66 RID: 56166 RVA: 0x00353FE4 File Offset: 0x003521E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Satori.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB67 RID: 56167 RVA: 0x00354020 File Offset: 0x00352220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203579, XrefRangeEnd = 203586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnNegativeBuffExecute_b__3_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB68 RID: 56168 RVA: 0x0035406C File Offset: 0x0035226C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203586, XrefRangeEnd = 203593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__4_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB69 RID: 56169 RVA: 0x00075434 File Offset: 0x00073634
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004753 RID: 18259
			// (get) Token: 0x0600DB6A RID: 56170 RVA: 0x003540B8 File Offset: 0x003522B8
			// (set) Token: 0x0600DB6B RID: 56171 RVA: 0x0007543D File Offset: 0x0007363D
			public unsafe static Spell_Satori.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Satori.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Satori.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Satori.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004754 RID: 18260
			// (get) Token: 0x0600DB6C RID: 56172 RVA: 0x003540E0 File Offset: 0x003522E0
			// (set) Token: 0x0600DB6D RID: 56173 RVA: 0x0007544F File Offset: 0x0007364F
			public unsafe static Func<int, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Satori.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Satori.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004755 RID: 18261
			// (get) Token: 0x0600DB6E RID: 56174 RVA: 0x00354108 File Offset: 0x00352308
			// (set) Token: 0x0600DB6F RID: 56175 RVA: 0x00075461 File Offset: 0x00073661
			public unsafe static Func<int, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Satori.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Satori.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C96 RID: 35990
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008C97 RID: 35991
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04008C98 RID: 35992
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04008C99 RID: 35993
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C9A RID: 35994
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_0_Internal_Boolean_Int32_0;

			// Token: 0x04008C9B RID: 35995
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_0_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000BBB RID: 3003
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Satori+<OnNegativeBuffExecute>d__3")]
		public sealed class _OnNegativeBuffExecute_d__3 : Object
		{
			// Token: 0x0600DB70 RID: 56176 RVA: 0x00354130 File Offset: 0x00352330
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__3()
			{
				Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr, "<OnNegativeBuffExecute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr);
				Spell_Satori._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr, "<>1__state");
				Spell_Satori._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr, "<>2__current");
				Spell_Satori._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr, "spellExecutionContext");
				Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679624);
				Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679625);
				Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679626);
				Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679627);
				Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679628);
				Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr, 100679629);
			}

			// Token: 0x0600DB71 RID: 56177 RVA: 0x00354210 File Offset: 0x00352410
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__3(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Satori._OnNegativeBuffExecute_d__3>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB72 RID: 56178 RVA: 0x00354258 File Offset: 0x00352458
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB73 RID: 56179 RVA: 0x0035428C File Offset: 0x0035248C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203593, XrefRangeEnd = 203628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004759 RID: 18265
			// (get) Token: 0x0600DB74 RID: 56180 RVA: 0x003542C8 File Offset: 0x003524C8
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DB75 RID: 56181 RVA: 0x00354308 File Offset: 0x00352508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203628, XrefRangeEnd = 203634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700475A RID: 18266
			// (get) Token: 0x0600DB76 RID: 56182 RVA: 0x0035433C File Offset: 0x0035253C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnNegativeBuffExecute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DB77 RID: 56183 RVA: 0x00075473 File Offset: 0x00073673
			public _OnNegativeBuffExecute_d__3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004756 RID: 18262
			// (get) Token: 0x0600DB78 RID: 56184 RVA: 0x0035437C File Offset: 0x0035257C
			// (set) Token: 0x0600DB79 RID: 56185 RVA: 0x0007547C File Offset: 0x0007367C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004757 RID: 18263
			// (get) Token: 0x0600DB7A RID: 56186 RVA: 0x003543A4 File Offset: 0x003525A4
			// (set) Token: 0x0600DB7B RID: 56187 RVA: 0x00075497 File Offset: 0x00073697
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004758 RID: 18264
			// (get) Token: 0x0600DB7C RID: 56188 RVA: 0x003543D4 File Offset: 0x003525D4
			// (set) Token: 0x0600DB7D RID: 56189 RVA: 0x000754B6 File Offset: 0x000736B6
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnNegativeBuffExecute_d__3.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C9C RID: 35996
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C9D RID: 35997
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C9E RID: 35998
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008C9F RID: 35999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008CA0 RID: 36000
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CA1 RID: 36001
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008CA2 RID: 36002
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008CA3 RID: 36003
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CA4 RID: 36004
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BBC RID: 3004
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Satori+<OnPositiveBuffExecute>d__4")]
		public sealed class _OnPositiveBuffExecute_d__4 : Object
		{
			// Token: 0x0600DB7E RID: 56190 RVA: 0x00354404 File Offset: 0x00352604
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__4()
			{
				Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Satori>.NativeClassPtr, "<OnPositiveBuffExecute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr);
				Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr, "<>1__state");
				Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr, "<>2__current");
				Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr, "spellExecutionContext");
				Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr, "<>4__this");
				Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679630);
				Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679631);
				Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679632);
				Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679633);
				Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679634);
				Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr, 100679635);
			}

			// Token: 0x0600DB7F RID: 56191 RVA: 0x003544F8 File Offset: 0x003526F8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Satori._OnPositiveBuffExecute_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB80 RID: 56192 RVA: 0x00354540 File Offset: 0x00352740
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB81 RID: 56193 RVA: 0x00354574 File Offset: 0x00352774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203634, XrefRangeEnd = 203677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700475F RID: 18271
			// (get) Token: 0x0600DB82 RID: 56194 RVA: 0x003545B0 File Offset: 0x003527B0
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DB83 RID: 56195 RVA: 0x003545F0 File Offset: 0x003527F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203677, XrefRangeEnd = 203683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004760 RID: 18272
			// (get) Token: 0x0600DB84 RID: 56196 RVA: 0x00354624 File Offset: 0x00352824
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Satori._OnPositiveBuffExecute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DB85 RID: 56197 RVA: 0x000754D5 File Offset: 0x000736D5
			public _OnPositiveBuffExecute_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700475B RID: 18267
			// (get) Token: 0x0600DB86 RID: 56198 RVA: 0x00354664 File Offset: 0x00352864
			// (set) Token: 0x0600DB87 RID: 56199 RVA: 0x000754DE File Offset: 0x000736DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700475C RID: 18268
			// (get) Token: 0x0600DB88 RID: 56200 RVA: 0x0035468C File Offset: 0x0035288C
			// (set) Token: 0x0600DB89 RID: 56201 RVA: 0x000754F9 File Offset: 0x000736F9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700475D RID: 18269
			// (get) Token: 0x0600DB8A RID: 56202 RVA: 0x003546BC File Offset: 0x003528BC
			// (set) Token: 0x0600DB8B RID: 56203 RVA: 0x00075518 File Offset: 0x00073718
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700475E RID: 18270
			// (get) Token: 0x0600DB8C RID: 56204 RVA: 0x003546EC File Offset: 0x003528EC
			// (set) Token: 0x0600DB8D RID: 56205 RVA: 0x00075537 File Offset: 0x00073737
			public unsafe Spell_Satori __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Satori>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Satori._OnPositiveBuffExecute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CA5 RID: 36005
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008CA6 RID: 36006
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008CA7 RID: 36007
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008CA8 RID: 36008
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CA9 RID: 36009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008CAA RID: 36010
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CAB RID: 36011
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008CAC RID: 36012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008CAD RID: 36013
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CAE RID: 36014
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
