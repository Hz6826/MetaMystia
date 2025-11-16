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
	// Token: 0x020001CA RID: 458
	public class IncomeControllerYuyuko : IncomeControllerBase
	{
		// Token: 0x06003966 RID: 14694 RVA: 0x00162948 File Offset: 0x00160B48
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeControllerYuyuko()
		{
			Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "IncomeControllerYuyuko");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr);
			IncomeControllerYuyuko.NativeFieldInfoPtr_CHANGE_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "CHANGE_AMOUNT");
			IncomeControllerYuyuko.NativeFieldInfoPtr_progressBar1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "progressBar1");
			IncomeControllerYuyuko.NativeFieldInfoPtr_progressBar2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "progressBar2");
			IncomeControllerYuyuko.NativeFieldInfoPtr_timeBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "timeBar");
			IncomeControllerYuyuko.NativeFieldInfoPtr_text1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "text1");
			IncomeControllerYuyuko.NativeFieldInfoPtr_progressLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "progressLiteral");
			IncomeControllerYuyuko.NativeFieldInfoPtr_valueCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "valueCurrent");
			IncomeControllerYuyuko.NativeFieldInfoPtr_valueTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "valueTotal");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase1TitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase1TitleColor");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase2TitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase2TitleColor");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase3TitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase3TitleColor");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase1ProgressLiteralColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase1ProgressLiteralColor");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase2ProgressLiteralColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase2ProgressLiteralColor");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase3ProgressLiteralColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase3ProgressLiteralColor");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase1Bar1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase1Bar1Color");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase1Bar2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase1Bar2Color");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase2Bar1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase2Bar1Color");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase2Bar2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase2Bar2Color");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase3Bar1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase3Bar1Color");
			IncomeControllerYuyuko.NativeFieldInfoPtr_phase3Bar2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "phase3Bar2Color");
			IncomeControllerYuyuko.NativeFieldInfoPtr_currentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "currentProgress");
			IncomeControllerYuyuko.NativeFieldInfoPtr_invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "invert");
			IncomeControllerYuyuko.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "maxValue");
			IncomeControllerYuyuko.NativeFieldInfoPtr_onUpdatingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "onUpdatingData");
			IncomeControllerYuyuko.NativeFieldInfoPtr_targetContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "targetContext");
			IncomeControllerYuyuko.NativeFieldInfoPtr_targetProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "targetProgress");
			IncomeControllerYuyuko.NativeMethodInfoPtr_SetText_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674034);
			IncomeControllerYuyuko.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674035);
			IncomeControllerYuyuko.NativeMethodInfoPtr_SetContext_Public_Void_String_Int32_Int32_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674036);
			IncomeControllerYuyuko.NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674037);
			IncomeControllerYuyuko.NativeMethodInfoPtr_SetTargetTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674038);
			IncomeControllerYuyuko.NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674039);
			IncomeControllerYuyuko.NativeMethodInfoPtr_TryUpdateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674040);
			IncomeControllerYuyuko.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674041);
			IncomeControllerYuyuko.NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674042);
			IncomeControllerYuyuko.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674043);
			IncomeControllerYuyuko.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674044);
			IncomeControllerYuyuko.NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674045);
			IncomeControllerYuyuko.NativeMethodInfoPtr__SetTargetTime_b__31_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674046);
			IncomeControllerYuyuko.NativeMethodInfoPtr__UpdateVisual_b__34_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674047);
			IncomeControllerYuyuko.NativeMethodInfoPtr__UpdateVisual_b__34_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, 100674048);
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x00162CAC File Offset: 0x00160EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131380, XrefRangeEnd = 131382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr_SetText_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x00162CF0 File Offset: 0x00160EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131382, XrefRangeEnd = 131419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerYuyuko.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x00162D2C File Offset: 0x00160F2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131434, RefRangeEnd = 131438, XrefRangeStart = 131419, XrefRangeEnd = 131434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContext(string context, int currentValue, int maxValue, IncomeControllerYuyuko.Phase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(context);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr_SetContext_Public_Void_String_Int32_Int32_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x00162D98 File Offset: 0x00160F98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131447, RefRangeEnd = 131451, XrefRangeStart = 131438, XrefRangeEnd = 131447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetProgress(int targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x00162DD8 File Offset: 0x00160FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131451, XrefRangeEnd = 131458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetTime(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr_SetTargetTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x00162E18 File Offset: 0x00161018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131458, XrefRangeEnd = 131461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetProgressImmediate(int targetValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x00162E58 File Offset: 0x00161058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131461, XrefRangeEnd = 131470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr_TryUpdateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x00162E8C File Offset: 0x0016108C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 131494, RefRangeEnd = 131499, XrefRangeStart = 131470, XrefRangeEnd = 131494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x00162EC0 File Offset: 0x001610C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131499, XrefRangeEnd = 131504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnUpdateFund()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x00162F00 File Offset: 0x00161100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131504, XrefRangeEnd = 131514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerYuyuko.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x00162F3C File Offset: 0x0016113C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131514, XrefRangeEnd = 131519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerYuyuko() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x00162F78 File Offset: 0x00161178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131519, XrefRangeEnd = 131528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Single_PDM_0(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x00162FB8 File Offset: 0x001611B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetTargetTime_b__31_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr__SetTargetTime_b__31_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x00162FF8 File Offset: 0x001611F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__34_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr__UpdateVisual_b__34_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00163038 File Offset: 0x00161238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateVisual_b__34_1(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko.NativeMethodInfoPtr__UpdateVisual_b__34_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00020180 File Offset: 0x0001E380
		public IncomeControllerYuyuko(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06003977 RID: 14711 RVA: 0x00163078 File Offset: 0x00161278
		// (set) Token: 0x06003978 RID: 14712 RVA: 0x00020189 File Offset: 0x0001E389
		public unsafe static int CHANGE_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IncomeControllerYuyuko.NativeFieldInfoPtr_CHANGE_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeControllerYuyuko.NativeFieldInfoPtr_CHANGE_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06003979 RID: 14713 RVA: 0x00163094 File Offset: 0x00161294
		// (set) Token: 0x0600397A RID: 14714 RVA: 0x00020197 File Offset: 0x0001E397
		public unsafe Image progressBar1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_progressBar1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_progressBar1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x001630C4 File Offset: 0x001612C4
		// (set) Token: 0x0600397C RID: 14716 RVA: 0x000201B6 File Offset: 0x0001E3B6
		public unsafe Image progressBar2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_progressBar2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_progressBar2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x001630F4 File Offset: 0x001612F4
		// (set) Token: 0x0600397E RID: 14718 RVA: 0x000201D5 File Offset: 0x0001E3D5
		public unsafe Image timeBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_timeBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_timeBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x0600397F RID: 14719 RVA: 0x00163124 File Offset: 0x00161324
		// (set) Token: 0x06003980 RID: 14720 RVA: 0x000201F4 File Offset: 0x0001E3F4
		public unsafe TextMeshProUGUI text1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_text1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_text1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06003981 RID: 14721 RVA: 0x00163154 File Offset: 0x00161354
		// (set) Token: 0x06003982 RID: 14722 RVA: 0x00020213 File Offset: 0x0001E413
		public unsafe TextMeshProUGUI progressLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_progressLiteral);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_progressLiteral), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06003983 RID: 14723 RVA: 0x00163184 File Offset: 0x00161384
		// (set) Token: 0x06003984 RID: 14724 RVA: 0x00020232 File Offset: 0x0001E432
		public unsafe TextMeshProUGUI valueCurrent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_valueCurrent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_valueCurrent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x001631B4 File Offset: 0x001613B4
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x00020251 File Offset: 0x0001E451
		public unsafe TextMeshProUGUI valueTotal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_valueTotal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_valueTotal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06003987 RID: 14727 RVA: 0x001631E4 File Offset: 0x001613E4
		// (set) Token: 0x06003988 RID: 14728 RVA: 0x00020270 File Offset: 0x0001E470
		public unsafe Color32 phase1TitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase1TitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase1TitleColor)) = value;
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x0016320C File Offset: 0x0016140C
		// (set) Token: 0x0600398A RID: 14730 RVA: 0x0002028B File Offset: 0x0001E48B
		public unsafe Color32 phase2TitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase2TitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase2TitleColor)) = value;
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x0600398B RID: 14731 RVA: 0x00163234 File Offset: 0x00161434
		// (set) Token: 0x0600398C RID: 14732 RVA: 0x000202A6 File Offset: 0x0001E4A6
		public unsafe Color32 phase3TitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase3TitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase3TitleColor)) = value;
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x0016325C File Offset: 0x0016145C
		// (set) Token: 0x0600398E RID: 14734 RVA: 0x000202C1 File Offset: 0x0001E4C1
		public unsafe Color32 phase1ProgressLiteralColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase1ProgressLiteralColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase1ProgressLiteralColor)) = value;
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x0600398F RID: 14735 RVA: 0x00163284 File Offset: 0x00161484
		// (set) Token: 0x06003990 RID: 14736 RVA: 0x000202DC File Offset: 0x0001E4DC
		public unsafe Color32 phase2ProgressLiteralColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase2ProgressLiteralColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase2ProgressLiteralColor)) = value;
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06003991 RID: 14737 RVA: 0x001632AC File Offset: 0x001614AC
		// (set) Token: 0x06003992 RID: 14738 RVA: 0x000202F7 File Offset: 0x0001E4F7
		public unsafe Color32 phase3ProgressLiteralColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase3ProgressLiteralColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase3ProgressLiteralColor)) = value;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06003993 RID: 14739 RVA: 0x001632D4 File Offset: 0x001614D4
		// (set) Token: 0x06003994 RID: 14740 RVA: 0x00020312 File Offset: 0x0001E512
		public unsafe Color32 phase1Bar1Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase1Bar1Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase1Bar1Color)) = value;
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06003995 RID: 14741 RVA: 0x001632FC File Offset: 0x001614FC
		// (set) Token: 0x06003996 RID: 14742 RVA: 0x0002032D File Offset: 0x0001E52D
		public unsafe Color32 phase1Bar2Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase1Bar2Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase1Bar2Color)) = value;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x00163324 File Offset: 0x00161524
		// (set) Token: 0x06003998 RID: 14744 RVA: 0x00020348 File Offset: 0x0001E548
		public unsafe Color32 phase2Bar1Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase2Bar1Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase2Bar1Color)) = value;
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06003999 RID: 14745 RVA: 0x0016334C File Offset: 0x0016154C
		// (set) Token: 0x0600399A RID: 14746 RVA: 0x00020363 File Offset: 0x0001E563
		public unsafe Color32 phase2Bar2Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase2Bar2Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase2Bar2Color)) = value;
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600399B RID: 14747 RVA: 0x00163374 File Offset: 0x00161574
		// (set) Token: 0x0600399C RID: 14748 RVA: 0x0002037E File Offset: 0x0001E57E
		public unsafe Color32 phase3Bar1Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase3Bar1Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase3Bar1Color)) = value;
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x0600399D RID: 14749 RVA: 0x0016339C File Offset: 0x0016159C
		// (set) Token: 0x0600399E RID: 14750 RVA: 0x00020399 File Offset: 0x0001E599
		public unsafe Color32 phase3Bar2Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase3Bar2Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_phase3Bar2Color)) = value;
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x0600399F RID: 14751 RVA: 0x001633C4 File Offset: 0x001615C4
		// (set) Token: 0x060039A0 RID: 14752 RVA: 0x000203B4 File Offset: 0x0001E5B4
		public unsafe int currentProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_currentProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_currentProgress)) = value;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x060039A1 RID: 14753 RVA: 0x001633EC File Offset: 0x001615EC
		// (set) Token: 0x060039A2 RID: 14754 RVA: 0x000203CF File Offset: 0x0001E5CF
		public unsafe bool invert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_invert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_invert)) = value;
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x060039A3 RID: 14755 RVA: 0x00163414 File Offset: 0x00161614
		// (set) Token: 0x060039A4 RID: 14756 RVA: 0x000203EA File Offset: 0x0001E5EA
		public unsafe int maxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_maxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_maxValue)) = value;
			}
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x060039A5 RID: 14757 RVA: 0x0016343C File Offset: 0x0016163C
		// (set) Token: 0x060039A6 RID: 14758 RVA: 0x00020405 File Offset: 0x0001E605
		public unsafe Coroutine onUpdatingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_onUpdatingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_onUpdatingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x060039A7 RID: 14759 RVA: 0x0016346C File Offset: 0x0016166C
		// (set) Token: 0x060039A8 RID: 14760 RVA: 0x00020424 File Offset: 0x0001E624
		public unsafe string targetContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_targetContext);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_targetContext), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x060039A9 RID: 14761 RVA: 0x00163494 File Offset: 0x00161694
		// (set) Token: 0x060039AA RID: 14762 RVA: 0x00020443 File Offset: 0x0001E643
		public unsafe int targetProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_targetProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko.NativeFieldInfoPtr_targetProgress)) = value;
			}
		}

		// Token: 0x040026A8 RID: 9896
		private static readonly IntPtr NativeFieldInfoPtr_CHANGE_AMOUNT;

		// Token: 0x040026A9 RID: 9897
		private static readonly IntPtr NativeFieldInfoPtr_progressBar1;

		// Token: 0x040026AA RID: 9898
		private static readonly IntPtr NativeFieldInfoPtr_progressBar2;

		// Token: 0x040026AB RID: 9899
		private static readonly IntPtr NativeFieldInfoPtr_timeBar;

		// Token: 0x040026AC RID: 9900
		private static readonly IntPtr NativeFieldInfoPtr_text1;

		// Token: 0x040026AD RID: 9901
		private static readonly IntPtr NativeFieldInfoPtr_progressLiteral;

		// Token: 0x040026AE RID: 9902
		private static readonly IntPtr NativeFieldInfoPtr_valueCurrent;

		// Token: 0x040026AF RID: 9903
		private static readonly IntPtr NativeFieldInfoPtr_valueTotal;

		// Token: 0x040026B0 RID: 9904
		private static readonly IntPtr NativeFieldInfoPtr_phase1TitleColor;

		// Token: 0x040026B1 RID: 9905
		private static readonly IntPtr NativeFieldInfoPtr_phase2TitleColor;

		// Token: 0x040026B2 RID: 9906
		private static readonly IntPtr NativeFieldInfoPtr_phase3TitleColor;

		// Token: 0x040026B3 RID: 9907
		private static readonly IntPtr NativeFieldInfoPtr_phase1ProgressLiteralColor;

		// Token: 0x040026B4 RID: 9908
		private static readonly IntPtr NativeFieldInfoPtr_phase2ProgressLiteralColor;

		// Token: 0x040026B5 RID: 9909
		private static readonly IntPtr NativeFieldInfoPtr_phase3ProgressLiteralColor;

		// Token: 0x040026B6 RID: 9910
		private static readonly IntPtr NativeFieldInfoPtr_phase1Bar1Color;

		// Token: 0x040026B7 RID: 9911
		private static readonly IntPtr NativeFieldInfoPtr_phase1Bar2Color;

		// Token: 0x040026B8 RID: 9912
		private static readonly IntPtr NativeFieldInfoPtr_phase2Bar1Color;

		// Token: 0x040026B9 RID: 9913
		private static readonly IntPtr NativeFieldInfoPtr_phase2Bar2Color;

		// Token: 0x040026BA RID: 9914
		private static readonly IntPtr NativeFieldInfoPtr_phase3Bar1Color;

		// Token: 0x040026BB RID: 9915
		private static readonly IntPtr NativeFieldInfoPtr_phase3Bar2Color;

		// Token: 0x040026BC RID: 9916
		private static readonly IntPtr NativeFieldInfoPtr_currentProgress;

		// Token: 0x040026BD RID: 9917
		private static readonly IntPtr NativeFieldInfoPtr_invert;

		// Token: 0x040026BE RID: 9918
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x040026BF RID: 9919
		private static readonly IntPtr NativeFieldInfoPtr_onUpdatingData;

		// Token: 0x040026C0 RID: 9920
		private static readonly IntPtr NativeFieldInfoPtr_targetContext;

		// Token: 0x040026C1 RID: 9921
		private static readonly IntPtr NativeFieldInfoPtr_targetProgress;

		// Token: 0x040026C2 RID: 9922
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_String_0;

		// Token: 0x040026C3 RID: 9923
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040026C4 RID: 9924
		private static readonly IntPtr NativeMethodInfoPtr_SetContext_Public_Void_String_Int32_Int32_Phase_0;

		// Token: 0x040026C5 RID: 9925
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetProgress_Public_Void_Int32_0;

		// Token: 0x040026C6 RID: 9926
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetTime_Public_Void_Single_0;

		// Token: 0x040026C7 RID: 9927
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetProgressImmediate_Public_Void_Int32_0;

		// Token: 0x040026C8 RID: 9928
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateData_Private_Void_0;

		// Token: 0x040026C9 RID: 9929
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x040026CA RID: 9930
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateFund_Private_IEnumerator_0;

		// Token: 0x040026CB RID: 9931
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040026CC RID: 9932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040026CD RID: 9933
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0;

		// Token: 0x040026CE RID: 9934
		private static readonly IntPtr NativeMethodInfoPtr__SetTargetTime_b__31_0_Private_Void_Single_0;

		// Token: 0x040026CF RID: 9935
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__34_0_Private_Void_Single_0;

		// Token: 0x040026D0 RID: 9936
		private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__34_1_Private_Void_Single_0;

		// Token: 0x02000946 RID: 2374
		public enum Phase : byte
		{
			// Token: 0x0400782C RID: 30764
			Phase1,
			// Token: 0x0400782D RID: 30765
			Phase2,
			// Token: 0x0400782E RID: 30766
			Phase3
		}

		// Token: 0x02000947 RID: 2375
		[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerYuyuko+<OnUpdateFund>d__35")]
		public sealed class _OnUpdateFund_d__35 : Il2CppSystem.Object
		{
			// Token: 0x0600B9F8 RID: 47608 RVA: 0x002EEC3C File Offset: 0x002ECE3C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnUpdateFund_d__35()
			{
				Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerYuyuko>.NativeClassPtr, "<OnUpdateFund>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr);
				IncomeControllerYuyuko._OnUpdateFund_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr, "<>1__state");
				IncomeControllerYuyuko._OnUpdateFund_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr, "<>2__current");
				IncomeControllerYuyuko._OnUpdateFund_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr, "<>4__this");
				IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr, 100674049);
				IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr, 100674050);
				IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr, 100674051);
				IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr, 100674052);
				IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr, 100674053);
				IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr, 100674054);
			}

			// Token: 0x0600B9F9 RID: 47609 RVA: 0x002EED1C File Offset: 0x002ECF1C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnUpdateFund_d__35(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerYuyuko._OnUpdateFund_d__35>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9FA RID: 47610 RVA: 0x002EED64 File Offset: 0x002ECF64
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9FB RID: 47611 RVA: 0x002EED98 File Offset: 0x002ECF98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131371, XrefRangeEnd = 131374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003CEB RID: 15595
			// (get) Token: 0x0600B9FC RID: 47612 RVA: 0x002EEDD4 File Offset: 0x002ECFD4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9FD RID: 47613 RVA: 0x002EEE14 File Offset: 0x002ED014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131374, XrefRangeEnd = 131380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003CEC RID: 15596
			// (get) Token: 0x0600B9FE RID: 47614 RVA: 0x002EEE48 File Offset: 0x002ED048
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9FF RID: 47615 RVA: 0x000645AE File Offset: 0x000627AE
			public _OnUpdateFund_d__35(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CE8 RID: 15592
			// (get) Token: 0x0600BA00 RID: 47616 RVA: 0x002EEE88 File Offset: 0x002ED088
			// (set) Token: 0x0600BA01 RID: 47617 RVA: 0x000645B7 File Offset: 0x000627B7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CE9 RID: 15593
			// (get) Token: 0x0600BA02 RID: 47618 RVA: 0x002EEEB0 File Offset: 0x002ED0B0
			// (set) Token: 0x0600BA03 RID: 47619 RVA: 0x000645D2 File Offset: 0x000627D2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CEA RID: 15594
			// (get) Token: 0x0600BA04 RID: 47620 RVA: 0x002EEEE0 File Offset: 0x002ED0E0
			// (set) Token: 0x0600BA05 RID: 47621 RVA: 0x000645F1 File Offset: 0x000627F1
			public unsafe IncomeControllerYuyuko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerYuyuko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerYuyuko._OnUpdateFund_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400782F RID: 30767
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007830 RID: 30768
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007831 RID: 30769
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007832 RID: 30770
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007833 RID: 30771
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007834 RID: 30772
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007835 RID: 30773
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007836 RID: 30774
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007837 RID: 30775
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
