using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000399 RID: 921
	public class NoteBookAlbumGuestSubSubPannel : UISubPanel<NoteBookAlbumGuestSubPannel>
	{
		// Token: 0x06006E46 RID: 28230 RVA: 0x0020E2A4 File Offset: 0x0020C4A4
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookAlbumGuestSubSubPannel()
		{
			Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookAlbumGuestSubSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr);
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_ActionExecutionScheduler");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_Scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "Scroller");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_NormalGuestDetailParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "NormalGuestDetailParent");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpecialGuestDetailParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "SpecialGuestDetailParent");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpecialGuestDetailCompactParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "SpecialGuestDetailCompactParent");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpellCardDetailParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "SpellCardDetailParent");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpellCardDetailCompactParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "SpellCardDetailCompactParent");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_PartnerDetailParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "PartnerDetailParent");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_GuestParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "GuestParent");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_nullGuestParentNameColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "nullGuestParentNameColor");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_nullGuestParentAvatarMaskColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "nullGuestParentAvatarMaskColor");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_NullPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "NullPannel");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_DescriberPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "DescriberPannel");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_NGuestField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "NGuestField");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SGuestField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "SGuestField");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpellField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "SpellField");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_PartnerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "PartnerField");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_ParticularGuestGuestField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "ParticularGuestGuestField");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_AllDescriberPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_AllDescriberPannel");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_NormalGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_NormalGuests");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ParticularSpecialGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_ParticularSpecialGuests");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_Partners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_Partners");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpecialGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_SpecialGuests");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_Spell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_Spell");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_checkRecordedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "checkRecordedCallback");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_currentDescribePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "currentDescribePanel");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_describeDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "describeDataCallback");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_Current");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_NGuestFieldGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_NGuestFieldGroup");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_NormalGuestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_NormalGuestGroup");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_OnSwitchButtonSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_OnSwitchButtonSubmit");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_PanelToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_PanelToken");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ParticularFieldGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_ParticularFieldGroup");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ParticularGuestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_ParticularGuestGroup");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_PartnerFieldGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_PartnerFieldGroup");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_PartnerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_PartnerGroup");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SGuestFieldGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_SGuestFieldGroup");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpecialGuestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_SpecialGuestGroup");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpellCardGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_SpellCardGroup");
			NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpellFieldGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "m_SpellFieldGroup");
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685875);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685876);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685877);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685878);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685879);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_SetParamValue_Private_Void_Func_2_GuestBase_Boolean_CanvasGroup_Action_1_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685880);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_GetDescriberPanel_Private_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685881);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_TValue_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685882);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_TValue_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685883);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685884);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685885);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_Method_Private_StaticVerticalGridScrollListUILogicalGroupT_3_TGuest_UIElementCluster_UIButtonSimple_GridLayoutGroup_List_1_TGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685886);
			NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__43_1_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, 100685887);
		}

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x06006E47 RID: 28231 RVA: 0x0020E6F8 File Offset: 0x0020C8F8
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x0020E740 File Offset: 0x0020C940
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006E49 RID: 28233 RVA: 0x0020E788 File Offset: 0x0020C988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276293, XrefRangeEnd = 276341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E4A RID: 28234 RVA: 0x0020E7C4 File Offset: 0x0020C9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276341, XrefRangeEnd = 276348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E4B RID: 28235 RVA: 0x0020E800 File Offset: 0x0020CA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276348, XrefRangeEnd = 276780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E4C RID: 28236 RVA: 0x0020E83C File Offset: 0x0020CA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276780, XrefRangeEnd = 276784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParamValue(Func<GuestBase, bool> checkRecordedCallback, CanvasGroup currentDescribePanel, Action<GuestBase> describeDataCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(checkRecordedCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentDescribePanel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describeDataCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_SetParamValue_Private_Void_Func_2_GuestBase_Boolean_CanvasGroup_Action_1_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x0020E8A4 File Offset: 0x0020CAA4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 276804, RefRangeEnd = 276809, XrefRangeStart = 276784, XrefRangeEnd = 276804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetDescriberPanel<T>(GameObject parent) where T : LanguageBaseDescriber
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.MethodInfoStoreGeneric_GetDescriberPanel_Private_T_GameObject_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x0020E8F0 File Offset: 0x0020CAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276809, XrefRangeEnd = 276893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled<TValue>(TValue guestData, UIElementCluster cluster, UIButtonSimple button) where TValue : GuestBase
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = guestData;
				intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref guestData;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.MethodInfoStoreGeneric_OnElementEnabled_Private_Void_TValue_UIElementCluster_UIButtonSimple_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06006E4F RID: 28239 RVA: 0x0020E98C File Offset: 0x0020CB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276893, XrefRangeEnd = 276905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementSelected<TValue>(TValue guestData, UIElementCluster cluster, UIButtonSimple button) where TValue : GuestBase
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = guestData;
				intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref guestData;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.MethodInfoStoreGeneric_OnElementSelected_Private_Void_TValue_UIElementCluster_UIButtonSimple_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06006E50 RID: 28240 RVA: 0x0020EA28 File Offset: 0x0020CC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276905, XrefRangeEnd = 276953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E51 RID: 28241 RVA: 0x0020EA64 File Offset: 0x0020CC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276953, XrefRangeEnd = 276993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookAlbumGuestSubSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E52 RID: 28242 RVA: 0x0020EAA0 File Offset: 0x0020CCA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 277009, RefRangeEnd = 277014, XrefRangeStart = 276993, XrefRangeEnd = 277009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<TGuest, UIElementCluster, UIButtonSimple> Method_Private_StaticVerticalGridScrollListUILogicalGroupT_3_TGuest_UIElementCluster_UIButtonSimple_GridLayoutGroup_List_1_TGuest_0<TGuest>(GridLayoutGroup field, List<TGuest> guest) where TGuest : GuestBase
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.MethodInfoStoreGeneric_Method_Private_StaticVerticalGridScrollListUILogicalGroupT_3_TGuest_UIElementCluster_UIButtonSimple_GridLayoutGroup_List_1_TGuest_0<TGuest>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<TGuest, UIElementCluster, UIButtonSimple>>(intPtr3) : null;
		}

		// Token: 0x06006E53 RID: 28243 RVA: 0x0020EB04 File Offset: 0x0020CD04
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__43_1(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__43_1_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E54 RID: 28244 RVA: 0x0003BA1E File Offset: 0x00039C1E
		public NoteBookAlbumGuestSubSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x06006E55 RID: 28245 RVA: 0x0020EB4C File Offset: 0x0020CD4C
		// (set) Token: 0x06006E56 RID: 28246 RVA: 0x0003BA27 File Offset: 0x00039C27
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x06006E57 RID: 28247 RVA: 0x0020EB7C File Offset: 0x0020CD7C
		// (set) Token: 0x06006E58 RID: 28248 RVA: 0x0003BA46 File Offset: 0x00039C46
		public unsafe AdpProgressIndicatorComponent Scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_Scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_Scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x06006E59 RID: 28249 RVA: 0x0020EBAC File Offset: 0x0020CDAC
		// (set) Token: 0x06006E5A RID: 28250 RVA: 0x0003BA65 File Offset: 0x00039C65
		public unsafe GameObject NormalGuestDetailParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_NormalGuestDetailParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_NormalGuestDetailParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x06006E5B RID: 28251 RVA: 0x0020EBDC File Offset: 0x0020CDDC
		// (set) Token: 0x06006E5C RID: 28252 RVA: 0x0003BA84 File Offset: 0x00039C84
		public unsafe GameObject SpecialGuestDetailParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpecialGuestDetailParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpecialGuestDetailParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x06006E5D RID: 28253 RVA: 0x0020EC0C File Offset: 0x0020CE0C
		// (set) Token: 0x06006E5E RID: 28254 RVA: 0x0003BAA3 File Offset: 0x00039CA3
		public unsafe GameObject SpecialGuestDetailCompactParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpecialGuestDetailCompactParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpecialGuestDetailCompactParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x06006E5F RID: 28255 RVA: 0x0020EC3C File Offset: 0x0020CE3C
		// (set) Token: 0x06006E60 RID: 28256 RVA: 0x0003BAC2 File Offset: 0x00039CC2
		public unsafe GameObject SpellCardDetailParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpellCardDetailParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpellCardDetailParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x06006E61 RID: 28257 RVA: 0x0020EC6C File Offset: 0x0020CE6C
		// (set) Token: 0x06006E62 RID: 28258 RVA: 0x0003BAE1 File Offset: 0x00039CE1
		public unsafe GameObject SpellCardDetailCompactParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpellCardDetailCompactParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpellCardDetailCompactParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x06006E63 RID: 28259 RVA: 0x0020EC9C File Offset: 0x0020CE9C
		// (set) Token: 0x06006E64 RID: 28260 RVA: 0x0003BB00 File Offset: 0x00039D00
		public unsafe GameObject PartnerDetailParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_PartnerDetailParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_PartnerDetailParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x06006E65 RID: 28261 RVA: 0x0020ECCC File Offset: 0x0020CECC
		// (set) Token: 0x06006E66 RID: 28262 RVA: 0x0003BB1F File Offset: 0x00039D1F
		public unsafe GameObject GuestParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_GuestParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_GuestParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x06006E67 RID: 28263 RVA: 0x0020ECFC File Offset: 0x0020CEFC
		// (set) Token: 0x06006E68 RID: 28264 RVA: 0x0003BB3E File Offset: 0x00039D3E
		public unsafe Color nullGuestParentNameColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_nullGuestParentNameColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_nullGuestParentNameColor)) = value;
			}
		}

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x06006E69 RID: 28265 RVA: 0x0020ED24 File Offset: 0x0020CF24
		// (set) Token: 0x06006E6A RID: 28266 RVA: 0x0003BB59 File Offset: 0x00039D59
		public unsafe Color nullGuestParentAvatarMaskColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_nullGuestParentAvatarMaskColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_nullGuestParentAvatarMaskColor)) = value;
			}
		}

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x06006E6B RID: 28267 RVA: 0x0020ED4C File Offset: 0x0020CF4C
		// (set) Token: 0x06006E6C RID: 28268 RVA: 0x0003BB74 File Offset: 0x00039D74
		public unsafe CanvasGroup NullPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_NullPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_NullPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x06006E6D RID: 28269 RVA: 0x0020ED7C File Offset: 0x0020CF7C
		// (set) Token: 0x06006E6E RID: 28270 RVA: 0x0003BB93 File Offset: 0x00039D93
		public unsafe CanvasGroup DescriberPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_DescriberPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_DescriberPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x06006E6F RID: 28271 RVA: 0x0020EDAC File Offset: 0x0020CFAC
		// (set) Token: 0x06006E70 RID: 28272 RVA: 0x0003BBB2 File Offset: 0x00039DB2
		public unsafe GridLayoutGroup NGuestField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_NGuestField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_NGuestField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x06006E71 RID: 28273 RVA: 0x0020EDDC File Offset: 0x0020CFDC
		// (set) Token: 0x06006E72 RID: 28274 RVA: 0x0003BBD1 File Offset: 0x00039DD1
		public unsafe GridLayoutGroup SGuestField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SGuestField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SGuestField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x06006E73 RID: 28275 RVA: 0x0020EE0C File Offset: 0x0020D00C
		// (set) Token: 0x06006E74 RID: 28276 RVA: 0x0003BBF0 File Offset: 0x00039DF0
		public unsafe GridLayoutGroup SpellField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpellField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_SpellField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x06006E75 RID: 28277 RVA: 0x0020EE3C File Offset: 0x0020D03C
		// (set) Token: 0x06006E76 RID: 28278 RVA: 0x0003BC0F File Offset: 0x00039E0F
		public unsafe GridLayoutGroup PartnerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_PartnerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_PartnerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x06006E77 RID: 28279 RVA: 0x0020EE6C File Offset: 0x0020D06C
		// (set) Token: 0x06006E78 RID: 28280 RVA: 0x0003BC2E File Offset: 0x00039E2E
		public unsafe GridLayoutGroup ParticularGuestGuestField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_ParticularGuestGuestField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_ParticularGuestGuestField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x06006E79 RID: 28281 RVA: 0x0020EE9C File Offset: 0x0020D09C
		// (set) Token: 0x06006E7A RID: 28282 RVA: 0x0003BC4D File Offset: 0x00039E4D
		public unsafe Dictionary<GameObject, CanvasGroup> m_AllDescriberPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_AllDescriberPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_AllDescriberPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x06006E7B RID: 28283 RVA: 0x0020EECC File Offset: 0x0020D0CC
		// (set) Token: 0x06006E7C RID: 28284 RVA: 0x0003BC6C File Offset: 0x00039E6C
		public unsafe List<NormalGuest> m_NormalGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_NormalGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NormalGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_NormalGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x06006E7D RID: 28285 RVA: 0x0020EEFC File Offset: 0x0020D0FC
		// (set) Token: 0x06006E7E RID: 28286 RVA: 0x0003BC8B File Offset: 0x00039E8B
		public unsafe List<SpecialGuest> m_ParticularSpecialGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ParticularSpecialGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ParticularSpecialGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x06006E7F RID: 28287 RVA: 0x0020EF2C File Offset: 0x0020D12C
		// (set) Token: 0x06006E80 RID: 28288 RVA: 0x0003BCAA File Offset: 0x00039EAA
		public unsafe List<SpecialGuest> m_Partners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_Partners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_Partners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x06006E81 RID: 28289 RVA: 0x0020EF5C File Offset: 0x0020D15C
		// (set) Token: 0x06006E82 RID: 28290 RVA: 0x0003BCC9 File Offset: 0x00039EC9
		public unsafe List<SpecialGuest> m_SpecialGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpecialGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpecialGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x06006E83 RID: 28291 RVA: 0x0020EF8C File Offset: 0x0020D18C
		// (set) Token: 0x06006E84 RID: 28292 RVA: 0x0003BCE8 File Offset: 0x00039EE8
		public unsafe List<SpecialGuest> m_Spell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_Spell);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_Spell), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x06006E85 RID: 28293 RVA: 0x0020EFBC File Offset: 0x0020D1BC
		// (set) Token: 0x06006E86 RID: 28294 RVA: 0x0003BD07 File Offset: 0x00039F07
		public unsafe Func<GuestBase, bool> checkRecordedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_checkRecordedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestBase, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_checkRecordedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x06006E87 RID: 28295 RVA: 0x0020EFEC File Offset: 0x0020D1EC
		// (set) Token: 0x06006E88 RID: 28296 RVA: 0x0003BD26 File Offset: 0x00039F26
		public unsafe CanvasGroup currentDescribePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_currentDescribePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_currentDescribePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x06006E89 RID: 28297 RVA: 0x0020F01C File Offset: 0x0020D21C
		// (set) Token: 0x06006E8A RID: 28298 RVA: 0x0003BD45 File Offset: 0x00039F45
		public unsafe Action<GuestBase> describeDataCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_describeDataCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_describeDataCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x06006E8B RID: 28299 RVA: 0x0020F04C File Offset: 0x0020D24C
		// (set) Token: 0x06006E8C RID: 28300 RVA: 0x0003BD64 File Offset: 0x00039F64
		public unsafe IStaticGridScrollListUILogicalGroup m_Current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_Current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStaticGridScrollListUILogicalGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_Current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x06006E8D RID: 28301 RVA: 0x0020F07C File Offset: 0x0020D27C
		// (set) Token: 0x06006E8E RID: 28302 RVA: 0x0003BD83 File Offset: 0x00039F83
		public unsafe CanvasGroup m_NGuestFieldGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_NGuestFieldGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_NGuestFieldGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x06006E8F RID: 28303 RVA: 0x0020F0AC File Offset: 0x0020D2AC
		// (set) Token: 0x06006E90 RID: 28304 RVA: 0x0003BDA2 File Offset: 0x00039FA2
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<NormalGuest, UIElementCluster, UIButtonSimple> m_NormalGuestGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_NormalGuestGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<NormalGuest, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_NormalGuestGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025DD RID: 9693
		// (get) Token: 0x06006E91 RID: 28305 RVA: 0x0020F0DC File Offset: 0x0020D2DC
		// (set) Token: 0x06006E92 RID: 28306 RVA: 0x0003BDC1 File Offset: 0x00039FC1
		public unsafe Action m_OnSwitchButtonSubmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_OnSwitchButtonSubmit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_OnSwitchButtonSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x06006E93 RID: 28307 RVA: 0x0020F10C File Offset: 0x0020D30C
		// (set) Token: 0x06006E94 RID: 28308 RVA: 0x0003BDE0 File Offset: 0x00039FE0
		public unsafe CancellationTokenSource m_PanelToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_PanelToken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_PanelToken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x06006E95 RID: 28309 RVA: 0x0020F13C File Offset: 0x0020D33C
		// (set) Token: 0x06006E96 RID: 28310 RVA: 0x0003BDFF File Offset: 0x00039FFF
		public unsafe CanvasGroup m_ParticularFieldGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ParticularFieldGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ParticularFieldGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x06006E97 RID: 28311 RVA: 0x0020F16C File Offset: 0x0020D36C
		// (set) Token: 0x06006E98 RID: 28312 RVA: 0x0003BE1E File Offset: 0x0003A01E
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple> m_ParticularGuestGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ParticularGuestGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_ParticularGuestGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x06006E99 RID: 28313 RVA: 0x0020F19C File Offset: 0x0020D39C
		// (set) Token: 0x06006E9A RID: 28314 RVA: 0x0003BE3D File Offset: 0x0003A03D
		public unsafe CanvasGroup m_PartnerFieldGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_PartnerFieldGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_PartnerFieldGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x06006E9B RID: 28315 RVA: 0x0020F1CC File Offset: 0x0020D3CC
		// (set) Token: 0x06006E9C RID: 28316 RVA: 0x0003BE5C File Offset: 0x0003A05C
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple> m_PartnerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_PartnerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_PartnerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x06006E9D RID: 28317 RVA: 0x0020F1FC File Offset: 0x0020D3FC
		// (set) Token: 0x06006E9E RID: 28318 RVA: 0x0003BE7B File Offset: 0x0003A07B
		public unsafe CanvasGroup m_SGuestFieldGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SGuestFieldGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SGuestFieldGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x06006E9F RID: 28319 RVA: 0x0020F22C File Offset: 0x0020D42C
		// (set) Token: 0x06006EA0 RID: 28320 RVA: 0x0003BE9A File Offset: 0x0003A09A
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple> m_SpecialGuestGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpecialGuestGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpecialGuestGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x06006EA1 RID: 28321 RVA: 0x0020F25C File Offset: 0x0020D45C
		// (set) Token: 0x06006EA2 RID: 28322 RVA: 0x0003BEB9 File Offset: 0x0003A0B9
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple> m_SpellCardGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpellCardGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpellCardGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x06006EA3 RID: 28323 RVA: 0x0020F28C File Offset: 0x0020D48C
		// (set) Token: 0x06006EA4 RID: 28324 RVA: 0x0003BED8 File Offset: 0x0003A0D8
		public unsafe CanvasGroup m_SpellFieldGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpellFieldGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.NativeFieldInfoPtr_m_SpellFieldGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400491E RID: 18718
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x0400491F RID: 18719
		private static readonly IntPtr NativeFieldInfoPtr_Scroller;

		// Token: 0x04004920 RID: 18720
		private static readonly IntPtr NativeFieldInfoPtr_NormalGuestDetailParent;

		// Token: 0x04004921 RID: 18721
		private static readonly IntPtr NativeFieldInfoPtr_SpecialGuestDetailParent;

		// Token: 0x04004922 RID: 18722
		private static readonly IntPtr NativeFieldInfoPtr_SpecialGuestDetailCompactParent;

		// Token: 0x04004923 RID: 18723
		private static readonly IntPtr NativeFieldInfoPtr_SpellCardDetailParent;

		// Token: 0x04004924 RID: 18724
		private static readonly IntPtr NativeFieldInfoPtr_SpellCardDetailCompactParent;

		// Token: 0x04004925 RID: 18725
		private static readonly IntPtr NativeFieldInfoPtr_PartnerDetailParent;

		// Token: 0x04004926 RID: 18726
		private static readonly IntPtr NativeFieldInfoPtr_GuestParent;

		// Token: 0x04004927 RID: 18727
		private static readonly IntPtr NativeFieldInfoPtr_nullGuestParentNameColor;

		// Token: 0x04004928 RID: 18728
		private static readonly IntPtr NativeFieldInfoPtr_nullGuestParentAvatarMaskColor;

		// Token: 0x04004929 RID: 18729
		private static readonly IntPtr NativeFieldInfoPtr_NullPannel;

		// Token: 0x0400492A RID: 18730
		private static readonly IntPtr NativeFieldInfoPtr_DescriberPannel;

		// Token: 0x0400492B RID: 18731
		private static readonly IntPtr NativeFieldInfoPtr_NGuestField;

		// Token: 0x0400492C RID: 18732
		private static readonly IntPtr NativeFieldInfoPtr_SGuestField;

		// Token: 0x0400492D RID: 18733
		private static readonly IntPtr NativeFieldInfoPtr_SpellField;

		// Token: 0x0400492E RID: 18734
		private static readonly IntPtr NativeFieldInfoPtr_PartnerField;

		// Token: 0x0400492F RID: 18735
		private static readonly IntPtr NativeFieldInfoPtr_ParticularGuestGuestField;

		// Token: 0x04004930 RID: 18736
		private static readonly IntPtr NativeFieldInfoPtr_m_AllDescriberPannel;

		// Token: 0x04004931 RID: 18737
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuests;

		// Token: 0x04004932 RID: 18738
		private static readonly IntPtr NativeFieldInfoPtr_m_ParticularSpecialGuests;

		// Token: 0x04004933 RID: 18739
		private static readonly IntPtr NativeFieldInfoPtr_m_Partners;

		// Token: 0x04004934 RID: 18740
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuests;

		// Token: 0x04004935 RID: 18741
		private static readonly IntPtr NativeFieldInfoPtr_m_Spell;

		// Token: 0x04004936 RID: 18742
		private static readonly IntPtr NativeFieldInfoPtr_checkRecordedCallback;

		// Token: 0x04004937 RID: 18743
		private static readonly IntPtr NativeFieldInfoPtr_currentDescribePanel;

		// Token: 0x04004938 RID: 18744
		private static readonly IntPtr NativeFieldInfoPtr_describeDataCallback;

		// Token: 0x04004939 RID: 18745
		private static readonly IntPtr NativeFieldInfoPtr_m_Current;

		// Token: 0x0400493A RID: 18746
		private static readonly IntPtr NativeFieldInfoPtr_m_NGuestFieldGroup;

		// Token: 0x0400493B RID: 18747
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuestGroup;

		// Token: 0x0400493C RID: 18748
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSwitchButtonSubmit;

		// Token: 0x0400493D RID: 18749
		private static readonly IntPtr NativeFieldInfoPtr_m_PanelToken;

		// Token: 0x0400493E RID: 18750
		private static readonly IntPtr NativeFieldInfoPtr_m_ParticularFieldGroup;

		// Token: 0x0400493F RID: 18751
		private static readonly IntPtr NativeFieldInfoPtr_m_ParticularGuestGroup;

		// Token: 0x04004940 RID: 18752
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerFieldGroup;

		// Token: 0x04004941 RID: 18753
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerGroup;

		// Token: 0x04004942 RID: 18754
		private static readonly IntPtr NativeFieldInfoPtr_m_SGuestFieldGroup;

		// Token: 0x04004943 RID: 18755
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestGroup;

		// Token: 0x04004944 RID: 18756
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellCardGroup;

		// Token: 0x04004945 RID: 18757
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellFieldGroup;

		// Token: 0x04004946 RID: 18758
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004947 RID: 18759
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004948 RID: 18760
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004949 RID: 18761
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400494A RID: 18762
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400494B RID: 18763
		private static readonly IntPtr NativeMethodInfoPtr_SetParamValue_Private_Void_Func_2_GuestBase_Boolean_CanvasGroup_Action_1_GuestBase_0;

		// Token: 0x0400494C RID: 18764
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriberPanel_Private_T_GameObject_0;

		// Token: 0x0400494D RID: 18765
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_TValue_UIElementCluster_UIButtonSimple_0;

		// Token: 0x0400494E RID: 18766
		private static readonly IntPtr NativeMethodInfoPtr_OnElementSelected_Private_Void_TValue_UIElementCluster_UIButtonSimple_0;

		// Token: 0x0400494F RID: 18767
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004950 RID: 18768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004951 RID: 18769
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_StaticVerticalGridScrollListUILogicalGroupT_3_TGuest_UIElementCluster_UIButtonSimple_GridLayoutGroup_List_1_TGuest_0;

		// Token: 0x04004952 RID: 18770
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__43_1_Private_Void_CallbackContext_0;

		// Token: 0x02000ECB RID: 3787
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumGuestSubSubPannel+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
		{
			// Token: 0x06010AD5 RID: 68309 RVA: 0x003DC030 File Offset: 0x003DA230
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0>.NativeClassPtr);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeFieldInfoPtr_unlockedSGuestNotHideInAlbum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0>.NativeClassPtr, "unlockedSGuestNotHideInAlbum");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0>.NativeClassPtr, "<>4__this");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0>.NativeClassPtr, 100685888);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0>.NativeClassPtr, 100685889);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Boolean_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0>.NativeClassPtr, 100685890);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeMethodInfoPtr__OnPanelOpen_b__14_Internal_Boolean_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0>.NativeClassPtr, 100685891);
			}

			// Token: 0x06010AD6 RID: 68310 RVA: 0x003DC0D4 File Offset: 0x003DA2D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AD7 RID: 68311 RVA: 0x003DC110 File Offset: 0x003DA310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276171, XrefRangeEnd = 276172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__4(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010AD8 RID: 68312 RVA: 0x003DC160 File Offset: 0x003DA360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276172, XrefRangeEnd = 276194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__9(GuestBase guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Boolean_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010AD9 RID: 68313 RVA: 0x003DC1B0 File Offset: 0x003DA3B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276194, XrefRangeEnd = 276216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__14(GuestBase guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeMethodInfoPtr__OnPanelOpen_b__14_Internal_Boolean_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010ADA RID: 68314 RVA: 0x000917D2 File Offset: 0x0008F9D2
			public __c__DisplayClass45_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056F4 RID: 22260
			// (get) Token: 0x06010ADB RID: 68315 RVA: 0x003DC200 File Offset: 0x003DA400
			// (set) Token: 0x06010ADC RID: 68316 RVA: 0x000917DB File Offset: 0x0008F9DB
			public unsafe Il2CppReferenceArray<SpecialGuest> unlockedSGuestNotHideInAlbum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeFieldInfoPtr_unlockedSGuestNotHideInAlbum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeFieldInfoPtr_unlockedSGuestNotHideInAlbum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056F5 RID: 22261
			// (get) Token: 0x06010ADD RID: 68317 RVA: 0x003DC230 File Offset: 0x003DA430
			// (set) Token: 0x06010ADE RID: 68318 RVA: 0x000917FA File Offset: 0x0008F9FA
			public unsafe NoteBookAlbumGuestSubSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumGuestSubSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8BB RID: 43195
			private static readonly IntPtr NativeFieldInfoPtr_unlockedSGuestNotHideInAlbum;

			// Token: 0x0400A8BC RID: 43196
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8BD RID: 43197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8BE RID: 43198
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Boolean_SpecialGuest_0;

			// Token: 0x0400A8BF RID: 43199
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Boolean_GuestBase_0;

			// Token: 0x0400A8C0 RID: 43200
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__14_Internal_Boolean_GuestBase_0;
		}

		// Token: 0x02000ECC RID: 3788
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumGuestSubSubPannel+<>c__DisplayClass45_1")]
		public sealed class __c__DisplayClass45_1 : Il2CppSystem.Object
		{
			// Token: 0x06010ADF RID: 68319 RVA: 0x003DC260 File Offset: 0x003DA460
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_1()
			{
				Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "<>c__DisplayClass45_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_recordedNormalGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, "recordedNormalGuests");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_normalGuestDescriberPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, "normalGuestDescriberPanel");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_specialGuestDescriberPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, "specialGuestDescriberPanel");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_partnerDescriberPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, "partnerDescriberPanel");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_particularSpecialGuestDescriberPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, "particularSpecialGuestDescriberPanel");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_spellDescribePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, "spellDescribePanel");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, "CS$<>8__locals1");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, 100685892);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, 100685893);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, 100685894);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, 100685895);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__13_Internal_Void_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, 100685896);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__15_Internal_Void_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, 100685897);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__17_Internal_Void_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr, 100685898);
			}

			// Token: 0x06010AE0 RID: 68320 RVA: 0x003DC3A4 File Offset: 0x003DA5A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AE1 RID: 68321 RVA: 0x003DC3E0 File Offset: 0x003DA5E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276216, XrefRangeEnd = 276220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__6(GuestBase guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010AE2 RID: 68322 RVA: 0x003DC430 File Offset: 0x003DA630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276220, XrefRangeEnd = 276225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__7(GuestBase guestData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AE3 RID: 68323 RVA: 0x003DC474 File Offset: 0x003DA674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276225, XrefRangeEnd = 276231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__10(GuestBase data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AE4 RID: 68324 RVA: 0x003DC4B8 File Offset: 0x003DA6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276231, XrefRangeEnd = 276237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__13(GuestBase data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__13_Internal_Void_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AE5 RID: 68325 RVA: 0x003DC4FC File Offset: 0x003DA6FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276237, XrefRangeEnd = 276243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__15(GuestBase data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__15_Internal_Void_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AE6 RID: 68326 RVA: 0x003DC540 File Offset: 0x003DA740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276243, XrefRangeEnd = 276248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__17(GuestBase data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeMethodInfoPtr__OnPanelOpen_b__17_Internal_Void_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AE7 RID: 68327 RVA: 0x00091819 File Offset: 0x0008FA19
			public __c__DisplayClass45_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056F6 RID: 22262
			// (get) Token: 0x06010AE8 RID: 68328 RVA: 0x003DC584 File Offset: 0x003DA784
			// (set) Token: 0x06010AE9 RID: 68329 RVA: 0x00091822 File Offset: 0x0008FA22
			public unsafe HashSet<int> recordedNormalGuests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_recordedNormalGuests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_recordedNormalGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056F7 RID: 22263
			// (get) Token: 0x06010AEA RID: 68330 RVA: 0x003DC5B4 File Offset: 0x003DA7B4
			// (set) Token: 0x06010AEB RID: 68331 RVA: 0x00091841 File Offset: 0x0008FA41
			public unsafe NormalGuestDescriber normalGuestDescriberPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_normalGuestDescriberPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuestDescriber>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_normalGuestDescriberPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056F8 RID: 22264
			// (get) Token: 0x06010AEC RID: 68332 RVA: 0x003DC5E4 File Offset: 0x003DA7E4
			// (set) Token: 0x06010AED RID: 68333 RVA: 0x00091860 File Offset: 0x0008FA60
			public unsafe SpecialGuestDescriber specialGuestDescriberPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_specialGuestDescriberPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestDescriber>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_specialGuestDescriberPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056F9 RID: 22265
			// (get) Token: 0x06010AEE RID: 68334 RVA: 0x003DC614 File Offset: 0x003DA814
			// (set) Token: 0x06010AEF RID: 68335 RVA: 0x0009187F File Offset: 0x0008FA7F
			public unsafe SpecialGuestDescriber partnerDescriberPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_partnerDescriberPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestDescriber>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_partnerDescriberPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056FA RID: 22266
			// (get) Token: 0x06010AF0 RID: 68336 RVA: 0x003DC644 File Offset: 0x003DA844
			// (set) Token: 0x06010AF1 RID: 68337 RVA: 0x0009189E File Offset: 0x0008FA9E
			public unsafe SpecialGuestDescriber particularSpecialGuestDescriberPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_particularSpecialGuestDescriberPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestDescriber>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_particularSpecialGuestDescriberPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056FB RID: 22267
			// (get) Token: 0x06010AF2 RID: 68338 RVA: 0x003DC674 File Offset: 0x003DA874
			// (set) Token: 0x06010AF3 RID: 68339 RVA: 0x000918BD File Offset: 0x0008FABD
			public unsafe SpecialGuestDescriber spellDescribePanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_spellDescribePanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestDescriber>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_spellDescribePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056FC RID: 22268
			// (get) Token: 0x06010AF4 RID: 68340 RVA: 0x003DC6A4 File Offset: 0x003DA8A4
			// (set) Token: 0x06010AF5 RID: 68341 RVA: 0x000918DC File Offset: 0x0008FADC
			public unsafe NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0 field_Public___c__DisplayClass45_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass45_1.NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8C1 RID: 43201
			private static readonly IntPtr NativeFieldInfoPtr_recordedNormalGuests;

			// Token: 0x0400A8C2 RID: 43202
			private static readonly IntPtr NativeFieldInfoPtr_normalGuestDescriberPanel;

			// Token: 0x0400A8C3 RID: 43203
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestDescriberPanel;

			// Token: 0x0400A8C4 RID: 43204
			private static readonly IntPtr NativeFieldInfoPtr_partnerDescriberPanel;

			// Token: 0x0400A8C5 RID: 43205
			private static readonly IntPtr NativeFieldInfoPtr_particularSpecialGuestDescriberPanel;

			// Token: 0x0400A8C6 RID: 43206
			private static readonly IntPtr NativeFieldInfoPtr_spellDescribePanel;

			// Token: 0x0400A8C7 RID: 43207
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0;

			// Token: 0x0400A8C8 RID: 43208
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8C9 RID: 43209
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_GuestBase_0;

			// Token: 0x0400A8CA RID: 43210
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_GuestBase_0;

			// Token: 0x0400A8CB RID: 43211
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_GuestBase_0;

			// Token: 0x0400A8CC RID: 43212
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__13_Internal_Void_GuestBase_0;

			// Token: 0x0400A8CD RID: 43213
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__15_Internal_Void_GuestBase_0;

			// Token: 0x0400A8CE RID: 43214
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__17_Internal_Void_GuestBase_0;
		}

		// Token: 0x02000ECD RID: 3789
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumGuestSubSubPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010AF6 RID: 68342 RVA: 0x003DC6D4 File Offset: 0x003DA8D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr);
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_0");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_1");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_2");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_3");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_5");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_8");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_19");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_11");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_12");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_20");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_16");
				NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, "<>9__45_18");
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685900);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_0_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685901);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_1_Internal_SpecialGuest_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685902);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_2_Internal_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685903);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_3_Internal_SpecialGuest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685904);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_5_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685905);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_8_Internal_Boolean_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685906);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_19_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685907);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_11_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685908);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_12_Internal_Boolean_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685909);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_20_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685910);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_16_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685911);
				NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_18_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr, 100685912);
			}

			// Token: 0x06010AF7 RID: 68343 RVA: 0x003DC908 File Offset: 0x003DAB08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AF8 RID: 68344 RVA: 0x003DC944 File Offset: 0x003DAB44
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__45_0(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_0_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010AF9 RID: 68345 RVA: 0x003DC994 File Offset: 0x003DAB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276248, XrefRangeEnd = 276256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuest _OnPanelOpen_b__45_1(SpecialGuest specialGuest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_1_Internal_SpecialGuest_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
			}

			// Token: 0x06010AFA RID: 68346 RVA: 0x003DC9E4 File Offset: 0x003DABE4
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__45_2(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_2_Internal_Int32_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010AFB RID: 68347 RVA: 0x003DCA34 File Offset: 0x003DAC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276256, XrefRangeEnd = 276260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuest _OnPanelOpen_b__45_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_3_Internal_SpecialGuest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
			}

			// Token: 0x06010AFC RID: 68348 RVA: 0x003DCA80 File Offset: 0x003DAC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276260, XrefRangeEnd = 276264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__45_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_5_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010AFD RID: 68349 RVA: 0x003DCACC File Offset: 0x003DACCC
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__45_8(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_8_Internal_Boolean_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010AFE RID: 68350 RVA: 0x003DCB1C File Offset: 0x003DAD1C
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__45_19(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_19_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010AFF RID: 68351 RVA: 0x003DCB6C File Offset: 0x003DAD6C
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__45_11(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_11_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010B00 RID: 68352 RVA: 0x003DCBBC File Offset: 0x003DADBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276264, XrefRangeEnd = 276269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__45_12(GuestBase guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_12_Internal_Boolean_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010B01 RID: 68353 RVA: 0x003DCC0C File Offset: 0x003DAE0C
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__45_20(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_20_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010B02 RID: 68354 RVA: 0x003DCC5C File Offset: 0x003DAE5C
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__45_16(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_16_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010B03 RID: 68355 RVA: 0x003DCCAC File Offset: 0x003DAEAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276269, XrefRangeEnd = 276271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__45_18(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__45_18_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010B04 RID: 68356 RVA: 0x000918FB File Offset: 0x0008FAFB
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056FD RID: 22269
			// (get) Token: 0x06010B05 RID: 68357 RVA: 0x003DCCFC File Offset: 0x003DAEFC
			// (set) Token: 0x06010B06 RID: 68358 RVA: 0x00091904 File Offset: 0x0008FB04
			public unsafe static NoteBookAlbumGuestSubSubPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumGuestSubSubPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056FE RID: 22270
			// (get) Token: 0x06010B07 RID: 68359 RVA: 0x003DCD24 File Offset: 0x003DAF24
			// (set) Token: 0x06010B08 RID: 68360 RVA: 0x00091916 File Offset: 0x0008FB16
			public unsafe static Func<SpecialGuest, bool> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056FF RID: 22271
			// (get) Token: 0x06010B09 RID: 68361 RVA: 0x003DCD4C File Offset: 0x003DAF4C
			// (set) Token: 0x06010B0A RID: 68362 RVA: 0x00091928 File Offset: 0x0008FB28
			public unsafe static Func<SpecialGuest, SpecialGuest> __9__45_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005700 RID: 22272
			// (get) Token: 0x06010B0B RID: 68363 RVA: 0x003DCD74 File Offset: 0x003DAF74
			// (set) Token: 0x06010B0C RID: 68364 RVA: 0x0009193A File Offset: 0x0008FB3A
			public unsafe static Func<SpecialGuest, int> __9__45_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005701 RID: 22273
			// (get) Token: 0x06010B0D RID: 68365 RVA: 0x003DCD9C File Offset: 0x003DAF9C
			// (set) Token: 0x06010B0E RID: 68366 RVA: 0x0009194C File Offset: 0x0008FB4C
			public unsafe static Func<int, SpecialGuest> __9__45_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005702 RID: 22274
			// (get) Token: 0x06010B0F RID: 68367 RVA: 0x003DCDC4 File Offset: 0x003DAFC4
			// (set) Token: 0x06010B10 RID: 68368 RVA: 0x0009195E File Offset: 0x0008FB5E
			public unsafe static Func<int, bool> __9__45_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005703 RID: 22275
			// (get) Token: 0x06010B11 RID: 68369 RVA: 0x003DCDEC File Offset: 0x003DAFEC
			// (set) Token: 0x06010B12 RID: 68370 RVA: 0x00091970 File Offset: 0x0008FB70
			public unsafe static Func<NormalGuest, bool> __9__45_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005704 RID: 22276
			// (get) Token: 0x06010B13 RID: 68371 RVA: 0x003DCE14 File Offset: 0x003DB014
			// (set) Token: 0x06010B14 RID: 68372 RVA: 0x00091982 File Offset: 0x0008FB82
			public unsafe static Func<SpecialGuest, bool> __9__45_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005705 RID: 22277
			// (get) Token: 0x06010B15 RID: 68373 RVA: 0x003DCE3C File Offset: 0x003DB03C
			// (set) Token: 0x06010B16 RID: 68374 RVA: 0x00091994 File Offset: 0x0008FB94
			public unsafe static Func<SpecialGuest, bool> __9__45_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005706 RID: 22278
			// (get) Token: 0x06010B17 RID: 68375 RVA: 0x003DCE64 File Offset: 0x003DB064
			// (set) Token: 0x06010B18 RID: 68376 RVA: 0x000919A6 File Offset: 0x0008FBA6
			public unsafe static Func<GuestBase, bool> __9__45_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005707 RID: 22279
			// (get) Token: 0x06010B19 RID: 68377 RVA: 0x003DCE8C File Offset: 0x003DB08C
			// (set) Token: 0x06010B1A RID: 68378 RVA: 0x000919B8 File Offset: 0x0008FBB8
			public unsafe static Func<SpecialGuest, bool> __9__45_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005708 RID: 22280
			// (get) Token: 0x06010B1B RID: 68379 RVA: 0x003DCEB4 File Offset: 0x003DB0B4
			// (set) Token: 0x06010B1C RID: 68380 RVA: 0x000919CA File Offset: 0x0008FBCA
			public unsafe static Func<SpecialGuest, bool> __9__45_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005709 RID: 22281
			// (get) Token: 0x06010B1D RID: 68381 RVA: 0x003DCEDC File Offset: 0x003DB0DC
			// (set) Token: 0x06010B1E RID: 68382 RVA: 0x000919DC File Offset: 0x0008FBDC
			public unsafe static Func<SpecialGuest, bool> __9__45_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c.NativeFieldInfoPtr___9__45_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8CF RID: 43215
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A8D0 RID: 43216
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x0400A8D1 RID: 43217
			private static readonly IntPtr NativeFieldInfoPtr___9__45_1;

			// Token: 0x0400A8D2 RID: 43218
			private static readonly IntPtr NativeFieldInfoPtr___9__45_2;

			// Token: 0x0400A8D3 RID: 43219
			private static readonly IntPtr NativeFieldInfoPtr___9__45_3;

			// Token: 0x0400A8D4 RID: 43220
			private static readonly IntPtr NativeFieldInfoPtr___9__45_5;

			// Token: 0x0400A8D5 RID: 43221
			private static readonly IntPtr NativeFieldInfoPtr___9__45_8;

			// Token: 0x0400A8D6 RID: 43222
			private static readonly IntPtr NativeFieldInfoPtr___9__45_19;

			// Token: 0x0400A8D7 RID: 43223
			private static readonly IntPtr NativeFieldInfoPtr___9__45_11;

			// Token: 0x0400A8D8 RID: 43224
			private static readonly IntPtr NativeFieldInfoPtr___9__45_12;

			// Token: 0x0400A8D9 RID: 43225
			private static readonly IntPtr NativeFieldInfoPtr___9__45_20;

			// Token: 0x0400A8DA RID: 43226
			private static readonly IntPtr NativeFieldInfoPtr___9__45_16;

			// Token: 0x0400A8DB RID: 43227
			private static readonly IntPtr NativeFieldInfoPtr___9__45_18;

			// Token: 0x0400A8DC RID: 43228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8DD RID: 43229
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_0_Internal_Boolean_SpecialGuest_0;

			// Token: 0x0400A8DE RID: 43230
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_1_Internal_SpecialGuest_SpecialGuest_0;

			// Token: 0x0400A8DF RID: 43231
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_2_Internal_Int32_SpecialGuest_0;

			// Token: 0x0400A8E0 RID: 43232
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_3_Internal_SpecialGuest_Int32_0;

			// Token: 0x0400A8E1 RID: 43233
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_5_Internal_Boolean_Int32_0;

			// Token: 0x0400A8E2 RID: 43234
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_8_Internal_Boolean_NormalGuest_0;

			// Token: 0x0400A8E3 RID: 43235
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_19_Internal_Boolean_SpecialGuest_0;

			// Token: 0x0400A8E4 RID: 43236
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_11_Internal_Boolean_SpecialGuest_0;

			// Token: 0x0400A8E5 RID: 43237
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_12_Internal_Boolean_GuestBase_0;

			// Token: 0x0400A8E6 RID: 43238
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_20_Internal_Boolean_SpecialGuest_0;

			// Token: 0x0400A8E7 RID: 43239
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_16_Internal_Boolean_SpecialGuest_0;

			// Token: 0x0400A8E8 RID: 43240
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__45_18_Internal_Boolean_SpecialGuest_0;
		}

		// Token: 0x02000ECE RID: 3790
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumGuestSubSubPannel+<>c__DisplayClass48_0`1")]
		public sealed class __c__DisplayClass48_0<TValue> : Il2CppSystem.Object where TValue : GuestBase
		{
			// Token: 0x06010B1F RID: 68383 RVA: 0x003DCF04 File Offset: 0x003DB104
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "<>c__DisplayClass48_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeFieldInfoPtr_recorded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr, "recorded");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr, "<>4__this");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeFieldInfoPtr_guestData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr, "guestData");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr, 100685913);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr, 100685914);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr, 100685915);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr, 100685916);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__6_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr, 100685917);
			}

			// Token: 0x06010B20 RID: 68384 RVA: 0x003DD00C File Offset: 0x003DB20C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B21 RID: 68385 RVA: 0x003DD048 File Offset: 0x003DB248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B22 RID: 68386 RVA: 0x003DD08C File Offset: 0x003DB28C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B23 RID: 68387 RVA: 0x003DD0D0 File Offset: 0x003DB2D0
			[CallerCount(0)]
			public unsafe void _OnElementEnabled_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B24 RID: 68388 RVA: 0x003DD114 File Offset: 0x003DB314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276271, XrefRangeEnd = 276273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__6(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__6_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B25 RID: 68389 RVA: 0x000919EE File Offset: 0x0008FBEE
			public __c__DisplayClass48_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700570A RID: 22282
			// (get) Token: 0x06010B26 RID: 68390 RVA: 0x003DD158 File Offset: 0x003DB358
			// (set) Token: 0x06010B27 RID: 68391 RVA: 0x000919F7 File Offset: 0x0008FBF7
			public unsafe bool recorded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeFieldInfoPtr_recorded);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeFieldInfoPtr_recorded)) = value;
				}
			}

			// Token: 0x1700570B RID: 22283
			// (get) Token: 0x06010B28 RID: 68392 RVA: 0x003DD180 File Offset: 0x003DB380
			// (set) Token: 0x06010B29 RID: 68393 RVA: 0x00091A12 File Offset: 0x0008FC12
			public unsafe NoteBookAlbumGuestSubSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumGuestSubSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700570C RID: 22284
			// (get) Token: 0x06010B2A RID: 68394 RVA: 0x003DD1B0 File Offset: 0x003DB3B0
			// (set) Token: 0x06010B2B RID: 68395 RVA: 0x003DD1D8 File Offset: 0x003DB3D8
			public unsafe TValue guestData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeFieldInfoPtr_guestData);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_0<TValue>.NativeFieldInfoPtr_guestData);
					Type typeFromHandle = typeof(TValue);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x0400A8E9 RID: 43241
			private static readonly IntPtr NativeFieldInfoPtr_recorded;

			// Token: 0x0400A8EA RID: 43242
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8EB RID: 43243
			private static readonly IntPtr NativeFieldInfoPtr_guestData;

			// Token: 0x0400A8EC RID: 43244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8ED RID: 43245
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0;

			// Token: 0x0400A8EE RID: 43246
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_Image_0;

			// Token: 0x0400A8EF RID: 43247
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A8F0 RID: 43248
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__6_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000ECF RID: 3791
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumGuestSubSubPannel+<>c__DisplayClass48_1`1")]
		public sealed class __c__DisplayClass48_1<TValue> : Il2CppSystem.Object where TValue : GuestBase
		{
			// Token: 0x06010B2C RID: 68396 RVA: 0x003DD280 File Offset: 0x003DB480
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_1()
			{
				Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "<>c__DisplayClass48_1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeFieldInfoPtr_colorScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr, "colorScheme");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr, "pixel");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr, 100685918);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr, 100685919);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr, 100685920);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr, 100685921);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr, 100685922);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr, 100685923);
			}

			// Token: 0x06010B2D RID: 68397 RVA: 0x003DD388 File Offset: 0x003DB588
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B2E RID: 68398 RVA: 0x003DD3C4 File Offset: 0x003DB5C4
			[CallerCount(0)]
			public unsafe void _OnElementEnabled_b__7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B2F RID: 68399 RVA: 0x003DD408 File Offset: 0x003DB608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276273, XrefRangeEnd = 276278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__8(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B30 RID: 68400 RVA: 0x003DD44C File Offset: 0x003DB64C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276278, XrefRangeEnd = 276283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__9(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B31 RID: 68401 RVA: 0x003DD490 File Offset: 0x003DB690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276283, XrefRangeEnd = 276286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B32 RID: 68402 RVA: 0x003DD4D4 File Offset: 0x003DB6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276286, XrefRangeEnd = 276289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B33 RID: 68403 RVA: 0x00091A31 File Offset: 0x0008FC31
			public __c__DisplayClass48_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700570D RID: 22285
			// (get) Token: 0x06010B34 RID: 68404 RVA: 0x003DD518 File Offset: 0x003DB718
			// (set) Token: 0x06010B35 RID: 68405 RVA: 0x00091A3A File Offset: 0x0008FC3A
			public unsafe Il2CppStructArray<Color> colorScheme
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeFieldInfoPtr_colorScheme);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeFieldInfoPtr_colorScheme), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700570E RID: 22286
			// (get) Token: 0x06010B36 RID: 68406 RVA: 0x003DD548 File Offset: 0x003DB748
			// (set) Token: 0x06010B37 RID: 68407 RVA: 0x00091A59 File Offset: 0x0008FC59
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass48_1<TValue>.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8F1 RID: 43249
			private static readonly IntPtr NativeFieldInfoPtr_colorScheme;

			// Token: 0x0400A8F2 RID: 43250
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x0400A8F3 RID: 43251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8F4 RID: 43252
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__7_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A8F5 RID: 43253
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__8_Internal_Void_Image_0;

			// Token: 0x0400A8F6 RID: 43254
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__9_Internal_Void_Image_0;

			// Token: 0x0400A8F7 RID: 43255
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__10_Internal_Void_Image_0;

			// Token: 0x0400A8F8 RID: 43256
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__11_Internal_Void_Image_0;
		}

		// Token: 0x02000ED0 RID: 3792
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumGuestSubSubPannel+<>c__48`1")]
		[Serializable]
		public sealed class __c__48<TValue> : Il2CppSystem.Object where TValue : GuestBase
		{
			// Token: 0x06010B38 RID: 68408 RVA: 0x003DD578 File Offset: 0x003DB778
			// Note: this type is marked as 'beforefieldinit'.
			static __c__48()
			{
				Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "<>c__48`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr);
				NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr, "<>9");
				NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9__48_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr, "<>9__48_2");
				NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9__48_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr, "<>9__48_3");
				NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9__48_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr, "<>9__48_4");
				NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr, 100685925);
				NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__48_2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr, 100685926);
				NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__48_3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr, 100685927);
				NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__48_4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr, 100685928);
			}

			// Token: 0x06010B39 RID: 68409 RVA: 0x003DD680 File Offset: 0x003DB880
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__48() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B3A RID: 68410 RVA: 0x003DD6BC File Offset: 0x003DB8BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__48_2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__48_2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B3B RID: 68411 RVA: 0x003DD700 File Offset: 0x003DB900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__48_3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__48_3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B3C RID: 68412 RVA: 0x003DD744 File Offset: 0x003DB944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276289, XrefRangeEnd = 276292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__48_4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeMethodInfoPtr__OnElementEnabled_b__48_4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B3D RID: 68413 RVA: 0x00091A78 File Offset: 0x0008FC78
			public __c__48(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700570F RID: 22287
			// (get) Token: 0x06010B3E RID: 68414 RVA: 0x003DD788 File Offset: 0x003DB988
			// (set) Token: 0x06010B3F RID: 68415 RVA: 0x00091A81 File Offset: 0x0008FC81
			public unsafe static NoteBookAlbumGuestSubSubPannel.__c__48<TValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumGuestSubSubPannel.__c__48<TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005710 RID: 22288
			// (get) Token: 0x06010B40 RID: 68416 RVA: 0x003DD7B0 File Offset: 0x003DB9B0
			// (set) Token: 0x06010B41 RID: 68417 RVA: 0x00091A93 File Offset: 0x0008FC93
			public unsafe static Action<Image> __9__48_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9__48_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9__48_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005711 RID: 22289
			// (get) Token: 0x06010B42 RID: 68418 RVA: 0x003DD7D8 File Offset: 0x003DB9D8
			// (set) Token: 0x06010B43 RID: 68419 RVA: 0x00091AA5 File Offset: 0x0008FCA5
			public unsafe static Action<Image> __9__48_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9__48_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9__48_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005712 RID: 22290
			// (get) Token: 0x06010B44 RID: 68420 RVA: 0x003DD800 File Offset: 0x003DBA00
			// (set) Token: 0x06010B45 RID: 68421 RVA: 0x00091AB7 File Offset: 0x0008FCB7
			public unsafe static Action<TextMeshProUGUI> __9__48_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9__48_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumGuestSubSubPannel.__c__48<TValue>.NativeFieldInfoPtr___9__48_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8F9 RID: 43257
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A8FA RID: 43258
			private static readonly IntPtr NativeFieldInfoPtr___9__48_2;

			// Token: 0x0400A8FB RID: 43259
			private static readonly IntPtr NativeFieldInfoPtr___9__48_3;

			// Token: 0x0400A8FC RID: 43260
			private static readonly IntPtr NativeFieldInfoPtr___9__48_4;

			// Token: 0x0400A8FD RID: 43261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8FE RID: 43262
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__48_2_Internal_Void_Image_0;

			// Token: 0x0400A8FF RID: 43263
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__48_3_Internal_Void_Image_0;

			// Token: 0x0400A900 RID: 43264
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__48_4_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000ED1 RID: 3793
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumGuestSubSubPannel+<>c__DisplayClass49_0`1")]
		public sealed class __c__DisplayClass49_0<TValue> : Il2CppSystem.Object where TValue : GuestBase
		{
			// Token: 0x06010B46 RID: 68422 RVA: 0x003DD828 File Offset: 0x003DBA28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr, "<>c__DisplayClass49_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>>.NativeClassPtr);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>>.NativeClassPtr, "<>4__this");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>.NativeFieldInfoPtr_guestData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>>.NativeClassPtr, "guestData");
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>>.NativeClassPtr, 100685929);
				NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>.NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>>.NativeClassPtr, 100685930);
			}

			// Token: 0x06010B47 RID: 68423 RVA: 0x003DD8E0 File Offset: 0x003DBAE0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B48 RID: 68424 RVA: 0x003DD91C File Offset: 0x003DBB1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276292, XrefRangeEnd = 276293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>.NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B49 RID: 68425 RVA: 0x00091AC9 File Offset: 0x0008FCC9
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005713 RID: 22291
			// (get) Token: 0x06010B4A RID: 68426 RVA: 0x003DD950 File Offset: 0x003DBB50
			// (set) Token: 0x06010B4B RID: 68427 RVA: 0x00091AD2 File Offset: 0x0008FCD2
			public unsafe NoteBookAlbumGuestSubSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumGuestSubSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005714 RID: 22292
			// (get) Token: 0x06010B4C RID: 68428 RVA: 0x003DD980 File Offset: 0x003DBB80
			// (set) Token: 0x06010B4D RID: 68429 RVA: 0x003DD9A8 File Offset: 0x003DBBA8
			public unsafe TValue guestData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>.NativeFieldInfoPtr_guestData);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubSubPannel.__c__DisplayClass49_0<TValue>.NativeFieldInfoPtr_guestData);
					Type typeFromHandle = typeof(TValue);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x0400A901 RID: 43265
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A902 RID: 43266
			private static readonly IntPtr NativeFieldInfoPtr_guestData;

			// Token: 0x0400A903 RID: 43267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A904 RID: 43268
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0;
		}

		// Token: 0x02000ED2 RID: 3794
		private sealed class MethodInfoStoreGeneric_GetDescriberPanel_Private_T_GameObject_0<T>
		{
			// Token: 0x0400A905 RID: 43269
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_GetDescriberPanel_Private_T_GameObject_0, Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000ED3 RID: 3795
		private sealed class MethodInfoStoreGeneric_OnElementEnabled_Private_Void_TValue_UIElementCluster_UIButtonSimple_0<TValue>
		{
			// Token: 0x0400A906 RID: 43270
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_TValue_UIElementCluster_UIButtonSimple_0, Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000ED4 RID: 3796
		private sealed class MethodInfoStoreGeneric_OnElementSelected_Private_Void_TValue_UIElementCluster_UIButtonSimple_0<TValue>
		{
			// Token: 0x0400A907 RID: 43271
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_TValue_UIElementCluster_UIButtonSimple_0, Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000ED5 RID: 3797
		private sealed class MethodInfoStoreGeneric_Method_Private_StaticVerticalGridScrollListUILogicalGroupT_3_TGuest_UIElementCluster_UIButtonSimple_GridLayoutGroup_List_1_TGuest_0<TGuest>
		{
			// Token: 0x0400A908 RID: 43272
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookAlbumGuestSubSubPannel.NativeMethodInfoPtr_Method_Private_StaticVerticalGridScrollListUILogicalGroupT_3_TGuest_UIElementCluster_UIButtonSimple_GridLayoutGroup_List_1_TGuest_0, Il2CppClassPointerStore<NoteBookAlbumGuestSubSubPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGuest>.NativeClassPtr))
			}))));
		}
	}
}
