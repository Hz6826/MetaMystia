using System;
using Common.DataBaseProfiles;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.U2D;

namespace GameData.Profile
{
	// Token: 0x020002D4 RID: 724
	public class ExpandableGameDataPack : ScriptableObject
	{
		// Token: 0x060058AC RID: 22700 RVA: 0x001C91AC File Offset: 0x001C73AC
		// Note: this type is marked as 'beforefieldinit'.
		static ExpandableGameDataPack()
		{
			Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "ExpandableGameDataPack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr);
			ExpandableGameDataPack.NativeFieldInfoPtr_mapAdditiveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "mapAdditiveData");
			ExpandableGameDataPack.NativeFieldInfoPtr_izakayaAdditiveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "izakayaAdditiveData");
			ExpandableGameDataPack.NativeFieldInfoPtr_schedulerConnectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "schedulerConnectionData");
			ExpandableGameDataPack.NativeFieldInfoPtr_schedulerNewsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "schedulerNewsData");
			ExpandableGameDataPack.NativeFieldInfoPtr_specialGuestAdditiveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "specialGuestAdditiveData");
			ExpandableGameDataPack.NativeFieldInfoPtr_DLCMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "DLCMarker");
			ExpandableGameDataPack.NativeFieldInfoPtr_IngredientProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "IngredientProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_BeverageProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BeverageProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_FoodProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "FoodProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_RecipeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "RecipeProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_CookerProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "CookerProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_IzakayaProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "IzakayaProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_ItemProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "ItemProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_BadgeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BadgeProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_ClothesProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "ClothesProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_DecorationProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "DecorationProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_RecordProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "RecordProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_TrophyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "TrophyProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_FoodTagRuleProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "FoodTagRuleProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_CollectableProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "CollectableProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_NormalNpcProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "NormalNpcProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_DialogCollectionProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "DialogCollectionProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_MerchantProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "MerchantProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneMapProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "DaySceneMapProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_KourindoStaticMerchandiseProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "KourindoStaticMerchandiseProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_IgnoreIngredientsProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "IgnoreIngredientsProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_MissionIngredientsProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "MissionIngredientsProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_OnlyOneDayItemsProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "OnlyOneDayItemsProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_PublicExtraDialogSelectionProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "PublicExtraDialogSelectionProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_FlandreHomeFurnitureProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "FlandreHomeFurnitureProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_NormalGuestPixelProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "NormalGuestPixelProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestVisualProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialGuestVisualProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneNormalGuestVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "DaySceneNormalGuestVisual");
			ExpandableGameDataPack.NativeFieldInfoPtr_NormalNPCIndexMappingProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "NormalNPCIndexMappingProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpecialNPCIndexMappingProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialNPCIndexMappingProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_NormalGuestProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "NormalGuestProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialGuestProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_PartnerInfoProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "PartnerInfoProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestMappingRuleProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialGuestMappingRuleProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_SchedulerProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SchedulerProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_CGProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "CGProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_CGProfileAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "CGProfileAlt");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpellProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpellProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_IzakayaMusicProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "IzakayaMusicProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_MusicMappingProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "MusicMappingProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_MusicChapterProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "MusicChapterProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_MainItemSpriteAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "MainItemSpriteAtlas");
			ExpandableGameDataPack.NativeFieldInfoPtr_BuffSpriteAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BuffSpriteAtlas");
			ExpandableGameDataPack.NativeFieldInfoPtr_IngredientSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "IngredientSprite");
			ExpandableGameDataPack.NativeFieldInfoPtr_ItemSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "ItemSprite");
			ExpandableGameDataPack.NativeFieldInfoPtr_BadgeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BadgeSprite");
			ExpandableGameDataPack.NativeFieldInfoPtr_BeverageSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BeverageSprite");
			ExpandableGameDataPack.NativeFieldInfoPtr_FoodSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "FoodSprite");
			ExpandableGameDataPack.NativeFieldInfoPtr_CookerSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "CookerSprite");
			ExpandableGameDataPack.NativeFieldInfoPtr_IzakayaSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "IzakayaSprite");
			ExpandableGameDataPack.NativeFieldInfoPtr_BuffSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BuffSprite");
			ExpandableGameDataPack.NativeFieldInfoPtr_IngredientItemBadgeBeverageFoodCookerIzakayaSpriteAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "IngredientItemBadgeBeverageFoodCookerIzakayaSpriteAtlas");
			ExpandableGameDataPack.NativeFieldInfoPtr_CommonPhraseLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "CommonPhraseLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_BeverageTagProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BeverageTagProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_BeverageTagsLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BeverageTagsLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_FoodTagProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "FoodTagProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_FoodTagsLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "FoodTagsLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_FoodPrefixLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "FoodPrefixLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_IngredientsLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "IngredientsLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_ItemsLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "ItemsLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_BadgeLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BadgeLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_BeveragesLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BeveragesLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_FoodsLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "FoodsLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_MissionsLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "MissionsLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_NewsLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "NewsLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_CookersLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "CookersLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_IzakayasLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "IzakayasLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_NormalGuestLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "NormalGuestLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialGuestLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestFoodRequestLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialGuestFoodRequestLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestBevRequestLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialGuestBevRequestLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_BuffDescriptionLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "BuffDescriptionLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_MissionFinishConditionLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "MissionFinishConditionLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_RewardConditionLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "RewardConditionLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_PartnerJobLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "PartnerJobLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_CGDataLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "CGDataLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_MusicNameDataLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "MusicNameDataLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpellLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpellLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpecialEvalLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialEvalLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_NormalEvalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "NormalEvalIndex");
			ExpandableGameDataPack.NativeFieldInfoPtr_NormalEvalLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "NormalEvalLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpecialConvLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialConvLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_NormalConvProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "NormalConvProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_SpecialConvProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialConvProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_NormalConvLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "NormalConvLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneNPCNameLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "DaySceneNPCNameLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneInteractableEntitiesNameLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "DaySceneInteractableEntitiesNameLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_MapLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "MapLang");
			ExpandableGameDataPack.NativeFieldInfoPtr_AchievementProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "AchievementProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_AdditionalStaffPages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "AdditionalStaffPages");
			ExpandableGameDataPack.NativeFieldInfoPtr_ConcertProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "ConcertProfile");
			ExpandableGameDataPack.NativeFieldInfoPtr_ConcertProfileAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "ConcertProfileAlt");
			ExpandableGameDataPack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, 100681273);
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x001C9984 File Offset: 0x001C7B84
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpandableGameDataPack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x0002F896 File Offset: 0x0002DA96
		public ExpandableGameDataPack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x060058AF RID: 22703 RVA: 0x001C99C0 File Offset: 0x001C7BC0
		// (set) Token: 0x060058B0 RID: 22704 RVA: 0x0002F89F File Offset: 0x0002DA9F
		public unsafe Il2CppReferenceArray<ExpandableGameDataPack.MapAdditiveData> mapAdditiveData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_mapAdditiveData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpandableGameDataPack.MapAdditiveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_mapAdditiveData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x060058B1 RID: 22705 RVA: 0x001C99F0 File Offset: 0x001C7BF0
		// (set) Token: 0x060058B2 RID: 22706 RVA: 0x0002F8BE File Offset: 0x0002DABE
		public unsafe Il2CppReferenceArray<ExpandableGameDataPack.IzakayaAdditiveData> izakayaAdditiveData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_izakayaAdditiveData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpandableGameDataPack.IzakayaAdditiveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_izakayaAdditiveData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x060058B3 RID: 22707 RVA: 0x001C9A20 File Offset: 0x001C7C20
		// (set) Token: 0x060058B4 RID: 22708 RVA: 0x0002F8DD File Offset: 0x0002DADD
		public unsafe Il2CppReferenceArray<ExpandableGameDataPack.SchedulerConnectionData> schedulerConnectionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_schedulerConnectionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpandableGameDataPack.SchedulerConnectionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_schedulerConnectionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x060058B5 RID: 22709 RVA: 0x001C9A50 File Offset: 0x001C7C50
		// (set) Token: 0x060058B6 RID: 22710 RVA: 0x0002F8FC File Offset: 0x0002DAFC
		public unsafe Il2CppReferenceArray<ExpandableGameDataPack.SchedulerNewsData> schedulerNewsData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_schedulerNewsData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpandableGameDataPack.SchedulerNewsData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_schedulerNewsData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x060058B7 RID: 22711 RVA: 0x001C9A80 File Offset: 0x001C7C80
		// (set) Token: 0x060058B8 RID: 22712 RVA: 0x0002F91B File Offset: 0x0002DB1B
		public unsafe Il2CppReferenceArray<ExpandableGameDataPack.SpecialGuestAdditiveData> specialGuestAdditiveData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_specialGuestAdditiveData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpandableGameDataPack.SpecialGuestAdditiveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_specialGuestAdditiveData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x060058B9 RID: 22713 RVA: 0x001C9AB0 File Offset: 0x001C7CB0
		// (set) Token: 0x060058BA RID: 22714 RVA: 0x0002F93A File Offset: 0x0002DB3A
		public unsafe AssetReference DLCMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DLCMarker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DLCMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x060058BB RID: 22715 RVA: 0x001C9AE0 File Offset: 0x001C7CE0
		// (set) Token: 0x060058BC RID: 22716 RVA: 0x0002F959 File Offset: 0x0002DB59
		public unsafe AssetReference IngredientProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IngredientProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IngredientProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x060058BD RID: 22717 RVA: 0x001C9B10 File Offset: 0x001C7D10
		// (set) Token: 0x060058BE RID: 22718 RVA: 0x0002F978 File Offset: 0x0002DB78
		public unsafe AssetReference BeverageProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BeverageProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BeverageProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x060058BF RID: 22719 RVA: 0x001C9B40 File Offset: 0x001C7D40
		// (set) Token: 0x060058C0 RID: 22720 RVA: 0x0002F997 File Offset: 0x0002DB97
		public unsafe AssetReference FoodProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x060058C1 RID: 22721 RVA: 0x001C9B70 File Offset: 0x001C7D70
		// (set) Token: 0x060058C2 RID: 22722 RVA: 0x0002F9B6 File Offset: 0x0002DBB6
		public unsafe AssetReference RecipeProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_RecipeProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_RecipeProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x060058C3 RID: 22723 RVA: 0x001C9BA0 File Offset: 0x001C7DA0
		// (set) Token: 0x060058C4 RID: 22724 RVA: 0x0002F9D5 File Offset: 0x0002DBD5
		public unsafe AssetReference CookerProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CookerProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CookerProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x060058C5 RID: 22725 RVA: 0x001C9BD0 File Offset: 0x001C7DD0
		// (set) Token: 0x060058C6 RID: 22726 RVA: 0x0002F9F4 File Offset: 0x0002DBF4
		public unsafe AssetReference IzakayaProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IzakayaProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IzakayaProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x060058C7 RID: 22727 RVA: 0x001C9C00 File Offset: 0x001C7E00
		// (set) Token: 0x060058C8 RID: 22728 RVA: 0x0002FA13 File Offset: 0x0002DC13
		public unsafe AssetReference ItemProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ItemProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ItemProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x060058C9 RID: 22729 RVA: 0x001C9C30 File Offset: 0x001C7E30
		// (set) Token: 0x060058CA RID: 22730 RVA: 0x0002FA32 File Offset: 0x0002DC32
		public unsafe AssetReference BadgeProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BadgeProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BadgeProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x060058CB RID: 22731 RVA: 0x001C9C60 File Offset: 0x001C7E60
		// (set) Token: 0x060058CC RID: 22732 RVA: 0x0002FA51 File Offset: 0x0002DC51
		public unsafe AssetReference ClothesProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ClothesProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ClothesProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x060058CD RID: 22733 RVA: 0x001C9C90 File Offset: 0x001C7E90
		// (set) Token: 0x060058CE RID: 22734 RVA: 0x0002FA70 File Offset: 0x0002DC70
		public unsafe AssetReference DecorationProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DecorationProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DecorationProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x060058CF RID: 22735 RVA: 0x001C9CC0 File Offset: 0x001C7EC0
		// (set) Token: 0x060058D0 RID: 22736 RVA: 0x0002FA8F File Offset: 0x0002DC8F
		public unsafe AssetReference RecordProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_RecordProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_RecordProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x060058D1 RID: 22737 RVA: 0x001C9CF0 File Offset: 0x001C7EF0
		// (set) Token: 0x060058D2 RID: 22738 RVA: 0x0002FAAE File Offset: 0x0002DCAE
		public unsafe AssetReference TrophyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_TrophyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_TrophyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x060058D3 RID: 22739 RVA: 0x001C9D20 File Offset: 0x001C7F20
		// (set) Token: 0x060058D4 RID: 22740 RVA: 0x0002FACD File Offset: 0x0002DCCD
		public unsafe AssetReference FoodTagRuleProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodTagRuleProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodTagRuleProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x060058D5 RID: 22741 RVA: 0x001C9D50 File Offset: 0x001C7F50
		// (set) Token: 0x060058D6 RID: 22742 RVA: 0x0002FAEC File Offset: 0x0002DCEC
		public unsafe AssetReference CollectableProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CollectableProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CollectableProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x060058D7 RID: 22743 RVA: 0x001C9D80 File Offset: 0x001C7F80
		// (set) Token: 0x060058D8 RID: 22744 RVA: 0x0002FB0B File Offset: 0x0002DD0B
		public unsafe AssetReference NormalNpcProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalNpcProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalNpcProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x060058D9 RID: 22745 RVA: 0x001C9DB0 File Offset: 0x001C7FB0
		// (set) Token: 0x060058DA RID: 22746 RVA: 0x0002FB2A File Offset: 0x0002DD2A
		public unsafe Il2CppReferenceArray<AssetReference> DialogCollectionProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DialogCollectionProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DialogCollectionProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x060058DB RID: 22747 RVA: 0x001C9DE0 File Offset: 0x001C7FE0
		// (set) Token: 0x060058DC RID: 22748 RVA: 0x0002FB49 File Offset: 0x0002DD49
		public unsafe AssetReference MerchantProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MerchantProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MerchantProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x060058DD RID: 22749 RVA: 0x001C9E10 File Offset: 0x001C8010
		// (set) Token: 0x060058DE RID: 22750 RVA: 0x0002FB68 File Offset: 0x0002DD68
		public unsafe AssetReference DaySceneMapProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneMapProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneMapProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x060058DF RID: 22751 RVA: 0x001C9E40 File Offset: 0x001C8040
		// (set) Token: 0x060058E0 RID: 22752 RVA: 0x0002FB87 File Offset: 0x0002DD87
		public unsafe AssetReference KourindoStaticMerchandiseProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_KourindoStaticMerchandiseProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_KourindoStaticMerchandiseProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x060058E1 RID: 22753 RVA: 0x001C9E70 File Offset: 0x001C8070
		// (set) Token: 0x060058E2 RID: 22754 RVA: 0x0002FBA6 File Offset: 0x0002DDA6
		public unsafe AssetReference IgnoreIngredientsProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IgnoreIngredientsProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IgnoreIngredientsProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x060058E3 RID: 22755 RVA: 0x001C9EA0 File Offset: 0x001C80A0
		// (set) Token: 0x060058E4 RID: 22756 RVA: 0x0002FBC5 File Offset: 0x0002DDC5
		public unsafe AssetReference MissionIngredientsProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MissionIngredientsProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MissionIngredientsProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x060058E5 RID: 22757 RVA: 0x001C9ED0 File Offset: 0x001C80D0
		// (set) Token: 0x060058E6 RID: 22758 RVA: 0x0002FBE4 File Offset: 0x0002DDE4
		public unsafe AssetReference OnlyOneDayItemsProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_OnlyOneDayItemsProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_OnlyOneDayItemsProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x060058E7 RID: 22759 RVA: 0x001C9F00 File Offset: 0x001C8100
		// (set) Token: 0x060058E8 RID: 22760 RVA: 0x0002FC03 File Offset: 0x0002DE03
		public unsafe AssetReference PublicExtraDialogSelectionProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_PublicExtraDialogSelectionProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_PublicExtraDialogSelectionProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x060058E9 RID: 22761 RVA: 0x001C9F30 File Offset: 0x001C8130
		// (set) Token: 0x060058EA RID: 22762 RVA: 0x0002FC22 File Offset: 0x0002DE22
		public unsafe AssetReference FlandreHomeFurnitureProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FlandreHomeFurnitureProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FlandreHomeFurnitureProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x060058EB RID: 22763 RVA: 0x001C9F60 File Offset: 0x001C8160
		// (set) Token: 0x060058EC RID: 22764 RVA: 0x0002FC41 File Offset: 0x0002DE41
		public unsafe AssetReference NormalGuestPixelProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalGuestPixelProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalGuestPixelProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x060058ED RID: 22765 RVA: 0x001C9F90 File Offset: 0x001C8190
		// (set) Token: 0x060058EE RID: 22766 RVA: 0x0002FC60 File Offset: 0x0002DE60
		public unsafe AssetReference SpecialGuestVisualProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestVisualProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestVisualProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x060058EF RID: 22767 RVA: 0x001C9FC0 File Offset: 0x001C81C0
		// (set) Token: 0x060058F0 RID: 22768 RVA: 0x0002FC7F File Offset: 0x0002DE7F
		public unsafe AssetReference DaySceneNormalGuestVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneNormalGuestVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneNormalGuestVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x060058F1 RID: 22769 RVA: 0x001C9FF0 File Offset: 0x001C81F0
		// (set) Token: 0x060058F2 RID: 22770 RVA: 0x0002FC9E File Offset: 0x0002DE9E
		public unsafe AssetReference NormalNPCIndexMappingProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalNPCIndexMappingProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalNPCIndexMappingProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x060058F3 RID: 22771 RVA: 0x001CA020 File Offset: 0x001C8220
		// (set) Token: 0x060058F4 RID: 22772 RVA: 0x0002FCBD File Offset: 0x0002DEBD
		public unsafe AssetReference SpecialNPCIndexMappingProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialNPCIndexMappingProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialNPCIndexMappingProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x060058F5 RID: 22773 RVA: 0x001CA050 File Offset: 0x001C8250
		// (set) Token: 0x060058F6 RID: 22774 RVA: 0x0002FCDC File Offset: 0x0002DEDC
		public unsafe AssetReference NormalGuestProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalGuestProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalGuestProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x060058F7 RID: 22775 RVA: 0x001CA080 File Offset: 0x001C8280
		// (set) Token: 0x060058F8 RID: 22776 RVA: 0x0002FCFB File Offset: 0x0002DEFB
		public unsafe AssetReference SpecialGuestProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x060058F9 RID: 22777 RVA: 0x001CA0B0 File Offset: 0x001C82B0
		// (set) Token: 0x060058FA RID: 22778 RVA: 0x0002FD1A File Offset: 0x0002DF1A
		public unsafe AssetReference PartnerInfoProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_PartnerInfoProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_PartnerInfoProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x060058FB RID: 22779 RVA: 0x001CA0E0 File Offset: 0x001C82E0
		// (set) Token: 0x060058FC RID: 22780 RVA: 0x0002FD39 File Offset: 0x0002DF39
		public unsafe AssetReference SpecialGuestMappingRuleProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestMappingRuleProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestMappingRuleProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x060058FD RID: 22781 RVA: 0x001CA110 File Offset: 0x001C8310
		// (set) Token: 0x060058FE RID: 22782 RVA: 0x0002FD58 File Offset: 0x0002DF58
		public unsafe AssetReference SchedulerProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SchedulerProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SchedulerProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x060058FF RID: 22783 RVA: 0x001CA140 File Offset: 0x001C8340
		// (set) Token: 0x06005900 RID: 22784 RVA: 0x0002FD77 File Offset: 0x0002DF77
		public unsafe AssetReference CGProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CGProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CGProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x06005901 RID: 22785 RVA: 0x001CA170 File Offset: 0x001C8370
		// (set) Token: 0x06005902 RID: 22786 RVA: 0x0002FD96 File Offset: 0x0002DF96
		public unsafe AssetReference CGProfileAlt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CGProfileAlt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CGProfileAlt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x06005903 RID: 22787 RVA: 0x001CA1A0 File Offset: 0x001C83A0
		// (set) Token: 0x06005904 RID: 22788 RVA: 0x0002FDB5 File Offset: 0x0002DFB5
		public unsafe AssetReference SpellProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpellProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpellProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x06005905 RID: 22789 RVA: 0x001CA1D0 File Offset: 0x001C83D0
		// (set) Token: 0x06005906 RID: 22790 RVA: 0x0002FDD4 File Offset: 0x0002DFD4
		public unsafe Il2CppReferenceArray<ExpandableGameDataPack.AssetReferenceIdPair> IzakayaMusicProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IzakayaMusicProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpandableGameDataPack.AssetReferenceIdPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IzakayaMusicProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x06005907 RID: 22791 RVA: 0x001CA200 File Offset: 0x001C8400
		// (set) Token: 0x06005908 RID: 22792 RVA: 0x0002FDF3 File Offset: 0x0002DFF3
		public unsafe AssetReference MusicMappingProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MusicMappingProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MusicMappingProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x06005909 RID: 22793 RVA: 0x001CA230 File Offset: 0x001C8430
		// (set) Token: 0x0600590A RID: 22794 RVA: 0x0002FE12 File Offset: 0x0002E012
		public unsafe AssetReference MusicChapterProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MusicChapterProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MusicChapterProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x0600590B RID: 22795 RVA: 0x001CA260 File Offset: 0x001C8460
		// (set) Token: 0x0600590C RID: 22796 RVA: 0x0002FE31 File Offset: 0x0002E031
		public unsafe AssetReferenceT<SpriteAtlas> MainItemSpriteAtlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MainItemSpriteAtlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<SpriteAtlas>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MainItemSpriteAtlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x0600590D RID: 22797 RVA: 0x001CA290 File Offset: 0x001C8490
		// (set) Token: 0x0600590E RID: 22798 RVA: 0x0002FE50 File Offset: 0x0002E050
		public unsafe AssetReferenceT<SpriteAtlas> BuffSpriteAtlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BuffSpriteAtlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<SpriteAtlas>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BuffSpriteAtlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x0600590F RID: 22799 RVA: 0x001CA2C0 File Offset: 0x001C84C0
		// (set) Token: 0x06005910 RID: 22800 RVA: 0x0002FE6F File Offset: 0x0002E06F
		public unsafe AssetReference IngredientSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IngredientSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IngredientSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x06005911 RID: 22801 RVA: 0x001CA2F0 File Offset: 0x001C84F0
		// (set) Token: 0x06005912 RID: 22802 RVA: 0x0002FE8E File Offset: 0x0002E08E
		public unsafe AssetReference ItemSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ItemSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ItemSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x06005913 RID: 22803 RVA: 0x001CA320 File Offset: 0x001C8520
		// (set) Token: 0x06005914 RID: 22804 RVA: 0x0002FEAD File Offset: 0x0002E0AD
		public unsafe AssetReference BadgeSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BadgeSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BadgeSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x06005915 RID: 22805 RVA: 0x001CA350 File Offset: 0x001C8550
		// (set) Token: 0x06005916 RID: 22806 RVA: 0x0002FECC File Offset: 0x0002E0CC
		public unsafe AssetReference BeverageSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BeverageSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BeverageSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06005917 RID: 22807 RVA: 0x001CA380 File Offset: 0x001C8580
		// (set) Token: 0x06005918 RID: 22808 RVA: 0x0002FEEB File Offset: 0x0002E0EB
		public unsafe AssetReference FoodSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x06005919 RID: 22809 RVA: 0x001CA3B0 File Offset: 0x001C85B0
		// (set) Token: 0x0600591A RID: 22810 RVA: 0x0002FF0A File Offset: 0x0002E10A
		public unsafe AssetReference CookerSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CookerSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CookerSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x0600591B RID: 22811 RVA: 0x001CA3E0 File Offset: 0x001C85E0
		// (set) Token: 0x0600591C RID: 22812 RVA: 0x0002FF29 File Offset: 0x0002E129
		public unsafe AssetReference IzakayaSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IzakayaSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IzakayaSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x0600591D RID: 22813 RVA: 0x001CA410 File Offset: 0x001C8610
		// (set) Token: 0x0600591E RID: 22814 RVA: 0x0002FF48 File Offset: 0x0002E148
		public unsafe AssetReference BuffSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BuffSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BuffSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x0600591F RID: 22815 RVA: 0x001CA440 File Offset: 0x001C8640
		// (set) Token: 0x06005920 RID: 22816 RVA: 0x0002FF67 File Offset: 0x0002E167
		public unsafe AssetReferenceT<SpriteAtlas> IngredientItemBadgeBeverageFoodCookerIzakayaSpriteAtlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IngredientItemBadgeBeverageFoodCookerIzakayaSpriteAtlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<SpriteAtlas>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IngredientItemBadgeBeverageFoodCookerIzakayaSpriteAtlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06005921 RID: 22817 RVA: 0x001CA470 File Offset: 0x001C8670
		// (set) Token: 0x06005922 RID: 22818 RVA: 0x0002FF86 File Offset: 0x0002E186
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference CommonPhraseLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CommonPhraseLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CommonPhraseLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06005923 RID: 22819 RVA: 0x001CA4A0 File Offset: 0x001C86A0
		// (set) Token: 0x06005924 RID: 22820 RVA: 0x0002FFA5 File Offset: 0x0002E1A5
		public unsafe AssetReference BeverageTagProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BeverageTagProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BeverageTagProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06005925 RID: 22821 RVA: 0x001CA4D0 File Offset: 0x001C86D0
		// (set) Token: 0x06005926 RID: 22822 RVA: 0x0002FFC4 File Offset: 0x0002E1C4
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference BeverageTagsLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BeverageTagsLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BeverageTagsLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06005927 RID: 22823 RVA: 0x001CA500 File Offset: 0x001C8700
		// (set) Token: 0x06005928 RID: 22824 RVA: 0x0002FFE3 File Offset: 0x0002E1E3
		public unsafe AssetReference FoodTagProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodTagProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodTagProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06005929 RID: 22825 RVA: 0x001CA530 File Offset: 0x001C8730
		// (set) Token: 0x0600592A RID: 22826 RVA: 0x00030002 File Offset: 0x0002E202
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference FoodTagsLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodTagsLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodTagsLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x0600592B RID: 22827 RVA: 0x001CA560 File Offset: 0x001C8760
		// (set) Token: 0x0600592C RID: 22828 RVA: 0x00030021 File Offset: 0x0002E221
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference FoodPrefixLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodPrefixLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodPrefixLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x0600592D RID: 22829 RVA: 0x001CA590 File Offset: 0x001C8790
		// (set) Token: 0x0600592E RID: 22830 RVA: 0x00030040 File Offset: 0x0002E240
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference IngredientsLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IngredientsLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IngredientsLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x0600592F RID: 22831 RVA: 0x001CA5C0 File Offset: 0x001C87C0
		// (set) Token: 0x06005930 RID: 22832 RVA: 0x0003005F File Offset: 0x0002E25F
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference ItemsLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ItemsLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ItemsLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06005931 RID: 22833 RVA: 0x001CA5F0 File Offset: 0x001C87F0
		// (set) Token: 0x06005932 RID: 22834 RVA: 0x0003007E File Offset: 0x0002E27E
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference BadgeLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BadgeLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BadgeLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06005933 RID: 22835 RVA: 0x001CA620 File Offset: 0x001C8820
		// (set) Token: 0x06005934 RID: 22836 RVA: 0x0003009D File Offset: 0x0002E29D
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference BeveragesLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BeveragesLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BeveragesLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06005935 RID: 22837 RVA: 0x001CA650 File Offset: 0x001C8850
		// (set) Token: 0x06005936 RID: 22838 RVA: 0x000300BC File Offset: 0x0002E2BC
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference FoodsLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodsLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_FoodsLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06005937 RID: 22839 RVA: 0x001CA680 File Offset: 0x001C8880
		// (set) Token: 0x06005938 RID: 22840 RVA: 0x000300DB File Offset: 0x0002E2DB
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference MissionsLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MissionsLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MissionsLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06005939 RID: 22841 RVA: 0x001CA6B0 File Offset: 0x001C88B0
		// (set) Token: 0x0600593A RID: 22842 RVA: 0x000300FA File Offset: 0x0002E2FA
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference NewsLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NewsLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NewsLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x0600593B RID: 22843 RVA: 0x001CA6E0 File Offset: 0x001C88E0
		// (set) Token: 0x0600593C RID: 22844 RVA: 0x00030119 File Offset: 0x0002E319
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference CookersLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CookersLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CookersLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x0600593D RID: 22845 RVA: 0x001CA710 File Offset: 0x001C8910
		// (set) Token: 0x0600593E RID: 22846 RVA: 0x00030138 File Offset: 0x0002E338
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference IzakayasLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IzakayasLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_IzakayasLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x0600593F RID: 22847 RVA: 0x001CA740 File Offset: 0x001C8940
		// (set) Token: 0x06005940 RID: 22848 RVA: 0x00030157 File Offset: 0x0002E357
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference NormalGuestLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalGuestLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalGuestLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06005941 RID: 22849 RVA: 0x001CA770 File Offset: 0x001C8970
		// (set) Token: 0x06005942 RID: 22850 RVA: 0x00030176 File Offset: 0x0002E376
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference SpecialGuestLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x06005943 RID: 22851 RVA: 0x001CA7A0 File Offset: 0x001C89A0
		// (set) Token: 0x06005944 RID: 22852 RVA: 0x00030195 File Offset: 0x0002E395
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference SpecialGuestFoodRequestLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestFoodRequestLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestFoodRequestLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x06005945 RID: 22853 RVA: 0x001CA7D0 File Offset: 0x001C89D0
		// (set) Token: 0x06005946 RID: 22854 RVA: 0x000301B4 File Offset: 0x0002E3B4
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference SpecialGuestBevRequestLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestBevRequestLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialGuestBevRequestLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x06005947 RID: 22855 RVA: 0x001CA800 File Offset: 0x001C8A00
		// (set) Token: 0x06005948 RID: 22856 RVA: 0x000301D3 File Offset: 0x0002E3D3
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference BuffDescriptionLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BuffDescriptionLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_BuffDescriptionLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06005949 RID: 22857 RVA: 0x001CA830 File Offset: 0x001C8A30
		// (set) Token: 0x0600594A RID: 22858 RVA: 0x000301F2 File Offset: 0x0002E3F2
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference MissionFinishConditionLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MissionFinishConditionLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MissionFinishConditionLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x0600594B RID: 22859 RVA: 0x001CA860 File Offset: 0x001C8A60
		// (set) Token: 0x0600594C RID: 22860 RVA: 0x00030211 File Offset: 0x0002E411
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference RewardConditionLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_RewardConditionLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_RewardConditionLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x0600594D RID: 22861 RVA: 0x001CA890 File Offset: 0x001C8A90
		// (set) Token: 0x0600594E RID: 22862 RVA: 0x00030230 File Offset: 0x0002E430
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference PartnerJobLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_PartnerJobLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_PartnerJobLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x0600594F RID: 22863 RVA: 0x001CA8C0 File Offset: 0x001C8AC0
		// (set) Token: 0x06005950 RID: 22864 RVA: 0x0003024F File Offset: 0x0002E44F
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference CGDataLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CGDataLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_CGDataLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x06005951 RID: 22865 RVA: 0x001CA8F0 File Offset: 0x001C8AF0
		// (set) Token: 0x06005952 RID: 22866 RVA: 0x0003026E File Offset: 0x0002E46E
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference MusicNameDataLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MusicNameDataLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MusicNameDataLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06005953 RID: 22867 RVA: 0x001CA920 File Offset: 0x001C8B20
		// (set) Token: 0x06005954 RID: 22868 RVA: 0x0003028D File Offset: 0x0002E48D
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference SpellLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpellLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpellLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x06005955 RID: 22869 RVA: 0x001CA950 File Offset: 0x001C8B50
		// (set) Token: 0x06005956 RID: 22870 RVA: 0x000302AC File Offset: 0x0002E4AC
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference SpecialEvalLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialEvalLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialEvalLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06005957 RID: 22871 RVA: 0x001CA980 File Offset: 0x001C8B80
		// (set) Token: 0x06005958 RID: 22872 RVA: 0x000302CB File Offset: 0x0002E4CB
		public unsafe AssetReference NormalEvalIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalEvalIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalEvalIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06005959 RID: 22873 RVA: 0x001CA9B0 File Offset: 0x001C8BB0
		// (set) Token: 0x0600595A RID: 22874 RVA: 0x000302EA File Offset: 0x0002E4EA
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference NormalEvalLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalEvalLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalEvalLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x0600595B RID: 22875 RVA: 0x001CA9E0 File Offset: 0x001C8BE0
		// (set) Token: 0x0600595C RID: 22876 RVA: 0x00030309 File Offset: 0x0002E509
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference SpecialConvLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialConvLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialConvLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x0600595D RID: 22877 RVA: 0x001CAA10 File Offset: 0x001C8C10
		// (set) Token: 0x0600595E RID: 22878 RVA: 0x00030328 File Offset: 0x0002E528
		public unsafe AssetReference NormalConvProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalConvProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalConvProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x0600595F RID: 22879 RVA: 0x001CAA40 File Offset: 0x001C8C40
		// (set) Token: 0x06005960 RID: 22880 RVA: 0x00030347 File Offset: 0x0002E547
		public unsafe AssetReference SpecialConvProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialConvProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_SpecialConvProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06005961 RID: 22881 RVA: 0x001CAA70 File Offset: 0x001C8C70
		// (set) Token: 0x06005962 RID: 22882 RVA: 0x00030366 File Offset: 0x0002E566
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference NormalConvLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalConvLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_NormalConvLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06005963 RID: 22883 RVA: 0x001CAAA0 File Offset: 0x001C8CA0
		// (set) Token: 0x06005964 RID: 22884 RVA: 0x00030385 File Offset: 0x0002E585
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference DaySceneNPCNameLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneNPCNameLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneNPCNameLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06005965 RID: 22885 RVA: 0x001CAAD0 File Offset: 0x001C8CD0
		// (set) Token: 0x06005966 RID: 22886 RVA: 0x000303A4 File Offset: 0x0002E5A4
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference DaySceneInteractableEntitiesNameLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneInteractableEntitiesNameLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_DaySceneInteractableEntitiesNameLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06005967 RID: 22887 RVA: 0x001CAB00 File Offset: 0x001C8D00
		// (set) Token: 0x06005968 RID: 22888 RVA: 0x000303C3 File Offset: 0x0002E5C3
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference MapLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MapLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_MapLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06005969 RID: 22889 RVA: 0x001CAB30 File Offset: 0x001C8D30
		// (set) Token: 0x0600596A RID: 22890 RVA: 0x000303E2 File Offset: 0x0002E5E2
		public unsafe AssetReference AchievementProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_AchievementProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_AchievementProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x0600596B RID: 22891 RVA: 0x001CAB60 File Offset: 0x001C8D60
		// (set) Token: 0x0600596C RID: 22892 RVA: 0x00030401 File Offset: 0x0002E601
		public unsafe Il2CppReferenceArray<AssetReference> AdditionalStaffPages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_AdditionalStaffPages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_AdditionalStaffPages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x0600596D RID: 22893 RVA: 0x001CAB90 File Offset: 0x001C8D90
		// (set) Token: 0x0600596E RID: 22894 RVA: 0x00030420 File Offset: 0x0002E620
		public unsafe ConcertProfile ConcertProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ConcertProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcertProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ConcertProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x0600596F RID: 22895 RVA: 0x001CABC0 File Offset: 0x001C8DC0
		// (set) Token: 0x06005970 RID: 22896 RVA: 0x0003043F File Offset: 0x0002E63F
		public unsafe ConcertProfile ConcertProfileAlt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ConcertProfileAlt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcertProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.NativeFieldInfoPtr_ConcertProfileAlt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B53 RID: 15187
		private static readonly IntPtr NativeFieldInfoPtr_mapAdditiveData;

		// Token: 0x04003B54 RID: 15188
		private static readonly IntPtr NativeFieldInfoPtr_izakayaAdditiveData;

		// Token: 0x04003B55 RID: 15189
		private static readonly IntPtr NativeFieldInfoPtr_schedulerConnectionData;

		// Token: 0x04003B56 RID: 15190
		private static readonly IntPtr NativeFieldInfoPtr_schedulerNewsData;

		// Token: 0x04003B57 RID: 15191
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestAdditiveData;

		// Token: 0x04003B58 RID: 15192
		private static readonly IntPtr NativeFieldInfoPtr_DLCMarker;

		// Token: 0x04003B59 RID: 15193
		private static readonly IntPtr NativeFieldInfoPtr_IngredientProfile;

		// Token: 0x04003B5A RID: 15194
		private static readonly IntPtr NativeFieldInfoPtr_BeverageProfile;

		// Token: 0x04003B5B RID: 15195
		private static readonly IntPtr NativeFieldInfoPtr_FoodProfile;

		// Token: 0x04003B5C RID: 15196
		private static readonly IntPtr NativeFieldInfoPtr_RecipeProfile;

		// Token: 0x04003B5D RID: 15197
		private static readonly IntPtr NativeFieldInfoPtr_CookerProfile;

		// Token: 0x04003B5E RID: 15198
		private static readonly IntPtr NativeFieldInfoPtr_IzakayaProfile;

		// Token: 0x04003B5F RID: 15199
		private static readonly IntPtr NativeFieldInfoPtr_ItemProfile;

		// Token: 0x04003B60 RID: 15200
		private static readonly IntPtr NativeFieldInfoPtr_BadgeProfile;

		// Token: 0x04003B61 RID: 15201
		private static readonly IntPtr NativeFieldInfoPtr_ClothesProfile;

		// Token: 0x04003B62 RID: 15202
		private static readonly IntPtr NativeFieldInfoPtr_DecorationProfile;

		// Token: 0x04003B63 RID: 15203
		private static readonly IntPtr NativeFieldInfoPtr_RecordProfile;

		// Token: 0x04003B64 RID: 15204
		private static readonly IntPtr NativeFieldInfoPtr_TrophyProfile;

		// Token: 0x04003B65 RID: 15205
		private static readonly IntPtr NativeFieldInfoPtr_FoodTagRuleProfile;

		// Token: 0x04003B66 RID: 15206
		private static readonly IntPtr NativeFieldInfoPtr_CollectableProfile;

		// Token: 0x04003B67 RID: 15207
		private static readonly IntPtr NativeFieldInfoPtr_NormalNpcProfile;

		// Token: 0x04003B68 RID: 15208
		private static readonly IntPtr NativeFieldInfoPtr_DialogCollectionProfile;

		// Token: 0x04003B69 RID: 15209
		private static readonly IntPtr NativeFieldInfoPtr_MerchantProfile;

		// Token: 0x04003B6A RID: 15210
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneMapProfile;

		// Token: 0x04003B6B RID: 15211
		private static readonly IntPtr NativeFieldInfoPtr_KourindoStaticMerchandiseProfile;

		// Token: 0x04003B6C RID: 15212
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreIngredientsProfile;

		// Token: 0x04003B6D RID: 15213
		private static readonly IntPtr NativeFieldInfoPtr_MissionIngredientsProfile;

		// Token: 0x04003B6E RID: 15214
		private static readonly IntPtr NativeFieldInfoPtr_OnlyOneDayItemsProfile;

		// Token: 0x04003B6F RID: 15215
		private static readonly IntPtr NativeFieldInfoPtr_PublicExtraDialogSelectionProfile;

		// Token: 0x04003B70 RID: 15216
		private static readonly IntPtr NativeFieldInfoPtr_FlandreHomeFurnitureProfile;

		// Token: 0x04003B71 RID: 15217
		private static readonly IntPtr NativeFieldInfoPtr_NormalGuestPixelProfile;

		// Token: 0x04003B72 RID: 15218
		private static readonly IntPtr NativeFieldInfoPtr_SpecialGuestVisualProfile;

		// Token: 0x04003B73 RID: 15219
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneNormalGuestVisual;

		// Token: 0x04003B74 RID: 15220
		private static readonly IntPtr NativeFieldInfoPtr_NormalNPCIndexMappingProfile;

		// Token: 0x04003B75 RID: 15221
		private static readonly IntPtr NativeFieldInfoPtr_SpecialNPCIndexMappingProfile;

		// Token: 0x04003B76 RID: 15222
		private static readonly IntPtr NativeFieldInfoPtr_NormalGuestProfile;

		// Token: 0x04003B77 RID: 15223
		private static readonly IntPtr NativeFieldInfoPtr_SpecialGuestProfile;

		// Token: 0x04003B78 RID: 15224
		private static readonly IntPtr NativeFieldInfoPtr_PartnerInfoProfile;

		// Token: 0x04003B79 RID: 15225
		private static readonly IntPtr NativeFieldInfoPtr_SpecialGuestMappingRuleProfile;

		// Token: 0x04003B7A RID: 15226
		private static readonly IntPtr NativeFieldInfoPtr_SchedulerProfile;

		// Token: 0x04003B7B RID: 15227
		private static readonly IntPtr NativeFieldInfoPtr_CGProfile;

		// Token: 0x04003B7C RID: 15228
		private static readonly IntPtr NativeFieldInfoPtr_CGProfileAlt;

		// Token: 0x04003B7D RID: 15229
		private static readonly IntPtr NativeFieldInfoPtr_SpellProfile;

		// Token: 0x04003B7E RID: 15230
		private static readonly IntPtr NativeFieldInfoPtr_IzakayaMusicProfile;

		// Token: 0x04003B7F RID: 15231
		private static readonly IntPtr NativeFieldInfoPtr_MusicMappingProfile;

		// Token: 0x04003B80 RID: 15232
		private static readonly IntPtr NativeFieldInfoPtr_MusicChapterProfile;

		// Token: 0x04003B81 RID: 15233
		private static readonly IntPtr NativeFieldInfoPtr_MainItemSpriteAtlas;

		// Token: 0x04003B82 RID: 15234
		private static readonly IntPtr NativeFieldInfoPtr_BuffSpriteAtlas;

		// Token: 0x04003B83 RID: 15235
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSprite;

		// Token: 0x04003B84 RID: 15236
		private static readonly IntPtr NativeFieldInfoPtr_ItemSprite;

		// Token: 0x04003B85 RID: 15237
		private static readonly IntPtr NativeFieldInfoPtr_BadgeSprite;

		// Token: 0x04003B86 RID: 15238
		private static readonly IntPtr NativeFieldInfoPtr_BeverageSprite;

		// Token: 0x04003B87 RID: 15239
		private static readonly IntPtr NativeFieldInfoPtr_FoodSprite;

		// Token: 0x04003B88 RID: 15240
		private static readonly IntPtr NativeFieldInfoPtr_CookerSprite;

		// Token: 0x04003B89 RID: 15241
		private static readonly IntPtr NativeFieldInfoPtr_IzakayaSprite;

		// Token: 0x04003B8A RID: 15242
		private static readonly IntPtr NativeFieldInfoPtr_BuffSprite;

		// Token: 0x04003B8B RID: 15243
		private static readonly IntPtr NativeFieldInfoPtr_IngredientItemBadgeBeverageFoodCookerIzakayaSpriteAtlas;

		// Token: 0x04003B8C RID: 15244
		private static readonly IntPtr NativeFieldInfoPtr_CommonPhraseLang;

		// Token: 0x04003B8D RID: 15245
		private static readonly IntPtr NativeFieldInfoPtr_BeverageTagProfile;

		// Token: 0x04003B8E RID: 15246
		private static readonly IntPtr NativeFieldInfoPtr_BeverageTagsLang;

		// Token: 0x04003B8F RID: 15247
		private static readonly IntPtr NativeFieldInfoPtr_FoodTagProfile;

		// Token: 0x04003B90 RID: 15248
		private static readonly IntPtr NativeFieldInfoPtr_FoodTagsLang;

		// Token: 0x04003B91 RID: 15249
		private static readonly IntPtr NativeFieldInfoPtr_FoodPrefixLang;

		// Token: 0x04003B92 RID: 15250
		private static readonly IntPtr NativeFieldInfoPtr_IngredientsLang;

		// Token: 0x04003B93 RID: 15251
		private static readonly IntPtr NativeFieldInfoPtr_ItemsLang;

		// Token: 0x04003B94 RID: 15252
		private static readonly IntPtr NativeFieldInfoPtr_BadgeLang;

		// Token: 0x04003B95 RID: 15253
		private static readonly IntPtr NativeFieldInfoPtr_BeveragesLang;

		// Token: 0x04003B96 RID: 15254
		private static readonly IntPtr NativeFieldInfoPtr_FoodsLang;

		// Token: 0x04003B97 RID: 15255
		private static readonly IntPtr NativeFieldInfoPtr_MissionsLang;

		// Token: 0x04003B98 RID: 15256
		private static readonly IntPtr NativeFieldInfoPtr_NewsLang;

		// Token: 0x04003B99 RID: 15257
		private static readonly IntPtr NativeFieldInfoPtr_CookersLang;

		// Token: 0x04003B9A RID: 15258
		private static readonly IntPtr NativeFieldInfoPtr_IzakayasLang;

		// Token: 0x04003B9B RID: 15259
		private static readonly IntPtr NativeFieldInfoPtr_NormalGuestLang;

		// Token: 0x04003B9C RID: 15260
		private static readonly IntPtr NativeFieldInfoPtr_SpecialGuestLang;

		// Token: 0x04003B9D RID: 15261
		private static readonly IntPtr NativeFieldInfoPtr_SpecialGuestFoodRequestLang;

		// Token: 0x04003B9E RID: 15262
		private static readonly IntPtr NativeFieldInfoPtr_SpecialGuestBevRequestLang;

		// Token: 0x04003B9F RID: 15263
		private static readonly IntPtr NativeFieldInfoPtr_BuffDescriptionLang;

		// Token: 0x04003BA0 RID: 15264
		private static readonly IntPtr NativeFieldInfoPtr_MissionFinishConditionLang;

		// Token: 0x04003BA1 RID: 15265
		private static readonly IntPtr NativeFieldInfoPtr_RewardConditionLang;

		// Token: 0x04003BA2 RID: 15266
		private static readonly IntPtr NativeFieldInfoPtr_PartnerJobLang;

		// Token: 0x04003BA3 RID: 15267
		private static readonly IntPtr NativeFieldInfoPtr_CGDataLang;

		// Token: 0x04003BA4 RID: 15268
		private static readonly IntPtr NativeFieldInfoPtr_MusicNameDataLang;

		// Token: 0x04003BA5 RID: 15269
		private static readonly IntPtr NativeFieldInfoPtr_SpellLang;

		// Token: 0x04003BA6 RID: 15270
		private static readonly IntPtr NativeFieldInfoPtr_SpecialEvalLang;

		// Token: 0x04003BA7 RID: 15271
		private static readonly IntPtr NativeFieldInfoPtr_NormalEvalIndex;

		// Token: 0x04003BA8 RID: 15272
		private static readonly IntPtr NativeFieldInfoPtr_NormalEvalLang;

		// Token: 0x04003BA9 RID: 15273
		private static readonly IntPtr NativeFieldInfoPtr_SpecialConvLang;

		// Token: 0x04003BAA RID: 15274
		private static readonly IntPtr NativeFieldInfoPtr_NormalConvProfile;

		// Token: 0x04003BAB RID: 15275
		private static readonly IntPtr NativeFieldInfoPtr_SpecialConvProfile;

		// Token: 0x04003BAC RID: 15276
		private static readonly IntPtr NativeFieldInfoPtr_NormalConvLang;

		// Token: 0x04003BAD RID: 15277
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneNPCNameLang;

		// Token: 0x04003BAE RID: 15278
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneInteractableEntitiesNameLang;

		// Token: 0x04003BAF RID: 15279
		private static readonly IntPtr NativeFieldInfoPtr_MapLang;

		// Token: 0x04003BB0 RID: 15280
		private static readonly IntPtr NativeFieldInfoPtr_AchievementProfile;

		// Token: 0x04003BB1 RID: 15281
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalStaffPages;

		// Token: 0x04003BB2 RID: 15282
		private static readonly IntPtr NativeFieldInfoPtr_ConcertProfile;

		// Token: 0x04003BB3 RID: 15283
		private static readonly IntPtr NativeFieldInfoPtr_ConcertProfileAlt;

		// Token: 0x04003BB4 RID: 15284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C96 RID: 3222
		[Serializable]
		public enum MapAddtiveType
		{
			// Token: 0x040093A2 RID: 37794
			Target,
			// Token: 0x040093A3 RID: 37795
			All
		}

		// Token: 0x02000C97 RID: 3223
		[Serializable]
		public sealed class IzakayaAdditiveData : ValueType
		{
			// Token: 0x0600E745 RID: 59205 RVA: 0x00377048 File Offset: 0x00375248
			// Note: this type is marked as 'beforefieldinit'.
			static IzakayaAdditiveData()
			{
				Il2CppClassPointerStore<ExpandableGameDataPack.IzakayaAdditiveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "IzakayaAdditiveData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandableGameDataPack.IzakayaAdditiveData>.NativeClassPtr);
				ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_izakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.IzakayaAdditiveData>.NativeClassPtr, "izakayaId");
				ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_additiveNormalGuestPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.IzakayaAdditiveData>.NativeClassPtr, "additiveNormalGuestPool");
				ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_additiveSpecialGuestPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.IzakayaAdditiveData>.NativeClassPtr, "additiveSpecialGuestPool");
				ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_additiveIzakayaSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.IzakayaAdditiveData>.NativeClassPtr, "additiveIzakayaSkin");
			}

			// Token: 0x0600E746 RID: 59206 RVA: 0x0007B7BC File Offset: 0x000799BC
			public IzakayaAdditiveData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E747 RID: 59207 RVA: 0x0007B7C5 File Offset: 0x000799C5
			public IzakayaAdditiveData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandableGameDataPack.IzakayaAdditiveData>.NativeClassPtr))
			{
			}

			// Token: 0x17004AFF RID: 19199
			// (get) Token: 0x0600E748 RID: 59208 RVA: 0x003770C4 File Offset: 0x003752C4
			// (set) Token: 0x0600E749 RID: 59209 RVA: 0x0007B7D7 File Offset: 0x000799D7
			public unsafe int izakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_izakayaId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_izakayaId)) = value;
				}
			}

			// Token: 0x17004B00 RID: 19200
			// (get) Token: 0x0600E74A RID: 59210 RVA: 0x003770EC File Offset: 0x003752EC
			// (set) Token: 0x0600E74B RID: 59211 RVA: 0x0007B7F2 File Offset: 0x000799F2
			public unsafe Il2CppReferenceArray<Izakaya.NormalGuestGroup> additiveNormalGuestPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_additiveNormalGuestPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya.NormalGuestGroup>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_additiveNormalGuestPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B01 RID: 19201
			// (get) Token: 0x0600E74C RID: 59212 RVA: 0x0037711C File Offset: 0x0037531C
			// (set) Token: 0x0600E74D RID: 59213 RVA: 0x0007B811 File Offset: 0x00079A11
			public unsafe Il2CppReferenceArray<Izakaya.SpecialGuestGroup> additiveSpecialGuestPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_additiveSpecialGuestPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya.SpecialGuestGroup>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_additiveSpecialGuestPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B02 RID: 19202
			// (get) Token: 0x0600E74E RID: 59214 RVA: 0x0037714C File Offset: 0x0037534C
			// (set) Token: 0x0600E74F RID: 59215 RVA: 0x0007B830 File Offset: 0x00079A30
			public unsafe Il2CppReferenceArray<ExpandableGameDataPack.AssetReferenceIdPair> additiveIzakayaSkin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_additiveIzakayaSkin);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpandableGameDataPack.AssetReferenceIdPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.IzakayaAdditiveData.NativeFieldInfoPtr_additiveIzakayaSkin), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093A4 RID: 37796
			private static readonly IntPtr NativeFieldInfoPtr_izakayaId;

			// Token: 0x040093A5 RID: 37797
			private static readonly IntPtr NativeFieldInfoPtr_additiveNormalGuestPool;

			// Token: 0x040093A6 RID: 37798
			private static readonly IntPtr NativeFieldInfoPtr_additiveSpecialGuestPool;

			// Token: 0x040093A7 RID: 37799
			private static readonly IntPtr NativeFieldInfoPtr_additiveIzakayaSkin;
		}

		// Token: 0x02000C98 RID: 3224
		[Serializable]
		public sealed class MapAdditiveData : ValueType
		{
			// Token: 0x0600E750 RID: 59216 RVA: 0x0037717C File Offset: 0x0037537C
			// Note: this type is marked as 'beforefieldinit'.
			static MapAdditiveData()
			{
				Il2CppClassPointerStore<ExpandableGameDataPack.MapAdditiveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "MapAdditiveData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandableGameDataPack.MapAdditiveData>.NativeClassPtr);
				ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.MapAdditiveData>.NativeClassPtr, "type");
				ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_mapKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.MapAdditiveData>.NativeClassPtr, "mapKey");
				ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_additionalObjectReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.MapAdditiveData>.NativeClassPtr, "additionalObjectReference");
				ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_enableCustomPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.MapAdditiveData>.NativeClassPtr, "enableCustomPosition");
				ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.MapAdditiveData>.NativeClassPtr, "worldPosition");
			}

			// Token: 0x0600E751 RID: 59217 RVA: 0x0007B84F File Offset: 0x00079A4F
			public MapAdditiveData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E752 RID: 59218 RVA: 0x0007B858 File Offset: 0x00079A58
			public MapAdditiveData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandableGameDataPack.MapAdditiveData>.NativeClassPtr))
			{
			}

			// Token: 0x17004B03 RID: 19203
			// (get) Token: 0x0600E753 RID: 59219 RVA: 0x0037720C File Offset: 0x0037540C
			// (set) Token: 0x0600E754 RID: 59220 RVA: 0x0007B86A File Offset: 0x00079A6A
			public unsafe ExpandableGameDataPack.MapAddtiveType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x17004B04 RID: 19204
			// (get) Token: 0x0600E755 RID: 59221 RVA: 0x00377234 File Offset: 0x00375434
			// (set) Token: 0x0600E756 RID: 59222 RVA: 0x0007B885 File Offset: 0x00079A85
			public unsafe string mapKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_mapKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_mapKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B05 RID: 19205
			// (get) Token: 0x0600E757 RID: 59223 RVA: 0x0037725C File Offset: 0x0037545C
			// (set) Token: 0x0600E758 RID: 59224 RVA: 0x0007B8A4 File Offset: 0x00079AA4
			public unsafe AssetReference additionalObjectReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_additionalObjectReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_additionalObjectReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B06 RID: 19206
			// (get) Token: 0x0600E759 RID: 59225 RVA: 0x0037728C File Offset: 0x0037548C
			// (set) Token: 0x0600E75A RID: 59226 RVA: 0x0007B8C3 File Offset: 0x00079AC3
			public unsafe bool enableCustomPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_enableCustomPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_enableCustomPosition)) = value;
				}
			}

			// Token: 0x17004B07 RID: 19207
			// (get) Token: 0x0600E75B RID: 59227 RVA: 0x003772B4 File Offset: 0x003754B4
			// (set) Token: 0x0600E75C RID: 59228 RVA: 0x0007B8DE File Offset: 0x00079ADE
			public unsafe Vector2 worldPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_worldPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.MapAdditiveData.NativeFieldInfoPtr_worldPosition)) = value;
				}
			}

			// Token: 0x040093A8 RID: 37800
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040093A9 RID: 37801
			private static readonly IntPtr NativeFieldInfoPtr_mapKey;

			// Token: 0x040093AA RID: 37802
			private static readonly IntPtr NativeFieldInfoPtr_additionalObjectReference;

			// Token: 0x040093AB RID: 37803
			private static readonly IntPtr NativeFieldInfoPtr_enableCustomPosition;

			// Token: 0x040093AC RID: 37804
			private static readonly IntPtr NativeFieldInfoPtr_worldPosition;
		}

		// Token: 0x02000C99 RID: 3225
		[Serializable]
		public sealed class SchedulerConnectionData : ValueType
		{
			// Token: 0x0600E75D RID: 59229 RVA: 0x003772DC File Offset: 0x003754DC
			// Note: this type is marked as 'beforefieldinit'.
			static SchedulerConnectionData()
			{
				Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerConnectionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SchedulerConnectionData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerConnectionData>.NativeClassPtr);
				ExpandableGameDataPack.SchedulerConnectionData.NativeFieldInfoPtr_sourceNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerConnectionData>.NativeClassPtr, "sourceNode");
				ExpandableGameDataPack.SchedulerConnectionData.NativeFieldInfoPtr_targetNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerConnectionData>.NativeClassPtr, "targetNode");
				ExpandableGameDataPack.SchedulerConnectionData.NativeFieldInfoPtr_finishAfterPerformance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerConnectionData>.NativeClassPtr, "finishAfterPerformance");
			}

			// Token: 0x0600E75E RID: 59230 RVA: 0x0007B8F9 File Offset: 0x00079AF9
			public SchedulerConnectionData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E75F RID: 59231 RVA: 0x0007B902 File Offset: 0x00079B02
			public SchedulerConnectionData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerConnectionData>.NativeClassPtr))
			{
			}

			// Token: 0x17004B08 RID: 19208
			// (get) Token: 0x0600E760 RID: 59232 RVA: 0x00377344 File Offset: 0x00375544
			// (set) Token: 0x0600E761 RID: 59233 RVA: 0x0007B914 File Offset: 0x00079B14
			public unsafe string sourceNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerConnectionData.NativeFieldInfoPtr_sourceNode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerConnectionData.NativeFieldInfoPtr_sourceNode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B09 RID: 19209
			// (get) Token: 0x0600E762 RID: 59234 RVA: 0x0037736C File Offset: 0x0037556C
			// (set) Token: 0x0600E763 RID: 59235 RVA: 0x0007B933 File Offset: 0x00079B33
			public unsafe string targetNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerConnectionData.NativeFieldInfoPtr_targetNode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerConnectionData.NativeFieldInfoPtr_targetNode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B0A RID: 19210
			// (get) Token: 0x0600E764 RID: 59236 RVA: 0x00377394 File Offset: 0x00375594
			// (set) Token: 0x0600E765 RID: 59237 RVA: 0x0007B952 File Offset: 0x00079B52
			public unsafe bool finishAfterPerformance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerConnectionData.NativeFieldInfoPtr_finishAfterPerformance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerConnectionData.NativeFieldInfoPtr_finishAfterPerformance)) = value;
				}
			}

			// Token: 0x040093AD RID: 37805
			private static readonly IntPtr NativeFieldInfoPtr_sourceNode;

			// Token: 0x040093AE RID: 37806
			private static readonly IntPtr NativeFieldInfoPtr_targetNode;

			// Token: 0x040093AF RID: 37807
			private static readonly IntPtr NativeFieldInfoPtr_finishAfterPerformance;
		}

		// Token: 0x02000C9A RID: 3226
		[Serializable]
		public sealed class SchedulerNewsData : ValueType
		{
			// Token: 0x0600E766 RID: 59238 RVA: 0x003773BC File Offset: 0x003755BC
			// Note: this type is marked as 'beforefieldinit'.
			static SchedulerNewsData()
			{
				Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerNewsData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SchedulerNewsData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerNewsData>.NativeClassPtr);
				ExpandableGameDataPack.SchedulerNewsData.NativeFieldInfoPtr_sourceNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerNewsData>.NativeClassPtr, "sourceNode");
				ExpandableGameDataPack.SchedulerNewsData.NativeFieldInfoPtr_targetNews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerNewsData>.NativeClassPtr, "targetNews");
				ExpandableGameDataPack.SchedulerNewsData.NativeFieldInfoPtr_triggerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerNewsData>.NativeClassPtr, "triggerDay");
			}

			// Token: 0x0600E767 RID: 59239 RVA: 0x0007B96D File Offset: 0x00079B6D
			public SchedulerNewsData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E768 RID: 59240 RVA: 0x0007B976 File Offset: 0x00079B76
			public SchedulerNewsData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandableGameDataPack.SchedulerNewsData>.NativeClassPtr))
			{
			}

			// Token: 0x17004B0B RID: 19211
			// (get) Token: 0x0600E769 RID: 59241 RVA: 0x00377424 File Offset: 0x00375624
			// (set) Token: 0x0600E76A RID: 59242 RVA: 0x0007B988 File Offset: 0x00079B88
			public unsafe string sourceNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerNewsData.NativeFieldInfoPtr_sourceNode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerNewsData.NativeFieldInfoPtr_sourceNode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B0C RID: 19212
			// (get) Token: 0x0600E76B RID: 59243 RVA: 0x0037744C File Offset: 0x0037564C
			// (set) Token: 0x0600E76C RID: 59244 RVA: 0x0007B9A7 File Offset: 0x00079BA7
			public unsafe string targetNews
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerNewsData.NativeFieldInfoPtr_targetNews);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerNewsData.NativeFieldInfoPtr_targetNews), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B0D RID: 19213
			// (get) Token: 0x0600E76D RID: 59245 RVA: 0x00377474 File Offset: 0x00375674
			// (set) Token: 0x0600E76E RID: 59246 RVA: 0x0007B9C6 File Offset: 0x00079BC6
			public unsafe SchedulerNode.Day triggerDay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerNewsData.NativeFieldInfoPtr_triggerDay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SchedulerNewsData.NativeFieldInfoPtr_triggerDay)) = value;
				}
			}

			// Token: 0x040093B0 RID: 37808
			private static readonly IntPtr NativeFieldInfoPtr_sourceNode;

			// Token: 0x040093B1 RID: 37809
			private static readonly IntPtr NativeFieldInfoPtr_targetNews;

			// Token: 0x040093B2 RID: 37810
			private static readonly IntPtr NativeFieldInfoPtr_triggerDay;
		}

		// Token: 0x02000C9B RID: 3227
		[Serializable]
		public sealed class AssetReferenceIdPair : ValueType
		{
			// Token: 0x0600E76F RID: 59247 RVA: 0x0037749C File Offset: 0x0037569C
			// Note: this type is marked as 'beforefieldinit'.
			static AssetReferenceIdPair()
			{
				Il2CppClassPointerStore<ExpandableGameDataPack.AssetReferenceIdPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "AssetReferenceIdPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandableGameDataPack.AssetReferenceIdPair>.NativeClassPtr);
				ExpandableGameDataPack.AssetReferenceIdPair.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.AssetReferenceIdPair>.NativeClassPtr, "id");
				ExpandableGameDataPack.AssetReferenceIdPair.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.AssetReferenceIdPair>.NativeClassPtr, "data");
			}

			// Token: 0x0600E770 RID: 59248 RVA: 0x0007B9E1 File Offset: 0x00079BE1
			public AssetReferenceIdPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E771 RID: 59249 RVA: 0x0007B9EA File Offset: 0x00079BEA
			public AssetReferenceIdPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandableGameDataPack.AssetReferenceIdPair>.NativeClassPtr))
			{
			}

			// Token: 0x17004B0E RID: 19214
			// (get) Token: 0x0600E772 RID: 59250 RVA: 0x003774F0 File Offset: 0x003756F0
			// (set) Token: 0x0600E773 RID: 59251 RVA: 0x0007B9FC File Offset: 0x00079BFC
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.AssetReferenceIdPair.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.AssetReferenceIdPair.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17004B0F RID: 19215
			// (get) Token: 0x0600E774 RID: 59252 RVA: 0x00377518 File Offset: 0x00375718
			// (set) Token: 0x0600E775 RID: 59253 RVA: 0x0007BA17 File Offset: 0x00079C17
			public unsafe AssetReference data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.AssetReferenceIdPair.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.AssetReferenceIdPair.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093B3 RID: 37811
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040093B4 RID: 37812
			private static readonly IntPtr NativeFieldInfoPtr_data;
		}

		// Token: 0x02000C9C RID: 3228
		[Serializable]
		public sealed class SpecialGuestAdditiveData : ValueType
		{
			// Token: 0x0600E776 RID: 59254 RVA: 0x00377548 File Offset: 0x00375748
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialGuestAdditiveData()
			{
				Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandableGameDataPack>.NativeClassPtr, "SpecialGuestAdditiveData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "id");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel1ChatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel1ChatData");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel1Welcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel1Welcome");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2ChatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel2ChatData");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2InviteFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel2InviteFailed");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2InviteSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel2InviteSucceed");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2Welcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel2Welcome");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3ChatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel3ChatData");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3InviteFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel3InviteFailed");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3InviteSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel3InviteSucceed");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3RequestIngerdient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel3RequestIngerdient");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3Welcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel3Welcome");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4ChatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel4ChatData");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4InviteFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel4InviteFailed");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4InviteSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel4InviteSucceed");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4RequestBeverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel4RequestBeverage");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4RequestIngerdient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel4RequestIngerdient");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4Welcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel4Welcome");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5ChatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel5ChatData");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5Commision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel5Commision");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5CommisionFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel5CommisionFinish");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5InviteSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel5InviteSucceed");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5RequestBeverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel5RequestBeverage");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5RequestIngerdient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel5RequestIngerdient");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5Welcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveCharacterKizunaLevel5Welcome");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveHateFoodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveHateFoodTag");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveLikeBevTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveLikeBevTag");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveLikeFoodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveLikeFoodTag");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveUnifiedSpawnExclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, "additiveUnifiedSpawnExclusion");
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveHateFoodTag_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681274);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveLikeFoodTag_Public_get_Il2CppReferenceArray_1_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681275);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveLikeBevTag_Public_get_Il2CppReferenceArray_1_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681276);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveUnifiedSpawnExclusion_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681277);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel1Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681278);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681279);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681280);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681281);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681282);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel1ChatData_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681283);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2ChatData_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681284);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3ChatData_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681285);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4ChatData_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681286);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5ChatData_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681287);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681288);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2InviteFailed_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681289);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681290);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3InviteFailed_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681291);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681292);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4InviteFailed_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681293);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681294);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3RequestIngerdient_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681295);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4RequestIngerdient_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681296);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5RequestIngerdient_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681297);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4RequestBeverage_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681298);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5RequestBeverage_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681299);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5Commision_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681300);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5CommisionFinish_Public_get_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681301);
				ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_op_Addition_Public_Static_SpecialGuestAdditiveData_SpecialGuestAdditiveData_SpecialGuestAdditiveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr, 100681302);
			}

			// Token: 0x17004B2D RID: 19245
			// (get) Token: 0x0600E777 RID: 59255 RVA: 0x003779FC File Offset: 0x00375BFC
			public unsafe Il2CppStructArray<int> AdditiveHateFoodTag
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 218742, RefRangeEnd = 218745, XrefRangeStart = 218737, XrefRangeEnd = 218742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveHateFoodTag_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B2E RID: 19246
			// (get) Token: 0x0600E778 RID: 59256 RVA: 0x00377A40 File Offset: 0x00375C40
			public unsafe Il2CppReferenceArray<SpecialGuest.WeightedTag> AdditiveLikeFoodTag
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218748, RefRangeEnd = 218749, XrefRangeStart = 218745, XrefRangeEnd = 218748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveLikeFoodTag_Public_get_Il2CppReferenceArray_1_WeightedTag_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest.WeightedTag>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B2F RID: 19247
			// (get) Token: 0x0600E779 RID: 59257 RVA: 0x00377A84 File Offset: 0x00375C84
			public unsafe Il2CppReferenceArray<SpecialGuest.WeightedTag> AdditiveLikeBevTag
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218752, RefRangeEnd = 218753, XrefRangeStart = 218749, XrefRangeEnd = 218752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveLikeBevTag_Public_get_Il2CppReferenceArray_1_WeightedTag_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest.WeightedTag>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B30 RID: 19248
			// (get) Token: 0x0600E77A RID: 59258 RVA: 0x00377AC8 File Offset: 0x00375CC8
			public unsafe Il2CppStringArray AdditiveUnifiedSpawnExclusion
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218756, RefRangeEnd = 218757, XrefRangeStart = 218753, XrefRangeEnd = 218756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveUnifiedSpawnExclusion_Public_get_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x17004B31 RID: 19249
			// (get) Token: 0x0600E77B RID: 59259 RVA: 0x00377B0C File Offset: 0x00375D0C
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel1Welcome
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218760, RefRangeEnd = 218761, XrefRangeStart = 218757, XrefRangeEnd = 218760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel1Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B32 RID: 19250
			// (get) Token: 0x0600E77C RID: 59260 RVA: 0x00377B50 File Offset: 0x00375D50
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel2Welcome
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218764, RefRangeEnd = 218765, XrefRangeStart = 218761, XrefRangeEnd = 218764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B33 RID: 19251
			// (get) Token: 0x0600E77D RID: 59261 RVA: 0x00377B94 File Offset: 0x00375D94
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel3Welcome
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218768, RefRangeEnd = 218769, XrefRangeStart = 218765, XrefRangeEnd = 218768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B34 RID: 19252
			// (get) Token: 0x0600E77E RID: 59262 RVA: 0x00377BD8 File Offset: 0x00375DD8
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel4Welcome
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218772, RefRangeEnd = 218773, XrefRangeStart = 218769, XrefRangeEnd = 218772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B35 RID: 19253
			// (get) Token: 0x0600E77F RID: 59263 RVA: 0x00377C1C File Offset: 0x00375E1C
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel5Welcome
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218776, RefRangeEnd = 218777, XrefRangeStart = 218773, XrefRangeEnd = 218776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B36 RID: 19254
			// (get) Token: 0x0600E780 RID: 59264 RVA: 0x00377C60 File Offset: 0x00375E60
			public unsafe Il2CppStringArray AdditiveCharacterKizunaLevel1ChatData
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218780, RefRangeEnd = 218781, XrefRangeStart = 218777, XrefRangeEnd = 218780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel1ChatData_Public_get_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x17004B37 RID: 19255
			// (get) Token: 0x0600E781 RID: 59265 RVA: 0x00377CA4 File Offset: 0x00375EA4
			public unsafe Il2CppStringArray AdditiveCharacterKizunaLevel2ChatData
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218784, RefRangeEnd = 218785, XrefRangeStart = 218781, XrefRangeEnd = 218784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2ChatData_Public_get_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x17004B38 RID: 19256
			// (get) Token: 0x0600E782 RID: 59266 RVA: 0x00377CE8 File Offset: 0x00375EE8
			public unsafe Il2CppStringArray AdditiveCharacterKizunaLevel3ChatData
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218788, RefRangeEnd = 218789, XrefRangeStart = 218785, XrefRangeEnd = 218788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3ChatData_Public_get_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x17004B39 RID: 19257
			// (get) Token: 0x0600E783 RID: 59267 RVA: 0x00377D2C File Offset: 0x00375F2C
			public unsafe Il2CppStringArray AdditiveCharacterKizunaLevel4ChatData
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218792, RefRangeEnd = 218793, XrefRangeStart = 218789, XrefRangeEnd = 218792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4ChatData_Public_get_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x17004B3A RID: 19258
			// (get) Token: 0x0600E784 RID: 59268 RVA: 0x00377D70 File Offset: 0x00375F70
			public unsafe Il2CppStringArray AdditiveCharacterKizunaLevel5ChatData
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218796, RefRangeEnd = 218797, XrefRangeStart = 218793, XrefRangeEnd = 218796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5ChatData_Public_get_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x17004B3B RID: 19259
			// (get) Token: 0x0600E785 RID: 59269 RVA: 0x00377DB4 File Offset: 0x00375FB4
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel2InviteSucceed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218800, RefRangeEnd = 218801, XrefRangeStart = 218797, XrefRangeEnd = 218800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B3C RID: 19260
			// (get) Token: 0x0600E786 RID: 59270 RVA: 0x00377DF8 File Offset: 0x00375FF8
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel2InviteFailed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218804, RefRangeEnd = 218805, XrefRangeStart = 218801, XrefRangeEnd = 218804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2InviteFailed_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B3D RID: 19261
			// (get) Token: 0x0600E787 RID: 59271 RVA: 0x00377E3C File Offset: 0x0037603C
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel3InviteSucceed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218808, RefRangeEnd = 218809, XrefRangeStart = 218805, XrefRangeEnd = 218808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B3E RID: 19262
			// (get) Token: 0x0600E788 RID: 59272 RVA: 0x00377E80 File Offset: 0x00376080
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel3InviteFailed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218812, RefRangeEnd = 218813, XrefRangeStart = 218809, XrefRangeEnd = 218812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3InviteFailed_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B3F RID: 19263
			// (get) Token: 0x0600E789 RID: 59273 RVA: 0x00377EC4 File Offset: 0x003760C4
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel4InviteSucceed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218816, RefRangeEnd = 218817, XrefRangeStart = 218813, XrefRangeEnd = 218816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B40 RID: 19264
			// (get) Token: 0x0600E78A RID: 59274 RVA: 0x00377F08 File Offset: 0x00376108
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel4InviteFailed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218820, RefRangeEnd = 218821, XrefRangeStart = 218817, XrefRangeEnd = 218820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4InviteFailed_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B41 RID: 19265
			// (get) Token: 0x0600E78B RID: 59275 RVA: 0x00377F4C File Offset: 0x0037614C
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel5InviteSucceed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218824, RefRangeEnd = 218825, XrefRangeStart = 218821, XrefRangeEnd = 218824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B42 RID: 19266
			// (get) Token: 0x0600E78C RID: 59276 RVA: 0x00377F90 File Offset: 0x00376190
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel3RequestIngerdient
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218828, RefRangeEnd = 218829, XrefRangeStart = 218825, XrefRangeEnd = 218828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3RequestIngerdient_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B43 RID: 19267
			// (get) Token: 0x0600E78D RID: 59277 RVA: 0x00377FD4 File Offset: 0x003761D4
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel4RequestIngerdient
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218832, RefRangeEnd = 218833, XrefRangeStart = 218829, XrefRangeEnd = 218832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4RequestIngerdient_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B44 RID: 19268
			// (get) Token: 0x0600E78E RID: 59278 RVA: 0x00378018 File Offset: 0x00376218
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel5RequestIngerdient
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218836, RefRangeEnd = 218837, XrefRangeStart = 218833, XrefRangeEnd = 218836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5RequestIngerdient_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B45 RID: 19269
			// (get) Token: 0x0600E78F RID: 59279 RVA: 0x0037805C File Offset: 0x0037625C
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel4RequestBeverage
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218840, RefRangeEnd = 218841, XrefRangeStart = 218837, XrefRangeEnd = 218840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4RequestBeverage_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B46 RID: 19270
			// (get) Token: 0x0600E790 RID: 59280 RVA: 0x003780A0 File Offset: 0x003762A0
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel5RequestBeverage
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218844, RefRangeEnd = 218845, XrefRangeStart = 218841, XrefRangeEnd = 218844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5RequestBeverage_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B47 RID: 19271
			// (get) Token: 0x0600E791 RID: 59281 RVA: 0x003780E4 File Offset: 0x003762E4
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel5Commision
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218848, RefRangeEnd = 218849, XrefRangeStart = 218845, XrefRangeEnd = 218848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5Commision_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x17004B48 RID: 19272
			// (get) Token: 0x0600E792 RID: 59282 RVA: 0x00378128 File Offset: 0x00376328
			public unsafe Il2CppReferenceArray<DialogPackage> AdditiveCharacterKizunaLevel5CommisionFinish
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 218852, RefRangeEnd = 218853, XrefRangeStart = 218849, XrefRangeEnd = 218852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5CommisionFinish_Public_get_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
				}
			}

			// Token: 0x0600E793 RID: 59283 RVA: 0x0037816C File Offset: 0x0037636C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 219166, RefRangeEnd = 219167, XrefRangeStart = 218853, XrefRangeEnd = 219166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ExpandableGameDataPack.SpecialGuestAdditiveData operator +(ExpandableGameDataPack.SpecialGuestAdditiveData current, ExpandableGameDataPack.SpecialGuestAdditiveData next)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(current));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(next));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeMethodInfoPtr_op_Addition_Public_Static_SpecialGuestAdditiveData_SpecialGuestAdditiveData_SpecialGuestAdditiveData_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ExpandableGameDataPack.SpecialGuestAdditiveData(pointer);
			}

			// Token: 0x0600E794 RID: 59284 RVA: 0x0007BA36 File Offset: 0x00079C36
			public SpecialGuestAdditiveData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E795 RID: 59285 RVA: 0x0007BA3F File Offset: 0x00079C3F
			public SpecialGuestAdditiveData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandableGameDataPack.SpecialGuestAdditiveData>.NativeClassPtr))
			{
			}

			// Token: 0x17004B10 RID: 19216
			// (get) Token: 0x0600E796 RID: 59286 RVA: 0x003781C4 File Offset: 0x003763C4
			// (set) Token: 0x0600E797 RID: 59287 RVA: 0x0007BA51 File Offset: 0x00079C51
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17004B11 RID: 19217
			// (get) Token: 0x0600E798 RID: 59288 RVA: 0x003781EC File Offset: 0x003763EC
			// (set) Token: 0x0600E799 RID: 59289 RVA: 0x0007BA6C File Offset: 0x00079C6C
			public unsafe Il2CppStringArray additiveCharacterKizunaLevel1ChatData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel1ChatData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel1ChatData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B12 RID: 19218
			// (get) Token: 0x0600E79A RID: 59290 RVA: 0x0037821C File Offset: 0x0037641C
			// (set) Token: 0x0600E79B RID: 59291 RVA: 0x0007BA8B File Offset: 0x00079C8B
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel1Welcome
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel1Welcome);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel1Welcome), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B13 RID: 19219
			// (get) Token: 0x0600E79C RID: 59292 RVA: 0x0037824C File Offset: 0x0037644C
			// (set) Token: 0x0600E79D RID: 59293 RVA: 0x0007BAAA File Offset: 0x00079CAA
			public unsafe Il2CppStringArray additiveCharacterKizunaLevel2ChatData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2ChatData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2ChatData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B14 RID: 19220
			// (get) Token: 0x0600E79E RID: 59294 RVA: 0x0037827C File Offset: 0x0037647C
			// (set) Token: 0x0600E79F RID: 59295 RVA: 0x0007BAC9 File Offset: 0x00079CC9
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel2InviteFailed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2InviteFailed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2InviteFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B15 RID: 19221
			// (get) Token: 0x0600E7A0 RID: 59296 RVA: 0x003782AC File Offset: 0x003764AC
			// (set) Token: 0x0600E7A1 RID: 59297 RVA: 0x0007BAE8 File Offset: 0x00079CE8
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel2InviteSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2InviteSucceed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2InviteSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B16 RID: 19222
			// (get) Token: 0x0600E7A2 RID: 59298 RVA: 0x003782DC File Offset: 0x003764DC
			// (set) Token: 0x0600E7A3 RID: 59299 RVA: 0x0007BB07 File Offset: 0x00079D07
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel2Welcome
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2Welcome);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel2Welcome), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B17 RID: 19223
			// (get) Token: 0x0600E7A4 RID: 59300 RVA: 0x0037830C File Offset: 0x0037650C
			// (set) Token: 0x0600E7A5 RID: 59301 RVA: 0x0007BB26 File Offset: 0x00079D26
			public unsafe Il2CppStringArray additiveCharacterKizunaLevel3ChatData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3ChatData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3ChatData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B18 RID: 19224
			// (get) Token: 0x0600E7A6 RID: 59302 RVA: 0x0037833C File Offset: 0x0037653C
			// (set) Token: 0x0600E7A7 RID: 59303 RVA: 0x0007BB45 File Offset: 0x00079D45
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel3InviteFailed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3InviteFailed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3InviteFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B19 RID: 19225
			// (get) Token: 0x0600E7A8 RID: 59304 RVA: 0x0037836C File Offset: 0x0037656C
			// (set) Token: 0x0600E7A9 RID: 59305 RVA: 0x0007BB64 File Offset: 0x00079D64
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel3InviteSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3InviteSucceed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3InviteSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B1A RID: 19226
			// (get) Token: 0x0600E7AA RID: 59306 RVA: 0x0037839C File Offset: 0x0037659C
			// (set) Token: 0x0600E7AB RID: 59307 RVA: 0x0007BB83 File Offset: 0x00079D83
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel3RequestIngerdient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3RequestIngerdient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3RequestIngerdient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B1B RID: 19227
			// (get) Token: 0x0600E7AC RID: 59308 RVA: 0x003783CC File Offset: 0x003765CC
			// (set) Token: 0x0600E7AD RID: 59309 RVA: 0x0007BBA2 File Offset: 0x00079DA2
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel3Welcome
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3Welcome);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel3Welcome), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B1C RID: 19228
			// (get) Token: 0x0600E7AE RID: 59310 RVA: 0x003783FC File Offset: 0x003765FC
			// (set) Token: 0x0600E7AF RID: 59311 RVA: 0x0007BBC1 File Offset: 0x00079DC1
			public unsafe Il2CppStringArray additiveCharacterKizunaLevel4ChatData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4ChatData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4ChatData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B1D RID: 19229
			// (get) Token: 0x0600E7B0 RID: 59312 RVA: 0x0037842C File Offset: 0x0037662C
			// (set) Token: 0x0600E7B1 RID: 59313 RVA: 0x0007BBE0 File Offset: 0x00079DE0
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel4InviteFailed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4InviteFailed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4InviteFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B1E RID: 19230
			// (get) Token: 0x0600E7B2 RID: 59314 RVA: 0x0037845C File Offset: 0x0037665C
			// (set) Token: 0x0600E7B3 RID: 59315 RVA: 0x0007BBFF File Offset: 0x00079DFF
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel4InviteSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4InviteSucceed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4InviteSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B1F RID: 19231
			// (get) Token: 0x0600E7B4 RID: 59316 RVA: 0x0037848C File Offset: 0x0037668C
			// (set) Token: 0x0600E7B5 RID: 59317 RVA: 0x0007BC1E File Offset: 0x00079E1E
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel4RequestBeverage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4RequestBeverage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4RequestBeverage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B20 RID: 19232
			// (get) Token: 0x0600E7B6 RID: 59318 RVA: 0x003784BC File Offset: 0x003766BC
			// (set) Token: 0x0600E7B7 RID: 59319 RVA: 0x0007BC3D File Offset: 0x00079E3D
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel4RequestIngerdient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4RequestIngerdient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4RequestIngerdient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B21 RID: 19233
			// (get) Token: 0x0600E7B8 RID: 59320 RVA: 0x003784EC File Offset: 0x003766EC
			// (set) Token: 0x0600E7B9 RID: 59321 RVA: 0x0007BC5C File Offset: 0x00079E5C
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel4Welcome
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4Welcome);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel4Welcome), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B22 RID: 19234
			// (get) Token: 0x0600E7BA RID: 59322 RVA: 0x0037851C File Offset: 0x0037671C
			// (set) Token: 0x0600E7BB RID: 59323 RVA: 0x0007BC7B File Offset: 0x00079E7B
			public unsafe Il2CppStringArray additiveCharacterKizunaLevel5ChatData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5ChatData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5ChatData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B23 RID: 19235
			// (get) Token: 0x0600E7BC RID: 59324 RVA: 0x0037854C File Offset: 0x0037674C
			// (set) Token: 0x0600E7BD RID: 59325 RVA: 0x0007BC9A File Offset: 0x00079E9A
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel5Commision
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5Commision);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5Commision), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B24 RID: 19236
			// (get) Token: 0x0600E7BE RID: 59326 RVA: 0x0037857C File Offset: 0x0037677C
			// (set) Token: 0x0600E7BF RID: 59327 RVA: 0x0007BCB9 File Offset: 0x00079EB9
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel5CommisionFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5CommisionFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5CommisionFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B25 RID: 19237
			// (get) Token: 0x0600E7C0 RID: 59328 RVA: 0x003785AC File Offset: 0x003767AC
			// (set) Token: 0x0600E7C1 RID: 59329 RVA: 0x0007BCD8 File Offset: 0x00079ED8
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel5InviteSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5InviteSucceed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5InviteSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B26 RID: 19238
			// (get) Token: 0x0600E7C2 RID: 59330 RVA: 0x003785DC File Offset: 0x003767DC
			// (set) Token: 0x0600E7C3 RID: 59331 RVA: 0x0007BCF7 File Offset: 0x00079EF7
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel5RequestBeverage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5RequestBeverage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5RequestBeverage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B27 RID: 19239
			// (get) Token: 0x0600E7C4 RID: 59332 RVA: 0x0037860C File Offset: 0x0037680C
			// (set) Token: 0x0600E7C5 RID: 59333 RVA: 0x0007BD16 File Offset: 0x00079F16
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel5RequestIngerdient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5RequestIngerdient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5RequestIngerdient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B28 RID: 19240
			// (get) Token: 0x0600E7C6 RID: 59334 RVA: 0x0037863C File Offset: 0x0037683C
			// (set) Token: 0x0600E7C7 RID: 59335 RVA: 0x0007BD35 File Offset: 0x00079F35
			public unsafe Il2CppReferenceArray<DialogPackage> additiveCharacterKizunaLevel5Welcome
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5Welcome);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveCharacterKizunaLevel5Welcome), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B29 RID: 19241
			// (get) Token: 0x0600E7C8 RID: 59336 RVA: 0x0037866C File Offset: 0x0037686C
			// (set) Token: 0x0600E7C9 RID: 59337 RVA: 0x0007BD54 File Offset: 0x00079F54
			public unsafe Il2CppStructArray<int> additiveHateFoodTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveHateFoodTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveHateFoodTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B2A RID: 19242
			// (get) Token: 0x0600E7CA RID: 59338 RVA: 0x0037869C File Offset: 0x0037689C
			// (set) Token: 0x0600E7CB RID: 59339 RVA: 0x0007BD73 File Offset: 0x00079F73
			public unsafe Il2CppReferenceArray<SpecialGuest.WeightedTag> additiveLikeBevTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveLikeBevTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest.WeightedTag>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveLikeBevTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B2B RID: 19243
			// (get) Token: 0x0600E7CC RID: 59340 RVA: 0x003786CC File Offset: 0x003768CC
			// (set) Token: 0x0600E7CD RID: 59341 RVA: 0x0007BD92 File Offset: 0x00079F92
			public unsafe Il2CppReferenceArray<SpecialGuest.WeightedTag> additiveLikeFoodTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveLikeFoodTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest.WeightedTag>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveLikeFoodTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B2C RID: 19244
			// (get) Token: 0x0600E7CE RID: 59342 RVA: 0x003786FC File Offset: 0x003768FC
			// (set) Token: 0x0600E7CF RID: 59343 RVA: 0x0007BDB1 File Offset: 0x00079FB1
			public unsafe Il2CppStringArray additiveUnifiedSpawnExclusion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveUnifiedSpawnExclusion);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableGameDataPack.SpecialGuestAdditiveData.NativeFieldInfoPtr_additiveUnifiedSpawnExclusion), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093B5 RID: 37813
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040093B6 RID: 37814
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel1ChatData;

			// Token: 0x040093B7 RID: 37815
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel1Welcome;

			// Token: 0x040093B8 RID: 37816
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel2ChatData;

			// Token: 0x040093B9 RID: 37817
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel2InviteFailed;

			// Token: 0x040093BA RID: 37818
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel2InviteSucceed;

			// Token: 0x040093BB RID: 37819
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel2Welcome;

			// Token: 0x040093BC RID: 37820
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel3ChatData;

			// Token: 0x040093BD RID: 37821
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel3InviteFailed;

			// Token: 0x040093BE RID: 37822
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel3InviteSucceed;

			// Token: 0x040093BF RID: 37823
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel3RequestIngerdient;

			// Token: 0x040093C0 RID: 37824
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel3Welcome;

			// Token: 0x040093C1 RID: 37825
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel4ChatData;

			// Token: 0x040093C2 RID: 37826
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel4InviteFailed;

			// Token: 0x040093C3 RID: 37827
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel4InviteSucceed;

			// Token: 0x040093C4 RID: 37828
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel4RequestBeverage;

			// Token: 0x040093C5 RID: 37829
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel4RequestIngerdient;

			// Token: 0x040093C6 RID: 37830
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel4Welcome;

			// Token: 0x040093C7 RID: 37831
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel5ChatData;

			// Token: 0x040093C8 RID: 37832
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel5Commision;

			// Token: 0x040093C9 RID: 37833
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel5CommisionFinish;

			// Token: 0x040093CA RID: 37834
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel5InviteSucceed;

			// Token: 0x040093CB RID: 37835
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel5RequestBeverage;

			// Token: 0x040093CC RID: 37836
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel5RequestIngerdient;

			// Token: 0x040093CD RID: 37837
			private static readonly IntPtr NativeFieldInfoPtr_additiveCharacterKizunaLevel5Welcome;

			// Token: 0x040093CE RID: 37838
			private static readonly IntPtr NativeFieldInfoPtr_additiveHateFoodTag;

			// Token: 0x040093CF RID: 37839
			private static readonly IntPtr NativeFieldInfoPtr_additiveLikeBevTag;

			// Token: 0x040093D0 RID: 37840
			private static readonly IntPtr NativeFieldInfoPtr_additiveLikeFoodTag;

			// Token: 0x040093D1 RID: 37841
			private static readonly IntPtr NativeFieldInfoPtr_additiveUnifiedSpawnExclusion;

			// Token: 0x040093D2 RID: 37842
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveHateFoodTag_Public_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x040093D3 RID: 37843
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveLikeFoodTag_Public_get_Il2CppReferenceArray_1_WeightedTag_0;

			// Token: 0x040093D4 RID: 37844
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveLikeBevTag_Public_get_Il2CppReferenceArray_1_WeightedTag_0;

			// Token: 0x040093D5 RID: 37845
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveUnifiedSpawnExclusion_Public_get_Il2CppStringArray_0;

			// Token: 0x040093D6 RID: 37846
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel1Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093D7 RID: 37847
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093D8 RID: 37848
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093D9 RID: 37849
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093DA RID: 37850
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5Welcome_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093DB RID: 37851
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel1ChatData_Public_get_Il2CppStringArray_0;

			// Token: 0x040093DC RID: 37852
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2ChatData_Public_get_Il2CppStringArray_0;

			// Token: 0x040093DD RID: 37853
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3ChatData_Public_get_Il2CppStringArray_0;

			// Token: 0x040093DE RID: 37854
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4ChatData_Public_get_Il2CppStringArray_0;

			// Token: 0x040093DF RID: 37855
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5ChatData_Public_get_Il2CppStringArray_0;

			// Token: 0x040093E0 RID: 37856
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093E1 RID: 37857
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel2InviteFailed_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093E2 RID: 37858
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093E3 RID: 37859
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3InviteFailed_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093E4 RID: 37860
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093E5 RID: 37861
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4InviteFailed_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093E6 RID: 37862
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5InviteSucceed_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093E7 RID: 37863
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel3RequestIngerdient_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093E8 RID: 37864
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4RequestIngerdient_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093E9 RID: 37865
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5RequestIngerdient_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093EA RID: 37866
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel4RequestBeverage_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093EB RID: 37867
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5RequestBeverage_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093EC RID: 37868
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5Commision_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093ED RID: 37869
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveCharacterKizunaLevel5CommisionFinish_Public_get_Il2CppReferenceArray_1_DialogPackage_0;

			// Token: 0x040093EE RID: 37870
			private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SpecialGuestAdditiveData_SpecialGuestAdditiveData_SpecialGuestAdditiveData_0;
		}
	}
}
