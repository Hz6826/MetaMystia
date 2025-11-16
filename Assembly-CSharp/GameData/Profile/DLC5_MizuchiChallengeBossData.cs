using System;
using System.Runtime.InteropServices;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using GameData.RunTime.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using Night.BossBattle.DLC5_MizuchiBossBattle;
using Night.UI.HUD;
using NightScene;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.Input;
using NightScene.UI;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Profile
{
	// Token: 0x020002FA RID: 762
	public class DLC5_MizuchiChallengeBossData : BossData
	{
		// Token: 0x06005BA8 RID: 23464 RVA: 0x001D030C File Offset: 0x001CE50C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_MizuchiChallengeBossData()
		{
			Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DLC5_MizuchiChallengeBossData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr);
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_TAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "MIZUCHIBUFFSWITCH_TAN");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_CHEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "MIZUCHIBUFFSWITCH_CHEN");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_CHI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "MIZUCHIBUFFSWITCH_CHI");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_LUNARCAPITAL_PRACTICE_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "LUNARCAPITAL_PRACTICE_KEY");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_PUYOYOFRUIT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "PUYOYOFRUIT_ID");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_PEPPER_WATER_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "PEPPER_WATER_ID");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "MIZUCHI_ID");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_prdRateForMizuchiSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "prdRateForMizuchiSpawn");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_ChallengeDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "ChallengeDatas");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenPinkEval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "getTimeWhenPinkEval");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenOrangeEval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "getTimeWhenOrangeEval");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenGreenEval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "getTimeWhenGreenEval");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenPurpleEval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "getTimeWhenPurpleEval");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenBlackEval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "getTimeWhenBlackEval");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenMizuchiRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "getTimeWhenMizuchiRun");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenPatienceRunOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "getTimeWhenPatienceRunOut");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_guestRefreshTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "guestRefreshTime");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_banTimeForTanBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "banTimeForTanBuff");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_ingredientPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "ingredientPrefab");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_patienceExtraDecreaseSpeedForChenBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "patienceExtraDecreaseSpeedForChenBuff");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_qteIntervalForChiBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "qteIntervalForChiBuff");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_qteFailedDebuffTimeForChiBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "qteFailedDebuffTimeForChiBuff");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_qteFailedDebuffRateForChiBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "qteFailedDebuffRateForChiBuff");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "fogForMizuchiMap");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "fogForMizuchiMap2");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "fogForMizuchiMap3");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "fogForMizuchiMap4");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_protectTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "protectTime");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_moonEyeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "moonEyeEffect");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_moonEyeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "moonEyeDuration");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_moonEyeControllerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "moonEyeControllerPanel");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_MirrorRadius");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_WaitForAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_WaitForAnimator");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_WaitForAnimatorEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_WaitForAnimatorEnd");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_MoveSpeed");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_OffsetOfPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_OffsetOfPlayer");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FindMizuchiVfxL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_FindMizuchiVfxL");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FindMizuchiVfxR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_FindMizuchiVfxR");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FindVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_FindVfx");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_DLC5_ChallengeResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_DLC5_ChallengeResult");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_StartMirrorDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_StartMirrorDuration");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FirstAddMirrorDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_FirstAddMirrorDuration");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_MirrorExtraRecoverSpeedFirst");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_SecondAddMirrorDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_SecondAddMirrorDuration");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_MirrorExtraRecoverSpeedSecond");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_ThirdAddMirrorDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_ThirdAddMirrorDuration");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedThird = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_MirrorExtraRecoverSpeedThird");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_CirculatedAddMirrorDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_CirculatedAddMirrorDuration");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorChargingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_MirrorChargingSpeed");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedAfterChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_MirrorExtraRecoverSpeedAfterChallenge");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_EatPepperVfx");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_EatPepperVfxOffset");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfx2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_EatPepperVfx2");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfx2Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_EatPepperVfx2Offset");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_PracticeAChallengeFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_PracticeAChallengeFinishedEvent");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_PracticeBChallengeFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_PracticeBChallengeFinishedEvent");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_PracticeCChallengeFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_PracticeCChallengeFinishedEvent");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MizuchiExtraTalkingDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_MizuchiExtraTalkingDialog");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_GuestActionWhenTheyEatPepper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_GuestActionWhenTheyEatPepper");
			DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "m_EatPepperSfx");
			DLC5_MizuchiChallengeBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, 100681993);
			DLC5_MizuchiChallengeBossData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, 100681994);
			DLC5_MizuchiChallengeBossData.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, 100681995);
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x001D0828 File Offset: 0x001CEA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228612, XrefRangeEnd = 228618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_MizuchiChallengeBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x001D0888 File Offset: 0x001CEA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228618, XrefRangeEnd = 228619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_MizuchiChallengeBossData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x001D08C4 File Offset: 0x001CEAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228619, XrefRangeEnd = 228628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x00031E9F File Offset: 0x0003009F
		public DLC5_MizuchiChallengeBossData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06005BAD RID: 23469 RVA: 0x001D08EC File Offset: 0x001CEAEC
		// (set) Token: 0x06005BAE RID: 23470 RVA: 0x00031EA8 File Offset: 0x000300A8
		public unsafe static string MIZUCHIBUFFSWITCH_TAN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_TAN, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_TAN, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06005BAF RID: 23471 RVA: 0x001D090C File Offset: 0x001CEB0C
		// (set) Token: 0x06005BB0 RID: 23472 RVA: 0x00031EBA File Offset: 0x000300BA
		public unsafe static string MIZUCHIBUFFSWITCH_CHEN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_CHEN, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_CHEN, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06005BB1 RID: 23473 RVA: 0x001D092C File Offset: 0x001CEB2C
		// (set) Token: 0x06005BB2 RID: 23474 RVA: 0x00031ECC File Offset: 0x000300CC
		public unsafe static string MIZUCHIBUFFSWITCH_CHI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_CHI, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_CHI, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06005BB3 RID: 23475 RVA: 0x001D094C File Offset: 0x001CEB4C
		// (set) Token: 0x06005BB4 RID: 23476 RVA: 0x00031EDE File Offset: 0x000300DE
		public unsafe static string LUNARCAPITAL_PRACTICE_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_LUNARCAPITAL_PRACTICE_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_LUNARCAPITAL_PRACTICE_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x06005BB5 RID: 23477 RVA: 0x001D096C File Offset: 0x001CEB6C
		// (set) Token: 0x06005BB6 RID: 23478 RVA: 0x00031EF0 File Offset: 0x000300F0
		public unsafe static int PUYOYOFRUIT_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_PUYOYOFRUIT_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_PUYOYOFRUIT_ID, (void*)(&value));
			}
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x06005BB7 RID: 23479 RVA: 0x001D0988 File Offset: 0x001CEB88
		// (set) Token: 0x06005BB8 RID: 23480 RVA: 0x00031EFE File Offset: 0x000300FE
		public unsafe static int PEPPER_WATER_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_PEPPER_WATER_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_PEPPER_WATER_ID, (void*)(&value));
			}
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x06005BB9 RID: 23481 RVA: 0x001D09A4 File Offset: 0x001CEBA4
		// (set) Token: 0x06005BBA RID: 23482 RVA: 0x00031F0C File Offset: 0x0003010C
		public unsafe static int MIZUCHI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_MIZUCHI_ID, (void*)(&value));
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x06005BBB RID: 23483 RVA: 0x001D09C0 File Offset: 0x001CEBC0
		// (set) Token: 0x06005BBC RID: 23484 RVA: 0x00031F1A File Offset: 0x0003011A
		public unsafe float prdRateForMizuchiSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_prdRateForMizuchiSpawn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_prdRateForMizuchiSpawn)) = value;
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x06005BBD RID: 23485 RVA: 0x001D09E8 File Offset: 0x001CEBE8
		// (set) Token: 0x06005BBE RID: 23486 RVA: 0x00031F35 File Offset: 0x00030135
		public unsafe Il2CppStructArray<DLC5_MizuchiChallengeBossData.ChallengeData> ChallengeDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_ChallengeDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DLC5_MizuchiChallengeBossData.ChallengeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_ChallengeDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x06005BBF RID: 23487 RVA: 0x001D0A18 File Offset: 0x001CEC18
		// (set) Token: 0x06005BC0 RID: 23488 RVA: 0x00031F54 File Offset: 0x00030154
		public unsafe int getTimeWhenPinkEval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenPinkEval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenPinkEval)) = value;
			}
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06005BC1 RID: 23489 RVA: 0x001D0A40 File Offset: 0x001CEC40
		// (set) Token: 0x06005BC2 RID: 23490 RVA: 0x00031F6F File Offset: 0x0003016F
		public unsafe int getTimeWhenOrangeEval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenOrangeEval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenOrangeEval)) = value;
			}
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x06005BC3 RID: 23491 RVA: 0x001D0A68 File Offset: 0x001CEC68
		// (set) Token: 0x06005BC4 RID: 23492 RVA: 0x00031F8A File Offset: 0x0003018A
		public unsafe int getTimeWhenGreenEval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenGreenEval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenGreenEval)) = value;
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x06005BC5 RID: 23493 RVA: 0x001D0A90 File Offset: 0x001CEC90
		// (set) Token: 0x06005BC6 RID: 23494 RVA: 0x00031FA5 File Offset: 0x000301A5
		public unsafe int getTimeWhenPurpleEval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenPurpleEval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenPurpleEval)) = value;
			}
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06005BC7 RID: 23495 RVA: 0x001D0AB8 File Offset: 0x001CECB8
		// (set) Token: 0x06005BC8 RID: 23496 RVA: 0x00031FC0 File Offset: 0x000301C0
		public unsafe int getTimeWhenBlackEval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenBlackEval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenBlackEval)) = value;
			}
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06005BC9 RID: 23497 RVA: 0x001D0AE0 File Offset: 0x001CECE0
		// (set) Token: 0x06005BCA RID: 23498 RVA: 0x00031FDB File Offset: 0x000301DB
		public unsafe int getTimeWhenMizuchiRun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenMizuchiRun);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenMizuchiRun)) = value;
			}
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x06005BCB RID: 23499 RVA: 0x001D0B08 File Offset: 0x001CED08
		// (set) Token: 0x06005BCC RID: 23500 RVA: 0x00031FF6 File Offset: 0x000301F6
		public unsafe int getTimeWhenPatienceRunOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenPatienceRunOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_getTimeWhenPatienceRunOut)) = value;
			}
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x06005BCD RID: 23501 RVA: 0x001D0B30 File Offset: 0x001CED30
		// (set) Token: 0x06005BCE RID: 23502 RVA: 0x00032011 File Offset: 0x00030211
		public unsafe Vector2Int guestRefreshTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_guestRefreshTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_guestRefreshTime)) = value;
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x06005BCF RID: 23503 RVA: 0x001D0B58 File Offset: 0x001CED58
		// (set) Token: 0x06005BD0 RID: 23504 RVA: 0x0003202C File Offset: 0x0003022C
		public unsafe int banTimeForTanBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_banTimeForTanBuff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_banTimeForTanBuff)) = value;
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x06005BD1 RID: 23505 RVA: 0x001D0B80 File Offset: 0x001CED80
		// (set) Token: 0x06005BD2 RID: 23506 RVA: 0x00032047 File Offset: 0x00030247
		public unsafe GameObject ingredientPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_ingredientPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_ingredientPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x06005BD3 RID: 23507 RVA: 0x001D0BB0 File Offset: 0x001CEDB0
		// (set) Token: 0x06005BD4 RID: 23508 RVA: 0x00032066 File Offset: 0x00030266
		public unsafe float patienceExtraDecreaseSpeedForChenBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_patienceExtraDecreaseSpeedForChenBuff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_patienceExtraDecreaseSpeedForChenBuff)) = value;
			}
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x06005BD5 RID: 23509 RVA: 0x001D0BD8 File Offset: 0x001CEDD8
		// (set) Token: 0x06005BD6 RID: 23510 RVA: 0x00032081 File Offset: 0x00030281
		public unsafe float qteIntervalForChiBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_qteIntervalForChiBuff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_qteIntervalForChiBuff)) = value;
			}
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x06005BD7 RID: 23511 RVA: 0x001D0C00 File Offset: 0x001CEE00
		// (set) Token: 0x06005BD8 RID: 23512 RVA: 0x0003209C File Offset: 0x0003029C
		public unsafe int qteFailedDebuffTimeForChiBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_qteFailedDebuffTimeForChiBuff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_qteFailedDebuffTimeForChiBuff)) = value;
			}
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x06005BD9 RID: 23513 RVA: 0x001D0C28 File Offset: 0x001CEE28
		// (set) Token: 0x06005BDA RID: 23514 RVA: 0x000320B7 File Offset: 0x000302B7
		public unsafe float qteFailedDebuffRateForChiBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_qteFailedDebuffRateForChiBuff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_qteFailedDebuffRateForChiBuff)) = value;
			}
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x06005BDB RID: 23515 RVA: 0x001D0C50 File Offset: 0x001CEE50
		// (set) Token: 0x06005BDC RID: 23516 RVA: 0x000320D2 File Offset: 0x000302D2
		public unsafe GameObject fogForMizuchiMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x06005BDD RID: 23517 RVA: 0x001D0C80 File Offset: 0x001CEE80
		// (set) Token: 0x06005BDE RID: 23518 RVA: 0x000320F1 File Offset: 0x000302F1
		public unsafe GameObject fogForMizuchiMap2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x06005BDF RID: 23519 RVA: 0x001D0CB0 File Offset: 0x001CEEB0
		// (set) Token: 0x06005BE0 RID: 23520 RVA: 0x00032110 File Offset: 0x00030310
		public unsafe GameObject fogForMizuchiMap3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x06005BE1 RID: 23521 RVA: 0x001D0CE0 File Offset: 0x001CEEE0
		// (set) Token: 0x06005BE2 RID: 23522 RVA: 0x0003212F File Offset: 0x0003032F
		public unsafe GameObject fogForMizuchiMap4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_fogForMizuchiMap4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x06005BE3 RID: 23523 RVA: 0x001D0D10 File Offset: 0x001CEF10
		// (set) Token: 0x06005BE4 RID: 23524 RVA: 0x0003214E File Offset: 0x0003034E
		public unsafe int protectTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_protectTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_protectTime)) = value;
			}
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x06005BE5 RID: 23525 RVA: 0x001D0D38 File Offset: 0x001CEF38
		// (set) Token: 0x06005BE6 RID: 23526 RVA: 0x00032169 File Offset: 0x00030369
		public unsafe GameObject moonEyeEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_moonEyeEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_moonEyeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x06005BE7 RID: 23527 RVA: 0x001D0D68 File Offset: 0x001CEF68
		// (set) Token: 0x06005BE8 RID: 23528 RVA: 0x00032188 File Offset: 0x00030388
		public unsafe float moonEyeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_moonEyeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_moonEyeDuration)) = value;
			}
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06005BE9 RID: 23529 RVA: 0x001D0D90 File Offset: 0x001CEF90
		// (set) Token: 0x06005BEA RID: 23530 RVA: 0x000321A3 File Offset: 0x000303A3
		public unsafe DLC5_MoonEyeControllerPanel moonEyeControllerPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_moonEyeControllerPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MoonEyeControllerPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_moonEyeControllerPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06005BEB RID: 23531 RVA: 0x001D0DC0 File Offset: 0x001CEFC0
		// (set) Token: 0x06005BEC RID: 23532 RVA: 0x000321C2 File Offset: 0x000303C2
		public unsafe float m_MirrorRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorRadius)) = value;
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06005BED RID: 23533 RVA: 0x001D0DE8 File Offset: 0x001CEFE8
		// (set) Token: 0x06005BEE RID: 23534 RVA: 0x000321DD File Offset: 0x000303DD
		public unsafe float m_WaitForAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_WaitForAnimator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_WaitForAnimator)) = value;
			}
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06005BEF RID: 23535 RVA: 0x001D0E10 File Offset: 0x001CF010
		// (set) Token: 0x06005BF0 RID: 23536 RVA: 0x000321F8 File Offset: 0x000303F8
		public unsafe float m_WaitForAnimatorEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_WaitForAnimatorEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_WaitForAnimatorEnd)) = value;
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x06005BF1 RID: 23537 RVA: 0x001D0E38 File Offset: 0x001CF038
		// (set) Token: 0x06005BF2 RID: 23538 RVA: 0x00032213 File Offset: 0x00030413
		public unsafe float m_MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MoveSpeed)) = value;
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x06005BF3 RID: 23539 RVA: 0x001D0E60 File Offset: 0x001CF060
		// (set) Token: 0x06005BF4 RID: 23540 RVA: 0x0003222E File Offset: 0x0003042E
		public unsafe Vector2 m_OffsetOfPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_OffsetOfPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_OffsetOfPlayer)) = value;
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x06005BF5 RID: 23541 RVA: 0x001D0E88 File Offset: 0x001CF088
		// (set) Token: 0x06005BF6 RID: 23542 RVA: 0x00032249 File Offset: 0x00030449
		public unsafe GameObject m_FindMizuchiVfxL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FindMizuchiVfxL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FindMizuchiVfxL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x06005BF7 RID: 23543 RVA: 0x001D0EB8 File Offset: 0x001CF0B8
		// (set) Token: 0x06005BF8 RID: 23544 RVA: 0x00032268 File Offset: 0x00030468
		public unsafe GameObject m_FindMizuchiVfxR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FindMizuchiVfxR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FindMizuchiVfxR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06005BF9 RID: 23545 RVA: 0x001D0EE8 File Offset: 0x001CF0E8
		// (set) Token: 0x06005BFA RID: 23546 RVA: 0x00032287 File Offset: 0x00030487
		public unsafe GameObject m_FindVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FindVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FindVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06005BFB RID: 23547 RVA: 0x001D0F18 File Offset: 0x001CF118
		// (set) Token: 0x06005BFC RID: 23548 RVA: 0x000322A6 File Offset: 0x000304A6
		public unsafe DLC5_ChallengeResult m_DLC5_ChallengeResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_DLC5_ChallengeResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_ChallengeResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_DLC5_ChallengeResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x06005BFD RID: 23549 RVA: 0x001D0F48 File Offset: 0x001CF148
		// (set) Token: 0x06005BFE RID: 23550 RVA: 0x000322C5 File Offset: 0x000304C5
		public unsafe int m_StartMirrorDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_StartMirrorDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_StartMirrorDuration)) = value;
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x06005BFF RID: 23551 RVA: 0x001D0F70 File Offset: 0x001CF170
		// (set) Token: 0x06005C00 RID: 23552 RVA: 0x000322E0 File Offset: 0x000304E0
		public unsafe int m_FirstAddMirrorDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FirstAddMirrorDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_FirstAddMirrorDuration)) = value;
			}
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06005C01 RID: 23553 RVA: 0x001D0F98 File Offset: 0x001CF198
		// (set) Token: 0x06005C02 RID: 23554 RVA: 0x000322FB File Offset: 0x000304FB
		public unsafe float m_MirrorExtraRecoverSpeedFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedFirst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedFirst)) = value;
			}
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x06005C03 RID: 23555 RVA: 0x001D0FC0 File Offset: 0x001CF1C0
		// (set) Token: 0x06005C04 RID: 23556 RVA: 0x00032316 File Offset: 0x00030516
		public unsafe int m_SecondAddMirrorDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_SecondAddMirrorDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_SecondAddMirrorDuration)) = value;
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x06005C05 RID: 23557 RVA: 0x001D0FE8 File Offset: 0x001CF1E8
		// (set) Token: 0x06005C06 RID: 23558 RVA: 0x00032331 File Offset: 0x00030531
		public unsafe float m_MirrorExtraRecoverSpeedSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedSecond)) = value;
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x06005C07 RID: 23559 RVA: 0x001D1010 File Offset: 0x001CF210
		// (set) Token: 0x06005C08 RID: 23560 RVA: 0x0003234C File Offset: 0x0003054C
		public unsafe int m_ThirdAddMirrorDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_ThirdAddMirrorDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_ThirdAddMirrorDuration)) = value;
			}
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06005C09 RID: 23561 RVA: 0x001D1038 File Offset: 0x001CF238
		// (set) Token: 0x06005C0A RID: 23562 RVA: 0x00032367 File Offset: 0x00030567
		public unsafe float m_MirrorExtraRecoverSpeedThird
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedThird);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedThird)) = value;
			}
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06005C0B RID: 23563 RVA: 0x001D1060 File Offset: 0x001CF260
		// (set) Token: 0x06005C0C RID: 23564 RVA: 0x00032382 File Offset: 0x00030582
		public unsafe int m_CirculatedAddMirrorDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_CirculatedAddMirrorDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_CirculatedAddMirrorDuration)) = value;
			}
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06005C0D RID: 23565 RVA: 0x001D1088 File Offset: 0x001CF288
		// (set) Token: 0x06005C0E RID: 23566 RVA: 0x0003239D File Offset: 0x0003059D
		public unsafe float m_MirrorChargingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorChargingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorChargingSpeed)) = value;
			}
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06005C0F RID: 23567 RVA: 0x001D10B0 File Offset: 0x001CF2B0
		// (set) Token: 0x06005C10 RID: 23568 RVA: 0x000323B8 File Offset: 0x000305B8
		public unsafe float m_MirrorExtraRecoverSpeedAfterChallenge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedAfterChallenge);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedAfterChallenge)) = value;
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06005C11 RID: 23569 RVA: 0x001D10D8 File Offset: 0x001CF2D8
		// (set) Token: 0x06005C12 RID: 23570 RVA: 0x000323D3 File Offset: 0x000305D3
		public unsafe GameObject m_EatPepperVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06005C13 RID: 23571 RVA: 0x001D1108 File Offset: 0x001CF308
		// (set) Token: 0x06005C14 RID: 23572 RVA: 0x000323F2 File Offset: 0x000305F2
		public unsafe Vector3 m_EatPepperVfxOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfxOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfxOffset)) = value;
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06005C15 RID: 23573 RVA: 0x001D1130 File Offset: 0x001CF330
		// (set) Token: 0x06005C16 RID: 23574 RVA: 0x0003240D File Offset: 0x0003060D
		public unsafe GameObject m_EatPepperVfx2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfx2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfx2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x06005C17 RID: 23575 RVA: 0x001D1160 File Offset: 0x001CF360
		// (set) Token: 0x06005C18 RID: 23576 RVA: 0x0003242C File Offset: 0x0003062C
		public unsafe Vector3 m_EatPepperVfx2Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfx2Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperVfx2Offset)) = value;
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06005C19 RID: 23577 RVA: 0x001D1188 File Offset: 0x001CF388
		// (set) Token: 0x06005C1A RID: 23578 RVA: 0x00032447 File Offset: 0x00030647
		public unsafe string m_PracticeAChallengeFinishedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_PracticeAChallengeFinishedEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_PracticeAChallengeFinishedEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06005C1B RID: 23579 RVA: 0x001D11B0 File Offset: 0x001CF3B0
		// (set) Token: 0x06005C1C RID: 23580 RVA: 0x00032466 File Offset: 0x00030666
		public unsafe string m_PracticeBChallengeFinishedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_PracticeBChallengeFinishedEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_PracticeBChallengeFinishedEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06005C1D RID: 23581 RVA: 0x001D11D8 File Offset: 0x001CF3D8
		// (set) Token: 0x06005C1E RID: 23582 RVA: 0x00032485 File Offset: 0x00030685
		public unsafe string m_PracticeCChallengeFinishedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_PracticeCChallengeFinishedEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_PracticeCChallengeFinishedEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06005C1F RID: 23583 RVA: 0x001D1200 File Offset: 0x001CF400
		// (set) Token: 0x06005C20 RID: 23584 RVA: 0x000324A4 File Offset: 0x000306A4
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset m_MizuchiExtraTalkingDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MizuchiExtraTalkingDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_MizuchiExtraTalkingDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x06005C21 RID: 23585 RVA: 0x001D1230 File Offset: 0x001CF430
		// (set) Token: 0x06005C22 RID: 23586 RVA: 0x000324C3 File Offset: 0x000306C3
		public unsafe Il2CppStructArray<DLC5_MizuchiChallengeBossData.GuestRunType> m_GuestActionWhenTheyEatPepper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_GuestActionWhenTheyEatPepper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DLC5_MizuchiChallengeBossData.GuestRunType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_GuestActionWhenTheyEatPepper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06005C23 RID: 23587 RVA: 0x001D1260 File Offset: 0x001CF460
		// (set) Token: 0x06005C24 RID: 23588 RVA: 0x000324E2 File Offset: 0x000306E2
		public unsafe AudioClip m_EatPepperSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.NativeFieldInfoPtr_m_EatPepperSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CD4 RID: 15572
		private static readonly IntPtr NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_TAN;

		// Token: 0x04003CD5 RID: 15573
		private static readonly IntPtr NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_CHEN;

		// Token: 0x04003CD6 RID: 15574
		private static readonly IntPtr NativeFieldInfoPtr_MIZUCHIBUFFSWITCH_CHI;

		// Token: 0x04003CD7 RID: 15575
		private static readonly IntPtr NativeFieldInfoPtr_LUNARCAPITAL_PRACTICE_KEY;

		// Token: 0x04003CD8 RID: 15576
		private static readonly IntPtr NativeFieldInfoPtr_PUYOYOFRUIT_ID;

		// Token: 0x04003CD9 RID: 15577
		private static readonly IntPtr NativeFieldInfoPtr_PEPPER_WATER_ID;

		// Token: 0x04003CDA RID: 15578
		private static readonly IntPtr NativeFieldInfoPtr_MIZUCHI_ID;

		// Token: 0x04003CDB RID: 15579
		private static readonly IntPtr NativeFieldInfoPtr_prdRateForMizuchiSpawn;

		// Token: 0x04003CDC RID: 15580
		private static readonly IntPtr NativeFieldInfoPtr_ChallengeDatas;

		// Token: 0x04003CDD RID: 15581
		private static readonly IntPtr NativeFieldInfoPtr_getTimeWhenPinkEval;

		// Token: 0x04003CDE RID: 15582
		private static readonly IntPtr NativeFieldInfoPtr_getTimeWhenOrangeEval;

		// Token: 0x04003CDF RID: 15583
		private static readonly IntPtr NativeFieldInfoPtr_getTimeWhenGreenEval;

		// Token: 0x04003CE0 RID: 15584
		private static readonly IntPtr NativeFieldInfoPtr_getTimeWhenPurpleEval;

		// Token: 0x04003CE1 RID: 15585
		private static readonly IntPtr NativeFieldInfoPtr_getTimeWhenBlackEval;

		// Token: 0x04003CE2 RID: 15586
		private static readonly IntPtr NativeFieldInfoPtr_getTimeWhenMizuchiRun;

		// Token: 0x04003CE3 RID: 15587
		private static readonly IntPtr NativeFieldInfoPtr_getTimeWhenPatienceRunOut;

		// Token: 0x04003CE4 RID: 15588
		private static readonly IntPtr NativeFieldInfoPtr_guestRefreshTime;

		// Token: 0x04003CE5 RID: 15589
		private static readonly IntPtr NativeFieldInfoPtr_banTimeForTanBuff;

		// Token: 0x04003CE6 RID: 15590
		private static readonly IntPtr NativeFieldInfoPtr_ingredientPrefab;

		// Token: 0x04003CE7 RID: 15591
		private static readonly IntPtr NativeFieldInfoPtr_patienceExtraDecreaseSpeedForChenBuff;

		// Token: 0x04003CE8 RID: 15592
		private static readonly IntPtr NativeFieldInfoPtr_qteIntervalForChiBuff;

		// Token: 0x04003CE9 RID: 15593
		private static readonly IntPtr NativeFieldInfoPtr_qteFailedDebuffTimeForChiBuff;

		// Token: 0x04003CEA RID: 15594
		private static readonly IntPtr NativeFieldInfoPtr_qteFailedDebuffRateForChiBuff;

		// Token: 0x04003CEB RID: 15595
		private static readonly IntPtr NativeFieldInfoPtr_fogForMizuchiMap;

		// Token: 0x04003CEC RID: 15596
		private static readonly IntPtr NativeFieldInfoPtr_fogForMizuchiMap2;

		// Token: 0x04003CED RID: 15597
		private static readonly IntPtr NativeFieldInfoPtr_fogForMizuchiMap3;

		// Token: 0x04003CEE RID: 15598
		private static readonly IntPtr NativeFieldInfoPtr_fogForMizuchiMap4;

		// Token: 0x04003CEF RID: 15599
		private static readonly IntPtr NativeFieldInfoPtr_protectTime;

		// Token: 0x04003CF0 RID: 15600
		private static readonly IntPtr NativeFieldInfoPtr_moonEyeEffect;

		// Token: 0x04003CF1 RID: 15601
		private static readonly IntPtr NativeFieldInfoPtr_moonEyeDuration;

		// Token: 0x04003CF2 RID: 15602
		private static readonly IntPtr NativeFieldInfoPtr_moonEyeControllerPanel;

		// Token: 0x04003CF3 RID: 15603
		private static readonly IntPtr NativeFieldInfoPtr_m_MirrorRadius;

		// Token: 0x04003CF4 RID: 15604
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitForAnimator;

		// Token: 0x04003CF5 RID: 15605
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitForAnimatorEnd;

		// Token: 0x04003CF6 RID: 15606
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveSpeed;

		// Token: 0x04003CF7 RID: 15607
		private static readonly IntPtr NativeFieldInfoPtr_m_OffsetOfPlayer;

		// Token: 0x04003CF8 RID: 15608
		private static readonly IntPtr NativeFieldInfoPtr_m_FindMizuchiVfxL;

		// Token: 0x04003CF9 RID: 15609
		private static readonly IntPtr NativeFieldInfoPtr_m_FindMizuchiVfxR;

		// Token: 0x04003CFA RID: 15610
		private static readonly IntPtr NativeFieldInfoPtr_m_FindVfx;

		// Token: 0x04003CFB RID: 15611
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC5_ChallengeResult;

		// Token: 0x04003CFC RID: 15612
		private static readonly IntPtr NativeFieldInfoPtr_m_StartMirrorDuration;

		// Token: 0x04003CFD RID: 15613
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAddMirrorDuration;

		// Token: 0x04003CFE RID: 15614
		private static readonly IntPtr NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedFirst;

		// Token: 0x04003CFF RID: 15615
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondAddMirrorDuration;

		// Token: 0x04003D00 RID: 15616
		private static readonly IntPtr NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedSecond;

		// Token: 0x04003D01 RID: 15617
		private static readonly IntPtr NativeFieldInfoPtr_m_ThirdAddMirrorDuration;

		// Token: 0x04003D02 RID: 15618
		private static readonly IntPtr NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedThird;

		// Token: 0x04003D03 RID: 15619
		private static readonly IntPtr NativeFieldInfoPtr_m_CirculatedAddMirrorDuration;

		// Token: 0x04003D04 RID: 15620
		private static readonly IntPtr NativeFieldInfoPtr_m_MirrorChargingSpeed;

		// Token: 0x04003D05 RID: 15621
		private static readonly IntPtr NativeFieldInfoPtr_m_MirrorExtraRecoverSpeedAfterChallenge;

		// Token: 0x04003D06 RID: 15622
		private static readonly IntPtr NativeFieldInfoPtr_m_EatPepperVfx;

		// Token: 0x04003D07 RID: 15623
		private static readonly IntPtr NativeFieldInfoPtr_m_EatPepperVfxOffset;

		// Token: 0x04003D08 RID: 15624
		private static readonly IntPtr NativeFieldInfoPtr_m_EatPepperVfx2;

		// Token: 0x04003D09 RID: 15625
		private static readonly IntPtr NativeFieldInfoPtr_m_EatPepperVfx2Offset;

		// Token: 0x04003D0A RID: 15626
		private static readonly IntPtr NativeFieldInfoPtr_m_PracticeAChallengeFinishedEvent;

		// Token: 0x04003D0B RID: 15627
		private static readonly IntPtr NativeFieldInfoPtr_m_PracticeBChallengeFinishedEvent;

		// Token: 0x04003D0C RID: 15628
		private static readonly IntPtr NativeFieldInfoPtr_m_PracticeCChallengeFinishedEvent;

		// Token: 0x04003D0D RID: 15629
		private static readonly IntPtr NativeFieldInfoPtr_m_MizuchiExtraTalkingDialog;

		// Token: 0x04003D0E RID: 15630
		private static readonly IntPtr NativeFieldInfoPtr_m_GuestActionWhenTheyEatPepper;

		// Token: 0x04003D0F RID: 15631
		private static readonly IntPtr NativeFieldInfoPtr_m_EatPepperSfx;

		// Token: 0x04003D10 RID: 15632
		private static readonly IntPtr NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0;

		// Token: 0x04003D11 RID: 15633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D12 RID: 15634
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0;

		// Token: 0x02000CF8 RID: 3320
		[Serializable]
		[StructLayout(2)]
		public struct ChallengeData
		{
			// Token: 0x0600EE9B RID: 61083 RVA: 0x0038BD6C File Offset: 0x00389F6C
			// Note: this type is marked as 'beforefieldinit'.
			static ChallengeData()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.ChallengeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "ChallengeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.ChallengeData>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.ChallengeData.NativeFieldInfoPtr_ChallengeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.ChallengeData>.NativeClassPtr, "ChallengeType");
				DLC5_MizuchiChallengeBossData.ChallengeData.NativeFieldInfoPtr_puyoyoFruitGiveNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.ChallengeData>.NativeClassPtr, "puyoyoFruitGiveNum");
				DLC5_MizuchiChallengeBossData.ChallengeData.NativeFieldInfoPtr_needCatchMizuchiTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.ChallengeData>.NativeClassPtr, "needCatchMizuchiTime");
				DLC5_MizuchiChallengeBossData.ChallengeData.NativeFieldInfoPtr_challengeHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.ChallengeData>.NativeClassPtr, "challengeHp");
			}

			// Token: 0x0600EE9C RID: 61084 RVA: 0x0007FE91 File Offset: 0x0007E091
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.ChallengeData>.NativeClassPtr, ref this));
			}

			// Token: 0x04009809 RID: 38921
			private static readonly IntPtr NativeFieldInfoPtr_ChallengeType;

			// Token: 0x0400980A RID: 38922
			private static readonly IntPtr NativeFieldInfoPtr_puyoyoFruitGiveNum;

			// Token: 0x0400980B RID: 38923
			private static readonly IntPtr NativeFieldInfoPtr_needCatchMizuchiTime;

			// Token: 0x0400980C RID: 38924
			private static readonly IntPtr NativeFieldInfoPtr_challengeHp;

			// Token: 0x0400980D RID: 38925
			[FieldOffset(0)]
			public NightSceneDirector.ChallengeType ChallengeType;

			// Token: 0x0400980E RID: 38926
			[FieldOffset(4)]
			public int puyoyoFruitGiveNum;

			// Token: 0x0400980F RID: 38927
			[FieldOffset(8)]
			public int needCatchMizuchiTime;

			// Token: 0x04009810 RID: 38928
			[FieldOffset(12)]
			public int challengeHp;
		}

		// Token: 0x02000CF9 RID: 3321
		[Serializable]
		[StructLayout(2)]
		public struct GuestRunType
		{
			// Token: 0x0600EE9D RID: 61085 RVA: 0x0038BDE8 File Offset: 0x00389FE8
			// Note: this type is marked as 'beforefieldinit'.
			static GuestRunType()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.GuestRunType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "GuestRunType");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.GuestRunType>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.GuestRunType.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.GuestRunType>.NativeClassPtr, "id");
				DLC5_MizuchiChallengeBossData.GuestRunType.NativeFieldInfoPtr_MouthFireType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.GuestRunType>.NativeClassPtr, "MouthFireType");
				DLC5_MizuchiChallengeBossData.GuestRunType.NativeFieldInfoPtr_RunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.GuestRunType>.NativeClassPtr, "RunSpeed");
				DLC5_MizuchiChallengeBossData.GuestRunType.NativeFieldInfoPtr_EyeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.GuestRunType>.NativeClassPtr, "EyeType");
			}

			// Token: 0x0600EE9E RID: 61086 RVA: 0x0007FEA3 File Offset: 0x0007E0A3
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.GuestRunType>.NativeClassPtr, ref this));
			}

			// Token: 0x04009811 RID: 38929
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04009812 RID: 38930
			private static readonly IntPtr NativeFieldInfoPtr_MouthFireType;

			// Token: 0x04009813 RID: 38931
			private static readonly IntPtr NativeFieldInfoPtr_RunSpeed;

			// Token: 0x04009814 RID: 38932
			private static readonly IntPtr NativeFieldInfoPtr_EyeType;

			// Token: 0x04009815 RID: 38933
			[FieldOffset(0)]
			public int id;

			// Token: 0x04009816 RID: 38934
			[FieldOffset(4)]
			public DLC5_MizuchiChallengeBossData.MouthFireType MouthFireType;

			// Token: 0x04009817 RID: 38935
			[FieldOffset(8)]
			public DLC5_MizuchiChallengeBossData.RunSpeed RunSpeed;

			// Token: 0x04009818 RID: 38936
			[FieldOffset(12)]
			public DLC5_MizuchiChallengeBossData.EyeType EyeType;
		}

		// Token: 0x02000CFA RID: 3322
		public enum MouthFireType
		{
			// Token: 0x0400981A RID: 38938
			Fire,
			// Token: 0x0400981B RID: 38939
			None
		}

		// Token: 0x02000CFB RID: 3323
		public enum RunSpeed
		{
			// Token: 0x0400981D RID: 38941
			Normal,
			// Token: 0x0400981E RID: 38942
			Fast,
			// Token: 0x0400981F RID: 38943
			VeryFast
		}

		// Token: 0x02000CFC RID: 3324
		public enum EyeType
		{
			// Token: 0x04009821 RID: 38945
			Smile,
			// Token: 0x04009822 RID: 38946
			Normal,
			// Token: 0x04009823 RID: 38947
			Pain,
			// Token: 0x04009824 RID: 38948
			Close
		}

		// Token: 0x02000CFD RID: 3325
		public enum MizuchiControlType
		{
			// Token: 0x04009826 RID: 38950
			WrongBeverageTag,
			// Token: 0x04009827 RID: 38951
			WrongFoodOrder,
			// Token: 0x04009828 RID: 38952
			WrongTalkingDialog,
			// Token: 0x04009829 RID: 38953
			None
		}

		// Token: 0x02000CFE RID: 3326
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EE9F RID: 61087 RVA: 0x0038BE64 File Offset: 0x0038A064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "foods");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "bevs");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "ings");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_guiText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "guiText");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_pupuyoFruitNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "pupuyoFruitNum");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_catchMizuchiNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "catchMizuchiNum");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_currentGuestWhoIsControlledByMizuchi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "currentGuestWhoIsControlledByMizuchi");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_typeOfMizuchi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "typeOfMizuchi");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "canContinue");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "eventManager");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<>4__this");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isTimeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "isTimeEnd");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_uiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "uiManager");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_extraRecoverSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "extraRecoverSpeed");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_targetIngredientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "targetIngredientId");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "bossDataContext");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_izakayaConfigure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "izakayaConfigure");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isUsingMoonEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "isUsingMoonEye");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_remainingTimeForMoonEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "remainingTimeForMoonEye");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_maxTimeForMoonEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "maxTimeForMoonEye");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_statusDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "statusDisplayer");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_specialGuestControllerInScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "specialGuestControllerInScene");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isMizuchiChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "isMizuchiChallenge");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_mizuchiFoundDialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "mizuchiFoundDialogs");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_characterDialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "characterDialogs");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_mizuchiNotFoundDialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "mizuchiNotFoundDialogs");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_allSpecialGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "allSpecialGuest");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_specialGuestInScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "specialGuestInScene");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_guestsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "guestsManager");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_remainingProtectTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "remainingProtectTime");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_challengeHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "challengeHp");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_trySpawnMizuchiTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "trySpawnMizuchiTime");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_mizuchiControlTypeHashset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "mizuchiControlTypeHashset");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_actionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "actionType");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_needCatchMizuchiTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "needCatchMizuchiTime");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "isAnimation");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_onChallengeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "onChallengeEnd");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_giveBadge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "giveBadge");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_canContinueYieldInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "canContinueYieldInstruction");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__66 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<>9__66");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__67 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<>9__67");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__68 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<>9__68");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__69 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<>9__69");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__70 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<>9__70");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100681996);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__0_Internal_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100681997);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100681998);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100681999);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682000);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682001);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__37_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682002);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682003);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__43_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682004);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Void_UIElementCluster_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682005);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682006);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682007);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682008);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682009);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682010);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_String_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682011);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682012);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_String_Int32_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682013);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682014);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__60_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682015);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__61_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682016);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__66_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682017);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__62_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682018);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__63_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682019);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__67_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682020);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__64_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682021);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__65_Internal_Int32_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682022);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__68_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682023);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__69_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682024);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__70_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682025);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682026);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682027);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Boolean_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682028);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682029);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass66_11_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682030);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__23_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682031);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__24_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682032);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__25_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682033);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__26_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682034);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__83_Internal_Void_DLC5_ChallengeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682035);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682036);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682037);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__84_Internal_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682038);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682039);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682040);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__85_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, 100682041);
			}

			// Token: 0x0600EEA0 RID: 61088 RVA: 0x0038C598 File Offset: 0x0038A798
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEA1 RID: 61089 RVA: 0x0038C5D4 File Offset: 0x0038A7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__0_Internal_Void_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEA2 RID: 61090 RVA: 0x0038C608 File Offset: 0x0038A808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226947, XrefRangeEnd = 226992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EEA3 RID: 61091 RVA: 0x0038C640 File Offset: 0x0038A840
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEA4 RID: 61092 RVA: 0x0038C67C File Offset: 0x0038A87C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 226992, RefRangeEnd = 226993, XrefRangeStart = 226992, XrefRangeEnd = 226992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEA5 RID: 61093 RVA: 0x0038C6B0 File Offset: 0x0038A8B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226993, XrefRangeEnd = 226998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EEA6 RID: 61094 RVA: 0x0038C6F0 File Offset: 0x0038A8F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226998, XrefRangeEnd = 227003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__37(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__37_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EEA7 RID: 61095 RVA: 0x0038C738 File Offset: 0x0038A938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227003, XrefRangeEnd = 227007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEA8 RID: 61096 RVA: 0x0038C76C File Offset: 0x0038A96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227007, XrefRangeEnd = 227012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__43(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__43_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EEA9 RID: 61097 RVA: 0x0038C7B4 File Offset: 0x0038A9B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227012, XrefRangeEnd = 227033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__52(UIElementCluster cluster, ValueTuple<int, int> id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(id));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Void_UIElementCluster_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEAA RID: 61098 RVA: 0x0038C810 File Offset: 0x0038AA10
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 227086, RefRangeEnd = 227087, XrefRangeStart = 227033, XrefRangeEnd = 227086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEAB RID: 61099 RVA: 0x0038C844 File Offset: 0x0038AA44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227087, XrefRangeEnd = 227092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EEAC RID: 61100 RVA: 0x0038C884 File Offset: 0x0038AA84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227092, XrefRangeEnd = 227094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEAD RID: 61101 RVA: 0x0038C8B8 File Offset: 0x0038AAB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227094, XrefRangeEnd = 227189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEAE RID: 61102 RVA: 0x0038C8EC File Offset: 0x0038AAEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227189, XrefRangeEnd = 227191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__55(float remaining)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref remaining;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEAF RID: 61103 RVA: 0x0038C92C File Offset: 0x0038AB2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227191, XrefRangeEnd = 227194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_Int32_PDM_0(int guestId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref guestId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_String_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EEB0 RID: 61104 RVA: 0x0038C970 File Offset: 0x0038AB70
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 227198, RefRangeEnd = 227200, XrefRangeStart = 227194, XrefRangeEnd = 227198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_Int32_0(int guestId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref guestId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EEB1 RID: 61105 RVA: 0x0038C9B4 File Offset: 0x0038ABB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227200, XrefRangeEnd = 227204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_Int32_PDM_1(int guestId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref guestId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_String_Int32_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EEB2 RID: 61106 RVA: 0x0038C9F8 File Offset: 0x0038ABF8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 227347, RefRangeEnd = 227349, XrefRangeStart = 227204, XrefRangeEnd = 227347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEB3 RID: 61107 RVA: 0x0038CA2C File Offset: 0x0038AC2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227349, XrefRangeEnd = 227354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__60(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__60_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEB4 RID: 61108 RVA: 0x0038CA7C File Offset: 0x0038AC7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227354, XrefRangeEnd = 227366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__61(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__61_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEB5 RID: 61109 RVA: 0x0038CACC File Offset: 0x0038ACCC
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__66(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__66_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEB6 RID: 61110 RVA: 0x0038CB18 File Offset: 0x0038AD18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227366, XrefRangeEnd = 227368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__62(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__62_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEB7 RID: 61111 RVA: 0x0038CB68 File Offset: 0x0038AD68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227368, XrefRangeEnd = 227380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__63(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__63_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEB8 RID: 61112 RVA: 0x0038CBB8 File Offset: 0x0038ADB8
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__67(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__67_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEB9 RID: 61113 RVA: 0x0038CC04 File Offset: 0x0038AE04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227380, XrefRangeEnd = 227385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__64(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__64_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEBA RID: 61114 RVA: 0x0038CC54 File Offset: 0x0038AE54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227385, XrefRangeEnd = 227397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__65(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__65_Internal_Int32_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEBB RID: 61115 RVA: 0x0038CCA4 File Offset: 0x0038AEA4
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__68(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__68_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEBC RID: 61116 RVA: 0x0038CCF0 File Offset: 0x0038AEF0
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__69(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__69_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEBD RID: 61117 RVA: 0x0038CD3C File Offset: 0x0038AF3C
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__70(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__70_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEBE RID: 61118 RVA: 0x0038CD88 File Offset: 0x0038AF88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227397, XrefRangeEnd = 227398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__21(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEBF RID: 61119 RVA: 0x0038CDCC File Offset: 0x0038AFCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227398, XrefRangeEnd = 227403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EEC0 RID: 61120 RVA: 0x0038CE0C File Offset: 0x0038B00C
			[CallerCount(0)]
			public unsafe bool Method_Internal_Boolean_Int32_PDM_0(int guestId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref guestId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Boolean_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEC1 RID: 61121 RVA: 0x0038CE58 File Offset: 0x0038B058
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_PDM_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEC2 RID: 61122 RVA: 0x0038CE8C File Offset: 0x0038B08C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 227418, RefRangeEnd = 227421, XrefRangeStart = 227403, XrefRangeEnd = 227418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_byref___c__DisplayClass66_11_PDM_0(ref DLC5_MizuchiChallengeBossData.__c__DisplayClass66_11 A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass66_11_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEC3 RID: 61123 RVA: 0x0038CECC File Offset: 0x0038B0CC
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__23()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__23_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEC4 RID: 61124 RVA: 0x0038CF08 File Offset: 0x0038B108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227421, XrefRangeEnd = 227422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__24()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__24_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEC5 RID: 61125 RVA: 0x0038CF44 File Offset: 0x0038B144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227422, XrefRangeEnd = 227423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__25(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__25_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEC6 RID: 61126 RVA: 0x0038CF88 File Offset: 0x0038B188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__26(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__26_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEC7 RID: 61127 RVA: 0x0038CFCC File Offset: 0x0038B1CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 226992, RefRangeEnd = 226993, XrefRangeStart = 226992, XrefRangeEnd = 226993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__83(DLC5_ChallengeResult _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__83_Internal_Void_DLC5_ChallengeResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEC8 RID: 61128 RVA: 0x0038D010 File Offset: 0x0038B210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227423, XrefRangeEnd = 227429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEC9 RID: 61129 RVA: 0x0038D044 File Offset: 0x0038B244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227429, XrefRangeEnd = 227434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EECA RID: 61130 RVA: 0x0038D084 File Offset: 0x0038B284
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 226992, RefRangeEnd = 226993, XrefRangeStart = 226992, XrefRangeEnd = 226993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__84()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__84_Internal_Void_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EECB RID: 61131 RVA: 0x0038D0B8 File Offset: 0x0038B2B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227434, XrefRangeEnd = 227436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Method_Internal_Int32_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EECC RID: 61132 RVA: 0x0038D0F4 File Offset: 0x0038B2F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227436, XrefRangeEnd = 227442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Func_1_Boolean_PDM_0(Func<bool> extraTiming)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extraTiming);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EECD RID: 61133 RVA: 0x0038D144 File Offset: 0x0038B344
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__85()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeMethodInfoPtr__MainChallengeLoop_b__85_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EECE RID: 61134 RVA: 0x0007FEB5 File Offset: 0x0007E0B5
			public __c__DisplayClass66_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D9C RID: 19868
			// (get) Token: 0x0600EECF RID: 61135 RVA: 0x0038D180 File Offset: 0x0038B380
			// (set) Token: 0x0600EED0 RID: 61136 RVA: 0x0007FEBE File Offset: 0x0007E0BE
			public unsafe IEnumerable<KeyValuePair<int, int>> foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D9D RID: 19869
			// (get) Token: 0x0600EED1 RID: 61137 RVA: 0x0038D1B0 File Offset: 0x0038B3B0
			// (set) Token: 0x0600EED2 RID: 61138 RVA: 0x0007FEDD File Offset: 0x0007E0DD
			public unsafe IEnumerable<KeyValuePair<int, int>> bevs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_bevs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D9E RID: 19870
			// (get) Token: 0x0600EED3 RID: 61139 RVA: 0x0038D1E0 File Offset: 0x0038B3E0
			// (set) Token: 0x0600EED4 RID: 61140 RVA: 0x0007FEFC File Offset: 0x0007E0FC
			public unsafe IEnumerable<KeyValuePair<int, int>> ings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_ings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_ings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D9F RID: 19871
			// (get) Token: 0x0600EED5 RID: 61141 RVA: 0x0038D210 File Offset: 0x0038B410
			// (set) Token: 0x0600EED6 RID: 61142 RVA: 0x0007FF1B File Offset: 0x0007E11B
			public unsafe StringBuilder guiText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_guiText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_guiText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DA0 RID: 19872
			// (get) Token: 0x0600EED7 RID: 61143 RVA: 0x0038D240 File Offset: 0x0038B440
			// (set) Token: 0x0600EED8 RID: 61144 RVA: 0x0007FF3A File Offset: 0x0007E13A
			public unsafe int pupuyoFruitNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_pupuyoFruitNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_pupuyoFruitNum)) = value;
				}
			}

			// Token: 0x17004DA1 RID: 19873
			// (get) Token: 0x0600EED9 RID: 61145 RVA: 0x0038D268 File Offset: 0x0038B468
			// (set) Token: 0x0600EEDA RID: 61146 RVA: 0x0007FF55 File Offset: 0x0007E155
			public unsafe int catchMizuchiNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_catchMizuchiNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_catchMizuchiNum)) = value;
				}
			}

			// Token: 0x17004DA2 RID: 19874
			// (get) Token: 0x0600EEDB RID: 61147 RVA: 0x0038D290 File Offset: 0x0038B490
			// (set) Token: 0x0600EEDC RID: 61148 RVA: 0x0007FF70 File Offset: 0x0007E170
			public unsafe int currentGuestWhoIsControlledByMizuchi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_currentGuestWhoIsControlledByMizuchi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_currentGuestWhoIsControlledByMizuchi)) = value;
				}
			}

			// Token: 0x17004DA3 RID: 19875
			// (get) Token: 0x0600EEDD RID: 61149 RVA: 0x0038D2B8 File Offset: 0x0038B4B8
			// (set) Token: 0x0600EEDE RID: 61150 RVA: 0x0007FF8B File Offset: 0x0007E18B
			public unsafe DLC5_MizuchiChallengeBossData.MizuchiControlType typeOfMizuchi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_typeOfMizuchi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_typeOfMizuchi)) = value;
				}
			}

			// Token: 0x17004DA4 RID: 19876
			// (get) Token: 0x0600EEDF RID: 61151 RVA: 0x0038D2E0 File Offset: 0x0038B4E0
			// (set) Token: 0x0600EEE0 RID: 61152 RVA: 0x0007FFA6 File Offset: 0x0007E1A6
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x17004DA5 RID: 19877
			// (get) Token: 0x0600EEE1 RID: 61153 RVA: 0x0038D308 File Offset: 0x0038B508
			// (set) Token: 0x0600EEE2 RID: 61154 RVA: 0x0007FFC1 File Offset: 0x0007E1C1
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DA6 RID: 19878
			// (get) Token: 0x0600EEE3 RID: 61155 RVA: 0x0038D338 File Offset: 0x0038B538
			// (set) Token: 0x0600EEE4 RID: 61156 RVA: 0x0007FFE0 File Offset: 0x0007E1E0
			public unsafe DLC5_MizuchiChallengeBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DA7 RID: 19879
			// (get) Token: 0x0600EEE5 RID: 61157 RVA: 0x0038D368 File Offset: 0x0038B568
			// (set) Token: 0x0600EEE6 RID: 61158 RVA: 0x0007FFFF File Offset: 0x0007E1FF
			public unsafe bool isTimeEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isTimeEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isTimeEnd)) = value;
				}
			}

			// Token: 0x17004DA8 RID: 19880
			// (get) Token: 0x0600EEE7 RID: 61159 RVA: 0x0038D390 File Offset: 0x0038B590
			// (set) Token: 0x0600EEE8 RID: 61160 RVA: 0x0008001A File Offset: 0x0007E21A
			public unsafe UIManager uiManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_uiManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_uiManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DA9 RID: 19881
			// (get) Token: 0x0600EEE9 RID: 61161 RVA: 0x0038D3C0 File Offset: 0x0038B5C0
			// (set) Token: 0x0600EEEA RID: 61162 RVA: 0x00080039 File Offset: 0x0007E239
			public unsafe float extraRecoverSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_extraRecoverSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_extraRecoverSpeed)) = value;
				}
			}

			// Token: 0x17004DAA RID: 19882
			// (get) Token: 0x0600EEEB RID: 61163 RVA: 0x0038D3E8 File Offset: 0x0038B5E8
			// (set) Token: 0x0600EEEC RID: 61164 RVA: 0x00080054 File Offset: 0x0007E254
			public unsafe int targetIngredientId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_targetIngredientId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_targetIngredientId)) = value;
				}
			}

			// Token: 0x17004DAB RID: 19883
			// (get) Token: 0x0600EEED RID: 61165 RVA: 0x0038D410 File Offset: 0x0038B610
			// (set) Token: 0x0600EEEE RID: 61166 RVA: 0x0008006F File Offset: 0x0007E26F
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004DAC RID: 19884
			// (get) Token: 0x0600EEEF RID: 61167 RVA: 0x0038D440 File Offset: 0x0038B640
			// (set) Token: 0x0600EEF0 RID: 61168 RVA: 0x0008009D File Offset: 0x0007E29D
			public unsafe IzakayaConfigure izakayaConfigure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_izakayaConfigure);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigure>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_izakayaConfigure), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DAD RID: 19885
			// (get) Token: 0x0600EEF1 RID: 61169 RVA: 0x0038D470 File Offset: 0x0038B670
			// (set) Token: 0x0600EEF2 RID: 61170 RVA: 0x000800BC File Offset: 0x0007E2BC
			public unsafe bool isUsingMoonEye
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isUsingMoonEye);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isUsingMoonEye)) = value;
				}
			}

			// Token: 0x17004DAE RID: 19886
			// (get) Token: 0x0600EEF3 RID: 61171 RVA: 0x0038D498 File Offset: 0x0038B698
			// (set) Token: 0x0600EEF4 RID: 61172 RVA: 0x000800D7 File Offset: 0x0007E2D7
			public unsafe float remainingTimeForMoonEye
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_remainingTimeForMoonEye);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_remainingTimeForMoonEye)) = value;
				}
			}

			// Token: 0x17004DAF RID: 19887
			// (get) Token: 0x0600EEF5 RID: 61173 RVA: 0x0038D4C0 File Offset: 0x0038B6C0
			// (set) Token: 0x0600EEF6 RID: 61174 RVA: 0x000800F2 File Offset: 0x0007E2F2
			public unsafe int maxTimeForMoonEye
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_maxTimeForMoonEye);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_maxTimeForMoonEye)) = value;
				}
			}

			// Token: 0x17004DB0 RID: 19888
			// (get) Token: 0x0600EEF7 RID: 61175 RVA: 0x0038D4E8 File Offset: 0x0038B6E8
			// (set) Token: 0x0600EEF8 RID: 61176 RVA: 0x0008010D File Offset: 0x0007E30D
			public unsafe IncomeControllerMizuchi statusDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_statusDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerMizuchi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_statusDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DB1 RID: 19889
			// (get) Token: 0x0600EEF9 RID: 61177 RVA: 0x0038D518 File Offset: 0x0038B718
			// (set) Token: 0x0600EEFA RID: 61178 RVA: 0x0008012C File Offset: 0x0007E32C
			public unsafe HashSet<GuestGroupController> specialGuestControllerInScene
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_specialGuestControllerInScene);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_specialGuestControllerInScene), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DB2 RID: 19890
			// (get) Token: 0x0600EEFB RID: 61179 RVA: 0x0038D548 File Offset: 0x0038B748
			// (set) Token: 0x0600EEFC RID: 61180 RVA: 0x0008014B File Offset: 0x0007E34B
			public unsafe bool isMizuchiChallenge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isMizuchiChallenge);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isMizuchiChallenge)) = value;
				}
			}

			// Token: 0x17004DB3 RID: 19891
			// (get) Token: 0x0600EEFD RID: 61181 RVA: 0x0038D570 File Offset: 0x0038B770
			// (set) Token: 0x0600EEFE RID: 61182 RVA: 0x00080166 File Offset: 0x0007E366
			public unsafe Il2CppStringArray mizuchiFoundDialogs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_mizuchiFoundDialogs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_mizuchiFoundDialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DB4 RID: 19892
			// (get) Token: 0x0600EEFF RID: 61183 RVA: 0x0038D5A0 File Offset: 0x0038B7A0
			// (set) Token: 0x0600EF00 RID: 61184 RVA: 0x00080185 File Offset: 0x0007E385
			public unsafe Dictionary<int, ValueTuple<string, string, string>> characterDialogs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_characterDialogs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<string, string, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_characterDialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DB5 RID: 19893
			// (get) Token: 0x0600EF01 RID: 61185 RVA: 0x0038D5D0 File Offset: 0x0038B7D0
			// (set) Token: 0x0600EF02 RID: 61186 RVA: 0x000801A4 File Offset: 0x0007E3A4
			public unsafe Il2CppStringArray mizuchiNotFoundDialogs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_mizuchiNotFoundDialogs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_mizuchiNotFoundDialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DB6 RID: 19894
			// (get) Token: 0x0600EF03 RID: 61187 RVA: 0x0038D600 File Offset: 0x0038B800
			// (set) Token: 0x0600EF04 RID: 61188 RVA: 0x000801C3 File Offset: 0x0007E3C3
			public unsafe Il2CppStructArray<int> allSpecialGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_allSpecialGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_allSpecialGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DB7 RID: 19895
			// (get) Token: 0x0600EF05 RID: 61189 RVA: 0x0038D630 File Offset: 0x0038B830
			// (set) Token: 0x0600EF06 RID: 61190 RVA: 0x000801E2 File Offset: 0x0007E3E2
			public unsafe HashSet<int> specialGuestInScene
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_specialGuestInScene);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_specialGuestInScene), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DB8 RID: 19896
			// (get) Token: 0x0600EF07 RID: 61191 RVA: 0x0038D660 File Offset: 0x0038B860
			// (set) Token: 0x0600EF08 RID: 61192 RVA: 0x00080201 File Offset: 0x0007E401
			public unsafe GuestsManager guestsManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_guestsManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_guestsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DB9 RID: 19897
			// (get) Token: 0x0600EF09 RID: 61193 RVA: 0x0038D690 File Offset: 0x0038B890
			// (set) Token: 0x0600EF0A RID: 61194 RVA: 0x00080220 File Offset: 0x0007E420
			public unsafe int remainingProtectTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_remainingProtectTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_remainingProtectTime)) = value;
				}
			}

			// Token: 0x17004DBA RID: 19898
			// (get) Token: 0x0600EF0B RID: 61195 RVA: 0x0038D6B8 File Offset: 0x0038B8B8
			// (set) Token: 0x0600EF0C RID: 61196 RVA: 0x0008023B File Offset: 0x0007E43B
			public unsafe int challengeHp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_challengeHp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_challengeHp)) = value;
				}
			}

			// Token: 0x17004DBB RID: 19899
			// (get) Token: 0x0600EF0D RID: 61197 RVA: 0x0038D6E0 File Offset: 0x0038B8E0
			// (set) Token: 0x0600EF0E RID: 61198 RVA: 0x00080256 File Offset: 0x0007E456
			public unsafe int trySpawnMizuchiTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_trySpawnMizuchiTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_trySpawnMizuchiTime)) = value;
				}
			}

			// Token: 0x17004DBC RID: 19900
			// (get) Token: 0x0600EF0F RID: 61199 RVA: 0x0038D708 File Offset: 0x0038B908
			// (set) Token: 0x0600EF10 RID: 61200 RVA: 0x00080271 File Offset: 0x0007E471
			public unsafe HashSet<DLC5_MizuchiChallengeBossData.MizuchiControlType> mizuchiControlTypeHashset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_mizuchiControlTypeHashset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<DLC5_MizuchiChallengeBossData.MizuchiControlType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_mizuchiControlTypeHashset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DBD RID: 19901
			// (get) Token: 0x0600EF11 RID: 61201 RVA: 0x0038D738 File Offset: 0x0038B938
			// (set) Token: 0x0600EF12 RID: 61202 RVA: 0x00080290 File Offset: 0x0007E490
			public unsafe Dictionary<int, DLC5_MizuchiChallengeBossData.GuestRunType> actionType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_actionType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DLC5_MizuchiChallengeBossData.GuestRunType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_actionType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DBE RID: 19902
			// (get) Token: 0x0600EF13 RID: 61203 RVA: 0x0038D768 File Offset: 0x0038B968
			// (set) Token: 0x0600EF14 RID: 61204 RVA: 0x000802AF File Offset: 0x0007E4AF
			public unsafe int needCatchMizuchiTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_needCatchMizuchiTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_needCatchMizuchiTime)) = value;
				}
			}

			// Token: 0x17004DBF RID: 19903
			// (get) Token: 0x0600EF15 RID: 61205 RVA: 0x0038D790 File Offset: 0x0038B990
			// (set) Token: 0x0600EF16 RID: 61206 RVA: 0x000802CA File Offset: 0x0007E4CA
			public unsafe bool isAnimation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isAnimation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_isAnimation)) = value;
				}
			}

			// Token: 0x17004DC0 RID: 19904
			// (get) Token: 0x0600EF17 RID: 61207 RVA: 0x0038D7B8 File Offset: 0x0038B9B8
			// (set) Token: 0x0600EF18 RID: 61208 RVA: 0x000802E5 File Offset: 0x0007E4E5
			public unsafe Action onChallengeEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_onChallengeEnd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_onChallengeEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DC1 RID: 19905
			// (get) Token: 0x0600EF19 RID: 61209 RVA: 0x0038D7E8 File Offset: 0x0038B9E8
			// (set) Token: 0x0600EF1A RID: 61210 RVA: 0x00080304 File Offset: 0x0007E504
			public unsafe Stack<int> giveBadge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_giveBadge);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_giveBadge), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DC2 RID: 19906
			// (get) Token: 0x0600EF1B RID: 61211 RVA: 0x0038D818 File Offset: 0x0038BA18
			// (set) Token: 0x0600EF1C RID: 61212 RVA: 0x00080323 File Offset: 0x0007E523
			public unsafe WaitUntil canContinueYieldInstruction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_canContinueYieldInstruction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr_canContinueYieldInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DC3 RID: 19907
			// (get) Token: 0x0600EF1D RID: 61213 RVA: 0x0038D848 File Offset: 0x0038BA48
			// (set) Token: 0x0600EF1E RID: 61214 RVA: 0x00080342 File Offset: 0x0007E542
			public unsafe Func<int, bool> __9__66
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__66);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__66), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DC4 RID: 19908
			// (get) Token: 0x0600EF1F RID: 61215 RVA: 0x0038D878 File Offset: 0x0038BA78
			// (set) Token: 0x0600EF20 RID: 61216 RVA: 0x00080361 File Offset: 0x0007E561
			public unsafe Func<int, bool> __9__67
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__67);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__67), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DC5 RID: 19909
			// (get) Token: 0x0600EF21 RID: 61217 RVA: 0x0038D8A8 File Offset: 0x0038BAA8
			// (set) Token: 0x0600EF22 RID: 61218 RVA: 0x00080380 File Offset: 0x0007E580
			public unsafe Func<int, bool> __9__68
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__68);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__68), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DC6 RID: 19910
			// (get) Token: 0x0600EF23 RID: 61219 RVA: 0x0038D8D8 File Offset: 0x0038BAD8
			// (set) Token: 0x0600EF24 RID: 61220 RVA: 0x0008039F File Offset: 0x0007E59F
			public unsafe Func<int, bool> __9__69
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__69);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__69), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DC7 RID: 19911
			// (get) Token: 0x0600EF25 RID: 61221 RVA: 0x0038D908 File Offset: 0x0038BB08
			// (set) Token: 0x0600EF26 RID: 61222 RVA: 0x000803BE File Offset: 0x0007E5BE
			public unsafe Func<int, bool> __9__70
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__70);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.NativeFieldInfoPtr___9__70), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400982A RID: 38954
			private static readonly IntPtr NativeFieldInfoPtr_foods;

			// Token: 0x0400982B RID: 38955
			private static readonly IntPtr NativeFieldInfoPtr_bevs;

			// Token: 0x0400982C RID: 38956
			private static readonly IntPtr NativeFieldInfoPtr_ings;

			// Token: 0x0400982D RID: 38957
			private static readonly IntPtr NativeFieldInfoPtr_guiText;

			// Token: 0x0400982E RID: 38958
			private static readonly IntPtr NativeFieldInfoPtr_pupuyoFruitNum;

			// Token: 0x0400982F RID: 38959
			private static readonly IntPtr NativeFieldInfoPtr_catchMizuchiNum;

			// Token: 0x04009830 RID: 38960
			private static readonly IntPtr NativeFieldInfoPtr_currentGuestWhoIsControlledByMizuchi;

			// Token: 0x04009831 RID: 38961
			private static readonly IntPtr NativeFieldInfoPtr_typeOfMizuchi;

			// Token: 0x04009832 RID: 38962
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x04009833 RID: 38963
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009834 RID: 38964
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009835 RID: 38965
			private static readonly IntPtr NativeFieldInfoPtr_isTimeEnd;

			// Token: 0x04009836 RID: 38966
			private static readonly IntPtr NativeFieldInfoPtr_uiManager;

			// Token: 0x04009837 RID: 38967
			private static readonly IntPtr NativeFieldInfoPtr_extraRecoverSpeed;

			// Token: 0x04009838 RID: 38968
			private static readonly IntPtr NativeFieldInfoPtr_targetIngredientId;

			// Token: 0x04009839 RID: 38969
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x0400983A RID: 38970
			private static readonly IntPtr NativeFieldInfoPtr_izakayaConfigure;

			// Token: 0x0400983B RID: 38971
			private static readonly IntPtr NativeFieldInfoPtr_isUsingMoonEye;

			// Token: 0x0400983C RID: 38972
			private static readonly IntPtr NativeFieldInfoPtr_remainingTimeForMoonEye;

			// Token: 0x0400983D RID: 38973
			private static readonly IntPtr NativeFieldInfoPtr_maxTimeForMoonEye;

			// Token: 0x0400983E RID: 38974
			private static readonly IntPtr NativeFieldInfoPtr_statusDisplayer;

			// Token: 0x0400983F RID: 38975
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestControllerInScene;

			// Token: 0x04009840 RID: 38976
			private static readonly IntPtr NativeFieldInfoPtr_isMizuchiChallenge;

			// Token: 0x04009841 RID: 38977
			private static readonly IntPtr NativeFieldInfoPtr_mizuchiFoundDialogs;

			// Token: 0x04009842 RID: 38978
			private static readonly IntPtr NativeFieldInfoPtr_characterDialogs;

			// Token: 0x04009843 RID: 38979
			private static readonly IntPtr NativeFieldInfoPtr_mizuchiNotFoundDialogs;

			// Token: 0x04009844 RID: 38980
			private static readonly IntPtr NativeFieldInfoPtr_allSpecialGuest;

			// Token: 0x04009845 RID: 38981
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestInScene;

			// Token: 0x04009846 RID: 38982
			private static readonly IntPtr NativeFieldInfoPtr_guestsManager;

			// Token: 0x04009847 RID: 38983
			private static readonly IntPtr NativeFieldInfoPtr_remainingProtectTime;

			// Token: 0x04009848 RID: 38984
			private static readonly IntPtr NativeFieldInfoPtr_challengeHp;

			// Token: 0x04009849 RID: 38985
			private static readonly IntPtr NativeFieldInfoPtr_trySpawnMizuchiTime;

			// Token: 0x0400984A RID: 38986
			private static readonly IntPtr NativeFieldInfoPtr_mizuchiControlTypeHashset;

			// Token: 0x0400984B RID: 38987
			private static readonly IntPtr NativeFieldInfoPtr_actionType;

			// Token: 0x0400984C RID: 38988
			private static readonly IntPtr NativeFieldInfoPtr_needCatchMizuchiTime;

			// Token: 0x0400984D RID: 38989
			private static readonly IntPtr NativeFieldInfoPtr_isAnimation;

			// Token: 0x0400984E RID: 38990
			private static readonly IntPtr NativeFieldInfoPtr_onChallengeEnd;

			// Token: 0x0400984F RID: 38991
			private static readonly IntPtr NativeFieldInfoPtr_giveBadge;

			// Token: 0x04009850 RID: 38992
			private static readonly IntPtr NativeFieldInfoPtr_canContinueYieldInstruction;

			// Token: 0x04009851 RID: 38993
			private static readonly IntPtr NativeFieldInfoPtr___9__66;

			// Token: 0x04009852 RID: 38994
			private static readonly IntPtr NativeFieldInfoPtr___9__67;

			// Token: 0x04009853 RID: 38995
			private static readonly IntPtr NativeFieldInfoPtr___9__68;

			// Token: 0x04009854 RID: 38996
			private static readonly IntPtr NativeFieldInfoPtr___9__69;

			// Token: 0x04009855 RID: 38997
			private static readonly IntPtr NativeFieldInfoPtr___9__70;

			// Token: 0x04009856 RID: 38998
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009857 RID: 38999
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__0_Internal_Void_2;

			// Token: 0x04009858 RID: 39000
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_PDM_0;

			// Token: 0x04009859 RID: 39001
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Boolean_0;

			// Token: 0x0400985A RID: 39002
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_2;

			// Token: 0x0400985B RID: 39003
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400985C RID: 39004
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__37_Internal_String_String_0;

			// Token: 0x0400985D RID: 39005
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400985E RID: 39006
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__43_Internal_String_String_0;

			// Token: 0x0400985F RID: 39007
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Void_UIElementCluster_ValueTuple_2_Int32_Int32_0;

			// Token: 0x04009860 RID: 39008
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04009861 RID: 39009
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x04009862 RID: 39010
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

			// Token: 0x04009863 RID: 39011
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_2;

			// Token: 0x04009864 RID: 39012
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Void_Single_0;

			// Token: 0x04009865 RID: 39013
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_Int32_PDM_0;

			// Token: 0x04009866 RID: 39014
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_Int32_0;

			// Token: 0x04009867 RID: 39015
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_Int32_PDM_1;

			// Token: 0x04009868 RID: 39016
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_1;

			// Token: 0x04009869 RID: 39017
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__60_Internal_Boolean_Sellable_0;

			// Token: 0x0400986A RID: 39018
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__61_Internal_Int32_Sellable_0;

			// Token: 0x0400986B RID: 39019
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_Internal_Boolean_Int32_0;

			// Token: 0x0400986C RID: 39020
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__62_Internal_Boolean_Sellable_0;

			// Token: 0x0400986D RID: 39021
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__63_Internal_Int32_Sellable_0;

			// Token: 0x0400986E RID: 39022
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__67_Internal_Boolean_Int32_0;

			// Token: 0x0400986F RID: 39023
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__64_Internal_Boolean_CookController_0;

			// Token: 0x04009870 RID: 39024
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__65_Internal_Int32_CookController_0;

			// Token: 0x04009871 RID: 39025
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__68_Internal_Boolean_Int32_0;

			// Token: 0x04009872 RID: 39026
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__69_Internal_Boolean_Int32_0;

			// Token: 0x04009873 RID: 39027
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__70_Internal_Boolean_Int32_0;

			// Token: 0x04009874 RID: 39028
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_Sellable_0;

			// Token: 0x04009875 RID: 39029
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2;

			// Token: 0x04009876 RID: 39030
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_Int32_PDM_0;

			// Token: 0x04009877 RID: 39031
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_3;

			// Token: 0x04009878 RID: 39032
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass66_11_PDM_0;

			// Token: 0x04009879 RID: 39033
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__23_Internal_Boolean_0;

			// Token: 0x0400987A RID: 39034
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__24_Internal_Boolean_0;

			// Token: 0x0400987B RID: 39035
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__25_Internal_Void_GuestGroupController_0;

			// Token: 0x0400987C RID: 39036
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_Internal_Void_GuestGroupController_0;

			// Token: 0x0400987D RID: 39037
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__83_Internal_Void_DLC5_ChallengeResult_0;

			// Token: 0x0400987E RID: 39038
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_4;

			// Token: 0x0400987F RID: 39039
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_3;

			// Token: 0x04009880 RID: 39040
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__84_Internal_Void_2;

			// Token: 0x04009881 RID: 39041
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Int32_PDM_0;

			// Token: 0x04009882 RID: 39042
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_PDM_0;

			// Token: 0x04009883 RID: 39043
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__85_Internal_Int32_0;

			// Token: 0x02001082 RID: 4226
			[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_0+<<MainChallengeLoop>g__QTECheck|31>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011FF9 RID: 73721 RVA: 0x0041CA8C File Offset: 0x0041AC8C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique()
				{
					Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<<MainChallengeLoop>g__QTECheck|31>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, "<>1__state");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, "<>2__current");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, "<>4__this");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, "<>8__1");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, "<>8__2");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__wait1_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, "<wait1>5__2");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__wait2_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, "<wait2>5__3");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__wait3_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, "<wait3>5__4");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__mizuchi_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, "<mizuchi>5__5");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__mizuchiSpellLang_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, "<mizuchiSpellLang>5__6");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, 100682042);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, 100682043);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, 100682044);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, 100682045);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, 100682046);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr, 100682047);
				}

				// Token: 0x06011FFA RID: 73722 RVA: 0x0041CBF8 File Offset: 0x0041ADF8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FFB RID: 73723 RVA: 0x0041CC40 File Offset: 0x0041AE40
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FFC RID: 73724 RVA: 0x0041CC74 File Offset: 0x0041AE74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226671, XrefRangeEnd = 226719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DEE RID: 24046
				// (get) Token: 0x06011FFD RID: 73725 RVA: 0x0041CCB0 File Offset: 0x0041AEB0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FFE RID: 73726 RVA: 0x0041CCF0 File Offset: 0x0041AEF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226719, XrefRangeEnd = 226725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DEF RID: 24047
				// (get) Token: 0x06011FFF RID: 73727 RVA: 0x0041CD24 File Offset: 0x0041AF24
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012000 RID: 73728 RVA: 0x0009C5B1 File Offset: 0x0009A7B1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DE4 RID: 24036
				// (get) Token: 0x06012001 RID: 73729 RVA: 0x0041CD64 File Offset: 0x0041AF64
				// (set) Token: 0x06012002 RID: 73730 RVA: 0x0009C5BA File Offset: 0x0009A7BA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DE5 RID: 24037
				// (get) Token: 0x06012003 RID: 73731 RVA: 0x0041CD8C File Offset: 0x0041AF8C
				// (set) Token: 0x06012004 RID: 73732 RVA: 0x0009C5D5 File Offset: 0x0009A7D5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DE6 RID: 24038
				// (get) Token: 0x06012005 RID: 73733 RVA: 0x0041CDBC File Offset: 0x0041AFBC
				// (set) Token: 0x06012006 RID: 73734 RVA: 0x0009C5F4 File Offset: 0x0009A7F4
				public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DE7 RID: 24039
				// (get) Token: 0x06012007 RID: 73735 RVA: 0x0041CDEC File Offset: 0x0041AFEC
				// (set) Token: 0x06012008 RID: 73736 RVA: 0x0009C613 File Offset: 0x0009A813
				public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DE8 RID: 24040
				// (get) Token: 0x06012009 RID: 73737 RVA: 0x0041CE1C File Offset: 0x0041B01C
				// (set) Token: 0x0601200A RID: 73738 RVA: 0x0009C632 File Offset: 0x0009A832
				public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3 __8__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___8__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DE9 RID: 24041
				// (get) Token: 0x0601200B RID: 73739 RVA: 0x0041CE4C File Offset: 0x0041B04C
				// (set) Token: 0x0601200C RID: 73740 RVA: 0x0009C651 File Offset: 0x0009A851
				public unsafe WaitForSeconds _wait1_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__wait1_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__wait1_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DEA RID: 24042
				// (get) Token: 0x0601200D RID: 73741 RVA: 0x0041CE7C File Offset: 0x0041B07C
				// (set) Token: 0x0601200E RID: 73742 RVA: 0x0009C670 File Offset: 0x0009A870
				public unsafe WaitForSeconds _wait2_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__wait2_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__wait2_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DEB RID: 24043
				// (get) Token: 0x0601200F RID: 73743 RVA: 0x0041CEAC File Offset: 0x0041B0AC
				// (set) Token: 0x06012010 RID: 73744 RVA: 0x0009C68F File Offset: 0x0009A88F
				public unsafe WaitUntil _wait3_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__wait3_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__wait3_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DEC RID: 24044
				// (get) Token: 0x06012011 RID: 73745 RVA: 0x0041CEDC File Offset: 0x0041B0DC
				// (set) Token: 0x06012012 RID: 73746 RVA: 0x0009C6AE File Offset: 0x0009A8AE
				public unsafe SpecialGuest _mizuchi_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__mizuchi_5__5);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__mizuchi_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DED RID: 24045
				// (get) Token: 0x06012013 RID: 73747 RVA: 0x0041CF0C File Offset: 0x0041B10C
				// (set) Token: 0x06012014 RID: 73748 RVA: 0x0009C6CD File Offset: 0x0009A8CD
				public unsafe LanguageBase _mizuchiSpellLang_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__mizuchiSpellLang_5__6);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaSpWaLaWaObObUnique.NativeFieldInfoPtr__mizuchiSpellLang_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B667 RID: 46695
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B668 RID: 46696
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B669 RID: 46697
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B66A RID: 46698
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B66B RID: 46699
				private static readonly IntPtr NativeFieldInfoPtr___8__2;

				// Token: 0x0400B66C RID: 46700
				private static readonly IntPtr NativeFieldInfoPtr__wait1_5__2;

				// Token: 0x0400B66D RID: 46701
				private static readonly IntPtr NativeFieldInfoPtr__wait2_5__3;

				// Token: 0x0400B66E RID: 46702
				private static readonly IntPtr NativeFieldInfoPtr__wait3_5__4;

				// Token: 0x0400B66F RID: 46703
				private static readonly IntPtr NativeFieldInfoPtr__mizuchi_5__5;

				// Token: 0x0400B670 RID: 46704
				private static readonly IntPtr NativeFieldInfoPtr__mizuchiSpellLang_5__6;

				// Token: 0x0400B671 RID: 46705
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B672 RID: 46706
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B673 RID: 46707
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B674 RID: 46708
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B675 RID: 46709
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B676 RID: 46710
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001083 RID: 4227
			[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_0+<<MainChallengeLoop>g__Charging|14>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0 : Il2CppSystem.Object
			{
				// Token: 0x06012015 RID: 73749 RVA: 0x0041CF3C File Offset: 0x0041B13C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0()
				{
					Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<<MainChallengeLoop>g__Charging|14>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>1__state");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>2__current");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>4__this");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100682048);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100682049);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100682050);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100682051);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100682052);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100682053);
				}

				// Token: 0x06012016 RID: 73750 RVA: 0x0041D01C File Offset: 0x0041B21C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012017 RID: 73751 RVA: 0x0041D064 File Offset: 0x0041B264
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012018 RID: 73752 RVA: 0x0041D098 File Offset: 0x0041B298
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226725, XrefRangeEnd = 226729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DF3 RID: 24051
				// (get) Token: 0x06012019 RID: 73753 RVA: 0x0041D0D4 File Offset: 0x0041B2D4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601201A RID: 73754 RVA: 0x0041D114 File Offset: 0x0041B314
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226729, XrefRangeEnd = 226735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DF4 RID: 24052
				// (get) Token: 0x0601201B RID: 73755 RVA: 0x0041D148 File Offset: 0x0041B348
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601201C RID: 73756 RVA: 0x0009C6EC File Offset: 0x0009A8EC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DF0 RID: 24048
				// (get) Token: 0x0601201D RID: 73757 RVA: 0x0041D188 File Offset: 0x0041B388
				// (set) Token: 0x0601201E RID: 73758 RVA: 0x0009C6F5 File Offset: 0x0009A8F5
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DF1 RID: 24049
				// (get) Token: 0x0601201F RID: 73759 RVA: 0x0041D1B0 File Offset: 0x0041B3B0
				// (set) Token: 0x06012020 RID: 73760 RVA: 0x0009C710 File Offset: 0x0009A910
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DF2 RID: 24050
				// (get) Token: 0x06012021 RID: 73761 RVA: 0x0041D1E0 File Offset: 0x0041B3E0
				// (set) Token: 0x06012022 RID: 73762 RVA: 0x0009C72F File Offset: 0x0009A92F
				public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B677 RID: 46711
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B678 RID: 46712
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B679 RID: 46713
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B67A RID: 46714
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B67B RID: 46715
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B67C RID: 46716
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B67D RID: 46717
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B67E RID: 46718
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B67F RID: 46719
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001084 RID: 4228
			[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_0+<<MainChallengeLoop>g__GuestSpawnLoop|22>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012023 RID: 73763 RVA: 0x0041D210 File Offset: 0x0041B410
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique()
				{
					Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<<MainChallengeLoop>g__GuestSpawnLoop|22>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<>1__state");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<>2__current");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<>4__this");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr__spawnInterval_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<spawnInterval>5__2");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100682054);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100682055);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100682056);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100682057);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100682058);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100682059);
				}

				// Token: 0x06012024 RID: 73764 RVA: 0x0041D304 File Offset: 0x0041B504
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012025 RID: 73765 RVA: 0x0041D34C File Offset: 0x0041B54C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012026 RID: 73766 RVA: 0x0041D380 File Offset: 0x0041B580
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226735, XrefRangeEnd = 226894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DF9 RID: 24057
				// (get) Token: 0x06012027 RID: 73767 RVA: 0x0041D3BC File Offset: 0x0041B5BC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012028 RID: 73768 RVA: 0x0041D3FC File Offset: 0x0041B5FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226894, XrefRangeEnd = 226900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DFA RID: 24058
				// (get) Token: 0x06012029 RID: 73769 RVA: 0x0041D430 File Offset: 0x0041B630
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601202A RID: 73770 RVA: 0x0009C74E File Offset: 0x0009A94E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DF5 RID: 24053
				// (get) Token: 0x0601202B RID: 73771 RVA: 0x0041D470 File Offset: 0x0041B670
				// (set) Token: 0x0601202C RID: 73772 RVA: 0x0009C757 File Offset: 0x0009A957
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DF6 RID: 24054
				// (get) Token: 0x0601202D RID: 73773 RVA: 0x0041D498 File Offset: 0x0041B698
				// (set) Token: 0x0601202E RID: 73774 RVA: 0x0009C772 File Offset: 0x0009A972
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DF7 RID: 24055
				// (get) Token: 0x0601202F RID: 73775 RVA: 0x0041D4C8 File Offset: 0x0041B6C8
				// (set) Token: 0x06012030 RID: 73776 RVA: 0x0009C791 File Offset: 0x0009A991
				public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DF8 RID: 24056
				// (get) Token: 0x06012031 RID: 73777 RVA: 0x0041D4F8 File Offset: 0x0041B6F8
				// (set) Token: 0x06012032 RID: 73778 RVA: 0x0009C7B0 File Offset: 0x0009A9B0
				public unsafe Vector2Int _spawnInterval_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr__spawnInterval_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr__spawnInterval_5__2)) = value;
					}
				}

				// Token: 0x0400B680 RID: 46720
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B681 RID: 46721
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B682 RID: 46722
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B683 RID: 46723
				private static readonly IntPtr NativeFieldInfoPtr__spawnInterval_5__2;

				// Token: 0x0400B684 RID: 46724
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B685 RID: 46725
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B686 RID: 46726
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B687 RID: 46727
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B688 RID: 46728
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B689 RID: 46729
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001085 RID: 4229
			[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_0+<<MainChallengeLoop>g__OnFail|28>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1 : Il2CppSystem.Object
			{
				// Token: 0x06012033 RID: 73779 RVA: 0x0041D520 File Offset: 0x0041B720
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1()
				{
					Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<<MainChallengeLoop>g__OnFail|28>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>1__state");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>2__current");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>4__this");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100682060);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100682061);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100682062);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100682063);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100682064);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100682065);
				}

				// Token: 0x06012034 RID: 73780 RVA: 0x0041D600 File Offset: 0x0041B800
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012035 RID: 73781 RVA: 0x0041D648 File Offset: 0x0041B848
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012036 RID: 73782 RVA: 0x0041D67C File Offset: 0x0041B87C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226900, XrefRangeEnd = 226914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DFE RID: 24062
				// (get) Token: 0x06012037 RID: 73783 RVA: 0x0041D6B8 File Offset: 0x0041B8B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012038 RID: 73784 RVA: 0x0041D6F8 File Offset: 0x0041B8F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226914, XrefRangeEnd = 226920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DFF RID: 24063
				// (get) Token: 0x06012039 RID: 73785 RVA: 0x0041D72C File Offset: 0x0041B92C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601203A RID: 73786 RVA: 0x0009C7CB File Offset: 0x0009A9CB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DFB RID: 24059
				// (get) Token: 0x0601203B RID: 73787 RVA: 0x0041D76C File Offset: 0x0041B96C
				// (set) Token: 0x0601203C RID: 73788 RVA: 0x0009C7D4 File Offset: 0x0009A9D4
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DFC RID: 24060
				// (get) Token: 0x0601203D RID: 73789 RVA: 0x0041D794 File Offset: 0x0041B994
				// (set) Token: 0x0601203E RID: 73790 RVA: 0x0009C7EF File Offset: 0x0009A9EF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DFD RID: 24061
				// (get) Token: 0x0601203F RID: 73791 RVA: 0x0041D7C4 File Offset: 0x0041B9C4
				// (set) Token: 0x06012040 RID: 73792 RVA: 0x0009C80E File Offset: 0x0009AA0E
				public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B68A RID: 46730
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B68B RID: 46731
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B68C RID: 46732
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B68D RID: 46733
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B68E RID: 46734
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B68F RID: 46735
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B690 RID: 46736
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B691 RID: 46737
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B692 RID: 46738
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001086 RID: 4230
			[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_0+<<MainChallengeLoop>g__Timing|30>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012041 RID: 73793 RVA: 0x0041D7F4 File Offset: 0x0041B9F4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique()
				{
					Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>.NativeClassPtr, "<<MainChallengeLoop>g__Timing|30>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr, "<>1__state");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr, "<>2__current");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr, "<>4__this");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr_extraTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr, "extraTiming");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr, 100682066);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr, 100682067);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr, 100682068);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr, 100682069);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr, 100682070);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr, 100682071);
				}

				// Token: 0x06012042 RID: 73794 RVA: 0x0041D8E8 File Offset: 0x0041BAE8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012043 RID: 73795 RVA: 0x0041D930 File Offset: 0x0041BB30
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012044 RID: 73796 RVA: 0x0041D964 File Offset: 0x0041BB64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226920, XrefRangeEnd = 226941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E04 RID: 24068
				// (get) Token: 0x06012045 RID: 73797 RVA: 0x0041D9A0 File Offset: 0x0041BBA0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012046 RID: 73798 RVA: 0x0041D9E0 File Offset: 0x0041BBE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226941, XrefRangeEnd = 226947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E05 RID: 24069
				// (get) Token: 0x06012047 RID: 73799 RVA: 0x0041DA14 File Offset: 0x0041BC14
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012048 RID: 73800 RVA: 0x0009C82D File Offset: 0x0009AA2D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E00 RID: 24064
				// (get) Token: 0x06012049 RID: 73801 RVA: 0x0041DA54 File Offset: 0x0041BC54
				// (set) Token: 0x0601204A RID: 73802 RVA: 0x0009C836 File Offset: 0x0009AA36
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E01 RID: 24065
				// (get) Token: 0x0601204B RID: 73803 RVA: 0x0041DA7C File Offset: 0x0041BC7C
				// (set) Token: 0x0601204C RID: 73804 RVA: 0x0009C851 File Offset: 0x0009AA51
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E02 RID: 24066
				// (get) Token: 0x0601204D RID: 73805 RVA: 0x0041DAAC File Offset: 0x0041BCAC
				// (set) Token: 0x0601204E RID: 73806 RVA: 0x0009C870 File Offset: 0x0009AA70
				public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E03 RID: 24067
				// (get) Token: 0x0601204F RID: 73807 RVA: 0x0041DADC File Offset: 0x0041BCDC
				// (set) Token: 0x06012050 RID: 73808 RVA: 0x0009C88F File Offset: 0x0009AA8F
				public unsafe Func<bool> extraTiming
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr_extraTiming);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexObObUnique.NativeFieldInfoPtr_extraTiming), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B693 RID: 46739
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B694 RID: 46740
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B695 RID: 46741
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B696 RID: 46742
				private static readonly IntPtr NativeFieldInfoPtr_extraTiming;

				// Token: 0x0400B697 RID: 46743
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B698 RID: 46744
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B699 RID: 46745
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B69A RID: 46746
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B69B RID: 46747
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B69C RID: 46748
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000CFF RID: 3327
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_1")]
		public sealed class __c__DisplayClass66_1 : Il2CppSystem.Object
		{
			// Token: 0x0600EF27 RID: 61223 RVA: 0x0038D938 File Offset: 0x0038BB38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_1()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1.NativeFieldInfoPtr_qteCorotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1>.NativeClassPtr, "qteCorotine");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1>.NativeClassPtr, 100682072);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1.NativeMethodInfoPtr__MainChallengeLoop_b__33_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1>.NativeClassPtr, 100682073);
			}

			// Token: 0x0600EF28 RID: 61224 RVA: 0x0038D9B4 File Offset: 0x0038BBB4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF29 RID: 61225 RVA: 0x0038D9F0 File Offset: 0x0038BBF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227442, XrefRangeEnd = 227444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__33()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1.NativeMethodInfoPtr__MainChallengeLoop_b__33_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF2A RID: 61226 RVA: 0x000803DD File Offset: 0x0007E5DD
			public __c__DisplayClass66_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DC8 RID: 19912
			// (get) Token: 0x0600EF2B RID: 61227 RVA: 0x0038DA24 File Offset: 0x0038BC24
			// (set) Token: 0x0600EF2C RID: 61228 RVA: 0x000803E6 File Offset: 0x0007E5E6
			public unsafe Coroutine qteCorotine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1.NativeFieldInfoPtr_qteCorotine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1.NativeFieldInfoPtr_qteCorotine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DC9 RID: 19913
			// (get) Token: 0x0600EF2D RID: 61229 RVA: 0x0038DA54 File Offset: 0x0038BC54
			// (set) Token: 0x0600EF2E RID: 61230 RVA: 0x00080405 File Offset: 0x0007E605
			public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 field_Public___c__DisplayClass66_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_1.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009884 RID: 39044
			private static readonly IntPtr NativeFieldInfoPtr_qteCorotine;

			// Token: 0x04009885 RID: 39045
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0;

			// Token: 0x04009886 RID: 39046
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009887 RID: 39047
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__33_Internal_Void_0;
		}

		// Token: 0x02000D00 RID: 3328
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_2")]
		public sealed class __c__DisplayClass66_2 : Il2CppSystem.Object
		{
			// Token: 0x0600EF2F RID: 61231 RVA: 0x0038DA84 File Offset: 0x0038BC84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_2()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2.NativeFieldInfoPtr_hasQTEEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2>.NativeClassPtr, "hasQTEEnd");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2>.NativeClassPtr, "CS$<>8__locals2");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2>.NativeClassPtr, 100682074);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2.NativeMethodInfoPtr__MainChallengeLoop_b__34_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2>.NativeClassPtr, 100682075);
			}

			// Token: 0x0600EF30 RID: 61232 RVA: 0x0038DB00 File Offset: 0x0038BD00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF31 RID: 61233 RVA: 0x0038DB3C File Offset: 0x0038BD3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__34()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2.NativeMethodInfoPtr__MainChallengeLoop_b__34_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EF32 RID: 61234 RVA: 0x00080424 File Offset: 0x0007E624
			public __c__DisplayClass66_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DCA RID: 19914
			// (get) Token: 0x0600EF33 RID: 61235 RVA: 0x0038DB78 File Offset: 0x0038BD78
			// (set) Token: 0x0600EF34 RID: 61236 RVA: 0x0008042D File Offset: 0x0007E62D
			public unsafe bool hasQTEEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2.NativeFieldInfoPtr_hasQTEEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2.NativeFieldInfoPtr_hasQTEEnd)) = value;
				}
			}

			// Token: 0x17004DCB RID: 19915
			// (get) Token: 0x0600EF35 RID: 61237 RVA: 0x0038DBA0 File Offset: 0x0038BDA0
			// (set) Token: 0x0600EF36 RID: 61238 RVA: 0x00080448 File Offset: 0x0007E648
			public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 field_Public___c__DisplayClass66_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009888 RID: 39048
			private static readonly IntPtr NativeFieldInfoPtr_hasQTEEnd;

			// Token: 0x04009889 RID: 39049
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0;

			// Token: 0x0400988A RID: 39050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400988B RID: 39051
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__34_Internal_Boolean_0;
		}

		// Token: 0x02000D01 RID: 3329
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_3")]
		public sealed class __c__DisplayClass66_3 : Il2CppSystem.Object
		{
			// Token: 0x0600EF37 RID: 61239 RVA: 0x0038DBD0 File Offset: 0x0038BDD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_3()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3>.NativeClassPtr, "score");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3.NativeFieldInfoPtr_field_Public___c__DisplayClass66_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3>.NativeClassPtr, "CS$<>8__locals3");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3>.NativeClassPtr, 100682076);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3.NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3>.NativeClassPtr, 100682077);
			}

			// Token: 0x0600EF38 RID: 61240 RVA: 0x0038DC4C File Offset: 0x0038BE4C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF39 RID: 61241 RVA: 0x0038DC88 File Offset: 0x0038BE88
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__35(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3.NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF3A RID: 61242 RVA: 0x00080467 File Offset: 0x0007E667
			public __c__DisplayClass66_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DCC RID: 19916
			// (get) Token: 0x0600EF3B RID: 61243 RVA: 0x0038DCC8 File Offset: 0x0038BEC8
			// (set) Token: 0x0600EF3C RID: 61244 RVA: 0x00080470 File Offset: 0x0007E670
			public unsafe float score
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3.NativeFieldInfoPtr_score);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3.NativeFieldInfoPtr_score)) = value;
				}
			}

			// Token: 0x17004DCD RID: 19917
			// (get) Token: 0x0600EF3D RID: 61245 RVA: 0x0038DCF0 File Offset: 0x0038BEF0
			// (set) Token: 0x0600EF3E RID: 61246 RVA: 0x0008048B File Offset: 0x0007E68B
			public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2 field_Public___c__DisplayClass66_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3.NativeFieldInfoPtr_field_Public___c__DisplayClass66_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3.NativeFieldInfoPtr_field_Public___c__DisplayClass66_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400988C RID: 39052
			private static readonly IntPtr NativeFieldInfoPtr_score;

			// Token: 0x0400988D RID: 39053
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass66_2_0;

			// Token: 0x0400988E RID: 39054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400988F RID: 39055
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Void_Single_0;
		}

		// Token: 0x02000D02 RID: 3330
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_4")]
		public sealed class __c__DisplayClass66_4 : Il2CppSystem.Object
		{
			// Token: 0x0600EF3F RID: 61247 RVA: 0x0038DD20 File Offset: 0x0038BF20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_4()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4>.NativeClassPtr, "character");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4.NativeFieldInfoPtr_field_Public___c__DisplayClass66_3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4>.NativeClassPtr, "CS$<>8__locals4");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4>.NativeClassPtr, 100682078);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4.NativeMethodInfoPtr__MainChallengeLoop_b__36_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4>.NativeClassPtr, 100682079);
			}

			// Token: 0x0600EF40 RID: 61248 RVA: 0x0038DD9C File Offset: 0x0038BF9C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF41 RID: 61249 RVA: 0x0038DDD8 File Offset: 0x0038BFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227444, XrefRangeEnd = 227445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__36()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4.NativeMethodInfoPtr__MainChallengeLoop_b__36_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF42 RID: 61250 RVA: 0x000804AA File Offset: 0x0007E6AA
			public __c__DisplayClass66_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DCE RID: 19918
			// (get) Token: 0x0600EF43 RID: 61251 RVA: 0x0038DE0C File Offset: 0x0038C00C
			// (set) Token: 0x0600EF44 RID: 61252 RVA: 0x000804B3 File Offset: 0x0007E6B3
			public unsafe WorkScenePlayerInputGenerator character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DCF RID: 19919
			// (get) Token: 0x0600EF45 RID: 61253 RVA: 0x0038DE3C File Offset: 0x0038C03C
			// (set) Token: 0x0600EF46 RID: 61254 RVA: 0x000804D2 File Offset: 0x0007E6D2
			public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3 field_Public___c__DisplayClass66_3_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4.NativeFieldInfoPtr_field_Public___c__DisplayClass66_3_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_4.NativeFieldInfoPtr_field_Public___c__DisplayClass66_3_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009890 RID: 39056
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x04009891 RID: 39057
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass66_3_0;

			// Token: 0x04009892 RID: 39058
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009893 RID: 39059
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__36_Internal_Void_0;
		}

		// Token: 0x02000D03 RID: 3331
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_5")]
		public sealed class __c__DisplayClass66_5 : Il2CppSystem.Object
		{
			// Token: 0x0600EF47 RID: 61255 RVA: 0x0038DE6C File Offset: 0x0038C06C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_5()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_parentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, "parentRect");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_allUsedIngredientsRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, "allUsedIngredientsRecord");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_interruptTanBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, "interruptTanBuff");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_gridLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, "gridLayoutGroup");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_allInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, "allInstance");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, "CS$<>8__locals5");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, 100682080);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr__MainChallengeLoop_b__38_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, 100682081);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr_Method_Internal_Void_Sellable_Recipe_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, 100682082);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, 100682083);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, 100682084);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr_Method_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr, 100682085);
			}

			// Token: 0x0600EF48 RID: 61256 RVA: 0x0038DF88 File Offset: 0x0038C188
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF49 RID: 61257 RVA: 0x0038DFC4 File Offset: 0x0038C1C4
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__38(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr__MainChallengeLoop_b__38_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF4A RID: 61258 RVA: 0x0038E008 File Offset: 0x0038C208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227445, XrefRangeEnd = 227508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Sellable_Recipe_PDM_0(Sellable lastOutput, Recipe targetRecipe)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastOutput);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetRecipe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr_Method_Internal_Void_Sellable_Recipe_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF4B RID: 61259 RVA: 0x0038E05C File Offset: 0x0038C25C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227508, XrefRangeEnd = 227549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF4C RID: 61260 RVA: 0x0038E090 File Offset: 0x0038C290
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 227563, RefRangeEnd = 227565, XrefRangeStart = 227549, XrefRangeEnd = 227563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF4D RID: 61261 RVA: 0x0038E0C4 File Offset: 0x0038C2C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 227612, RefRangeEnd = 227613, XrefRangeStart = 227565, XrefRangeEnd = 227612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeMethodInfoPtr_Method_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF4E RID: 61262 RVA: 0x000804F1 File Offset: 0x0007E6F1
			public __c__DisplayClass66_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DD0 RID: 19920
			// (get) Token: 0x0600EF4F RID: 61263 RVA: 0x0038E0F8 File Offset: 0x0038C2F8
			// (set) Token: 0x0600EF50 RID: 61264 RVA: 0x000804FA File Offset: 0x0007E6FA
			public unsafe RectTransform parentRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_parentRect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_parentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DD1 RID: 19921
			// (get) Token: 0x0600EF51 RID: 61265 RVA: 0x0038E128 File Offset: 0x0038C328
			// (set) Token: 0x0600EF52 RID: 61266 RVA: 0x00080519 File Offset: 0x0007E719
			public unsafe Dictionary<int, int> allUsedIngredientsRecord
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_allUsedIngredientsRecord);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_allUsedIngredientsRecord), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DD2 RID: 19922
			// (get) Token: 0x0600EF53 RID: 61267 RVA: 0x0038E158 File Offset: 0x0038C358
			// (set) Token: 0x0600EF54 RID: 61268 RVA: 0x00080538 File Offset: 0x0007E738
			public unsafe List<Action> interruptTanBuff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_interruptTanBuff);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_interruptTanBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DD3 RID: 19923
			// (get) Token: 0x0600EF55 RID: 61269 RVA: 0x0038E188 File Offset: 0x0038C388
			// (set) Token: 0x0600EF56 RID: 61270 RVA: 0x00080557 File Offset: 0x0007E757
			public unsafe GridLayoutGroup gridLayoutGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_gridLayoutGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_gridLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DD4 RID: 19924
			// (get) Token: 0x0600EF57 RID: 61271 RVA: 0x0038E1B8 File Offset: 0x0038C3B8
			// (set) Token: 0x0600EF58 RID: 61272 RVA: 0x00080576 File Offset: 0x0007E776
			public unsafe List<GameObject> allInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_allInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_allInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DD5 RID: 19925
			// (get) Token: 0x0600EF59 RID: 61273 RVA: 0x0038E1E8 File Offset: 0x0038C3E8
			// (set) Token: 0x0600EF5A RID: 61274 RVA: 0x00080595 File Offset: 0x0007E795
			public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 field_Public___c__DisplayClass66_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009894 RID: 39060
			private static readonly IntPtr NativeFieldInfoPtr_parentRect;

			// Token: 0x04009895 RID: 39061
			private static readonly IntPtr NativeFieldInfoPtr_allUsedIngredientsRecord;

			// Token: 0x04009896 RID: 39062
			private static readonly IntPtr NativeFieldInfoPtr_interruptTanBuff;

			// Token: 0x04009897 RID: 39063
			private static readonly IntPtr NativeFieldInfoPtr_gridLayoutGroup;

			// Token: 0x04009898 RID: 39064
			private static readonly IntPtr NativeFieldInfoPtr_allInstance;

			// Token: 0x04009899 RID: 39065
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0;

			// Token: 0x0400989A RID: 39066
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400989B RID: 39067
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__38_Internal_Void_RectTransform_0;

			// Token: 0x0400989C RID: 39068
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Sellable_Recipe_PDM_0;

			// Token: 0x0400989D RID: 39069
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400989E RID: 39070
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x0400989F RID: 39071
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_1;
		}

		// Token: 0x02000D04 RID: 3332
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_6")]
		public sealed class __c__DisplayClass66_6 : Il2CppSystem.Object
		{
			// Token: 0x0600EF5B RID: 61275 RVA: 0x0038E218 File Offset: 0x0038C418
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_6()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_allUsedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr, "allUsedIngredients");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_removeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr, "removeCallback");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_thisInterruptTanBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr, "thisInterruptTanBuff");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_field_Public___c__DisplayClass66_5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr, "CS$<>8__locals6");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr___9__47 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr, "<>9__47");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr, 100682086);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr, 100682087);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeMethodInfoPtr__MainChallengeLoop_b__47_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr, 100682088);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeMethodInfoPtr__MainChallengeLoop_b__45_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr, 100682089);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeMethodInfoPtr__MainChallengeLoop_b__46_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr, 100682090);
			}

			// Token: 0x0600EF5C RID: 61276 RVA: 0x0038E30C File Offset: 0x0038C50C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_6() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF5D RID: 61277 RVA: 0x0038E348 File Offset: 0x0038C548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227613, XrefRangeEnd = 227628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__44(ValueTuple<Recipe, Sellable> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EF5E RID: 61278 RVA: 0x0038E39C File Offset: 0x0038C59C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227628, XrefRangeEnd = 227631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__47(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeMethodInfoPtr__MainChallengeLoop_b__47_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EF5F RID: 61279 RVA: 0x0038E3E8 File Offset: 0x0038C5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227631, XrefRangeEnd = 227655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__45()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeMethodInfoPtr__MainChallengeLoop_b__45_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF60 RID: 61280 RVA: 0x0038E41C File Offset: 0x0038C61C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227655, XrefRangeEnd = 227703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__46(int currentTime, string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeMethodInfoPtr__MainChallengeLoop_b__46_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EF61 RID: 61281 RVA: 0x000805B4 File Offset: 0x0007E7B4
			public __c__DisplayClass66_6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DD6 RID: 19926
			// (get) Token: 0x0600EF62 RID: 61282 RVA: 0x0038E474 File Offset: 0x0038C674
			// (set) Token: 0x0600EF63 RID: 61283 RVA: 0x000805BD File Offset: 0x0007E7BD
			public unsafe IEnumerable<int> allUsedIngredients
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_allUsedIngredients);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_allUsedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DD7 RID: 19927
			// (get) Token: 0x0600EF64 RID: 61284 RVA: 0x0038E4A4 File Offset: 0x0038C6A4
			// (set) Token: 0x0600EF65 RID: 61285 RVA: 0x000805DC File Offset: 0x0007E7DC
			public unsafe Action removeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_removeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_removeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DD8 RID: 19928
			// (get) Token: 0x0600EF66 RID: 61286 RVA: 0x0038E4D4 File Offset: 0x0038C6D4
			// (set) Token: 0x0600EF67 RID: 61287 RVA: 0x000805FB File Offset: 0x0007E7FB
			public unsafe Action thisInterruptTanBuff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_thisInterruptTanBuff);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_thisInterruptTanBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DD9 RID: 19929
			// (get) Token: 0x0600EF68 RID: 61288 RVA: 0x0038E504 File Offset: 0x0038C704
			// (set) Token: 0x0600EF69 RID: 61289 RVA: 0x0008061A File Offset: 0x0007E81A
			public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5 field_Public___c__DisplayClass66_5_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_field_Public___c__DisplayClass66_5_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_5>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr_field_Public___c__DisplayClass66_5_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DDA RID: 19930
			// (get) Token: 0x0600EF6A RID: 61290 RVA: 0x0038E534 File Offset: 0x0038C734
			// (set) Token: 0x0600EF6B RID: 61291 RVA: 0x00080639 File Offset: 0x0007E839
			public unsafe Func<int, bool> __9__47
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr___9__47);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_6.NativeFieldInfoPtr___9__47), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098A0 RID: 39072
			private static readonly IntPtr NativeFieldInfoPtr_allUsedIngredients;

			// Token: 0x040098A1 RID: 39073
			private static readonly IntPtr NativeFieldInfoPtr_removeCallback;

			// Token: 0x040098A2 RID: 39074
			private static readonly IntPtr NativeFieldInfoPtr_thisInterruptTanBuff;

			// Token: 0x040098A3 RID: 39075
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass66_5_0;

			// Token: 0x040098A4 RID: 39076
			private static readonly IntPtr NativeFieldInfoPtr___9__47;

			// Token: 0x040098A5 RID: 39077
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098A6 RID: 39078
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0;

			// Token: 0x040098A7 RID: 39079
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__47_Internal_Boolean_Int32_0;

			// Token: 0x040098A8 RID: 39080
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__45_Internal_Void_0;

			// Token: 0x040098A9 RID: 39081
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__46_Internal_String_Int32_String_0;
		}

		// Token: 0x02000D05 RID: 3333
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_7")]
		public sealed class __c__DisplayClass66_7 : Il2CppSystem.Object
		{
			// Token: 0x0600EF6C RID: 61292 RVA: 0x0038E564 File Offset: 0x0038C764
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_7()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7>.NativeClassPtr, "id");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7>.NativeClassPtr, "CS$<>8__locals7");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7>.NativeClassPtr, 100682091);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeMethodInfoPtr__MainChallengeLoop_b__53_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7>.NativeClassPtr, 100682092);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeMethodInfoPtr__MainChallengeLoop_b__54_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7>.NativeClassPtr, 100682093);
			}

			// Token: 0x0600EF6D RID: 61293 RVA: 0x0038E5F4 File Offset: 0x0038C7F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_7() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF6E RID: 61294 RVA: 0x0038E630 File Offset: 0x0038C830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__53(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeMethodInfoPtr__MainChallengeLoop_b__53_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF6F RID: 61295 RVA: 0x0038E674 File Offset: 0x0038C874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227703, XrefRangeEnd = 227705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__54(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeMethodInfoPtr__MainChallengeLoop_b__54_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF70 RID: 61296 RVA: 0x00080658 File Offset: 0x0007E858
			public __c__DisplayClass66_7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DDB RID: 19931
			// (get) Token: 0x0600EF71 RID: 61297 RVA: 0x0038E6B8 File Offset: 0x0038C8B8
			// (set) Token: 0x0600EF72 RID: 61298 RVA: 0x00080661 File Offset: 0x0007E861
			public ValueTuple<int, int> id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeFieldInfoPtr_id);
					return new ValueTuple<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeFieldInfoPtr_id), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004DDC RID: 19932
			// (get) Token: 0x0600EF73 RID: 61299 RVA: 0x0038E6E8 File Offset: 0x0038C8E8
			// (set) Token: 0x0600EF74 RID: 61300 RVA: 0x0008068F File Offset: 0x0007E88F
			public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 field_Public___c__DisplayClass66_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_7.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098AA RID: 39082
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040098AB RID: 39083
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0;

			// Token: 0x040098AC RID: 39084
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098AD RID: 39085
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__53_Internal_Void_Image_0;

			// Token: 0x040098AE RID: 39086
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__54_Internal_Void_Image_0;
		}

		// Token: 0x02000D06 RID: 3334
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_8")]
		public sealed class __c__DisplayClass66_8 : Il2CppSystem.Object
		{
			// Token: 0x0600EF75 RID: 61301 RVA: 0x0038E718 File Offset: 0x0038C918
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_8()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, "effect");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_findEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, "findEffect");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_currentSettingBgm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, "currentSettingBgm");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_isLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, "isLeft");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_mizuchiPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, "mizuchiPosition");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, "CS$<>8__locals8");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, 100682094);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, 100682095);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, 100682096);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, 100682097);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, 100682098);
			}

			// Token: 0x0600EF76 RID: 61302 RVA: 0x0038E820 File Offset: 0x0038CA20
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_8() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF77 RID: 61303 RVA: 0x0038E85C File Offset: 0x0038CA5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227720, XrefRangeEnd = 227737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__56()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF78 RID: 61304 RVA: 0x0038E890 File Offset: 0x0038CA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227737, XrefRangeEnd = 227758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Single_PDM_0(float remaining)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref remaining;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF79 RID: 61305 RVA: 0x0038E8D0 File Offset: 0x0038CAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227758, XrefRangeEnd = 227763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EF7A RID: 61306 RVA: 0x0038E910 File Offset: 0x0038CB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227763, XrefRangeEnd = 227775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF7B RID: 61307 RVA: 0x000806AE File Offset: 0x0007E8AE
			public __c__DisplayClass66_8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DDD RID: 19933
			// (get) Token: 0x0600EF7C RID: 61308 RVA: 0x0038E944 File Offset: 0x0038CB44
			// (set) Token: 0x0600EF7D RID: 61309 RVA: 0x000806B7 File Offset: 0x0007E8B7
			public unsafe GameObject effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DDE RID: 19934
			// (get) Token: 0x0600EF7E RID: 61310 RVA: 0x0038E974 File Offset: 0x0038CB74
			// (set) Token: 0x0600EF7F RID: 61311 RVA: 0x000806D6 File Offset: 0x0007E8D6
			public unsafe GameObject findEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_findEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_findEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DDF RID: 19935
			// (get) Token: 0x0600EF80 RID: 61312 RVA: 0x0038E9A4 File Offset: 0x0038CBA4
			// (set) Token: 0x0600EF81 RID: 61313 RVA: 0x000806F5 File Offset: 0x0007E8F5
			public unsafe float currentSettingBgm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_currentSettingBgm);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_currentSettingBgm)) = value;
				}
			}

			// Token: 0x17004DE0 RID: 19936
			// (get) Token: 0x0600EF82 RID: 61314 RVA: 0x0038E9CC File Offset: 0x0038CBCC
			// (set) Token: 0x0600EF83 RID: 61315 RVA: 0x00080710 File Offset: 0x0007E910
			public unsafe bool isLeft
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_isLeft);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_isLeft)) = value;
				}
			}

			// Token: 0x17004DE1 RID: 19937
			// (get) Token: 0x0600EF84 RID: 61316 RVA: 0x0038E9F4 File Offset: 0x0038CBF4
			// (set) Token: 0x0600EF85 RID: 61317 RVA: 0x0008072B File Offset: 0x0007E92B
			public Nullable<Vector2> mizuchiPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_mizuchiPosition);
					return new Nullable<Vector2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector2>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_mizuchiPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector2>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004DE2 RID: 19938
			// (get) Token: 0x0600EF86 RID: 61318 RVA: 0x0038EA24 File Offset: 0x0038CC24
			// (set) Token: 0x0600EF87 RID: 61319 RVA: 0x00080759 File Offset: 0x0007E959
			public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 field_Public___c__DisplayClass66_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098AF RID: 39087
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x040098B0 RID: 39088
			private static readonly IntPtr NativeFieldInfoPtr_findEffect;

			// Token: 0x040098B1 RID: 39089
			private static readonly IntPtr NativeFieldInfoPtr_currentSettingBgm;

			// Token: 0x040098B2 RID: 39090
			private static readonly IntPtr NativeFieldInfoPtr_isLeft;

			// Token: 0x040098B3 RID: 39091
			private static readonly IntPtr NativeFieldInfoPtr_mizuchiPosition;

			// Token: 0x040098B4 RID: 39092
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0;

			// Token: 0x040098B5 RID: 39093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098B6 RID: 39094
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Void_0;

			// Token: 0x040098B7 RID: 39095
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0;

			// Token: 0x040098B8 RID: 39096
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040098B9 RID: 39097
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x02001087 RID: 4231
			[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_8+<<MainChallengeLoop>g__DeleteFindEffect|58>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012051 RID: 73809 RVA: 0x0041DB0C File Offset: 0x0041BD0C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>.NativeClassPtr, "<<MainChallengeLoop>g__DeleteFindEffect|58>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682099);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682100);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682101);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682102);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682103);
					DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682104);
				}

				// Token: 0x06012052 RID: 73810 RVA: 0x0041DBEC File Offset: 0x0041BDEC
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012053 RID: 73811 RVA: 0x0041DC34 File Offset: 0x0041BE34
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012054 RID: 73812 RVA: 0x0041DC68 File Offset: 0x0041BE68
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227705, XrefRangeEnd = 227714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E09 RID: 24073
				// (get) Token: 0x06012055 RID: 73813 RVA: 0x0041DCA4 File Offset: 0x0041BEA4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012056 RID: 73814 RVA: 0x0041DCE4 File Offset: 0x0041BEE4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227714, XrefRangeEnd = 227720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E0A RID: 24074
				// (get) Token: 0x06012057 RID: 73815 RVA: 0x0041DD18 File Offset: 0x0041BF18
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012058 RID: 73816 RVA: 0x0009C8AE File Offset: 0x0009AAAE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E06 RID: 24070
				// (get) Token: 0x06012059 RID: 73817 RVA: 0x0041DD58 File Offset: 0x0041BF58
				// (set) Token: 0x0601205A RID: 73818 RVA: 0x0009C8B7 File Offset: 0x0009AAB7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E07 RID: 24071
				// (get) Token: 0x0601205B RID: 73819 RVA: 0x0041DD80 File Offset: 0x0041BF80
				// (set) Token: 0x0601205C RID: 73820 RVA: 0x0009C8D2 File Offset: 0x0009AAD2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E08 RID: 24072
				// (get) Token: 0x0601205D RID: 73821 RVA: 0x0041DDB0 File Offset: 0x0041BFB0
				// (set) Token: 0x0601205E RID: 73822 RVA: 0x0009C8F1 File Offset: 0x0009AAF1
				public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_8.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B69D RID: 46749
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B69E RID: 46750
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B69F RID: 46751
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B6A0 RID: 46752
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B6A1 RID: 46753
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6A2 RID: 46754
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B6A3 RID: 46755
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B6A4 RID: 46756
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6A5 RID: 46757
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D07 RID: 3335
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_9")]
		public sealed class __c__DisplayClass66_9 : Il2CppSystem.Object
		{
			// Token: 0x0600EF88 RID: 61320 RVA: 0x0038EA54 File Offset: 0x0038CC54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_9()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeFieldInfoPtr_selectedGuestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9>.NativeClassPtr, "selectedGuestGroup");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9>.NativeClassPtr, "group");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9>.NativeClassPtr, "CS$<>8__locals9");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9>.NativeClassPtr, 100682105);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeMethodInfoPtr__MainChallengeLoop_b__78_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9>.NativeClassPtr, 100682106);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeMethodInfoPtr__MainChallengeLoop_b__79_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9>.NativeClassPtr, 100682107);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9>.NativeClassPtr, 100682108);
			}

			// Token: 0x0600EF89 RID: 61321 RVA: 0x0038EB0C File Offset: 0x0038CD0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_9() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF8A RID: 61322 RVA: 0x0038EB48 File Offset: 0x0038CD48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227775, XrefRangeEnd = 227781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__78(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeMethodInfoPtr__MainChallengeLoop_b__78_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF8B RID: 61323 RVA: 0x0038EB8C File Offset: 0x0038CD8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227781, XrefRangeEnd = 227790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__79(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeMethodInfoPtr__MainChallengeLoop_b__79_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF8C RID: 61324 RVA: 0x0038EBD0 File Offset: 0x0038CDD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227790, XrefRangeEnd = 227925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0(GuestGroupController.EvaluationResult originResult, GuestGroupController thisGuest, bool oldComboProtect, out string message, out bool comboProtect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref originResult;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				message = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600EF8D RID: 61325 RVA: 0x00080778 File Offset: 0x0007E978
			public __c__DisplayClass66_9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DE3 RID: 19939
			// (get) Token: 0x0600EF8E RID: 61326 RVA: 0x0038EC64 File Offset: 0x0038CE64
			// (set) Token: 0x0600EF8F RID: 61327 RVA: 0x00080781 File Offset: 0x0007E981
			public unsafe int selectedGuestGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeFieldInfoPtr_selectedGuestGroup);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeFieldInfoPtr_selectedGuestGroup)) = value;
				}
			}

			// Token: 0x17004DE4 RID: 19940
			// (get) Token: 0x0600EF90 RID: 61328 RVA: 0x0038EC8C File Offset: 0x0038CE8C
			// (set) Token: 0x0600EF91 RID: 61329 RVA: 0x0008079C File Offset: 0x0007E99C
			public unsafe SpecialGuestsController group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeFieldInfoPtr_group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DE5 RID: 19941
			// (get) Token: 0x0600EF92 RID: 61330 RVA: 0x0038ECBC File Offset: 0x0038CEBC
			// (set) Token: 0x0600EF93 RID: 61331 RVA: 0x000807BB File Offset: 0x0007E9BB
			public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 field_Public___c__DisplayClass66_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_9.NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098BA RID: 39098
			private static readonly IntPtr NativeFieldInfoPtr_selectedGuestGroup;

			// Token: 0x040098BB RID: 39099
			private static readonly IntPtr NativeFieldInfoPtr_group;

			// Token: 0x040098BC RID: 39100
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass66_0_0;

			// Token: 0x040098BD RID: 39101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098BE RID: 39102
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__78_Internal_Void_GuestGroupController_0;

			// Token: 0x040098BF RID: 39103
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__79_Internal_Void_GuestGroupController_0;

			// Token: 0x040098C0 RID: 39104
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0;
		}

		// Token: 0x02000D08 RID: 3336
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_10")]
		public sealed class __c__DisplayClass66_10 : Il2CppSystem.Object
		{
			// Token: 0x0600EF94 RID: 61332 RVA: 0x0038ECEC File Offset: 0x0038CEEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_10()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeFieldInfoPtr_targetText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10>.NativeClassPtr, "targetText");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeFieldInfoPtr_targetText2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10>.NativeClassPtr, "targetText2");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeFieldInfoPtr_targetText3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10>.NativeClassPtr, "targetText3");
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10>.NativeClassPtr, 100682109);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10>.NativeClassPtr, 100682110);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeMethodInfoPtr__MainChallengeLoop_b__76_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10>.NativeClassPtr, 100682111);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeMethodInfoPtr__MainChallengeLoop_b__77_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10>.NativeClassPtr, 100682112);
			}

			// Token: 0x0600EF95 RID: 61333 RVA: 0x0038EDA4 File Offset: 0x0038CFA4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_10() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF96 RID: 61334 RVA: 0x0038EDE0 File Offset: 0x0038CFE0
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__75(int foodId, string specGuest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref foodId;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(specGuest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EF97 RID: 61335 RVA: 0x0038EE38 File Offset: 0x0038D038
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__76(int bevId, string specGuest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref bevId;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(specGuest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeMethodInfoPtr__MainChallengeLoop_b__76_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EF98 RID: 61336 RVA: 0x0038EE90 File Offset: 0x0038D090
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__77(string oldText)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeMethodInfoPtr__MainChallengeLoop_b__77_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EF99 RID: 61337 RVA: 0x000807DA File Offset: 0x0007E9DA
			public __c__DisplayClass66_10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DE6 RID: 19942
			// (get) Token: 0x0600EF9A RID: 61338 RVA: 0x0038EED8 File Offset: 0x0038D0D8
			// (set) Token: 0x0600EF9B RID: 61339 RVA: 0x000807E3 File Offset: 0x0007E9E3
			public unsafe string targetText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeFieldInfoPtr_targetText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeFieldInfoPtr_targetText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004DE7 RID: 19943
			// (get) Token: 0x0600EF9C RID: 61340 RVA: 0x0038EF00 File Offset: 0x0038D100
			// (set) Token: 0x0600EF9D RID: 61341 RVA: 0x00080802 File Offset: 0x0007EA02
			public unsafe string targetText2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeFieldInfoPtr_targetText2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeFieldInfoPtr_targetText2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004DE8 RID: 19944
			// (get) Token: 0x0600EF9E RID: 61342 RVA: 0x0038EF28 File Offset: 0x0038D128
			// (set) Token: 0x0600EF9F RID: 61343 RVA: 0x00080821 File Offset: 0x0007EA21
			public unsafe string targetText3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeFieldInfoPtr_targetText3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData.__c__DisplayClass66_10.NativeFieldInfoPtr_targetText3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040098C1 RID: 39105
			private static readonly IntPtr NativeFieldInfoPtr_targetText;

			// Token: 0x040098C2 RID: 39106
			private static readonly IntPtr NativeFieldInfoPtr_targetText2;

			// Token: 0x040098C3 RID: 39107
			private static readonly IntPtr NativeFieldInfoPtr_targetText3;

			// Token: 0x040098C4 RID: 39108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098C5 RID: 39109
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_String_Int32_String_0;

			// Token: 0x040098C6 RID: 39110
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__76_Internal_String_Int32_String_0;

			// Token: 0x040098C7 RID: 39111
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__77_Internal_String_String_0;
		}

		// Token: 0x02000D09 RID: 3337
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c__DisplayClass66_11")]
		[StructLayout(2)]
		public struct __c__DisplayClass66_11
		{
			// Token: 0x0600EFA0 RID: 61344 RVA: 0x00080840 File Offset: 0x0007EA40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_11()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c__DisplayClass66_11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_11>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c__DisplayClass66_11.NativeFieldInfoPtr_originResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_11>.NativeClassPtr, "originResult");
			}

			// Token: 0x0600EFA1 RID: 61345 RVA: 0x00080874 File Offset: 0x0007EA74
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_11>.NativeClassPtr, ref this));
			}

			// Token: 0x040098C8 RID: 39112
			private static readonly IntPtr NativeFieldInfoPtr_originResult;

			// Token: 0x040098C9 RID: 39113
			[FieldOffset(0)]
			public GuestGroupController.EvaluationResult originResult;
		}

		// Token: 0x02000D0A RID: 3338
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EFA2 RID: 61346 RVA: 0x0038EF50 File Offset: 0x0038D150
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_1");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_2");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_3");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_4");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_5");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_6");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_8");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_32");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_48 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_48");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_49 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_49");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_50 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_50");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_51 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_51");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_74 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_74");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_81 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_81");
				DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_82 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, "<>9__66_82");
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682114);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_1_Internal_Int32_GuestRunType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682115);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_2_Internal_KeyValuePair_2_Int32_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682116);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_3_Internal_Boolean_KeyValuePair_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682117);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_4_Internal_ValueTuple_4_Int32_String_String_String_KeyValuePair_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682118);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_5_Internal_Int32_ValueTuple_4_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682119);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_6_Internal_ValueTuple_3_String_String_String_ValueTuple_4_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682120);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_8_Internal_Boolean_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682121);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_32_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682122);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_48_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682123);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_49_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682124);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_50_Internal_ValueTuple_2_Int32_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682125);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_51_Internal_Int32_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682126);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_74_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682127);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_81_Internal_Boolean_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682128);
				DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_82_Internal_Boolean_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr, 100682129);
			}

			// Token: 0x0600EFA3 RID: 61347 RVA: 0x0038F1FC File Offset: 0x0038D3FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EFA4 RID: 61348 RVA: 0x0038F238 File Offset: 0x0038D438
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__66_1(DLC5_MizuchiChallengeBossData.GuestRunType x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_1_Internal_Int32_GuestRunType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EFA5 RID: 61349 RVA: 0x0038F284 File Offset: 0x0038D484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227925, XrefRangeEnd = 227938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<int, Il2CppStringArray> _MainChallengeLoop_b__66_2(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_2_Internal_KeyValuePair_2_Int32_Il2CppStringArray_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<int, Il2CppStringArray>(pointer);
			}

			// Token: 0x0600EFA6 RID: 61350 RVA: 0x0038F2CC File Offset: 0x0038D4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227938, XrefRangeEnd = 227939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__66_3(KeyValuePair<int, Il2CppStringArray> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_3_Internal_Boolean_KeyValuePair_2_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EFA7 RID: 61351 RVA: 0x0038F320 File Offset: 0x0038D520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227939, XrefRangeEnd = 227944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, string, string, string> _MainChallengeLoop_b__66_4(KeyValuePair<int, Il2CppStringArray> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_4_Internal_ValueTuple_4_Int32_String_String_String_KeyValuePair_2_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, string, string, string>(pointer);
			}

			// Token: 0x0600EFA8 RID: 61352 RVA: 0x0038F370 File Offset: 0x0038D570
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__66_5(ValueTuple<int, string, string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_5_Internal_Int32_ValueTuple_4_Int32_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EFA9 RID: 61353 RVA: 0x0038F3C4 File Offset: 0x0038D5C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227944, XrefRangeEnd = 227947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, string, string> _MainChallengeLoop_b__66_6(ValueTuple<int, string, string, string> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_6_Internal_ValueTuple_3_String_String_String_ValueTuple_4_Int32_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<string, string, string>(pointer);
			}

			// Token: 0x0600EFAA RID: 61354 RVA: 0x0038F414 File Offset: 0x0038D614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227947, XrefRangeEnd = 227949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__66_8(DLC5_MizuchiChallengeBossData.ChallengeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_8_Internal_Boolean_ChallengeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EFAB RID: 61355 RVA: 0x0038F460 File Offset: 0x0038D660
			[CallerCount(0)]
			public unsafe string _MainChallengeLoop_b__66_32(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_32_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EFAC RID: 61356 RVA: 0x0038F4A8 File Offset: 0x0038D6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__66_48(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_48_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EFAD RID: 61357 RVA: 0x0038F4EC File Offset: 0x0038D6EC
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__66_49(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_49_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EFAE RID: 61358 RVA: 0x0038F530 File Offset: 0x0038D730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227949, XrefRangeEnd = 227954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, int> _MainChallengeLoop_b__66_50(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_50_Internal_ValueTuple_2_Int32_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, int>(pointer);
			}

			// Token: 0x0600EFAF RID: 61359 RVA: 0x0038F580 File Offset: 0x0038D780
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__66_51(ValueTuple<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_51_Internal_Int32_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EFB0 RID: 61360 RVA: 0x0038F5D4 File Offset: 0x0038D7D4
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__66_74(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_74_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EFB1 RID: 61361 RVA: 0x0038F620 File Offset: 0x0038D820
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__66_81(SpecialGuestsController _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_81_Internal_Boolean_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EFB2 RID: 61362 RVA: 0x0038F670 File Offset: 0x0038D870
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__66_82(SpecialGuestsController _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__66_82_Internal_Boolean_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EFB3 RID: 61363 RVA: 0x00080886 File Offset: 0x0007EA86
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DE9 RID: 19945
			// (get) Token: 0x0600EFB4 RID: 61364 RVA: 0x0038F6C0 File Offset: 0x0038D8C0
			// (set) Token: 0x0600EFB5 RID: 61365 RVA: 0x0008088F File Offset: 0x0007EA8F
			public unsafe static DLC5_MizuchiChallengeBossData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DEA RID: 19946
			// (get) Token: 0x0600EFB6 RID: 61366 RVA: 0x0038F6E8 File Offset: 0x0038D8E8
			// (set) Token: 0x0600EFB7 RID: 61367 RVA: 0x000808A1 File Offset: 0x0007EAA1
			public unsafe static Func<DLC5_MizuchiChallengeBossData.GuestRunType, int> __9__66_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_MizuchiChallengeBossData.GuestRunType, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DEB RID: 19947
			// (get) Token: 0x0600EFB8 RID: 61368 RVA: 0x0038F710 File Offset: 0x0038D910
			// (set) Token: 0x0600EFB9 RID: 61369 RVA: 0x000808B3 File Offset: 0x0007EAB3
			public unsafe static Func<Il2CppStringArray, KeyValuePair<int, Il2CppStringArray>> __9__66_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, KeyValuePair<int, Il2CppStringArray>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DEC RID: 19948
			// (get) Token: 0x0600EFBA RID: 61370 RVA: 0x0038F738 File Offset: 0x0038D938
			// (set) Token: 0x0600EFBB RID: 61371 RVA: 0x000808C5 File Offset: 0x0007EAC5
			public unsafe static Func<KeyValuePair<int, Il2CppStringArray>, bool> __9__66_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Il2CppStringArray>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DED RID: 19949
			// (get) Token: 0x0600EFBC RID: 61372 RVA: 0x0038F760 File Offset: 0x0038D960
			// (set) Token: 0x0600EFBD RID: 61373 RVA: 0x000808D7 File Offset: 0x0007EAD7
			public unsafe static Func<KeyValuePair<int, Il2CppStringArray>, ValueTuple<int, string, string, string>> __9__66_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Il2CppStringArray>, ValueTuple<int, string, string, string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DEE RID: 19950
			// (get) Token: 0x0600EFBE RID: 61374 RVA: 0x0038F788 File Offset: 0x0038D988
			// (set) Token: 0x0600EFBF RID: 61375 RVA: 0x000808E9 File Offset: 0x0007EAE9
			public unsafe static Func<ValueTuple<int, string, string, string>, int> __9__66_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, string, string, string>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DEF RID: 19951
			// (get) Token: 0x0600EFC0 RID: 61376 RVA: 0x0038F7B0 File Offset: 0x0038D9B0
			// (set) Token: 0x0600EFC1 RID: 61377 RVA: 0x000808FB File Offset: 0x0007EAFB
			public unsafe static Func<ValueTuple<int, string, string, string>, ValueTuple<string, string, string>> __9__66_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, string, string, string>, ValueTuple<string, string, string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DF0 RID: 19952
			// (get) Token: 0x0600EFC2 RID: 61378 RVA: 0x0038F7D8 File Offset: 0x0038D9D8
			// (set) Token: 0x0600EFC3 RID: 61379 RVA: 0x0008090D File Offset: 0x0007EB0D
			public unsafe static Func<DLC5_MizuchiChallengeBossData.ChallengeData, bool> __9__66_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_MizuchiChallengeBossData.ChallengeData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DF1 RID: 19953
			// (get) Token: 0x0600EFC4 RID: 61380 RVA: 0x0038F800 File Offset: 0x0038DA00
			// (set) Token: 0x0600EFC5 RID: 61381 RVA: 0x0008091F File Offset: 0x0007EB1F
			public unsafe static Func<string, string> __9__66_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DF2 RID: 19954
			// (get) Token: 0x0600EFC6 RID: 61382 RVA: 0x0038F828 File Offset: 0x0038DA28
			// (set) Token: 0x0600EFC7 RID: 61383 RVA: 0x00080931 File Offset: 0x0007EB31
			public unsafe static Func<int, string> __9__66_48
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_48, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_48, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DF3 RID: 19955
			// (get) Token: 0x0600EFC8 RID: 61384 RVA: 0x0038F850 File Offset: 0x0038DA50
			// (set) Token: 0x0600EFC9 RID: 61385 RVA: 0x00080943 File Offset: 0x0007EB43
			public unsafe static Action<Action> __9__66_49
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_49, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_49, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DF4 RID: 19956
			// (get) Token: 0x0600EFCA RID: 61386 RVA: 0x0038F878 File Offset: 0x0038DA78
			// (set) Token: 0x0600EFCB RID: 61387 RVA: 0x00080955 File Offset: 0x0007EB55
			public unsafe static Func<KeyValuePair<int, int>, ValueTuple<int, int>> __9__66_50
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_50, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, ValueTuple<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_50, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DF5 RID: 19957
			// (get) Token: 0x0600EFCC RID: 61388 RVA: 0x0038F8A0 File Offset: 0x0038DAA0
			// (set) Token: 0x0600EFCD RID: 61389 RVA: 0x00080967 File Offset: 0x0007EB67
			public unsafe static Func<ValueTuple<int, int>, int> __9__66_51
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_51, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_51, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DF6 RID: 19958
			// (get) Token: 0x0600EFCE RID: 61390 RVA: 0x0038F8C8 File Offset: 0x0038DAC8
			// (set) Token: 0x0600EFCF RID: 61391 RVA: 0x00080979 File Offset: 0x0007EB79
			public unsafe static Func<int, bool> __9__66_74
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_74, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_74, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DF7 RID: 19959
			// (get) Token: 0x0600EFD0 RID: 61392 RVA: 0x0038F8F0 File Offset: 0x0038DAF0
			// (set) Token: 0x0600EFD1 RID: 61393 RVA: 0x0008098B File Offset: 0x0007EB8B
			public unsafe static SpecialGuestsController.CanUseSpellCardDelegate __9__66_81
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_81, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController.CanUseSpellCardDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_81, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DF8 RID: 19960
			// (get) Token: 0x0600EFD2 RID: 61394 RVA: 0x0038F918 File Offset: 0x0038DB18
			// (set) Token: 0x0600EFD3 RID: 61395 RVA: 0x0008099D File Offset: 0x0007EB9D
			public unsafe static SpecialGuestsController.CanUseSpellCardDelegate __9__66_82
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_82, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController.CanUseSpellCardDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MizuchiChallengeBossData.__c.NativeFieldInfoPtr___9__66_82, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098CA RID: 39114
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040098CB RID: 39115
			private static readonly IntPtr NativeFieldInfoPtr___9__66_1;

			// Token: 0x040098CC RID: 39116
			private static readonly IntPtr NativeFieldInfoPtr___9__66_2;

			// Token: 0x040098CD RID: 39117
			private static readonly IntPtr NativeFieldInfoPtr___9__66_3;

			// Token: 0x040098CE RID: 39118
			private static readonly IntPtr NativeFieldInfoPtr___9__66_4;

			// Token: 0x040098CF RID: 39119
			private static readonly IntPtr NativeFieldInfoPtr___9__66_5;

			// Token: 0x040098D0 RID: 39120
			private static readonly IntPtr NativeFieldInfoPtr___9__66_6;

			// Token: 0x040098D1 RID: 39121
			private static readonly IntPtr NativeFieldInfoPtr___9__66_8;

			// Token: 0x040098D2 RID: 39122
			private static readonly IntPtr NativeFieldInfoPtr___9__66_32;

			// Token: 0x040098D3 RID: 39123
			private static readonly IntPtr NativeFieldInfoPtr___9__66_48;

			// Token: 0x040098D4 RID: 39124
			private static readonly IntPtr NativeFieldInfoPtr___9__66_49;

			// Token: 0x040098D5 RID: 39125
			private static readonly IntPtr NativeFieldInfoPtr___9__66_50;

			// Token: 0x040098D6 RID: 39126
			private static readonly IntPtr NativeFieldInfoPtr___9__66_51;

			// Token: 0x040098D7 RID: 39127
			private static readonly IntPtr NativeFieldInfoPtr___9__66_74;

			// Token: 0x040098D8 RID: 39128
			private static readonly IntPtr NativeFieldInfoPtr___9__66_81;

			// Token: 0x040098D9 RID: 39129
			private static readonly IntPtr NativeFieldInfoPtr___9__66_82;

			// Token: 0x040098DA RID: 39130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098DB RID: 39131
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_1_Internal_Int32_GuestRunType_0;

			// Token: 0x040098DC RID: 39132
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_2_Internal_KeyValuePair_2_Int32_Il2CppStringArray_Il2CppStringArray_0;

			// Token: 0x040098DD RID: 39133
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_3_Internal_Boolean_KeyValuePair_2_Int32_Il2CppStringArray_0;

			// Token: 0x040098DE RID: 39134
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_4_Internal_ValueTuple_4_Int32_String_String_String_KeyValuePair_2_Int32_Il2CppStringArray_0;

			// Token: 0x040098DF RID: 39135
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_5_Internal_Int32_ValueTuple_4_Int32_String_String_String_0;

			// Token: 0x040098E0 RID: 39136
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_6_Internal_ValueTuple_3_String_String_String_ValueTuple_4_Int32_String_String_String_0;

			// Token: 0x040098E1 RID: 39137
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_8_Internal_Boolean_ChallengeData_0;

			// Token: 0x040098E2 RID: 39138
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_32_Internal_String_String_0;

			// Token: 0x040098E3 RID: 39139
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_48_Internal_String_Int32_0;

			// Token: 0x040098E4 RID: 39140
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_49_Internal_Void_Action_0;

			// Token: 0x040098E5 RID: 39141
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_50_Internal_ValueTuple_2_Int32_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040098E6 RID: 39142
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_51_Internal_Int32_ValueTuple_2_Int32_Int32_0;

			// Token: 0x040098E7 RID: 39143
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_74_Internal_Boolean_Int32_0;

			// Token: 0x040098E8 RID: 39144
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_81_Internal_Boolean_SpecialGuestsController_0;

			// Token: 0x040098E9 RID: 39145
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_82_Internal_Boolean_SpecialGuestsController_0;
		}

		// Token: 0x02000D0B RID: 3339
		[ObfuscatedName("GameData.Profile.DLC5_MizuchiChallengeBossData+<MainChallengeLoop>d__66")]
		public sealed class _MainChallengeLoop_d__66 : Il2CppSystem.Object
		{
			// Token: 0x0600EFD4 RID: 61396 RVA: 0x0038F940 File Offset: 0x0038DB40
			// Note: this type is marked as 'beforefieldinit'.
			static _MainChallengeLoop_d__66()
			{
				Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData>.NativeClassPtr, "<MainChallengeLoop>d__66");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr);
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<>1__state");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<>2__current");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<>4__this");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "bossDataContext");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<>8__1");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__cookSystemManagerInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<cookSystemManagerInstance>5__2");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__puyoyoFruitGiveNum_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<puyoyoFruitGiveNum>5__3");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__finishChallengeA_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<finishChallengeA>5__4");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__finishChallengeB_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<finishChallengeB>5__5");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__finishChallengeC_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<finishChallengeC>5__6");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__practiceTime_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<practiceTime>5__7");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__mizuchiBuffNum_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<mizuchiBuffNum>5__8");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__mainLoop_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<mainLoop>5__9");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__chargingCoroutine_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, "<chargingCoroutine>5__10");
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, 100682130);
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, 100682131);
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, 100682132);
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, 100682133);
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, 100682134);
				DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr, 100682135);
			}

			// Token: 0x0600EFD5 RID: 61397 RVA: 0x0038FAFC File Offset: 0x0038DCFC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MainChallengeLoop_d__66(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EFD6 RID: 61398 RVA: 0x0038FB44 File Offset: 0x0038DD44
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EFD7 RID: 61399 RVA: 0x0038FB78 File Offset: 0x0038DD78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227954, XrefRangeEnd = 228606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004E07 RID: 19975
			// (get) Token: 0x0600EFD8 RID: 61400 RVA: 0x0038FBB4 File Offset: 0x0038DDB4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EFD9 RID: 61401 RVA: 0x0038FBF4 File Offset: 0x0038DDF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228606, XrefRangeEnd = 228612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004E08 RID: 19976
			// (get) Token: 0x0600EFDA RID: 61402 RVA: 0x0038FC28 File Offset: 0x0038DE28
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EFDB RID: 61403 RVA: 0x000809AF File Offset: 0x0007EBAF
			public _MainChallengeLoop_d__66(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004DF9 RID: 19961
			// (get) Token: 0x0600EFDC RID: 61404 RVA: 0x0038FC68 File Offset: 0x0038DE68
			// (set) Token: 0x0600EFDD RID: 61405 RVA: 0x000809B8 File Offset: 0x0007EBB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004DFA RID: 19962
			// (get) Token: 0x0600EFDE RID: 61406 RVA: 0x0038FC90 File Offset: 0x0038DE90
			// (set) Token: 0x0600EFDF RID: 61407 RVA: 0x000809D3 File Offset: 0x0007EBD3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DFB RID: 19963
			// (get) Token: 0x0600EFE0 RID: 61408 RVA: 0x0038FCC0 File Offset: 0x0038DEC0
			// (set) Token: 0x0600EFE1 RID: 61409 RVA: 0x000809F2 File Offset: 0x0007EBF2
			public unsafe DLC5_MizuchiChallengeBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DFC RID: 19964
			// (get) Token: 0x0600EFE2 RID: 61410 RVA: 0x0038FCF0 File Offset: 0x0038DEF0
			// (set) Token: 0x0600EFE3 RID: 61411 RVA: 0x00080A11 File Offset: 0x0007EC11
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004DFD RID: 19965
			// (get) Token: 0x0600EFE4 RID: 61412 RVA: 0x0038FD20 File Offset: 0x0038DF20
			// (set) Token: 0x0600EFE5 RID: 61413 RVA: 0x00080A3F File Offset: 0x0007EC3F
			public unsafe DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MizuchiChallengeBossData.__c__DisplayClass66_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DFE RID: 19966
			// (get) Token: 0x0600EFE6 RID: 61414 RVA: 0x0038FD50 File Offset: 0x0038DF50
			// (set) Token: 0x0600EFE7 RID: 61415 RVA: 0x00080A5E File Offset: 0x0007EC5E
			public unsafe CookSystemManager _cookSystemManagerInstance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__cookSystemManagerInstance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookSystemManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__cookSystemManagerInstance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004DFF RID: 19967
			// (get) Token: 0x0600EFE8 RID: 61416 RVA: 0x0038FD80 File Offset: 0x0038DF80
			// (set) Token: 0x0600EFE9 RID: 61417 RVA: 0x00080A7D File Offset: 0x0007EC7D
			public unsafe int _puyoyoFruitGiveNum_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__puyoyoFruitGiveNum_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__puyoyoFruitGiveNum_5__3)) = value;
				}
			}

			// Token: 0x17004E00 RID: 19968
			// (get) Token: 0x0600EFEA RID: 61418 RVA: 0x0038FDA8 File Offset: 0x0038DFA8
			// (set) Token: 0x0600EFEB RID: 61419 RVA: 0x00080A98 File Offset: 0x0007EC98
			public unsafe bool _finishChallengeA_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__finishChallengeA_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__finishChallengeA_5__4)) = value;
				}
			}

			// Token: 0x17004E01 RID: 19969
			// (get) Token: 0x0600EFEC RID: 61420 RVA: 0x0038FDD0 File Offset: 0x0038DFD0
			// (set) Token: 0x0600EFED RID: 61421 RVA: 0x00080AB3 File Offset: 0x0007ECB3
			public unsafe bool _finishChallengeB_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__finishChallengeB_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__finishChallengeB_5__5)) = value;
				}
			}

			// Token: 0x17004E02 RID: 19970
			// (get) Token: 0x0600EFEE RID: 61422 RVA: 0x0038FDF8 File Offset: 0x0038DFF8
			// (set) Token: 0x0600EFEF RID: 61423 RVA: 0x00080ACE File Offset: 0x0007ECCE
			public unsafe bool _finishChallengeC_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__finishChallengeC_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__finishChallengeC_5__6)) = value;
				}
			}

			// Token: 0x17004E03 RID: 19971
			// (get) Token: 0x0600EFF0 RID: 61424 RVA: 0x0038FE20 File Offset: 0x0038E020
			// (set) Token: 0x0600EFF1 RID: 61425 RVA: 0x00080AE9 File Offset: 0x0007ECE9
			public unsafe int _practiceTime_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__practiceTime_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__practiceTime_5__7)) = value;
				}
			}

			// Token: 0x17004E04 RID: 19972
			// (get) Token: 0x0600EFF2 RID: 61426 RVA: 0x0038FE48 File Offset: 0x0038E048
			// (set) Token: 0x0600EFF3 RID: 61427 RVA: 0x00080B04 File Offset: 0x0007ED04
			public unsafe int _mizuchiBuffNum_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__mizuchiBuffNum_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__mizuchiBuffNum_5__8)) = value;
				}
			}

			// Token: 0x17004E05 RID: 19973
			// (get) Token: 0x0600EFF4 RID: 61428 RVA: 0x0038FE70 File Offset: 0x0038E070
			// (set) Token: 0x0600EFF5 RID: 61429 RVA: 0x00080B1F File Offset: 0x0007ED1F
			public unsafe Coroutine _mainLoop_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__mainLoop_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__mainLoop_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E06 RID: 19974
			// (get) Token: 0x0600EFF6 RID: 61430 RVA: 0x0038FEA0 File Offset: 0x0038E0A0
			// (set) Token: 0x0600EFF7 RID: 61431 RVA: 0x00080B3E File Offset: 0x0007ED3E
			public unsafe Coroutine _chargingCoroutine_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__chargingCoroutine_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MizuchiChallengeBossData._MainChallengeLoop_d__66.NativeFieldInfoPtr__chargingCoroutine_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098EA RID: 39146
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040098EB RID: 39147
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040098EC RID: 39148
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098ED RID: 39149
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x040098EE RID: 39150
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040098EF RID: 39151
			private static readonly IntPtr NativeFieldInfoPtr__cookSystemManagerInstance_5__2;

			// Token: 0x040098F0 RID: 39152
			private static readonly IntPtr NativeFieldInfoPtr__puyoyoFruitGiveNum_5__3;

			// Token: 0x040098F1 RID: 39153
			private static readonly IntPtr NativeFieldInfoPtr__finishChallengeA_5__4;

			// Token: 0x040098F2 RID: 39154
			private static readonly IntPtr NativeFieldInfoPtr__finishChallengeB_5__5;

			// Token: 0x040098F3 RID: 39155
			private static readonly IntPtr NativeFieldInfoPtr__finishChallengeC_5__6;

			// Token: 0x040098F4 RID: 39156
			private static readonly IntPtr NativeFieldInfoPtr__practiceTime_5__7;

			// Token: 0x040098F5 RID: 39157
			private static readonly IntPtr NativeFieldInfoPtr__mizuchiBuffNum_5__8;

			// Token: 0x040098F6 RID: 39158
			private static readonly IntPtr NativeFieldInfoPtr__mainLoop_5__9;

			// Token: 0x040098F7 RID: 39159
			private static readonly IntPtr NativeFieldInfoPtr__chargingCoroutine_5__10;

			// Token: 0x040098F8 RID: 39160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040098F9 RID: 39161
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040098FA RID: 39162
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040098FB RID: 39163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040098FC RID: 39164
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040098FD RID: 39165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
