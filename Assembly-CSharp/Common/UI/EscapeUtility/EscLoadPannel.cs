using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection.Async;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using DEYU.Utils;
using GameData.RunTime.Common;
using GameData.Utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.EscapeUtility
{
	// Token: 0x020003BF RID: 959
	public class EscLoadPannel : AsyncUISubPanel<EscMainPannel>
	{
		// Token: 0x0600726C RID: 29292 RVA: 0x0021C11C File Offset: 0x0021A31C
		// Note: this type is marked as 'beforefieldinit'.
		static EscLoadPannel()
		{
			Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.EscapeUtility", "EscLoadPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr);
			EscLoadPannel.NativeFieldInfoPtr_m_FirstOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "m_FirstOpen");
			EscLoadPannel.NativeFieldInfoPtr_SaveParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "SaveParent");
			EscLoadPannel.NativeFieldInfoPtr_ElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "ElementField");
			EscLoadPannel.NativeFieldInfoPtr_Scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "Scroller");
			EscLoadPannel.NativeFieldInfoPtr_NullIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "NullIndicator");
			EscLoadPannel.NativeFieldInfoPtr_SubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "SubPannel");
			EscLoadPannel.NativeFieldInfoPtr_RefreshButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "RefreshButton");
			EscLoadPannel.NativeFieldInfoPtr_m_MessagePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "m_MessagePanel");
			EscLoadPannel.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "m_Data");
			EscLoadPannel.NativeFieldInfoPtr_m_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "m_Group");
			EscLoadPannel.NativeFieldInfoPtr_m_ShouldInstantClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "m_ShouldInstantClose");
			EscLoadPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686864);
			EscLoadPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686865);
			EscLoadPannel.NativeMethodInfoPtr_OnSecondaryInput_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686866);
			EscLoadPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686867);
			EscLoadPannel.NativeMethodInfoPtr_AlertSaveFileHasChanged_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686868);
			EscLoadPannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686869);
			EscLoadPannel.NativeMethodInfoPtr_RefreshPanel_Private_UniTask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686870);
			EscLoadPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686871);
			EscLoadPannel.NativeMethodInfoPtr_RefreshSaveElementsAsync_Private_UniTask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686872);
			EscLoadPannel.NativeMethodInfoPtr_InitializeSaveElementVisual_Public_Static_Void_UIElementCluster_KeyValuePair_2_Int32_LoadedSaveDataInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686873);
			EscLoadPannel.NativeMethodInfoPtr_OnElementPressed_Private_UniTaskVoid_KeyValuePair_2_Int32_PlayerSaveFile_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686874);
			EscLoadPannel.NativeMethodInfoPtr_CannotLoadAsync_Private_UniTask_IReadOnlyList_1_String_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686875);
			EscLoadPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686876);
			EscLoadPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686877);
			EscLoadPannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_1_Private_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686878);
			EscLoadPannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, 100686879);
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x0600726D RID: 29293 RVA: 0x0021C368 File Offset: 0x0021A568
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600726E RID: 29294 RVA: 0x0021C3B0 File Offset: 0x0021A5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286017, XrefRangeEnd = 286078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x0021C3EC File Offset: 0x0021A5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286078, XrefRangeEnd = 286082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSecondaryInput(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.NativeMethodInfoPtr_OnSecondaryInput_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x0021C434 File Offset: 0x0021A634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286082, XrefRangeEnd = 286083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007271 RID: 29297 RVA: 0x0021C47C File Offset: 0x0021A67C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286085, RefRangeEnd = 286086, XrefRangeStart = 286083, XrefRangeEnd = 286085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AlertSaveFileHasChanged()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.NativeMethodInfoPtr_AlertSaveFileHasChanged_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007272 RID: 29298 RVA: 0x0021C4A4 File Offset: 0x0021A6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286086, XrefRangeEnd = 286091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UniTaskVoid OnPanelOpenAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007273 RID: 29299 RVA: 0x0021C4EC File Offset: 0x0021A6EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286097, RefRangeEnd = 286099, XrefRangeStart = 286091, XrefRangeEnd = 286097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask RefreshPanel(bool clearInternalCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clearInternalCache;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.NativeMethodInfoPtr_RefreshPanel_Private_UniTask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06007274 RID: 29300 RVA: 0x0021C530 File Offset: 0x0021A730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286099, XrefRangeEnd = 286104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x0021C56C File Offset: 0x0021A76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286104, XrefRangeEnd = 286110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask RefreshSaveElementsAsync(bool clearInternalCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clearInternalCache;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.NativeMethodInfoPtr_RefreshSaveElementsAsync_Private_UniTask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x0021C5B0 File Offset: 0x0021A7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286110, XrefRangeEnd = 286250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeSaveElementVisual(UIElementCluster uiElement, KeyValuePair<int, LoadedSaveDataInfo> data, bool isTestFlight)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElement);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTestFlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.NativeMethodInfoPtr_InitializeSaveElementVisual_Public_Static_Void_UIElementCluster_KeyValuePair_2_Int32_LoadedSaveDataInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x0021C60C File Offset: 0x0021A80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286250, XrefRangeEnd = 286257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OnElementPressed(KeyValuePair<int, PlayerSaveFile> operatingSave, Vector3 elementPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operatingSave));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.NativeMethodInfoPtr_OnElementPressed_Private_UniTaskVoid_KeyValuePair_2_Int32_PlayerSaveFile_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x0021C66C File Offset: 0x0021A86C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286265, RefRangeEnd = 286266, XrefRangeStart = 286257, XrefRangeEnd = 286265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask CannotLoadAsync(IReadOnlyList<string> activeArray, IReadOnlyList<string> inSaveArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeArray);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inSaveArray);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.NativeMethodInfoPtr_CannotLoadAsync_Private_UniTask_IReadOnlyList_1_String_IReadOnlyList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x0021C6C8 File Offset: 0x0021A8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286266, XrefRangeEnd = 286278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x0021C704 File Offset: 0x0021A904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286278, XrefRangeEnd = 286850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EscLoadPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x0021C740 File Offset: 0x0021A940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286850, XrefRangeEnd = 286872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__13_1(KeyValuePair<int, LoadedSaveDataInfo> value, UIElementCluster _, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_1_Private_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x0021C7AC File Offset: 0x0021A9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286872, XrefRangeEnd = 286880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__13_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x0003DE64 File Offset: 0x0003C064
		public EscLoadPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x0600727E RID: 29310 RVA: 0x0021C7E0 File Offset: 0x0021A9E0
		// (set) Token: 0x0600727F RID: 29311 RVA: 0x0003DE6D File Offset: 0x0003C06D
		public unsafe static bool m_FirstOpen
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(EscLoadPannel.NativeFieldInfoPtr_m_FirstOpen, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EscLoadPannel.NativeFieldInfoPtr_m_FirstOpen, (void*)(&value));
			}
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x06007280 RID: 29312 RVA: 0x0021C7FC File Offset: 0x0021A9FC
		// (set) Token: 0x06007281 RID: 29313 RVA: 0x0003DE7B File Offset: 0x0003C07B
		public unsafe GameObject SaveParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_SaveParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_SaveParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x06007282 RID: 29314 RVA: 0x0021C82C File Offset: 0x0021AA2C
		// (set) Token: 0x06007283 RID: 29315 RVA: 0x0003DE9A File Offset: 0x0003C09A
		public unsafe GridLayoutGroup ElementField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_ElementField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_ElementField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x06007284 RID: 29316 RVA: 0x0021C85C File Offset: 0x0021AA5C
		// (set) Token: 0x06007285 RID: 29317 RVA: 0x0003DEB9 File Offset: 0x0003C0B9
		public unsafe AdpProgressIndicatorComponent Scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_Scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_Scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x06007286 RID: 29318 RVA: 0x0021C88C File Offset: 0x0021AA8C
		// (set) Token: 0x06007287 RID: 29319 RVA: 0x0003DED8 File Offset: 0x0003C0D8
		public unsafe GameObject NullIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_NullIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_NullIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x06007288 RID: 29320 RVA: 0x0021C8BC File Offset: 0x0021AABC
		// (set) Token: 0x06007289 RID: 29321 RVA: 0x0003DEF7 File Offset: 0x0003C0F7
		public unsafe EscLoadPannelSubPannel SubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_SubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannelSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_SubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x0600728A RID: 29322 RVA: 0x0021C8EC File Offset: 0x0021AAEC
		// (set) Token: 0x0600728B RID: 29323 RVA: 0x0003DF16 File Offset: 0x0003C116
		public unsafe UIButtonSimple RefreshButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_RefreshButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_RefreshButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x0600728C RID: 29324 RVA: 0x0021C91C File Offset: 0x0021AB1C
		// (set) Token: 0x0600728D RID: 29325 RVA: 0x0003DF35 File Offset: 0x0003C135
		public unsafe DialogBoxPannel m_MessagePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_m_MessagePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogBoxPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_m_MessagePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x0600728E RID: 29326 RVA: 0x0021C94C File Offset: 0x0021AB4C
		// (set) Token: 0x0600728F RID: 29327 RVA: 0x0003DF54 File Offset: 0x0003C154
		public unsafe List<KeyValuePair<int, LoadedSaveDataInfo>> m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_m_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<int, LoadedSaveDataInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x06007290 RID: 29328 RVA: 0x0021C97C File Offset: 0x0021AB7C
		// (set) Token: 0x06007291 RID: 29329 RVA: 0x0003DF73 File Offset: 0x0003C173
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<int, LoadedSaveDataInfo>, UIElementCluster, UIButtonSimple> m_Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_m_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<int, LoadedSaveDataInfo>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_m_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x06007292 RID: 29330 RVA: 0x0021C9AC File Offset: 0x0021ABAC
		// (set) Token: 0x06007293 RID: 29331 RVA: 0x0003DF92 File Offset: 0x0003C192
		public unsafe bool m_ShouldInstantClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_m_ShouldInstantClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.NativeFieldInfoPtr_m_ShouldInstantClose)) = value;
			}
		}

		// Token: 0x04004BD8 RID: 19416
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstOpen;

		// Token: 0x04004BD9 RID: 19417
		private static readonly IntPtr NativeFieldInfoPtr_SaveParent;

		// Token: 0x04004BDA RID: 19418
		private static readonly IntPtr NativeFieldInfoPtr_ElementField;

		// Token: 0x04004BDB RID: 19419
		private static readonly IntPtr NativeFieldInfoPtr_Scroller;

		// Token: 0x04004BDC RID: 19420
		private static readonly IntPtr NativeFieldInfoPtr_NullIndicator;

		// Token: 0x04004BDD RID: 19421
		private static readonly IntPtr NativeFieldInfoPtr_SubPannel;

		// Token: 0x04004BDE RID: 19422
		private static readonly IntPtr NativeFieldInfoPtr_RefreshButton;

		// Token: 0x04004BDF RID: 19423
		private static readonly IntPtr NativeFieldInfoPtr_m_MessagePanel;

		// Token: 0x04004BE0 RID: 19424
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x04004BE1 RID: 19425
		private static readonly IntPtr NativeFieldInfoPtr_m_Group;

		// Token: 0x04004BE2 RID: 19426
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldInstantClose;

		// Token: 0x04004BE3 RID: 19427
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004BE4 RID: 19428
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004BE5 RID: 19429
		private static readonly IntPtr NativeMethodInfoPtr_OnSecondaryInput_Private_Void_CallbackContext_0;

		// Token: 0x04004BE6 RID: 19430
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004BE7 RID: 19431
		private static readonly IntPtr NativeMethodInfoPtr_AlertSaveFileHasChanged_Public_Static_Void_0;

		// Token: 0x04004BE8 RID: 19432
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0;

		// Token: 0x04004BE9 RID: 19433
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPanel_Private_UniTask_Boolean_0;

		// Token: 0x04004BEA RID: 19434
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004BEB RID: 19435
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSaveElementsAsync_Private_UniTask_Boolean_0;

		// Token: 0x04004BEC RID: 19436
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveElementVisual_Public_Static_Void_UIElementCluster_KeyValuePair_2_Int32_LoadedSaveDataInfo_Boolean_0;

		// Token: 0x04004BED RID: 19437
		private static readonly IntPtr NativeMethodInfoPtr_OnElementPressed_Private_UniTaskVoid_KeyValuePair_2_Int32_PlayerSaveFile_Vector3_0;

		// Token: 0x04004BEE RID: 19438
		private static readonly IntPtr NativeMethodInfoPtr_CannotLoadAsync_Private_UniTask_IReadOnlyList_1_String_IReadOnlyList_1_String_0;

		// Token: 0x04004BEF RID: 19439
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004BF0 RID: 19440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004BF1 RID: 19441
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_1_Private_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004BF2 RID: 19442
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_2_Private_Void_0;

		// Token: 0x02000F38 RID: 3896
		[ObfuscatedName("Common.UI.EscapeUtility.EscLoadPannel+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x06010FFB RID: 69627 RVA: 0x003ED89C File Offset: 0x003EBA9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass13_0>.NativeClassPtr);
				EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass13_0>.NativeClassPtr, "value");
				EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_loadedSaveDataInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass13_0>.NativeClassPtr, "loadedSaveDataInfo");
				EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass13_0>.NativeClassPtr, "button");
				EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				EscLoadPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass13_0>.NativeClassPtr, 100686880);
				EscLoadPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass13_0>.NativeClassPtr, 100686881);
				EscLoadPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass13_0>.NativeClassPtr, 100686882);
			}

			// Token: 0x06010FFC RID: 69628 RVA: 0x003ED954 File Offset: 0x003EBB54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FFD RID: 69629 RVA: 0x003ED990 File Offset: 0x003EBB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285620, XrefRangeEnd = 285638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FFE RID: 69630 RVA: 0x003ED9C4 File Offset: 0x003EBBC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285638, XrefRangeEnd = 285640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FFF RID: 69631 RVA: 0x00093BA1 File Offset: 0x00091DA1
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700586E RID: 22638
			// (get) Token: 0x06011000 RID: 69632 RVA: 0x003ED9F8 File Offset: 0x003EBBF8
			// (set) Token: 0x06011001 RID: 69633 RVA: 0x00093BAA File Offset: 0x00091DAA
			public KeyValuePair<int, LoadedSaveDataInfo> value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_value);
					return new KeyValuePair<int, LoadedSaveDataInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<int, LoadedSaveDataInfo>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<int, LoadedSaveDataInfo>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700586F RID: 22639
			// (get) Token: 0x06011002 RID: 69634 RVA: 0x003EDA28 File Offset: 0x003EBC28
			// (set) Token: 0x06011003 RID: 69635 RVA: 0x00093BD8 File Offset: 0x00091DD8
			public LoadedSaveDataInfo loadedSaveDataInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_loadedSaveDataInfo);
					return new LoadedSaveDataInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_loadedSaveDataInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005870 RID: 22640
			// (get) Token: 0x06011004 RID: 69636 RVA: 0x003EDA58 File Offset: 0x003EBC58
			// (set) Token: 0x06011005 RID: 69637 RVA: 0x00093C06 File Offset: 0x00091E06
			public unsafe UIButtonSimple button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005871 RID: 22641
			// (get) Token: 0x06011006 RID: 69638 RVA: 0x003EDA88 File Offset: 0x003EBC88
			// (set) Token: 0x06011007 RID: 69639 RVA: 0x00093C25 File Offset: 0x00091E25
			public unsafe EscLoadPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ABFA RID: 44026
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400ABFB RID: 44027
			private static readonly IntPtr NativeFieldInfoPtr_loadedSaveDataInfo;

			// Token: 0x0400ABFC RID: 44028
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x0400ABFD RID: 44029
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400ABFE RID: 44030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ABFF RID: 44031
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0;

			// Token: 0x0400AC00 RID: 44032
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_0;
		}

		// Token: 0x02000F39 RID: 3897
		[ObfuscatedName("Common.UI.EscapeUtility.EscLoadPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06011008 RID: 69640 RVA: 0x003EDAB8 File Offset: 0x003EBCB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr);
				EscLoadPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, "<>9");
				EscLoadPannel.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, "<>9__13_0");
				EscLoadPannel.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, "<>9__17_0");
				EscLoadPannel.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, "<>9__20_0");
				EscLoadPannel.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, "<>9__22_0");
				EscLoadPannel.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, "<>9__22_1");
				EscLoadPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, 100686884);
				EscLoadPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Internal_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, 100686885);
				EscLoadPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__17_0_Internal_KeyValuePair_2_Int32_LoadedSaveDataInfo_KeyValuePair_2_LoadedSaveDataInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, 100686886);
				EscLoadPannel.__c.NativeMethodInfoPtr__RefreshSaveElementsAsync_b__20_0_Internal_KeyValuePair_2_Int32_LoadedSaveDataInfo_KeyValuePair_2_LoadedSaveDataInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, 100686887);
				EscLoadPannel.__c.NativeMethodInfoPtr__OnElementPressed_b__22_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, 100686888);
				EscLoadPannel.__c.NativeMethodInfoPtr__OnElementPressed_b__22_1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr, 100686889);
			}

			// Token: 0x06011009 RID: 69641 RVA: 0x003EDBD4 File Offset: 0x003EBDD4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601100A RID: 69642 RVA: 0x003EDC10 File Offset: 0x003EBE10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285640, XrefRangeEnd = 285681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__13_0(KeyValuePair<int, LoadedSaveDataInfo> value, UIElementCluster cluster, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Internal_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601100B RID: 69643 RVA: 0x003EDC7C File Offset: 0x003EBE7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285681, XrefRangeEnd = 285687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<int, LoadedSaveDataInfo> _OnPanelOpenAsync_b__17_0(KeyValuePair<LoadedSaveDataInfo, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__17_0_Internal_KeyValuePair_2_Int32_LoadedSaveDataInfo_KeyValuePair_2_LoadedSaveDataInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<int, LoadedSaveDataInfo>(pointer);
			}

			// Token: 0x0601100C RID: 69644 RVA: 0x003EDCCC File Offset: 0x003EBECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285687, XrefRangeEnd = 285693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<int, LoadedSaveDataInfo> _RefreshSaveElementsAsync_b__20_0(KeyValuePair<LoadedSaveDataInfo, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c.NativeMethodInfoPtr__RefreshSaveElementsAsync_b__20_0_Internal_KeyValuePair_2_Int32_LoadedSaveDataInfo_KeyValuePair_2_LoadedSaveDataInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<int, LoadedSaveDataInfo>(pointer);
			}

			// Token: 0x0601100D RID: 69645 RVA: 0x003EDD1C File Offset: 0x003EBF1C
			[CallerCount(0)]
			public unsafe string _OnElementPressed_b__22_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c.NativeMethodInfoPtr__OnElementPressed_b__22_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0601100E RID: 69646 RVA: 0x003EDD64 File Offset: 0x003EBF64
			[CallerCount(0)]
			public unsafe string _OnElementPressed_b__22_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c.NativeMethodInfoPtr__OnElementPressed_b__22_1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0601100F RID: 69647 RVA: 0x00093C44 File Offset: 0x00091E44
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005872 RID: 22642
			// (get) Token: 0x06011010 RID: 69648 RVA: 0x003EDDAC File Offset: 0x003EBFAC
			// (set) Token: 0x06011011 RID: 69649 RVA: 0x00093C4D File Offset: 0x00091E4D
			public unsafe static EscLoadPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscLoadPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscLoadPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005873 RID: 22643
			// (get) Token: 0x06011012 RID: 69650 RVA: 0x003EDDD4 File Offset: 0x003EBFD4
			// (set) Token: 0x06011013 RID: 69651 RVA: 0x00093C5F File Offset: 0x00091E5F
			public unsafe static Action<KeyValuePair<int, LoadedSaveDataInfo>, UIElementCluster, UIButtonSimple> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscLoadPannel.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<int, LoadedSaveDataInfo>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscLoadPannel.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005874 RID: 22644
			// (get) Token: 0x06011014 RID: 69652 RVA: 0x003EDDFC File Offset: 0x003EBFFC
			// (set) Token: 0x06011015 RID: 69653 RVA: 0x00093C71 File Offset: 0x00091E71
			public unsafe static Func<KeyValuePair<LoadedSaveDataInfo, int>, KeyValuePair<int, LoadedSaveDataInfo>> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscLoadPannel.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<LoadedSaveDataInfo, int>, KeyValuePair<int, LoadedSaveDataInfo>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscLoadPannel.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005875 RID: 22645
			// (get) Token: 0x06011016 RID: 69654 RVA: 0x003EDE24 File Offset: 0x003EC024
			// (set) Token: 0x06011017 RID: 69655 RVA: 0x00093C83 File Offset: 0x00091E83
			public unsafe static Func<KeyValuePair<LoadedSaveDataInfo, int>, KeyValuePair<int, LoadedSaveDataInfo>> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscLoadPannel.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<LoadedSaveDataInfo, int>, KeyValuePair<int, LoadedSaveDataInfo>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscLoadPannel.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005876 RID: 22646
			// (get) Token: 0x06011018 RID: 69656 RVA: 0x003EDE4C File Offset: 0x003EC04C
			// (set) Token: 0x06011019 RID: 69657 RVA: 0x00093C95 File Offset: 0x00091E95
			public unsafe static Func<string, string> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscLoadPannel.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscLoadPannel.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005877 RID: 22647
			// (get) Token: 0x0601101A RID: 69658 RVA: 0x003EDE74 File Offset: 0x003EC074
			// (set) Token: 0x0601101B RID: 69659 RVA: 0x00093CA7 File Offset: 0x00091EA7
			public unsafe static Func<string, string> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscLoadPannel.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscLoadPannel.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC01 RID: 44033
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AC02 RID: 44034
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400AC03 RID: 44035
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400AC04 RID: 44036
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400AC05 RID: 44037
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x0400AC06 RID: 44038
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x0400AC07 RID: 44039
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AC08 RID: 44040
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Internal_Void_KeyValuePair_2_Int32_LoadedSaveDataInfo_UIElementCluster_UIButtonSimple_0;

			// Token: 0x0400AC09 RID: 44041
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__17_0_Internal_KeyValuePair_2_Int32_LoadedSaveDataInfo_KeyValuePair_2_LoadedSaveDataInfo_Int32_0;

			// Token: 0x0400AC0A RID: 44042
			private static readonly IntPtr NativeMethodInfoPtr__RefreshSaveElementsAsync_b__20_0_Internal_KeyValuePair_2_Int32_LoadedSaveDataInfo_KeyValuePair_2_LoadedSaveDataInfo_Int32_0;

			// Token: 0x0400AC0B RID: 44043
			private static readonly IntPtr NativeMethodInfoPtr__OnElementPressed_b__22_0_Internal_String_String_0;

			// Token: 0x0400AC0C RID: 44044
			private static readonly IntPtr NativeMethodInfoPtr__OnElementPressed_b__22_1_Internal_String_String_0;
		}

		// Token: 0x02000F3A RID: 3898
		[ObfuscatedName("Common.UI.EscapeUtility.EscLoadPannel+<OnPanelOpenAsync>d__17")]
		public sealed class _OnPanelOpenAsync_d__17 : ValueType
		{
			// Token: 0x0601101C RID: 69660 RVA: 0x003EDE9C File Offset: 0x003EC09C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPanelOpenAsync_d__17()
			{
				Il2CppClassPointerStore<EscLoadPannel._OnPanelOpenAsync_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "<OnPanelOpenAsync>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannel._OnPanelOpenAsync_d__17>.NativeClassPtr);
				EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnPanelOpenAsync_d__17>.NativeClassPtr, "<>1__state");
				EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnPanelOpenAsync_d__17>.NativeClassPtr, "<>t__builder");
				EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnPanelOpenAsync_d__17>.NativeClassPtr, "<>4__this");
				EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnPanelOpenAsync_d__17>.NativeClassPtr, "<>u__1");
				EscLoadPannel._OnPanelOpenAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel._OnPanelOpenAsync_d__17>.NativeClassPtr, 100686890);
				EscLoadPannel._OnPanelOpenAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel._OnPanelOpenAsync_d__17>.NativeClassPtr, 100686891);
			}

			// Token: 0x0601101D RID: 69661 RVA: 0x003EDF40 File Offset: 0x003EC140
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 285716, RefRangeEnd = 285718, XrefRangeStart = 285693, XrefRangeEnd = 285716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel._OnPanelOpenAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601101E RID: 69662 RVA: 0x003EDF78 File Offset: 0x003EC178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel._OnPanelOpenAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601101F RID: 69663 RVA: 0x00093CB9 File Offset: 0x00091EB9
			public _OnPanelOpenAsync_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06011020 RID: 69664 RVA: 0x00093CC2 File Offset: 0x00091EC2
			public _OnPanelOpenAsync_d__17() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannel._OnPanelOpenAsync_d__17>.NativeClassPtr))
			{
			}

			// Token: 0x17005878 RID: 22648
			// (get) Token: 0x06011021 RID: 69665 RVA: 0x003EDFC0 File Offset: 0x003EC1C0
			// (set) Token: 0x06011022 RID: 69666 RVA: 0x00093CD4 File Offset: 0x00091ED4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005879 RID: 22649
			// (get) Token: 0x06011023 RID: 69667 RVA: 0x003EDFE8 File Offset: 0x003EC1E8
			// (set) Token: 0x06011024 RID: 69668 RVA: 0x00093CEF File Offset: 0x00091EEF
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700587A RID: 22650
			// (get) Token: 0x06011025 RID: 69669 RVA: 0x003EE018 File Offset: 0x003EC218
			// (set) Token: 0x06011026 RID: 69670 RVA: 0x00093D1D File Offset: 0x00091F1D
			public unsafe EscLoadPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700587B RID: 22651
			// (get) Token: 0x06011027 RID: 69671 RVA: 0x003EE048 File Offset: 0x003EC248
			// (set) Token: 0x06011028 RID: 69672 RVA: 0x00093D3C File Offset: 0x00091F3C
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnPanelOpenAsync_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AC0D RID: 44045
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AC0E RID: 44046
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400AC0F RID: 44047
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AC10 RID: 44048
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400AC11 RID: 44049
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AC12 RID: 44050
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000F3B RID: 3899
		[ObfuscatedName("Common.UI.EscapeUtility.EscLoadPannel+<RefreshPanel>d__18")]
		public sealed class _RefreshPanel_d__18 : ValueType
		{
			// Token: 0x06011029 RID: 69673 RVA: 0x003EE078 File Offset: 0x003EC278
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshPanel_d__18()
			{
				Il2CppClassPointerStore<EscLoadPannel._RefreshPanel_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "<RefreshPanel>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannel._RefreshPanel_d__18>.NativeClassPtr);
				EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._RefreshPanel_d__18>.NativeClassPtr, "<>1__state");
				EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._RefreshPanel_d__18>.NativeClassPtr, "<>t__builder");
				EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._RefreshPanel_d__18>.NativeClassPtr, "<>4__this");
				EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr_clearInternalCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._RefreshPanel_d__18>.NativeClassPtr, "clearInternalCache");
				EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._RefreshPanel_d__18>.NativeClassPtr, "<>u__1");
				EscLoadPannel._RefreshPanel_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel._RefreshPanel_d__18>.NativeClassPtr, 100686892);
				EscLoadPannel._RefreshPanel_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel._RefreshPanel_d__18>.NativeClassPtr, 100686893);
			}

			// Token: 0x0601102A RID: 69674 RVA: 0x003EE130 File Offset: 0x003EC330
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 285732, RefRangeEnd = 285735, XrefRangeStart = 285718, XrefRangeEnd = 285732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel._RefreshPanel_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601102B RID: 69675 RVA: 0x003EE168 File Offset: 0x003EC368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel._RefreshPanel_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601102C RID: 69676 RVA: 0x00093D6A File Offset: 0x00091F6A
			public _RefreshPanel_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601102D RID: 69677 RVA: 0x00093D73 File Offset: 0x00091F73
			public _RefreshPanel_d__18() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannel._RefreshPanel_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x1700587C RID: 22652
			// (get) Token: 0x0601102E RID: 69678 RVA: 0x003EE1B0 File Offset: 0x003EC3B0
			// (set) Token: 0x0601102F RID: 69679 RVA: 0x00093D85 File Offset: 0x00091F85
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700587D RID: 22653
			// (get) Token: 0x06011030 RID: 69680 RVA: 0x003EE1D8 File Offset: 0x003EC3D8
			// (set) Token: 0x06011031 RID: 69681 RVA: 0x00093DA0 File Offset: 0x00091FA0
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700587E RID: 22654
			// (get) Token: 0x06011032 RID: 69682 RVA: 0x003EE208 File Offset: 0x003EC408
			// (set) Token: 0x06011033 RID: 69683 RVA: 0x00093DCE File Offset: 0x00091FCE
			public unsafe EscLoadPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700587F RID: 22655
			// (get) Token: 0x06011034 RID: 69684 RVA: 0x003EE238 File Offset: 0x003EC438
			// (set) Token: 0x06011035 RID: 69685 RVA: 0x00093DED File Offset: 0x00091FED
			public unsafe bool clearInternalCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr_clearInternalCache);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr_clearInternalCache)) = value;
				}
			}

			// Token: 0x17005880 RID: 22656
			// (get) Token: 0x06011036 RID: 69686 RVA: 0x003EE260 File Offset: 0x003EC460
			// (set) Token: 0x06011037 RID: 69687 RVA: 0x00093E08 File Offset: 0x00092008
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshPanel_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AC13 RID: 44051
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AC14 RID: 44052
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400AC15 RID: 44053
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AC16 RID: 44054
			private static readonly IntPtr NativeFieldInfoPtr_clearInternalCache;

			// Token: 0x0400AC17 RID: 44055
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400AC18 RID: 44056
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AC19 RID: 44057
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000F3C RID: 3900
		[ObfuscatedName("Common.UI.EscapeUtility.EscLoadPannel+<RefreshSaveElementsAsync>d__20")]
		public sealed class _RefreshSaveElementsAsync_d__20 : ValueType
		{
			// Token: 0x06011038 RID: 69688 RVA: 0x003EE290 File Offset: 0x003EC490
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshSaveElementsAsync_d__20()
			{
				Il2CppClassPointerStore<EscLoadPannel._RefreshSaveElementsAsync_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "<RefreshSaveElementsAsync>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannel._RefreshSaveElementsAsync_d__20>.NativeClassPtr);
				EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._RefreshSaveElementsAsync_d__20>.NativeClassPtr, "<>1__state");
				EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._RefreshSaveElementsAsync_d__20>.NativeClassPtr, "<>t__builder");
				EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr_clearInternalCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._RefreshSaveElementsAsync_d__20>.NativeClassPtr, "clearInternalCache");
				EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._RefreshSaveElementsAsync_d__20>.NativeClassPtr, "<>4__this");
				EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._RefreshSaveElementsAsync_d__20>.NativeClassPtr, "<>u__1");
				EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel._RefreshSaveElementsAsync_d__20>.NativeClassPtr, 100686894);
				EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel._RefreshSaveElementsAsync_d__20>.NativeClassPtr, 100686895);
			}

			// Token: 0x06011039 RID: 69689 RVA: 0x003EE348 File Offset: 0x003EC548
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 285770, RefRangeEnd = 285773, XrefRangeStart = 285735, XrefRangeEnd = 285770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601103A RID: 69690 RVA: 0x003EE380 File Offset: 0x003EC580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601103B RID: 69691 RVA: 0x00093E36 File Offset: 0x00092036
			public _RefreshSaveElementsAsync_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601103C RID: 69692 RVA: 0x00093E3F File Offset: 0x0009203F
			public _RefreshSaveElementsAsync_d__20() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannel._RefreshSaveElementsAsync_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x17005881 RID: 22657
			// (get) Token: 0x0601103D RID: 69693 RVA: 0x003EE3C8 File Offset: 0x003EC5C8
			// (set) Token: 0x0601103E RID: 69694 RVA: 0x00093E51 File Offset: 0x00092051
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005882 RID: 22658
			// (get) Token: 0x0601103F RID: 69695 RVA: 0x003EE3F0 File Offset: 0x003EC5F0
			// (set) Token: 0x06011040 RID: 69696 RVA: 0x00093E6C File Offset: 0x0009206C
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005883 RID: 22659
			// (get) Token: 0x06011041 RID: 69697 RVA: 0x003EE420 File Offset: 0x003EC620
			// (set) Token: 0x06011042 RID: 69698 RVA: 0x00093E9A File Offset: 0x0009209A
			public unsafe bool clearInternalCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr_clearInternalCache);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr_clearInternalCache)) = value;
				}
			}

			// Token: 0x17005884 RID: 22660
			// (get) Token: 0x06011043 RID: 69699 RVA: 0x003EE448 File Offset: 0x003EC648
			// (set) Token: 0x06011044 RID: 69700 RVA: 0x00093EB5 File Offset: 0x000920B5
			public unsafe EscLoadPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005885 RID: 22661
			// (get) Token: 0x06011045 RID: 69701 RVA: 0x003EE478 File Offset: 0x003EC678
			// (set) Token: 0x06011046 RID: 69702 RVA: 0x00093ED4 File Offset: 0x000920D4
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._RefreshSaveElementsAsync_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AC1A RID: 44058
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AC1B RID: 44059
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400AC1C RID: 44060
			private static readonly IntPtr NativeFieldInfoPtr_clearInternalCache;

			// Token: 0x0400AC1D RID: 44061
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AC1E RID: 44062
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400AC1F RID: 44063
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AC20 RID: 44064
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000F3D RID: 3901
		[ObfuscatedName("Common.UI.EscapeUtility.EscLoadPannel+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x06011047 RID: 69703 RVA: 0x003EE4A8 File Offset: 0x003EC6A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr);
				EscLoadPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_saveFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr, "saveFile");
				EscLoadPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_convertedTimeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr, "convertedTimeCode");
				EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr, 100686896);
				EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr, 100686897);
				EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr, 100686898);
				EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr, 100686899);
				EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr, 100686900);
				EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr, 100686901);
				EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr, 100686902);
			}

			// Token: 0x06011048 RID: 69704 RVA: 0x003EE588 File Offset: 0x003EC788
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011049 RID: 69705 RVA: 0x003EE5C4 File Offset: 0x003EC7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285773, XrefRangeEnd = 285774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeSaveElementVisual_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601104A RID: 69706 RVA: 0x003EE608 File Offset: 0x003EC808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285774, XrefRangeEnd = 285776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeSaveElementVisual_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601104B RID: 69707 RVA: 0x003EE64C File Offset: 0x003EC84C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285776, XrefRangeEnd = 285778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeSaveElementVisual_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601104C RID: 69708 RVA: 0x003EE690 File Offset: 0x003EC890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285778, XrefRangeEnd = 285784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeSaveElementVisual_b__3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601104D RID: 69709 RVA: 0x003EE6D4 File Offset: 0x003EC8D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285784, XrefRangeEnd = 285790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeSaveElementVisual_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601104E RID: 69710 RVA: 0x003EE718 File Offset: 0x003EC918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285790, XrefRangeEnd = 285792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeSaveElementVisual_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeSaveElementVisual_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601104F RID: 69711 RVA: 0x00093F02 File Offset: 0x00092102
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005886 RID: 22662
			// (get) Token: 0x06011050 RID: 69712 RVA: 0x003EE75C File Offset: 0x003EC95C
			// (set) Token: 0x06011051 RID: 69713 RVA: 0x00093F0B File Offset: 0x0009210B
			public PlayerSaveFile saveFile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_saveFile);
					return new PlayerSaveFile(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_saveFile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005887 RID: 22663
			// (get) Token: 0x06011052 RID: 69714 RVA: 0x003EE78C File Offset: 0x003EC98C
			// (set) Token: 0x06011053 RID: 69715 RVA: 0x00093F39 File Offset: 0x00092139
			public unsafe DateTime convertedTimeCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_convertedTimeCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_convertedTimeCode)) = value;
				}
			}

			// Token: 0x0400AC21 RID: 44065
			private static readonly IntPtr NativeFieldInfoPtr_saveFile;

			// Token: 0x0400AC22 RID: 44066
			private static readonly IntPtr NativeFieldInfoPtr_convertedTimeCode;

			// Token: 0x0400AC23 RID: 44067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AC24 RID: 44068
			private static readonly IntPtr NativeMethodInfoPtr__InitializeSaveElementVisual_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AC25 RID: 44069
			private static readonly IntPtr NativeMethodInfoPtr__InitializeSaveElementVisual_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AC26 RID: 44070
			private static readonly IntPtr NativeMethodInfoPtr__InitializeSaveElementVisual_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AC27 RID: 44071
			private static readonly IntPtr NativeMethodInfoPtr__InitializeSaveElementVisual_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AC28 RID: 44072
			private static readonly IntPtr NativeMethodInfoPtr__InitializeSaveElementVisual_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AC29 RID: 44073
			private static readonly IntPtr NativeMethodInfoPtr__InitializeSaveElementVisual_b__5_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000F3E RID: 3902
		[ObfuscatedName("Common.UI.EscapeUtility.EscLoadPannel+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x06011054 RID: 69716 RVA: 0x003EE7B4 File Offset: 0x003EC9B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass22_0>.NativeClassPtr);
				EscLoadPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_operatingSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass22_0>.NativeClassPtr, "operatingSave");
				EscLoadPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass22_0>.NativeClassPtr, 100686903);
				EscLoadPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnElementPressed_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass22_0>.NativeClassPtr, 100686904);
			}

			// Token: 0x06011055 RID: 69717 RVA: 0x003EE81C File Offset: 0x003ECA1C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannel.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011056 RID: 69718 RVA: 0x003EE858 File Offset: 0x003ECA58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285792, XrefRangeEnd = 285810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementPressed_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__OnElementPressed_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011057 RID: 69719 RVA: 0x00093F54 File Offset: 0x00092154
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005888 RID: 22664
			// (get) Token: 0x06011058 RID: 69720 RVA: 0x003EE88C File Offset: 0x003ECA8C
			// (set) Token: 0x06011059 RID: 69721 RVA: 0x00093F5D File Offset: 0x0009215D
			public KeyValuePair<int, PlayerSaveFile> operatingSave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_operatingSave);
					return new KeyValuePair<int, PlayerSaveFile>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<int, PlayerSaveFile>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_operatingSave), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<int, PlayerSaveFile>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AC2A RID: 44074
			private static readonly IntPtr NativeFieldInfoPtr_operatingSave;

			// Token: 0x0400AC2B RID: 44075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AC2C RID: 44076
			private static readonly IntPtr NativeMethodInfoPtr__OnElementPressed_b__2_Internal_Void_0;
		}

		// Token: 0x02000F3F RID: 3903
		[ObfuscatedName("Common.UI.EscapeUtility.EscLoadPannel+<OnElementPressed>d__22")]
		public sealed class _OnElementPressed_d__22 : ValueType
		{
			// Token: 0x0601105A RID: 69722 RVA: 0x003EE8BC File Offset: 0x003ECABC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnElementPressed_d__22()
			{
				Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "<OnElementPressed>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr);
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "<>1__state");
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "<>t__builder");
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr_operatingSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "operatingSave");
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "<>4__this");
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr_elementPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "elementPosition");
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "<>8__1");
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr__pannelInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "<pannelInstance>5__2");
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr__a_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "<a>5__3");
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr__b_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "<b>5__4");
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "<>u__1");
				EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, "<>u__2");
				EscLoadPannel._OnElementPressed_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, 100686905);
				EscLoadPannel._OnElementPressed_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr, 100686906);
			}

			// Token: 0x0601105B RID: 69723 RVA: 0x003EE9EC File Offset: 0x003ECBEC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 285995, RefRangeEnd = 285997, XrefRangeStart = 285810, XrefRangeEnd = 285995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel._OnElementPressed_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601105C RID: 69724 RVA: 0x003EEA24 File Offset: 0x003ECC24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel._OnElementPressed_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601105D RID: 69725 RVA: 0x00093F8B File Offset: 0x0009218B
			public _OnElementPressed_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601105E RID: 69726 RVA: 0x00093F94 File Offset: 0x00092194
			public _OnElementPressed_d__22() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannel._OnElementPressed_d__22>.NativeClassPtr))
			{
			}

			// Token: 0x17005889 RID: 22665
			// (get) Token: 0x0601105F RID: 69727 RVA: 0x003EEA6C File Offset: 0x003ECC6C
			// (set) Token: 0x06011060 RID: 69728 RVA: 0x00093FA6 File Offset: 0x000921A6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700588A RID: 22666
			// (get) Token: 0x06011061 RID: 69729 RVA: 0x003EEA94 File Offset: 0x003ECC94
			// (set) Token: 0x06011062 RID: 69730 RVA: 0x00093FC1 File Offset: 0x000921C1
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700588B RID: 22667
			// (get) Token: 0x06011063 RID: 69731 RVA: 0x003EEAC4 File Offset: 0x003ECCC4
			// (set) Token: 0x06011064 RID: 69732 RVA: 0x00093FEF File Offset: 0x000921EF
			public KeyValuePair<int, PlayerSaveFile> operatingSave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr_operatingSave);
					return new KeyValuePair<int, PlayerSaveFile>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<int, PlayerSaveFile>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr_operatingSave), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<int, PlayerSaveFile>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700588C RID: 22668
			// (get) Token: 0x06011065 RID: 69733 RVA: 0x003EEAF4 File Offset: 0x003ECCF4
			// (set) Token: 0x06011066 RID: 69734 RVA: 0x0009401D File Offset: 0x0009221D
			public unsafe EscLoadPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700588D RID: 22669
			// (get) Token: 0x06011067 RID: 69735 RVA: 0x003EEB24 File Offset: 0x003ECD24
			// (set) Token: 0x06011068 RID: 69736 RVA: 0x0009403C File Offset: 0x0009223C
			public unsafe Vector3 elementPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr_elementPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr_elementPosition)) = value;
				}
			}

			// Token: 0x1700588E RID: 22670
			// (get) Token: 0x06011069 RID: 69737 RVA: 0x003EEB4C File Offset: 0x003ECD4C
			// (set) Token: 0x0601106A RID: 69738 RVA: 0x00094057 File Offset: 0x00092257
			public unsafe EscLoadPannel.__c__DisplayClass22_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannel.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700588F RID: 22671
			// (get) Token: 0x0601106B RID: 69739 RVA: 0x003EEB7C File Offset: 0x003ECD7C
			// (set) Token: 0x0601106C RID: 69740 RVA: 0x00094076 File Offset: 0x00092276
			public unsafe EscLoadPannelSubPannel _pannelInstance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr__pannelInstance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannelSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr__pannelInstance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005890 RID: 22672
			// (get) Token: 0x0601106D RID: 69741 RVA: 0x003EEBAC File Offset: 0x003ECDAC
			// (set) Token: 0x0601106E RID: 69742 RVA: 0x00094095 File Offset: 0x00092295
			public UnityEngineExtensionStatic.ScopedTempHashSetHandle<string> _a_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr__a_5__3);
					return new UnityEngineExtensionStatic.ScopedTempHashSetHandle<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityEngineExtensionStatic.ScopedTempHashSetHandle<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr__a_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnityEngineExtensionStatic.ScopedTempHashSetHandle<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005891 RID: 22673
			// (get) Token: 0x0601106F RID: 69743 RVA: 0x003EEBDC File Offset: 0x003ECDDC
			// (set) Token: 0x06011070 RID: 69744 RVA: 0x000940C3 File Offset: 0x000922C3
			public UnityEngineExtensionStatic.ScopedTempHashSetHandle<string> _b_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr__b_5__4);
					return new UnityEngineExtensionStatic.ScopedTempHashSetHandle<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityEngineExtensionStatic.ScopedTempHashSetHandle<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr__b_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnityEngineExtensionStatic.ScopedTempHashSetHandle<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005892 RID: 22674
			// (get) Token: 0x06011071 RID: 69745 RVA: 0x003EEC0C File Offset: 0x003ECE0C
			// (set) Token: 0x06011072 RID: 69746 RVA: 0x000940F1 File Offset: 0x000922F1
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005893 RID: 22675
			// (get) Token: 0x06011073 RID: 69747 RVA: 0x003EEC3C File Offset: 0x003ECE3C
			// (set) Token: 0x06011074 RID: 69748 RVA: 0x0009411F File Offset: 0x0009231F
			public UniTask<EscLoadPannelSubPannel>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___u__2);
					return new UniTask<EscLoadPannelSubPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<EscLoadPannelSubPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._OnElementPressed_d__22.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<EscLoadPannelSubPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AC2D RID: 44077
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AC2E RID: 44078
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400AC2F RID: 44079
			private static readonly IntPtr NativeFieldInfoPtr_operatingSave;

			// Token: 0x0400AC30 RID: 44080
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AC31 RID: 44081
			private static readonly IntPtr NativeFieldInfoPtr_elementPosition;

			// Token: 0x0400AC32 RID: 44082
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400AC33 RID: 44083
			private static readonly IntPtr NativeFieldInfoPtr__pannelInstance_5__2;

			// Token: 0x0400AC34 RID: 44084
			private static readonly IntPtr NativeFieldInfoPtr__a_5__3;

			// Token: 0x0400AC35 RID: 44085
			private static readonly IntPtr NativeFieldInfoPtr__b_5__4;

			// Token: 0x0400AC36 RID: 44086
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400AC37 RID: 44087
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400AC38 RID: 44088
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AC39 RID: 44089
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000F40 RID: 3904
		[ObfuscatedName("Common.UI.EscapeUtility.EscLoadPannel+<CannotLoadAsync>d__23")]
		public sealed class _CannotLoadAsync_d__23 : ValueType
		{
			// Token: 0x06011075 RID: 69749 RVA: 0x003EEC6C File Offset: 0x003ECE6C
			// Note: this type is marked as 'beforefieldinit'.
			static _CannotLoadAsync_d__23()
			{
				Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscLoadPannel>.NativeClassPtr, "<CannotLoadAsync>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr);
				EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr, "<>1__state");
				EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr, "<>t__builder");
				EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr, "<>4__this");
				EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr_activeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr, "activeArray");
				EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr_inSaveArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr, "inSaveArray");
				EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr, "<>u__1");
				EscLoadPannel._CannotLoadAsync_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr, 100686907);
				EscLoadPannel._CannotLoadAsync_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr, 100686908);
			}

			// Token: 0x06011076 RID: 69750 RVA: 0x003EED38 File Offset: 0x003ECF38
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 286014, RefRangeEnd = 286017, XrefRangeStart = 285997, XrefRangeEnd = 286014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel._CannotLoadAsync_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011077 RID: 69751 RVA: 0x003EED70 File Offset: 0x003ECF70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannel._CannotLoadAsync_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011078 RID: 69752 RVA: 0x0009414D File Offset: 0x0009234D
			public _CannotLoadAsync_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06011079 RID: 69753 RVA: 0x00094156 File Offset: 0x00092356
			public _CannotLoadAsync_d__23() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannel._CannotLoadAsync_d__23>.NativeClassPtr))
			{
			}

			// Token: 0x17005894 RID: 22676
			// (get) Token: 0x0601107A RID: 69754 RVA: 0x003EEDB8 File Offset: 0x003ECFB8
			// (set) Token: 0x0601107B RID: 69755 RVA: 0x00094168 File Offset: 0x00092368
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005895 RID: 22677
			// (get) Token: 0x0601107C RID: 69756 RVA: 0x003EEDE0 File Offset: 0x003ECFE0
			// (set) Token: 0x0601107D RID: 69757 RVA: 0x00094183 File Offset: 0x00092383
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005896 RID: 22678
			// (get) Token: 0x0601107E RID: 69758 RVA: 0x003EEE10 File Offset: 0x003ED010
			// (set) Token: 0x0601107F RID: 69759 RVA: 0x000941B1 File Offset: 0x000923B1
			public unsafe EscLoadPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005897 RID: 22679
			// (get) Token: 0x06011080 RID: 69760 RVA: 0x003EEE40 File Offset: 0x003ED040
			// (set) Token: 0x06011081 RID: 69761 RVA: 0x000941D0 File Offset: 0x000923D0
			public unsafe IReadOnlyList<string> activeArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr_activeArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr_activeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005898 RID: 22680
			// (get) Token: 0x06011082 RID: 69762 RVA: 0x003EEE70 File Offset: 0x003ED070
			// (set) Token: 0x06011083 RID: 69763 RVA: 0x000941EF File Offset: 0x000923EF
			public unsafe IReadOnlyList<string> inSaveArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr_inSaveArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr_inSaveArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005899 RID: 22681
			// (get) Token: 0x06011084 RID: 69764 RVA: 0x003EEEA0 File Offset: 0x003ED0A0
			// (set) Token: 0x06011085 RID: 69765 RVA: 0x0009420E File Offset: 0x0009240E
			public UniTask<DialogBoxPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___u__1);
					return new UniTask<DialogBoxPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DialogBoxPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannel._CannotLoadAsync_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DialogBoxPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AC3A RID: 44090
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AC3B RID: 44091
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400AC3C RID: 44092
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AC3D RID: 44093
			private static readonly IntPtr NativeFieldInfoPtr_activeArray;

			// Token: 0x0400AC3E RID: 44094
			private static readonly IntPtr NativeFieldInfoPtr_inSaveArray;

			// Token: 0x0400AC3F RID: 44095
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400AC40 RID: 44096
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AC41 RID: 44097
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
