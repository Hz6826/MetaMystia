using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000106 RID: 262
	[Serializable]
	public class RogueLikeCardBase : ScriptableObject
	{
		// Token: 0x06001CD6 RID: 7382 RVA: 0x000FEE6C File Offset: 0x000FD06C
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeCardBase()
		{
			Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeCardBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr);
			RogueLikeCardBase.NativeFieldInfoPtr_m_CardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, "m_CardType");
			RogueLikeCardBase.NativeFieldInfoPtr_m_IsDangerousCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, "m_IsDangerousCard");
			RogueLikeCardBase.NativeFieldInfoPtr_m_ForcedShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, "m_ForcedShow");
			RogueLikeCardBase.NativeFieldInfoPtr_m_Bg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, "m_Bg");
			RogueLikeCardBase.NativeMethodInfoPtr_get_IsDangerousCard_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, 100668485);
			RogueLikeCardBase.NativeMethodInfoPtr_get_BG_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, 100668486);
			RogueLikeCardBase.NativeMethodInfoPtr_get_ForcedShow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, 100668487);
			RogueLikeCardBase.NativeMethodInfoPtr_get_GetCardType_Public_get_CardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, 100668488);
			RogueLikeCardBase.NativeMethodInfoPtr_get_GetCardForm_Public_Abstract_Virtual_New_get_CardForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, 100668489);
			RogueLikeCardBase.NativeMethodInfoPtr_RegisterTimedBuff_Protected_Boolean_EventManager_BuffType_Single_Action_1_Int32_BuffRegisterType_Int32_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, 100668490);
			RogueLikeCardBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr, 100668491);
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x000FEF78 File Offset: 0x000FD178
		public unsafe bool IsDangerousCard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardBase.NativeMethodInfoPtr_get_IsDangerousCard_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000FEFB4 File Offset: 0x000FD1B4
		public unsafe Sprite BG
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardBase.NativeMethodInfoPtr_get_BG_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x000FEFF4 File Offset: 0x000FD1F4
		public unsafe bool ForcedShow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardBase.NativeMethodInfoPtr_get_ForcedShow_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000FF030 File Offset: 0x000FD230
		public unsafe RogueLikeCardBase.CardType GetCardType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardBase.NativeMethodInfoPtr_get_GetCardType_Public_get_CardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x000FF06C File Offset: 0x000FD26C
		public unsafe virtual RogueLikeCardBase.CardForm GetCardForm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardBase.NativeMethodInfoPtr_get_GetCardForm_Public_Abstract_Virtual_New_get_CardForm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000FF0B4 File Offset: 0x000FD2B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 73626, RefRangeEnd = 73632, XrefRangeStart = 73624, XrefRangeEnd = 73626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RegisterTimedBuff(EventManager eventManager, EventManager.BuffType buffType, float duration, Action<int> defaultRegisterBuffAction, EventManager.BuffRegisterType buffRegisterType = EventManager.BuffRegisterType.Additive, int extraDuration = -1, Action<int> haveBuffRegisterBuffAction = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultRegisterBuffAction);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffRegisterType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraDuration;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(haveBuffRegisterBuffAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardBase.NativeMethodInfoPtr_RegisterTimedBuff_Protected_Boolean_EventManager_BuffType_Single_Action_1_Int32_BuffRegisterType_Int32_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000FF160 File Offset: 0x000FD360
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeCardBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeCardBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00011863 File Offset: 0x0000FA63
		public RogueLikeCardBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x000FF19C File Offset: 0x000FD39C
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x0001186C File Offset: 0x0000FA6C
		public unsafe RogueLikeCardBase.CardType m_CardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardBase.NativeFieldInfoPtr_m_CardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardBase.NativeFieldInfoPtr_m_CardType)) = value;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x000FF1C4 File Offset: 0x000FD3C4
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x00011887 File Offset: 0x0000FA87
		public unsafe bool m_IsDangerousCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardBase.NativeFieldInfoPtr_m_IsDangerousCard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardBase.NativeFieldInfoPtr_m_IsDangerousCard)) = value;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x000FF1EC File Offset: 0x000FD3EC
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x000118A2 File Offset: 0x0000FAA2
		public unsafe bool m_ForcedShow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardBase.NativeFieldInfoPtr_m_ForcedShow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardBase.NativeFieldInfoPtr_m_ForcedShow)) = value;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x000FF214 File Offset: 0x000FD414
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x000118BD File Offset: 0x0000FABD
		public unsafe Sprite m_Bg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardBase.NativeFieldInfoPtr_m_Bg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardBase.NativeFieldInfoPtr_m_Bg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeFieldInfoPtr_m_CardType;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDangerousCard;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeFieldInfoPtr_m_ForcedShow;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeFieldInfoPtr_m_Bg;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDangerousCard_Public_get_Boolean_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_get_BG_Public_get_Sprite_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedShow_Public_get_Boolean_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_get_GetCardType_Public_get_CardType_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_get_GetCardForm_Public_Abstract_Virtual_New_get_CardForm_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTimedBuff_Protected_Boolean_EventManager_BuffType_Single_Action_1_Int32_BuffRegisterType_Int32_Action_1_Int32_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020006D6 RID: 1750
		public enum Rarity
		{
			// Token: 0x04006400 RID: 25600
			Green,
			// Token: 0x04006401 RID: 25601
			Blue,
			// Token: 0x04006402 RID: 25602
			Purple,
			// Token: 0x04006403 RID: 25603
			Gold
		}

		// Token: 0x020006D7 RID: 1751
		public enum CardType
		{
			// Token: 0x04006405 RID: 25605
			Constant,
			// Token: 0x04006406 RID: 25606
			Constant,
			// Token: 0x04006407 RID: 25607
			Constant,
			// Token: 0x04006408 RID: 25608
			Constant,
			// Token: 0x04006409 RID: 25609
			Constant,
			// Token: 0x0400640A RID: 25610
			Constant,
			// Token: 0x0400640B RID: 25611
			Constant,
			// Token: 0x0400640C RID: 25612
			Constant,
			// Token: 0x0400640D RID: 25613
			Constant,
			// Token: 0x0400640E RID: 25614
			Constant,
			// Token: 0x0400640F RID: 25615
			Constant,
			// Token: 0x04006410 RID: 25616
			Constant,
			// Token: 0x04006411 RID: 25617
			Constant,
			// Token: 0x04006412 RID: 25618
			Constant,
			// Token: 0x04006413 RID: 25619
			Constant,
			// Token: 0x04006414 RID: 25620
			Constant,
			// Token: 0x04006415 RID: 25621
			Constant,
			// Token: 0x04006416 RID: 25622
			Constant,
			// Token: 0x04006417 RID: 25623
			Constant,
			// Token: 0x04006418 RID: 25624
			Constant,
			// Token: 0x04006419 RID: 25625
			Constant,
			// Token: 0x0400641A RID: 25626
			Constant,
			// Token: 0x0400641B RID: 25627
			Constant,
			// Token: 0x0400641C RID: 25628
			Constant,
			// Token: 0x0400641D RID: 25629
			Constant,
			// Token: 0x0400641E RID: 25630
			Constant = 1000,
			// Token: 0x0400641F RID: 25631
			Constant,
			// Token: 0x04006420 RID: 25632
			Constant,
			// Token: 0x04006421 RID: 25633
			Constant,
			// Token: 0x04006422 RID: 25634
			Constant,
			// Token: 0x04006423 RID: 25635
			Constant,
			// Token: 0x04006424 RID: 25636
			Constant = 25,
			// Token: 0x04006425 RID: 25637
			Constant,
			// Token: 0x04006426 RID: 25638
			Constant,
			// Token: 0x04006427 RID: 25639
			Constant,
			// Token: 0x04006428 RID: 25640
			Constant,
			// Token: 0x04006429 RID: 25641
			Constant,
			// Token: 0x0400642A RID: 25642
			Constant,
			// Token: 0x0400642B RID: 25643
			Constant,
			// Token: 0x0400642C RID: 25644
			Constant,
			// Token: 0x0400642D RID: 25645
			Constant,
			// Token: 0x0400642E RID: 25646
			Constant,
			// Token: 0x0400642F RID: 25647
			Constant,
			// Token: 0x04006430 RID: 25648
			Constant,
			// Token: 0x04006431 RID: 25649
			Constant,
			// Token: 0x04006432 RID: 25650
			Constant,
			// Token: 0x04006433 RID: 25651
			Constant,
			// Token: 0x04006434 RID: 25652
			Constant,
			// Token: 0x04006435 RID: 25653
			Constant,
			// Token: 0x04006436 RID: 25654
			Constant,
			// Token: 0x04006437 RID: 25655
			Constant = 56,
			// Token: 0x04006438 RID: 25656
			Constant,
			// Token: 0x04006439 RID: 25657
			Constant = 60,
			// Token: 0x0400643A RID: 25658
			Constant,
			// Token: 0x0400643B RID: 25659
			Constant,
			// Token: 0x0400643C RID: 25660
			Constant,
			// Token: 0x0400643D RID: 25661
			Constant,
			// Token: 0x0400643E RID: 25662
			Constant = 44,
			// Token: 0x0400643F RID: 25663
			Constant,
			// Token: 0x04006440 RID: 25664
			Constant,
			// Token: 0x04006441 RID: 25665
			Constant,
			// Token: 0x04006442 RID: 25666
			Constant,
			// Token: 0x04006443 RID: 25667
			Constant = 50,
			// Token: 0x04006444 RID: 25668
			Constant,
			// Token: 0x04006445 RID: 25669
			Constant,
			// Token: 0x04006446 RID: 25670
			Constant,
			// Token: 0x04006447 RID: 25671
			Constant,
			// Token: 0x04006448 RID: 25672
			Constant,
			// Token: 0x04006449 RID: 25673
			Constant = 58,
			// Token: 0x0400644A RID: 25674
			Constant,
			// Token: 0x0400644B RID: 25675
			Constant = 2000,
			// Token: 0x0400644C RID: 25676
			Constant
		}

		// Token: 0x020006D8 RID: 1752
		public enum CardForm
		{
			// Token: 0x0400644E RID: 25678
			InGame,
			// Token: 0x0400644F RID: 25679
			InSettled
		}
	}
}
