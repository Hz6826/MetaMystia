using System;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200010C RID: 268
	public class DLC5_RogueLikeDataProfileUnchangeable : ScriptableObject
	{
		// Token: 0x06001D38 RID: 7480 RVA: 0x001007A0 File Offset: 0x000FE9A0
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeDataProfileUnchangeable()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeDataProfileUnchangeable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr);
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RoguelikePoolEditMessagePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_RoguelikePoolEditMessagePanel");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RoguelikePoolViewerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_RoguelikePoolViewerPanel");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RogueLikeCardScorePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_RogueLikeCardScorePanel");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RoguelikeTutorialPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_RoguelikeTutorialPanel");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_CardSelectorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_CardSelectorPanel");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_Cards");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_CardsPersistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_CardsPersistent");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_CardDescriptionLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_CardDescriptionLang");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RecipeCollectRateWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_RecipeCollectRateWeight");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_ItemCollectRateWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_ItemCollectRateWeight");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_PartnerCollectRateWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_PartnerCollectRateWeight");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_IzakayaCollectRateWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_IzakayaCollectRateWeight");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_PartnerPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_PartnerPrice");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_FirstRefreshCardPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_FirstRefreshCardPrice");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RogueLikeAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_RogueLikeAchievements");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_EliteChallengeProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_EliteChallengeProfiles");
			DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_EliteRewardSelectionPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, "m_EliteRewardSelectionPanel");
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RoguelikePoolEditMessagePanel_Public_get_DLC5_RogueLikePoolResultPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668547);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RoguelikePoolViewerPanel_Public_get_DLC5_RogueLikePoolViewerPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668548);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RoguelikeTutorialPanel_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668549);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RogueLikeCardScorePanel_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668550);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_CardSelectorPanel_Public_get_DLC5_RogueLikeCardSelectorPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668551);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_Cards_Public_get_Il2CppReferenceArray_1_RogueLikeCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668552);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_CardDescriptionLang_Public_get_MultiLanguageTextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668553);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_CardsPersistent_Public_get_Il2CppReferenceArray_1_RogueLikeCardPersistent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668554);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RecipeCollectRateWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668555);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_ItemCollectRateWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668556);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_PartnerCollectRateWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668557);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_IzakayaCollectRateWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668558);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RogueLikeAchievements_Public_get_Il2CppReferenceArray_1_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668559);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_PartnerPrice_Public_get_Il2CppStructArray_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668560);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_FirstRefreshCardPrice_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668561);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_EliteChallengeProfiles_Public_get_Il2CppReferenceArray_1_EliteChallengeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668562);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_EliteRewardSelectionPanel_Public_get_DLC5_RogueLikeEliteRewardSelectionPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668563);
			DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr, 100668564);
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00100A8C File Offset: 0x000FEC8C
		public unsafe DLC5_RogueLikePoolResultPanel RoguelikePoolEditMessagePanel
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RoguelikePoolEditMessagePanel_Public_get_DLC5_RogueLikePoolResultPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolResultPanel>(intPtr3) : null;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00100ACC File Offset: 0x000FECCC
		public unsafe DLC5_RogueLikePoolViewerPanel RoguelikePoolViewerPanel
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RoguelikePoolViewerPanel_Public_get_DLC5_RogueLikePoolViewerPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel>(intPtr3) : null;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00100B0C File Offset: 0x000FED0C
		public unsafe AssetReference RoguelikeTutorialPanel
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RoguelikeTutorialPanel_Public_get_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00100B4C File Offset: 0x000FED4C
		public unsafe AssetReference RogueLikeCardScorePanel
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RogueLikeCardScorePanel_Public_get_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x00100B8C File Offset: 0x000FED8C
		public unsafe DLC5_RogueLikeCardSelectorPanel CardSelectorPanel
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_CardSelectorPanel_Public_get_DLC5_RogueLikeCardSelectorPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel>(intPtr3) : null;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00100BCC File Offset: 0x000FEDCC
		public unsafe Il2CppReferenceArray<RogueLikeCard> Cards
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_Cards_Public_get_Il2CppReferenceArray_1_RogueLikeCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeCard>>(intPtr3) : null;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00100C0C File Offset: 0x000FEE0C
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset CardDescriptionLang
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_CardDescriptionLang_Public_get_MultiLanguageTextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr3) : null;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00100C4C File Offset: 0x000FEE4C
		public unsafe Il2CppReferenceArray<RogueLikeCardPersistent> CardsPersistent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_CardsPersistent_Public_get_Il2CppReferenceArray_1_RogueLikeCardPersistent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeCardPersistent>>(intPtr3) : null;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x00100C8C File Offset: 0x000FEE8C
		public unsafe float RecipeCollectRateWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RecipeCollectRateWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00100CC8 File Offset: 0x000FEEC8
		public unsafe float ItemCollectRateWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_ItemCollectRateWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x00100D04 File Offset: 0x000FEF04
		public unsafe float PartnerCollectRateWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_PartnerCollectRateWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00100D40 File Offset: 0x000FEF40
		public unsafe float IzakayaCollectRateWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_IzakayaCollectRateWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00100D7C File Offset: 0x000FEF7C
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement> RogueLikeAchievements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_RogueLikeAchievements_Public_get_Il2CppReferenceArray_1_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr3) : null;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00100DBC File Offset: 0x000FEFBC
		public unsafe Il2CppStructArray<Vector2Int> PartnerPrice
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_PartnerPrice_Public_get_Il2CppStructArray_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr3) : null;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x00100DFC File Offset: 0x000FEFFC
		public unsafe int FirstRefreshCardPrice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20042, RefRangeEnd = 20043, XrefRangeStart = 20042, XrefRangeEnd = 20043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_FirstRefreshCardPrice_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x00100E38 File Offset: 0x000FF038
		public unsafe Il2CppReferenceArray<RogueLikeRunTimeData.EliteChallengeBase> EliteChallengeProfiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_EliteChallengeProfiles_Public_get_Il2CppReferenceArray_1_EliteChallengeBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeRunTimeData.EliteChallengeBase>>(intPtr3) : null;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x00100E78 File Offset: 0x000FF078
		public unsafe DLC5_RogueLikeEliteRewardSelectionPanel EliteRewardSelectionPanel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr_get_EliteRewardSelectionPanel_Public_get_DLC5_RogueLikeEliteRewardSelectionPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteRewardSelectionPanel>(intPtr3) : null;
			}
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00100EB8 File Offset: 0x000FF0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73875, XrefRangeEnd = 73876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeDataProfileUnchangeable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeDataProfileUnchangeable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfileUnchangeable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00011A87 File Offset: 0x0000FC87
		public DLC5_RogueLikeDataProfileUnchangeable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00100EF4 File Offset: 0x000FF0F4
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x00011A90 File Offset: 0x0000FC90
		public unsafe DLC5_RogueLikePoolResultPanel m_RoguelikePoolEditMessagePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RoguelikePoolEditMessagePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolResultPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RoguelikePoolEditMessagePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00100F24 File Offset: 0x000FF124
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x00011AAF File Offset: 0x0000FCAF
		public unsafe DLC5_RogueLikePoolViewerPanel m_RoguelikePoolViewerPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RoguelikePoolViewerPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RoguelikePoolViewerPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00100F54 File Offset: 0x000FF154
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x00011ACE File Offset: 0x0000FCCE
		public unsafe AssetReference m_RogueLikeCardScorePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RogueLikeCardScorePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RogueLikeCardScorePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00100F84 File Offset: 0x000FF184
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x00011AED File Offset: 0x0000FCED
		public unsafe AssetReference m_RoguelikeTutorialPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RoguelikeTutorialPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RoguelikeTutorialPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00100FB4 File Offset: 0x000FF1B4
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x00011B0C File Offset: 0x0000FD0C
		public unsafe DLC5_RogueLikeCardSelectorPanel m_CardSelectorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_CardSelectorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_CardSelectorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00100FE4 File Offset: 0x000FF1E4
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00011B2B File Offset: 0x0000FD2B
		public unsafe Il2CppReferenceArray<RogueLikeCard> m_Cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_Cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_Cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00101014 File Offset: 0x000FF214
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x00011B4A File Offset: 0x0000FD4A
		public unsafe Il2CppReferenceArray<RogueLikeCardPersistent> m_CardsPersistent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_CardsPersistent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeCardPersistent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_CardsPersistent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00101044 File Offset: 0x000FF244
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x00011B69 File Offset: 0x0000FD69
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset m_CardDescriptionLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_CardDescriptionLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_CardDescriptionLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x00101074 File Offset: 0x000FF274
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x00011B88 File Offset: 0x0000FD88
		public unsafe float m_RecipeCollectRateWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RecipeCollectRateWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RecipeCollectRateWeight)) = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0010109C File Offset: 0x000FF29C
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x00011BA3 File Offset: 0x0000FDA3
		public unsafe float m_ItemCollectRateWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_ItemCollectRateWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_ItemCollectRateWeight)) = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x001010C4 File Offset: 0x000FF2C4
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x00011BBE File Offset: 0x0000FDBE
		public unsafe float m_PartnerCollectRateWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_PartnerCollectRateWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_PartnerCollectRateWeight)) = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x001010EC File Offset: 0x000FF2EC
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x00011BD9 File Offset: 0x0000FDD9
		public unsafe float m_IzakayaCollectRateWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_IzakayaCollectRateWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_IzakayaCollectRateWeight)) = value;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x00101114 File Offset: 0x000FF314
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x00011BF4 File Offset: 0x0000FDF4
		public unsafe Il2CppStructArray<Vector2Int> m_PartnerPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_PartnerPrice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_PartnerPrice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00101144 File Offset: 0x000FF344
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x00011C13 File Offset: 0x0000FE13
		public unsafe int m_FirstRefreshCardPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_FirstRefreshCardPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_FirstRefreshCardPrice)) = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x0010116C File Offset: 0x000FF36C
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x00011C2E File Offset: 0x0000FE2E
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement> m_RogueLikeAchievements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RogueLikeAchievements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_RogueLikeAchievements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x0010119C File Offset: 0x000FF39C
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x00011C4D File Offset: 0x0000FE4D
		public unsafe Il2CppReferenceArray<RogueLikeRunTimeData.EliteChallengeBase> m_EliteChallengeProfiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_EliteChallengeProfiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeRunTimeData.EliteChallengeBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_EliteChallengeProfiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x001011CC File Offset: 0x000FF3CC
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x00011C6C File Offset: 0x0000FE6C
		public unsafe DLC5_RogueLikeEliteRewardSelectionPanel m_EliteRewardSelectionPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_EliteRewardSelectionPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteRewardSelectionPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfileUnchangeable.NativeFieldInfoPtr_m_EliteRewardSelectionPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeFieldInfoPtr_m_RoguelikePoolEditMessagePanel;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeFieldInfoPtr_m_RoguelikePoolViewerPanel;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeFieldInfoPtr_m_RogueLikeCardScorePanel;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeFieldInfoPtr_m_RoguelikeTutorialPanel;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeFieldInfoPtr_m_CardSelectorPanel;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeFieldInfoPtr_m_Cards;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeFieldInfoPtr_m_CardsPersistent;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeFieldInfoPtr_m_CardDescriptionLang;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeCollectRateWeight;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemCollectRateWeight;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerCollectRateWeight;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaCollectRateWeight;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerPrice;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstRefreshCardPrice;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeFieldInfoPtr_m_RogueLikeAchievements;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteChallengeProfiles;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteRewardSelectionPanel;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_get_RoguelikePoolEditMessagePanel_Public_get_DLC5_RogueLikePoolResultPanel_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_get_RoguelikePoolViewerPanel_Public_get_DLC5_RogueLikePoolViewerPanel_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_get_RoguelikeTutorialPanel_Public_get_AssetReference_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeCardScorePanel_Public_get_AssetReference_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_get_CardSelectorPanel_Public_get_DLC5_RogueLikeCardSelectorPanel_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_get_Cards_Public_get_Il2CppReferenceArray_1_RogueLikeCard_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_get_CardDescriptionLang_Public_get_MultiLanguageTextAsset_0;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeMethodInfoPtr_get_CardsPersistent_Public_get_Il2CppReferenceArray_1_RogueLikeCardPersistent_0;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeMethodInfoPtr_get_RecipeCollectRateWeight_Public_get_Single_0;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemCollectRateWeight_Public_get_Single_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerCollectRateWeight_Public_get_Single_0;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_get_IzakayaCollectRateWeight_Public_get_Single_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeAchievements_Public_get_Il2CppReferenceArray_1_RogueLikeAchievement_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerPrice_Public_get_Il2CppStructArray_1_Vector2Int_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstRefreshCardPrice_Public_get_Int32_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_get_EliteChallengeProfiles_Public_get_Il2CppReferenceArray_1_EliteChallengeBase_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_get_EliteRewardSelectionPanel_Public_get_DLC5_RogueLikeEliteRewardSelectionPanel_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
