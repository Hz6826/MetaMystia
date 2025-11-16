using System;
using Common.UI;
using Common.UI.GlobalMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AssetHandleUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000C9 RID: 201
	public class DaySceneSustainedPannel : ExtendedSustainedPannel
	{
		// Token: 0x060017AF RID: 6063 RVA: 0x000ED94C File Offset: 0x000EBB4C
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneSustainedPannel()
		{
			Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneSustainedPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr);
			DaySceneSustainedPannel.NativeFieldInfoPtr_MapBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "MapBtn");
			DaySceneSustainedPannel.NativeFieldInfoPtr_DaySceneFastTravelPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "DaySceneFastTravelPannel");
			DaySceneSustainedPannel.NativeFieldInfoPtr_disableMapEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "disableMapEvents");
			DaySceneSustainedPannel.NativeFieldInfoPtr_tipsPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "tipsPannel");
			DaySceneSustainedPannel.NativeFieldInfoPtr_m_MapBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "m_MapBlocker");
			DaySceneSustainedPannel.NativeFieldInfoPtr_m_LoadedFastTravelPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "m_LoadedFastTravelPanel");
			DaySceneSustainedPannel.NativeFieldInfoPtr_m_DaySceneFastTravelPanelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "m_DaySceneFastTravelPanelInstance");
			DaySceneSustainedPannel.NativeFieldInfoPtr_m_YukariToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "m_YukariToggle");
			DaySceneSustainedPannel.NativeFieldInfoPtr_OnPanelWillOpenCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "OnPanelWillOpenCallback");
			DaySceneSustainedPannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667570);
			DaySceneSustainedPannel.NativeMethodInfoPtr_get_HoldActionMap_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667571);
			DaySceneSustainedPannel.NativeMethodInfoPtr_get_HoldActionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667572);
			DaySceneSustainedPannel.NativeMethodInfoPtr_add_OnPanelWillOpenCallback_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667573);
			DaySceneSustainedPannel.NativeMethodInfoPtr_remove_OnPanelWillOpenCallback_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667574);
			DaySceneSustainedPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667575);
			DaySceneSustainedPannel.NativeMethodInfoPtr_OnPrePanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667576);
			DaySceneSustainedPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667577);
			DaySceneSustainedPannel.NativeMethodInfoPtr_OnPanelWillOpen_Protected_Virtual_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667578);
			DaySceneSustainedPannel.NativeMethodInfoPtr_OnPanelClosed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667579);
			DaySceneSustainedPannel.NativeMethodInfoPtr_UpdateMapBtnVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667580);
			DaySceneSustainedPannel.NativeMethodInfoPtr_UpdateFastForwardBtn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667581);
			DaySceneSustainedPannel.NativeMethodInfoPtr_CheckCanOpen_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667582);
			DaySceneSustainedPannel.NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667583);
			DaySceneSustainedPannel.NativeMethodInfoPtr_LoadPanelAsync_Public_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667584);
			DaySceneSustainedPannel.NativeMethodInfoPtr_ReleasePanel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667585);
			DaySceneSustainedPannel.NativeMethodInfoPtr_OpenFastTravelPanelParameterless_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667586);
			DaySceneSustainedPannel.NativeMethodInfoPtr_OpenFastTravelPannel_Public_Void_Boolean_Predicate_1_IGuideMapSpot_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667587);
			DaySceneSustainedPannel.NativeMethodInfoPtr_OnFastForwardSubmit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667588);
			DaySceneSustainedPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667589);
			DaySceneSustainedPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667590);
			DaySceneSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__19_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, 100667591);
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x000EDBE8 File Offset: 0x000EBDE8
		public unsafe override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x000EDC30 File Offset: 0x000EBE30
		public unsafe override string HoldActionMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66297, XrefRangeEnd = 66299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.NativeMethodInfoPtr_get_HoldActionMap_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x000EDC74 File Offset: 0x000EBE74
		public unsafe override string HoldActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66299, XrefRangeEnd = 66300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.NativeMethodInfoPtr_get_HoldActionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x000EDCB8 File Offset: 0x000EBEB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66304, RefRangeEnd = 66305, XrefRangeStart = 66300, XrefRangeEnd = 66304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnPanelWillOpenCallback(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr_add_OnPanelWillOpenCallback_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000EDCFC File Offset: 0x000EBEFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66309, RefRangeEnd = 66310, XrefRangeStart = 66305, XrefRangeEnd = 66309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnPanelWillOpenCallback(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr_remove_OnPanelWillOpenCallback_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000EDD40 File Offset: 0x000EBF40
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000EDD7C File Offset: 0x000EBF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66310, XrefRangeEnd = 66328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPrePanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.NativeMethodInfoPtr_OnPrePanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000EDDB8 File Offset: 0x000EBFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66328, XrefRangeEnd = 66365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPannelPostInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x000EDDF4 File Offset: 0x000EBFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66365, XrefRangeEnd = 66374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelWillOpen<T>(T panelParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = panelParent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref panelParent;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.MethodInfoStoreGeneric_OnPanelWillOpen_Protected_Virtual_Void_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000EDE78 File Offset: 0x000EC078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66374, XrefRangeEnd = 66377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.NativeMethodInfoPtr_OnPanelClosed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000EDEB4 File Offset: 0x000EC0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66377, XrefRangeEnd = 66381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMapBtnVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr_UpdateMapBtnVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000EDEE8 File Offset: 0x000EC0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66381, XrefRangeEnd = 66383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void UpdateFastForwardBtn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr_UpdateFastForwardBtn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000EDF1C File Offset: 0x000EC11C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 66388, RefRangeEnd = 66393, XrefRangeStart = 66383, XrefRangeEnd = 66388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr_CheckCanOpen_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x000EDF58 File Offset: 0x000EC158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66393, XrefRangeEnd = 66402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPannelPostOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x000EDF94 File Offset: 0x000EC194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66419, RefRangeEnd = 66421, XrefRangeStart = 66402, XrefRangeEnd = 66419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask LoadPanelAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr_LoadPanelAsync_Public_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x000EDFCC File Offset: 0x000EC1CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66425, RefRangeEnd = 66426, XrefRangeStart = 66421, XrefRangeEnd = 66425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr_ReleasePanel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000EE000 File Offset: 0x000EC200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66436, RefRangeEnd = 66438, XrefRangeStart = 66426, XrefRangeEnd = 66436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenFastTravelPanelParameterless()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr_OpenFastTravelPanelParameterless_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000EE034 File Offset: 0x000EC234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66483, RefRangeEnd = 66485, XrefRangeStart = 66438, XrefRangeEnd = 66483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenFastTravelPannel(bool isYukari, Predicate<IGuideMapSpot> getFirstToSelectNodeCallback = null, Action onPannelCloseCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isYukari;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getFirstToSelectNodeCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr_OpenFastTravelPannel_Public_Void_Boolean_Predicate_1_IGuideMapSpot_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000EE098 File Offset: 0x000EC298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66485, XrefRangeEnd = 66492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFastForwardSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.NativeMethodInfoPtr_OnFastForwardSubmit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000EE0D4 File Offset: 0x000EC2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66492, XrefRangeEnd = 66501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSustainedPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x000EE110 File Offset: 0x000EC310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66501, XrefRangeEnd = 66502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneSustainedPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x000EE14C File Offset: 0x000EC34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66502, XrefRangeEnd = 66509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPannelPostInitialize_b__19_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__19_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x0000EC7D File Offset: 0x0000CE7D
		public DaySceneSustainedPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x000EE180 File Offset: 0x000EC380
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x0000EC86 File Offset: 0x0000CE86
		public unsafe UIButtonSimple MapBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_MapBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_MapBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x000EE1B0 File Offset: 0x000EC3B0
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x0000ECA5 File Offset: 0x0000CEA5
		public unsafe AssetReferenceT<GameObject> DaySceneFastTravelPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_DaySceneFastTravelPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_DaySceneFastTravelPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x000EE1E0 File Offset: 0x000EC3E0
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x0000ECC4 File Offset: 0x0000CEC4
		public unsafe Il2CppStringArray disableMapEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_disableMapEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_disableMapEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x000EE210 File Offset: 0x000EC410
		// (set) Token: 0x060017CE RID: 6094 RVA: 0x0000ECE3 File Offset: 0x0000CEE3
		public unsafe Tips tipsPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_tipsPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tips>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_tipsPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x000EE240 File Offset: 0x000EC440
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x0000ED02 File Offset: 0x0000CF02
		public unsafe Image m_MapBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_m_MapBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_m_MapBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x000EE270 File Offset: 0x000EC470
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x0000ED21 File Offset: 0x0000CF21
		public unsafe IGameObjectAssetHandle<FastTravelPanel_New> m_LoadedFastTravelPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_m_LoadedFastTravelPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<FastTravelPanel_New>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_m_LoadedFastTravelPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x000EE2A0 File Offset: 0x000EC4A0
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0000ED40 File Offset: 0x0000CF40
		public unsafe FastTravelPanel_New m_DaySceneFastTravelPanelInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_m_DaySceneFastTravelPanelInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastTravelPanel_New>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_m_DaySceneFastTravelPanelInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x000EE2D0 File Offset: 0x000EC4D0
		// (set) Token: 0x060017D6 RID: 6102 RVA: 0x0000ED5F File Offset: 0x0000CF5F
		public Nullable<bool> m_YukariToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_m_YukariToggle);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_m_YukariToggle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x000EE300 File Offset: 0x000EC500
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x0000ED8D File Offset: 0x0000CF8D
		public unsafe Action OnPanelWillOpenCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_OnPanelWillOpenCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.NativeFieldInfoPtr_OnPanelWillOpenCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeFieldInfoPtr_MapBtn;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneFastTravelPannel;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeFieldInfoPtr_disableMapEvents;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeFieldInfoPtr_tipsPannel;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr_m_MapBlocker;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedFastTravelPanel;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeFieldInfoPtr_m_DaySceneFastTravelPanelInstance;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeFieldInfoPtr_m_YukariToggle;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeFieldInfoPtr_OnPanelWillOpenCallback;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_get_HoldActionMap_Public_Virtual_get_String_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_get_HoldActionName_Public_Virtual_get_String_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPanelWillOpenCallback_Public_add_Void_Action_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPanelWillOpenCallback_Public_rem_Void_Action_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_OnPrePanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelWillOpen_Protected_Virtual_Void_T_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClosed_Protected_Virtual_Void_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMapBtnVisual_Private_Void_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFastForwardBtn_Private_Void_0;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanOpen_Private_Boolean_0;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr_LoadPanelAsync_Public_UniTask_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePanel_Public_Void_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_OpenFastTravelPanelParameterless_Public_Void_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_OpenFastTravelPannel_Public_Void_Boolean_Predicate_1_IGuideMapSpot_Action_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_OnFastForwardSubmit_Public_Virtual_Void_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__19_0_Private_Void_0;

		// Token: 0x02000667 RID: 1639
		[ObfuscatedName("DayScene.UI.DaySceneSustainedPannel+<LoadPanelAsync>d__26")]
		public sealed class _LoadPanelAsync_d__26 : ValueType
		{
			// Token: 0x060094E3 RID: 38115 RVA: 0x0028199C File Offset: 0x0027FB9C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadPanelAsync_d__26()
			{
				Il2CppClassPointerStore<DaySceneSustainedPannel._LoadPanelAsync_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "<LoadPanelAsync>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneSustainedPannel._LoadPanelAsync_d__26>.NativeClassPtr);
				DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel._LoadPanelAsync_d__26>.NativeClassPtr, "<>1__state");
				DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel._LoadPanelAsync_d__26>.NativeClassPtr, "<>t__builder");
				DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel._LoadPanelAsync_d__26>.NativeClassPtr, "<>4__this");
				DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel._LoadPanelAsync_d__26>.NativeClassPtr, "<>u__1");
				DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel._LoadPanelAsync_d__26>.NativeClassPtr, 100667592);
				DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel._LoadPanelAsync_d__26>.NativeClassPtr, 100667593);
			}

			// Token: 0x060094E4 RID: 38116 RVA: 0x00281A40 File Offset: 0x0027FC40
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 66286, RefRangeEnd = 66289, XrefRangeStart = 66241, XrefRangeEnd = 66286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094E5 RID: 38117 RVA: 0x00281A78 File Offset: 0x0027FC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094E6 RID: 38118 RVA: 0x000507D8 File Offset: 0x0004E9D8
			public _LoadPanelAsync_d__26(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060094E7 RID: 38119 RVA: 0x000507E1 File Offset: 0x0004E9E1
			public _LoadPanelAsync_d__26() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneSustainedPannel._LoadPanelAsync_d__26>.NativeClassPtr))
			{
			}

			// Token: 0x17003178 RID: 12664
			// (get) Token: 0x060094E8 RID: 38120 RVA: 0x00281AC0 File Offset: 0x0027FCC0
			// (set) Token: 0x060094E9 RID: 38121 RVA: 0x000507F3 File Offset: 0x0004E9F3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003179 RID: 12665
			// (get) Token: 0x060094EA RID: 38122 RVA: 0x00281AE8 File Offset: 0x0027FCE8
			// (set) Token: 0x060094EB RID: 38123 RVA: 0x0005080E File Offset: 0x0004EA0E
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700317A RID: 12666
			// (get) Token: 0x060094EC RID: 38124 RVA: 0x00281B18 File Offset: 0x0027FD18
			// (set) Token: 0x060094ED RID: 38125 RVA: 0x0005083C File Offset: 0x0004EA3C
			public unsafe DaySceneSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700317B RID: 12667
			// (get) Token: 0x060094EE RID: 38126 RVA: 0x00281B48 File Offset: 0x0027FD48
			// (set) Token: 0x060094EF RID: 38127 RVA: 0x0005085B File Offset: 0x0004EA5B
			public UniTask<IGameObjectAssetHandle<FastTravelPanel_New>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___u__1);
					return new UniTask<IGameObjectAssetHandle<FastTravelPanel_New>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<FastTravelPanel_New>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel._LoadPanelAsync_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<FastTravelPanel_New>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006092 RID: 24722
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006093 RID: 24723
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006094 RID: 24724
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006095 RID: 24725
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006096 RID: 24726
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006097 RID: 24727
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000668 RID: 1640
		[ObfuscatedName("DayScene.UI.DaySceneSustainedPannel+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x060094F0 RID: 38128 RVA: 0x00281B78 File Offset: 0x0027FD78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<DaySceneSustainedPannel.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneSustainedPannel.__c__DisplayClass29_0>.NativeClassPtr);
				DaySceneSustainedPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_onPannelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel.__c__DisplayClass29_0>.NativeClassPtr, "onPannelCloseCallback");
				DaySceneSustainedPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel.__c__DisplayClass29_0>.NativeClassPtr, 100667594);
				DaySceneSustainedPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__OpenFastTravelPannel_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel.__c__DisplayClass29_0>.NativeClassPtr, 100667595);
			}

			// Token: 0x060094F1 RID: 38129 RVA: 0x00281BE0 File Offset: 0x0027FDE0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneSustainedPannel.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094F2 RID: 38130 RVA: 0x00281C1C File Offset: 0x0027FE1C
			[CallerCount(0)]
			public unsafe void _OpenFastTravelPannel_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__OpenFastTravelPannel_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094F3 RID: 38131 RVA: 0x00050889 File Offset: 0x0004EA89
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700317C RID: 12668
			// (get) Token: 0x060094F4 RID: 38132 RVA: 0x00281C50 File Offset: 0x0027FE50
			// (set) Token: 0x060094F5 RID: 38133 RVA: 0x00050892 File Offset: 0x0004EA92
			public unsafe Action onPannelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_onPannelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSustainedPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_onPannelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006098 RID: 24728
			private static readonly IntPtr NativeFieldInfoPtr_onPannelCloseCallback;

			// Token: 0x04006099 RID: 24729
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400609A RID: 24730
			private static readonly IntPtr NativeMethodInfoPtr__OpenFastTravelPannel_b__1_Internal_Void_0;
		}

		// Token: 0x02000669 RID: 1641
		[ObfuscatedName("DayScene.UI.DaySceneSustainedPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060094F6 RID: 38134 RVA: 0x00281C80 File Offset: 0x0027FE80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneSustainedPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneSustainedPannel.__c>.NativeClassPtr);
				DaySceneSustainedPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel.__c>.NativeClassPtr, "<>9");
				DaySceneSustainedPannel.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSustainedPannel.__c>.NativeClassPtr, "<>9__29_0");
				DaySceneSustainedPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel.__c>.NativeClassPtr, 100667597);
				DaySceneSustainedPannel.__c.NativeMethodInfoPtr__OpenFastTravelPannel_b__29_0_Internal_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSustainedPannel.__c>.NativeClassPtr, 100667598);
			}

			// Token: 0x060094F7 RID: 38135 RVA: 0x00281CFC File Offset: 0x0027FEFC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneSustainedPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094F8 RID: 38136 RVA: 0x00281D38 File Offset: 0x0027FF38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66289, XrefRangeEnd = 66297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenFastTravelPannel_b__29_0(IGuideMapSpot guideMapSpot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSustainedPannel.__c.NativeMethodInfoPtr__OpenFastTravelPannel_b__29_0_Internal_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060094F9 RID: 38137 RVA: 0x000508B1 File Offset: 0x0004EAB1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700317D RID: 12669
			// (get) Token: 0x060094FA RID: 38138 RVA: 0x00281D88 File Offset: 0x0027FF88
			// (set) Token: 0x060094FB RID: 38139 RVA: 0x000508BA File Offset: 0x0004EABA
			public unsafe static DaySceneSustainedPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneSustainedPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneSustainedPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneSustainedPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700317E RID: 12670
			// (get) Token: 0x060094FC RID: 38140 RVA: 0x00281DB0 File Offset: 0x0027FFB0
			// (set) Token: 0x060094FD RID: 38141 RVA: 0x000508CC File Offset: 0x0004EACC
			public unsafe static Predicate<IGuideMapSpot> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneSustainedPannel.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<IGuideMapSpot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneSustainedPannel.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400609B RID: 24731
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400609C RID: 24732
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400609D RID: 24733
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400609E RID: 24734
			private static readonly IntPtr NativeMethodInfoPtr__OpenFastTravelPannel_b__29_0_Internal_Boolean_IGuideMapSpot_0;
		}

		// Token: 0x0200066A RID: 1642
		private sealed class MethodInfoStoreGeneric_OnPanelWillOpen_Protected_Virtual_Void_T_0<T>
		{
			// Token: 0x0400609F RID: 24735
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DaySceneSustainedPannel.NativeMethodInfoPtr_OnPanelWillOpen_Protected_Virtual_Void_T_0, Il2CppClassPointerStore<DaySceneSustainedPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
