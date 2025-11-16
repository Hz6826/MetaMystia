using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.UI;
using DEYU.UniversalUISystem;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002BA RID: 698
	public class YuugiExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x060056C2 RID: 22210 RVA: 0x001C2D50 File Offset: 0x001C0F50
		// Note: this type is marked as 'beforefieldinit'.
		static YuugiExtraDialogData()
		{
			Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "YuugiExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr);
			YuugiExtraDialogData.NativeFieldInfoPtr_ABOUT_SPRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "ABOUT_SPRING");
			YuugiExtraDialogData.NativeFieldInfoPtr_ACTION_CONSUMPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "ACTION_CONSUMPTION");
			YuugiExtraDialogData.NativeFieldInfoPtr_openSpringEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "openSpringEventId");
			YuugiExtraDialogData.NativeFieldInfoPtr_introduceSpringDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "introduceSpringDialog");
			YuugiExtraDialogData.NativeFieldInfoPtr_springPriceConfirmSingleDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "springPriceConfirmSingleDialog");
			YuugiExtraDialogData.NativeFieldInfoPtr_springPriceConfirmMultiDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "springPriceConfirmMultiDialog");
			YuugiExtraDialogData.NativeFieldInfoPtr_springPriceConfirmTogetherDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "springPriceConfirmTogetherDialog");
			YuugiExtraDialogData.NativeFieldInfoPtr_finalConfirmDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "finalConfirmDialog");
			YuugiExtraDialogData.NativeFieldInfoPtr_endSpringDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "endSpringDialog");
			YuugiExtraDialogData.NativeFieldInfoPtr_lackMoneyDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "lackMoneyDialog");
			YuugiExtraDialogData.NativeFieldInfoPtr_showerCGGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "showerCGGameObject");
			YuugiExtraDialogData.NativeFieldInfoPtr_mystiaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "mystiaData");
			YuugiExtraDialogData.NativeFieldInfoPtr_springData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "springData");
			YuugiExtraDialogData.NativeFieldInfoPtr_cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "cost");
			YuugiExtraDialogData.NativeFieldInfoPtr_preferentialEachPerson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "preferentialEachPerson");
			YuugiExtraDialogData.NativeFieldInfoPtr_rewardMoveSpeedRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "rewardMoveSpeedRate");
			YuugiExtraDialogData.NativeFieldInfoPtr_rewardCookSpeedRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "rewardCookSpeedRate");
			YuugiExtraDialogData.NativeFieldInfoPtr_targetPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "targetPartner");
			YuugiExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680941);
			YuugiExtraDialogData.NativeMethodInfoPtr_GotoSpring_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680942);
			YuugiExtraDialogData.NativeMethodInfoPtr_GetPartnerData_Private_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680943);
			YuugiExtraDialogData.NativeMethodInfoPtr_GetExtraSelectionsCallback_Private_IEnumerable_1_ValueTuple_3_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680944);
			YuugiExtraDialogData.NativeMethodInfoPtr_GetName_Private_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680945);
			YuugiExtraDialogData.NativeMethodInfoPtr_GetSelectAllSelectionCallback_Private_ValueTuple_3_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680946);
			YuugiExtraDialogData.NativeMethodInfoPtr_OnPanelClosed_Private_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680947);
			YuugiExtraDialogData.NativeMethodInfoPtr_AddExtraSpringBuffToWorkScene_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680948);
			YuugiExtraDialogData.NativeMethodInfoPtr_PlayConfirmDialog_Private_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680949);
			YuugiExtraDialogData.NativeMethodInfoPtr_PlayConfirmDialogAsync_Private_UniTaskVoid_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680950);
			YuugiExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, 100680951);
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x001C2FC4 File Offset: 0x001C11C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215662, XrefRangeEnd = 215679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetSpecialGuestExtraDialogData(out Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> prependSelection, out Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> appendSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), YuugiExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x001C3044 File Offset: 0x001C1244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215679, XrefRangeEnd = 215700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GotoSpring(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.NativeMethodInfoPtr_GotoSpring_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x001C30D4 File Offset: 0x001C12D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215748, RefRangeEnd = 215749, XrefRangeStart = 215700, XrefRangeEnd = 215748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Il2CppSystem.Object> GetPartnerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.NativeMethodInfoPtr_GetPartnerData_Private_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(intPtr3) : null;
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x001C3114 File Offset: 0x001C1314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215749, XrefRangeEnd = 215754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<Il2CppSystem.Object, string, string>> GetExtraSelectionsCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.NativeMethodInfoPtr_GetExtraSelectionsCallback_Private_IEnumerable_1_ValueTuple_3_Object_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<Il2CppSystem.Object, string, string>>>(intPtr3) : null;
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x001C3154 File Offset: 0x001C1354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215754, XrefRangeEnd = 215761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetName(Il2CppSystem.Object id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.NativeMethodInfoPtr_GetName_Private_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x001C319C File Offset: 0x001C139C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215761, XrefRangeEnd = 215768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, string, string> GetSelectAllSelectionCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.NativeMethodInfoPtr_GetSelectAllSelectionCallback_Private_ValueTuple_3_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<int, string, string>(pointer);
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x001C31D4 File Offset: 0x001C13D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215768, XrefRangeEnd = 215776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelClosed(Il2CppStructArray<int> selections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selections);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.NativeMethodInfoPtr_OnPanelClosed_Private_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x001C3218 File Offset: 0x001C1418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215884, RefRangeEnd = 215885, XrefRangeStart = 215776, XrefRangeEnd = 215884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExtraSpringBuffToWorkScene(int partnerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.NativeMethodInfoPtr_AddExtraSpringBuffToWorkScene_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x001C3258 File Offset: 0x001C1458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215885, XrefRangeEnd = 215892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayConfirmDialog(Il2CppStructArray<int> partnerIds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.NativeMethodInfoPtr_PlayConfirmDialog_Private_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x001C329C File Offset: 0x001C149C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215892, XrefRangeEnd = 215898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid PlayConfirmDialogAsync(Il2CppStructArray<int> partnerIds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.NativeMethodInfoPtr_PlayConfirmDialogAsync_Private_UniTaskVoid_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x001C32EC File Offset: 0x001C14EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215898, XrefRangeEnd = 215911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YuugiExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x0002EB0C File Offset: 0x0002CD0C
		public YuugiExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x060056CF RID: 22223 RVA: 0x001C3328 File Offset: 0x001C1528
		// (set) Token: 0x060056D0 RID: 22224 RVA: 0x0002EB15 File Offset: 0x0002CD15
		public unsafe static string ABOUT_SPRING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.NativeFieldInfoPtr_ABOUT_SPRING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.NativeFieldInfoPtr_ABOUT_SPRING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x060056D1 RID: 22225 RVA: 0x001C3348 File Offset: 0x001C1548
		// (set) Token: 0x060056D2 RID: 22226 RVA: 0x0002EB27 File Offset: 0x0002CD27
		public unsafe static int ACTION_CONSUMPTION
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.NativeFieldInfoPtr_ACTION_CONSUMPTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.NativeFieldInfoPtr_ACTION_CONSUMPTION, (void*)(&value));
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x060056D3 RID: 22227 RVA: 0x001C3364 File Offset: 0x001C1564
		// (set) Token: 0x060056D4 RID: 22228 RVA: 0x0002EB35 File Offset: 0x0002CD35
		public unsafe string openSpringEventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_openSpringEventId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_openSpringEventId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x060056D5 RID: 22229 RVA: 0x001C338C File Offset: 0x001C158C
		// (set) Token: 0x060056D6 RID: 22230 RVA: 0x0002EB54 File Offset: 0x0002CD54
		public unsafe DialogPackage introduceSpringDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_introduceSpringDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_introduceSpringDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x060056D7 RID: 22231 RVA: 0x001C33BC File Offset: 0x001C15BC
		// (set) Token: 0x060056D8 RID: 22232 RVA: 0x0002EB73 File Offset: 0x0002CD73
		public unsafe DialogPackage springPriceConfirmSingleDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_springPriceConfirmSingleDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_springPriceConfirmSingleDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x060056D9 RID: 22233 RVA: 0x001C33EC File Offset: 0x001C15EC
		// (set) Token: 0x060056DA RID: 22234 RVA: 0x0002EB92 File Offset: 0x0002CD92
		public unsafe DialogPackage springPriceConfirmMultiDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_springPriceConfirmMultiDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_springPriceConfirmMultiDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x060056DB RID: 22235 RVA: 0x001C341C File Offset: 0x001C161C
		// (set) Token: 0x060056DC RID: 22236 RVA: 0x0002EBB1 File Offset: 0x0002CDB1
		public unsafe DialogPackage springPriceConfirmTogetherDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_springPriceConfirmTogetherDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_springPriceConfirmTogetherDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x060056DD RID: 22237 RVA: 0x001C344C File Offset: 0x001C164C
		// (set) Token: 0x060056DE RID: 22238 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
		public unsafe DialogPackage finalConfirmDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_finalConfirmDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_finalConfirmDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x060056DF RID: 22239 RVA: 0x001C347C File Offset: 0x001C167C
		// (set) Token: 0x060056E0 RID: 22240 RVA: 0x0002EBEF File Offset: 0x0002CDEF
		public unsafe DialogPackage endSpringDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_endSpringDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_endSpringDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x060056E1 RID: 22241 RVA: 0x001C34AC File Offset: 0x001C16AC
		// (set) Token: 0x060056E2 RID: 22242 RVA: 0x0002EC0E File Offset: 0x0002CE0E
		public unsafe DialogPackage lackMoneyDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_lackMoneyDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_lackMoneyDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x060056E3 RID: 22243 RVA: 0x001C34DC File Offset: 0x001C16DC
		// (set) Token: 0x060056E4 RID: 22244 RVA: 0x0002EC2D File Offset: 0x0002CE2D
		public unsafe GameObject showerCGGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_showerCGGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_showerCGGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x060056E5 RID: 22245 RVA: 0x001C350C File Offset: 0x001C170C
		// (set) Token: 0x060056E6 RID: 22246 RVA: 0x0002EC4C File Offset: 0x0002CE4C
		public YuugiExtraDialogData.PartnerSpringData mystiaData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_mystiaData);
				return new YuugiExtraDialogData.PartnerSpringData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_mystiaData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x060056E7 RID: 22247 RVA: 0x001C353C File Offset: 0x001C173C
		// (set) Token: 0x060056E8 RID: 22248 RVA: 0x0002EC7A File Offset: 0x0002CE7A
		public unsafe Il2CppReferenceArray<YuugiExtraDialogData.PartnerSpringData> springData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_springData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<YuugiExtraDialogData.PartnerSpringData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_springData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x060056E9 RID: 22249 RVA: 0x001C356C File Offset: 0x001C176C
		// (set) Token: 0x060056EA RID: 22250 RVA: 0x0002EC99 File Offset: 0x0002CE99
		public unsafe int cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_cost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_cost)) = value;
			}
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x060056EB RID: 22251 RVA: 0x001C3594 File Offset: 0x001C1794
		// (set) Token: 0x060056EC RID: 22252 RVA: 0x0002ECB4 File Offset: 0x0002CEB4
		public unsafe int preferentialEachPerson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_preferentialEachPerson);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_preferentialEachPerson)) = value;
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x060056ED RID: 22253 RVA: 0x001C35BC File Offset: 0x001C17BC
		// (set) Token: 0x060056EE RID: 22254 RVA: 0x0002ECCF File Offset: 0x0002CECF
		public unsafe float rewardMoveSpeedRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_rewardMoveSpeedRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_rewardMoveSpeedRate)) = value;
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x060056EF RID: 22255 RVA: 0x001C35E4 File Offset: 0x001C17E4
		// (set) Token: 0x060056F0 RID: 22256 RVA: 0x0002ECEA File Offset: 0x0002CEEA
		public unsafe float rewardCookSpeedRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_rewardCookSpeedRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_rewardCookSpeedRate)) = value;
			}
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x060056F1 RID: 22257 RVA: 0x001C360C File Offset: 0x001C180C
		// (set) Token: 0x060056F2 RID: 22258 RVA: 0x0002ED05 File Offset: 0x0002CF05
		public unsafe Queue<YuugiExtraDialogData.PartnerSpringData> targetPartner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_targetPartner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<YuugiExtraDialogData.PartnerSpringData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.NativeFieldInfoPtr_targetPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A1A RID: 14874
		private static readonly IntPtr NativeFieldInfoPtr_ABOUT_SPRING;

		// Token: 0x04003A1B RID: 14875
		private static readonly IntPtr NativeFieldInfoPtr_ACTION_CONSUMPTION;

		// Token: 0x04003A1C RID: 14876
		private static readonly IntPtr NativeFieldInfoPtr_openSpringEventId;

		// Token: 0x04003A1D RID: 14877
		private static readonly IntPtr NativeFieldInfoPtr_introduceSpringDialog;

		// Token: 0x04003A1E RID: 14878
		private static readonly IntPtr NativeFieldInfoPtr_springPriceConfirmSingleDialog;

		// Token: 0x04003A1F RID: 14879
		private static readonly IntPtr NativeFieldInfoPtr_springPriceConfirmMultiDialog;

		// Token: 0x04003A20 RID: 14880
		private static readonly IntPtr NativeFieldInfoPtr_springPriceConfirmTogetherDialog;

		// Token: 0x04003A21 RID: 14881
		private static readonly IntPtr NativeFieldInfoPtr_finalConfirmDialog;

		// Token: 0x04003A22 RID: 14882
		private static readonly IntPtr NativeFieldInfoPtr_endSpringDialog;

		// Token: 0x04003A23 RID: 14883
		private static readonly IntPtr NativeFieldInfoPtr_lackMoneyDialog;

		// Token: 0x04003A24 RID: 14884
		private static readonly IntPtr NativeFieldInfoPtr_showerCGGameObject;

		// Token: 0x04003A25 RID: 14885
		private static readonly IntPtr NativeFieldInfoPtr_mystiaData;

		// Token: 0x04003A26 RID: 14886
		private static readonly IntPtr NativeFieldInfoPtr_springData;

		// Token: 0x04003A27 RID: 14887
		private static readonly IntPtr NativeFieldInfoPtr_cost;

		// Token: 0x04003A28 RID: 14888
		private static readonly IntPtr NativeFieldInfoPtr_preferentialEachPerson;

		// Token: 0x04003A29 RID: 14889
		private static readonly IntPtr NativeFieldInfoPtr_rewardMoveSpeedRate;

		// Token: 0x04003A2A RID: 14890
		private static readonly IntPtr NativeFieldInfoPtr_rewardCookSpeedRate;

		// Token: 0x04003A2B RID: 14891
		private static readonly IntPtr NativeFieldInfoPtr_targetPartner;

		// Token: 0x04003A2C RID: 14892
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x04003A2D RID: 14893
		private static readonly IntPtr NativeMethodInfoPtr_GotoSpring_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003A2E RID: 14894
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerData_Private_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003A2F RID: 14895
		private static readonly IntPtr NativeMethodInfoPtr_GetExtraSelectionsCallback_Private_IEnumerable_1_ValueTuple_3_Object_String_String_0;

		// Token: 0x04003A30 RID: 14896
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Private_String_Object_0;

		// Token: 0x04003A31 RID: 14897
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectAllSelectionCallback_Private_ValueTuple_3_Int32_String_String_0;

		// Token: 0x04003A32 RID: 14898
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClosed_Private_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003A33 RID: 14899
		private static readonly IntPtr NativeMethodInfoPtr_AddExtraSpringBuffToWorkScene_Public_Void_Int32_0;

		// Token: 0x04003A34 RID: 14900
		private static readonly IntPtr NativeMethodInfoPtr_PlayConfirmDialog_Private_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003A35 RID: 14901
		private static readonly IntPtr NativeMethodInfoPtr_PlayConfirmDialogAsync_Private_UniTaskVoid_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003A36 RID: 14902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C75 RID: 3189
		public enum DLCMapping
		{
			// Token: 0x04009281 RID: 37505
			Main,
			// Token: 0x04009282 RID: 37506
			DLC1,
			// Token: 0x04009283 RID: 37507
			DLC2,
			// Token: 0x04009284 RID: 37508
			DLC3,
			// Token: 0x04009285 RID: 37509
			DLC4,
			// Token: 0x04009286 RID: 37510
			DLC5
		}

		// Token: 0x02000C76 RID: 3190
		public enum ShowerType
		{
			// Token: 0x04009288 RID: 37512
			Single,
			// Token: 0x04009289 RID: 37513
			Multi,
			// Token: 0x0400928A RID: 37514
			Together
		}

		// Token: 0x02000C77 RID: 3191
		[Serializable]
		public sealed class PartnerSpringData : ValueType
		{
			// Token: 0x0600E56F RID: 58735 RVA: 0x00371A8C File Offset: 0x0036FC8C
			// Note: this type is marked as 'beforefieldinit'.
			static PartnerSpringData()
			{
				Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "PartnerSpringData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr);
				YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_partnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr, "partnerId");
				YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_dLCMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr, "dLCMapping");
				YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_showerCG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr, "showerCG");
				YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_beginDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr, "beginDialog");
				YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_showeringDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr, "showeringDialog");
				YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_endDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr, "endDialog");
			}

			// Token: 0x0600E570 RID: 58736 RVA: 0x0007A7AF File Offset: 0x000789AF
			public PartnerSpringData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E571 RID: 58737 RVA: 0x0007A7B8 File Offset: 0x000789B8
			public PartnerSpringData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr))
			{
			}

			// Token: 0x17004A67 RID: 19047
			// (get) Token: 0x0600E572 RID: 58738 RVA: 0x00371B30 File Offset: 0x0036FD30
			// (set) Token: 0x0600E573 RID: 58739 RVA: 0x0007A7CA File Offset: 0x000789CA
			public unsafe int partnerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_partnerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_partnerId)) = value;
				}
			}

			// Token: 0x17004A68 RID: 19048
			// (get) Token: 0x0600E574 RID: 58740 RVA: 0x00371B58 File Offset: 0x0036FD58
			// (set) Token: 0x0600E575 RID: 58741 RVA: 0x0007A7E5 File Offset: 0x000789E5
			public unsafe YuugiExtraDialogData.DLCMapping dLCMapping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_dLCMapping);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_dLCMapping)) = value;
				}
			}

			// Token: 0x17004A69 RID: 19049
			// (get) Token: 0x0600E576 RID: 58742 RVA: 0x00371B80 File Offset: 0x0036FD80
			// (set) Token: 0x0600E577 RID: 58743 RVA: 0x0007A800 File Offset: 0x00078A00
			public unsafe Sprite showerCG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_showerCG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_showerCG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A6A RID: 19050
			// (get) Token: 0x0600E578 RID: 58744 RVA: 0x00371BB0 File Offset: 0x0036FDB0
			// (set) Token: 0x0600E579 RID: 58745 RVA: 0x0007A81F File Offset: 0x00078A1F
			public unsafe DialogPackage beginDialog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_beginDialog);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_beginDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A6B RID: 19051
			// (get) Token: 0x0600E57A RID: 58746 RVA: 0x00371BE0 File Offset: 0x0036FDE0
			// (set) Token: 0x0600E57B RID: 58747 RVA: 0x0007A83E File Offset: 0x00078A3E
			public unsafe DialogPackage showeringDialog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_showeringDialog);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_showeringDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A6C RID: 19052
			// (get) Token: 0x0600E57C RID: 58748 RVA: 0x00371C10 File Offset: 0x0036FE10
			// (set) Token: 0x0600E57D RID: 58749 RVA: 0x0007A85D File Offset: 0x00078A5D
			public unsafe DialogPackage endDialog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_endDialog);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.PartnerSpringData.NativeFieldInfoPtr_endDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400928B RID: 37515
			private static readonly IntPtr NativeFieldInfoPtr_partnerId;

			// Token: 0x0400928C RID: 37516
			private static readonly IntPtr NativeFieldInfoPtr_dLCMapping;

			// Token: 0x0400928D RID: 37517
			private static readonly IntPtr NativeFieldInfoPtr_showerCG;

			// Token: 0x0400928E RID: 37518
			private static readonly IntPtr NativeFieldInfoPtr_beginDialog;

			// Token: 0x0400928F RID: 37519
			private static readonly IntPtr NativeFieldInfoPtr_showeringDialog;

			// Token: 0x04009290 RID: 37520
			private static readonly IntPtr NativeFieldInfoPtr_endDialog;
		}

		// Token: 0x02000C78 RID: 3192
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YuugiExtraDialogData+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E57E RID: 58750 RVA: 0x00371C40 File Offset: 0x0036FE40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass21_0>.NativeClassPtr);
				YuugiExtraDialogData.__c__DisplayClass21_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass21_0>.NativeClassPtr, "specialNPCInteractData");
				YuugiExtraDialogData.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				YuugiExtraDialogData.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass21_0>.NativeClassPtr, "<>9__1");
				YuugiExtraDialogData.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass21_0>.NativeClassPtr, 100680952);
				YuugiExtraDialogData.__c__DisplayClass21_0.NativeMethodInfoPtr__GotoSpring_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass21_0>.NativeClassPtr, 100680953);
				YuugiExtraDialogData.__c__DisplayClass21_0.NativeMethodInfoPtr__GotoSpring_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass21_0>.NativeClassPtr, 100680954);
			}

			// Token: 0x0600E57F RID: 58751 RVA: 0x00371CE4 File Offset: 0x0036FEE4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E580 RID: 58752 RVA: 0x00371D20 File Offset: 0x0036FF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215031, XrefRangeEnd = 215042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GotoSpring_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass21_0.NativeMethodInfoPtr__GotoSpring_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E581 RID: 58753 RVA: 0x00371D54 File Offset: 0x0036FF54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215042, XrefRangeEnd = 215086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GotoSpring_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass21_0.NativeMethodInfoPtr__GotoSpring_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E582 RID: 58754 RVA: 0x0007A87C File Offset: 0x00078A7C
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A6D RID: 19053
			// (get) Token: 0x0600E583 RID: 58755 RVA: 0x00371D88 File Offset: 0x0036FF88
			// (set) Token: 0x0600E584 RID: 58756 RVA: 0x0007A885 File Offset: 0x00078A85
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass21_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass21_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A6E RID: 19054
			// (get) Token: 0x0600E585 RID: 58757 RVA: 0x00371DB8 File Offset: 0x0036FFB8
			// (set) Token: 0x0600E586 RID: 58758 RVA: 0x0007A8A4 File Offset: 0x00078AA4
			public unsafe YuugiExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuugiExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A6F RID: 19055
			// (get) Token: 0x0600E587 RID: 58759 RVA: 0x00371DE8 File Offset: 0x0036FFE8
			// (set) Token: 0x0600E588 RID: 58760 RVA: 0x0007A8C3 File Offset: 0x00078AC3
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009291 RID: 37521
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009292 RID: 37522
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009293 RID: 37523
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04009294 RID: 37524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009295 RID: 37525
			private static readonly IntPtr NativeMethodInfoPtr__GotoSpring_b__0_Internal_Void_0;

			// Token: 0x04009296 RID: 37526
			private static readonly IntPtr NativeMethodInfoPtr__GotoSpring_b__1_Internal_Void_0;
		}

		// Token: 0x02000C79 RID: 3193
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YuugiExtraDialogData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E589 RID: 58761 RVA: 0x00371E18 File Offset: 0x00370018
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr);
				YuugiExtraDialogData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, "<>9");
				YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, "<>9__22_0");
				YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, "<>9__22_1");
				YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__27_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, "<>9__27_5");
				YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__27_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, "<>9__27_6");
				YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, "<>9__30_1");
				YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, "<>9__30_2");
				YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, "<>9__30_7");
				YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, "<>9__30_3");
				YuugiExtraDialogData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, 100680956);
				YuugiExtraDialogData.__c.NativeMethodInfoPtr__GetPartnerData_b__22_0_Internal_Boolean_PartnerSpringData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, 100680957);
				YuugiExtraDialogData.__c.NativeMethodInfoPtr__GetPartnerData_b__22_1_Internal_Int32_PartnerSpringData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, 100680958);
				YuugiExtraDialogData.__c.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__27_5_Internal_Int32_PartnerSpringData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, 100680959);
				YuugiExtraDialogData.__c.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__27_6_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, 100680960);
				YuugiExtraDialogData.__c.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_1_Internal_Boolean_PartnerSpringData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, 100680961);
				YuugiExtraDialogData.__c.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_2_Internal_Int32_PartnerSpringData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, 100680962);
				YuugiExtraDialogData.__c.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_7_Internal_Boolean_PartnerSpringData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, 100680963);
				YuugiExtraDialogData.__c.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr, 100680964);
			}

			// Token: 0x0600E58A RID: 58762 RVA: 0x00371FAC File Offset: 0x003701AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E58B RID: 58763 RVA: 0x00371FE8 File Offset: 0x003701E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215086, XrefRangeEnd = 215090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPartnerData_b__22_0(YuugiExtraDialogData.PartnerSpringData z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(z));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c.NativeMethodInfoPtr__GetPartnerData_b__22_0_Internal_Boolean_PartnerSpringData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E58C RID: 58764 RVA: 0x0037203C File Offset: 0x0037023C
			[CallerCount(0)]
			public unsafe int _GetPartnerData_b__22_1(YuugiExtraDialogData.PartnerSpringData y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c.NativeMethodInfoPtr__GetPartnerData_b__22_1_Internal_Int32_PartnerSpringData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E58D RID: 58765 RVA: 0x00372090 File Offset: 0x00370290
			[CallerCount(0)]
			public unsafe int _AddExtraSpringBuffToWorkScene_b__27_5(YuugiExtraDialogData.PartnerSpringData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__27_5_Internal_Int32_PartnerSpringData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E58E RID: 58766 RVA: 0x003720E4 File Offset: 0x003702E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215090, XrefRangeEnd = 215094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddExtraSpringBuffToWorkScene_b__27_6(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__27_6_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E58F RID: 58767 RVA: 0x00372130 File Offset: 0x00370330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215094, XrefRangeEnd = 215098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayConfirmDialogAsync_b__30_1(YuugiExtraDialogData.PartnerSpringData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_1_Internal_Boolean_PartnerSpringData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E590 RID: 58768 RVA: 0x00372184 File Offset: 0x00370384
			[CallerCount(0)]
			public unsafe int _PlayConfirmDialogAsync_b__30_2(YuugiExtraDialogData.PartnerSpringData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_2_Internal_Int32_PartnerSpringData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E591 RID: 58769 RVA: 0x003721D8 File Offset: 0x003703D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215098, XrefRangeEnd = 215102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayConfirmDialogAsync_b__30_7(YuugiExtraDialogData.PartnerSpringData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_7_Internal_Boolean_PartnerSpringData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E592 RID: 58770 RVA: 0x0037222C File Offset: 0x0037042C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayConfirmDialogAsync_b__30_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E593 RID: 58771 RVA: 0x0007A8E2 File Offset: 0x00078AE2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A70 RID: 19056
			// (get) Token: 0x0600E594 RID: 58772 RVA: 0x00372260 File Offset: 0x00370460
			// (set) Token: 0x0600E595 RID: 58773 RVA: 0x0007A8EB File Offset: 0x00078AEB
			public unsafe static YuugiExtraDialogData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuugiExtraDialogData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A71 RID: 19057
			// (get) Token: 0x0600E596 RID: 58774 RVA: 0x00372288 File Offset: 0x00370488
			// (set) Token: 0x0600E597 RID: 58775 RVA: 0x0007A8FD File Offset: 0x00078AFD
			public unsafe static Func<YuugiExtraDialogData.PartnerSpringData, bool> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<YuugiExtraDialogData.PartnerSpringData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A72 RID: 19058
			// (get) Token: 0x0600E598 RID: 58776 RVA: 0x003722B0 File Offset: 0x003704B0
			// (set) Token: 0x0600E599 RID: 58777 RVA: 0x0007A90F File Offset: 0x00078B0F
			public unsafe static Func<YuugiExtraDialogData.PartnerSpringData, int> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<YuugiExtraDialogData.PartnerSpringData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A73 RID: 19059
			// (get) Token: 0x0600E59A RID: 58778 RVA: 0x003722D8 File Offset: 0x003704D8
			// (set) Token: 0x0600E59B RID: 58779 RVA: 0x0007A921 File Offset: 0x00078B21
			public unsafe static Func<YuugiExtraDialogData.PartnerSpringData, int> __9__27_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__27_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<YuugiExtraDialogData.PartnerSpringData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__27_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A74 RID: 19060
			// (get) Token: 0x0600E59C RID: 58780 RVA: 0x00372300 File Offset: 0x00370500
			// (set) Token: 0x0600E59D RID: 58781 RVA: 0x0007A933 File Offset: 0x00078B33
			public unsafe static Func<int, bool> __9__27_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__27_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__27_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A75 RID: 19061
			// (get) Token: 0x0600E59E RID: 58782 RVA: 0x00372328 File Offset: 0x00370528
			// (set) Token: 0x0600E59F RID: 58783 RVA: 0x0007A945 File Offset: 0x00078B45
			public unsafe static Func<YuugiExtraDialogData.PartnerSpringData, bool> __9__30_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<YuugiExtraDialogData.PartnerSpringData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A76 RID: 19062
			// (get) Token: 0x0600E5A0 RID: 58784 RVA: 0x00372350 File Offset: 0x00370550
			// (set) Token: 0x0600E5A1 RID: 58785 RVA: 0x0007A957 File Offset: 0x00078B57
			public unsafe static Func<YuugiExtraDialogData.PartnerSpringData, int> __9__30_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<YuugiExtraDialogData.PartnerSpringData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A77 RID: 19063
			// (get) Token: 0x0600E5A2 RID: 58786 RVA: 0x00372378 File Offset: 0x00370578
			// (set) Token: 0x0600E5A3 RID: 58787 RVA: 0x0007A969 File Offset: 0x00078B69
			public unsafe static Func<YuugiExtraDialogData.PartnerSpringData, bool> __9__30_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<YuugiExtraDialogData.PartnerSpringData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A78 RID: 19064
			// (get) Token: 0x0600E5A4 RID: 58788 RVA: 0x003723A0 File Offset: 0x003705A0
			// (set) Token: 0x0600E5A5 RID: 58789 RVA: 0x0007A97B File Offset: 0x00078B7B
			public unsafe static Action __9__30_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuugiExtraDialogData.__c.NativeFieldInfoPtr___9__30_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009297 RID: 37527
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009298 RID: 37528
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04009299 RID: 37529
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x0400929A RID: 37530
			private static readonly IntPtr NativeFieldInfoPtr___9__27_5;

			// Token: 0x0400929B RID: 37531
			private static readonly IntPtr NativeFieldInfoPtr___9__27_6;

			// Token: 0x0400929C RID: 37532
			private static readonly IntPtr NativeFieldInfoPtr___9__30_1;

			// Token: 0x0400929D RID: 37533
			private static readonly IntPtr NativeFieldInfoPtr___9__30_2;

			// Token: 0x0400929E RID: 37534
			private static readonly IntPtr NativeFieldInfoPtr___9__30_7;

			// Token: 0x0400929F RID: 37535
			private static readonly IntPtr NativeFieldInfoPtr___9__30_3;

			// Token: 0x040092A0 RID: 37536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092A1 RID: 37537
			private static readonly IntPtr NativeMethodInfoPtr__GetPartnerData_b__22_0_Internal_Boolean_PartnerSpringData_0;

			// Token: 0x040092A2 RID: 37538
			private static readonly IntPtr NativeMethodInfoPtr__GetPartnerData_b__22_1_Internal_Int32_PartnerSpringData_0;

			// Token: 0x040092A3 RID: 37539
			private static readonly IntPtr NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__27_5_Internal_Int32_PartnerSpringData_0;

			// Token: 0x040092A4 RID: 37540
			private static readonly IntPtr NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__27_6_Internal_Boolean_Int32_0;

			// Token: 0x040092A5 RID: 37541
			private static readonly IntPtr NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_1_Internal_Boolean_PartnerSpringData_0;

			// Token: 0x040092A6 RID: 37542
			private static readonly IntPtr NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_2_Internal_Int32_PartnerSpringData_0;

			// Token: 0x040092A7 RID: 37543
			private static readonly IntPtr NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_7_Internal_Boolean_PartnerSpringData_0;

			// Token: 0x040092A8 RID: 37544
			private static readonly IntPtr NativeMethodInfoPtr__PlayConfirmDialogAsync_b__30_3_Internal_Void_0;
		}

		// Token: 0x02000C7A RID: 3194
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YuugiExtraDialogData+<GetExtraSelectionsCallback>d__23")]
		public sealed class _GetExtraSelectionsCallback_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600E5A6 RID: 58790 RVA: 0x003723C8 File Offset: 0x003705C8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetExtraSelectionsCallback_d__23()
			{
				Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "<GetExtraSelectionsCallback>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr);
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, "<>1__state");
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, "<>2__current");
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, "<>l__initialThreadId");
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, 100680965);
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, 100680966);
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, 100680967);
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, 100680968);
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, 100680969);
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, 100680970);
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, 100680971);
				YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr, 100680972);
			}

			// Token: 0x0600E5A7 RID: 58791 RVA: 0x003724D0 File Offset: 0x003706D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetExtraSelectionsCallback_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData._GetExtraSelectionsCallback_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5A8 RID: 58792 RVA: 0x00372518 File Offset: 0x00370718
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5A9 RID: 58793 RVA: 0x0037254C File Offset: 0x0037074C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215102, XrefRangeEnd = 215113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A7C RID: 19068
			// (get) Token: 0x0600E5AA RID: 58794 RVA: 0x00372588 File Offset: 0x00370788
			public unsafe ValueTuple<Il2CppSystem.Object, string, string> prop_ValueTuple_3_Object_String_String_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_Object_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ValueTuple<Il2CppSystem.Object, string, string>(pointer);
				}
			}

			// Token: 0x0600E5AB RID: 58795 RVA: 0x003725C0 File Offset: 0x003707C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215113, XrefRangeEnd = 215119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A7D RID: 19069
			// (get) Token: 0x0600E5AC RID: 58796 RVA: 0x003725F4 File Offset: 0x003707F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215119, XrefRangeEnd = 215122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E5AD RID: 58797 RVA: 0x00372634 File Offset: 0x00370834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215122, XrefRangeEnd = 215124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<Il2CppSystem.Object, string, string>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Object_String_String_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Object_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<Il2CppSystem.Object, string, string>>>(intPtr3) : null;
			}

			// Token: 0x0600E5AE RID: 58798 RVA: 0x00372674 File Offset: 0x00370874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E5AF RID: 58799 RVA: 0x0007A98D File Offset: 0x00078B8D
			public _GetExtraSelectionsCallback_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A79 RID: 19065
			// (get) Token: 0x0600E5B0 RID: 58800 RVA: 0x003726B4 File Offset: 0x003708B4
			// (set) Token: 0x0600E5B1 RID: 58801 RVA: 0x0007A996 File Offset: 0x00078B96
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A7A RID: 19066
			// (get) Token: 0x0600E5B2 RID: 58802 RVA: 0x003726DC File Offset: 0x003708DC
			// (set) Token: 0x0600E5B3 RID: 58803 RVA: 0x0007A9B1 File Offset: 0x00078BB1
			public ValueTuple<Il2CppSystem.Object, string, string> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeFieldInfoPtr___2__current);
					return new ValueTuple<Il2CppSystem.Object, string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<Il2CppSystem.Object, string, string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<Il2CppSystem.Object, string, string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004A7B RID: 19067
			// (get) Token: 0x0600E5B4 RID: 58804 RVA: 0x0037270C File Offset: 0x0037090C
			// (set) Token: 0x0600E5B5 RID: 58805 RVA: 0x0007A9DF File Offset: 0x00078BDF
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._GetExtraSelectionsCallback_d__23.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040092A9 RID: 37545
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092AA RID: 37546
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092AB RID: 37547
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040092AC RID: 37548
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092AD RID: 37549
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092AE RID: 37550
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092AF RID: 37551
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_Object_String_String_0;

			// Token: 0x040092B0 RID: 37552
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092B1 RID: 37553
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092B2 RID: 37554
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Object_String_String_0;

			// Token: 0x040092B3 RID: 37555
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000C7B RID: 3195
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YuugiExtraDialogData+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E5B6 RID: 58806 RVA: 0x00372734 File Offset: 0x00370934
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr);
				YuugiExtraDialogData.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				YuugiExtraDialogData.__c__DisplayClass27_0.NativeFieldInfoPtr_partnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr, "partnerId");
				YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr, 100680973);
				YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr, 100680974);
				YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__4_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr, 100680975);
				YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__1_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr, 100680976);
				YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__2_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr, 100680977);
				YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__3_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr, 100680978);
			}

			// Token: 0x0600E5B7 RID: 58807 RVA: 0x00372800 File Offset: 0x00370A00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5B8 RID: 58808 RVA: 0x0037283C File Offset: 0x00370A3C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 215139, RefRangeEnd = 215143, XrefRangeStart = 215124, XrefRangeEnd = 215139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_Action_0(int thisPartnerId, Action onFinish)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref thisPartnerId;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5B9 RID: 58809 RVA: 0x0037288C File Offset: 0x00370A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215143, XrefRangeEnd = 215148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _AddExtraSpringBuffToWorkScene_b__4(int a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__4_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E5BA RID: 58810 RVA: 0x003728E4 File Offset: 0x00370AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215148, XrefRangeEnd = 215149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddExtraSpringBuffToWorkScene_b__1(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__1_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5BB RID: 58811 RVA: 0x00372928 File Offset: 0x00370B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddExtraSpringBuffToWorkScene_b__2(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__2_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5BC RID: 58812 RVA: 0x0037296C File Offset: 0x00370B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215149, XrefRangeEnd = 215150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddExtraSpringBuffToWorkScene_b__3(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass27_0.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__3_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5BD RID: 58813 RVA: 0x0007A9FA File Offset: 0x00078BFA
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A7E RID: 19070
			// (get) Token: 0x0600E5BE RID: 58814 RVA: 0x003729B0 File Offset: 0x00370BB0
			// (set) Token: 0x0600E5BF RID: 58815 RVA: 0x0007AA03 File Offset: 0x00078C03
			public unsafe YuugiExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuugiExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A7F RID: 19071
			// (get) Token: 0x0600E5C0 RID: 58816 RVA: 0x003729E0 File Offset: 0x00370BE0
			// (set) Token: 0x0600E5C1 RID: 58817 RVA: 0x0007AA22 File Offset: 0x00078C22
			public unsafe int partnerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass27_0.NativeFieldInfoPtr_partnerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass27_0.NativeFieldInfoPtr_partnerId)) = value;
				}
			}

			// Token: 0x040092B4 RID: 37556
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092B5 RID: 37557
			private static readonly IntPtr NativeFieldInfoPtr_partnerId;

			// Token: 0x040092B6 RID: 37558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092B7 RID: 37559
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_Action_0;

			// Token: 0x040092B8 RID: 37560
			private static readonly IntPtr NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__4_Internal_String_Int32_String_0;

			// Token: 0x040092B9 RID: 37561
			private static readonly IntPtr NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__1_Internal_Void_Action_0;

			// Token: 0x040092BA RID: 37562
			private static readonly IntPtr NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__2_Internal_Void_Action_0;

			// Token: 0x040092BB RID: 37563
			private static readonly IntPtr NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__3_Internal_Void_Action_0;
		}

		// Token: 0x02000C7C RID: 3196
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YuugiExtraDialogData+<>c__DisplayClass27_1")]
		public sealed class __c__DisplayClass27_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E5C2 RID: 58818 RVA: 0x00372A08 File Offset: 0x00370C08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_1()
			{
				Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "<>c__DisplayClass27_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_1>.NativeClassPtr);
				YuugiExtraDialogData.__c__DisplayClass27_1.NativeFieldInfoPtr_partner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_1>.NativeClassPtr, "partner");
				YuugiExtraDialogData.__c__DisplayClass27_1.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_1>.NativeClassPtr, "CS$<>8__locals1");
				YuugiExtraDialogData.__c__DisplayClass27_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_1>.NativeClassPtr, 100680979);
				YuugiExtraDialogData.__c__DisplayClass27_1.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__7_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_1>.NativeClassPtr, 100680980);
			}

			// Token: 0x0600E5C3 RID: 58819 RVA: 0x00372A84 File Offset: 0x00370C84
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass27_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass27_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5C4 RID: 58820 RVA: 0x00372AC0 File Offset: 0x00370CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215150, XrefRangeEnd = 215152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddExtraSpringBuffToWorkScene_b__7(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass27_1.NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__7_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5C5 RID: 58821 RVA: 0x0007AA3D File Offset: 0x00078C3D
			public __c__DisplayClass27_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A80 RID: 19072
			// (get) Token: 0x0600E5C6 RID: 58822 RVA: 0x00372B04 File Offset: 0x00370D04
			// (set) Token: 0x0600E5C7 RID: 58823 RVA: 0x0007AA46 File Offset: 0x00078C46
			public unsafe int partner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass27_1.NativeFieldInfoPtr_partner);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass27_1.NativeFieldInfoPtr_partner)) = value;
				}
			}

			// Token: 0x17004A81 RID: 19073
			// (get) Token: 0x0600E5C8 RID: 58824 RVA: 0x00372B2C File Offset: 0x00370D2C
			// (set) Token: 0x0600E5C9 RID: 58825 RVA: 0x0007AA61 File Offset: 0x00078C61
			public unsafe YuugiExtraDialogData.__c__DisplayClass27_0 field_Public___c__DisplayClass27_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass27_1.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuugiExtraDialogData.__c__DisplayClass27_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass27_1.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092BC RID: 37564
			private static readonly IntPtr NativeFieldInfoPtr_partner;

			// Token: 0x040092BD RID: 37565
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0;

			// Token: 0x040092BE RID: 37566
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092BF RID: 37567
			private static readonly IntPtr NativeMethodInfoPtr__AddExtraSpringBuffToWorkScene_b__7_Internal_Void_Action_0;
		}

		// Token: 0x02000C7D RID: 3197
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YuugiExtraDialogData+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E5CA RID: 58826 RVA: 0x00372B5C File Offset: 0x00370D5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr);
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_costMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, "costMoney");
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_partnerDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, "partnerDic");
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_canvasGroup1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, "canvasGroup1");
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_showerGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, "showerGameObject");
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_endDialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, "endDialogs");
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_overrideTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, "overrideTexts");
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr___9__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, "<>9__11");
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, 100680981);
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__0_Internal_Dictionary_2_Int32_String_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, 100680982);
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__9_Internal_Void_PartnerSpringData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, 100680983);
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__8_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, 100680984);
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__4_Internal_Void_PartnerSpringData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, 100680985);
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, 100680986);
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, 100680987);
				YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_Dictionary_2_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, 100680988);
			}

			// Token: 0x0600E5CB RID: 58827 RVA: 0x00372CC8 File Offset: 0x00370EC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5CC RID: 58828 RVA: 0x00372D04 File Offset: 0x00370F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215219, XrefRangeEnd = 215229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<int, string> _PlayConfirmDialogAsync_b__0(Dictionary<int, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__0_Internal_Dictionary_2_Int32_String_Dictionary_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}

			// Token: 0x0600E5CD RID: 58829 RVA: 0x00372D54 File Offset: 0x00370F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215229, XrefRangeEnd = 215232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayConfirmDialogAsync_b__9(YuugiExtraDialogData.PartnerSpringData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__9_Internal_Void_PartnerSpringData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5CE RID: 58830 RVA: 0x00372D9C File Offset: 0x00370F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215232, XrefRangeEnd = 215238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayConfirmDialogAsync_b__8(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__8_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5CF RID: 58831 RVA: 0x00372DDC File Offset: 0x00370FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215238, XrefRangeEnd = 215240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayConfirmDialogAsync_b__4(YuugiExtraDialogData.PartnerSpringData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__4_Internal_Void_PartnerSpringData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5D0 RID: 58832 RVA: 0x00372E24 File Offset: 0x00371024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215240, XrefRangeEnd = 215245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayConfirmDialogAsync_b__11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5D1 RID: 58833 RVA: 0x00372E68 File Offset: 0x00371068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215245, XrefRangeEnd = 215251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask Method_Internal_UniTask_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x0600E5D2 RID: 58834 RVA: 0x00372EA0 File Offset: 0x003710A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215251, XrefRangeEnd = 215252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Dictionary_2_Int32_String_PDM_0(Dictionary<int, string> texts)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_Dictionary_2_Int32_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5D3 RID: 58835 RVA: 0x0007AA80 File Offset: 0x00078C80
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A82 RID: 19074
			// (get) Token: 0x0600E5D4 RID: 58836 RVA: 0x00372EE4 File Offset: 0x003710E4
			// (set) Token: 0x0600E5D5 RID: 58837 RVA: 0x0007AA89 File Offset: 0x00078C89
			public unsafe int costMoney
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_costMoney);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_costMoney)) = value;
				}
			}

			// Token: 0x17004A83 RID: 19075
			// (get) Token: 0x0600E5D6 RID: 58838 RVA: 0x00372F0C File Offset: 0x0037110C
			// (set) Token: 0x0600E5D7 RID: 58839 RVA: 0x0007AAA4 File Offset: 0x00078CA4
			public unsafe YuugiExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuugiExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A84 RID: 19076
			// (get) Token: 0x0600E5D8 RID: 58840 RVA: 0x00372F3C File Offset: 0x0037113C
			// (set) Token: 0x0600E5D9 RID: 58841 RVA: 0x0007AAC3 File Offset: 0x00078CC3
			public unsafe Dictionary<int, YuugiExtraDialogData.PartnerSpringData> partnerDic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_partnerDic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, YuugiExtraDialogData.PartnerSpringData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_partnerDic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A85 RID: 19077
			// (get) Token: 0x0600E5DA RID: 58842 RVA: 0x00372F6C File Offset: 0x0037116C
			// (set) Token: 0x0600E5DB RID: 58843 RVA: 0x0007AAE2 File Offset: 0x00078CE2
			public unsafe CanvasGroup canvasGroup1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_canvasGroup1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_canvasGroup1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A86 RID: 19078
			// (get) Token: 0x0600E5DC RID: 58844 RVA: 0x00372F9C File Offset: 0x0037119C
			// (set) Token: 0x0600E5DD RID: 58845 RVA: 0x0007AB01 File Offset: 0x00078D01
			public unsafe GameObject showerGameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_showerGameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_showerGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A87 RID: 19079
			// (get) Token: 0x0600E5DE RID: 58846 RVA: 0x00372FCC File Offset: 0x003711CC
			// (set) Token: 0x0600E5DF RID: 58847 RVA: 0x0007AB20 File Offset: 0x00078D20
			public unsafe Queue<DialogPackage> endDialogs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_endDialogs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_endDialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A88 RID: 19080
			// (get) Token: 0x0600E5E0 RID: 58848 RVA: 0x00372FFC File Offset: 0x003711FC
			// (set) Token: 0x0600E5E1 RID: 58849 RVA: 0x0007AB3F File Offset: 0x00078D3F
			public unsafe Func<Dictionary<int, string>, Dictionary<int, string>> overrideTexts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_overrideTexts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Dictionary<int, string>, Dictionary<int, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr_overrideTexts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A89 RID: 19081
			// (get) Token: 0x0600E5E2 RID: 58850 RVA: 0x0037302C File Offset: 0x0037122C
			// (set) Token: 0x0600E5E3 RID: 58851 RVA: 0x0007AB5E File Offset: 0x00078D5E
			public unsafe Action<Image> __9__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr___9__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.NativeFieldInfoPtr___9__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092C0 RID: 37568
			private static readonly IntPtr NativeFieldInfoPtr_costMoney;

			// Token: 0x040092C1 RID: 37569
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092C2 RID: 37570
			private static readonly IntPtr NativeFieldInfoPtr_partnerDic;

			// Token: 0x040092C3 RID: 37571
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup1;

			// Token: 0x040092C4 RID: 37572
			private static readonly IntPtr NativeFieldInfoPtr_showerGameObject;

			// Token: 0x040092C5 RID: 37573
			private static readonly IntPtr NativeFieldInfoPtr_endDialogs;

			// Token: 0x040092C6 RID: 37574
			private static readonly IntPtr NativeFieldInfoPtr_overrideTexts;

			// Token: 0x040092C7 RID: 37575
			private static readonly IntPtr NativeFieldInfoPtr___9__11;

			// Token: 0x040092C8 RID: 37576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092C9 RID: 37577
			private static readonly IntPtr NativeMethodInfoPtr__PlayConfirmDialogAsync_b__0_Internal_Dictionary_2_Int32_String_Dictionary_2_Int32_String_0;

			// Token: 0x040092CA RID: 37578
			private static readonly IntPtr NativeMethodInfoPtr__PlayConfirmDialogAsync_b__9_Internal_Void_PartnerSpringData_0;

			// Token: 0x040092CB RID: 37579
			private static readonly IntPtr NativeMethodInfoPtr__PlayConfirmDialogAsync_b__8_Internal_Void_Int32_0;

			// Token: 0x040092CC RID: 37580
			private static readonly IntPtr NativeMethodInfoPtr__PlayConfirmDialogAsync_b__4_Internal_Void_PartnerSpringData_0;

			// Token: 0x040092CD RID: 37581
			private static readonly IntPtr NativeMethodInfoPtr__PlayConfirmDialogAsync_b__11_Internal_Void_Image_0;

			// Token: 0x040092CE RID: 37582
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0;

			// Token: 0x040092CF RID: 37583
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Dictionary_2_Int32_String_PDM_0;

			// Token: 0x0200105A RID: 4186
			[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YuugiExtraDialogData+<>c__DisplayClass30_0+<<PlayConfirmDialogAsync>g__OnCustomEventEnd|5>d")]
			public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique : ValueType
			{
				// Token: 0x06011E4C RID: 73292 RVA: 0x00417A40 File Offset: 0x00415C40
				// Note: this type is marked as 'beforefieldinit'.
				static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique()
				{
					Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0>.NativeClassPtr, "<<PlayConfirmDialogAsync>g__OnCustomEventEnd|5>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr);
					YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>1__state");
					YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>t__builder");
					YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>4__this");
					YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>u__1");
					YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, 100680989);
					YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, 100680990);
				}

				// Token: 0x06011E4D RID: 73293 RVA: 0x00417AE4 File Offset: 0x00415CE4
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 215217, RefRangeEnd = 215219, XrefRangeStart = 215152, XrefRangeEnd = 215217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E4E RID: 73294 RVA: 0x00417B1C File Offset: 0x00415D1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E4F RID: 73295 RVA: 0x0009B761 File Offset: 0x00099961
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x06011E50 RID: 73296 RVA: 0x0009B76A File Offset: 0x0009996A
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr))
				{
				}

				// Token: 0x17005D45 RID: 23877
				// (get) Token: 0x06011E51 RID: 73297 RVA: 0x00417B64 File Offset: 0x00415D64
				// (set) Token: 0x06011E52 RID: 73298 RVA: 0x0009B77C File Offset: 0x0009997C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D46 RID: 23878
				// (get) Token: 0x06011E53 RID: 73299 RVA: 0x00417B8C File Offset: 0x00415D8C
				// (set) Token: 0x06011E54 RID: 73300 RVA: 0x0009B797 File Offset: 0x00099997
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005D47 RID: 23879
				// (get) Token: 0x06011E55 RID: 73301 RVA: 0x00417BBC File Offset: 0x00415DBC
				// (set) Token: 0x06011E56 RID: 73302 RVA: 0x0009B7C5 File Offset: 0x000999C5
				public unsafe YuugiExtraDialogData.__c__DisplayClass30_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuugiExtraDialogData.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D48 RID: 23880
				// (get) Token: 0x06011E57 RID: 73303 RVA: 0x00417BEC File Offset: 0x00415DEC
				// (set) Token: 0x06011E58 RID: 73304 RVA: 0x0009B7E4 File Offset: 0x000999E4
				public UniTask.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B4D6 RID: 46294
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B4D7 RID: 46295
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B4D8 RID: 46296
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B4D9 RID: 46297
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B4DA RID: 46298
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4DB RID: 46299
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x02000C7E RID: 3198
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YuugiExtraDialogData+<>c__DisplayClass30_1")]
		public sealed class __c__DisplayClass30_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E5E4 RID: 58852 RVA: 0x0037305C File Offset: 0x0037125C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_1()
			{
				Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "<>c__DisplayClass30_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_1>.NativeClassPtr);
				YuugiExtraDialogData.__c__DisplayClass30_1.NativeFieldInfoPtr_firstPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_1>.NativeClassPtr, "firstPartner");
				YuugiExtraDialogData.__c__DisplayClass30_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_1>.NativeClassPtr, 100680991);
				YuugiExtraDialogData.__c__DisplayClass30_1.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_1>.NativeClassPtr, 100680992);
			}

			// Token: 0x0600E5E5 RID: 58853 RVA: 0x003730C4 File Offset: 0x003712C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData.__c__DisplayClass30_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5E6 RID: 58854 RVA: 0x00373100 File Offset: 0x00371300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayConfirmDialogAsync_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData.__c__DisplayClass30_1.NativeMethodInfoPtr__PlayConfirmDialogAsync_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5E7 RID: 58855 RVA: 0x0007AB7D File Offset: 0x00078D7D
			public __c__DisplayClass30_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A8A RID: 19082
			// (get) Token: 0x0600E5E8 RID: 58856 RVA: 0x00373144 File Offset: 0x00371344
			// (set) Token: 0x0600E5E9 RID: 58857 RVA: 0x0007AB86 File Offset: 0x00078D86
			public YuugiExtraDialogData.PartnerSpringData firstPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_1.NativeFieldInfoPtr_firstPartner);
					return new YuugiExtraDialogData.PartnerSpringData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData.__c__DisplayClass30_1.NativeFieldInfoPtr_firstPartner), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<YuugiExtraDialogData.PartnerSpringData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040092D0 RID: 37584
			private static readonly IntPtr NativeFieldInfoPtr_firstPartner;

			// Token: 0x040092D1 RID: 37585
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092D2 RID: 37586
			private static readonly IntPtr NativeMethodInfoPtr__PlayConfirmDialogAsync_b__10_Internal_Void_Image_0;
		}

		// Token: 0x02000C7F RID: 3199
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YuugiExtraDialogData+<PlayConfirmDialogAsync>d__30")]
		public sealed class _PlayConfirmDialogAsync_d__30 : ValueType
		{
			// Token: 0x0600E5EA RID: 58858 RVA: 0x00373174 File Offset: 0x00371374
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayConfirmDialogAsync_d__30()
			{
				Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuugiExtraDialogData>.NativeClassPtr, "<PlayConfirmDialogAsync>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr);
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, "<>1__state");
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, "<>t__builder");
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, "<>4__this");
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr_partnerIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, "partnerIds");
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, "<>8__1");
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, "<>8__2");
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr__uiElement_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, "<uiElement>5__2");
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, "<>u__1");
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, "<>u__2");
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, 100680993);
				YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr, 100680994);
			}

			// Token: 0x0600E5EB RID: 58859 RVA: 0x0037327C File Offset: 0x0037147C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 215660, RefRangeEnd = 215662, XrefRangeStart = 215252, XrefRangeEnd = 215660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5EC RID: 58860 RVA: 0x003732B4 File Offset: 0x003714B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5ED RID: 58861 RVA: 0x0007ABB4 File Offset: 0x00078DB4
			public _PlayConfirmDialogAsync_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E5EE RID: 58862 RVA: 0x0007ABBD File Offset: 0x00078DBD
			public _PlayConfirmDialogAsync_d__30() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuugiExtraDialogData._PlayConfirmDialogAsync_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x17004A8B RID: 19083
			// (get) Token: 0x0600E5EF RID: 58863 RVA: 0x003732FC File Offset: 0x003714FC
			// (set) Token: 0x0600E5F0 RID: 58864 RVA: 0x0007ABCF File Offset: 0x00078DCF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A8C RID: 19084
			// (get) Token: 0x0600E5F1 RID: 58865 RVA: 0x00373324 File Offset: 0x00371524
			// (set) Token: 0x0600E5F2 RID: 58866 RVA: 0x0007ABEA File Offset: 0x00078DEA
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004A8D RID: 19085
			// (get) Token: 0x0600E5F3 RID: 58867 RVA: 0x00373354 File Offset: 0x00371554
			// (set) Token: 0x0600E5F4 RID: 58868 RVA: 0x0007AC18 File Offset: 0x00078E18
			public unsafe YuugiExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuugiExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A8E RID: 19086
			// (get) Token: 0x0600E5F5 RID: 58869 RVA: 0x00373384 File Offset: 0x00371584
			// (set) Token: 0x0600E5F6 RID: 58870 RVA: 0x0007AC37 File Offset: 0x00078E37
			public unsafe Il2CppStructArray<int> partnerIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr_partnerIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr_partnerIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A8F RID: 19087
			// (get) Token: 0x0600E5F7 RID: 58871 RVA: 0x003733B4 File Offset: 0x003715B4
			// (set) Token: 0x0600E5F8 RID: 58872 RVA: 0x0007AC56 File Offset: 0x00078E56
			public unsafe YuugiExtraDialogData.__c__DisplayClass30_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuugiExtraDialogData.__c__DisplayClass30_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A90 RID: 19088
			// (get) Token: 0x0600E5F9 RID: 58873 RVA: 0x003733E4 File Offset: 0x003715E4
			// (set) Token: 0x0600E5FA RID: 58874 RVA: 0x0007AC75 File Offset: 0x00078E75
			public unsafe YuugiExtraDialogData.__c__DisplayClass30_1 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuugiExtraDialogData.__c__DisplayClass30_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A91 RID: 19089
			// (get) Token: 0x0600E5FB RID: 58875 RVA: 0x00373414 File Offset: 0x00371614
			// (set) Token: 0x0600E5FC RID: 58876 RVA: 0x0007AC94 File Offset: 0x00078E94
			public unsafe UIElementCluster _uiElement_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr__uiElement_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr__uiElement_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A92 RID: 19090
			// (get) Token: 0x0600E5FD RID: 58877 RVA: 0x00373444 File Offset: 0x00371644
			// (set) Token: 0x0600E5FE RID: 58878 RVA: 0x0007ACB3 File Offset: 0x00078EB3
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004A93 RID: 19091
			// (get) Token: 0x0600E5FF RID: 58879 RVA: 0x00373474 File Offset: 0x00371674
			// (set) Token: 0x0600E600 RID: 58880 RVA: 0x0007ACE1 File Offset: 0x00078EE1
			public UniTask<bool>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___u__2);
					return new UniTask<bool>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuugiExtraDialogData._PlayConfirmDialogAsync_d__30.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040092D3 RID: 37587
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092D4 RID: 37588
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040092D5 RID: 37589
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092D6 RID: 37590
			private static readonly IntPtr NativeFieldInfoPtr_partnerIds;

			// Token: 0x040092D7 RID: 37591
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040092D8 RID: 37592
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x040092D9 RID: 37593
			private static readonly IntPtr NativeFieldInfoPtr__uiElement_5__2;

			// Token: 0x040092DA RID: 37594
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040092DB RID: 37595
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040092DC RID: 37596
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092DD RID: 37597
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
