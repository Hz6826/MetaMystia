using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.UI;
using NightScene.UI.HUDUtility;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Night.UI.HUD
{
	// Token: 0x0200004F RID: 79
	public class IncomeControllerMizuchi : IncomeControllerBase
	{
		// Token: 0x060009C4 RID: 2500 RVA: 0x000BD1AC File Offset: 0x000BB3AC
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeControllerMizuchi()
		{
			Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.UI.HUD", "IncomeControllerMizuchi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr);
			IncomeControllerMizuchi.NativeFieldInfoPtr_TIME_CHANGE_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "TIME_CHANGE_AMOUNT");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeButtonHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_MoonEyeButtonHold");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeEnergyImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_MoonEyeEnergyImage");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeEnergyShiningImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_MoonEyeEnergyShiningImage");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_Target");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_Current");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_Title");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_Pic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_Pic");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_Remaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_Remaining");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_CanvasGroup");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_MoonEyeCanvasGroup");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_TanBuffLockIngredientsCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_TanBuffLockIngredientsCanvasGroup");
			IncomeControllerMizuchi.NativeFieldInfoPtr_progressBar1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "progressBar1");
			IncomeControllerMizuchi.NativeFieldInfoPtr_progressBar2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "progressBar2");
			IncomeControllerMizuchi.NativeFieldInfoPtr_timeBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "timeBar");
			IncomeControllerMizuchi.NativeFieldInfoPtr_progressLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "progressLiteral");
			IncomeControllerMizuchi.NativeFieldInfoPtr_OnMoonEyeActivedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "OnMoonEyeActivedCallback");
			IncomeControllerMizuchi.NativeFieldInfoPtr__OnMoonEyeActivedChangeCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "<OnMoonEyeActivedChangeCallback>k__BackingField");
			IncomeControllerMizuchi.NativeFieldInfoPtr__MaxValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "<MaxValue>k__BackingField");
			IncomeControllerMizuchi.NativeFieldInfoPtr_currentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "currentProgress");
			IncomeControllerMizuchi.NativeFieldInfoPtr_targetProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "targetProgress");
			IncomeControllerMizuchi.NativeFieldInfoPtr_onUpdatingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "onUpdatingData");
			IncomeControllerMizuchi.NativeFieldInfoPtr_onUpdatingCatchProgressData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "onUpdatingCatchProgressData");
			IncomeControllerMizuchi.NativeFieldInfoPtr_currentCatchNumProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "currentCatchNumProgress");
			IncomeControllerMizuchi.NativeFieldInfoPtr_targetCatchNumProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "targetCatchNumProgress");
			IncomeControllerMizuchi.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "maxValue");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_SustainedPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_SustainedPannel");
			IncomeControllerMizuchi.NativeFieldInfoPtr_m_SustainedCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "m_SustainedCanvasGroup");
			IncomeControllerMizuchi.NativeFieldInfoPtr_CHANGE_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "CHANGE_AMOUNT");
			IncomeControllerMizuchi.NativeMethodInfoPtr_add_OnMoonEyeActivedCallback_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664908);
			IncomeControllerMizuchi.NativeMethodInfoPtr_remove_OnMoonEyeActivedCallback_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664909);
			IncomeControllerMizuchi.NativeMethodInfoPtr_get_OnMoonEyeActivedChangeCallback_Private_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664910);
			IncomeControllerMizuchi.NativeMethodInfoPtr_set_OnMoonEyeActivedChangeCallback_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664911);
			IncomeControllerMizuchi.NativeMethodInfoPtr_get_MaxValue_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664912);
			IncomeControllerMizuchi.NativeMethodInfoPtr_set_MaxValue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664913);
			IncomeControllerMizuchi.NativeMethodInfoPtr_UpdateInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664914);
			IncomeControllerMizuchi.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664915);
			IncomeControllerMizuchi.NativeMethodInfoPtr_AfterInitialized_Public_Void_String_Sprite_Boolean_byref_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664916);
			IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetNum_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664917);
			IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664918);
			IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664919);
			IncomeControllerMizuchi.NativeMethodInfoPtr_UpdateMoonEyeEnergyCharging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664920);
			IncomeControllerMizuchi.NativeMethodInfoPtr_CallMoonEye_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664921);
			IncomeControllerMizuchi.NativeMethodInfoPtr_TryUpdateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664922);
			IncomeControllerMizuchi.NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664923);
			IncomeControllerMizuchi.NativeMethodInfoPtr_UpdateRemainingNum_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664924);
			IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetCatchProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664925);
			IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetCatchProgressImmediate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664926);
			IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetTime_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664927);
			IncomeControllerMizuchi.NativeMethodInfoPtr_TryUpdateTimeData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664928);
			IncomeControllerMizuchi.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664929);
			IncomeControllerMizuchi.NativeMethodInfoPtr_OnUpdateCatchNumProgress_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664930);
			IncomeControllerMizuchi.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664931);
			IncomeControllerMizuchi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664932);
			IncomeControllerMizuchi.NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664933);
			IncomeControllerMizuchi.NativeMethodInfoPtr__Initialize_b__37_2_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664934);
			IncomeControllerMizuchi.NativeMethodInfoPtr__Initialize_b__37_3_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664935);
			IncomeControllerMizuchi.NativeMethodInfoPtr__Initialize_b__37_4_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664936);
			IncomeControllerMizuchi.NativeMethodInfoPtr__SetTargetTime_b__50_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664937);
			IncomeControllerMizuchi.NativeMethodInfoPtr__UpdateVisual_b__52_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664938);
			IncomeControllerMizuchi.NativeMethodInfoPtr__UpdateVisual_b__52_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, 100664939);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000BD6A0 File Offset: 0x000BB8A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39195, RefRangeEnd = 39196, XrefRangeStart = 39191, XrefRangeEnd = 39195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnMoonEyeActivedCallback(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_add_OnMoonEyeActivedCallback_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000BD6E4 File Offset: 0x000BB8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39196, XrefRangeEnd = 39200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnMoonEyeActivedCallback(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_remove_OnMoonEyeActivedCallback_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000BD728 File Offset: 0x000BB928
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x000BD768 File Offset: 0x000BB968
		public unsafe Action OnMoonEyeActivedChangeCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_get_OnMoonEyeActivedChangeCallback_Private_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39200, XrefRangeEnd = 39201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_set_OnMoonEyeActivedChangeCallback_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x000BD7AC File Offset: 0x000BB9AC
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x000BD7E8 File Offset: 0x000BB9E8
		public unsafe int MaxValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30554, RefRangeEnd = 30555, XrefRangeStart = 30554, XrefRangeEnd = 30555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_get_MaxValue_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_set_MaxValue_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000BD828 File Offset: 0x000BBA28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39203, RefRangeEnd = 39205, XrefRangeStart = 39201, XrefRangeEnd = 39203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInteractable(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_UpdateInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000BD868 File Offset: 0x000BBA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39205, XrefRangeEnd = 39289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerMizuchi.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000BD8A4 File Offset: 0x000BBAA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39304, RefRangeEnd = 39305, XrefRangeStart = 39289, XrefRangeEnd = 39304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AfterInitialized(string title, Sprite pic, bool isTanBuffActive, out CanvasGroup tanBuffCanvasGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pic);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTanBuffActive;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_AfterInitialized_Public_Void_String_Sprite_Boolean_byref_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			tanBuffCanvasGroup = ((intPtr4 == 0) ? null : new CanvasGroup(intPtr4));
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000BD928 File Offset: 0x000BBB28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39306, RefRangeEnd = 39307, XrefRangeStart = 39305, XrefRangeEnd = 39306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetNum(int targetNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetNum_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000BD968 File Offset: 0x000BBB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39317, RefRangeEnd = 39318, XrefRangeStart = 39307, XrefRangeEnd = 39317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetProgress(float targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000BD9A8 File Offset: 0x000BBBA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39323, RefRangeEnd = 39326, XrefRangeStart = 39318, XrefRangeEnd = 39323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetProgressImmediate(float targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000BD9E8 File Offset: 0x000BBBE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 39328, RefRangeEnd = 39332, XrefRangeStart = 39326, XrefRangeEnd = 39328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMoonEyeEnergyCharging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_UpdateMoonEyeEnergyCharging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000BDA1C File Offset: 0x000BBC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39332, XrefRangeEnd = 39333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallMoonEye()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_CallMoonEye_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000BDA50 File Offset: 0x000BBC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39333, XrefRangeEnd = 39342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_TryUpdateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000BDA84 File Offset: 0x000BBC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39342, XrefRangeEnd = 39347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnUpdateFund()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000BDAC4 File Offset: 0x000BBCC4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 39348, RefRangeEnd = 39360, XrefRangeStart = 39347, XrefRangeEnd = 39348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRemainingNum(int currentNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_UpdateRemainingNum_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000BDB04 File Offset: 0x000BBD04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39368, RefRangeEnd = 39369, XrefRangeStart = 39360, XrefRangeEnd = 39368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetCatchProgress(int targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetCatchProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000BDB44 File Offset: 0x000BBD44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39381, RefRangeEnd = 39382, XrefRangeStart = 39369, XrefRangeEnd = 39381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetCatchProgressImmediate(int targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetCatchProgressImmediate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000BDB84 File Offset: 0x000BBD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39382, XrefRangeEnd = 39389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTime(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_SetTargetTime_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000BDBC4 File Offset: 0x000BBDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39389, XrefRangeEnd = 39398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateTimeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_TryUpdateTimeData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000BDBF8 File Offset: 0x000BBDF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39418, RefRangeEnd = 39420, XrefRangeStart = 39398, XrefRangeEnd = 39418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000BDC2C File Offset: 0x000BBE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39420, XrefRangeEnd = 39425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnUpdateCatchNumProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_OnUpdateCatchNumProgress_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000BDC6C File Offset: 0x000BBE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39425, XrefRangeEnd = 39447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerMizuchi.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000BDCA8 File Offset: 0x000BBEA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerMizuchi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000BDCE4 File Offset: 0x000BBEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39447, XrefRangeEnd = 39456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Single_PDM_0(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000BDD24 File Offset: 0x000BBF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39456, XrefRangeEnd = 39457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__37_2(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr__Initialize_b__37_2_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000BDD6C File Offset: 0x000BBF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39457, XrefRangeEnd = 39459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__37_3(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr__Initialize_b__37_3_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x000BDDB4 File Offset: 0x000BBFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39459, XrefRangeEnd = 39461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__37_4(bool isopen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isopen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr__Initialize_b__37_4_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000BDDF4 File Offset: 0x000BBFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39461, XrefRangeEnd = 39463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetTargetTime_b__50_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr__SetTargetTime_b__50_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000BDE34 File Offset: 0x000BC034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39463, XrefRangeEnd = 39465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__52_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr__UpdateVisual_b__52_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000BDE74 File Offset: 0x000BC074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39465, XrefRangeEnd = 39467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__52_1(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.NativeMethodInfoPtr__UpdateVisual_b__52_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00007739 File Offset: 0x00005939
		public IncomeControllerMizuchi(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000BDEB4 File Offset: 0x000BC0B4
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00007742 File Offset: 0x00005942
		public unsafe static int TIME_CHANGE_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IncomeControllerMizuchi.NativeFieldInfoPtr_TIME_CHANGE_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeControllerMizuchi.NativeFieldInfoPtr_TIME_CHANGE_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000BDED0 File Offset: 0x000BC0D0
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00007750 File Offset: 0x00005950
		public unsafe UIButtonHold m_MoonEyeButtonHold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeButtonHold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeButtonHold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000BDF00 File Offset: 0x000BC100
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x0000776F File Offset: 0x0000596F
		public unsafe Image m_MoonEyeEnergyImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeEnergyImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeEnergyImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x000BDF30 File Offset: 0x000BC130
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0000778E File Offset: 0x0000598E
		public unsafe Image m_MoonEyeEnergyShiningImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeEnergyShiningImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeEnergyShiningImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x000BDF60 File Offset: 0x000BC160
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x000077AD File Offset: 0x000059AD
		public unsafe TextMeshProUGUI m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000BDF90 File Offset: 0x000BC190
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x000077CC File Offset: 0x000059CC
		public unsafe TextMeshProUGUI m_Current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_Current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_Current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000BDFC0 File Offset: 0x000BC1C0
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x000077EB File Offset: 0x000059EB
		public unsafe TextMeshProUGUI m_Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000BDFF0 File Offset: 0x000BC1F0
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x0000780A File Offset: 0x00005A0A
		public unsafe Image m_Pic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_Pic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_Pic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x000BE020 File Offset: 0x000BC220
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00007829 File Offset: 0x00005A29
		public unsafe TextMeshProUGUI m_Remaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_Remaining);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_Remaining), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x000BE050 File Offset: 0x000BC250
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x00007848 File Offset: 0x00005A48
		public unsafe CanvasGroup m_CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x000BE080 File Offset: 0x000BC280
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x00007867 File Offset: 0x00005A67
		public unsafe CanvasGroup m_MoonEyeCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_MoonEyeCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x000BE0B0 File Offset: 0x000BC2B0
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x00007886 File Offset: 0x00005A86
		public unsafe CanvasGroup m_TanBuffLockIngredientsCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_TanBuffLockIngredientsCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_TanBuffLockIngredientsCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x000BE0E0 File Offset: 0x000BC2E0
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x000078A5 File Offset: 0x00005AA5
		public unsafe Image progressBar1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_progressBar1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_progressBar1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x000BE110 File Offset: 0x000BC310
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x000078C4 File Offset: 0x00005AC4
		public unsafe Image progressBar2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_progressBar2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_progressBar2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x000BE140 File Offset: 0x000BC340
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x000078E3 File Offset: 0x00005AE3
		public unsafe Image timeBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_timeBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_timeBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x000BE170 File Offset: 0x000BC370
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00007902 File Offset: 0x00005B02
		public unsafe TextMeshProUGUI progressLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_progressLiteral);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_progressLiteral), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000BE1A0 File Offset: 0x000BC3A0
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00007921 File Offset: 0x00005B21
		public unsafe Action OnMoonEyeActivedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_OnMoonEyeActivedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_OnMoonEyeActivedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x000BE1D0 File Offset: 0x000BC3D0
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00007940 File Offset: 0x00005B40
		public unsafe Action _OnMoonEyeActivedChangeCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr__OnMoonEyeActivedChangeCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr__OnMoonEyeActivedChangeCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x000BE200 File Offset: 0x000BC400
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0000795F File Offset: 0x00005B5F
		public unsafe int _MaxValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr__MaxValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr__MaxValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x000BE228 File Offset: 0x000BC428
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0000797A File Offset: 0x00005B7A
		public unsafe int currentProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_currentProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_currentProgress)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x000BE250 File Offset: 0x000BC450
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00007995 File Offset: 0x00005B95
		public unsafe int targetProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_targetProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_targetProgress)) = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x000BE278 File Offset: 0x000BC478
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x000079B0 File Offset: 0x00005BB0
		public unsafe Coroutine onUpdatingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_onUpdatingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_onUpdatingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x000BE2A8 File Offset: 0x000BC4A8
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x000079CF File Offset: 0x00005BCF
		public unsafe Coroutine onUpdatingCatchProgressData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_onUpdatingCatchProgressData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_onUpdatingCatchProgressData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x000BE2D8 File Offset: 0x000BC4D8
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x000079EE File Offset: 0x00005BEE
		public unsafe int currentCatchNumProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_currentCatchNumProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_currentCatchNumProgress)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x000BE300 File Offset: 0x000BC500
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00007A09 File Offset: 0x00005C09
		public unsafe int targetCatchNumProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_targetCatchNumProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_targetCatchNumProgress)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x000BE328 File Offset: 0x000BC528
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00007A24 File Offset: 0x00005C24
		public unsafe int maxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_maxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_maxValue)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x000BE350 File Offset: 0x000BC550
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00007A3F File Offset: 0x00005C3F
		public unsafe WorkSceneSustainedPannel m_SustainedPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_SustainedPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_SustainedPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000BE380 File Offset: 0x000BC580
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00007A5E File Offset: 0x00005C5E
		public unsafe CanvasGroup m_SustainedCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_SustainedCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi.NativeFieldInfoPtr_m_SustainedCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x000BE3B0 File Offset: 0x000BC5B0
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00007A7D File Offset: 0x00005C7D
		public unsafe static int CHANGE_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IncomeControllerMizuchi.NativeFieldInfoPtr_CHANGE_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeControllerMizuchi.NativeFieldInfoPtr_CHANGE_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr_TIME_CHANGE_AMOUNT;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_m_MoonEyeButtonHold;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_m_MoonEyeEnergyImage;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr_m_MoonEyeEnergyShiningImage;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr_m_Current;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeFieldInfoPtr_m_Title;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeFieldInfoPtr_m_Pic;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeFieldInfoPtr_m_Remaining;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasGroup;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr_m_MoonEyeCanvasGroup;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeFieldInfoPtr_m_TanBuffLockIngredientsCanvasGroup;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeFieldInfoPtr_progressBar1;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeFieldInfoPtr_progressBar2;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeFieldInfoPtr_timeBar;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeFieldInfoPtr_progressLiteral;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeFieldInfoPtr_OnMoonEyeActivedCallback;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeFieldInfoPtr__OnMoonEyeActivedChangeCallback_k__BackingField;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeFieldInfoPtr__MaxValue_k__BackingField;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeFieldInfoPtr_currentProgress;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeFieldInfoPtr_targetProgress;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeFieldInfoPtr_onUpdatingData;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeFieldInfoPtr_onUpdatingCatchProgressData;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeFieldInfoPtr_currentCatchNumProgress;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr_targetCatchNumProgress;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeFieldInfoPtr_m_SustainedPannel;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr_m_SustainedCanvasGroup;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeFieldInfoPtr_CHANGE_AMOUNT;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_add_OnMoonEyeActivedCallback_Public_add_Void_Action_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnMoonEyeActivedCallback_Public_rem_Void_Action_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_get_OnMoonEyeActivedChangeCallback_Private_get_Action_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_set_OnMoonEyeActivedChangeCallback_Public_set_Void_Action_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxValue_Private_get_Int32_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxValue_Public_set_Void_Int32_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInteractable_Public_Void_Boolean_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_AfterInitialized_Public_Void_String_Sprite_Boolean_byref_CanvasGroup_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetNum_Public_Void_Int32_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetProgress_Public_Void_Single_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Single_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMoonEyeEnergyCharging_Private_Void_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_CallMoonEye_Private_Void_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateData_Private_Void_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRemainingNum_Public_Void_Int32_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetCatchProgress_Public_Void_Int32_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetCatchProgressImmediate_Public_Void_Int32_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTime_Private_Void_Single_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateTimeData_Private_Void_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateCatchNumProgress_Private_IEnumerator_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__37_2_Private_Void_CallbackContext_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__37_3_Private_Void_CallbackContext_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__37_4_Private_Void_Boolean_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr__SetTargetTime_b__50_0_Private_Void_Single_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__52_0_Private_Void_Single_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__52_1_Private_Void_Single_0;

		// Token: 0x02000512 RID: 1298
		[ObfuscatedName("Night.UI.HUD.IncomeControllerMizuchi+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008478 RID: 33912 RVA: 0x00252544 File Offset: 0x00250744
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IncomeControllerMizuchi.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerMizuchi.__c>.NativeClassPtr);
				IncomeControllerMizuchi.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi.__c>.NativeClassPtr, "<>9");
				IncomeControllerMizuchi.__c.NativeFieldInfoPtr___9__37_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi.__c>.NativeClassPtr, "<>9__37_1");
				IncomeControllerMizuchi.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi.__c>.NativeClassPtr, 100664941);
				IncomeControllerMizuchi.__c.NativeMethodInfoPtr__Initialize_b__37_1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi.__c>.NativeClassPtr, 100664942);
			}

			// Token: 0x06008479 RID: 33913 RVA: 0x002525C0 File Offset: 0x002507C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerMizuchi.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600847A RID: 33914 RVA: 0x002525FC File Offset: 0x002507FC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__37_1(int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi.__c.NativeMethodInfoPtr__Initialize_b__37_1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600847B RID: 33915 RVA: 0x0004751D File Offset: 0x0004571D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C82 RID: 11394
			// (get) Token: 0x0600847C RID: 33916 RVA: 0x0025263C File Offset: 0x0025083C
			// (set) Token: 0x0600847D RID: 33917 RVA: 0x00047526 File Offset: 0x00045726
			public unsafe static IncomeControllerMizuchi.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerMizuchi.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerMizuchi.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerMizuchi.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C83 RID: 11395
			// (get) Token: 0x0600847E RID: 33918 RVA: 0x00252664 File Offset: 0x00250864
			// (set) Token: 0x0600847F RID: 33919 RVA: 0x00047538 File Offset: 0x00045738
			public unsafe static Action<int> __9__37_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerMizuchi.__c.NativeFieldInfoPtr___9__37_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerMizuchi.__c.NativeFieldInfoPtr___9__37_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005721 RID: 22305
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005722 RID: 22306
			private static readonly IntPtr NativeFieldInfoPtr___9__37_1;

			// Token: 0x04005723 RID: 22307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005724 RID: 22308
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__37_1_Internal_Void_Int32_0;
		}

		// Token: 0x02000513 RID: 1299
		[ObfuscatedName("Night.UI.HUD.IncomeControllerMizuchi+<OnUpdateFund>d__45")]
		public sealed class _OnUpdateFund_d__45 : Il2CppSystem.Object
		{
			// Token: 0x06008480 RID: 33920 RVA: 0x0025268C File Offset: 0x0025088C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnUpdateFund_d__45()
			{
				Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "<OnUpdateFund>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr);
				IncomeControllerMizuchi._OnUpdateFund_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr, "<>1__state");
				IncomeControllerMizuchi._OnUpdateFund_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr, "<>2__current");
				IncomeControllerMizuchi._OnUpdateFund_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr, "<>4__this");
				IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr, 100664943);
				IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr, 100664944);
				IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr, 100664945);
				IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr, 100664946);
				IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr, 100664947);
				IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr, 100664948);
			}

			// Token: 0x06008481 RID: 33921 RVA: 0x0025276C File Offset: 0x0025096C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnUpdateFund_d__45(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateFund_d__45>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008482 RID: 33922 RVA: 0x002527B4 File Offset: 0x002509B4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008483 RID: 33923 RVA: 0x002527E8 File Offset: 0x002509E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39173, XrefRangeEnd = 39176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002C87 RID: 11399
			// (get) Token: 0x06008484 RID: 33924 RVA: 0x00252824 File Offset: 0x00250A24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008485 RID: 33925 RVA: 0x00252864 File Offset: 0x00250A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39176, XrefRangeEnd = 39182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002C88 RID: 11400
			// (get) Token: 0x06008486 RID: 33926 RVA: 0x00252898 File Offset: 0x00250A98
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008487 RID: 33927 RVA: 0x0004754A File Offset: 0x0004574A
			public _OnUpdateFund_d__45(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C84 RID: 11396
			// (get) Token: 0x06008488 RID: 33928 RVA: 0x002528D8 File Offset: 0x00250AD8
			// (set) Token: 0x06008489 RID: 33929 RVA: 0x00047553 File Offset: 0x00045753
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002C85 RID: 11397
			// (get) Token: 0x0600848A RID: 33930 RVA: 0x00252900 File Offset: 0x00250B00
			// (set) Token: 0x0600848B RID: 33931 RVA: 0x0004756E File Offset: 0x0004576E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C86 RID: 11398
			// (get) Token: 0x0600848C RID: 33932 RVA: 0x00252930 File Offset: 0x00250B30
			// (set) Token: 0x0600848D RID: 33933 RVA: 0x0004758D File Offset: 0x0004578D
			public unsafe IncomeControllerMizuchi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerMizuchi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateFund_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005725 RID: 22309
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005726 RID: 22310
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005727 RID: 22311
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005728 RID: 22312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005729 RID: 22313
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400572A RID: 22314
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400572B RID: 22315
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400572C RID: 22316
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400572D RID: 22317
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000514 RID: 1300
		[ObfuscatedName("Night.UI.HUD.IncomeControllerMizuchi+<OnUpdateCatchNumProgress>d__53")]
		public sealed class _OnUpdateCatchNumProgress_d__53 : Il2CppSystem.Object
		{
			// Token: 0x0600848E RID: 33934 RVA: 0x00252960 File Offset: 0x00250B60
			// Note: this type is marked as 'beforefieldinit'.
			static _OnUpdateCatchNumProgress_d__53()
			{
				Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerMizuchi>.NativeClassPtr, "<OnUpdateCatchNumProgress>d__53");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr);
				IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr, "<>1__state");
				IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr, "<>2__current");
				IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr, "<>4__this");
				IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr, 100664949);
				IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr, 100664950);
				IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr, 100664951);
				IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr, 100664952);
				IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr, 100664953);
				IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr, 100664954);
			}

			// Token: 0x0600848F RID: 33935 RVA: 0x00252A40 File Offset: 0x00250C40
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnUpdateCatchNumProgress_d__53(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008490 RID: 33936 RVA: 0x00252A88 File Offset: 0x00250C88
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008491 RID: 33937 RVA: 0x00252ABC File Offset: 0x00250CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39182, XrefRangeEnd = 39185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002C8C RID: 11404
			// (get) Token: 0x06008492 RID: 33938 RVA: 0x00252AF8 File Offset: 0x00250CF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008493 RID: 33939 RVA: 0x00252B38 File Offset: 0x00250D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39185, XrefRangeEnd = 39191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002C8D RID: 11405
			// (get) Token: 0x06008494 RID: 33940 RVA: 0x00252B6C File Offset: 0x00250D6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008495 RID: 33941 RVA: 0x000475AC File Offset: 0x000457AC
			public _OnUpdateCatchNumProgress_d__53(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C89 RID: 11401
			// (get) Token: 0x06008496 RID: 33942 RVA: 0x00252BAC File Offset: 0x00250DAC
			// (set) Token: 0x06008497 RID: 33943 RVA: 0x000475B5 File Offset: 0x000457B5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002C8A RID: 11402
			// (get) Token: 0x06008498 RID: 33944 RVA: 0x00252BD4 File Offset: 0x00250DD4
			// (set) Token: 0x06008499 RID: 33945 RVA: 0x000475D0 File Offset: 0x000457D0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C8B RID: 11403
			// (get) Token: 0x0600849A RID: 33946 RVA: 0x00252C04 File Offset: 0x00250E04
			// (set) Token: 0x0600849B RID: 33947 RVA: 0x000475EF File Offset: 0x000457EF
			public unsafe IncomeControllerMizuchi __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerMizuchi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMizuchi._OnUpdateCatchNumProgress_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400572E RID: 22318
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400572F RID: 22319
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005730 RID: 22320
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005731 RID: 22321
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005732 RID: 22322
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005733 RID: 22323
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005734 RID: 22324
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005735 RID: 22325
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005736 RID: 22326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
