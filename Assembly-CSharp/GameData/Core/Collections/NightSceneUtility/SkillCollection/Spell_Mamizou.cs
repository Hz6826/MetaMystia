using System;
using Common.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200026D RID: 621
	public class Spell_Mamizou : SpellBase
	{
		// Token: 0x06004D67 RID: 19815 RVA: 0x001A97F0 File Offset: 0x001A79F0
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Mamizou()
		{
			Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Mamizou");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr);
			Spell_Mamizou.NativeFieldInfoPtr_MAMIZOU_SPELLCARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "MAMIZOU_SPELLCARD");
			Spell_Mamizou.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "negativeDuration");
			Spell_Mamizou.NativeFieldInfoPtr_smokeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "smokeEffect");
			Spell_Mamizou.NativeFieldInfoPtr_magicEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "magicEffect");
			Spell_Mamizou.NativeFieldInfoPtr_leafStormEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "leafStormEffect");
			Spell_Mamizou.NativeFieldInfoPtr_leafDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "leafDuration");
			Spell_Mamizou.NativeFieldInfoPtr_magicSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "magicSFX");
			Spell_Mamizou.NativeFieldInfoPtr_leafSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "leafSFX");
			Spell_Mamizou.NativeFieldInfoPtr_smokeSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "smokeSFX");
			Spell_Mamizou.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, 100678881);
			Spell_Mamizou.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, 100678882);
			Spell_Mamizou.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, 100678883);
			Spell_Mamizou.NativeMethodInfoPtr_SetSpellCondition_Private_Boolean_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, 100678884);
			Spell_Mamizou.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, 100678885);
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x001A9938 File Offset: 0x001A7B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198934, XrefRangeEnd = 198936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Mamizou.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x001A997C File Offset: 0x001A7B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198936, XrefRangeEnd = 198942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Mamizou.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x001A99D8 File Offset: 0x001A7BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198942, XrefRangeEnd = 198948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Mamizou.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x001A9A34 File Offset: 0x001A7C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198948, XrefRangeEnd = 198975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetSpellCondition(SpecialGuestsController specialGuestsController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuestsController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.NativeMethodInfoPtr_SetSpellCondition_Private_Boolean_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x001A9A84 File Offset: 0x001A7C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Mamizou() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x00028450 File Offset: 0x00026650
		public Spell_Mamizou(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x06004D6E RID: 19822 RVA: 0x001A9AC0 File Offset: 0x001A7CC0
		// (set) Token: 0x06004D6F RID: 19823 RVA: 0x00028459 File Offset: 0x00026659
		public unsafe static string MAMIZOU_SPELLCARD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Mamizou.NativeFieldInfoPtr_MAMIZOU_SPELLCARD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Mamizou.NativeFieldInfoPtr_MAMIZOU_SPELLCARD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06004D70 RID: 19824 RVA: 0x001A9AE0 File Offset: 0x001A7CE0
		// (set) Token: 0x06004D71 RID: 19825 RVA: 0x0002846B File Offset: 0x0002666B
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06004D72 RID: 19826 RVA: 0x001A9B08 File Offset: 0x001A7D08
		// (set) Token: 0x06004D73 RID: 19827 RVA: 0x00028486 File Offset: 0x00026686
		public unsafe GameObject smokeEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_smokeEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_smokeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06004D74 RID: 19828 RVA: 0x001A9B38 File Offset: 0x001A7D38
		// (set) Token: 0x06004D75 RID: 19829 RVA: 0x000284A5 File Offset: 0x000266A5
		public unsafe GameObject magicEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_magicEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_magicEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06004D76 RID: 19830 RVA: 0x001A9B68 File Offset: 0x001A7D68
		// (set) Token: 0x06004D77 RID: 19831 RVA: 0x000284C4 File Offset: 0x000266C4
		public unsafe GameObject leafStormEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_leafStormEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_leafStormEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06004D78 RID: 19832 RVA: 0x001A9B98 File Offset: 0x001A7D98
		// (set) Token: 0x06004D79 RID: 19833 RVA: 0x000284E3 File Offset: 0x000266E3
		public unsafe float leafDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_leafDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_leafDuration)) = value;
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06004D7A RID: 19834 RVA: 0x001A9BC0 File Offset: 0x001A7DC0
		// (set) Token: 0x06004D7B RID: 19835 RVA: 0x000284FE File Offset: 0x000266FE
		public unsafe AudioClip magicSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_magicSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_magicSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06004D7C RID: 19836 RVA: 0x001A9BF0 File Offset: 0x001A7DF0
		// (set) Token: 0x06004D7D RID: 19837 RVA: 0x0002851D File Offset: 0x0002671D
		public SpellBase.DelayAudioClip leafSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_leafSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_leafSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06004D7E RID: 19838 RVA: 0x001A9C20 File Offset: 0x001A7E20
		// (set) Token: 0x06004D7F RID: 19839 RVA: 0x0002854B File Offset: 0x0002674B
		public unsafe AudioClip smokeSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_smokeSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.NativeFieldInfoPtr_smokeSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034D6 RID: 13526
		private static readonly IntPtr NativeFieldInfoPtr_MAMIZOU_SPELLCARD;

		// Token: 0x040034D7 RID: 13527
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x040034D8 RID: 13528
		private static readonly IntPtr NativeFieldInfoPtr_smokeEffect;

		// Token: 0x040034D9 RID: 13529
		private static readonly IntPtr NativeFieldInfoPtr_magicEffect;

		// Token: 0x040034DA RID: 13530
		private static readonly IntPtr NativeFieldInfoPtr_leafStormEffect;

		// Token: 0x040034DB RID: 13531
		private static readonly IntPtr NativeFieldInfoPtr_leafDuration;

		// Token: 0x040034DC RID: 13532
		private static readonly IntPtr NativeFieldInfoPtr_magicSFX;

		// Token: 0x040034DD RID: 13533
		private static readonly IntPtr NativeFieldInfoPtr_leafSFX;

		// Token: 0x040034DE RID: 13534
		private static readonly IntPtr NativeFieldInfoPtr_smokeSFX;

		// Token: 0x040034DF RID: 13535
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040034E0 RID: 13536
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040034E1 RID: 13537
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040034E2 RID: 13538
		private static readonly IntPtr NativeMethodInfoPtr_SetSpellCondition_Private_Boolean_SpecialGuestsController_0;

		// Token: 0x040034E3 RID: 13539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B47 RID: 2887
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mamizou+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D576 RID: 54646 RVA: 0x003424A0 File Offset: 0x003406A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass10_0>.NativeClassPtr);
				Spell_Mamizou.__c__DisplayClass10_0.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass10_0>.NativeClassPtr, "effect");
				Spell_Mamizou.__c__DisplayClass10_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass10_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Mamizou.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				Spell_Mamizou.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass10_0>.NativeClassPtr, 100678886);
				Spell_Mamizou.__c__DisplayClass10_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass10_0>.NativeClassPtr, 100678887);
				Spell_Mamizou.__c__DisplayClass10_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass10_0>.NativeClassPtr, 100678888);
			}

			// Token: 0x0600D577 RID: 54647 RVA: 0x00342544 File Offset: 0x00340744
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D578 RID: 54648 RVA: 0x00342580 File Offset: 0x00340780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198754, XrefRangeEnd = 198764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass10_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D579 RID: 54649 RVA: 0x003425C4 File Offset: 0x003407C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198764, XrefRangeEnd = 198766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass10_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D57A RID: 54650 RVA: 0x000723B7 File Offset: 0x000705B7
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004570 RID: 17776
			// (get) Token: 0x0600D57B RID: 54651 RVA: 0x00342604 File Offset: 0x00340804
			// (set) Token: 0x0600D57C RID: 54652 RVA: 0x000723C0 File Offset: 0x000705C0
			public unsafe ParticleSystem effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass10_0.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass10_0.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004571 RID: 17777
			// (get) Token: 0x0600D57D RID: 54653 RVA: 0x00342634 File Offset: 0x00340834
			// (set) Token: 0x0600D57E RID: 54654 RVA: 0x000723DF File Offset: 0x000705DF
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass10_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass10_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004572 RID: 17778
			// (get) Token: 0x0600D57F RID: 54655 RVA: 0x00342664 File Offset: 0x00340864
			// (set) Token: 0x0600D580 RID: 54656 RVA: 0x000723FE File Offset: 0x000705FE
			public unsafe Spell_Mamizou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mamizou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088FB RID: 35067
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x040088FC RID: 35068
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040088FD RID: 35069
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088FE RID: 35070
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088FF RID: 35071
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008900 RID: 35072
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_Int32_0;
		}

		// Token: 0x02000B48 RID: 2888
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mamizou+<OnNegativeBuffExecute>d__10")]
		public sealed class _OnNegativeBuffExecute_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600D581 RID: 54657 RVA: 0x00342694 File Offset: 0x00340894
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__10()
			{
				Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "<OnNegativeBuffExecute>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr);
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, "<>1__state");
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, "<>2__current");
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, "spellExecutionContext");
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, "<>4__this");
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, "<>8__1");
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, 100678889);
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, 100678890);
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, 100678891);
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, 100678892);
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, 100678893);
				Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr, 100678894);
			}

			// Token: 0x0600D582 RID: 54658 RVA: 0x0034279C File Offset: 0x0034099C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mamizou._OnNegativeBuffExecute_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D583 RID: 54659 RVA: 0x003427E4 File Offset: 0x003409E4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D584 RID: 54660 RVA: 0x00342818 File Offset: 0x00340A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198766, XrefRangeEnd = 198780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004578 RID: 17784
			// (get) Token: 0x0600D585 RID: 54661 RVA: 0x00342854 File Offset: 0x00340A54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D586 RID: 54662 RVA: 0x00342894 File Offset: 0x00340A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198780, XrefRangeEnd = 198786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004579 RID: 17785
			// (get) Token: 0x0600D587 RID: 54663 RVA: 0x003428C8 File Offset: 0x00340AC8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D588 RID: 54664 RVA: 0x0007241D File Offset: 0x0007061D
			public _OnNegativeBuffExecute_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004573 RID: 17779
			// (get) Token: 0x0600D589 RID: 54665 RVA: 0x00342908 File Offset: 0x00340B08
			// (set) Token: 0x0600D58A RID: 54666 RVA: 0x00072426 File Offset: 0x00070626
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004574 RID: 17780
			// (get) Token: 0x0600D58B RID: 54667 RVA: 0x00342930 File Offset: 0x00340B30
			// (set) Token: 0x0600D58C RID: 54668 RVA: 0x00072441 File Offset: 0x00070641
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004575 RID: 17781
			// (get) Token: 0x0600D58D RID: 54669 RVA: 0x00342960 File Offset: 0x00340B60
			// (set) Token: 0x0600D58E RID: 54670 RVA: 0x00072460 File Offset: 0x00070660
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004576 RID: 17782
			// (get) Token: 0x0600D58F RID: 54671 RVA: 0x00342990 File Offset: 0x00340B90
			// (set) Token: 0x0600D590 RID: 54672 RVA: 0x0007247F File Offset: 0x0007067F
			public unsafe Spell_Mamizou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mamizou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004577 RID: 17783
			// (get) Token: 0x0600D591 RID: 54673 RVA: 0x003429C0 File Offset: 0x00340BC0
			// (set) Token: 0x0600D592 RID: 54674 RVA: 0x0007249E File Offset: 0x0007069E
			public unsafe Spell_Mamizou.__c__DisplayClass10_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mamizou.__c__DisplayClass10_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnNegativeBuffExecute_d__10.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008901 RID: 35073
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008902 RID: 35074
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008903 RID: 35075
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008904 RID: 35076
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008905 RID: 35077
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008906 RID: 35078
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008907 RID: 35079
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008908 RID: 35080
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008909 RID: 35081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400890A RID: 35082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400890B RID: 35083
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B49 RID: 2889
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mamizou+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D593 RID: 54675 RVA: 0x003429F0 File Offset: 0x00340BF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr);
				Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr, "<>9__2");
				Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr, "<>9__4");
				Spell_Mamizou.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr, 100678895);
				Spell_Mamizou.__c__DisplayClass11_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr, 100678896);
				Spell_Mamizou.__c__DisplayClass11_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr, 100678897);
				Spell_Mamizou.__c__DisplayClass11_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr, 100678898);
			}

			// Token: 0x0600D594 RID: 54676 RVA: 0x00342ABC File Offset: 0x00340CBC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D595 RID: 54677 RVA: 0x00342AF8 File Offset: 0x00340CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198786, XrefRangeEnd = 198792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass11_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D596 RID: 54678 RVA: 0x00342B3C File Offset: 0x00340D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198792, XrefRangeEnd = 198806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(GuestGroupController thisGuest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass11_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D597 RID: 54679 RVA: 0x00342B80 File Offset: 0x00340D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198806, XrefRangeEnd = 198820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__4(GuestGroupController thisGuest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass11_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D598 RID: 54680 RVA: 0x000724BD File Offset: 0x000706BD
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457A RID: 17786
			// (get) Token: 0x0600D599 RID: 54681 RVA: 0x00342BC4 File Offset: 0x00340DC4
			// (set) Token: 0x0600D59A RID: 54682 RVA: 0x000724C6 File Offset: 0x000706C6
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457B RID: 17787
			// (get) Token: 0x0600D59B RID: 54683 RVA: 0x00342BF4 File Offset: 0x00340DF4
			// (set) Token: 0x0600D59C RID: 54684 RVA: 0x000724E5 File Offset: 0x000706E5
			public unsafe Spell_Mamizou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mamizou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457C RID: 17788
			// (get) Token: 0x0600D59D RID: 54685 RVA: 0x00342C24 File Offset: 0x00340E24
			// (set) Token: 0x0600D59E RID: 54686 RVA: 0x00072504 File Offset: 0x00070704
			public unsafe Action<GuestGroupController> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457D RID: 17789
			// (get) Token: 0x0600D59F RID: 54687 RVA: 0x00342C54 File Offset: 0x00340E54
			// (set) Token: 0x0600D5A0 RID: 54688 RVA: 0x00072523 File Offset: 0x00070723
			public unsafe Action<GuestGroupController> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400890C RID: 35084
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400890D RID: 35085
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400890E RID: 35086
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400890F RID: 35087
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04008910 RID: 35088
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008911 RID: 35089
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008912 RID: 35090
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GuestGroupController_0;

			// Token: 0x04008913 RID: 35091
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000B4A RID: 2890
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mamizou+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D5A1 RID: 54689 RVA: 0x00342C84 File Offset: 0x00340E84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_1>.NativeClassPtr);
				Spell_Mamizou.__c__DisplayClass11_1.NativeFieldInfoPtr_place = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_1>.NativeClassPtr, "place");
				Spell_Mamizou.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_1>.NativeClassPtr, 100678899);
				Spell_Mamizou.__c__DisplayClass11_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_1>.NativeClassPtr, 100678900);
			}

			// Token: 0x0600D5A2 RID: 54690 RVA: 0x00342CEC File Offset: 0x00340EEC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5A3 RID: 54691 RVA: 0x00342D28 File Offset: 0x00340F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198820, XrefRangeEnd = 198822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass11_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5A4 RID: 54692 RVA: 0x00072542 File Offset: 0x00070742
			public __c__DisplayClass11_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457E RID: 17790
			// (get) Token: 0x0600D5A5 RID: 54693 RVA: 0x00342D6C File Offset: 0x00340F6C
			// (set) Token: 0x0600D5A6 RID: 54694 RVA: 0x0007254B File Offset: 0x0007074B
			public unsafe Vector3Int place
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_1.NativeFieldInfoPtr_place);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_1.NativeFieldInfoPtr_place)) = value;
				}
			}

			// Token: 0x04008914 RID: 35092
			private static readonly IntPtr NativeFieldInfoPtr_place;

			// Token: 0x04008915 RID: 35093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008916 RID: 35094
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B4B RID: 2891
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mamizou+<>c__DisplayClass11_2")]
		public sealed class __c__DisplayClass11_2 : Il2CppSystem.Object
		{
			// Token: 0x0600D5A7 RID: 54695 RVA: 0x00342D94 File Offset: 0x00340F94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_2()
			{
				Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "<>c__DisplayClass11_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_2>.NativeClassPtr);
				Spell_Mamizou.__c__DisplayClass11_2.NativeFieldInfoPtr_guestPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_2>.NativeClassPtr, "guestPosition");
				Spell_Mamizou.__c__DisplayClass11_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_2>.NativeClassPtr, 100678901);
				Spell_Mamizou.__c__DisplayClass11_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_2>.NativeClassPtr, 100678902);
			}

			// Token: 0x0600D5A8 RID: 54696 RVA: 0x00342DFC File Offset: 0x00340FFC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass11_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5A9 RID: 54697 RVA: 0x00342E38 File Offset: 0x00341038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198822, XrefRangeEnd = 198826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__3(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass11_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5AA RID: 54698 RVA: 0x00072566 File Offset: 0x00070766
			public __c__DisplayClass11_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457F RID: 17791
			// (get) Token: 0x0600D5AB RID: 54699 RVA: 0x00342E7C File Offset: 0x0034107C
			// (set) Token: 0x0600D5AC RID: 54700 RVA: 0x0007256F File Offset: 0x0007076F
			public unsafe AStarInputGeneratorComponent guestPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_2.NativeFieldInfoPtr_guestPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_2.NativeFieldInfoPtr_guestPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008917 RID: 35095
			private static readonly IntPtr NativeFieldInfoPtr_guestPosition;

			// Token: 0x04008918 RID: 35096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008919 RID: 35097
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B4C RID: 2892
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mamizou+<>c__DisplayClass11_3")]
		public sealed class __c__DisplayClass11_3 : Il2CppSystem.Object
		{
			// Token: 0x0600D5AD RID: 54701 RVA: 0x00342EAC File Offset: 0x003410AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_3()
			{
				Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "<>c__DisplayClass11_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_3>.NativeClassPtr);
				Spell_Mamizou.__c__DisplayClass11_3.NativeFieldInfoPtr_thisGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_3>.NativeClassPtr, "thisGuest");
				Spell_Mamizou.__c__DisplayClass11_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_3>.NativeClassPtr, 100678903);
				Spell_Mamizou.__c__DisplayClass11_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_3>.NativeClassPtr, 100678904);
			}

			// Token: 0x0600D5AE RID: 54702 RVA: 0x00342F14 File Offset: 0x00341114
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass11_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass11_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5AF RID: 54703 RVA: 0x00342F50 File Offset: 0x00341150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198826, XrefRangeEnd = 198830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__5(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass11_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5B0 RID: 54704 RVA: 0x0007258E File Offset: 0x0007078E
			public __c__DisplayClass11_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004580 RID: 17792
			// (get) Token: 0x0600D5B1 RID: 54705 RVA: 0x00342F94 File Offset: 0x00341194
			// (set) Token: 0x0600D5B2 RID: 54706 RVA: 0x00072597 File Offset: 0x00070797
			public unsafe GuestGroupController thisGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_3.NativeFieldInfoPtr_thisGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass11_3.NativeFieldInfoPtr_thisGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400891A RID: 35098
			private static readonly IntPtr NativeFieldInfoPtr_thisGuest;

			// Token: 0x0400891B RID: 35099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400891C RID: 35100
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B4D RID: 2893
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mamizou+<OnPositiveBuffExecute>d__11")]
		public sealed class _OnPositiveBuffExecute_d__11 : Il2CppSystem.Object
		{
			// Token: 0x0600D5B3 RID: 54707 RVA: 0x00342FC4 File Offset: 0x003411C4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__11()
			{
				Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "<OnPositiveBuffExecute>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr);
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, "<>1__state");
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, "<>2__current");
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, "spellExecutionContext");
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, "<>4__this");
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, "<>8__1");
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr__guestManager_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, "<guestManager>5__2");
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr__waitForSeconds_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, "<waitForSeconds>5__3");
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, "<>7__wrap3");
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, "<>7__wrap4");
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, 100678905);
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, 100678906);
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, 100678907);
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, 100678908);
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, 100678909);
				Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr, 100678910);
			}

			// Token: 0x0600D5B4 RID: 54708 RVA: 0x0034311C File Offset: 0x0034131C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mamizou._OnPositiveBuffExecute_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5B5 RID: 54709 RVA: 0x00343164 File Offset: 0x00341364
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5B6 RID: 54710 RVA: 0x00343198 File Offset: 0x00341398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198830, XrefRangeEnd = 198928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700458A RID: 17802
			// (get) Token: 0x0600D5B7 RID: 54711 RVA: 0x003431D4 File Offset: 0x003413D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5B8 RID: 54712 RVA: 0x00343214 File Offset: 0x00341414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198928, XrefRangeEnd = 198934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700458B RID: 17803
			// (get) Token: 0x0600D5B9 RID: 54713 RVA: 0x00343248 File Offset: 0x00341448
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5BA RID: 54714 RVA: 0x000725B6 File Offset: 0x000707B6
			public _OnPositiveBuffExecute_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004581 RID: 17793
			// (get) Token: 0x0600D5BB RID: 54715 RVA: 0x00343288 File Offset: 0x00341488
			// (set) Token: 0x0600D5BC RID: 54716 RVA: 0x000725BF File Offset: 0x000707BF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004582 RID: 17794
			// (get) Token: 0x0600D5BD RID: 54717 RVA: 0x003432B0 File Offset: 0x003414B0
			// (set) Token: 0x0600D5BE RID: 54718 RVA: 0x000725DA File Offset: 0x000707DA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004583 RID: 17795
			// (get) Token: 0x0600D5BF RID: 54719 RVA: 0x003432E0 File Offset: 0x003414E0
			// (set) Token: 0x0600D5C0 RID: 54720 RVA: 0x000725F9 File Offset: 0x000707F9
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004584 RID: 17796
			// (get) Token: 0x0600D5C1 RID: 54721 RVA: 0x00343310 File Offset: 0x00341510
			// (set) Token: 0x0600D5C2 RID: 54722 RVA: 0x00072618 File Offset: 0x00070818
			public unsafe Spell_Mamizou __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mamizou>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004585 RID: 17797
			// (get) Token: 0x0600D5C3 RID: 54723 RVA: 0x00343340 File Offset: 0x00341540
			// (set) Token: 0x0600D5C4 RID: 54724 RVA: 0x00072637 File Offset: 0x00070837
			public unsafe Spell_Mamizou.__c__DisplayClass11_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Mamizou.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004586 RID: 17798
			// (get) Token: 0x0600D5C5 RID: 54725 RVA: 0x00343370 File Offset: 0x00341570
			// (set) Token: 0x0600D5C6 RID: 54726 RVA: 0x00072656 File Offset: 0x00070856
			public unsafe GuestsManager _guestManager_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr__guestManager_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr__guestManager_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004587 RID: 17799
			// (get) Token: 0x0600D5C7 RID: 54727 RVA: 0x003433A0 File Offset: 0x003415A0
			// (set) Token: 0x0600D5C8 RID: 54728 RVA: 0x00072675 File Offset: 0x00070875
			public unsafe WaitForSeconds _waitForSeconds_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr__waitForSeconds_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr__waitForSeconds_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004588 RID: 17800
			// (get) Token: 0x0600D5C9 RID: 54729 RVA: 0x003433D0 File Offset: 0x003415D0
			// (set) Token: 0x0600D5CA RID: 54730 RVA: 0x00072694 File Offset: 0x00070894
			public unsafe Il2CppReferenceArray<GuestGroupController> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004589 RID: 17801
			// (get) Token: 0x0600D5CB RID: 54731 RVA: 0x00343400 File Offset: 0x00341600
			// (set) Token: 0x0600D5CC RID: 54732 RVA: 0x000726B3 File Offset: 0x000708B3
			public unsafe int __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___7__wrap4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou._OnPositiveBuffExecute_d__11.NativeFieldInfoPtr___7__wrap4)) = value;
				}
			}

			// Token: 0x0400891D RID: 35101
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400891E RID: 35102
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400891F RID: 35103
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008920 RID: 35104
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008921 RID: 35105
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008922 RID: 35106
			private static readonly IntPtr NativeFieldInfoPtr__guestManager_5__2;

			// Token: 0x04008923 RID: 35107
			private static readonly IntPtr NativeFieldInfoPtr__waitForSeconds_5__3;

			// Token: 0x04008924 RID: 35108
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04008925 RID: 35109
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04008926 RID: 35110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008927 RID: 35111
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008928 RID: 35112
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008929 RID: 35113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400892A RID: 35114
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400892B RID: 35115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B4E RID: 2894
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Mamizou+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5CD RID: 54733 RVA: 0x00343428 File Offset: 0x00341628
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Mamizou>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass12_0>.NativeClassPtr);
				Spell_Mamizou.__c__DisplayClass12_0.NativeFieldInfoPtr_specialGuestsController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass12_0>.NativeClassPtr, "specialGuestsController");
				Spell_Mamizou.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass12_0>.NativeClassPtr, 100678911);
				Spell_Mamizou.__c__DisplayClass12_0.NativeMethodInfoPtr__SetSpellCondition_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass12_0>.NativeClassPtr, 100678912);
			}

			// Token: 0x0600D5CE RID: 54734 RVA: 0x00343490 File Offset: 0x00341690
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Mamizou.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5CF RID: 54735 RVA: 0x003434CC File Offset: 0x003416CC
			[CallerCount(0)]
			public unsafe bool _SetSpellCondition_b__0(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Mamizou.__c__DisplayClass12_0.NativeMethodInfoPtr__SetSpellCondition_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D5D0 RID: 54736 RVA: 0x000726CE File Offset: 0x000708CE
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458C RID: 17804
			// (get) Token: 0x0600D5D1 RID: 54737 RVA: 0x00343518 File Offset: 0x00341718
			// (set) Token: 0x0600D5D2 RID: 54738 RVA: 0x000726D7 File Offset: 0x000708D7
			public unsafe SpecialGuestsController specialGuestsController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass12_0.NativeFieldInfoPtr_specialGuestsController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Mamizou.__c__DisplayClass12_0.NativeFieldInfoPtr_specialGuestsController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400892C RID: 35116
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestsController;

			// Token: 0x0400892D RID: 35117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400892E RID: 35118
			private static readonly IntPtr NativeMethodInfoPtr__SetSpellCondition_b__0_Internal_Boolean_Int32_0;
		}
	}
}
