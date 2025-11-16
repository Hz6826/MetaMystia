using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000107 RID: 263
	[Serializable]
	public class RogueLikeCardPersistent : RogueLikeCardBase
	{
		// Token: 0x06001CE7 RID: 7399 RVA: 0x000FF244 File Offset: 0x000FD444
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeCardPersistent()
		{
			Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeCardPersistent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr);
			RogueLikeCardPersistent.NativeFieldInfoPtr_m_CardForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, "m_CardForm");
			RogueLikeCardPersistent.NativeFieldInfoPtr_m_Unique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, "m_Unique");
			RogueLikeCardPersistent.NativeFieldInfoPtr_m_HasMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, "m_HasMinimum");
			RogueLikeCardPersistent.NativeFieldInfoPtr_m_BuffDurationWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, "m_BuffDurationWave");
			RogueLikeCardPersistent.NativeFieldInfoPtr_m_MaxNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, "m_MaxNum");
			RogueLikeCardPersistent.NativeFieldInfoPtr_m_Rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, "m_Rarity");
			RogueLikeCardPersistent.NativeFieldInfoPtr_m_AlwaysShowBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, "m_AlwaysShowBuff");
			RogueLikeCardPersistent.NativeMethodInfoPtr_get_GetCardForm_Public_Virtual_Final_get_CardForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668492);
			RogueLikeCardPersistent.NativeMethodInfoPtr_get_GetInSettledCardForm_Public_get_InSettledCardForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668493);
			RogueLikeCardPersistent.NativeMethodInfoPtr_get_BuffDurationWave_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668494);
			RogueLikeCardPersistent.NativeMethodInfoPtr_get_IsNoLimit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668495);
			RogueLikeCardPersistent.NativeMethodInfoPtr_get_MaxNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668496);
			RogueLikeCardPersistent.NativeMethodInfoPtr_get_HasMinimum_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668497);
			RogueLikeCardPersistent.NativeMethodInfoPtr_get_CardRarity_Public_get_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668498);
			RogueLikeCardPersistent.NativeMethodInfoPtr_get_AlwaysShowBuff_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668499);
			RogueLikeCardPersistent.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_New_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668500);
			RogueLikeCardPersistent.NativeMethodInfoPtr_GetDescriptionInAlbum_Public_Virtual_New_String_String_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668501);
			RogueLikeCardPersistent.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_New_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668502);
			RogueLikeCardPersistent.NativeMethodInfoPtr_CheckCouldShow_Public_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668503);
			RogueLikeCardPersistent.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_New_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668504);
			RogueLikeCardPersistent.NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668505);
			RogueLikeCardPersistent.NativeMethodInfoPtr_AfterSelect_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668506);
			RogueLikeCardPersistent.NativeMethodInfoPtr_RemoveCard_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668507);
			RogueLikeCardPersistent.NativeMethodInfoPtr_AfterInitialize_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668508);
			RogueLikeCardPersistent.NativeMethodInfoPtr_CheckExistSameCard_Protected_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668509);
			RogueLikeCardPersistent.NativeMethodInfoPtr_BaseBuffDescription_Protected_String_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668510);
			RogueLikeCardPersistent.NativeMethodInfoPtr_OverrideBuffDescription_Public_Virtual_New_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668511);
			RogueLikeCardPersistent.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_New_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668512);
			RogueLikeCardPersistent.NativeMethodInfoPtr_FormatString_Protected_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668513);
			RogueLikeCardPersistent.NativeMethodInfoPtr_FormatStringFromIntValue_Protected_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668514);
			RogueLikeCardPersistent.NativeMethodInfoPtr_FormatStringFromFloatValue_Protected_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668515);
			RogueLikeCardPersistent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668516);
			RogueLikeCardPersistent.NativeMethodInfoPtr__CheckCouldShow_b__27_0_Private_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668517);
			RogueLikeCardPersistent.NativeMethodInfoPtr__CheckExistSameCard_b__33_0_Private_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, 100668518);
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x000FF51C File Offset: 0x000FD71C
		public unsafe override RogueLikeCardBase.CardForm GetCardForm
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_get_GetCardForm_Public_Virtual_Final_get_CardForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x000FF558 File Offset: 0x000FD758
		public unsafe RogueLikeCardPersistent.InSettledCardForm GetInSettledCardForm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49351, RefRangeEnd = 49352, XrefRangeStart = 49351, XrefRangeEnd = 49352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_get_GetInSettledCardForm_Public_get_InSettledCardForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x000FF594 File Offset: 0x000FD794
		public unsafe int BuffDurationWave
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53318, RefRangeEnd = 53319, XrefRangeStart = 53318, XrefRangeEnd = 53319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_get_BuffDurationWave_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x000FF5D0 File Offset: 0x000FD7D0
		public unsafe bool IsNoLimit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73633, RefRangeEnd = 73634, XrefRangeStart = 73633, XrefRangeEnd = 73633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_get_IsNoLimit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000FF60C File Offset: 0x000FD80C
		public unsafe int MaxNum
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73634, RefRangeEnd = 73635, XrefRangeStart = 73634, XrefRangeEnd = 73634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_get_MaxNum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x000FF648 File Offset: 0x000FD848
		public unsafe bool HasMinimum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_get_HasMinimum_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x000FF684 File Offset: 0x000FD884
		public unsafe RogueLikeCardBase.Rarity CardRarity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_get_CardRarity_Public_get_Rarity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x000FF6C0 File Offset: 0x000FD8C0
		public unsafe bool AlwaysShowBuff
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_get_AlwaysShowBuff_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000FF6FC File Offset: 0x000FD8FC
		[CallerCount(0)]
		public unsafe virtual string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardPersistent.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_New_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000FF784 File Offset: 0x000FD984
		[CallerCount(0)]
		public unsafe virtual string GetDescriptionInAlbum(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardPersistent.NativeMethodInfoPtr_GetDescriptionInAlbum_Public_Virtual_New_String_String_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000FF7EC File Offset: 0x000FD9EC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardPersistent.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_New_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000FF868 File Offset: 0x000FDA68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73673, RefRangeEnd = 73674, XrefRangeStart = 73635, XrefRangeEnd = 73673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCouldShow(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_CheckCouldShow_Public_Boolean_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000FF8B8 File Offset: 0x000FDAB8
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardPersistent.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_New_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000FF938 File Offset: 0x000FDB38
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardPersistent.NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000FF998 File Offset: 0x000FDB98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 73674, RefRangeEnd = 73678, XrefRangeStart = 73674, XrefRangeEnd = 73674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardPersistent.NativeMethodInfoPtr_AfterSelect_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000FF9F8 File Offset: 0x000FDBF8
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardPersistent.NativeMethodInfoPtr_RemoveCard_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000FFA58 File Offset: 0x000FDC58
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AfterInitialize(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardPersistent.NativeMethodInfoPtr_AfterInitialize_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000FFAB8 File Offset: 0x000FDCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73678, XrefRangeEnd = 73688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckExistSameCard(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_CheckExistSameCard_Protected_Boolean_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000FFB08 File Offset: 0x000FDD08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 73691, RefRangeEnd = 73695, XrefRangeStart = 73688, XrefRangeEnd = 73691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BaseBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_BaseBuffDescription_Protected_String_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000FFB50 File Offset: 0x000FDD50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 73691, RefRangeEnd = 73695, XrefRangeStart = 73691, XrefRangeEnd = 73695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardPersistent.NativeMethodInfoPtr_OverrideBuffDescription_Public_Virtual_New_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000FFBC4 File Offset: 0x000FDDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73695, XrefRangeEnd = 73697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCardPersistent.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_New_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x000FFC38 File Offset: 0x000FDE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73697, XrefRangeEnd = 73702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatString(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_FormatString_Protected_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x000FFC80 File Offset: 0x000FDE80
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 30674, RefRangeEnd = 30684, XrefRangeStart = 30674, XrefRangeEnd = 30684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatStringFromIntValue(int data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_FormatStringFromIntValue_Protected_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x000FFCC4 File Offset: 0x000FDEC4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 73707, RefRangeEnd = 73720, XrefRangeStart = 73702, XrefRangeEnd = 73707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatStringFromFloatValue(float data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr_FormatStringFromFloatValue_Protected_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x000FFD08 File Offset: 0x000FDF08
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeCardPersistent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x000FFD44 File Offset: 0x000FDF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73720, XrefRangeEnd = 73721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CheckCouldShow_b__27_0(KeyValuePair<RogueLikePersistentCardInstance, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr__CheckCouldShow_b__27_0_Private_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000FFD98 File Offset: 0x000FDF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73721, XrefRangeEnd = 73722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CheckExistSameCard_b__33_0(KeyValuePair<RogueLikePersistentCardInstance, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.NativeMethodInfoPtr__CheckExistSameCard_b__33_0_Private_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000118DC File Offset: 0x0000FADC
		public RogueLikeCardPersistent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x000FFDEC File Offset: 0x000FDFEC
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x000118E5 File Offset: 0x0000FAE5
		public unsafe RogueLikeCardPersistent.InSettledCardForm m_CardForm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_CardForm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_CardForm)) = value;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000FFE14 File Offset: 0x000FE014
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x00011900 File Offset: 0x0000FB00
		public unsafe bool m_Unique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_Unique);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_Unique)) = value;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x000FFE3C File Offset: 0x000FE03C
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x0001191B File Offset: 0x0000FB1B
		public unsafe bool m_HasMinimum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_HasMinimum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_HasMinimum)) = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x000FFE64 File Offset: 0x000FE064
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x00011936 File Offset: 0x0000FB36
		public unsafe int m_BuffDurationWave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_BuffDurationWave);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_BuffDurationWave)) = value;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x000FFE8C File Offset: 0x000FE08C
		// (set) Token: 0x06001D0D RID: 7437 RVA: 0x00011951 File Offset: 0x0000FB51
		public unsafe int m_MaxNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_MaxNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_MaxNum)) = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x000FFEB4 File Offset: 0x000FE0B4
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x0001196C File Offset: 0x0000FB6C
		public unsafe RogueLikeCardBase.Rarity m_Rarity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_Rarity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_Rarity)) = value;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x000FFEDC File Offset: 0x000FE0DC
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x00011987 File Offset: 0x0000FB87
		public unsafe bool m_AlwaysShowBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_AlwaysShowBuff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardPersistent.NativeFieldInfoPtr_m_AlwaysShowBuff)) = value;
			}
		}

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeFieldInfoPtr_m_CardForm;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeFieldInfoPtr_m_Unique;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeFieldInfoPtr_m_HasMinimum;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeFieldInfoPtr_m_BuffDurationWave;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxNum;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeFieldInfoPtr_m_Rarity;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeFieldInfoPtr_m_AlwaysShowBuff;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_get_GetCardForm_Public_Virtual_Final_get_CardForm_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_get_GetInSettledCardForm_Public_get_InSettledCardForm_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_get_BuffDurationWave_Public_get_Int32_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNoLimit_Public_get_Boolean_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxNum_Public_get_Int32_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_get_HasMinimum_Public_get_Boolean_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr_get_CardRarity_Public_get_Rarity_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_get_AlwaysShowBuff_Public_get_Boolean_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_New_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptionInAlbum_Public_Virtual_New_String_String_RogueLikeRunTimeData_0;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_New_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr_CheckCouldShow_Public_Boolean_RogueLikeRunTimeData_0;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_New_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_AfterSelect_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCard_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_AfterInitialize_Public_Virtual_New_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_CheckExistSameCard_Protected_Boolean_RogueLikeRunTimeData_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_BaseBuffDescription_Protected_String_RogueLikeRunTimeData_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_OverrideBuffDescription_Public_Virtual_New_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_New_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_FormatString_Protected_String_String_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_FormatStringFromIntValue_Protected_String_Int32_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_FormatStringFromFloatValue_Protected_String_Single_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr__CheckCouldShow_b__27_0_Private_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr__CheckExistSameCard_b__33_0_Private_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x020006D9 RID: 1753
		public enum InSettledCardForm
		{
			// Token: 0x04006451 RID: 25681
			Forever,
			// Token: 0x04006452 RID: 25682
			Remaining
		}

		// Token: 0x020006DA RID: 1754
		[ObfuscatedName("DayScene.UI.RogueLike.RogueLikeCardPersistent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06009A42 RID: 39490 RVA: 0x002910D0 File Offset: 0x0028F2D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RogueLikeCardPersistent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeCardPersistent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeCardPersistent.__c>.NativeClassPtr);
				RogueLikeCardPersistent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardPersistent.__c>.NativeClassPtr, "<>9");
				RogueLikeCardPersistent.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardPersistent.__c>.NativeClassPtr, "<>9__27_1");
				RogueLikeCardPersistent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent.__c>.NativeClassPtr, 100668520);
				RogueLikeCardPersistent.__c.NativeMethodInfoPtr__CheckCouldShow_b__27_1_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardPersistent.__c>.NativeClassPtr, 100668521);
			}

			// Token: 0x06009A43 RID: 39491 RVA: 0x0029114C File Offset: 0x0028F34C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeCardPersistent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A44 RID: 39492 RVA: 0x00291188 File Offset: 0x0028F388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73632, XrefRangeEnd = 73633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckCouldShow_b__27_1(KeyValuePair<RogueLikePersistentCardInstance, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardPersistent.__c.NativeMethodInfoPtr__CheckCouldShow_b__27_1_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009A45 RID: 39493 RVA: 0x000537CB File Offset: 0x000519CB
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003341 RID: 13121
			// (get) Token: 0x06009A46 RID: 39494 RVA: 0x002911DC File Offset: 0x0028F3DC
			// (set) Token: 0x06009A47 RID: 39495 RVA: 0x000537D4 File Offset: 0x000519D4
			public unsafe static RogueLikeCardPersistent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeCardPersistent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeCardPersistent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeCardPersistent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003342 RID: 13122
			// (get) Token: 0x06009A48 RID: 39496 RVA: 0x00291204 File Offset: 0x0028F404
			// (set) Token: 0x06009A49 RID: 39497 RVA: 0x000537E6 File Offset: 0x000519E6
			public unsafe static Func<KeyValuePair<RogueLikePersistentCardInstance, int>, int> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeCardPersistent.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikePersistentCardInstance, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeCardPersistent.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006453 RID: 25683
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006454 RID: 25684
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x04006455 RID: 25685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006456 RID: 25686
			private static readonly IntPtr NativeMethodInfoPtr__CheckCouldShow_b__27_1_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;
		}
	}
}
