using System;
using Common.UI.GlobalMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x02000375 RID: 885
	public sealed class IzakayaSelectorPanel_New : GuideMapPanel<IzakayaSelectorPanel_New.OpenContext, int>
	{
		// Token: 0x060068DD RID: 26845 RVA: 0x001FC648 File Offset: 0x001FA848
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaSelectorPanel_New()
		{
			Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "IzakayaSelectorPanel_New");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr);
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_GotoIzakayaBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_GotoIzakayaBtn");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_GotoPartnerBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_GotoPartnerBtn");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_NoteBookBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_NoteBookBtn");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_StorageBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_StorageBtn");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_Level1Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_Level1Toggle");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_Level2Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_Level2Toggle");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_Level3Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_Level3Toggle");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_LockIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_LockIndicator");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_GuideMapSpotExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_GuideMapSpotExtension");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_SelectedPartnerDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_SelectedPartnerDescriber");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_DefaultPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_DefaultPartner");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_SelectedIzakayaDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_SelectedIzakayaDescriber");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_MainPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_MainPanel");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_ExpandButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_ExpandButton");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_DetailPanel");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_SpotToExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_SpotToExtensions");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_LockedSelectionCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_LockedSelectionCache");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_CurrentSelectedIzakayaLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_CurrentSelectedIzakayaLevel");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_CurrentSelectedSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_CurrentSelectedSpot");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_AllAvailableMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_AllAvailableMaps");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_CurrentSelectedIzakayaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_CurrentSelectedIzakayaData");
			IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_IsDetailPanelOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "m_IsDetailPanelOpened");
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685094);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685095);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_OpenDescriptionMenu_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685096);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685097);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapPanelPostOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685098);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685099);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapClose_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685100);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685101);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_IsGuideMapSpotCanBeSelected_Protected_Virtual_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685102);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685103);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_UpdateCurrentIzakaya_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685104);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_CalculateIzakayaId_Private_Int32_byref_GuideMapSpotRuntimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685105);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_IzakayaLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685106);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_IzakayaLevel_IzakayaLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685107);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_UpdateToggleStatus_Private_Void_IzakayaLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685108);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_PostInitializeGuideMapSpot_Protected_Virtual_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685109);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_PrintPartnerData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685110);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_LoadSelectionToIzakayaConfig_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685111);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685112);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685113);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685114);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685115);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685116);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_4_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685117);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685118);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685119);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685120);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685121);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685122);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_10_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685123);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_11_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685124);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_12_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685125);
			IzakayaSelectorPanel_New.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_1_T_Func_2_T_Boolean_byref_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, 100685126);
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x001FCAC4 File Offset: 0x001FACC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268176, XrefRangeEnd = 268307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x001FCAF8 File Offset: 0x001FACF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268307, XrefRangeEnd = 268319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSecondarySwitchUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x001FCB2C File Offset: 0x001FAD2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268336, RefRangeEnd = 268337, XrefRangeStart = 268319, XrefRangeEnd = 268336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OpenDescriptionMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_OpenDescriptionMenu_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x001FCB64 File Offset: 0x001FAD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268337, XrefRangeEnd = 268349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapPanelPreOpen(IzakayaSelectorPanel_New.OpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_Void_OpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x001FCBAC File Offset: 0x001FADAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268349, XrefRangeEnd = 268359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapPanelPostOpen(IzakayaSelectorPanel_New.OpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapPanelPostOpen_Protected_Virtual_Void_OpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x001FCBF4 File Offset: 0x001FADF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268359, XrefRangeEnd = 268375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapPanelEndOpen(IzakayaSelectorPanel_New.OpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_Void_OpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x001FCC3C File Offset: 0x001FAE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268375, XrefRangeEnd = 268379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapClose(int closeContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapClose_Protected_Virtual_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x001FCC7C File Offset: 0x001FAE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268379, XrefRangeEnd = 268427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetSpotOpenStatus(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x001FCCCC File Offset: 0x001FAECC
		[CallerCount(0)]
		public unsafe override bool IsGuideMapSpotCanBeSelected(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_IsGuideMapSpotCanBeSelected_Protected_Virtual_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x001FCD1C File Offset: 0x001FAF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268427, XrefRangeEnd = 268433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapSpotSelected(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x001FCD60 File Offset: 0x001FAF60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 268441, RefRangeEnd = 268446, XrefRangeStart = 268433, XrefRangeEnd = 268441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentIzakaya()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_UpdateCurrentIzakaya_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x001FCD94 File Offset: 0x001FAF94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 268455, RefRangeEnd = 268457, XrefRangeStart = 268446, XrefRangeEnd = 268455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateIzakayaId(out IzakayaSelectorPanel_New.GuideMapSpotRuntimeData runtimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_CalculateIzakayaId_Private_Int32_byref_GuideMapSpotRuntimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			runtimeData = ((intPtr4 == 0) ? null : new IzakayaSelectorPanel_New.GuideMapSpotRuntimeData(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x001FCDF4 File Offset: 0x001FAFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268457, XrefRangeEnd = 268458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryChangeIzakayaLevel(ref IzakayaLevel izakayaLevel, bool add)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &izakayaLevel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_IzakayaLevel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x001FCE4C File Offset: 0x001FB04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268458, XrefRangeEnd = 268462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryChangeIzakayaLevel(ref IzakayaLevel izakayaLevel, IzakayaLevel targetLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &izakayaLevel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_IzakayaLevel_IzakayaLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x001FCEA4 File Offset: 0x001FB0A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 268466, RefRangeEnd = 268468, XrefRangeStart = 268462, XrefRangeEnd = 268466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateToggleStatus(IzakayaLevel targetLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_UpdateToggleStatus_Private_Void_IzakayaLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x001FCEE4 File Offset: 0x001FB0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268468, XrefRangeEnd = 268487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostInitializeGuideMapSpot(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_PostInitializeGuideMapSpot_Protected_Virtual_Void_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x001FCF28 File Offset: 0x001FB128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268487, XrefRangeEnd = 268490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintPartnerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_PrintPartnerData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x001FCF5C File Offset: 0x001FB15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268490, XrefRangeEnd = 268502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSelectionToIzakayaConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_LoadSelectionToIzakayaConfig_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x001FCF90 File Offset: 0x001FB190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268502, XrefRangeEnd = 268529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x001FCFC4 File Offset: 0x001FB1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268529, XrefRangeEnd = 268547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaSelectorPanel_New() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x001FD000 File Offset: 0x001FB200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268547, XrefRangeEnd = 268578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x001FD034 File Offset: 0x001FB234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268578, XrefRangeEnd = 268599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x001FD068 File Offset: 0x001FB268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268599, XrefRangeEnd = 268607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x001FD09C File Offset: 0x001FB29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268607, XrefRangeEnd = 268610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_4(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_4_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F6 RID: 26870 RVA: 0x001FD0E4 File Offset: 0x001FB2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268610, XrefRangeEnd = 268618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F7 RID: 26871 RVA: 0x001FD118 File Offset: 0x001FB318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268618, XrefRangeEnd = 268626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F8 RID: 26872 RVA: 0x001FD14C File Offset: 0x001FB34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268626, XrefRangeEnd = 268634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F9 RID: 26873 RVA: 0x001FD180 File Offset: 0x001FB380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268634, XrefRangeEnd = 268642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068FA RID: 26874 RVA: 0x001FD1B4 File Offset: 0x001FB3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268642, XrefRangeEnd = 268650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x001FD1E8 File Offset: 0x001FB3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268650, XrefRangeEnd = 268655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_10(InputAction.CallbackContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_10_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068FC RID: 26876 RVA: 0x001FD230 File Offset: 0x001FB430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268655, XrefRangeEnd = 268657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_11(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_11_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x001FD278 File Offset: 0x001FB478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268657, XrefRangeEnd = 268666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__21_12(InputAction.CallbackContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_12_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x001FD2C0 File Offset: 0x001FB4C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 268677, RefRangeEnd = 268680, XrefRangeStart = 268666, XrefRangeEnd = 268677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_IEnumerable_1_T_Func_2_T_Boolean_byref_Nullable_1_T_0<T>(IEnumerable<T> collection, Func<T, bool> handler, out Nullable<T> matched) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.MethodInfoStoreGeneric_Method_Internal_Static_Boolean_IEnumerable_1_T_Func_2_T_Boolean_byref_Nullable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			matched = ((intPtr4 == 0) ? null : new Nullable<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060068FF RID: 26879 RVA: 0x00038B31 File Offset: 0x00036D31
		public IzakayaSelectorPanel_New(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x06006900 RID: 26880 RVA: 0x001FD338 File Offset: 0x001FB538
		// (set) Token: 0x06006901 RID: 26881 RVA: 0x00038B3A File Offset: 0x00036D3A
		public unsafe UIButtonHold m_GotoIzakayaBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_GotoIzakayaBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_GotoIzakayaBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x06006902 RID: 26882 RVA: 0x001FD368 File Offset: 0x001FB568
		// (set) Token: 0x06006903 RID: 26883 RVA: 0x00038B59 File Offset: 0x00036D59
		public unsafe UIButtonSimple m_GotoPartnerBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_GotoPartnerBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_GotoPartnerBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x06006904 RID: 26884 RVA: 0x001FD398 File Offset: 0x001FB598
		// (set) Token: 0x06006905 RID: 26885 RVA: 0x00038B78 File Offset: 0x00036D78
		public unsafe UIButtonSimple m_NoteBookBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_NoteBookBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_NoteBookBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x06006906 RID: 26886 RVA: 0x001FD3C8 File Offset: 0x001FB5C8
		// (set) Token: 0x06006907 RID: 26887 RVA: 0x00038B97 File Offset: 0x00036D97
		public unsafe UIButtonSimple m_StorageBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_StorageBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_StorageBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x06006908 RID: 26888 RVA: 0x001FD3F8 File Offset: 0x001FB5F8
		// (set) Token: 0x06006909 RID: 26889 RVA: 0x00038BB6 File Offset: 0x00036DB6
		public unsafe UIButtonToggle m_Level1Toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_Level1Toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_Level1Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x0600690A RID: 26890 RVA: 0x001FD428 File Offset: 0x001FB628
		// (set) Token: 0x0600690B RID: 26891 RVA: 0x00038BD5 File Offset: 0x00036DD5
		public unsafe UIButtonToggle m_Level2Toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_Level2Toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_Level2Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x0600690C RID: 26892 RVA: 0x001FD458 File Offset: 0x001FB658
		// (set) Token: 0x0600690D RID: 26893 RVA: 0x00038BF4 File Offset: 0x00036DF4
		public unsafe UIButtonToggle m_Level3Toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_Level3Toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_Level3Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600690E RID: 26894 RVA: 0x001FD488 File Offset: 0x001FB688
		// (set) Token: 0x0600690F RID: 26895 RVA: 0x00038C13 File Offset: 0x00036E13
		public unsafe GameObject m_LockIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_LockIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_LockIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x06006910 RID: 26896 RVA: 0x001FD4B8 File Offset: 0x001FB6B8
		// (set) Token: 0x06006911 RID: 26897 RVA: 0x00038C32 File Offset: 0x00036E32
		public unsafe GuideMapSpotIzakayaExtension m_GuideMapSpotExtension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_GuideMapSpotExtension);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapSpotIzakayaExtension>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_GuideMapSpotExtension), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x06006912 RID: 26898 RVA: 0x001FD4E8 File Offset: 0x001FB6E8
		// (set) Token: 0x06006913 RID: 26899 RVA: 0x00038C51 File Offset: 0x00036E51
		public unsafe SelectedPartnerDescriber m_SelectedPartnerDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_SelectedPartnerDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedPartnerDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_SelectedPartnerDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x06006914 RID: 26900 RVA: 0x001FD518 File Offset: 0x001FB718
		// (set) Token: 0x06006915 RID: 26901 RVA: 0x00038C70 File Offset: 0x00036E70
		public unsafe GameObject m_DefaultPartner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_DefaultPartner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_DefaultPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x06006916 RID: 26902 RVA: 0x001FD548 File Offset: 0x001FB748
		// (set) Token: 0x06006917 RID: 26903 RVA: 0x00038C8F File Offset: 0x00036E8F
		public unsafe SelectedIzakayaDescriber m_SelectedIzakayaDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_SelectedIzakayaDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedIzakayaDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_SelectedIzakayaDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x06006918 RID: 26904 RVA: 0x001FD578 File Offset: 0x001FB778
		// (set) Token: 0x06006919 RID: 26905 RVA: 0x00038CAE File Offset: 0x00036EAE
		public unsafe CanvasGroup m_MainPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_MainPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_MainPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x0600691A RID: 26906 RVA: 0x001FD5A8 File Offset: 0x001FB7A8
		// (set) Token: 0x0600691B RID: 26907 RVA: 0x00038CCD File Offset: 0x00036ECD
		public unsafe UIButtonSimple m_ExpandButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_ExpandButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_ExpandButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x0600691C RID: 26908 RVA: 0x001FD5D8 File Offset: 0x001FB7D8
		// (set) Token: 0x0600691D RID: 26909 RVA: 0x00038CEC File Offset: 0x00036EEC
		public unsafe IzakayaDetailPanel m_DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x0600691E RID: 26910 RVA: 0x001FD608 File Offset: 0x001FB808
		// (set) Token: 0x0600691F RID: 26911 RVA: 0x00038D0B File Offset: 0x00036F0B
		public unsafe Dictionary<IGuideMapSpot, IzakayaSelectorPanel_New.GuideMapSpotRuntimeData> m_SpotToExtensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_SpotToExtensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IGuideMapSpot, IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_SpotToExtensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x06006920 RID: 26912 RVA: 0x001FD638 File Offset: 0x001FB838
		// (set) Token: 0x06006921 RID: 26913 RVA: 0x00038D2A File Offset: 0x00036F2A
		public unsafe List<GameObject> m_LockedSelectionCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_LockedSelectionCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_LockedSelectionCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x06006922 RID: 26914 RVA: 0x001FD668 File Offset: 0x001FB868
		// (set) Token: 0x06006923 RID: 26915 RVA: 0x00038D49 File Offset: 0x00036F49
		public unsafe IzakayaLevel m_CurrentSelectedIzakayaLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_CurrentSelectedIzakayaLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_CurrentSelectedIzakayaLevel)) = value;
			}
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x06006924 RID: 26916 RVA: 0x001FD690 File Offset: 0x001FB890
		// (set) Token: 0x06006925 RID: 26917 RVA: 0x00038D64 File Offset: 0x00036F64
		public unsafe IGuideMapSpot m_CurrentSelectedSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_CurrentSelectedSpot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGuideMapSpot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_CurrentSelectedSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x06006926 RID: 26918 RVA: 0x001FD6C0 File Offset: 0x001FB8C0
		// (set) Token: 0x06006927 RID: 26919 RVA: 0x00038D83 File Offset: 0x00036F83
		public unsafe HashSet<string> m_AllAvailableMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_AllAvailableMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_AllAvailableMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x06006928 RID: 26920 RVA: 0x001FD6F0 File Offset: 0x001FB8F0
		// (set) Token: 0x06006929 RID: 26921 RVA: 0x00038DA2 File Offset: 0x00036FA2
		public unsafe Izakaya m_CurrentSelectedIzakayaData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_CurrentSelectedIzakayaData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_CurrentSelectedIzakayaData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x001FD720 File Offset: 0x001FB920
		// (set) Token: 0x0600692B RID: 26923 RVA: 0x00038DC1 File Offset: 0x00036FC1
		public unsafe bool m_IsDetailPanelOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_IsDetailPanelOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.NativeFieldInfoPtr_m_IsDetailPanelOpened)) = value;
			}
		}

		// Token: 0x04004589 RID: 17801
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoIzakayaBtn;

		// Token: 0x0400458A RID: 17802
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoPartnerBtn;

		// Token: 0x0400458B RID: 17803
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteBookBtn;

		// Token: 0x0400458C RID: 17804
		private static readonly IntPtr NativeFieldInfoPtr_m_StorageBtn;

		// Token: 0x0400458D RID: 17805
		private static readonly IntPtr NativeFieldInfoPtr_m_Level1Toggle;

		// Token: 0x0400458E RID: 17806
		private static readonly IntPtr NativeFieldInfoPtr_m_Level2Toggle;

		// Token: 0x0400458F RID: 17807
		private static readonly IntPtr NativeFieldInfoPtr_m_Level3Toggle;

		// Token: 0x04004590 RID: 17808
		private static readonly IntPtr NativeFieldInfoPtr_m_LockIndicator;

		// Token: 0x04004591 RID: 17809
		private static readonly IntPtr NativeFieldInfoPtr_m_GuideMapSpotExtension;

		// Token: 0x04004592 RID: 17810
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedPartnerDescriber;

		// Token: 0x04004593 RID: 17811
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultPartner;

		// Token: 0x04004594 RID: 17812
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedIzakayaDescriber;

		// Token: 0x04004595 RID: 17813
		private static readonly IntPtr NativeFieldInfoPtr_m_MainPanel;

		// Token: 0x04004596 RID: 17814
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpandButton;

		// Token: 0x04004597 RID: 17815
		private static readonly IntPtr NativeFieldInfoPtr_m_DetailPanel;

		// Token: 0x04004598 RID: 17816
		private static readonly IntPtr NativeFieldInfoPtr_m_SpotToExtensions;

		// Token: 0x04004599 RID: 17817
		private static readonly IntPtr NativeFieldInfoPtr_m_LockedSelectionCache;

		// Token: 0x0400459A RID: 17818
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelectedIzakayaLevel;

		// Token: 0x0400459B RID: 17819
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelectedSpot;

		// Token: 0x0400459C RID: 17820
		private static readonly IntPtr NativeFieldInfoPtr_m_AllAvailableMaps;

		// Token: 0x0400459D RID: 17821
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelectedIzakayaData;

		// Token: 0x0400459E RID: 17822
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDetailPanelOpened;

		// Token: 0x0400459F RID: 17823
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0;

		// Token: 0x040045A0 RID: 17824
		private static readonly IntPtr NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_Void_0;

		// Token: 0x040045A1 RID: 17825
		private static readonly IntPtr NativeMethodInfoPtr_OpenDescriptionMenu_Private_UniTask_0;

		// Token: 0x040045A2 RID: 17826
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x040045A3 RID: 17827
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelPostOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x040045A4 RID: 17828
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x040045A5 RID: 17829
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapClose_Protected_Virtual_Void_Int32_0;

		// Token: 0x040045A6 RID: 17830
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0;

		// Token: 0x040045A7 RID: 17831
		private static readonly IntPtr NativeMethodInfoPtr_IsGuideMapSpotCanBeSelected_Protected_Virtual_Boolean_IGuideMapSpot_0;

		// Token: 0x040045A8 RID: 17832
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0;

		// Token: 0x040045A9 RID: 17833
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentIzakaya_Private_Void_0;

		// Token: 0x040045AA RID: 17834
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIzakayaId_Private_Int32_byref_GuideMapSpotRuntimeData_0;

		// Token: 0x040045AB RID: 17835
		private static readonly IntPtr NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_IzakayaLevel_Boolean_0;

		// Token: 0x040045AC RID: 17836
		private static readonly IntPtr NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_IzakayaLevel_IzakayaLevel_0;

		// Token: 0x040045AD RID: 17837
		private static readonly IntPtr NativeMethodInfoPtr_UpdateToggleStatus_Private_Void_IzakayaLevel_0;

		// Token: 0x040045AE RID: 17838
		private static readonly IntPtr NativeMethodInfoPtr_PostInitializeGuideMapSpot_Protected_Virtual_Void_IGuideMapSpot_0;

		// Token: 0x040045AF RID: 17839
		private static readonly IntPtr NativeMethodInfoPtr_PrintPartnerData_Private_Void_0;

		// Token: 0x040045B0 RID: 17840
		private static readonly IntPtr NativeMethodInfoPtr_LoadSelectionToIzakayaConfig_Private_Void_0;

		// Token: 0x040045B1 RID: 17841
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040045B2 RID: 17842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040045B3 RID: 17843
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_0_Private_Void_0;

		// Token: 0x040045B4 RID: 17844
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_1_Private_Void_0;

		// Token: 0x040045B5 RID: 17845
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_2_Private_Void_0;

		// Token: 0x040045B6 RID: 17846
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_4_Private_Void_CallbackContext_0;

		// Token: 0x040045B7 RID: 17847
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_5_Private_Void_0;

		// Token: 0x040045B8 RID: 17848
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_6_Private_Void_0;

		// Token: 0x040045B9 RID: 17849
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_7_Private_Void_0;

		// Token: 0x040045BA RID: 17850
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_8_Private_Void_0;

		// Token: 0x040045BB RID: 17851
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_9_Private_Void_0;

		// Token: 0x040045BC RID: 17852
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_10_Private_Void_CallbackContext_0;

		// Token: 0x040045BD RID: 17853
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_11_Private_Void_CallbackContext_0;

		// Token: 0x040045BE RID: 17854
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_12_Private_Void_CallbackContext_0;

		// Token: 0x040045BF RID: 17855
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_1_T_Func_2_T_Boolean_byref_Nullable_1_T_0;

		// Token: 0x02000E7F RID: 3711
		public class GuideMapSpotRuntimeData : Il2CppSystem.Object
		{
			// Token: 0x0601079A RID: 67482 RVA: 0x003D2914 File Offset: 0x003D0B14
			// Note: this type is marked as 'beforefieldinit'.
			static GuideMapSpotRuntimeData()
			{
				Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "GuideMapSpotRuntimeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr);
				IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Extension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, "Extension");
				IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr__IzakayaLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, "<IzakayaLevel>k__BackingField");
				IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level1IzakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, "Level1IzakayaId");
				IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level2IzakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, "Level2IzakayaId");
				IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level3IzakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, "Level3IzakayaId");
				IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr_get_IzakayaLevel_Public_get_IzakayaLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, 100685127);
				IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr_set_IzakayaLevel_Public_set_Void_IzakayaLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, 100685128);
				IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr__ctor_Public_Void_GuideMapSpotIzakayaExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, 100685129);
			}

			// Token: 0x1700560B RID: 22027
			// (get) Token: 0x0601079B RID: 67483 RVA: 0x003D29E0 File Offset: 0x003D0BE0
			// (set) Token: 0x0601079C RID: 67484 RVA: 0x003D2A1C File Offset: 0x003D0C1C
			public unsafe IzakayaLevel IzakayaLevel
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr_get_IzakayaLevel_Public_get_IzakayaLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 82111, RefRangeEnd = 82113, XrefRangeStart = 82111, XrefRangeEnd = 82113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr_set_IzakayaLevel_Public_set_Void_IzakayaLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0601079D RID: 67485 RVA: 0x003D2A5C File Offset: 0x003D0C5C
			[CallerCount(109)]
			[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60056, XrefRangeEnd = 60165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuideMapSpotRuntimeData(GuideMapSpotIzakayaExtension extension) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSelectorPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr__ctor_Public_Void_GuideMapSpotIzakayaExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601079E RID: 67486 RVA: 0x0008FC07 File Offset: 0x0008DE07
			public GuideMapSpotRuntimeData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005606 RID: 22022
			// (get) Token: 0x0601079F RID: 67487 RVA: 0x003D2AA8 File Offset: 0x003D0CA8
			// (set) Token: 0x060107A0 RID: 67488 RVA: 0x0008FC10 File Offset: 0x0008DE10
			public unsafe GuideMapSpotIzakayaExtension Extension
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Extension);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapSpotIzakayaExtension>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Extension), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005607 RID: 22023
			// (get) Token: 0x060107A1 RID: 67489 RVA: 0x003D2AD8 File Offset: 0x003D0CD8
			// (set) Token: 0x060107A2 RID: 67490 RVA: 0x0008FC2F File Offset: 0x0008DE2F
			public unsafe IzakayaLevel _IzakayaLevel_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr__IzakayaLevel_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr__IzakayaLevel_k__BackingField)) = value;
				}
			}

			// Token: 0x17005608 RID: 22024
			// (get) Token: 0x060107A3 RID: 67491 RVA: 0x003D2B00 File Offset: 0x003D0D00
			// (set) Token: 0x060107A4 RID: 67492 RVA: 0x0008FC4A File Offset: 0x0008DE4A
			public Nullable<int> Level1IzakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level1IzakayaId);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level1IzakayaId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005609 RID: 22025
			// (get) Token: 0x060107A5 RID: 67493 RVA: 0x003D2B30 File Offset: 0x003D0D30
			// (set) Token: 0x060107A6 RID: 67494 RVA: 0x0008FC78 File Offset: 0x0008DE78
			public Nullable<int> Level2IzakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level2IzakayaId);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level2IzakayaId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700560A RID: 22026
			// (get) Token: 0x060107A7 RID: 67495 RVA: 0x003D2B60 File Offset: 0x003D0D60
			// (set) Token: 0x060107A8 RID: 67496 RVA: 0x0008FCA6 File Offset: 0x0008DEA6
			public Nullable<int> Level3IzakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level3IzakayaId);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level3IzakayaId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A6D1 RID: 42705
			private static readonly IntPtr NativeFieldInfoPtr_Extension;

			// Token: 0x0400A6D2 RID: 42706
			private static readonly IntPtr NativeFieldInfoPtr__IzakayaLevel_k__BackingField;

			// Token: 0x0400A6D3 RID: 42707
			private static readonly IntPtr NativeFieldInfoPtr_Level1IzakayaId;

			// Token: 0x0400A6D4 RID: 42708
			private static readonly IntPtr NativeFieldInfoPtr_Level2IzakayaId;

			// Token: 0x0400A6D5 RID: 42709
			private static readonly IntPtr NativeFieldInfoPtr_Level3IzakayaId;

			// Token: 0x0400A6D6 RID: 42710
			private static readonly IntPtr NativeMethodInfoPtr_get_IzakayaLevel_Public_get_IzakayaLevel_0;

			// Token: 0x0400A6D7 RID: 42711
			private static readonly IntPtr NativeMethodInfoPtr_set_IzakayaLevel_Public_set_Void_IzakayaLevel_0;

			// Token: 0x0400A6D8 RID: 42712
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuideMapSpotIzakayaExtension_0;
		}

		// Token: 0x02000E80 RID: 3712
		public sealed class OpenContext : ValueType
		{
			// Token: 0x060107A9 RID: 67497 RVA: 0x003D2B90 File Offset: 0x003D0D90
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr);
				IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_PartnerSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr, "PartnerSelection");
				IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_IsIzakayaAvailableHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr, "IsIzakayaAvailableHandler");
				IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_m_IzakayaLockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr, "m_IzakayaLockType");
				IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_m_IzakayaMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr, "m_IzakayaMappings");
				IzakayaSelectorPanel_New.OpenContext.NativeMethodInfoPtr_get_IsIzakayaLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr, 100685130);
				IzakayaSelectorPanel_New.OpenContext.NativeMethodInfoPtr_TryMapIzakayaId_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr, 100685131);
				IzakayaSelectorPanel_New.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_IzakayaLockType_Il2CppStructArray_1_IzakayaMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr, 100685132);
			}

			// Token: 0x17005610 RID: 22032
			// (get) Token: 0x060107AA RID: 67498 RVA: 0x003D2C48 File Offset: 0x003D0E48
			public unsafe bool IsIzakayaLocked
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.OpenContext.NativeMethodInfoPtr_get_IsIzakayaLocked_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060107AB RID: 67499 RVA: 0x003D2C8C File Offset: 0x003D0E8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268088, RefRangeEnd = 268089, XrefRangeStart = 268085, XrefRangeEnd = 268088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int TryMapIzakayaId(int sourceId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref sourceId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.OpenContext.NativeMethodInfoPtr_TryMapIzakayaId_Public_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060107AC RID: 67500 RVA: 0x003D2CDC File Offset: 0x003D0EDC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268157, RefRangeEnd = 268158, XrefRangeStart = 268089, XrefRangeEnd = 268157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>> partnerSelection, SchedulerNode.Trigger.IzakayaLockType izakayaLockType, Il2CppStructArray<SchedulerNode.Trigger.IzakayaMapping> izakayaMappings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerSelection);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref izakayaLockType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(izakayaMappings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_IzakayaLockType_Il2CppStructArray_1_IzakayaMapping_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107AD RID: 67501 RVA: 0x0008FCD4 File Offset: 0x0008DED4
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060107AE RID: 67502 RVA: 0x0008FCDD File Offset: 0x0008DEDD
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x1700560C RID: 22028
			// (get) Token: 0x060107AF RID: 67503 RVA: 0x003D2D4C File Offset: 0x003D0F4C
			// (set) Token: 0x060107B0 RID: 67504 RVA: 0x0008FCEF File Offset: 0x0008DEEF
			public unsafe Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>> PartnerSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_PartnerSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_PartnerSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700560D RID: 22029
			// (get) Token: 0x060107B1 RID: 67505 RVA: 0x003D2D7C File Offset: 0x003D0F7C
			// (set) Token: 0x060107B2 RID: 67506 RVA: 0x0008FD0E File Offset: 0x0008DF0E
			public unsafe Func<int, bool> IsIzakayaAvailableHandler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_IsIzakayaAvailableHandler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_IsIzakayaAvailableHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700560E RID: 22030
			// (get) Token: 0x060107B3 RID: 67507 RVA: 0x003D2DAC File Offset: 0x003D0FAC
			// (set) Token: 0x060107B4 RID: 67508 RVA: 0x0008FD2D File Offset: 0x0008DF2D
			public unsafe SchedulerNode.Trigger.IzakayaLockType m_IzakayaLockType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_m_IzakayaLockType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_m_IzakayaLockType)) = value;
				}
			}

			// Token: 0x1700560F RID: 22031
			// (get) Token: 0x060107B5 RID: 67509 RVA: 0x003D2DD4 File Offset: 0x003D0FD4
			// (set) Token: 0x060107B6 RID: 67510 RVA: 0x0008FD48 File Offset: 0x0008DF48
			public unsafe IReadOnlyDictionary<int, int> m_IzakayaMappings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_m_IzakayaMappings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.OpenContext.NativeFieldInfoPtr_m_IzakayaMappings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6D9 RID: 42713
			private static readonly IntPtr NativeFieldInfoPtr_PartnerSelection;

			// Token: 0x0400A6DA RID: 42714
			private static readonly IntPtr NativeFieldInfoPtr_IsIzakayaAvailableHandler;

			// Token: 0x0400A6DB RID: 42715
			private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaLockType;

			// Token: 0x0400A6DC RID: 42716
			private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaMappings;

			// Token: 0x0400A6DD RID: 42717
			private static readonly IntPtr NativeMethodInfoPtr_get_IsIzakayaLocked_Public_get_Boolean_0;

			// Token: 0x0400A6DE RID: 42718
			private static readonly IntPtr NativeMethodInfoPtr_TryMapIzakayaId_Public_Int32_Int32_0;

			// Token: 0x0400A6DF RID: 42719
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_IzakayaLockType_Il2CppStructArray_1_IzakayaMapping_0;

			// Token: 0x020010B6 RID: 4278
			[ObfuscatedName("Common.UI.IzakayaSelectorPanel_New+OpenContext+<>c__DisplayClass7_0")]
			public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
			{
				// Token: 0x0601230B RID: 74507 RVA: 0x00425CE4 File Offset: 0x00423EE4
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass7_0()
				{
					Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr, "<>c__DisplayClass7_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0>.NativeClassPtr);
					IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0.NativeFieldInfoPtr_readOnlyDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0>.NativeClassPtr, "readOnlyDictionary");
					IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0>.NativeClassPtr, 100685133);
					IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0.NativeMethodInfoPtr___ctor_b__3_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0>.NativeClassPtr, 100685134);
				}

				// Token: 0x0601230C RID: 74508 RVA: 0x00425D4C File Offset: 0x00423F4C
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601230D RID: 74509 RVA: 0x00425D88 File Offset: 0x00423F88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268083, XrefRangeEnd = 268085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool __ctor_b__3(int izakayaId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref izakayaId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0.NativeMethodInfoPtr___ctor_b__3_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601230E RID: 74510 RVA: 0x0009DF42 File Offset: 0x0009C142
				public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F26 RID: 24358
				// (get) Token: 0x0601230F RID: 74511 RVA: 0x00425DD4 File Offset: 0x00423FD4
				// (set) Token: 0x06012310 RID: 74512 RVA: 0x0009DF4B File Offset: 0x0009C14B
				public unsafe Dictionary<int, int> readOnlyDictionary
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0.NativeFieldInfoPtr_readOnlyDictionary);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New.OpenContext.__c__DisplayClass7_0.NativeFieldInfoPtr_readOnlyDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B861 RID: 47201
				private static readonly IntPtr NativeFieldInfoPtr_readOnlyDictionary;

				// Token: 0x0400B862 RID: 47202
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B863 RID: 47203
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_Internal_Boolean_Int32_0;
			}

			// Token: 0x020010B7 RID: 4279
			[ObfuscatedName("Common.UI.IzakayaSelectorPanel_New+OpenContext+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x06012311 RID: 74513 RVA: 0x00425E04 File Offset: 0x00424004
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr);
					IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr, "<>9");
					IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr, "<>9__7_0");
					IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr, "<>9__7_1");
					IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr, "<>9__7_2");
					IzakayaSelectorPanel_New.OpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr, 100685136);
					IzakayaSelectorPanel_New.OpenContext.__c.NativeMethodInfoPtr___ctor_b__7_0_Internal_Int32_IzakayaMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr, 100685137);
					IzakayaSelectorPanel_New.OpenContext.__c.NativeMethodInfoPtr___ctor_b__7_1_Internal_Int32_IzakayaMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr, 100685138);
					IzakayaSelectorPanel_New.OpenContext.__c.NativeMethodInfoPtr___ctor_b__7_2_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr, 100685139);
				}

				// Token: 0x06012312 RID: 74514 RVA: 0x00425ED0 File Offset: 0x004240D0
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSelectorPanel_New.OpenContext.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.OpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012313 RID: 74515 RVA: 0x00425F0C File Offset: 0x0042410C
				[CallerCount(0)]
				public unsafe int __ctor_b__7_0(SchedulerNode.Trigger.IzakayaMapping x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.OpenContext.__c.NativeMethodInfoPtr___ctor_b__7_0_Internal_Int32_IzakayaMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06012314 RID: 74516 RVA: 0x00425F58 File Offset: 0x00424158
				[CallerCount(0)]
				public unsafe int __ctor_b__7_1(SchedulerNode.Trigger.IzakayaMapping x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.OpenContext.__c.NativeMethodInfoPtr___ctor_b__7_1_Internal_Int32_IzakayaMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06012315 RID: 74517 RVA: 0x00425FA4 File Offset: 0x004241A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool __ctor_b__7_2(int izakayaId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref izakayaId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.OpenContext.__c.NativeMethodInfoPtr___ctor_b__7_2_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06012316 RID: 74518 RVA: 0x0009DF6A File Offset: 0x0009C16A
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F27 RID: 24359
				// (get) Token: 0x06012317 RID: 74519 RVA: 0x00425FF0 File Offset: 0x004241F0
				// (set) Token: 0x06012318 RID: 74520 RVA: 0x0009DF73 File Offset: 0x0009C173
				public unsafe static IzakayaSelectorPanel_New.OpenContext.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaSelectorPanel_New.OpenContext.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F28 RID: 24360
				// (get) Token: 0x06012319 RID: 74521 RVA: 0x00426018 File Offset: 0x00424218
				// (set) Token: 0x0601231A RID: 74522 RVA: 0x0009DF85 File Offset: 0x0009C185
				public unsafe static Func<SchedulerNode.Trigger.IzakayaMapping, int> __9__7_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SchedulerNode.Trigger.IzakayaMapping, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F29 RID: 24361
				// (get) Token: 0x0601231B RID: 74523 RVA: 0x00426040 File Offset: 0x00424240
				// (set) Token: 0x0601231C RID: 74524 RVA: 0x0009DF97 File Offset: 0x0009C197
				public unsafe static Func<SchedulerNode.Trigger.IzakayaMapping, int> __9__7_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SchedulerNode.Trigger.IzakayaMapping, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F2A RID: 24362
				// (get) Token: 0x0601231D RID: 74525 RVA: 0x00426068 File Offset: 0x00424268
				// (set) Token: 0x0601231E RID: 74526 RVA: 0x0009DFA9 File Offset: 0x0009C1A9
				public unsafe static Func<int, bool> __9__7_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaSelectorPanel_New.OpenContext.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B864 RID: 47204
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B865 RID: 47205
				private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

				// Token: 0x0400B866 RID: 47206
				private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

				// Token: 0x0400B867 RID: 47207
				private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

				// Token: 0x0400B868 RID: 47208
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B869 RID: 47209
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__7_0_Internal_Int32_IzakayaMapping_0;

				// Token: 0x0400B86A RID: 47210
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__7_1_Internal_Int32_IzakayaMapping_0;

				// Token: 0x0400B86B RID: 47211
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__7_2_Internal_Boolean_Int32_0;
			}
		}

		// Token: 0x02000E81 RID: 3713
		[ObfuscatedName("Common.UI.IzakayaSelectorPanel_New+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060107B7 RID: 67511 RVA: 0x003D2E04 File Offset: 0x003D1004
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IzakayaSelectorPanel_New.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaSelectorPanel_New.__c>.NativeClassPtr);
				IzakayaSelectorPanel_New.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.__c>.NativeClassPtr, "<>9");
				IzakayaSelectorPanel_New.__c.NativeFieldInfoPtr___9__21_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New.__c>.NativeClassPtr, "<>9__21_3");
				IzakayaSelectorPanel_New.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.__c>.NativeClassPtr, 100685141);
				IzakayaSelectorPanel_New.__c.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_3_Internal_Void_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New.__c>.NativeClassPtr, 100685142);
			}

			// Token: 0x060107B8 RID: 67512 RVA: 0x003D2E80 File Offset: 0x003D1080
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSelectorPanel_New.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107B9 RID: 67513 RVA: 0x003D2EBC File Offset: 0x003D10BC
			[CallerCount(0)]
			public unsafe void _OnGuideMapInitialize_b__21_3(UIButtonToggle toggle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New.__c.NativeMethodInfoPtr__OnGuideMapInitialize_b__21_3_Internal_Void_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107BA RID: 67514 RVA: 0x0008FD67 File Offset: 0x0008DF67
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005611 RID: 22033
			// (get) Token: 0x060107BB RID: 67515 RVA: 0x003D2F00 File Offset: 0x003D1100
			// (set) Token: 0x060107BC RID: 67516 RVA: 0x0008FD70 File Offset: 0x0008DF70
			public unsafe static IzakayaSelectorPanel_New.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSelectorPanel_New.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaSelectorPanel_New.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSelectorPanel_New.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005612 RID: 22034
			// (get) Token: 0x060107BD RID: 67517 RVA: 0x003D2F28 File Offset: 0x003D1128
			// (set) Token: 0x060107BE RID: 67518 RVA: 0x0008FD82 File Offset: 0x0008DF82
			public unsafe static Action<UIButtonToggle> __9__21_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSelectorPanel_New.__c.NativeFieldInfoPtr___9__21_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIButtonToggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSelectorPanel_New.__c.NativeFieldInfoPtr___9__21_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6E0 RID: 42720
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A6E1 RID: 42721
			private static readonly IntPtr NativeFieldInfoPtr___9__21_3;

			// Token: 0x0400A6E2 RID: 42722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6E3 RID: 42723
			private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__21_3_Internal_Void_UIButtonToggle_0;
		}

		// Token: 0x02000E82 RID: 3714
		[ObfuscatedName("Common.UI.IzakayaSelectorPanel_New+<OpenDescriptionMenu>d__24")]
		public sealed class _OpenDescriptionMenu_d__24 : ValueType
		{
			// Token: 0x060107BF RID: 67519 RVA: 0x003D2F50 File Offset: 0x003D1150
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenDescriptionMenu_d__24()
			{
				Il2CppClassPointerStore<IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr, "<OpenDescriptionMenu>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24>.NativeClassPtr);
				IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24>.NativeClassPtr, "<>1__state");
				IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24>.NativeClassPtr, "<>t__builder");
				IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24>.NativeClassPtr, "<>4__this");
				IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24>.NativeClassPtr, "<>u__1");
				IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24>.NativeClassPtr, 100685143);
				IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24>.NativeClassPtr, 100685144);
			}

			// Token: 0x060107C0 RID: 67520 RVA: 0x003D2FF4 File Offset: 0x003D11F4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 268173, RefRangeEnd = 268176, XrefRangeStart = 268158, XrefRangeEnd = 268173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107C1 RID: 67521 RVA: 0x003D302C File Offset: 0x003D122C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107C2 RID: 67522 RVA: 0x0008FD94 File Offset: 0x0008DF94
			public _OpenDescriptionMenu_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060107C3 RID: 67523 RVA: 0x0008FD9D File Offset: 0x0008DF9D
			public _OpenDescriptionMenu_d__24() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24>.NativeClassPtr))
			{
			}

			// Token: 0x17005613 RID: 22035
			// (get) Token: 0x060107C4 RID: 67524 RVA: 0x003D3074 File Offset: 0x003D1274
			// (set) Token: 0x060107C5 RID: 67525 RVA: 0x0008FDAF File Offset: 0x0008DFAF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005614 RID: 22036
			// (get) Token: 0x060107C6 RID: 67526 RVA: 0x003D309C File Offset: 0x003D129C
			// (set) Token: 0x060107C7 RID: 67527 RVA: 0x0008FDCA File Offset: 0x0008DFCA
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005615 RID: 22037
			// (get) Token: 0x060107C8 RID: 67528 RVA: 0x003D30CC File Offset: 0x003D12CC
			// (set) Token: 0x060107C9 RID: 67529 RVA: 0x0008FDF8 File Offset: 0x0008DFF8
			public unsafe IzakayaSelectorPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaSelectorPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005616 RID: 22038
			// (get) Token: 0x060107CA RID: 67530 RVA: 0x003D30FC File Offset: 0x003D12FC
			// (set) Token: 0x060107CB RID: 67531 RVA: 0x0008FE17 File Offset: 0x0008E017
			public UniTask<IzakayaDetailPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___u__1);
					return new UniTask<IzakayaDetailPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IzakayaDetailPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSelectorPanel_New._OpenDescriptionMenu_d__24.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IzakayaDetailPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A6E4 RID: 42724
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A6E5 RID: 42725
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A6E6 RID: 42726
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A6E7 RID: 42727
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A6E8 RID: 42728
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A6E9 RID: 42729
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E83 RID: 3715
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Boolean_IEnumerable_1_T_Func_2_T_Boolean_byref_Nullable_1_T_0<T>
		{
			// Token: 0x0400A6EA RID: 42730
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IzakayaSelectorPanel_New.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IEnumerable_1_T_Func_2_T_Boolean_byref_Nullable_1_T_0, Il2CppClassPointerStore<IzakayaSelectorPanel_New>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
