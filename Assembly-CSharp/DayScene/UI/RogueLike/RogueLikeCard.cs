using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000108 RID: 264
	public class RogueLikeCard : RogueLikeCardBase
	{
		// Token: 0x06001D12 RID: 7442 RVA: 0x000FFF04 File Offset: 0x000FE104
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeCard()
		{
			Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr);
			RogueLikeCard.NativeFieldInfoPtr_m_ContainsRarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, "m_ContainsRarity");
			RogueLikeCard.NativeFieldInfoPtr_m_OnlyShowOncePerWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, "m_OnlyShowOncePerWave");
			RogueLikeCard.NativeFieldInfoPtr_m_InstantTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, "m_InstantTrigger");
			RogueLikeCard.NativeFieldInfoPtr_m_TriggerAfterSettle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, "m_TriggerAfterSettle");
			RogueLikeCard.NativeMethodInfoPtr_get_GetCardForm_Public_Virtual_Final_get_CardForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668522);
			RogueLikeCard.NativeMethodInfoPtr_get_ContainsRarity_Public_get_Il2CppStructArray_1_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668523);
			RogueLikeCard.NativeMethodInfoPtr_get_OnlyShowOncePerWave_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668524);
			RogueLikeCard.NativeMethodInfoPtr_get_InstantTrigger_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668525);
			RogueLikeCard.NativeMethodInfoPtr_get_TriggerAfterSettle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668526);
			RogueLikeCard.NativeMethodInfoPtr_GetRarityDataMapping_Protected_T_Il2CppArrayBase_1_T_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668527);
			RogueLikeCard.NativeMethodInfoPtr_UseCard_Public_Virtual_New_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668528);
			RogueLikeCard.NativeMethodInfoPtr_ModifyStorageAfterSettle_Public_Virtual_New_Void_Rarity_RogueLikeManager_byref_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668529);
			RogueLikeCard.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_New_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668530);
			RogueLikeCard.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_New_Boolean_RogueLikeManager_EventManager_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668531);
			RogueLikeCard.NativeMethodInfoPtr_CheckExistSameCard_Protected_Boolean_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668532);
			RogueLikeCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668533);
			RogueLikeCard.NativeMethodInfoPtr__CheckExistSameCard_b__19_0_Private_Boolean_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, 100668534);
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x00100088 File Offset: 0x000FE288
		public unsafe override RogueLikeCardBase.CardForm GetCardForm
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.NativeMethodInfoPtr_get_GetCardForm_Public_Virtual_Final_get_CardForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x001000C4 File Offset: 0x000FE2C4
		public unsafe Il2CppStructArray<RogueLikeCardBase.Rarity> ContainsRarity
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.NativeMethodInfoPtr_get_ContainsRarity_Public_get_Il2CppStructArray_1_Rarity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RogueLikeCardBase.Rarity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00100104 File Offset: 0x000FE304
		public unsafe bool OnlyShowOncePerWave
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.NativeMethodInfoPtr_get_OnlyShowOncePerWave_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00100140 File Offset: 0x000FE340
		public unsafe bool InstantTrigger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.NativeMethodInfoPtr_get_InstantTrigger_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x0010017C File Offset: 0x000FE37C
		public unsafe bool TriggerAfterSettle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.NativeMethodInfoPtr_get_TriggerAfterSettle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x001001B8 File Offset: 0x000FE3B8
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 73774, RefRangeEnd = 73815, XrefRangeStart = 73750, XrefRangeEnd = 73774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetRarityDataMapping<T>(Il2CppArrayBase<T> allProvidedData, RogueLikeCardBase.Rarity rarity) where T : RarityDataMapping
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(allProvidedData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.MethodInfoStoreGeneric_GetRarityDataMapping_Protected_T_Il2CppArrayBase_1_T_Rarity_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00100210 File Offset: 0x000FE410
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 73820, RefRangeEnd = 73855, XrefRangeStart = 73815, XrefRangeEnd = 73820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCard.NativeMethodInfoPtr_UseCard_Public_Virtual_New_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00100290 File Offset: 0x000FE490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73863, RefRangeEnd = 73864, XrefRangeStart = 73855, XrefRangeEnd = 73863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyStorageAfterSettle(RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager, out List<Product> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rarity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCard.NativeMethodInfoPtr_ModifyStorageAfterSettle_Public_Virtual_New_Void_Rarity_RogueLikeManager_byref_List_1_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			products = ((intPtr4 == 0) ? null : new List<Product>(intPtr4));
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0010030C File Offset: 0x000FE50C
		[CallerCount(0)]
		public unsafe virtual string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCard.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_New_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00100370 File Offset: 0x000FE570
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikeCard.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_New_Boolean_RogueLikeManager_EventManager_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x001003E8 File Offset: 0x000FE5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73864, XrefRangeEnd = 73874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckExistSameCard(RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.NativeMethodInfoPtr_CheckExistSameCard_Protected_Boolean_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00100438 File Offset: 0x000FE638
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeCard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00100474 File Offset: 0x000FE674
		[CallerCount(0)]
		public unsafe bool _CheckExistSameCard_b__19_0(RogueLikeCardInstance x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.NativeMethodInfoPtr__CheckExistSameCard_b__19_0_Private_Boolean_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x000119A2 File Offset: 0x0000FBA2
		public RogueLikeCard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x001004C4 File Offset: 0x000FE6C4
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x000119AB File Offset: 0x0000FBAB
		public unsafe Il2CppStructArray<RogueLikeCardBase.Rarity> m_ContainsRarity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard.NativeFieldInfoPtr_m_ContainsRarity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RogueLikeCardBase.Rarity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard.NativeFieldInfoPtr_m_ContainsRarity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x001004F4 File Offset: 0x000FE6F4
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x000119CA File Offset: 0x0000FBCA
		public unsafe bool m_OnlyShowOncePerWave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard.NativeFieldInfoPtr_m_OnlyShowOncePerWave);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard.NativeFieldInfoPtr_m_OnlyShowOncePerWave)) = value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0010051C File Offset: 0x000FE71C
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x000119E5 File Offset: 0x0000FBE5
		public unsafe bool m_InstantTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard.NativeFieldInfoPtr_m_InstantTrigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard.NativeFieldInfoPtr_m_InstantTrigger)) = value;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00100544 File Offset: 0x000FE744
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x00011A00 File Offset: 0x0000FC00
		public unsafe bool m_TriggerAfterSettle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard.NativeFieldInfoPtr_m_TriggerAfterSettle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard.NativeFieldInfoPtr_m_TriggerAfterSettle)) = value;
			}
		}

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeFieldInfoPtr_m_ContainsRarity;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeFieldInfoPtr_m_OnlyShowOncePerWave;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeFieldInfoPtr_m_InstantTrigger;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerAfterSettle;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_get_GetCardForm_Public_Virtual_Final_get_CardForm_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsRarity_Public_get_Il2CppStructArray_1_Rarity_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_get_OnlyShowOncePerWave_Public_get_Boolean_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_get_InstantTrigger_Public_get_Boolean_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_get_TriggerAfterSettle_Public_get_Boolean_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_GetRarityDataMapping_Protected_T_Il2CppArrayBase_1_T_Rarity_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_New_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_ModifyStorageAfterSettle_Public_Virtual_New_Void_Rarity_RogueLikeManager_byref_List_1_Product_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_New_String_String_Rarity_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_New_Boolean_RogueLikeManager_EventManager_Rarity_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_CheckExistSameCard_Protected_Boolean_RogueLikeManager_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr__CheckExistSameCard_b__19_0_Private_Boolean_RogueLikeCardInstance_0;

		// Token: 0x020006DB RID: 1755
		[ObfuscatedName("DayScene.UI.RogueLike.RogueLikeCard+<>c__DisplayClass14_0`1")]
		public sealed class __c__DisplayClass14_0<T> : Object where T : RarityDataMapping
		{
			// Token: 0x06009A4A RID: 39498 RVA: 0x0029122C File Offset: 0x0028F42C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<RogueLikeCard.__c__DisplayClass14_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, "<>c__DisplayClass14_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeCard.__c__DisplayClass14_0<T>>.NativeClassPtr);
				RogueLikeCard.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCard.__c__DisplayClass14_0<T>>.NativeClassPtr, "rarity");
				RogueLikeCard.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard.__c__DisplayClass14_0<T>>.NativeClassPtr, 100668535);
				RogueLikeCard.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__GetRarityDataMapping_b__0_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard.__c__DisplayClass14_0<T>>.NativeClassPtr, 100668536);
				RogueLikeCard.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__GetRarityDataMapping_b__1_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard.__c__DisplayClass14_0<T>>.NativeClassPtr, 100668537);
			}

			// Token: 0x06009A4B RID: 39499 RVA: 0x002912E4 File Offset: 0x0028F4E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeCard.__c__DisplayClass14_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A4C RID: 39500 RVA: 0x00291320 File Offset: 0x0028F520
			[CallerCount(0)]
			public unsafe bool _GetRarityDataMapping_b__0(T x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = x;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref x;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__GetRarityDataMapping_b__0_Internal_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06009A4D RID: 39501 RVA: 0x002913A4 File Offset: 0x0028F5A4
			[CallerCount(0)]
			public unsafe bool _GetRarityDataMapping_b__1(T x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = x;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref x;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__GetRarityDataMapping_b__1_Internal_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06009A4E RID: 39502 RVA: 0x000537F8 File Offset: 0x000519F8
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003343 RID: 13123
			// (get) Token: 0x06009A4F RID: 39503 RVA: 0x00291428 File Offset: 0x0028F628
			// (set) Token: 0x06009A50 RID: 39504 RVA: 0x00053801 File Offset: 0x00051A01
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x04006457 RID: 25687
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x04006458 RID: 25688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006459 RID: 25689
			private static readonly IntPtr NativeMethodInfoPtr__GetRarityDataMapping_b__0_Internal_Boolean_T_0;

			// Token: 0x0400645A RID: 25690
			private static readonly IntPtr NativeMethodInfoPtr__GetRarityDataMapping_b__1_Internal_Boolean_T_0;
		}

		// Token: 0x020006DC RID: 1756
		[ObfuscatedName("DayScene.UI.RogueLike.RogueLikeCard+<UseCard>d__15")]
		public sealed class _UseCard_d__15 : Object
		{
			// Token: 0x06009A51 RID: 39505 RVA: 0x00291450 File Offset: 0x0028F650
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__15()
			{
				Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr, "<UseCard>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr);
				RogueLikeCard._UseCard_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr, "<>1__state");
				RogueLikeCard._UseCard_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr, "<>2__current");
				RogueLikeCard._UseCard_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr, "<>4__this");
				RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr, 100668538);
				RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr, 100668539);
				RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr, 100668540);
				RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr, 100668541);
				RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr, 100668542);
				RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr, 100668543);
			}

			// Token: 0x06009A52 RID: 39506 RVA: 0x00291530 File Offset: 0x0028F730
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeCard._UseCard_d__15>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A53 RID: 39507 RVA: 0x00291578 File Offset: 0x0028F778
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A54 RID: 39508 RVA: 0x002915AC File Offset: 0x0028F7AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73722, XrefRangeEnd = 73733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003347 RID: 13127
			// (get) Token: 0x06009A55 RID: 39509 RVA: 0x002915E8 File Offset: 0x0028F7E8
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009A56 RID: 39510 RVA: 0x00291628 File Offset: 0x0028F828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73733, XrefRangeEnd = 73750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003348 RID: 13128
			// (get) Token: 0x06009A57 RID: 39511 RVA: 0x0029165C File Offset: 0x0028F85C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCard._UseCard_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009A58 RID: 39512 RVA: 0x0005381C File Offset: 0x00051A1C
			public _UseCard_d__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003344 RID: 13124
			// (get) Token: 0x06009A59 RID: 39513 RVA: 0x0029169C File Offset: 0x0028F89C
			// (set) Token: 0x06009A5A RID: 39514 RVA: 0x00053825 File Offset: 0x00051A25
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard._UseCard_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard._UseCard_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003345 RID: 13125
			// (get) Token: 0x06009A5B RID: 39515 RVA: 0x002916C4 File Offset: 0x0028F8C4
			// (set) Token: 0x06009A5C RID: 39516 RVA: 0x00053840 File Offset: 0x00051A40
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard._UseCard_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard._UseCard_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003346 RID: 13126
			// (get) Token: 0x06009A5D RID: 39517 RVA: 0x002916F4 File Offset: 0x0028F8F4
			// (set) Token: 0x06009A5E RID: 39518 RVA: 0x0005385F File Offset: 0x00051A5F
			public unsafe RogueLikeCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard._UseCard_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCard._UseCard_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400645B RID: 25691
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400645C RID: 25692
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400645D RID: 25693
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400645E RID: 25694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400645F RID: 25695
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006460 RID: 25696
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006461 RID: 25697
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006462 RID: 25698
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006463 RID: 25699
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020006DD RID: 1757
		private sealed class MethodInfoStoreGeneric_GetRarityDataMapping_Protected_T_Il2CppArrayBase_1_T_Rarity_0<T>
		{
			// Token: 0x04006464 RID: 25700
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RogueLikeCard.NativeMethodInfoPtr_GetRarityDataMapping_Protected_T_Il2CppArrayBase_1_T_Rarity_0, Il2CppClassPointerStore<RogueLikeCard>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
