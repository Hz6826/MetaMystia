using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace PrepNightScene.UI
{
	// Token: 0x02000040 RID: 64
	public class IzakayaPresetPannel : UISubPanel<IzakayaConfigSubPannel>
	{
		// Token: 0x0600073C RID: 1852 RVA: 0x000B4F40 File Offset: 0x000B3140
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaPresetPannel()
		{
			Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrepNightScene.UI", "IzakayaPresetPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr);
			IzakayaPresetPannel.NativeFieldInfoPtr_Scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "Scroller");
			IzakayaPresetPannel.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "Content");
			IzakayaPresetPannel.NativeFieldInfoPtr_RecipeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "RecipeField");
			IzakayaPresetPannel.NativeFieldInfoPtr_BeverageField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "BeverageField");
			IzakayaPresetPannel.NativeFieldInfoPtr_CookerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "CookerField");
			IzakayaPresetPannel.NativeFieldInfoPtr_ListObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "ListObjectParent");
			IzakayaPresetPannel.NativeFieldInfoPtr_ObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "ObjectParent");
			IzakayaPresetPannel.NativeFieldInfoPtr_ObjectStackParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "ObjectStackParent");
			IzakayaPresetPannel.NativeFieldInfoPtr_IzakayaLevel1Btn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "IzakayaLevel1Btn");
			IzakayaPresetPannel.NativeFieldInfoPtr_IzakayaLevel2Btn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "IzakayaLevel2Btn");
			IzakayaPresetPannel.NativeFieldInfoPtr_IzakayaLevel3Btn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "IzakayaLevel3Btn");
			IzakayaPresetPannel.NativeFieldInfoPtr_SubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "SubPannel");
			IzakayaPresetPannel.NativeFieldInfoPtr_m_AllBeverageInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "m_AllBeverageInstances");
			IzakayaPresetPannel.NativeFieldInfoPtr_m_AllCookerInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "m_AllCookerInstances");
			IzakayaPresetPannel.NativeFieldInfoPtr_m_AllRecipeInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "m_AllRecipeInstances");
			IzakayaPresetPannel.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "m_Data");
			IzakayaPresetPannel.NativeFieldInfoPtr_m_AllToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "m_AllToggles");
			IzakayaPresetPannel.NativeFieldInfoPtr_m_CurrentPreviewingIzakayaLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "m_CurrentPreviewingIzakayaLevel");
			IzakayaPresetPannel.NativeFieldInfoPtr_m_GridControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "m_GridControl");
			IzakayaPresetPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664447);
			IzakayaPresetPannel.NativeMethodInfoPtr_OnMove_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664448);
			IzakayaPresetPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664449);
			IzakayaPresetPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664450);
			IzakayaPresetPannel.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664451);
			IzakayaPresetPannel.NativeMethodInfoPtr_OpenSubMenu_Private_Void_Int32_HistoryIzakayaMenuSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664452);
			IzakayaPresetPannel.NativeMethodInfoPtr_OnSubMenuExit_Private_Void_Int32_HistoryIzakayaMenuSelection_PannelCloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664453);
			IzakayaPresetPannel.NativeMethodInfoPtr_AddNewPreset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664454);
			IzakayaPresetPannel.NativeMethodInfoPtr_CleanDetail_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664455);
			IzakayaPresetPannel.NativeMethodInfoPtr_PrintDetail_Private_Void_HistoryIzakayaMenuSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664456);
			IzakayaPresetPannel.NativeMethodInfoPtr_ProcessDetail_Private_Void_UIElementCluster_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664457);
			IzakayaPresetPannel.NativeMethodInfoPtr_ProcessDetail_Private_Void_UIElementCluster_ValueTuple_2_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664458);
			IzakayaPresetPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664459);
			IzakayaPresetPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664460);
			IzakayaPresetPannel.NativeMethodInfoPtr__OnPanelInitialize_b__19_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664461);
			IzakayaPresetPannel.NativeMethodInfoPtr__OnPanelInitialize_b__19_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664462);
			IzakayaPresetPannel.NativeMethodInfoPtr__OnPanelInitialize_b__19_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664463);
			IzakayaPresetPannel.NativeMethodInfoPtr_Method_Private_Void_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664464);
			IzakayaPresetPannel.NativeMethodInfoPtr__OnPanelInitialize_b__19_5_Private_Void_Nullable_1_HistoryIzakayaMenuSelection_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664465);
			IzakayaPresetPannel.NativeMethodInfoPtr__OnPanelInitialize_b__19_6_Private_Void_Nullable_1_HistoryIzakayaMenuSelection_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, 100664466);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000B527C File Offset: 0x000B347C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30013, XrefRangeEnd = 30102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaPresetPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000B52B8 File Offset: 0x000B34B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30102, XrefRangeEnd = 30110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMove(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr_OnMove_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000B5300 File Offset: 0x000B3500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30110, XrefRangeEnd = 30121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaPresetPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000B533C File Offset: 0x000B353C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30121, XrefRangeEnd = 30126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaPresetPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000B5378 File Offset: 0x000B3578
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 30150, RefRangeEnd = 30157, XrefRangeStart = 30126, XrefRangeEnd = 30150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000B53AC File Offset: 0x000B35AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30157, XrefRangeEnd = 30178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenSubMenu(int index, PlayerSaveFile.HistoryIzakayaMenuSelection data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr_OpenSubMenu_Private_Void_Int32_HistoryIzakayaMenuSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000B5404 File Offset: 0x000B3604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30178, XrefRangeEnd = 30190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubMenuExit(int index, PlayerSaveFile.HistoryIzakayaMenuSelection data, IzakayaPresetSubPannel.PannelCloseContext closeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr_OnSubMenuExit_Private_Void_Int32_HistoryIzakayaMenuSelection_PannelCloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000B5468 File Offset: 0x000B3668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30190, XrefRangeEnd = 30244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNewPreset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr_AddNewPreset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000B549C File Offset: 0x000B369C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30250, RefRangeEnd = 30252, XrefRangeStart = 30244, XrefRangeEnd = 30250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanDetail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr_CleanDetail_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000B54D0 File Offset: 0x000B36D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30356, RefRangeEnd = 30357, XrefRangeStart = 30252, XrefRangeEnd = 30356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintDetail(PlayerSaveFile.HistoryIzakayaMenuSelection data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr_PrintDetail_Private_Void_HistoryIzakayaMenuSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000B5518 File Offset: 0x000B3718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30357, XrefRangeEnd = 30367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDetail(UIElementCluster component, Cooker cooker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr_ProcessDetail_Private_Void_UIElementCluster_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000B556C File Offset: 0x000B376C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30367, XrefRangeEnd = 30401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDetail(UIElementCluster component, ValueTuple<Sprite, int> property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(property));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr_ProcessDetail_Private_Void_UIElementCluster_ValueTuple_2_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000B55C8 File Offset: 0x000B37C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30401, XrefRangeEnd = 30426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaPresetPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000B5604 File Offset: 0x000B3804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30426, XrefRangeEnd = 30454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaPresetPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000B5640 File Offset: 0x000B3840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30454, XrefRangeEnd = 30459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__19_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr__OnPanelInitialize_b__19_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000B5674 File Offset: 0x000B3874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30459, XrefRangeEnd = 30464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__19_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr__OnPanelInitialize_b__19_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000B56A8 File Offset: 0x000B38A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30464, XrefRangeEnd = 30469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__19_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr__OnPanelInitialize_b__19_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000B56DC File Offset: 0x000B38DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30469, XrefRangeEnd = 30474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Int32_PDM_0(int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr_Method_Private_Void_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000B571C File Offset: 0x000B391C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30474, XrefRangeEnd = 30522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__19_5(Nullable<PlayerSaveFile.HistoryIzakayaMenuSelection> currentData, UIElementCluster component, UIButtonSimple _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currentData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr__OnPanelInitialize_b__19_5_Private_Void_Nullable_1_HistoryIzakayaMenuSelection_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000B5788 File Offset: 0x000B3988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30522, XrefRangeEnd = 30551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__19_6(Nullable<PlayerSaveFile.HistoryIzakayaMenuSelection> currentData, UIElementCluster _, UIButtonSimple uiButton)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currentData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButton);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.NativeMethodInfoPtr__OnPanelInitialize_b__19_6_Private_Void_Nullable_1_HistoryIzakayaMenuSelection_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000064C7 File Offset: 0x000046C7
		public IzakayaPresetPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x000B57F4 File Offset: 0x000B39F4
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x000064D0 File Offset: 0x000046D0
		public unsafe AdpProgressIndicatorComponent Scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_Scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_Scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x000B5824 File Offset: 0x000B3A24
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x000064EF File Offset: 0x000046EF
		public unsafe GridLayoutGroup Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x000B5854 File Offset: 0x000B3A54
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x0000650E File Offset: 0x0000470E
		public unsafe RectTransform RecipeField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_RecipeField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_RecipeField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x000B5884 File Offset: 0x000B3A84
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x0000652D File Offset: 0x0000472D
		public unsafe RectTransform BeverageField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_BeverageField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_BeverageField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x000B58B4 File Offset: 0x000B3AB4
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x0000654C File Offset: 0x0000474C
		public unsafe RectTransform CookerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_CookerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_CookerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x000B58E4 File Offset: 0x000B3AE4
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x0000656B File Offset: 0x0000476B
		public unsafe GameObject ListObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_ListObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_ListObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x000B5914 File Offset: 0x000B3B14
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x0000658A File Offset: 0x0000478A
		public unsafe GameObject ObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_ObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_ObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x000B5944 File Offset: 0x000B3B44
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x000065A9 File Offset: 0x000047A9
		public unsafe GameObject ObjectStackParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_ObjectStackParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_ObjectStackParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x000B5974 File Offset: 0x000B3B74
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x000065C8 File Offset: 0x000047C8
		public unsafe UIButtonToggle IzakayaLevel1Btn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_IzakayaLevel1Btn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_IzakayaLevel1Btn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x000B59A4 File Offset: 0x000B3BA4
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x000065E7 File Offset: 0x000047E7
		public unsafe UIButtonToggle IzakayaLevel2Btn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_IzakayaLevel2Btn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_IzakayaLevel2Btn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x000B59D4 File Offset: 0x000B3BD4
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00006606 File Offset: 0x00004806
		public unsafe UIButtonToggle IzakayaLevel3Btn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_IzakayaLevel3Btn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_IzakayaLevel3Btn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x000B5A04 File Offset: 0x000B3C04
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00006625 File Offset: 0x00004825
		public unsafe IzakayaPresetSubPannel SubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_SubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaPresetSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_SubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x000B5A34 File Offset: 0x000B3C34
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00006644 File Offset: 0x00004844
		public unsafe List<GameObject> m_AllBeverageInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_AllBeverageInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_AllBeverageInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x000B5A64 File Offset: 0x000B3C64
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00006663 File Offset: 0x00004863
		public unsafe List<GameObject> m_AllCookerInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_AllCookerInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_AllCookerInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x000B5A94 File Offset: 0x000B3C94
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00006682 File Offset: 0x00004882
		public unsafe List<GameObject> m_AllRecipeInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_AllRecipeInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_AllRecipeInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x000B5AC4 File Offset: 0x000B3CC4
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x000066A1 File Offset: 0x000048A1
		public unsafe List<Nullable<PlayerSaveFile.HistoryIzakayaMenuSelection>> m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Nullable<PlayerSaveFile.HistoryIzakayaMenuSelection>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x000B5AF4 File Offset: 0x000B3CF4
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x000066C0 File Offset: 0x000048C0
		public unsafe Il2CppReferenceArray<UIButtonToggle> m_AllToggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_AllToggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIButtonToggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_AllToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x000B5B24 File Offset: 0x000B3D24
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x000066DF File Offset: 0x000048DF
		public unsafe int m_CurrentPreviewingIzakayaLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_CurrentPreviewingIzakayaLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_CurrentPreviewingIzakayaLevel)) = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x000B5B4C File Offset: 0x000B3D4C
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x000066FA File Offset: 0x000048FA
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Nullable<PlayerSaveFile.HistoryIzakayaMenuSelection>, UIElementCluster, UIButtonSimple> m_GridControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_GridControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Nullable<PlayerSaveFile.HistoryIzakayaMenuSelection>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.NativeFieldInfoPtr_m_GridControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeFieldInfoPtr_Scroller;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr_RecipeField;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr_BeverageField;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr_CookerField;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr_ListObjectParent;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr_ObjectParent;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_ObjectStackParent;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_IzakayaLevel1Btn;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeFieldInfoPtr_IzakayaLevel2Btn;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeFieldInfoPtr_IzakayaLevel3Btn;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeFieldInfoPtr_SubPannel;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeFieldInfoPtr_m_AllBeverageInstances;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeFieldInfoPtr_m_AllCookerInstances;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr_m_AllRecipeInstances;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr_m_AllToggles;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPreviewingIzakayaLevel;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeFieldInfoPtr_m_GridControl;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Private_Void_CallbackContext_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubMenu_Private_Void_Int32_HistoryIzakayaMenuSelection_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_OnSubMenuExit_Private_Void_Int32_HistoryIzakayaMenuSelection_PannelCloseContext_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_AddNewPreset_Private_Void_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_CleanDetail_Private_Void_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_PrintDetail_Private_Void_HistoryIzakayaMenuSelection_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDetail_Private_Void_UIElementCluster_Cooker_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDetail_Private_Void_UIElementCluster_ValueTuple_2_Sprite_Int32_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__19_1_Private_Void_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__19_2_Private_Void_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__19_3_Private_Void_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Int32_PDM_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__19_5_Private_Void_Nullable_1_HistoryIzakayaMenuSelection_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__19_6_Private_Void_Nullable_1_HistoryIzakayaMenuSelection_UIElementCluster_UIButtonSimple_0;

		// Token: 0x020004EE RID: 1262
		[ObfuscatedName("PrepNightScene.UI.IzakayaPresetPannel+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600827D RID: 33405 RVA: 0x0024C510 File Offset: 0x0024A710
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_0>.NativeClassPtr);
				IzakayaPresetPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_0>.NativeClassPtr, "currentIndex");
				IzakayaPresetPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_0>.NativeClassPtr, 100664467);
				IzakayaPresetPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_0>.NativeClassPtr, 100664468);
			}

			// Token: 0x0600827E RID: 33406 RVA: 0x0024C578 File Offset: 0x0024A778
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600827F RID: 33407 RVA: 0x0024C5B4 File Offset: 0x0024A7B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29964, XrefRangeEnd = 29966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__8(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c__DisplayClass19_0.NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008280 RID: 33408 RVA: 0x00046733 File Offset: 0x00044933
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BED RID: 11245
			// (get) Token: 0x06008281 RID: 33409 RVA: 0x0024C5F8 File Offset: 0x0024A7F8
			// (set) Token: 0x06008282 RID: 33410 RVA: 0x0004673C File Offset: 0x0004493C
			public unsafe int currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass19_0.NativeFieldInfoPtr_currentIndex)) = value;
				}
			}

			// Token: 0x04005579 RID: 21881
			private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

			// Token: 0x0400557A RID: 21882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400557B RID: 21883
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__8_Internal_Void_Image_0;
		}

		// Token: 0x020004EF RID: 1263
		[ObfuscatedName("PrepNightScene.UI.IzakayaPresetPannel+<>c__DisplayClass19_1")]
		public sealed class __c__DisplayClass19_1 : Il2CppSystem.Object
		{
			// Token: 0x06008283 RID: 33411 RVA: 0x0024C620 File Offset: 0x0024A820
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_1()
			{
				Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "<>c__DisplayClass19_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_1>.NativeClassPtr);
				IzakayaPresetPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_currentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_1>.NativeClassPtr, "currentData");
				IzakayaPresetPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_1>.NativeClassPtr, "currentIndex");
				IzakayaPresetPannel.__c__DisplayClass19_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_1>.NativeClassPtr, "<>4__this");
				IzakayaPresetPannel.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_1>.NativeClassPtr, 100664469);
				IzakayaPresetPannel.__c__DisplayClass19_1.NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_1>.NativeClassPtr, 100664470);
			}

			// Token: 0x06008284 RID: 33412 RVA: 0x0024C6B0 File Offset: 0x0024A8B0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass19_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008285 RID: 33413 RVA: 0x0024C6EC File Offset: 0x0024A8EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29966, XrefRangeEnd = 29990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c__DisplayClass19_1.NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008286 RID: 33414 RVA: 0x00046757 File Offset: 0x00044957
			public __c__DisplayClass19_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BEE RID: 11246
			// (get) Token: 0x06008287 RID: 33415 RVA: 0x0024C720 File Offset: 0x0024A920
			// (set) Token: 0x06008288 RID: 33416 RVA: 0x00046760 File Offset: 0x00044960
			public Nullable<PlayerSaveFile.HistoryIzakayaMenuSelection> currentData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_currentData);
					return new Nullable<PlayerSaveFile.HistoryIzakayaMenuSelection>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<PlayerSaveFile.HistoryIzakayaMenuSelection>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_currentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<PlayerSaveFile.HistoryIzakayaMenuSelection>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002BEF RID: 11247
			// (get) Token: 0x06008289 RID: 33417 RVA: 0x0024C750 File Offset: 0x0024A950
			// (set) Token: 0x0600828A RID: 33418 RVA: 0x0004678E File Offset: 0x0004498E
			public unsafe int currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass19_1.NativeFieldInfoPtr_currentIndex)) = value;
				}
			}

			// Token: 0x17002BF0 RID: 11248
			// (get) Token: 0x0600828B RID: 33419 RVA: 0x0024C778 File Offset: 0x0024A978
			// (set) Token: 0x0600828C RID: 33420 RVA: 0x000467A9 File Offset: 0x000449A9
			public unsafe IzakayaPresetPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass19_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaPresetPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass19_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400557C RID: 21884
			private static readonly IntPtr NativeFieldInfoPtr_currentData;

			// Token: 0x0400557D RID: 21885
			private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

			// Token: 0x0400557E RID: 21886
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400557F RID: 21887
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005580 RID: 21888
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_0;
		}

		// Token: 0x020004F0 RID: 1264
		[ObfuscatedName("PrepNightScene.UI.IzakayaPresetPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600828D RID: 33421 RVA: 0x0024C7A8 File Offset: 0x0024A9A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr);
				IzakayaPresetPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, "<>9");
				IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, "<>9__19_0");
				IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__19_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, "<>9__19_7");
				IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, "<>9__26_0");
				IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__26_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, "<>9__26_1");
				IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, "<>9__28_0");
				IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, "<>9__28_1");
				IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__28_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, "<>9__28_2");
				IzakayaPresetPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, 100664472);
				IzakayaPresetPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__19_0_Internal_Void_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, 100664473);
				IzakayaPresetPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__19_7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, 100664474);
				IzakayaPresetPannel.__c.NativeMethodInfoPtr__AddNewPreset_b__26_0_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, 100664475);
				IzakayaPresetPannel.__c.NativeMethodInfoPtr__AddNewPreset_b__26_1_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, 100664476);
				IzakayaPresetPannel.__c.NativeMethodInfoPtr__PrintDetail_b__28_0_Internal_ValueTuple_2_Sprite_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, 100664477);
				IzakayaPresetPannel.__c.NativeMethodInfoPtr__PrintDetail_b__28_1_Internal_ValueTuple_2_Sprite_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, 100664478);
				IzakayaPresetPannel.__c.NativeMethodInfoPtr__PrintDetail_b__28_2_Internal_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr, 100664479);
			}

			// Token: 0x0600828E RID: 33422 RVA: 0x0024C914 File Offset: 0x0024AB14
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaPresetPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600828F RID: 33423 RVA: 0x0024C950 File Offset: 0x0024AB50
			[CallerCount(0)]
			public unsafe void _OnPanelInitialize_b__19_0(UIButtonToggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__19_0_Internal_Void_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008290 RID: 33424 RVA: 0x0024C994 File Offset: 0x0024AB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__19_7(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__19_7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008291 RID: 33425 RVA: 0x0024C9D8 File Offset: 0x0024ABD8
			[CallerCount(0)]
			public unsafe int _AddNewPreset_b__26_0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c.NativeMethodInfoPtr__AddNewPreset_b__26_0_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008292 RID: 33426 RVA: 0x0024CA28 File Offset: 0x0024AC28
			[CallerCount(0)]
			public unsafe int _AddNewPreset_b__26_1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c.NativeMethodInfoPtr__AddNewPreset_b__26_1_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008293 RID: 33427 RVA: 0x0024CA78 File Offset: 0x0024AC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29990, XrefRangeEnd = 29995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Sprite, int> _PrintDetail_b__28_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c.NativeMethodInfoPtr__PrintDetail_b__28_0_Internal_ValueTuple_2_Sprite_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Sprite, int>(pointer);
			}

			// Token: 0x06008294 RID: 33428 RVA: 0x0024CABC File Offset: 0x0024ACBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29995, XrefRangeEnd = 30000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Sprite, int> _PrintDetail_b__28_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c.NativeMethodInfoPtr__PrintDetail_b__28_1_Internal_ValueTuple_2_Sprite_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Sprite, int>(pointer);
			}

			// Token: 0x06008295 RID: 33429 RVA: 0x0024CB00 File Offset: 0x0024AD00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Cooker _PrintDetail_b__28_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c.NativeMethodInfoPtr__PrintDetail_b__28_2_Internal_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr3) : null;
			}

			// Token: 0x06008296 RID: 33430 RVA: 0x000467C8 File Offset: 0x000449C8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BF1 RID: 11249
			// (get) Token: 0x06008297 RID: 33431 RVA: 0x0024CB4C File Offset: 0x0024AD4C
			// (set) Token: 0x06008298 RID: 33432 RVA: 0x000467D1 File Offset: 0x000449D1
			public unsafe static IzakayaPresetPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaPresetPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BF2 RID: 11250
			// (get) Token: 0x06008299 RID: 33433 RVA: 0x0024CB74 File Offset: 0x0024AD74
			// (set) Token: 0x0600829A RID: 33434 RVA: 0x000467E3 File Offset: 0x000449E3
			public unsafe static Action<UIButtonToggle> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIButtonToggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BF3 RID: 11251
			// (get) Token: 0x0600829B RID: 33435 RVA: 0x0024CB9C File Offset: 0x0024AD9C
			// (set) Token: 0x0600829C RID: 33436 RVA: 0x000467F5 File Offset: 0x000449F5
			public unsafe static Action<Image> __9__19_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__19_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__19_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BF4 RID: 11252
			// (get) Token: 0x0600829D RID: 33437 RVA: 0x0024CBC4 File Offset: 0x0024ADC4
			// (set) Token: 0x0600829E RID: 33438 RVA: 0x00046807 File Offset: 0x00044A07
			public unsafe static Func<Recipe, int> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BF5 RID: 11253
			// (get) Token: 0x0600829F RID: 33439 RVA: 0x0024CBEC File Offset: 0x0024ADEC
			// (set) Token: 0x060082A0 RID: 33440 RVA: 0x00046819 File Offset: 0x00044A19
			public unsafe static Func<Sellable, int> __9__26_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__26_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__26_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BF6 RID: 11254
			// (get) Token: 0x060082A1 RID: 33441 RVA: 0x0024CC14 File Offset: 0x0024AE14
			// (set) Token: 0x060082A2 RID: 33442 RVA: 0x0004682B File Offset: 0x00044A2B
			public unsafe static Func<int, ValueTuple<Sprite, int>> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, ValueTuple<Sprite, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BF7 RID: 11255
			// (get) Token: 0x060082A3 RID: 33443 RVA: 0x0024CC3C File Offset: 0x0024AE3C
			// (set) Token: 0x060082A4 RID: 33444 RVA: 0x0004683D File Offset: 0x00044A3D
			public unsafe static Func<int, ValueTuple<Sprite, int>> __9__28_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, ValueTuple<Sprite, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BF8 RID: 11256
			// (get) Token: 0x060082A5 RID: 33445 RVA: 0x0024CC64 File Offset: 0x0024AE64
			// (set) Token: 0x060082A6 RID: 33446 RVA: 0x0004684F File Offset: 0x00044A4F
			public unsafe static Func<int, Cooker> __9__28_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__28_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Cooker>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaPresetPannel.__c.NativeFieldInfoPtr___9__28_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005581 RID: 21889
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005582 RID: 21890
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04005583 RID: 21891
			private static readonly IntPtr NativeFieldInfoPtr___9__19_7;

			// Token: 0x04005584 RID: 21892
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04005585 RID: 21893
			private static readonly IntPtr NativeFieldInfoPtr___9__26_1;

			// Token: 0x04005586 RID: 21894
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x04005587 RID: 21895
			private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

			// Token: 0x04005588 RID: 21896
			private static readonly IntPtr NativeFieldInfoPtr___9__28_2;

			// Token: 0x04005589 RID: 21897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400558A RID: 21898
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__19_0_Internal_Void_UIButtonToggle_0;

			// Token: 0x0400558B RID: 21899
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__19_7_Internal_Void_Image_0;

			// Token: 0x0400558C RID: 21900
			private static readonly IntPtr NativeMethodInfoPtr__AddNewPreset_b__26_0_Internal_Int32_Recipe_0;

			// Token: 0x0400558D RID: 21901
			private static readonly IntPtr NativeMethodInfoPtr__AddNewPreset_b__26_1_Internal_Int32_Sellable_0;

			// Token: 0x0400558E RID: 21902
			private static readonly IntPtr NativeMethodInfoPtr__PrintDetail_b__28_0_Internal_ValueTuple_2_Sprite_Int32_Int32_0;

			// Token: 0x0400558F RID: 21903
			private static readonly IntPtr NativeMethodInfoPtr__PrintDetail_b__28_1_Internal_ValueTuple_2_Sprite_Int32_Int32_0;

			// Token: 0x04005590 RID: 21904
			private static readonly IntPtr NativeMethodInfoPtr__PrintDetail_b__28_2_Internal_Cooker_Int32_0;
		}

		// Token: 0x020004F1 RID: 1265
		[ObfuscatedName("PrepNightScene.UI.IzakayaPresetPannel+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x060082A7 RID: 33447 RVA: 0x0024CC8C File Offset: 0x0024AE8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass24_0>.NativeClassPtr);
				IzakayaPresetPannel.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				IzakayaPresetPannel.__c__DisplayClass24_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass24_0>.NativeClassPtr, "index");
				IzakayaPresetPannel.__c__DisplayClass24_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass24_0>.NativeClassPtr, "data");
				IzakayaPresetPannel.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass24_0>.NativeClassPtr, 100664480);
				IzakayaPresetPannel.__c__DisplayClass24_0.NativeMethodInfoPtr__OpenSubMenu_b__0_Internal_Void_IzakayaPresetSubPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass24_0>.NativeClassPtr, 100664481);
			}

			// Token: 0x060082A8 RID: 33448 RVA: 0x0024CD1C File Offset: 0x0024AF1C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060082A9 RID: 33449 RVA: 0x0024CD58 File Offset: 0x0024AF58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30000, XrefRangeEnd = 30012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenSubMenu_b__0(IzakayaPresetSubPannel pannelInstance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pannelInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c__DisplayClass24_0.NativeMethodInfoPtr__OpenSubMenu_b__0_Internal_Void_IzakayaPresetSubPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060082AA RID: 33450 RVA: 0x00046861 File Offset: 0x00044A61
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BF9 RID: 11257
			// (get) Token: 0x060082AB RID: 33451 RVA: 0x0024CD9C File Offset: 0x0024AF9C
			// (set) Token: 0x060082AC RID: 33452 RVA: 0x0004686A File Offset: 0x00044A6A
			public unsafe IzakayaPresetPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaPresetPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BFA RID: 11258
			// (get) Token: 0x060082AD RID: 33453 RVA: 0x0024CDCC File Offset: 0x0024AFCC
			// (set) Token: 0x060082AE RID: 33454 RVA: 0x00046889 File Offset: 0x00044A89
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass24_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass24_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17002BFB RID: 11259
			// (get) Token: 0x060082AF RID: 33455 RVA: 0x0024CDF4 File Offset: 0x0024AFF4
			// (set) Token: 0x060082B0 RID: 33456 RVA: 0x000468A4 File Offset: 0x00044AA4
			public PlayerSaveFile.HistoryIzakayaMenuSelection data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass24_0.NativeFieldInfoPtr_data);
					return new PlayerSaveFile.HistoryIzakayaMenuSelection(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass24_0.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005591 RID: 21905
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005592 RID: 21906
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04005593 RID: 21907
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04005594 RID: 21908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005595 RID: 21909
			private static readonly IntPtr NativeMethodInfoPtr__OpenSubMenu_b__0_Internal_Void_IzakayaPresetSubPannel_0;
		}

		// Token: 0x020004F2 RID: 1266
		[ObfuscatedName("PrepNightScene.UI.IzakayaPresetPannel+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x060082B1 RID: 33457 RVA: 0x0024CE24 File Offset: 0x0024B024
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaPresetPannel>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass30_0>.NativeClassPtr);
				IzakayaPresetPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass30_0>.NativeClassPtr, "property");
				IzakayaPresetPannel.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass30_0>.NativeClassPtr, 100664482);
				IzakayaPresetPannel.__c__DisplayClass30_0.NativeMethodInfoPtr__ProcessDetail_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass30_0>.NativeClassPtr, 100664483);
			}

			// Token: 0x060082B2 RID: 33458 RVA: 0x0024CE8C File Offset: 0x0024B08C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaPresetPannel.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060082B3 RID: 33459 RVA: 0x0024CEC8 File Offset: 0x0024B0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30012, XrefRangeEnd = 30013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessDetail_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetPannel.__c__DisplayClass30_0.NativeMethodInfoPtr__ProcessDetail_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060082B4 RID: 33460 RVA: 0x000468D2 File Offset: 0x00044AD2
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BFC RID: 11260
			// (get) Token: 0x060082B5 RID: 33461 RVA: 0x0024CF0C File Offset: 0x0024B10C
			// (set) Token: 0x060082B6 RID: 33462 RVA: 0x000468DB File Offset: 0x00044ADB
			public ValueTuple<Sprite, int> property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_property);
					return new ValueTuple<Sprite, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<Sprite, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_property), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<Sprite, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005596 RID: 21910
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04005597 RID: 21911
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005598 RID: 21912
			private static readonly IntPtr NativeMethodInfoPtr__ProcessDetail_b__0_Internal_Void_Image_0;
		}
	}
}
