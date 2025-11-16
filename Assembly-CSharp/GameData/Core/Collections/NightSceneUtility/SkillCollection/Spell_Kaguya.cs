using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000266 RID: 614
	public class Spell_Kaguya : SpellBase
	{
		// Token: 0x06004C16 RID: 19478 RVA: 0x001A62F4 File Offset: 0x001A44F4
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Kaguya()
		{
			Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Kaguya");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr);
			Spell_Kaguya.NativeFieldInfoPtr_addTimeModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "addTimeModify");
			Spell_Kaguya.NativeFieldInfoPtr_reduceTimeModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "reduceTimeModify");
			Spell_Kaguya.NativeFieldInfoPtr_positiveSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "positiveSFX");
			Spell_Kaguya.NativeFieldInfoPtr_positiveEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "positiveEffect");
			Spell_Kaguya.NativeFieldInfoPtr_positiveEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "positiveEffectDuration");
			Spell_Kaguya.NativeFieldInfoPtr_negativeSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "negativeSFX");
			Spell_Kaguya.NativeFieldInfoPtr_negativeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "negativeEffect");
			Spell_Kaguya.NativeFieldInfoPtr_negativeEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "negativeEffectDuration");
			Spell_Kaguya.NativeFieldInfoPtr_cancelSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "cancelSFX");
			Spell_Kaguya.NativeFieldInfoPtr_cancelSFXOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "cancelSFXOffset");
			Spell_Kaguya.NativeFieldInfoPtr_cancelNegativeSFXOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "cancelNegativeSFXOffset");
			Spell_Kaguya.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, 100678619);
			Spell_Kaguya.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, 100678620);
			Spell_Kaguya.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, 100678621);
			Spell_Kaguya.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, 100678622);
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x001A6450 File Offset: 0x001A4650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196512, XrefRangeEnd = 196514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kaguya.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x001A6494 File Offset: 0x001A4694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196514, XrefRangeEnd = 196519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kaguya.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x001A64F0 File Offset: 0x001A46F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196519, XrefRangeEnd = 196524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Kaguya.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x001A654C File Offset: 0x001A474C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Kaguya() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x00027414 File Offset: 0x00025614
		public Spell_Kaguya(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06004C1C RID: 19484 RVA: 0x001A6588 File Offset: 0x001A4788
		// (set) Token: 0x06004C1D RID: 19485 RVA: 0x0002741D File Offset: 0x0002561D
		public unsafe int addTimeModify
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_addTimeModify);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_addTimeModify)) = value;
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06004C1E RID: 19486 RVA: 0x001A65B0 File Offset: 0x001A47B0
		// (set) Token: 0x06004C1F RID: 19487 RVA: 0x00027438 File Offset: 0x00025638
		public unsafe int reduceTimeModify
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_reduceTimeModify);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_reduceTimeModify)) = value;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06004C20 RID: 19488 RVA: 0x001A65D8 File Offset: 0x001A47D8
		// (set) Token: 0x06004C21 RID: 19489 RVA: 0x00027453 File Offset: 0x00025653
		public unsafe AudioClip positiveSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_positiveSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_positiveSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06004C22 RID: 19490 RVA: 0x001A6608 File Offset: 0x001A4808
		// (set) Token: 0x06004C23 RID: 19491 RVA: 0x00027472 File Offset: 0x00025672
		public unsafe GameObject positiveEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_positiveEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_positiveEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06004C24 RID: 19492 RVA: 0x001A6638 File Offset: 0x001A4838
		// (set) Token: 0x06004C25 RID: 19493 RVA: 0x00027491 File Offset: 0x00025691
		public unsafe float positiveEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_positiveEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_positiveEffectDuration)) = value;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06004C26 RID: 19494 RVA: 0x001A6660 File Offset: 0x001A4860
		// (set) Token: 0x06004C27 RID: 19495 RVA: 0x000274AC File Offset: 0x000256AC
		public unsafe AudioClip negativeSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_negativeSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_negativeSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06004C28 RID: 19496 RVA: 0x001A6690 File Offset: 0x001A4890
		// (set) Token: 0x06004C29 RID: 19497 RVA: 0x000274CB File Offset: 0x000256CB
		public unsafe GameObject negativeEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_negativeEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_negativeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06004C2A RID: 19498 RVA: 0x001A66C0 File Offset: 0x001A48C0
		// (set) Token: 0x06004C2B RID: 19499 RVA: 0x000274EA File Offset: 0x000256EA
		public unsafe float negativeEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_negativeEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_negativeEffectDuration)) = value;
			}
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06004C2C RID: 19500 RVA: 0x001A66E8 File Offset: 0x001A48E8
		// (set) Token: 0x06004C2D RID: 19501 RVA: 0x00027505 File Offset: 0x00025705
		public unsafe AudioClip cancelSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_cancelSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_cancelSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06004C2E RID: 19502 RVA: 0x001A6718 File Offset: 0x001A4918
		// (set) Token: 0x06004C2F RID: 19503 RVA: 0x00027524 File Offset: 0x00025724
		public unsafe float cancelSFXOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_cancelSFXOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_cancelSFXOffset)) = value;
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06004C30 RID: 19504 RVA: 0x001A6740 File Offset: 0x001A4940
		// (set) Token: 0x06004C31 RID: 19505 RVA: 0x0002753F File Offset: 0x0002573F
		public unsafe float cancelNegativeSFXOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_cancelNegativeSFXOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya.NativeFieldInfoPtr_cancelNegativeSFXOffset)) = value;
			}
		}

		// Token: 0x0400341D RID: 13341
		private static readonly IntPtr NativeFieldInfoPtr_addTimeModify;

		// Token: 0x0400341E RID: 13342
		private static readonly IntPtr NativeFieldInfoPtr_reduceTimeModify;

		// Token: 0x0400341F RID: 13343
		private static readonly IntPtr NativeFieldInfoPtr_positiveSFX;

		// Token: 0x04003420 RID: 13344
		private static readonly IntPtr NativeFieldInfoPtr_positiveEffect;

		// Token: 0x04003421 RID: 13345
		private static readonly IntPtr NativeFieldInfoPtr_positiveEffectDuration;

		// Token: 0x04003422 RID: 13346
		private static readonly IntPtr NativeFieldInfoPtr_negativeSFX;

		// Token: 0x04003423 RID: 13347
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffect;

		// Token: 0x04003424 RID: 13348
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectDuration;

		// Token: 0x04003425 RID: 13349
		private static readonly IntPtr NativeFieldInfoPtr_cancelSFX;

		// Token: 0x04003426 RID: 13350
		private static readonly IntPtr NativeFieldInfoPtr_cancelSFXOffset;

		// Token: 0x04003427 RID: 13351
		private static readonly IntPtr NativeFieldInfoPtr_cancelNegativeSFXOffset;

		// Token: 0x04003428 RID: 13352
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003429 RID: 13353
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400342A RID: 13354
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400342B RID: 13355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B27 RID: 2855
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kaguya+<OnNegativeBuffExecute>d__12")]
		public sealed class _OnNegativeBuffExecute_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600D379 RID: 54137 RVA: 0x0033C24C File Offset: 0x0033A44C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__12()
			{
				Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "<OnNegativeBuffExecute>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr);
				Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr, "<>1__state");
				Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr, "<>2__current");
				Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr, "<>4__this");
				Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100678623);
				Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100678624);
				Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100678625);
				Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100678626);
				Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100678627);
				Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr, 100678628);
			}

			// Token: 0x0600D37A RID: 54138 RVA: 0x0033C32C File Offset: 0x0033A52C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kaguya._OnNegativeBuffExecute_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D37B RID: 54139 RVA: 0x0033C374 File Offset: 0x0033A574
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D37C RID: 54140 RVA: 0x0033C3A8 File Offset: 0x0033A5A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196498, XrefRangeEnd = 196499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044D3 RID: 17619
			// (get) Token: 0x0600D37D RID: 54141 RVA: 0x0033C3E4 File Offset: 0x0033A5E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D37E RID: 54142 RVA: 0x0033C424 File Offset: 0x0033A624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196499, XrefRangeEnd = 196505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044D4 RID: 17620
			// (get) Token: 0x0600D37F RID: 54143 RVA: 0x0033C458 File Offset: 0x0033A658
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D380 RID: 54144 RVA: 0x00071431 File Offset: 0x0006F631
			public _OnNegativeBuffExecute_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044D0 RID: 17616
			// (get) Token: 0x0600D381 RID: 54145 RVA: 0x0033C498 File Offset: 0x0033A698
			// (set) Token: 0x0600D382 RID: 54146 RVA: 0x0007143A File Offset: 0x0006F63A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044D1 RID: 17617
			// (get) Token: 0x0600D383 RID: 54147 RVA: 0x0033C4C0 File Offset: 0x0033A6C0
			// (set) Token: 0x0600D384 RID: 54148 RVA: 0x00071455 File Offset: 0x0006F655
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D2 RID: 17618
			// (get) Token: 0x0600D385 RID: 54149 RVA: 0x0033C4F0 File Offset: 0x0033A6F0
			// (set) Token: 0x0600D386 RID: 54150 RVA: 0x00071474 File Offset: 0x0006F674
			public unsafe Spell_Kaguya __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kaguya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnNegativeBuffExecute_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087C2 RID: 34754
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087C3 RID: 34755
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087C4 RID: 34756
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087C5 RID: 34757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087C6 RID: 34758
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087C7 RID: 34759
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087C8 RID: 34760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087C9 RID: 34761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087CA RID: 34762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B28 RID: 2856
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Kaguya+<OnPositiveBuffExecute>d__13")]
		public sealed class _OnPositiveBuffExecute_d__13 : Il2CppSystem.Object
		{
			// Token: 0x0600D387 RID: 54151 RVA: 0x0033C520 File Offset: 0x0033A720
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__13()
			{
				Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Kaguya>.NativeClassPtr, "<OnPositiveBuffExecute>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr);
				Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr, "<>1__state");
				Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr, "<>2__current");
				Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr, "<>4__this");
				Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678629);
				Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678630);
				Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678631);
				Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678632);
				Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678633);
				Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr, 100678634);
			}

			// Token: 0x0600D388 RID: 54152 RVA: 0x0033C600 File Offset: 0x0033A800
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Kaguya._OnPositiveBuffExecute_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D389 RID: 54153 RVA: 0x0033C648 File Offset: 0x0033A848
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D38A RID: 54154 RVA: 0x0033C67C File Offset: 0x0033A87C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196505, XrefRangeEnd = 196506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044D8 RID: 17624
			// (get) Token: 0x0600D38B RID: 54155 RVA: 0x0033C6B8 File Offset: 0x0033A8B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D38C RID: 54156 RVA: 0x0033C6F8 File Offset: 0x0033A8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196506, XrefRangeEnd = 196512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044D9 RID: 17625
			// (get) Token: 0x0600D38D RID: 54157 RVA: 0x0033C72C File Offset: 0x0033A92C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D38E RID: 54158 RVA: 0x00071493 File Offset: 0x0006F693
			public _OnPositiveBuffExecute_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044D5 RID: 17621
			// (get) Token: 0x0600D38F RID: 54159 RVA: 0x0033C76C File Offset: 0x0033A96C
			// (set) Token: 0x0600D390 RID: 54160 RVA: 0x0007149C File Offset: 0x0006F69C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044D6 RID: 17622
			// (get) Token: 0x0600D391 RID: 54161 RVA: 0x0033C794 File Offset: 0x0033A994
			// (set) Token: 0x0600D392 RID: 54162 RVA: 0x000714B7 File Offset: 0x0006F6B7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D7 RID: 17623
			// (get) Token: 0x0600D393 RID: 54163 RVA: 0x0033C7C4 File Offset: 0x0033A9C4
			// (set) Token: 0x0600D394 RID: 54164 RVA: 0x000714D6 File Offset: 0x0006F6D6
			public unsafe Spell_Kaguya __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Kaguya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Kaguya._OnPositiveBuffExecute_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087CB RID: 34763
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087CC RID: 34764
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087CD RID: 34765
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087CE RID: 34766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087CF RID: 34767
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087D0 RID: 34768
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087D1 RID: 34769
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087D2 RID: 34770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087D3 RID: 34771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
