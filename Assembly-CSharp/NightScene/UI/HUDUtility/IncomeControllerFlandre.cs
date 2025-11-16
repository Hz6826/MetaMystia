using System;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Night.BossBattle.DLC4_BossBattle;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001C4 RID: 452
	public class IncomeControllerFlandre : IncomeControllerBase
	{
		// Token: 0x0600382B RID: 14379 RVA: 0x0015F064 File Offset: 0x0015D264
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeControllerFlandre()
		{
			Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "IncomeControllerFlandre");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr);
			IncomeControllerFlandre.NativeFieldInfoPtr_CHANGE_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "CHANGE_AMOUNT");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_Flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_Flag");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_FlagContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_FlagContent");
			IncomeControllerFlandre.NativeFieldInfoPtr_progressBar1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "progressBar1");
			IncomeControllerFlandre.NativeFieldInfoPtr_progressBar2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "progressBar2");
			IncomeControllerFlandre.NativeFieldInfoPtr_timeBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "timeBar");
			IncomeControllerFlandre.NativeFieldInfoPtr_remainingFlandreNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "remainingFlandreNum");
			IncomeControllerFlandre.NativeFieldInfoPtr_progressLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "progressLiteral");
			IncomeControllerFlandre.NativeFieldInfoPtr_pPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "pPoint");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_FlandreHPContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_FlandreHPContext");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_FlandreBossHpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_FlandreBossHpOffset");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_WaitFlandreHPContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_WaitFlandreHPContent");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_CardRechargeIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_CardRechargeIndicator");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicProgressCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_MagicProgressCanvasGroup");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_MagicProgress");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicVFXObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_MagicVFXObject");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicEndVFXObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_MagicEndVFXObject");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_MagicPosition");
			IncomeControllerFlandre.NativeFieldInfoPtr_flagCanvasGroupQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "flagCanvasGroupQueue");
			IncomeControllerFlandre.NativeFieldInfoPtr_flandreBossHpContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "flandreBossHpContexts");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_CardRechargeLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_CardRechargeLists");
			IncomeControllerFlandre.NativeFieldInfoPtr_currentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "currentProgress");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicEndVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_MagicEndVFX");
			IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "m_MagicVFX");
			IncomeControllerFlandre.NativeFieldInfoPtr_onUpdatingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "onUpdatingData");
			IncomeControllerFlandre.NativeFieldInfoPtr_targetProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "targetProgress");
			IncomeControllerFlandre.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673900);
			IncomeControllerFlandre.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673901);
			IncomeControllerFlandre.NativeMethodInfoPtr_SetManager_Public_Void_DLC4_BossBattleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673902);
			IncomeControllerFlandre.NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673903);
			IncomeControllerFlandre.NativeMethodInfoPtr_FinishBigWave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673904);
			IncomeControllerFlandre.NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673905);
			IncomeControllerFlandre.NativeMethodInfoPtr_TryUpdateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673906);
			IncomeControllerFlandre.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673907);
			IncomeControllerFlandre.NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673908);
			IncomeControllerFlandre.NativeMethodInfoPtr_SetFlags_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673909);
			IncomeControllerFlandre.NativeMethodInfoPtr_SetFlandreNum_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673910);
			IncomeControllerFlandre.NativeMethodInfoPtr_SpawnBossHpContext_Public_FlandreBossHPContext_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673911);
			IncomeControllerFlandre.NativeMethodInfoPtr_OnBossDie_Public_Void_FlandreBossHPContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673912);
			IncomeControllerFlandre.NativeMethodInfoPtr_SetPPoint_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673913);
			IncomeControllerFlandre.NativeMethodInfoPtr_TryUpdateVisualInIndicatorBegin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673914);
			IncomeControllerFlandre.NativeMethodInfoPtr_TryUpdateVisualInIndicatorAfter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673915);
			IncomeControllerFlandre.NativeMethodInfoPtr_SetCoolDown_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673916);
			IncomeControllerFlandre.NativeMethodInfoPtr_PatchouliMagicStartCoolDown_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673917);
			IncomeControllerFlandre.NativeMethodInfoPtr_SetMagicProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673918);
			IncomeControllerFlandre.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673919);
			IncomeControllerFlandre.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673920);
			IncomeControllerFlandre.NativeMethodInfoPtr__UpdateVisual_b__33_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673921);
			IncomeControllerFlandre.NativeMethodInfoPtr__UpdateVisual_b__33_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673922);
			IncomeControllerFlandre.NativeMethodInfoPtr__UpdateVisual_b__33_2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, 100673923);
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x0015F47C File Offset: 0x0015D67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130242, XrefRangeEnd = 130245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x0015F4B0 File Offset: 0x0015D6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130245, XrefRangeEnd = 130326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerFlandre.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x0015F4EC File Offset: 0x0015D6EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130328, RefRangeEnd = 130329, XrefRangeStart = 130326, XrefRangeEnd = 130328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManager(DLC4_BossBattleManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_SetManager_Public_Void_DLC4_BossBattleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x0015F530 File Offset: 0x0015D730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130339, RefRangeEnd = 130341, XrefRangeStart = 130329, XrefRangeEnd = 130339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetProgress(int targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x0015F570 File Offset: 0x0015D770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130348, RefRangeEnd = 130349, XrefRangeStart = 130341, XrefRangeEnd = 130348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishBigWave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_FinishBigWave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x0015F5A4 File Offset: 0x0015D7A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130361, RefRangeEnd = 130362, XrefRangeStart = 130349, XrefRangeEnd = 130361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetProgressImmediate(int targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x0015F5E4 File Offset: 0x0015D7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130362, XrefRangeEnd = 130371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_TryUpdateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x0015F618 File Offset: 0x0015D818
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130397, RefRangeEnd = 130400, XrefRangeStart = 130371, XrefRangeEnd = 130397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x0015F64C File Offset: 0x0015D84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130400, XrefRangeEnd = 130405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnUpdateFund()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x0015F68C File Offset: 0x0015D88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130421, RefRangeEnd = 130422, XrefRangeStart = 130405, XrefRangeEnd = 130421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlags(int flagNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flagNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_SetFlags_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x0015F6CC File Offset: 0x0015D8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130422, XrefRangeEnd = 130424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlandreNum(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_SetFlandreNum_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x0015F70C File Offset: 0x0015D90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130460, RefRangeEnd = 130461, XrefRangeStart = 130424, XrefRangeEnd = 130460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerFlandre.FlandreBossHPContext SpawnBossHpContext(DLC4_FlandreEnemyCharacterController flandreEnemyCharacterController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(flandreEnemyCharacterController);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_SpawnBossHpContext_Public_FlandreBossHPContext_DLC4_FlandreEnemyCharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new IncomeControllerFlandre.FlandreBossHPContext(pointer);
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x0015F754 File Offset: 0x0015D954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130475, RefRangeEnd = 130476, XrefRangeStart = 130461, XrefRangeEnd = 130475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBossDie(IncomeControllerFlandre.FlandreBossHPContext flandreBossHpContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(flandreBossHpContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_OnBossDie_Public_Void_FlandreBossHPContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x0015F79C File Offset: 0x0015D99C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 39348, RefRangeEnd = 39360, XrefRangeStart = 39348, XrefRangeEnd = 39360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPPoint(int currentPPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentPPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_SetPPoint_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x0015F7DC File Offset: 0x0015D9DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130477, RefRangeEnd = 130478, XrefRangeStart = 130476, XrefRangeEnd = 130477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateVisualInIndicatorBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_TryUpdateVisualInIndicatorBegin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x0015F810 File Offset: 0x0015DA10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130480, RefRangeEnd = 130481, XrefRangeStart = 130478, XrefRangeEnd = 130480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateVisualInIndicatorAfter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_TryUpdateVisualInIndicatorAfter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x0015F844 File Offset: 0x0015DA44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130483, RefRangeEnd = 130484, XrefRangeStart = 130481, XrefRangeEnd = 130483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCoolDown(int poolId, float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref poolId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_SetCoolDown_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x0015F890 File Offset: 0x0015DA90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130492, RefRangeEnd = 130494, XrefRangeStart = 130484, XrefRangeEnd = 130492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PatchouliMagicStartCoolDown(bool showEndVFX, bool lastCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showEndVFX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastCard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_PatchouliMagicStartCoolDown_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x0015F8DC File Offset: 0x0015DADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130512, RefRangeEnd = 130513, XrefRangeStart = 130494, XrefRangeEnd = 130512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMagicProgress(float newProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr_SetMagicProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x0015F91C File Offset: 0x0015DB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130513, XrefRangeEnd = 130541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerFlandre.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x0015F958 File Offset: 0x0015DB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130541, XrefRangeEnd = 130564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerFlandre() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x0015F994 File Offset: 0x0015DB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130564, XrefRangeEnd = 130566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__33_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr__UpdateVisual_b__33_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x0015F9D4 File Offset: 0x0015DBD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130568, RefRangeEnd = 130571, XrefRangeStart = 130566, XrefRangeEnd = 130568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__33_1(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr__UpdateVisual_b__33_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x0015FA14 File Offset: 0x0015DC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130571, XrefRangeEnd = 130573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__33_2(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.NativeMethodInfoPtr__UpdateVisual_b__33_2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x0001F4ED File Offset: 0x0001D6ED
		public IncomeControllerFlandre(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06003845 RID: 14405 RVA: 0x0015FA54 File Offset: 0x0015DC54
		// (set) Token: 0x06003846 RID: 14406 RVA: 0x0001F4F6 File Offset: 0x0001D6F6
		public unsafe static int CHANGE_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IncomeControllerFlandre.NativeFieldInfoPtr_CHANGE_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeControllerFlandre.NativeFieldInfoPtr_CHANGE_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06003847 RID: 14407 RVA: 0x0015FA70 File Offset: 0x0015DC70
		// (set) Token: 0x06003848 RID: 14408 RVA: 0x0001F504 File Offset: 0x0001D704
		public unsafe GameObject m_Flag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_Flag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_Flag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06003849 RID: 14409 RVA: 0x0015FAA0 File Offset: 0x0015DCA0
		// (set) Token: 0x0600384A RID: 14410 RVA: 0x0001F523 File Offset: 0x0001D723
		public unsafe RectTransform m_FlagContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_FlagContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_FlagContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x0600384B RID: 14411 RVA: 0x0015FAD0 File Offset: 0x0015DCD0
		// (set) Token: 0x0600384C RID: 14412 RVA: 0x0001F542 File Offset: 0x0001D742
		public unsafe Image progressBar1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_progressBar1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_progressBar1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x0600384D RID: 14413 RVA: 0x0015FB00 File Offset: 0x0015DD00
		// (set) Token: 0x0600384E RID: 14414 RVA: 0x0001F561 File Offset: 0x0001D761
		public unsafe Image progressBar2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_progressBar2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_progressBar2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x0600384F RID: 14415 RVA: 0x0015FB30 File Offset: 0x0015DD30
		// (set) Token: 0x06003850 RID: 14416 RVA: 0x0001F580 File Offset: 0x0001D780
		public unsafe Image timeBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_timeBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_timeBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x0015FB60 File Offset: 0x0015DD60
		// (set) Token: 0x06003852 RID: 14418 RVA: 0x0001F59F File Offset: 0x0001D79F
		public unsafe ComboController remainingFlandreNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_remainingFlandreNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComboController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_remainingFlandreNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06003853 RID: 14419 RVA: 0x0015FB90 File Offset: 0x0015DD90
		// (set) Token: 0x06003854 RID: 14420 RVA: 0x0001F5BE File Offset: 0x0001D7BE
		public unsafe TextMeshProUGUI progressLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_progressLiteral);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_progressLiteral), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x0015FBC0 File Offset: 0x0015DDC0
		// (set) Token: 0x06003856 RID: 14422 RVA: 0x0001F5DD File Offset: 0x0001D7DD
		public unsafe TextMeshProUGUI pPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_pPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_pPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06003857 RID: 14423 RVA: 0x0015FBF0 File Offset: 0x0015DDF0
		// (set) Token: 0x06003858 RID: 14424 RVA: 0x0001F5FC File Offset: 0x0001D7FC
		public unsafe GameObject m_FlandreHPContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_FlandreHPContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_FlandreHPContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06003859 RID: 14425 RVA: 0x0015FC20 File Offset: 0x0015DE20
		// (set) Token: 0x0600385A RID: 14426 RVA: 0x0001F61B File Offset: 0x0001D81B
		public unsafe Vector2 m_FlandreBossHpOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_FlandreBossHpOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_FlandreBossHpOffset)) = value;
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x0600385B RID: 14427 RVA: 0x0015FC48 File Offset: 0x0015DE48
		// (set) Token: 0x0600385C RID: 14428 RVA: 0x0001F636 File Offset: 0x0001D836
		public unsafe RectTransform m_WaitFlandreHPContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_WaitFlandreHPContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_WaitFlandreHPContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x0600385D RID: 14429 RVA: 0x0015FC78 File Offset: 0x0015DE78
		// (set) Token: 0x0600385E RID: 14430 RVA: 0x0001F655 File Offset: 0x0001D855
		public unsafe IncomeControllerFlandre_CardRechargeIndicator m_CardRechargeIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_CardRechargeIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerFlandre_CardRechargeIndicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_CardRechargeIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x0600385F RID: 14431 RVA: 0x0015FCA8 File Offset: 0x0015DEA8
		// (set) Token: 0x06003860 RID: 14432 RVA: 0x0001F674 File Offset: 0x0001D874
		public unsafe CanvasGroup m_MagicProgressCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicProgressCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicProgressCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06003861 RID: 14433 RVA: 0x0015FCD8 File Offset: 0x0015DED8
		// (set) Token: 0x06003862 RID: 14434 RVA: 0x0001F693 File Offset: 0x0001D893
		public unsafe Image m_MagicProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicProgress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicProgress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06003863 RID: 14435 RVA: 0x0015FD08 File Offset: 0x0015DF08
		// (set) Token: 0x06003864 RID: 14436 RVA: 0x0001F6B2 File Offset: 0x0001D8B2
		public unsafe GameObject m_MagicVFXObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicVFXObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicVFXObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x0015FD38 File Offset: 0x0015DF38
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x0001F6D1 File Offset: 0x0001D8D1
		public unsafe GameObject m_MagicEndVFXObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicEndVFXObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicEndVFXObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x0015FD68 File Offset: 0x0015DF68
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
		public unsafe RectTransform m_MagicPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x0015FD98 File Offset: 0x0015DF98
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x0001F70F File Offset: 0x0001D90F
		public unsafe Queue<CanvasGroup> flagCanvasGroupQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_flagCanvasGroupQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_flagCanvasGroupQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x0015FDC8 File Offset: 0x0015DFC8
		// (set) Token: 0x0600386C RID: 14444 RVA: 0x0001F72E File Offset: 0x0001D92E
		public unsafe List<IncomeControllerFlandre.FlandreBossHPContext> flandreBossHpContexts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_flandreBossHpContexts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IncomeControllerFlandre.FlandreBossHPContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_flandreBossHpContexts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x0600386D RID: 14445 RVA: 0x0015FDF8 File Offset: 0x0015DFF8
		// (set) Token: 0x0600386E RID: 14446 RVA: 0x0001F74D File Offset: 0x0001D94D
		public unsafe List<RechargeInfo> m_CardRechargeLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_CardRechargeLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RechargeInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_CardRechargeLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x0600386F RID: 14447 RVA: 0x0015FE28 File Offset: 0x0015E028
		// (set) Token: 0x06003870 RID: 14448 RVA: 0x0001F76C File Offset: 0x0001D96C
		public unsafe int currentProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_currentProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_currentProgress)) = value;
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06003871 RID: 14449 RVA: 0x0015FE50 File Offset: 0x0015E050
		// (set) Token: 0x06003872 RID: 14450 RVA: 0x0001F787 File Offset: 0x0001D987
		public unsafe ParticleSystem m_MagicEndVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicEndVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicEndVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06003873 RID: 14451 RVA: 0x0015FE80 File Offset: 0x0015E080
		// (set) Token: 0x06003874 RID: 14452 RVA: 0x0001F7A6 File Offset: 0x0001D9A6
		public unsafe ParticleSystem m_MagicVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_m_MagicVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06003875 RID: 14453 RVA: 0x0015FEB0 File Offset: 0x0015E0B0
		// (set) Token: 0x06003876 RID: 14454 RVA: 0x0001F7C5 File Offset: 0x0001D9C5
		public unsafe Coroutine onUpdatingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_onUpdatingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_onUpdatingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x0015FEE0 File Offset: 0x0015E0E0
		// (set) Token: 0x06003878 RID: 14456 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		public unsafe int targetProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_targetProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.NativeFieldInfoPtr_targetProgress)) = value;
			}
		}

		// Token: 0x040025E2 RID: 9698
		private static readonly IntPtr NativeFieldInfoPtr_CHANGE_AMOUNT;

		// Token: 0x040025E3 RID: 9699
		private static readonly IntPtr NativeFieldInfoPtr_m_Flag;

		// Token: 0x040025E4 RID: 9700
		private static readonly IntPtr NativeFieldInfoPtr_m_FlagContent;

		// Token: 0x040025E5 RID: 9701
		private static readonly IntPtr NativeFieldInfoPtr_progressBar1;

		// Token: 0x040025E6 RID: 9702
		private static readonly IntPtr NativeFieldInfoPtr_progressBar2;

		// Token: 0x040025E7 RID: 9703
		private static readonly IntPtr NativeFieldInfoPtr_timeBar;

		// Token: 0x040025E8 RID: 9704
		private static readonly IntPtr NativeFieldInfoPtr_remainingFlandreNum;

		// Token: 0x040025E9 RID: 9705
		private static readonly IntPtr NativeFieldInfoPtr_progressLiteral;

		// Token: 0x040025EA RID: 9706
		private static readonly IntPtr NativeFieldInfoPtr_pPoint;

		// Token: 0x040025EB RID: 9707
		private static readonly IntPtr NativeFieldInfoPtr_m_FlandreHPContext;

		// Token: 0x040025EC RID: 9708
		private static readonly IntPtr NativeFieldInfoPtr_m_FlandreBossHpOffset;

		// Token: 0x040025ED RID: 9709
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitFlandreHPContent;

		// Token: 0x040025EE RID: 9710
		private static readonly IntPtr NativeFieldInfoPtr_m_CardRechargeIndicator;

		// Token: 0x040025EF RID: 9711
		private static readonly IntPtr NativeFieldInfoPtr_m_MagicProgressCanvasGroup;

		// Token: 0x040025F0 RID: 9712
		private static readonly IntPtr NativeFieldInfoPtr_m_MagicProgress;

		// Token: 0x040025F1 RID: 9713
		private static readonly IntPtr NativeFieldInfoPtr_m_MagicVFXObject;

		// Token: 0x040025F2 RID: 9714
		private static readonly IntPtr NativeFieldInfoPtr_m_MagicEndVFXObject;

		// Token: 0x040025F3 RID: 9715
		private static readonly IntPtr NativeFieldInfoPtr_m_MagicPosition;

		// Token: 0x040025F4 RID: 9716
		private static readonly IntPtr NativeFieldInfoPtr_flagCanvasGroupQueue;

		// Token: 0x040025F5 RID: 9717
		private static readonly IntPtr NativeFieldInfoPtr_flandreBossHpContexts;

		// Token: 0x040025F6 RID: 9718
		private static readonly IntPtr NativeFieldInfoPtr_m_CardRechargeLists;

		// Token: 0x040025F7 RID: 9719
		private static readonly IntPtr NativeFieldInfoPtr_currentProgress;

		// Token: 0x040025F8 RID: 9720
		private static readonly IntPtr NativeFieldInfoPtr_m_MagicEndVFX;

		// Token: 0x040025F9 RID: 9721
		private static readonly IntPtr NativeFieldInfoPtr_m_MagicVFX;

		// Token: 0x040025FA RID: 9722
		private static readonly IntPtr NativeFieldInfoPtr_onUpdatingData;

		// Token: 0x040025FB RID: 9723
		private static readonly IntPtr NativeFieldInfoPtr_targetProgress;

		// Token: 0x040025FC RID: 9724
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x040025FD RID: 9725
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040025FE RID: 9726
		private static readonly IntPtr NativeMethodInfoPtr_SetManager_Public_Void_DLC4_BossBattleManager_0;

		// Token: 0x040025FF RID: 9727
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0;

		// Token: 0x04002600 RID: 9728
		private static readonly IntPtr NativeMethodInfoPtr_FinishBigWave_Public_Void_0;

		// Token: 0x04002601 RID: 9729
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_0;

		// Token: 0x04002602 RID: 9730
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateData_Private_Void_0;

		// Token: 0x04002603 RID: 9731
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x04002604 RID: 9732
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0;

		// Token: 0x04002605 RID: 9733
		private static readonly IntPtr NativeMethodInfoPtr_SetFlags_Public_Void_Int32_0;

		// Token: 0x04002606 RID: 9734
		private static readonly IntPtr NativeMethodInfoPtr_SetFlandreNum_Public_Void_Int32_0;

		// Token: 0x04002607 RID: 9735
		private static readonly IntPtr NativeMethodInfoPtr_SpawnBossHpContext_Public_FlandreBossHPContext_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x04002608 RID: 9736
		private static readonly IntPtr NativeMethodInfoPtr_OnBossDie_Public_Void_FlandreBossHPContext_0;

		// Token: 0x04002609 RID: 9737
		private static readonly IntPtr NativeMethodInfoPtr_SetPPoint_Public_Void_Int32_0;

		// Token: 0x0400260A RID: 9738
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateVisualInIndicatorBegin_Public_Void_0;

		// Token: 0x0400260B RID: 9739
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateVisualInIndicatorAfter_Public_Void_0;

		// Token: 0x0400260C RID: 9740
		private static readonly IntPtr NativeMethodInfoPtr_SetCoolDown_Public_Void_Int32_Single_0;

		// Token: 0x0400260D RID: 9741
		private static readonly IntPtr NativeMethodInfoPtr_PatchouliMagicStartCoolDown_Public_Void_Boolean_Boolean_0;

		// Token: 0x0400260E RID: 9742
		private static readonly IntPtr NativeMethodInfoPtr_SetMagicProgress_Public_Void_Single_0;

		// Token: 0x0400260F RID: 9743
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04002610 RID: 9744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002611 RID: 9745
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__33_0_Private_Void_Single_0;

		// Token: 0x04002612 RID: 9746
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__33_1_Private_Void_Single_0;

		// Token: 0x04002613 RID: 9747
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__33_2_Private_Void_Single_0;

		// Token: 0x0200093B RID: 2363
		public sealed class FlandreBossHPContext : ValueType
		{
			// Token: 0x0600B98F RID: 47503 RVA: 0x002ED834 File Offset: 0x002EBA34
			// Note: this type is marked as 'beforefieldinit'.
			static FlandreBossHPContext()
			{
				Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "FlandreBossHPContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr);
				IncomeControllerFlandre.FlandreBossHPContext.NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, "cluster");
				IncomeControllerFlandre.FlandreBossHPContext.NativeMethodInfoPtr_get_ContextObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, 100673924);
				IncomeControllerFlandre.FlandreBossHPContext.NativeMethodInfoPtr__ctor_Public_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, 100673925);
				IncomeControllerFlandre.FlandreBossHPContext.NativeMethodInfoPtr_SetHP_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, 100673926);
				IncomeControllerFlandre.FlandreBossHPContext.NativeMethodInfoPtr_OnBossDie_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, 100673927);
				IncomeControllerFlandre.FlandreBossHPContext.NativeMethodInfoPtr_OnBossSpawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, 100673928);
			}

			// Token: 0x17003CCA RID: 15562
			// (get) Token: 0x0600B990 RID: 47504 RVA: 0x002ED8D8 File Offset: 0x002EBAD8
			public unsafe GameObject ContextObject
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130184, XrefRangeEnd = 130186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.NativeMethodInfoPtr_get_ContextObject_Public_get_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
				}
			}

			// Token: 0x0600B991 RID: 47505 RVA: 0x002ED91C File Offset: 0x002EBB1C
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 2767, RefRangeEnd = 2776, XrefRangeStart = 2767, XrefRangeEnd = 2776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FlandreBossHPContext(UIElementCluster cluster) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.NativeMethodInfoPtr__ctor_Public_Void_UIElementCluster_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B992 RID: 47506 RVA: 0x002ED96C File Offset: 0x002EBB6C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 130200, RefRangeEnd = 130201, XrefRangeStart = 130186, XrefRangeEnd = 130200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetHP(float currentProgress)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentProgress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.NativeMethodInfoPtr_SetHP_Public_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B993 RID: 47507 RVA: 0x002ED9B0 File Offset: 0x002EBBB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 130214, RefRangeEnd = 130215, XrefRangeStart = 130201, XrefRangeEnd = 130214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnBossDie(Action onFinish)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.NativeMethodInfoPtr_OnBossDie_Public_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B994 RID: 47508 RVA: 0x002ED9F8 File Offset: 0x002EBBF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130215, XrefRangeEnd = 130220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnBossSpawn()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.NativeMethodInfoPtr_OnBossSpawn_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B995 RID: 47509 RVA: 0x000642C2 File Offset: 0x000624C2
			public FlandreBossHPContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B996 RID: 47510 RVA: 0x000642CB File Offset: 0x000624CB
			public FlandreBossHPContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr))
			{
			}

			// Token: 0x17003CC9 RID: 15561
			// (get) Token: 0x0600B997 RID: 47511 RVA: 0x002EDA30 File Offset: 0x002EBC30
			// (set) Token: 0x0600B998 RID: 47512 RVA: 0x000642DD File Offset: 0x000624DD
			public unsafe UIElementCluster cluster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.FlandreBossHPContext.NativeFieldInfoPtr_cluster);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.FlandreBossHPContext.NativeFieldInfoPtr_cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077E9 RID: 30697
			private static readonly IntPtr NativeFieldInfoPtr_cluster;

			// Token: 0x040077EA RID: 30698
			private static readonly IntPtr NativeMethodInfoPtr_get_ContextObject_Public_get_GameObject_0;

			// Token: 0x040077EB RID: 30699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIElementCluster_0;

			// Token: 0x040077EC RID: 30700
			private static readonly IntPtr NativeMethodInfoPtr_SetHP_Public_Void_Single_0;

			// Token: 0x040077ED RID: 30701
			private static readonly IntPtr NativeMethodInfoPtr_OnBossDie_Public_Void_Action_0;

			// Token: 0x040077EE RID: 30702
			private static readonly IntPtr NativeMethodInfoPtr_OnBossSpawn_Public_Void_0;

			// Token: 0x02000FFB RID: 4091
			[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerFlandre+FlandreBossHPContext+<>c__DisplayClass4_0")]
			public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
			{
				// Token: 0x06011877 RID: 71799 RVA: 0x004062F0 File Offset: 0x004044F0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass4_0()
				{
					Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, "<>c__DisplayClass4_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0>.NativeClassPtr);
					IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0.NativeFieldInfoPtr_currentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0>.NativeClassPtr, "currentProgress");
					IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0>.NativeClassPtr, 100673929);
					IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0.NativeMethodInfoPtr__SetHP_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0>.NativeClassPtr, 100673930);
				}

				// Token: 0x06011878 RID: 71800 RVA: 0x00406358 File Offset: 0x00404558
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011879 RID: 71801 RVA: 0x00406394 File Offset: 0x00404594
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130168, XrefRangeEnd = 130181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _SetHP_b__0(Image image)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0.NativeMethodInfoPtr__SetHP_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601187A RID: 71802 RVA: 0x00098787 File Offset: 0x00096987
				public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B2B RID: 23339
				// (get) Token: 0x0601187B RID: 71803 RVA: 0x004063D8 File Offset: 0x004045D8
				// (set) Token: 0x0601187C RID: 71804 RVA: 0x00098790 File Offset: 0x00096990
				public unsafe float currentProgress
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0.NativeFieldInfoPtr_currentProgress);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_0.NativeFieldInfoPtr_currentProgress)) = value;
					}
				}

				// Token: 0x0400B133 RID: 45363
				private static readonly IntPtr NativeFieldInfoPtr_currentProgress;

				// Token: 0x0400B134 RID: 45364
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B135 RID: 45365
				private static readonly IntPtr NativeMethodInfoPtr__SetHP_b__0_Internal_Void_Image_0;
			}

			// Token: 0x02000FFC RID: 4092
			[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerFlandre+FlandreBossHPContext+<>c__DisplayClass4_1")]
			public sealed class __c__DisplayClass4_1 : Il2CppSystem.Object
			{
				// Token: 0x0601187D RID: 71805 RVA: 0x00406400 File Offset: 0x00404600
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass4_1()
				{
					Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, "<>c__DisplayClass4_1");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1>.NativeClassPtr);
					IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1>.NativeClassPtr, "image");
					IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1>.NativeClassPtr, 100673931);
					IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1.NativeMethodInfoPtr__SetHP_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1>.NativeClassPtr, 100673932);
				}

				// Token: 0x0601187E RID: 71806 RVA: 0x00406468 File Offset: 0x00404668
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass4_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601187F RID: 71807 RVA: 0x004064A4 File Offset: 0x004046A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130181, XrefRangeEnd = 130183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _SetHP_b__1(float x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1.NativeMethodInfoPtr__SetHP_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011880 RID: 71808 RVA: 0x000987AB File Offset: 0x000969AB
				public __c__DisplayClass4_1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B2C RID: 23340
				// (get) Token: 0x06011881 RID: 71809 RVA: 0x004064E4 File Offset: 0x004046E4
				// (set) Token: 0x06011882 RID: 71810 RVA: 0x000987B4 File Offset: 0x000969B4
				public unsafe Image image
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1.NativeFieldInfoPtr_image);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass4_1.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B136 RID: 45366
				private static readonly IntPtr NativeFieldInfoPtr_image;

				// Token: 0x0400B137 RID: 45367
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B138 RID: 45368
				private static readonly IntPtr NativeMethodInfoPtr__SetHP_b__1_Internal_Void_Single_0;
			}

			// Token: 0x02000FFD RID: 4093
			[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerFlandre+FlandreBossHPContext+<>c__DisplayClass5_0")]
			public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
			{
				// Token: 0x06011883 RID: 71811 RVA: 0x00406514 File Offset: 0x00404714
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass5_0()
				{
					Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, "<>c__DisplayClass5_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0>.NativeClassPtr);
					IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0>.NativeClassPtr, "onFinish");
					IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0>.NativeClassPtr, 100673933);
					IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0.NativeMethodInfoPtr__OnBossDie_b__0_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0>.NativeClassPtr, 100673934);
				}

				// Token: 0x06011884 RID: 71812 RVA: 0x0040657C File Offset: 0x0040477C
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011885 RID: 71813 RVA: 0x004065B8 File Offset: 0x004047B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130183, XrefRangeEnd = 130184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _OnBossDie_b__0(CanvasGroup x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0.NativeMethodInfoPtr__OnBossDie_b__0_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011886 RID: 71814 RVA: 0x000987D3 File Offset: 0x000969D3
				public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B2D RID: 23341
				// (get) Token: 0x06011887 RID: 71815 RVA: 0x004065FC File Offset: 0x004047FC
				// (set) Token: 0x06011888 RID: 71816 RVA: 0x000987DC File Offset: 0x000969DC
				public unsafe Action onFinish
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0.NativeFieldInfoPtr_onFinish);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.FlandreBossHPContext.__c__DisplayClass5_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B139 RID: 45369
				private static readonly IntPtr NativeFieldInfoPtr_onFinish;

				// Token: 0x0400B13A RID: 45370
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B13B RID: 45371
				private static readonly IntPtr NativeMethodInfoPtr__OnBossDie_b__0_Internal_Void_CanvasGroup_0;
			}
		}

		// Token: 0x0200093C RID: 2364
		[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerFlandre+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B999 RID: 47513 RVA: 0x002EDA60 File Offset: 0x002EBC60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IncomeControllerFlandre.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre.__c>.NativeClassPtr);
				IncomeControllerFlandre.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre.__c>.NativeClassPtr, "<>9");
				IncomeControllerFlandre.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre.__c>.NativeClassPtr, "<>9__27_0");
				IncomeControllerFlandre.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.__c>.NativeClassPtr, 100673936);
				IncomeControllerFlandre.__c.NativeMethodInfoPtr__Initialize_b__27_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.__c>.NativeClassPtr, 100673937);
			}

			// Token: 0x0600B99A RID: 47514 RVA: 0x002EDADC File Offset: 0x002EBCDC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B99B RID: 47515 RVA: 0x002EDB18 File Offset: 0x002EBD18
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__27_0(int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.__c.NativeMethodInfoPtr__Initialize_b__27_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B99C RID: 47516 RVA: 0x000642FC File Offset: 0x000624FC
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CCB RID: 15563
			// (get) Token: 0x0600B99D RID: 47517 RVA: 0x002EDB58 File Offset: 0x002EBD58
			// (set) Token: 0x0600B99E RID: 47518 RVA: 0x00064305 File Offset: 0x00062505
			public unsafe static IncomeControllerFlandre.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerFlandre.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerFlandre.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerFlandre.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CCC RID: 15564
			// (get) Token: 0x0600B99F RID: 47519 RVA: 0x002EDB80 File Offset: 0x002EBD80
			// (set) Token: 0x0600B9A0 RID: 47520 RVA: 0x00064317 File Offset: 0x00062517
			public unsafe static Action<int> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerFlandre.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerFlandre.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077EF RID: 30703
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040077F0 RID: 30704
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x040077F1 RID: 30705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040077F2 RID: 30706
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__27_0_Internal_Void_Int32_0;
		}

		// Token: 0x0200093D RID: 2365
		[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerFlandre+<OnUpdateFund>d__34")]
		public sealed class _OnUpdateFund_d__34 : Il2CppSystem.Object
		{
			// Token: 0x0600B9A1 RID: 47521 RVA: 0x002EDBA8 File Offset: 0x002EBDA8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnUpdateFund_d__34()
			{
				Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "<OnUpdateFund>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr);
				IncomeControllerFlandre._OnUpdateFund_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr, "<>1__state");
				IncomeControllerFlandre._OnUpdateFund_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr, "<>2__current");
				IncomeControllerFlandre._OnUpdateFund_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr, "<>4__this");
				IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr, 100673938);
				IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr, 100673939);
				IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr, 100673940);
				IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr, 100673941);
				IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr, 100673942);
				IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr, 100673943);
			}

			// Token: 0x0600B9A2 RID: 47522 RVA: 0x002EDC88 File Offset: 0x002EBE88
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnUpdateFund_d__34(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre._OnUpdateFund_d__34>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9A3 RID: 47523 RVA: 0x002EDCD0 File Offset: 0x002EBED0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9A4 RID: 47524 RVA: 0x002EDD04 File Offset: 0x002EBF04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130220, XrefRangeEnd = 130223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003CD0 RID: 15568
			// (get) Token: 0x0600B9A5 RID: 47525 RVA: 0x002EDD40 File Offset: 0x002EBF40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9A6 RID: 47526 RVA: 0x002EDD80 File Offset: 0x002EBF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130223, XrefRangeEnd = 130229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003CD1 RID: 15569
			// (get) Token: 0x0600B9A7 RID: 47527 RVA: 0x002EDDB4 File Offset: 0x002EBFB4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre._OnUpdateFund_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9A8 RID: 47528 RVA: 0x00064329 File Offset: 0x00062529
			public _OnUpdateFund_d__34(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CCD RID: 15565
			// (get) Token: 0x0600B9A9 RID: 47529 RVA: 0x002EDDF4 File Offset: 0x002EBFF4
			// (set) Token: 0x0600B9AA RID: 47530 RVA: 0x00064332 File Offset: 0x00062532
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre._OnUpdateFund_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre._OnUpdateFund_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CCE RID: 15566
			// (get) Token: 0x0600B9AB RID: 47531 RVA: 0x002EDE1C File Offset: 0x002EC01C
			// (set) Token: 0x0600B9AC RID: 47532 RVA: 0x0006434D File Offset: 0x0006254D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre._OnUpdateFund_d__34.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre._OnUpdateFund_d__34.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CCF RID: 15567
			// (get) Token: 0x0600B9AD RID: 47533 RVA: 0x002EDE4C File Offset: 0x002EC04C
			// (set) Token: 0x0600B9AE RID: 47534 RVA: 0x0006436C File Offset: 0x0006256C
			public unsafe IncomeControllerFlandre __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre._OnUpdateFund_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerFlandre>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre._OnUpdateFund_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077F3 RID: 30707
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040077F4 RID: 30708
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040077F5 RID: 30709
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040077F6 RID: 30710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040077F7 RID: 30711
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040077F8 RID: 30712
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040077F9 RID: 30713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040077FA RID: 30714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040077FB RID: 30715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200093E RID: 2366
		[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerFlandre+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B9AF RID: 47535 RVA: 0x002EDE7C File Offset: 0x002EC07C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass38_0>.NativeClassPtr);
				IncomeControllerFlandre.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				IncomeControllerFlandre.__c__DisplayClass38_0.NativeFieldInfoPtr_flandreBossHpContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass38_0>.NativeClassPtr, "flandreBossHpContext");
				IncomeControllerFlandre.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass38_0>.NativeClassPtr, 100673944);
				IncomeControllerFlandre.__c__DisplayClass38_0.NativeMethodInfoPtr__OnBossDie_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass38_0>.NativeClassPtr, 100673945);
			}

			// Token: 0x0600B9B0 RID: 47536 RVA: 0x002EDEF8 File Offset: 0x002EC0F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9B1 RID: 47537 RVA: 0x002EDF34 File Offset: 0x002EC134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130229, XrefRangeEnd = 130238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBossDie_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.__c__DisplayClass38_0.NativeMethodInfoPtr__OnBossDie_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9B2 RID: 47538 RVA: 0x0006438B File Offset: 0x0006258B
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD2 RID: 15570
			// (get) Token: 0x0600B9B3 RID: 47539 RVA: 0x002EDF68 File Offset: 0x002EC168
			// (set) Token: 0x0600B9B4 RID: 47540 RVA: 0x00064394 File Offset: 0x00062594
			public unsafe IncomeControllerFlandre __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerFlandre>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CD3 RID: 15571
			// (get) Token: 0x0600B9B5 RID: 47541 RVA: 0x002EDF98 File Offset: 0x002EC198
			// (set) Token: 0x0600B9B6 RID: 47542 RVA: 0x000643B3 File Offset: 0x000625B3
			public IncomeControllerFlandre.FlandreBossHPContext flandreBossHpContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.__c__DisplayClass38_0.NativeFieldInfoPtr_flandreBossHpContext);
					return new IncomeControllerFlandre.FlandreBossHPContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.__c__DisplayClass38_0.NativeFieldInfoPtr_flandreBossHpContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IncomeControllerFlandre.FlandreBossHPContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040077FC RID: 30716
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040077FD RID: 30717
			private static readonly IntPtr NativeFieldInfoPtr_flandreBossHpContext;

			// Token: 0x040077FE RID: 30718
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040077FF RID: 30719
			private static readonly IntPtr NativeMethodInfoPtr__OnBossDie_b__0_Internal_Void_0;
		}

		// Token: 0x0200093F RID: 2367
		[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerFlandre+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B9B7 RID: 47543 RVA: 0x002EDFC8 File Offset: 0x002EC1C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerFlandre>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass44_0>.NativeClassPtr);
				IncomeControllerFlandre.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass44_0>.NativeClassPtr, "<>4__this");
				IncomeControllerFlandre.__c__DisplayClass44_0.NativeFieldInfoPtr_newProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass44_0>.NativeClassPtr, "newProgress");
				IncomeControllerFlandre.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass44_0>.NativeClassPtr, 100673946);
				IncomeControllerFlandre.__c__DisplayClass44_0.NativeMethodInfoPtr__SetMagicProgress_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass44_0>.NativeClassPtr, 100673947);
				IncomeControllerFlandre.__c__DisplayClass44_0.NativeMethodInfoPtr__SetMagicProgress_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass44_0>.NativeClassPtr, 100673948);
			}

			// Token: 0x0600B9B8 RID: 47544 RVA: 0x002EE058 File Offset: 0x002EC258
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9B9 RID: 47545 RVA: 0x002EE094 File Offset: 0x002EC294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130238, XrefRangeEnd = 130240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetMagicProgress_b__0(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.__c__DisplayClass44_0.NativeMethodInfoPtr__SetMagicProgress_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9BA RID: 47546 RVA: 0x002EE0D4 File Offset: 0x002EC2D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130240, XrefRangeEnd = 130242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetMagicProgress_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre.__c__DisplayClass44_0.NativeMethodInfoPtr__SetMagicProgress_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9BB RID: 47547 RVA: 0x000643E1 File Offset: 0x000625E1
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD4 RID: 15572
			// (get) Token: 0x0600B9BC RID: 47548 RVA: 0x002EE108 File Offset: 0x002EC308
			// (set) Token: 0x0600B9BD RID: 47549 RVA: 0x000643EA File Offset: 0x000625EA
			public unsafe IncomeControllerFlandre __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerFlandre>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CD5 RID: 15573
			// (get) Token: 0x0600B9BE RID: 47550 RVA: 0x002EE138 File Offset: 0x002EC338
			// (set) Token: 0x0600B9BF RID: 47551 RVA: 0x00064409 File Offset: 0x00062609
			public unsafe float newProgress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.__c__DisplayClass44_0.NativeFieldInfoPtr_newProgress);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre.__c__DisplayClass44_0.NativeFieldInfoPtr_newProgress)) = value;
				}
			}

			// Token: 0x04007800 RID: 30720
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007801 RID: 30721
			private static readonly IntPtr NativeFieldInfoPtr_newProgress;

			// Token: 0x04007802 RID: 30722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007803 RID: 30723
			private static readonly IntPtr NativeMethodInfoPtr__SetMagicProgress_b__0_Internal_Void_Single_0;

			// Token: 0x04007804 RID: 30724
			private static readonly IntPtr NativeMethodInfoPtr__SetMagicProgress_b__1_Internal_Void_0;
		}
	}
}
