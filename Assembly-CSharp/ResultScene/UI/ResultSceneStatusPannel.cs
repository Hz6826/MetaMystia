using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ResultScene.UI
{
	// Token: 0x0200003A RID: 58
	public class ResultSceneStatusPannel : UIPanel
	{
		// Token: 0x0600062F RID: 1583 RVA: 0x000B21BC File Offset: 0x000B03BC
		// Note: this type is marked as 'beforefieldinit'.
		static ResultSceneStatusPannel()
		{
			Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ResultScene.UI", "ResultSceneStatusPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr);
			ResultSceneStatusPannel.NativeFieldInfoPtr_GAINED_OBJECTS_PAINT_FRAMES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "GAINED_OBJECTS_PAINT_FRAMES");
			ResultSceneStatusPannel.NativeFieldInfoPtr_DIGIT_TYPE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "DIGIT_TYPE_SPEED");
			ResultSceneStatusPannel.NativeFieldInfoPtr_showedObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "showedObjectParent");
			ResultSceneStatusPannel.NativeFieldInfoPtr_showedObjectParentWithNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "showedObjectParentWithNum");
			ResultSceneStatusPannel.NativeFieldInfoPtr_printObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "printObject");
			ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessExpences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "bussinessExpences");
			ResultSceneStatusPannel.NativeFieldInfoPtr_missionExpences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "missionExpences");
			ResultSceneStatusPannel.NativeFieldInfoPtr_debtValuePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "debtValuePairs");
			ResultSceneStatusPannel.NativeFieldInfoPtr_debtExpences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "debtExpences");
			ResultSceneStatusPannel.NativeFieldInfoPtr_partnerValuePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "partnerValuePairs");
			ResultSceneStatusPannel.NativeFieldInfoPtr_partnerExpences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "partnerExpences");
			ResultSceneStatusPannel.NativeFieldInfoPtr_missionIncome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "missionIncome");
			ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessIncome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "bussinessIncome");
			ResultSceneStatusPannel.NativeFieldInfoPtr_fee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "fee");
			ResultSceneStatusPannel.NativeFieldInfoPtr_netProfit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "netProfit");
			ResultSceneStatusPannel.NativeFieldInfoPtr_performanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "performanceCount");
			ResultSceneStatusPannel.NativeFieldInfoPtr_performanceSucceedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "performanceSucceedCount");
			ResultSceneStatusPannel.NativeFieldInfoPtr_performanceFullComboCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "performanceFullComboCount");
			ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessFoodConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "bussinessFoodConsumes");
			ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessBeverageConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "bussinessBeverageConsumes");
			ResultSceneStatusPannel.NativeFieldInfoPtr_missionIngredientConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "missionIngredientConsumes");
			ResultSceneStatusPannel.NativeFieldInfoPtr_missionFoodConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "missionFoodConsumes");
			ResultSceneStatusPannel.NativeFieldInfoPtr_missionBeverageConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "missionBeverageConsumes");
			ResultSceneStatusPannel.NativeFieldInfoPtr_invalidFoodConsumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "invalidFoodConsumes");
			ResultSceneStatusPannel.NativeFieldInfoPtr_gainExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "gainExp");
			ResultSceneStatusPannel.NativeFieldInfoPtr_maxCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "maxCombo");
			ResultSceneStatusPannel.NativeFieldInfoPtr_maxPassion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "maxPassion");
			ResultSceneStatusPannel.NativeFieldInfoPtr_visitors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "visitors");
			ResultSceneStatusPannel.NativeFieldInfoPtr_normalGuestReception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "normalGuestReception");
			ResultSceneStatusPannel.NativeFieldInfoPtr_specialGuestReception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "specialGuestReception");
			ResultSceneStatusPannel.NativeFieldInfoPtr_triggeredPositiveSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "triggeredPositiveSkill");
			ResultSceneStatusPannel.NativeFieldInfoPtr_triggeredNegativeSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "triggeredNegativeSkill");
			ResultSceneStatusPannel.NativeFieldInfoPtr_ClosePanelBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "ClosePanelBtn");
			ResultSceneStatusPannel.NativeFieldInfoPtr_ELEMENT_NUM_LINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "ELEMENT_NUM_LINE");
			ResultSceneStatusPannel.NativeFieldInfoPtr_ELEMENT_NUM_COLUMN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "ELEMENT_NUM_COLUMN");
			ResultSceneStatusPannel.NativeFieldInfoPtr_m_CurrentPaintNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "m_CurrentPaintNum");
			ResultSceneStatusPannel.NativeFieldInfoPtr_m_AutoScrollers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "m_AutoScrollers");
			ResultSceneStatusPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664212);
			ResultSceneStatusPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664213);
			ResultSceneStatusPannel.NativeMethodInfoPtr_ShowTrackedStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664214);
			ResultSceneStatusPannel.NativeMethodInfoPtr_Paint_Private_Void_RectTransform_IEnumerable_1_Int32_Func_2_Int32_Sprite_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664215);
			ResultSceneStatusPannel.NativeMethodInfoPtr_OnPaintEnd_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664216);
			ResultSceneStatusPannel.NativeMethodInfoPtr_Type_Public_Void_TextMeshProUGUI_String_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664217);
			ResultSceneStatusPannel.NativeMethodInfoPtr_DisposeWorkSceneData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664218);
			ResultSceneStatusPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664219);
			ResultSceneStatusPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664220);
			ResultSceneStatusPannel.NativeMethodInfoPtr_Method_Private_Void_RectTransform_IEnumerable_1_Int32_Func_2_Int32_Sprite_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664221);
			ResultSceneStatusPannel.NativeMethodInfoPtr_Method_Private_Void_TextMeshProUGUI_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664222);
			ResultSceneStatusPannel.NativeMethodInfoPtr__OnPaintEnd_b__41_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, 100664223);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000B25C0 File Offset: 0x000B07C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27078, XrefRangeEnd = 27087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResultSceneStatusPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000B25FC File Offset: 0x000B07FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27087, XrefRangeEnd = 27089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResultSceneStatusPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000B2638 File Offset: 0x000B0838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27279, RefRangeEnd = 27280, XrefRangeStart = 27089, XrefRangeEnd = 27279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTrackedStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.NativeMethodInfoPtr_ShowTrackedStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000B266C File Offset: 0x000B086C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 27350, RefRangeEnd = 27357, XrefRangeStart = 27280, XrefRangeEnd = 27350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Paint(RectTransform field, IEnumerable<int> collection, Func<int, Sprite> getSpriteCallback, int offset, int paintFrames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getSpriteCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paintFrames;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.NativeMethodInfoPtr_Paint_Private_Void_RectTransform_IEnumerable_1_Int32_Func_2_Int32_Sprite_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000B26F0 File Offset: 0x000B08F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27357, XrefRangeEnd = 27362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnPaintEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.NativeMethodInfoPtr_OnPaintEnd_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000B2730 File Offset: 0x000B0930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27362, XrefRangeEnd = 27382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Type(TextMeshProUGUI text, string prependValue, string appendValue, int targetValue, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prependValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appendValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.NativeMethodInfoPtr_Type_Public_Void_TextMeshProUGUI_String_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000B27B4 File Offset: 0x000B09B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27388, RefRangeEnd = 27389, XrefRangeStart = 27382, XrefRangeEnd = 27388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisposeWorkSceneData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.NativeMethodInfoPtr_DisposeWorkSceneData_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000B27DC File Offset: 0x000B09DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27389, XrefRangeEnd = 27424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResultSceneStatusPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x000B2818 File Offset: 0x000B0A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27424, XrefRangeEnd = 27433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResultSceneStatusPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000B2854 File Offset: 0x000B0A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27433, XrefRangeEnd = 27434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_RectTransform_IEnumerable_1_Int32_Func_2_Int32_Sprite_Int32_PDM_0(RectTransform field, IEnumerable<int> collection, Func<int, Sprite> getSpriteCallback, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getSpriteCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.NativeMethodInfoPtr_Method_Private_Void_RectTransform_IEnumerable_1_Int32_Func_2_Int32_Sprite_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000B28C8 File Offset: 0x000B0AC8
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 27458, RefRangeEnd = 27477, XrefRangeStart = 27434, XrefRangeEnd = 27458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_TextMeshProUGUI_Int32_String_String_0(TextMeshProUGUI textMesh, int targetValue, string prepend, string append)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(textMesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prepend);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(append);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.NativeMethodInfoPtr_Method_Private_Void_TextMeshProUGUI_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000B2940 File Offset: 0x000B0B40
		[CallerCount(0)]
		public unsafe bool _OnPaintEnd_b__41_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.NativeMethodInfoPtr__OnPaintEnd_b__41_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00005911 File Offset: 0x00003B11
		public ResultSceneStatusPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x000B297C File Offset: 0x000B0B7C
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x0000591A File Offset: 0x00003B1A
		public unsafe static int GAINED_OBJECTS_PAINT_FRAMES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.NativeFieldInfoPtr_GAINED_OBJECTS_PAINT_FRAMES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.NativeFieldInfoPtr_GAINED_OBJECTS_PAINT_FRAMES, (void*)(&value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x000B2998 File Offset: 0x000B0B98
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00005928 File Offset: 0x00003B28
		public unsafe static float DIGIT_TYPE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.NativeFieldInfoPtr_DIGIT_TYPE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.NativeFieldInfoPtr_DIGIT_TYPE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x000B29B4 File Offset: 0x000B0BB4
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00005936 File Offset: 0x00003B36
		public unsafe GameObject showedObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_showedObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_showedObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000B29E4 File Offset: 0x000B0BE4
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00005955 File Offset: 0x00003B55
		public unsafe GameObject showedObjectParentWithNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_showedObjectParentWithNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_showedObjectParentWithNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x000B2A14 File Offset: 0x000B0C14
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00005974 File Offset: 0x00003B74
		public unsafe AudioClip printObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_printObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_printObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x000B2A44 File Offset: 0x000B0C44
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00005993 File Offset: 0x00003B93
		public unsafe TextMeshProUGUI bussinessExpences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessExpences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessExpences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000B2A74 File Offset: 0x000B0C74
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x000059B2 File Offset: 0x00003BB2
		public unsafe TextMeshProUGUI missionExpences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_missionExpences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_missionExpences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000B2AA4 File Offset: 0x000B0CA4
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x000059D1 File Offset: 0x00003BD1
		public unsafe Il2CppReferenceArray<GameObject> debtValuePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_debtValuePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_debtValuePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x000B2AD4 File Offset: 0x000B0CD4
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x000059F0 File Offset: 0x00003BF0
		public unsafe TextMeshProUGUI debtExpences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_debtExpences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_debtExpences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000B2B04 File Offset: 0x000B0D04
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00005A0F File Offset: 0x00003C0F
		public unsafe Il2CppReferenceArray<GameObject> partnerValuePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_partnerValuePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_partnerValuePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x000B2B34 File Offset: 0x000B0D34
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00005A2E File Offset: 0x00003C2E
		public unsafe TextMeshProUGUI partnerExpences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_partnerExpences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_partnerExpences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x000B2B64 File Offset: 0x000B0D64
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00005A4D File Offset: 0x00003C4D
		public unsafe TextMeshProUGUI missionIncome
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_missionIncome);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_missionIncome), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x000B2B94 File Offset: 0x000B0D94
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00005A6C File Offset: 0x00003C6C
		public unsafe TextMeshProUGUI bussinessIncome
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessIncome);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessIncome), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x000B2BC4 File Offset: 0x000B0DC4
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x00005A8B File Offset: 0x00003C8B
		public unsafe TextMeshProUGUI fee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_fee);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_fee), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x000B2BF4 File Offset: 0x000B0DF4
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00005AAA File Offset: 0x00003CAA
		public unsafe TextMeshProUGUI netProfit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_netProfit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_netProfit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000B2C24 File Offset: 0x000B0E24
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00005AC9 File Offset: 0x00003CC9
		public unsafe TextMeshProUGUI performanceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_performanceCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_performanceCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x000B2C54 File Offset: 0x000B0E54
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00005AE8 File Offset: 0x00003CE8
		public unsafe TextMeshProUGUI performanceSucceedCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_performanceSucceedCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_performanceSucceedCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x000B2C84 File Offset: 0x000B0E84
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x00005B07 File Offset: 0x00003D07
		public unsafe TextMeshProUGUI performanceFullComboCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_performanceFullComboCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_performanceFullComboCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x000B2CB4 File Offset: 0x000B0EB4
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x00005B26 File Offset: 0x00003D26
		public unsafe RectTransform bussinessFoodConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessFoodConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessFoodConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x000B2CE4 File Offset: 0x000B0EE4
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x00005B45 File Offset: 0x00003D45
		public unsafe RectTransform bussinessBeverageConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessBeverageConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_bussinessBeverageConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x000B2D14 File Offset: 0x000B0F14
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00005B64 File Offset: 0x00003D64
		public unsafe RectTransform missionIngredientConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_missionIngredientConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_missionIngredientConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x000B2D44 File Offset: 0x000B0F44
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00005B83 File Offset: 0x00003D83
		public unsafe RectTransform missionFoodConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_missionFoodConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_missionFoodConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x000B2D74 File Offset: 0x000B0F74
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00005BA2 File Offset: 0x00003DA2
		public unsafe RectTransform missionBeverageConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_missionBeverageConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_missionBeverageConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000B2DA4 File Offset: 0x000B0FA4
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00005BC1 File Offset: 0x00003DC1
		public unsafe RectTransform invalidFoodConsumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_invalidFoodConsumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_invalidFoodConsumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x000B2DD4 File Offset: 0x000B0FD4
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00005BE0 File Offset: 0x00003DE0
		public unsafe TextMeshProUGUI gainExp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_gainExp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_gainExp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x000B2E04 File Offset: 0x000B1004
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00005BFF File Offset: 0x00003DFF
		public unsafe TextMeshProUGUI maxCombo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_maxCombo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_maxCombo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x000B2E34 File Offset: 0x000B1034
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00005C1E File Offset: 0x00003E1E
		public unsafe TextMeshProUGUI maxPassion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_maxPassion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_maxPassion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x000B2E64 File Offset: 0x000B1064
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00005C3D File Offset: 0x00003E3D
		public unsafe TextMeshProUGUI visitors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_visitors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_visitors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x000B2E94 File Offset: 0x000B1094
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00005C5C File Offset: 0x00003E5C
		public unsafe TextMeshProUGUI normalGuestReception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_normalGuestReception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_normalGuestReception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x000B2EC4 File Offset: 0x000B10C4
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00005C7B File Offset: 0x00003E7B
		public unsafe TextMeshProUGUI specialGuestReception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_specialGuestReception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_specialGuestReception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x000B2EF4 File Offset: 0x000B10F4
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00005C9A File Offset: 0x00003E9A
		public unsafe TextMeshProUGUI triggeredPositiveSkill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_triggeredPositiveSkill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_triggeredPositiveSkill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x000B2F24 File Offset: 0x000B1124
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00005CB9 File Offset: 0x00003EB9
		public unsafe TextMeshProUGUI triggeredNegativeSkill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_triggeredNegativeSkill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_triggeredNegativeSkill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x000B2F54 File Offset: 0x000B1154
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00005CD8 File Offset: 0x00003ED8
		public unsafe UIButtonSimple ClosePanelBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_ClosePanelBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_ClosePanelBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x000B2F84 File Offset: 0x000B1184
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00005CF7 File Offset: 0x00003EF7
		public unsafe static int ELEMENT_NUM_LINE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.NativeFieldInfoPtr_ELEMENT_NUM_LINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.NativeFieldInfoPtr_ELEMENT_NUM_LINE, (void*)(&value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000B2FA0 File Offset: 0x000B11A0
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00005D05 File Offset: 0x00003F05
		public unsafe static int ELEMENT_NUM_COLUMN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.NativeFieldInfoPtr_ELEMENT_NUM_COLUMN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.NativeFieldInfoPtr_ELEMENT_NUM_COLUMN, (void*)(&value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x000B2FBC File Offset: 0x000B11BC
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00005D13 File Offset: 0x00003F13
		public unsafe int m_CurrentPaintNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_m_CurrentPaintNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_m_CurrentPaintNum)) = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000B2FE4 File Offset: 0x000B11E4
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00005D2E File Offset: 0x00003F2E
		public unsafe List<AutoScroller> m_AutoScrollers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_m_AutoScrollers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AutoScroller>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.NativeFieldInfoPtr_m_AutoScrollers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr_GAINED_OBJECTS_PAINT_FRAMES;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_DIGIT_TYPE_SPEED;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_showedObjectParent;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_showedObjectParentWithNum;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_printObject;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_bussinessExpences;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_missionExpences;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_debtValuePairs;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_debtExpences;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_partnerValuePairs;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_partnerExpences;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_missionIncome;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_bussinessIncome;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_fee;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_netProfit;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_performanceCount;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_performanceSucceedCount;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_performanceFullComboCount;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_bussinessFoodConsumes;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_bussinessBeverageConsumes;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_missionIngredientConsumes;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_missionFoodConsumes;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_missionBeverageConsumes;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_invalidFoodConsumes;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_gainExp;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_maxCombo;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr_maxPassion;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr_visitors;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr_normalGuestReception;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestReception;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_triggeredPositiveSkill;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr_triggeredNegativeSkill;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr_ClosePanelBtn;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr_ELEMENT_NUM_LINE;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr_ELEMENT_NUM_COLUMN;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPaintNum;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoScrollers;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_ShowTrackedStatus_Private_Void_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_Paint_Private_Void_RectTransform_IEnumerable_1_Int32_Func_2_Int32_Sprite_Int32_Int32_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_OnPaintEnd_Private_IEnumerator_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_Type_Public_Void_TextMeshProUGUI_String_String_Int32_Single_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_DisposeWorkSceneData_Public_Static_Void_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_RectTransform_IEnumerable_1_Int32_Func_2_Int32_Sprite_Int32_PDM_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_TextMeshProUGUI_Int32_String_String_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr__OnPaintEnd_b__41_0_Private_Boolean_0;

		// Token: 0x020004D4 RID: 1236
		[ObfuscatedName("ResultScene.UI.ResultSceneStatusPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060080EC RID: 33004 RVA: 0x002471C4 File Offset: 0x002453C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr);
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__39_2");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__39_3");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__39_4");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__39_5");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__39_6");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__39_7");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__39_8");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__39_9");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__40_0");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__40_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__40_1");
				ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__40_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, "<>9__40_2");
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664225);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664226);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_3_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664227);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_4_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664228);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_5_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664229);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_6_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664230);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_7_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664231);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_8_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664232);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_9_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664233);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__Paint_b__40_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664234);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__Paint_b__40_1_Internal_Int32_IGrouping_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664235);
				ResultSceneStatusPannel.__c.NativeMethodInfoPtr__Paint_b__40_2_Internal_Int32_IGrouping_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr, 100664236);
			}

			// Token: 0x060080ED RID: 33005 RVA: 0x002473D0 File Offset: 0x002455D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneStatusPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080EE RID: 33006 RVA: 0x0024740C File Offset: 0x0024560C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26889, XrefRangeEnd = 26891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowTrackedStatus_b__39_2(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080EF RID: 33007 RVA: 0x00247450 File Offset: 0x00245650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowTrackedStatus_b__39_3(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_3_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060080F0 RID: 33008 RVA: 0x00247494 File Offset: 0x00245694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26891, XrefRangeEnd = 26892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _ShowTrackedStatus_b__39_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_4_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x060080F1 RID: 33009 RVA: 0x002474E0 File Offset: 0x002456E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26892, XrefRangeEnd = 26893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _ShowTrackedStatus_b__39_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_5_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x060080F2 RID: 33010 RVA: 0x0024752C File Offset: 0x0024572C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26893, XrefRangeEnd = 26894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _ShowTrackedStatus_b__39_6(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_6_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x060080F3 RID: 33011 RVA: 0x00247578 File Offset: 0x00245778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _ShowTrackedStatus_b__39_7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_7_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x060080F4 RID: 33012 RVA: 0x002475C4 File Offset: 0x002457C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _ShowTrackedStatus_b__39_8(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_8_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x060080F5 RID: 33013 RVA: 0x00247610 File Offset: 0x00245810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _ShowTrackedStatus_b__39_9(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__ShowTrackedStatus_b__39_9_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x060080F6 RID: 33014 RVA: 0x0024765C File Offset: 0x0024585C
			[CallerCount(0)]
			public unsafe int _Paint_b__40_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__Paint_b__40_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060080F7 RID: 33015 RVA: 0x002476A8 File Offset: 0x002458A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26894, XrefRangeEnd = 26898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Paint_b__40_1(IGrouping<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__Paint_b__40_1_Internal_Int32_IGrouping_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060080F8 RID: 33016 RVA: 0x002476F8 File Offset: 0x002458F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26898, XrefRangeEnd = 26901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Paint_b__40_2(IGrouping<int, int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c.NativeMethodInfoPtr__Paint_b__40_2_Internal_Int32_IGrouping_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060080F9 RID: 33017 RVA: 0x00045B48 File Offset: 0x00043D48
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B7E RID: 11134
			// (get) Token: 0x060080FA RID: 33018 RVA: 0x00247748 File Offset: 0x00245948
			// (set) Token: 0x060080FB RID: 33019 RVA: 0x00045B51 File Offset: 0x00043D51
			public unsafe static ResultSceneStatusPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneStatusPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B7F RID: 11135
			// (get) Token: 0x060080FC RID: 33020 RVA: 0x00247770 File Offset: 0x00245970
			// (set) Token: 0x060080FD RID: 33021 RVA: 0x00045B63 File Offset: 0x00043D63
			public unsafe static Action<GameObject> __9__39_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B80 RID: 11136
			// (get) Token: 0x060080FE RID: 33022 RVA: 0x00247798 File Offset: 0x00245998
			// (set) Token: 0x060080FF RID: 33023 RVA: 0x00045B75 File Offset: 0x00043D75
			public unsafe static Action<GameObject> __9__39_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B81 RID: 11137
			// (get) Token: 0x06008100 RID: 33024 RVA: 0x002477C0 File Offset: 0x002459C0
			// (set) Token: 0x06008101 RID: 33025 RVA: 0x00045B87 File Offset: 0x00043D87
			public unsafe static Func<int, Sprite> __9__39_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B82 RID: 11138
			// (get) Token: 0x06008102 RID: 33026 RVA: 0x002477E8 File Offset: 0x002459E8
			// (set) Token: 0x06008103 RID: 33027 RVA: 0x00045B99 File Offset: 0x00043D99
			public unsafe static Func<int, Sprite> __9__39_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B83 RID: 11139
			// (get) Token: 0x06008104 RID: 33028 RVA: 0x00247810 File Offset: 0x00245A10
			// (set) Token: 0x06008105 RID: 33029 RVA: 0x00045BAB File Offset: 0x00043DAB
			public unsafe static Func<int, Sprite> __9__39_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B84 RID: 11140
			// (get) Token: 0x06008106 RID: 33030 RVA: 0x00247838 File Offset: 0x00245A38
			// (set) Token: 0x06008107 RID: 33031 RVA: 0x00045BBD File Offset: 0x00043DBD
			public unsafe static Func<int, Sprite> __9__39_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B85 RID: 11141
			// (get) Token: 0x06008108 RID: 33032 RVA: 0x00247860 File Offset: 0x00245A60
			// (set) Token: 0x06008109 RID: 33033 RVA: 0x00045BCF File Offset: 0x00043DCF
			public unsafe static Func<int, Sprite> __9__39_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B86 RID: 11142
			// (get) Token: 0x0600810A RID: 33034 RVA: 0x00247888 File Offset: 0x00245A88
			// (set) Token: 0x0600810B RID: 33035 RVA: 0x00045BE1 File Offset: 0x00043DE1
			public unsafe static Func<int, Sprite> __9__39_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__39_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B87 RID: 11143
			// (get) Token: 0x0600810C RID: 33036 RVA: 0x002478B0 File Offset: 0x00245AB0
			// (set) Token: 0x0600810D RID: 33037 RVA: 0x00045BF3 File Offset: 0x00043DF3
			public unsafe static Func<int, int> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B88 RID: 11144
			// (get) Token: 0x0600810E RID: 33038 RVA: 0x002478D8 File Offset: 0x00245AD8
			// (set) Token: 0x0600810F RID: 33039 RVA: 0x00045C05 File Offset: 0x00043E05
			public unsafe static Func<IGrouping<int, int>, int> __9__40_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__40_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__40_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B89 RID: 11145
			// (get) Token: 0x06008110 RID: 33040 RVA: 0x00247900 File Offset: 0x00245B00
			// (set) Token: 0x06008111 RID: 33041 RVA: 0x00045C17 File Offset: 0x00043E17
			public unsafe static Func<IGrouping<int, int>, int> __9__40_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__40_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResultSceneStatusPannel.__c.NativeFieldInfoPtr___9__40_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400547F RID: 21631
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005480 RID: 21632
			private static readonly IntPtr NativeFieldInfoPtr___9__39_2;

			// Token: 0x04005481 RID: 21633
			private static readonly IntPtr NativeFieldInfoPtr___9__39_3;

			// Token: 0x04005482 RID: 21634
			private static readonly IntPtr NativeFieldInfoPtr___9__39_4;

			// Token: 0x04005483 RID: 21635
			private static readonly IntPtr NativeFieldInfoPtr___9__39_5;

			// Token: 0x04005484 RID: 21636
			private static readonly IntPtr NativeFieldInfoPtr___9__39_6;

			// Token: 0x04005485 RID: 21637
			private static readonly IntPtr NativeFieldInfoPtr___9__39_7;

			// Token: 0x04005486 RID: 21638
			private static readonly IntPtr NativeFieldInfoPtr___9__39_8;

			// Token: 0x04005487 RID: 21639
			private static readonly IntPtr NativeFieldInfoPtr___9__39_9;

			// Token: 0x04005488 RID: 21640
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04005489 RID: 21641
			private static readonly IntPtr NativeFieldInfoPtr___9__40_1;

			// Token: 0x0400548A RID: 21642
			private static readonly IntPtr NativeFieldInfoPtr___9__40_2;

			// Token: 0x0400548B RID: 21643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400548C RID: 21644
			private static readonly IntPtr NativeMethodInfoPtr__ShowTrackedStatus_b__39_2_Internal_Void_GameObject_0;

			// Token: 0x0400548D RID: 21645
			private static readonly IntPtr NativeMethodInfoPtr__ShowTrackedStatus_b__39_3_Internal_Void_GameObject_0;

			// Token: 0x0400548E RID: 21646
			private static readonly IntPtr NativeMethodInfoPtr__ShowTrackedStatus_b__39_4_Internal_Sprite_Int32_0;

			// Token: 0x0400548F RID: 21647
			private static readonly IntPtr NativeMethodInfoPtr__ShowTrackedStatus_b__39_5_Internal_Sprite_Int32_0;

			// Token: 0x04005490 RID: 21648
			private static readonly IntPtr NativeMethodInfoPtr__ShowTrackedStatus_b__39_6_Internal_Sprite_Int32_0;

			// Token: 0x04005491 RID: 21649
			private static readonly IntPtr NativeMethodInfoPtr__ShowTrackedStatus_b__39_7_Internal_Sprite_Int32_0;

			// Token: 0x04005492 RID: 21650
			private static readonly IntPtr NativeMethodInfoPtr__ShowTrackedStatus_b__39_8_Internal_Sprite_Int32_0;

			// Token: 0x04005493 RID: 21651
			private static readonly IntPtr NativeMethodInfoPtr__ShowTrackedStatus_b__39_9_Internal_Sprite_Int32_0;

			// Token: 0x04005494 RID: 21652
			private static readonly IntPtr NativeMethodInfoPtr__Paint_b__40_0_Internal_Int32_Int32_0;

			// Token: 0x04005495 RID: 21653
			private static readonly IntPtr NativeMethodInfoPtr__Paint_b__40_1_Internal_Int32_IGrouping_2_Int32_Int32_0;

			// Token: 0x04005496 RID: 21654
			private static readonly IntPtr NativeMethodInfoPtr__Paint_b__40_2_Internal_Int32_IGrouping_2_Int32_Int32_0;
		}

		// Token: 0x020004D5 RID: 1237
		[ObfuscatedName("ResultScene.UI.ResultSceneStatusPannel+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
		{
			// Token: 0x06008112 RID: 33042 RVA: 0x00247928 File Offset: 0x00245B28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr);
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, "offset");
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_paintFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, "paintFrames");
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, "<>4__this");
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, "field");
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_getSpriteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, "getSpriteCallback");
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_allCollectionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, "allCollectionQueue");
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_currentPaintFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, "currentPaintFrames");
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_objectNumDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, "objectNumDic");
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, "<>9__4");
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, 100664237);
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, 100664238);
				ResultSceneStatusPannel.__c__DisplayClass40_0.NativeMethodInfoPtr__Paint_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, 100664239);
			}

			// Token: 0x06008113 RID: 33043 RVA: 0x00247A44 File Offset: 0x00245C44
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008114 RID: 33044 RVA: 0x00247A80 File Offset: 0x00245C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27028, XrefRangeEnd = 27033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008115 RID: 33045 RVA: 0x00247AC0 File Offset: 0x00245CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27033, XrefRangeEnd = 27039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Paint_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeMethodInfoPtr__Paint_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008116 RID: 33046 RVA: 0x00045C29 File Offset: 0x00043E29
			public __c__DisplayClass40_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B8A RID: 11146
			// (get) Token: 0x06008117 RID: 33047 RVA: 0x00247B04 File Offset: 0x00245D04
			// (set) Token: 0x06008118 RID: 33048 RVA: 0x00045C32 File Offset: 0x00043E32
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17002B8B RID: 11147
			// (get) Token: 0x06008119 RID: 33049 RVA: 0x00247B2C File Offset: 0x00245D2C
			// (set) Token: 0x0600811A RID: 33050 RVA: 0x00045C4D File Offset: 0x00043E4D
			public unsafe int paintFrames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_paintFrames);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_paintFrames)) = value;
				}
			}

			// Token: 0x17002B8C RID: 11148
			// (get) Token: 0x0600811B RID: 33051 RVA: 0x00247B54 File Offset: 0x00245D54
			// (set) Token: 0x0600811C RID: 33052 RVA: 0x00045C68 File Offset: 0x00043E68
			public unsafe ResultSceneStatusPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneStatusPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B8D RID: 11149
			// (get) Token: 0x0600811D RID: 33053 RVA: 0x00247B84 File Offset: 0x00245D84
			// (set) Token: 0x0600811E RID: 33054 RVA: 0x00045C87 File Offset: 0x00043E87
			public unsafe RectTransform field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_field);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_field), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B8E RID: 11150
			// (get) Token: 0x0600811F RID: 33055 RVA: 0x00247BB4 File Offset: 0x00245DB4
			// (set) Token: 0x06008120 RID: 33056 RVA: 0x00045CA6 File Offset: 0x00043EA6
			public unsafe Func<int, Sprite> getSpriteCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_getSpriteCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_getSpriteCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B8F RID: 11151
			// (get) Token: 0x06008121 RID: 33057 RVA: 0x00247BE4 File Offset: 0x00245DE4
			// (set) Token: 0x06008122 RID: 33058 RVA: 0x00045CC5 File Offset: 0x00043EC5
			public unsafe Queue<int> allCollectionQueue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_allCollectionQueue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_allCollectionQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B90 RID: 11152
			// (get) Token: 0x06008123 RID: 33059 RVA: 0x00247C14 File Offset: 0x00245E14
			// (set) Token: 0x06008124 RID: 33060 RVA: 0x00045CE4 File Offset: 0x00043EE4
			public unsafe int currentPaintFrames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_currentPaintFrames);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_currentPaintFrames)) = value;
				}
			}

			// Token: 0x17002B91 RID: 11153
			// (get) Token: 0x06008125 RID: 33061 RVA: 0x00247C3C File Offset: 0x00245E3C
			// (set) Token: 0x06008126 RID: 33062 RVA: 0x00045CFF File Offset: 0x00043EFF
			public unsafe Dictionary<int, int> objectNumDic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_objectNumDic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr_objectNumDic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B92 RID: 11154
			// (get) Token: 0x06008127 RID: 33063 RVA: 0x00247C6C File Offset: 0x00245E6C
			// (set) Token: 0x06008128 RID: 33064 RVA: 0x00045D1E File Offset: 0x00043F1E
			public unsafe Action<Image> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005497 RID: 21655
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04005498 RID: 21656
			private static readonly IntPtr NativeFieldInfoPtr_paintFrames;

			// Token: 0x04005499 RID: 21657
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400549A RID: 21658
			private static readonly IntPtr NativeFieldInfoPtr_field;

			// Token: 0x0400549B RID: 21659
			private static readonly IntPtr NativeFieldInfoPtr_getSpriteCallback;

			// Token: 0x0400549C RID: 21660
			private static readonly IntPtr NativeFieldInfoPtr_allCollectionQueue;

			// Token: 0x0400549D RID: 21661
			private static readonly IntPtr NativeFieldInfoPtr_currentPaintFrames;

			// Token: 0x0400549E RID: 21662
			private static readonly IntPtr NativeFieldInfoPtr_objectNumDic;

			// Token: 0x0400549F RID: 21663
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x040054A0 RID: 21664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040054A1 RID: 21665
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040054A2 RID: 21666
			private static readonly IntPtr NativeMethodInfoPtr__Paint_b__4_Internal_Void_Image_0;

			// Token: 0x02000FAC RID: 4012
			[ObfuscatedName("ResultScene.UI.ResultSceneStatusPannel+<>c__DisplayClass40_0+<<Paint>g__OnPaintingCollection|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique : Il2CppSystem.Object
			{
				// Token: 0x060114CE RID: 70862 RVA: 0x003FB3BC File Offset: 0x003F95BC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique()
				{
					Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0>.NativeClassPtr, "<<Paint>g__OnPaintingCollection|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr);
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, "<>1__state");
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, "<>2__current");
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, "<>4__this");
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr__spawnedObjects_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, "<spawnedObjects>5__2");
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, "<i>5__3");
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, "<>7__wrap3");
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, 100664240);
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, 100664241);
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, 100664242);
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, 100664243);
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, 100664244);
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, 100664245);
					ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr, 100664246);
				}

				// Token: 0x060114CF RID: 70863 RVA: 0x003FB4EC File Offset: 0x003F96EC
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114D0 RID: 70864 RVA: 0x003FB534 File Offset: 0x003F9734
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 26906, RefRangeEnd = 26907, XrefRangeStart = 26901, XrefRangeEnd = 26906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114D1 RID: 70865 RVA: 0x003FB568 File Offset: 0x003F9768
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26907, XrefRangeEnd = 27019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060114D2 RID: 70866 RVA: 0x003FB5A4 File Offset: 0x003F97A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27019, XrefRangeEnd = 27022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __m__Finally1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170059F4 RID: 23028
				// (get) Token: 0x060114D3 RID: 70867 RVA: 0x003FB5D8 File Offset: 0x003F97D8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060114D4 RID: 70868 RVA: 0x003FB618 File Offset: 0x003F9818
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27022, XrefRangeEnd = 27028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170059F5 RID: 23029
				// (get) Token: 0x060114D5 RID: 70869 RVA: 0x003FB64C File Offset: 0x003F984C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060114D6 RID: 70870 RVA: 0x00096800 File Offset: 0x00094A00
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170059EE RID: 23022
				// (get) Token: 0x060114D7 RID: 70871 RVA: 0x003FB68C File Offset: 0x003F988C
				// (set) Token: 0x060114D8 RID: 70872 RVA: 0x00096809 File Offset: 0x00094A09
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170059EF RID: 23023
				// (get) Token: 0x060114D9 RID: 70873 RVA: 0x003FB6B4 File Offset: 0x003F98B4
				// (set) Token: 0x060114DA RID: 70874 RVA: 0x00096824 File Offset: 0x00094A24
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059F0 RID: 23024
				// (get) Token: 0x060114DB RID: 70875 RVA: 0x003FB6E4 File Offset: 0x003F98E4
				// (set) Token: 0x060114DC RID: 70876 RVA: 0x00096843 File Offset: 0x00094A43
				public unsafe ResultSceneStatusPannel.__c__DisplayClass40_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneStatusPannel.__c__DisplayClass40_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059F1 RID: 23025
				// (get) Token: 0x060114DD RID: 70877 RVA: 0x003FB714 File Offset: 0x003F9914
				// (set) Token: 0x060114DE RID: 70878 RVA: 0x00096862 File Offset: 0x00094A62
				public unsafe HashSet<GameObject> _spawnedObjects_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr__spawnedObjects_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr__spawnedObjects_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059F2 RID: 23026
				// (get) Token: 0x060114DF RID: 70879 RVA: 0x003FB744 File Offset: 0x003F9944
				// (set) Token: 0x060114E0 RID: 70880 RVA: 0x00096881 File Offset: 0x00094A81
				public unsafe int _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x170059F3 RID: 23027
				// (get) Token: 0x060114E1 RID: 70881 RVA: 0x003FB76C File Offset: 0x003F996C
				// (set) Token: 0x060114E2 RID: 70882 RVA: 0x0009689C File Offset: 0x00094A9C
				public Dictionary<int, int>.Enumerator __7__wrap3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___7__wrap3);
						return new Dictionary<int, int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<int, int>.Enumerator>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObHa1GaEnIn2ObInUnique.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<int, int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400AEE1 RID: 44769
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEE2 RID: 44770
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AEE3 RID: 44771
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEE4 RID: 44772
				private static readonly IntPtr NativeFieldInfoPtr__spawnedObjects_5__2;

				// Token: 0x0400AEE5 RID: 44773
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400AEE6 RID: 44774
				private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

				// Token: 0x0400AEE7 RID: 44775
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AEE8 RID: 44776
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEE9 RID: 44777
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AEEA RID: 44778
				private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

				// Token: 0x0400AEEB RID: 44779
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AEEC RID: 44780
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEED RID: 44781
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020004D6 RID: 1238
		[ObfuscatedName("ResultScene.UI.ResultSceneStatusPannel+<>c__DisplayClass40_1")]
		public sealed class __c__DisplayClass40_1 : Il2CppSystem.Object
		{
			// Token: 0x06008129 RID: 33065 RVA: 0x00247C9C File Offset: 0x00245E9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_1()
			{
				Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "<>c__DisplayClass40_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_1>.NativeClassPtr);
				ResultSceneStatusPannel.__c__DisplayClass40_1.NativeFieldInfoPtr_newPaintPair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_1>.NativeClassPtr, "newPaintPair");
				ResultSceneStatusPannel.__c__DisplayClass40_1.NativeFieldInfoPtr_field_Public___c__DisplayClass40_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_1>.NativeClassPtr, "CS$<>8__locals1");
				ResultSceneStatusPannel.__c__DisplayClass40_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_1>.NativeClassPtr, 100664247);
				ResultSceneStatusPannel.__c__DisplayClass40_1.NativeMethodInfoPtr__Paint_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_1>.NativeClassPtr, 100664248);
				ResultSceneStatusPannel.__c__DisplayClass40_1.NativeMethodInfoPtr__Paint_b__6_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_1>.NativeClassPtr, 100664249);
				ResultSceneStatusPannel.__c__DisplayClass40_1.NativeMethodInfoPtr__Paint_b__7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_1>.NativeClassPtr, 100664250);
			}

			// Token: 0x0600812A RID: 33066 RVA: 0x00247D40 File Offset: 0x00245F40
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass40_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600812B RID: 33067 RVA: 0x00247D7C File Offset: 0x00245F7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27039, XrefRangeEnd = 27043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Paint_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_1.NativeMethodInfoPtr__Paint_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600812C RID: 33068 RVA: 0x00247DC0 File Offset: 0x00245FC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27043, XrefRangeEnd = 27045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Paint_b__6(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_1.NativeMethodInfoPtr__Paint_b__6_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600812D RID: 33069 RVA: 0x00247E04 File Offset: 0x00246004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27045, XrefRangeEnd = 27047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Paint_b__7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass40_1.NativeMethodInfoPtr__Paint_b__7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600812E RID: 33070 RVA: 0x00045D3D File Offset: 0x00043F3D
			public __c__DisplayClass40_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B93 RID: 11155
			// (get) Token: 0x0600812F RID: 33071 RVA: 0x00247E48 File Offset: 0x00246048
			// (set) Token: 0x06008130 RID: 33072 RVA: 0x00045D46 File Offset: 0x00043F46
			public KeyValuePair<int, int> newPaintPair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_1.NativeFieldInfoPtr_newPaintPair);
					return new KeyValuePair<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<int, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_1.NativeFieldInfoPtr_newPaintPair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<int, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B94 RID: 11156
			// (get) Token: 0x06008131 RID: 33073 RVA: 0x00247E78 File Offset: 0x00246078
			// (set) Token: 0x06008132 RID: 33074 RVA: 0x00045D74 File Offset: 0x00043F74
			public unsafe ResultSceneStatusPannel.__c__DisplayClass40_0 field_Public___c__DisplayClass40_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_1.NativeFieldInfoPtr_field_Public___c__DisplayClass40_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneStatusPannel.__c__DisplayClass40_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass40_1.NativeFieldInfoPtr_field_Public___c__DisplayClass40_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040054A3 RID: 21667
			private static readonly IntPtr NativeFieldInfoPtr_newPaintPair;

			// Token: 0x040054A4 RID: 21668
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass40_0_0;

			// Token: 0x040054A5 RID: 21669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040054A6 RID: 21670
			private static readonly IntPtr NativeMethodInfoPtr__Paint_b__5_Internal_Void_Image_0;

			// Token: 0x040054A7 RID: 21671
			private static readonly IntPtr NativeMethodInfoPtr__Paint_b__6_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x040054A8 RID: 21672
			private static readonly IntPtr NativeMethodInfoPtr__Paint_b__7_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x020004D7 RID: 1239
		[ObfuscatedName("ResultScene.UI.ResultSceneStatusPannel+<OnPaintEnd>d__41")]
		public sealed class _OnPaintEnd_d__41 : Il2CppSystem.Object
		{
			// Token: 0x06008133 RID: 33075 RVA: 0x00247EA8 File Offset: 0x002460A8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPaintEnd_d__41()
			{
				Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "<OnPaintEnd>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr);
				ResultSceneStatusPannel._OnPaintEnd_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr, "<>1__state");
				ResultSceneStatusPannel._OnPaintEnd_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr, "<>2__current");
				ResultSceneStatusPannel._OnPaintEnd_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr, "<>4__this");
				ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr, 100664251);
				ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr, 100664252);
				ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr, 100664253);
				ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr, 100664254);
				ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr, 100664255);
				ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr, 100664256);
			}

			// Token: 0x06008134 RID: 33076 RVA: 0x00247F88 File Offset: 0x00246188
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPaintEnd_d__41(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneStatusPannel._OnPaintEnd_d__41>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008135 RID: 33077 RVA: 0x00247FD0 File Offset: 0x002461D0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008136 RID: 33078 RVA: 0x00248004 File Offset: 0x00246204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27047, XrefRangeEnd = 27058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002B98 RID: 11160
			// (get) Token: 0x06008137 RID: 33079 RVA: 0x00248040 File Offset: 0x00246240
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008138 RID: 33080 RVA: 0x00248080 File Offset: 0x00246280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27058, XrefRangeEnd = 27064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B99 RID: 11161
			// (get) Token: 0x06008139 RID: 33081 RVA: 0x002480B4 File Offset: 0x002462B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600813A RID: 33082 RVA: 0x00045D93 File Offset: 0x00043F93
			public _OnPaintEnd_d__41(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B95 RID: 11157
			// (get) Token: 0x0600813B RID: 33083 RVA: 0x002480F4 File Offset: 0x002462F4
			// (set) Token: 0x0600813C RID: 33084 RVA: 0x00045D9C File Offset: 0x00043F9C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B96 RID: 11158
			// (get) Token: 0x0600813D RID: 33085 RVA: 0x0024811C File Offset: 0x0024631C
			// (set) Token: 0x0600813E RID: 33086 RVA: 0x00045DB7 File Offset: 0x00043FB7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B97 RID: 11159
			// (get) Token: 0x0600813F RID: 33087 RVA: 0x0024814C File Offset: 0x0024634C
			// (set) Token: 0x06008140 RID: 33088 RVA: 0x00045DD6 File Offset: 0x00043FD6
			public unsafe ResultSceneStatusPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneStatusPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel._OnPaintEnd_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040054A9 RID: 21673
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040054AA RID: 21674
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040054AB RID: 21675
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040054AC RID: 21676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040054AD RID: 21677
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040054AE RID: 21678
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040054AF RID: 21679
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040054B0 RID: 21680
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040054B1 RID: 21681
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020004D8 RID: 1240
		[ObfuscatedName("ResultScene.UI.ResultSceneStatusPannel+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x06008141 RID: 33089 RVA: 0x0024817C File Offset: 0x0024637C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultSceneStatusPannel>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass42_0>.NativeClassPtr);
				ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass42_0>.NativeClassPtr, "text");
				ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_prependValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass42_0>.NativeClassPtr, "prependValue");
				ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_targetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass42_0>.NativeClassPtr, "targetValue");
				ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_appendValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass42_0>.NativeClassPtr, "appendValue");
				ResultSceneStatusPannel.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass42_0>.NativeClassPtr, 100664257);
				ResultSceneStatusPannel.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass42_0>.NativeClassPtr, 100664258);
				ResultSceneStatusPannel.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass42_0>.NativeClassPtr, 100664259);
			}

			// Token: 0x06008142 RID: 33090 RVA: 0x00248234 File Offset: 0x00246434
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultSceneStatusPannel.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008143 RID: 33091 RVA: 0x00248270 File Offset: 0x00246470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27064, XrefRangeEnd = 27072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Single_PDM_0(float progress)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref progress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008144 RID: 33092 RVA: 0x002482B0 File Offset: 0x002464B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27072, XrefRangeEnd = 27078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008145 RID: 33093 RVA: 0x00045DF5 File Offset: 0x00043FF5
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B9A RID: 11162
			// (get) Token: 0x06008146 RID: 33094 RVA: 0x002482E4 File Offset: 0x002464E4
			// (set) Token: 0x06008147 RID: 33095 RVA: 0x00045DFE File Offset: 0x00043FFE
			public unsafe TextMeshProUGUI text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B9B RID: 11163
			// (get) Token: 0x06008148 RID: 33096 RVA: 0x00248314 File Offset: 0x00246514
			// (set) Token: 0x06008149 RID: 33097 RVA: 0x00045E1D File Offset: 0x0004401D
			public unsafe string prependValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_prependValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_prependValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002B9C RID: 11164
			// (get) Token: 0x0600814A RID: 33098 RVA: 0x0024833C File Offset: 0x0024653C
			// (set) Token: 0x0600814B RID: 33099 RVA: 0x00045E3C File Offset: 0x0004403C
			public unsafe int targetValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_targetValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_targetValue)) = value;
				}
			}

			// Token: 0x17002B9D RID: 11165
			// (get) Token: 0x0600814C RID: 33100 RVA: 0x00248364 File Offset: 0x00246564
			// (set) Token: 0x0600814D RID: 33101 RVA: 0x00045E57 File Offset: 0x00044057
			public unsafe string appendValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_appendValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultSceneStatusPannel.__c__DisplayClass42_0.NativeFieldInfoPtr_appendValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040054B2 RID: 21682
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x040054B3 RID: 21683
			private static readonly IntPtr NativeFieldInfoPtr_prependValue;

			// Token: 0x040054B4 RID: 21684
			private static readonly IntPtr NativeFieldInfoPtr_targetValue;

			// Token: 0x040054B5 RID: 21685
			private static readonly IntPtr NativeFieldInfoPtr_appendValue;

			// Token: 0x040054B6 RID: 21686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040054B7 RID: 21687
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0;

			// Token: 0x040054B8 RID: 21688
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
