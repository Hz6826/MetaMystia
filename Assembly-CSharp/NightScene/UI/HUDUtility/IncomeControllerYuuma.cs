using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001C9 RID: 457
	public class IncomeControllerYuuma : IncomeControllerBase
	{
		// Token: 0x06003914 RID: 14612 RVA: 0x001619EC File Offset: 0x0015FBEC
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeControllerYuuma()
		{
			Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "IncomeControllerYuuma");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr);
			IncomeControllerYuuma.NativeFieldInfoPtr_CHANGE_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "CHANGE_AMOUNT");
			IncomeControllerYuuma.NativeFieldInfoPtr_ANGER_CHANGE_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "ANGER_CHANGE_AMOUNT");
			IncomeControllerYuuma.NativeFieldInfoPtr_ANGER_DECREASE_CHANGE_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "ANGER_DECREASE_CHANGE_AMOUNT");
			IncomeControllerYuuma.NativeFieldInfoPtr_progressBar1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "progressBar1");
			IncomeControllerYuuma.NativeFieldInfoPtr_progressBar2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "progressBar2");
			IncomeControllerYuuma.NativeFieldInfoPtr_timeBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "timeBar");
			IncomeControllerYuuma.NativeFieldInfoPtr_angerBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "angerBar");
			IncomeControllerYuuma.NativeFieldInfoPtr_text1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "text1");
			IncomeControllerYuuma.NativeFieldInfoPtr_m_TutorialButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "m_TutorialButton");
			IncomeControllerYuuma.NativeFieldInfoPtr_m_TutorialButtonCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "m_TutorialButtonCanvasGroup");
			IncomeControllerYuuma.NativeFieldInfoPtr_progressLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "progressLiteral");
			IncomeControllerYuuma.NativeFieldInfoPtr_angerProgressLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "angerProgressLiteral");
			IncomeControllerYuuma.NativeFieldInfoPtr_valueCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "valueCurrent");
			IncomeControllerYuuma.NativeFieldInfoPtr_valueTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "valueTotal");
			IncomeControllerYuuma.NativeFieldInfoPtr_tag1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "tag1");
			IncomeControllerYuuma.NativeFieldInfoPtr_tag2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "tag2");
			IncomeControllerYuuma.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "effect");
			IncomeControllerYuuma.NativeFieldInfoPtr_spoonScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "spoonScroller");
			IncomeControllerYuuma.NativeFieldInfoPtr_currentAnger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "currentAnger");
			IncomeControllerYuuma.NativeFieldInfoPtr_currentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "currentProgress");
			IncomeControllerYuuma.NativeFieldInfoPtr_maxAnger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "maxAnger");
			IncomeControllerYuuma.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "maxValue");
			IncomeControllerYuuma.NativeFieldInfoPtr_onUpdatingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "onUpdatingData");
			IncomeControllerYuuma.NativeFieldInfoPtr_onUpdatingDataAnger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "onUpdatingDataAnger");
			IncomeControllerYuuma.NativeFieldInfoPtr_spoonScrollerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "spoonScrollerCanvasGroup");
			IncomeControllerYuuma.NativeFieldInfoPtr_targetAnger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "targetAnger");
			IncomeControllerYuuma.NativeFieldInfoPtr_targetContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "targetContext");
			IncomeControllerYuuma.NativeFieldInfoPtr_targetProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "targetProgress");
			IncomeControllerYuuma.NativeMethodInfoPtr_SetText_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100673998);
			IncomeControllerYuuma.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100673999);
			IncomeControllerYuuma.NativeMethodInfoPtr_SetContext_Public_Void_String_Int32_Int32_Int32_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674000);
			IncomeControllerYuuma.NativeMethodInfoPtr_SetSpoonPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674001);
			IncomeControllerYuuma.NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674002);
			IncomeControllerYuuma.NativeMethodInfoPtr_SetAngerProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674003);
			IncomeControllerYuuma.NativeMethodInfoPtr_SetTargetTag_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674004);
			IncomeControllerYuuma.NativeMethodInfoPtr_SetTargetTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674005);
			IncomeControllerYuuma.NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674006);
			IncomeControllerYuuma.NativeMethodInfoPtr_TryUpdateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674007);
			IncomeControllerYuuma.NativeMethodInfoPtr_TryUpdateAngerData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674008);
			IncomeControllerYuuma.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674009);
			IncomeControllerYuuma.NativeMethodInfoPtr_UpdateAngerVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674010);
			IncomeControllerYuuma.NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674011);
			IncomeControllerYuuma.NativeMethodInfoPtr_OnUpdateAnger_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674012);
			IncomeControllerYuuma.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674013);
			IncomeControllerYuuma.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674014);
			IncomeControllerYuuma.NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674015);
			IncomeControllerYuuma.NativeMethodInfoPtr__SetContext_b__30_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674016);
			IncomeControllerYuuma.NativeMethodInfoPtr__SetContext_b__30_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674017);
			IncomeControllerYuuma.NativeMethodInfoPtr__SetTargetTime_b__35_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674018);
			IncomeControllerYuuma.NativeMethodInfoPtr__UpdateVisual_b__39_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674019);
			IncomeControllerYuuma.NativeMethodInfoPtr__UpdateVisual_b__39_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674020);
			IncomeControllerYuuma.NativeMethodInfoPtr__UpdateAngerVisual_b__40_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, 100674021);
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00161E2C File Offset: 0x0016002C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131109, XrefRangeEnd = 131111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_SetText_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x00161E70 File Offset: 0x00160070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131111, XrefRangeEnd = 131152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerYuuma.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x00161EAC File Offset: 0x001600AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131191, RefRangeEnd = 131192, XrefRangeStart = 131152, XrefRangeEnd = 131191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContext(string context, int currentValue, int maxValue, int currentAngerValue, int maxAngerValue, Action onTutorialButtonPressed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(context);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentAngerValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAngerValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTutorialButtonPressed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_SetContext_Public_Void_String_Int32_Int32_Int32_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00161F3C File Offset: 0x0016013C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131198, RefRangeEnd = 131199, XrefRangeStart = 131192, XrefRangeEnd = 131198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpoonPosition(float targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_SetSpoonPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00161F7C File Offset: 0x0016017C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131208, RefRangeEnd = 131209, XrefRangeStart = 131199, XrefRangeEnd = 131208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetProgress(int targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x00161FBC File Offset: 0x001601BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131218, RefRangeEnd = 131220, XrefRangeStart = 131209, XrefRangeEnd = 131218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAngerProgress(int targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_SetAngerProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x00161FFC File Offset: 0x001601FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131244, RefRangeEnd = 131246, XrefRangeStart = 131220, XrefRangeEnd = 131244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTag(string tag1String, string tag2String, bool useEffect = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag1String);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tag2String);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useEffect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_SetTargetTag_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x00162060 File Offset: 0x00160260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131246, XrefRangeEnd = 131253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTime(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_SetTargetTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x001620A0 File Offset: 0x001602A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131253, XrefRangeEnd = 131258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetProgressImmediate(int targetValueHP, int targetValueAnger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValueHP;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValueAnger;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x001620EC File Offset: 0x001602EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131258, XrefRangeEnd = 131267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_TryUpdateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x00162120 File Offset: 0x00160320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131267, XrefRangeEnd = 131276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateAngerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_TryUpdateAngerData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x00162154 File Offset: 0x00160354
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 131299, RefRangeEnd = 131304, XrefRangeStart = 131276, XrefRangeEnd = 131299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x00162188 File Offset: 0x00160388
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 131318, RefRangeEnd = 131323, XrefRangeStart = 131304, XrefRangeEnd = 131318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAngerVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_UpdateAngerVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x001621BC File Offset: 0x001603BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131323, XrefRangeEnd = 131328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnUpdateFund()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x001621FC File Offset: 0x001603FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131328, XrefRangeEnd = 131333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnUpdateAnger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_OnUpdateAnger_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x0016223C File Offset: 0x0016043C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131333, XrefRangeEnd = 131353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerYuuma.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x00162278 File Offset: 0x00160478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131353, XrefRangeEnd = 131358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerYuuma() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x001622B4 File Offset: 0x001604B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131358, XrefRangeEnd = 131367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Single_PDM_0(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x001622F4 File Offset: 0x001604F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131367, XrefRangeEnd = 131369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetContext_b__30_0(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr__SetContext_b__30_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x0016233C File Offset: 0x0016053C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131369, XrefRangeEnd = 131371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetContext_b__30_1(bool isopen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isopen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr__SetContext_b__30_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0016237C File Offset: 0x0016057C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetTargetTime_b__35_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr__SetTargetTime_b__35_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x001623BC File Offset: 0x001605BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__39_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr__UpdateVisual_b__39_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x001623FC File Offset: 0x001605FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__39_1(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr__UpdateVisual_b__39_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x0016243C File Offset: 0x0016063C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130568, RefRangeEnd = 130571, XrefRangeStart = 130568, XrefRangeEnd = 130571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateAngerVisual_b__40_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma.NativeMethodInfoPtr__UpdateAngerVisual_b__40_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x0001FE5E File Offset: 0x0001E05E
		public IncomeControllerYuuma(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x0016247C File Offset: 0x0016067C
		// (set) Token: 0x0600392F RID: 14639 RVA: 0x0001FE67 File Offset: 0x0001E067
		public unsafe static int CHANGE_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IncomeControllerYuuma.NativeFieldInfoPtr_CHANGE_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeControllerYuuma.NativeFieldInfoPtr_CHANGE_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x00162498 File Offset: 0x00160698
		// (set) Token: 0x06003931 RID: 14641 RVA: 0x0001FE75 File Offset: 0x0001E075
		public unsafe static int ANGER_CHANGE_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IncomeControllerYuuma.NativeFieldInfoPtr_ANGER_CHANGE_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeControllerYuuma.NativeFieldInfoPtr_ANGER_CHANGE_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06003932 RID: 14642 RVA: 0x001624B4 File Offset: 0x001606B4
		// (set) Token: 0x06003933 RID: 14643 RVA: 0x0001FE83 File Offset: 0x0001E083
		public unsafe static int ANGER_DECREASE_CHANGE_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IncomeControllerYuuma.NativeFieldInfoPtr_ANGER_DECREASE_CHANGE_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeControllerYuuma.NativeFieldInfoPtr_ANGER_DECREASE_CHANGE_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06003934 RID: 14644 RVA: 0x001624D0 File Offset: 0x001606D0
		// (set) Token: 0x06003935 RID: 14645 RVA: 0x0001FE91 File Offset: 0x0001E091
		public unsafe Image progressBar1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_progressBar1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_progressBar1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06003936 RID: 14646 RVA: 0x00162500 File Offset: 0x00160700
		// (set) Token: 0x06003937 RID: 14647 RVA: 0x0001FEB0 File Offset: 0x0001E0B0
		public unsafe Image progressBar2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_progressBar2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_progressBar2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x00162530 File Offset: 0x00160730
		// (set) Token: 0x06003939 RID: 14649 RVA: 0x0001FECF File Offset: 0x0001E0CF
		public unsafe Image timeBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_timeBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_timeBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x0600393A RID: 14650 RVA: 0x00162560 File Offset: 0x00160760
		// (set) Token: 0x0600393B RID: 14651 RVA: 0x0001FEEE File Offset: 0x0001E0EE
		public unsafe Image angerBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_angerBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_angerBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x0600393C RID: 14652 RVA: 0x00162590 File Offset: 0x00160790
		// (set) Token: 0x0600393D RID: 14653 RVA: 0x0001FF0D File Offset: 0x0001E10D
		public unsafe TextMeshProUGUI text1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_text1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_text1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x0600393E RID: 14654 RVA: 0x001625C0 File Offset: 0x001607C0
		// (set) Token: 0x0600393F RID: 14655 RVA: 0x0001FF2C File Offset: 0x0001E12C
		public unsafe UIButtonSimple m_TutorialButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_m_TutorialButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_m_TutorialButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06003940 RID: 14656 RVA: 0x001625F0 File Offset: 0x001607F0
		// (set) Token: 0x06003941 RID: 14657 RVA: 0x0001FF4B File Offset: 0x0001E14B
		public unsafe CanvasGroup m_TutorialButtonCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_m_TutorialButtonCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_m_TutorialButtonCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x06003942 RID: 14658 RVA: 0x00162620 File Offset: 0x00160820
		// (set) Token: 0x06003943 RID: 14659 RVA: 0x0001FF6A File Offset: 0x0001E16A
		public unsafe TextMeshProUGUI progressLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_progressLiteral);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_progressLiteral), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06003944 RID: 14660 RVA: 0x00162650 File Offset: 0x00160850
		// (set) Token: 0x06003945 RID: 14661 RVA: 0x0001FF89 File Offset: 0x0001E189
		public unsafe TextMeshProUGUI angerProgressLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_angerProgressLiteral);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_angerProgressLiteral), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x06003946 RID: 14662 RVA: 0x00162680 File Offset: 0x00160880
		// (set) Token: 0x06003947 RID: 14663 RVA: 0x0001FFA8 File Offset: 0x0001E1A8
		public unsafe TextMeshProUGUI valueCurrent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_valueCurrent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_valueCurrent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x001626B0 File Offset: 0x001608B0
		// (set) Token: 0x06003949 RID: 14665 RVA: 0x0001FFC7 File Offset: 0x0001E1C7
		public unsafe TextMeshProUGUI valueTotal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_valueTotal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_valueTotal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x001626E0 File Offset: 0x001608E0
		// (set) Token: 0x0600394B RID: 14667 RVA: 0x0001FFE6 File Offset: 0x0001E1E6
		public unsafe TextMeshProUGUI tag1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_tag1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_tag1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x00162710 File Offset: 0x00160910
		// (set) Token: 0x0600394D RID: 14669 RVA: 0x00020005 File Offset: 0x0001E205
		public unsafe TextMeshProUGUI tag2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_tag2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_tag2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x0600394E RID: 14670 RVA: 0x00162740 File Offset: 0x00160940
		// (set) Token: 0x0600394F RID: 14671 RVA: 0x00020024 File Offset: 0x0001E224
		public unsafe GameObject effect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_effect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x00162770 File Offset: 0x00160970
		// (set) Token: 0x06003951 RID: 14673 RVA: 0x00020043 File Offset: 0x0001E243
		public unsafe AdpProgressIndicatorComponent spoonScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_spoonScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_spoonScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x001627A0 File Offset: 0x001609A0
		// (set) Token: 0x06003953 RID: 14675 RVA: 0x00020062 File Offset: 0x0001E262
		public unsafe int currentAnger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_currentAnger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_currentAnger)) = value;
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06003954 RID: 14676 RVA: 0x001627C8 File Offset: 0x001609C8
		// (set) Token: 0x06003955 RID: 14677 RVA: 0x0002007D File Offset: 0x0001E27D
		public unsafe int currentProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_currentProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_currentProgress)) = value;
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06003956 RID: 14678 RVA: 0x001627F0 File Offset: 0x001609F0
		// (set) Token: 0x06003957 RID: 14679 RVA: 0x00020098 File Offset: 0x0001E298
		public unsafe int maxAnger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_maxAnger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_maxAnger)) = value;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06003958 RID: 14680 RVA: 0x00162818 File Offset: 0x00160A18
		// (set) Token: 0x06003959 RID: 14681 RVA: 0x000200B3 File Offset: 0x0001E2B3
		public unsafe int maxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_maxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_maxValue)) = value;
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600395A RID: 14682 RVA: 0x00162840 File Offset: 0x00160A40
		// (set) Token: 0x0600395B RID: 14683 RVA: 0x000200CE File Offset: 0x0001E2CE
		public unsafe Coroutine onUpdatingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_onUpdatingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_onUpdatingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x00162870 File Offset: 0x00160A70
		// (set) Token: 0x0600395D RID: 14685 RVA: 0x000200ED File Offset: 0x0001E2ED
		public unsafe Coroutine onUpdatingDataAnger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_onUpdatingDataAnger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_onUpdatingDataAnger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x001628A0 File Offset: 0x00160AA0
		// (set) Token: 0x0600395F RID: 14687 RVA: 0x0002010C File Offset: 0x0001E30C
		public unsafe CanvasGroup spoonScrollerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_spoonScrollerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_spoonScrollerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06003960 RID: 14688 RVA: 0x001628D0 File Offset: 0x00160AD0
		// (set) Token: 0x06003961 RID: 14689 RVA: 0x0002012B File Offset: 0x0001E32B
		public unsafe int targetAnger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_targetAnger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_targetAnger)) = value;
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06003962 RID: 14690 RVA: 0x001628F8 File Offset: 0x00160AF8
		// (set) Token: 0x06003963 RID: 14691 RVA: 0x00020146 File Offset: 0x0001E346
		public unsafe string targetContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_targetContext);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_targetContext), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06003964 RID: 14692 RVA: 0x00162920 File Offset: 0x00160B20
		// (set) Token: 0x06003965 RID: 14693 RVA: 0x00020165 File Offset: 0x0001E365
		public unsafe int targetProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_targetProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma.NativeFieldInfoPtr_targetProgress)) = value;
			}
		}

		// Token: 0x04002674 RID: 9844
		private static readonly IntPtr NativeFieldInfoPtr_CHANGE_AMOUNT;

		// Token: 0x04002675 RID: 9845
		private static readonly IntPtr NativeFieldInfoPtr_ANGER_CHANGE_AMOUNT;

		// Token: 0x04002676 RID: 9846
		private static readonly IntPtr NativeFieldInfoPtr_ANGER_DECREASE_CHANGE_AMOUNT;

		// Token: 0x04002677 RID: 9847
		private static readonly IntPtr NativeFieldInfoPtr_progressBar1;

		// Token: 0x04002678 RID: 9848
		private static readonly IntPtr NativeFieldInfoPtr_progressBar2;

		// Token: 0x04002679 RID: 9849
		private static readonly IntPtr NativeFieldInfoPtr_timeBar;

		// Token: 0x0400267A RID: 9850
		private static readonly IntPtr NativeFieldInfoPtr_angerBar;

		// Token: 0x0400267B RID: 9851
		private static readonly IntPtr NativeFieldInfoPtr_text1;

		// Token: 0x0400267C RID: 9852
		private static readonly IntPtr NativeFieldInfoPtr_m_TutorialButton;

		// Token: 0x0400267D RID: 9853
		private static readonly IntPtr NativeFieldInfoPtr_m_TutorialButtonCanvasGroup;

		// Token: 0x0400267E RID: 9854
		private static readonly IntPtr NativeFieldInfoPtr_progressLiteral;

		// Token: 0x0400267F RID: 9855
		private static readonly IntPtr NativeFieldInfoPtr_angerProgressLiteral;

		// Token: 0x04002680 RID: 9856
		private static readonly IntPtr NativeFieldInfoPtr_valueCurrent;

		// Token: 0x04002681 RID: 9857
		private static readonly IntPtr NativeFieldInfoPtr_valueTotal;

		// Token: 0x04002682 RID: 9858
		private static readonly IntPtr NativeFieldInfoPtr_tag1;

		// Token: 0x04002683 RID: 9859
		private static readonly IntPtr NativeFieldInfoPtr_tag2;

		// Token: 0x04002684 RID: 9860
		private static readonly IntPtr NativeFieldInfoPtr_effect;

		// Token: 0x04002685 RID: 9861
		private static readonly IntPtr NativeFieldInfoPtr_spoonScroller;

		// Token: 0x04002686 RID: 9862
		private static readonly IntPtr NativeFieldInfoPtr_currentAnger;

		// Token: 0x04002687 RID: 9863
		private static readonly IntPtr NativeFieldInfoPtr_currentProgress;

		// Token: 0x04002688 RID: 9864
		private static readonly IntPtr NativeFieldInfoPtr_maxAnger;

		// Token: 0x04002689 RID: 9865
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x0400268A RID: 9866
		private static readonly IntPtr NativeFieldInfoPtr_onUpdatingData;

		// Token: 0x0400268B RID: 9867
		private static readonly IntPtr NativeFieldInfoPtr_onUpdatingDataAnger;

		// Token: 0x0400268C RID: 9868
		private static readonly IntPtr NativeFieldInfoPtr_spoonScrollerCanvasGroup;

		// Token: 0x0400268D RID: 9869
		private static readonly IntPtr NativeFieldInfoPtr_targetAnger;

		// Token: 0x0400268E RID: 9870
		private static readonly IntPtr NativeFieldInfoPtr_targetContext;

		// Token: 0x0400268F RID: 9871
		private static readonly IntPtr NativeFieldInfoPtr_targetProgress;

		// Token: 0x04002690 RID: 9872
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_String_0;

		// Token: 0x04002691 RID: 9873
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002692 RID: 9874
		private static readonly IntPtr NativeMethodInfoPtr_SetContext_Public_Void_String_Int32_Int32_Int32_Int32_Action_0;

		// Token: 0x04002693 RID: 9875
		private static readonly IntPtr NativeMethodInfoPtr_SetSpoonPosition_Public_Void_Single_0;

		// Token: 0x04002694 RID: 9876
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0;

		// Token: 0x04002695 RID: 9877
		private static readonly IntPtr NativeMethodInfoPtr_SetAngerProgress_Public_Void_Int32_0;

		// Token: 0x04002696 RID: 9878
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTag_Public_Void_String_String_Boolean_0;

		// Token: 0x04002697 RID: 9879
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTime_Public_Void_Single_0;

		// Token: 0x04002698 RID: 9880
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_Int32_0;

		// Token: 0x04002699 RID: 9881
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateData_Private_Void_0;

		// Token: 0x0400269A RID: 9882
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateAngerData_Private_Void_0;

		// Token: 0x0400269B RID: 9883
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x0400269C RID: 9884
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAngerVisual_Private_Void_0;

		// Token: 0x0400269D RID: 9885
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0;

		// Token: 0x0400269E RID: 9886
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateAnger_Private_IEnumerator_0;

		// Token: 0x0400269F RID: 9887
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040026A0 RID: 9888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040026A1 RID: 9889
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0;

		// Token: 0x040026A2 RID: 9890
		private static readonly IntPtr NativeMethodInfoPtr__SetContext_b__30_0_Private_Void_CallbackContext_0;

		// Token: 0x040026A3 RID: 9891
		private static readonly IntPtr NativeMethodInfoPtr__SetContext_b__30_1_Private_Void_Boolean_0;

		// Token: 0x040026A4 RID: 9892
		private static readonly IntPtr NativeMethodInfoPtr__SetTargetTime_b__35_0_Private_Void_Single_0;

		// Token: 0x040026A5 RID: 9893
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__39_0_Private_Void_Single_0;

		// Token: 0x040026A6 RID: 9894
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__39_1_Private_Void_Single_0;

		// Token: 0x040026A7 RID: 9895
		private static readonly IntPtr NativeMethodInfoPtr__UpdateAngerVisual_b__40_0_Private_Void_Single_0;

		// Token: 0x02000944 RID: 2372
		[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerYuuma+<OnUpdateFund>d__41")]
		public sealed class _OnUpdateFund_d__41 : Il2CppSystem.Object
		{
			// Token: 0x0600B9DC RID: 47580 RVA: 0x002EE694 File Offset: 0x002EC894
			// Note: this type is marked as 'beforefieldinit'.
			static _OnUpdateFund_d__41()
			{
				Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "<OnUpdateFund>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr);
				IncomeControllerYuuma._OnUpdateFund_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr, "<>1__state");
				IncomeControllerYuuma._OnUpdateFund_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr, "<>2__current");
				IncomeControllerYuuma._OnUpdateFund_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr, "<>4__this");
				IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr, 100674022);
				IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr, 100674023);
				IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr, 100674024);
				IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr, 100674025);
				IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr, 100674026);
				IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr, 100674027);
			}

			// Token: 0x0600B9DD RID: 47581 RVA: 0x002EE774 File Offset: 0x002EC974
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnUpdateFund_d__41(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateFund_d__41>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9DE RID: 47582 RVA: 0x002EE7BC File Offset: 0x002EC9BC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9DF RID: 47583 RVA: 0x002EE7F0 File Offset: 0x002EC9F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131091, XrefRangeEnd = 131094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003CE1 RID: 15585
			// (get) Token: 0x0600B9E0 RID: 47584 RVA: 0x002EE82C File Offset: 0x002ECA2C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9E1 RID: 47585 RVA: 0x002EE86C File Offset: 0x002ECA6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131094, XrefRangeEnd = 131100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003CE2 RID: 15586
			// (get) Token: 0x0600B9E2 RID: 47586 RVA: 0x002EE8A0 File Offset: 0x002ECAA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateFund_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9E3 RID: 47587 RVA: 0x000644EA File Offset: 0x000626EA
			public _OnUpdateFund_d__41(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CDE RID: 15582
			// (get) Token: 0x0600B9E4 RID: 47588 RVA: 0x002EE8E0 File Offset: 0x002ECAE0
			// (set) Token: 0x0600B9E5 RID: 47589 RVA: 0x000644F3 File Offset: 0x000626F3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateFund_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateFund_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CDF RID: 15583
			// (get) Token: 0x0600B9E6 RID: 47590 RVA: 0x002EE908 File Offset: 0x002ECB08
			// (set) Token: 0x0600B9E7 RID: 47591 RVA: 0x0006450E File Offset: 0x0006270E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateFund_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateFund_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CE0 RID: 15584
			// (get) Token: 0x0600B9E8 RID: 47592 RVA: 0x002EE938 File Offset: 0x002ECB38
			// (set) Token: 0x0600B9E9 RID: 47593 RVA: 0x0006452D File Offset: 0x0006272D
			public unsafe IncomeControllerYuuma __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateFund_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerYuuma>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateFund_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007819 RID: 30745
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400781A RID: 30746
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400781B RID: 30747
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400781C RID: 30748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400781D RID: 30749
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400781E RID: 30750
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400781F RID: 30751
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007820 RID: 30752
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007821 RID: 30753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000945 RID: 2373
		[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerYuuma+<OnUpdateAnger>d__42")]
		public sealed class _OnUpdateAnger_d__42 : Il2CppSystem.Object
		{
			// Token: 0x0600B9EA RID: 47594 RVA: 0x002EE968 File Offset: 0x002ECB68
			// Note: this type is marked as 'beforefieldinit'.
			static _OnUpdateAnger_d__42()
			{
				Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerYuuma>.NativeClassPtr, "<OnUpdateAnger>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr);
				IncomeControllerYuuma._OnUpdateAnger_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr, "<>1__state");
				IncomeControllerYuuma._OnUpdateAnger_d__42.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr, "<>2__current");
				IncomeControllerYuuma._OnUpdateAnger_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr, "<>4__this");
				IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr, 100674028);
				IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr, 100674029);
				IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr, 100674030);
				IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr, 100674031);
				IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr, 100674032);
				IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr, 100674033);
			}

			// Token: 0x0600B9EB RID: 47595 RVA: 0x002EEA48 File Offset: 0x002ECC48
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnUpdateAnger_d__42(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerYuuma._OnUpdateAnger_d__42>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9EC RID: 47596 RVA: 0x002EEA90 File Offset: 0x002ECC90
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9ED RID: 47597 RVA: 0x002EEAC4 File Offset: 0x002ECCC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131100, XrefRangeEnd = 131103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003CE6 RID: 15590
			// (get) Token: 0x0600B9EE RID: 47598 RVA: 0x002EEB00 File Offset: 0x002ECD00
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9EF RID: 47599 RVA: 0x002EEB40 File Offset: 0x002ECD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131103, XrefRangeEnd = 131109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003CE7 RID: 15591
			// (get) Token: 0x0600B9F0 RID: 47600 RVA: 0x002EEB74 File Offset: 0x002ECD74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9F1 RID: 47601 RVA: 0x0006454C File Offset: 0x0006274C
			public _OnUpdateAnger_d__42(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CE3 RID: 15587
			// (get) Token: 0x0600B9F2 RID: 47602 RVA: 0x002EEBB4 File Offset: 0x002ECDB4
			// (set) Token: 0x0600B9F3 RID: 47603 RVA: 0x00064555 File Offset: 0x00062755
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CE4 RID: 15588
			// (get) Token: 0x0600B9F4 RID: 47604 RVA: 0x002EEBDC File Offset: 0x002ECDDC
			// (set) Token: 0x0600B9F5 RID: 47605 RVA: 0x00064570 File Offset: 0x00062770
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CE5 RID: 15589
			// (get) Token: 0x0600B9F6 RID: 47606 RVA: 0x002EEC0C File Offset: 0x002ECE0C
			// (set) Token: 0x0600B9F7 RID: 47607 RVA: 0x0006458F File Offset: 0x0006278F
			public unsafe IncomeControllerYuuma __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerYuuma>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuuma._OnUpdateAnger_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007822 RID: 30754
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007823 RID: 30755
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007824 RID: 30756
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007825 RID: 30757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007826 RID: 30758
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007827 RID: 30759
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007828 RID: 30760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007829 RID: 30761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400782A RID: 30762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
