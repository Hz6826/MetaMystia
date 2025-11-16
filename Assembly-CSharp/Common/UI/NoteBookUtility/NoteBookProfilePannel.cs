using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x0200039E RID: 926
	public class NoteBookProfilePannel : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x06006FBA RID: 28602 RVA: 0x002126C0 File Offset: 0x002108C0
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookProfilePannel()
		{
			Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookProfilePannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr);
			NoteBookProfilePannel.NativeFieldInfoPtr_FINAL_MISSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "FINAL_MISSION");
			NoteBookProfilePannel.NativeFieldInfoPtr_GotoPreviousBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "GotoPreviousBtn");
			NoteBookProfilePannel.NativeFieldInfoPtr_GotoNextBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "GotoNextBtn");
			NoteBookProfilePannel.NativeFieldInfoPtr_currentPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "currentPage");
			NoteBookProfilePannel.NativeFieldInfoPtr_wholePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "wholePage");
			NoteBookProfilePannel.NativeFieldInfoPtr_mystiaPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "mystiaPic");
			NoteBookProfilePannel.NativeFieldInfoPtr_defaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "defaultPosition");
			NoteBookProfilePannel.NativeFieldInfoPtr_titles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "titles");
			NoteBookProfilePannel.NativeFieldInfoPtr_ScrollList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "ScrollList");
			NoteBookProfilePannel.NativeFieldInfoPtr_defaultPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "defaultPic");
			NoteBookProfilePannel.NativeFieldInfoPtr_title5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "title5");
			NoteBookProfilePannel.NativeFieldInfoPtr_SubPanelCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "SubPanelCollection");
			NoteBookProfilePannel.NativeFieldInfoPtr_m_ActiveSubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "m_ActiveSubPannel");
			NoteBookProfilePannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "m_AnimatedPortrayalCoroutine");
			NoteBookProfilePannel.NativeFieldInfoPtr_m_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, "m_Current");
			NoteBookProfilePannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686135);
			NoteBookProfilePannel.NativeMethodInfoPtr_set_CurrentPage_Public_set_Void_ProfileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686136);
			NoteBookProfilePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686137);
			NoteBookProfilePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686138);
			NoteBookProfilePannel.NativeMethodInfoPtr_UpdateCurrent_Private_Void_ProfileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686139);
			NoteBookProfilePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686140);
			NoteBookProfilePannel.NativeMethodInfoPtr_SecondarySwitchStarted_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686141);
			NoteBookProfilePannel.NativeMethodInfoPtr_PageTurning_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686142);
			NoteBookProfilePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686143);
			NoteBookProfilePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686144);
			NoteBookProfilePannel.NativeMethodInfoPtr__OnPanelInitialize_b__20_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686145);
			NoteBookProfilePannel.NativeMethodInfoPtr__OnPanelInitialize_b__20_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr, 100686146);
		}

		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x06006FBB RID: 28603 RVA: 0x0021290C File Offset: 0x00210B0C
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfilePannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002665 RID: 9829
		// (set) Token: 0x06006FBC RID: 28604 RVA: 0x00212954 File Offset: 0x00210B54
		public unsafe NoteBookProfilePannel.ProfileType CurrentPage
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfilePannel.NativeMethodInfoPtr_set_CurrentPage_Public_set_Void_ProfileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x00212994 File Offset: 0x00210B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279736, XrefRangeEnd = 279764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfilePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x002129D0 File Offset: 0x00210BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279764, XrefRangeEnd = 279793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfilePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x00212A0C File Offset: 0x00210C0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 279809, RefRangeEnd = 279816, XrefRangeStart = 279793, XrefRangeEnd = 279809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrent(NoteBookProfilePannel.ProfileType profileType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref profileType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfilePannel.NativeMethodInfoPtr_UpdateCurrent_Private_Void_ProfileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC0 RID: 28608 RVA: 0x00212A4C File Offset: 0x00210C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279816, XrefRangeEnd = 279820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfilePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC1 RID: 28609 RVA: 0x00212A88 File Offset: 0x00210C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279820, XrefRangeEnd = 279826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SecondarySwitchStarted(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfilePannel.NativeMethodInfoPtr_SecondarySwitchStarted_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC2 RID: 28610 RVA: 0x00212AD0 File Offset: 0x00210CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279826, XrefRangeEnd = 279829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PageTurning(bool turnLeft = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref turnLeft;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfilePannel.NativeMethodInfoPtr_PageTurning_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x00212B10 File Offset: 0x00210D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279829, XrefRangeEnd = 279843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfilePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x00212B4C File Offset: 0x00210D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279843, XrefRangeEnd = 279846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookProfilePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookProfilePannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfilePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x00212B88 File Offset: 0x00210D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279846, XrefRangeEnd = 279847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__20_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfilePannel.NativeMethodInfoPtr__OnPanelInitialize_b__20_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x00212BBC File Offset: 0x00210DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279847, XrefRangeEnd = 279848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__20_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfilePannel.NativeMethodInfoPtr__OnPanelInitialize_b__20_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x0003CAA1 File Offset: 0x0003ACA1
		public NoteBookProfilePannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x06006FC8 RID: 28616 RVA: 0x00212BF0 File Offset: 0x00210DF0
		// (set) Token: 0x06006FC9 RID: 28617 RVA: 0x0003CAAA File Offset: 0x0003ACAA
		public unsafe static string FINAL_MISSION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoteBookProfilePannel.NativeFieldInfoPtr_FINAL_MISSION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteBookProfilePannel.NativeFieldInfoPtr_FINAL_MISSION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x06006FCA RID: 28618 RVA: 0x00212C10 File Offset: 0x00210E10
		// (set) Token: 0x06006FCB RID: 28619 RVA: 0x0003CABC File Offset: 0x0003ACBC
		public unsafe UIButtonBase GotoPreviousBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_GotoPreviousBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_GotoPreviousBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x06006FCC RID: 28620 RVA: 0x00212C40 File Offset: 0x00210E40
		// (set) Token: 0x06006FCD RID: 28621 RVA: 0x0003CADB File Offset: 0x0003ACDB
		public unsafe UIButtonBase GotoNextBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_GotoNextBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_GotoNextBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x06006FCE RID: 28622 RVA: 0x00212C70 File Offset: 0x00210E70
		// (set) Token: 0x06006FCF RID: 28623 RVA: 0x0003CAFA File Offset: 0x0003ACFA
		public unsafe TextMeshProUGUI currentPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_currentPage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_currentPage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x06006FD0 RID: 28624 RVA: 0x00212CA0 File Offset: 0x00210EA0
		// (set) Token: 0x06006FD1 RID: 28625 RVA: 0x0003CB19 File Offset: 0x0003AD19
		public unsafe TextMeshProUGUI wholePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_wholePage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_wholePage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x06006FD2 RID: 28626 RVA: 0x00212CD0 File Offset: 0x00210ED0
		// (set) Token: 0x06006FD3 RID: 28627 RVA: 0x0003CB38 File Offset: 0x0003AD38
		public unsafe Image mystiaPic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_mystiaPic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_mystiaPic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x06006FD4 RID: 28628 RVA: 0x00212D00 File Offset: 0x00210F00
		// (set) Token: 0x06006FD5 RID: 28629 RVA: 0x0003CB57 File Offset: 0x0003AD57
		public unsafe RectTransform defaultPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_defaultPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_defaultPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x06006FD6 RID: 28630 RVA: 0x00212D30 File Offset: 0x00210F30
		// (set) Token: 0x06006FD7 RID: 28631 RVA: 0x0003CB76 File Offset: 0x0003AD76
		public unsafe RectTransform titles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_titles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_titles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x06006FD8 RID: 28632 RVA: 0x00212D60 File Offset: 0x00210F60
		// (set) Token: 0x06006FD9 RID: 28633 RVA: 0x0003CB95 File Offset: 0x0003AD95
		public unsafe AdpScrollListAdaptiveComponent ScrollList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_ScrollList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpScrollListAdaptiveComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_ScrollList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x06006FDA RID: 28634 RVA: 0x00212D90 File Offset: 0x00210F90
		// (set) Token: 0x06006FDB RID: 28635 RVA: 0x0003CBB4 File Offset: 0x0003ADB4
		public unsafe Sprite defaultPic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_defaultPic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_defaultPic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x06006FDC RID: 28636 RVA: 0x00212DC0 File Offset: 0x00210FC0
		// (set) Token: 0x06006FDD RID: 28637 RVA: 0x0003CBD3 File Offset: 0x0003ADD3
		public unsafe GameObject title5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_title5);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_title5), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x06006FDE RID: 28638 RVA: 0x00212DF0 File Offset: 0x00210FF0
		// (set) Token: 0x06006FDF RID: 28639 RVA: 0x0003CBF2 File Offset: 0x0003ADF2
		public unsafe Il2CppReferenceArray<UIPanelExtern> SubPanelCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_SubPanelCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIPanelExtern>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_SubPanelCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x06006FE0 RID: 28640 RVA: 0x00212E20 File Offset: 0x00211020
		// (set) Token: 0x06006FE1 RID: 28641 RVA: 0x0003CC11 File Offset: 0x0003AE11
		public unsafe UIPanelExtern m_ActiveSubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_m_ActiveSubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanelExtern>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_m_ActiveSubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x06006FE2 RID: 28642 RVA: 0x00212E50 File Offset: 0x00211050
		// (set) Token: 0x06006FE3 RID: 28643 RVA: 0x0003CC30 File Offset: 0x0003AE30
		public unsafe Coroutine m_AnimatedPortrayalCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x06006FE4 RID: 28644 RVA: 0x00212E80 File Offset: 0x00211080
		// (set) Token: 0x06006FE5 RID: 28645 RVA: 0x0003CC4F File Offset: 0x0003AE4F
		public unsafe NoteBookProfilePannel.ProfileType m_Current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_m_Current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfilePannel.NativeFieldInfoPtr_m_Current)) = value;
			}
		}

		// Token: 0x04004A00 RID: 18944
		private static readonly IntPtr NativeFieldInfoPtr_FINAL_MISSION;

		// Token: 0x04004A01 RID: 18945
		private static readonly IntPtr NativeFieldInfoPtr_GotoPreviousBtn;

		// Token: 0x04004A02 RID: 18946
		private static readonly IntPtr NativeFieldInfoPtr_GotoNextBtn;

		// Token: 0x04004A03 RID: 18947
		private static readonly IntPtr NativeFieldInfoPtr_currentPage;

		// Token: 0x04004A04 RID: 18948
		private static readonly IntPtr NativeFieldInfoPtr_wholePage;

		// Token: 0x04004A05 RID: 18949
		private static readonly IntPtr NativeFieldInfoPtr_mystiaPic;

		// Token: 0x04004A06 RID: 18950
		private static readonly IntPtr NativeFieldInfoPtr_defaultPosition;

		// Token: 0x04004A07 RID: 18951
		private static readonly IntPtr NativeFieldInfoPtr_titles;

		// Token: 0x04004A08 RID: 18952
		private static readonly IntPtr NativeFieldInfoPtr_ScrollList;

		// Token: 0x04004A09 RID: 18953
		private static readonly IntPtr NativeFieldInfoPtr_defaultPic;

		// Token: 0x04004A0A RID: 18954
		private static readonly IntPtr NativeFieldInfoPtr_title5;

		// Token: 0x04004A0B RID: 18955
		private static readonly IntPtr NativeFieldInfoPtr_SubPanelCollection;

		// Token: 0x04004A0C RID: 18956
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveSubPannel;

		// Token: 0x04004A0D RID: 18957
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine;

		// Token: 0x04004A0E RID: 18958
		private static readonly IntPtr NativeFieldInfoPtr_m_Current;

		// Token: 0x04004A0F RID: 18959
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004A10 RID: 18960
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPage_Public_set_Void_ProfileType_0;

		// Token: 0x04004A11 RID: 18961
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004A12 RID: 18962
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004A13 RID: 18963
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrent_Private_Void_ProfileType_0;

		// Token: 0x04004A14 RID: 18964
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004A15 RID: 18965
		private static readonly IntPtr NativeMethodInfoPtr_SecondarySwitchStarted_Private_Void_CallbackContext_0;

		// Token: 0x04004A16 RID: 18966
		private static readonly IntPtr NativeMethodInfoPtr_PageTurning_Private_Void_Boolean_0;

		// Token: 0x04004A17 RID: 18967
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004A18 RID: 18968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004A19 RID: 18969
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__20_0_Private_Void_0;

		// Token: 0x04004A1A RID: 18970
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__20_1_Private_Void_0;

		// Token: 0x02000EEF RID: 3823
		public enum ProfileType : short
		{
			// Token: 0x0400A9FF RID: 43519
			Status,
			// Token: 0x0400AA00 RID: 43520
			Izakaya,
			// Token: 0x0400AA01 RID: 43521
			AchievementBadge,
			// Token: 0x0400AA02 RID: 43522
			Null
		}
	}
}
