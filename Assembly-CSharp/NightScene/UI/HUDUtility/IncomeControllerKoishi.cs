using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001C7 RID: 455
	public class IncomeControllerKoishi : IncomeControllerBase
	{
		// Token: 0x0600389C RID: 14492 RVA: 0x001605C4 File Offset: 0x0015E7C4
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeControllerKoishi()
		{
			Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "IncomeControllerKoishi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr);
			IncomeControllerKoishi.NativeFieldInfoPtr_s_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "s_End");
			IncomeControllerKoishi.NativeFieldInfoPtr_s_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "s_Start");
			IncomeControllerKoishi.NativeFieldInfoPtr_CHANGE_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "CHANGE_AMOUNT");
			IncomeControllerKoishi.NativeFieldInfoPtr_progressBar1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "progressBar1");
			IncomeControllerKoishi.NativeFieldInfoPtr_progressBar2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "progressBar2");
			IncomeControllerKoishi.NativeFieldInfoPtr_timeBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "timeBar");
			IncomeControllerKoishi.NativeFieldInfoPtr_tagRefreshBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "tagRefreshBar");
			IncomeControllerKoishi.NativeFieldInfoPtr_text1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "text1");
			IncomeControllerKoishi.NativeFieldInfoPtr_progressLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "progressLiteral");
			IncomeControllerKoishi.NativeFieldInfoPtr_valueCurrent1or3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "valueCurrent1or3");
			IncomeControllerKoishi.NativeFieldInfoPtr_valueTotal1or3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "valueTotal1or3");
			IncomeControllerKoishi.NativeFieldInfoPtr_valueCurrent3ForBroken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "valueCurrent3ForBroken");
			IncomeControllerKoishi.NativeFieldInfoPtr_valueTotal3ForBroken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "valueTotal3ForBroken");
			IncomeControllerKoishi.NativeFieldInfoPtr_valueCurrent2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "valueCurrent2");
			IncomeControllerKoishi.NativeFieldInfoPtr_valueTotal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "valueTotal2");
			IncomeControllerKoishi.NativeFieldInfoPtr_bgPhase1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "bgPhase1");
			IncomeControllerKoishi.NativeFieldInfoPtr_bgPhase2or3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "bgPhase2or3");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase1TitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase1TitleColor");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase2TitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase2TitleColor");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase3TitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase3TitleColor");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase1ProgressLiteralColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase1ProgressLiteralColor");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase2ProgressLiteralColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase2ProgressLiteralColor");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase3ProgressLiteralColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase3ProgressLiteralColor");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase1Bar1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase1Bar1Color");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase1Bar2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase1Bar2Color");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase2Bar1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase2Bar1Color");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase2Bar2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase2Bar2Color");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase3Bar1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase3Bar1Color");
			IncomeControllerKoishi.NativeFieldInfoPtr_phase3Bar2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "phase3Bar2Color");
			IncomeControllerKoishi.NativeFieldInfoPtr_tag1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "tag1");
			IncomeControllerKoishi.NativeFieldInfoPtr_shieldMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "shieldMode");
			IncomeControllerKoishi.NativeFieldInfoPtr_brokenShieldMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "brokenShieldMode");
			IncomeControllerKoishi.NativeFieldInfoPtr_frenzyAnimatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "frenzyAnimatar");
			IncomeControllerKoishi.NativeFieldInfoPtr_currentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "currentProgress");
			IncomeControllerKoishi.NativeFieldInfoPtr_currentPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "currentPhase");
			IncomeControllerKoishi.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "maxValue");
			IncomeControllerKoishi.NativeFieldInfoPtr_onUpdatingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "onUpdatingData");
			IncomeControllerKoishi.NativeFieldInfoPtr_targetContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "targetContext");
			IncomeControllerKoishi.NativeFieldInfoPtr_targetProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "targetProgress");
			IncomeControllerKoishi.NativeMethodInfoPtr_SetText_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673965);
			IncomeControllerKoishi.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673966);
			IncomeControllerKoishi.NativeMethodInfoPtr_SetContext_Public_Void_String_Int32_Int32_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673967);
			IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673968);
			IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673969);
			IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetTagTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673970);
			IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetTagTimeImmediately_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673971);
			IncomeControllerKoishi.NativeMethodInfoPtr_IntoShieldMode_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673972);
			IncomeControllerKoishi.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673973);
			IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673974);
			IncomeControllerKoishi.NativeMethodInfoPtr_TryUpdateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673975);
			IncomeControllerKoishi.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673976);
			IncomeControllerKoishi.NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673977);
			IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetTag_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673978);
			IncomeControllerKoishi.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673979);
			IncomeControllerKoishi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673980);
			IncomeControllerKoishi.NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673982);
			IncomeControllerKoishi.NativeMethodInfoPtr__SetTargetTime_b__44_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673983);
			IncomeControllerKoishi.NativeMethodInfoPtr__SetTargetTagTime_b__45_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673984);
			IncomeControllerKoishi.NativeMethodInfoPtr__UpdateVisual_b__51_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673985);
			IncomeControllerKoishi.NativeMethodInfoPtr__UpdateVisual_b__51_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, 100673986);
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x00160AA4 File Offset: 0x0015ECA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130780, XrefRangeEnd = 130784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_SetText_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x00160AE8 File Offset: 0x0015ECE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130784, XrefRangeEnd = 130827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerKoishi.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x00160B24 File Offset: 0x0015ED24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130851, RefRangeEnd = 130854, XrefRangeStart = 130827, XrefRangeEnd = 130851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContext(string context, int currentValue, int maxValue, IncomeControllerKoishi.Phase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(context);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_SetContext_Public_Void_String_Int32_Int32_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00160B90 File Offset: 0x0015ED90
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 130863, RefRangeEnd = 130870, XrefRangeStart = 130854, XrefRangeEnd = 130863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetProgress(int targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x00160BD0 File Offset: 0x0015EDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130870, XrefRangeEnd = 130877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTime(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x00160C10 File Offset: 0x0015EE10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130884, RefRangeEnd = 130886, XrefRangeStart = 130877, XrefRangeEnd = 130884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTagTime(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetTagTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x00160C50 File Offset: 0x0015EE50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130568, RefRangeEnd = 130571, XrefRangeStart = 130568, XrefRangeEnd = 130571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTagTimeImmediately(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetTagTimeImmediately_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x00160C90 File Offset: 0x0015EE90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130902, RefRangeEnd = 130906, XrefRangeStart = 130886, XrefRangeEnd = 130902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntoShieldMode(bool broken, bool recover = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref broken;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recover;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_IntoShieldMode_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x00160CDC File Offset: 0x0015EEDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130906, RefRangeEnd = 130909, XrefRangeStart = 130906, XrefRangeEnd = 130906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x00160D1C File Offset: 0x0015EF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130909, XrefRangeEnd = 130916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetProgressImmediate(int targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x00160D5C File Offset: 0x0015EF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130916, XrefRangeEnd = 130925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_TryUpdateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x00160D90 File Offset: 0x0015EF90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130953, RefRangeEnd = 130958, XrefRangeStart = 130925, XrefRangeEnd = 130953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x00160DC4 File Offset: 0x0015EFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130958, XrefRangeEnd = 130963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnUpdateFund()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x00160E04 File Offset: 0x0015F004
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130976, RefRangeEnd = 130979, XrefRangeStart = 130963, XrefRangeEnd = 130976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTag(string tag1String, bool useEffect = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag1String);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useEffect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_SetTargetTag_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00160E54 File Offset: 0x0015F054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130979, XrefRangeEnd = 130999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerKoishi.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x00160E90 File Offset: 0x0015F090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130999, XrefRangeEnd = 131004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerKoishi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00160ECC File Offset: 0x0015F0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131004, XrefRangeEnd = 131015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Single_PDM_0(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x00160F0C File Offset: 0x0015F10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetTargetTime_b__44_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr__SetTargetTime_b__44_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x00160F4C File Offset: 0x0015F14C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130568, RefRangeEnd = 130571, XrefRangeStart = 130568, XrefRangeEnd = 130571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetTargetTagTime_b__45_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr__SetTargetTagTime_b__45_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x00160F8C File Offset: 0x0015F18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__51_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr__UpdateVisual_b__51_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x00160FCC File Offset: 0x0015F1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131015, XrefRangeEnd = 131017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__51_1(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi.NativeMethodInfoPtr__UpdateVisual_b__51_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x0001F950 File Offset: 0x0001DB50
		public IncomeControllerKoishi(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x060038B3 RID: 14515 RVA: 0x0016100C File Offset: 0x0015F20C
		// (set) Token: 0x060038B4 RID: 14516 RVA: 0x0001F959 File Offset: 0x0001DB59
		public unsafe static int s_End
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IncomeControllerKoishi.NativeFieldInfoPtr_s_End, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeControllerKoishi.NativeFieldInfoPtr_s_End, (void*)(&value));
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x00161028 File Offset: 0x0015F228
		// (set) Token: 0x060038B6 RID: 14518 RVA: 0x0001F967 File Offset: 0x0001DB67
		public unsafe static int s_Start
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IncomeControllerKoishi.NativeFieldInfoPtr_s_Start, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeControllerKoishi.NativeFieldInfoPtr_s_Start, (void*)(&value));
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x00161044 File Offset: 0x0015F244
		// (set) Token: 0x060038B8 RID: 14520 RVA: 0x0001F975 File Offset: 0x0001DB75
		public unsafe static int CHANGE_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IncomeControllerKoishi.NativeFieldInfoPtr_CHANGE_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeControllerKoishi.NativeFieldInfoPtr_CHANGE_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x00161060 File Offset: 0x0015F260
		// (set) Token: 0x060038BA RID: 14522 RVA: 0x0001F983 File Offset: 0x0001DB83
		public unsafe Image progressBar1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_progressBar1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_progressBar1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x060038BB RID: 14523 RVA: 0x00161090 File Offset: 0x0015F290
		// (set) Token: 0x060038BC RID: 14524 RVA: 0x0001F9A2 File Offset: 0x0001DBA2
		public unsafe Image progressBar2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_progressBar2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_progressBar2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x060038BD RID: 14525 RVA: 0x001610C0 File Offset: 0x0015F2C0
		// (set) Token: 0x060038BE RID: 14526 RVA: 0x0001F9C1 File Offset: 0x0001DBC1
		public unsafe Image timeBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_timeBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_timeBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x060038BF RID: 14527 RVA: 0x001610F0 File Offset: 0x0015F2F0
		// (set) Token: 0x060038C0 RID: 14528 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
		public unsafe Image tagRefreshBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_tagRefreshBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_tagRefreshBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x060038C1 RID: 14529 RVA: 0x00161120 File Offset: 0x0015F320
		// (set) Token: 0x060038C2 RID: 14530 RVA: 0x0001F9FF File Offset: 0x0001DBFF
		public unsafe TextMeshProUGUI text1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_text1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_text1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x060038C3 RID: 14531 RVA: 0x00161150 File Offset: 0x0015F350
		// (set) Token: 0x060038C4 RID: 14532 RVA: 0x0001FA1E File Offset: 0x0001DC1E
		public unsafe TextMeshProUGUI progressLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_progressLiteral);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_progressLiteral), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x060038C5 RID: 14533 RVA: 0x00161180 File Offset: 0x0015F380
		// (set) Token: 0x060038C6 RID: 14534 RVA: 0x0001FA3D File Offset: 0x0001DC3D
		public unsafe TextMeshProUGUI valueCurrent1or3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueCurrent1or3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueCurrent1or3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x060038C7 RID: 14535 RVA: 0x001611B0 File Offset: 0x0015F3B0
		// (set) Token: 0x060038C8 RID: 14536 RVA: 0x0001FA5C File Offset: 0x0001DC5C
		public unsafe TextMeshProUGUI valueTotal1or3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueTotal1or3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueTotal1or3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x001611E0 File Offset: 0x0015F3E0
		// (set) Token: 0x060038CA RID: 14538 RVA: 0x0001FA7B File Offset: 0x0001DC7B
		public unsafe TextMeshProUGUI valueCurrent3ForBroken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueCurrent3ForBroken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueCurrent3ForBroken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x00161210 File Offset: 0x0015F410
		// (set) Token: 0x060038CC RID: 14540 RVA: 0x0001FA9A File Offset: 0x0001DC9A
		public unsafe TextMeshProUGUI valueTotal3ForBroken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueTotal3ForBroken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueTotal3ForBroken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x060038CD RID: 14541 RVA: 0x00161240 File Offset: 0x0015F440
		// (set) Token: 0x060038CE RID: 14542 RVA: 0x0001FAB9 File Offset: 0x0001DCB9
		public unsafe TextMeshProUGUI valueCurrent2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueCurrent2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueCurrent2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x00161270 File Offset: 0x0015F470
		// (set) Token: 0x060038D0 RID: 14544 RVA: 0x0001FAD8 File Offset: 0x0001DCD8
		public unsafe TextMeshProUGUI valueTotal2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueTotal2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_valueTotal2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x001612A0 File Offset: 0x0015F4A0
		// (set) Token: 0x060038D2 RID: 14546 RVA: 0x0001FAF7 File Offset: 0x0001DCF7
		public unsafe CanvasGroup bgPhase1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_bgPhase1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_bgPhase1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x060038D3 RID: 14547 RVA: 0x001612D0 File Offset: 0x0015F4D0
		// (set) Token: 0x060038D4 RID: 14548 RVA: 0x0001FB16 File Offset: 0x0001DD16
		public unsafe CanvasGroup bgPhase2or3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_bgPhase2or3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_bgPhase2or3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x00161300 File Offset: 0x0015F500
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x0001FB35 File Offset: 0x0001DD35
		public unsafe Color32 phase1TitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase1TitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase1TitleColor)) = value;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x00161328 File Offset: 0x0015F528
		// (set) Token: 0x060038D8 RID: 14552 RVA: 0x0001FB50 File Offset: 0x0001DD50
		public unsafe Color32 phase2TitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase2TitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase2TitleColor)) = value;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x00161350 File Offset: 0x0015F550
		// (set) Token: 0x060038DA RID: 14554 RVA: 0x0001FB6B File Offset: 0x0001DD6B
		public unsafe Color32 phase3TitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase3TitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase3TitleColor)) = value;
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x00161378 File Offset: 0x0015F578
		// (set) Token: 0x060038DC RID: 14556 RVA: 0x0001FB86 File Offset: 0x0001DD86
		public unsafe Color32 phase1ProgressLiteralColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase1ProgressLiteralColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase1ProgressLiteralColor)) = value;
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x060038DD RID: 14557 RVA: 0x001613A0 File Offset: 0x0015F5A0
		// (set) Token: 0x060038DE RID: 14558 RVA: 0x0001FBA1 File Offset: 0x0001DDA1
		public unsafe Color32 phase2ProgressLiteralColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase2ProgressLiteralColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase2ProgressLiteralColor)) = value;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x001613C8 File Offset: 0x0015F5C8
		// (set) Token: 0x060038E0 RID: 14560 RVA: 0x0001FBBC File Offset: 0x0001DDBC
		public unsafe Color32 phase3ProgressLiteralColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase3ProgressLiteralColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase3ProgressLiteralColor)) = value;
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x001613F0 File Offset: 0x0015F5F0
		// (set) Token: 0x060038E2 RID: 14562 RVA: 0x0001FBD7 File Offset: 0x0001DDD7
		public unsafe Color32 phase1Bar1Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase1Bar1Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase1Bar1Color)) = value;
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x00161418 File Offset: 0x0015F618
		// (set) Token: 0x060038E4 RID: 14564 RVA: 0x0001FBF2 File Offset: 0x0001DDF2
		public unsafe Color32 phase1Bar2Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase1Bar2Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase1Bar2Color)) = value;
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x00161440 File Offset: 0x0015F640
		// (set) Token: 0x060038E6 RID: 14566 RVA: 0x0001FC0D File Offset: 0x0001DE0D
		public unsafe Color32 phase2Bar1Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase2Bar1Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase2Bar1Color)) = value;
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x00161468 File Offset: 0x0015F668
		// (set) Token: 0x060038E8 RID: 14568 RVA: 0x0001FC28 File Offset: 0x0001DE28
		public unsafe Color32 phase2Bar2Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase2Bar2Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase2Bar2Color)) = value;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x00161490 File Offset: 0x0015F690
		// (set) Token: 0x060038EA RID: 14570 RVA: 0x0001FC43 File Offset: 0x0001DE43
		public unsafe Color32 phase3Bar1Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase3Bar1Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase3Bar1Color)) = value;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x001614B8 File Offset: 0x0015F6B8
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x0001FC5E File Offset: 0x0001DE5E
		public unsafe Color32 phase3Bar2Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase3Bar2Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_phase3Bar2Color)) = value;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x001614E0 File Offset: 0x0015F6E0
		// (set) Token: 0x060038EE RID: 14574 RVA: 0x0001FC79 File Offset: 0x0001DE79
		public unsafe TextMeshProUGUI tag1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_tag1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_tag1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x00161510 File Offset: 0x0015F710
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x0001FC98 File Offset: 0x0001DE98
		public unsafe CanvasGroup shieldMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_shieldMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_shieldMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x00161540 File Offset: 0x0015F740
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x0001FCB7 File Offset: 0x0001DEB7
		public unsafe CanvasGroup brokenShieldMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_brokenShieldMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_brokenShieldMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x00161570 File Offset: 0x0015F770
		// (set) Token: 0x060038F4 RID: 14580 RVA: 0x0001FCD6 File Offset: 0x0001DED6
		public unsafe Animator frenzyAnimatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_frenzyAnimatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_frenzyAnimatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x001615A0 File Offset: 0x0015F7A0
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x0001FCF5 File Offset: 0x0001DEF5
		public unsafe int currentProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_currentProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_currentProgress)) = value;
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x001615C8 File Offset: 0x0015F7C8
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x0001FD10 File Offset: 0x0001DF10
		public unsafe IncomeControllerKoishi.Phase currentPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_currentPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_currentPhase)) = value;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x001615F0 File Offset: 0x0015F7F0
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x0001FD2B File Offset: 0x0001DF2B
		public unsafe int maxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_maxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_maxValue)) = value;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x00161618 File Offset: 0x0015F818
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x0001FD46 File Offset: 0x0001DF46
		public unsafe Coroutine onUpdatingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_onUpdatingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_onUpdatingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x00161648 File Offset: 0x0015F848
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x0001FD65 File Offset: 0x0001DF65
		public unsafe string targetContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_targetContext);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_targetContext), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x00161670 File Offset: 0x0015F870
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x0001FD84 File Offset: 0x0001DF84
		public unsafe int targetProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_targetProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi.NativeFieldInfoPtr_targetProgress)) = value;
			}
		}

		// Token: 0x0400262D RID: 9773
		private static readonly IntPtr NativeFieldInfoPtr_s_End;

		// Token: 0x0400262E RID: 9774
		private static readonly IntPtr NativeFieldInfoPtr_s_Start;

		// Token: 0x0400262F RID: 9775
		private static readonly IntPtr NativeFieldInfoPtr_CHANGE_AMOUNT;

		// Token: 0x04002630 RID: 9776
		private static readonly IntPtr NativeFieldInfoPtr_progressBar1;

		// Token: 0x04002631 RID: 9777
		private static readonly IntPtr NativeFieldInfoPtr_progressBar2;

		// Token: 0x04002632 RID: 9778
		private static readonly IntPtr NativeFieldInfoPtr_timeBar;

		// Token: 0x04002633 RID: 9779
		private static readonly IntPtr NativeFieldInfoPtr_tagRefreshBar;

		// Token: 0x04002634 RID: 9780
		private static readonly IntPtr NativeFieldInfoPtr_text1;

		// Token: 0x04002635 RID: 9781
		private static readonly IntPtr NativeFieldInfoPtr_progressLiteral;

		// Token: 0x04002636 RID: 9782
		private static readonly IntPtr NativeFieldInfoPtr_valueCurrent1or3;

		// Token: 0x04002637 RID: 9783
		private static readonly IntPtr NativeFieldInfoPtr_valueTotal1or3;

		// Token: 0x04002638 RID: 9784
		private static readonly IntPtr NativeFieldInfoPtr_valueCurrent3ForBroken;

		// Token: 0x04002639 RID: 9785
		private static readonly IntPtr NativeFieldInfoPtr_valueTotal3ForBroken;

		// Token: 0x0400263A RID: 9786
		private static readonly IntPtr NativeFieldInfoPtr_valueCurrent2;

		// Token: 0x0400263B RID: 9787
		private static readonly IntPtr NativeFieldInfoPtr_valueTotal2;

		// Token: 0x0400263C RID: 9788
		private static readonly IntPtr NativeFieldInfoPtr_bgPhase1;

		// Token: 0x0400263D RID: 9789
		private static readonly IntPtr NativeFieldInfoPtr_bgPhase2or3;

		// Token: 0x0400263E RID: 9790
		private static readonly IntPtr NativeFieldInfoPtr_phase1TitleColor;

		// Token: 0x0400263F RID: 9791
		private static readonly IntPtr NativeFieldInfoPtr_phase2TitleColor;

		// Token: 0x04002640 RID: 9792
		private static readonly IntPtr NativeFieldInfoPtr_phase3TitleColor;

		// Token: 0x04002641 RID: 9793
		private static readonly IntPtr NativeFieldInfoPtr_phase1ProgressLiteralColor;

		// Token: 0x04002642 RID: 9794
		private static readonly IntPtr NativeFieldInfoPtr_phase2ProgressLiteralColor;

		// Token: 0x04002643 RID: 9795
		private static readonly IntPtr NativeFieldInfoPtr_phase3ProgressLiteralColor;

		// Token: 0x04002644 RID: 9796
		private static readonly IntPtr NativeFieldInfoPtr_phase1Bar1Color;

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeFieldInfoPtr_phase1Bar2Color;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeFieldInfoPtr_phase2Bar1Color;

		// Token: 0x04002647 RID: 9799
		private static readonly IntPtr NativeFieldInfoPtr_phase2Bar2Color;

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeFieldInfoPtr_phase3Bar1Color;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeFieldInfoPtr_phase3Bar2Color;

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeFieldInfoPtr_tag1;

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeFieldInfoPtr_shieldMode;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeFieldInfoPtr_brokenShieldMode;

		// Token: 0x0400264D RID: 9805
		private static readonly IntPtr NativeFieldInfoPtr_frenzyAnimatar;

		// Token: 0x0400264E RID: 9806
		private static readonly IntPtr NativeFieldInfoPtr_currentProgress;

		// Token: 0x0400264F RID: 9807
		private static readonly IntPtr NativeFieldInfoPtr_currentPhase;

		// Token: 0x04002650 RID: 9808
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x04002651 RID: 9809
		private static readonly IntPtr NativeFieldInfoPtr_onUpdatingData;

		// Token: 0x04002652 RID: 9810
		private static readonly IntPtr NativeFieldInfoPtr_targetContext;

		// Token: 0x04002653 RID: 9811
		private static readonly IntPtr NativeFieldInfoPtr_targetProgress;

		// Token: 0x04002654 RID: 9812
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_String_0;

		// Token: 0x04002655 RID: 9813
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeMethodInfoPtr_SetContext_Public_Void_String_Int32_Int32_Phase_0;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTime_Public_Void_Single_0;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTagTime_Public_Void_Single_0;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTagTimeImmediately_Public_Void_Single_0;

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeMethodInfoPtr_IntoShieldMode_Public_Void_Boolean_Boolean_0;

		// Token: 0x0400265C RID: 9820
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x0400265D RID: 9821
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_0;

		// Token: 0x0400265E RID: 9822
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateData_Private_Void_0;

		// Token: 0x0400265F RID: 9823
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x04002660 RID: 9824
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0;

		// Token: 0x04002661 RID: 9825
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTag_Public_Void_String_Boolean_0;

		// Token: 0x04002662 RID: 9826
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04002663 RID: 9827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002664 RID: 9828
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0;

		// Token: 0x04002665 RID: 9829
		private static readonly IntPtr NativeMethodInfoPtr__SetTargetTime_b__44_0_Private_Void_Single_0;

		// Token: 0x04002666 RID: 9830
		private static readonly IntPtr NativeMethodInfoPtr__SetTargetTagTime_b__45_0_Private_Void_Single_0;

		// Token: 0x04002667 RID: 9831
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__51_0_Private_Void_Single_0;

		// Token: 0x04002668 RID: 9832
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__51_1_Private_Void_Single_0;

		// Token: 0x02000942 RID: 2370
		public enum Phase : byte
		{
			// Token: 0x0400780D RID: 30733
			Phase1,
			// Token: 0x0400780E RID: 30734
			Phase2,
			// Token: 0x0400780F RID: 30735
			Phase3
		}

		// Token: 0x02000943 RID: 2371
		[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerKoishi+<OnUpdateFund>d__52")]
		public sealed class _OnUpdateFund_d__52 : Il2CppSystem.Object
		{
			// Token: 0x0600B9CE RID: 47566 RVA: 0x002EE3C0 File Offset: 0x002EC5C0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnUpdateFund_d__52()
			{
				Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerKoishi>.NativeClassPtr, "<OnUpdateFund>d__52");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr);
				IncomeControllerKoishi._OnUpdateFund_d__52.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr, "<>1__state");
				IncomeControllerKoishi._OnUpdateFund_d__52.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr, "<>2__current");
				IncomeControllerKoishi._OnUpdateFund_d__52.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr, "<>4__this");
				IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr, 100673987);
				IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr, 100673988);
				IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr, 100673989);
				IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr, 100673990);
				IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr, 100673991);
				IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr, 100673992);
			}

			// Token: 0x0600B9CF RID: 47567 RVA: 0x002EE4A0 File Offset: 0x002EC6A0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnUpdateFund_d__52(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerKoishi._OnUpdateFund_d__52>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9D0 RID: 47568 RVA: 0x002EE4E8 File Offset: 0x002EC6E8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9D1 RID: 47569 RVA: 0x002EE51C File Offset: 0x002EC71C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130771, XrefRangeEnd = 130774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003CDC RID: 15580
			// (get) Token: 0x0600B9D2 RID: 47570 RVA: 0x002EE558 File Offset: 0x002EC758
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9D3 RID: 47571 RVA: 0x002EE598 File Offset: 0x002EC798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130774, XrefRangeEnd = 130780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003CDD RID: 15581
			// (get) Token: 0x0600B9D4 RID: 47572 RVA: 0x002EE5CC File Offset: 0x002EC7CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerKoishi._OnUpdateFund_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9D5 RID: 47573 RVA: 0x00064488 File Offset: 0x00062688
			public _OnUpdateFund_d__52(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD9 RID: 15577
			// (get) Token: 0x0600B9D6 RID: 47574 RVA: 0x002EE60C File Offset: 0x002EC80C
			// (set) Token: 0x0600B9D7 RID: 47575 RVA: 0x00064491 File Offset: 0x00062691
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi._OnUpdateFund_d__52.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi._OnUpdateFund_d__52.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CDA RID: 15578
			// (get) Token: 0x0600B9D8 RID: 47576 RVA: 0x002EE634 File Offset: 0x002EC834
			// (set) Token: 0x0600B9D9 RID: 47577 RVA: 0x000644AC File Offset: 0x000626AC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi._OnUpdateFund_d__52.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi._OnUpdateFund_d__52.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CDB RID: 15579
			// (get) Token: 0x0600B9DA RID: 47578 RVA: 0x002EE664 File Offset: 0x002EC864
			// (set) Token: 0x0600B9DB RID: 47579 RVA: 0x000644CB File Offset: 0x000626CB
			public unsafe IncomeControllerKoishi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi._OnUpdateFund_d__52.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerKoishi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerKoishi._OnUpdateFund_d__52.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007810 RID: 30736
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007811 RID: 30737
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007812 RID: 30738
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007813 RID: 30739
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007814 RID: 30740
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007815 RID: 30741
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007816 RID: 30742
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007817 RID: 30743
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007818 RID: 30744
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
