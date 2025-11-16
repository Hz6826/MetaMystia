using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.UI.RogueLike;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using PrepNightScene.UI;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002FB RID: 763
	public class DLC5_RogueLikeBossData : BossData
	{
		// Token: 0x06005C25 RID: 23589 RVA: 0x001D1290 File Offset: 0x001CF490
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeBossData()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DLC5_RogueLikeBossData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr);
			DLC5_RogueLikeBossData.NativeFieldInfoPtr_RogueLikeEndEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "RogueLikeEndEvent");
			DLC5_RogueLikeBossData.NativeFieldInfoPtr_DELAY_GACHA_PANEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "DELAY_GACHA_PANEL");
			DLC5_RogueLikeBossData.NativeFieldInfoPtr_SubPannelForRogueLike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "SubPannelForRogueLike");
			DLC5_RogueLikeBossData.NativeFieldInfoPtr_RemindPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "RemindPanel");
			DLC5_RogueLikeBossData.NativeFieldInfoPtr_endBgm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "endBgm");
			DLC5_RogueLikeBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, 100682136);
			DLC5_RogueLikeBossData.NativeMethodInfoPtr_Timing_Private_IEnumerator_EventManager_Int32_CancellationTokenSource_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, 100682137);
			DLC5_RogueLikeBossData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, 100682138);
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x001D1360 File Offset: 0x001CF560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230328, XrefRangeEnd = 230334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x001D13C0 File Offset: 0x001CF5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230334, XrefRangeEnd = 230342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Timing(EventManager eventManager, int duration, CancellationTokenSource tokenSource, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenSource);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.NativeMethodInfoPtr_Timing_Private_IEnumerator_EventManager_Int32_CancellationTokenSource_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005C28 RID: 23592 RVA: 0x001D1444 File Offset: 0x001CF644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230343, RefRangeEnd = 230345, XrefRangeStart = 230342, XrefRangeEnd = 230343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeBossData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C29 RID: 23593 RVA: 0x00032501 File Offset: 0x00030701
		public DLC5_RogueLikeBossData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06005C2A RID: 23594 RVA: 0x001D1480 File Offset: 0x001CF680
		// (set) Token: 0x06005C2B RID: 23595 RVA: 0x0003250A File Offset: 0x0003070A
		public unsafe static string RogueLikeEndEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.NativeFieldInfoPtr_RogueLikeEndEvent, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.NativeFieldInfoPtr_RogueLikeEndEvent, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06005C2C RID: 23596 RVA: 0x001D14A0 File Offset: 0x001CF6A0
		// (set) Token: 0x06005C2D RID: 23597 RVA: 0x0003251C File Offset: 0x0003071C
		public unsafe static float DELAY_GACHA_PANEL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.NativeFieldInfoPtr_DELAY_GACHA_PANEL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.NativeFieldInfoPtr_DELAY_GACHA_PANEL, (void*)(&value));
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06005C2E RID: 23598 RVA: 0x001D14BC File Offset: 0x001CF6BC
		// (set) Token: 0x06005C2F RID: 23599 RVA: 0x0003252A File Offset: 0x0003072A
		public unsafe IzakayaConfigSubPannelForRogueLike SubPannelForRogueLike
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.NativeFieldInfoPtr_SubPannelForRogueLike);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigSubPannelForRogueLike>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.NativeFieldInfoPtr_SubPannelForRogueLike), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x06005C30 RID: 23600 RVA: 0x001D14EC File Offset: 0x001CF6EC
		// (set) Token: 0x06005C31 RID: 23601 RVA: 0x00032549 File Offset: 0x00030749
		public unsafe RemindSubPanel RemindPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.NativeFieldInfoPtr_RemindPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemindSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.NativeFieldInfoPtr_RemindPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x06005C32 RID: 23602 RVA: 0x001D151C File Offset: 0x001CF71C
		// (set) Token: 0x06005C33 RID: 23603 RVA: 0x00032568 File Offset: 0x00030768
		public unsafe LoopedBGMPackage endBgm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.NativeFieldInfoPtr_endBgm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.NativeFieldInfoPtr_endBgm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D13 RID: 15635
		private static readonly IntPtr NativeFieldInfoPtr_RogueLikeEndEvent;

		// Token: 0x04003D14 RID: 15636
		private static readonly IntPtr NativeFieldInfoPtr_DELAY_GACHA_PANEL;

		// Token: 0x04003D15 RID: 15637
		private static readonly IntPtr NativeFieldInfoPtr_SubPannelForRogueLike;

		// Token: 0x04003D16 RID: 15638
		private static readonly IntPtr NativeFieldInfoPtr_RemindPanel;

		// Token: 0x04003D17 RID: 15639
		private static readonly IntPtr NativeFieldInfoPtr_endBgm;

		// Token: 0x04003D18 RID: 15640
		private static readonly IntPtr NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0;

		// Token: 0x04003D19 RID: 15641
		private static readonly IntPtr NativeMethodInfoPtr_Timing_Private_IEnumerator_EventManager_Int32_CancellationTokenSource_RogueLikeManager_0;

		// Token: 0x04003D1A RID: 15642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D0C RID: 3340
		[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EFF8 RID: 61432 RVA: 0x0038FED0 File Offset: 0x0038E0D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "rogueLikeRunTimeData");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_specialGuestPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "specialGuestPool");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_lastProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "lastProbability");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "bossDataContext");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_spawnedSpecialGuestList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "spawnedSpecialGuestList");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_specialGuestOriginPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "specialGuestOriginPool");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_statusDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "statusDisplay");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_getSpellCardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "getSpellCardNum");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_targetSpellNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "targetSpellNum");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_perfectEvalNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "perfectEvalNum");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_currentPassionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "currentPassionLevel");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_targetComboNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "targetComboNum");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_comboTriggerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "comboTriggerTime");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_gainedEnoughFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "gainedEnoughFund");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "canContinue");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_tokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "tokenSource");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_rogueLikeCardDescriptionLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "rogueLikeCardDescriptionLang");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_persistentCardDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "persistentCardDic");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_roundNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "roundNumber");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_dataProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "dataProfile");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_canUseWorkCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "canUseWorkCard");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardTriggerCurrentCardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "cardTriggerCurrentCardNum");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardRateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "cardRateData");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_challengeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "challengeStart");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardTriggerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "cardTriggerData");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "cardData");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "startTime");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_statusTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "statusTracker");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_earnedFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "earnedFund");
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682139);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__0_Internal_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682140);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682141);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__6_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682142);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__7_Internal_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682143);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682144);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682145);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682146);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682147);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682148);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__12_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682149);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__13_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682150);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682151);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__15_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682152);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__16_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682153);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__17_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682154);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682155);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__19_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682156);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682157);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682158);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__33_Internal_KeyValuePair_2_String_List_1_Product_KeyValuePair_2_CardType_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682159);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__34_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682160);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682161);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__38_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682162);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__39_Internal_List_1_RogueLikeCardInstance_TriggerCardCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682163);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__40_Internal_Void_TriggerCardCondition_RogueLikeCardInstance_List_1_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682164);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__41_Internal_RogueLikeCardBase_CardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682165);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__42_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682166);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__43_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682167);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682168);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_TriggerCardCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682169);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_List_1_RogueLikeCardInstance_TriggerCardCondition_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682170);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682171);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__54_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682172);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Void_TriggerCardCondition_RogueLikeCardInstance_List_1_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682173);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__57_Internal_RogueLikeCardBase_CardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682174);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__58_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682175);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__59_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682176);
				DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, 100682177);
			}

			// Token: 0x0600EFF9 RID: 61433 RVA: 0x00390474 File Offset: 0x0038E674
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EFFA RID: 61434 RVA: 0x003904B0 File Offset: 0x0038E6B0
			[CallerCount(0)]
			public unsafe IList<int> _MainChallengeLoop_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__0_Internal_IList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr3) : null;
			}

			// Token: 0x0600EFFB RID: 61435 RVA: 0x003904F0 File Offset: 0x0038E6F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228819, XrefRangeEnd = 228852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EFFC RID: 61436 RVA: 0x0039052C File Offset: 0x0038E72C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228852, XrefRangeEnd = 228855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__6_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EFFD RID: 61437 RVA: 0x00390568 File Offset: 0x0038E768
			[CallerCount(0)]
			public unsafe IList<int> _MainChallengeLoop_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__7_Internal_IList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr3) : null;
			}

			// Token: 0x0600EFFE RID: 61438 RVA: 0x003905A8 File Offset: 0x0038E7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228855, XrefRangeEnd = 228862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__8(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EFFF RID: 61439 RVA: 0x003905E8 File Offset: 0x0038E7E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228862, XrefRangeEnd = 228883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F000 RID: 61440 RVA: 0x0039061C File Offset: 0x0038E81C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228883, XrefRangeEnd = 228887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__10(int num)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F001 RID: 61441 RVA: 0x0039065C File Offset: 0x0038E85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228887, XrefRangeEnd = 228896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__11(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F002 RID: 61442 RVA: 0x003906A0 File Offset: 0x0038E8A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228896, XrefRangeEnd = 228903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0(GuestGroupController.EvaluationResult evalResult, GuestGroupController thisGuest, bool oldComboProtect, out string message, out bool comboProtect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref evalResult;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				message = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600F003 RID: 61443 RVA: 0x00390734 File Offset: 0x0038E934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228903, XrefRangeEnd = 228942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__12(int musicLevel)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref musicLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__12_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F004 RID: 61444 RVA: 0x00390774 File Offset: 0x0038E974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228942, XrefRangeEnd = 228947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__13(int currentCombo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentCombo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__13_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F005 RID: 61445 RVA: 0x003907B4 File Offset: 0x0038E9B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228947, XrefRangeEnd = 228949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_PDM_0(int earnedMoney1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref earnedMoney1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F006 RID: 61446 RVA: 0x003907F4 File Offset: 0x0038E9F4
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__15()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__15_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F007 RID: 61447 RVA: 0x00390830 File Offset: 0x0038EA30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228949, XrefRangeEnd = 228954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__16()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__16_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F008 RID: 61448 RVA: 0x00390864 File Offset: 0x0038EA64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228954, XrefRangeEnd = 228956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__17()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__17_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F009 RID: 61449 RVA: 0x003908A0 File Offset: 0x0038EAA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228956, XrefRangeEnd = 228957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__18()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F00A RID: 61450 RVA: 0x003908DC File Offset: 0x0038EADC
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__19()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__19_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F00B RID: 61451 RVA: 0x00390910 File Offset: 0x0038EB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228957, XrefRangeEnd = 228958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__20()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F00C RID: 61452 RVA: 0x0039094C File Offset: 0x0038EB4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228958, XrefRangeEnd = 228960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_PDM_1(int _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref _;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F00D RID: 61453 RVA: 0x0039098C File Offset: 0x0038EB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228960, XrefRangeEnd = 228968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<string, List<Product>> _MainChallengeLoop_b__33(KeyValuePair<RogueLikeCardBase.CardType, List<Product>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__33_Internal_KeyValuePair_2_String_List_1_Product_KeyValuePair_2_CardType_List_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<string, List<Product>>(pointer);
			}

			// Token: 0x0600F00E RID: 61454 RVA: 0x003909DC File Offset: 0x0038EBDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228968, XrefRangeEnd = 228972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__34()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__34_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F00F RID: 61455 RVA: 0x00390A10 File Offset: 0x0038EC10
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__35()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F010 RID: 61456 RVA: 0x00390A44 File Offset: 0x0038EC44
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__38()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__38_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F011 RID: 61457 RVA: 0x00390A78 File Offset: 0x0038EC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228972, XrefRangeEnd = 229044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe List<RogueLikeCardInstance> _MainChallengeLoop_b__39(TriggerCardCondition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__39_Internal_List_1_RogueLikeCardInstance_TriggerCardCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCardInstance>>(intPtr3) : null;
			}

			// Token: 0x0600F012 RID: 61458 RVA: 0x00390AC4 File Offset: 0x0038ECC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229044, XrefRangeEnd = 229063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__40(TriggerCardCondition _, RogueLikeCardInstance x, List<RogueLikeCardInstance> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref _;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__40_Internal_Void_TriggerCardCondition_RogueLikeCardInstance_List_1_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F013 RID: 61459 RVA: 0x00390B28 File Offset: 0x0038ED28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229063, XrefRangeEnd = 229066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueLikeCardBase _MainChallengeLoop_b__41(RogueLikeCardBase.CardType x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__41_Internal_RogueLikeCardBase_CardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeCardBase>(intPtr3) : null;
			}

			// Token: 0x0600F014 RID: 61460 RVA: 0x00390B74 File Offset: 0x0038ED74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229066, XrefRangeEnd = 229068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__42(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__42_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F015 RID: 61461 RVA: 0x00390BB4 File Offset: 0x0038EDB4
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__43()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__43_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F016 RID: 61462 RVA: 0x00390BF0 File Offset: 0x0038EDF0
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__44()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F017 RID: 61463 RVA: 0x00390C24 File Offset: 0x0038EE24
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 229088, RefRangeEnd = 229092, XrefRangeStart = 229068, XrefRangeEnd = 229088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_TriggerCardCondition_0(TriggerCardCondition condition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref condition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_TriggerCardCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F018 RID: 61464 RVA: 0x00390C64 File Offset: 0x0038EE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229092, XrefRangeEnd = 229190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe List<RogueLikeCardInstance> Method_Internal_List_1_RogueLikeCardInstance_TriggerCardCondition_PDM_0(TriggerCardCondition thisCondition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref thisCondition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_List_1_RogueLikeCardInstance_TriggerCardCondition_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCardInstance>>(intPtr3) : null;
			}

			// Token: 0x0600F019 RID: 61465 RVA: 0x00390CB0 File Offset: 0x0038EEB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 229208, RefRangeEnd = 229209, XrefRangeStart = 229190, XrefRangeEnd = 229208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask Method_Internal_UniTask_CancellationToken_0(CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_UniTask_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x0600F01A RID: 61466 RVA: 0x00390D00 File Offset: 0x0038EF00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229209, XrefRangeEnd = 229213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__54()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__54_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F01B RID: 61467 RVA: 0x00390D3C File Offset: 0x0038EF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229213, XrefRangeEnd = 229226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__56(TriggerCardCondition thisCondition, RogueLikeCardInstance x, List<RogueLikeCardInstance> associatedCard)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref thisCondition;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(associatedCard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Void_TriggerCardCondition_RogueLikeCardInstance_List_1_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F01C RID: 61468 RVA: 0x00390DA0 File Offset: 0x0038EFA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229226, XrefRangeEnd = 229230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueLikeCardBase _MainChallengeLoop_b__57(RogueLikeCardBase.CardType x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__57_Internal_RogueLikeCardBase_CardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeCardBase>(intPtr3) : null;
			}

			// Token: 0x0600F01D RID: 61469 RVA: 0x00390DEC File Offset: 0x0038EFEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229230, XrefRangeEnd = 229233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__58(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__58_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F01E RID: 61470 RVA: 0x00390E2C File Offset: 0x0038F02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229233, XrefRangeEnd = 229234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__59()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr__MainChallengeLoop_b__59_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F01F RID: 61471 RVA: 0x00390E68 File Offset: 0x0038F068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229234, XrefRangeEnd = 229247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F020 RID: 61472 RVA: 0x00080B5D File Offset: 0x0007ED5D
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E09 RID: 19977
			// (get) Token: 0x0600F021 RID: 61473 RVA: 0x00390E9C File Offset: 0x0038F09C
			// (set) Token: 0x0600F022 RID: 61474 RVA: 0x00080B66 File Offset: 0x0007ED66
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E0A RID: 19978
			// (get) Token: 0x0600F023 RID: 61475 RVA: 0x00390ECC File Offset: 0x0038F0CC
			// (set) Token: 0x0600F024 RID: 61476 RVA: 0x00080B85 File Offset: 0x0007ED85
			public unsafe Dictionary<int, Vector2> specialGuestPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_specialGuestPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_specialGuestPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E0B RID: 19979
			// (get) Token: 0x0600F025 RID: 61477 RVA: 0x00390EFC File Offset: 0x0038F0FC
			// (set) Token: 0x0600F026 RID: 61478 RVA: 0x00080BA4 File Offset: 0x0007EDA4
			public unsafe float lastProbability
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_lastProbability);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_lastProbability)) = value;
				}
			}

			// Token: 0x17004E0C RID: 19980
			// (get) Token: 0x0600F027 RID: 61479 RVA: 0x00390F24 File Offset: 0x0038F124
			// (set) Token: 0x0600F028 RID: 61480 RVA: 0x00080BBF File Offset: 0x0007EDBF
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004E0D RID: 19981
			// (get) Token: 0x0600F029 RID: 61481 RVA: 0x00390F54 File Offset: 0x0038F154
			// (set) Token: 0x0600F02A RID: 61482 RVA: 0x00080BED File Offset: 0x0007EDED
			public unsafe HashSet<int> spawnedSpecialGuestList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_spawnedSpecialGuestList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_spawnedSpecialGuestList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E0E RID: 19982
			// (get) Token: 0x0600F02B RID: 61483 RVA: 0x00390F84 File Offset: 0x0038F184
			// (set) Token: 0x0600F02C RID: 61484 RVA: 0x00080C0C File Offset: 0x0007EE0C
			public unsafe List<int> specialGuestOriginPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_specialGuestOriginPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_specialGuestOriginPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E0F RID: 19983
			// (get) Token: 0x0600F02D RID: 61485 RVA: 0x00390FB4 File Offset: 0x0038F1B4
			// (set) Token: 0x0600F02E RID: 61486 RVA: 0x00080C2B File Offset: 0x0007EE2B
			public unsafe IncomeControllerRogueLike statusDisplay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_statusDisplay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerRogueLike>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_statusDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E10 RID: 19984
			// (get) Token: 0x0600F02F RID: 61487 RVA: 0x00390FE4 File Offset: 0x0038F1E4
			// (set) Token: 0x0600F030 RID: 61488 RVA: 0x00080C4A File Offset: 0x0007EE4A
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E11 RID: 19985
			// (get) Token: 0x0600F031 RID: 61489 RVA: 0x00391014 File Offset: 0x0038F214
			// (set) Token: 0x0600F032 RID: 61490 RVA: 0x00080C69 File Offset: 0x0007EE69
			public unsafe int getSpellCardNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_getSpellCardNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_getSpellCardNum)) = value;
				}
			}

			// Token: 0x17004E12 RID: 19986
			// (get) Token: 0x0600F033 RID: 61491 RVA: 0x0039103C File Offset: 0x0038F23C
			// (set) Token: 0x0600F034 RID: 61492 RVA: 0x00080C84 File Offset: 0x0007EE84
			public unsafe int targetSpellNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_targetSpellNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_targetSpellNum)) = value;
				}
			}

			// Token: 0x17004E13 RID: 19987
			// (get) Token: 0x0600F035 RID: 61493 RVA: 0x00391064 File Offset: 0x0038F264
			// (set) Token: 0x0600F036 RID: 61494 RVA: 0x00080C9F File Offset: 0x0007EE9F
			public unsafe int perfectEvalNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_perfectEvalNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_perfectEvalNum)) = value;
				}
			}

			// Token: 0x17004E14 RID: 19988
			// (get) Token: 0x0600F037 RID: 61495 RVA: 0x0039108C File Offset: 0x0038F28C
			// (set) Token: 0x0600F038 RID: 61496 RVA: 0x00080CBA File Offset: 0x0007EEBA
			public unsafe int currentPassionLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_currentPassionLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_currentPassionLevel)) = value;
				}
			}

			// Token: 0x17004E15 RID: 19989
			// (get) Token: 0x0600F039 RID: 61497 RVA: 0x003910B4 File Offset: 0x0038F2B4
			// (set) Token: 0x0600F03A RID: 61498 RVA: 0x00080CD5 File Offset: 0x0007EED5
			public unsafe int targetComboNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_targetComboNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_targetComboNum)) = value;
				}
			}

			// Token: 0x17004E16 RID: 19990
			// (get) Token: 0x0600F03B RID: 61499 RVA: 0x003910DC File Offset: 0x0038F2DC
			// (set) Token: 0x0600F03C RID: 61500 RVA: 0x00080CF0 File Offset: 0x0007EEF0
			public unsafe int comboTriggerTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_comboTriggerTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_comboTriggerTime)) = value;
				}
			}

			// Token: 0x17004E17 RID: 19991
			// (get) Token: 0x0600F03D RID: 61501 RVA: 0x00391104 File Offset: 0x0038F304
			// (set) Token: 0x0600F03E RID: 61502 RVA: 0x00080D0B File Offset: 0x0007EF0B
			public unsafe bool gainedEnoughFund
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_gainedEnoughFund);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_gainedEnoughFund)) = value;
				}
			}

			// Token: 0x17004E18 RID: 19992
			// (get) Token: 0x0600F03F RID: 61503 RVA: 0x0039112C File Offset: 0x0038F32C
			// (set) Token: 0x0600F040 RID: 61504 RVA: 0x00080D26 File Offset: 0x0007EF26
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x17004E19 RID: 19993
			// (get) Token: 0x0600F041 RID: 61505 RVA: 0x00391154 File Offset: 0x0038F354
			// (set) Token: 0x0600F042 RID: 61506 RVA: 0x00080D41 File Offset: 0x0007EF41
			public unsafe CancellationTokenSource tokenSource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_tokenSource);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_tokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E1A RID: 19994
			// (get) Token: 0x0600F043 RID: 61507 RVA: 0x00391184 File Offset: 0x0038F384
			// (set) Token: 0x0600F044 RID: 61508 RVA: 0x00080D60 File Offset: 0x0007EF60
			public unsafe Dictionary<RogueLikeCardBase.CardType, Il2CppStringArray> rogueLikeCardDescriptionLang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_rogueLikeCardDescriptionLang);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeCardBase.CardType, Il2CppStringArray>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_rogueLikeCardDescriptionLang), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E1B RID: 19995
			// (get) Token: 0x0600F045 RID: 61509 RVA: 0x003911B4 File Offset: 0x0038F3B4
			// (set) Token: 0x0600F046 RID: 61510 RVA: 0x00080D7F File Offset: 0x0007EF7F
			public unsafe Dictionary<RogueLikeCardBase.CardType, RogueLikeCardPersistent> persistentCardDic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_persistentCardDic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeCardBase.CardType, RogueLikeCardPersistent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_persistentCardDic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E1C RID: 19996
			// (get) Token: 0x0600F047 RID: 61511 RVA: 0x003911E4 File Offset: 0x0038F3E4
			// (set) Token: 0x0600F048 RID: 61512 RVA: 0x00080D9E File Offset: 0x0007EF9E
			public unsafe int roundNumber
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_roundNumber);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_roundNumber)) = value;
				}
			}

			// Token: 0x17004E1D RID: 19997
			// (get) Token: 0x0600F049 RID: 61513 RVA: 0x0039120C File Offset: 0x0038F40C
			// (set) Token: 0x0600F04A RID: 61514 RVA: 0x00080DB9 File Offset: 0x0007EFB9
			public IRogueLikeData dataProfile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_dataProfile);
					return new IRogueLikeData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_dataProfile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004E1E RID: 19998
			// (get) Token: 0x0600F04B RID: 61515 RVA: 0x0039123C File Offset: 0x0038F43C
			// (set) Token: 0x0600F04C RID: 61516 RVA: 0x00080DE7 File Offset: 0x0007EFE7
			public unsafe DLC5_RogueLikeBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E1F RID: 19999
			// (get) Token: 0x0600F04D RID: 61517 RVA: 0x0039126C File Offset: 0x0038F46C
			// (set) Token: 0x0600F04E RID: 61518 RVA: 0x00080E06 File Offset: 0x0007F006
			public unsafe bool canUseWorkCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_canUseWorkCard);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_canUseWorkCard)) = value;
				}
			}

			// Token: 0x17004E20 RID: 20000
			// (get) Token: 0x0600F04F RID: 61519 RVA: 0x00391294 File Offset: 0x0038F494
			// (set) Token: 0x0600F050 RID: 61520 RVA: 0x00080E21 File Offset: 0x0007F021
			public unsafe Dictionary<TriggerCardCondition, int> cardTriggerCurrentCardNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardTriggerCurrentCardNum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TriggerCardCondition, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardTriggerCurrentCardNum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E21 RID: 20001
			// (get) Token: 0x0600F051 RID: 61521 RVA: 0x003912C4 File Offset: 0x0038F4C4
			// (set) Token: 0x0600F052 RID: 61522 RVA: 0x00080E40 File Offset: 0x0007F040
			public unsafe Dictionary<int, Il2CppStructArray<RogueLikeCardRewardRate>> cardRateData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardRateData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStructArray<RogueLikeCardRewardRate>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardRateData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E22 RID: 20002
			// (get) Token: 0x0600F053 RID: 61523 RVA: 0x003912F4 File Offset: 0x0038F4F4
			// (set) Token: 0x0600F054 RID: 61524 RVA: 0x00080E5F File Offset: 0x0007F05F
			public unsafe bool challengeStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_challengeStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_challengeStart)) = value;
				}
			}

			// Token: 0x17004E23 RID: 20003
			// (get) Token: 0x0600F055 RID: 61525 RVA: 0x0039131C File Offset: 0x0038F51C
			// (set) Token: 0x0600F056 RID: 61526 RVA: 0x00080E7A File Offset: 0x0007F07A
			public unsafe Dictionary<TriggerCardCondition, TriggerCardData> cardTriggerData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardTriggerData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TriggerCardCondition, TriggerCardData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardTriggerData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E24 RID: 20004
			// (get) Token: 0x0600F057 RID: 61527 RVA: 0x0039134C File Offset: 0x0038F54C
			// (set) Token: 0x0600F058 RID: 61528 RVA: 0x00080E99 File Offset: 0x0007F099
			public unsafe Dictionary<RogueLikeCardBase.CardType, RogueLikeCard> cardData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeCardBase.CardType, RogueLikeCard>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_cardData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E25 RID: 20005
			// (get) Token: 0x0600F059 RID: 61529 RVA: 0x0039137C File Offset: 0x0038F57C
			// (set) Token: 0x0600F05A RID: 61530 RVA: 0x00080EB8 File Offset: 0x0007F0B8
			public unsafe float startTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_startTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_startTime)) = value;
				}
			}

			// Token: 0x17004E26 RID: 20006
			// (get) Token: 0x0600F05B RID: 61531 RVA: 0x003913A4 File Offset: 0x0038F5A4
			// (set) Token: 0x0600F05C RID: 61532 RVA: 0x00080ED3 File Offset: 0x0007F0D3
			public unsafe StatusTracker statusTracker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_statusTracker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatusTracker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_statusTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E27 RID: 20007
			// (get) Token: 0x0600F05D RID: 61533 RVA: 0x003913D4 File Offset: 0x0038F5D4
			// (set) Token: 0x0600F05E RID: 61534 RVA: 0x00080EF2 File Offset: 0x0007F0F2
			public unsafe int earnedFund
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_earnedFund);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.NativeFieldInfoPtr_earnedFund)) = value;
				}
			}

			// Token: 0x040098FE RID: 39166
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x040098FF RID: 39167
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestPool;

			// Token: 0x04009900 RID: 39168
			private static readonly IntPtr NativeFieldInfoPtr_lastProbability;

			// Token: 0x04009901 RID: 39169
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x04009902 RID: 39170
			private static readonly IntPtr NativeFieldInfoPtr_spawnedSpecialGuestList;

			// Token: 0x04009903 RID: 39171
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestOriginPool;

			// Token: 0x04009904 RID: 39172
			private static readonly IntPtr NativeFieldInfoPtr_statusDisplay;

			// Token: 0x04009905 RID: 39173
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x04009906 RID: 39174
			private static readonly IntPtr NativeFieldInfoPtr_getSpellCardNum;

			// Token: 0x04009907 RID: 39175
			private static readonly IntPtr NativeFieldInfoPtr_targetSpellNum;

			// Token: 0x04009908 RID: 39176
			private static readonly IntPtr NativeFieldInfoPtr_perfectEvalNum;

			// Token: 0x04009909 RID: 39177
			private static readonly IntPtr NativeFieldInfoPtr_currentPassionLevel;

			// Token: 0x0400990A RID: 39178
			private static readonly IntPtr NativeFieldInfoPtr_targetComboNum;

			// Token: 0x0400990B RID: 39179
			private static readonly IntPtr NativeFieldInfoPtr_comboTriggerTime;

			// Token: 0x0400990C RID: 39180
			private static readonly IntPtr NativeFieldInfoPtr_gainedEnoughFund;

			// Token: 0x0400990D RID: 39181
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x0400990E RID: 39182
			private static readonly IntPtr NativeFieldInfoPtr_tokenSource;

			// Token: 0x0400990F RID: 39183
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeCardDescriptionLang;

			// Token: 0x04009910 RID: 39184
			private static readonly IntPtr NativeFieldInfoPtr_persistentCardDic;

			// Token: 0x04009911 RID: 39185
			private static readonly IntPtr NativeFieldInfoPtr_roundNumber;

			// Token: 0x04009912 RID: 39186
			private static readonly IntPtr NativeFieldInfoPtr_dataProfile;

			// Token: 0x04009913 RID: 39187
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009914 RID: 39188
			private static readonly IntPtr NativeFieldInfoPtr_canUseWorkCard;

			// Token: 0x04009915 RID: 39189
			private static readonly IntPtr NativeFieldInfoPtr_cardTriggerCurrentCardNum;

			// Token: 0x04009916 RID: 39190
			private static readonly IntPtr NativeFieldInfoPtr_cardRateData;

			// Token: 0x04009917 RID: 39191
			private static readonly IntPtr NativeFieldInfoPtr_challengeStart;

			// Token: 0x04009918 RID: 39192
			private static readonly IntPtr NativeFieldInfoPtr_cardTriggerData;

			// Token: 0x04009919 RID: 39193
			private static readonly IntPtr NativeFieldInfoPtr_cardData;

			// Token: 0x0400991A RID: 39194
			private static readonly IntPtr NativeFieldInfoPtr_startTime;

			// Token: 0x0400991B RID: 39195
			private static readonly IntPtr NativeFieldInfoPtr_statusTracker;

			// Token: 0x0400991C RID: 39196
			private static readonly IntPtr NativeFieldInfoPtr_earnedFund;

			// Token: 0x0400991D RID: 39197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400991E RID: 39198
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__0_Internal_IList_1_Int32_0;

			// Token: 0x0400991F RID: 39199
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Int32_0;

			// Token: 0x04009920 RID: 39200
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__6_Internal_Boolean_0;

			// Token: 0x04009921 RID: 39201
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__7_Internal_IList_1_Int32_0;

			// Token: 0x04009922 RID: 39202
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Void_Int32_0;

			// Token: 0x04009923 RID: 39203
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_0;

			// Token: 0x04009924 RID: 39204
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Void_Int32_0;

			// Token: 0x04009925 RID: 39205
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_GuestGroupController_0;

			// Token: 0x04009926 RID: 39206
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0;

			// Token: 0x04009927 RID: 39207
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__12_Internal_Void_Int32_0;

			// Token: 0x04009928 RID: 39208
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_Internal_Void_Int32_0;

			// Token: 0x04009929 RID: 39209
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0;

			// Token: 0x0400992A RID: 39210
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__15_Internal_Boolean_0;

			// Token: 0x0400992B RID: 39211
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_Internal_Void_0;

			// Token: 0x0400992C RID: 39212
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__17_Internal_Boolean_0;

			// Token: 0x0400992D RID: 39213
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Boolean_0;

			// Token: 0x0400992E RID: 39214
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__19_Internal_Void_0;

			// Token: 0x0400992F RID: 39215
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Boolean_0;

			// Token: 0x04009930 RID: 39216
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_1;

			// Token: 0x04009931 RID: 39217
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__33_Internal_KeyValuePair_2_String_List_1_Product_KeyValuePair_2_CardType_List_1_Product_0;

			// Token: 0x04009932 RID: 39218
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__34_Internal_Void_0;

			// Token: 0x04009933 RID: 39219
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Void_0;

			// Token: 0x04009934 RID: 39220
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__38_Internal_Void_0;

			// Token: 0x04009935 RID: 39221
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__39_Internal_List_1_RogueLikeCardInstance_TriggerCardCondition_0;

			// Token: 0x04009936 RID: 39222
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__40_Internal_Void_TriggerCardCondition_RogueLikeCardInstance_List_1_RogueLikeCardInstance_0;

			// Token: 0x04009937 RID: 39223
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__41_Internal_RogueLikeCardBase_CardType_0;

			// Token: 0x04009938 RID: 39224
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__42_Internal_Void_Int32_0;

			// Token: 0x04009939 RID: 39225
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__43_Internal_Int32_0;

			// Token: 0x0400993A RID: 39226
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Void_0;

			// Token: 0x0400993B RID: 39227
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_TriggerCardCondition_0;

			// Token: 0x0400993C RID: 39228
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_List_1_RogueLikeCardInstance_TriggerCardCondition_PDM_0;

			// Token: 0x0400993D RID: 39229
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_UniTask_CancellationToken_0;

			// Token: 0x0400993E RID: 39230
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__54_Internal_Boolean_0;

			// Token: 0x0400993F RID: 39231
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Void_TriggerCardCondition_RogueLikeCardInstance_List_1_RogueLikeCardInstance_0;

			// Token: 0x04009940 RID: 39232
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__57_Internal_RogueLikeCardBase_CardType_0;

			// Token: 0x04009941 RID: 39233
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__58_Internal_Void_Int32_0;

			// Token: 0x04009942 RID: 39234
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_Internal_Int32_0;

			// Token: 0x04009943 RID: 39235
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x02001088 RID: 4232
			[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<>c__DisplayClass5_0+<<MainChallengeLoop>g__OpenCardSelector|25>d")]
			public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique : ValueType
			{
				// Token: 0x0601205F RID: 73823 RVA: 0x0041DDE0 File Offset: 0x0041BFE0
				// Note: this type is marked as 'beforefieldinit'.
				static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique()
				{
					Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0>.NativeClassPtr, "<<MainChallengeLoop>g__OpenCardSelector|25>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr);
					DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr, "<>1__state");
					DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr, "<>t__builder");
					DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr, "cancellationToken");
					DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr, "<>4__this");
					DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr__selectedCardQueue_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr, "<selectedCardQueue>5__2");
					DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr, "<>u__1");
					DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr, "<>u__2");
					DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr, 100682178);
					DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr, 100682179);
				}

				// Token: 0x06012060 RID: 73824 RVA: 0x0041DEC0 File Offset: 0x0041C0C0
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 228817, RefRangeEnd = 228819, XrefRangeStart = 228628, XrefRangeEnd = 228817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012061 RID: 73825 RVA: 0x0041DEF8 File Offset: 0x0041C0F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012062 RID: 73826 RVA: 0x0009C910 File Offset: 0x0009AB10
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x06012063 RID: 73827 RVA: 0x0009C919 File Offset: 0x0009AB19
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique>.NativeClassPtr))
				{
				}

				// Token: 0x17005E0B RID: 24075
				// (get) Token: 0x06012064 RID: 73828 RVA: 0x0041DF40 File Offset: 0x0041C140
				// (set) Token: 0x06012065 RID: 73829 RVA: 0x0009C92B File Offset: 0x0009AB2B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E0C RID: 24076
				// (get) Token: 0x06012066 RID: 73830 RVA: 0x0041DF68 File Offset: 0x0041C168
				// (set) Token: 0x06012067 RID: 73831 RVA: 0x0009C946 File Offset: 0x0009AB46
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005E0D RID: 24077
				// (get) Token: 0x06012068 RID: 73832 RVA: 0x0041DF98 File Offset: 0x0041C198
				// (set) Token: 0x06012069 RID: 73833 RVA: 0x0009C974 File Offset: 0x0009AB74
				public CancellationToken cancellationToken
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr_cancellationToken);
						return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005E0E RID: 24078
				// (get) Token: 0x0601206A RID: 73834 RVA: 0x0041DFC8 File Offset: 0x0041C1C8
				// (set) Token: 0x0601206B RID: 73835 RVA: 0x0009C9A2 File Offset: 0x0009ABA2
				public unsafe DLC5_RogueLikeBossData.__c__DisplayClass5_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData.__c__DisplayClass5_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E0F RID: 24079
				// (get) Token: 0x0601206C RID: 73836 RVA: 0x0041DFF8 File Offset: 0x0041C1F8
				// (set) Token: 0x0601206D RID: 73837 RVA: 0x0009C9C1 File Offset: 0x0009ABC1
				public unsafe Queue<RogueLikeCardInstance> _selectedCardQueue_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr__selectedCardQueue_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<RogueLikeCardInstance>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr__selectedCardQueue_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E10 RID: 24080
				// (get) Token: 0x0601206E RID: 73838 RVA: 0x0041E028 File Offset: 0x0041C228
				// (set) Token: 0x0601206F RID: 73839 RVA: 0x0009C9E0 File Offset: 0x0009ABE0
				public UniTask.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___u__1);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005E11 RID: 24081
				// (get) Token: 0x06012070 RID: 73840 RVA: 0x0041E058 File Offset: 0x0041C258
				// (set) Token: 0x06012071 RID: 73841 RVA: 0x0009CA0E File Offset: 0x0009AC0E
				public UniTask<DLC5_RogueLikeCardSelectorPanel>.Awaiter __u__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___u__2);
						return new UniTask<DLC5_RogueLikeCardSelectorPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeCardSelectorPanel>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsCacaQu1RoAwDLAwUnique.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeCardSelectorPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B6A6 RID: 46758
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B6A7 RID: 46759
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B6A8 RID: 46760
				private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

				// Token: 0x0400B6A9 RID: 46761
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B6AA RID: 46762
				private static readonly IntPtr NativeFieldInfoPtr__selectedCardQueue_5__2;

				// Token: 0x0400B6AB RID: 46763
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B6AC RID: 46764
				private static readonly IntPtr NativeFieldInfoPtr___u__2;

				// Token: 0x0400B6AD RID: 46765
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6AE RID: 46766
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x02000D0D RID: 3341
		[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F05F RID: 61535 RVA: 0x003913FC File Offset: 0x0038F5FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_1>.NativeClassPtr);
				DLC5_RogueLikeBossData.__c__DisplayClass5_1.NativeFieldInfoPtr_randVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_1>.NativeClassPtr, "randVal");
				DLC5_RogueLikeBossData.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_1>.NativeClassPtr, 100682180);
				DLC5_RogueLikeBossData.__c__DisplayClass5_1.NativeMethodInfoPtr__MainChallengeLoop_b__27_Internal_Boolean_KeyValuePair_2_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_1>.NativeClassPtr, 100682181);
			}

			// Token: 0x0600F060 RID: 61536 RVA: 0x00391464 File Offset: 0x0038F664
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F061 RID: 61537 RVA: 0x003914A0 File Offset: 0x0038F6A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229247, XrefRangeEnd = 229248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__27(KeyValuePair<int, Vector2> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_1.NativeMethodInfoPtr__MainChallengeLoop_b__27_Internal_Boolean_KeyValuePair_2_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F062 RID: 61538 RVA: 0x00080F0D File Offset: 0x0007F10D
			public __c__DisplayClass5_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E28 RID: 20008
			// (get) Token: 0x0600F063 RID: 61539 RVA: 0x003914F4 File Offset: 0x0038F6F4
			// (set) Token: 0x0600F064 RID: 61540 RVA: 0x00080F16 File Offset: 0x0007F116
			public unsafe float randVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_1.NativeFieldInfoPtr_randVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_1.NativeFieldInfoPtr_randVal)) = value;
				}
			}

			// Token: 0x04009944 RID: 39236
			private static readonly IntPtr NativeFieldInfoPtr_randVal;

			// Token: 0x04009945 RID: 39237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009946 RID: 39238
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__27_Internal_Boolean_KeyValuePair_2_Int32_Vector2_0;
		}

		// Token: 0x02000D0E RID: 3342
		[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<>c__DisplayClass5_2")]
		public sealed class __c__DisplayClass5_2 : Il2CppSystem.Object
		{
			// Token: 0x0600F065 RID: 61541 RVA: 0x0039151C File Offset: 0x0038F71C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_2()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "<>c__DisplayClass5_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_2>.NativeClassPtr);
				DLC5_RogueLikeBossData.__c__DisplayClass5_2.NativeFieldInfoPtr_extraScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_2>.NativeClassPtr, "extraScore");
				DLC5_RogueLikeBossData.__c__DisplayClass5_2.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_2>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_RogueLikeBossData.__c__DisplayClass5_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_2>.NativeClassPtr, 100682182);
				DLC5_RogueLikeBossData.__c__DisplayClass5_2.NativeMethodInfoPtr__MainChallengeLoop_b__37_Internal_Void_EliteReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_2>.NativeClassPtr, 100682183);
			}

			// Token: 0x0600F066 RID: 61542 RVA: 0x00391598 File Offset: 0x0038F798
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F067 RID: 61543 RVA: 0x003915D4 File Offset: 0x0038F7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229248, XrefRangeEnd = 229269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__37(RogueLikeRunTimeData.EliteChallengeBase.EliteReward x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_2.NativeMethodInfoPtr__MainChallengeLoop_b__37_Internal_Void_EliteReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F068 RID: 61544 RVA: 0x00080F31 File Offset: 0x0007F131
			public __c__DisplayClass5_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E29 RID: 20009
			// (get) Token: 0x0600F069 RID: 61545 RVA: 0x0039161C File Offset: 0x0038F81C
			// (set) Token: 0x0600F06A RID: 61546 RVA: 0x00080F3A File Offset: 0x0007F13A
			public unsafe int extraScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_2.NativeFieldInfoPtr_extraScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_2.NativeFieldInfoPtr_extraScore)) = value;
				}
			}

			// Token: 0x17004E2A RID: 20010
			// (get) Token: 0x0600F06B RID: 61547 RVA: 0x00391644 File Offset: 0x0038F844
			// (set) Token: 0x0600F06C RID: 61548 RVA: 0x00080F55 File Offset: 0x0007F155
			public unsafe DLC5_RogueLikeBossData.__c__DisplayClass5_0 field_Public___c__DisplayClass5_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_2.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData.__c__DisplayClass5_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_2.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009947 RID: 39239
			private static readonly IntPtr NativeFieldInfoPtr_extraScore;

			// Token: 0x04009948 RID: 39240
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0;

			// Token: 0x04009949 RID: 39241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400994A RID: 39242
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__37_Internal_Void_EliteReward_0;
		}

		// Token: 0x02000D0F RID: 3343
		[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<>c__DisplayClass5_3")]
		public sealed class __c__DisplayClass5_3 : Il2CppSystem.Object
		{
			// Token: 0x0600F06D RID: 61549 RVA: 0x00391674 File Offset: 0x0038F874
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_3()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "<>c__DisplayClass5_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_3>.NativeClassPtr);
				DLC5_RogueLikeBossData.__c__DisplayClass5_3.NativeFieldInfoPtr_selectedCardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_3>.NativeClassPtr, "selectedCardType");
				DLC5_RogueLikeBossData.__c__DisplayClass5_3.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_3>.NativeClassPtr, "CS$<>8__locals2");
				DLC5_RogueLikeBossData.__c__DisplayClass5_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_3>.NativeClassPtr, 100682184);
			}

			// Token: 0x0600F06E RID: 61550 RVA: 0x003916DC File Offset: 0x0038F8DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F06F RID: 61551 RVA: 0x00080F74 File Offset: 0x0007F174
			public __c__DisplayClass5_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E2B RID: 20011
			// (get) Token: 0x0600F070 RID: 61552 RVA: 0x00391718 File Offset: 0x0038F918
			// (set) Token: 0x0600F071 RID: 61553 RVA: 0x00080F7D File Offset: 0x0007F17D
			public unsafe List<RogueLikeCardBase.CardType> selectedCardType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_3.NativeFieldInfoPtr_selectedCardType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCardBase.CardType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_3.NativeFieldInfoPtr_selectedCardType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E2C RID: 20012
			// (get) Token: 0x0600F072 RID: 61554 RVA: 0x00391748 File Offset: 0x0038F948
			// (set) Token: 0x0600F073 RID: 61555 RVA: 0x00080F9C File Offset: 0x0007F19C
			public unsafe DLC5_RogueLikeBossData.__c__DisplayClass5_0 field_Public___c__DisplayClass5_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_3.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData.__c__DisplayClass5_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_3.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400994B RID: 39243
			private static readonly IntPtr NativeFieldInfoPtr_selectedCardType;

			// Token: 0x0400994C RID: 39244
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0;

			// Token: 0x0400994D RID: 39245
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D10 RID: 3344
		[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<>c__DisplayClass5_4")]
		public sealed class __c__DisplayClass5_4 : Il2CppSystem.Object
		{
			// Token: 0x0600F074 RID: 61556 RVA: 0x00391778 File Offset: 0x0038F978
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_4()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "<>c__DisplayClass5_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_4>.NativeClassPtr);
				DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeFieldInfoPtr_dangerousCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_4>.NativeClassPtr, "dangerousCard");
				DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeFieldInfoPtr_targetRarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_4>.NativeClassPtr, "targetRarity");
				DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeFieldInfoPtr_field_Public___c__DisplayClass5_3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_4>.NativeClassPtr, "CS$<>8__locals3");
				DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_4>.NativeClassPtr, 100682185);
				DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeMethodInfoPtr__MainChallengeLoop_b__51_Internal_Boolean_RogueLikeCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_4>.NativeClassPtr, 100682186);
			}

			// Token: 0x0600F075 RID: 61557 RVA: 0x00391808 File Offset: 0x0038FA08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F076 RID: 61558 RVA: 0x00391844 File Offset: 0x0038FA44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229269, XrefRangeEnd = 229292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__51(RogueLikeCard x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeMethodInfoPtr__MainChallengeLoop_b__51_Internal_Boolean_RogueLikeCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F077 RID: 61559 RVA: 0x00080FBB File Offset: 0x0007F1BB
			public __c__DisplayClass5_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E2D RID: 20013
			// (get) Token: 0x0600F078 RID: 61560 RVA: 0x00391894 File Offset: 0x0038FA94
			// (set) Token: 0x0600F079 RID: 61561 RVA: 0x00080FC4 File Offset: 0x0007F1C4
			public unsafe bool dangerousCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeFieldInfoPtr_dangerousCard);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeFieldInfoPtr_dangerousCard)) = value;
				}
			}

			// Token: 0x17004E2E RID: 20014
			// (get) Token: 0x0600F07A RID: 61562 RVA: 0x003918BC File Offset: 0x0038FABC
			// (set) Token: 0x0600F07B RID: 61563 RVA: 0x00080FDF File Offset: 0x0007F1DF
			public unsafe RogueLikeCardBase.Rarity targetRarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeFieldInfoPtr_targetRarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeFieldInfoPtr_targetRarity)) = value;
				}
			}

			// Token: 0x17004E2F RID: 20015
			// (get) Token: 0x0600F07C RID: 61564 RVA: 0x003918E4 File Offset: 0x0038FAE4
			// (set) Token: 0x0600F07D RID: 61565 RVA: 0x00080FFA File Offset: 0x0007F1FA
			public unsafe DLC5_RogueLikeBossData.__c__DisplayClass5_3 field_Public___c__DisplayClass5_3_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeFieldInfoPtr_field_Public___c__DisplayClass5_3_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData.__c__DisplayClass5_3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_4.NativeFieldInfoPtr_field_Public___c__DisplayClass5_3_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400994E RID: 39246
			private static readonly IntPtr NativeFieldInfoPtr_dangerousCard;

			// Token: 0x0400994F RID: 39247
			private static readonly IntPtr NativeFieldInfoPtr_targetRarity;

			// Token: 0x04009950 RID: 39248
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass5_3_0;

			// Token: 0x04009951 RID: 39249
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009952 RID: 39250
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__51_Internal_Boolean_RogueLikeCard_0;
		}

		// Token: 0x02000D11 RID: 3345
		[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<>c__DisplayClass5_5")]
		public sealed class __c__DisplayClass5_5 : Il2CppSystem.Object
		{
			// Token: 0x0600F07E RID: 61566 RVA: 0x00391914 File Offset: 0x0038FB14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_5()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "<>c__DisplayClass5_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_5>.NativeClassPtr);
				DLC5_RogueLikeBossData.__c__DisplayClass5_5.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_5>.NativeClassPtr, "x");
				DLC5_RogueLikeBossData.__c__DisplayClass5_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_5>.NativeClassPtr, 100682187);
				DLC5_RogueLikeBossData.__c__DisplayClass5_5.NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Boolean_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_5>.NativeClassPtr, 100682188);
				DLC5_RogueLikeBossData.__c__DisplayClass5_5.NativeMethodInfoPtr__MainChallengeLoop_b__53_Internal_Boolean_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_5>.NativeClassPtr, 100682189);
			}

			// Token: 0x0600F07F RID: 61567 RVA: 0x00391990 File Offset: 0x0038FB90
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass5_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F080 RID: 61568 RVA: 0x003919CC File Offset: 0x0038FBCC
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__52(RogueLikeCardInstance y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_5.NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Boolean_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F081 RID: 61569 RVA: 0x00391A1C File Offset: 0x0038FC1C
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__53(RogueLikeCardInstance y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass5_5.NativeMethodInfoPtr__MainChallengeLoop_b__53_Internal_Boolean_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F082 RID: 61570 RVA: 0x00081019 File Offset: 0x0007F219
			public __c__DisplayClass5_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E30 RID: 20016
			// (get) Token: 0x0600F083 RID: 61571 RVA: 0x00391A6C File Offset: 0x0038FC6C
			// (set) Token: 0x0600F084 RID: 61572 RVA: 0x00081022 File Offset: 0x0007F222
			public unsafe RogueLikeCard x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_5.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass5_5.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009953 RID: 39251
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04009954 RID: 39252
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009955 RID: 39253
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Boolean_RogueLikeCardInstance_0;

			// Token: 0x04009956 RID: 39254
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__53_Internal_Boolean_RogueLikeCardInstance_0;
		}

		// Token: 0x02000D12 RID: 3346
		[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F085 RID: 61573 RVA: 0x00391A9C File Offset: 0x0038FC9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr);
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_1");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_2");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_3");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_4");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_28");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_29");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_31");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_32");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_36");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_45 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_45");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_46 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_46");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_47 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_47");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_48 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_48");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_22");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_49 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_49");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_50 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_50");
				DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_55 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, "<>9__5_55");
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682191);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_1_Internal_TriggerCardCondition_KeyValuePair_2_TriggerCardCondition_TriggerCardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682192);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_2_Internal_Int32_KeyValuePair_2_TriggerCardCondition_TriggerCardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682193);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_3_Internal_CardType_RogueLikeCardPersistent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682194);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_4_Internal_RogueLikeCardPersistent_RogueLikeCardPersistent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682195);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_28_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682196);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_29_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682197);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_31_Internal_CardType_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682198);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_32_Internal_KeyValuePair_2_CardType_Int32_IGrouping_2_CardType_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682199);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_36_Internal_Boolean_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682200);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_45_Internal_Boolean_CardScorePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682201);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_46_Internal_Int32_CardScorePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682202);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_47_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682203);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_22_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682204);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_48_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682205);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_49_Internal_Single_RogueLikeCardRewardRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682206);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_50_Internal_Rarity_RogueLikeCardRewardRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682207);
				DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_55_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr, 100682208);
			}

			// Token: 0x0600F086 RID: 61574 RVA: 0x00391D98 File Offset: 0x0038FF98
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F087 RID: 61575 RVA: 0x00391DD4 File Offset: 0x0038FFD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229292, XrefRangeEnd = 229293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TriggerCardCondition _MainChallengeLoop_b__5_1(KeyValuePair<TriggerCardCondition, TriggerCardData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_1_Internal_TriggerCardCondition_KeyValuePair_2_TriggerCardCondition_TriggerCardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F088 RID: 61576 RVA: 0x00391E28 File Offset: 0x00390028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229293, XrefRangeEnd = 229294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__5_2(KeyValuePair<TriggerCardCondition, TriggerCardData> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_2_Internal_Int32_KeyValuePair_2_TriggerCardCondition_TriggerCardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F089 RID: 61577 RVA: 0x00391E7C File Offset: 0x0039007C
			[CallerCount(0)]
			public unsafe RogueLikeCardBase.CardType _MainChallengeLoop_b__5_3(RogueLikeCardPersistent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_3_Internal_CardType_RogueLikeCardPersistent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F08A RID: 61578 RVA: 0x00391ECC File Offset: 0x003900CC
			[CallerCount(0)]
			public unsafe RogueLikeCardPersistent _MainChallengeLoop_b__5_4(RogueLikeCardPersistent y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_4_Internal_RogueLikeCardPersistent_RogueLikeCardPersistent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeCardPersistent>(intPtr3) : null;
			}

			// Token: 0x0600F08B RID: 61579 RVA: 0x00391F1C File Offset: 0x0039011C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229294, XrefRangeEnd = 229298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__5_28()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_28_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F08C RID: 61580 RVA: 0x00391F50 File Offset: 0x00390150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229298, XrefRangeEnd = 229303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__5_29()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_29_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F08D RID: 61581 RVA: 0x00391F84 File Offset: 0x00390184
			[CallerCount(0)]
			public unsafe RogueLikeCardBase.CardType _MainChallengeLoop_b__5_31(RogueLikeCardInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_31_Internal_CardType_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F08E RID: 61582 RVA: 0x00391FD4 File Offset: 0x003901D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229303, XrefRangeEnd = 229312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<RogueLikeCardBase.CardType, int> _MainChallengeLoop_b__5_32(IGrouping<RogueLikeCardBase.CardType, RogueLikeCardInstance> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_32_Internal_KeyValuePair_2_CardType_Int32_IGrouping_2_CardType_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<RogueLikeCardBase.CardType, int>(pointer);
			}

			// Token: 0x0600F08F RID: 61583 RVA: 0x0039201C File Offset: 0x0039021C
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__5_36(RogueLikeRunTimeData.EliteChallengeCache y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_36_Internal_Boolean_EliteChallengeCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F090 RID: 61584 RVA: 0x0039206C File Offset: 0x0039026C
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__5_45(DLC5_RogueLikeCardScorePanel.CardScorePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_45_Internal_Boolean_CardScorePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F091 RID: 61585 RVA: 0x003920C0 File Offset: 0x003902C0
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__5_46(DLC5_RogueLikeCardScorePanel.CardScorePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_46_Internal_Int32_CardScorePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F092 RID: 61586 RVA: 0x00392114 File Offset: 0x00390314
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__5_47(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_47_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F093 RID: 61587 RVA: 0x00392168 File Offset: 0x00390368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229312, XrefRangeEnd = 229332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__5_22()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_22_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F094 RID: 61588 RVA: 0x0039219C File Offset: 0x0039039C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229332, XrefRangeEnd = 229344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__5_48()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_48_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F095 RID: 61589 RVA: 0x003921D0 File Offset: 0x003903D0
			[CallerCount(0)]
			public unsafe float _MainChallengeLoop_b__5_49(RogueLikeCardRewardRate x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_49_Internal_Single_RogueLikeCardRewardRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F096 RID: 61590 RVA: 0x0039221C File Offset: 0x0039041C
			[CallerCount(0)]
			public unsafe RogueLikeCardBase.Rarity _MainChallengeLoop_b__5_50(RogueLikeCardRewardRate x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_50_Internal_Rarity_RogueLikeCardRewardRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F097 RID: 61591 RVA: 0x00392268 File Offset: 0x00390468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229344, XrefRangeEnd = 229348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__5_55()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__5_55_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F098 RID: 61592 RVA: 0x00081041 File Offset: 0x0007F241
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E31 RID: 20017
			// (get) Token: 0x0600F099 RID: 61593 RVA: 0x003922A4 File Offset: 0x003904A4
			// (set) Token: 0x0600F09A RID: 61594 RVA: 0x0008104A File Offset: 0x0007F24A
			public unsafe static DLC5_RogueLikeBossData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E32 RID: 20018
			// (get) Token: 0x0600F09B RID: 61595 RVA: 0x003922CC File Offset: 0x003904CC
			// (set) Token: 0x0600F09C RID: 61596 RVA: 0x0008105C File Offset: 0x0007F25C
			public unsafe static Func<KeyValuePair<TriggerCardCondition, TriggerCardData>, TriggerCardCondition> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TriggerCardCondition, TriggerCardData>, TriggerCardCondition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E33 RID: 20019
			// (get) Token: 0x0600F09D RID: 61597 RVA: 0x003922F4 File Offset: 0x003904F4
			// (set) Token: 0x0600F09E RID: 61598 RVA: 0x0008106E File Offset: 0x0007F26E
			public unsafe static Func<KeyValuePair<TriggerCardCondition, TriggerCardData>, int> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TriggerCardCondition, TriggerCardData>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E34 RID: 20020
			// (get) Token: 0x0600F09F RID: 61599 RVA: 0x0039231C File Offset: 0x0039051C
			// (set) Token: 0x0600F0A0 RID: 61600 RVA: 0x00081080 File Offset: 0x0007F280
			public unsafe static Func<RogueLikeCardPersistent, RogueLikeCardBase.CardType> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardPersistent, RogueLikeCardBase.CardType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E35 RID: 20021
			// (get) Token: 0x0600F0A1 RID: 61601 RVA: 0x00392344 File Offset: 0x00390544
			// (set) Token: 0x0600F0A2 RID: 61602 RVA: 0x00081092 File Offset: 0x0007F292
			public unsafe static Func<RogueLikeCardPersistent, RogueLikeCardPersistent> __9__5_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardPersistent, RogueLikeCardPersistent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E36 RID: 20022
			// (get) Token: 0x0600F0A3 RID: 61603 RVA: 0x0039236C File Offset: 0x0039056C
			// (set) Token: 0x0600F0A4 RID: 61604 RVA: 0x000810A4 File Offset: 0x0007F2A4
			public unsafe static Action __9__5_28
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_28, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_28, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E37 RID: 20023
			// (get) Token: 0x0600F0A5 RID: 61605 RVA: 0x00392394 File Offset: 0x00390594
			// (set) Token: 0x0600F0A6 RID: 61606 RVA: 0x000810B6 File Offset: 0x0007F2B6
			public unsafe static Action __9__5_29
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_29, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_29, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E38 RID: 20024
			// (get) Token: 0x0600F0A7 RID: 61607 RVA: 0x003923BC File Offset: 0x003905BC
			// (set) Token: 0x0600F0A8 RID: 61608 RVA: 0x000810C8 File Offset: 0x0007F2C8
			public unsafe static Func<RogueLikeCardInstance, RogueLikeCardBase.CardType> __9__5_31
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_31, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardInstance, RogueLikeCardBase.CardType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_31, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E39 RID: 20025
			// (get) Token: 0x0600F0A9 RID: 61609 RVA: 0x003923E4 File Offset: 0x003905E4
			// (set) Token: 0x0600F0AA RID: 61610 RVA: 0x000810DA File Offset: 0x0007F2DA
			public unsafe static Func<IGrouping<RogueLikeCardBase.CardType, RogueLikeCardInstance>, KeyValuePair<RogueLikeCardBase.CardType, int>> __9__5_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<RogueLikeCardBase.CardType, RogueLikeCardInstance>, KeyValuePair<RogueLikeCardBase.CardType, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E3A RID: 20026
			// (get) Token: 0x0600F0AB RID: 61611 RVA: 0x0039240C File Offset: 0x0039060C
			// (set) Token: 0x0600F0AC RID: 61612 RVA: 0x000810EC File Offset: 0x0007F2EC
			public unsafe static Func<RogueLikeRunTimeData.EliteChallengeCache, bool> __9__5_36
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_36, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeRunTimeData.EliteChallengeCache, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_36, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E3B RID: 20027
			// (get) Token: 0x0600F0AD RID: 61613 RVA: 0x00392434 File Offset: 0x00390634
			// (set) Token: 0x0600F0AE RID: 61614 RVA: 0x000810FE File Offset: 0x0007F2FE
			public unsafe static Func<DLC5_RogueLikeCardScorePanel.CardScorePair, bool> __9__5_45
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_45, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeCardScorePanel.CardScorePair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_45, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E3C RID: 20028
			// (get) Token: 0x0600F0AF RID: 61615 RVA: 0x0039245C File Offset: 0x0039065C
			// (set) Token: 0x0600F0B0 RID: 61616 RVA: 0x00081110 File Offset: 0x0007F310
			public unsafe static Func<DLC5_RogueLikeCardScorePanel.CardScorePair, int> __9__5_46
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_46, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeCardScorePanel.CardScorePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_46, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E3D RID: 20029
			// (get) Token: 0x0600F0B1 RID: 61617 RVA: 0x00392484 File Offset: 0x00390684
			// (set) Token: 0x0600F0B2 RID: 61618 RVA: 0x00081122 File Offset: 0x0007F322
			public unsafe static Func<Product, bool> __9__5_47
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_47, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_47, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E3E RID: 20030
			// (get) Token: 0x0600F0B3 RID: 61619 RVA: 0x003924AC File Offset: 0x003906AC
			// (set) Token: 0x0600F0B4 RID: 61620 RVA: 0x00081134 File Offset: 0x0007F334
			public unsafe static Action __9__5_48
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_48, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_48, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E3F RID: 20031
			// (get) Token: 0x0600F0B5 RID: 61621 RVA: 0x003924D4 File Offset: 0x003906D4
			// (set) Token: 0x0600F0B6 RID: 61622 RVA: 0x00081146 File Offset: 0x0007F346
			public unsafe static Action __9__5_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E40 RID: 20032
			// (get) Token: 0x0600F0B7 RID: 61623 RVA: 0x003924FC File Offset: 0x003906FC
			// (set) Token: 0x0600F0B8 RID: 61624 RVA: 0x00081158 File Offset: 0x0007F358
			public unsafe static Func<RogueLikeCardRewardRate, float> __9__5_49
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_49, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardRewardRate, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_49, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E41 RID: 20033
			// (get) Token: 0x0600F0B9 RID: 61625 RVA: 0x00392524 File Offset: 0x00390724
			// (set) Token: 0x0600F0BA RID: 61626 RVA: 0x0008116A File Offset: 0x0007F36A
			public unsafe static Func<RogueLikeCardRewardRate, RogueLikeCardBase.Rarity> __9__5_50
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_50, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardRewardRate, RogueLikeCardBase.Rarity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_50, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E42 RID: 20034
			// (get) Token: 0x0600F0BB RID: 61627 RVA: 0x0039254C File Offset: 0x0039074C
			// (set) Token: 0x0600F0BC RID: 61628 RVA: 0x0008117C File Offset: 0x0007F37C
			public unsafe static Func<bool> __9__5_55
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_55, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeBossData.__c.NativeFieldInfoPtr___9__5_55, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009957 RID: 39255
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009958 RID: 39256
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04009959 RID: 39257
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x0400995A RID: 39258
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x0400995B RID: 39259
			private static readonly IntPtr NativeFieldInfoPtr___9__5_4;

			// Token: 0x0400995C RID: 39260
			private static readonly IntPtr NativeFieldInfoPtr___9__5_28;

			// Token: 0x0400995D RID: 39261
			private static readonly IntPtr NativeFieldInfoPtr___9__5_29;

			// Token: 0x0400995E RID: 39262
			private static readonly IntPtr NativeFieldInfoPtr___9__5_31;

			// Token: 0x0400995F RID: 39263
			private static readonly IntPtr NativeFieldInfoPtr___9__5_32;

			// Token: 0x04009960 RID: 39264
			private static readonly IntPtr NativeFieldInfoPtr___9__5_36;

			// Token: 0x04009961 RID: 39265
			private static readonly IntPtr NativeFieldInfoPtr___9__5_45;

			// Token: 0x04009962 RID: 39266
			private static readonly IntPtr NativeFieldInfoPtr___9__5_46;

			// Token: 0x04009963 RID: 39267
			private static readonly IntPtr NativeFieldInfoPtr___9__5_47;

			// Token: 0x04009964 RID: 39268
			private static readonly IntPtr NativeFieldInfoPtr___9__5_48;

			// Token: 0x04009965 RID: 39269
			private static readonly IntPtr NativeFieldInfoPtr___9__5_22;

			// Token: 0x04009966 RID: 39270
			private static readonly IntPtr NativeFieldInfoPtr___9__5_49;

			// Token: 0x04009967 RID: 39271
			private static readonly IntPtr NativeFieldInfoPtr___9__5_50;

			// Token: 0x04009968 RID: 39272
			private static readonly IntPtr NativeFieldInfoPtr___9__5_55;

			// Token: 0x04009969 RID: 39273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400996A RID: 39274
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_1_Internal_TriggerCardCondition_KeyValuePair_2_TriggerCardCondition_TriggerCardData_0;

			// Token: 0x0400996B RID: 39275
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_2_Internal_Int32_KeyValuePair_2_TriggerCardCondition_TriggerCardData_0;

			// Token: 0x0400996C RID: 39276
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_3_Internal_CardType_RogueLikeCardPersistent_0;

			// Token: 0x0400996D RID: 39277
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_4_Internal_RogueLikeCardPersistent_RogueLikeCardPersistent_0;

			// Token: 0x0400996E RID: 39278
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_28_Internal_Void_0;

			// Token: 0x0400996F RID: 39279
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_29_Internal_Void_0;

			// Token: 0x04009970 RID: 39280
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_31_Internal_CardType_RogueLikeCardInstance_0;

			// Token: 0x04009971 RID: 39281
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_32_Internal_KeyValuePair_2_CardType_Int32_IGrouping_2_CardType_RogueLikeCardInstance_0;

			// Token: 0x04009972 RID: 39282
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_36_Internal_Boolean_EliteChallengeCache_0;

			// Token: 0x04009973 RID: 39283
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_45_Internal_Boolean_CardScorePair_0;

			// Token: 0x04009974 RID: 39284
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_46_Internal_Int32_CardScorePair_0;

			// Token: 0x04009975 RID: 39285
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_47_Internal_Boolean_Product_0;

			// Token: 0x04009976 RID: 39286
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_22_Internal_Void_0;

			// Token: 0x04009977 RID: 39287
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_48_Internal_Void_0;

			// Token: 0x04009978 RID: 39288
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_49_Internal_Single_RogueLikeCardRewardRate_0;

			// Token: 0x04009979 RID: 39289
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_50_Internal_Rarity_RogueLikeCardRewardRate_0;

			// Token: 0x0400997A RID: 39290
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_55_Internal_Boolean_0;
		}

		// Token: 0x02000D13 RID: 3347
		[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<MainChallengeLoop>d__5")]
		public sealed class _MainChallengeLoop_d__5 : Il2CppSystem.Object
		{
			// Token: 0x0600F0BD RID: 61629 RVA: 0x00392574 File Offset: 0x00390774
			// Note: this type is marked as 'beforefieldinit'.
			static _MainChallengeLoop_d__5()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "<MainChallengeLoop>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr);
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "bossDataContext");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<>8__1");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<>8__2");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__achievementData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<achievementData>5__2");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__selectedRoundSetup_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<selectedRoundSetup>5__3");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__roundDuration_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<roundDuration>5__4");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__waitForContinue_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<waitForContinue>5__5");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__eliteBossChallengeData_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<eliteBossChallengeData>5__6");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__coroutine_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<coroutine>5__7");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__baseMoneyDoNotPassed_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<baseMoneyDoNotPassed>5__8");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__cardDic_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<cardDic>5__9");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__cardScorePairs_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, "<cardScorePairs>5__10");
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, 100682209);
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, 100682210);
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, 100682211);
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, 100682212);
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, 100682213);
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, 100682214);
				DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr, 100682215);
			}

			// Token: 0x0600F0BE RID: 61630 RVA: 0x00392758 File Offset: 0x00390958
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MainChallengeLoop_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData._MainChallengeLoop_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F0BF RID: 61631 RVA: 0x003927A0 File Offset: 0x003909A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229348, XrefRangeEnd = 229351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F0C0 RID: 61632 RVA: 0x003927D4 File Offset: 0x003909D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229351, XrefRangeEnd = 230288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F0C1 RID: 61633 RVA: 0x00392810 File Offset: 0x00390A10
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 230294, RefRangeEnd = 230295, XrefRangeStart = 230288, XrefRangeEnd = 230294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004E52 RID: 20050
			// (get) Token: 0x0600F0C2 RID: 61634 RVA: 0x00392844 File Offset: 0x00390A44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F0C3 RID: 61635 RVA: 0x00392884 File Offset: 0x00390A84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230295, XrefRangeEnd = 230301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004E53 RID: 20051
			// (get) Token: 0x0600F0C4 RID: 61636 RVA: 0x003928B8 File Offset: 0x00390AB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F0C5 RID: 61637 RVA: 0x0008118E File Offset: 0x0007F38E
			public _MainChallengeLoop_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E43 RID: 20035
			// (get) Token: 0x0600F0C6 RID: 61638 RVA: 0x003928F8 File Offset: 0x00390AF8
			// (set) Token: 0x0600F0C7 RID: 61639 RVA: 0x00081197 File Offset: 0x0007F397
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004E44 RID: 20036
			// (get) Token: 0x0600F0C8 RID: 61640 RVA: 0x00392920 File Offset: 0x00390B20
			// (set) Token: 0x0600F0C9 RID: 61641 RVA: 0x000811B2 File Offset: 0x0007F3B2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E45 RID: 20037
			// (get) Token: 0x0600F0CA RID: 61642 RVA: 0x00392950 File Offset: 0x00390B50
			// (set) Token: 0x0600F0CB RID: 61643 RVA: 0x000811D1 File Offset: 0x0007F3D1
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004E46 RID: 20038
			// (get) Token: 0x0600F0CC RID: 61644 RVA: 0x00392980 File Offset: 0x00390B80
			// (set) Token: 0x0600F0CD RID: 61645 RVA: 0x000811FF File Offset: 0x0007F3FF
			public unsafe DLC5_RogueLikeBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E47 RID: 20039
			// (get) Token: 0x0600F0CE RID: 61646 RVA: 0x003929B0 File Offset: 0x00390BB0
			// (set) Token: 0x0600F0CF RID: 61647 RVA: 0x0008121E File Offset: 0x0007F41E
			public unsafe DLC5_RogueLikeBossData.__c__DisplayClass5_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData.__c__DisplayClass5_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E48 RID: 20040
			// (get) Token: 0x0600F0D0 RID: 61648 RVA: 0x003929E0 File Offset: 0x00390BE0
			// (set) Token: 0x0600F0D1 RID: 61649 RVA: 0x0008123D File Offset: 0x0007F43D
			public unsafe DLC5_RogueLikeBossData.__c__DisplayClass5_2 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData.__c__DisplayClass5_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E49 RID: 20041
			// (get) Token: 0x0600F0D2 RID: 61650 RVA: 0x00392A10 File Offset: 0x00390C10
			// (set) Token: 0x0600F0D3 RID: 61651 RVA: 0x0008125C File Offset: 0x0007F45C
			public unsafe RogueLikeAchievementRunTimeData _achievementData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__achievementData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeAchievementRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__achievementData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E4A RID: 20042
			// (get) Token: 0x0600F0D4 RID: 61652 RVA: 0x00392A40 File Offset: 0x00390C40
			// (set) Token: 0x0600F0D5 RID: 61653 RVA: 0x0008127B File Offset: 0x0007F47B
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeRoundSetup _selectedRoundSetup_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__selectedRoundSetup_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__selectedRoundSetup_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E4B RID: 20043
			// (get) Token: 0x0600F0D6 RID: 61654 RVA: 0x00392A70 File Offset: 0x00390C70
			// (set) Token: 0x0600F0D7 RID: 61655 RVA: 0x0008129A File Offset: 0x0007F49A
			public unsafe int _roundDuration_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__roundDuration_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__roundDuration_5__4)) = value;
				}
			}

			// Token: 0x17004E4C RID: 20044
			// (get) Token: 0x0600F0D8 RID: 61656 RVA: 0x00392A98 File Offset: 0x00390C98
			// (set) Token: 0x0600F0D9 RID: 61657 RVA: 0x000812B5 File Offset: 0x0007F4B5
			public unsafe WaitUntil _waitForContinue_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__waitForContinue_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__waitForContinue_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E4D RID: 20045
			// (get) Token: 0x0600F0DA RID: 61658 RVA: 0x00392AC8 File Offset: 0x00390CC8
			// (set) Token: 0x0600F0DB RID: 61659 RVA: 0x000812D4 File Offset: 0x0007F4D4
			public unsafe RogueLikeRunTimeData.EliteChallengeBase _eliteBossChallengeData_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__eliteBossChallengeData_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData.EliteChallengeBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__eliteBossChallengeData_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E4E RID: 20046
			// (get) Token: 0x0600F0DC RID: 61660 RVA: 0x00392AF8 File Offset: 0x00390CF8
			// (set) Token: 0x0600F0DD RID: 61661 RVA: 0x000812F3 File Offset: 0x0007F4F3
			public unsafe Coroutine _coroutine_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__coroutine_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__coroutine_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E4F RID: 20047
			// (get) Token: 0x0600F0DE RID: 61662 RVA: 0x00392B28 File Offset: 0x00390D28
			// (set) Token: 0x0600F0DF RID: 61663 RVA: 0x00081312 File Offset: 0x0007F512
			public unsafe bool _baseMoneyDoNotPassed_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__baseMoneyDoNotPassed_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__baseMoneyDoNotPassed_5__8)) = value;
				}
			}

			// Token: 0x17004E50 RID: 20048
			// (get) Token: 0x0600F0E0 RID: 61664 RVA: 0x00392B50 File Offset: 0x00390D50
			// (set) Token: 0x0600F0E1 RID: 61665 RVA: 0x0008132D File Offset: 0x0007F52D
			public unsafe Dictionary<RogueLikeCardBase.CardType, List<Product>> _cardDic_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__cardDic_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeCardBase.CardType, List<Product>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__cardDic_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E51 RID: 20049
			// (get) Token: 0x0600F0E2 RID: 61666 RVA: 0x00392B80 File Offset: 0x00390D80
			// (set) Token: 0x0600F0E3 RID: 61667 RVA: 0x0008134C File Offset: 0x0007F54C
			public unsafe List<DLC5_RogueLikeCardScorePanel.CardScorePair> _cardScorePairs_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__cardScorePairs_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_RogueLikeCardScorePanel.CardScorePair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._MainChallengeLoop_d__5.NativeFieldInfoPtr__cardScorePairs_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400997B RID: 39291
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400997C RID: 39292
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400997D RID: 39293
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x0400997E RID: 39294
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400997F RID: 39295
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04009980 RID: 39296
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x04009981 RID: 39297
			private static readonly IntPtr NativeFieldInfoPtr__achievementData_5__2;

			// Token: 0x04009982 RID: 39298
			private static readonly IntPtr NativeFieldInfoPtr__selectedRoundSetup_5__3;

			// Token: 0x04009983 RID: 39299
			private static readonly IntPtr NativeFieldInfoPtr__roundDuration_5__4;

			// Token: 0x04009984 RID: 39300
			private static readonly IntPtr NativeFieldInfoPtr__waitForContinue_5__5;

			// Token: 0x04009985 RID: 39301
			private static readonly IntPtr NativeFieldInfoPtr__eliteBossChallengeData_5__6;

			// Token: 0x04009986 RID: 39302
			private static readonly IntPtr NativeFieldInfoPtr__coroutine_5__7;

			// Token: 0x04009987 RID: 39303
			private static readonly IntPtr NativeFieldInfoPtr__baseMoneyDoNotPassed_5__8;

			// Token: 0x04009988 RID: 39304
			private static readonly IntPtr NativeFieldInfoPtr__cardDic_5__9;

			// Token: 0x04009989 RID: 39305
			private static readonly IntPtr NativeFieldInfoPtr__cardScorePairs_5__10;

			// Token: 0x0400998A RID: 39306
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400998B RID: 39307
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400998C RID: 39308
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400998D RID: 39309
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400998E RID: 39310
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400998F RID: 39311
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009990 RID: 39312
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D14 RID: 3348
		[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F0E4 RID: 61668 RVA: 0x00392BB0 File Offset: 0x00390DB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr);
				DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr, "duration");
				DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_timeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr, "timeEnd");
				DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_tokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr, "tokenSource");
				DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr, 100682216);
				DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeMethodInfoPtr__Timing_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr, 100682217);
				DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr, 100682218);
				DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr, 100682219);
			}

			// Token: 0x0600F0E5 RID: 61669 RVA: 0x00392C7C File Offset: 0x00390E7C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F0E6 RID: 61670 RVA: 0x00392CB8 File Offset: 0x00390EB8
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Timing_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeMethodInfoPtr__Timing_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F0E7 RID: 61671 RVA: 0x00392CF4 File Offset: 0x00390EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230301, XrefRangeEnd = 230303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Method_Internal_Int32_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F0E8 RID: 61672 RVA: 0x00392D30 File Offset: 0x00390F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230303, XrefRangeEnd = 230305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F0E9 RID: 61673 RVA: 0x0008136B File Offset: 0x0007F56B
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E54 RID: 20052
			// (get) Token: 0x0600F0EA RID: 61674 RVA: 0x00392D64 File Offset: 0x00390F64
			// (set) Token: 0x0600F0EB RID: 61675 RVA: 0x00081374 File Offset: 0x0007F574
			public unsafe int duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004E55 RID: 20053
			// (get) Token: 0x0600F0EC RID: 61676 RVA: 0x00392D8C File Offset: 0x00390F8C
			// (set) Token: 0x0600F0ED RID: 61677 RVA: 0x0008138F File Offset: 0x0007F58F
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E56 RID: 20054
			// (get) Token: 0x0600F0EE RID: 61678 RVA: 0x00392DBC File Offset: 0x00390FBC
			// (set) Token: 0x0600F0EF RID: 61679 RVA: 0x000813AE File Offset: 0x0007F5AE
			public unsafe bool timeEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_timeEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_timeEnd)) = value;
				}
			}

			// Token: 0x17004E57 RID: 20055
			// (get) Token: 0x0600F0F0 RID: 61680 RVA: 0x00392DE4 File Offset: 0x00390FE4
			// (set) Token: 0x0600F0F1 RID: 61681 RVA: 0x000813C9 File Offset: 0x0007F5C9
			public unsafe CancellationTokenSource tokenSource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_tokenSource);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData.__c__DisplayClass6_0.NativeFieldInfoPtr_tokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009991 RID: 39313
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04009992 RID: 39314
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009993 RID: 39315
			private static readonly IntPtr NativeFieldInfoPtr_timeEnd;

			// Token: 0x04009994 RID: 39316
			private static readonly IntPtr NativeFieldInfoPtr_tokenSource;

			// Token: 0x04009995 RID: 39317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009996 RID: 39318
			private static readonly IntPtr NativeMethodInfoPtr__Timing_b__0_Internal_Int32_0;

			// Token: 0x04009997 RID: 39319
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Int32_PDM_0;

			// Token: 0x04009998 RID: 39320
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000D15 RID: 3349
		[ObfuscatedName("GameData.Profile.DLC5_RogueLikeBossData+<Timing>d__6")]
		public sealed class _Timing_d__6 : Il2CppSystem.Object
		{
			// Token: 0x0600F0F2 RID: 61682 RVA: 0x00392E14 File Offset: 0x00391014
			// Note: this type is marked as 'beforefieldinit'.
			static _Timing_d__6()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeBossData>.NativeClassPtr, "<Timing>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr);
				DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, "duration");
				DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_tokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, "tokenSource");
				DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, "<>8__1");
				DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, 100682220);
				DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, 100682221);
				DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, 100682222);
				DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, 100682223);
				DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, 100682224);
				DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr, 100682225);
			}

			// Token: 0x0600F0F3 RID: 61683 RVA: 0x00392F58 File Offset: 0x00391158
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Timing_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeBossData._Timing_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F0F4 RID: 61684 RVA: 0x00392FA0 File Offset: 0x003911A0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F0F5 RID: 61685 RVA: 0x00392FD4 File Offset: 0x003911D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230305, XrefRangeEnd = 230322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004E60 RID: 20064
			// (get) Token: 0x0600F0F6 RID: 61686 RVA: 0x00393010 File Offset: 0x00391210
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F0F7 RID: 61687 RVA: 0x00393050 File Offset: 0x00391250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230322, XrefRangeEnd = 230328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004E61 RID: 20065
			// (get) Token: 0x0600F0F8 RID: 61688 RVA: 0x00393084 File Offset: 0x00391284
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeBossData._Timing_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F0F9 RID: 61689 RVA: 0x000813E8 File Offset: 0x0007F5E8
			public _Timing_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E58 RID: 20056
			// (get) Token: 0x0600F0FA RID: 61690 RVA: 0x003930C4 File Offset: 0x003912C4
			// (set) Token: 0x0600F0FB RID: 61691 RVA: 0x000813F1 File Offset: 0x0007F5F1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004E59 RID: 20057
			// (get) Token: 0x0600F0FC RID: 61692 RVA: 0x003930EC File Offset: 0x003912EC
			// (set) Token: 0x0600F0FD RID: 61693 RVA: 0x0008140C File Offset: 0x0007F60C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E5A RID: 20058
			// (get) Token: 0x0600F0FE RID: 61694 RVA: 0x0039311C File Offset: 0x0039131C
			// (set) Token: 0x0600F0FF RID: 61695 RVA: 0x0008142B File Offset: 0x0007F62B
			public unsafe int duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004E5B RID: 20059
			// (get) Token: 0x0600F100 RID: 61696 RVA: 0x00393144 File Offset: 0x00391344
			// (set) Token: 0x0600F101 RID: 61697 RVA: 0x00081446 File Offset: 0x0007F646
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E5C RID: 20060
			// (get) Token: 0x0600F102 RID: 61698 RVA: 0x00393174 File Offset: 0x00391374
			// (set) Token: 0x0600F103 RID: 61699 RVA: 0x00081465 File Offset: 0x0007F665
			public unsafe CancellationTokenSource tokenSource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_tokenSource);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_tokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E5D RID: 20061
			// (get) Token: 0x0600F104 RID: 61700 RVA: 0x003931A4 File Offset: 0x003913A4
			// (set) Token: 0x0600F105 RID: 61701 RVA: 0x00081484 File Offset: 0x0007F684
			public unsafe DLC5_RogueLikeBossData.__c__DisplayClass6_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E5E RID: 20062
			// (get) Token: 0x0600F106 RID: 61702 RVA: 0x003931D4 File Offset: 0x003913D4
			// (set) Token: 0x0600F107 RID: 61703 RVA: 0x000814A3 File Offset: 0x0007F6A3
			public unsafe DLC5_RogueLikeBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E5F RID: 20063
			// (get) Token: 0x0600F108 RID: 61704 RVA: 0x00393204 File Offset: 0x00391404
			// (set) Token: 0x0600F109 RID: 61705 RVA: 0x000814C2 File Offset: 0x0007F6C2
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeBossData._Timing_d__6.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009999 RID: 39321
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400999A RID: 39322
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400999B RID: 39323
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400999C RID: 39324
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x0400999D RID: 39325
			private static readonly IntPtr NativeFieldInfoPtr_tokenSource;

			// Token: 0x0400999E RID: 39326
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400999F RID: 39327
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099A0 RID: 39328
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040099A1 RID: 39329
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040099A2 RID: 39330
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099A3 RID: 39331
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040099A4 RID: 39332
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040099A5 RID: 39333
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099A6 RID: 39334
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
