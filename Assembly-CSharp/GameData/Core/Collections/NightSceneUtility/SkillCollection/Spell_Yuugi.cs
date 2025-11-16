using System;
using Common.VFX;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000295 RID: 661
	public class Spell_Yuugi : SpellBase
	{
		// Token: 0x060053A3 RID: 21411 RVA: 0x001B95E0 File Offset: 0x001B77E0
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Yuugi()
		{
			Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Yuugi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr);
			Spell_Yuugi.NativeFieldInfoPtr_level1BevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "level1BevNum");
			Spell_Yuugi.NativeFieldInfoPtr_level1BevTransRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "level1BevTransRate");
			Spell_Yuugi.NativeFieldInfoPtr_level2BevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "level2BevNum");
			Spell_Yuugi.NativeFieldInfoPtr_level2BevTransRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "level2BevTransRate");
			Spell_Yuugi.NativeFieldInfoPtr_level3BevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "level3BevNum");
			Spell_Yuugi.NativeFieldInfoPtr_level3BevTransRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "level3BevTransRate");
			Spell_Yuugi.NativeFieldInfoPtr_bowlEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "bowlEffect");
			Spell_Yuugi.NativeFieldInfoPtr_bowlOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "bowlOffset");
			Spell_Yuugi.NativeFieldInfoPtr_passionHappyEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "passionHappyEffect");
			Spell_Yuugi.NativeFieldInfoPtr_passionHappyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "passionHappyDuration");
			Spell_Yuugi.NativeFieldInfoPtr_removeBevEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "removeBevEffect");
			Spell_Yuugi.NativeFieldInfoPtr_getBevEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "getBevEffect");
			Spell_Yuugi.NativeFieldInfoPtr_threeStepsObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "threeStepsObject");
			Spell_Yuugi.NativeFieldInfoPtr_stunEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "stunEffect");
			Spell_Yuugi.NativeFieldInfoPtr_bulletEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "bulletEffect");
			Spell_Yuugi.NativeFieldInfoPtr_sinnerShacklesEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "sinnerShacklesEffect");
			Spell_Yuugi.NativeFieldInfoPtr_circle2MoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "circle2MoveSpeedMultiplier");
			Spell_Yuugi.NativeFieldInfoPtr_circle3StunTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "circle3StunTime");
			Spell_Yuugi.NativeFieldInfoPtr_circle1Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "circle1Radius");
			Spell_Yuugi.NativeFieldInfoPtr_circle2Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "circle2Radius");
			Spell_Yuugi.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "negativeDuration");
			Spell_Yuugi.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "rewardSFX");
			Spell_Yuugi.NativeFieldInfoPtr_punishmentSFX1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "punishmentSFX1");
			Spell_Yuugi.NativeFieldInfoPtr_punishmentSFX2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "punishmentSFX2");
			Spell_Yuugi.NativeFieldInfoPtr_bulletHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "bulletHit");
			Spell_Yuugi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, 100680361);
			Spell_Yuugi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, 100680362);
			Spell_Yuugi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, 100680363);
			Spell_Yuugi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, 100680364);
			Spell_Yuugi.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_Transform_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, 100680365);
			Spell_Yuugi.NativeMethodInfoPtr_Method_Internal_Static_GameObject_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, 100680366);
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x001B987C File Offset: 0x001B7A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209922, XrefRangeEnd = 209924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuugi.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x001B98C0 File Offset: 0x001B7AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209924, XrefRangeEnd = 209929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuugi.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x001B991C File Offset: 0x001B7B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209929, XrefRangeEnd = 209934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuugi.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x001B9978 File Offset: 0x001B7B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209934, XrefRangeEnd = 209935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Yuugi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x001B99B4 File Offset: 0x001B7BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209935, XrefRangeEnd = 209940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_Transform_PDM_0(Transform gameObject)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_Transform_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x001B99F8 File Offset: 0x001B7BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject Method_Internal_Static_GameObject_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.NativeMethodInfoPtr_Method_Internal_Static_GameObject_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x0002CEEA File Offset: 0x0002B0EA
		public Spell_Yuugi(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x060053AB RID: 21419 RVA: 0x001B9A2C File Offset: 0x001B7C2C
		// (set) Token: 0x060053AC RID: 21420 RVA: 0x0002CEF3 File Offset: 0x0002B0F3
		public unsafe int level1BevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level1BevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level1BevNum)) = value;
			}
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x060053AD RID: 21421 RVA: 0x001B9A54 File Offset: 0x001B7C54
		// (set) Token: 0x060053AE RID: 21422 RVA: 0x0002CF0E File Offset: 0x0002B10E
		public unsafe float level1BevTransRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level1BevTransRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level1BevTransRate)) = value;
			}
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x060053AF RID: 21423 RVA: 0x001B9A7C File Offset: 0x001B7C7C
		// (set) Token: 0x060053B0 RID: 21424 RVA: 0x0002CF29 File Offset: 0x0002B129
		public unsafe int level2BevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level2BevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level2BevNum)) = value;
			}
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x060053B1 RID: 21425 RVA: 0x001B9AA4 File Offset: 0x001B7CA4
		// (set) Token: 0x060053B2 RID: 21426 RVA: 0x0002CF44 File Offset: 0x0002B144
		public unsafe float level2BevTransRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level2BevTransRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level2BevTransRate)) = value;
			}
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x060053B3 RID: 21427 RVA: 0x001B9ACC File Offset: 0x001B7CCC
		// (set) Token: 0x060053B4 RID: 21428 RVA: 0x0002CF5F File Offset: 0x0002B15F
		public unsafe int level3BevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level3BevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level3BevNum)) = value;
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x060053B5 RID: 21429 RVA: 0x001B9AF4 File Offset: 0x001B7CF4
		// (set) Token: 0x060053B6 RID: 21430 RVA: 0x0002CF7A File Offset: 0x0002B17A
		public unsafe float level3BevTransRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level3BevTransRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_level3BevTransRate)) = value;
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x001B9B1C File Offset: 0x001B7D1C
		// (set) Token: 0x060053B8 RID: 21432 RVA: 0x0002CF95 File Offset: 0x0002B195
		public unsafe GameObject bowlEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_bowlEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_bowlEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x060053B9 RID: 21433 RVA: 0x001B9B4C File Offset: 0x001B7D4C
		// (set) Token: 0x060053BA RID: 21434 RVA: 0x0002CFB4 File Offset: 0x0002B1B4
		public unsafe Vector2 bowlOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_bowlOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_bowlOffset)) = value;
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x060053BB RID: 21435 RVA: 0x001B9B74 File Offset: 0x001B7D74
		// (set) Token: 0x060053BC RID: 21436 RVA: 0x0002CFCF File Offset: 0x0002B1CF
		public unsafe GameObject passionHappyEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_passionHappyEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_passionHappyEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x060053BD RID: 21437 RVA: 0x001B9BA4 File Offset: 0x001B7DA4
		// (set) Token: 0x060053BE RID: 21438 RVA: 0x0002CFEE File Offset: 0x0002B1EE
		public unsafe float passionHappyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_passionHappyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_passionHappyDuration)) = value;
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x060053BF RID: 21439 RVA: 0x001B9BCC File Offset: 0x001B7DCC
		// (set) Token: 0x060053C0 RID: 21440 RVA: 0x0002D009 File Offset: 0x0002B209
		public unsafe GameObject removeBevEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_removeBevEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_removeBevEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x060053C1 RID: 21441 RVA: 0x001B9BFC File Offset: 0x001B7DFC
		// (set) Token: 0x060053C2 RID: 21442 RVA: 0x0002D028 File Offset: 0x0002B228
		public unsafe GameObject getBevEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_getBevEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_getBevEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x060053C3 RID: 21443 RVA: 0x001B9C2C File Offset: 0x001B7E2C
		// (set) Token: 0x060053C4 RID: 21444 RVA: 0x0002D047 File Offset: 0x0002B247
		public unsafe GameObject threeStepsObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_threeStepsObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_threeStepsObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x060053C5 RID: 21445 RVA: 0x001B9C5C File Offset: 0x001B7E5C
		// (set) Token: 0x060053C6 RID: 21446 RVA: 0x0002D066 File Offset: 0x0002B266
		public unsafe GameObject stunEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_stunEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_stunEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x060053C7 RID: 21447 RVA: 0x001B9C8C File Offset: 0x001B7E8C
		// (set) Token: 0x060053C8 RID: 21448 RVA: 0x0002D085 File Offset: 0x0002B285
		public unsafe GameObject bulletEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_bulletEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_bulletEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x060053C9 RID: 21449 RVA: 0x001B9CBC File Offset: 0x001B7EBC
		// (set) Token: 0x060053CA RID: 21450 RVA: 0x0002D0A4 File Offset: 0x0002B2A4
		public unsafe GameObject sinnerShacklesEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_sinnerShacklesEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_sinnerShacklesEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x060053CB RID: 21451 RVA: 0x001B9CEC File Offset: 0x001B7EEC
		// (set) Token: 0x060053CC RID: 21452 RVA: 0x0002D0C3 File Offset: 0x0002B2C3
		public unsafe float circle2MoveSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_circle2MoveSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_circle2MoveSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x060053CD RID: 21453 RVA: 0x001B9D14 File Offset: 0x001B7F14
		// (set) Token: 0x060053CE RID: 21454 RVA: 0x0002D0DE File Offset: 0x0002B2DE
		public unsafe int circle3StunTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_circle3StunTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_circle3StunTime)) = value;
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x060053CF RID: 21455 RVA: 0x001B9D3C File Offset: 0x001B7F3C
		// (set) Token: 0x060053D0 RID: 21456 RVA: 0x0002D0F9 File Offset: 0x0002B2F9
		public unsafe float circle1Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_circle1Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_circle1Radius)) = value;
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x060053D1 RID: 21457 RVA: 0x001B9D64 File Offset: 0x001B7F64
		// (set) Token: 0x060053D2 RID: 21458 RVA: 0x0002D114 File Offset: 0x0002B314
		public unsafe float circle2Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_circle2Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_circle2Radius)) = value;
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x060053D3 RID: 21459 RVA: 0x001B9D8C File Offset: 0x001B7F8C
		// (set) Token: 0x060053D4 RID: 21460 RVA: 0x0002D12F File Offset: 0x0002B32F
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x060053D5 RID: 21461 RVA: 0x001B9DB4 File Offset: 0x001B7FB4
		// (set) Token: 0x060053D6 RID: 21462 RVA: 0x0002D14A File Offset: 0x0002B34A
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x060053D7 RID: 21463 RVA: 0x001B9DE4 File Offset: 0x001B7FE4
		// (set) Token: 0x060053D8 RID: 21464 RVA: 0x0002D169 File Offset: 0x0002B369
		public unsafe AudioClip punishmentSFX1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_punishmentSFX1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_punishmentSFX1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x060053D9 RID: 21465 RVA: 0x001B9E14 File Offset: 0x001B8014
		// (set) Token: 0x060053DA RID: 21466 RVA: 0x0002D188 File Offset: 0x0002B388
		public unsafe AudioClip punishmentSFX2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_punishmentSFX2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_punishmentSFX2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x060053DB RID: 21467 RVA: 0x001B9E44 File Offset: 0x001B8044
		// (set) Token: 0x060053DC RID: 21468 RVA: 0x0002D1A7 File Offset: 0x0002B3A7
		public unsafe AudioClip bulletHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_bulletHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.NativeFieldInfoPtr_bulletHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003843 RID: 14403
		private static readonly IntPtr NativeFieldInfoPtr_level1BevNum;

		// Token: 0x04003844 RID: 14404
		private static readonly IntPtr NativeFieldInfoPtr_level1BevTransRate;

		// Token: 0x04003845 RID: 14405
		private static readonly IntPtr NativeFieldInfoPtr_level2BevNum;

		// Token: 0x04003846 RID: 14406
		private static readonly IntPtr NativeFieldInfoPtr_level2BevTransRate;

		// Token: 0x04003847 RID: 14407
		private static readonly IntPtr NativeFieldInfoPtr_level3BevNum;

		// Token: 0x04003848 RID: 14408
		private static readonly IntPtr NativeFieldInfoPtr_level3BevTransRate;

		// Token: 0x04003849 RID: 14409
		private static readonly IntPtr NativeFieldInfoPtr_bowlEffect;

		// Token: 0x0400384A RID: 14410
		private static readonly IntPtr NativeFieldInfoPtr_bowlOffset;

		// Token: 0x0400384B RID: 14411
		private static readonly IntPtr NativeFieldInfoPtr_passionHappyEffect;

		// Token: 0x0400384C RID: 14412
		private static readonly IntPtr NativeFieldInfoPtr_passionHappyDuration;

		// Token: 0x0400384D RID: 14413
		private static readonly IntPtr NativeFieldInfoPtr_removeBevEffect;

		// Token: 0x0400384E RID: 14414
		private static readonly IntPtr NativeFieldInfoPtr_getBevEffect;

		// Token: 0x0400384F RID: 14415
		private static readonly IntPtr NativeFieldInfoPtr_threeStepsObject;

		// Token: 0x04003850 RID: 14416
		private static readonly IntPtr NativeFieldInfoPtr_stunEffect;

		// Token: 0x04003851 RID: 14417
		private static readonly IntPtr NativeFieldInfoPtr_bulletEffect;

		// Token: 0x04003852 RID: 14418
		private static readonly IntPtr NativeFieldInfoPtr_sinnerShacklesEffect;

		// Token: 0x04003853 RID: 14419
		private static readonly IntPtr NativeFieldInfoPtr_circle2MoveSpeedMultiplier;

		// Token: 0x04003854 RID: 14420
		private static readonly IntPtr NativeFieldInfoPtr_circle3StunTime;

		// Token: 0x04003855 RID: 14421
		private static readonly IntPtr NativeFieldInfoPtr_circle1Radius;

		// Token: 0x04003856 RID: 14422
		private static readonly IntPtr NativeFieldInfoPtr_circle2Radius;

		// Token: 0x04003857 RID: 14423
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003858 RID: 14424
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x04003859 RID: 14425
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX1;

		// Token: 0x0400385A RID: 14426
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX2;

		// Token: 0x0400385B RID: 14427
		private static readonly IntPtr NativeFieldInfoPtr_bulletHit;

		// Token: 0x0400385C RID: 14428
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400385D RID: 14429
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400385E RID: 14430
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400385F RID: 14431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003860 RID: 14432
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_Transform_PDM_0;

		// Token: 0x04003861 RID: 14433
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_GameObject_PDM_0;

		// Token: 0x02000C26 RID: 3110
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass26_0")]
		public new sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E140 RID: 57664 RVA: 0x003658CC File Offset: 0x00363ACC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr);
				Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "effect");
				Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_circle2Interrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "circle2Interrupt");
				Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_circle3Interrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "circle3Interrupt");
				Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_corotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "corotine");
				Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_shakeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "shakeCoroutine");
				Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_chainCorotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "chainCorotine");
				Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_haveCircle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "haveCircle2");
				Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_haveCircle3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "haveCircle3");
				Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "<>9__5");
				Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, 100680367);
				Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, 100680368);
				Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, 100680369);
				Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, 100680370);
				Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, 100680371);
				Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, 100680372);
			}

			// Token: 0x0600E141 RID: 57665 RVA: 0x00365A38 File Offset: 0x00363C38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E142 RID: 57666 RVA: 0x00365A74 File Offset: 0x00363C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209422, XrefRangeEnd = 209443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E143 RID: 57667 RVA: 0x00365AA8 File Offset: 0x00363CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209443, XrefRangeEnd = 209447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E144 RID: 57668 RVA: 0x00365ADC File Offset: 0x00363CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209447, XrefRangeEnd = 209452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E145 RID: 57669 RVA: 0x00365B1C File Offset: 0x00363D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209452, XrefRangeEnd = 209457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E146 RID: 57670 RVA: 0x00365B5C File Offset: 0x00363D5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209457, XrefRangeEnd = 209462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__5(int x, string y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E147 RID: 57671 RVA: 0x000782AC File Offset: 0x000764AC
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004924 RID: 18724
			// (get) Token: 0x0600E148 RID: 57672 RVA: 0x00365BB4 File Offset: 0x00363DB4
			// (set) Token: 0x0600E149 RID: 57673 RVA: 0x000782B5 File Offset: 0x000764B5
			public unsafe GameObject effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004925 RID: 18725
			// (get) Token: 0x0600E14A RID: 57674 RVA: 0x00365BE4 File Offset: 0x00363DE4
			// (set) Token: 0x0600E14B RID: 57675 RVA: 0x000782D4 File Offset: 0x000764D4
			public unsafe Action circle2Interrupt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_circle2Interrupt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_circle2Interrupt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004926 RID: 18726
			// (get) Token: 0x0600E14C RID: 57676 RVA: 0x00365C14 File Offset: 0x00363E14
			// (set) Token: 0x0600E14D RID: 57677 RVA: 0x000782F3 File Offset: 0x000764F3
			public unsafe Action circle3Interrupt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_circle3Interrupt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_circle3Interrupt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004927 RID: 18727
			// (get) Token: 0x0600E14E RID: 57678 RVA: 0x00365C44 File Offset: 0x00363E44
			// (set) Token: 0x0600E14F RID: 57679 RVA: 0x00078312 File Offset: 0x00076512
			public unsafe Coroutine corotine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_corotine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_corotine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004928 RID: 18728
			// (get) Token: 0x0600E150 RID: 57680 RVA: 0x00365C74 File Offset: 0x00363E74
			// (set) Token: 0x0600E151 RID: 57681 RVA: 0x00078331 File Offset: 0x00076531
			public unsafe Spell_Yuugi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004929 RID: 18729
			// (get) Token: 0x0600E152 RID: 57682 RVA: 0x00365CA4 File Offset: 0x00363EA4
			// (set) Token: 0x0600E153 RID: 57683 RVA: 0x00078350 File Offset: 0x00076550
			public unsafe Coroutine shakeCoroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_shakeCoroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_shakeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700492A RID: 18730
			// (get) Token: 0x0600E154 RID: 57684 RVA: 0x00365CD4 File Offset: 0x00363ED4
			// (set) Token: 0x0600E155 RID: 57685 RVA: 0x0007836F File Offset: 0x0007656F
			public unsafe Coroutine chainCorotine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_chainCorotine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_chainCorotine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700492B RID: 18731
			// (get) Token: 0x0600E156 RID: 57686 RVA: 0x00365D04 File Offset: 0x00363F04
			// (set) Token: 0x0600E157 RID: 57687 RVA: 0x0007838E File Offset: 0x0007658E
			public unsafe bool haveCircle2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_haveCircle2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_haveCircle2)) = value;
				}
			}

			// Token: 0x1700492C RID: 18732
			// (get) Token: 0x0600E158 RID: 57688 RVA: 0x00365D2C File Offset: 0x00363F2C
			// (set) Token: 0x0600E159 RID: 57689 RVA: 0x000783A9 File Offset: 0x000765A9
			public unsafe bool haveCircle3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_haveCircle3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr_haveCircle3)) = value;
				}
			}

			// Token: 0x1700492D RID: 18733
			// (get) Token: 0x0600E15A RID: 57690 RVA: 0x00365D54 File Offset: 0x00363F54
			// (set) Token: 0x0600E15B RID: 57691 RVA: 0x000783C4 File Offset: 0x000765C4
			public unsafe Func<int, string, string> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009013 RID: 36883
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x04009014 RID: 36884
			private static readonly IntPtr NativeFieldInfoPtr_circle2Interrupt;

			// Token: 0x04009015 RID: 36885
			private static readonly IntPtr NativeFieldInfoPtr_circle3Interrupt;

			// Token: 0x04009016 RID: 36886
			private static readonly IntPtr NativeFieldInfoPtr_corotine;

			// Token: 0x04009017 RID: 36887
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009018 RID: 36888
			private static readonly IntPtr NativeFieldInfoPtr_shakeCoroutine;

			// Token: 0x04009019 RID: 36889
			private static readonly IntPtr NativeFieldInfoPtr_chainCorotine;

			// Token: 0x0400901A RID: 36890
			private static readonly IntPtr NativeFieldInfoPtr_haveCircle2;

			// Token: 0x0400901B RID: 36891
			private static readonly IntPtr NativeFieldInfoPtr_haveCircle3;

			// Token: 0x0400901C RID: 36892
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x0400901D RID: 36893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400901E RID: 36894
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400901F RID: 36895
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Void_0;

			// Token: 0x04009020 RID: 36896
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009021 RID: 36897
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x04009022 RID: 36898
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_String_Int32_String_0;

			// Token: 0x02001051 RID: 4177
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass26_0+<<OnNegativeBuffExecute>g__Shake|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011DB6 RID: 73142 RVA: 0x00415F78 File Offset: 0x00414178
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Shake|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680373);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680374);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680375);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680376);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680377);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680378);
				}

				// Token: 0x06011DB7 RID: 73143 RVA: 0x00416058 File Offset: 0x00414258
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DB8 RID: 73144 RVA: 0x004160A0 File Offset: 0x004142A0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DB9 RID: 73145 RVA: 0x004160D4 File Offset: 0x004142D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209306, XrefRangeEnd = 209307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D10 RID: 23824
				// (get) Token: 0x06011DBA RID: 73146 RVA: 0x00416110 File Offset: 0x00414310
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011DBB RID: 73147 RVA: 0x00416150 File Offset: 0x00414350
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209307, XrefRangeEnd = 209313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D11 RID: 23825
				// (get) Token: 0x06011DBC RID: 73148 RVA: 0x00416184 File Offset: 0x00414384
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011DBD RID: 73149 RVA: 0x0009B1D6 File Offset: 0x000993D6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D0D RID: 23821
				// (get) Token: 0x06011DBE RID: 73150 RVA: 0x004161C4 File Offset: 0x004143C4
				// (set) Token: 0x06011DBF RID: 73151 RVA: 0x0009B1DF File Offset: 0x000993DF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D0E RID: 23822
				// (get) Token: 0x06011DC0 RID: 73152 RVA: 0x004161EC File Offset: 0x004143EC
				// (set) Token: 0x06011DC1 RID: 73153 RVA: 0x0009B1FA File Offset: 0x000993FA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D0F RID: 23823
				// (get) Token: 0x06011DC2 RID: 73154 RVA: 0x0041621C File Offset: 0x0041441C
				// (set) Token: 0x06011DC3 RID: 73155 RVA: 0x0009B219 File Offset: 0x00099419
				public unsafe Spell_Yuugi.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B47E RID: 46206
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B47F RID: 46207
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B480 RID: 46208
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B481 RID: 46209
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B482 RID: 46210
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B483 RID: 46211
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B484 RID: 46212
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B485 RID: 46213
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B486 RID: 46214
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001052 RID: 4178
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass26_0+<<OnNegativeBuffExecute>g__threeStepsKnockOutCheck|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011DC4 RID: 73156 RVA: 0x0041624C File Offset: 0x0041444C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique()
				{
					Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__threeStepsKnockOutCheck|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr__center_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, "<center>5__2");
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr__haveEnteredPhase2_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, "<haveEnteredPhase2>5__3");
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr__haveEnteredPhase3_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, "<haveEnteredPhase3>5__4");
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, 100680379);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, 100680380);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, 100680381);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, 100680382);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, 100680383);
					Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr, 100680384);
				}

				// Token: 0x06011DC5 RID: 73157 RVA: 0x00416368 File Offset: 0x00414568
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DC6 RID: 73158 RVA: 0x004163B0 File Offset: 0x004145B0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DC7 RID: 73159 RVA: 0x004163E4 File Offset: 0x004145E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209313, XrefRangeEnd = 209416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D18 RID: 23832
				// (get) Token: 0x06011DC8 RID: 73160 RVA: 0x00416420 File Offset: 0x00414620
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011DC9 RID: 73161 RVA: 0x00416460 File Offset: 0x00414660
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209416, XrefRangeEnd = 209422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D19 RID: 23833
				// (get) Token: 0x06011DCA RID: 73162 RVA: 0x00416494 File Offset: 0x00414694
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011DCB RID: 73163 RVA: 0x0009B238 File Offset: 0x00099438
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D12 RID: 23826
				// (get) Token: 0x06011DCC RID: 73164 RVA: 0x004164D4 File Offset: 0x004146D4
				// (set) Token: 0x06011DCD RID: 73165 RVA: 0x0009B241 File Offset: 0x00099441
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D13 RID: 23827
				// (get) Token: 0x06011DCE RID: 73166 RVA: 0x004164FC File Offset: 0x004146FC
				// (set) Token: 0x06011DCF RID: 73167 RVA: 0x0009B25C File Offset: 0x0009945C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D14 RID: 23828
				// (get) Token: 0x06011DD0 RID: 73168 RVA: 0x0041652C File Offset: 0x0041472C
				// (set) Token: 0x06011DD1 RID: 73169 RVA: 0x0009B27B File Offset: 0x0009947B
				public unsafe Spell_Yuugi.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D15 RID: 23829
				// (get) Token: 0x06011DD2 RID: 73170 RVA: 0x0041655C File Offset: 0x0041475C
				// (set) Token: 0x06011DD3 RID: 73171 RVA: 0x0009B29A File Offset: 0x0009949A
				public unsafe Vector3 _center_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr__center_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr__center_5__2)) = value;
					}
				}

				// Token: 0x17005D16 RID: 23830
				// (get) Token: 0x06011DD4 RID: 73172 RVA: 0x00416584 File Offset: 0x00414784
				// (set) Token: 0x06011DD5 RID: 73173 RVA: 0x0009B2B5 File Offset: 0x000994B5
				public unsafe bool _haveEnteredPhase2_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr__haveEnteredPhase2_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr__haveEnteredPhase2_5__3)) = value;
					}
				}

				// Token: 0x17005D17 RID: 23831
				// (get) Token: 0x06011DD6 RID: 73174 RVA: 0x004165AC File Offset: 0x004147AC
				// (set) Token: 0x06011DD7 RID: 73175 RVA: 0x0009B2D0 File Offset: 0x000994D0
				public unsafe bool _haveEnteredPhase3_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr__haveEnteredPhase3_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeBoBoObObUnique.NativeFieldInfoPtr__haveEnteredPhase3_5__4)) = value;
					}
				}

				// Token: 0x0400B487 RID: 46215
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B488 RID: 46216
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B489 RID: 46217
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B48A RID: 46218
				private static readonly IntPtr NativeFieldInfoPtr__center_5__2;

				// Token: 0x0400B48B RID: 46219
				private static readonly IntPtr NativeFieldInfoPtr__haveEnteredPhase2_5__3;

				// Token: 0x0400B48C RID: 46220
				private static readonly IntPtr NativeFieldInfoPtr__haveEnteredPhase3_5__4;

				// Token: 0x0400B48D RID: 46221
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B48E RID: 46222
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B48F RID: 46223
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B490 RID: 46224
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B491 RID: 46225
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B492 RID: 46226
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C27 RID: 3111
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass26_1")]
		public sealed class __c__DisplayClass26_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E15C RID: 57692 RVA: 0x00365D84 File Offset: 0x00363F84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_1()
			{
				Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<>c__DisplayClass26_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_1>.NativeClassPtr);
				Spell_Yuugi.__c__DisplayClass26_1.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_1>.NativeClassPtr, "effect");
				Spell_Yuugi.__c__DisplayClass26_1.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Yuugi.__c__DisplayClass26_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_1>.NativeClassPtr, 100680385);
				Spell_Yuugi.__c__DisplayClass26_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_1>.NativeClassPtr, 100680386);
			}

			// Token: 0x0600E15D RID: 57693 RVA: 0x00365E00 File Offset: 0x00364000
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E15E RID: 57694 RVA: 0x00365E3C File Offset: 0x0036403C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209462, XrefRangeEnd = 209473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E15F RID: 57695 RVA: 0x000783E3 File Offset: 0x000765E3
			public __c__DisplayClass26_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700492E RID: 18734
			// (get) Token: 0x0600E160 RID: 57696 RVA: 0x00365E70 File Offset: 0x00364070
			// (set) Token: 0x0600E161 RID: 57697 RVA: 0x000783EC File Offset: 0x000765EC
			public unsafe GameObject effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_1.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_1.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700492F RID: 18735
			// (get) Token: 0x0600E162 RID: 57698 RVA: 0x00365EA0 File Offset: 0x003640A0
			// (set) Token: 0x0600E163 RID: 57699 RVA: 0x0007840B File Offset: 0x0007660B
			public unsafe Spell_Yuugi.__c__DisplayClass26_0 field_Public___c__DisplayClass26_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_1.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass26_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_1.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009023 RID: 36899
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x04009024 RID: 36900
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0;

			// Token: 0x04009025 RID: 36901
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009026 RID: 36902
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_0;
		}

		// Token: 0x02000C28 RID: 3112
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass26_2")]
		public sealed class __c__DisplayClass26_2 : Il2CppSystem.Object
		{
			// Token: 0x0600E164 RID: 57700 RVA: 0x00365ED0 File Offset: 0x003640D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_2()
			{
				Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<>c__DisplayClass26_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_2>.NativeClassPtr);
				Spell_Yuugi.__c__DisplayClass26_2.NativeFieldInfoPtr_stunEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_2>.NativeClassPtr, "stunEffect");
				Spell_Yuugi.__c__DisplayClass26_2.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_2>.NativeClassPtr, "CS$<>8__locals2");
				Spell_Yuugi.__c__DisplayClass26_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_2>.NativeClassPtr, 100680387);
				Spell_Yuugi.__c__DisplayClass26_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_2>.NativeClassPtr, 100680388);
			}

			// Token: 0x0600E165 RID: 57701 RVA: 0x00365F4C File Offset: 0x0036414C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass26_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E166 RID: 57702 RVA: 0x00365F88 File Offset: 0x00364188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209473, XrefRangeEnd = 209484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass26_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E167 RID: 57703 RVA: 0x0007842A File Offset: 0x0007662A
			public __c__DisplayClass26_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004930 RID: 18736
			// (get) Token: 0x0600E168 RID: 57704 RVA: 0x00365FBC File Offset: 0x003641BC
			// (set) Token: 0x0600E169 RID: 57705 RVA: 0x00078433 File Offset: 0x00076633
			public unsafe DisplayProgress stunEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_2.NativeFieldInfoPtr_stunEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayProgress>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_2.NativeFieldInfoPtr_stunEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004931 RID: 18737
			// (get) Token: 0x0600E16A RID: 57706 RVA: 0x00365FEC File Offset: 0x003641EC
			// (set) Token: 0x0600E16B RID: 57707 RVA: 0x00078452 File Offset: 0x00076652
			public unsafe Spell_Yuugi.__c__DisplayClass26_0 field_Public___c__DisplayClass26_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_2.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass26_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass26_2.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009027 RID: 36903
			private static readonly IntPtr NativeFieldInfoPtr_stunEffect;

			// Token: 0x04009028 RID: 36904
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0;

			// Token: 0x04009029 RID: 36905
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400902A RID: 36906
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_0;
		}

		// Token: 0x02000C29 RID: 3113
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<OnNegativeBuffExecute>d__26")]
		public sealed class _OnNegativeBuffExecute_d__26 : Il2CppSystem.Object
		{
			// Token: 0x0600E16C RID: 57708 RVA: 0x0036601C File Offset: 0x0036421C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__26()
			{
				Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<OnNegativeBuffExecute>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr);
				Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr, "<>1__state");
				Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr, "<>2__current");
				Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr, "<>4__this");
				Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100680389);
				Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100680390);
				Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100680391);
				Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100680392);
				Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100680393);
				Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100680394);
			}

			// Token: 0x0600E16D RID: 57709 RVA: 0x003660FC File Offset: 0x003642FC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__26(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi._OnNegativeBuffExecute_d__26>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E16E RID: 57710 RVA: 0x00366144 File Offset: 0x00364344
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E16F RID: 57711 RVA: 0x00366178 File Offset: 0x00364378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209484, XrefRangeEnd = 209525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004935 RID: 18741
			// (get) Token: 0x0600E170 RID: 57712 RVA: 0x003661B4 File Offset: 0x003643B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E171 RID: 57713 RVA: 0x003661F4 File Offset: 0x003643F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209525, XrefRangeEnd = 209531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004936 RID: 18742
			// (get) Token: 0x0600E172 RID: 57714 RVA: 0x00366228 File Offset: 0x00364428
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E173 RID: 57715 RVA: 0x00078471 File Offset: 0x00076671
			public _OnNegativeBuffExecute_d__26(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004932 RID: 18738
			// (get) Token: 0x0600E174 RID: 57716 RVA: 0x00366268 File Offset: 0x00364468
			// (set) Token: 0x0600E175 RID: 57717 RVA: 0x0007847A File Offset: 0x0007667A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004933 RID: 18739
			// (get) Token: 0x0600E176 RID: 57718 RVA: 0x00366290 File Offset: 0x00364490
			// (set) Token: 0x0600E177 RID: 57719 RVA: 0x00078495 File Offset: 0x00076695
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004934 RID: 18740
			// (get) Token: 0x0600E178 RID: 57720 RVA: 0x003662C0 File Offset: 0x003644C0
			// (set) Token: 0x0600E179 RID: 57721 RVA: 0x000784B4 File Offset: 0x000766B4
			public unsafe Spell_Yuugi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400902B RID: 36907
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400902C RID: 36908
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400902D RID: 36909
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400902E RID: 36910
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400902F RID: 36911
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009030 RID: 36912
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009031 RID: 36913
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009032 RID: 36914
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009033 RID: 36915
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C2A RID: 3114
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E17A RID: 57722 RVA: 0x003662F0 File Offset: 0x003644F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr);
				Spell_Yuugi.__c__DisplayClass27_0.NativeFieldInfoPtr_bowl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr, "bowl");
				Spell_Yuugi.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				Spell_Yuugi.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr, 100680395);
				Spell_Yuugi.__c__DisplayClass27_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr, 100680396);
				Spell_Yuugi.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr, 100680397);
				Spell_Yuugi.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Int32_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr, 100680398);
			}

			// Token: 0x0600E17B RID: 57723 RVA: 0x00366394 File Offset: 0x00364594
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E17C RID: 57724 RVA: 0x003663D0 File Offset: 0x003645D0
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E17D RID: 57725 RVA: 0x00366414 File Offset: 0x00364614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209601, XrefRangeEnd = 209606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Int32_PDM_0(int bevID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref bevID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E17E RID: 57726 RVA: 0x00366460 File Offset: 0x00364660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209606, XrefRangeEnd = 209611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Int32_PDM_1(int bevID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref bevID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Int32_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E17F RID: 57727 RVA: 0x000784D3 File Offset: 0x000766D3
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004937 RID: 18743
			// (get) Token: 0x0600E180 RID: 57728 RVA: 0x003664AC File Offset: 0x003646AC
			// (set) Token: 0x0600E181 RID: 57729 RVA: 0x000784DC File Offset: 0x000766DC
			public unsafe GameObject bowl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.NativeFieldInfoPtr_bowl);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.NativeFieldInfoPtr_bowl), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004938 RID: 18744
			// (get) Token: 0x0600E182 RID: 57730 RVA: 0x003664DC File Offset: 0x003646DC
			// (set) Token: 0x0600E183 RID: 57731 RVA: 0x000784FB File Offset: 0x000766FB
			public unsafe Spell_Yuugi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009034 RID: 36916
			private static readonly IntPtr NativeFieldInfoPtr_bowl;

			// Token: 0x04009035 RID: 36917
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009036 RID: 36918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009037 RID: 36919
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04009038 RID: 36920
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Int32_PDM_0;

			// Token: 0x04009039 RID: 36921
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Int32_PDM_1;

			// Token: 0x02001053 RID: 4179
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass27_0+<<OnPositiveBuffExecute>g__RemoveBev|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0 : Il2CppSystem.Object
			{
				// Token: 0x06011DD8 RID: 73176 RVA: 0x004165D4 File Offset: 0x004147D4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0()
				{
					Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__RemoveBev|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, "<>1__state");
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, "<>2__current");
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, "<>4__this");
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr_bevID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, "bevID");
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, "<>8__1");
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, 100680399);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, 100680400);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, 100680401);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, 100680402);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, 100680403);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr, 100680404);
				}

				// Token: 0x06011DD9 RID: 73177 RVA: 0x004166DC File Offset: 0x004148DC
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DDA RID: 73178 RVA: 0x00416724 File Offset: 0x00414924
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DDB RID: 73179 RVA: 0x00416758 File Offset: 0x00414958
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209531, XrefRangeEnd = 209548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D1F RID: 23839
				// (get) Token: 0x06011DDC RID: 73180 RVA: 0x00416794 File Offset: 0x00414994
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011DDD RID: 73181 RVA: 0x004167D4 File Offset: 0x004149D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209548, XrefRangeEnd = 209554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D20 RID: 23840
				// (get) Token: 0x06011DDE RID: 73182 RVA: 0x00416808 File Offset: 0x00414A08
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011DDF RID: 73183 RVA: 0x0009B2EB File Offset: 0x000994EB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D1A RID: 23834
				// (get) Token: 0x06011DE0 RID: 73184 RVA: 0x00416848 File Offset: 0x00414A48
				// (set) Token: 0x06011DE1 RID: 73185 RVA: 0x0009B2F4 File Offset: 0x000994F4
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D1B RID: 23835
				// (get) Token: 0x06011DE2 RID: 73186 RVA: 0x00416870 File Offset: 0x00414A70
				// (set) Token: 0x06011DE3 RID: 73187 RVA: 0x0009B30F File Offset: 0x0009950F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D1C RID: 23836
				// (get) Token: 0x06011DE4 RID: 73188 RVA: 0x004168A0 File Offset: 0x00414AA0
				// (set) Token: 0x06011DE5 RID: 73189 RVA: 0x0009B32E File Offset: 0x0009952E
				public unsafe Spell_Yuugi.__c__DisplayClass27_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass27_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D1D RID: 23837
				// (get) Token: 0x06011DE6 RID: 73190 RVA: 0x004168D0 File Offset: 0x00414AD0
				// (set) Token: 0x06011DE7 RID: 73191 RVA: 0x0009B34D File Offset: 0x0009954D
				public unsafe int bevID
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr_bevID);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr_bevID)) = value;
					}
				}

				// Token: 0x17005D1E RID: 23838
				// (get) Token: 0x06011DE8 RID: 73192 RVA: 0x004168F8 File Offset: 0x00414AF8
				// (set) Token: 0x06011DE9 RID: 73193 RVA: 0x0009B368 File Offset: 0x00099568
				public unsafe Spell_Yuugi.__c__DisplayClass27_2 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass27_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb0.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B493 RID: 46227
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B494 RID: 46228
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B495 RID: 46229
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B496 RID: 46230
				private static readonly IntPtr NativeFieldInfoPtr_bevID;

				// Token: 0x0400B497 RID: 46231
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B498 RID: 46232
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B499 RID: 46233
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B49A RID: 46234
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B49B RID: 46235
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B49C RID: 46236
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B49D RID: 46237
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001054 RID: 4180
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass27_0+<<OnPositiveBuffExecute>g__GetBev|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1 : Il2CppSystem.Object
			{
				// Token: 0x06011DEA RID: 73194 RVA: 0x00416928 File Offset: 0x00414B28
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1()
				{
					Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__GetBev|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, "<>1__state");
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, "<>2__current");
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, "<>4__this");
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr_bevID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, "bevID");
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, "<>8__1");
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, 100680405);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, 100680406);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, 100680407);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, 100680408);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, 100680409);
					Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr, 100680410);
				}

				// Token: 0x06011DEB RID: 73195 RVA: 0x00416A30 File Offset: 0x00414C30
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DEC RID: 73196 RVA: 0x00416A78 File Offset: 0x00414C78
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DED RID: 73197 RVA: 0x00416AAC File Offset: 0x00414CAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209554, XrefRangeEnd = 209595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D26 RID: 23846
				// (get) Token: 0x06011DEE RID: 73198 RVA: 0x00416AE8 File Offset: 0x00414CE8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011DEF RID: 73199 RVA: 0x00416B28 File Offset: 0x00414D28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209595, XrefRangeEnd = 209601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D27 RID: 23847
				// (get) Token: 0x06011DF0 RID: 73200 RVA: 0x00416B5C File Offset: 0x00414D5C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011DF1 RID: 73201 RVA: 0x0009B387 File Offset: 0x00099587
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D21 RID: 23841
				// (get) Token: 0x06011DF2 RID: 73202 RVA: 0x00416B9C File Offset: 0x00414D9C
				// (set) Token: 0x06011DF3 RID: 73203 RVA: 0x0009B390 File Offset: 0x00099590
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D22 RID: 23842
				// (get) Token: 0x06011DF4 RID: 73204 RVA: 0x00416BC4 File Offset: 0x00414DC4
				// (set) Token: 0x06011DF5 RID: 73205 RVA: 0x0009B3AB File Offset: 0x000995AB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D23 RID: 23843
				// (get) Token: 0x06011DF6 RID: 73206 RVA: 0x00416BF4 File Offset: 0x00414DF4
				// (set) Token: 0x06011DF7 RID: 73207 RVA: 0x0009B3CA File Offset: 0x000995CA
				public unsafe Spell_Yuugi.__c__DisplayClass27_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass27_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D24 RID: 23844
				// (get) Token: 0x06011DF8 RID: 73208 RVA: 0x00416C24 File Offset: 0x00414E24
				// (set) Token: 0x06011DF9 RID: 73209 RVA: 0x0009B3E9 File Offset: 0x000995E9
				public unsafe int bevID
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr_bevID);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr_bevID)) = value;
					}
				}

				// Token: 0x17005D25 RID: 23845
				// (get) Token: 0x06011DFA RID: 73210 RVA: 0x00416C4C File Offset: 0x00414E4C
				// (set) Token: 0x06011DFB RID: 73211 RVA: 0x0009B404 File Offset: 0x00099604
				public unsafe Spell_Yuugi.__c__DisplayClass27_3 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass27_3>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbeInVoObMoVoBoOb1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B49E RID: 46238
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B49F RID: 46239
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B4A0 RID: 46240
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B4A1 RID: 46241
				private static readonly IntPtr NativeFieldInfoPtr_bevID;

				// Token: 0x0400B4A2 RID: 46242
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B4A3 RID: 46243
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B4A4 RID: 46244
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4A5 RID: 46245
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B4A6 RID: 46246
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B4A7 RID: 46247
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4A8 RID: 46248
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C2B RID: 3115
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass27_1")]
		public sealed class __c__DisplayClass27_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E184 RID: 57732 RVA: 0x0036650C File Offset: 0x0036470C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_1()
			{
				Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<>c__DisplayClass27_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_1>.NativeClassPtr);
				Spell_Yuugi.__c__DisplayClass27_1.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_1>.NativeClassPtr, "item");
				Spell_Yuugi.__c__DisplayClass27_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_1>.NativeClassPtr, 100680411);
				Spell_Yuugi.__c__DisplayClass27_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_1>.NativeClassPtr, 100680412);
			}

			// Token: 0x0600E185 RID: 57733 RVA: 0x00366574 File Offset: 0x00364774
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E186 RID: 57734 RVA: 0x003665B0 File Offset: 0x003647B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__4(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E187 RID: 57735 RVA: 0x0007851A File Offset: 0x0007671A
			public __c__DisplayClass27_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004939 RID: 18745
			// (get) Token: 0x0600E188 RID: 57736 RVA: 0x003665F4 File Offset: 0x003647F4
			// (set) Token: 0x0600E189 RID: 57737 RVA: 0x00078523 File Offset: 0x00076723
			public unsafe Vector3 item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_1.NativeFieldInfoPtr_item);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_1.NativeFieldInfoPtr_item)) = value;
				}
			}

			// Token: 0x0400903A RID: 36922
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x0400903B RID: 36923
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400903C RID: 36924
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_GameObject_0;
		}

		// Token: 0x02000C2C RID: 3116
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass27_2")]
		public sealed class __c__DisplayClass27_2 : Il2CppSystem.Object
		{
			// Token: 0x0600E18A RID: 57738 RVA: 0x0036661C File Offset: 0x0036481C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_2()
			{
				Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<>c__DisplayClass27_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_2>.NativeClassPtr);
				Spell_Yuugi.__c__DisplayClass27_2.NativeFieldInfoPtr_bev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_2>.NativeClassPtr, "bev");
				Spell_Yuugi.__c__DisplayClass27_2.NativeFieldInfoPtr_bevID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_2>.NativeClassPtr, "bevID");
				Spell_Yuugi.__c__DisplayClass27_2.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_2>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Yuugi.__c__DisplayClass27_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_2>.NativeClassPtr, 100680413);
				Spell_Yuugi.__c__DisplayClass27_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_2>.NativeClassPtr, 100680414);
				Spell_Yuugi.__c__DisplayClass27_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_2>.NativeClassPtr, 100680415);
				Spell_Yuugi.__c__DisplayClass27_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_2>.NativeClassPtr, 100680416);
			}

			// Token: 0x0600E18B RID: 57739 RVA: 0x003666D4 File Offset: 0x003648D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E18C RID: 57740 RVA: 0x00366710 File Offset: 0x00364910
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__11(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E18D RID: 57741 RVA: 0x00366754 File Offset: 0x00364954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209611, XrefRangeEnd = 209615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__12(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E18E RID: 57742 RVA: 0x00366798 File Offset: 0x00364998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209615, XrefRangeEnd = 209619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E18F RID: 57743 RVA: 0x0007853E File Offset: 0x0007673E
			public __c__DisplayClass27_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700493A RID: 18746
			// (get) Token: 0x0600E190 RID: 57744 RVA: 0x003667D4 File Offset: 0x003649D4
			// (set) Token: 0x0600E191 RID: 57745 RVA: 0x00078547 File Offset: 0x00076747
			public unsafe GameObject bev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_2.NativeFieldInfoPtr_bev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_2.NativeFieldInfoPtr_bev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700493B RID: 18747
			// (get) Token: 0x0600E192 RID: 57746 RVA: 0x00366804 File Offset: 0x00364A04
			// (set) Token: 0x0600E193 RID: 57747 RVA: 0x00078566 File Offset: 0x00076766
			public unsafe int bevID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_2.NativeFieldInfoPtr_bevID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_2.NativeFieldInfoPtr_bevID)) = value;
				}
			}

			// Token: 0x1700493C RID: 18748
			// (get) Token: 0x0600E194 RID: 57748 RVA: 0x0036682C File Offset: 0x00364A2C
			// (set) Token: 0x0600E195 RID: 57749 RVA: 0x00078581 File Offset: 0x00076781
			public unsafe Spell_Yuugi.__c__DisplayClass27_0 field_Public___c__DisplayClass27_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_2.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass27_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_2.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400903D RID: 36925
			private static readonly IntPtr NativeFieldInfoPtr_bev;

			// Token: 0x0400903E RID: 36926
			private static readonly IntPtr NativeFieldInfoPtr_bevID;

			// Token: 0x0400903F RID: 36927
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0;

			// Token: 0x04009040 RID: 36928
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009041 RID: 36929
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Void_GameObject_0;

			// Token: 0x04009042 RID: 36930
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__12_Internal_Void_SpriteRenderer_0;

			// Token: 0x04009043 RID: 36931
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_Internal_Vector3_0;
		}

		// Token: 0x02000C2D RID: 3117
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c__DisplayClass27_3")]
		public sealed class __c__DisplayClass27_3 : Il2CppSystem.Object
		{
			// Token: 0x0600E196 RID: 57750 RVA: 0x0036685C File Offset: 0x00364A5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_3()
			{
				Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<>c__DisplayClass27_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_3>.NativeClassPtr);
				Spell_Yuugi.__c__DisplayClass27_3.NativeFieldInfoPtr_bev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_3>.NativeClassPtr, "bev");
				Spell_Yuugi.__c__DisplayClass27_3.NativeFieldInfoPtr_bevID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_3>.NativeClassPtr, "bevID");
				Spell_Yuugi.__c__DisplayClass27_3.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_3>.NativeClassPtr, "CS$<>8__locals2");
				Spell_Yuugi.__c__DisplayClass27_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_3>.NativeClassPtr, 100680417);
				Spell_Yuugi.__c__DisplayClass27_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_3>.NativeClassPtr, 100680418);
				Spell_Yuugi.__c__DisplayClass27_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_3>.NativeClassPtr, 100680419);
				Spell_Yuugi.__c__DisplayClass27_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_3>.NativeClassPtr, 100680420);
			}

			// Token: 0x0600E197 RID: 57751 RVA: 0x00366914 File Offset: 0x00364B14
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c__DisplayClass27_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E198 RID: 57752 RVA: 0x00366950 File Offset: 0x00364B50
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__14(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E199 RID: 57753 RVA: 0x00366994 File Offset: 0x00364B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__15(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E19A RID: 57754 RVA: 0x003669D8 File Offset: 0x00364BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209619, XrefRangeEnd = 209622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__16()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c__DisplayClass27_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E19B RID: 57755 RVA: 0x000785A0 File Offset: 0x000767A0
			public __c__DisplayClass27_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700493D RID: 18749
			// (get) Token: 0x0600E19C RID: 57756 RVA: 0x00366A14 File Offset: 0x00364C14
			// (set) Token: 0x0600E19D RID: 57757 RVA: 0x000785A9 File Offset: 0x000767A9
			public unsafe GameObject bev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_3.NativeFieldInfoPtr_bev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_3.NativeFieldInfoPtr_bev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700493E RID: 18750
			// (get) Token: 0x0600E19E RID: 57758 RVA: 0x00366A44 File Offset: 0x00364C44
			// (set) Token: 0x0600E19F RID: 57759 RVA: 0x000785C8 File Offset: 0x000767C8
			public unsafe int bevID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_3.NativeFieldInfoPtr_bevID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_3.NativeFieldInfoPtr_bevID)) = value;
				}
			}

			// Token: 0x1700493F RID: 18751
			// (get) Token: 0x0600E1A0 RID: 57760 RVA: 0x00366A6C File Offset: 0x00364C6C
			// (set) Token: 0x0600E1A1 RID: 57761 RVA: 0x000785E3 File Offset: 0x000767E3
			public unsafe Spell_Yuugi.__c__DisplayClass27_0 field_Public___c__DisplayClass27_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_3.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass27_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.__c__DisplayClass27_3.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009044 RID: 36932
			private static readonly IntPtr NativeFieldInfoPtr_bev;

			// Token: 0x04009045 RID: 36933
			private static readonly IntPtr NativeFieldInfoPtr_bevID;

			// Token: 0x04009046 RID: 36934
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0;

			// Token: 0x04009047 RID: 36935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009048 RID: 36936
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_Internal_Void_GameObject_0;

			// Token: 0x04009049 RID: 36937
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_Internal_Void_SpriteRenderer_0;

			// Token: 0x0400904A RID: 36938
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_Internal_Vector3_0;
		}

		// Token: 0x02000C2E RID: 3118
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E1A2 RID: 57762 RVA: 0x00366A9C File Offset: 0x00364C9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr);
				Spell_Yuugi.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, "<>9");
				Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, "<>9__27_1");
				Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, "<>9__27_5");
				Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, "<>9__27_6");
				Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, "<>9__27_7");
				Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, "<>9__27_8");
				Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, "<>9__27_9");
				Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, "<>9__27_10");
				Spell_Yuugi.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, 100680422);
				Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_1_Internal_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, 100680423);
				Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_5_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, 100680424);
				Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_6_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, 100680425);
				Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_7_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, 100680426);
				Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_8_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, 100680427);
				Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_9_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, 100680428);
				Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_10_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr, 100680429);
			}

			// Token: 0x0600E1A3 RID: 57763 RVA: 0x00366C08 File Offset: 0x00364E08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1A4 RID: 57764 RVA: 0x00366C44 File Offset: 0x00364E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _OnPositiveBuffExecute_b__27_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_1_Internal_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600E1A5 RID: 57765 RVA: 0x00366C90 File Offset: 0x00364E90
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__27_5(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_5_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1A6 RID: 57766 RVA: 0x00366CE0 File Offset: 0x00364EE0
			[CallerCount(0)]
			public unsafe int _OnPositiveBuffExecute_b__27_6(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_6_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1A7 RID: 57767 RVA: 0x00366D30 File Offset: 0x00364F30
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__27_7(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_7_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1A8 RID: 57768 RVA: 0x00366D80 File Offset: 0x00364F80
			[CallerCount(0)]
			public unsafe int _OnPositiveBuffExecute_b__27_8(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_8_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1A9 RID: 57769 RVA: 0x00366DD0 File Offset: 0x00364FD0
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__27_9(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_9_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1AA RID: 57770 RVA: 0x00366E20 File Offset: 0x00365020
			[CallerCount(0)]
			public unsafe int _OnPositiveBuffExecute_b__27_10(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_10_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1AB RID: 57771 RVA: 0x00078602 File Offset: 0x00076802
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004940 RID: 18752
			// (get) Token: 0x0600E1AC RID: 57772 RVA: 0x00366E70 File Offset: 0x00365070
			// (set) Token: 0x0600E1AD RID: 57773 RVA: 0x0007860B File Offset: 0x0007680B
			public unsafe static Spell_Yuugi.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004941 RID: 18753
			// (get) Token: 0x0600E1AE RID: 57774 RVA: 0x00366E98 File Offset: 0x00365098
			// (set) Token: 0x0600E1AF RID: 57775 RVA: 0x0007861D File Offset: 0x0007681D
			public unsafe static Func<int, Sellable> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004942 RID: 18754
			// (get) Token: 0x0600E1B0 RID: 57776 RVA: 0x00366EC0 File Offset: 0x003650C0
			// (set) Token: 0x0600E1B1 RID: 57777 RVA: 0x0007862F File Offset: 0x0007682F
			public unsafe static Func<Sellable, bool> __9__27_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004943 RID: 18755
			// (get) Token: 0x0600E1B2 RID: 57778 RVA: 0x00366EE8 File Offset: 0x003650E8
			// (set) Token: 0x0600E1B3 RID: 57779 RVA: 0x00078641 File Offset: 0x00076841
			public unsafe static Func<Sellable, int> __9__27_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004944 RID: 18756
			// (get) Token: 0x0600E1B4 RID: 57780 RVA: 0x00366F10 File Offset: 0x00365110
			// (set) Token: 0x0600E1B5 RID: 57781 RVA: 0x00078653 File Offset: 0x00076853
			public unsafe static Func<Sellable, bool> __9__27_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004945 RID: 18757
			// (get) Token: 0x0600E1B6 RID: 57782 RVA: 0x00366F38 File Offset: 0x00365138
			// (set) Token: 0x0600E1B7 RID: 57783 RVA: 0x00078665 File Offset: 0x00076865
			public unsafe static Func<Sellable, int> __9__27_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004946 RID: 18758
			// (get) Token: 0x0600E1B8 RID: 57784 RVA: 0x00366F60 File Offset: 0x00365160
			// (set) Token: 0x0600E1B9 RID: 57785 RVA: 0x00078677 File Offset: 0x00076877
			public unsafe static Func<Sellable, bool> __9__27_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004947 RID: 18759
			// (get) Token: 0x0600E1BA RID: 57786 RVA: 0x00366F88 File Offset: 0x00365188
			// (set) Token: 0x0600E1BB RID: 57787 RVA: 0x00078689 File Offset: 0x00076889
			public unsafe static Func<Sellable, int> __9__27_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuugi.__c.NativeFieldInfoPtr___9__27_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400904B RID: 36939
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400904C RID: 36940
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x0400904D RID: 36941
			private static readonly IntPtr NativeFieldInfoPtr___9__27_5;

			// Token: 0x0400904E RID: 36942
			private static readonly IntPtr NativeFieldInfoPtr___9__27_6;

			// Token: 0x0400904F RID: 36943
			private static readonly IntPtr NativeFieldInfoPtr___9__27_7;

			// Token: 0x04009050 RID: 36944
			private static readonly IntPtr NativeFieldInfoPtr___9__27_8;

			// Token: 0x04009051 RID: 36945
			private static readonly IntPtr NativeFieldInfoPtr___9__27_9;

			// Token: 0x04009052 RID: 36946
			private static readonly IntPtr NativeFieldInfoPtr___9__27_10;

			// Token: 0x04009053 RID: 36947
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009054 RID: 36948
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_1_Internal_Sellable_Int32_0;

			// Token: 0x04009055 RID: 36949
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_5_Internal_Boolean_Sellable_0;

			// Token: 0x04009056 RID: 36950
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_6_Internal_Int32_Sellable_0;

			// Token: 0x04009057 RID: 36951
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_7_Internal_Boolean_Sellable_0;

			// Token: 0x04009058 RID: 36952
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_8_Internal_Int32_Sellable_0;

			// Token: 0x04009059 RID: 36953
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_9_Internal_Boolean_Sellable_0;

			// Token: 0x0400905A RID: 36954
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__27_10_Internal_Int32_Sellable_0;
		}

		// Token: 0x02000C2F RID: 3119
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<OnPositiveBuffExecute>d__27")]
		public sealed class _OnPositiveBuffExecute_d__27 : Il2CppSystem.Object
		{
			// Token: 0x0600E1BC RID: 57788 RVA: 0x00366FB0 File Offset: 0x003651B0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__27()
			{
				Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<OnPositiveBuffExecute>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr);
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<>1__state");
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<>2__current");
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<>4__this");
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<>8__1");
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr__toTrans_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<toTrans>5__2");
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr__finalGets_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<finalGets>5__3");
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr__wait_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<wait>5__4");
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<>7__wrap4");
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100680430);
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100680431);
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100680432);
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100680433);
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100680434);
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100680435);
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100680436);
				Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100680437);
			}

			// Token: 0x0600E1BD RID: 57789 RVA: 0x0036711C File Offset: 0x0036531C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__27(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi._OnPositiveBuffExecute_d__27>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1BE RID: 57790 RVA: 0x00367164 File Offset: 0x00365364
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1BF RID: 57791 RVA: 0x00367198 File Offset: 0x00365398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209622, XrefRangeEnd = 209896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1C0 RID: 57792 RVA: 0x003671D4 File Offset: 0x003653D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209896, XrefRangeEnd = 209899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1C1 RID: 57793 RVA: 0x00367208 File Offset: 0x00365408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209899, XrefRangeEnd = 209902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004950 RID: 18768
			// (get) Token: 0x0600E1C2 RID: 57794 RVA: 0x0036723C File Offset: 0x0036543C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E1C3 RID: 57795 RVA: 0x0036727C File Offset: 0x0036547C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209902, XrefRangeEnd = 209908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004951 RID: 18769
			// (get) Token: 0x0600E1C4 RID: 57796 RVA: 0x003672B0 File Offset: 0x003654B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E1C5 RID: 57797 RVA: 0x0007869B File Offset: 0x0007689B
			public _OnPositiveBuffExecute_d__27(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004948 RID: 18760
			// (get) Token: 0x0600E1C6 RID: 57798 RVA: 0x003672F0 File Offset: 0x003654F0
			// (set) Token: 0x0600E1C7 RID: 57799 RVA: 0x000786A4 File Offset: 0x000768A4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004949 RID: 18761
			// (get) Token: 0x0600E1C8 RID: 57800 RVA: 0x00367318 File Offset: 0x00365518
			// (set) Token: 0x0600E1C9 RID: 57801 RVA: 0x000786BF File Offset: 0x000768BF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700494A RID: 18762
			// (get) Token: 0x0600E1CA RID: 57802 RVA: 0x00367348 File Offset: 0x00365548
			// (set) Token: 0x0600E1CB RID: 57803 RVA: 0x000786DE File Offset: 0x000768DE
			public unsafe Spell_Yuugi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700494B RID: 18763
			// (get) Token: 0x0600E1CC RID: 57804 RVA: 0x00367378 File Offset: 0x00365578
			// (set) Token: 0x0600E1CD RID: 57805 RVA: 0x000786FD File Offset: 0x000768FD
			public unsafe Spell_Yuugi.__c__DisplayClass27_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuugi.__c__DisplayClass27_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700494C RID: 18764
			// (get) Token: 0x0600E1CE RID: 57806 RVA: 0x003673A8 File Offset: 0x003655A8
			// (set) Token: 0x0600E1CF RID: 57807 RVA: 0x0007871C File Offset: 0x0007691C
			public unsafe List<int> _toTrans_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr__toTrans_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr__toTrans_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700494D RID: 18765
			// (get) Token: 0x0600E1D0 RID: 57808 RVA: 0x003673D8 File Offset: 0x003655D8
			// (set) Token: 0x0600E1D1 RID: 57809 RVA: 0x0007873B File Offset: 0x0007693B
			public unsafe List<int> _finalGets_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr__finalGets_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr__finalGets_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700494E RID: 18766
			// (get) Token: 0x0600E1D2 RID: 57810 RVA: 0x00367408 File Offset: 0x00365608
			// (set) Token: 0x0600E1D3 RID: 57811 RVA: 0x0007875A File Offset: 0x0007695A
			public unsafe WaitForSeconds _wait_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr__wait_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr__wait_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700494F RID: 18767
			// (get) Token: 0x0600E1D4 RID: 57812 RVA: 0x00367438 File Offset: 0x00365638
			// (set) Token: 0x0600E1D5 RID: 57813 RVA: 0x00078779 File Offset: 0x00076979
			public List<int>.Enumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___7__wrap4);
					return new List<int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400905B RID: 36955
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400905C RID: 36956
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400905D RID: 36957
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400905E RID: 36958
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400905F RID: 36959
			private static readonly IntPtr NativeFieldInfoPtr__toTrans_5__2;

			// Token: 0x04009060 RID: 36960
			private static readonly IntPtr NativeFieldInfoPtr__finalGets_5__3;

			// Token: 0x04009061 RID: 36961
			private static readonly IntPtr NativeFieldInfoPtr__wait_5__4;

			// Token: 0x04009062 RID: 36962
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04009063 RID: 36963
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009064 RID: 36964
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009065 RID: 36965
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009066 RID: 36966
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04009067 RID: 36967
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04009068 RID: 36968
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009069 RID: 36969
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400906A RID: 36970
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C30 RID: 3120
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuugi+<<OnNegativeBuffExecute>g__Follow|26_6>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E1D6 RID: 57814 RVA: 0x00367468 File Offset: 0x00365668
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique()
			{
				Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuugi>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Follow|26_6>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr);
				Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr, "<>1__state");
				Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr, "<>2__current");
				Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr, "gameObject");
				Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr, 100680438);
				Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr, 100680439);
				Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr, 100680440);
				Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr, 100680441);
				Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr, 100680442);
				Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr, 100680443);
			}

			// Token: 0x0600E1D7 RID: 57815 RVA: 0x00367548 File Offset: 0x00365748
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1D8 RID: 57816 RVA: 0x00367590 File Offset: 0x00365790
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1D9 RID: 57817 RVA: 0x003675C4 File Offset: 0x003657C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209908, XrefRangeEnd = 209916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004955 RID: 18773
			// (get) Token: 0x0600E1DA RID: 57818 RVA: 0x00367600 File Offset: 0x00365800
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E1DB RID: 57819 RVA: 0x00367640 File Offset: 0x00365840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209916, XrefRangeEnd = 209922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004956 RID: 18774
			// (get) Token: 0x0600E1DC RID: 57820 RVA: 0x00367674 File Offset: 0x00365874
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E1DD RID: 57821 RVA: 0x000787A7 File Offset: 0x000769A7
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004952 RID: 18770
			// (get) Token: 0x0600E1DE RID: 57822 RVA: 0x003676B4 File Offset: 0x003658B4
			// (set) Token: 0x0600E1DF RID: 57823 RVA: 0x000787B0 File Offset: 0x000769B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004953 RID: 18771
			// (get) Token: 0x0600E1E0 RID: 57824 RVA: 0x003676DC File Offset: 0x003658DC
			// (set) Token: 0x0600E1E1 RID: 57825 RVA: 0x000787CB File Offset: 0x000769CB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004954 RID: 18772
			// (get) Token: 0x0600E1E2 RID: 57826 RVA: 0x0036770C File Offset: 0x0036590C
			// (set) Token: 0x0600E1E3 RID: 57827 RVA: 0x000787EA File Offset: 0x000769EA
			public unsafe Transform gameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeFieldInfoPtr_gameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuugi.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrgaObObUnique.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400906B RID: 36971
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400906C RID: 36972
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400906D RID: 36973
			private static readonly IntPtr NativeFieldInfoPtr_gameObject;

			// Token: 0x0400906E RID: 36974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400906F RID: 36975
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009070 RID: 36976
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009071 RID: 36977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009072 RID: 36978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009073 RID: 36979
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
