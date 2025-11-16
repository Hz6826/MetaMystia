using System;
using System.Runtime.InteropServices;
using Common.UI;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.CoreLanguage;
using GameData.Profile;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000249 RID: 585
	[Serializable]
	public class SpecialGuest : GuestBase
	{
		// Token: 0x060048D2 RID: 18642 RVA: 0x0019B28C File Offset: 0x0019948C
		// Note: this type is marked as 'beforefieldinit'.
		static SpecialGuest()
		{
			Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "SpecialGuest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr);
			SpecialGuest.NativeFieldInfoPtr_stringId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "stringId");
			SpecialGuest.NativeFieldInfoPtr_fundRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "fundRange");
			SpecialGuest.NativeFieldInfoPtr_enduranceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "enduranceLimit");
			SpecialGuest.NativeFieldInfoPtr_hateFoodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "hateFoodTag");
			SpecialGuest.NativeFieldInfoPtr_likeFoodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "likeFoodTag");
			SpecialGuest.NativeFieldInfoPtr_likeBevTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "likeBevTag");
			SpecialGuest.NativeFieldInfoPtr_reaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "reaction");
			SpecialGuest.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "destination");
			SpecialGuest.NativeFieldInfoPtr_commisionAreaLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "commisionAreaLabel");
			SpecialGuest.NativeFieldInfoPtr_hideInAlbum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "hideInAlbum");
			SpecialGuest.NativeFieldInfoPtr_isParticular = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "isParticular");
			SpecialGuest.NativeFieldInfoPtr_isCollabCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "isCollabCharacter");
			SpecialGuest.NativeFieldInfoPtr_hideInNX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "hideInNX");
			SpecialGuest.NativeFieldInfoPtr_spawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "spawnType");
			SpecialGuest.NativeFieldInfoPtr_unifiedSpawnProb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "unifiedSpawnProb");
			SpecialGuest.NativeFieldInfoPtr_unifiedSpawnExclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "unifiedSpawnExclusion");
			SpecialGuest.NativeFieldInfoPtr_unifiedSpawnWhereAfterEventOrMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "unifiedSpawnWhereAfterEventOrMission");
			SpecialGuest.NativeFieldInfoPtr_doNotShowInNightByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "doNotShowInNightByDefault");
			SpecialGuest.NativeFieldInfoPtr_doNotShowInChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "doNotShowInChallenge");
			SpecialGuest.NativeFieldInfoPtr_controllable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "controllable");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel1Welcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel1Welcome");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2Welcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel2Welcome");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3Welcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel3Welcome");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4Welcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel4Welcome");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5Welcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel5Welcome");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel1ChatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel1ChatData");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2ChatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel2ChatData");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3ChatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel3ChatData");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4ChatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel4ChatData");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5ChatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel5ChatData");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2InviteSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel2InviteSucceed");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2InviteFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel2InviteFailed");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3InviteSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel3InviteSucceed");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3InviteFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel3InviteFailed");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4InviteSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel4InviteSucceed");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4InviteFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel4InviteFailed");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5InviteSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel5InviteSucceed");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3RequestIngerdient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel3RequestIngerdient");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4RequestIngerdient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel4RequestIngerdient");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5RequestIngerdient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel5RequestIngerdient");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4RequestBeverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel4RequestBeverage");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5RequestBeverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel5RequestBeverage");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5Commision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel5Commision");
			SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5CommisionFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "characterKizunaLevel5CommisionFinish");
			SpecialGuest.NativeFieldInfoPtr_m_SpecialGuestExtraDialogDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "m_SpecialGuestExtraDialogDataAsset");
			SpecialGuest.NativeFieldInfoPtr_guestFoodEasterEggData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "guestFoodEasterEggData");
			SpecialGuest.NativeMethodInfoPtr_get_RunTimeData_Public_get_SpecialGuestRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677843);
			SpecialGuest.NativeMethodInfoPtr_get_CharacterPortrayal_Public_Virtual_get_CharacterPortrayal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677844);
			SpecialGuest.NativeMethodInfoPtr_get_CharacterDefaultPortrayal_Public_get_CharacterPortrayal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677845);
			SpecialGuest.NativeMethodInfoPtr_get_CharacterPixel_Public_Virtual_get_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677846);
			SpecialGuest.NativeMethodInfoPtr_get_GuestFoodEasterEggData_Public_get_GuestFoodEasterEggData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677847);
			SpecialGuest.NativeMethodInfoPtr_get_HateFoodTag_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677848);
			SpecialGuest.NativeMethodInfoPtr_get_LikeBevTagUnfolded_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677849);
			SpecialGuest.NativeMethodInfoPtr_get_LikeBevTag_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677850);
			SpecialGuest.NativeMethodInfoPtr_get_LikeFoodTag_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677851);
			SpecialGuest.NativeMethodInfoPtr_get_LikeFoodTagUnfolded_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677852);
			SpecialGuest.NativeMethodInfoPtr_get_LikeFoodTagOriginal_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677853);
			SpecialGuest.NativeMethodInfoPtr_get_HateFoodTagOriginal_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677854);
			SpecialGuest.NativeMethodInfoPtr_get_LikeBevTagOriginal_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677855);
			SpecialGuest.NativeMethodInfoPtr_get_HideInAlbum_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677856);
			SpecialGuest.NativeMethodInfoPtr_get_HideInAlbumAfterOverride_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677857);
			SpecialGuest.NativeMethodInfoPtr_get_DoNotShowInNightByDefault_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677858);
			SpecialGuest.NativeMethodInfoPtr_get_DoNotShowInChallenge_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677859);
			SpecialGuest.NativeMethodInfoPtr_get_IsParticular_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677860);
			SpecialGuest.NativeMethodInfoPtr_get_IsCollabCharacter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677861);
			SpecialGuest.NativeMethodInfoPtr_get_HideInNX_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677862);
			SpecialGuest.NativeMethodInfoPtr_get_Controllable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677863);
			SpecialGuest.NativeMethodInfoPtr_get_HateBevTag_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677864);
			SpecialGuest.NativeMethodInfoPtr_get_Reaction_Public_get_Prespective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677865);
			SpecialGuest.NativeMethodInfoPtr_get_Text_Public_Virtual_get_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677866);
			SpecialGuest.NativeMethodInfoPtr_get_StringId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677867);
			SpecialGuest.NativeMethodInfoPtr_get_HasSpell_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677868);
			SpecialGuest.NativeMethodInfoPtr_get_GetEnduranceLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677869);
			SpecialGuest.NativeMethodInfoPtr_get_Evaluation_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677870);
			SpecialGuest.NativeMethodInfoPtr_get_Destination_Public_get_Destination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677871);
			SpecialGuest.NativeMethodInfoPtr_get_CommisionAreaLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677872);
			SpecialGuest.NativeMethodInfoPtr_get_SpawnType_Public_get_WorkSceneSpawnType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677873);
			SpecialGuest.NativeMethodInfoPtr_get_SpawnExtraProperty_Public_get_ValueTuple_2_Single_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677874);
			SpecialGuest.NativeMethodInfoPtr_GetFundRange_Public_Virtual_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677875);
			SpecialGuest.NativeMethodInfoPtr_InjectAdditiveData_Public_Void_SpecialGuestAdditiveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677876);
			SpecialGuest.NativeMethodInfoPtr_GetSpecialGuestSpawnInfo_Public_Void_byref_PlaceRenderMode_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677877);
			SpecialGuest.NativeMethodInfoPtr_ShouldSpawnHere_Public_Boolean_Int32_String_IEnumerable_1_SpecialGuestGroup_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677878);
			SpecialGuest.NativeMethodInfoPtr_CheckCanSpawnEveryWhere_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677879);
			SpecialGuest.NativeMethodInfoPtr_ShouldSpawnHere_Public_Boolean_Izakaya_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677880);
			SpecialGuest.NativeMethodInfoPtr_OnGetVisual_Protected_Virtual_GuestProfilePair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677881);
			SpecialGuest.NativeMethodInfoPtr_GetLikeTagWeighted_Private_IEnumerable_1_WeightedTag_IEnumerable_1_WeightedTag_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677882);
			SpecialGuest.NativeMethodInfoPtr_GetFoodTagText_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677883);
			SpecialGuest.NativeMethodInfoPtr_GetBevTagText_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677884);
			SpecialGuest.NativeMethodInfoPtr_GenerateRandomConvMessage_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677885);
			SpecialGuest.NativeMethodInfoPtr_GenerateRandomConvMessage_Public_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677886);
			SpecialGuest.NativeMethodInfoPtr_GetSpellLanguage_Public_Il2CppReferenceArray_1_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677887);
			SpecialGuest.NativeMethodInfoPtr_GetDialogPackagesAtKizunaLevel_Public_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677888);
			SpecialGuest.NativeMethodInfoPtr_GetWelcomeDialogPackagesAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677889);
			SpecialGuest.NativeMethodInfoPtr_GetInviteDialogPackageAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677890);
			SpecialGuest.NativeMethodInfoPtr_GetRequestIngerdientAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677891);
			SpecialGuest.NativeMethodInfoPtr_GetRequestBeverageAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677892);
			SpecialGuest.NativeMethodInfoPtr_GetCommisionDialogPackage_Public_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677893);
			SpecialGuest.NativeMethodInfoPtr_GetCommisionFinishDialogPackage_Public_Il2CppReferenceArray_1_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677894);
			SpecialGuest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677895);
			SpecialGuest.NativeMethodInfoPtr_Clone_Public_SpecialGuest_Destination_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677896);
			SpecialGuest.NativeMethodInfoPtr_LoadExtraDialogData_Public_UniTask_1_IAssetHandle_1_SpecialGuestExtraDialogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677897);
			SpecialGuest.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Vector2Int_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_WeightedTag_Il2CppReferenceArray_1_WeightedTag_Prespective_Destination_String_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppReferenceArray_1_DialogPackage_Il2CppRefer = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677898);
			SpecialGuest.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_1_Private_Boolean_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677899);
			SpecialGuest.NativeMethodInfoPtr__ShouldSpawnHere_b__88_0_Private_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, 100677900);
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x060048D3 RID: 18643 RVA: 0x0019BADC File Offset: 0x00199CDC
		public unsafe RunTimeAlbum.SpecialGuestRunTimeData RunTimeData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 190730, RefRangeEnd = 190732, XrefRangeStart = 190726, XrefRangeEnd = 190730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_RunTimeData_Public_get_SpecialGuestRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.SpecialGuestRunTimeData>(intPtr3) : null;
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x060048D4 RID: 18644 RVA: 0x0019BB1C File Offset: 0x00199D1C
		public unsafe override CharacterPortrayal CharacterPortrayal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190732, XrefRangeEnd = 190736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuest.NativeMethodInfoPtr_get_CharacterPortrayal_Public_Virtual_get_CharacterPortrayal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr3) : null;
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x0019BB68 File Offset: 0x00199D68
		public unsafe CharacterPortrayal CharacterDefaultPortrayal
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 190740, RefRangeEnd = 190743, XrefRangeStart = 190736, XrefRangeEnd = 190740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_CharacterDefaultPortrayal_Public_get_CharacterPortrayal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr3) : null;
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x060048D6 RID: 18646 RVA: 0x0019BBA8 File Offset: 0x00199DA8
		public unsafe override CharacterSpriteSetCompact CharacterPixel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190743, XrefRangeEnd = 190747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuest.NativeMethodInfoPtr_get_CharacterPixel_Public_Virtual_get_CharacterSpriteSetCompact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x0019BBF4 File Offset: 0x00199DF4
		public unsafe GuestFoodEasterEggData GuestFoodEasterEggData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_GuestFoodEasterEggData_Public_get_GuestFoodEasterEggData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestFoodEasterEggData>(intPtr3) : null;
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x0019BC34 File Offset: 0x00199E34
		public unsafe IEnumerable<int> HateFoodTag
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 190755, RefRangeEnd = 190773, XrefRangeStart = 190747, XrefRangeEnd = 190755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_HateFoodTag_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x0019BC74 File Offset: 0x00199E74
		public unsafe Il2CppStructArray<int> LikeBevTagUnfolded
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 190796, RefRangeEnd = 190801, XrefRangeStart = 190773, XrefRangeEnd = 190796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_LikeBevTagUnfolded_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x060048DA RID: 18650 RVA: 0x0019BCB4 File Offset: 0x00199EB4
		public unsafe Il2CppStructArray<int> LikeBevTag
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 190824, RefRangeEnd = 190837, XrefRangeStart = 190801, XrefRangeEnd = 190824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_LikeBevTag_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x060048DB RID: 18651 RVA: 0x0019BCF4 File Offset: 0x00199EF4
		public unsafe override Il2CppStructArray<int> LikeFoodTag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190837, XrefRangeEnd = 190860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuest.NativeMethodInfoPtr_get_LikeFoodTag_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x060048DC RID: 18652 RVA: 0x0019BD40 File Offset: 0x00199F40
		public unsafe Il2CppStructArray<int> LikeFoodTagUnfolded
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 190883, RefRangeEnd = 190890, XrefRangeStart = 190860, XrefRangeEnd = 190883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_LikeFoodTagUnfolded_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x060048DD RID: 18653 RVA: 0x0019BD80 File Offset: 0x00199F80
		public unsafe Il2CppStructArray<int> LikeFoodTagOriginal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190912, RefRangeEnd = 190913, XrefRangeStart = 190890, XrefRangeEnd = 190912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_LikeFoodTagOriginal_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x0019BDC0 File Offset: 0x00199FC0
		public unsafe Il2CppStructArray<int> HateFoodTagOriginal
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_HateFoodTagOriginal_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x0019BE00 File Offset: 0x0019A000
		public unsafe Il2CppStructArray<int> LikeBevTagOriginal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190935, RefRangeEnd = 190936, XrefRangeStart = 190913, XrefRangeEnd = 190935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_LikeBevTagOriginal_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x060048E0 RID: 18656 RVA: 0x0019BE40 File Offset: 0x0019A040
		public unsafe bool HideInAlbum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_HideInAlbum_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x060048E1 RID: 18657 RVA: 0x0019BE7C File Offset: 0x0019A07C
		public unsafe bool HideInAlbumAfterOverride
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 190940, RefRangeEnd = 190962, XrefRangeStart = 190936, XrefRangeEnd = 190940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_HideInAlbumAfterOverride_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x0019BEB8 File Offset: 0x0019A0B8
		public unsafe bool DoNotShowInNightByDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_DoNotShowInNightByDefault_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x0019BEF4 File Offset: 0x0019A0F4
		public unsafe bool DoNotShowInChallenge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_DoNotShowInChallenge_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x0019BF30 File Offset: 0x0019A130
		public unsafe bool IsParticular
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_IsParticular_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x0019BF6C File Offset: 0x0019A16C
		public unsafe bool IsCollabCharacter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_IsCollabCharacter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x060048E6 RID: 18662 RVA: 0x0019BFA8 File Offset: 0x0019A1A8
		public unsafe bool HideInNX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_HideInNX_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x060048E7 RID: 18663 RVA: 0x0019BFE4 File Offset: 0x0019A1E4
		public unsafe bool Controllable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_Controllable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x060048E8 RID: 18664 RVA: 0x0019C020 File Offset: 0x0019A220
		public unsafe IEnumerable<int> HateBevTag
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 190970, RefRangeEnd = 190973, XrefRangeStart = 190962, XrefRangeEnd = 190970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_HateBevTag_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x060048E9 RID: 18665 RVA: 0x0019C060 File Offset: 0x0019A260
		public unsafe SpecialGuest.Prespective Reaction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_Reaction_Public_get_Prespective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x060048EA RID: 18666 RVA: 0x0019C09C File Offset: 0x0019A29C
		public unsafe override LanguageBase Text
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190973, XrefRangeEnd = 190974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuest.NativeMethodInfoPtr_get_Text_Public_Virtual_get_LanguageBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x060048EB RID: 18667 RVA: 0x0019C0E8 File Offset: 0x0019A2E8
		public unsafe string StringId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_StringId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x060048EC RID: 18668 RVA: 0x0019C120 File Offset: 0x0019A320
		public unsafe bool HasSpell
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 190978, RefRangeEnd = 190984, XrefRangeStart = 190974, XrefRangeEnd = 190978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_HasSpell_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x0019C15C File Offset: 0x0019A35C
		public unsafe float GetEnduranceLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_GetEnduranceLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x060048EE RID: 18670 RVA: 0x0019C198 File Offset: 0x0019A398
		public unsafe Il2CppStringArray Evaluation
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 190990, RefRangeEnd = 190994, XrefRangeStart = 190984, XrefRangeEnd = 190990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_Evaluation_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x0019C1D8 File Offset: 0x0019A3D8
		public unsafe NPC.Destination Destination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_Destination_Public_get_Destination_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NPC.Destination(pointer);
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x0019C210 File Offset: 0x0019A410
		public unsafe string CommisionAreaLabel
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54389, RefRangeEnd = 54396, XrefRangeStart = 54389, XrefRangeEnd = 54396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_CommisionAreaLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x0019C248 File Offset: 0x0019A448
		public unsafe SpecialGuest.WorkSceneSpawnType SpawnType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_SpawnType_Public_get_WorkSceneSpawnType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x060048F2 RID: 18674 RVA: 0x0019C284 File Offset: 0x0019A484
		public unsafe ValueTuple<float, Il2CppStringArray> SpawnExtraProperty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190994, XrefRangeEnd = 190997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_get_SpawnExtraProperty_Public_get_ValueTuple_2_Single_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<float, Il2CppStringArray>(pointer);
			}
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x0019C2BC File Offset: 0x0019A4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190997, XrefRangeEnd = 191004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2Int GetFundRange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuest.NativeMethodInfoPtr_GetFundRange_Public_Virtual_Vector2Int_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x0019C304 File Offset: 0x0019A504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191180, RefRangeEnd = 191181, XrefRangeStart = 191004, XrefRangeEnd = 191180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InjectAdditiveData(ExpandableGameDataPack.SpecialGuestAdditiveData additiveDataPack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(additiveDataPack));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_InjectAdditiveData_Public_Void_SpecialGuestAdditiveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x0019C34C File Offset: 0x0019A54C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191296, RefRangeEnd = 191297, XrefRangeStart = 191181, XrefRangeEnd = 191296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSpecialGuestSpawnInfo(out NormalGuestDescriber.PlaceRenderMode renderMode, out Il2CppStructArray<int> izakayaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &renderMode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetSpecialGuestSpawnInfo_Public_Void_byref_PlaceRenderMode_byref_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			izakayaInfo = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x0019C3AC File Offset: 0x0019A5AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191338, RefRangeEnd = 191341, XrefRangeStart = 191297, XrefRangeEnd = 191338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSpawnHere(int izakayaId, string daySceneMapLabel, IEnumerable<Izakaya.SpecialGuestGroup> specialGuestGroups, bool isChallengeSession, out float spawnProb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref izakayaId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daySceneMapLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuestGroups);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isChallengeSession;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spawnProb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_ShouldSpawnHere_Public_Boolean_Int32_String_IEnumerable_1_SpecialGuestGroup_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x0019C438 File Offset: 0x0019A638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191351, RefRangeEnd = 191353, XrefRangeStart = 191341, XrefRangeEnd = 191351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanSpawnEveryWhere()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_CheckCanSpawnEveryWhere_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x0019C474 File Offset: 0x0019A674
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 191354, RefRangeEnd = 191358, XrefRangeStart = 191353, XrefRangeEnd = 191354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSpawnHere(Izakaya izakaya, bool isChallengeSession, out float spawnProb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(izakaya);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isChallengeSession;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spawnProb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_ShouldSpawnHere_Public_Boolean_Izakaya_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x0019C4E0 File Offset: 0x0019A6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191358, XrefRangeEnd = 191362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GuestProfilePair OnGetVisual(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuest.NativeMethodInfoPtr_OnGetVisual_Protected_Virtual_GuestProfilePair_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestProfilePair>(intPtr3) : null;
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x0019C538 File Offset: 0x0019A738
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 191392, RefRangeEnd = 191398, XrefRangeStart = 191362, XrefRangeEnd = 191392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<SpecialGuest.WeightedTag> GetLikeTagWeighted(IEnumerable<SpecialGuest.WeightedTag> rawTagSet, bool includesPop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawTagSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includesPop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetLikeTagWeighted_Private_IEnumerable_1_WeightedTag_IEnumerable_1_WeightedTag_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SpecialGuest.WeightedTag>>(intPtr3) : null;
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x0019C598 File Offset: 0x0019A798
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 191410, RefRangeEnd = 191414, XrefRangeStart = 191398, XrefRangeEnd = 191410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFoodTagText(int tagId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tagId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetFoodTagText_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x0019C5DC File Offset: 0x0019A7DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191426, RefRangeEnd = 191428, XrefRangeStart = 191414, XrefRangeEnd = 191426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetBevTagText(int tagId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tagId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetBevTagText_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x0019C620 File Offset: 0x0019A820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191429, RefRangeEnd = 191431, XrefRangeStart = 191428, XrefRangeEnd = 191429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenerateRandomConvMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GenerateRandomConvMessage_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x0019C658 File Offset: 0x0019A858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191446, RefRangeEnd = 191447, XrefRangeStart = 191431, XrefRangeEnd = 191446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenerateRandomConvMessage(IEnumerable<string> extraConv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(extraConv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GenerateRandomConvMessage_Public_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x0019C6A0 File Offset: 0x0019A8A0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 191448, RefRangeEnd = 191466, XrefRangeStart = 191447, XrefRangeEnd = 191448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<LanguageBase> GetSpellLanguage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetSpellLanguage_Public_Il2CppReferenceArray_1_LanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LanguageBase>>(intPtr3) : null;
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x0019C6E0 File Offset: 0x0019A8E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191466, RefRangeEnd = 191468, XrefRangeStart = 191466, XrefRangeEnd = 191466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetDialogPackagesAtKizunaLevel(int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetDialogPackagesAtKizunaLevel_Public_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x0019C72C File Offset: 0x0019A92C
		[CallerCount(0)]
		public unsafe Il2CppReferenceArray<DialogPackage> GetWelcomeDialogPackagesAtKizunaLevel(int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetWelcomeDialogPackagesAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x0019C778 File Offset: 0x0019A978
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191468, RefRangeEnd = 191470, XrefRangeStart = 191468, XrefRangeEnd = 191468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DialogPackage> GetInviteDialogPackageAtKizunaLevel(int level, bool succeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref succeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetInviteDialogPackageAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x0019C7D4 File Offset: 0x0019A9D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191470, RefRangeEnd = 191471, XrefRangeStart = 191470, XrefRangeEnd = 191470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DialogPackage> GetRequestIngerdientAtKizunaLevel(int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetRequestIngerdientAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x0019C820 File Offset: 0x0019AA20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191471, RefRangeEnd = 191472, XrefRangeStart = 191471, XrefRangeEnd = 191471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DialogPackage> GetRequestBeverageAtKizunaLevel(int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetRequestBeverageAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x0019C86C File Offset: 0x0019AA6C
		[CallerCount(0)]
		public unsafe Il2CppReferenceArray<DialogPackage> GetCommisionDialogPackage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetCommisionDialogPackage_Public_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x0019C8AC File Offset: 0x0019AAAC
		[CallerCount(0)]
		public unsafe Il2CppReferenceArray<DialogPackage> GetCommisionFinishDialogPackage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_GetCommisionFinishDialogPackage_Public_Il2CppReferenceArray_1_DialogPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr3) : null;
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x0019C8EC File Offset: 0x0019AAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191472, XrefRangeEnd = 191561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x0019C930 File Offset: 0x0019AB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191565, RefRangeEnd = 191566, XrefRangeStart = 191561, XrefRangeEnd = 191565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuest Clone(NPC.Destination overrideDestination, string daySceneLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideDestination));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daySceneLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_Clone_Public_SpecialGuest_Destination_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x0019C998 File Offset: 0x0019AB98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191571, RefRangeEnd = 191572, XrefRangeStart = 191566, XrefRangeEnd = 191571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<IAssetHandle<SpecialGuestExtraDialogData>> LoadExtraDialogData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr_LoadExtraDialogData_Public_UniTask_1_IAssetHandle_1_SpecialGuestExtraDialogData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IAssetHandle<SpecialGuestExtraDialogData>>(pointer);
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x0019C9D0 File Offset: 0x0019ABD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191607, RefRangeEnd = 191608, XrefRangeStart = 191572, XrefRangeEnd = 191607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuest(int id, string stringId, Vector2Int fundRange, Il2CppStructArray<int> hateFoodTag, Il2CppReferenceArray<SpecialGuest.WeightedTag> likeFoodTag, Il2CppReferenceArray<SpecialGuest.WeightedTag> likeBevTag, SpecialGuest.Prespective reaction, NPC.Destination destination, string commisionAreaLabel, Il2CppReferenceArray<DialogPackage> characterKizunaLevel1Welcome, Il2CppReferenceArray<DialogPackage> characterKizunaLevel2Welcome, Il2CppReferenceArray<DialogPackage> characterKizunaLevel3Welcome, Il2CppReferenceArray<DialogPackage> characterKizunaLevel4Welcome, Il2CppReferenceArray<DialogPackage> characterKizunaLevel5Welcome, Il2CppStringArray characterKizunaLevel1ChatData, Il2CppStringArray characterKizunaLevel2ChatData, Il2CppStringArray characterKizunaLevel3ChatData, Il2CppStringArray characterKizunaLevel4ChatData, Il2CppStringArray characterKizunaLevel5ChatData, Il2CppReferenceArray<DialogPackage> characterKizunaLevel2InviteSucceed, Il2CppReferenceArray<DialogPackage> characterKizunaLevel2InviteFailed, Il2CppReferenceArray<DialogPackage> characterKizunaLevel3InviteSucceed, Il2CppReferenceArray<DialogPackage> characterKizunaLevel3InviteFailed, Il2CppReferenceArray<DialogPackage> characterKizunaLevel4InviteSucceed, Il2CppReferenceArray<DialogPackage> characterKizunaLevel4InviteFailed, Il2CppReferenceArray<DialogPackage> characterKizunaLevel5InviteSucceed, Il2CppReferenceArray<DialogPackage> characterKizunaLevel3RequestIngerdient, Il2CppReferenceArray<DialogPackage> characterKizunaLevel4RequestIngerdient, Il2CppReferenceArray<DialogPackage> characterKizunaLevel5RequestIngerdient, Il2CppReferenceArray<DialogPackage> characterKizunaLevel4RequestBeverage, Il2CppReferenceArray<DialogPackage> characterKizunaLevel5RequestBeverage, Il2CppReferenceArray<DialogPackage> characterKizunaLevel5Commision, Il2CppReferenceArray<DialogPackage> characterKizunaLevel5CommisionFinish, bool hideInAlbum, bool isParticular, bool isCollabCharacter, SpecialGuest.WorkSceneSpawnType spawnType, Il2CppStringArray unifiedSpawnExclusion, string unifiedSpawnWhereAfterEventOrMission, float unifiedSpawnProb, AssetReferenceT<SpecialGuestExtraDialogData> specialGuestExtraDialogData, bool doNotShowInNightByDefault, bool doNotShowInChallenge, GuestFoodEasterEggData guestFoodEasterEggData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)44) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fundRange;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hateFoodTag);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(likeFoodTag);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(likeBevTag);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reaction;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(commisionAreaLabel);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel1Welcome);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel2Welcome);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel3Welcome);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel4Welcome);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel5Welcome);
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel1ChatData);
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel2ChatData);
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel3ChatData);
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel4ChatData);
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel5ChatData);
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel2InviteSucceed);
			ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel2InviteFailed);
			ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel3InviteSucceed);
			ptr[checked(unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel3InviteFailed);
			ptr[checked(unchecked((UIntPtr)23) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel4InviteSucceed);
			ptr[checked(unchecked((UIntPtr)24) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel4InviteFailed);
			ptr[checked(unchecked((UIntPtr)25) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel5InviteSucceed);
			ptr[checked(unchecked((UIntPtr)26) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel3RequestIngerdient);
			ptr[checked(unchecked((UIntPtr)27) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel4RequestIngerdient);
			ptr[checked(unchecked((UIntPtr)28) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel5RequestIngerdient);
			ptr[checked(unchecked((UIntPtr)29) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel4RequestBeverage);
			ptr[checked(unchecked((UIntPtr)30) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel5RequestBeverage);
			ptr[checked(unchecked((UIntPtr)31) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel5Commision);
			ptr[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterKizunaLevel5CommisionFinish);
			ptr[checked(unchecked((UIntPtr)33) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hideInAlbum;
			ptr[checked(unchecked((UIntPtr)34) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isParticular;
			ptr[checked(unchecked((UIntPtr)35) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCollabCharacter;
			ptr[checked(unchecked((UIntPtr)36) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnType;
			ptr[checked(unchecked((UIntPtr)37) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unifiedSpawnExclusion);
			ptr[checked(unchecked((UIntPtr)38) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(unifiedSpawnWhereAfterEventOrMission);
			ptr[checked(unchecked((UIntPtr)39) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unifiedSpawnProb;
			ptr[checked(unchecked((UIntPtr)40) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuestExtraDialogData);
			ptr[checked(unchecked((UIntPtr)41) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotShowInNightByDefault;
			ptr[checked(unchecked((UIntPtr)42) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotShowInChallenge;
			ptr[checked(unchecked((UIntPtr)43) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestFoodEasterEggData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Vector2Int_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_WeightedTag_Il2CppReferenceArray_1_WeightedTag_Prespective_Destination_String_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppReferenceArray_1_DialogPackage_Il2CppRefer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x0019CD44 File Offset: 0x0019AF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191608, XrefRangeEnd = 191609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetSpecialGuestSpawnInfo_b__87_1(Izakaya x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_1_Private_Boolean_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x0019CD94 File Offset: 0x0019AF94
		[CallerCount(0)]
		public unsafe bool _ShouldSpawnHere_b__88_0(Izakaya.SpecialGuestGroup x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.NativeMethodInfoPtr__ShouldSpawnHere_b__88_0_Private_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x000255A1 File Offset: 0x000237A1
		public SpecialGuest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x0019CDE4 File Offset: 0x0019AFE4
		// (set) Token: 0x0600490F RID: 18703 RVA: 0x000255AA File Offset: 0x000237AA
		public unsafe string stringId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_stringId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_stringId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x0019CE0C File Offset: 0x0019B00C
		// (set) Token: 0x06004911 RID: 18705 RVA: 0x000255C9 File Offset: 0x000237C9
		public unsafe Vector2Int fundRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_fundRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_fundRange)) = value;
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x0019CE34 File Offset: 0x0019B034
		// (set) Token: 0x06004913 RID: 18707 RVA: 0x000255E4 File Offset: 0x000237E4
		public unsafe float enduranceLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_enduranceLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_enduranceLimit)) = value;
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06004914 RID: 18708 RVA: 0x0019CE5C File Offset: 0x0019B05C
		// (set) Token: 0x06004915 RID: 18709 RVA: 0x000255FF File Offset: 0x000237FF
		public unsafe Il2CppStructArray<int> hateFoodTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_hateFoodTag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_hateFoodTag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06004916 RID: 18710 RVA: 0x0019CE8C File Offset: 0x0019B08C
		// (set) Token: 0x06004917 RID: 18711 RVA: 0x0002561E File Offset: 0x0002381E
		public unsafe Il2CppReferenceArray<SpecialGuest.WeightedTag> likeFoodTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_likeFoodTag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest.WeightedTag>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_likeFoodTag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06004918 RID: 18712 RVA: 0x0019CEBC File Offset: 0x0019B0BC
		// (set) Token: 0x06004919 RID: 18713 RVA: 0x0002563D File Offset: 0x0002383D
		public unsafe Il2CppReferenceArray<SpecialGuest.WeightedTag> likeBevTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_likeBevTag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest.WeightedTag>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_likeBevTag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x0600491A RID: 18714 RVA: 0x0019CEEC File Offset: 0x0019B0EC
		// (set) Token: 0x0600491B RID: 18715 RVA: 0x0002565C File Offset: 0x0002385C
		public unsafe SpecialGuest.Prespective reaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_reaction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_reaction)) = value;
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x0600491C RID: 18716 RVA: 0x0019CF14 File Offset: 0x0019B114
		// (set) Token: 0x0600491D RID: 18717 RVA: 0x00025677 File Offset: 0x00023877
		public NPC.Destination destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_destination);
				return new NPC.Destination(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_destination), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x0600491E RID: 18718 RVA: 0x0019CF44 File Offset: 0x0019B144
		// (set) Token: 0x0600491F RID: 18719 RVA: 0x000256A5 File Offset: 0x000238A5
		public unsafe string commisionAreaLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_commisionAreaLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_commisionAreaLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x0019CF6C File Offset: 0x0019B16C
		// (set) Token: 0x06004921 RID: 18721 RVA: 0x000256C4 File Offset: 0x000238C4
		public unsafe bool hideInAlbum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_hideInAlbum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_hideInAlbum)) = value;
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06004922 RID: 18722 RVA: 0x0019CF94 File Offset: 0x0019B194
		// (set) Token: 0x06004923 RID: 18723 RVA: 0x000256DF File Offset: 0x000238DF
		public unsafe bool isParticular
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_isParticular);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_isParticular)) = value;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06004924 RID: 18724 RVA: 0x0019CFBC File Offset: 0x0019B1BC
		// (set) Token: 0x06004925 RID: 18725 RVA: 0x000256FA File Offset: 0x000238FA
		public unsafe bool isCollabCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_isCollabCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_isCollabCharacter)) = value;
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x0019CFE4 File Offset: 0x0019B1E4
		// (set) Token: 0x06004927 RID: 18727 RVA: 0x00025715 File Offset: 0x00023915
		public unsafe bool hideInNX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_hideInNX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_hideInNX)) = value;
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06004928 RID: 18728 RVA: 0x0019D00C File Offset: 0x0019B20C
		// (set) Token: 0x06004929 RID: 18729 RVA: 0x00025730 File Offset: 0x00023930
		public unsafe SpecialGuest.WorkSceneSpawnType spawnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_spawnType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_spawnType)) = value;
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x0600492A RID: 18730 RVA: 0x0019D034 File Offset: 0x0019B234
		// (set) Token: 0x0600492B RID: 18731 RVA: 0x0002574B File Offset: 0x0002394B
		public unsafe float unifiedSpawnProb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_unifiedSpawnProb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_unifiedSpawnProb)) = value;
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x0600492C RID: 18732 RVA: 0x0019D05C File Offset: 0x0019B25C
		// (set) Token: 0x0600492D RID: 18733 RVA: 0x00025766 File Offset: 0x00023966
		public unsafe Il2CppStringArray unifiedSpawnExclusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_unifiedSpawnExclusion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_unifiedSpawnExclusion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x0600492E RID: 18734 RVA: 0x0019D08C File Offset: 0x0019B28C
		// (set) Token: 0x0600492F RID: 18735 RVA: 0x00025785 File Offset: 0x00023985
		public unsafe string unifiedSpawnWhereAfterEventOrMission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_unifiedSpawnWhereAfterEventOrMission);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_unifiedSpawnWhereAfterEventOrMission), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x0019D0B4 File Offset: 0x0019B2B4
		// (set) Token: 0x06004931 RID: 18737 RVA: 0x000257A4 File Offset: 0x000239A4
		public unsafe bool doNotShowInNightByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_doNotShowInNightByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_doNotShowInNightByDefault)) = value;
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06004932 RID: 18738 RVA: 0x0019D0DC File Offset: 0x0019B2DC
		// (set) Token: 0x06004933 RID: 18739 RVA: 0x000257BF File Offset: 0x000239BF
		public unsafe bool doNotShowInChallenge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_doNotShowInChallenge);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_doNotShowInChallenge)) = value;
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06004934 RID: 18740 RVA: 0x0019D104 File Offset: 0x0019B304
		// (set) Token: 0x06004935 RID: 18741 RVA: 0x000257DA File Offset: 0x000239DA
		public unsafe bool controllable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_controllable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_controllable)) = value;
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06004936 RID: 18742 RVA: 0x0019D12C File Offset: 0x0019B32C
		// (set) Token: 0x06004937 RID: 18743 RVA: 0x000257F5 File Offset: 0x000239F5
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel1Welcome
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel1Welcome);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel1Welcome), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06004938 RID: 18744 RVA: 0x0019D15C File Offset: 0x0019B35C
		// (set) Token: 0x06004939 RID: 18745 RVA: 0x00025814 File Offset: 0x00023A14
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel2Welcome
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2Welcome);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2Welcome), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x0600493A RID: 18746 RVA: 0x0019D18C File Offset: 0x0019B38C
		// (set) Token: 0x0600493B RID: 18747 RVA: 0x00025833 File Offset: 0x00023A33
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel3Welcome
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3Welcome);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3Welcome), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x0600493C RID: 18748 RVA: 0x0019D1BC File Offset: 0x0019B3BC
		// (set) Token: 0x0600493D RID: 18749 RVA: 0x00025852 File Offset: 0x00023A52
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel4Welcome
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4Welcome);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4Welcome), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x0600493E RID: 18750 RVA: 0x0019D1EC File Offset: 0x0019B3EC
		// (set) Token: 0x0600493F RID: 18751 RVA: 0x00025871 File Offset: 0x00023A71
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel5Welcome
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5Welcome);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5Welcome), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06004940 RID: 18752 RVA: 0x0019D21C File Offset: 0x0019B41C
		// (set) Token: 0x06004941 RID: 18753 RVA: 0x00025890 File Offset: 0x00023A90
		public unsafe Il2CppStringArray characterKizunaLevel1ChatData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel1ChatData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel1ChatData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06004942 RID: 18754 RVA: 0x0019D24C File Offset: 0x0019B44C
		// (set) Token: 0x06004943 RID: 18755 RVA: 0x000258AF File Offset: 0x00023AAF
		public unsafe Il2CppStringArray characterKizunaLevel2ChatData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2ChatData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2ChatData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06004944 RID: 18756 RVA: 0x0019D27C File Offset: 0x0019B47C
		// (set) Token: 0x06004945 RID: 18757 RVA: 0x000258CE File Offset: 0x00023ACE
		public unsafe Il2CppStringArray characterKizunaLevel3ChatData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3ChatData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3ChatData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06004946 RID: 18758 RVA: 0x0019D2AC File Offset: 0x0019B4AC
		// (set) Token: 0x06004947 RID: 18759 RVA: 0x000258ED File Offset: 0x00023AED
		public unsafe Il2CppStringArray characterKizunaLevel4ChatData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4ChatData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4ChatData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06004948 RID: 18760 RVA: 0x0019D2DC File Offset: 0x0019B4DC
		// (set) Token: 0x06004949 RID: 18761 RVA: 0x0002590C File Offset: 0x00023B0C
		public unsafe Il2CppStringArray characterKizunaLevel5ChatData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5ChatData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5ChatData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x0600494A RID: 18762 RVA: 0x0019D30C File Offset: 0x0019B50C
		// (set) Token: 0x0600494B RID: 18763 RVA: 0x0002592B File Offset: 0x00023B2B
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel2InviteSucceed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2InviteSucceed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2InviteSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x0019D33C File Offset: 0x0019B53C
		// (set) Token: 0x0600494D RID: 18765 RVA: 0x0002594A File Offset: 0x00023B4A
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel2InviteFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2InviteFailed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel2InviteFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x0600494E RID: 18766 RVA: 0x0019D36C File Offset: 0x0019B56C
		// (set) Token: 0x0600494F RID: 18767 RVA: 0x00025969 File Offset: 0x00023B69
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel3InviteSucceed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3InviteSucceed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3InviteSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06004950 RID: 18768 RVA: 0x0019D39C File Offset: 0x0019B59C
		// (set) Token: 0x06004951 RID: 18769 RVA: 0x00025988 File Offset: 0x00023B88
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel3InviteFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3InviteFailed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3InviteFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06004952 RID: 18770 RVA: 0x0019D3CC File Offset: 0x0019B5CC
		// (set) Token: 0x06004953 RID: 18771 RVA: 0x000259A7 File Offset: 0x00023BA7
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel4InviteSucceed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4InviteSucceed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4InviteSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06004954 RID: 18772 RVA: 0x0019D3FC File Offset: 0x0019B5FC
		// (set) Token: 0x06004955 RID: 18773 RVA: 0x000259C6 File Offset: 0x00023BC6
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel4InviteFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4InviteFailed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4InviteFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06004956 RID: 18774 RVA: 0x0019D42C File Offset: 0x0019B62C
		// (set) Token: 0x06004957 RID: 18775 RVA: 0x000259E5 File Offset: 0x00023BE5
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel5InviteSucceed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5InviteSucceed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5InviteSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06004958 RID: 18776 RVA: 0x0019D45C File Offset: 0x0019B65C
		// (set) Token: 0x06004959 RID: 18777 RVA: 0x00025A04 File Offset: 0x00023C04
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel3RequestIngerdient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3RequestIngerdient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel3RequestIngerdient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x0600495A RID: 18778 RVA: 0x0019D48C File Offset: 0x0019B68C
		// (set) Token: 0x0600495B RID: 18779 RVA: 0x00025A23 File Offset: 0x00023C23
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel4RequestIngerdient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4RequestIngerdient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4RequestIngerdient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x0600495C RID: 18780 RVA: 0x0019D4BC File Offset: 0x0019B6BC
		// (set) Token: 0x0600495D RID: 18781 RVA: 0x00025A42 File Offset: 0x00023C42
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel5RequestIngerdient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5RequestIngerdient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5RequestIngerdient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x0600495E RID: 18782 RVA: 0x0019D4EC File Offset: 0x0019B6EC
		// (set) Token: 0x0600495F RID: 18783 RVA: 0x00025A61 File Offset: 0x00023C61
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel4RequestBeverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4RequestBeverage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel4RequestBeverage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06004960 RID: 18784 RVA: 0x0019D51C File Offset: 0x0019B71C
		// (set) Token: 0x06004961 RID: 18785 RVA: 0x00025A80 File Offset: 0x00023C80
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel5RequestBeverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5RequestBeverage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5RequestBeverage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06004962 RID: 18786 RVA: 0x0019D54C File Offset: 0x0019B74C
		// (set) Token: 0x06004963 RID: 18787 RVA: 0x00025A9F File Offset: 0x00023C9F
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel5Commision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5Commision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5Commision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06004964 RID: 18788 RVA: 0x0019D57C File Offset: 0x0019B77C
		// (set) Token: 0x06004965 RID: 18789 RVA: 0x00025ABE File Offset: 0x00023CBE
		public unsafe Il2CppReferenceArray<DialogPackage> characterKizunaLevel5CommisionFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5CommisionFinish);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_characterKizunaLevel5CommisionFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06004966 RID: 18790 RVA: 0x0019D5AC File Offset: 0x0019B7AC
		// (set) Token: 0x06004967 RID: 18791 RVA: 0x00025ADD File Offset: 0x00023CDD
		public unsafe AssetReferenceT<SpecialGuestExtraDialogData> m_SpecialGuestExtraDialogDataAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_m_SpecialGuestExtraDialogDataAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<SpecialGuestExtraDialogData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_m_SpecialGuestExtraDialogDataAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06004968 RID: 18792 RVA: 0x0019D5DC File Offset: 0x0019B7DC
		// (set) Token: 0x06004969 RID: 18793 RVA: 0x00025AFC File Offset: 0x00023CFC
		public unsafe GuestFoodEasterEggData guestFoodEasterEggData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_guestFoodEasterEggData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestFoodEasterEggData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.NativeFieldInfoPtr_guestFoodEasterEggData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400320B RID: 12811
		private static readonly IntPtr NativeFieldInfoPtr_stringId;

		// Token: 0x0400320C RID: 12812
		private static readonly IntPtr NativeFieldInfoPtr_fundRange;

		// Token: 0x0400320D RID: 12813
		private static readonly IntPtr NativeFieldInfoPtr_enduranceLimit;

		// Token: 0x0400320E RID: 12814
		private static readonly IntPtr NativeFieldInfoPtr_hateFoodTag;

		// Token: 0x0400320F RID: 12815
		private static readonly IntPtr NativeFieldInfoPtr_likeFoodTag;

		// Token: 0x04003210 RID: 12816
		private static readonly IntPtr NativeFieldInfoPtr_likeBevTag;

		// Token: 0x04003211 RID: 12817
		private static readonly IntPtr NativeFieldInfoPtr_reaction;

		// Token: 0x04003212 RID: 12818
		private static readonly IntPtr NativeFieldInfoPtr_destination;

		// Token: 0x04003213 RID: 12819
		private static readonly IntPtr NativeFieldInfoPtr_commisionAreaLabel;

		// Token: 0x04003214 RID: 12820
		private static readonly IntPtr NativeFieldInfoPtr_hideInAlbum;

		// Token: 0x04003215 RID: 12821
		private static readonly IntPtr NativeFieldInfoPtr_isParticular;

		// Token: 0x04003216 RID: 12822
		private static readonly IntPtr NativeFieldInfoPtr_isCollabCharacter;

		// Token: 0x04003217 RID: 12823
		private static readonly IntPtr NativeFieldInfoPtr_hideInNX;

		// Token: 0x04003218 RID: 12824
		private static readonly IntPtr NativeFieldInfoPtr_spawnType;

		// Token: 0x04003219 RID: 12825
		private static readonly IntPtr NativeFieldInfoPtr_unifiedSpawnProb;

		// Token: 0x0400321A RID: 12826
		private static readonly IntPtr NativeFieldInfoPtr_unifiedSpawnExclusion;

		// Token: 0x0400321B RID: 12827
		private static readonly IntPtr NativeFieldInfoPtr_unifiedSpawnWhereAfterEventOrMission;

		// Token: 0x0400321C RID: 12828
		private static readonly IntPtr NativeFieldInfoPtr_doNotShowInNightByDefault;

		// Token: 0x0400321D RID: 12829
		private static readonly IntPtr NativeFieldInfoPtr_doNotShowInChallenge;

		// Token: 0x0400321E RID: 12830
		private static readonly IntPtr NativeFieldInfoPtr_controllable;

		// Token: 0x0400321F RID: 12831
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel1Welcome;

		// Token: 0x04003220 RID: 12832
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel2Welcome;

		// Token: 0x04003221 RID: 12833
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel3Welcome;

		// Token: 0x04003222 RID: 12834
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel4Welcome;

		// Token: 0x04003223 RID: 12835
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel5Welcome;

		// Token: 0x04003224 RID: 12836
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel1ChatData;

		// Token: 0x04003225 RID: 12837
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel2ChatData;

		// Token: 0x04003226 RID: 12838
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel3ChatData;

		// Token: 0x04003227 RID: 12839
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel4ChatData;

		// Token: 0x04003228 RID: 12840
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel5ChatData;

		// Token: 0x04003229 RID: 12841
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel2InviteSucceed;

		// Token: 0x0400322A RID: 12842
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel2InviteFailed;

		// Token: 0x0400322B RID: 12843
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel3InviteSucceed;

		// Token: 0x0400322C RID: 12844
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel3InviteFailed;

		// Token: 0x0400322D RID: 12845
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel4InviteSucceed;

		// Token: 0x0400322E RID: 12846
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel4InviteFailed;

		// Token: 0x0400322F RID: 12847
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel5InviteSucceed;

		// Token: 0x04003230 RID: 12848
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel3RequestIngerdient;

		// Token: 0x04003231 RID: 12849
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel4RequestIngerdient;

		// Token: 0x04003232 RID: 12850
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel5RequestIngerdient;

		// Token: 0x04003233 RID: 12851
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel4RequestBeverage;

		// Token: 0x04003234 RID: 12852
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel5RequestBeverage;

		// Token: 0x04003235 RID: 12853
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel5Commision;

		// Token: 0x04003236 RID: 12854
		private static readonly IntPtr NativeFieldInfoPtr_characterKizunaLevel5CommisionFinish;

		// Token: 0x04003237 RID: 12855
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestExtraDialogDataAsset;

		// Token: 0x04003238 RID: 12856
		private static readonly IntPtr NativeFieldInfoPtr_guestFoodEasterEggData;

		// Token: 0x04003239 RID: 12857
		private static readonly IntPtr NativeMethodInfoPtr_get_RunTimeData_Public_get_SpecialGuestRunTimeData_0;

		// Token: 0x0400323A RID: 12858
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterPortrayal_Public_Virtual_get_CharacterPortrayal_0;

		// Token: 0x0400323B RID: 12859
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterDefaultPortrayal_Public_get_CharacterPortrayal_0;

		// Token: 0x0400323C RID: 12860
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterPixel_Public_Virtual_get_CharacterSpriteSetCompact_0;

		// Token: 0x0400323D RID: 12861
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestFoodEasterEggData_Public_get_GuestFoodEasterEggData_0;

		// Token: 0x0400323E RID: 12862
		private static readonly IntPtr NativeMethodInfoPtr_get_HateFoodTag_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x0400323F RID: 12863
		private static readonly IntPtr NativeMethodInfoPtr_get_LikeBevTagUnfolded_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003240 RID: 12864
		private static readonly IntPtr NativeMethodInfoPtr_get_LikeBevTag_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003241 RID: 12865
		private static readonly IntPtr NativeMethodInfoPtr_get_LikeFoodTag_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003242 RID: 12866
		private static readonly IntPtr NativeMethodInfoPtr_get_LikeFoodTagUnfolded_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003243 RID: 12867
		private static readonly IntPtr NativeMethodInfoPtr_get_LikeFoodTagOriginal_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003244 RID: 12868
		private static readonly IntPtr NativeMethodInfoPtr_get_HateFoodTagOriginal_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003245 RID: 12869
		private static readonly IntPtr NativeMethodInfoPtr_get_LikeBevTagOriginal_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003246 RID: 12870
		private static readonly IntPtr NativeMethodInfoPtr_get_HideInAlbum_Public_get_Boolean_0;

		// Token: 0x04003247 RID: 12871
		private static readonly IntPtr NativeMethodInfoPtr_get_HideInAlbumAfterOverride_Public_get_Boolean_0;

		// Token: 0x04003248 RID: 12872
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotShowInNightByDefault_Public_get_Boolean_0;

		// Token: 0x04003249 RID: 12873
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotShowInChallenge_Public_get_Boolean_0;

		// Token: 0x0400324A RID: 12874
		private static readonly IntPtr NativeMethodInfoPtr_get_IsParticular_Public_get_Boolean_0;

		// Token: 0x0400324B RID: 12875
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCollabCharacter_Public_get_Boolean_0;

		// Token: 0x0400324C RID: 12876
		private static readonly IntPtr NativeMethodInfoPtr_get_HideInNX_Public_get_Boolean_0;

		// Token: 0x0400324D RID: 12877
		private static readonly IntPtr NativeMethodInfoPtr_get_Controllable_Public_get_Boolean_0;

		// Token: 0x0400324E RID: 12878
		private static readonly IntPtr NativeMethodInfoPtr_get_HateBevTag_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x0400324F RID: 12879
		private static readonly IntPtr NativeMethodInfoPtr_get_Reaction_Public_get_Prespective_0;

		// Token: 0x04003250 RID: 12880
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_Virtual_get_LanguageBase_0;

		// Token: 0x04003251 RID: 12881
		private static readonly IntPtr NativeMethodInfoPtr_get_StringId_Public_get_String_0;

		// Token: 0x04003252 RID: 12882
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSpell_Public_get_Boolean_0;

		// Token: 0x04003253 RID: 12883
		private static readonly IntPtr NativeMethodInfoPtr_get_GetEnduranceLimit_Public_get_Single_0;

		// Token: 0x04003254 RID: 12884
		private static readonly IntPtr NativeMethodInfoPtr_get_Evaluation_Public_get_Il2CppStringArray_0;

		// Token: 0x04003255 RID: 12885
		private static readonly IntPtr NativeMethodInfoPtr_get_Destination_Public_get_Destination_0;

		// Token: 0x04003256 RID: 12886
		private static readonly IntPtr NativeMethodInfoPtr_get_CommisionAreaLabel_Public_get_String_0;

		// Token: 0x04003257 RID: 12887
		private static readonly IntPtr NativeMethodInfoPtr_get_SpawnType_Public_get_WorkSceneSpawnType_0;

		// Token: 0x04003258 RID: 12888
		private static readonly IntPtr NativeMethodInfoPtr_get_SpawnExtraProperty_Public_get_ValueTuple_2_Single_Il2CppStringArray_0;

		// Token: 0x04003259 RID: 12889
		private static readonly IntPtr NativeMethodInfoPtr_GetFundRange_Public_Virtual_Vector2Int_0;

		// Token: 0x0400325A RID: 12890
		private static readonly IntPtr NativeMethodInfoPtr_InjectAdditiveData_Public_Void_SpecialGuestAdditiveData_0;

		// Token: 0x0400325B RID: 12891
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestSpawnInfo_Public_Void_byref_PlaceRenderMode_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400325C RID: 12892
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSpawnHere_Public_Boolean_Int32_String_IEnumerable_1_SpecialGuestGroup_Boolean_byref_Single_0;

		// Token: 0x0400325D RID: 12893
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanSpawnEveryWhere_Private_Boolean_0;

		// Token: 0x0400325E RID: 12894
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSpawnHere_Public_Boolean_Izakaya_Boolean_byref_Single_0;

		// Token: 0x0400325F RID: 12895
		private static readonly IntPtr NativeMethodInfoPtr_OnGetVisual_Protected_Virtual_GuestProfilePair_Int32_0;

		// Token: 0x04003260 RID: 12896
		private static readonly IntPtr NativeMethodInfoPtr_GetLikeTagWeighted_Private_IEnumerable_1_WeightedTag_IEnumerable_1_WeightedTag_Boolean_0;

		// Token: 0x04003261 RID: 12897
		private static readonly IntPtr NativeMethodInfoPtr_GetFoodTagText_Public_String_Int32_0;

		// Token: 0x04003262 RID: 12898
		private static readonly IntPtr NativeMethodInfoPtr_GetBevTagText_Public_String_Int32_0;

		// Token: 0x04003263 RID: 12899
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandomConvMessage_Public_String_0;

		// Token: 0x04003264 RID: 12900
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandomConvMessage_Public_String_IEnumerable_1_String_0;

		// Token: 0x04003265 RID: 12901
		private static readonly IntPtr NativeMethodInfoPtr_GetSpellLanguage_Public_Il2CppReferenceArray_1_LanguageBase_0;

		// Token: 0x04003266 RID: 12902
		private static readonly IntPtr NativeMethodInfoPtr_GetDialogPackagesAtKizunaLevel_Public_Il2CppStringArray_Int32_0;

		// Token: 0x04003267 RID: 12903
		private static readonly IntPtr NativeMethodInfoPtr_GetWelcomeDialogPackagesAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_0;

		// Token: 0x04003268 RID: 12904
		private static readonly IntPtr NativeMethodInfoPtr_GetInviteDialogPackageAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_Boolean_0;

		// Token: 0x04003269 RID: 12905
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestIngerdientAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_0;

		// Token: 0x0400326A RID: 12906
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestBeverageAtKizunaLevel_Public_Il2CppReferenceArray_1_DialogPackage_Int32_0;

		// Token: 0x0400326B RID: 12907
		private static readonly IntPtr NativeMethodInfoPtr_GetCommisionDialogPackage_Public_Il2CppReferenceArray_1_DialogPackage_0;

		// Token: 0x0400326C RID: 12908
		private static readonly IntPtr NativeMethodInfoPtr_GetCommisionFinishDialogPackage_Public_Il2CppReferenceArray_1_DialogPackage_0;

		// Token: 0x0400326D RID: 12909
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400326E RID: 12910
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_SpecialGuest_Destination_String_0;

		// Token: 0x0400326F RID: 12911
		private static readonly IntPtr NativeMethodInfoPtr_LoadExtraDialogData_Public_UniTask_1_IAssetHandle_1_SpecialGuestExtraDialogData_0;

		// Token: 0x04003270 RID: 12912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Vector2Int_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_WeightedTag_Il2CppReferenceArray_1_WeightedTag_Prespective_Destination_String_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppReferenceArray_1_DialogPackage_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppReferenceArray_1_DialogPackage_Il2CppRefer;

		// Token: 0x04003271 RID: 12913
		private static readonly IntPtr NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_1_Private_Boolean_Izakaya_0;

		// Token: 0x04003272 RID: 12914
		private static readonly IntPtr NativeMethodInfoPtr__ShouldSpawnHere_b__88_0_Private_Boolean_SpecialGuestGroup_0;

		// Token: 0x02000AC7 RID: 2759
		public enum WorkSceneSpawnType
		{
			// Token: 0x040084A7 RID: 33959
			Specific,
			// Token: 0x040084A8 RID: 33960
			EveryWhere,
			// Token: 0x040084A9 RID: 33961
			NeverCome
		}

		// Token: 0x02000AC8 RID: 2760
		[Serializable]
		public class WeightedTag : Il2CppSystem.Object
		{
			// Token: 0x0600CE2B RID: 52779 RVA: 0x0032CD90 File Offset: 0x0032AF90
			// Note: this type is marked as 'beforefieldinit'.
			static WeightedTag()
			{
				Il2CppClassPointerStore<SpecialGuest.WeightedTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "WeightedTag");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuest.WeightedTag>.NativeClassPtr);
				SpecialGuest.WeightedTag.NativeFieldInfoPtr_tagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.WeightedTag>.NativeClassPtr, "tagId");
				SpecialGuest.WeightedTag.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.WeightedTag>.NativeClassPtr, "weight");
				SpecialGuest.WeightedTag.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.WeightedTag>.NativeClassPtr, 100677901);
			}

			// Token: 0x0600CE2C RID: 52780 RVA: 0x0032CDF8 File Offset: 0x0032AFF8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 150, RefRangeEnd = 154, XrefRangeStart = 150, XrefRangeEnd = 154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WeightedTag(int tagId, int weight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuest.WeightedTag>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref tagId;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.WeightedTag.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE2D RID: 52781 RVA: 0x0006E656 File Offset: 0x0006C856
			public WeightedTag(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004302 RID: 17154
			// (get) Token: 0x0600CE2E RID: 52782 RVA: 0x0032CE50 File Offset: 0x0032B050
			// (set) Token: 0x0600CE2F RID: 52783 RVA: 0x0006E65F File Offset: 0x0006C85F
			public unsafe int tagId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.WeightedTag.NativeFieldInfoPtr_tagId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.WeightedTag.NativeFieldInfoPtr_tagId)) = value;
				}
			}

			// Token: 0x17004303 RID: 17155
			// (get) Token: 0x0600CE30 RID: 52784 RVA: 0x0032CE78 File Offset: 0x0032B078
			// (set) Token: 0x0600CE31 RID: 52785 RVA: 0x0006E67A File Offset: 0x0006C87A
			public unsafe int weight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.WeightedTag.NativeFieldInfoPtr_weight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.WeightedTag.NativeFieldInfoPtr_weight)) = value;
				}
			}

			// Token: 0x040084AA RID: 33962
			private static readonly IntPtr NativeFieldInfoPtr_tagId;

			// Token: 0x040084AB RID: 33963
			private static readonly IntPtr NativeFieldInfoPtr_weight;

			// Token: 0x040084AC RID: 33964
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
		}

		// Token: 0x02000AC9 RID: 2761
		[Serializable]
		[StructLayout(2)]
		public struct Prespective
		{
			// Token: 0x0600CE32 RID: 52786 RVA: 0x0032CEA0 File Offset: 0x0032B0A0
			// Note: this type is marked as 'beforefieldinit'.
			static Prespective()
			{
				Il2CppClassPointerStore<SpecialGuest.Prespective>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "Prespective");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuest.Prespective>.NativeClassPtr);
				SpecialGuest.Prespective.NativeFieldInfoPtr_toPop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.Prespective>.NativeClassPtr, "toPop");
				SpecialGuest.Prespective.NativeFieldInfoPtr_toInfam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.Prespective>.NativeClassPtr, "toInfam");
				SpecialGuest.Prespective.NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.Prespective>.NativeClassPtr, 100677902);
				SpecialGuest.Prespective.NativeMethodInfoPtr_get_ToPopLike_Public_get_Respond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.Prespective>.NativeClassPtr, 100677903);
				SpecialGuest.Prespective.NativeMethodInfoPtr_get_ToPopHate_Public_get_Respond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.Prespective>.NativeClassPtr, 100677904);
			}

			// Token: 0x0600CE33 RID: 52787 RVA: 0x0032CF30 File Offset: 0x0032B130
			[CallerCount(0)]
			public unsafe Prespective(Vector2Int raw)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref raw;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.Prespective.NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004304 RID: 17156
			// (get) Token: 0x0600CE34 RID: 52788 RVA: 0x0032CF64 File Offset: 0x0032B164
			public unsafe SpecialGuest.Prespective.Respond ToPopLike
			{
				[CallerCount(140)]
				[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.Prespective.NativeMethodInfoPtr_get_ToPopLike_Public_get_Respond_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004305 RID: 17157
			// (get) Token: 0x0600CE35 RID: 52789 RVA: 0x0032CF94 File Offset: 0x0032B194
			public unsafe SpecialGuest.Prespective.Respond ToPopHate
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.Prespective.NativeMethodInfoPtr_get_ToPopHate_Public_get_Respond_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600CE36 RID: 52790 RVA: 0x0006E695 File Offset: 0x0006C895
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpecialGuest.Prespective>.NativeClassPtr, ref this));
			}

			// Token: 0x040084AD RID: 33965
			private static readonly IntPtr NativeFieldInfoPtr_toPop;

			// Token: 0x040084AE RID: 33966
			private static readonly IntPtr NativeFieldInfoPtr_toInfam;

			// Token: 0x040084AF RID: 33967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_0;

			// Token: 0x040084B0 RID: 33968
			private static readonly IntPtr NativeMethodInfoPtr_get_ToPopLike_Public_get_Respond_0;

			// Token: 0x040084B1 RID: 33969
			private static readonly IntPtr NativeMethodInfoPtr_get_ToPopHate_Public_get_Respond_0;

			// Token: 0x040084B2 RID: 33970
			[FieldOffset(0)]
			public SpecialGuest.Prespective.Respond toPop;

			// Token: 0x040084B3 RID: 33971
			[FieldOffset(4)]
			public SpecialGuest.Prespective.Respond toInfam;

			// Token: 0x02001018 RID: 4120
			public enum Respond
			{
				// Token: 0x0400B23F RID: 45631
				Negative,
				// Token: 0x0400B240 RID: 45632
				Neutral,
				// Token: 0x0400B241 RID: 45633
				Positive
			}
		}

		// Token: 0x02000ACA RID: 2762
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpecialGuest+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CE37 RID: 52791 RVA: 0x0032CFC4 File Offset: 0x0032B1C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr);
				SpecialGuest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9");
				SpecialGuest.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__34_0");
				SpecialGuest.__c.NativeFieldInfoPtr___9__36_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__36_0");
				SpecialGuest.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__38_0");
				SpecialGuest.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__40_0");
				SpecialGuest.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__42_0");
				SpecialGuest.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__46_0");
				SpecialGuest.__c.NativeFieldInfoPtr___9__87_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__87_0");
				SpecialGuest.__c.NativeFieldInfoPtr___9__87_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__87_2");
				SpecialGuest.__c.NativeFieldInfoPtr___9__87_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__87_3");
				SpecialGuest.__c.NativeFieldInfoPtr___9__87_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__87_5");
				SpecialGuest.__c.NativeFieldInfoPtr___9__92_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__92_0");
				SpecialGuest.__c.NativeFieldInfoPtr___9__105_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__105_0");
				SpecialGuest.__c.NativeFieldInfoPtr___9__105_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, "<>9__105_1");
				SpecialGuest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677906);
				SpecialGuest.__c.NativeMethodInfoPtr__get_LikeBevTagUnfolded_b__34_0_Internal_IEnumerable_1_Int32_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677907);
				SpecialGuest.__c.NativeMethodInfoPtr__get_LikeBevTag_b__36_0_Internal_Int32_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677908);
				SpecialGuest.__c.NativeMethodInfoPtr__get_LikeFoodTag_b__38_0_Internal_Int32_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677909);
				SpecialGuest.__c.NativeMethodInfoPtr__get_LikeFoodTagUnfolded_b__40_0_Internal_IEnumerable_1_Int32_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677910);
				SpecialGuest.__c.NativeMethodInfoPtr__get_LikeFoodTagOriginal_b__42_0_Internal_Int32_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677911);
				SpecialGuest.__c.NativeMethodInfoPtr__get_LikeBevTagOriginal_b__46_0_Internal_Int32_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677912);
				SpecialGuest.__c.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_0_Internal_Izakaya_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677913);
				SpecialGuest.__c.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_2_Internal_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677914);
				SpecialGuest.__c.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_3_Internal_Izakaya_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677915);
				SpecialGuest.__c.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_5_Internal_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677916);
				SpecialGuest.__c.NativeMethodInfoPtr__GetLikeTagWeighted_b__92_0_Internal_Int32_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677917);
				SpecialGuest.__c.NativeMethodInfoPtr__ToString_b__105_0_Internal_String_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677918);
				SpecialGuest.__c.NativeMethodInfoPtr__ToString_b__105_1_Internal_String_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr, 100677919);
			}

			// Token: 0x0600CE38 RID: 52792 RVA: 0x0032D220 File Offset: 0x0032B420
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE39 RID: 52793 RVA: 0x0032D25C File Offset: 0x0032B45C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190702, XrefRangeEnd = 190706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _get_LikeBevTagUnfolded_b__34_0(SpecialGuest.WeightedTag x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__get_LikeBevTagUnfolded_b__34_0_Internal_IEnumerable_1_Int32_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CE3A RID: 52794 RVA: 0x0032D2AC File Offset: 0x0032B4AC
			[CallerCount(0)]
			public unsafe int _get_LikeBevTag_b__36_0(SpecialGuest.WeightedTag x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__get_LikeBevTag_b__36_0_Internal_Int32_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE3B RID: 52795 RVA: 0x0032D2FC File Offset: 0x0032B4FC
			[CallerCount(0)]
			public unsafe int _get_LikeFoodTag_b__38_0(SpecialGuest.WeightedTag x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__get_LikeFoodTag_b__38_0_Internal_Int32_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE3C RID: 52796 RVA: 0x0032D34C File Offset: 0x0032B54C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190706, XrefRangeEnd = 190710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _get_LikeFoodTagUnfolded_b__40_0(SpecialGuest.WeightedTag x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__get_LikeFoodTagUnfolded_b__40_0_Internal_IEnumerable_1_Int32_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CE3D RID: 52797 RVA: 0x0032D39C File Offset: 0x0032B59C
			[CallerCount(0)]
			public unsafe int _get_LikeFoodTagOriginal_b__42_0(SpecialGuest.WeightedTag x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__get_LikeFoodTagOriginal_b__42_0_Internal_Int32_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE3E RID: 52798 RVA: 0x0032D3EC File Offset: 0x0032B5EC
			[CallerCount(0)]
			public unsafe int _get_LikeBevTagOriginal_b__46_0(SpecialGuest.WeightedTag x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__get_LikeBevTagOriginal_b__46_0_Internal_Int32_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE3F RID: 52799 RVA: 0x0032D43C File Offset: 0x0032B63C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190710, XrefRangeEnd = 190711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Izakaya _GetSpecialGuestSpawnInfo_b__87_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_0_Internal_Izakaya_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr3) : null;
			}

			// Token: 0x0600CE40 RID: 52800 RVA: 0x0032D488 File Offset: 0x0032B688
			[CallerCount(0)]
			public unsafe int _GetSpecialGuestSpawnInfo_b__87_2(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_2_Internal_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE41 RID: 52801 RVA: 0x0032D4D8 File Offset: 0x0032B6D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Izakaya _GetSpecialGuestSpawnInfo_b__87_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_3_Internal_Izakaya_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr3) : null;
			}

			// Token: 0x0600CE42 RID: 52802 RVA: 0x0032D524 File Offset: 0x0032B724
			[CallerCount(0)]
			public unsafe int _GetSpecialGuestSpawnInfo_b__87_5(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_5_Internal_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE43 RID: 52803 RVA: 0x0032D574 File Offset: 0x0032B774
			[CallerCount(0)]
			public unsafe int _GetLikeTagWeighted_b__92_0(SpecialGuest.WeightedTag x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__GetLikeTagWeighted_b__92_0_Internal_Int32_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE44 RID: 52804 RVA: 0x0032D5C4 File Offset: 0x0032B7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190711, XrefRangeEnd = 190717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__105_0(SpecialGuest.WeightedTag x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__ToString_b__105_0_Internal_String_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CE45 RID: 52805 RVA: 0x0032D60C File Offset: 0x0032B80C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190717, XrefRangeEnd = 190723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__105_1(SpecialGuest.WeightedTag x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c.NativeMethodInfoPtr__ToString_b__105_1_Internal_String_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CE46 RID: 52806 RVA: 0x0006E6A7 File Offset: 0x0006C8A7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004306 RID: 17158
			// (get) Token: 0x0600CE47 RID: 52807 RVA: 0x0032D654 File Offset: 0x0032B854
			// (set) Token: 0x0600CE48 RID: 52808 RVA: 0x0006E6B0 File Offset: 0x0006C8B0
			public unsafe static SpecialGuest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004307 RID: 17159
			// (get) Token: 0x0600CE49 RID: 52809 RVA: 0x0032D67C File Offset: 0x0032B87C
			// (set) Token: 0x0600CE4A RID: 52810 RVA: 0x0006E6C2 File Offset: 0x0006C8C2
			public unsafe static Func<SpecialGuest.WeightedTag, IEnumerable<int>> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004308 RID: 17160
			// (get) Token: 0x0600CE4B RID: 52811 RVA: 0x0032D6A4 File Offset: 0x0032B8A4
			// (set) Token: 0x0600CE4C RID: 52812 RVA: 0x0006E6D4 File Offset: 0x0006C8D4
			public unsafe static Func<SpecialGuest.WeightedTag, int> __9__36_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__36_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__36_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004309 RID: 17161
			// (get) Token: 0x0600CE4D RID: 52813 RVA: 0x0032D6CC File Offset: 0x0032B8CC
			// (set) Token: 0x0600CE4E RID: 52814 RVA: 0x0006E6E6 File Offset: 0x0006C8E6
			public unsafe static Func<SpecialGuest.WeightedTag, int> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430A RID: 17162
			// (get) Token: 0x0600CE4F RID: 52815 RVA: 0x0032D6F4 File Offset: 0x0032B8F4
			// (set) Token: 0x0600CE50 RID: 52816 RVA: 0x0006E6F8 File Offset: 0x0006C8F8
			public unsafe static Func<SpecialGuest.WeightedTag, IEnumerable<int>> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430B RID: 17163
			// (get) Token: 0x0600CE51 RID: 52817 RVA: 0x0032D71C File Offset: 0x0032B91C
			// (set) Token: 0x0600CE52 RID: 52818 RVA: 0x0006E70A File Offset: 0x0006C90A
			public unsafe static Func<SpecialGuest.WeightedTag, int> __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430C RID: 17164
			// (get) Token: 0x0600CE53 RID: 52819 RVA: 0x0032D744 File Offset: 0x0032B944
			// (set) Token: 0x0600CE54 RID: 52820 RVA: 0x0006E71C File Offset: 0x0006C91C
			public unsafe static Func<SpecialGuest.WeightedTag, int> __9__46_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__46_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430D RID: 17165
			// (get) Token: 0x0600CE55 RID: 52821 RVA: 0x0032D76C File Offset: 0x0032B96C
			// (set) Token: 0x0600CE56 RID: 52822 RVA: 0x0006E72E File Offset: 0x0006C92E
			public unsafe static Func<int, Izakaya> __9__87_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__87_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Izakaya>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__87_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430E RID: 17166
			// (get) Token: 0x0600CE57 RID: 52823 RVA: 0x0032D794 File Offset: 0x0032B994
			// (set) Token: 0x0600CE58 RID: 52824 RVA: 0x0006E740 File Offset: 0x0006C940
			public unsafe static Func<Izakaya, int> __9__87_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__87_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__87_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430F RID: 17167
			// (get) Token: 0x0600CE59 RID: 52825 RVA: 0x0032D7BC File Offset: 0x0032B9BC
			// (set) Token: 0x0600CE5A RID: 52826 RVA: 0x0006E752 File Offset: 0x0006C952
			public unsafe static Func<int, Izakaya> __9__87_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__87_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Izakaya>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__87_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004310 RID: 17168
			// (get) Token: 0x0600CE5B RID: 52827 RVA: 0x0032D7E4 File Offset: 0x0032B9E4
			// (set) Token: 0x0600CE5C RID: 52828 RVA: 0x0006E764 File Offset: 0x0006C964
			public unsafe static Func<Izakaya, int> __9__87_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__87_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__87_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004311 RID: 17169
			// (get) Token: 0x0600CE5D RID: 52829 RVA: 0x0032D80C File Offset: 0x0032BA0C
			// (set) Token: 0x0600CE5E RID: 52830 RVA: 0x0006E776 File Offset: 0x0006C976
			public unsafe static Func<SpecialGuest.WeightedTag, int> __9__92_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__92_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__92_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004312 RID: 17170
			// (get) Token: 0x0600CE5F RID: 52831 RVA: 0x0032D834 File Offset: 0x0032BA34
			// (set) Token: 0x0600CE60 RID: 52832 RVA: 0x0006E788 File Offset: 0x0006C988
			public unsafe static Func<SpecialGuest.WeightedTag, string> __9__105_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__105_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__105_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004313 RID: 17171
			// (get) Token: 0x0600CE61 RID: 52833 RVA: 0x0032D85C File Offset: 0x0032BA5C
			// (set) Token: 0x0600CE62 RID: 52834 RVA: 0x0006E79A File Offset: 0x0006C99A
			public unsafe static Func<SpecialGuest.WeightedTag, string> __9__105_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuest.__c.NativeFieldInfoPtr___9__105_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuest.__c.NativeFieldInfoPtr___9__105_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084B4 RID: 33972
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084B5 RID: 33973
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x040084B6 RID: 33974
			private static readonly IntPtr NativeFieldInfoPtr___9__36_0;

			// Token: 0x040084B7 RID: 33975
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x040084B8 RID: 33976
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x040084B9 RID: 33977
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x040084BA RID: 33978
			private static readonly IntPtr NativeFieldInfoPtr___9__46_0;

			// Token: 0x040084BB RID: 33979
			private static readonly IntPtr NativeFieldInfoPtr___9__87_0;

			// Token: 0x040084BC RID: 33980
			private static readonly IntPtr NativeFieldInfoPtr___9__87_2;

			// Token: 0x040084BD RID: 33981
			private static readonly IntPtr NativeFieldInfoPtr___9__87_3;

			// Token: 0x040084BE RID: 33982
			private static readonly IntPtr NativeFieldInfoPtr___9__87_5;

			// Token: 0x040084BF RID: 33983
			private static readonly IntPtr NativeFieldInfoPtr___9__92_0;

			// Token: 0x040084C0 RID: 33984
			private static readonly IntPtr NativeFieldInfoPtr___9__105_0;

			// Token: 0x040084C1 RID: 33985
			private static readonly IntPtr NativeFieldInfoPtr___9__105_1;

			// Token: 0x040084C2 RID: 33986
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084C3 RID: 33987
			private static readonly IntPtr NativeMethodInfoPtr__get_LikeBevTagUnfolded_b__34_0_Internal_IEnumerable_1_Int32_WeightedTag_0;

			// Token: 0x040084C4 RID: 33988
			private static readonly IntPtr NativeMethodInfoPtr__get_LikeBevTag_b__36_0_Internal_Int32_WeightedTag_0;

			// Token: 0x040084C5 RID: 33989
			private static readonly IntPtr NativeMethodInfoPtr__get_LikeFoodTag_b__38_0_Internal_Int32_WeightedTag_0;

			// Token: 0x040084C6 RID: 33990
			private static readonly IntPtr NativeMethodInfoPtr__get_LikeFoodTagUnfolded_b__40_0_Internal_IEnumerable_1_Int32_WeightedTag_0;

			// Token: 0x040084C7 RID: 33991
			private static readonly IntPtr NativeMethodInfoPtr__get_LikeFoodTagOriginal_b__42_0_Internal_Int32_WeightedTag_0;

			// Token: 0x040084C8 RID: 33992
			private static readonly IntPtr NativeMethodInfoPtr__get_LikeBevTagOriginal_b__46_0_Internal_Int32_WeightedTag_0;

			// Token: 0x040084C9 RID: 33993
			private static readonly IntPtr NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_0_Internal_Izakaya_Int32_0;

			// Token: 0x040084CA RID: 33994
			private static readonly IntPtr NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_2_Internal_Int32_Izakaya_0;

			// Token: 0x040084CB RID: 33995
			private static readonly IntPtr NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_3_Internal_Izakaya_Int32_0;

			// Token: 0x040084CC RID: 33996
			private static readonly IntPtr NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__87_5_Internal_Int32_Izakaya_0;

			// Token: 0x040084CD RID: 33997
			private static readonly IntPtr NativeMethodInfoPtr__GetLikeTagWeighted_b__92_0_Internal_Int32_WeightedTag_0;

			// Token: 0x040084CE RID: 33998
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__105_0_Internal_String_WeightedTag_0;

			// Token: 0x040084CF RID: 33999
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__105_1_Internal_String_WeightedTag_0;
		}

		// Token: 0x02000ACB RID: 2763
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpecialGuest+<>c__DisplayClass87_0")]
		public sealed class __c__DisplayClass87_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE63 RID: 52835 RVA: 0x0032D884 File Offset: 0x0032BA84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass87_0()
			{
				Il2CppClassPointerStore<SpecialGuest.__c__DisplayClass87_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuest>.NativeClassPtr, "<>c__DisplayClass87_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuest.__c__DisplayClass87_0>.NativeClassPtr);
				SpecialGuest.__c__DisplayClass87_0.NativeFieldInfoPtr_hashSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c__DisplayClass87_0>.NativeClassPtr, "hashSet");
				SpecialGuest.__c__DisplayClass87_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuest.__c__DisplayClass87_0>.NativeClassPtr, "<>4__this");
				SpecialGuest.__c__DisplayClass87_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c__DisplayClass87_0>.NativeClassPtr, 100677920);
				SpecialGuest.__c__DisplayClass87_0.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__4_Internal_Boolean_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuest.__c__DisplayClass87_0>.NativeClassPtr, 100677921);
			}

			// Token: 0x0600CE64 RID: 52836 RVA: 0x0032D900 File Offset: 0x0032BB00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass87_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuest.__c__DisplayClass87_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c__DisplayClass87_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE65 RID: 52837 RVA: 0x0032D93C File Offset: 0x0032BB3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190723, XrefRangeEnd = 190726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSpecialGuestSpawnInfo_b__4(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuest.__c__DisplayClass87_0.NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__4_Internal_Boolean_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE66 RID: 52838 RVA: 0x0006E7AC File Offset: 0x0006C9AC
			public __c__DisplayClass87_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004314 RID: 17172
			// (get) Token: 0x0600CE67 RID: 52839 RVA: 0x0032D98C File Offset: 0x0032BB8C
			// (set) Token: 0x0600CE68 RID: 52840 RVA: 0x0006E7B5 File Offset: 0x0006C9B5
			public unsafe HashSet<string> hashSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.__c__DisplayClass87_0.NativeFieldInfoPtr_hashSet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.__c__DisplayClass87_0.NativeFieldInfoPtr_hashSet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004315 RID: 17173
			// (get) Token: 0x0600CE69 RID: 52841 RVA: 0x0032D9BC File Offset: 0x0032BBBC
			// (set) Token: 0x0600CE6A RID: 52842 RVA: 0x0006E7D4 File Offset: 0x0006C9D4
			public unsafe SpecialGuest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.__c__DisplayClass87_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuest.__c__DisplayClass87_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084D0 RID: 34000
			private static readonly IntPtr NativeFieldInfoPtr_hashSet;

			// Token: 0x040084D1 RID: 34001
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040084D2 RID: 34002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084D3 RID: 34003
			private static readonly IntPtr NativeMethodInfoPtr__GetSpecialGuestSpawnInfo_b__4_Internal_Boolean_Izakaya_0;
		}
	}
}
