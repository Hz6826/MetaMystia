using System;
using DayScene.UI.RogueLike;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x020003A0 RID: 928
	public class NoteBookProfileIzakayaSubPannel : UIPanelExtern
	{
		// Token: 0x06006FFD RID: 28669 RVA: 0x002133FC File Offset: 0x002115FC
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookProfileIzakayaSubPannel()
		{
			Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookProfileIzakayaSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr);
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_perIzakayaNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "perIzakayaNum");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_izakayaElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "izakayaElement");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_izakayaContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "izakayaContent");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_unlockedIzakayaTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "unlockedIzakayaTextColor");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_lockedIzakayaTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "lockedIzakayaTextColor");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_unlockedIzakayaPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "unlockedIzakayaPic");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_lockedIzakayaPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "lockedIzakayaPic");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "viewport");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "selected");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_progressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "progressIndicator");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_m_AllIzakayaGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "m_AllIzakayaGroup");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_m_ViewportWorldCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "m_ViewportWorldCenter");
			NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_unlockedIzakayas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "unlockedIzakayas");
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686158);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686159);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686160);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686161);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686162);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_OnIzakayaElementEnabled_Private_Void_String_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686163);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_OnIzakayaElementSelected_Private_Void_String_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686164);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_UpdateIzakayaElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686165);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686166);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686167);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_2_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686168);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_3_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686169);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_4_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686170);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_5_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686171);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_6_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686172);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_7_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686173);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_8_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686174);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_9_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686175);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_10_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686176);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_11_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686177);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_12_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686178);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_13_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686179);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_14_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686180);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_15_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686181);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_16_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686182);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_17_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686183);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_18_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686184);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_19_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686185);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_20_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686186);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_21_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686187);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_22_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686188);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_23_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686189);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_24_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686190);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_25_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686191);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_26_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686192);
			NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_27_Private_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, 100686193);
		}

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x06006FFE RID: 28670 RVA: 0x00213800 File Offset: 0x00211A00
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x00213848 File Offset: 0x00211A48
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x00213890 File Offset: 0x00211A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279959, XrefRangeEnd = 279979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x002138CC File Offset: 0x00211ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279979, XrefRangeEnd = 279984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x00213908 File Offset: 0x00211B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279984, XrefRangeEnd = 279996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x00213944 File Offset: 0x00211B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279996, XrefRangeEnd = 280114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnIzakayaElementEnabled(string mapInfo, UIElementCluster izakaya, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(izakaya);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_OnIzakayaElementEnabled_Private_Void_String_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x002139AC File Offset: 0x00211BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280114, XrefRangeEnd = 280131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnIzakayaElementSelected(string mapInfo, UIElementCluster uiElementCluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_OnIzakayaElementSelected_Private_Void_String_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x00213A14 File Offset: 0x00211C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280201, RefRangeEnd = 280202, XrefRangeStart = 280131, XrefRangeEnd = 280201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIzakayaElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_UpdateIzakayaElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007006 RID: 28678 RVA: 0x00213A48 File Offset: 0x00211C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280202, XrefRangeEnd = 280212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007007 RID: 28679 RVA: 0x00213A84 File Offset: 0x00211C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280212, XrefRangeEnd = 280213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookProfileIzakayaSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007008 RID: 28680 RVA: 0x00213AC0 File Offset: 0x00211CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280213, XrefRangeEnd = 280215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_2(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_2_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x00213B04 File Offset: 0x00211D04
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_3(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_3_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600700A RID: 28682 RVA: 0x00213B48 File Offset: 0x00211D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280215, XrefRangeEnd = 280217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_4(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_4_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x00213B8C File Offset: 0x00211D8C
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_5(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_5_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x00213BD0 File Offset: 0x00211DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_6(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_6_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600700D RID: 28685 RVA: 0x00213C14 File Offset: 0x00211E14
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_7(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_7_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x00213C58 File Offset: 0x00211E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_8(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_8_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600700F RID: 28687 RVA: 0x00213C9C File Offset: 0x00211E9C
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_9(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_9_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007010 RID: 28688 RVA: 0x00213CE0 File Offset: 0x00211EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_10(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_10_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x00213D24 File Offset: 0x00211F24
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_11(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_11_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007012 RID: 28690 RVA: 0x00213D68 File Offset: 0x00211F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_12(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_12_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007013 RID: 28691 RVA: 0x00213DAC File Offset: 0x00211FAC
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_13(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_13_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007014 RID: 28692 RVA: 0x00213DF0 File Offset: 0x00211FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_14(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_14_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007015 RID: 28693 RVA: 0x00213E34 File Offset: 0x00212034
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_15(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_15_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007016 RID: 28694 RVA: 0x00213E78 File Offset: 0x00212078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_16(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_16_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007017 RID: 28695 RVA: 0x00213EBC File Offset: 0x002120BC
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_17(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_17_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007018 RID: 28696 RVA: 0x00213F00 File Offset: 0x00212100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_18(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_18_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007019 RID: 28697 RVA: 0x00213F44 File Offset: 0x00212144
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_19(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_19_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600701A RID: 28698 RVA: 0x00213F88 File Offset: 0x00212188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_20(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_20_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600701B RID: 28699 RVA: 0x00213FCC File Offset: 0x002121CC
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_21(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_21_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600701C RID: 28700 RVA: 0x00214010 File Offset: 0x00212210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_22(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_22_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600701D RID: 28701 RVA: 0x00214054 File Offset: 0x00212254
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_23(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_23_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600701E RID: 28702 RVA: 0x00214098 File Offset: 0x00212298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_24(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_24_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600701F RID: 28703 RVA: 0x002140DC File Offset: 0x002122DC
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_25(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_25_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x00214120 File Offset: 0x00212320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnIzakayaElementEnabled_b__19_26(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_26_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x00214164 File Offset: 0x00212364
		[CallerCount(0)]
		public unsafe void _OnIzakayaElementEnabled_b__19_27(TextMeshProUGUI x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_27_Private_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x0003CD0E File Offset: 0x0003AF0E
		public NoteBookProfileIzakayaSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x06007023 RID: 28707 RVA: 0x002141A8 File Offset: 0x002123A8
		// (set) Token: 0x06007024 RID: 28708 RVA: 0x0003CD17 File Offset: 0x0003AF17
		public unsafe int perIzakayaNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_perIzakayaNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_perIzakayaNum)) = value;
			}
		}

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x06007025 RID: 28709 RVA: 0x002141D0 File Offset: 0x002123D0
		// (set) Token: 0x06007026 RID: 28710 RVA: 0x0003CD32 File Offset: 0x0003AF32
		public unsafe GameObject izakayaElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_izakayaElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_izakayaElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x06007027 RID: 28711 RVA: 0x00214200 File Offset: 0x00212400
		// (set) Token: 0x06007028 RID: 28712 RVA: 0x0003CD51 File Offset: 0x0003AF51
		public unsafe VerticalLayoutGroup izakayaContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_izakayaContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_izakayaContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x06007029 RID: 28713 RVA: 0x00214230 File Offset: 0x00212430
		// (set) Token: 0x0600702A RID: 28714 RVA: 0x0003CD70 File Offset: 0x0003AF70
		public unsafe Color unlockedIzakayaTextColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_unlockedIzakayaTextColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_unlockedIzakayaTextColor)) = value;
			}
		}

		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x0600702B RID: 28715 RVA: 0x00214258 File Offset: 0x00212458
		// (set) Token: 0x0600702C RID: 28716 RVA: 0x0003CD8B File Offset: 0x0003AF8B
		public unsafe Color lockedIzakayaTextColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_lockedIzakayaTextColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_lockedIzakayaTextColor)) = value;
			}
		}

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x0600702D RID: 28717 RVA: 0x00214280 File Offset: 0x00212480
		// (set) Token: 0x0600702E RID: 28718 RVA: 0x0003CDA6 File Offset: 0x0003AFA6
		public unsafe Sprite unlockedIzakayaPic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_unlockedIzakayaPic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_unlockedIzakayaPic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x0600702F RID: 28719 RVA: 0x002142B0 File Offset: 0x002124B0
		// (set) Token: 0x06007030 RID: 28720 RVA: 0x0003CDC5 File Offset: 0x0003AFC5
		public unsafe Sprite lockedIzakayaPic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_lockedIzakayaPic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_lockedIzakayaPic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x06007031 RID: 28721 RVA: 0x002142E0 File Offset: 0x002124E0
		// (set) Token: 0x06007032 RID: 28722 RVA: 0x0003CDE4 File Offset: 0x0003AFE4
		public unsafe RectTransform viewport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_viewport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_viewport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x00214310 File Offset: 0x00212510
		// (set) Token: 0x06007034 RID: 28724 RVA: 0x0003CE03 File Offset: 0x0003B003
		public unsafe CanvasGroup selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x06007035 RID: 28725 RVA: 0x00214340 File Offset: 0x00212540
		// (set) Token: 0x06007036 RID: 28726 RVA: 0x0003CE22 File Offset: 0x0003B022
		public unsafe AdpProgressIndicatorComponent progressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_progressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_progressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x06007037 RID: 28727 RVA: 0x00214370 File Offset: 0x00212570
		// (set) Token: 0x06007038 RID: 28728 RVA: 0x0003CE41 File Offset: 0x0003B041
		public unsafe StaticVirtualScrollListUILogicalGroupT<string, UIElementCluster, UIButtonSimple> m_AllIzakayaGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_m_AllIzakayaGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVirtualScrollListUILogicalGroupT<string, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_m_AllIzakayaGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x06007039 RID: 28729 RVA: 0x002143A0 File Offset: 0x002125A0
		// (set) Token: 0x0600703A RID: 28730 RVA: 0x0003CE60 File Offset: 0x0003B060
		public unsafe Vector3 m_ViewportWorldCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_m_ViewportWorldCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_m_ViewportWorldCenter)) = value;
			}
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x0600703B RID: 28731 RVA: 0x002143C8 File Offset: 0x002125C8
		// (set) Token: 0x0600703C RID: 28732 RVA: 0x0003CE7B File Offset: 0x0003B07B
		public unsafe IEnumerable<int> unlockedIzakayas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_unlockedIzakayas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.NativeFieldInfoPtr_unlockedIzakayas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A2B RID: 18987
		private static readonly IntPtr NativeFieldInfoPtr_perIzakayaNum;

		// Token: 0x04004A2C RID: 18988
		private static readonly IntPtr NativeFieldInfoPtr_izakayaElement;

		// Token: 0x04004A2D RID: 18989
		private static readonly IntPtr NativeFieldInfoPtr_izakayaContent;

		// Token: 0x04004A2E RID: 18990
		private static readonly IntPtr NativeFieldInfoPtr_unlockedIzakayaTextColor;

		// Token: 0x04004A2F RID: 18991
		private static readonly IntPtr NativeFieldInfoPtr_lockedIzakayaTextColor;

		// Token: 0x04004A30 RID: 18992
		private static readonly IntPtr NativeFieldInfoPtr_unlockedIzakayaPic;

		// Token: 0x04004A31 RID: 18993
		private static readonly IntPtr NativeFieldInfoPtr_lockedIzakayaPic;

		// Token: 0x04004A32 RID: 18994
		private static readonly IntPtr NativeFieldInfoPtr_viewport;

		// Token: 0x04004A33 RID: 18995
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x04004A34 RID: 18996
		private static readonly IntPtr NativeFieldInfoPtr_progressIndicator;

		// Token: 0x04004A35 RID: 18997
		private static readonly IntPtr NativeFieldInfoPtr_m_AllIzakayaGroup;

		// Token: 0x04004A36 RID: 18998
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewportWorldCenter;

		// Token: 0x04004A37 RID: 18999
		private static readonly IntPtr NativeFieldInfoPtr_unlockedIzakayas;

		// Token: 0x04004A38 RID: 19000
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004A39 RID: 19001
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004A3A RID: 19002
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004A3B RID: 19003
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004A3C RID: 19004
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004A3D RID: 19005
		private static readonly IntPtr NativeMethodInfoPtr_OnIzakayaElementEnabled_Private_Void_String_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004A3E RID: 19006
		private static readonly IntPtr NativeMethodInfoPtr_OnIzakayaElementSelected_Private_Void_String_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004A3F RID: 19007
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIzakayaElements_Private_Void_0;

		// Token: 0x04004A40 RID: 19008
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004A41 RID: 19009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004A42 RID: 19010
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_2_Private_Void_Image_0;

		// Token: 0x04004A43 RID: 19011
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_3_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A44 RID: 19012
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_4_Private_Void_Image_0;

		// Token: 0x04004A45 RID: 19013
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_5_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A46 RID: 19014
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_6_Private_Void_Image_0;

		// Token: 0x04004A47 RID: 19015
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_7_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A48 RID: 19016
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_8_Private_Void_Image_0;

		// Token: 0x04004A49 RID: 19017
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_9_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A4A RID: 19018
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_10_Private_Void_Image_0;

		// Token: 0x04004A4B RID: 19019
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_11_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A4C RID: 19020
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_12_Private_Void_Image_0;

		// Token: 0x04004A4D RID: 19021
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_13_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A4E RID: 19022
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_14_Private_Void_Image_0;

		// Token: 0x04004A4F RID: 19023
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_15_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A50 RID: 19024
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_16_Private_Void_Image_0;

		// Token: 0x04004A51 RID: 19025
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_17_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A52 RID: 19026
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_18_Private_Void_Image_0;

		// Token: 0x04004A53 RID: 19027
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_19_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A54 RID: 19028
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_20_Private_Void_Image_0;

		// Token: 0x04004A55 RID: 19029
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_21_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A56 RID: 19030
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_22_Private_Void_Image_0;

		// Token: 0x04004A57 RID: 19031
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_23_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A58 RID: 19032
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_24_Private_Void_Image_0;

		// Token: 0x04004A59 RID: 19033
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_25_Private_Void_TextMeshProUGUI_0;

		// Token: 0x04004A5A RID: 19034
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_26_Private_Void_Image_0;

		// Token: 0x04004A5B RID: 19035
		private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_27_Private_Void_TextMeshProUGUI_0;

		// Token: 0x02000EF0 RID: 3824
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookProfileIzakayaSubPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010CCC RID: 68812 RVA: 0x003E2858 File Offset: 0x003E0A58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr);
				NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, "<>9");
				NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, "<>9__19_0");
				NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, "<>9__19_1");
				NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, "<>9__21_0");
				NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__21_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, "<>9__21_1");
				NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__21_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, "<>9__21_2");
				NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, 100686195);
				NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, 100686196);
				NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, 100686197);
				NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__UpdateIzakayaElements_b__21_0_Internal_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, 100686198);
				NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__UpdateIzakayaElements_b__21_1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, 100686199);
				NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__UpdateIzakayaElements_b__21_2_Internal_String_MapSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr, 100686200);
			}

			// Token: 0x06010CCD RID: 68813 RVA: 0x003E2974 File Offset: 0x003E0B74
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CCE RID: 68814 RVA: 0x003E29B0 File Offset: 0x003E0BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279933, XrefRangeEnd = 279937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnIzakayaElementEnabled_b__19_0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CCF RID: 68815 RVA: 0x003E29F4 File Offset: 0x003E0BF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279937, XrefRangeEnd = 279941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnIzakayaElementEnabled_b__19_1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CD0 RID: 68816 RVA: 0x003E2A38 File Offset: 0x003E0C38
			[CallerCount(0)]
			public unsafe int _UpdateIzakayaElements_b__21_0(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__UpdateIzakayaElements_b__21_0_Internal_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010CD1 RID: 68817 RVA: 0x003E2A88 File Offset: 0x003E0C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279941, XrefRangeEnd = 279949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateIzakayaElements_b__21_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__UpdateIzakayaElements_b__21_1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010CD2 RID: 68818 RVA: 0x003E2AD8 File Offset: 0x003E0CD8
			[CallerCount(0)]
			public unsafe string _UpdateIzakayaElements_b__21_2(DLC5_RogueLikeDataProfile.MapSetup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.__c.NativeMethodInfoPtr__UpdateIzakayaElements_b__21_2_Internal_String_MapSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010CD3 RID: 68819 RVA: 0x0009270A File Offset: 0x0009090A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005781 RID: 22401
			// (get) Token: 0x06010CD4 RID: 68820 RVA: 0x003E2B28 File Offset: 0x003E0D28
			// (set) Token: 0x06010CD5 RID: 68821 RVA: 0x00092713 File Offset: 0x00090913
			public unsafe static NoteBookProfileIzakayaSubPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookProfileIzakayaSubPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005782 RID: 22402
			// (get) Token: 0x06010CD6 RID: 68822 RVA: 0x003E2B50 File Offset: 0x003E0D50
			// (set) Token: 0x06010CD7 RID: 68823 RVA: 0x00092725 File Offset: 0x00090925
			public unsafe static Action<Image> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005783 RID: 22403
			// (get) Token: 0x06010CD8 RID: 68824 RVA: 0x003E2B78 File Offset: 0x003E0D78
			// (set) Token: 0x06010CD9 RID: 68825 RVA: 0x00092737 File Offset: 0x00090937
			public unsafe static Action<Image> __9__19_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__19_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005784 RID: 22404
			// (get) Token: 0x06010CDA RID: 68826 RVA: 0x003E2BA0 File Offset: 0x003E0DA0
			// (set) Token: 0x06010CDB RID: 68827 RVA: 0x00092749 File Offset: 0x00090949
			public unsafe static Func<Izakaya, int> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005785 RID: 22405
			// (get) Token: 0x06010CDC RID: 68828 RVA: 0x003E2BC8 File Offset: 0x003E0DC8
			// (set) Token: 0x06010CDD RID: 68829 RVA: 0x0009275B File Offset: 0x0009095B
			public unsafe static Func<string, bool> __9__21_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__21_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__21_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005786 RID: 22406
			// (get) Token: 0x06010CDE RID: 68830 RVA: 0x003E2BF0 File Offset: 0x003E0DF0
			// (set) Token: 0x06010CDF RID: 68831 RVA: 0x0009276D File Offset: 0x0009096D
			public unsafe static Func<DLC5_RogueLikeDataProfile.MapSetup, string> __9__21_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__21_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.MapSetup, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileIzakayaSubPannel.__c.NativeFieldInfoPtr___9__21_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA03 RID: 43523
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AA04 RID: 43524
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x0400AA05 RID: 43525
			private static readonly IntPtr NativeFieldInfoPtr___9__19_1;

			// Token: 0x0400AA06 RID: 43526
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x0400AA07 RID: 43527
			private static readonly IntPtr NativeFieldInfoPtr___9__21_1;

			// Token: 0x0400AA08 RID: 43528
			private static readonly IntPtr NativeFieldInfoPtr___9__21_2;

			// Token: 0x0400AA09 RID: 43529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA0A RID: 43530
			private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_0_Internal_Void_Image_0;

			// Token: 0x0400AA0B RID: 43531
			private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementEnabled_b__19_1_Internal_Void_Image_0;

			// Token: 0x0400AA0C RID: 43532
			private static readonly IntPtr NativeMethodInfoPtr__UpdateIzakayaElements_b__21_0_Internal_Int32_Izakaya_0;

			// Token: 0x0400AA0D RID: 43533
			private static readonly IntPtr NativeMethodInfoPtr__UpdateIzakayaElements_b__21_1_Internal_Boolean_String_0;

			// Token: 0x0400AA0E RID: 43534
			private static readonly IntPtr NativeMethodInfoPtr__UpdateIzakayaElements_b__21_2_Internal_String_MapSetup_0;
		}

		// Token: 0x02000EF1 RID: 3825
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookProfileIzakayaSubPannel+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x06010CE0 RID: 68832 RVA: 0x003E2C18 File Offset: 0x003E0E18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0>.NativeClassPtr);
				NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_uiElementCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0>.NativeClassPtr, "uiElementCluster");
				NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0>.NativeClassPtr, 100686201);
				NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__OnIzakayaElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0>.NativeClassPtr, 100686202);
			}

			// Token: 0x06010CE1 RID: 68833 RVA: 0x003E2C94 File Offset: 0x003E0E94
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CE2 RID: 68834 RVA: 0x003E2CD0 File Offset: 0x003E0ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279949, XrefRangeEnd = 279959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnIzakayaElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__OnIzakayaElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CE3 RID: 68835 RVA: 0x0009277F File Offset: 0x0009097F
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005787 RID: 22407
			// (get) Token: 0x06010CE4 RID: 68836 RVA: 0x003E2D04 File Offset: 0x003E0F04
			// (set) Token: 0x06010CE5 RID: 68837 RVA: 0x00092788 File Offset: 0x00090988
			public unsafe UIElementCluster uiElementCluster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_uiElementCluster);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_uiElementCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005788 RID: 22408
			// (get) Token: 0x06010CE6 RID: 68838 RVA: 0x003E2D34 File Offset: 0x003E0F34
			// (set) Token: 0x06010CE7 RID: 68839 RVA: 0x000927A7 File Offset: 0x000909A7
			public unsafe NoteBookProfileIzakayaSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookProfileIzakayaSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileIzakayaSubPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA0F RID: 43535
			private static readonly IntPtr NativeFieldInfoPtr_uiElementCluster;

			// Token: 0x0400AA10 RID: 43536
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA11 RID: 43537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA12 RID: 43538
			private static readonly IntPtr NativeMethodInfoPtr__OnIzakayaElementSelected_b__0_Internal_Void_0;
		}
	}
}
