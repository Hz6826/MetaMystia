using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200028D RID: 653
	public class Spell_Ushio : SpellBase
	{
		// Token: 0x060052A5 RID: 21157 RVA: 0x001B69F0 File Offset: 0x001B4BF0
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Ushio()
		{
			Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Ushio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr);
			Spell_Ushio.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, "negativeDuration");
			Spell_Ushio.NativeFieldInfoPtr_negativeTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, "negativeTags");
			Spell_Ushio.NativeFieldInfoPtr_negativeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, "negativeRate");
			Spell_Ushio.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, "positiveDuration");
			Spell_Ushio.NativeFieldInfoPtr_leastOrderCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, "leastOrderCost");
			Spell_Ushio.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680074);
			Spell_Ushio.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680075);
			Spell_Ushio.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680076);
			Spell_Ushio.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680077);
			Spell_Ushio.NativeMethodInfoPtr_UshioSpecialOrderProbabilityCheck_Private_Single_GuestGroupController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680078);
			Spell_Ushio.NativeMethodInfoPtr_OnBuffEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680079);
			Spell_Ushio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680080);
			Spell_Ushio.NativeMethodInfoPtr_Method_Private_String_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680081);
			Spell_Ushio.NativeMethodInfoPtr_Method_Private_String_Int32_String_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680082);
			Spell_Ushio.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680083);
			Spell_Ushio.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_2_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, 100680084);
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x001B6B60 File Offset: 0x001B4D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207250, XrefRangeEnd = 207252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Ushio.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x001B6BA4 File Offset: 0x001B4DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207252, XrefRangeEnd = 207257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Ushio.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x001B6C00 File Offset: 0x001B4E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207257, XrefRangeEnd = 207262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Ushio.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x001B6C5C File Offset: 0x001B4E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207262, XrefRangeEnd = 207273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGuestSpawn(GuestGroupController guestGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x001B6CA0 File Offset: 0x001B4EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207273, XrefRangeEnd = 207287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float UshioSpecialOrderProbabilityCheck(GuestGroupController toOverride, float lastProbability)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toOverride);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastProbability;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio.NativeMethodInfoPtr_UshioSpecialOrderProbabilityCheck_Private_Single_GuestGroupController_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x001B6CFC File Offset: 0x001B4EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207287, XrefRangeEnd = 207324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBuffEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio.NativeMethodInfoPtr_OnBuffEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x001B6D30 File Offset: 0x001B4F30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Ushio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x001B6D6C File Offset: 0x001B4F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207324, XrefRangeEnd = 207366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Method_Private_String_Int32_String_PDM_0(int currentTime, string buffDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio.NativeMethodInfoPtr_Method_Private_String_Int32_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x001B6DC4 File Offset: 0x001B4FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207366, XrefRangeEnd = 207378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Method_Private_String_Int32_String_PDM_1(int currentTime, string buffDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio.NativeMethodInfoPtr_Method_Private_String_Int32_String_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x001B6E1C File Offset: 0x001B501C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207378, XrefRangeEnd = 207394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__7_1(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x001B6E5C File Offset: 0x001B505C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207394, XrefRangeEnd = 207405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__7_2(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_2_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x0002C3D5 File Offset: 0x0002A5D5
		public Spell_Ushio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x060052B2 RID: 21170 RVA: 0x001B6EA0 File Offset: 0x001B50A0
		// (set) Token: 0x060052B3 RID: 21171 RVA: 0x0002C3DE File Offset: 0x0002A5DE
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x060052B4 RID: 21172 RVA: 0x001B6EC8 File Offset: 0x001B50C8
		// (set) Token: 0x060052B5 RID: 21173 RVA: 0x0002C3F9 File Offset: 0x0002A5F9
		public unsafe Il2CppStructArray<int> negativeTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio.NativeFieldInfoPtr_negativeTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio.NativeFieldInfoPtr_negativeTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x060052B6 RID: 21174 RVA: 0x001B6EF8 File Offset: 0x001B50F8
		// (set) Token: 0x060052B7 RID: 21175 RVA: 0x0002C418 File Offset: 0x0002A618
		public unsafe float negativeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio.NativeFieldInfoPtr_negativeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio.NativeFieldInfoPtr_negativeRate)) = value;
			}
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x060052B8 RID: 21176 RVA: 0x001B6F20 File Offset: 0x001B5120
		// (set) Token: 0x060052B9 RID: 21177 RVA: 0x0002C433 File Offset: 0x0002A633
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x060052BA RID: 21178 RVA: 0x001B6F48 File Offset: 0x001B5148
		// (set) Token: 0x060052BB RID: 21179 RVA: 0x0002C44E File Offset: 0x0002A64E
		public unsafe float leastOrderCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio.NativeFieldInfoPtr_leastOrderCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio.NativeFieldInfoPtr_leastOrderCost)) = value;
			}
		}

		// Token: 0x040037B3 RID: 14259
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x040037B4 RID: 14260
		private static readonly IntPtr NativeFieldInfoPtr_negativeTags;

		// Token: 0x040037B5 RID: 14261
		private static readonly IntPtr NativeFieldInfoPtr_negativeRate;

		// Token: 0x040037B6 RID: 14262
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x040037B7 RID: 14263
		private static readonly IntPtr NativeFieldInfoPtr_leastOrderCost;

		// Token: 0x040037B8 RID: 14264
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040037B9 RID: 14265
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040037BA RID: 14266
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040037BB RID: 14267
		private static readonly IntPtr NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0;

		// Token: 0x040037BC RID: 14268
		private static readonly IntPtr NativeMethodInfoPtr_UshioSpecialOrderProbabilityCheck_Private_Single_GuestGroupController_Single_0;

		// Token: 0x040037BD RID: 14269
		private static readonly IntPtr NativeMethodInfoPtr_OnBuffEnd_Private_Void_0;

		// Token: 0x040037BE RID: 14270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037BF RID: 14271
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_String_Int32_String_PDM_0;

		// Token: 0x040037C0 RID: 14272
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_String_Int32_String_PDM_1;

		// Token: 0x040037C1 RID: 14273
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_1_Private_Void_Int32_0;

		// Token: 0x040037C2 RID: 14274
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_2_Private_Void_GuestGroupController_0;

		// Token: 0x02000BFC RID: 3068
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Ushio+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600DF1A RID: 57114 RVA: 0x0035F1B0 File Offset: 0x0035D3B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Ushio.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ushio.__c>.NativeClassPtr);
				Spell_Ushio.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio.__c>.NativeClassPtr, "<>9");
				Spell_Ushio.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio.__c>.NativeClassPtr, "<>9__6_1");
				Spell_Ushio.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio.__c>.NativeClassPtr, 100680086);
				Spell_Ushio.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_1_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio.__c>.NativeClassPtr, 100680087);
			}

			// Token: 0x0600DF1B RID: 57115 RVA: 0x0035F22C File Offset: 0x0035D42C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ushio.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF1C RID: 57116 RVA: 0x0035F268 File Offset: 0x0035D468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__6_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_1_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DF1D RID: 57117 RVA: 0x0007722C File Offset: 0x0007542C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004879 RID: 18553
			// (get) Token: 0x0600DF1E RID: 57118 RVA: 0x0035F2AC File Offset: 0x0035D4AC
			// (set) Token: 0x0600DF1F RID: 57119 RVA: 0x00077235 File Offset: 0x00075435
			public unsafe static Spell_Ushio.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Ushio.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Ushio.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Ushio.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700487A RID: 18554
			// (get) Token: 0x0600DF20 RID: 57120 RVA: 0x0035F2D4 File Offset: 0x0035D4D4
			// (set) Token: 0x0600DF21 RID: 57121 RVA: 0x00077247 File Offset: 0x00075447
			public unsafe static Func<int, string> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Ushio.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Ushio.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ECC RID: 36556
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008ECD RID: 36557
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04008ECE RID: 36558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ECF RID: 36559
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_1_Internal_String_Int32_0;
		}

		// Token: 0x02000BFD RID: 3069
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Ushio+<OnNegativeBuffExecute>d__6")]
		public sealed class _OnNegativeBuffExecute_d__6 : Object
		{
			// Token: 0x0600DF22 RID: 57122 RVA: 0x0035F2FC File Offset: 0x0035D4FC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__6()
			{
				Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, "<OnNegativeBuffExecute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr);
				Spell_Ushio._OnNegativeBuffExecute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr, "<>1__state");
				Spell_Ushio._OnNegativeBuffExecute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr, "<>2__current");
				Spell_Ushio._OnNegativeBuffExecute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr, "<>4__this");
				Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr, 100680088);
				Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr, 100680089);
				Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr, 100680090);
				Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr, 100680091);
				Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr, 100680092);
				Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr, 100680093);
			}

			// Token: 0x0600DF23 RID: 57123 RVA: 0x0035F3DC File Offset: 0x0035D5DC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ushio._OnNegativeBuffExecute_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF24 RID: 57124 RVA: 0x0035F424 File Offset: 0x0035D624
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF25 RID: 57125 RVA: 0x0035F458 File Offset: 0x0035D658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207202, XrefRangeEnd = 207211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700487E RID: 18558
			// (get) Token: 0x0600DF26 RID: 57126 RVA: 0x0035F494 File Offset: 0x0035D694
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF27 RID: 57127 RVA: 0x0035F4D4 File Offset: 0x0035D6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207211, XrefRangeEnd = 207217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700487F RID: 18559
			// (get) Token: 0x0600DF28 RID: 57128 RVA: 0x0035F508 File Offset: 0x0035D708
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF29 RID: 57129 RVA: 0x00077259 File Offset: 0x00075459
			public _OnNegativeBuffExecute_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700487B RID: 18555
			// (get) Token: 0x0600DF2A RID: 57130 RVA: 0x0035F548 File Offset: 0x0035D748
			// (set) Token: 0x0600DF2B RID: 57131 RVA: 0x00077262 File Offset: 0x00075462
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700487C RID: 18556
			// (get) Token: 0x0600DF2C RID: 57132 RVA: 0x0035F570 File Offset: 0x0035D770
			// (set) Token: 0x0600DF2D RID: 57133 RVA: 0x0007727D File Offset: 0x0007547D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700487D RID: 18557
			// (get) Token: 0x0600DF2E RID: 57134 RVA: 0x0035F5A0 File Offset: 0x0035D7A0
			// (set) Token: 0x0600DF2F RID: 57135 RVA: 0x0007729C File Offset: 0x0007549C
			public unsafe Spell_Ushio __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Ushio>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnNegativeBuffExecute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ED0 RID: 36560
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008ED1 RID: 36561
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008ED2 RID: 36562
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008ED3 RID: 36563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008ED4 RID: 36564
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008ED5 RID: 36565
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008ED6 RID: 36566
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008ED7 RID: 36567
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008ED8 RID: 36568
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BFE RID: 3070
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Ushio+<OnPositiveBuffExecute>d__7")]
		public sealed class _OnPositiveBuffExecute_d__7 : Object
		{
			// Token: 0x0600DF30 RID: 57136 RVA: 0x0035F5D0 File Offset: 0x0035D7D0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__7()
			{
				Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Ushio>.NativeClassPtr, "<OnPositiveBuffExecute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr);
				Spell_Ushio._OnPositiveBuffExecute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr, "<>1__state");
				Spell_Ushio._OnPositiveBuffExecute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr, "<>2__current");
				Spell_Ushio._OnPositiveBuffExecute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr, "<>4__this");
				Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr, 100680094);
				Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr, 100680095);
				Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr, 100680096);
				Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr, 100680097);
				Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr, 100680098);
				Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr, 100680099);
			}

			// Token: 0x0600DF31 RID: 57137 RVA: 0x0035F6B0 File Offset: 0x0035D8B0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ushio._OnPositiveBuffExecute_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF32 RID: 57138 RVA: 0x0035F6F8 File Offset: 0x0035D8F8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF33 RID: 57139 RVA: 0x0035F72C File Offset: 0x0035D92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207217, XrefRangeEnd = 207244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004883 RID: 18563
			// (get) Token: 0x0600DF34 RID: 57140 RVA: 0x0035F768 File Offset: 0x0035D968
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF35 RID: 57141 RVA: 0x0035F7A8 File Offset: 0x0035D9A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207244, XrefRangeEnd = 207250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004884 RID: 18564
			// (get) Token: 0x0600DF36 RID: 57142 RVA: 0x0035F7DC File Offset: 0x0035D9DC
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF37 RID: 57143 RVA: 0x000772BB File Offset: 0x000754BB
			public _OnPositiveBuffExecute_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004880 RID: 18560
			// (get) Token: 0x0600DF38 RID: 57144 RVA: 0x0035F81C File Offset: 0x0035DA1C
			// (set) Token: 0x0600DF39 RID: 57145 RVA: 0x000772C4 File Offset: 0x000754C4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004881 RID: 18561
			// (get) Token: 0x0600DF3A RID: 57146 RVA: 0x0035F844 File Offset: 0x0035DA44
			// (set) Token: 0x0600DF3B RID: 57147 RVA: 0x000772DF File Offset: 0x000754DF
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004882 RID: 18562
			// (get) Token: 0x0600DF3C RID: 57148 RVA: 0x0035F874 File Offset: 0x0035DA74
			// (set) Token: 0x0600DF3D RID: 57149 RVA: 0x000772FE File Offset: 0x000754FE
			public unsafe Spell_Ushio __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Ushio>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ushio._OnPositiveBuffExecute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ED9 RID: 36569
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008EDA RID: 36570
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008EDB RID: 36571
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EDC RID: 36572
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008EDD RID: 36573
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EDE RID: 36574
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008EDF RID: 36575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008EE0 RID: 36576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EE1 RID: 36577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
