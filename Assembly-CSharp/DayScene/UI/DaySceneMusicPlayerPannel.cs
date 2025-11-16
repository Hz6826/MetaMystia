using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000C6 RID: 198
	public class DaySceneMusicPlayerPannel : UIPanel
	{
		// Token: 0x060016F4 RID: 5876 RVA: 0x000EB4B8 File Offset: 0x000E96B8
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneMusicPlayerPannel()
		{
			Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneMusicPlayerPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr);
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_recordElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "recordElement");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_emptyElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "emptyElement");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_recordPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "recordPannel");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "scroller");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_deselectedImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "deselectedImages");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_selectedImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "selectedImages");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_SubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "SubPannel");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_AllInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "m_AllInstances");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_ArrayBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "m_ArrayBuffer");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_RecordGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "m_RecordGroup");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_EmptyElementTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "m_EmptyElementTransform");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_UpdateHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "m_UpdateHandle");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr__UnlockedCD_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "<UnlockedCD>k__BackingField");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr__CurrentSelectedRecordIzakayaMusicPackageID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "<CurrentSelectedRecordIzakayaMusicPackageID>k__BackingField");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr__CurrentSelectedRecordIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "<CurrentSelectedRecordIndex>k__BackingField");
			DaySceneMusicPlayerPannel.NativeFieldInfoPtr__CurrentSelectedRecordInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "<CurrentSelectedRecordInfo>k__BackingField");
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_get_UnlockedCD_Public_get_List_1_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667461);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_set_UnlockedCD_Private_set_Void_List_1_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667462);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_get_CurrentSelectedRecordIzakayaMusicPackageID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667463);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_set_CurrentSelectedRecordIzakayaMusicPackageID_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667464);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_get_CurrentSelectedRecordIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667465);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_set_CurrentSelectedRecordIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667466);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_get_CurrentSelectedRecordInfo_Public_get_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667467);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_set_CurrentSelectedRecordInfo_Private_set_Void_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667468);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_UpdateCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667469);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667470);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_ProcessRecordElement_Private_Void_UIElementCluster_Record_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667471);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_OpenSubPannel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667472);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667473);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667474);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667475);
			DaySceneMusicPlayerPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, 100667476);
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x000EB768 File Offset: 0x000E9968
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x000EB7A8 File Offset: 0x000E99A8
		public unsafe List<Record> UnlockedCD
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_get_UnlockedCD_Public_get_List_1_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Record>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_set_UnlockedCD_Private_set_Void_List_1_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x000EB7EC File Offset: 0x000E99EC
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x000EB828 File Offset: 0x000E9A28
		public unsafe int CurrentSelectedRecordIzakayaMusicPackageID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_get_CurrentSelectedRecordIzakayaMusicPackageID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_set_CurrentSelectedRecordIzakayaMusicPackageID_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x000EB868 File Offset: 0x000E9A68
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x000EB8A4 File Offset: 0x000E9AA4
		public unsafe int CurrentSelectedRecordIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_get_CurrentSelectedRecordIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_set_CurrentSelectedRecordIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x000EB8E4 File Offset: 0x000E9AE4
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x000EB924 File Offset: 0x000E9B24
		public unsafe Record CurrentSelectedRecordInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_get_CurrentSelectedRecordInfo_Public_get_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Record>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64879, XrefRangeEnd = 64880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_set_CurrentSelectedRecordInfo_Private_set_Void_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x000EB968 File Offset: 0x000E9B68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 47033, RefRangeEnd = 47038, XrefRangeStart = 47033, XrefRangeEnd = 47038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_UpdateCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x000EB99C File Offset: 0x000E9B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64880, XrefRangeEnd = 64900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMusicPlayerPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x000EB9D8 File Offset: 0x000E9BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64900, XrefRangeEnd = 64974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessRecordElement(UIElementCluster uIElementCluster, Record recordInfo, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uIElementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recordInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_ProcessRecordElement_Private_Void_UIElementCluster_Record_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000EBA3C File Offset: 0x000E9C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64974, XrefRangeEnd = 64983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenSubPannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr_OpenSubPannel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x000EBA70 File Offset: 0x000E9C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64983, XrefRangeEnd = 65083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMusicPlayerPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x000EBAAC File Offset: 0x000E9CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65083, XrefRangeEnd = 65088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMusicPlayerPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x000EBAE8 File Offset: 0x000E9CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65088, XrefRangeEnd = 65104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMusicPlayerPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x000EBB24 File Offset: 0x000E9D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65104, XrefRangeEnd = 65124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneMusicPlayerPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0000E501 File Offset: 0x0000C701
		public DaySceneMusicPlayerPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x000EBB60 File Offset: 0x000E9D60
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x0000E50A File Offset: 0x0000C70A
		public unsafe GameObject recordElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_recordElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_recordElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x000EBB90 File Offset: 0x000E9D90
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x0000E529 File Offset: 0x0000C729
		public unsafe GameObject emptyElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_emptyElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_emptyElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x000EBBC0 File Offset: 0x000E9DC0
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x0000E548 File Offset: 0x0000C748
		public unsafe RectTransform recordPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_recordPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_recordPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x000EBBF0 File Offset: 0x000E9DF0
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x0000E567 File Offset: 0x0000C767
		public unsafe AdpScrollListFixedComponent scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpScrollListFixedComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x000EBC20 File Offset: 0x000E9E20
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x0000E586 File Offset: 0x0000C786
		public unsafe Il2CppReferenceArray<Sprite> deselectedImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_deselectedImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_deselectedImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x000EBC50 File Offset: 0x000E9E50
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x0000E5A5 File Offset: 0x0000C7A5
		public unsafe Il2CppReferenceArray<Sprite> selectedImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_selectedImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_selectedImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x000EBC80 File Offset: 0x000E9E80
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x0000E5C4 File Offset: 0x0000C7C4
		public unsafe DaySceneMusicPlayerSubPannel SubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_SubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneMusicPlayerSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_SubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x000EBCB0 File Offset: 0x000E9EB0
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x0000E5E3 File Offset: 0x0000C7E3
		public unsafe List<GameObject> m_AllInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_AllInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_AllInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x000EBCE0 File Offset: 0x000E9EE0
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x0000E602 File Offset: 0x0000C802
		public unsafe Il2CppReferenceArray<List<UILogicalUnit>> m_ArrayBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_ArrayBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<UILogicalUnit>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_ArrayBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x000EBD10 File Offset: 0x000E9F10
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x0000E621 File Offset: 0x0000C821
		public unsafe UILogicalGroupT<Record> m_RecordGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_RecordGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<Record>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_RecordGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x000EBD40 File Offset: 0x000E9F40
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x0000E640 File Offset: 0x0000C840
		public unsafe Transform m_EmptyElementTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_EmptyElementTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_EmptyElementTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x000EBD70 File Offset: 0x000E9F70
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x0000E65F File Offset: 0x0000C85F
		public unsafe Action m_UpdateHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_UpdateHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr_m_UpdateHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x000EBDA0 File Offset: 0x000E9FA0
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x0000E67E File Offset: 0x0000C87E
		public unsafe List<Record> _UnlockedCD_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr__UnlockedCD_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Record>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr__UnlockedCD_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x000EBDD0 File Offset: 0x000E9FD0
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x0000E69D File Offset: 0x0000C89D
		public unsafe int _CurrentSelectedRecordIzakayaMusicPackageID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr__CurrentSelectedRecordIzakayaMusicPackageID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr__CurrentSelectedRecordIzakayaMusicPackageID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x000EBDF8 File Offset: 0x000E9FF8
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		public unsafe int _CurrentSelectedRecordIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr__CurrentSelectedRecordIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr__CurrentSelectedRecordIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x000EBE20 File Offset: 0x000EA020
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x0000E6D3 File Offset: 0x0000C8D3
		public unsafe Record _CurrentSelectedRecordInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr__CurrentSelectedRecordInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Record>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.NativeFieldInfoPtr__CurrentSelectedRecordInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeFieldInfoPtr_recordElement;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeFieldInfoPtr_emptyElement;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeFieldInfoPtr_recordPannel;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeFieldInfoPtr_scroller;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeFieldInfoPtr_deselectedImages;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeFieldInfoPtr_selectedImages;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeFieldInfoPtr_SubPannel;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeFieldInfoPtr_m_AllInstances;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeFieldInfoPtr_m_ArrayBuffer;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeFieldInfoPtr_m_RecordGroup;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeFieldInfoPtr_m_EmptyElementTransform;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateHandle;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeFieldInfoPtr__UnlockedCD_k__BackingField;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSelectedRecordIzakayaMusicPackageID_k__BackingField;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSelectedRecordIndex_k__BackingField;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSelectedRecordInfo_k__BackingField;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockedCD_Public_get_List_1_Record_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_set_UnlockedCD_Private_set_Void_List_1_Record_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectedRecordIzakayaMusicPackageID_Public_get_Int32_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSelectedRecordIzakayaMusicPackageID_Private_set_Void_Int32_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectedRecordIndex_Public_get_Int32_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSelectedRecordIndex_Private_set_Void_Int32_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectedRecordInfo_Public_get_Record_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSelectedRecordInfo_Private_set_Void_Record_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCheck_Public_Void_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRecordElement_Private_Void_UIElementCluster_Record_Int32_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubPannel_Private_Void_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200065B RID: 1627
		[ObfuscatedName("DayScene.UI.DaySceneMusicPlayerPannel+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x06009447 RID: 37959 RVA: 0x0027FD4C File Offset: 0x0027DF4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr);
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_randomNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, "randomNum");
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, "currentIndex");
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, "interactable");
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_currentCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, "currentCluster");
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_recordInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, "recordInfo");
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_izakayaMusicPackageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, "izakayaMusicPackageID");
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_izakayaMusicIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, "izakayaMusicIndex");
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_currentInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, "currentInfo");
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_selectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, "selectionIndicator");
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, 100667477);
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeMethodInfoPtr__ProcessRecordElement_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, 100667478);
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, 100667479);
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, 100667480);
				DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr, 100667481);
			}

			// Token: 0x06009448 RID: 37960 RVA: 0x0027FEA4 File Offset: 0x0027E0A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009449 RID: 37961 RVA: 0x0027FEE0 File Offset: 0x0027E0E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64834, XrefRangeEnd = 64838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessRecordElement_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeMethodInfoPtr__ProcessRecordElement_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600944A RID: 37962 RVA: 0x0027FF24 File Offset: 0x0027E124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64838, XrefRangeEnd = 64856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600944B RID: 37963 RVA: 0x0027FF58 File Offset: 0x0027E158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64856, XrefRangeEnd = 64859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600944C RID: 37964 RVA: 0x0027FF8C File Offset: 0x0027E18C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64859, XrefRangeEnd = 64874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600944D RID: 37965 RVA: 0x0005029D File Offset: 0x0004E49D
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700314C RID: 12620
			// (get) Token: 0x0600944E RID: 37966 RVA: 0x0027FFC0 File Offset: 0x0027E1C0
			// (set) Token: 0x0600944F RID: 37967 RVA: 0x000502A6 File Offset: 0x0004E4A6
			public unsafe DaySceneMusicPlayerPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneMusicPlayerPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700314D RID: 12621
			// (get) Token: 0x06009450 RID: 37968 RVA: 0x0027FFF0 File Offset: 0x0027E1F0
			// (set) Token: 0x06009451 RID: 37969 RVA: 0x000502C5 File Offset: 0x0004E4C5
			public unsafe int randomNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_randomNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_randomNum)) = value;
				}
			}

			// Token: 0x1700314E RID: 12622
			// (get) Token: 0x06009452 RID: 37970 RVA: 0x00280018 File Offset: 0x0027E218
			// (set) Token: 0x06009453 RID: 37971 RVA: 0x000502E0 File Offset: 0x0004E4E0
			public unsafe int currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_currentIndex)) = value;
				}
			}

			// Token: 0x1700314F RID: 12623
			// (get) Token: 0x06009454 RID: 37972 RVA: 0x00280040 File Offset: 0x0027E240
			// (set) Token: 0x06009455 RID: 37973 RVA: 0x000502FB File Offset: 0x0004E4FB
			public unsafe UIButtonSimple interactable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_interactable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_interactable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003150 RID: 12624
			// (get) Token: 0x06009456 RID: 37974 RVA: 0x00280070 File Offset: 0x0027E270
			// (set) Token: 0x06009457 RID: 37975 RVA: 0x0005031A File Offset: 0x0004E51A
			public unsafe UIElementCluster currentCluster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_currentCluster);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_currentCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003151 RID: 12625
			// (get) Token: 0x06009458 RID: 37976 RVA: 0x002800A0 File Offset: 0x0027E2A0
			// (set) Token: 0x06009459 RID: 37977 RVA: 0x00050339 File Offset: 0x0004E539
			public unsafe Record recordInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_recordInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Record>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_recordInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003152 RID: 12626
			// (get) Token: 0x0600945A RID: 37978 RVA: 0x002800D0 File Offset: 0x0027E2D0
			// (set) Token: 0x0600945B RID: 37979 RVA: 0x00050358 File Offset: 0x0004E558
			public unsafe int izakayaMusicPackageID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_izakayaMusicPackageID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_izakayaMusicPackageID)) = value;
				}
			}

			// Token: 0x17003153 RID: 12627
			// (get) Token: 0x0600945C RID: 37980 RVA: 0x002800F8 File Offset: 0x0027E2F8
			// (set) Token: 0x0600945D RID: 37981 RVA: 0x00050373 File Offset: 0x0004E573
			public unsafe int izakayaMusicIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_izakayaMusicIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_izakayaMusicIndex)) = value;
				}
			}

			// Token: 0x17003154 RID: 12628
			// (get) Token: 0x0600945E RID: 37982 RVA: 0x00280120 File Offset: 0x0027E320
			// (set) Token: 0x0600945F RID: 37983 RVA: 0x0005038E File Offset: 0x0004E58E
			public unsafe Record currentInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_currentInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Record>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_currentInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003155 RID: 12629
			// (get) Token: 0x06009460 RID: 37984 RVA: 0x00280150 File Offset: 0x0027E350
			// (set) Token: 0x06009461 RID: 37985 RVA: 0x000503AD File Offset: 0x0004E5AD
			public unsafe GameObject selectionIndicator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_selectionIndicator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass30_0.NativeFieldInfoPtr_selectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006038 RID: 24632
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006039 RID: 24633
			private static readonly IntPtr NativeFieldInfoPtr_randomNum;

			// Token: 0x0400603A RID: 24634
			private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

			// Token: 0x0400603B RID: 24635
			private static readonly IntPtr NativeFieldInfoPtr_interactable;

			// Token: 0x0400603C RID: 24636
			private static readonly IntPtr NativeFieldInfoPtr_currentCluster;

			// Token: 0x0400603D RID: 24637
			private static readonly IntPtr NativeFieldInfoPtr_recordInfo;

			// Token: 0x0400603E RID: 24638
			private static readonly IntPtr NativeFieldInfoPtr_izakayaMusicPackageID;

			// Token: 0x0400603F RID: 24639
			private static readonly IntPtr NativeFieldInfoPtr_izakayaMusicIndex;

			// Token: 0x04006040 RID: 24640
			private static readonly IntPtr NativeFieldInfoPtr_currentInfo;

			// Token: 0x04006041 RID: 24641
			private static readonly IntPtr NativeFieldInfoPtr_selectionIndicator;

			// Token: 0x04006042 RID: 24642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006043 RID: 24643
			private static readonly IntPtr NativeMethodInfoPtr__ProcessRecordElement_b__0_Internal_Void_Image_0;

			// Token: 0x04006044 RID: 24644
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04006045 RID: 24645
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

			// Token: 0x04006046 RID: 24646
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_2;
		}

		// Token: 0x0200065C RID: 1628
		[ObfuscatedName("DayScene.UI.DaySceneMusicPlayerPannel+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x06009462 RID: 37986 RVA: 0x00280180 File Offset: 0x0027E380
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass32_0>.NativeClassPtr);
				DaySceneMusicPlayerPannel.__c__DisplayClass32_0.NativeFieldInfoPtr_finalCd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass32_0>.NativeClassPtr, "finalCd");
				DaySceneMusicPlayerPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass32_0>.NativeClassPtr, 100667482);
				DaySceneMusicPlayerPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass32_0>.NativeClassPtr, 100667483);
			}

			// Token: 0x06009463 RID: 37987 RVA: 0x002801E8 File Offset: 0x0027E3E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009464 RID: 37988 RVA: 0x00280224 File Offset: 0x0027E424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64874, XrefRangeEnd = 64878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009465 RID: 37989 RVA: 0x000503CC File Offset: 0x0004E5CC
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003156 RID: 12630
			// (get) Token: 0x06009466 RID: 37990 RVA: 0x00280270 File Offset: 0x0027E470
			// (set) Token: 0x06009467 RID: 37991 RVA: 0x000503D5 File Offset: 0x0004E5D5
			public unsafe HashSet<int> finalCd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass32_0.NativeFieldInfoPtr_finalCd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMusicPlayerPannel.__c__DisplayClass32_0.NativeFieldInfoPtr_finalCd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006047 RID: 24647
			private static readonly IntPtr NativeFieldInfoPtr_finalCd;

			// Token: 0x04006048 RID: 24648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006049 RID: 24649
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_Int32_0;
		}

		// Token: 0x0200065D RID: 1629
		[ObfuscatedName("DayScene.UI.DaySceneMusicPlayerPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009468 RID: 37992 RVA: 0x002802A0 File Offset: 0x0027E4A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneMusicPlayerPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c>.NativeClassPtr);
				DaySceneMusicPlayerPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c>.NativeClassPtr, "<>9");
				DaySceneMusicPlayerPannel.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c>.NativeClassPtr, "<>9__32_0");
				DaySceneMusicPlayerPannel.__c.NativeFieldInfoPtr___9__32_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c>.NativeClassPtr, "<>9__32_2");
				DaySceneMusicPlayerPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c>.NativeClassPtr, 100667485);
				DaySceneMusicPlayerPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__32_0_Internal_Int32_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c>.NativeClassPtr, 100667486);
				DaySceneMusicPlayerPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__32_2_Internal_Record_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c>.NativeClassPtr, 100667487);
			}

			// Token: 0x06009469 RID: 37993 RVA: 0x00280344 File Offset: 0x0027E544
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMusicPlayerPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600946A RID: 37994 RVA: 0x00280380 File Offset: 0x0027E580
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__32_0(Record x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__32_0_Internal_Int32_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600946B RID: 37995 RVA: 0x002803D0 File Offset: 0x0027E5D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64878, XrefRangeEnd = 64879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Record _OnPanelOpen_b__32_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMusicPlayerPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__32_2_Internal_Record_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Record>(intPtr3) : null;
			}

			// Token: 0x0600946C RID: 37996 RVA: 0x000503F4 File Offset: 0x0004E5F4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003157 RID: 12631
			// (get) Token: 0x0600946D RID: 37997 RVA: 0x0028041C File Offset: 0x0027E61C
			// (set) Token: 0x0600946E RID: 37998 RVA: 0x000503FD File Offset: 0x0004E5FD
			public unsafe static DaySceneMusicPlayerPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMusicPlayerPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneMusicPlayerPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMusicPlayerPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003158 RID: 12632
			// (get) Token: 0x0600946F RID: 37999 RVA: 0x00280444 File Offset: 0x0027E644
			// (set) Token: 0x06009470 RID: 38000 RVA: 0x0005040F File Offset: 0x0004E60F
			public unsafe static Func<Record, int> __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMusicPlayerPannel.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Record, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMusicPlayerPannel.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003159 RID: 12633
			// (get) Token: 0x06009471 RID: 38001 RVA: 0x0028046C File Offset: 0x0027E66C
			// (set) Token: 0x06009472 RID: 38002 RVA: 0x00050421 File Offset: 0x0004E621
			public unsafe static Func<int, Record> __9__32_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMusicPlayerPannel.__c.NativeFieldInfoPtr___9__32_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Record>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMusicPlayerPannel.__c.NativeFieldInfoPtr___9__32_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400604A RID: 24650
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400604B RID: 24651
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x0400604C RID: 24652
			private static readonly IntPtr NativeFieldInfoPtr___9__32_2;

			// Token: 0x0400604D RID: 24653
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400604E RID: 24654
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__32_0_Internal_Int32_Record_0;

			// Token: 0x0400604F RID: 24655
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__32_2_Internal_Record_Int32_0;
		}
	}
}
