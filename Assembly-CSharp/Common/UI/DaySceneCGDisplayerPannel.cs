using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x0200036C RID: 876
	public class DaySceneCGDisplayerPannel : UIPanel
	{
		// Token: 0x060067F5 RID: 26613 RVA: 0x001F978C File Offset: 0x001F798C
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneCGDisplayerPannel()
		{
			Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DaySceneCGDisplayerPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr);
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_MAX_PIC_PER_PAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "MAX_PIC_PER_PAGE");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_SPLIT_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "SPLIT_DATA");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_CGPictureElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "CGPictureElement");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_leftPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "leftPannel");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_rightPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "rightPannel");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_GotoPreviousBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "GotoPreviousBtn");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_GotoNextBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "GotoNextBtn");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_currentPageNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "currentPageNum");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_wholePageNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "wholePageNum");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_PanelOpenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "PanelOpenMode");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_FanArtLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "FanArtLabel");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_SubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "SubPannel");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_AllCGPictures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "AllCGPictures");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_CGPicturesLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "CGPicturesLeft");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_CGPicturesRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "CGPicturesRight");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_currentPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "currentPage");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_isSelectingLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "isSelectingLeft");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_m_AlbumPicLeftGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "m_AlbumPicLeftGroup");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_m_AlbumPicRightGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "m_AlbumPicRightGroup");
			DaySceneCGDisplayerPannel.NativeFieldInfoPtr_releaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "releaseHandle");
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684975);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684976);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnSwitchMove_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684977);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnSwitchScroll_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684978);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnSwitch_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684979);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_GoToNext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684980);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_GoToPrevious_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684981);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_GetCGAssetReference_Private_ValueTuple_3_AssetReference_Boolean_Boolean_MultiLanguageCGPic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684982);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684983);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_InitVisual_Public_Static_Void_Image_IList_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684984);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684985);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_UpdateCurrentPage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684986);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_TryReselect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684987);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OpenCGDescriber_Private_Void_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684988);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_SortSprites_Private_IList_1_Sprite_IList_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684989);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_ReleaseAsset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684990);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684991);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684992);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684993);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr__OnPanelOpen_b__22_0_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684994);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr__OnPanelOpen_b__22_1_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684995);
			DaySceneCGDisplayerPannel.NativeMethodInfoPtr__OpenCGDescriber_b__34_0_Private_ValueTuple_3_Sprite_Boolean_Boolean_ValueTuple_3_AssetReference_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, 100684996);
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x001F9B04 File Offset: 0x001F7D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266950, XrefRangeEnd = 266985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x001F9B40 File Offset: 0x001F7D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266985, XrefRangeEnd = 267113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x001F9B7C File Offset: 0x001F7D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267113, XrefRangeEnd = 267117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSwitchMove(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnSwitchMove_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x001F9BC4 File Offset: 0x001F7DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267117, XrefRangeEnd = 267121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSwitchScroll(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnSwitchScroll_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x001F9C0C File Offset: 0x001F7E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267126, RefRangeEnd = 267128, XrefRangeStart = 267121, XrefRangeEnd = 267126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSwitch(float dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnSwitch_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x001F9C4C File Offset: 0x001F7E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267128, XrefRangeEnd = 267133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_GoToNext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x001F9C80 File Offset: 0x001F7E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267133, XrefRangeEnd = 267135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToPrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_GoToPrevious_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x001F9CB4 File Offset: 0x001F7EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267143, RefRangeEnd = 267144, XrefRangeStart = 267135, XrefRangeEnd = 267143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<AssetReference, bool, bool> GetCGAssetReference(RunTimeScheduler.CGPicture.MultiLanguageCGPic multiLanguageCGPic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(multiLanguageCGPic);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_GetCGAssetReference_Private_ValueTuple_3_AssetReference_Boolean_Boolean_MultiLanguageCGPic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<AssetReference, bool, bool>(pointer);
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x001F9CFC File Offset: 0x001F7EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267144, XrefRangeEnd = 267236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled(ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>> cgData, UIElementCluster uiElement, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cgData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElement);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x001F9D68 File Offset: 0x001F7F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267261, RefRangeEnd = 267262, XrefRangeStart = 267236, XrefRangeEnd = 267261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitVisual(Image x, IList<Sprite> loaded)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loaded);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_InitVisual_Public_Static_Void_Image_IList_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x001F9DB0 File Offset: 0x001F7FB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267276, RefRangeEnd = 267278, XrefRangeStart = 267262, XrefRangeEnd = 267276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementSelected(ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>> cgData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cgData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006801 RID: 26625 RVA: 0x001F9E1C File Offset: 0x001F801C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 267308, RefRangeEnd = 267312, XrefRangeStart = 267278, XrefRangeEnd = 267308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentPage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_UpdateCurrentPage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006802 RID: 26626 RVA: 0x001F9E50 File Offset: 0x001F8050
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 267326, RefRangeEnd = 267329, XrefRangeStart = 267312, XrefRangeEnd = 267326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryReselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_TryReselect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x001F9E84 File Offset: 0x001F8084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267329, XrefRangeEnd = 267351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenCGDescriber(List<ValueTuple<AssetReference, bool, bool>> picAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(picAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OpenCGDescriber_Private_Void_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x001F9EC8 File Offset: 0x001F80C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267377, RefRangeEnd = 267379, XrefRangeStart = 267351, XrefRangeEnd = 267377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<Sprite> SortSprites(IList<Sprite> sprites)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprites);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_SortSprites_Private_IList_1_Sprite_IList_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Sprite>>(intPtr3) : null;
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x001F9F18 File Offset: 0x001F8118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267379, XrefRangeEnd = 267380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr_ReleaseAsset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x001F9F4C File Offset: 0x001F814C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267380, XrefRangeEnd = 267388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCGDisplayerPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x001F9F88 File Offset: 0x001F8188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267388, XrefRangeEnd = 267409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCGDisplayerPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x001F9FC4 File Offset: 0x001F81C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267409, XrefRangeEnd = 267430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneCGDisplayerPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x001FA000 File Offset: 0x001F8200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267430, XrefRangeEnd = 267431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__22_0(ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>> a, UIElementCluster b, UIButtonSimple c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr__OnPanelOpen_b__22_0_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x001FA06C File Offset: 0x001F826C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267431, XrefRangeEnd = 267432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__22_1(ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>> a, UIElementCluster b, UIButtonSimple c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr__OnPanelOpen_b__22_1_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x001FA0D8 File Offset: 0x001F82D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267432, XrefRangeEnd = 267442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<Sprite, bool, bool> _OpenCGDescriber_b__34_0(ValueTuple<AssetReference, bool, bool> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.NativeMethodInfoPtr__OpenCGDescriber_b__34_0_Private_ValueTuple_3_Sprite_Boolean_Boolean_ValueTuple_3_AssetReference_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<Sprite, bool, bool>(pointer);
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x00038331 File Offset: 0x00036531
		public DaySceneCGDisplayerPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0600680D RID: 26637 RVA: 0x001FA128 File Offset: 0x001F8328
		// (set) Token: 0x0600680E RID: 26638 RVA: 0x0003833A File Offset: 0x0003653A
		public unsafe static int MAX_PIC_PER_PAGE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_MAX_PIC_PER_PAGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_MAX_PIC_PER_PAGE, (void*)(&value));
			}
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x0600680F RID: 26639 RVA: 0x001FA144 File Offset: 0x001F8344
		// (set) Token: 0x06006810 RID: 26640 RVA: 0x00038348 File Offset: 0x00036548
		public unsafe static string SPLIT_DATA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_SPLIT_DATA, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_SPLIT_DATA, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x06006811 RID: 26641 RVA: 0x001FA164 File Offset: 0x001F8364
		// (set) Token: 0x06006812 RID: 26642 RVA: 0x0003835A File Offset: 0x0003655A
		public unsafe GameObject CGPictureElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_CGPictureElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_CGPictureElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x06006813 RID: 26643 RVA: 0x001FA194 File Offset: 0x001F8394
		// (set) Token: 0x06006814 RID: 26644 RVA: 0x00038379 File Offset: 0x00036579
		public unsafe GridLayoutGroup leftPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_leftPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_leftPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x06006815 RID: 26645 RVA: 0x001FA1C4 File Offset: 0x001F83C4
		// (set) Token: 0x06006816 RID: 26646 RVA: 0x00038398 File Offset: 0x00036598
		public unsafe GridLayoutGroup rightPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_rightPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_rightPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x06006817 RID: 26647 RVA: 0x001FA1F4 File Offset: 0x001F83F4
		// (set) Token: 0x06006818 RID: 26648 RVA: 0x000383B7 File Offset: 0x000365B7
		public unsafe UIButtonSimple GotoPreviousBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_GotoPreviousBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_GotoPreviousBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x06006819 RID: 26649 RVA: 0x001FA224 File Offset: 0x001F8424
		// (set) Token: 0x0600681A RID: 26650 RVA: 0x000383D6 File Offset: 0x000365D6
		public unsafe UIButtonSimple GotoNextBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_GotoNextBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_GotoNextBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x0600681B RID: 26651 RVA: 0x001FA254 File Offset: 0x001F8454
		// (set) Token: 0x0600681C RID: 26652 RVA: 0x000383F5 File Offset: 0x000365F5
		public unsafe TextMeshProUGUI currentPageNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_currentPageNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_currentPageNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x0600681D RID: 26653 RVA: 0x001FA284 File Offset: 0x001F8484
		// (set) Token: 0x0600681E RID: 26654 RVA: 0x00038414 File Offset: 0x00036614
		public unsafe TextMeshProUGUI wholePageNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_wholePageNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_wholePageNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x0600681F RID: 26655 RVA: 0x001FA2B4 File Offset: 0x001F84B4
		// (set) Token: 0x06006820 RID: 26656 RVA: 0x00038433 File Offset: 0x00036633
		public unsafe DaySceneCGDisplayerPannel.OpenMode PanelOpenMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_PanelOpenMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_PanelOpenMode)) = value;
			}
		}

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x06006821 RID: 26657 RVA: 0x001FA2DC File Offset: 0x001F84DC
		// (set) Token: 0x06006822 RID: 26658 RVA: 0x0003844E File Offset: 0x0003664E
		public unsafe string FanArtLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_FanArtLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_FanArtLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x06006823 RID: 26659 RVA: 0x001FA304 File Offset: 0x001F8504
		// (set) Token: 0x06006824 RID: 26660 RVA: 0x0003846D File Offset: 0x0003666D
		public unsafe DaySceneCGDisplayerSubPannel SubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_SubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCGDisplayerSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_SubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x06006825 RID: 26661 RVA: 0x001FA334 File Offset: 0x001F8534
		// (set) Token: 0x06006826 RID: 26662 RVA: 0x0003848C File Offset: 0x0003668C
		public unsafe Dictionary<int, ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>> AllCGPictures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_AllCGPictures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_AllCGPictures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x06006827 RID: 26663 RVA: 0x001FA364 File Offset: 0x001F8564
		// (set) Token: 0x06006828 RID: 26664 RVA: 0x000384AB File Offset: 0x000366AB
		public unsafe List<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>> CGPicturesLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_CGPicturesLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_CGPicturesLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x001FA394 File Offset: 0x001F8594
		// (set) Token: 0x0600682A RID: 26666 RVA: 0x000384CA File Offset: 0x000366CA
		public unsafe List<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>> CGPicturesRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_CGPicturesRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_CGPicturesRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x0600682B RID: 26667 RVA: 0x001FA3C4 File Offset: 0x001F85C4
		// (set) Token: 0x0600682C RID: 26668 RVA: 0x000384E9 File Offset: 0x000366E9
		public unsafe int currentPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_currentPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_currentPage)) = value;
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x0600682D RID: 26669 RVA: 0x001FA3EC File Offset: 0x001F85EC
		// (set) Token: 0x0600682E RID: 26670 RVA: 0x00038504 File Offset: 0x00036704
		public unsafe bool isSelectingLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_isSelectingLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_isSelectingLeft)) = value;
			}
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x0600682F RID: 26671 RVA: 0x001FA414 File Offset: 0x001F8614
		// (set) Token: 0x06006830 RID: 26672 RVA: 0x0003851F File Offset: 0x0003671F
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>, UIElementCluster, UIButtonSimple> m_AlbumPicLeftGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_m_AlbumPicLeftGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_m_AlbumPicLeftGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x06006831 RID: 26673 RVA: 0x001FA444 File Offset: 0x001F8644
		// (set) Token: 0x06006832 RID: 26674 RVA: 0x0003853E File Offset: 0x0003673E
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>, UIElementCluster, UIButtonSimple> m_AlbumPicRightGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_m_AlbumPicRightGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_m_AlbumPicRightGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x06006833 RID: 26675 RVA: 0x001FA474 File Offset: 0x001F8674
		// (set) Token: 0x06006834 RID: 26676 RVA: 0x0003855D File Offset: 0x0003675D
		public unsafe Action releaseHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_releaseHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.NativeFieldInfoPtr_releaseHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044EF RID: 17647
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PIC_PER_PAGE;

		// Token: 0x040044F0 RID: 17648
		private static readonly IntPtr NativeFieldInfoPtr_SPLIT_DATA;

		// Token: 0x040044F1 RID: 17649
		private static readonly IntPtr NativeFieldInfoPtr_CGPictureElement;

		// Token: 0x040044F2 RID: 17650
		private static readonly IntPtr NativeFieldInfoPtr_leftPannel;

		// Token: 0x040044F3 RID: 17651
		private static readonly IntPtr NativeFieldInfoPtr_rightPannel;

		// Token: 0x040044F4 RID: 17652
		private static readonly IntPtr NativeFieldInfoPtr_GotoPreviousBtn;

		// Token: 0x040044F5 RID: 17653
		private static readonly IntPtr NativeFieldInfoPtr_GotoNextBtn;

		// Token: 0x040044F6 RID: 17654
		private static readonly IntPtr NativeFieldInfoPtr_currentPageNum;

		// Token: 0x040044F7 RID: 17655
		private static readonly IntPtr NativeFieldInfoPtr_wholePageNum;

		// Token: 0x040044F8 RID: 17656
		private static readonly IntPtr NativeFieldInfoPtr_PanelOpenMode;

		// Token: 0x040044F9 RID: 17657
		private static readonly IntPtr NativeFieldInfoPtr_FanArtLabel;

		// Token: 0x040044FA RID: 17658
		private static readonly IntPtr NativeFieldInfoPtr_SubPannel;

		// Token: 0x040044FB RID: 17659
		private static readonly IntPtr NativeFieldInfoPtr_AllCGPictures;

		// Token: 0x040044FC RID: 17660
		private static readonly IntPtr NativeFieldInfoPtr_CGPicturesLeft;

		// Token: 0x040044FD RID: 17661
		private static readonly IntPtr NativeFieldInfoPtr_CGPicturesRight;

		// Token: 0x040044FE RID: 17662
		private static readonly IntPtr NativeFieldInfoPtr_currentPage;

		// Token: 0x040044FF RID: 17663
		private static readonly IntPtr NativeFieldInfoPtr_isSelectingLeft;

		// Token: 0x04004500 RID: 17664
		private static readonly IntPtr NativeFieldInfoPtr_m_AlbumPicLeftGroup;

		// Token: 0x04004501 RID: 17665
		private static readonly IntPtr NativeFieldInfoPtr_m_AlbumPicRightGroup;

		// Token: 0x04004502 RID: 17666
		private static readonly IntPtr NativeFieldInfoPtr_releaseHandle;

		// Token: 0x04004503 RID: 17667
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004504 RID: 17668
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004505 RID: 17669
		private static readonly IntPtr NativeMethodInfoPtr_OnSwitchMove_Private_Void_CallbackContext_0;

		// Token: 0x04004506 RID: 17670
		private static readonly IntPtr NativeMethodInfoPtr_OnSwitchScroll_Private_Void_CallbackContext_0;

		// Token: 0x04004507 RID: 17671
		private static readonly IntPtr NativeMethodInfoPtr_OnSwitch_Private_Void_Single_0;

		// Token: 0x04004508 RID: 17672
		private static readonly IntPtr NativeMethodInfoPtr_GoToNext_Private_Void_0;

		// Token: 0x04004509 RID: 17673
		private static readonly IntPtr NativeMethodInfoPtr_GoToPrevious_Private_Void_0;

		// Token: 0x0400450A RID: 17674
		private static readonly IntPtr NativeMethodInfoPtr_GetCGAssetReference_Private_ValueTuple_3_AssetReference_Boolean_Boolean_MultiLanguageCGPic_0;

		// Token: 0x0400450B RID: 17675
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0;

		// Token: 0x0400450C RID: 17676
		private static readonly IntPtr NativeMethodInfoPtr_InitVisual_Public_Static_Void_Image_IList_1_Sprite_0;

		// Token: 0x0400450D RID: 17677
		private static readonly IntPtr NativeMethodInfoPtr_OnElementSelected_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0;

		// Token: 0x0400450E RID: 17678
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentPage_Private_Void_0;

		// Token: 0x0400450F RID: 17679
		private static readonly IntPtr NativeMethodInfoPtr_TryReselect_Private_Void_0;

		// Token: 0x04004510 RID: 17680
		private static readonly IntPtr NativeMethodInfoPtr_OpenCGDescriber_Private_Void_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_0;

		// Token: 0x04004511 RID: 17681
		private static readonly IntPtr NativeMethodInfoPtr_SortSprites_Private_IList_1_Sprite_IList_1_Sprite_0;

		// Token: 0x04004512 RID: 17682
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAsset_Private_Void_0;

		// Token: 0x04004513 RID: 17683
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004514 RID: 17684
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004515 RID: 17685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004516 RID: 17686
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__22_0_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004517 RID: 17687
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__22_1_Private_Void_ValueTuple_2_String_List_1_ValueTuple_3_AssetReference_Boolean_Boolean_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004518 RID: 17688
		private static readonly IntPtr NativeMethodInfoPtr__OpenCGDescriber_b__34_0_Private_ValueTuple_3_Sprite_Boolean_Boolean_ValueTuple_3_AssetReference_Boolean_Boolean_0;

		// Token: 0x02000E6F RID: 3695
		public enum OpenMode
		{
			// Token: 0x0400A68B RID: 42635
			CG,
			// Token: 0x0400A68C RID: 42636
			FanArt
		}

		// Token: 0x02000E70 RID: 3696
		[ObfuscatedName("Common.UI.DaySceneCGDisplayerPannel+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x06010715 RID: 67349 RVA: 0x003D1290 File Offset: 0x003CF490
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass22_0>.NativeClassPtr);
				DaySceneCGDisplayerPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_picDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass22_0>.NativeClassPtr, "picDic");
				DaySceneCGDisplayerPannel.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				DaySceneCGDisplayerPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass22_0>.NativeClassPtr, 100684997);
				DaySceneCGDisplayerPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_MultiLanguageCGPic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass22_0>.NativeClassPtr, 100684998);
			}

			// Token: 0x06010716 RID: 67350 RVA: 0x003D130C File Offset: 0x003CF50C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010717 RID: 67351 RVA: 0x003D1348 File Offset: 0x003CF548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266834, XrefRangeEnd = 266837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__2(RunTimeScheduler.CGPicture.MultiLanguageCGPic x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_MultiLanguageCGPic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010718 RID: 67352 RVA: 0x0008F778 File Offset: 0x0008D978
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055E4 RID: 21988
			// (get) Token: 0x06010719 RID: 67353 RVA: 0x003D138C File Offset: 0x003CF58C
			// (set) Token: 0x0601071A RID: 67354 RVA: 0x0008F781 File Offset: 0x0008D981
			public unsafe List<ValueTuple<AssetReference, bool, bool>> picDic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_picDic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<AssetReference, bool, bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_picDic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055E5 RID: 21989
			// (get) Token: 0x0601071B RID: 67355 RVA: 0x003D13BC File Offset: 0x003CF5BC
			// (set) Token: 0x0601071C RID: 67356 RVA: 0x0008F7A0 File Offset: 0x0008D9A0
			public unsafe DaySceneCGDisplayerPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCGDisplayerPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A68D RID: 42637
			private static readonly IntPtr NativeFieldInfoPtr_picDic;

			// Token: 0x0400A68E RID: 42638
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A68F RID: 42639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A690 RID: 42640
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_MultiLanguageCGPic_0;
		}

		// Token: 0x02000E71 RID: 3697
		[ObfuscatedName("Common.UI.DaySceneCGDisplayerPannel+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0601071D RID: 67357 RVA: 0x003D13EC File Offset: 0x003CF5EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_opCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, "opCount");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_uiElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, "uiElement");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, "image");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, "loaded");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_imageCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, "imageCanvasGroup");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_spriteNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, "spriteNum");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, "<>9__7");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, 100684999);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, 100685000);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, 100685001);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, 100685002);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__OnElementEnabled_b__7_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr, 100685003);
			}

			// Token: 0x0601071E RID: 67358 RVA: 0x003D151C File Offset: 0x003CF71C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601071F RID: 67359 RVA: 0x003D1558 File Offset: 0x003CF758
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 266863, RefRangeEnd = 266864, XrefRangeStart = 266837, XrefRangeEnd = 266863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_0(int num)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010720 RID: 67360 RVA: 0x003D1598 File Offset: 0x003CF798
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 266889, RefRangeEnd = 266890, XrefRangeStart = 266864, XrefRangeEnd = 266889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_Int32_Int32_0(AsyncOperationHandle<IList<Sprite>> handle, int num, int page)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref page;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010721 RID: 67361 RVA: 0x003D15FC File Offset: 0x003CF7FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 266904, RefRangeEnd = 266905, XrefRangeStart = 266890, XrefRangeEnd = 266904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_Int32_0(AsyncOperationHandle<IList<Sprite>> handle, int num)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010722 RID: 67362 RVA: 0x003D1654 File Offset: 0x003CF854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266905, XrefRangeEnd = 266906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__7(AsyncOperationHandle<IList<Sprite>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__OnElementEnabled_b__7_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010723 RID: 67363 RVA: 0x0008F7BF File Offset: 0x0008D9BF
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055E6 RID: 21990
			// (get) Token: 0x06010724 RID: 67364 RVA: 0x003D169C File Offset: 0x003CF89C
			// (set) Token: 0x06010725 RID: 67365 RVA: 0x0008F7C8 File Offset: 0x0008D9C8
			public unsafe int opCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_opCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_opCount)) = value;
				}
			}

			// Token: 0x170055E7 RID: 21991
			// (get) Token: 0x06010726 RID: 67366 RVA: 0x003D16C4 File Offset: 0x003CF8C4
			// (set) Token: 0x06010727 RID: 67367 RVA: 0x0008F7E3 File Offset: 0x0008D9E3
			public unsafe UIElementCluster uiElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_uiElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_uiElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055E8 RID: 21992
			// (get) Token: 0x06010728 RID: 67368 RVA: 0x003D16F4 File Offset: 0x003CF8F4
			// (set) Token: 0x06010729 RID: 67369 RVA: 0x0008F802 File Offset: 0x0008DA02
			public unsafe Image image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055E9 RID: 21993
			// (get) Token: 0x0601072A RID: 67370 RVA: 0x003D1724 File Offset: 0x003CF924
			// (set) Token: 0x0601072B RID: 67371 RVA: 0x0008F821 File Offset: 0x0008DA21
			public unsafe IList<Sprite> loaded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_loaded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_loaded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055EA RID: 21994
			// (get) Token: 0x0601072C RID: 67372 RVA: 0x003D1754 File Offset: 0x003CF954
			// (set) Token: 0x0601072D RID: 67373 RVA: 0x0008F840 File Offset: 0x0008DA40
			public unsafe CanvasGroup imageCanvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_imageCanvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_imageCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055EB RID: 21995
			// (get) Token: 0x0601072E RID: 67374 RVA: 0x003D1784 File Offset: 0x003CF984
			// (set) Token: 0x0601072F RID: 67375 RVA: 0x0008F85F File Offset: 0x0008DA5F
			public unsafe int spriteNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_spriteNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_spriteNum)) = value;
				}
			}

			// Token: 0x170055EC RID: 21996
			// (get) Token: 0x06010730 RID: 67376 RVA: 0x003D17AC File Offset: 0x003CF9AC
			// (set) Token: 0x06010731 RID: 67377 RVA: 0x0008F87A File Offset: 0x0008DA7A
			public unsafe DaySceneCGDisplayerPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCGDisplayerPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055ED RID: 21997
			// (get) Token: 0x06010732 RID: 67378 RVA: 0x003D17DC File Offset: 0x003CF9DC
			// (set) Token: 0x06010733 RID: 67379 RVA: 0x0008F899 File Offset: 0x0008DA99
			public unsafe Action<AsyncOperationHandle<IList<Sprite>>> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<IList<Sprite>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A691 RID: 42641
			private static readonly IntPtr NativeFieldInfoPtr_opCount;

			// Token: 0x0400A692 RID: 42642
			private static readonly IntPtr NativeFieldInfoPtr_uiElement;

			// Token: 0x0400A693 RID: 42643
			private static readonly IntPtr NativeFieldInfoPtr_image;

			// Token: 0x0400A694 RID: 42644
			private static readonly IntPtr NativeFieldInfoPtr_loaded;

			// Token: 0x0400A695 RID: 42645
			private static readonly IntPtr NativeFieldInfoPtr_imageCanvasGroup;

			// Token: 0x0400A696 RID: 42646
			private static readonly IntPtr NativeFieldInfoPtr_spriteNum;

			// Token: 0x0400A697 RID: 42647
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A698 RID: 42648
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x0400A699 RID: 42649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A69A RID: 42650
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_0;

			// Token: 0x0400A69B RID: 42651
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_Int32_Int32_0;

			// Token: 0x0400A69C RID: 42652
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_Int32_0;

			// Token: 0x0400A69D RID: 42653
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__7_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_0;
		}

		// Token: 0x02000E72 RID: 3698
		[ObfuscatedName("Common.UI.DaySceneCGDisplayerPannel+<>c__DisplayClass29_1")]
		public sealed class __c__DisplayClass29_1 : Il2CppSystem.Object
		{
			// Token: 0x06010734 RID: 67380 RVA: 0x003D180C File Offset: 0x003CFA0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_1()
			{
				Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "<>c__DisplayClass29_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_1>.NativeClassPtr);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_1>.NativeClassPtr, "num");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_1>.NativeClassPtr, 100685004);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_1>.NativeClassPtr, 100685005);
			}

			// Token: 0x06010735 RID: 67381 RVA: 0x003D1874 File Offset: 0x003CFA74
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010736 RID: 67382 RVA: 0x003D18B0 File Offset: 0x003CFAB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266906, XrefRangeEnd = 266909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010737 RID: 67383 RVA: 0x0008F8B8 File Offset: 0x0008DAB8
			public __c__DisplayClass29_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055EE RID: 21998
			// (get) Token: 0x06010738 RID: 67384 RVA: 0x003D18F4 File Offset: 0x003CFAF4
			// (set) Token: 0x06010739 RID: 67385 RVA: 0x0008F8C1 File Offset: 0x0008DAC1
			public unsafe int num
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_num);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_num)) = value;
				}
			}

			// Token: 0x0400A69E RID: 42654
			private static readonly IntPtr NativeFieldInfoPtr_num;

			// Token: 0x0400A69F RID: 42655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6A0 RID: 42656
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_Image_0;
		}

		// Token: 0x02000E73 RID: 3699
		[ObfuscatedName("Common.UI.DaySceneCGDisplayerPannel+<>c__DisplayClass29_2")]
		public sealed class __c__DisplayClass29_2 : Il2CppSystem.Object
		{
			// Token: 0x0601073A RID: 67386 RVA: 0x003D191C File Offset: 0x003CFB1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_2()
			{
				Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "<>c__DisplayClass29_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_2>.NativeClassPtr);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_2.NativeFieldInfoPtr_currentPageForLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_2>.NativeClassPtr, "currentPageForLoad");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_2.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_2>.NativeClassPtr, "CS$<>8__locals1");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_2>.NativeClassPtr, 100685006);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_2.NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_2>.NativeClassPtr, 100685007);
			}

			// Token: 0x0601073B RID: 67387 RVA: 0x003D1998 File Offset: 0x003CFB98
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601073C RID: 67388 RVA: 0x003D19D4 File Offset: 0x003CFBD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266909, XrefRangeEnd = 266910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__3(AsyncOperationHandle<IList<Sprite>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_2.NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601073D RID: 67389 RVA: 0x0008F8DC File Offset: 0x0008DADC
			public __c__DisplayClass29_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055EF RID: 21999
			// (get) Token: 0x0601073E RID: 67390 RVA: 0x003D1A1C File Offset: 0x003CFC1C
			// (set) Token: 0x0601073F RID: 67391 RVA: 0x0008F8E5 File Offset: 0x0008DAE5
			public unsafe int currentPageForLoad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_2.NativeFieldInfoPtr_currentPageForLoad);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_2.NativeFieldInfoPtr_currentPageForLoad)) = value;
				}
			}

			// Token: 0x170055F0 RID: 22000
			// (get) Token: 0x06010740 RID: 67392 RVA: 0x003D1A44 File Offset: 0x003CFC44
			// (set) Token: 0x06010741 RID: 67393 RVA: 0x0008F900 File Offset: 0x0008DB00
			public unsafe DaySceneCGDisplayerPannel.__c__DisplayClass29_0 field_Public___c__DisplayClass29_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_2.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCGDisplayerPannel.__c__DisplayClass29_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_2.NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6A1 RID: 42657
			private static readonly IntPtr NativeFieldInfoPtr_currentPageForLoad;

			// Token: 0x0400A6A2 RID: 42658
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass29_0_0;

			// Token: 0x0400A6A3 RID: 42659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6A4 RID: 42660
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_AsyncOperationHandle_1_IList_1_Sprite_0;
		}

		// Token: 0x02000E74 RID: 3700
		[ObfuscatedName("Common.UI.DaySceneCGDisplayerPannel+<>c__DisplayClass29_3")]
		public sealed class __c__DisplayClass29_3 : Il2CppSystem.Object
		{
			// Token: 0x06010742 RID: 67394 RVA: 0x003D1A74 File Offset: 0x003CFC74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_3()
			{
				Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "<>c__DisplayClass29_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_3>.NativeClassPtr);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_3.NativeFieldInfoPtr_thisHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_3>.NativeClassPtr, "thisHandle");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_3>.NativeClassPtr, 100685008);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_3.NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_3>.NativeClassPtr, 100685009);
			}

			// Token: 0x06010743 RID: 67395 RVA: 0x003D1ADC File Offset: 0x003CFCDC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010744 RID: 67396 RVA: 0x003D1B18 File Offset: 0x003CFD18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266910, XrefRangeEnd = 266919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_3.NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010745 RID: 67397 RVA: 0x0008F91F File Offset: 0x0008DB1F
			public __c__DisplayClass29_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055F1 RID: 22001
			// (get) Token: 0x06010746 RID: 67398 RVA: 0x003D1B4C File Offset: 0x003CFD4C
			// (set) Token: 0x06010747 RID: 67399 RVA: 0x0008F928 File Offset: 0x0008DB28
			public AsyncOperationHandle<IList<Sprite>> thisHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_3.NativeFieldInfoPtr_thisHandle);
					return new AsyncOperationHandle<IList<Sprite>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<Sprite>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_3.NativeFieldInfoPtr_thisHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<Sprite>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A6A5 RID: 42661
			private static readonly IntPtr NativeFieldInfoPtr_thisHandle;

			// Token: 0x0400A6A6 RID: 42662
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6A7 RID: 42663
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_0;
		}

		// Token: 0x02000E75 RID: 3701
		[ObfuscatedName("Common.UI.DaySceneCGDisplayerPannel+<>c__DisplayClass29_4")]
		public sealed class __c__DisplayClass29_4 : Il2CppSystem.Object
		{
			// Token: 0x06010748 RID: 67400 RVA: 0x003D1B7C File Offset: 0x003CFD7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_4()
			{
				Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "<>c__DisplayClass29_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_4>.NativeClassPtr);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_4.NativeFieldInfoPtr_thisHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_4>.NativeClassPtr, "thisHandle");
				DaySceneCGDisplayerPannel.__c__DisplayClass29_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_4>.NativeClassPtr, 100685010);
				DaySceneCGDisplayerPannel.__c__DisplayClass29_4.NativeMethodInfoPtr__OnElementEnabled_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_4>.NativeClassPtr, 100685011);
			}

			// Token: 0x06010749 RID: 67401 RVA: 0x003D1BE4 File Offset: 0x003CFDE4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass29_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601074A RID: 67402 RVA: 0x003D1C20 File Offset: 0x003CFE20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266919, XrefRangeEnd = 266928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass29_4.NativeMethodInfoPtr__OnElementEnabled_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601074B RID: 67403 RVA: 0x0008F956 File Offset: 0x0008DB56
			public __c__DisplayClass29_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055F2 RID: 22002
			// (get) Token: 0x0601074C RID: 67404 RVA: 0x003D1C54 File Offset: 0x003CFE54
			// (set) Token: 0x0601074D RID: 67405 RVA: 0x0008F95F File Offset: 0x0008DB5F
			public AsyncOperationHandle<IList<Sprite>> thisHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_4.NativeFieldInfoPtr_thisHandle);
					return new AsyncOperationHandle<IList<Sprite>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<Sprite>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass29_4.NativeFieldInfoPtr_thisHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<Sprite>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A6A8 RID: 42664
			private static readonly IntPtr NativeFieldInfoPtr_thisHandle;

			// Token: 0x0400A6A9 RID: 42665
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6AA RID: 42666
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__8_Internal_Void_0;
		}

		// Token: 0x02000E76 RID: 3702
		[ObfuscatedName("Common.UI.DaySceneCGDisplayerPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0601074E RID: 67406 RVA: 0x003D1C84 File Offset: 0x003CFE84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c>.NativeClassPtr);
				DaySceneCGDisplayerPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c>.NativeClassPtr, "<>9");
				DaySceneCGDisplayerPannel.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c>.NativeClassPtr, "<>9__29_0");
				DaySceneCGDisplayerPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c>.NativeClassPtr, 100685013);
				DaySceneCGDisplayerPannel.__c.NativeMethodInfoPtr__OnElementEnabled_b__29_0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c>.NativeClassPtr, 100685014);
			}

			// Token: 0x0601074F RID: 67407 RVA: 0x003D1D00 File Offset: 0x003CFF00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010750 RID: 67408 RVA: 0x003D1D3C File Offset: 0x003CFF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__29_0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c.NativeMethodInfoPtr__OnElementEnabled_b__29_0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010751 RID: 67409 RVA: 0x0008F98D File Offset: 0x0008DB8D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055F3 RID: 22003
			// (get) Token: 0x06010752 RID: 67410 RVA: 0x003D1D80 File Offset: 0x003CFF80
			// (set) Token: 0x06010753 RID: 67411 RVA: 0x0008F996 File Offset: 0x0008DB96
			public unsafe static DaySceneCGDisplayerPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneCGDisplayerPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCGDisplayerPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneCGDisplayerPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055F4 RID: 22004
			// (get) Token: 0x06010754 RID: 67412 RVA: 0x003D1DA8 File Offset: 0x003CFFA8
			// (set) Token: 0x06010755 RID: 67413 RVA: 0x0008F9A8 File Offset: 0x0008DBA8
			public unsafe static Action<Image> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneCGDisplayerPannel.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneCGDisplayerPannel.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6AB RID: 42667
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A6AC RID: 42668
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400A6AD RID: 42669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6AE RID: 42670
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__29_0_Internal_Void_Image_0;
		}

		// Token: 0x02000E77 RID: 3703
		[ObfuscatedName("Common.UI.DaySceneCGDisplayerPannel+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x06010756 RID: 67414 RVA: 0x003D1DD0 File Offset: 0x003CFFD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCGDisplayerPannel>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass31_0>.NativeClassPtr);
				DaySceneCGDisplayerPannel.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				DaySceneCGDisplayerPannel.__c__DisplayClass31_0.NativeFieldInfoPtr_cgData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass31_0>.NativeClassPtr, "cgData");
				DaySceneCGDisplayerPannel.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass31_0>.NativeClassPtr, 100685015);
				DaySceneCGDisplayerPannel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass31_0>.NativeClassPtr, 100685016);
			}

			// Token: 0x06010757 RID: 67415 RVA: 0x003D1E4C File Offset: 0x003D004C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerPannel.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010758 RID: 67416 RVA: 0x003D1E88 File Offset: 0x003D0088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266928, XrefRangeEnd = 266950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerPannel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010759 RID: 67417 RVA: 0x0008F9BA File Offset: 0x0008DBBA
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055F5 RID: 22005
			// (get) Token: 0x0601075A RID: 67418 RVA: 0x003D1EBC File Offset: 0x003D00BC
			// (set) Token: 0x0601075B RID: 67419 RVA: 0x0008F9C3 File Offset: 0x0008DBC3
			public unsafe DaySceneCGDisplayerPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCGDisplayerPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055F6 RID: 22006
			// (get) Token: 0x0601075C RID: 67420 RVA: 0x003D1EEC File Offset: 0x003D00EC
			// (set) Token: 0x0601075D RID: 67421 RVA: 0x0008F9E2 File Offset: 0x0008DBE2
			public ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>> cgData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass31_0.NativeFieldInfoPtr_cgData);
					return new ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerPannel.__c__DisplayClass31_0.NativeFieldInfoPtr_cgData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A6AF RID: 42671
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A6B0 RID: 42672
			private static readonly IntPtr NativeFieldInfoPtr_cgData;

			// Token: 0x0400A6B1 RID: 42673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6B2 RID: 42674
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0;
		}
	}
}
