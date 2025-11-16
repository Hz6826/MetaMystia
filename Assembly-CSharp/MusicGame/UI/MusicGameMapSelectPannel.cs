using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace MusicGame.UI
{
	// Token: 0x0200001C RID: 28
	public class MusicGameMapSelectPannel : UISubPanel<MusicGameIntroInfoPannel>
	{
		// Token: 0x06000216 RID: 534 RVA: 0x000A5C14 File Offset: 0x000A3E14
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameMapSelectPannel()
		{
			Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicGameMapSelectPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr);
			MusicGameMapSelectPannel.NativeFieldInfoPtr_currentMapLabelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "currentMapLabelText");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_CDComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "CDComponent");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_selectableMapField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "selectableMapField");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_cacheField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "cacheField");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_recordCoverElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "recordCoverElement");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_mapCoverFieldScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "mapCoverFieldScroller");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_selectorPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "selectorPannel");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_allUnlockBadgeConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "allUnlockBadgeConditions");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_cannotSelectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "cannotSelectColor");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_unlockText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "unlockText");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_m_DLCIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "m_DLCIndicator");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_currentMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "currentMapLabel");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_m_MusicMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "m_MusicMapping");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_m_pannelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "m_pannelInstance");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_m_UILogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "m_UILogicalGroup");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_m_UnlockedMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "m_UnlockedMapLabel");
			MusicGameMapSelectPannel.NativeFieldInfoPtr_BadgeUnlockCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "BadgeUnlockCondition");
			MusicGameMapSelectPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663585);
			MusicGameMapSelectPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663586);
			MusicGameMapSelectPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663587);
			MusicGameMapSelectPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663588);
			MusicGameMapSelectPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663589);
			MusicGameMapSelectPannel.NativeMethodInfoPtr_ExitPannel_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663590);
			MusicGameMapSelectPannel.NativeMethodInfoPtr_OnFadeFinish_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663591);
			MusicGameMapSelectPannel.NativeMethodInfoPtr_RefreshPannel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663592);
			MusicGameMapSelectPannel.NativeMethodInfoPtr_OnMapItemEnable_Private_Void_MusicMapping_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663593);
			MusicGameMapSelectPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663594);
			MusicGameMapSelectPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663595);
			MusicGameMapSelectPannel.NativeMethodInfoPtr__OnPanelOpen_b__20_0_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663596);
			MusicGameMapSelectPannel.NativeMethodInfoPtr__OnPanelOpen_b__20_2_Private_Boolean_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663597);
			MusicGameMapSelectPannel.NativeMethodInfoPtr__OnPanelOpen_b__20_3_Private_Boolean_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663598);
			MusicGameMapSelectPannel.NativeMethodInfoPtr__RefreshPannel_b__25_0_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, 100663599);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000217 RID: 535 RVA: 0x000A5EC4 File Offset: 0x000A40C4
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMapSelectPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000A5F0C File Offset: 0x000A410C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19595, XrefRangeEnd = 19622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMapSelectPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000A5F48 File Offset: 0x000A4148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19622, XrefRangeEnd = 19732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMapSelectPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000A5F84 File Offset: 0x000A4184
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMapSelectPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000A5FCC File Offset: 0x000A41CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19732, XrefRangeEnd = 19736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMapSelectPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000A6008 File Offset: 0x000A4208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19736, XrefRangeEnd = 19748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitPannel(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.NativeMethodInfoPtr_ExitPannel_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000A6050 File Offset: 0x000A4250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19748, XrefRangeEnd = 19756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFadeFinish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.NativeMethodInfoPtr_OnFadeFinish_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000A6084 File Offset: 0x000A4284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19756, XrefRangeEnd = 19786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.NativeMethodInfoPtr_RefreshPannel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000A60B8 File Offset: 0x000A42B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19786, XrefRangeEnd = 19963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMapItemEnable(MusicGameMappingProfile.MusicMapping data, UIElementCluster uiElement, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElement);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.NativeMethodInfoPtr_OnMapItemEnable_Private_Void_MusicMapping_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000A6124 File Offset: 0x000A4324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19963, XrefRangeEnd = 19984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMapSelectPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000A6160 File Offset: 0x000A4360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19984, XrefRangeEnd = 20002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameMapSelectPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000A619C File Offset: 0x000A439C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20002, XrefRangeEnd = 20017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPanelOpen_b__20_0(string x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.NativeMethodInfoPtr__OnPanelOpen_b__20_0_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000A61EC File Offset: 0x000A43EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20017, XrefRangeEnd = 20018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPanelOpen_b__20_2(MusicGameMappingProfile.MusicMapping x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.NativeMethodInfoPtr__OnPanelOpen_b__20_2_Private_Boolean_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000A6240 File Offset: 0x000A4440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPanelOpen_b__20_3(MusicGameMappingProfile.MusicMapping x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.NativeMethodInfoPtr__OnPanelOpen_b__20_3_Private_Boolean_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000A6294 File Offset: 0x000A4494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20018, XrefRangeEnd = 20033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RefreshPannel_b__25_0(string x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.NativeMethodInfoPtr__RefreshPannel_b__25_0_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00003104 File Offset: 0x00001304
		public MusicGameMapSelectPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000A62E4 File Offset: 0x000A44E4
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0000310D File Offset: 0x0000130D
		public unsafe TextMeshProUGUI currentMapLabelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_currentMapLabelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_currentMapLabelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000A6314 File Offset: 0x000A4514
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000312C File Offset: 0x0000132C
		public unsafe UIElementCluster CDComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_CDComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_CDComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000A6344 File Offset: 0x000A4544
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0000314B File Offset: 0x0000134B
		public unsafe RectTransform selectableMapField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_selectableMapField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_selectableMapField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600022D RID: 557 RVA: 0x000A6374 File Offset: 0x000A4574
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0000316A File Offset: 0x0000136A
		public unsafe RectTransform cacheField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_cacheField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_cacheField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600022F RID: 559 RVA: 0x000A63A4 File Offset: 0x000A45A4
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00003189 File Offset: 0x00001389
		public unsafe GameObject recordCoverElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_recordCoverElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_recordCoverElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000A63D4 File Offset: 0x000A45D4
		// (set) Token: 0x06000232 RID: 562 RVA: 0x000031A8 File Offset: 0x000013A8
		public unsafe AdpScrollListFixedComponent mapCoverFieldScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_mapCoverFieldScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpScrollListFixedComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_mapCoverFieldScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000A6404 File Offset: 0x000A4604
		// (set) Token: 0x06000234 RID: 564 RVA: 0x000031C7 File Offset: 0x000013C7
		public unsafe MusicSelectorPannel selectorPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_selectorPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_selectorPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000A6434 File Offset: 0x000A4634
		// (set) Token: 0x06000236 RID: 566 RVA: 0x000031E6 File Offset: 0x000013E6
		public unsafe Il2CppReferenceArray<MusicGameMapSelectPannel.UnlockBadgeCondition> allUnlockBadgeConditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_allUnlockBadgeConditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MusicGameMapSelectPannel.UnlockBadgeCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_allUnlockBadgeConditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000A6464 File Offset: 0x000A4664
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00003205 File Offset: 0x00001405
		public unsafe Color cannotSelectColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_cannotSelectColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_cannotSelectColor)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000A648C File Offset: 0x000A468C
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00003220 File Offset: 0x00001420
		public unsafe TextMeshProUGUI unlockText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_unlockText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_unlockText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600023B RID: 571 RVA: 0x000A64BC File Offset: 0x000A46BC
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000323F File Offset: 0x0000143F
		public unsafe Dictionary<UIElementCluster, GameObject> m_DLCIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_m_DLCIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UIElementCluster, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_m_DLCIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600023D RID: 573 RVA: 0x000A64EC File Offset: 0x000A46EC
		// (set) Token: 0x0600023E RID: 574 RVA: 0x0000325E File Offset: 0x0000145E
		public unsafe string currentMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_currentMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_currentMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600023F RID: 575 RVA: 0x000A6514 File Offset: 0x000A4714
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0000327D File Offset: 0x0000147D
		public unsafe List<MusicGameMappingProfile.MusicMapping> m_MusicMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_m_MusicMapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicGameMappingProfile.MusicMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_m_MusicMapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000A6544 File Offset: 0x000A4744
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0000329C File Offset: 0x0000149C
		public unsafe MusicSelectorPannel m_pannelInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_m_pannelInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_m_pannelInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000A6574 File Offset: 0x000A4774
		// (set) Token: 0x06000244 RID: 580 RVA: 0x000032BB File Offset: 0x000014BB
		public unsafe VirtualScrollListUILogicalGroupT<MusicGameMappingProfile.MusicMapping, UIElementCluster, UIButtonSimple> m_UILogicalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_m_UILogicalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VirtualScrollListUILogicalGroupT<MusicGameMappingProfile.MusicMapping, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_m_UILogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000245 RID: 581 RVA: 0x000A65A4 File Offset: 0x000A47A4
		// (set) Token: 0x06000246 RID: 582 RVA: 0x000032DA File Offset: 0x000014DA
		public unsafe List<string> m_UnlockedMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_m_UnlockedMapLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_m_UnlockedMapLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000A65D4 File Offset: 0x000A47D4
		// (set) Token: 0x06000248 RID: 584 RVA: 0x000032F9 File Offset: 0x000014F9
		public unsafe Dictionary<string, ValueTuple<int, int>> BadgeUnlockCondition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_BadgeUnlockCondition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<int, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.NativeFieldInfoPtr_BadgeUnlockCondition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_currentMapLabelText;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_CDComponent;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_selectableMapField;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_cacheField;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_recordCoverElement;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_mapCoverFieldScroller;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_selectorPannel;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_allUnlockBadgeConditions;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_cannotSelectColor;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_unlockText;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_m_DLCIndicator;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_currentMapLabel;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicMapping;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_m_pannelInstance;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_m_UILogicalGroup;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_m_UnlockedMapLabel;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_BadgeUnlockCondition;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_ExitPannel_Private_Void_CallbackContext_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_OnFadeFinish_Private_Void_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPannel_Private_Void_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_OnMapItemEnable_Private_Void_MusicMapping_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__20_0_Private_Boolean_String_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__20_2_Private_Boolean_MusicMapping_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__20_3_Private_Boolean_MusicMapping_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr__RefreshPannel_b__25_0_Private_Boolean_String_0;

		// Token: 0x02000483 RID: 1155
		[Serializable]
		public sealed class UnlockBadgeCondition : ValueType
		{
			// Token: 0x06007CF5 RID: 31989 RVA: 0x0023C320 File Offset: 0x0023A520
			// Note: this type is marked as 'beforefieldinit'.
			static UnlockBadgeCondition()
			{
				Il2CppClassPointerStore<MusicGameMapSelectPannel.UnlockBadgeCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "UnlockBadgeCondition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMapSelectPannel.UnlockBadgeCondition>.NativeClassPtr);
				MusicGameMapSelectPannel.UnlockBadgeCondition.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.UnlockBadgeCondition>.NativeClassPtr, "mapLabel");
				MusicGameMapSelectPannel.UnlockBadgeCondition.NativeFieldInfoPtr_easyBadgeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.UnlockBadgeCondition>.NativeClassPtr, "easyBadgeId");
				MusicGameMapSelectPannel.UnlockBadgeCondition.NativeFieldInfoPtr_hardBadgeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.UnlockBadgeCondition>.NativeClassPtr, "hardBadgeId");
			}

			// Token: 0x06007CF6 RID: 31990 RVA: 0x000434E3 File Offset: 0x000416E3
			public UnlockBadgeCondition(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007CF7 RID: 31991 RVA: 0x000434EC File Offset: 0x000416EC
			public UnlockBadgeCondition() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMapSelectPannel.UnlockBadgeCondition>.NativeClassPtr))
			{
			}

			// Token: 0x17002A4E RID: 10830
			// (get) Token: 0x06007CF8 RID: 31992 RVA: 0x0023C388 File Offset: 0x0023A588
			// (set) Token: 0x06007CF9 RID: 31993 RVA: 0x000434FE File Offset: 0x000416FE
			public unsafe string mapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.UnlockBadgeCondition.NativeFieldInfoPtr_mapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.UnlockBadgeCondition.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002A4F RID: 10831
			// (get) Token: 0x06007CFA RID: 31994 RVA: 0x0023C3B0 File Offset: 0x0023A5B0
			// (set) Token: 0x06007CFB RID: 31995 RVA: 0x0004351D File Offset: 0x0004171D
			public unsafe int easyBadgeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.UnlockBadgeCondition.NativeFieldInfoPtr_easyBadgeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.UnlockBadgeCondition.NativeFieldInfoPtr_easyBadgeId)) = value;
				}
			}

			// Token: 0x17002A50 RID: 10832
			// (get) Token: 0x06007CFC RID: 31996 RVA: 0x0023C3D8 File Offset: 0x0023A5D8
			// (set) Token: 0x06007CFD RID: 31997 RVA: 0x00043538 File Offset: 0x00041738
			public unsafe int hardBadgeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.UnlockBadgeCondition.NativeFieldInfoPtr_hardBadgeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.UnlockBadgeCondition.NativeFieldInfoPtr_hardBadgeId)) = value;
				}
			}

			// Token: 0x04005239 RID: 21049
			private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

			// Token: 0x0400523A RID: 21050
			private static readonly IntPtr NativeFieldInfoPtr_easyBadgeId;

			// Token: 0x0400523B RID: 21051
			private static readonly IntPtr NativeFieldInfoPtr_hardBadgeId;
		}

		// Token: 0x02000484 RID: 1156
		[ObfuscatedName("MusicGame.UI.MusicGameMapSelectPannel+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x06007CFE RID: 31998 RVA: 0x0023C400 File Offset: 0x0023A600
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass20_0>.NativeClassPtr);
				MusicGameMapSelectPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass20_0>.NativeClassPtr, "x");
				MusicGameMapSelectPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass20_0>.NativeClassPtr, 100663600);
				MusicGameMapSelectPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Boolean_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass20_0>.NativeClassPtr, 100663601);
			}

			// Token: 0x06007CFF RID: 31999 RVA: 0x0023C468 File Offset: 0x0023A668
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D00 RID: 32000 RVA: 0x0023C4A4 File Offset: 0x0023A6A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19420, XrefRangeEnd = 19421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__5(MusicGameMappingProfile.MusicMapping y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Boolean_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007D01 RID: 32001 RVA: 0x00043553 File Offset: 0x00041753
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A51 RID: 10833
			// (get) Token: 0x06007D02 RID: 32002 RVA: 0x0023C4F8 File Offset: 0x0023A6F8
			// (set) Token: 0x06007D03 RID: 32003 RVA: 0x0004355C File Offset: 0x0004175C
			public unsafe string x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_x);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_x), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400523C RID: 21052
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400523D RID: 21053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400523E RID: 21054
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Boolean_MusicMapping_0;
		}

		// Token: 0x02000485 RID: 1157
		[ObfuscatedName("MusicGame.UI.MusicGameMapSelectPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06007D04 RID: 32004 RVA: 0x0023C520 File Offset: 0x0023A720
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr);
				MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, "<>9");
				MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__20_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, "<>9__20_4");
				MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, "<>9__20_1");
				MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, "<>9__26_2");
				MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, "<>9__26_3");
				MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, "<>9__26_7");
				MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, "<>9__26_9");
				MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, "<>9__26_13");
				MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, 100663603);
				MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__20_4_Internal_Boolean_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, 100663604);
				MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__20_1_Internal_Boolean_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, 100663605);
				MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnMapItemEnable_b__26_2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, 100663606);
				MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnMapItemEnable_b__26_3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, 100663607);
				MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnMapItemEnable_b__26_7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, 100663608);
				MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnMapItemEnable_b__26_9_Internal_String_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, 100663609);
				MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnMapItemEnable_b__26_13_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr, 100663610);
			}

			// Token: 0x06007D05 RID: 32005 RVA: 0x0023C68C File Offset: 0x0023A88C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D06 RID: 32006 RVA: 0x0023C6C8 File Offset: 0x0023A8C8
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__20_4(MusicGameMappingProfile.MusicMapping musicMapping)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(musicMapping));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__20_4_Internal_Boolean_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007D07 RID: 32007 RVA: 0x0023C71C File Offset: 0x0023A91C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19421, XrefRangeEnd = 19427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__20_1(KeyValuePair<string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__20_1_Internal_Boolean_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007D08 RID: 32008 RVA: 0x0023C770 File Offset: 0x0023A970
			[CallerCount(0)]
			public unsafe void _OnMapItemEnable_b__26_2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnMapItemEnable_b__26_2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D09 RID: 32009 RVA: 0x0023C7B4 File Offset: 0x0023A9B4
			[CallerCount(0)]
			public unsafe void _OnMapItemEnable_b__26_3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnMapItemEnable_b__26_3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D0A RID: 32010 RVA: 0x0023C7F8 File Offset: 0x0023A9F8
			[CallerCount(0)]
			public unsafe void _OnMapItemEnable_b__26_7(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnMapItemEnable_b__26_7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D0B RID: 32011 RVA: 0x0023C83C File Offset: 0x0023AA3C
			[CallerCount(0)]
			public unsafe string _OnMapItemEnable_b__26_9(MusicGameMappingProfile.MusicMapping x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnMapItemEnable_b__26_9_Internal_String_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06007D0C RID: 32012 RVA: 0x0023C88C File Offset: 0x0023AA8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19427, XrefRangeEnd = 19430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnMapItemEnable_b__26_13(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c.NativeMethodInfoPtr__OnMapItemEnable_b__26_13_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06007D0D RID: 32013 RVA: 0x0004357B File Offset: 0x0004177B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A52 RID: 10834
			// (get) Token: 0x06007D0E RID: 32014 RVA: 0x0023C8D4 File Offset: 0x0023AAD4
			// (set) Token: 0x06007D0F RID: 32015 RVA: 0x00043584 File Offset: 0x00041784
			public unsafe static MusicGameMapSelectPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMapSelectPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A53 RID: 10835
			// (get) Token: 0x06007D10 RID: 32016 RVA: 0x0023C8FC File Offset: 0x0023AAFC
			// (set) Token: 0x06007D11 RID: 32017 RVA: 0x00043596 File Offset: 0x00041796
			public unsafe static Func<MusicGameMappingProfile.MusicMapping, bool> __9__20_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__20_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MusicGameMappingProfile.MusicMapping, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__20_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A54 RID: 10836
			// (get) Token: 0x06007D12 RID: 32018 RVA: 0x0023C924 File Offset: 0x0023AB24
			// (set) Token: 0x06007D13 RID: 32019 RVA: 0x000435A8 File Offset: 0x000417A8
			public unsafe static Func<KeyValuePair<string, string>, bool> __9__20_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, string>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A55 RID: 10837
			// (get) Token: 0x06007D14 RID: 32020 RVA: 0x0023C94C File Offset: 0x0023AB4C
			// (set) Token: 0x06007D15 RID: 32021 RVA: 0x000435BA File Offset: 0x000417BA
			public unsafe static Action<Image> __9__26_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A56 RID: 10838
			// (get) Token: 0x06007D16 RID: 32022 RVA: 0x0023C974 File Offset: 0x0023AB74
			// (set) Token: 0x06007D17 RID: 32023 RVA: 0x000435CC File Offset: 0x000417CC
			public unsafe static Action<Image> __9__26_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A57 RID: 10839
			// (get) Token: 0x06007D18 RID: 32024 RVA: 0x0023C99C File Offset: 0x0023AB9C
			// (set) Token: 0x06007D19 RID: 32025 RVA: 0x000435DE File Offset: 0x000417DE
			public unsafe static Action<Image> __9__26_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A58 RID: 10840
			// (get) Token: 0x06007D1A RID: 32026 RVA: 0x0023C9C4 File Offset: 0x0023ABC4
			// (set) Token: 0x06007D1B RID: 32027 RVA: 0x000435F0 File Offset: 0x000417F0
			public unsafe static Func<MusicGameMappingProfile.MusicMapping, string> __9__26_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MusicGameMappingProfile.MusicMapping, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A59 RID: 10841
			// (get) Token: 0x06007D1C RID: 32028 RVA: 0x0023C9EC File Offset: 0x0023ABEC
			// (set) Token: 0x06007D1D RID: 32029 RVA: 0x00043602 File Offset: 0x00041802
			public unsafe static Func<string, string> __9__26_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMapSelectPannel.__c.NativeFieldInfoPtr___9__26_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400523F RID: 21055
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005240 RID: 21056
			private static readonly IntPtr NativeFieldInfoPtr___9__20_4;

			// Token: 0x04005241 RID: 21057
			private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

			// Token: 0x04005242 RID: 21058
			private static readonly IntPtr NativeFieldInfoPtr___9__26_2;

			// Token: 0x04005243 RID: 21059
			private static readonly IntPtr NativeFieldInfoPtr___9__26_3;

			// Token: 0x04005244 RID: 21060
			private static readonly IntPtr NativeFieldInfoPtr___9__26_7;

			// Token: 0x04005245 RID: 21061
			private static readonly IntPtr NativeFieldInfoPtr___9__26_9;

			// Token: 0x04005246 RID: 21062
			private static readonly IntPtr NativeFieldInfoPtr___9__26_13;

			// Token: 0x04005247 RID: 21063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005248 RID: 21064
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__20_4_Internal_Boolean_MusicMapping_0;

			// Token: 0x04005249 RID: 21065
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__20_1_Internal_Boolean_KeyValuePair_2_String_String_0;

			// Token: 0x0400524A RID: 21066
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__26_2_Internal_Void_Image_0;

			// Token: 0x0400524B RID: 21067
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__26_3_Internal_Void_Image_0;

			// Token: 0x0400524C RID: 21068
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__26_7_Internal_Void_Image_0;

			// Token: 0x0400524D RID: 21069
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__26_9_Internal_String_MusicMapping_0;

			// Token: 0x0400524E RID: 21070
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__26_13_Internal_String_String_0;
		}

		// Token: 0x02000486 RID: 1158
		[ObfuscatedName("MusicGame.UI.MusicGameMapSelectPannel+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x06007D1E RID: 32030 RVA: 0x0023CA14 File Offset: 0x0023AC14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass25_0>.NativeClassPtr);
				MusicGameMapSelectPannel.__c__DisplayClass25_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass25_0>.NativeClassPtr, "x");
				MusicGameMapSelectPannel.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass25_0>.NativeClassPtr, 100663611);
				MusicGameMapSelectPannel.__c__DisplayClass25_0.NativeMethodInfoPtr__RefreshPannel_b__1_Internal_Boolean_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass25_0>.NativeClassPtr, 100663612);
			}

			// Token: 0x06007D1F RID: 32031 RVA: 0x0023CA7C File Offset: 0x0023AC7C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D20 RID: 32032 RVA: 0x0023CAB8 File Offset: 0x0023ACB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshPannel_b__1(MusicGameMappingProfile.MusicMapping y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass25_0.NativeMethodInfoPtr__RefreshPannel_b__1_Internal_Boolean_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007D21 RID: 32033 RVA: 0x00043614 File Offset: 0x00041814
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A5A RID: 10842
			// (get) Token: 0x06007D22 RID: 32034 RVA: 0x0023CB0C File Offset: 0x0023AD0C
			// (set) Token: 0x06007D23 RID: 32035 RVA: 0x0004361D File Offset: 0x0004181D
			public unsafe string x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass25_0.NativeFieldInfoPtr_x);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass25_0.NativeFieldInfoPtr_x), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400524F RID: 21071
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04005250 RID: 21072
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005251 RID: 21073
			private static readonly IntPtr NativeMethodInfoPtr__RefreshPannel_b__1_Internal_Boolean_MusicMapping_0;
		}

		// Token: 0x02000487 RID: 1159
		[ObfuscatedName("MusicGame.UI.MusicGameMapSelectPannel+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x06007D24 RID: 32036 RVA: 0x0023CB34 File Offset: 0x0023AD34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMapSelectPannel>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_musicChapter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "musicChapter");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "data");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_uiElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "uiElement");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "mapLabel");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_isUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "isUnlocked");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_shouldUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "shouldUnlock");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "animator");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "<>9__12");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "<>9__14");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, "<>9__15");
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663613);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663614);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__1_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663615);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663616);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__12_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663617);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__5_Internal_Boolean_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663618);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663619);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__8_Internal_Boolean_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663620);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__10_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663621);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__14_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663622);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663623);
				MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__15_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr, 100663624);
			}

			// Token: 0x06007D25 RID: 32037 RVA: 0x0023CD2C File Offset: 0x0023AF2C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMapSelectPannel.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D26 RID: 32038 RVA: 0x0023CD68 File Offset: 0x0023AF68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19430, XrefRangeEnd = 19432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMapItemEnable_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D27 RID: 32039 RVA: 0x0023CDAC File Offset: 0x0023AFAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19432, XrefRangeEnd = 19443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMapItemEnable_b__1(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__1_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D28 RID: 32040 RVA: 0x0023CDF0 File Offset: 0x0023AFF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19443, XrefRangeEnd = 19458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMapItemEnable_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D29 RID: 32041 RVA: 0x0023CE24 File Offset: 0x0023B024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19458, XrefRangeEnd = 19482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMapItemEnable_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__12_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D2A RID: 32042 RVA: 0x0023CE58 File Offset: 0x0023B058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19482, XrefRangeEnd = 19485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnMapItemEnable_b__5(MusicGameMappingProfile.MusicMapping x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__5_Internal_Boolean_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007D2B RID: 32043 RVA: 0x0023CEAC File Offset: 0x0023B0AC
			[CallerCount(0)]
			public unsafe void _OnMapItemEnable_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D2C RID: 32044 RVA: 0x0023CEF0 File Offset: 0x0023B0F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19485, XrefRangeEnd = 19488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnMapItemEnable_b__8(MusicGameMappingProfile.MusicMapping x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__8_Internal_Boolean_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007D2D RID: 32045 RVA: 0x0023CF44 File Offset: 0x0023B144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19488, XrefRangeEnd = 19549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMapItemEnable_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__10_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D2E RID: 32046 RVA: 0x0023CF78 File Offset: 0x0023B178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19549, XrefRangeEnd = 19556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMapItemEnable_b__14()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__14_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D2F RID: 32047 RVA: 0x0023CFAC File Offset: 0x0023B1AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19556, XrefRangeEnd = 19568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMapItemEnable_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D30 RID: 32048 RVA: 0x0023CFE0 File Offset: 0x0023B1E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19568, XrefRangeEnd = 19576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMapItemEnable_b__15()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnMapItemEnable_b__15_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D31 RID: 32049 RVA: 0x0004363C File Offset: 0x0004183C
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A5B RID: 10843
			// (get) Token: 0x06007D32 RID: 32050 RVA: 0x0023D014 File Offset: 0x0023B214
			// (set) Token: 0x06007D33 RID: 32051 RVA: 0x00043645 File Offset: 0x00041845
			public MusicGameChapterProfile.MusicChapter musicChapter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_musicChapter);
					return new MusicGameChapterProfile.MusicChapter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_musicChapter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002A5C RID: 10844
			// (get) Token: 0x06007D34 RID: 32052 RVA: 0x0023D044 File Offset: 0x0023B244
			// (set) Token: 0x06007D35 RID: 32053 RVA: 0x00043673 File Offset: 0x00041873
			public MusicGameMappingProfile.MusicMapping data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_data);
					return new MusicGameMappingProfile.MusicMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002A5D RID: 10845
			// (get) Token: 0x06007D36 RID: 32054 RVA: 0x0023D074 File Offset: 0x0023B274
			// (set) Token: 0x06007D37 RID: 32055 RVA: 0x000436A1 File Offset: 0x000418A1
			public unsafe MusicGameMapSelectPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMapSelectPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A5E RID: 10846
			// (get) Token: 0x06007D38 RID: 32056 RVA: 0x0023D0A4 File Offset: 0x0023B2A4
			// (set) Token: 0x06007D39 RID: 32057 RVA: 0x000436C0 File Offset: 0x000418C0
			public unsafe UIElementCluster uiElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_uiElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_uiElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A5F RID: 10847
			// (get) Token: 0x06007D3A RID: 32058 RVA: 0x0023D0D4 File Offset: 0x0023B2D4
			// (set) Token: 0x06007D3B RID: 32059 RVA: 0x000436DF File Offset: 0x000418DF
			public unsafe string mapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_mapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002A60 RID: 10848
			// (get) Token: 0x06007D3C RID: 32060 RVA: 0x0023D0FC File Offset: 0x0023B2FC
			// (set) Token: 0x06007D3D RID: 32061 RVA: 0x000436FE File Offset: 0x000418FE
			public unsafe bool isUnlocked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_isUnlocked);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_isUnlocked)) = value;
				}
			}

			// Token: 0x17002A61 RID: 10849
			// (get) Token: 0x06007D3E RID: 32062 RVA: 0x0023D124 File Offset: 0x0023B324
			// (set) Token: 0x06007D3F RID: 32063 RVA: 0x00043719 File Offset: 0x00041919
			public unsafe Il2CppStringArray shouldUnlock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_shouldUnlock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_shouldUnlock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A62 RID: 10850
			// (get) Token: 0x06007D40 RID: 32064 RVA: 0x0023D154 File Offset: 0x0023B354
			// (set) Token: 0x06007D41 RID: 32065 RVA: 0x00043738 File Offset: 0x00041938
			public unsafe Animator animator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_animator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A63 RID: 10851
			// (get) Token: 0x06007D42 RID: 32066 RVA: 0x0023D184 File Offset: 0x0023B384
			// (set) Token: 0x06007D43 RID: 32067 RVA: 0x00043757 File Offset: 0x00041957
			public unsafe Action __9__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A64 RID: 10852
			// (get) Token: 0x06007D44 RID: 32068 RVA: 0x0023D1B4 File Offset: 0x0023B3B4
			// (set) Token: 0x06007D45 RID: 32069 RVA: 0x00043776 File Offset: 0x00041976
			public unsafe Action __9__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__14);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__14), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A65 RID: 10853
			// (get) Token: 0x06007D46 RID: 32070 RVA: 0x0023D1E4 File Offset: 0x0023B3E4
			// (set) Token: 0x06007D47 RID: 32071 RVA: 0x00043795 File Offset: 0x00041995
			public unsafe Action __9__15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__15);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMapSelectPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___9__15), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005252 RID: 21074
			private static readonly IntPtr NativeFieldInfoPtr_musicChapter;

			// Token: 0x04005253 RID: 21075
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04005254 RID: 21076
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005255 RID: 21077
			private static readonly IntPtr NativeFieldInfoPtr_uiElement;

			// Token: 0x04005256 RID: 21078
			private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

			// Token: 0x04005257 RID: 21079
			private static readonly IntPtr NativeFieldInfoPtr_isUnlocked;

			// Token: 0x04005258 RID: 21080
			private static readonly IntPtr NativeFieldInfoPtr_shouldUnlock;

			// Token: 0x04005259 RID: 21081
			private static readonly IntPtr NativeFieldInfoPtr_animator;

			// Token: 0x0400525A RID: 21082
			private static readonly IntPtr NativeFieldInfoPtr___9__12;

			// Token: 0x0400525B RID: 21083
			private static readonly IntPtr NativeFieldInfoPtr___9__14;

			// Token: 0x0400525C RID: 21084
			private static readonly IntPtr NativeFieldInfoPtr___9__15;

			// Token: 0x0400525D RID: 21085
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400525E RID: 21086
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__0_Internal_Void_Image_0;

			// Token: 0x0400525F RID: 21087
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__1_Internal_Void_RectTransform_0;

			// Token: 0x04005260 RID: 21088
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__4_Internal_Void_0;

			// Token: 0x04005261 RID: 21089
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__12_Internal_Void_0;

			// Token: 0x04005262 RID: 21090
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__5_Internal_Boolean_MusicMapping_0;

			// Token: 0x04005263 RID: 21091
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__6_Internal_Void_Image_0;

			// Token: 0x04005264 RID: 21092
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__8_Internal_Boolean_MusicMapping_0;

			// Token: 0x04005265 RID: 21093
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__10_Internal_Void_0;

			// Token: 0x04005266 RID: 21094
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__14_Internal_Void_0;

			// Token: 0x04005267 RID: 21095
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__11_Internal_Void_0;

			// Token: 0x04005268 RID: 21096
			private static readonly IntPtr NativeMethodInfoPtr__OnMapItemEnable_b__15_Internal_Void_0;
		}
	}
}
