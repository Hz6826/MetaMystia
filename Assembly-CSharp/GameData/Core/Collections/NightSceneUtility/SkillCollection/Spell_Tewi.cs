using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.CoreLanguage;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.UI;
using NightScene.UI.Miscellaneous;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000288 RID: 648
	public class Spell_Tewi : SpellBase
	{
		// Token: 0x060051F8 RID: 20984 RVA: 0x001B4CE8 File Offset: 0x001B2EE8
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Tewi()
		{
			Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Tewi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr);
			Spell_Tewi.NativeFieldInfoPtr_SPECIAL_EVENT_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, "SPECIAL_EVENT_KEY");
			Spell_Tewi.NativeFieldInfoPtr_sharedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, "sharedData");
			Spell_Tewi.NativeFieldInfoPtr_isHardSell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, "isHardSell");
			Spell_Tewi.NativeMethodInfoPtr_get_ShouldProtectedByShield_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679871);
			Spell_Tewi.NativeMethodInfoPtr_get_HasLeaveSpell_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679872);
			Spell_Tewi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679873);
			Spell_Tewi.NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679874);
			Spell_Tewi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679875);
			Spell_Tewi.NativeMethodInfoPtr_GetProducts_Private_Il2CppReferenceArray_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679876);
			Spell_Tewi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679877);
			Spell_Tewi.NativeMethodInfoPtr_OnLeaveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679878);
			Spell_Tewi.NativeMethodInfoPtr_RunPunishmentSpell_Private_IEnumerator_SpecialGuest_Il2CppReferenceArray_1_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679879);
			Spell_Tewi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679880);
			Spell_Tewi.NativeMethodInfoPtr__GetProducts_b__10_2_Private_Product_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, 100679881);
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x060051F9 RID: 20985 RVA: 0x001B4E30 File Offset: 0x001B3030
		public unsafe override bool ShouldProtectedByShield
		{
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Tewi.NativeMethodInfoPtr_get_ShouldProtectedByShield_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x001B4E78 File Offset: 0x001B3078
		public unsafe override bool HasLeaveSpell
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Tewi.NativeMethodInfoPtr_get_HasLeaveSpell_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x001B4EC0 File Offset: 0x001B30C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205756, XrefRangeEnd = 205758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Tewi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x001B4F04 File Offset: 0x001B3104
		[CallerCount(0)]
		public unsafe override bool ShouldCallSpellDeclarationAuto(bool isPositive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isPositive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Tewi.NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x001B4F58 File Offset: 0x001B3158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205758, XrefRangeEnd = 205763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Tewi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x001B4FB4 File Offset: 0x001B31B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205825, RefRangeEnd = 205826, XrefRangeStart = 205763, XrefRangeEnd = 205825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Product> GetProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.NativeMethodInfoPtr_GetProducts_Private_Il2CppReferenceArray_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr3) : null;
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x001B4FF4 File Offset: 0x001B31F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205826, XrefRangeEnd = 205832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Tewi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x001B5050 File Offset: 0x001B3250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205832, XrefRangeEnd = 205838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnLeaveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Tewi.NativeMethodInfoPtr_OnLeaveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x001B50AC File Offset: 0x001B32AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205845, RefRangeEnd = 205847, XrefRangeStart = 205838, XrefRangeEnd = 205845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RunPunishmentSpell(SpecialGuest characterData, Il2CppReferenceArray<LanguageBase> spellLanguageData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spellLanguageData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.NativeMethodInfoPtr_RunPunishmentSpell_Private_IEnumerator_SpecialGuest_Il2CppReferenceArray_1_LanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x001B5110 File Offset: 0x001B3310
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Tewi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x001B514C File Offset: 0x001B334C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205847, XrefRangeEnd = 205851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product _GetProducts_b__10_2(Ingredient x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.NativeMethodInfoPtr__GetProducts_b__10_2_Private_Product_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Product(pointer);
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x0002BBE4 File Offset: 0x00029DE4
		public Spell_Tewi(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06005205 RID: 20997 RVA: 0x001B5194 File Offset: 0x001B3394
		// (set) Token: 0x06005206 RID: 20998 RVA: 0x0002BBED File Offset: 0x00029DED
		public unsafe static string SPECIAL_EVENT_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Tewi.NativeFieldInfoPtr_SPECIAL_EVENT_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Tewi.NativeFieldInfoPtr_SPECIAL_EVENT_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06005207 RID: 20999 RVA: 0x001B51B4 File Offset: 0x001B33B4
		// (set) Token: 0x06005208 RID: 21000 RVA: 0x0002BBFF File Offset: 0x00029DFF
		public unsafe Spell_Tewi_SharedData sharedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.NativeFieldInfoPtr_sharedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tewi_SharedData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.NativeFieldInfoPtr_sharedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06005209 RID: 21001 RVA: 0x001B51E4 File Offset: 0x001B33E4
		// (set) Token: 0x0600520A RID: 21002 RVA: 0x0002BC1E File Offset: 0x00029E1E
		public unsafe bool isHardSell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.NativeFieldInfoPtr_isHardSell);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.NativeFieldInfoPtr_isHardSell)) = value;
			}
		}

		// Token: 0x04003752 RID: 14162
		private static readonly IntPtr NativeFieldInfoPtr_SPECIAL_EVENT_KEY;

		// Token: 0x04003753 RID: 14163
		private static readonly IntPtr NativeFieldInfoPtr_sharedData;

		// Token: 0x04003754 RID: 14164
		private static readonly IntPtr NativeFieldInfoPtr_isHardSell;

		// Token: 0x04003755 RID: 14165
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldProtectedByShield_Protected_Virtual_get_Boolean_0;

		// Token: 0x04003756 RID: 14166
		private static readonly IntPtr NativeMethodInfoPtr_get_HasLeaveSpell_Public_Virtual_get_Boolean_0;

		// Token: 0x04003757 RID: 14167
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003758 RID: 14168
		private static readonly IntPtr NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0;

		// Token: 0x04003759 RID: 14169
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400375A RID: 14170
		private static readonly IntPtr NativeMethodInfoPtr_GetProducts_Private_Il2CppReferenceArray_1_Product_0;

		// Token: 0x0400375B RID: 14171
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400375C RID: 14172
		private static readonly IntPtr NativeMethodInfoPtr_OnLeaveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400375D RID: 14173
		private static readonly IntPtr NativeMethodInfoPtr_RunPunishmentSpell_Private_IEnumerator_SpecialGuest_Il2CppReferenceArray_1_LanguageBase_0;

		// Token: 0x0400375E RID: 14174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400375F RID: 14175
		private static readonly IntPtr NativeMethodInfoPtr__GetProducts_b__10_2_Private_Product_Ingredient_0;

		// Token: 0x02000BDB RID: 3035
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tewi+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600DD5B RID: 56667 RVA: 0x00359DE0 File Offset: 0x00357FE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr);
				Spell_Tewi.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr, "<>9");
				Spell_Tewi.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr, "<>9__9_0");
				Spell_Tewi.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr, "<>9__10_0");
				Spell_Tewi.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr, "<>9__10_1");
				Spell_Tewi.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr, "<>9__13_0");
				Spell_Tewi.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr, 100679883);
				Spell_Tewi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_0_Internal_Void_TrackedCollectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr, 100679884);
				Spell_Tewi.__c.NativeMethodInfoPtr__GetProducts_b__10_0_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr, 100679885);
				Spell_Tewi.__c.NativeMethodInfoPtr__GetProducts_b__10_1_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr, 100679886);
				Spell_Tewi.__c.NativeMethodInfoPtr__RunPunishmentSpell_b__13_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr, 100679887);
			}

			// Token: 0x0600DD5C RID: 56668 RVA: 0x00359ED4 File Offset: 0x003580D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tewi.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD5D RID: 56669 RVA: 0x00359F10 File Offset: 0x00358110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__9_0(TrackedCollectable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_0_Internal_Void_TrackedCollectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD5E RID: 56670 RVA: 0x00359F54 File Offset: 0x00358154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _GetProducts_b__10_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c.NativeMethodInfoPtr__GetProducts_b__10_0_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600DD5F RID: 56671 RVA: 0x00359FA0 File Offset: 0x003581A0
			[CallerCount(0)]
			public unsafe bool _GetProducts_b__10_1(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c.NativeMethodInfoPtr__GetProducts_b__10_1_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD60 RID: 56672 RVA: 0x00359FF0 File Offset: 0x003581F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205522, XrefRangeEnd = 205526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunPunishmentSpell_b__13_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c.NativeMethodInfoPtr__RunPunishmentSpell_b__13_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD61 RID: 56673 RVA: 0x00076427 File Offset: 0x00074627
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047F2 RID: 18418
			// (get) Token: 0x0600DD62 RID: 56674 RVA: 0x0035A02C File Offset: 0x0035822C
			// (set) Token: 0x0600DD63 RID: 56675 RVA: 0x00076430 File Offset: 0x00074630
			public unsafe static Spell_Tewi.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Tewi.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tewi.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Tewi.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047F3 RID: 18419
			// (get) Token: 0x0600DD64 RID: 56676 RVA: 0x0035A054 File Offset: 0x00358254
			// (set) Token: 0x0600DD65 RID: 56677 RVA: 0x00076442 File Offset: 0x00074642
			public unsafe static Action<TrackedCollectable> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Tewi.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TrackedCollectable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Tewi.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047F4 RID: 18420
			// (get) Token: 0x0600DD66 RID: 56678 RVA: 0x0035A07C File Offset: 0x0035827C
			// (set) Token: 0x0600DD67 RID: 56679 RVA: 0x00076454 File Offset: 0x00074654
			public unsafe static Func<int, Ingredient> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Tewi.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Tewi.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047F5 RID: 18421
			// (get) Token: 0x0600DD68 RID: 56680 RVA: 0x0035A0A4 File Offset: 0x003582A4
			// (set) Token: 0x0600DD69 RID: 56681 RVA: 0x00076466 File Offset: 0x00074666
			public unsafe static Func<Ingredient, bool> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Tewi.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Tewi.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047F6 RID: 18422
			// (get) Token: 0x0600DD6A RID: 56682 RVA: 0x0035A0CC File Offset: 0x003582CC
			// (set) Token: 0x0600DD6B RID: 56683 RVA: 0x00076478 File Offset: 0x00074678
			public unsafe static Func<bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Tewi.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Tewi.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DC3 RID: 36291
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DC4 RID: 36292
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04008DC5 RID: 36293
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04008DC6 RID: 36294
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04008DC7 RID: 36295
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04008DC8 RID: 36296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DC9 RID: 36297
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_0_Internal_Void_TrackedCollectable_0;

			// Token: 0x04008DCA RID: 36298
			private static readonly IntPtr NativeMethodInfoPtr__GetProducts_b__10_0_Internal_Ingredient_Int32_0;

			// Token: 0x04008DCB RID: 36299
			private static readonly IntPtr NativeMethodInfoPtr__GetProducts_b__10_1_Internal_Boolean_Ingredient_0;

			// Token: 0x04008DCC RID: 36300
			private static readonly IntPtr NativeMethodInfoPtr__RunPunishmentSpell_b__13_0_Internal_Boolean_0;
		}

		// Token: 0x02000BDC RID: 3036
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tewi+<OnPositiveBuffExecute>d__9")]
		public sealed class _OnPositiveBuffExecute_d__9 : Object
		{
			// Token: 0x0600DD6C RID: 56684 RVA: 0x0035A0F4 File Offset: 0x003582F4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__9()
			{
				Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, "<OnPositiveBuffExecute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr);
				Spell_Tewi._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr, "<>1__state");
				Spell_Tewi._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr, "<>2__current");
				Spell_Tewi._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr, "<>4__this");
				Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100679888);
				Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100679889);
				Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100679890);
				Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100679891);
				Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100679892);
				Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100679893);
			}

			// Token: 0x0600DD6D RID: 56685 RVA: 0x0035A1D4 File Offset: 0x003583D4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tewi._OnPositiveBuffExecute_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD6E RID: 56686 RVA: 0x0035A21C File Offset: 0x0035841C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD6F RID: 56687 RVA: 0x0035A250 File Offset: 0x00358450
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205526, XrefRangeEnd = 205558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047FA RID: 18426
			// (get) Token: 0x0600DD70 RID: 56688 RVA: 0x0035A28C File Offset: 0x0035848C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD71 RID: 56689 RVA: 0x0035A2CC File Offset: 0x003584CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205558, XrefRangeEnd = 205564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047FB RID: 18427
			// (get) Token: 0x0600DD72 RID: 56690 RVA: 0x0035A300 File Offset: 0x00358500
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD73 RID: 56691 RVA: 0x0007648A File Offset: 0x0007468A
			public _OnPositiveBuffExecute_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047F7 RID: 18423
			// (get) Token: 0x0600DD74 RID: 56692 RVA: 0x0035A340 File Offset: 0x00358540
			// (set) Token: 0x0600DD75 RID: 56693 RVA: 0x00076493 File Offset: 0x00074693
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047F8 RID: 18424
			// (get) Token: 0x0600DD76 RID: 56694 RVA: 0x0035A368 File Offset: 0x00358568
			// (set) Token: 0x0600DD77 RID: 56695 RVA: 0x000764AE File Offset: 0x000746AE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047F9 RID: 18425
			// (get) Token: 0x0600DD78 RID: 56696 RVA: 0x0035A398 File Offset: 0x00358598
			// (set) Token: 0x0600DD79 RID: 56697 RVA: 0x000764CD File Offset: 0x000746CD
			public unsafe Spell_Tewi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tewi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DCD RID: 36301
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DCE RID: 36302
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DCF RID: 36303
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DD0 RID: 36304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DD1 RID: 36305
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DD2 RID: 36306
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DD3 RID: 36307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DD4 RID: 36308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DD5 RID: 36309
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BDD RID: 3037
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tewi+<OnNegativeBuffExecute>d__11")]
		public sealed class _OnNegativeBuffExecute_d__11 : Object
		{
			// Token: 0x0600DD7A RID: 56698 RVA: 0x0035A3C8 File Offset: 0x003585C8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__11()
			{
				Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, "<OnNegativeBuffExecute>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr);
				Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>1__state");
				Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>2__current");
				Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>4__this");
				Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr, "spellExecutionContext");
				Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679894);
				Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679895);
				Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679896);
				Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679897);
				Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679898);
				Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100679899);
			}

			// Token: 0x0600DD7B RID: 56699 RVA: 0x0035A4BC File Offset: 0x003586BC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tewi._OnNegativeBuffExecute_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD7C RID: 56700 RVA: 0x0035A504 File Offset: 0x00358704
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD7D RID: 56701 RVA: 0x0035A538 File Offset: 0x00358738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205564, XrefRangeEnd = 205566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004800 RID: 18432
			// (get) Token: 0x0600DD7E RID: 56702 RVA: 0x0035A574 File Offset: 0x00358774
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD7F RID: 56703 RVA: 0x0035A5B4 File Offset: 0x003587B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205566, XrefRangeEnd = 205572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004801 RID: 18433
			// (get) Token: 0x0600DD80 RID: 56704 RVA: 0x0035A5E8 File Offset: 0x003587E8
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD81 RID: 56705 RVA: 0x000764EC File Offset: 0x000746EC
			public _OnNegativeBuffExecute_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047FC RID: 18428
			// (get) Token: 0x0600DD82 RID: 56706 RVA: 0x0035A628 File Offset: 0x00358828
			// (set) Token: 0x0600DD83 RID: 56707 RVA: 0x000764F5 File Offset: 0x000746F5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047FD RID: 18429
			// (get) Token: 0x0600DD84 RID: 56708 RVA: 0x0035A650 File Offset: 0x00358850
			// (set) Token: 0x0600DD85 RID: 56709 RVA: 0x00076510 File Offset: 0x00074710
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047FE RID: 18430
			// (get) Token: 0x0600DD86 RID: 56710 RVA: 0x0035A680 File Offset: 0x00358880
			// (set) Token: 0x0600DD87 RID: 56711 RVA: 0x0007652F File Offset: 0x0007472F
			public unsafe Spell_Tewi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tewi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047FF RID: 18431
			// (get) Token: 0x0600DD88 RID: 56712 RVA: 0x0035A6B0 File Offset: 0x003588B0
			// (set) Token: 0x0600DD89 RID: 56713 RVA: 0x0007654E File Offset: 0x0007474E
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DD6 RID: 36310
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DD7 RID: 36311
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DD8 RID: 36312
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DD9 RID: 36313
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008DDA RID: 36314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DDB RID: 36315
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DDC RID: 36316
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DDD RID: 36317
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DDE RID: 36318
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DDF RID: 36319
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BDE RID: 3038
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tewi+<OnLeaveBuffExecute>d__12")]
		public sealed class _OnLeaveBuffExecute_d__12 : Object
		{
			// Token: 0x0600DD8A RID: 56714 RVA: 0x0035A6E0 File Offset: 0x003588E0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnLeaveBuffExecute_d__12()
			{
				Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, "<OnLeaveBuffExecute>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr);
				Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr, "<>1__state");
				Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr, "<>2__current");
				Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr, "<>4__this");
				Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr, "spellExecutionContext");
				Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr, 100679900);
				Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr, 100679901);
				Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr, 100679902);
				Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr, 100679903);
				Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr, 100679904);
				Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr, 100679905);
			}

			// Token: 0x0600DD8B RID: 56715 RVA: 0x0035A7D4 File Offset: 0x003589D4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnLeaveBuffExecute_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tewi._OnLeaveBuffExecute_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD8C RID: 56716 RVA: 0x0035A81C File Offset: 0x00358A1C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD8D RID: 56717 RVA: 0x0035A850 File Offset: 0x00358A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205572, XrefRangeEnd = 205574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004806 RID: 18438
			// (get) Token: 0x0600DD8E RID: 56718 RVA: 0x0035A88C File Offset: 0x00358A8C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD8F RID: 56719 RVA: 0x0035A8CC File Offset: 0x00358ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205574, XrefRangeEnd = 205580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004807 RID: 18439
			// (get) Token: 0x0600DD90 RID: 56720 RVA: 0x0035A900 File Offset: 0x00358B00
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD91 RID: 56721 RVA: 0x0007656D File Offset: 0x0007476D
			public _OnLeaveBuffExecute_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004802 RID: 18434
			// (get) Token: 0x0600DD92 RID: 56722 RVA: 0x0035A940 File Offset: 0x00358B40
			// (set) Token: 0x0600DD93 RID: 56723 RVA: 0x00076576 File Offset: 0x00074776
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004803 RID: 18435
			// (get) Token: 0x0600DD94 RID: 56724 RVA: 0x0035A968 File Offset: 0x00358B68
			// (set) Token: 0x0600DD95 RID: 56725 RVA: 0x00076591 File Offset: 0x00074791
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004804 RID: 18436
			// (get) Token: 0x0600DD96 RID: 56726 RVA: 0x0035A998 File Offset: 0x00358B98
			// (set) Token: 0x0600DD97 RID: 56727 RVA: 0x000765B0 File Offset: 0x000747B0
			public unsafe Spell_Tewi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tewi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004805 RID: 18437
			// (get) Token: 0x0600DD98 RID: 56728 RVA: 0x0035A9C8 File Offset: 0x00358BC8
			// (set) Token: 0x0600DD99 RID: 56729 RVA: 0x000765CF File Offset: 0x000747CF
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._OnLeaveBuffExecute_d__12.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DE0 RID: 36320
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DE1 RID: 36321
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DE2 RID: 36322
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DE3 RID: 36323
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008DE4 RID: 36324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DE5 RID: 36325
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DE6 RID: 36326
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DE7 RID: 36327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DE8 RID: 36328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DE9 RID: 36329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BDF RID: 3039
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tewi+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600DD9A RID: 56730 RVA: 0x0035A9F8 File Offset: 0x00358BF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr);
				Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, "canContinue");
				Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, "result");
				Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_pannelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, "pannelInstance");
				Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_cheat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, "cheat");
				Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, 100679906);
				Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, 100679907);
				Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, 100679908);
				Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, 100679909);
				Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, 100679910);
				Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, 100679911);
				Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__6_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, 100679912);
				Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, 100679913);
				Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, 100679914);
				Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__9_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr, 100679915);
			}

			// Token: 0x0600DD9B RID: 56731 RVA: 0x0035AB3C File Offset: 0x00358D3C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tewi.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD9C RID: 56732 RVA: 0x0035AB78 File Offset: 0x00358D78
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunPunishmentSpell_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD9D RID: 56733 RVA: 0x0035ABAC File Offset: 0x00358DAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunPunishmentSpell_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD9E RID: 56734 RVA: 0x0035ABE8 File Offset: 0x00358DE8
			[CallerCount(0)]
			public unsafe void _RunPunishmentSpell_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD9F RID: 56735 RVA: 0x0035AC1C File Offset: 0x00358E1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunPunishmentSpell_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDA0 RID: 56736 RVA: 0x0035AC58 File Offset: 0x00358E58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunPunishmentSpell_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA1 RID: 56737 RVA: 0x0035AC8C File Offset: 0x00358E8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunPunishmentSpell_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__6_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDA2 RID: 56738 RVA: 0x0035ACC8 File Offset: 0x00358EC8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunPunishmentSpell_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA3 RID: 56739 RVA: 0x0035ACFC File Offset: 0x00358EFC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunPunishmentSpell_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA4 RID: 56740 RVA: 0x0035AD30 File Offset: 0x00358F30
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunPunishmentSpell_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi.__c__DisplayClass13_0.NativeMethodInfoPtr__RunPunishmentSpell_b__9_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDA5 RID: 56741 RVA: 0x000765EE File Offset: 0x000747EE
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004808 RID: 18440
			// (get) Token: 0x0600DDA6 RID: 56742 RVA: 0x0035AD6C File Offset: 0x00358F6C
			// (set) Token: 0x0600DDA7 RID: 56743 RVA: 0x000765F7 File Offset: 0x000747F7
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x17004809 RID: 18441
			// (get) Token: 0x0600DDA8 RID: 56744 RVA: 0x0035AD94 File Offset: 0x00358F94
			// (set) Token: 0x0600DDA9 RID: 56745 RVA: 0x00076612 File Offset: 0x00074812
			public unsafe bool result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x1700480A RID: 18442
			// (get) Token: 0x0600DDAA RID: 56746 RVA: 0x0035ADBC File Offset: 0x00358FBC
			// (set) Token: 0x0600DDAB RID: 56747 RVA: 0x0007662D File Offset: 0x0007482D
			public unsafe WorkSceneTewiShopPannel pannelInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_pannelInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTewiShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_pannelInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700480B RID: 18443
			// (get) Token: 0x0600DDAC RID: 56748 RVA: 0x0035ADEC File Offset: 0x00358FEC
			// (set) Token: 0x0600DDAD RID: 56749 RVA: 0x0007664C File Offset: 0x0007484C
			public unsafe bool cheat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_cheat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi.__c__DisplayClass13_0.NativeFieldInfoPtr_cheat)) = value;
				}
			}

			// Token: 0x04008DEA RID: 36330
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x04008DEB RID: 36331
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x04008DEC RID: 36332
			private static readonly IntPtr NativeFieldInfoPtr_pannelInstance;

			// Token: 0x04008DED RID: 36333
			private static readonly IntPtr NativeFieldInfoPtr_cheat;

			// Token: 0x04008DEE RID: 36334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DEF RID: 36335
			private static readonly IntPtr NativeMethodInfoPtr__RunPunishmentSpell_b__1_Internal_Void_0;

			// Token: 0x04008DF0 RID: 36336
			private static readonly IntPtr NativeMethodInfoPtr__RunPunishmentSpell_b__2_Internal_Boolean_0;

			// Token: 0x04008DF1 RID: 36337
			private static readonly IntPtr NativeMethodInfoPtr__RunPunishmentSpell_b__3_Internal_Void_0;

			// Token: 0x04008DF2 RID: 36338
			private static readonly IntPtr NativeMethodInfoPtr__RunPunishmentSpell_b__4_Internal_Boolean_0;

			// Token: 0x04008DF3 RID: 36339
			private static readonly IntPtr NativeMethodInfoPtr__RunPunishmentSpell_b__5_Internal_Void_0;

			// Token: 0x04008DF4 RID: 36340
			private static readonly IntPtr NativeMethodInfoPtr__RunPunishmentSpell_b__6_Internal_Boolean_0;

			// Token: 0x04008DF5 RID: 36341
			private static readonly IntPtr NativeMethodInfoPtr__RunPunishmentSpell_b__7_Internal_Void_0;

			// Token: 0x04008DF6 RID: 36342
			private static readonly IntPtr NativeMethodInfoPtr__RunPunishmentSpell_b__8_Internal_Void_0;

			// Token: 0x04008DF7 RID: 36343
			private static readonly IntPtr NativeMethodInfoPtr__RunPunishmentSpell_b__9_Internal_Boolean_0;
		}

		// Token: 0x02000BE0 RID: 3040
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Tewi+<RunPunishmentSpell>d__13")]
		public sealed class _RunPunishmentSpell_d__13 : Object
		{
			// Token: 0x0600DDAE RID: 56750 RVA: 0x0035AE14 File Offset: 0x00359014
			// Note: this type is marked as 'beforefieldinit'.
			static _RunPunishmentSpell_d__13()
			{
				Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Tewi>.NativeClassPtr, "<RunPunishmentSpell>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr);
				Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, "<>1__state");
				Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, "<>2__current");
				Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr_characterData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, "characterData");
				Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, "<>4__this");
				Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, "<>8__1");
				Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr_spellLanguageData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, "spellLanguageData");
				Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr__thisCharacterData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, "<thisCharacterData>5__2");
				Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr__sustainedPannel_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, "<sustainedPannel>5__3");
				Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, 100679916);
				Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, 100679917);
				Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, 100679918);
				Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, 100679919);
				Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, 100679920);
				Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr, 100679921);
			}

			// Token: 0x0600DDAF RID: 56751 RVA: 0x0035AF58 File Offset: 0x00359158
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunPunishmentSpell_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tewi._RunPunishmentSpell_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDB0 RID: 56752 RVA: 0x0035AFA0 File Offset: 0x003591A0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDB1 RID: 56753 RVA: 0x0035AFD4 File Offset: 0x003591D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205580, XrefRangeEnd = 205750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004814 RID: 18452
			// (get) Token: 0x0600DDB2 RID: 56754 RVA: 0x0035B010 File Offset: 0x00359210
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDB3 RID: 56755 RVA: 0x0035B050 File Offset: 0x00359250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205750, XrefRangeEnd = 205756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004815 RID: 18453
			// (get) Token: 0x0600DDB4 RID: 56756 RVA: 0x0035B084 File Offset: 0x00359284
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi._RunPunishmentSpell_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDB5 RID: 56757 RVA: 0x00076667 File Offset: 0x00074867
			public _RunPunishmentSpell_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700480C RID: 18444
			// (get) Token: 0x0600DDB6 RID: 56758 RVA: 0x0035B0C4 File Offset: 0x003592C4
			// (set) Token: 0x0600DDB7 RID: 56759 RVA: 0x00076670 File Offset: 0x00074870
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700480D RID: 18445
			// (get) Token: 0x0600DDB8 RID: 56760 RVA: 0x0035B0EC File Offset: 0x003592EC
			// (set) Token: 0x0600DDB9 RID: 56761 RVA: 0x0007668B File Offset: 0x0007488B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700480E RID: 18446
			// (get) Token: 0x0600DDBA RID: 56762 RVA: 0x0035B11C File Offset: 0x0035931C
			// (set) Token: 0x0600DDBB RID: 56763 RVA: 0x000766AA File Offset: 0x000748AA
			public unsafe SpecialGuest characterData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr_characterData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr_characterData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700480F RID: 18447
			// (get) Token: 0x0600DDBC RID: 56764 RVA: 0x0035B14C File Offset: 0x0035934C
			// (set) Token: 0x0600DDBD RID: 56765 RVA: 0x000766C9 File Offset: 0x000748C9
			public unsafe Spell_Tewi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tewi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004810 RID: 18448
			// (get) Token: 0x0600DDBE RID: 56766 RVA: 0x0035B17C File Offset: 0x0035937C
			// (set) Token: 0x0600DDBF RID: 56767 RVA: 0x000766E8 File Offset: 0x000748E8
			public unsafe Spell_Tewi.__c__DisplayClass13_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Tewi.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004811 RID: 18449
			// (get) Token: 0x0600DDC0 RID: 56768 RVA: 0x0035B1AC File Offset: 0x003593AC
			// (set) Token: 0x0600DDC1 RID: 56769 RVA: 0x00076707 File Offset: 0x00074907
			public unsafe Il2CppReferenceArray<LanguageBase> spellLanguageData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr_spellLanguageData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LanguageBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr_spellLanguageData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004812 RID: 18450
			// (get) Token: 0x0600DDC2 RID: 56770 RVA: 0x0035B1DC File Offset: 0x003593DC
			// (set) Token: 0x0600DDC3 RID: 56771 RVA: 0x00076726 File Offset: 0x00074926
			public unsafe SpecialGuest _thisCharacterData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr__thisCharacterData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr__thisCharacterData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004813 RID: 18451
			// (get) Token: 0x0600DDC4 RID: 56772 RVA: 0x0035B20C File Offset: 0x0035940C
			// (set) Token: 0x0600DDC5 RID: 56773 RVA: 0x00076745 File Offset: 0x00074945
			public unsafe WorkSceneSustainedPannel _sustainedPannel_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr__sustainedPannel_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi._RunPunishmentSpell_d__13.NativeFieldInfoPtr__sustainedPannel_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DF8 RID: 36344
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DF9 RID: 36345
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DFA RID: 36346
			private static readonly IntPtr NativeFieldInfoPtr_characterData;

			// Token: 0x04008DFB RID: 36347
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DFC RID: 36348
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008DFD RID: 36349
			private static readonly IntPtr NativeFieldInfoPtr_spellLanguageData;

			// Token: 0x04008DFE RID: 36350
			private static readonly IntPtr NativeFieldInfoPtr__thisCharacterData_5__2;

			// Token: 0x04008DFF RID: 36351
			private static readonly IntPtr NativeFieldInfoPtr__sustainedPannel_5__3;

			// Token: 0x04008E00 RID: 36352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E01 RID: 36353
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E02 RID: 36354
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E03 RID: 36355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E04 RID: 36356
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E05 RID: 36357
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
