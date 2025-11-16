using System;
using System.Runtime.InteropServices;
using Common.CharacterUtility;
using DayScene.Input;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x0200031F RID: 799
	public class PartnerInfoBase : ScriptableObject
	{
		// Token: 0x06005EB2 RID: 24242 RVA: 0x001D93D8 File Offset: 0x001D75D8
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoBase()
		{
			Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr);
			PartnerInfoBase.NativeFieldInfoPtr_partnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "partnerId");
			PartnerInfoBase.NativeFieldInfoPtr_partnerCut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "partnerCut");
			PartnerInfoBase.NativeFieldInfoPtr_addToInventoryDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "addToInventoryDelay");
			PartnerInfoBase.NativeFieldInfoPtr_extractFromInventoryDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "extractFromInventoryDelay");
			PartnerInfoBase.NativeFieldInfoPtr_deliverDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "deliverDelay");
			PartnerInfoBase.NativeFieldInfoPtr_banSGuestToSpawnId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "banSGuestToSpawnId");
			PartnerInfoBase.NativeFieldInfoPtr_companionPartners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "companionPartners");
			PartnerInfoBase.NativeFieldInfoPtr_notUseCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "notUseCollider");
			PartnerInfoBase.NativeFieldInfoPtr_workSpeedLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "workSpeedLiteral");
			PartnerInfoBase.NativeFieldInfoPtr_moveSpdMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "moveSpdMultiplier");
			PartnerInfoBase.NativeMethodInfoPtr_get_PartnerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682753);
			PartnerInfoBase.NativeMethodInfoPtr_get_PartnerCut_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682754);
			PartnerInfoBase.NativeMethodInfoPtr_get_AddToInventoryDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682755);
			PartnerInfoBase.NativeMethodInfoPtr_get_ExtractFromInventoryDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682756);
			PartnerInfoBase.NativeMethodInfoPtr_get_DeliverDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682757);
			PartnerInfoBase.NativeMethodInfoPtr_get_WorkSpeedLiteral_Public_get_Speed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682758);
			PartnerInfoBase.NativeMethodInfoPtr_get_MoveSpdMultiplier_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682759);
			PartnerInfoBase.NativeMethodInfoPtr_get_NotUseCollider_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682760);
			PartnerInfoBase.NativeMethodInfoPtr_get_BanGuestId_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682761);
			PartnerInfoBase.NativeMethodInfoPtr_get_CompanionPartners_Public_get_Il2CppStructArray_1_CompanionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682762);
			PartnerInfoBase.NativeMethodInfoPtr_get_UiAnimationFieldFront_Protected_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682763);
			PartnerInfoBase.NativeMethodInfoPtr_get_UiAnimationFieldTop_Protected_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682764);
			PartnerInfoBase.NativeMethodInfoPtr_get_UiAnimationFieldMiddle_Protected_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682765);
			PartnerInfoBase.NativeMethodInfoPtr_get_UiAnimationFieldBack_Protected_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682766);
			PartnerInfoBase.NativeMethodInfoPtr_get_IfNeverWork_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682767);
			PartnerInfoBase.NativeMethodInfoPtr_get_HasWorkSleepLoop_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682768);
			PartnerInfoBase.NativeMethodInfoPtr_get_WorkTime_Protected_Virtual_New_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682769);
			PartnerInfoBase.NativeMethodInfoPtr_get_SleepTime_Protected_Virtual_New_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682770);
			PartnerInfoBase.NativeMethodInfoPtr_get_PartnerDeliverType_Public_Virtual_New_get_DeliverType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682771);
			PartnerInfoBase.NativeMethodInfoPtr_GetPartnerType_Public_Virtual_New_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682772);
			PartnerInfoBase.NativeMethodInfoPtr_GetWorldToScreenPoint_Protected_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682773);
			PartnerInfoBase.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_New_Single_CookController_Sellable_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682774);
			PartnerInfoBase.NativeMethodInfoPtr_OnGetOverrideFinalCookResult_Public_Virtual_New_Sellable_CookController_Sellable_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682775);
			PartnerInfoBase.NativeMethodInfoPtr_get_AdditionalDataRequirement_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682776);
			PartnerInfoBase.NativeMethodInfoPtr_get_TotalAdditionalDataRequirement_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682777);
			PartnerInfoBase.NativeMethodInfoPtr_PreloadPartner_Public_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682778);
			PartnerInfoBase.NativeMethodInfoPtr_GetCompanionPartnerType_Public_Virtual_New_Il2CppReferenceArray_1_ValueTuple_2_CompanionProperty_PartnerType_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682779);
			PartnerInfoBase.NativeMethodInfoPtr_OnInventoryUpdate_Public_Virtual_New_Void_PartnerBase_EventManager_PartnerManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682780);
			PartnerInfoBase.NativeMethodInfoPtr_WorkSleepLoop_Private_IEnumerator_PartnerBase_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682781);
			PartnerInfoBase.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_New_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682782);
			PartnerInfoBase.NativeMethodInfoPtr_ReleasePartner_Public_Void_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682783);
			PartnerInfoBase.NativeMethodInfoPtr_MoveCharacter_Public_Virtual_New_Void_AStarInputGeneratorComponent_TileManager_Vector3Int_Vector3_CharacterRotation_Action_PartnerManager_Boolean_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682784);
			PartnerInfoBase.NativeMethodInfoPtr_ExternalStop_Public_Virtual_New_Void_AStarInputGeneratorComponent_PartnerManager_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682785);
			PartnerInfoBase.NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682786);
			PartnerInfoBase.NativeMethodInfoPtr_GetText_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682787);
			PartnerInfoBase.NativeMethodInfoPtr_FormatString_Protected_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682788);
			PartnerInfoBase.NativeMethodInfoPtr_GetSpeedLang_Protected_Static_String_Speed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682789);
			PartnerInfoBase.NativeMethodInfoPtr_GetMoveSpeedText_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682790);
			PartnerInfoBase.NativeMethodInfoPtr_GetWorkSpeedText_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682791);
			PartnerInfoBase.NativeMethodInfoPtr_PreProcessInfo_Protected_Virtual_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682792);
			PartnerInfoBase.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682793);
			PartnerInfoBase.NativeMethodInfoPtr_get_DoNotShowRevenueCut_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682794);
			PartnerInfoBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, 100682795);
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x001D982C File Offset: 0x001D7A2C
		public unsafe int PartnerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_PartnerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06005EB4 RID: 24244 RVA: 0x001D9868 File Offset: 0x001D7A68
		public unsafe float PartnerCut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_PartnerCut_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06005EB5 RID: 24245 RVA: 0x001D98A4 File Offset: 0x001D7AA4
		public unsafe float AddToInventoryDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_AddToInventoryDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06005EB6 RID: 24246 RVA: 0x001D98E0 File Offset: 0x001D7AE0
		public unsafe float ExtractFromInventoryDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_ExtractFromInventoryDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06005EB7 RID: 24247 RVA: 0x001D991C File Offset: 0x001D7B1C
		public unsafe float DeliverDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_DeliverDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06005EB8 RID: 24248 RVA: 0x001D9958 File Offset: 0x001D7B58
		public unsafe PartnerInfoBase.Speed WorkSpeedLiteral
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_WorkSpeedLiteral_Public_get_Speed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06005EB9 RID: 24249 RVA: 0x001D9994 File Offset: 0x001D7B94
		public unsafe virtual float MoveSpdMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_get_MoveSpdMultiplier_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06005EBA RID: 24250 RVA: 0x001D99DC File Offset: 0x001D7BDC
		public unsafe bool NotUseCollider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_NotUseCollider_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06005EBB RID: 24251 RVA: 0x001D9A18 File Offset: 0x001D7C18
		public unsafe IEnumerable<int> BanGuestId
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 234849, RefRangeEnd = 234852, XrefRangeStart = 234843, XrefRangeEnd = 234849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_BanGuestId_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06005EBC RID: 24252 RVA: 0x001D9A58 File Offset: 0x001D7C58
		public unsafe Il2CppStructArray<PartnerInfoBase.CompanionProperty> CompanionPartners
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 234857, RefRangeEnd = 234860, XrefRangeStart = 234852, XrefRangeEnd = 234857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_CompanionPartners_Public_get_Il2CppStructArray_1_CompanionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PartnerInfoBase.CompanionProperty>>(intPtr3) : null;
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06005EBD RID: 24253 RVA: 0x001D9A98 File Offset: 0x001D7C98
		public unsafe Transform UiAnimationFieldFront
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234860, XrefRangeEnd = 234863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_UiAnimationFieldFront_Protected_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x06005EBE RID: 24254 RVA: 0x001D9AD8 File Offset: 0x001D7CD8
		public unsafe Transform UiAnimationFieldTop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234863, XrefRangeEnd = 234866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_UiAnimationFieldTop_Protected_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x06005EBF RID: 24255 RVA: 0x001D9B18 File Offset: 0x001D7D18
		public unsafe Transform UiAnimationFieldMiddle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 234869, RefRangeEnd = 234870, XrefRangeStart = 234866, XrefRangeEnd = 234869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_UiAnimationFieldMiddle_Protected_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x06005EC0 RID: 24256 RVA: 0x001D9B58 File Offset: 0x001D7D58
		public unsafe Transform UiAnimationFieldBack
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234870, XrefRangeEnd = 234873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_UiAnimationFieldBack_Protected_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x06005EC1 RID: 24257 RVA: 0x001D9B98 File Offset: 0x001D7D98
		public unsafe virtual bool IfNeverWork
		{
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_get_IfNeverWork_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x06005EC2 RID: 24258 RVA: 0x001D9BE0 File Offset: 0x001D7DE0
		public unsafe virtual bool HasWorkSleepLoop
		{
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_get_HasWorkSleepLoop_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x001D9C28 File Offset: 0x001D7E28
		public unsafe virtual Vector2Int WorkTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_get_WorkTime_Protected_Virtual_New_get_Vector2Int_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06005EC4 RID: 24260 RVA: 0x001D9C70 File Offset: 0x001D7E70
		public unsafe virtual Vector2Int SleepTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_get_SleepTime_Protected_Virtual_New_get_Vector2Int_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x06005EC5 RID: 24261 RVA: 0x001D9CB8 File Offset: 0x001D7EB8
		public unsafe virtual PartnerInfoBase.DeliverType PartnerDeliverType
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_get_PartnerDeliverType_Public_Virtual_New_get_DeliverType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x001D9D00 File Offset: 0x001D7F00
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PartnerInfoBase.PartnerType GetPartnerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_GetPartnerType_Public_Virtual_New_PartnerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x001D9D48 File Offset: 0x001D7F48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193475, RefRangeEnd = 193478, XrefRangeStart = 193475, XrefRangeEnd = 193478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetWorldToScreenPoint(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_GetWorldToScreenPoint_Protected_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x001D9D94 File Offset: 0x001D7F94
		[CallerCount(0)]
		public unsafe virtual float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseSpeed, ref bool doNotCostIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseSpeed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &doNotCostIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_New_Single_CookController_Sellable_Single_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005EC9 RID: 24265 RVA: 0x001D9E1C File Offset: 0x001D801C
		[CallerCount(0)]
		public unsafe virtual Sellable OnGetOverrideFinalCookResult(CookController cooker, Sellable lastFood, out bool isRequestedFood)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastFood);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isRequestedFood;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_OnGetOverrideFinalCookResult_Public_Virtual_New_Sellable_CookController_Sellable_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x06005ECA RID: 24266 RVA: 0x001D9E98 File Offset: 0x001D8098
		public unsafe virtual int AdditionalDataRequirement
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_get_AdditionalDataRequirement_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06005ECB RID: 24267 RVA: 0x001D9EE0 File Offset: 0x001D80E0
		public unsafe int TotalAdditionalDataRequirement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_get_TotalAdditionalDataRequirement_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005ECC RID: 24268 RVA: 0x001D9F1C File Offset: 0x001D811C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234891, RefRangeEnd = 234892, XrefRangeStart = 234873, XrefRangeEnd = 234891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreloadPartner(PartnerBase currentPartner, EventManager eventManager, PartnerManager manager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPartner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_PreloadPartner_Public_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECD RID: 24269 RVA: 0x001D9F98 File Offset: 0x001D8198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234892, XrefRangeEnd = 234911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<ValueTuple<PartnerInfoBase.CompanionProperty, PartnerBase.PartnerType>> GetCompanionPartnerType(PartnerBase currentPartner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPartner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_GetCompanionPartnerType_Public_Virtual_New_Il2CppReferenceArray_1_ValueTuple_2_CompanionProperty_PartnerType_PartnerBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<PartnerInfoBase.CompanionProperty, PartnerBase.PartnerType>>>(intPtr3) : null;
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x001D9FF4 File Offset: 0x001D81F4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInventoryUpdate(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_OnInventoryUpdate_Public_Virtual_New_Void_PartnerBase_EventManager_PartnerManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x001DA068 File Offset: 0x001D8268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234911, XrefRangeEnd = 234918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WorkSleepLoop(PartnerBase currentPartner, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPartner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_WorkSleepLoop_Private_IEnumerator_PartnerBase_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x001DA0CC File Offset: 0x001D82CC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_New_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x001DA150 File Offset: 0x001D8350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234918, XrefRangeEnd = 234921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePartner(PartnerManager partnerManager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_ReleasePartner_Public_Void_PartnerManager_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x001DA1A4 File Offset: 0x001D83A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234921, XrefRangeEnd = 234930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveCharacter(AStarInputGeneratorComponent controlledCharacter, TileManager tileManager, Vector3Int dest, Vector3 extraOffset, DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation, Action onArrivalCallback, PartnerManager manager, bool haveCollision, ref Il2CppSystem.Object partnerMovementAdditionData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlledCharacter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tileManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onArrivalRotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onArrivalCallback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref haveCollision;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(partnerMovementAdditionData);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_MoveCharacter_Public_Virtual_New_Void_AStarInputGeneratorComponent_TileManager_Vector3Int_Vector3_CharacterRotation_Action_PartnerManager_Boolean_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			partnerMovementAdditionData = ((intPtr4 == 0) ? null : new Il2CppSystem.Object(intPtr4));
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x001DA28C File Offset: 0x001D848C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExternalStop(AStarInputGeneratorComponent controlledCharacter, PartnerManager manager, ref Il2CppSystem.Object partnerMovementAdditionData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlledCharacter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(partnerMovementAdditionData);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_ExternalStop_Public_Virtual_New_Void_AStarInputGeneratorComponent_PartnerManager_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			partnerMovementAdditionData = ((intPtr4 == 0) ? null : new Il2CppSystem.Object(intPtr4));
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x001DA314 File Offset: 0x001D8514
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 234935, RefRangeEnd = 234941, XrefRangeStart = 234930, XrefRangeEnd = 234935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAudio(AudioClip audioClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x001DA358 File Offset: 0x001D8558
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 234997, RefRangeEnd = 235001, XrefRangeStart = 234941, XrefRangeEnd = 234997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetText(bool showFullText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showFullText;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_GetText_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x001DA39C File Offset: 0x001D859C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235006, RefRangeEnd = 235007, XrefRangeStart = 235001, XrefRangeEnd = 235006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatString(string data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_FormatString_Protected_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x001DA3D8 File Offset: 0x001D85D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 235013, RefRangeEnd = 235018, XrefRangeStart = 235007, XrefRangeEnd = 235013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSpeedLang(PartnerInfoBase.Speed speed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr_GetSpeedLang_Protected_Static_String_Speed_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x001DA410 File Offset: 0x001D8610
		[CallerCount(0)]
		public unsafe virtual string GetMoveSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_GetMoveSpeedText_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x001DA454 File Offset: 0x001D8654
		[CallerCount(0)]
		public unsafe virtual string GetWorkSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_GetWorkSpeedText_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x001DA498 File Offset: 0x001D8698
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PreProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_PreProcessInfo_Protected_Virtual_New_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x001DA4E8 File Offset: 0x001D86E8
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_New_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x06005EDC RID: 24284 RVA: 0x001DA538 File Offset: 0x001D8738
		public unsafe virtual bool DoNotShowRevenueCut
		{
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoBase.NativeMethodInfoPtr_get_DoNotShowRevenueCut_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x001DA580 File Offset: 0x001D8780
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x00033A69 File Offset: 0x00031C69
		public PartnerInfoBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06005EDF RID: 24287 RVA: 0x001DA5BC File Offset: 0x001D87BC
		// (set) Token: 0x06005EE0 RID: 24288 RVA: 0x00033A72 File Offset: 0x00031C72
		public unsafe int partnerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_partnerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_partnerId)) = value;
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06005EE1 RID: 24289 RVA: 0x001DA5E4 File Offset: 0x001D87E4
		// (set) Token: 0x06005EE2 RID: 24290 RVA: 0x00033A8D File Offset: 0x00031C8D
		public unsafe float partnerCut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_partnerCut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_partnerCut)) = value;
			}
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06005EE3 RID: 24291 RVA: 0x001DA60C File Offset: 0x001D880C
		// (set) Token: 0x06005EE4 RID: 24292 RVA: 0x00033AA8 File Offset: 0x00031CA8
		public unsafe float addToInventoryDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_addToInventoryDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_addToInventoryDelay)) = value;
			}
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x06005EE5 RID: 24293 RVA: 0x001DA634 File Offset: 0x001D8834
		// (set) Token: 0x06005EE6 RID: 24294 RVA: 0x00033AC3 File Offset: 0x00031CC3
		public unsafe float extractFromInventoryDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_extractFromInventoryDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_extractFromInventoryDelay)) = value;
			}
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06005EE7 RID: 24295 RVA: 0x001DA65C File Offset: 0x001D885C
		// (set) Token: 0x06005EE8 RID: 24296 RVA: 0x00033ADE File Offset: 0x00031CDE
		public unsafe float deliverDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_deliverDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_deliverDelay)) = value;
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06005EE9 RID: 24297 RVA: 0x001DA684 File Offset: 0x001D8884
		// (set) Token: 0x06005EEA RID: 24298 RVA: 0x00033AF9 File Offset: 0x00031CF9
		public unsafe Il2CppStructArray<int> banSGuestToSpawnId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_banSGuestToSpawnId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_banSGuestToSpawnId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06005EEB RID: 24299 RVA: 0x001DA6B4 File Offset: 0x001D88B4
		// (set) Token: 0x06005EEC RID: 24300 RVA: 0x00033B18 File Offset: 0x00031D18
		public unsafe Il2CppStructArray<PartnerInfoBase.CompanionProperty> companionPartners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_companionPartners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PartnerInfoBase.CompanionProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_companionPartners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06005EED RID: 24301 RVA: 0x001DA6E4 File Offset: 0x001D88E4
		// (set) Token: 0x06005EEE RID: 24302 RVA: 0x00033B37 File Offset: 0x00031D37
		public unsafe bool notUseCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_notUseCollider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_notUseCollider)) = value;
			}
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x06005EEF RID: 24303 RVA: 0x001DA70C File Offset: 0x001D890C
		// (set) Token: 0x06005EF0 RID: 24304 RVA: 0x00033B52 File Offset: 0x00031D52
		public unsafe PartnerInfoBase.Speed workSpeedLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_workSpeedLiteral);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_workSpeedLiteral)) = value;
			}
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x001DA734 File Offset: 0x001D8934
		// (set) Token: 0x06005EF2 RID: 24306 RVA: 0x00033B6D File Offset: 0x00031D6D
		public unsafe float moveSpdMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_moveSpdMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.NativeFieldInfoPtr_moveSpdMultiplier)) = value;
			}
		}

		// Token: 0x04003E9F RID: 16031
		private static readonly IntPtr NativeFieldInfoPtr_partnerId;

		// Token: 0x04003EA0 RID: 16032
		private static readonly IntPtr NativeFieldInfoPtr_partnerCut;

		// Token: 0x04003EA1 RID: 16033
		private static readonly IntPtr NativeFieldInfoPtr_addToInventoryDelay;

		// Token: 0x04003EA2 RID: 16034
		private static readonly IntPtr NativeFieldInfoPtr_extractFromInventoryDelay;

		// Token: 0x04003EA3 RID: 16035
		private static readonly IntPtr NativeFieldInfoPtr_deliverDelay;

		// Token: 0x04003EA4 RID: 16036
		private static readonly IntPtr NativeFieldInfoPtr_banSGuestToSpawnId;

		// Token: 0x04003EA5 RID: 16037
		private static readonly IntPtr NativeFieldInfoPtr_companionPartners;

		// Token: 0x04003EA6 RID: 16038
		private static readonly IntPtr NativeFieldInfoPtr_notUseCollider;

		// Token: 0x04003EA7 RID: 16039
		private static readonly IntPtr NativeFieldInfoPtr_workSpeedLiteral;

		// Token: 0x04003EA8 RID: 16040
		private static readonly IntPtr NativeFieldInfoPtr_moveSpdMultiplier;

		// Token: 0x04003EA9 RID: 16041
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerId_Public_get_Int32_0;

		// Token: 0x04003EAA RID: 16042
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerCut_Public_get_Single_0;

		// Token: 0x04003EAB RID: 16043
		private static readonly IntPtr NativeMethodInfoPtr_get_AddToInventoryDelay_Public_get_Single_0;

		// Token: 0x04003EAC RID: 16044
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtractFromInventoryDelay_Public_get_Single_0;

		// Token: 0x04003EAD RID: 16045
		private static readonly IntPtr NativeMethodInfoPtr_get_DeliverDelay_Public_get_Single_0;

		// Token: 0x04003EAE RID: 16046
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkSpeedLiteral_Public_get_Speed_0;

		// Token: 0x04003EAF RID: 16047
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveSpdMultiplier_Public_Virtual_New_get_Single_0;

		// Token: 0x04003EB0 RID: 16048
		private static readonly IntPtr NativeMethodInfoPtr_get_NotUseCollider_Public_get_Boolean_0;

		// Token: 0x04003EB1 RID: 16049
		private static readonly IntPtr NativeMethodInfoPtr_get_BanGuestId_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04003EB2 RID: 16050
		private static readonly IntPtr NativeMethodInfoPtr_get_CompanionPartners_Public_get_Il2CppStructArray_1_CompanionProperty_0;

		// Token: 0x04003EB3 RID: 16051
		private static readonly IntPtr NativeMethodInfoPtr_get_UiAnimationFieldFront_Protected_get_Transform_0;

		// Token: 0x04003EB4 RID: 16052
		private static readonly IntPtr NativeMethodInfoPtr_get_UiAnimationFieldTop_Protected_get_Transform_0;

		// Token: 0x04003EB5 RID: 16053
		private static readonly IntPtr NativeMethodInfoPtr_get_UiAnimationFieldMiddle_Protected_get_Transform_0;

		// Token: 0x04003EB6 RID: 16054
		private static readonly IntPtr NativeMethodInfoPtr_get_UiAnimationFieldBack_Protected_get_Transform_0;

		// Token: 0x04003EB7 RID: 16055
		private static readonly IntPtr NativeMethodInfoPtr_get_IfNeverWork_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003EB8 RID: 16056
		private static readonly IntPtr NativeMethodInfoPtr_get_HasWorkSleepLoop_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003EB9 RID: 16057
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkTime_Protected_Virtual_New_get_Vector2Int_0;

		// Token: 0x04003EBA RID: 16058
		private static readonly IntPtr NativeMethodInfoPtr_get_SleepTime_Protected_Virtual_New_get_Vector2Int_0;

		// Token: 0x04003EBB RID: 16059
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerDeliverType_Public_Virtual_New_get_DeliverType_0;

		// Token: 0x04003EBC RID: 16060
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerType_Public_Virtual_New_PartnerType_0;

		// Token: 0x04003EBD RID: 16061
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldToScreenPoint_Protected_Vector3_Vector3_0;

		// Token: 0x04003EBE RID: 16062
		private static readonly IntPtr NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_New_Single_CookController_Sellable_Single_byref_Boolean_0;

		// Token: 0x04003EBF RID: 16063
		private static readonly IntPtr NativeMethodInfoPtr_OnGetOverrideFinalCookResult_Public_Virtual_New_Sellable_CookController_Sellable_byref_Boolean_0;

		// Token: 0x04003EC0 RID: 16064
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalDataRequirement_Protected_Virtual_New_get_Int32_0;

		// Token: 0x04003EC1 RID: 16065
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalAdditionalDataRequirement_Public_get_Int32_0;

		// Token: 0x04003EC2 RID: 16066
		private static readonly IntPtr NativeMethodInfoPtr_PreloadPartner_Public_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003EC3 RID: 16067
		private static readonly IntPtr NativeMethodInfoPtr_GetCompanionPartnerType_Public_Virtual_New_Il2CppReferenceArray_1_ValueTuple_2_CompanionProperty_PartnerType_PartnerBase_0;

		// Token: 0x04003EC4 RID: 16068
		private static readonly IntPtr NativeMethodInfoPtr_OnInventoryUpdate_Public_Virtual_New_Void_PartnerBase_EventManager_PartnerManager_0;

		// Token: 0x04003EC5 RID: 16069
		private static readonly IntPtr NativeMethodInfoPtr_WorkSleepLoop_Private_IEnumerator_PartnerBase_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003EC6 RID: 16070
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_New_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003EC7 RID: 16071
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePartner_Public_Void_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003EC8 RID: 16072
		private static readonly IntPtr NativeMethodInfoPtr_MoveCharacter_Public_Virtual_New_Void_AStarInputGeneratorComponent_TileManager_Vector3Int_Vector3_CharacterRotation_Action_PartnerManager_Boolean_byref_Object_0;

		// Token: 0x04003EC9 RID: 16073
		private static readonly IntPtr NativeMethodInfoPtr_ExternalStop_Public_Virtual_New_Void_AStarInputGeneratorComponent_PartnerManager_byref_Object_0;

		// Token: 0x04003ECA RID: 16074
		private static readonly IntPtr NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0;

		// Token: 0x04003ECB RID: 16075
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_String_Boolean_0;

		// Token: 0x04003ECC RID: 16076
		private static readonly IntPtr NativeMethodInfoPtr_FormatString_Protected_Static_String_String_0;

		// Token: 0x04003ECD RID: 16077
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedLang_Protected_Static_String_Speed_0;

		// Token: 0x04003ECE RID: 16078
		private static readonly IntPtr NativeMethodInfoPtr_GetMoveSpeedText_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x04003ECF RID: 16079
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkSpeedText_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x04003ED0 RID: 16080
		private static readonly IntPtr NativeMethodInfoPtr_PreProcessInfo_Protected_Virtual_New_Void_StringBuilder_0;

		// Token: 0x04003ED1 RID: 16081
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_New_Void_StringBuilder_0;

		// Token: 0x04003ED2 RID: 16082
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotShowRevenueCut_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04003ED3 RID: 16083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000D4A RID: 3402
		public enum CompanionType
		{
			// Token: 0x04009B7B RID: 39803
			SideBySide,
			// Token: 0x04009B7C RID: 39804
			BlendTogether,
			// Token: 0x04009B7D RID: 39805
			Sekibanki
		}

		// Token: 0x02000D4B RID: 3403
		public enum DeliverType
		{
			// Token: 0x04009B7F RID: 39807
			Normal,
			// Token: 0x04009B80 RID: 39808
			Throw
		}

		// Token: 0x02000D4C RID: 3404
		public enum PartnerType
		{
			// Token: 0x04009B82 RID: 39810
			Normal,
			// Token: 0x04009B83 RID: 39811
			Boss
		}

		// Token: 0x02000D4D RID: 3405
		public enum Speed
		{
			// Token: 0x04009B85 RID: 39813
			Slow,
			// Token: 0x04009B86 RID: 39814
			Medium,
			// Token: 0x04009B87 RID: 39815
			Fast,
			// Token: 0x04009B88 RID: 39816
			None
		}

		// Token: 0x02000D4E RID: 3406
		public enum WorkState
		{
			// Token: 0x04009B8A RID: 39818
			InWork,
			// Token: 0x04009B8B RID: 39819
			Sleep,
			// Token: 0x04009B8C RID: 39820
			FocusOnOtherThing
		}

		// Token: 0x02000D4F RID: 3407
		[Serializable]
		[StructLayout(2)]
		public struct CompanionProperty
		{
			// Token: 0x0600F429 RID: 62505 RVA: 0x0039C188 File Offset: 0x0039A388
			// Note: this type is marked as 'beforefieldinit'.
			static CompanionProperty()
			{
				Il2CppClassPointerStore<PartnerInfoBase.CompanionProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "CompanionProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoBase.CompanionProperty>.NativeClassPtr);
				PartnerInfoBase.CompanionProperty.NativeFieldInfoPtr_companionPartnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase.CompanionProperty>.NativeClassPtr, "companionPartnerId");
				PartnerInfoBase.CompanionProperty.NativeFieldInfoPtr_mappingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase.CompanionProperty>.NativeClassPtr, "mappingIndex");
				PartnerInfoBase.CompanionProperty.NativeFieldInfoPtr_companionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase.CompanionProperty>.NativeClassPtr, "companionType");
				PartnerInfoBase.CompanionProperty.NativeMethodInfoPtr_get_CompanionPartnerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase.CompanionProperty>.NativeClassPtr, 100682796);
				PartnerInfoBase.CompanionProperty.NativeMethodInfoPtr_get_MappingIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase.CompanionProperty>.NativeClassPtr, 100682797);
				PartnerInfoBase.CompanionProperty.NativeMethodInfoPtr_get_Type_Public_get_CompanionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase.CompanionProperty>.NativeClassPtr, 100682798);
			}

			// Token: 0x17004F59 RID: 20313
			// (get) Token: 0x0600F42A RID: 62506 RVA: 0x0039C22C File Offset: 0x0039A42C
			public unsafe int CompanionPartnerId
			{
				[CallerCount(140)]
				[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.CompanionProperty.NativeMethodInfoPtr_get_CompanionPartnerId_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004F5A RID: 20314
			// (get) Token: 0x0600F42B RID: 62507 RVA: 0x0039C25C File Offset: 0x0039A45C
			public unsafe int MappingIndex
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.CompanionProperty.NativeMethodInfoPtr_get_MappingIndex_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004F5B RID: 20315
			// (get) Token: 0x0600F42C RID: 62508 RVA: 0x0039C28C File Offset: 0x0039A48C
			public unsafe PartnerInfoBase.CompanionType Type
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 88495, RefRangeEnd = 88519, XrefRangeStart = 88495, XrefRangeEnd = 88519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.CompanionProperty.NativeMethodInfoPtr_get_Type_Public_get_CompanionType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600F42D RID: 62509 RVA: 0x00083143 File Offset: 0x00081343
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PartnerInfoBase.CompanionProperty>.NativeClassPtr, ref this));
			}

			// Token: 0x04009B8D RID: 39821
			private static readonly IntPtr NativeFieldInfoPtr_companionPartnerId;

			// Token: 0x04009B8E RID: 39822
			private static readonly IntPtr NativeFieldInfoPtr_mappingIndex;

			// Token: 0x04009B8F RID: 39823
			private static readonly IntPtr NativeFieldInfoPtr_companionType;

			// Token: 0x04009B90 RID: 39824
			private static readonly IntPtr NativeMethodInfoPtr_get_CompanionPartnerId_Public_get_Int32_0;

			// Token: 0x04009B91 RID: 39825
			private static readonly IntPtr NativeMethodInfoPtr_get_MappingIndex_Public_get_Int32_0;

			// Token: 0x04009B92 RID: 39826
			private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_CompanionType_0;

			// Token: 0x04009B93 RID: 39827
			[FieldOffset(0)]
			public int companionPartnerId;

			// Token: 0x04009B94 RID: 39828
			[FieldOffset(4)]
			public int mappingIndex;

			// Token: 0x04009B95 RID: 39829
			[FieldOffset(8)]
			public PartnerInfoBase.CompanionType companionType;
		}

		// Token: 0x02000D50 RID: 3408
		[ObfuscatedName("GameData.Profile.PartnerInfoBase+<get_BanGuestId>d__32")]
		public sealed class _get_BanGuestId_d__32 : Il2CppSystem.Object
		{
			// Token: 0x0600F42E RID: 62510 RVA: 0x0039C2BC File Offset: 0x0039A4BC
			// Note: this type is marked as 'beforefieldinit'.
			static _get_BanGuestId_d__32()
			{
				Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "<get_BanGuestId>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr);
				PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, "<>1__state");
				PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, "<>2__current");
				PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, "<>l__initialThreadId");
				PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, "<>4__this");
				PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, "<>7__wrap1");
				PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, "<>7__wrap2");
				PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, 100682799);
				PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, 100682800);
				PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, 100682801);
				PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, 100682802);
				PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, 100682803);
				PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, 100682804);
				PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, 100682805);
				PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr, 100682806);
			}

			// Token: 0x0600F42F RID: 62511 RVA: 0x0039C400 File Offset: 0x0039A600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234777, XrefRangeEnd = 234779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_BanGuestId_d__32(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoBase._get_BanGuestId_d__32>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F430 RID: 62512 RVA: 0x0039C448 File Offset: 0x0039A648
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F431 RID: 62513 RVA: 0x0039C47C File Offset: 0x0039A67C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234779, XrefRangeEnd = 234781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004F62 RID: 20322
			// (get) Token: 0x0600F432 RID: 62514 RVA: 0x0039C4B8 File Offset: 0x0039A6B8
			public unsafe int Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600F433 RID: 62515 RVA: 0x0039C4F4 File Offset: 0x0039A6F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234781, XrefRangeEnd = 234787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004F63 RID: 20323
			// (get) Token: 0x0600F434 RID: 62516 RVA: 0x0039C528 File Offset: 0x0039A728
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234787, XrefRangeEnd = 234790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F435 RID: 62517 RVA: 0x0039C568 File Offset: 0x0039A768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234790, XrefRangeEnd = 234792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<int> System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr3) : null;
			}

			// Token: 0x0600F436 RID: 62518 RVA: 0x0039C5A8 File Offset: 0x0039A7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._get_BanGuestId_d__32.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F437 RID: 62519 RVA: 0x00083155 File Offset: 0x00081355
			public _get_BanGuestId_d__32(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F5C RID: 20316
			// (get) Token: 0x0600F438 RID: 62520 RVA: 0x0039C5E8 File Offset: 0x0039A7E8
			// (set) Token: 0x0600F439 RID: 62521 RVA: 0x0008315E File Offset: 0x0008135E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004F5D RID: 20317
			// (get) Token: 0x0600F43A RID: 62522 RVA: 0x0039C610 File Offset: 0x0039A810
			// (set) Token: 0x0600F43B RID: 62523 RVA: 0x00083179 File Offset: 0x00081379
			public unsafe int __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x17004F5E RID: 20318
			// (get) Token: 0x0600F43C RID: 62524 RVA: 0x0039C638 File Offset: 0x0039A838
			// (set) Token: 0x0600F43D RID: 62525 RVA: 0x00083194 File Offset: 0x00081394
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17004F5F RID: 20319
			// (get) Token: 0x0600F43E RID: 62526 RVA: 0x0039C660 File Offset: 0x0039A860
			// (set) Token: 0x0600F43F RID: 62527 RVA: 0x000831AF File Offset: 0x000813AF
			public unsafe PartnerInfoBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F60 RID: 20320
			// (get) Token: 0x0600F440 RID: 62528 RVA: 0x0039C690 File Offset: 0x0039A890
			// (set) Token: 0x0600F441 RID: 62529 RVA: 0x000831CE File Offset: 0x000813CE
			public unsafe Il2CppStructArray<int> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F61 RID: 20321
			// (get) Token: 0x0600F442 RID: 62530 RVA: 0x0039C6C0 File Offset: 0x0039A8C0
			// (set) Token: 0x0600F443 RID: 62531 RVA: 0x000831ED File Offset: 0x000813ED
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._get_BanGuestId_d__32.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x04009B96 RID: 39830
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009B97 RID: 39831
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009B98 RID: 39832
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04009B99 RID: 39833
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009B9A RID: 39834
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04009B9B RID: 39835
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04009B9C RID: 39836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009B9D RID: 39837
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009B9E RID: 39838
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009B9F RID: 39839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04009BA0 RID: 39840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009BA1 RID: 39841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009BA2 RID: 39842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0;

			// Token: 0x04009BA3 RID: 39843
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000D51 RID: 3409
		[ObfuscatedName("GameData.Profile.PartnerInfoBase+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F444 RID: 62532 RVA: 0x0039C6E8 File Offset: 0x0039A8E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass63_0>.NativeClassPtr);
				PartnerInfoBase.__c__DisplayClass63_0.NativeFieldInfoPtr_currentPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass63_0>.NativeClassPtr, "currentPartner");
				PartnerInfoBase.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass63_0>.NativeClassPtr, 100682807);
				PartnerInfoBase.__c__DisplayClass63_0.NativeMethodInfoPtr__GetCompanionPartnerType_b__0_Internal_ValueTuple_2_CompanionProperty_PartnerType_CompanionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass63_0>.NativeClassPtr, 100682808);
			}

			// Token: 0x0600F445 RID: 62533 RVA: 0x0039C750 File Offset: 0x0039A950
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F446 RID: 62534 RVA: 0x0039C78C File Offset: 0x0039A98C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234792, XrefRangeEnd = 234795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<PartnerInfoBase.CompanionProperty, PartnerBase.PartnerType> _GetCompanionPartnerType_b__0(PartnerInfoBase.CompanionProperty x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.__c__DisplayClass63_0.NativeMethodInfoPtr__GetCompanionPartnerType_b__0_Internal_ValueTuple_2_CompanionProperty_PartnerType_CompanionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<PartnerInfoBase.CompanionProperty, PartnerBase.PartnerType>(pointer);
			}

			// Token: 0x0600F447 RID: 62535 RVA: 0x00083208 File Offset: 0x00081408
			public __c__DisplayClass63_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F64 RID: 20324
			// (get) Token: 0x0600F448 RID: 62536 RVA: 0x0039C7D0 File Offset: 0x0039A9D0
			// (set) Token: 0x0600F449 RID: 62537 RVA: 0x00083211 File Offset: 0x00081411
			public unsafe PartnerBase currentPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.__c__DisplayClass63_0.NativeFieldInfoPtr_currentPartner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.__c__DisplayClass63_0.NativeFieldInfoPtr_currentPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BA4 RID: 39844
			private static readonly IntPtr NativeFieldInfoPtr_currentPartner;

			// Token: 0x04009BA5 RID: 39845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BA6 RID: 39846
			private static readonly IntPtr NativeMethodInfoPtr__GetCompanionPartnerType_b__0_Internal_ValueTuple_2_CompanionProperty_PartnerType_CompanionProperty_0;
		}

		// Token: 0x02000D52 RID: 3410
		[ObfuscatedName("GameData.Profile.PartnerInfoBase+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F44A RID: 62538 RVA: 0x0039C800 File Offset: 0x0039AA00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass65_0>.NativeClassPtr);
				PartnerInfoBase.__c__DisplayClass65_0.NativeFieldInfoPtr_thisPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass65_0>.NativeClassPtr, "thisPartner");
				PartnerInfoBase.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass65_0>.NativeClassPtr, 100682809);
				PartnerInfoBase.__c__DisplayClass65_0.NativeMethodInfoPtr__WorkSleepLoop_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass65_0>.NativeClassPtr, 100682810);
			}

			// Token: 0x0600F44B RID: 62539 RVA: 0x0039C868 File Offset: 0x0039AA68
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoBase.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F44C RID: 62540 RVA: 0x0039C8A4 File Offset: 0x0039AAA4
			[CallerCount(0)]
			public unsafe bool _WorkSleepLoop_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase.__c__DisplayClass65_0.NativeMethodInfoPtr__WorkSleepLoop_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F44D RID: 62541 RVA: 0x00083230 File Offset: 0x00081430
			public __c__DisplayClass65_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F65 RID: 20325
			// (get) Token: 0x0600F44E RID: 62542 RVA: 0x0039C8E0 File Offset: 0x0039AAE0
			// (set) Token: 0x0600F44F RID: 62543 RVA: 0x00083239 File Offset: 0x00081439
			public unsafe PartnerBase thisPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.__c__DisplayClass65_0.NativeFieldInfoPtr_thisPartner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase.__c__DisplayClass65_0.NativeFieldInfoPtr_thisPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BA7 RID: 39847
			private static readonly IntPtr NativeFieldInfoPtr_thisPartner;

			// Token: 0x04009BA8 RID: 39848
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BA9 RID: 39849
			private static readonly IntPtr NativeMethodInfoPtr__WorkSleepLoop_b__0_Internal_Boolean_0;
		}

		// Token: 0x02000D53 RID: 3411
		[ObfuscatedName("GameData.Profile.PartnerInfoBase+<WorkSleepLoop>d__65")]
		public sealed class _WorkSleepLoop_d__65 : Il2CppSystem.Object
		{
			// Token: 0x0600F450 RID: 62544 RVA: 0x0039C910 File Offset: 0x0039AB10
			// Note: this type is marked as 'beforefieldinit'.
			static _WorkSleepLoop_d__65()
			{
				Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoBase>.NativeClassPtr, "<WorkSleepLoop>d__65");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr);
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "<>1__state");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "<>2__current");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "<>4__this");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr_additionalData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "additionalData");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr_currentPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "currentPartner");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "<time>5__2");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__currentTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "<currentTime>5__3");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__currentState_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "<currentState>5__4");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__callback_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "<callback>5__5");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__progressCallback_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "<progressCallback>5__6");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__waitForOneSecond_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "<waitForOneSecond>5__7");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__blocker_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, "<blocker>5__8");
				PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, 100682811);
				PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, 100682812);
				PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, 100682813);
				PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, 100682814);
				PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, 100682815);
				PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr, 100682816);
			}

			// Token: 0x0600F451 RID: 62545 RVA: 0x0039CAA4 File Offset: 0x0039ACA4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WorkSleepLoop_d__65(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoBase._WorkSleepLoop_d__65>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F452 RID: 62546 RVA: 0x0039CAEC File Offset: 0x0039ACEC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F453 RID: 62547 RVA: 0x0039CB20 File Offset: 0x0039AD20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234795, XrefRangeEnd = 234837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004F72 RID: 20338
			// (get) Token: 0x0600F454 RID: 62548 RVA: 0x0039CB5C File Offset: 0x0039AD5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F455 RID: 62549 RVA: 0x0039CB9C File Offset: 0x0039AD9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234837, XrefRangeEnd = 234843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004F73 RID: 20339
			// (get) Token: 0x0600F456 RID: 62550 RVA: 0x0039CBD0 File Offset: 0x0039ADD0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoBase._WorkSleepLoop_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F457 RID: 62551 RVA: 0x00083258 File Offset: 0x00081458
			public _WorkSleepLoop_d__65(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F66 RID: 20326
			// (get) Token: 0x0600F458 RID: 62552 RVA: 0x0039CC10 File Offset: 0x0039AE10
			// (set) Token: 0x0600F459 RID: 62553 RVA: 0x00083261 File Offset: 0x00081461
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004F67 RID: 20327
			// (get) Token: 0x0600F45A RID: 62554 RVA: 0x0039CC38 File Offset: 0x0039AE38
			// (set) Token: 0x0600F45B RID: 62555 RVA: 0x0008327C File Offset: 0x0008147C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F68 RID: 20328
			// (get) Token: 0x0600F45C RID: 62556 RVA: 0x0039CC68 File Offset: 0x0039AE68
			// (set) Token: 0x0600F45D RID: 62557 RVA: 0x0008329B File Offset: 0x0008149B
			public unsafe PartnerInfoBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F69 RID: 20329
			// (get) Token: 0x0600F45E RID: 62558 RVA: 0x0039CC98 File Offset: 0x0039AE98
			// (set) Token: 0x0600F45F RID: 62559 RVA: 0x000832BA File Offset: 0x000814BA
			public unsafe Il2CppReferenceArray<Il2CppSystem.Object> additionalData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr_additionalData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr_additionalData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F6A RID: 20330
			// (get) Token: 0x0600F460 RID: 62560 RVA: 0x0039CCC8 File Offset: 0x0039AEC8
			// (set) Token: 0x0600F461 RID: 62561 RVA: 0x000832D9 File Offset: 0x000814D9
			public unsafe PartnerBase currentPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr_currentPartner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr_currentPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F6B RID: 20331
			// (get) Token: 0x0600F462 RID: 62562 RVA: 0x0039CCF8 File Offset: 0x0039AEF8
			// (set) Token: 0x0600F463 RID: 62563 RVA: 0x000832F8 File Offset: 0x000814F8
			public unsafe int _time_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__time_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__time_5__2)) = value;
				}
			}

			// Token: 0x17004F6C RID: 20332
			// (get) Token: 0x0600F464 RID: 62564 RVA: 0x0039CD20 File Offset: 0x0039AF20
			// (set) Token: 0x0600F465 RID: 62565 RVA: 0x00083313 File Offset: 0x00081513
			public unsafe float _currentTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__currentTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__currentTime_5__3)) = value;
				}
			}

			// Token: 0x17004F6D RID: 20333
			// (get) Token: 0x0600F466 RID: 62566 RVA: 0x0039CD48 File Offset: 0x0039AF48
			// (set) Token: 0x0600F467 RID: 62567 RVA: 0x0008332E File Offset: 0x0008152E
			public unsafe PartnerInfoBase.WorkState _currentState_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__currentState_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__currentState_5__4)) = value;
				}
			}

			// Token: 0x17004F6E RID: 20334
			// (get) Token: 0x0600F468 RID: 62568 RVA: 0x0039CD70 File Offset: 0x0039AF70
			// (set) Token: 0x0600F469 RID: 62569 RVA: 0x00083349 File Offset: 0x00081549
			public unsafe Action<PartnerInfoBase.WorkState> _callback_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__callback_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PartnerInfoBase.WorkState>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__callback_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F6F RID: 20335
			// (get) Token: 0x0600F46A RID: 62570 RVA: 0x0039CDA0 File Offset: 0x0039AFA0
			// (set) Token: 0x0600F46B RID: 62571 RVA: 0x00083368 File Offset: 0x00081568
			public unsafe Action<float> _progressCallback_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__progressCallback_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__progressCallback_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F70 RID: 20336
			// (get) Token: 0x0600F46C RID: 62572 RVA: 0x0039CDD0 File Offset: 0x0039AFD0
			// (set) Token: 0x0600F46D RID: 62573 RVA: 0x00083387 File Offset: 0x00081587
			public unsafe WaitForSeconds _waitForOneSecond_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__waitForOneSecond_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__waitForOneSecond_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F71 RID: 20337
			// (get) Token: 0x0600F46E RID: 62574 RVA: 0x0039CE00 File Offset: 0x0039B000
			// (set) Token: 0x0600F46F RID: 62575 RVA: 0x000833A6 File Offset: 0x000815A6
			public unsafe WaitUntil _blocker_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__blocker_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoBase._WorkSleepLoop_d__65.NativeFieldInfoPtr__blocker_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BAA RID: 39850
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009BAB RID: 39851
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009BAC RID: 39852
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BAD RID: 39853
			private static readonly IntPtr NativeFieldInfoPtr_additionalData;

			// Token: 0x04009BAE RID: 39854
			private static readonly IntPtr NativeFieldInfoPtr_currentPartner;

			// Token: 0x04009BAF RID: 39855
			private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

			// Token: 0x04009BB0 RID: 39856
			private static readonly IntPtr NativeFieldInfoPtr__currentTime_5__3;

			// Token: 0x04009BB1 RID: 39857
			private static readonly IntPtr NativeFieldInfoPtr__currentState_5__4;

			// Token: 0x04009BB2 RID: 39858
			private static readonly IntPtr NativeFieldInfoPtr__callback_5__5;

			// Token: 0x04009BB3 RID: 39859
			private static readonly IntPtr NativeFieldInfoPtr__progressCallback_5__6;

			// Token: 0x04009BB4 RID: 39860
			private static readonly IntPtr NativeFieldInfoPtr__waitForOneSecond_5__7;

			// Token: 0x04009BB5 RID: 39861
			private static readonly IntPtr NativeFieldInfoPtr__blocker_5__8;

			// Token: 0x04009BB6 RID: 39862
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009BB7 RID: 39863
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009BB8 RID: 39864
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009BB9 RID: 39865
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009BBA RID: 39866
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009BBB RID: 39867
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
