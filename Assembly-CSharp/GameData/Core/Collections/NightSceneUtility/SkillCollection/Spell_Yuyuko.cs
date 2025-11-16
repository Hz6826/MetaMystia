using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000297 RID: 663
	public class Spell_Yuyuko : SpellBase
	{
		// Token: 0x06005428 RID: 21544 RVA: 0x001BA9A8 File Offset: 0x001B8BA8
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Yuyuko()
		{
			Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Yuyuko");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr);
			Spell_Yuyuko.NativeFieldInfoPtr_YUYUKO_SPECIAL_POSITIVE_SPELL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "YUYUKO_SPECIAL_POSITIVE_SPELL");
			Spell_Yuyuko.NativeFieldInfoPtr_BIG_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "BIG_TAG");
			Spell_Yuyuko.NativeFieldInfoPtr_YUYUKO_RESURRECTION_BUTTERFLY_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "YUYUKO_RESURRECTION_BUTTERFLY_NUM");
			Spell_Yuyuko.NativeFieldInfoPtr_maxEvalLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "maxEvalLevel");
			Spell_Yuyuko.NativeFieldInfoPtr_firstEatNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "firstEatNum");
			Spell_Yuyuko.NativeFieldInfoPtr_secondEatNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "secondEatNum");
			Spell_Yuyuko.NativeFieldInfoPtr_thirdEatNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "thirdEatNum");
			Spell_Yuyuko.NativeFieldInfoPtr_fourthEatNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "fourthEatNum");
			Spell_Yuyuko.NativeFieldInfoPtr_extraPayment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "extraPayment");
			Spell_Yuyuko.NativeFieldInfoPtr_cherryRainEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "cherryRainEffect");
			Spell_Yuyuko.NativeFieldInfoPtr_fanEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "fanEffect");
			Spell_Yuyuko.NativeFieldInfoPtr_animDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "animDuration");
			Spell_Yuyuko.NativeFieldInfoPtr_fanOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "fanOffsetY");
			Spell_Yuyuko.NativeFieldInfoPtr_fanEffect2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "fanEffect2");
			Spell_Yuyuko.NativeFieldInfoPtr_butterflyEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "butterflyEffect");
			Spell_Yuyuko.NativeFieldInfoPtr_butterflyEffect2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "butterflyEffect2");
			Spell_Yuyuko.NativeFieldInfoPtr_butterflyEndEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "butterflyEndEffect");
			Spell_Yuyuko.NativeFieldInfoPtr_animFanDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "animFanDuration");
			Spell_Yuyuko.NativeFieldInfoPtr_butterflyFlyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "butterflyFlyTime");
			Spell_Yuyuko.NativeFieldInfoPtr_butterflyFlyRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "butterflyFlyRadius");
			Spell_Yuyuko.NativeFieldInfoPtr_butterflyEndOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "butterflyEndOffset");
			Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceEffectHungry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "butterflyFaceEffectHungry");
			Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceEffectHappy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "butterflyFaceEffectHappy");
			Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "butterflyFaceDuration");
			Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "butterflyFaceOffset");
			Spell_Yuyuko.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, 100680514);
			Spell_Yuyuko.NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, 100680515);
			Spell_Yuyuko.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, 100680516);
			Spell_Yuyuko.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, 100680517);
			Spell_Yuyuko.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, 100680518);
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x001BAC30 File Offset: 0x001B8E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211164, XrefRangeEnd = 211166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuyuko.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x001BAC74 File Offset: 0x001B8E74
		[CallerCount(0)]
		public unsafe override bool ShouldCallSpellDeclarationAuto(bool isPositive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isPositive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuyuko.NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x001BACC8 File Offset: 0x001B8EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211166, XrefRangeEnd = 211171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuyuko.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x001BAD24 File Offset: 0x001B8F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211171, XrefRangeEnd = 211177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuyuko.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x001BAD80 File Offset: 0x001B8F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211177, XrefRangeEnd = 211178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Yuyuko() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x0002D58D File Offset: 0x0002B78D
		public Spell_Yuyuko(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x0600542F RID: 21551 RVA: 0x001BADBC File Offset: 0x001B8FBC
		// (set) Token: 0x06005430 RID: 21552 RVA: 0x0002D596 File Offset: 0x0002B796
		public unsafe static int YUYUKO_SPECIAL_POSITIVE_SPELL
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Yuyuko.NativeFieldInfoPtr_YUYUKO_SPECIAL_POSITIVE_SPELL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Yuyuko.NativeFieldInfoPtr_YUYUKO_SPECIAL_POSITIVE_SPELL, (void*)(&value));
			}
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06005431 RID: 21553 RVA: 0x001BADD8 File Offset: 0x001B8FD8
		// (set) Token: 0x06005432 RID: 21554 RVA: 0x0002D5A4 File Offset: 0x0002B7A4
		public unsafe static int BIG_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Yuyuko.NativeFieldInfoPtr_BIG_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Yuyuko.NativeFieldInfoPtr_BIG_TAG, (void*)(&value));
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06005433 RID: 21555 RVA: 0x001BADF4 File Offset: 0x001B8FF4
		// (set) Token: 0x06005434 RID: 21556 RVA: 0x0002D5B2 File Offset: 0x0002B7B2
		public unsafe static string YUYUKO_RESURRECTION_BUTTERFLY_NUM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Yuyuko.NativeFieldInfoPtr_YUYUKO_RESURRECTION_BUTTERFLY_NUM, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Yuyuko.NativeFieldInfoPtr_YUYUKO_RESURRECTION_BUTTERFLY_NUM, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06005435 RID: 21557 RVA: 0x001BAE14 File Offset: 0x001B9014
		// (set) Token: 0x06005436 RID: 21558 RVA: 0x0002D5C4 File Offset: 0x0002B7C4
		public unsafe int maxEvalLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_maxEvalLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_maxEvalLevel)) = value;
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06005437 RID: 21559 RVA: 0x001BAE3C File Offset: 0x001B903C
		// (set) Token: 0x06005438 RID: 21560 RVA: 0x0002D5DF File Offset: 0x0002B7DF
		public unsafe int firstEatNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_firstEatNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_firstEatNum)) = value;
			}
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06005439 RID: 21561 RVA: 0x001BAE64 File Offset: 0x001B9064
		// (set) Token: 0x0600543A RID: 21562 RVA: 0x0002D5FA File Offset: 0x0002B7FA
		public unsafe int secondEatNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_secondEatNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_secondEatNum)) = value;
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x001BAE8C File Offset: 0x001B908C
		// (set) Token: 0x0600543C RID: 21564 RVA: 0x0002D615 File Offset: 0x0002B815
		public unsafe int thirdEatNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_thirdEatNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_thirdEatNum)) = value;
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x001BAEB4 File Offset: 0x001B90B4
		// (set) Token: 0x0600543E RID: 21566 RVA: 0x0002D630 File Offset: 0x0002B830
		public unsafe int fourthEatNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_fourthEatNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_fourthEatNum)) = value;
			}
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x0600543F RID: 21567 RVA: 0x001BAEDC File Offset: 0x001B90DC
		// (set) Token: 0x06005440 RID: 21568 RVA: 0x0002D64B File Offset: 0x0002B84B
		public unsafe float extraPayment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_extraPayment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_extraPayment)) = value;
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06005441 RID: 21569 RVA: 0x001BAF04 File Offset: 0x001B9104
		// (set) Token: 0x06005442 RID: 21570 RVA: 0x0002D666 File Offset: 0x0002B866
		public unsafe GameObject cherryRainEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_cherryRainEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_cherryRainEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x001BAF34 File Offset: 0x001B9134
		// (set) Token: 0x06005444 RID: 21572 RVA: 0x0002D685 File Offset: 0x0002B885
		public unsafe GameObject fanEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_fanEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_fanEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06005445 RID: 21573 RVA: 0x001BAF64 File Offset: 0x001B9164
		// (set) Token: 0x06005446 RID: 21574 RVA: 0x0002D6A4 File Offset: 0x0002B8A4
		public unsafe float animDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_animDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_animDuration)) = value;
			}
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x001BAF8C File Offset: 0x001B918C
		// (set) Token: 0x06005448 RID: 21576 RVA: 0x0002D6BF File Offset: 0x0002B8BF
		public unsafe float fanOffsetY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_fanOffsetY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_fanOffsetY)) = value;
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06005449 RID: 21577 RVA: 0x001BAFB4 File Offset: 0x001B91B4
		// (set) Token: 0x0600544A RID: 21578 RVA: 0x0002D6DA File Offset: 0x0002B8DA
		public unsafe GameObject fanEffect2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_fanEffect2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_fanEffect2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x0600544B RID: 21579 RVA: 0x001BAFE4 File Offset: 0x001B91E4
		// (set) Token: 0x0600544C RID: 21580 RVA: 0x0002D6F9 File Offset: 0x0002B8F9
		public unsafe GameObject butterflyEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x0600544D RID: 21581 RVA: 0x001BB014 File Offset: 0x001B9214
		// (set) Token: 0x0600544E RID: 21582 RVA: 0x0002D718 File Offset: 0x0002B918
		public unsafe GameObject butterflyEffect2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyEffect2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyEffect2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x0600544F RID: 21583 RVA: 0x001BB044 File Offset: 0x001B9244
		// (set) Token: 0x06005450 RID: 21584 RVA: 0x0002D737 File Offset: 0x0002B937
		public unsafe GameObject butterflyEndEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyEndEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyEndEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06005451 RID: 21585 RVA: 0x001BB074 File Offset: 0x001B9274
		// (set) Token: 0x06005452 RID: 21586 RVA: 0x0002D756 File Offset: 0x0002B956
		public unsafe float animFanDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_animFanDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_animFanDuration)) = value;
			}
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06005453 RID: 21587 RVA: 0x001BB09C File Offset: 0x001B929C
		// (set) Token: 0x06005454 RID: 21588 RVA: 0x0002D771 File Offset: 0x0002B971
		public unsafe float butterflyFlyTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFlyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFlyTime)) = value;
			}
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06005455 RID: 21589 RVA: 0x001BB0C4 File Offset: 0x001B92C4
		// (set) Token: 0x06005456 RID: 21590 RVA: 0x0002D78C File Offset: 0x0002B98C
		public unsafe float butterflyFlyRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFlyRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFlyRadius)) = value;
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06005457 RID: 21591 RVA: 0x001BB0EC File Offset: 0x001B92EC
		// (set) Token: 0x06005458 RID: 21592 RVA: 0x0002D7A7 File Offset: 0x0002B9A7
		public unsafe float butterflyEndOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyEndOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyEndOffset)) = value;
			}
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06005459 RID: 21593 RVA: 0x001BB114 File Offset: 0x001B9314
		// (set) Token: 0x0600545A RID: 21594 RVA: 0x0002D7C2 File Offset: 0x0002B9C2
		public unsafe GameObject butterflyFaceEffectHungry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceEffectHungry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceEffectHungry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x0600545B RID: 21595 RVA: 0x001BB144 File Offset: 0x001B9344
		// (set) Token: 0x0600545C RID: 21596 RVA: 0x0002D7E1 File Offset: 0x0002B9E1
		public unsafe GameObject butterflyFaceEffectHappy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceEffectHappy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceEffectHappy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x001BB174 File Offset: 0x001B9374
		// (set) Token: 0x0600545E RID: 21598 RVA: 0x0002D800 File Offset: 0x0002BA00
		public unsafe float butterflyFaceDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceDuration)) = value;
			}
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x0600545F RID: 21599 RVA: 0x001BB19C File Offset: 0x001B939C
		// (set) Token: 0x06005460 RID: 21600 RVA: 0x0002D81B File Offset: 0x0002BA1B
		public unsafe float butterflyFaceOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.NativeFieldInfoPtr_butterflyFaceOffset)) = value;
			}
		}

		// Token: 0x0400388B RID: 14475
		private static readonly IntPtr NativeFieldInfoPtr_YUYUKO_SPECIAL_POSITIVE_SPELL;

		// Token: 0x0400388C RID: 14476
		private static readonly IntPtr NativeFieldInfoPtr_BIG_TAG;

		// Token: 0x0400388D RID: 14477
		private static readonly IntPtr NativeFieldInfoPtr_YUYUKO_RESURRECTION_BUTTERFLY_NUM;

		// Token: 0x0400388E RID: 14478
		private static readonly IntPtr NativeFieldInfoPtr_maxEvalLevel;

		// Token: 0x0400388F RID: 14479
		private static readonly IntPtr NativeFieldInfoPtr_firstEatNum;

		// Token: 0x04003890 RID: 14480
		private static readonly IntPtr NativeFieldInfoPtr_secondEatNum;

		// Token: 0x04003891 RID: 14481
		private static readonly IntPtr NativeFieldInfoPtr_thirdEatNum;

		// Token: 0x04003892 RID: 14482
		private static readonly IntPtr NativeFieldInfoPtr_fourthEatNum;

		// Token: 0x04003893 RID: 14483
		private static readonly IntPtr NativeFieldInfoPtr_extraPayment;

		// Token: 0x04003894 RID: 14484
		private static readonly IntPtr NativeFieldInfoPtr_cherryRainEffect;

		// Token: 0x04003895 RID: 14485
		private static readonly IntPtr NativeFieldInfoPtr_fanEffect;

		// Token: 0x04003896 RID: 14486
		private static readonly IntPtr NativeFieldInfoPtr_animDuration;

		// Token: 0x04003897 RID: 14487
		private static readonly IntPtr NativeFieldInfoPtr_fanOffsetY;

		// Token: 0x04003898 RID: 14488
		private static readonly IntPtr NativeFieldInfoPtr_fanEffect2;

		// Token: 0x04003899 RID: 14489
		private static readonly IntPtr NativeFieldInfoPtr_butterflyEffect;

		// Token: 0x0400389A RID: 14490
		private static readonly IntPtr NativeFieldInfoPtr_butterflyEffect2;

		// Token: 0x0400389B RID: 14491
		private static readonly IntPtr NativeFieldInfoPtr_butterflyEndEffect;

		// Token: 0x0400389C RID: 14492
		private static readonly IntPtr NativeFieldInfoPtr_animFanDuration;

		// Token: 0x0400389D RID: 14493
		private static readonly IntPtr NativeFieldInfoPtr_butterflyFlyTime;

		// Token: 0x0400389E RID: 14494
		private static readonly IntPtr NativeFieldInfoPtr_butterflyFlyRadius;

		// Token: 0x0400389F RID: 14495
		private static readonly IntPtr NativeFieldInfoPtr_butterflyEndOffset;

		// Token: 0x040038A0 RID: 14496
		private static readonly IntPtr NativeFieldInfoPtr_butterflyFaceEffectHungry;

		// Token: 0x040038A1 RID: 14497
		private static readonly IntPtr NativeFieldInfoPtr_butterflyFaceEffectHappy;

		// Token: 0x040038A2 RID: 14498
		private static readonly IntPtr NativeFieldInfoPtr_butterflyFaceDuration;

		// Token: 0x040038A3 RID: 14499
		private static readonly IntPtr NativeFieldInfoPtr_butterflyFaceOffset;

		// Token: 0x040038A4 RID: 14500
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040038A5 RID: 14501
		private static readonly IntPtr NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_Boolean_Boolean_0;

		// Token: 0x040038A6 RID: 14502
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040038A7 RID: 14503
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040038A8 RID: 14504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C39 RID: 3129
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuyuko+<OnNegativeBuffExecute>d__27")]
		public sealed class _OnNegativeBuffExecute_d__27 : Il2CppSystem.Object
		{
			// Token: 0x0600E26E RID: 57966 RVA: 0x003690D4 File Offset: 0x003672D4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__27()
			{
				Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "<OnNegativeBuffExecute>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr);
				Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr, "<>1__state");
				Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr, "<>2__current");
				Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr, "<>4__this");
				Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100680519);
				Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100680520);
				Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100680521);
				Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100680522);
				Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100680523);
				Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr, 100680524);
			}

			// Token: 0x0600E26F RID: 57967 RVA: 0x003691B4 File Offset: 0x003673B4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__27(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuyuko._OnNegativeBuffExecute_d__27>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E270 RID: 57968 RVA: 0x003691FC File Offset: 0x003673FC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E271 RID: 57969 RVA: 0x00369230 File Offset: 0x00367430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210781, XrefRangeEnd = 210789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004986 RID: 18822
			// (get) Token: 0x0600E272 RID: 57970 RVA: 0x0036926C File Offset: 0x0036746C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E273 RID: 57971 RVA: 0x003692AC File Offset: 0x003674AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210789, XrefRangeEnd = 210795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004987 RID: 18823
			// (get) Token: 0x0600E274 RID: 57972 RVA: 0x003692E0 File Offset: 0x003674E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E275 RID: 57973 RVA: 0x00078C9E File Offset: 0x00076E9E
			public _OnNegativeBuffExecute_d__27(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004983 RID: 18819
			// (get) Token: 0x0600E276 RID: 57974 RVA: 0x00369320 File Offset: 0x00367520
			// (set) Token: 0x0600E277 RID: 57975 RVA: 0x00078CA7 File Offset: 0x00076EA7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004984 RID: 18820
			// (get) Token: 0x0600E278 RID: 57976 RVA: 0x00369348 File Offset: 0x00367548
			// (set) Token: 0x0600E279 RID: 57977 RVA: 0x00078CC2 File Offset: 0x00076EC2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004985 RID: 18821
			// (get) Token: 0x0600E27A RID: 57978 RVA: 0x00369378 File Offset: 0x00367578
			// (set) Token: 0x0600E27B RID: 57979 RVA: 0x00078CE1 File Offset: 0x00076EE1
			public unsafe Spell_Yuyuko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuyuko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnNegativeBuffExecute_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090C6 RID: 37062
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090C7 RID: 37063
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090C8 RID: 37064
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090C9 RID: 37065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090CA RID: 37066
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090CB RID: 37067
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090CC RID: 37068
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090CD RID: 37069
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090CE RID: 37070
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C3A RID: 3130
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuyuko+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E27C RID: 57980 RVA: 0x003693A8 File Offset: 0x003675A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_0>.NativeClassPtr);
				Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_0>.NativeClassPtr, "startPosition");
				Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr_foodStorageWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_0>.NativeClassPtr, "foodStorageWorldPosition");
				Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_0>.NativeClassPtr, "<>9__5");
				Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_0>.NativeClassPtr, "<>9__7");
				Spell_Yuyuko.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_0>.NativeClassPtr, 100680525);
				Spell_Yuyuko.__c__DisplayClass28_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_0>.NativeClassPtr, 100680526);
				Spell_Yuyuko.__c__DisplayClass28_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_0>.NativeClassPtr, 100680527);
			}

			// Token: 0x0600E27D RID: 57981 RVA: 0x00369460 File Offset: 0x00367660
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E27E RID: 57982 RVA: 0x0036949C File Offset: 0x0036769C
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c__DisplayClass28_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E27F RID: 57983 RVA: 0x003694D8 File Offset: 0x003676D8
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c__DisplayClass28_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E280 RID: 57984 RVA: 0x00078D00 File Offset: 0x00076F00
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004988 RID: 18824
			// (get) Token: 0x0600E281 RID: 57985 RVA: 0x00369514 File Offset: 0x00367714
			// (set) Token: 0x0600E282 RID: 57986 RVA: 0x00078D09 File Offset: 0x00076F09
			public unsafe Vector3 startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x17004989 RID: 18825
			// (get) Token: 0x0600E283 RID: 57987 RVA: 0x0036953C File Offset: 0x0036773C
			// (set) Token: 0x0600E284 RID: 57988 RVA: 0x00078D24 File Offset: 0x00076F24
			public unsafe Vector3 foodStorageWorldPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr_foodStorageWorldPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr_foodStorageWorldPosition)) = value;
				}
			}

			// Token: 0x1700498A RID: 18826
			// (get) Token: 0x0600E285 RID: 57989 RVA: 0x00369564 File Offset: 0x00367764
			// (set) Token: 0x0600E286 RID: 57990 RVA: 0x00078D3F File Offset: 0x00076F3F
			public unsafe Func<Vector3> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700498B RID: 18827
			// (get) Token: 0x0600E287 RID: 57991 RVA: 0x00369594 File Offset: 0x00367794
			// (set) Token: 0x0600E288 RID: 57992 RVA: 0x00078D5E File Offset: 0x00076F5E
			public unsafe Func<Vector3> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090CF RID: 37071
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x040090D0 RID: 37072
			private static readonly IntPtr NativeFieldInfoPtr_foodStorageWorldPosition;

			// Token: 0x040090D1 RID: 37073
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x040090D2 RID: 37074
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x040090D3 RID: 37075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090D4 RID: 37076
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Vector3_0;

			// Token: 0x040090D5 RID: 37077
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Vector3_0;
		}

		// Token: 0x02000C3B RID: 3131
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuyuko+<>c__DisplayClass28_1")]
		public sealed class __c__DisplayClass28_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E289 RID: 57993 RVA: 0x003695C4 File Offset: 0x003677C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_1()
			{
				Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "<>c__DisplayClass28_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_1>.NativeClassPtr);
				Spell_Yuyuko.__c__DisplayClass28_1.NativeFieldInfoPtr_extraButterflyOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_1>.NativeClassPtr, "extraButterflyOffset");
				Spell_Yuyuko.__c__DisplayClass28_1.NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Yuyuko.__c__DisplayClass28_1.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_1>.NativeClassPtr, "<>9__6");
				Spell_Yuyuko.__c__DisplayClass28_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_1>.NativeClassPtr, 100680528);
				Spell_Yuyuko.__c__DisplayClass28_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_1>.NativeClassPtr, 100680529);
				Spell_Yuyuko.__c__DisplayClass28_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_1>.NativeClassPtr, 100680530);
			}

			// Token: 0x0600E28A RID: 57994 RVA: 0x00369668 File Offset: 0x00367868
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuyuko.__c__DisplayClass28_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c__DisplayClass28_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E28B RID: 57995 RVA: 0x003696A4 File Offset: 0x003678A4
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c__DisplayClass28_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E28C RID: 57996 RVA: 0x003696E0 File Offset: 0x003678E0
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c__DisplayClass28_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E28D RID: 57997 RVA: 0x00078D7D File Offset: 0x00076F7D
			public __c__DisplayClass28_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700498C RID: 18828
			// (get) Token: 0x0600E28E RID: 57998 RVA: 0x0036971C File Offset: 0x0036791C
			// (set) Token: 0x0600E28F RID: 57999 RVA: 0x00078D86 File Offset: 0x00076F86
			public unsafe Vector3 extraButterflyOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_1.NativeFieldInfoPtr_extraButterflyOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_1.NativeFieldInfoPtr_extraButterflyOffset)) = value;
				}
			}

			// Token: 0x1700498D RID: 18829
			// (get) Token: 0x0600E290 RID: 58000 RVA: 0x00369744 File Offset: 0x00367944
			// (set) Token: 0x0600E291 RID: 58001 RVA: 0x00078DA1 File Offset: 0x00076FA1
			public unsafe Spell_Yuyuko.__c__DisplayClass28_0 field_Public___c__DisplayClass28_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_1.NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuyuko.__c__DisplayClass28_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_1.NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700498E RID: 18830
			// (get) Token: 0x0600E292 RID: 58002 RVA: 0x00369774 File Offset: 0x00367974
			// (set) Token: 0x0600E293 RID: 58003 RVA: 0x00078DC0 File Offset: 0x00076FC0
			public unsafe Func<Vector3> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_1.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko.__c__DisplayClass28_1.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090D6 RID: 37078
			private static readonly IntPtr NativeFieldInfoPtr_extraButterflyOffset;

			// Token: 0x040090D7 RID: 37079
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass28_0_0;

			// Token: 0x040090D8 RID: 37080
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x040090D9 RID: 37081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090DA RID: 37082
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Vector3_0;

			// Token: 0x040090DB RID: 37083
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Vector3_0;
		}

		// Token: 0x02000C3C RID: 3132
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuyuko+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E294 RID: 58004 RVA: 0x003697A4 File Offset: 0x003679A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr);
				Spell_Yuyuko.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr, "<>9");
				Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr, "<>9__28_0");
				Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr, "<>9__28_1");
				Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr, "<>9__28_2");
				Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr, "<>9__28_3");
				Spell_Yuyuko.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr, 100680532);
				Spell_Yuyuko.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_0_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr, 100680533);
				Spell_Yuyuko.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_1_Internal_Int32_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr, 100680534);
				Spell_Yuyuko.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_2_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr, 100680535);
				Spell_Yuyuko.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_3_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr, 100680536);
			}

			// Token: 0x0600E295 RID: 58005 RVA: 0x00369898 File Offset: 0x00367A98
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuyuko.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E296 RID: 58006 RVA: 0x003698D4 File Offset: 0x00367AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210795, XrefRangeEnd = 210800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__28_0(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_0_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E297 RID: 58007 RVA: 0x00369928 File Offset: 0x00367B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210800, XrefRangeEnd = 210803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPositiveBuffExecute_b__28_1(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_1_Internal_Int32_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E298 RID: 58008 RVA: 0x0036997C File Offset: 0x00367B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210803, XrefRangeEnd = 210806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__28_2(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_2_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E299 RID: 58009 RVA: 0x003699D0 File Offset: 0x00367BD0
			[CallerCount(0)]
			public unsafe int _OnPositiveBuffExecute_b__28_3(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_3_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E29A RID: 58010 RVA: 0x00078DDF File Offset: 0x00076FDF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700498F RID: 18831
			// (get) Token: 0x0600E29B RID: 58011 RVA: 0x00369A20 File Offset: 0x00367C20
			// (set) Token: 0x0600E29C RID: 58012 RVA: 0x00078DE8 File Offset: 0x00076FE8
			public unsafe static Spell_Yuyuko.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuyuko.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuyuko.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuyuko.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004990 RID: 18832
			// (get) Token: 0x0600E29D RID: 58013 RVA: 0x00369A48 File Offset: 0x00367C48
			// (set) Token: 0x0600E29E RID: 58014 RVA: 0x00078DFA File Offset: 0x00076FFA
			public unsafe static Func<KeyValuePair<Sellable, int>, bool> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004991 RID: 18833
			// (get) Token: 0x0600E29F RID: 58015 RVA: 0x00369A70 File Offset: 0x00367C70
			// (set) Token: 0x0600E2A0 RID: 58016 RVA: 0x00078E0C File Offset: 0x0007700C
			public unsafe static Func<KeyValuePair<Sellable, int>, int> __9__28_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004992 RID: 18834
			// (get) Token: 0x0600E2A1 RID: 58017 RVA: 0x00369A98 File Offset: 0x00367C98
			// (set) Token: 0x0600E2A2 RID: 58018 RVA: 0x00078E1E File Offset: 0x0007701E
			public unsafe static Func<KeyValuePair<Sellable, int>, bool> __9__28_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004993 RID: 18835
			// (get) Token: 0x0600E2A3 RID: 58019 RVA: 0x00369AC0 File Offset: 0x00367CC0
			// (set) Token: 0x0600E2A4 RID: 58020 RVA: 0x00078E30 File Offset: 0x00077030
			public unsafe static Func<Sellable, int> __9__28_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuyuko.__c.NativeFieldInfoPtr___9__28_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090DC RID: 37084
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040090DD RID: 37085
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x040090DE RID: 37086
			private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

			// Token: 0x040090DF RID: 37087
			private static readonly IntPtr NativeFieldInfoPtr___9__28_2;

			// Token: 0x040090E0 RID: 37088
			private static readonly IntPtr NativeFieldInfoPtr___9__28_3;

			// Token: 0x040090E1 RID: 37089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090E2 RID: 37090
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_0_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x040090E3 RID: 37091
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_1_Internal_Int32_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x040090E4 RID: 37092
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_2_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x040090E5 RID: 37093
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__28_3_Internal_Int32_Sellable_0;
		}

		// Token: 0x02000C3D RID: 3133
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuyuko+<OnPositiveBuffExecute>d__28")]
		public sealed class _OnPositiveBuffExecute_d__28 : Il2CppSystem.Object
		{
			// Token: 0x0600E2A5 RID: 58021 RVA: 0x00369AE8 File Offset: 0x00367CE8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__28()
			{
				Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuyuko>.NativeClassPtr, "<OnPositiveBuffExecute>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr);
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<>1__state");
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<>2__current");
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<>4__this");
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, "spellExecutionContext");
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<>8__1");
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr__spellUseNum_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<spellUseNum>5__2");
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr__butterflyUseNum_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, "<butterflyUseNum>5__3");
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100680537);
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100680538);
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100680539);
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100680540);
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100680541);
				Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr, 100680542);
			}

			// Token: 0x0600E2A6 RID: 58022 RVA: 0x00369C18 File Offset: 0x00367E18
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__28(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuyuko._OnPositiveBuffExecute_d__28>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2A7 RID: 58023 RVA: 0x00369C60 File Offset: 0x00367E60
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2A8 RID: 58024 RVA: 0x00369C94 File Offset: 0x00367E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210806, XrefRangeEnd = 211158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700499B RID: 18843
			// (get) Token: 0x0600E2A9 RID: 58025 RVA: 0x00369CD0 File Offset: 0x00367ED0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E2AA RID: 58026 RVA: 0x00369D10 File Offset: 0x00367F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211158, XrefRangeEnd = 211164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700499C RID: 18844
			// (get) Token: 0x0600E2AB RID: 58027 RVA: 0x00369D44 File Offset: 0x00367F44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E2AC RID: 58028 RVA: 0x00078E42 File Offset: 0x00077042
			public _OnPositiveBuffExecute_d__28(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004994 RID: 18836
			// (get) Token: 0x0600E2AD RID: 58029 RVA: 0x00369D84 File Offset: 0x00367F84
			// (set) Token: 0x0600E2AE RID: 58030 RVA: 0x00078E4B File Offset: 0x0007704B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004995 RID: 18837
			// (get) Token: 0x0600E2AF RID: 58031 RVA: 0x00369DAC File Offset: 0x00367FAC
			// (set) Token: 0x0600E2B0 RID: 58032 RVA: 0x00078E66 File Offset: 0x00077066
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004996 RID: 18838
			// (get) Token: 0x0600E2B1 RID: 58033 RVA: 0x00369DDC File Offset: 0x00367FDC
			// (set) Token: 0x0600E2B2 RID: 58034 RVA: 0x00078E85 File Offset: 0x00077085
			public unsafe Spell_Yuyuko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuyuko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004997 RID: 18839
			// (get) Token: 0x0600E2B3 RID: 58035 RVA: 0x00369E0C File Offset: 0x0036800C
			// (set) Token: 0x0600E2B4 RID: 58036 RVA: 0x00078EA4 File Offset: 0x000770A4
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004998 RID: 18840
			// (get) Token: 0x0600E2B5 RID: 58037 RVA: 0x00369E3C File Offset: 0x0036803C
			// (set) Token: 0x0600E2B6 RID: 58038 RVA: 0x00078EC3 File Offset: 0x000770C3
			public unsafe Spell_Yuyuko.__c__DisplayClass28_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuyuko.__c__DisplayClass28_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004999 RID: 18841
			// (get) Token: 0x0600E2B7 RID: 58039 RVA: 0x00369E6C File Offset: 0x0036806C
			// (set) Token: 0x0600E2B8 RID: 58040 RVA: 0x00078EE2 File Offset: 0x000770E2
			public unsafe int _spellUseNum_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr__spellUseNum_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr__spellUseNum_5__2)) = value;
				}
			}

			// Token: 0x1700499A RID: 18842
			// (get) Token: 0x0600E2B9 RID: 58041 RVA: 0x00369E94 File Offset: 0x00368094
			// (set) Token: 0x0600E2BA RID: 58042 RVA: 0x00078EFD File Offset: 0x000770FD
			public unsafe int _butterflyUseNum_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr__butterflyUseNum_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuyuko._OnPositiveBuffExecute_d__28.NativeFieldInfoPtr__butterflyUseNum_5__3)) = value;
				}
			}

			// Token: 0x040090E6 RID: 37094
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090E7 RID: 37095
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090E8 RID: 37096
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090E9 RID: 37097
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040090EA RID: 37098
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040090EB RID: 37099
			private static readonly IntPtr NativeFieldInfoPtr__spellUseNum_5__2;

			// Token: 0x040090EC RID: 37100
			private static readonly IntPtr NativeFieldInfoPtr__butterflyUseNum_5__3;

			// Token: 0x040090ED RID: 37101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090EE RID: 37102
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090EF RID: 37103
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090F0 RID: 37104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090F1 RID: 37105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090F2 RID: 37106
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
