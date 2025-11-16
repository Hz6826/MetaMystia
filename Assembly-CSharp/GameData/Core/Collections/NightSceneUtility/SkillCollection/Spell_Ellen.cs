using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.EventSystem.Spells.SpecialItem;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000262 RID: 610
	public class Spell_Ellen : SpellBase
	{
		// Token: 0x06004B84 RID: 19332 RVA: 0x001A4A30 File Offset: 0x001A2C30
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Ellen()
		{
			Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Ellen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr);
			Spell_Ellen.NativeFieldInfoPtr_candy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "candy");
			Spell_Ellen.NativeFieldInfoPtr_candyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "candyId");
			Spell_Ellen.NativeFieldInfoPtr_candyBuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "candyBuffDuration");
			Spell_Ellen.NativeFieldInfoPtr_candyOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "candyOffsetX");
			Spell_Ellen.NativeFieldInfoPtr_candyOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "candyOffsetY");
			Spell_Ellen.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "negativeDuration");
			Spell_Ellen.NativeFieldInfoPtr_blackCatSpeedModifer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "blackCatSpeedModifer");
			Spell_Ellen.NativeFieldInfoPtr_blackCatWorkSpeedModifer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "blackCatWorkSpeedModifer");
			Spell_Ellen.NativeFieldInfoPtr_startCandy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "startCandy");
			Spell_Ellen.NativeFieldInfoPtr_candayVfxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "candayVfxDuration");
			Spell_Ellen.NativeFieldInfoPtr_candayVfxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "candayVfxOffset");
			Spell_Ellen.NativeFieldInfoPtr_catVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "catVfx");
			Spell_Ellen.NativeFieldInfoPtr_catIntimidateVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "catIntimidateVfx");
			Spell_Ellen.NativeFieldInfoPtr_catOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "catOffset");
			Spell_Ellen.NativeFieldInfoPtr_catIntimidateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "catIntimidateOffset");
			Spell_Ellen.NativeFieldInfoPtr_getCandy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "getCandy");
			Spell_Ellen.NativeFieldInfoPtr_negativeSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "negativeSfx");
			Spell_Ellen.NativeFieldInfoPtr_positiveSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "positiveSfx");
			Spell_Ellen.NativeFieldInfoPtr_positiveSfx2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "positiveSfx2");
			Spell_Ellen.NativeFieldInfoPtr_positiveCandyDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "positiveCandyDrop");
			Spell_Ellen.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, 100678494);
			Spell_Ellen.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, 100678495);
			Spell_Ellen.NativeMethodInfoPtr_CandyPartySet_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, 100678496);
			Spell_Ellen.NativeMethodInfoPtr_CandyParty_Private_Void_EvaluationResult_GuestGroupController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, 100678497);
			Spell_Ellen.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, 100678498);
			Spell_Ellen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, 100678499);
			Spell_Ellen.NativeMethodInfoPtr__OnPositiveBuffExecute_b__21_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, 100678500);
			Spell_Ellen.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, 100678501);
			Spell_Ellen.NativeMethodInfoPtr__OnPositiveBuffExecute_b__21_2_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, 100678502);
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x001A4CA4 File Offset: 0x001A2EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195809, XrefRangeEnd = 195811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Ellen.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x001A4CE8 File Offset: 0x001A2EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195811, XrefRangeEnd = 195817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Ellen.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x001A4D44 File Offset: 0x001A2F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195817, XrefRangeEnd = 195829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CandyPartySet(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.NativeMethodInfoPtr_CandyPartySet_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x001A4D88 File Offset: 0x001A2F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195829, XrefRangeEnd = 195858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CandyParty(GuestGroupController.EvaluationResult eval, GuestGroupController guestGroupController, bool _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eval;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.NativeMethodInfoPtr_CandyParty_Private_Void_EvaluationResult_GuestGroupController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x001A4DE8 File Offset: 0x001A2FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195858, XrefRangeEnd = 195864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Ellen.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x001A4E44 File Offset: 0x001A3044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195864, XrefRangeEnd = 195865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Ellen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x001A4E80 File Offset: 0x001A3080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195865, XrefRangeEnd = 195873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__21_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.NativeMethodInfoPtr__OnPositiveBuffExecute_b__21_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x001A4EC0 File Offset: 0x001A30C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195873, XrefRangeEnd = 195893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x001A4EF4 File Offset: 0x001A30F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195893, XrefRangeEnd = 195905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__21_2(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.NativeMethodInfoPtr__OnPositiveBuffExecute_b__21_2_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x00026D5B File Offset: 0x00024F5B
		public Spell_Ellen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06004B8F RID: 19343 RVA: 0x001A4F38 File Offset: 0x001A3138
		// (set) Token: 0x06004B90 RID: 19344 RVA: 0x00026D64 File Offset: 0x00024F64
		public unsafe GameObject candy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06004B91 RID: 19345 RVA: 0x001A4F68 File Offset: 0x001A3168
		// (set) Token: 0x06004B92 RID: 19346 RVA: 0x00026D83 File Offset: 0x00024F83
		public unsafe int candyId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candyId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candyId)) = value;
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x001A4F90 File Offset: 0x001A3190
		// (set) Token: 0x06004B94 RID: 19348 RVA: 0x00026D9E File Offset: 0x00024F9E
		public unsafe float candyBuffDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candyBuffDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candyBuffDuration)) = value;
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06004B95 RID: 19349 RVA: 0x001A4FB8 File Offset: 0x001A31B8
		// (set) Token: 0x06004B96 RID: 19350 RVA: 0x00026DB9 File Offset: 0x00024FB9
		public unsafe Vector2 candyOffsetX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candyOffsetX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candyOffsetX)) = value;
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x06004B97 RID: 19351 RVA: 0x001A4FE0 File Offset: 0x001A31E0
		// (set) Token: 0x06004B98 RID: 19352 RVA: 0x00026DD4 File Offset: 0x00024FD4
		public unsafe Vector2 candyOffsetY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candyOffsetY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candyOffsetY)) = value;
			}
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06004B99 RID: 19353 RVA: 0x001A5008 File Offset: 0x001A3208
		// (set) Token: 0x06004B9A RID: 19354 RVA: 0x00026DEF File Offset: 0x00024FEF
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06004B9B RID: 19355 RVA: 0x001A5030 File Offset: 0x001A3230
		// (set) Token: 0x06004B9C RID: 19356 RVA: 0x00026E0A File Offset: 0x0002500A
		public unsafe float blackCatSpeedModifer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_blackCatSpeedModifer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_blackCatSpeedModifer)) = value;
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06004B9D RID: 19357 RVA: 0x001A5058 File Offset: 0x001A3258
		// (set) Token: 0x06004B9E RID: 19358 RVA: 0x00026E25 File Offset: 0x00025025
		public unsafe float blackCatWorkSpeedModifer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_blackCatWorkSpeedModifer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_blackCatWorkSpeedModifer)) = value;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06004B9F RID: 19359 RVA: 0x001A5080 File Offset: 0x001A3280
		// (set) Token: 0x06004BA0 RID: 19360 RVA: 0x00026E40 File Offset: 0x00025040
		public unsafe GameObject startCandy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_startCandy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_startCandy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x001A50B0 File Offset: 0x001A32B0
		// (set) Token: 0x06004BA2 RID: 19362 RVA: 0x00026E5F File Offset: 0x0002505F
		public unsafe float candayVfxDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candayVfxDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candayVfxDuration)) = value;
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x001A50D8 File Offset: 0x001A32D8
		// (set) Token: 0x06004BA4 RID: 19364 RVA: 0x00026E7A File Offset: 0x0002507A
		public unsafe Vector3 candayVfxOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candayVfxOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_candayVfxOffset)) = value;
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x001A5100 File Offset: 0x001A3300
		// (set) Token: 0x06004BA6 RID: 19366 RVA: 0x00026E95 File Offset: 0x00025095
		public unsafe GameObject catVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_catVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_catVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06004BA7 RID: 19367 RVA: 0x001A5130 File Offset: 0x001A3330
		// (set) Token: 0x06004BA8 RID: 19368 RVA: 0x00026EB4 File Offset: 0x000250B4
		public unsafe GameObject catIntimidateVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_catIntimidateVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_catIntimidateVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06004BA9 RID: 19369 RVA: 0x001A5160 File Offset: 0x001A3360
		// (set) Token: 0x06004BAA RID: 19370 RVA: 0x00026ED3 File Offset: 0x000250D3
		public unsafe Vector2 catOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_catOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_catOffset)) = value;
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06004BAB RID: 19371 RVA: 0x001A5188 File Offset: 0x001A3388
		// (set) Token: 0x06004BAC RID: 19372 RVA: 0x00026EEE File Offset: 0x000250EE
		public unsafe Vector2 catIntimidateOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_catIntimidateOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_catIntimidateOffset)) = value;
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x06004BAD RID: 19373 RVA: 0x001A51B0 File Offset: 0x001A33B0
		// (set) Token: 0x06004BAE RID: 19374 RVA: 0x00026F09 File Offset: 0x00025109
		public unsafe AudioClip getCandy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_getCandy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_getCandy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x06004BAF RID: 19375 RVA: 0x001A51E0 File Offset: 0x001A33E0
		// (set) Token: 0x06004BB0 RID: 19376 RVA: 0x00026F28 File Offset: 0x00025128
		public SpellBase.DelayAudioClip negativeSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_negativeSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_negativeSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x06004BB1 RID: 19377 RVA: 0x001A5210 File Offset: 0x001A3410
		// (set) Token: 0x06004BB2 RID: 19378 RVA: 0x00026F56 File Offset: 0x00025156
		public SpellBase.DelayAudioClip positiveSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_positiveSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_positiveSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x06004BB3 RID: 19379 RVA: 0x001A5240 File Offset: 0x001A3440
		// (set) Token: 0x06004BB4 RID: 19380 RVA: 0x00026F84 File Offset: 0x00025184
		public SpellBase.DelayAudioClip positiveSfx2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_positiveSfx2);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_positiveSfx2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06004BB5 RID: 19381 RVA: 0x001A5270 File Offset: 0x001A3470
		// (set) Token: 0x06004BB6 RID: 19382 RVA: 0x00026FB2 File Offset: 0x000251B2
		public SpellBase.DelayAudioClip positiveCandyDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_positiveCandyDrop);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.NativeFieldInfoPtr_positiveCandyDrop), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040033CA RID: 13258
		private static readonly IntPtr NativeFieldInfoPtr_candy;

		// Token: 0x040033CB RID: 13259
		private static readonly IntPtr NativeFieldInfoPtr_candyId;

		// Token: 0x040033CC RID: 13260
		private static readonly IntPtr NativeFieldInfoPtr_candyBuffDuration;

		// Token: 0x040033CD RID: 13261
		private static readonly IntPtr NativeFieldInfoPtr_candyOffsetX;

		// Token: 0x040033CE RID: 13262
		private static readonly IntPtr NativeFieldInfoPtr_candyOffsetY;

		// Token: 0x040033CF RID: 13263
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x040033D0 RID: 13264
		private static readonly IntPtr NativeFieldInfoPtr_blackCatSpeedModifer;

		// Token: 0x040033D1 RID: 13265
		private static readonly IntPtr NativeFieldInfoPtr_blackCatWorkSpeedModifer;

		// Token: 0x040033D2 RID: 13266
		private static readonly IntPtr NativeFieldInfoPtr_startCandy;

		// Token: 0x040033D3 RID: 13267
		private static readonly IntPtr NativeFieldInfoPtr_candayVfxDuration;

		// Token: 0x040033D4 RID: 13268
		private static readonly IntPtr NativeFieldInfoPtr_candayVfxOffset;

		// Token: 0x040033D5 RID: 13269
		private static readonly IntPtr NativeFieldInfoPtr_catVfx;

		// Token: 0x040033D6 RID: 13270
		private static readonly IntPtr NativeFieldInfoPtr_catIntimidateVfx;

		// Token: 0x040033D7 RID: 13271
		private static readonly IntPtr NativeFieldInfoPtr_catOffset;

		// Token: 0x040033D8 RID: 13272
		private static readonly IntPtr NativeFieldInfoPtr_catIntimidateOffset;

		// Token: 0x040033D9 RID: 13273
		private static readonly IntPtr NativeFieldInfoPtr_getCandy;

		// Token: 0x040033DA RID: 13274
		private static readonly IntPtr NativeFieldInfoPtr_negativeSfx;

		// Token: 0x040033DB RID: 13275
		private static readonly IntPtr NativeFieldInfoPtr_positiveSfx;

		// Token: 0x040033DC RID: 13276
		private static readonly IntPtr NativeFieldInfoPtr_positiveSfx2;

		// Token: 0x040033DD RID: 13277
		private static readonly IntPtr NativeFieldInfoPtr_positiveCandyDrop;

		// Token: 0x040033DE RID: 13278
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040033DF RID: 13279
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040033E0 RID: 13280
		private static readonly IntPtr NativeMethodInfoPtr_CandyPartySet_Private_Void_GuestGroupController_0;

		// Token: 0x040033E1 RID: 13281
		private static readonly IntPtr NativeMethodInfoPtr_CandyParty_Private_Void_EvaluationResult_GuestGroupController_Boolean_0;

		// Token: 0x040033E2 RID: 13282
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040033E3 RID: 13283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040033E4 RID: 13284
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__21_0_Private_Void_Int32_0;

		// Token: 0x040033E5 RID: 13285
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x040033E6 RID: 13286
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__21_2_Private_Void_GuestGroupController_0;

		// Token: 0x02000B14 RID: 2836
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Ellen+<OnPositiveBuffExecute>d__21")]
		public sealed class _OnPositiveBuffExecute_d__21 : Il2CppSystem.Object
		{
			// Token: 0x0600D289 RID: 53897 RVA: 0x0033949C File Offset: 0x0033769C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__21()
			{
				Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "<OnPositiveBuffExecute>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr);
				Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr, "<>1__state");
				Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr, "<>2__current");
				Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr, "<>4__this");
				Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr, "spellExecutionContext");
				Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr, 100678503);
				Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr, 100678504);
				Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr, 100678505);
				Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr, 100678506);
				Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr, 100678507);
				Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr, 100678508);
			}

			// Token: 0x0600D28A RID: 53898 RVA: 0x00339590 File Offset: 0x00337790
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ellen._OnPositiveBuffExecute_d__21>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D28B RID: 53899 RVA: 0x003395D8 File Offset: 0x003377D8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D28C RID: 53900 RVA: 0x0033960C File Offset: 0x0033780C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195665, XrefRangeEnd = 195694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004489 RID: 17545
			// (get) Token: 0x0600D28D RID: 53901 RVA: 0x00339648 File Offset: 0x00337848
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D28E RID: 53902 RVA: 0x00339688 File Offset: 0x00337888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195694, XrefRangeEnd = 195700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700448A RID: 17546
			// (get) Token: 0x0600D28F RID: 53903 RVA: 0x003396BC File Offset: 0x003378BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D290 RID: 53904 RVA: 0x00070CBE File Offset: 0x0006EEBE
			public _OnPositiveBuffExecute_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004485 RID: 17541
			// (get) Token: 0x0600D291 RID: 53905 RVA: 0x003396FC File Offset: 0x003378FC
			// (set) Token: 0x0600D292 RID: 53906 RVA: 0x00070CC7 File Offset: 0x0006EEC7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004486 RID: 17542
			// (get) Token: 0x0600D293 RID: 53907 RVA: 0x00339724 File Offset: 0x00337924
			// (set) Token: 0x0600D294 RID: 53908 RVA: 0x00070CE2 File Offset: 0x0006EEE2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004487 RID: 17543
			// (get) Token: 0x0600D295 RID: 53909 RVA: 0x00339754 File Offset: 0x00337954
			// (set) Token: 0x0600D296 RID: 53910 RVA: 0x00070D01 File Offset: 0x0006EF01
			public unsafe Spell_Ellen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Ellen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004488 RID: 17544
			// (get) Token: 0x0600D297 RID: 53911 RVA: 0x00339784 File Offset: 0x00337984
			// (set) Token: 0x0600D298 RID: 53912 RVA: 0x00070D20 File Offset: 0x0006EF20
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnPositiveBuffExecute_d__21.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008733 RID: 34611
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008734 RID: 34612
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008735 RID: 34613
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008736 RID: 34614
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008737 RID: 34615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008738 RID: 34616
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008739 RID: 34617
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400873A RID: 34618
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400873B RID: 34619
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400873C RID: 34620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B15 RID: 2837
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Ellen+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D299 RID: 53913 RVA: 0x003397B4 File Offset: 0x003379B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass23_0>.NativeClassPtr);
				Spell_Ellen.__c__DisplayClass23_0.NativeFieldInfoPtr_tablePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass23_0>.NativeClassPtr, "tablePosition");
				Spell_Ellen.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				Spell_Ellen.__c__DisplayClass23_0.NativeFieldInfoPtr_tryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass23_0>.NativeClassPtr, "tryTime");
				Spell_Ellen.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass23_0>.NativeClassPtr, 100678509);
				Spell_Ellen.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass23_0>.NativeClassPtr, 100678510);
				Spell_Ellen.__c__DisplayClass23_0.NativeMethodInfoPtr__CandyParty_b__1_Internal_Void_Ellen_Candy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass23_0>.NativeClassPtr, 100678511);
			}

			// Token: 0x0600D29A RID: 53914 RVA: 0x00339858 File Offset: 0x00337A58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D29B RID: 53915 RVA: 0x00339894 File Offset: 0x00337A94
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 195717, RefRangeEnd = 195719, XrefRangeStart = 195700, XrefRangeEnd = 195717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 Method_Internal_Vector3_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D29C RID: 53916 RVA: 0x003398D0 File Offset: 0x00337AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195719, XrefRangeEnd = 195725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CandyParty_b__1(Ellen_Candy _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass23_0.NativeMethodInfoPtr__CandyParty_b__1_Internal_Void_Ellen_Candy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D29D RID: 53917 RVA: 0x00070D3F File Offset: 0x0006EF3F
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700448B RID: 17547
			// (get) Token: 0x0600D29E RID: 53918 RVA: 0x00339914 File Offset: 0x00337B14
			// (set) Token: 0x0600D29F RID: 53919 RVA: 0x00070D48 File Offset: 0x0006EF48
			public unsafe Vector3 tablePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass23_0.NativeFieldInfoPtr_tablePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass23_0.NativeFieldInfoPtr_tablePosition)) = value;
				}
			}

			// Token: 0x1700448C RID: 17548
			// (get) Token: 0x0600D2A0 RID: 53920 RVA: 0x0033993C File Offset: 0x00337B3C
			// (set) Token: 0x0600D2A1 RID: 53921 RVA: 0x00070D63 File Offset: 0x0006EF63
			public unsafe Spell_Ellen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Ellen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700448D RID: 17549
			// (get) Token: 0x0600D2A2 RID: 53922 RVA: 0x0033996C File Offset: 0x00337B6C
			// (set) Token: 0x0600D2A3 RID: 53923 RVA: 0x00070D82 File Offset: 0x0006EF82
			public unsafe int tryTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass23_0.NativeFieldInfoPtr_tryTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass23_0.NativeFieldInfoPtr_tryTime)) = value;
				}
			}

			// Token: 0x0400873D RID: 34621
			private static readonly IntPtr NativeFieldInfoPtr_tablePosition;

			// Token: 0x0400873E RID: 34622
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400873F RID: 34623
			private static readonly IntPtr NativeFieldInfoPtr_tryTime;

			// Token: 0x04008740 RID: 34624
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008741 RID: 34625
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Vector3_0;

			// Token: 0x04008742 RID: 34626
			private static readonly IntPtr NativeMethodInfoPtr__CandyParty_b__1_Internal_Void_Ellen_Candy_0;
		}

		// Token: 0x02000B16 RID: 2838
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Ellen+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2A4 RID: 53924 RVA: 0x00339994 File Offset: 0x00337B94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_0>.NativeClassPtr);
				Spell_Ellen.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				Spell_Ellen.__c__DisplayClass24_0.NativeFieldInfoPtr_speedVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_0>.NativeClassPtr, "speedVfx");
				Spell_Ellen.__c__DisplayClass24_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_0>.NativeClassPtr, "<>9__3");
				Spell_Ellen.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_0>.NativeClassPtr, 100678512);
				Spell_Ellen.__c__DisplayClass24_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_0>.NativeClassPtr, 100678513);
				Spell_Ellen.__c__DisplayClass24_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_0>.NativeClassPtr, 100678514);
				Spell_Ellen.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_0>.NativeClassPtr, 100678515);
			}

			// Token: 0x0600D2A5 RID: 53925 RVA: 0x00339A4C File Offset: 0x00337C4C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2A6 RID: 53926 RVA: 0x00339A88 File Offset: 0x00337C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195725, XrefRangeEnd = 195744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2A7 RID: 53927 RVA: 0x00339AC8 File Offset: 0x00337CC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195744, XrefRangeEnd = 195758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__3(int currentTime, string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D2A8 RID: 53928 RVA: 0x00339B20 File Offset: 0x00337D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195758, XrefRangeEnd = 195762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2A9 RID: 53929 RVA: 0x00070D9D File Offset: 0x0006EF9D
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700448E RID: 17550
			// (get) Token: 0x0600D2AA RID: 53930 RVA: 0x00339B54 File Offset: 0x00337D54
			// (set) Token: 0x0600D2AB RID: 53931 RVA: 0x00070DA6 File Offset: 0x0006EFA6
			public unsafe Spell_Ellen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Ellen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700448F RID: 17551
			// (get) Token: 0x0600D2AC RID: 53932 RVA: 0x00339B84 File Offset: 0x00337D84
			// (set) Token: 0x0600D2AD RID: 53933 RVA: 0x00070DC5 File Offset: 0x0006EFC5
			public unsafe int speedVfx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_0.NativeFieldInfoPtr_speedVfx);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_0.NativeFieldInfoPtr_speedVfx)) = value;
				}
			}

			// Token: 0x17004490 RID: 17552
			// (get) Token: 0x0600D2AE RID: 53934 RVA: 0x00339BAC File Offset: 0x00337DAC
			// (set) Token: 0x0600D2AF RID: 53935 RVA: 0x00070DE0 File Offset: 0x0006EFE0
			public unsafe Func<int, string, string> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008743 RID: 34627
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008744 RID: 34628
			private static readonly IntPtr NativeFieldInfoPtr_speedVfx;

			// Token: 0x04008745 RID: 34629
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04008746 RID: 34630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008747 RID: 34631
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_Int32_0;

			// Token: 0x04008748 RID: 34632
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_String_Int32_String_0;

			// Token: 0x04008749 RID: 34633
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000B17 RID: 2839
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Ellen+<>c__DisplayClass24_1")]
		public sealed class __c__DisplayClass24_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D2B0 RID: 53936 RVA: 0x00339BDC File Offset: 0x00337DDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_1()
			{
				Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "<>c__DisplayClass24_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1>.NativeClassPtr);
				Spell_Ellen.__c__DisplayClass24_1.NativeFieldInfoPtr_partnerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1>.NativeClassPtr, "partnerTransform");
				Spell_Ellen.__c__DisplayClass24_1.NativeFieldInfoPtr_vfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1>.NativeClassPtr, "vfx");
				Spell_Ellen.__c__DisplayClass24_1.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Ellen.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1>.NativeClassPtr, 100678516);
				Spell_Ellen.__c__DisplayClass24_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1>.NativeClassPtr, 100678517);
			}

			// Token: 0x0600D2B1 RID: 53937 RVA: 0x00339C6C File Offset: 0x00337E6C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2B2 RID: 53938 RVA: 0x00339CA8 File Offset: 0x00337EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195782, XrefRangeEnd = 195787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D2B3 RID: 53939 RVA: 0x00070DFF File Offset: 0x0006EFFF
			public __c__DisplayClass24_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004491 RID: 17553
			// (get) Token: 0x0600D2B4 RID: 53940 RVA: 0x00339CE8 File Offset: 0x00337EE8
			// (set) Token: 0x0600D2B5 RID: 53941 RVA: 0x00070E08 File Offset: 0x0006F008
			public unsafe Transform partnerTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.NativeFieldInfoPtr_partnerTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.NativeFieldInfoPtr_partnerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004492 RID: 17554
			// (get) Token: 0x0600D2B6 RID: 53942 RVA: 0x00339D18 File Offset: 0x00337F18
			// (set) Token: 0x0600D2B7 RID: 53943 RVA: 0x00070E27 File Offset: 0x0006F027
			public unsafe GameObject vfx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.NativeFieldInfoPtr_vfx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.NativeFieldInfoPtr_vfx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004493 RID: 17555
			// (get) Token: 0x0600D2B8 RID: 53944 RVA: 0x00339D48 File Offset: 0x00337F48
			// (set) Token: 0x0600D2B9 RID: 53945 RVA: 0x00070E46 File Offset: 0x0006F046
			public unsafe Spell_Ellen.__c__DisplayClass24_0 field_Public___c__DisplayClass24_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Ellen.__c__DisplayClass24_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400874A RID: 34634
			private static readonly IntPtr NativeFieldInfoPtr_partnerTransform;

			// Token: 0x0400874B RID: 34635
			private static readonly IntPtr NativeFieldInfoPtr_vfx;

			// Token: 0x0400874C RID: 34636
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0;

			// Token: 0x0400874D RID: 34637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400874E RID: 34638
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001027 RID: 4135
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Ellen+<>c__DisplayClass24_1+<<OnNegativeBuffExecute>g__Delay|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011B16 RID: 72470 RVA: 0x0040DE10 File Offset: 0x0040C010
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Delay|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr);
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisPartner_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<thisPartner>5__2");
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisVfx_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, "<thisVfx>5__3");
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100678518);
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100678519);
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100678520);
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100678521);
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100678522);
					Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr, 100678523);
				}

				// Token: 0x06011B17 RID: 72471 RVA: 0x0040DF18 File Offset: 0x0040C118
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B18 RID: 72472 RVA: 0x0040DF60 File Offset: 0x0040C160
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B19 RID: 72473 RVA: 0x0040DF94 File Offset: 0x0040C194
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195762, XrefRangeEnd = 195776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C16 RID: 23574
				// (get) Token: 0x06011B1A RID: 72474 RVA: 0x0040DFD0 File Offset: 0x0040C1D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B1B RID: 72475 RVA: 0x0040E010 File Offset: 0x0040C210
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195776, XrefRangeEnd = 195782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C17 RID: 23575
				// (get) Token: 0x06011B1C RID: 72476 RVA: 0x0040E044 File Offset: 0x0040C244
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B1D RID: 72477 RVA: 0x00099CF0 File Offset: 0x00097EF0
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C11 RID: 23569
				// (get) Token: 0x06011B1E RID: 72478 RVA: 0x0040E084 File Offset: 0x0040C284
				// (set) Token: 0x06011B1F RID: 72479 RVA: 0x00099CF9 File Offset: 0x00097EF9
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C12 RID: 23570
				// (get) Token: 0x06011B20 RID: 72480 RVA: 0x0040E0AC File Offset: 0x0040C2AC
				// (set) Token: 0x06011B21 RID: 72481 RVA: 0x00099D14 File Offset: 0x00097F14
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C13 RID: 23571
				// (get) Token: 0x06011B22 RID: 72482 RVA: 0x0040E0DC File Offset: 0x0040C2DC
				// (set) Token: 0x06011B23 RID: 72483 RVA: 0x00099D33 File Offset: 0x00097F33
				public unsafe Spell_Ellen.__c__DisplayClass24_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Ellen.__c__DisplayClass24_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C14 RID: 23572
				// (get) Token: 0x06011B24 RID: 72484 RVA: 0x0040E10C File Offset: 0x0040C30C
				// (set) Token: 0x06011B25 RID: 72485 RVA: 0x00099D52 File Offset: 0x00097F52
				public unsafe Transform _thisPartner_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisPartner_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisPartner_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C15 RID: 23573
				// (get) Token: 0x06011B26 RID: 72486 RVA: 0x0040E13C File Offset: 0x0040C33C
				// (set) Token: 0x06011B27 RID: 72487 RVA: 0x00099D71 File Offset: 0x00097F71
				public unsafe GameObject _thisVfx_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisVfx_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen.__c__DisplayClass24_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrGaObObUnique.NativeFieldInfoPtr__thisVfx_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B2DA RID: 45786
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B2DB RID: 45787
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B2DC RID: 45788
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B2DD RID: 45789
				private static readonly IntPtr NativeFieldInfoPtr__thisPartner_5__2;

				// Token: 0x0400B2DE RID: 45790
				private static readonly IntPtr NativeFieldInfoPtr__thisVfx_5__3;

				// Token: 0x0400B2DF RID: 45791
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B2E0 RID: 45792
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2E1 RID: 45793
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B2E2 RID: 45794
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B2E3 RID: 45795
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2E4 RID: 45796
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B18 RID: 2840
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Ellen+<OnNegativeBuffExecute>d__24")]
		public sealed class _OnNegativeBuffExecute_d__24 : Il2CppSystem.Object
		{
			// Token: 0x0600D2BA RID: 53946 RVA: 0x00339D78 File Offset: 0x00337F78
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__24()
			{
				Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Ellen>.NativeClassPtr, "<OnNegativeBuffExecute>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr);
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<>1__state");
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<>2__current");
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<>4__this");
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, "spellExecutionContext");
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<>8__1");
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100678524);
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100678525);
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100678526);
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100678527);
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100678528);
				Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100678529);
			}

			// Token: 0x0600D2BB RID: 53947 RVA: 0x00339E80 File Offset: 0x00338080
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Ellen._OnNegativeBuffExecute_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2BC RID: 53948 RVA: 0x00339EC8 File Offset: 0x003380C8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2BD RID: 53949 RVA: 0x00339EFC File Offset: 0x003380FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195787, XrefRangeEnd = 195803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004499 RID: 17561
			// (get) Token: 0x0600D2BE RID: 53950 RVA: 0x00339F38 File Offset: 0x00338138
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D2BF RID: 53951 RVA: 0x00339F78 File Offset: 0x00338178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195803, XrefRangeEnd = 195809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700449A RID: 17562
			// (get) Token: 0x0600D2C0 RID: 53952 RVA: 0x00339FAC File Offset: 0x003381AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D2C1 RID: 53953 RVA: 0x00070E65 File Offset: 0x0006F065
			public _OnNegativeBuffExecute_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004494 RID: 17556
			// (get) Token: 0x0600D2C2 RID: 53954 RVA: 0x00339FEC File Offset: 0x003381EC
			// (set) Token: 0x0600D2C3 RID: 53955 RVA: 0x00070E6E File Offset: 0x0006F06E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004495 RID: 17557
			// (get) Token: 0x0600D2C4 RID: 53956 RVA: 0x0033A014 File Offset: 0x00338214
			// (set) Token: 0x0600D2C5 RID: 53957 RVA: 0x00070E89 File Offset: 0x0006F089
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004496 RID: 17558
			// (get) Token: 0x0600D2C6 RID: 53958 RVA: 0x0033A044 File Offset: 0x00338244
			// (set) Token: 0x0600D2C7 RID: 53959 RVA: 0x00070EA8 File Offset: 0x0006F0A8
			public unsafe Spell_Ellen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Ellen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004497 RID: 17559
			// (get) Token: 0x0600D2C8 RID: 53960 RVA: 0x0033A074 File Offset: 0x00338274
			// (set) Token: 0x0600D2C9 RID: 53961 RVA: 0x00070EC7 File Offset: 0x0006F0C7
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004498 RID: 17560
			// (get) Token: 0x0600D2CA RID: 53962 RVA: 0x0033A0A4 File Offset: 0x003382A4
			// (set) Token: 0x0600D2CB RID: 53963 RVA: 0x00070EE6 File Offset: 0x0006F0E6
			public unsafe Spell_Ellen.__c__DisplayClass24_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Ellen.__c__DisplayClass24_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Ellen._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400874F RID: 34639
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008750 RID: 34640
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008751 RID: 34641
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008752 RID: 34642
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008753 RID: 34643
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008754 RID: 34644
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008755 RID: 34645
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008756 RID: 34646
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008757 RID: 34647
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008758 RID: 34648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008759 RID: 34649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
