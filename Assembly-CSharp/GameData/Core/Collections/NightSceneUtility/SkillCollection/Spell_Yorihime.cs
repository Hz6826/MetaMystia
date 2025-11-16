using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000291 RID: 657
	public class Spell_Yorihime : SpellBase
	{
		// Token: 0x06005332 RID: 21298 RVA: 0x001B8220 File Offset: 0x001B6420
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Yorihime()
		{
			Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Yorihime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr);
			Spell_Yorihime.NativeFieldInfoPtr_addNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "addNum");
			Spell_Yorihime.NativeFieldInfoPtr_addNumWhenGetLegend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "addNumWhenGetLegend");
			Spell_Yorihime.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "negativeDuration");
			Spell_Yorihime.NativeFieldInfoPtr_lightVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "lightVfx");
			Spell_Yorihime.NativeFieldInfoPtr_energyVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "energyVfx");
			Spell_Yorihime.NativeFieldInfoPtr_ringVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "ringVfx");
			Spell_Yorihime.NativeFieldInfoPtr_energyOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "energyOffset");
			Spell_Yorihime.NativeFieldInfoPtr_ringOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "ringOffset");
			Spell_Yorihime.NativeFieldInfoPtr_ringDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "ringDelay");
			Spell_Yorihime.NativeFieldInfoPtr_punishmentVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "punishmentVfx");
			Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxCNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "punishmentVfxCNT");
			Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "punishmentVfxEN");
			Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxJP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "punishmentVfxJP");
			Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxKR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "punishmentVfxKR");
			Spell_Yorihime.NativeFieldInfoPtr_shakeDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "shakeDelay");
			Spell_Yorihime.NativeFieldInfoPtr_wholeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "wholeDuration");
			Spell_Yorihime.NativeFieldInfoPtr_positiveSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "positiveSfx");
			Spell_Yorihime.NativeFieldInfoPtr_negativeSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "negativeSfx");
			Spell_Yorihime.NativeFieldInfoPtr_LEGEND_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "LEGEND_ID");
			Spell_Yorihime.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, 100680234);
			Spell_Yorihime.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, 100680235);
			Spell_Yorihime.NativeMethodInfoPtr_KamiOracle_Private_Boolean_GuestGroupController_Sellable_Sellable_EvaluationResult_byref_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, 100680236);
			Spell_Yorihime.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, 100680237);
			Spell_Yorihime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, 100680238);
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x001B8430 File Offset: 0x001B6630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208337, XrefRangeEnd = 208339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yorihime.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x001B8474 File Offset: 0x001B6674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208339, XrefRangeEnd = 208345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yorihime.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x001B84D0 File Offset: 0x001B66D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208345, XrefRangeEnd = 208351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool KamiOracle(GuestGroupController guestGroup, Sellable food, Sellable bev, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult overrideEval)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bev);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldResult;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &overrideEval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.NativeMethodInfoPtr_KamiOracle_Private_Boolean_GuestGroupController_Sellable_Sellable_EvaluationResult_byref_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x001B8560 File Offset: 0x001B6760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208351, XrefRangeEnd = 208356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yorihime.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x001B85BC File Offset: 0x001B67BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Yorihime() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x0002CA3C File Offset: 0x0002AC3C
		public Spell_Yorihime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06005339 RID: 21305 RVA: 0x001B85F8 File Offset: 0x001B67F8
		// (set) Token: 0x0600533A RID: 21306 RVA: 0x0002CA45 File Offset: 0x0002AC45
		public unsafe int addNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_addNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_addNum)) = value;
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x0600533B RID: 21307 RVA: 0x001B8620 File Offset: 0x001B6820
		// (set) Token: 0x0600533C RID: 21308 RVA: 0x0002CA60 File Offset: 0x0002AC60
		public unsafe int addNumWhenGetLegend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_addNumWhenGetLegend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_addNumWhenGetLegend)) = value;
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x0600533D RID: 21309 RVA: 0x001B8648 File Offset: 0x001B6848
		// (set) Token: 0x0600533E RID: 21310 RVA: 0x0002CA7B File Offset: 0x0002AC7B
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x0600533F RID: 21311 RVA: 0x001B8670 File Offset: 0x001B6870
		// (set) Token: 0x06005340 RID: 21312 RVA: 0x0002CA96 File Offset: 0x0002AC96
		public unsafe GameObject lightVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_lightVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_lightVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06005341 RID: 21313 RVA: 0x001B86A0 File Offset: 0x001B68A0
		// (set) Token: 0x06005342 RID: 21314 RVA: 0x0002CAB5 File Offset: 0x0002ACB5
		public unsafe GameObject energyVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_energyVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_energyVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06005343 RID: 21315 RVA: 0x001B86D0 File Offset: 0x001B68D0
		// (set) Token: 0x06005344 RID: 21316 RVA: 0x0002CAD4 File Offset: 0x0002ACD4
		public unsafe GameObject ringVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_ringVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_ringVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06005345 RID: 21317 RVA: 0x001B8700 File Offset: 0x001B6900
		// (set) Token: 0x06005346 RID: 21318 RVA: 0x0002CAF3 File Offset: 0x0002ACF3
		public unsafe Vector2 energyOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_energyOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_energyOffset)) = value;
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06005347 RID: 21319 RVA: 0x001B8728 File Offset: 0x001B6928
		// (set) Token: 0x06005348 RID: 21320 RVA: 0x0002CB0E File Offset: 0x0002AD0E
		public unsafe Vector2 ringOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_ringOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_ringOffset)) = value;
			}
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06005349 RID: 21321 RVA: 0x001B8750 File Offset: 0x001B6950
		// (set) Token: 0x0600534A RID: 21322 RVA: 0x0002CB29 File Offset: 0x0002AD29
		public unsafe float ringDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_ringDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_ringDelay)) = value;
			}
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x0600534B RID: 21323 RVA: 0x001B8778 File Offset: 0x001B6978
		// (set) Token: 0x0600534C RID: 21324 RVA: 0x0002CB44 File Offset: 0x0002AD44
		public unsafe GameObject punishmentVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_punishmentVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_punishmentVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x0600534D RID: 21325 RVA: 0x001B87A8 File Offset: 0x001B69A8
		// (set) Token: 0x0600534E RID: 21326 RVA: 0x0002CB63 File Offset: 0x0002AD63
		public unsafe GameObject punishmentVfxCNT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxCNT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxCNT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x0600534F RID: 21327 RVA: 0x001B87D8 File Offset: 0x001B69D8
		// (set) Token: 0x06005350 RID: 21328 RVA: 0x0002CB82 File Offset: 0x0002AD82
		public unsafe GameObject punishmentVfxEN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxEN);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxEN), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06005351 RID: 21329 RVA: 0x001B8808 File Offset: 0x001B6A08
		// (set) Token: 0x06005352 RID: 21330 RVA: 0x0002CBA1 File Offset: 0x0002ADA1
		public unsafe GameObject punishmentVfxJP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxJP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxJP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06005353 RID: 21331 RVA: 0x001B8838 File Offset: 0x001B6A38
		// (set) Token: 0x06005354 RID: 21332 RVA: 0x0002CBC0 File Offset: 0x0002ADC0
		public unsafe GameObject punishmentVfxKR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxKR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_punishmentVfxKR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06005355 RID: 21333 RVA: 0x001B8868 File Offset: 0x001B6A68
		// (set) Token: 0x06005356 RID: 21334 RVA: 0x0002CBDF File Offset: 0x0002ADDF
		public unsafe float shakeDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_shakeDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_shakeDelay)) = value;
			}
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06005357 RID: 21335 RVA: 0x001B8890 File Offset: 0x001B6A90
		// (set) Token: 0x06005358 RID: 21336 RVA: 0x0002CBFA File Offset: 0x0002ADFA
		public unsafe float wholeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_wholeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_wholeDuration)) = value;
			}
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06005359 RID: 21337 RVA: 0x001B88B8 File Offset: 0x001B6AB8
		// (set) Token: 0x0600535A RID: 21338 RVA: 0x0002CC15 File Offset: 0x0002AE15
		public SpellBase.DelayAudioClip positiveSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_positiveSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_positiveSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x0600535B RID: 21339 RVA: 0x001B88E8 File Offset: 0x001B6AE8
		// (set) Token: 0x0600535C RID: 21340 RVA: 0x0002CC43 File Offset: 0x0002AE43
		public SpellBase.DelayAudioClip negativeSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_negativeSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.NativeFieldInfoPtr_negativeSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x0600535D RID: 21341 RVA: 0x001B8918 File Offset: 0x001B6B18
		// (set) Token: 0x0600535E RID: 21342 RVA: 0x0002CC71 File Offset: 0x0002AE71
		public unsafe static int LEGEND_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Yorihime.NativeFieldInfoPtr_LEGEND_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Yorihime.NativeFieldInfoPtr_LEGEND_ID, (void*)(&value));
			}
		}

		// Token: 0x04003803 RID: 14339
		private static readonly IntPtr NativeFieldInfoPtr_addNum;

		// Token: 0x04003804 RID: 14340
		private static readonly IntPtr NativeFieldInfoPtr_addNumWhenGetLegend;

		// Token: 0x04003805 RID: 14341
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003806 RID: 14342
		private static readonly IntPtr NativeFieldInfoPtr_lightVfx;

		// Token: 0x04003807 RID: 14343
		private static readonly IntPtr NativeFieldInfoPtr_energyVfx;

		// Token: 0x04003808 RID: 14344
		private static readonly IntPtr NativeFieldInfoPtr_ringVfx;

		// Token: 0x04003809 RID: 14345
		private static readonly IntPtr NativeFieldInfoPtr_energyOffset;

		// Token: 0x0400380A RID: 14346
		private static readonly IntPtr NativeFieldInfoPtr_ringOffset;

		// Token: 0x0400380B RID: 14347
		private static readonly IntPtr NativeFieldInfoPtr_ringDelay;

		// Token: 0x0400380C RID: 14348
		private static readonly IntPtr NativeFieldInfoPtr_punishmentVfx;

		// Token: 0x0400380D RID: 14349
		private static readonly IntPtr NativeFieldInfoPtr_punishmentVfxCNT;

		// Token: 0x0400380E RID: 14350
		private static readonly IntPtr NativeFieldInfoPtr_punishmentVfxEN;

		// Token: 0x0400380F RID: 14351
		private static readonly IntPtr NativeFieldInfoPtr_punishmentVfxJP;

		// Token: 0x04003810 RID: 14352
		private static readonly IntPtr NativeFieldInfoPtr_punishmentVfxKR;

		// Token: 0x04003811 RID: 14353
		private static readonly IntPtr NativeFieldInfoPtr_shakeDelay;

		// Token: 0x04003812 RID: 14354
		private static readonly IntPtr NativeFieldInfoPtr_wholeDuration;

		// Token: 0x04003813 RID: 14355
		private static readonly IntPtr NativeFieldInfoPtr_positiveSfx;

		// Token: 0x04003814 RID: 14356
		private static readonly IntPtr NativeFieldInfoPtr_negativeSfx;

		// Token: 0x04003815 RID: 14357
		private static readonly IntPtr NativeFieldInfoPtr_LEGEND_ID;

		// Token: 0x04003816 RID: 14358
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003817 RID: 14359
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003818 RID: 14360
		private static readonly IntPtr NativeMethodInfoPtr_KamiOracle_Private_Boolean_GuestGroupController_Sellable_Sellable_EvaluationResult_byref_EvaluationResult_0;

		// Token: 0x04003819 RID: 14361
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400381A RID: 14362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C0F RID: 3087
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yorihime+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E029 RID: 57385 RVA: 0x0036248C File Offset: 0x0036068C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr);
				Spell_Yorihime.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, "<>9");
				Spell_Yorihime.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, "<>9__20_0");
				Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, "<>9__22_3");
				Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, "<>9__22_4");
				Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, "<>9__22_0");
				Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, "<>9__22_5");
				Spell_Yorihime.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, 100680240);
				Spell_Yorihime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_0_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, 100680241);
				Spell_Yorihime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_0_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, 100680242);
				Spell_Yorihime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_3_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, 100680243);
				Spell_Yorihime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_4_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, 100680244);
				Spell_Yorihime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_5_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr, 100680245);
			}

			// Token: 0x0600E02A RID: 57386 RVA: 0x003625A8 File Offset: 0x003607A8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yorihime.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E02B RID: 57387 RVA: 0x003625E4 File Offset: 0x003607E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208163, XrefRangeEnd = 208171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnPositiveBuffExecute_b__20_0(int num, string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref num;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_0_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E02C RID: 57388 RVA: 0x0036263C File Offset: 0x0036083C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208171, XrefRangeEnd = 208209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnNegativeBuffExecute_b__22_0(ValueTuple<Recipe, Sellable> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_0_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E02D RID: 57389 RVA: 0x00362690 File Offset: 0x00360890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208209, XrefRangeEnd = 208214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnNegativeBuffExecute_b__22_3(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_3_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E02E RID: 57390 RVA: 0x003626DC File Offset: 0x003608DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208214, XrefRangeEnd = 208219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnNegativeBuffExecute_b__22_4(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_4_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E02F RID: 57391 RVA: 0x00362728 File Offset: 0x00360928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208219, XrefRangeEnd = 208227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__22_5(int currentTime, string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_5_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E030 RID: 57392 RVA: 0x00077A63 File Offset: 0x00075C63
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048CF RID: 18639
			// (get) Token: 0x0600E031 RID: 57393 RVA: 0x00362780 File Offset: 0x00360980
			// (set) Token: 0x0600E032 RID: 57394 RVA: 0x00077A6C File Offset: 0x00075C6C
			public unsafe static Spell_Yorihime.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yorihime.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048D0 RID: 18640
			// (get) Token: 0x0600E033 RID: 57395 RVA: 0x003627A8 File Offset: 0x003609A8
			// (set) Token: 0x0600E034 RID: 57396 RVA: 0x00077A7E File Offset: 0x00075C7E
			public unsafe static Func<int, string, string> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048D1 RID: 18641
			// (get) Token: 0x0600E035 RID: 57397 RVA: 0x003627D0 File Offset: 0x003609D0
			// (set) Token: 0x0600E036 RID: 57398 RVA: 0x00077A90 File Offset: 0x00075C90
			public unsafe static Func<int, bool> __9__22_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048D2 RID: 18642
			// (get) Token: 0x0600E037 RID: 57399 RVA: 0x003627F8 File Offset: 0x003609F8
			// (set) Token: 0x0600E038 RID: 57400 RVA: 0x00077AA2 File Offset: 0x00075CA2
			public unsafe static Func<int, bool> __9__22_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048D3 RID: 18643
			// (get) Token: 0x0600E039 RID: 57401 RVA: 0x00362820 File Offset: 0x00360A20
			// (set) Token: 0x0600E03A RID: 57402 RVA: 0x00077AB4 File Offset: 0x00075CB4
			public unsafe static Predicate<ValueTuple<Recipe, Sellable>> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ValueTuple<Recipe, Sellable>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048D4 RID: 18644
			// (get) Token: 0x0600E03B RID: 57403 RVA: 0x00362848 File Offset: 0x00360A48
			// (set) Token: 0x0600E03C RID: 57404 RVA: 0x00077AC6 File Offset: 0x00075CC6
			public unsafe static Func<int, string, string> __9__22_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yorihime.__c.NativeFieldInfoPtr___9__22_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F6F RID: 36719
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F70 RID: 36720
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04008F71 RID: 36721
			private static readonly IntPtr NativeFieldInfoPtr___9__22_3;

			// Token: 0x04008F72 RID: 36722
			private static readonly IntPtr NativeFieldInfoPtr___9__22_4;

			// Token: 0x04008F73 RID: 36723
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04008F74 RID: 36724
			private static readonly IntPtr NativeFieldInfoPtr___9__22_5;

			// Token: 0x04008F75 RID: 36725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F76 RID: 36726
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_0_Internal_String_Int32_String_0;

			// Token: 0x04008F77 RID: 36727
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_0_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0;

			// Token: 0x04008F78 RID: 36728
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_3_Internal_Boolean_Int32_0;

			// Token: 0x04008F79 RID: 36729
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_4_Internal_Boolean_Int32_0;

			// Token: 0x04008F7A RID: 36730
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__22_5_Internal_String_Int32_String_0;
		}

		// Token: 0x02000C10 RID: 3088
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yorihime+<OnPositiveBuffExecute>d__20")]
		public sealed class _OnPositiveBuffExecute_d__20 : Il2CppSystem.Object
		{
			// Token: 0x0600E03D RID: 57405 RVA: 0x00362870 File Offset: 0x00360A70
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__20()
			{
				Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "<OnPositiveBuffExecute>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr);
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>1__state");
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>2__current");
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>4__this");
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, "spellExecutionContext");
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr__num_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<num>5__2");
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680246);
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680247);
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680248);
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680249);
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680250);
				Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100680251);
			}

			// Token: 0x0600E03E RID: 57406 RVA: 0x00362978 File Offset: 0x00360B78
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yorihime._OnPositiveBuffExecute_d__20>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E03F RID: 57407 RVA: 0x003629C0 File Offset: 0x00360BC0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E040 RID: 57408 RVA: 0x003629F4 File Offset: 0x00360BF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208227, XrefRangeEnd = 208272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048DA RID: 18650
			// (get) Token: 0x0600E041 RID: 57409 RVA: 0x00362A30 File Offset: 0x00360C30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E042 RID: 57410 RVA: 0x00362A70 File Offset: 0x00360C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208272, XrefRangeEnd = 208278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048DB RID: 18651
			// (get) Token: 0x0600E043 RID: 57411 RVA: 0x00362AA4 File Offset: 0x00360CA4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E044 RID: 57412 RVA: 0x00077AD8 File Offset: 0x00075CD8
			public _OnPositiveBuffExecute_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048D5 RID: 18645
			// (get) Token: 0x0600E045 RID: 57413 RVA: 0x00362AE4 File Offset: 0x00360CE4
			// (set) Token: 0x0600E046 RID: 57414 RVA: 0x00077AE1 File Offset: 0x00075CE1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048D6 RID: 18646
			// (get) Token: 0x0600E047 RID: 57415 RVA: 0x00362B0C File Offset: 0x00360D0C
			// (set) Token: 0x0600E048 RID: 57416 RVA: 0x00077AFC File Offset: 0x00075CFC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048D7 RID: 18647
			// (get) Token: 0x0600E049 RID: 57417 RVA: 0x00362B3C File Offset: 0x00360D3C
			// (set) Token: 0x0600E04A RID: 57418 RVA: 0x00077B1B File Offset: 0x00075D1B
			public unsafe Spell_Yorihime __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yorihime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048D8 RID: 18648
			// (get) Token: 0x0600E04B RID: 57419 RVA: 0x00362B6C File Offset: 0x00360D6C
			// (set) Token: 0x0600E04C RID: 57420 RVA: 0x00077B3A File Offset: 0x00075D3A
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048D9 RID: 18649
			// (get) Token: 0x0600E04D RID: 57421 RVA: 0x00362B9C File Offset: 0x00360D9C
			// (set) Token: 0x0600E04E RID: 57422 RVA: 0x00077B59 File Offset: 0x00075D59
			public unsafe int _num_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr__num_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr__num_5__2)) = value;
				}
			}

			// Token: 0x04008F7B RID: 36731
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F7C RID: 36732
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F7D RID: 36733
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F7E RID: 36734
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008F7F RID: 36735
			private static readonly IntPtr NativeFieldInfoPtr__num_5__2;

			// Token: 0x04008F80 RID: 36736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F81 RID: 36737
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F82 RID: 36738
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F83 RID: 36739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F84 RID: 36740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F85 RID: 36741
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C11 RID: 3089
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yorihime+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E04F RID: 57423 RVA: 0x00362BC4 File Offset: 0x00360DC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<Spell_Yorihime.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yorihime.__c__DisplayClass22_0>.NativeClassPtr);
				Spell_Yorihime.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				Spell_Yorihime.__c__DisplayClass22_0.NativeFieldInfoPtr_removeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime.__c__DisplayClass22_0>.NativeClassPtr, "removeCallback");
				Spell_Yorihime.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime.__c__DisplayClass22_0>.NativeClassPtr, 100680252);
				Spell_Yorihime.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime.__c__DisplayClass22_0>.NativeClassPtr, 100680253);
				Spell_Yorihime.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime.__c__DisplayClass22_0>.NativeClassPtr, 100680254);
			}

			// Token: 0x0600E050 RID: 57424 RVA: 0x00362C54 File Offset: 0x00360E54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yorihime.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E051 RID: 57425 RVA: 0x00362C90 File Offset: 0x00360E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208278, XrefRangeEnd = 208301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.__c__DisplayClass22_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E052 RID: 57426 RVA: 0x00362CD0 File Offset: 0x00360ED0
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E053 RID: 57427 RVA: 0x00077B74 File Offset: 0x00075D74
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048DC RID: 18652
			// (get) Token: 0x0600E054 RID: 57428 RVA: 0x00362D04 File Offset: 0x00360F04
			// (set) Token: 0x0600E055 RID: 57429 RVA: 0x00077B7D File Offset: 0x00075D7D
			public unsafe Spell_Yorihime __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yorihime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048DD RID: 18653
			// (get) Token: 0x0600E056 RID: 57430 RVA: 0x00362D34 File Offset: 0x00360F34
			// (set) Token: 0x0600E057 RID: 57431 RVA: 0x00077B9C File Offset: 0x00075D9C
			public unsafe Action removeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.__c__DisplayClass22_0.NativeFieldInfoPtr_removeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime.__c__DisplayClass22_0.NativeFieldInfoPtr_removeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F86 RID: 36742
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F87 RID: 36743
			private static readonly IntPtr NativeFieldInfoPtr_removeCallback;

			// Token: 0x04008F88 RID: 36744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F89 RID: 36745
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_Int32_0;

			// Token: 0x04008F8A RID: 36746
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000C12 RID: 3090
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yorihime+<OnNegativeBuffExecute>d__22")]
		public sealed class _OnNegativeBuffExecute_d__22 : Il2CppSystem.Object
		{
			// Token: 0x0600E058 RID: 57432 RVA: 0x00362D64 File Offset: 0x00360F64
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__22()
			{
				Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yorihime>.NativeClassPtr, "<OnNegativeBuffExecute>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr);
				Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>1__state");
				Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>2__current");
				Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>4__this");
				Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr, "<>8__1");
				Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680255);
				Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680256);
				Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680257);
				Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680258);
				Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680259);
				Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr, 100680260);
			}

			// Token: 0x0600E059 RID: 57433 RVA: 0x00362E58 File Offset: 0x00361058
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yorihime._OnNegativeBuffExecute_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E05A RID: 57434 RVA: 0x00362EA0 File Offset: 0x003610A0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E05B RID: 57435 RVA: 0x00362ED4 File Offset: 0x003610D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208301, XrefRangeEnd = 208331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048E2 RID: 18658
			// (get) Token: 0x0600E05C RID: 57436 RVA: 0x00362F10 File Offset: 0x00361110
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E05D RID: 57437 RVA: 0x00362F50 File Offset: 0x00361150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208331, XrefRangeEnd = 208337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048E3 RID: 18659
			// (get) Token: 0x0600E05E RID: 57438 RVA: 0x00362F84 File Offset: 0x00361184
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E05F RID: 57439 RVA: 0x00077BBB File Offset: 0x00075DBB
			public _OnNegativeBuffExecute_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048DE RID: 18654
			// (get) Token: 0x0600E060 RID: 57440 RVA: 0x00362FC4 File Offset: 0x003611C4
			// (set) Token: 0x0600E061 RID: 57441 RVA: 0x00077BC4 File Offset: 0x00075DC4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048DF RID: 18655
			// (get) Token: 0x0600E062 RID: 57442 RVA: 0x00362FEC File Offset: 0x003611EC
			// (set) Token: 0x0600E063 RID: 57443 RVA: 0x00077BDF File Offset: 0x00075DDF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048E0 RID: 18656
			// (get) Token: 0x0600E064 RID: 57444 RVA: 0x0036301C File Offset: 0x0036121C
			// (set) Token: 0x0600E065 RID: 57445 RVA: 0x00077BFE File Offset: 0x00075DFE
			public unsafe Spell_Yorihime __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yorihime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048E1 RID: 18657
			// (get) Token: 0x0600E066 RID: 57446 RVA: 0x0036304C File Offset: 0x0036124C
			// (set) Token: 0x0600E067 RID: 57447 RVA: 0x00077C1D File Offset: 0x00075E1D
			public unsafe Spell_Yorihime.__c__DisplayClass22_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yorihime.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yorihime._OnNegativeBuffExecute_d__22.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F8B RID: 36747
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F8C RID: 36748
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F8D RID: 36749
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F8E RID: 36750
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008F8F RID: 36751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F90 RID: 36752
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F91 RID: 36753
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F92 RID: 36754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F93 RID: 36755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F94 RID: 36756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
