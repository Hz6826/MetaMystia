using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.CharacterUtility
{
	// Token: 0x020002C0 RID: 704
	public static class DataBaseCharacter : Il2CppSystem.Object
	{
		// Token: 0x06005767 RID: 22375 RVA: 0x001C52C8 File Offset: 0x001C34C8
		// Note: this type is marked as 'beforefieldinit'.
		static DataBaseCharacter()
		{
			Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.CharacterUtility", "DataBaseCharacter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr);
			DataBaseCharacter.NativeFieldInfoPtr_m_ClothesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "m_ClothesData");
			DataBaseCharacter.NativeFieldInfoPtr_m_PlayerActiveSkinPortrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "m_PlayerActiveSkinPortrayal");
			DataBaseCharacter.NativeFieldInfoPtr_m_PlayerActiveAnimatedSkinPortrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "m_PlayerActiveAnimatedSkinPortrayal");
			DataBaseCharacter.NativeFieldInfoPtr__NormalGuestVisual_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<NormalGuestVisual>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestVisual_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<SpecialGuestVisual>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__DaySceneNormalGuestVisual_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<DaySceneNormalGuestVisual>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__NormalGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<NormalGuest>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__SpecialGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<SpecialGuest>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__MappedSpecialGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<MappedSpecialGuest>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__BufferedMappedSpecialGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<BufferedMappedSpecialGuest>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__PartnerInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<PartnerInfo>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__StringMappingData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<StringMappingData>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__InvStringMappingData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<InvStringMappingData>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestMappingRules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<SpecialGuestMappingRules>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__UnifiedNormalGuestBGColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<UnifiedNormalGuestBGColor>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__UnifiedNormalGuestTextColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<UnifiedNormalGuestTextColor>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__NormalGuestVisualMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<NormalGuestVisualMapping>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestVisualMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<SpecialGuestVisualMapping>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__DaySceneNormalGuestVisualMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<DaySceneNormalGuestVisualMapping>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__NormalGuestMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<NormalGuestMapping>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<SpecialGuestMapping>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__PartnerInfoMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<PartnerInfoMapping>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__MappedSpecialGuestMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<MappedSpecialGuestMapping>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__FallbackSpecialGuestVisual_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<FallbackSpecialGuestVisual>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__FallbackPortrayal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<FallbackPortrayal>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__FallbackFullPixel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<FallbackFullPixel>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__FallbackCompactPixel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<FallbackCompactPixel>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__SelfSpriteSet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<SelfSpriteSet>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__SelfPortrayalSet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<SelfPortrayalSet>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__FaceMatrix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<FaceMatrix>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__MovingMatrix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<MovingMatrix>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__RotatingMatrix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<RotatingMatrix>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__CharacterBase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<CharacterBase>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__CharacterMouth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<CharacterMouth>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__CharacterSFX_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<CharacterSFX>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__CharacterPFX_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<CharacterPFX>k__BackingField");
			DataBaseCharacter.NativeFieldInfoPtr__CharacterHasSpell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<CharacterHasSpell>k__BackingField");
			DataBaseCharacter.NativeMethodInfoPtr_get_NormalGuestVisual_Private_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681060);
			DataBaseCharacter.NativeMethodInfoPtr_set_NormalGuestVisual_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681061);
			DataBaseCharacter.NativeMethodInfoPtr_get_SpecialGuestVisual_Private_Static_get_Dictionary_2_Int32_GuestProfilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681062);
			DataBaseCharacter.NativeMethodInfoPtr_set_SpecialGuestVisual_Private_Static_set_Void_Dictionary_2_Int32_GuestProfilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681063);
			DataBaseCharacter.NativeMethodInfoPtr_get_DaySceneNormalGuestVisual_Private_Static_get_Dictionary_2_Int32_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681064);
			DataBaseCharacter.NativeMethodInfoPtr_set_DaySceneNormalGuestVisual_Private_Static_set_Void_Dictionary_2_Int32_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681065);
			DataBaseCharacter.NativeMethodInfoPtr_get_NormalGuest_Private_Static_get_Dictionary_2_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681066);
			DataBaseCharacter.NativeMethodInfoPtr_set_NormalGuest_Private_Static_set_Void_Dictionary_2_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681067);
			DataBaseCharacter.NativeMethodInfoPtr_get_SpecialGuest_Private_Static_get_Dictionary_2_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681068);
			DataBaseCharacter.NativeMethodInfoPtr_set_SpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681069);
			DataBaseCharacter.NativeMethodInfoPtr_get_MappedSpecialGuest_Private_Static_get_Dictionary_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681070);
			DataBaseCharacter.NativeMethodInfoPtr_set_MappedSpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681071);
			DataBaseCharacter.NativeMethodInfoPtr_get_BufferedMappedSpecialGuest_Private_Static_get_Dictionary_2_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681072);
			DataBaseCharacter.NativeMethodInfoPtr_set_BufferedMappedSpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681073);
			DataBaseCharacter.NativeMethodInfoPtr_get_PartnerInfo_Private_Static_get_Dictionary_2_Int32_PartnerInfoBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681074);
			DataBaseCharacter.NativeMethodInfoPtr_set_PartnerInfo_Private_Static_set_Void_Dictionary_2_Int32_PartnerInfoBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681075);
			DataBaseCharacter.NativeMethodInfoPtr_get_StringMappingData_Private_Static_get_Dictionary_2_String_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681076);
			DataBaseCharacter.NativeMethodInfoPtr_set_StringMappingData_Private_Static_set_Void_Dictionary_2_String_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681077);
			DataBaseCharacter.NativeMethodInfoPtr_get_InvStringMappingData_Private_Static_get_Dictionary_2_Character_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681078);
			DataBaseCharacter.NativeMethodInfoPtr_set_InvStringMappingData_Private_Static_set_Void_Dictionary_2_Character_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681079);
			DataBaseCharacter.NativeMethodInfoPtr_get_SpecialGuestMappingRules_Private_Static_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681080);
			DataBaseCharacter.NativeMethodInfoPtr_set_SpecialGuestMappingRules_Private_Static_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681081);
			DataBaseCharacter.NativeMethodInfoPtr_get_UnifiedNormalGuestBGColor_Private_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681082);
			DataBaseCharacter.NativeMethodInfoPtr_set_UnifiedNormalGuestBGColor_Private_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681083);
			DataBaseCharacter.NativeMethodInfoPtr_get_UnifiedNormalGuestTextColor_Private_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681084);
			DataBaseCharacter.NativeMethodInfoPtr_set_UnifiedNormalGuestTextColor_Private_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681085);
			DataBaseCharacter.NativeMethodInfoPtr_get_NormalGuestVisualMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681086);
			DataBaseCharacter.NativeMethodInfoPtr_set_NormalGuestVisualMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681087);
			DataBaseCharacter.NativeMethodInfoPtr_get_SpecialGuestVisualMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681088);
			DataBaseCharacter.NativeMethodInfoPtr_set_SpecialGuestVisualMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681089);
			DataBaseCharacter.NativeMethodInfoPtr_get_DaySceneNormalGuestVisualMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681090);
			DataBaseCharacter.NativeMethodInfoPtr_set_DaySceneNormalGuestVisualMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681091);
			DataBaseCharacter.NativeMethodInfoPtr_get_NormalGuestMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681092);
			DataBaseCharacter.NativeMethodInfoPtr_set_NormalGuestMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681093);
			DataBaseCharacter.NativeMethodInfoPtr_get_SpecialGuestMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681094);
			DataBaseCharacter.NativeMethodInfoPtr_set_SpecialGuestMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681095);
			DataBaseCharacter.NativeMethodInfoPtr_get_PartnerInfoMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681096);
			DataBaseCharacter.NativeMethodInfoPtr_set_PartnerInfoMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681097);
			DataBaseCharacter.NativeMethodInfoPtr_get_MappedSpecialGuestMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681098);
			DataBaseCharacter.NativeMethodInfoPtr_set_MappedSpecialGuestMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681099);
			DataBaseCharacter.NativeMethodInfoPtr_get_FallbackSpecialGuestVisual_Public_Static_get_GuestProfilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681100);
			DataBaseCharacter.NativeMethodInfoPtr_set_FallbackSpecialGuestVisual_Private_Static_set_Void_GuestProfilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681101);
			DataBaseCharacter.NativeMethodInfoPtr_get_FallbackPortrayal_Public_Static_get_CharacterPortrayal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681102);
			DataBaseCharacter.NativeMethodInfoPtr_set_FallbackPortrayal_Private_Static_set_Void_CharacterPortrayal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681103);
			DataBaseCharacter.NativeMethodInfoPtr_get_FallbackFullPixel_Public_Static_get_CharacterSpriteSetFull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681104);
			DataBaseCharacter.NativeMethodInfoPtr_set_FallbackFullPixel_Private_Static_set_Void_CharacterSpriteSetFull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681105);
			DataBaseCharacter.NativeMethodInfoPtr_get_FallbackCompactPixel_Public_Static_get_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681106);
			DataBaseCharacter.NativeMethodInfoPtr_set_FallbackCompactPixel_Private_Static_set_Void_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681107);
			DataBaseCharacter.NativeMethodInfoPtr_get_SelfSpriteSet_Public_Static_get_CharacterSkinSets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681108);
			DataBaseCharacter.NativeMethodInfoPtr_set_SelfSpriteSet_Private_Static_set_Void_CharacterSkinSets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681109);
			DataBaseCharacter.NativeMethodInfoPtr_get_SelfPortrayalSet_Public_Static_get_CharacterProtrayalSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681110);
			DataBaseCharacter.NativeMethodInfoPtr_set_SelfPortrayalSet_Private_Static_set_Void_CharacterProtrayalSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681111);
			DataBaseCharacter.NativeMethodInfoPtr_get_FaceMatrix_Public_Static_get_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681112);
			DataBaseCharacter.NativeMethodInfoPtr_get_MovingMatrix_Public_Static_get_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681113);
			DataBaseCharacter.NativeMethodInfoPtr_get_RotatingMatrix_Public_Static_get_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681114);
			DataBaseCharacter.NativeMethodInfoPtr_get_CharacterBase_Public_Static_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681115);
			DataBaseCharacter.NativeMethodInfoPtr_set_CharacterBase_Private_Static_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681116);
			DataBaseCharacter.NativeMethodInfoPtr_get_CharacterMouth_Public_Static_get_List_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681117);
			DataBaseCharacter.NativeMethodInfoPtr_get_CharacterSFX_Public_Static_get_Dictionary_2_Int32_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681118);
			DataBaseCharacter.NativeMethodInfoPtr_get_CharacterPFX_Public_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681119);
			DataBaseCharacter.NativeMethodInfoPtr_get_CharacterHasSpell_Public_Static_get_Dictionary_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681120);
			DataBaseCharacter.NativeMethodInfoPtr_set_CharacterHasSpell_Private_Static_set_Void_Dictionary_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681121);
			DataBaseCharacter.NativeMethodInfoPtr_GetNormalGuestVisualDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681122);
			DataBaseCharacter.NativeMethodInfoPtr_GetSpecialGuestVisualDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681123);
			DataBaseCharacter.NativeMethodInfoPtr_GetDaySceneNormalGuestVisualDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681124);
			DataBaseCharacter.NativeMethodInfoPtr_GetNormalGuestDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681125);
			DataBaseCharacter.NativeMethodInfoPtr_GetSpecialGuestDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681126);
			DataBaseCharacter.NativeMethodInfoPtr_GetPartnerInfoDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681127);
			DataBaseCharacter.NativeMethodInfoPtr_GetMappedSpecialGuestDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681128);
			DataBaseCharacter.NativeMethodInfoPtr_LoadActivePlayerSkinAsync_Public_Static_UniTask_Clothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681129);
			DataBaseCharacter.NativeMethodInfoPtr_UnloadActivePlayerSkin_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681130);
			DataBaseCharacter.NativeMethodInfoPtr_SetupPortrayalVisual_Public_Static_Boolean_Image_MonoBehaviour_byref_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681131);
			DataBaseCharacter.NativeMethodInfoPtr_Initialize_Public_Static_Void_GameObject_CharacterPortrayal_CharacterSpriteSetFull_CharacterSpriteSetCompact_CharacterProtrayalSet_CharacterSkinSets_Color_Color_Dictionary_2_String_Character_Dictionary_2_String_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681132);
			DataBaseCharacter.NativeMethodInfoPtr_PopulateNullValues_Private_Static_GuestProfilePair_GuestProfilePair_GuestProfilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681133);
			DataBaseCharacter.NativeMethodInfoPtr_PopulateNullValues_Private_Static_Il2CppReferenceArray_1_CharacterSpriteSetCompact_Il2CppReferenceArray_1_CharacterSpriteSetCompact_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681134);
			DataBaseCharacter.NativeMethodInfoPtr_NormalGuestExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681135);
			DataBaseCharacter.NativeMethodInfoPtr_RefNGuest_Public_Static_NormalGuest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681136);
			DataBaseCharacter.NativeMethodInfoPtr_IsSpecialGuestMapped_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681137);
			DataBaseCharacter.NativeMethodInfoPtr_RefSGuest_Public_Static_SpecialGuest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681138);
			DataBaseCharacter.NativeMethodInfoPtr_RefSGuest_Public_Static_SpecialGuest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681139);
			DataBaseCharacter.NativeMethodInfoPtr_MappedID2TargetID_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681140);
			DataBaseCharacter.NativeMethodInfoPtr_GetAllNormalGuests_Public_Static_Il2CppReferenceArray_1_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681141);
			DataBaseCharacter.NativeMethodInfoPtr_GetAllSpecialGuests_Public_Static_Il2CppReferenceArray_1_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681142);
			DataBaseCharacter.NativeMethodInfoPtr_SpecialGuestExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681143);
			DataBaseCharacter.NativeMethodInfoPtr_GetAllMappedGuests_Public_Static_Il2CppReferenceArray_1_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681144);
			DataBaseCharacter.NativeMethodInfoPtr_PreinitSpecialGuests_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681145);
			DataBaseCharacter.NativeMethodInfoPtr_GetSpecialGuestsAndMappedGuests_Public_Static_Il2CppReferenceArray_1_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681146);
			DataBaseCharacter.NativeMethodInfoPtr_GetMappedSpecialGuests_Public_Static_Dictionary_2_String_Il2CppReferenceArray_1_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681147);
			DataBaseCharacter.NativeMethodInfoPtr_RefPartnerInfo_Public_Static_PartnerInfoBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681148);
			DataBaseCharacter.NativeMethodInfoPtr_CheckIdIsPartner_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681149);
			DataBaseCharacter.NativeMethodInfoPtr_CheckIdIsBossPartner_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681150);
			DataBaseCharacter.NativeMethodInfoPtr_GetAllValidPartnerIndex_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681151);
			DataBaseCharacter.NativeMethodInfoPtr_AsCharacterSpriteSet_Public_Static_Il2CppReferenceArray_1_Sprite_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681152);
			DataBaseCharacter.NativeMethodInfoPtr_RefNormalGuestVisual_Public_Static_GuestProfilePair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681153);
			DataBaseCharacter.NativeMethodInfoPtr_RefDaySceneNormalGuestVisual_Public_Static_CharacterSpriteSetCompact_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681154);
			DataBaseCharacter.NativeMethodInfoPtr_RefSpecialGuestVisual_Public_Static_GuestProfilePair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681155);
			DataBaseCharacter.NativeMethodInfoPtr_RefNPCIdentity_Public_Static_Character_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681156);
			DataBaseCharacter.NativeMethodInfoPtr_GetNPCLabel_Public_Static_String_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681157);
			DataBaseCharacter.NativeMethodInfoPtr_RefNPCVisual_Public_Static_CharacterSpriteSetCompact_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681158);
			DataBaseCharacter.NativeMethodInfoPtr_CheckCharacterHasSpell_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681159);
			DataBaseCharacter.NativeMethodInfoPtr_GetAllOriginSGuestMapping_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681160);
			DataBaseCharacter.NativeMethodInfoPtr_TryGetTargetSGuestMapping_Public_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681161);
			DataBaseCharacter.NativeMethodInfoPtr_TryGetOriginalSGuestFromMapping_Public_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, 100681162);
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x06005768 RID: 22376 RVA: 0x001C5DE8 File Offset: 0x001C3FE8
		// (set) Token: 0x06005769 RID: 22377 RVA: 0x001C5E1C File Offset: 0x001C401C
		public unsafe static Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>> NormalGuestVisual
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216574, XrefRangeEnd = 216578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_NormalGuestVisual_Private_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216578, XrefRangeEnd = 216584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_NormalGuestVisual_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x0600576A RID: 22378 RVA: 0x001C5E54 File Offset: 0x001C4054
		// (set) Token: 0x0600576B RID: 22379 RVA: 0x001C5E88 File Offset: 0x001C4088
		public unsafe static Dictionary<int, GuestProfilePair> SpecialGuestVisual
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216584, XrefRangeEnd = 216588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_SpecialGuestVisual_Private_Static_get_Dictionary_2_Int32_GuestProfilePair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestProfilePair>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216588, XrefRangeEnd = 216594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_SpecialGuestVisual_Private_Static_set_Void_Dictionary_2_Int32_GuestProfilePair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x0600576C RID: 22380 RVA: 0x001C5EC0 File Offset: 0x001C40C0
		// (set) Token: 0x0600576D RID: 22381 RVA: 0x001C5EF4 File Offset: 0x001C40F4
		public unsafe static Dictionary<int, CharacterSpriteSetCompact> DaySceneNormalGuestVisual
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216594, XrefRangeEnd = 216598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_DaySceneNormalGuestVisual_Private_Static_get_Dictionary_2_Int32_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, CharacterSpriteSetCompact>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216598, XrefRangeEnd = 216604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_DaySceneNormalGuestVisual_Private_Static_set_Void_Dictionary_2_Int32_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x0600576E RID: 22382 RVA: 0x001C5F2C File Offset: 0x001C412C
		// (set) Token: 0x0600576F RID: 22383 RVA: 0x001C5F60 File Offset: 0x001C4160
		public unsafe static Dictionary<int, NormalGuest> NormalGuest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216604, XrefRangeEnd = 216608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_NormalGuest_Private_Static_get_Dictionary_2_Int32_NormalGuest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, NormalGuest>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216608, XrefRangeEnd = 216614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_NormalGuest_Private_Static_set_Void_Dictionary_2_Int32_NormalGuest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x06005770 RID: 22384 RVA: 0x001C5F98 File Offset: 0x001C4198
		// (set) Token: 0x06005771 RID: 22385 RVA: 0x001C5FCC File Offset: 0x001C41CC
		public unsafe static Dictionary<int, SpecialGuest> SpecialGuest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216614, XrefRangeEnd = 216618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_SpecialGuest_Private_Static_get_Dictionary_2_Int32_SpecialGuest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SpecialGuest>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216618, XrefRangeEnd = 216624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_SpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_SpecialGuest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x06005772 RID: 22386 RVA: 0x001C6004 File Offset: 0x001C4204
		// (set) Token: 0x06005773 RID: 22387 RVA: 0x001C6038 File Offset: 0x001C4238
		public unsafe static Dictionary<int, MappedSpecialGuest> MappedSpecialGuest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216624, XrefRangeEnd = 216628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_MappedSpecialGuest_Private_Static_get_Dictionary_2_Int32_MappedSpecialGuest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MappedSpecialGuest>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216628, XrefRangeEnd = 216634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_MappedSpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_MappedSpecialGuest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x06005774 RID: 22388 RVA: 0x001C6070 File Offset: 0x001C4270
		// (set) Token: 0x06005775 RID: 22389 RVA: 0x001C60A4 File Offset: 0x001C42A4
		public unsafe static Dictionary<int, SpecialGuest> BufferedMappedSpecialGuest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216634, XrefRangeEnd = 216638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_BufferedMappedSpecialGuest_Private_Static_get_Dictionary_2_Int32_SpecialGuest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SpecialGuest>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216638, XrefRangeEnd = 216644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_BufferedMappedSpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_SpecialGuest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06005776 RID: 22390 RVA: 0x001C60DC File Offset: 0x001C42DC
		// (set) Token: 0x06005777 RID: 22391 RVA: 0x001C6110 File Offset: 0x001C4310
		public unsafe static Dictionary<int, PartnerInfoBase> PartnerInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216644, XrefRangeEnd = 216648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_PartnerInfo_Private_Static_get_Dictionary_2_Int32_PartnerInfoBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PartnerInfoBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216648, XrefRangeEnd = 216654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_PartnerInfo_Private_Static_set_Void_Dictionary_2_Int32_PartnerInfoBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x001C6148 File Offset: 0x001C4348
		// (set) Token: 0x06005779 RID: 22393 RVA: 0x001C617C File Offset: 0x001C437C
		public unsafe static Dictionary<string, SchedulerNode.Character> StringMappingData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216654, XrefRangeEnd = 216658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_StringMappingData_Private_Static_get_Dictionary_2_String_Character_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchedulerNode.Character>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216658, XrefRangeEnd = 216664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_StringMappingData_Private_Static_set_Void_Dictionary_2_String_Character_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x001C61B4 File Offset: 0x001C43B4
		// (set) Token: 0x0600577B RID: 22395 RVA: 0x001C61E8 File Offset: 0x001C43E8
		public unsafe static Dictionary<SchedulerNode.Character, Il2CppStringArray> InvStringMappingData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216664, XrefRangeEnd = 216668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_InvStringMappingData_Private_Static_get_Dictionary_2_Character_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<SchedulerNode.Character, Il2CppStringArray>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216668, XrefRangeEnd = 216674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_InvStringMappingData_Private_Static_set_Void_Dictionary_2_Character_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x0600577C RID: 22396 RVA: 0x001C6220 File Offset: 0x001C4420
		// (set) Token: 0x0600577D RID: 22397 RVA: 0x001C6254 File Offset: 0x001C4454
		public unsafe static Dictionary<int, int> SpecialGuestMappingRules
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216674, XrefRangeEnd = 216678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_SpecialGuestMappingRules_Private_Static_get_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216678, XrefRangeEnd = 216684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_SpecialGuestMappingRules_Private_Static_set_Void_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x0600577E RID: 22398 RVA: 0x001C628C File Offset: 0x001C448C
		// (set) Token: 0x0600577F RID: 22399 RVA: 0x001C62BC File Offset: 0x001C44BC
		public unsafe static Color UnifiedNormalGuestBGColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216684, XrefRangeEnd = 216688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_UnifiedNormalGuestBGColor_Private_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216688, XrefRangeEnd = 216692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_UnifiedNormalGuestBGColor_Private_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x06005780 RID: 22400 RVA: 0x001C62F0 File Offset: 0x001C44F0
		// (set) Token: 0x06005781 RID: 22401 RVA: 0x001C6320 File Offset: 0x001C4520
		public unsafe static Color UnifiedNormalGuestTextColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216692, XrefRangeEnd = 216696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_UnifiedNormalGuestTextColor_Private_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216696, XrefRangeEnd = 216700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_UnifiedNormalGuestTextColor_Private_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06005782 RID: 22402 RVA: 0x001C6354 File Offset: 0x001C4554
		// (set) Token: 0x06005783 RID: 22403 RVA: 0x001C6388 File Offset: 0x001C4588
		public unsafe static Dictionary<int, string> NormalGuestVisualMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216700, XrefRangeEnd = 216704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_NormalGuestVisualMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216704, XrefRangeEnd = 216710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_NormalGuestVisualMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06005784 RID: 22404 RVA: 0x001C63C0 File Offset: 0x001C45C0
		// (set) Token: 0x06005785 RID: 22405 RVA: 0x001C63F4 File Offset: 0x001C45F4
		public unsafe static Dictionary<int, string> SpecialGuestVisualMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216710, XrefRangeEnd = 216714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_SpecialGuestVisualMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216714, XrefRangeEnd = 216720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_SpecialGuestVisualMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x06005786 RID: 22406 RVA: 0x001C642C File Offset: 0x001C462C
		// (set) Token: 0x06005787 RID: 22407 RVA: 0x001C6460 File Offset: 0x001C4660
		public unsafe static Dictionary<int, string> DaySceneNormalGuestVisualMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216720, XrefRangeEnd = 216724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_DaySceneNormalGuestVisualMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216724, XrefRangeEnd = 216730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_DaySceneNormalGuestVisualMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x06005788 RID: 22408 RVA: 0x001C6498 File Offset: 0x001C4698
		// (set) Token: 0x06005789 RID: 22409 RVA: 0x001C64CC File Offset: 0x001C46CC
		public unsafe static Dictionary<int, string> NormalGuestMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216730, XrefRangeEnd = 216734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_NormalGuestMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216734, XrefRangeEnd = 216740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_NormalGuestMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x0600578A RID: 22410 RVA: 0x001C6504 File Offset: 0x001C4704
		// (set) Token: 0x0600578B RID: 22411 RVA: 0x001C6538 File Offset: 0x001C4738
		public unsafe static Dictionary<int, string> SpecialGuestMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216740, XrefRangeEnd = 216744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_SpecialGuestMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216744, XrefRangeEnd = 216750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_SpecialGuestMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x0600578C RID: 22412 RVA: 0x001C6570 File Offset: 0x001C4770
		// (set) Token: 0x0600578D RID: 22413 RVA: 0x001C65A4 File Offset: 0x001C47A4
		public unsafe static Dictionary<int, string> PartnerInfoMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216750, XrefRangeEnd = 216754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_PartnerInfoMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216754, XrefRangeEnd = 216760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_PartnerInfoMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x0600578E RID: 22414 RVA: 0x001C65DC File Offset: 0x001C47DC
		// (set) Token: 0x0600578F RID: 22415 RVA: 0x001C6610 File Offset: 0x001C4810
		public unsafe static Dictionary<int, string> MappedSpecialGuestMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216760, XrefRangeEnd = 216764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_MappedSpecialGuestMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216764, XrefRangeEnd = 216770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_MappedSpecialGuestMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06005790 RID: 22416 RVA: 0x001C6648 File Offset: 0x001C4848
		// (set) Token: 0x06005791 RID: 22417 RVA: 0x001C667C File Offset: 0x001C487C
		public unsafe static GuestProfilePair FallbackSpecialGuestVisual
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216770, XrefRangeEnd = 216774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_FallbackSpecialGuestVisual_Public_Static_get_GuestProfilePair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestProfilePair>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216774, XrefRangeEnd = 216780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_FallbackSpecialGuestVisual_Private_Static_set_Void_GuestProfilePair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x06005792 RID: 22418 RVA: 0x001C66B4 File Offset: 0x001C48B4
		// (set) Token: 0x06005793 RID: 22419 RVA: 0x001C66E8 File Offset: 0x001C48E8
		public unsafe static CharacterPortrayal FallbackPortrayal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216780, XrefRangeEnd = 216784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_FallbackPortrayal_Public_Static_get_CharacterPortrayal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216784, XrefRangeEnd = 216790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_FallbackPortrayal_Private_Static_set_Void_CharacterPortrayal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x06005794 RID: 22420 RVA: 0x001C6720 File Offset: 0x001C4920
		// (set) Token: 0x06005795 RID: 22421 RVA: 0x001C6754 File Offset: 0x001C4954
		public unsafe static CharacterSpriteSetFull FallbackFullPixel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216790, XrefRangeEnd = 216794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_FallbackFullPixel_Public_Static_get_CharacterSpriteSetFull_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetFull>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216794, XrefRangeEnd = 216800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_FallbackFullPixel_Private_Static_set_Void_CharacterSpriteSetFull_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x06005796 RID: 22422 RVA: 0x001C678C File Offset: 0x001C498C
		// (set) Token: 0x06005797 RID: 22423 RVA: 0x001C67C0 File Offset: 0x001C49C0
		public unsafe static CharacterSpriteSetCompact FallbackCompactPixel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216800, XrefRangeEnd = 216804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_FallbackCompactPixel_Public_Static_get_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216804, XrefRangeEnd = 216810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_FallbackCompactPixel_Private_Static_set_Void_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x06005798 RID: 22424 RVA: 0x001C67F8 File Offset: 0x001C49F8
		// (set) Token: 0x06005799 RID: 22425 RVA: 0x001C682C File Offset: 0x001C4A2C
		public unsafe static CharacterSkinSets SelfSpriteSet
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216810, XrefRangeEnd = 216814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_SelfSpriteSet_Public_Static_get_CharacterSkinSets_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSkinSets>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216814, XrefRangeEnd = 216820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_SelfSpriteSet_Private_Static_set_Void_CharacterSkinSets_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x0600579A RID: 22426 RVA: 0x001C6864 File Offset: 0x001C4A64
		// (set) Token: 0x0600579B RID: 22427 RVA: 0x001C6898 File Offset: 0x001C4A98
		public unsafe static CharacterProtrayalSet SelfPortrayalSet
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216820, XrefRangeEnd = 216824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_SelfPortrayalSet_Public_Static_get_CharacterProtrayalSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterProtrayalSet>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216824, XrefRangeEnd = 216830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_SelfPortrayalSet_Private_Static_set_Void_CharacterProtrayalSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x0600579C RID: 22428 RVA: 0x001C68D0 File Offset: 0x001C4AD0
		public unsafe static Il2CppObjectBase FaceMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216830, XrefRangeEnd = 216834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_FaceMatrix_Public_Static_get_Il2CppObjectBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr3) : null;
			}
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x0600579D RID: 22429 RVA: 0x001C6904 File Offset: 0x001C4B04
		public unsafe static Il2CppObjectBase MovingMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216834, XrefRangeEnd = 216838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_MovingMatrix_Public_Static_get_Il2CppObjectBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr3) : null;
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x0600579E RID: 22430 RVA: 0x001C6938 File Offset: 0x001C4B38
		public unsafe static Il2CppObjectBase RotatingMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216838, XrefRangeEnd = 216842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_RotatingMatrix_Public_Static_get_Il2CppObjectBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr3) : null;
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x001C696C File Offset: 0x001C4B6C
		// (set) Token: 0x060057A0 RID: 22432 RVA: 0x001C69A0 File Offset: 0x001C4BA0
		public unsafe static GameObject CharacterBase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216842, XrefRangeEnd = 216846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_CharacterBase_Public_Static_get_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216846, XrefRangeEnd = 216852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_CharacterBase_Private_Static_set_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x001C69D8 File Offset: 0x001C4BD8
		public unsafe static List<Sprite> CharacterMouth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216852, XrefRangeEnd = 216856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_CharacterMouth_Public_Static_get_List_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x060057A2 RID: 22434 RVA: 0x001C6A0C File Offset: 0x001C4C0C
		public unsafe static Dictionary<int, AudioClip> CharacterSFX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216856, XrefRangeEnd = 216860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_CharacterSFX_Public_Static_get_Dictionary_2_Int32_AudioClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, AudioClip>>(intPtr3) : null;
			}
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x060057A3 RID: 22435 RVA: 0x001C6A40 File Offset: 0x001C4C40
		public unsafe static Dictionary<int, Il2CppReferenceArray<Sprite>> CharacterPFX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216860, XrefRangeEnd = 216864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_CharacterPFX_Public_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Sprite>>>(intPtr3) : null;
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x060057A4 RID: 22436 RVA: 0x001C6A74 File Offset: 0x001C4C74
		// (set) Token: 0x060057A5 RID: 22437 RVA: 0x001C6AA8 File Offset: 0x001C4CA8
		public unsafe static Dictionary<int, bool> CharacterHasSpell
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216864, XrefRangeEnd = 216868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_get_CharacterHasSpell_Public_Static_get_Dictionary_2_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216868, XrefRangeEnd = 216874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_set_CharacterHasSpell_Private_Static_set_Void_Dictionary_2_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x001C6AE0 File Offset: 0x001C4CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216874, XrefRangeEnd = 216886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNormalGuestVisualDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetNormalGuestVisualDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x001C6B18 File Offset: 0x001C4D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216886, XrefRangeEnd = 216898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSpecialGuestVisualDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetSpecialGuestVisualDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057A8 RID: 22440 RVA: 0x001C6B50 File Offset: 0x001C4D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216898, XrefRangeEnd = 216910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDaySceneNormalGuestVisualDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetDaySceneNormalGuestVisualDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x001C6B88 File Offset: 0x001C4D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216922, RefRangeEnd = 216923, XrefRangeStart = 216910, XrefRangeEnd = 216922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNormalGuestDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetNormalGuestDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x001C6BC0 File Offset: 0x001C4DC0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 216935, RefRangeEnd = 216941, XrefRangeStart = 216923, XrefRangeEnd = 216935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSpecialGuestDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetSpecialGuestDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x001C6BF8 File Offset: 0x001C4DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216953, RefRangeEnd = 216955, XrefRangeStart = 216941, XrefRangeEnd = 216953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPartnerInfoDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetPartnerInfoDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x001C6C30 File Offset: 0x001C4E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216955, XrefRangeEnd = 216967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMappedSpecialGuestDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetMappedSpecialGuestDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x001C6C68 File Offset: 0x001C4E68
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 216984, RefRangeEnd = 216991, XrefRangeStart = 216967, XrefRangeEnd = 216984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask LoadActivePlayerSkinAsync(ClothesProfile.Clothes clothesData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clothesData);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_LoadActivePlayerSkinAsync_Public_Static_UniTask_Clothes_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x001C6CA4 File Offset: 0x001C4EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217041, RefRangeEnd = 217042, XrefRangeStart = 216991, XrefRangeEnd = 217041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadActivePlayerSkin()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_UnloadActivePlayerSkin_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x001C6CCC File Offset: 0x001C4ECC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 217074, RefRangeEnd = 217080, XrefRangeStart = 217042, XrefRangeEnd = 217074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetupPortrayalVisual(Image imageComponent, MonoBehaviour coroutineRunner, ref Coroutine dynamicPortrayalCoroutine)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageComponent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coroutineRunner);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dynamicPortrayalCoroutine);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_SetupPortrayalVisual_Public_Static_Boolean_Image_MonoBehaviour_byref_Coroutine_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dynamicPortrayalCoroutine = ((intPtr4 == 0) ? null : new Coroutine(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x001C6D48 File Offset: 0x001C4F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217720, RefRangeEnd = 217721, XrefRangeStart = 217080, XrefRangeEnd = 217720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(GameObject characterControllerUnitParent, CharacterPortrayal characterPortrayalFallback, CharacterSpriteSetFull defaultFullSpriteSet, CharacterSpriteSetCompact defaultCompactSpriteSet, CharacterProtrayalSet selfPortrayalSet, CharacterSkinSets selfSpriteSet, Color unifiedNormalGuestBGColor, Color unifiedNormalGuestTextColor, Dictionary<string, SchedulerNode.Character> extraStringMappingData, Dictionary<string, DataBaseCharacter.DataBaseCharacterData> characterData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterControllerUnitParent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterPortrayalFallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultFullSpriteSet);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultCompactSpriteSet);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selfPortrayalSet);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selfSpriteSet);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unifiedNormalGuestBGColor;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unifiedNormalGuestTextColor;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraStringMappingData);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_Initialize_Public_Static_Void_GameObject_CharacterPortrayal_CharacterSpriteSetFull_CharacterSpriteSetCompact_CharacterProtrayalSet_CharacterSkinSets_Color_Color_Dictionary_2_String_Character_Dictionary_2_String_DataBaseCharacterData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x001C6E20 File Offset: 0x001C5020
		[CallerCount(0)]
		public unsafe static GuestProfilePair PopulateNullValues(GuestProfilePair toPopulate, GuestProfilePair populateReference)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toPopulate);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(populateReference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_PopulateNullValues_Private_Static_GuestProfilePair_GuestProfilePair_GuestProfilePair_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestProfilePair>(intPtr3) : null;
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x001C6E78 File Offset: 0x001C5078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217721, XrefRangeEnd = 217726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CharacterSpriteSetCompact> PopulateNullValues(Il2CppReferenceArray<CharacterSpriteSetCompact> original, CharacterSpriteSetCompact reference)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_PopulateNullValues_Private_Static_Il2CppReferenceArray_1_CharacterSpriteSetCompact_Il2CppReferenceArray_1_CharacterSpriteSetCompact_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterSpriteSetCompact>>(intPtr3) : null;
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x001C6ED0 File Offset: 0x001C50D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217726, XrefRangeEnd = 217737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NormalGuestExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_NormalGuestExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x001C6F10 File Offset: 0x001C5110
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 217747, RefRangeEnd = 217757, XrefRangeStart = 217737, XrefRangeEnd = 217747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NormalGuest RefNGuest(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_RefNGuest_Public_Static_NormalGuest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NormalGuest>(intPtr3) : null;
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x001C6F50 File Offset: 0x001C5150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217757, XrefRangeEnd = 217768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSpecialGuestMapped(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_IsSpecialGuestMapped_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x001C6F90 File Offset: 0x001C5190
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217813, RefRangeEnd = 217815, XrefRangeStart = 217768, XrefRangeEnd = 217813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpecialGuest RefSGuest(this string daySceneNPCid)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(daySceneNPCid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_RefSGuest_Public_Static_SpecialGuest_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x001C6FD4 File Offset: 0x001C51D4
		[CallerCount(123)]
		[CachedScanResults(RefRangeStart = 217837, RefRangeEnd = 217960, XrefRangeStart = 217815, XrefRangeEnd = 217837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpecialGuest RefSGuest(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_RefSGuest_Public_Static_SpecialGuest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x001C7014 File Offset: 0x001C5214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217960, XrefRangeEnd = 217974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MappedID2TargetID(int source)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_MappedID2TargetID_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x001C7054 File Offset: 0x001C5254
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 217988, RefRangeEnd = 217995, XrefRangeStart = 217974, XrefRangeEnd = 217988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<NormalGuest> GetAllNormalGuests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetAllNormalGuests_Public_Static_Il2CppReferenceArray_1_NormalGuest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NormalGuest>>(intPtr3) : null;
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x001C7088 File Offset: 0x001C5288
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 218009, RefRangeEnd = 218029, XrefRangeStart = 217995, XrefRangeEnd = 218009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<SpecialGuest> GetAllSpecialGuests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetAllSpecialGuests_Public_Static_Il2CppReferenceArray_1_SpecialGuest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest>>(intPtr3) : null;
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x001C70BC File Offset: 0x001C52BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 218040, RefRangeEnd = 218047, XrefRangeStart = 218029, XrefRangeEnd = 218040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SpecialGuestExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_SpecialGuestExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x001C70FC File Offset: 0x001C52FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218061, RefRangeEnd = 218063, XrefRangeStart = 218047, XrefRangeEnd = 218061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<MappedSpecialGuest> GetAllMappedGuests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetAllMappedGuests_Public_Static_Il2CppReferenceArray_1_MappedSpecialGuest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MappedSpecialGuest>>(intPtr3) : null;
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x001C7130 File Offset: 0x001C5330
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218115, RefRangeEnd = 218117, XrefRangeStart = 218063, XrefRangeEnd = 218115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreinitSpecialGuests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_PreinitSpecialGuests_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x001C7158 File Offset: 0x001C5358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218117, XrefRangeEnd = 218141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<SpecialGuest> GetSpecialGuestsAndMappedGuests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetSpecialGuestsAndMappedGuests_Public_Static_Il2CppReferenceArray_1_SpecialGuest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest>>(intPtr3) : null;
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x001C718C File Offset: 0x001C538C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218199, RefRangeEnd = 218200, XrefRangeStart = 218141, XrefRangeEnd = 218199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Il2CppReferenceArray<SpecialGuest>> GetMappedSpecialGuests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetMappedSpecialGuests_Public_Static_Dictionary_2_String_Il2CppReferenceArray_1_SpecialGuest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppReferenceArray<SpecialGuest>>>(intPtr3) : null;
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x001C71C0 File Offset: 0x001C53C0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 218210, RefRangeEnd = 218224, XrefRangeStart = 218200, XrefRangeEnd = 218210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PartnerInfoBase RefPartnerInfo(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_RefPartnerInfo_Public_Static_PartnerInfoBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartnerInfoBase>(intPtr3) : null;
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x001C7200 File Offset: 0x001C5400
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218235, RefRangeEnd = 218238, XrefRangeStart = 218224, XrefRangeEnd = 218235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIdIsPartner(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_CheckIdIsPartner_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x001C7240 File Offset: 0x001C5440
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 218276, RefRangeEnd = 218281, XrefRangeStart = 218238, XrefRangeEnd = 218276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIdIsBossPartner(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_CheckIdIsBossPartner_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x001C7280 File Offset: 0x001C5480
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 218347, RefRangeEnd = 218353, XrefRangeStart = 218281, XrefRangeEnd = 218347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllValidPartnerIndex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetAllValidPartnerIndex_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x001C72B4 File Offset: 0x001C54B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218353, XrefRangeEnd = 218370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Sprite> AsCharacterSpriteSet(this Sprite original)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_AsCharacterSpriteSet_Public_Static_Il2CppReferenceArray_1_Sprite_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x001C72F8 File Offset: 0x001C54F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218413, RefRangeEnd = 218416, XrefRangeStart = 218370, XrefRangeEnd = 218413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GuestProfilePair RefNormalGuestVisual(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_RefNormalGuestVisual_Public_Static_GuestProfilePair_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestProfilePair>(intPtr3) : null;
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x001C7338 File Offset: 0x001C5538
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218439, RefRangeEnd = 218443, XrefRangeStart = 218416, XrefRangeEnd = 218439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterSpriteSetCompact RefDaySceneNormalGuestVisual(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_RefDaySceneNormalGuestVisual_Public_Static_CharacterSpriteSetCompact_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x001C7378 File Offset: 0x001C5578
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 218457, RefRangeEnd = 218464, XrefRangeStart = 218443, XrefRangeEnd = 218457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GuestProfilePair RefSpecialGuestVisual(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_RefSpecialGuestVisual_Public_Static_GuestProfilePair_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestProfilePair>(intPtr3) : null;
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x001C73B8 File Offset: 0x001C55B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218517, RefRangeEnd = 218519, XrefRangeStart = 218464, XrefRangeEnd = 218517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SchedulerNode.Character RefNPCIdentity(this string stringId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(stringId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_RefNPCIdentity_Public_Static_Character_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x001C73FC File Offset: 0x001C55FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218529, RefRangeEnd = 218530, XrefRangeStart = 218519, XrefRangeEnd = 218529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNPCLabel(SchedulerNode.Character identity)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref identity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetNPCLabel_Public_Static_String_Character_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x001C7434 File Offset: 0x001C5634
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218547, RefRangeEnd = 218550, XrefRangeStart = 218530, XrefRangeEnd = 218547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterSpriteSetCompact RefNPCVisual(this string stringId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(stringId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_RefNPCVisual_Public_Static_CharacterSpriteSetCompact_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x001C7478 File Offset: 0x001C5678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218560, RefRangeEnd = 218561, XrefRangeStart = 218550, XrefRangeEnd = 218560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckCharacterHasSpell(int specialGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_CheckCharacterHasSpell_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x001C74B8 File Offset: 0x001C56B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218572, RefRangeEnd = 218573, XrefRangeStart = 218561, XrefRangeEnd = 218572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllOriginSGuestMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_GetAllOriginSGuestMapping_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x001C74EC File Offset: 0x001C56EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218583, RefRangeEnd = 218586, XrefRangeStart = 218573, XrefRangeEnd = 218583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetTargetSGuestMapping(int originalGuest, out int mappingGuest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref originalGuest;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mappingGuest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_TryGetTargetSGuestMapping_Public_Static_Boolean_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x001C7538 File Offset: 0x001C5738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218586, XrefRangeEnd = 218619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetOriginalSGuestFromMapping(int mappingGuest, out int originalGuest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mappingGuest;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &originalGuest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.NativeMethodInfoPtr_TryGetOriginalSGuestFromMapping_Public_Static_Boolean_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x0002F063 File Offset: 0x0002D263
		public DataBaseCharacter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x060057D0 RID: 22480 RVA: 0x001C7584 File Offset: 0x001C5784
		// (set) Token: 0x060057D1 RID: 22481 RVA: 0x0002F06C File Offset: 0x0002D26C
		public unsafe static ClothesProfile.Clothes m_ClothesData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr_m_ClothesData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothesProfile.Clothes>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr_m_ClothesData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x060057D2 RID: 22482 RVA: 0x001C75AC File Offset: 0x001C57AC
		// (set) Token: 0x060057D3 RID: 22483 RVA: 0x0002F07E File Offset: 0x0002D27E
		public unsafe static IAssetHandle<Sprite> m_PlayerActiveSkinPortrayal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr_m_PlayerActiveSkinPortrayal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<Sprite>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr_m_PlayerActiveSkinPortrayal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x060057D4 RID: 22484 RVA: 0x001C75D4 File Offset: 0x001C57D4
		// (set) Token: 0x060057D5 RID: 22485 RVA: 0x0002F090 File Offset: 0x0002D290
		public unsafe static IAssetHandleArray<Sprite> m_PlayerActiveAnimatedSkinPortrayal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr_m_PlayerActiveAnimatedSkinPortrayal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandleArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr_m_PlayerActiveAnimatedSkinPortrayal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x060057D6 RID: 22486 RVA: 0x001C75FC File Offset: 0x001C57FC
		// (set) Token: 0x060057D7 RID: 22487 RVA: 0x0002F0A2 File Offset: 0x0002D2A2
		public unsafe static Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>> _NormalGuestVisual_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__NormalGuestVisual_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__NormalGuestVisual_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x060057D8 RID: 22488 RVA: 0x001C7624 File Offset: 0x001C5824
		// (set) Token: 0x060057D9 RID: 22489 RVA: 0x0002F0B4 File Offset: 0x0002D2B4
		public unsafe static Dictionary<int, GuestProfilePair> _SpecialGuestVisual_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestVisual_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestProfilePair>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestVisual_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x060057DA RID: 22490 RVA: 0x001C764C File Offset: 0x001C584C
		// (set) Token: 0x060057DB RID: 22491 RVA: 0x0002F0C6 File Offset: 0x0002D2C6
		public unsafe static Dictionary<int, CharacterSpriteSetCompact> _DaySceneNormalGuestVisual_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__DaySceneNormalGuestVisual_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, CharacterSpriteSetCompact>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__DaySceneNormalGuestVisual_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x060057DC RID: 22492 RVA: 0x001C7674 File Offset: 0x001C5874
		// (set) Token: 0x060057DD RID: 22493 RVA: 0x0002F0D8 File Offset: 0x0002D2D8
		public unsafe static Dictionary<int, NormalGuest> _NormalGuest_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__NormalGuest_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, NormalGuest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__NormalGuest_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x060057DE RID: 22494 RVA: 0x001C769C File Offset: 0x001C589C
		// (set) Token: 0x060057DF RID: 22495 RVA: 0x0002F0EA File Offset: 0x0002D2EA
		public unsafe static Dictionary<int, SpecialGuest> _SpecialGuest_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__SpecialGuest_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__SpecialGuest_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x060057E0 RID: 22496 RVA: 0x001C76C4 File Offset: 0x001C58C4
		// (set) Token: 0x060057E1 RID: 22497 RVA: 0x0002F0FC File Offset: 0x0002D2FC
		public unsafe static Dictionary<int, MappedSpecialGuest> _MappedSpecialGuest_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__MappedSpecialGuest_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MappedSpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__MappedSpecialGuest_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x060057E2 RID: 22498 RVA: 0x001C76EC File Offset: 0x001C58EC
		// (set) Token: 0x060057E3 RID: 22499 RVA: 0x0002F10E File Offset: 0x0002D30E
		public unsafe static Dictionary<int, SpecialGuest> _BufferedMappedSpecialGuest_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__BufferedMappedSpecialGuest_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__BufferedMappedSpecialGuest_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x060057E4 RID: 22500 RVA: 0x001C7714 File Offset: 0x001C5914
		// (set) Token: 0x060057E5 RID: 22501 RVA: 0x0002F120 File Offset: 0x0002D320
		public unsafe static Dictionary<int, PartnerInfoBase> _PartnerInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__PartnerInfo_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PartnerInfoBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__PartnerInfo_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x060057E6 RID: 22502 RVA: 0x001C773C File Offset: 0x001C593C
		// (set) Token: 0x060057E7 RID: 22503 RVA: 0x0002F132 File Offset: 0x0002D332
		public unsafe static Dictionary<string, SchedulerNode.Character> _StringMappingData_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__StringMappingData_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchedulerNode.Character>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__StringMappingData_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x060057E8 RID: 22504 RVA: 0x001C7764 File Offset: 0x001C5964
		// (set) Token: 0x060057E9 RID: 22505 RVA: 0x0002F144 File Offset: 0x0002D344
		public unsafe static Dictionary<SchedulerNode.Character, Il2CppStringArray> _InvStringMappingData_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__InvStringMappingData_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SchedulerNode.Character, Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__InvStringMappingData_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x060057EA RID: 22506 RVA: 0x001C778C File Offset: 0x001C598C
		// (set) Token: 0x060057EB RID: 22507 RVA: 0x0002F156 File Offset: 0x0002D356
		public unsafe static Dictionary<int, int> _SpecialGuestMappingRules_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestMappingRules_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestMappingRules_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x060057EC RID: 22508 RVA: 0x001C77B4 File Offset: 0x001C59B4
		// (set) Token: 0x060057ED RID: 22509 RVA: 0x0002F168 File Offset: 0x0002D368
		public unsafe static Color _UnifiedNormalGuestBGColor_k__BackingField
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__UnifiedNormalGuestBGColor_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__UnifiedNormalGuestBGColor_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x060057EE RID: 22510 RVA: 0x001C77D0 File Offset: 0x001C59D0
		// (set) Token: 0x060057EF RID: 22511 RVA: 0x0002F176 File Offset: 0x0002D376
		public unsafe static Color _UnifiedNormalGuestTextColor_k__BackingField
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__UnifiedNormalGuestTextColor_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__UnifiedNormalGuestTextColor_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x060057F0 RID: 22512 RVA: 0x001C77EC File Offset: 0x001C59EC
		// (set) Token: 0x060057F1 RID: 22513 RVA: 0x0002F184 File Offset: 0x0002D384
		public unsafe static Dictionary<int, string> _NormalGuestVisualMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__NormalGuestVisualMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__NormalGuestVisualMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x060057F2 RID: 22514 RVA: 0x001C7814 File Offset: 0x001C5A14
		// (set) Token: 0x060057F3 RID: 22515 RVA: 0x0002F196 File Offset: 0x0002D396
		public unsafe static Dictionary<int, string> _SpecialGuestVisualMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestVisualMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestVisualMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x060057F4 RID: 22516 RVA: 0x001C783C File Offset: 0x001C5A3C
		// (set) Token: 0x060057F5 RID: 22517 RVA: 0x0002F1A8 File Offset: 0x0002D3A8
		public unsafe static Dictionary<int, string> _DaySceneNormalGuestVisualMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__DaySceneNormalGuestVisualMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__DaySceneNormalGuestVisualMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x060057F6 RID: 22518 RVA: 0x001C7864 File Offset: 0x001C5A64
		// (set) Token: 0x060057F7 RID: 22519 RVA: 0x0002F1BA File Offset: 0x0002D3BA
		public unsafe static Dictionary<int, string> _NormalGuestMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__NormalGuestMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__NormalGuestMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x060057F8 RID: 22520 RVA: 0x001C788C File Offset: 0x001C5A8C
		// (set) Token: 0x060057F9 RID: 22521 RVA: 0x0002F1CC File Offset: 0x0002D3CC
		public unsafe static Dictionary<int, string> _SpecialGuestMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__SpecialGuestMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x060057FA RID: 22522 RVA: 0x001C78B4 File Offset: 0x001C5AB4
		// (set) Token: 0x060057FB RID: 22523 RVA: 0x0002F1DE File Offset: 0x0002D3DE
		public unsafe static Dictionary<int, string> _PartnerInfoMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__PartnerInfoMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__PartnerInfoMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x060057FC RID: 22524 RVA: 0x001C78DC File Offset: 0x001C5ADC
		// (set) Token: 0x060057FD RID: 22525 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		public unsafe static Dictionary<int, string> _MappedSpecialGuestMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__MappedSpecialGuestMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__MappedSpecialGuestMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x060057FE RID: 22526 RVA: 0x001C7904 File Offset: 0x001C5B04
		// (set) Token: 0x060057FF RID: 22527 RVA: 0x0002F202 File Offset: 0x0002D402
		public unsafe static GuestProfilePair _FallbackSpecialGuestVisual_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__FallbackSpecialGuestVisual_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestProfilePair>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__FallbackSpecialGuestVisual_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06005800 RID: 22528 RVA: 0x001C792C File Offset: 0x001C5B2C
		// (set) Token: 0x06005801 RID: 22529 RVA: 0x0002F214 File Offset: 0x0002D414
		public unsafe static CharacterPortrayal _FallbackPortrayal_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__FallbackPortrayal_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__FallbackPortrayal_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x06005802 RID: 22530 RVA: 0x001C7954 File Offset: 0x001C5B54
		// (set) Token: 0x06005803 RID: 22531 RVA: 0x0002F226 File Offset: 0x0002D426
		public unsafe static CharacterSpriteSetFull _FallbackFullPixel_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__FallbackFullPixel_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetFull>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__FallbackFullPixel_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x06005804 RID: 22532 RVA: 0x001C797C File Offset: 0x001C5B7C
		// (set) Token: 0x06005805 RID: 22533 RVA: 0x0002F238 File Offset: 0x0002D438
		public unsafe static CharacterSpriteSetCompact _FallbackCompactPixel_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__FallbackCompactPixel_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__FallbackCompactPixel_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x001C79A4 File Offset: 0x001C5BA4
		// (set) Token: 0x06005807 RID: 22535 RVA: 0x0002F24A File Offset: 0x0002D44A
		public unsafe static CharacterSkinSets _SelfSpriteSet_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__SelfSpriteSet_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSkinSets>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__SelfSpriteSet_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06005808 RID: 22536 RVA: 0x001C79CC File Offset: 0x001C5BCC
		// (set) Token: 0x06005809 RID: 22537 RVA: 0x0002F25C File Offset: 0x0002D45C
		public unsafe static CharacterProtrayalSet _SelfPortrayalSet_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__SelfPortrayalSet_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterProtrayalSet>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__SelfPortrayalSet_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x001C79F4 File Offset: 0x001C5BF4
		// (set) Token: 0x0600580B RID: 22539 RVA: 0x0002F26E File Offset: 0x0002D46E
		public unsafe static Il2CppObjectBase _FaceMatrix_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__FaceMatrix_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__FaceMatrix_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x0600580C RID: 22540 RVA: 0x001C7A1C File Offset: 0x001C5C1C
		// (set) Token: 0x0600580D RID: 22541 RVA: 0x0002F280 File Offset: 0x0002D480
		public unsafe static Il2CppObjectBase _MovingMatrix_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__MovingMatrix_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__MovingMatrix_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x0600580E RID: 22542 RVA: 0x001C7A44 File Offset: 0x001C5C44
		// (set) Token: 0x0600580F RID: 22543 RVA: 0x0002F292 File Offset: 0x0002D492
		public unsafe static Il2CppObjectBase _RotatingMatrix_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__RotatingMatrix_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__RotatingMatrix_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06005810 RID: 22544 RVA: 0x001C7A6C File Offset: 0x001C5C6C
		// (set) Token: 0x06005811 RID: 22545 RVA: 0x0002F2A4 File Offset: 0x0002D4A4
		public unsafe static GameObject _CharacterBase_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__CharacterBase_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__CharacterBase_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x06005812 RID: 22546 RVA: 0x001C7A94 File Offset: 0x001C5C94
		// (set) Token: 0x06005813 RID: 22547 RVA: 0x0002F2B6 File Offset: 0x0002D4B6
		public unsafe static List<Sprite> _CharacterMouth_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__CharacterMouth_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sprite>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__CharacterMouth_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x06005814 RID: 22548 RVA: 0x001C7ABC File Offset: 0x001C5CBC
		// (set) Token: 0x06005815 RID: 22549 RVA: 0x0002F2C8 File Offset: 0x0002D4C8
		public unsafe static Dictionary<int, AudioClip> _CharacterSFX_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__CharacterSFX_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, AudioClip>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__CharacterSFX_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x06005816 RID: 22550 RVA: 0x001C7AE4 File Offset: 0x001C5CE4
		// (set) Token: 0x06005817 RID: 22551 RVA: 0x0002F2DA File Offset: 0x0002D4DA
		public unsafe static Dictionary<int, Il2CppReferenceArray<Sprite>> _CharacterPFX_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__CharacterPFX_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Sprite>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__CharacterPFX_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x06005818 RID: 22552 RVA: 0x001C7B0C File Offset: 0x001C5D0C
		// (set) Token: 0x06005819 RID: 22553 RVA: 0x0002F2EC File Offset: 0x0002D4EC
		public unsafe static Dictionary<int, bool> _CharacterHasSpell_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.NativeFieldInfoPtr__CharacterHasSpell_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.NativeFieldInfoPtr__CharacterHasSpell_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A85 RID: 14981
		private static readonly IntPtr NativeFieldInfoPtr_m_ClothesData;

		// Token: 0x04003A86 RID: 14982
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerActiveSkinPortrayal;

		// Token: 0x04003A87 RID: 14983
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerActiveAnimatedSkinPortrayal;

		// Token: 0x04003A88 RID: 14984
		private static readonly IntPtr NativeFieldInfoPtr__NormalGuestVisual_k__BackingField;

		// Token: 0x04003A89 RID: 14985
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestVisual_k__BackingField;

		// Token: 0x04003A8A RID: 14986
		private static readonly IntPtr NativeFieldInfoPtr__DaySceneNormalGuestVisual_k__BackingField;

		// Token: 0x04003A8B RID: 14987
		private static readonly IntPtr NativeFieldInfoPtr__NormalGuest_k__BackingField;

		// Token: 0x04003A8C RID: 14988
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuest_k__BackingField;

		// Token: 0x04003A8D RID: 14989
		private static readonly IntPtr NativeFieldInfoPtr__MappedSpecialGuest_k__BackingField;

		// Token: 0x04003A8E RID: 14990
		private static readonly IntPtr NativeFieldInfoPtr__BufferedMappedSpecialGuest_k__BackingField;

		// Token: 0x04003A8F RID: 14991
		private static readonly IntPtr NativeFieldInfoPtr__PartnerInfo_k__BackingField;

		// Token: 0x04003A90 RID: 14992
		private static readonly IntPtr NativeFieldInfoPtr__StringMappingData_k__BackingField;

		// Token: 0x04003A91 RID: 14993
		private static readonly IntPtr NativeFieldInfoPtr__InvStringMappingData_k__BackingField;

		// Token: 0x04003A92 RID: 14994
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestMappingRules_k__BackingField;

		// Token: 0x04003A93 RID: 14995
		private static readonly IntPtr NativeFieldInfoPtr__UnifiedNormalGuestBGColor_k__BackingField;

		// Token: 0x04003A94 RID: 14996
		private static readonly IntPtr NativeFieldInfoPtr__UnifiedNormalGuestTextColor_k__BackingField;

		// Token: 0x04003A95 RID: 14997
		private static readonly IntPtr NativeFieldInfoPtr__NormalGuestVisualMapping_k__BackingField;

		// Token: 0x04003A96 RID: 14998
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestVisualMapping_k__BackingField;

		// Token: 0x04003A97 RID: 14999
		private static readonly IntPtr NativeFieldInfoPtr__DaySceneNormalGuestVisualMapping_k__BackingField;

		// Token: 0x04003A98 RID: 15000
		private static readonly IntPtr NativeFieldInfoPtr__NormalGuestMapping_k__BackingField;

		// Token: 0x04003A99 RID: 15001
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestMapping_k__BackingField;

		// Token: 0x04003A9A RID: 15002
		private static readonly IntPtr NativeFieldInfoPtr__PartnerInfoMapping_k__BackingField;

		// Token: 0x04003A9B RID: 15003
		private static readonly IntPtr NativeFieldInfoPtr__MappedSpecialGuestMapping_k__BackingField;

		// Token: 0x04003A9C RID: 15004
		private static readonly IntPtr NativeFieldInfoPtr__FallbackSpecialGuestVisual_k__BackingField;

		// Token: 0x04003A9D RID: 15005
		private static readonly IntPtr NativeFieldInfoPtr__FallbackPortrayal_k__BackingField;

		// Token: 0x04003A9E RID: 15006
		private static readonly IntPtr NativeFieldInfoPtr__FallbackFullPixel_k__BackingField;

		// Token: 0x04003A9F RID: 15007
		private static readonly IntPtr NativeFieldInfoPtr__FallbackCompactPixel_k__BackingField;

		// Token: 0x04003AA0 RID: 15008
		private static readonly IntPtr NativeFieldInfoPtr__SelfSpriteSet_k__BackingField;

		// Token: 0x04003AA1 RID: 15009
		private static readonly IntPtr NativeFieldInfoPtr__SelfPortrayalSet_k__BackingField;

		// Token: 0x04003AA2 RID: 15010
		private static readonly IntPtr NativeFieldInfoPtr__FaceMatrix_k__BackingField;

		// Token: 0x04003AA3 RID: 15011
		private static readonly IntPtr NativeFieldInfoPtr__MovingMatrix_k__BackingField;

		// Token: 0x04003AA4 RID: 15012
		private static readonly IntPtr NativeFieldInfoPtr__RotatingMatrix_k__BackingField;

		// Token: 0x04003AA5 RID: 15013
		private static readonly IntPtr NativeFieldInfoPtr__CharacterBase_k__BackingField;

		// Token: 0x04003AA6 RID: 15014
		private static readonly IntPtr NativeFieldInfoPtr__CharacterMouth_k__BackingField;

		// Token: 0x04003AA7 RID: 15015
		private static readonly IntPtr NativeFieldInfoPtr__CharacterSFX_k__BackingField;

		// Token: 0x04003AA8 RID: 15016
		private static readonly IntPtr NativeFieldInfoPtr__CharacterPFX_k__BackingField;

		// Token: 0x04003AA9 RID: 15017
		private static readonly IntPtr NativeFieldInfoPtr__CharacterHasSpell_k__BackingField;

		// Token: 0x04003AAA RID: 15018
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestVisual_Private_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0;

		// Token: 0x04003AAB RID: 15019
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuestVisual_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0;

		// Token: 0x04003AAC RID: 15020
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestVisual_Private_Static_get_Dictionary_2_Int32_GuestProfilePair_0;

		// Token: 0x04003AAD RID: 15021
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestVisual_Private_Static_set_Void_Dictionary_2_Int32_GuestProfilePair_0;

		// Token: 0x04003AAE RID: 15022
		private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneNormalGuestVisual_Private_Static_get_Dictionary_2_Int32_CharacterSpriteSetCompact_0;

		// Token: 0x04003AAF RID: 15023
		private static readonly IntPtr NativeMethodInfoPtr_set_DaySceneNormalGuestVisual_Private_Static_set_Void_Dictionary_2_Int32_CharacterSpriteSetCompact_0;

		// Token: 0x04003AB0 RID: 15024
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuest_Private_Static_get_Dictionary_2_Int32_NormalGuest_0;

		// Token: 0x04003AB1 RID: 15025
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuest_Private_Static_set_Void_Dictionary_2_Int32_NormalGuest_0;

		// Token: 0x04003AB2 RID: 15026
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuest_Private_Static_get_Dictionary_2_Int32_SpecialGuest_0;

		// Token: 0x04003AB3 RID: 15027
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_SpecialGuest_0;

		// Token: 0x04003AB4 RID: 15028
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedSpecialGuest_Private_Static_get_Dictionary_2_Int32_MappedSpecialGuest_0;

		// Token: 0x04003AB5 RID: 15029
		private static readonly IntPtr NativeMethodInfoPtr_set_MappedSpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_MappedSpecialGuest_0;

		// Token: 0x04003AB6 RID: 15030
		private static readonly IntPtr NativeMethodInfoPtr_get_BufferedMappedSpecialGuest_Private_Static_get_Dictionary_2_Int32_SpecialGuest_0;

		// Token: 0x04003AB7 RID: 15031
		private static readonly IntPtr NativeMethodInfoPtr_set_BufferedMappedSpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_SpecialGuest_0;

		// Token: 0x04003AB8 RID: 15032
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerInfo_Private_Static_get_Dictionary_2_Int32_PartnerInfoBase_0;

		// Token: 0x04003AB9 RID: 15033
		private static readonly IntPtr NativeMethodInfoPtr_set_PartnerInfo_Private_Static_set_Void_Dictionary_2_Int32_PartnerInfoBase_0;

		// Token: 0x04003ABA RID: 15034
		private static readonly IntPtr NativeMethodInfoPtr_get_StringMappingData_Private_Static_get_Dictionary_2_String_Character_0;

		// Token: 0x04003ABB RID: 15035
		private static readonly IntPtr NativeMethodInfoPtr_set_StringMappingData_Private_Static_set_Void_Dictionary_2_String_Character_0;

		// Token: 0x04003ABC RID: 15036
		private static readonly IntPtr NativeMethodInfoPtr_get_InvStringMappingData_Private_Static_get_Dictionary_2_Character_Il2CppStringArray_0;

		// Token: 0x04003ABD RID: 15037
		private static readonly IntPtr NativeMethodInfoPtr_set_InvStringMappingData_Private_Static_set_Void_Dictionary_2_Character_Il2CppStringArray_0;

		// Token: 0x04003ABE RID: 15038
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestMappingRules_Private_Static_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04003ABF RID: 15039
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestMappingRules_Private_Static_set_Void_Dictionary_2_Int32_Int32_0;

		// Token: 0x04003AC0 RID: 15040
		private static readonly IntPtr NativeMethodInfoPtr_get_UnifiedNormalGuestBGColor_Private_Static_get_Color_0;

		// Token: 0x04003AC1 RID: 15041
		private static readonly IntPtr NativeMethodInfoPtr_set_UnifiedNormalGuestBGColor_Private_Static_set_Void_Color_0;

		// Token: 0x04003AC2 RID: 15042
		private static readonly IntPtr NativeMethodInfoPtr_get_UnifiedNormalGuestTextColor_Private_Static_get_Color_0;

		// Token: 0x04003AC3 RID: 15043
		private static readonly IntPtr NativeMethodInfoPtr_set_UnifiedNormalGuestTextColor_Private_Static_set_Void_Color_0;

		// Token: 0x04003AC4 RID: 15044
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestVisualMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04003AC5 RID: 15045
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuestVisualMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04003AC6 RID: 15046
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestVisualMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04003AC7 RID: 15047
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestVisualMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04003AC8 RID: 15048
		private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneNormalGuestVisualMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04003AC9 RID: 15049
		private static readonly IntPtr NativeMethodInfoPtr_set_DaySceneNormalGuestVisualMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04003ACA RID: 15050
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04003ACB RID: 15051
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuestMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04003ACC RID: 15052
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04003ACD RID: 15053
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04003ACE RID: 15054
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerInfoMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04003ACF RID: 15055
		private static readonly IntPtr NativeMethodInfoPtr_set_PartnerInfoMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04003AD0 RID: 15056
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedSpecialGuestMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04003AD1 RID: 15057
		private static readonly IntPtr NativeMethodInfoPtr_set_MappedSpecialGuestMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04003AD2 RID: 15058
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackSpecialGuestVisual_Public_Static_get_GuestProfilePair_0;

		// Token: 0x04003AD3 RID: 15059
		private static readonly IntPtr NativeMethodInfoPtr_set_FallbackSpecialGuestVisual_Private_Static_set_Void_GuestProfilePair_0;

		// Token: 0x04003AD4 RID: 15060
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackPortrayal_Public_Static_get_CharacterPortrayal_0;

		// Token: 0x04003AD5 RID: 15061
		private static readonly IntPtr NativeMethodInfoPtr_set_FallbackPortrayal_Private_Static_set_Void_CharacterPortrayal_0;

		// Token: 0x04003AD6 RID: 15062
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackFullPixel_Public_Static_get_CharacterSpriteSetFull_0;

		// Token: 0x04003AD7 RID: 15063
		private static readonly IntPtr NativeMethodInfoPtr_set_FallbackFullPixel_Private_Static_set_Void_CharacterSpriteSetFull_0;

		// Token: 0x04003AD8 RID: 15064
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackCompactPixel_Public_Static_get_CharacterSpriteSetCompact_0;

		// Token: 0x04003AD9 RID: 15065
		private static readonly IntPtr NativeMethodInfoPtr_set_FallbackCompactPixel_Private_Static_set_Void_CharacterSpriteSetCompact_0;

		// Token: 0x04003ADA RID: 15066
		private static readonly IntPtr NativeMethodInfoPtr_get_SelfSpriteSet_Public_Static_get_CharacterSkinSets_0;

		// Token: 0x04003ADB RID: 15067
		private static readonly IntPtr NativeMethodInfoPtr_set_SelfSpriteSet_Private_Static_set_Void_CharacterSkinSets_0;

		// Token: 0x04003ADC RID: 15068
		private static readonly IntPtr NativeMethodInfoPtr_get_SelfPortrayalSet_Public_Static_get_CharacterProtrayalSet_0;

		// Token: 0x04003ADD RID: 15069
		private static readonly IntPtr NativeMethodInfoPtr_set_SelfPortrayalSet_Private_Static_set_Void_CharacterProtrayalSet_0;

		// Token: 0x04003ADE RID: 15070
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceMatrix_Public_Static_get_Il2CppObjectBase_0;

		// Token: 0x04003ADF RID: 15071
		private static readonly IntPtr NativeMethodInfoPtr_get_MovingMatrix_Public_Static_get_Il2CppObjectBase_0;

		// Token: 0x04003AE0 RID: 15072
		private static readonly IntPtr NativeMethodInfoPtr_get_RotatingMatrix_Public_Static_get_Il2CppObjectBase_0;

		// Token: 0x04003AE1 RID: 15073
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterBase_Public_Static_get_GameObject_0;

		// Token: 0x04003AE2 RID: 15074
		private static readonly IntPtr NativeMethodInfoPtr_set_CharacterBase_Private_Static_set_Void_GameObject_0;

		// Token: 0x04003AE3 RID: 15075
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterMouth_Public_Static_get_List_1_Sprite_0;

		// Token: 0x04003AE4 RID: 15076
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterSFX_Public_Static_get_Dictionary_2_Int32_AudioClip_0;

		// Token: 0x04003AE5 RID: 15077
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterPFX_Public_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003AE6 RID: 15078
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterHasSpell_Public_Static_get_Dictionary_2_Int32_Boolean_0;

		// Token: 0x04003AE7 RID: 15079
		private static readonly IntPtr NativeMethodInfoPtr_set_CharacterHasSpell_Private_Static_set_Void_Dictionary_2_Int32_Boolean_0;

		// Token: 0x04003AE8 RID: 15080
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalGuestVisualDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x04003AE9 RID: 15081
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestVisualDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x04003AEA RID: 15082
		private static readonly IntPtr NativeMethodInfoPtr_GetDaySceneNormalGuestVisualDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x04003AEB RID: 15083
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalGuestDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x04003AEC RID: 15084
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x04003AED RID: 15085
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerInfoDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x04003AEE RID: 15086
		private static readonly IntPtr NativeMethodInfoPtr_GetMappedSpecialGuestDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x04003AEF RID: 15087
		private static readonly IntPtr NativeMethodInfoPtr_LoadActivePlayerSkinAsync_Public_Static_UniTask_Clothes_0;

		// Token: 0x04003AF0 RID: 15088
		private static readonly IntPtr NativeMethodInfoPtr_UnloadActivePlayerSkin_Public_Static_Void_0;

		// Token: 0x04003AF1 RID: 15089
		private static readonly IntPtr NativeMethodInfoPtr_SetupPortrayalVisual_Public_Static_Boolean_Image_MonoBehaviour_byref_Coroutine_0;

		// Token: 0x04003AF2 RID: 15090
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_GameObject_CharacterPortrayal_CharacterSpriteSetFull_CharacterSpriteSetCompact_CharacterProtrayalSet_CharacterSkinSets_Color_Color_Dictionary_2_String_Character_Dictionary_2_String_DataBaseCharacterData_0;

		// Token: 0x04003AF3 RID: 15091
		private static readonly IntPtr NativeMethodInfoPtr_PopulateNullValues_Private_Static_GuestProfilePair_GuestProfilePair_GuestProfilePair_0;

		// Token: 0x04003AF4 RID: 15092
		private static readonly IntPtr NativeMethodInfoPtr_PopulateNullValues_Private_Static_Il2CppReferenceArray_1_CharacterSpriteSetCompact_Il2CppReferenceArray_1_CharacterSpriteSetCompact_CharacterSpriteSetCompact_0;

		// Token: 0x04003AF5 RID: 15093
		private static readonly IntPtr NativeMethodInfoPtr_NormalGuestExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003AF6 RID: 15094
		private static readonly IntPtr NativeMethodInfoPtr_RefNGuest_Public_Static_NormalGuest_Int32_0;

		// Token: 0x04003AF7 RID: 15095
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecialGuestMapped_Public_Static_Boolean_Int32_0;

		// Token: 0x04003AF8 RID: 15096
		private static readonly IntPtr NativeMethodInfoPtr_RefSGuest_Public_Static_SpecialGuest_String_0;

		// Token: 0x04003AF9 RID: 15097
		private static readonly IntPtr NativeMethodInfoPtr_RefSGuest_Public_Static_SpecialGuest_Int32_0;

		// Token: 0x04003AFA RID: 15098
		private static readonly IntPtr NativeMethodInfoPtr_MappedID2TargetID_Public_Static_Int32_Int32_0;

		// Token: 0x04003AFB RID: 15099
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNormalGuests_Public_Static_Il2CppReferenceArray_1_NormalGuest_0;

		// Token: 0x04003AFC RID: 15100
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSpecialGuests_Public_Static_Il2CppReferenceArray_1_SpecialGuest_0;

		// Token: 0x04003AFD RID: 15101
		private static readonly IntPtr NativeMethodInfoPtr_SpecialGuestExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003AFE RID: 15102
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMappedGuests_Public_Static_Il2CppReferenceArray_1_MappedSpecialGuest_0;

		// Token: 0x04003AFF RID: 15103
		private static readonly IntPtr NativeMethodInfoPtr_PreinitSpecialGuests_Private_Static_Void_0;

		// Token: 0x04003B00 RID: 15104
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestsAndMappedGuests_Public_Static_Il2CppReferenceArray_1_SpecialGuest_0;

		// Token: 0x04003B01 RID: 15105
		private static readonly IntPtr NativeMethodInfoPtr_GetMappedSpecialGuests_Public_Static_Dictionary_2_String_Il2CppReferenceArray_1_SpecialGuest_0;

		// Token: 0x04003B02 RID: 15106
		private static readonly IntPtr NativeMethodInfoPtr_RefPartnerInfo_Public_Static_PartnerInfoBase_Int32_0;

		// Token: 0x04003B03 RID: 15107
		private static readonly IntPtr NativeMethodInfoPtr_CheckIdIsPartner_Public_Static_Boolean_Int32_0;

		// Token: 0x04003B04 RID: 15108
		private static readonly IntPtr NativeMethodInfoPtr_CheckIdIsBossPartner_Public_Static_Boolean_Int32_0;

		// Token: 0x04003B05 RID: 15109
		private static readonly IntPtr NativeMethodInfoPtr_GetAllValidPartnerIndex_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x04003B06 RID: 15110
		private static readonly IntPtr NativeMethodInfoPtr_AsCharacterSpriteSet_Public_Static_Il2CppReferenceArray_1_Sprite_Sprite_0;

		// Token: 0x04003B07 RID: 15111
		private static readonly IntPtr NativeMethodInfoPtr_RefNormalGuestVisual_Public_Static_GuestProfilePair_Int32_0;

		// Token: 0x04003B08 RID: 15112
		private static readonly IntPtr NativeMethodInfoPtr_RefDaySceneNormalGuestVisual_Public_Static_CharacterSpriteSetCompact_Int32_0;

		// Token: 0x04003B09 RID: 15113
		private static readonly IntPtr NativeMethodInfoPtr_RefSpecialGuestVisual_Public_Static_GuestProfilePair_Int32_0;

		// Token: 0x04003B0A RID: 15114
		private static readonly IntPtr NativeMethodInfoPtr_RefNPCIdentity_Public_Static_Character_String_0;

		// Token: 0x04003B0B RID: 15115
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCLabel_Public_Static_String_Character_0;

		// Token: 0x04003B0C RID: 15116
		private static readonly IntPtr NativeMethodInfoPtr_RefNPCVisual_Public_Static_CharacterSpriteSetCompact_String_0;

		// Token: 0x04003B0D RID: 15117
		private static readonly IntPtr NativeMethodInfoPtr_CheckCharacterHasSpell_Public_Static_Boolean_Int32_0;

		// Token: 0x04003B0E RID: 15118
		private static readonly IntPtr NativeMethodInfoPtr_GetAllOriginSGuestMapping_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x04003B0F RID: 15119
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTargetSGuestMapping_Public_Static_Boolean_Int32_byref_Int32_0;

		// Token: 0x04003B10 RID: 15120
		private static readonly IntPtr NativeMethodInfoPtr_TryGetOriginalSGuestFromMapping_Public_Static_Boolean_Int32_byref_Int32_0;

		// Token: 0x02000C85 RID: 3205
		public class DataBaseCharacterData : Il2CppSystem.Object
		{
			// Token: 0x0600E625 RID: 58917 RVA: 0x00373BE0 File Offset: 0x00371DE0
			// Note: this type is marked as 'beforefieldinit'.
			static DataBaseCharacterData()
			{
				Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "DataBaseCharacterData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr);
				DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__NormalGuestVisual_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, "<NormalGuestVisual>k__BackingField");
				DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__SpecialGuestVisual_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, "<SpecialGuestVisual>k__BackingField");
				DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__DaySceneNormalGuestVisual_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, "<DaySceneNormalGuestVisual>k__BackingField");
				DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__NormalGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, "<NormalGuest>k__BackingField");
				DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__SpecialGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, "<SpecialGuest>k__BackingField");
				DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__CharacterHasSpell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, "<CharacterHasSpell>k__BackingField");
				DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__PartnerInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, "<PartnerInfo>k__BackingField");
				DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__MappedSpecialGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, "<MappedSpecialGuest>k__BackingField");
				DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__SpecialGuestMappingRules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, "<SpecialGuestMappingRules>k__BackingField");
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_Dictionary_2_Int32_GuestProfilePair_Dictionary_2_Int32_CharacterSpriteSetCompact_Dictionary_2_Int32_NormalGuest_Dictionary_2_Int32_SpecialGuest_Dictionary_2_Int32_PartnerInfoBase_Dictionary_2_Int32_MappedSpecialGuest_List_1_Il2CppStructArray_1_Int32_Dictionary_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681164);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_NormalGuestVisual_Internal_get_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681165);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_NormalGuestVisual_Internal_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681166);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_SpecialGuestVisual_Internal_get_Dictionary_2_Int32_GuestProfilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681167);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_SpecialGuestVisual_Internal_set_Void_Dictionary_2_Int32_GuestProfilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681168);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_DaySceneNormalGuestVisual_Internal_get_Dictionary_2_Int32_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681169);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_DaySceneNormalGuestVisual_Internal_set_Void_Dictionary_2_Int32_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681170);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_NormalGuest_Internal_get_Dictionary_2_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681171);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_NormalGuest_Internal_set_Void_Dictionary_2_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681172);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_SpecialGuest_Internal_get_Dictionary_2_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681173);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_SpecialGuest_Internal_set_Void_Dictionary_2_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681174);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_CharacterHasSpell_Internal_get_Dictionary_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681175);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_CharacterHasSpell_Internal_set_Void_Dictionary_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681176);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_PartnerInfo_Internal_get_Dictionary_2_Int32_PartnerInfoBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681177);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_PartnerInfo_Internal_set_Void_Dictionary_2_Int32_PartnerInfoBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681178);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_MappedSpecialGuest_Internal_get_Dictionary_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681179);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_MappedSpecialGuest_Internal_set_Void_Dictionary_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681180);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_SpecialGuestMappingRules_Internal_get_List_1_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681181);
				DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_SpecialGuestMappingRules_Internal_set_Void_List_1_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr, 100681182);
			}

			// Token: 0x0600E626 RID: 58918 RVA: 0x00373E3C File Offset: 0x0037203C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 216223, RefRangeEnd = 216224, XrefRangeStart = 216213, XrefRangeEnd = 216223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataBaseCharacterData(Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>> normalGuestVisual, Dictionary<int, GuestProfilePair> specialGuestVisual, Dictionary<int, CharacterSpriteSetCompact> daySceneNormalGuestVisual, Dictionary<int, NormalGuest> normalGuest, Dictionary<int, SpecialGuest> specialGuest, Dictionary<int, PartnerInfoBase> partnerInfo, Dictionary<int, MappedSpecialGuest> mappedSpecialGuestData, List<Il2CppStructArray<int>> specialGuestMappingRules, Dictionary<int, bool> characterHasSpell) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter.DataBaseCharacterData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalGuestVisual);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuestVisual);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(daySceneNormalGuestVisual);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalGuest);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuest);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerInfo);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mappedSpecialGuestData);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuestMappingRules);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterHasSpell);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_Dictionary_2_Int32_GuestProfilePair_Dictionary_2_Int32_CharacterSpriteSetCompact_Dictionary_2_Int32_NormalGuest_Dictionary_2_Int32_SpecialGuest_Dictionary_2_Int32_PartnerInfoBase_Dictionary_2_Int32_MappedSpecialGuest_List_1_Il2CppStructArray_1_Int32_Dictionary_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004AA8 RID: 19112
			// (get) Token: 0x0600E627 RID: 58919 RVA: 0x00373F20 File Offset: 0x00372120
			// (set) Token: 0x0600E628 RID: 58920 RVA: 0x00373F60 File Offset: 0x00372160
			public unsafe Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>> NormalGuestVisual
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_NormalGuestVisual_Internal_get_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>>(intPtr3) : null;
				}
				[CallerCount(18)]
				[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_NormalGuestVisual_Internal_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004AA9 RID: 19113
			// (get) Token: 0x0600E629 RID: 58921 RVA: 0x00373FA4 File Offset: 0x003721A4
			// (set) Token: 0x0600E62A RID: 58922 RVA: 0x00373FE4 File Offset: 0x003721E4
			public unsafe Dictionary<int, GuestProfilePair> SpecialGuestVisual
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_SpecialGuestVisual_Internal_get_Dictionary_2_Int32_GuestProfilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestProfilePair>>(intPtr3) : null;
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_SpecialGuestVisual_Internal_set_Void_Dictionary_2_Int32_GuestProfilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004AAA RID: 19114
			// (get) Token: 0x0600E62B RID: 58923 RVA: 0x00374028 File Offset: 0x00372228
			// (set) Token: 0x0600E62C RID: 58924 RVA: 0x00374068 File Offset: 0x00372268
			public unsafe Dictionary<int, CharacterSpriteSetCompact> DaySceneNormalGuestVisual
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_DaySceneNormalGuestVisual_Internal_get_Dictionary_2_Int32_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, CharacterSpriteSetCompact>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_DaySceneNormalGuestVisual_Internal_set_Void_Dictionary_2_Int32_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004AAB RID: 19115
			// (get) Token: 0x0600E62D RID: 58925 RVA: 0x003740AC File Offset: 0x003722AC
			// (set) Token: 0x0600E62E RID: 58926 RVA: 0x003740EC File Offset: 0x003722EC
			public unsafe Dictionary<int, NormalGuest> NormalGuest
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_NormalGuest_Internal_get_Dictionary_2_Int32_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, NormalGuest>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_NormalGuest_Internal_set_Void_Dictionary_2_Int32_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004AAC RID: 19116
			// (get) Token: 0x0600E62F RID: 58927 RVA: 0x00374130 File Offset: 0x00372330
			// (set) Token: 0x0600E630 RID: 58928 RVA: 0x00374170 File Offset: 0x00372370
			public unsafe Dictionary<int, SpecialGuest> SpecialGuest
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_SpecialGuest_Internal_get_Dictionary_2_Int32_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SpecialGuest>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_SpecialGuest_Internal_set_Void_Dictionary_2_Int32_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004AAD RID: 19117
			// (get) Token: 0x0600E631 RID: 58929 RVA: 0x003741B4 File Offset: 0x003723B4
			// (set) Token: 0x0600E632 RID: 58930 RVA: 0x003741F4 File Offset: 0x003723F4
			public unsafe Dictionary<int, bool> CharacterHasSpell
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_CharacterHasSpell_Internal_get_Dictionary_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 98510, RefRangeEnd = 98511, XrefRangeStart = 98510, XrefRangeEnd = 98511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_CharacterHasSpell_Internal_set_Void_Dictionary_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004AAE RID: 19118
			// (get) Token: 0x0600E633 RID: 58931 RVA: 0x00374238 File Offset: 0x00372438
			// (set) Token: 0x0600E634 RID: 58932 RVA: 0x00374278 File Offset: 0x00372478
			public unsafe Dictionary<int, PartnerInfoBase> PartnerInfo
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_PartnerInfo_Internal_get_Dictionary_2_Int32_PartnerInfoBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PartnerInfoBase>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_PartnerInfo_Internal_set_Void_Dictionary_2_Int32_PartnerInfoBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004AAF RID: 19119
			// (get) Token: 0x0600E635 RID: 58933 RVA: 0x003742BC File Offset: 0x003724BC
			// (set) Token: 0x0600E636 RID: 58934 RVA: 0x003742FC File Offset: 0x003724FC
			public unsafe Dictionary<int, MappedSpecialGuest> MappedSpecialGuest
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_MappedSpecialGuest_Internal_get_Dictionary_2_Int32_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MappedSpecialGuest>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 157648, RefRangeEnd = 157649, XrefRangeStart = 157648, XrefRangeEnd = 157649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_MappedSpecialGuest_Internal_set_Void_Dictionary_2_Int32_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004AB0 RID: 19120
			// (get) Token: 0x0600E637 RID: 58935 RVA: 0x00374340 File Offset: 0x00372540
			// (set) Token: 0x0600E638 RID: 58936 RVA: 0x00374380 File Offset: 0x00372580
			public unsafe List<Il2CppStructArray<int>> SpecialGuestMappingRules
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_get_SpecialGuestMappingRules_Internal_get_List_1_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<int>>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.DataBaseCharacterData.NativeMethodInfoPtr_set_SpecialGuestMappingRules_Internal_set_Void_List_1_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600E639 RID: 58937 RVA: 0x0007AE16 File Offset: 0x00079016
			public DataBaseCharacterData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A9F RID: 19103
			// (get) Token: 0x0600E63A RID: 58938 RVA: 0x003743C4 File Offset: 0x003725C4
			// (set) Token: 0x0600E63B RID: 58939 RVA: 0x0007AE1F File Offset: 0x0007901F
			public unsafe Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>> _NormalGuestVisual_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__NormalGuestVisual_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__NormalGuestVisual_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA0 RID: 19104
			// (get) Token: 0x0600E63C RID: 58940 RVA: 0x003743F4 File Offset: 0x003725F4
			// (set) Token: 0x0600E63D RID: 58941 RVA: 0x0007AE3E File Offset: 0x0007903E
			public unsafe Dictionary<int, GuestProfilePair> _SpecialGuestVisual_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__SpecialGuestVisual_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestProfilePair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__SpecialGuestVisual_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA1 RID: 19105
			// (get) Token: 0x0600E63E RID: 58942 RVA: 0x00374424 File Offset: 0x00372624
			// (set) Token: 0x0600E63F RID: 58943 RVA: 0x0007AE5D File Offset: 0x0007905D
			public unsafe Dictionary<int, CharacterSpriteSetCompact> _DaySceneNormalGuestVisual_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__DaySceneNormalGuestVisual_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, CharacterSpriteSetCompact>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__DaySceneNormalGuestVisual_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA2 RID: 19106
			// (get) Token: 0x0600E640 RID: 58944 RVA: 0x00374454 File Offset: 0x00372654
			// (set) Token: 0x0600E641 RID: 58945 RVA: 0x0007AE7C File Offset: 0x0007907C
			public unsafe Dictionary<int, NormalGuest> _NormalGuest_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__NormalGuest_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, NormalGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__NormalGuest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA3 RID: 19107
			// (get) Token: 0x0600E642 RID: 58946 RVA: 0x00374484 File Offset: 0x00372684
			// (set) Token: 0x0600E643 RID: 58947 RVA: 0x0007AE9B File Offset: 0x0007909B
			public unsafe Dictionary<int, SpecialGuest> _SpecialGuest_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__SpecialGuest_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__SpecialGuest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA4 RID: 19108
			// (get) Token: 0x0600E644 RID: 58948 RVA: 0x003744B4 File Offset: 0x003726B4
			// (set) Token: 0x0600E645 RID: 58949 RVA: 0x0007AEBA File Offset: 0x000790BA
			public unsafe Dictionary<int, bool> _CharacterHasSpell_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__CharacterHasSpell_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__CharacterHasSpell_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA5 RID: 19109
			// (get) Token: 0x0600E646 RID: 58950 RVA: 0x003744E4 File Offset: 0x003726E4
			// (set) Token: 0x0600E647 RID: 58951 RVA: 0x0007AED9 File Offset: 0x000790D9
			public unsafe Dictionary<int, PartnerInfoBase> _PartnerInfo_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__PartnerInfo_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PartnerInfoBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__PartnerInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA6 RID: 19110
			// (get) Token: 0x0600E648 RID: 58952 RVA: 0x00374514 File Offset: 0x00372714
			// (set) Token: 0x0600E649 RID: 58953 RVA: 0x0007AEF8 File Offset: 0x000790F8
			public unsafe Dictionary<int, MappedSpecialGuest> _MappedSpecialGuest_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__MappedSpecialGuest_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MappedSpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__MappedSpecialGuest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA7 RID: 19111
			// (get) Token: 0x0600E64A RID: 58954 RVA: 0x00374544 File Offset: 0x00372744
			// (set) Token: 0x0600E64B RID: 58955 RVA: 0x0007AF17 File Offset: 0x00079117
			public unsafe List<Il2CppStructArray<int>> _SpecialGuestMappingRules_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__SpecialGuestMappingRules_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.DataBaseCharacterData.NativeFieldInfoPtr__SpecialGuestMappingRules_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092FF RID: 37631
			private static readonly IntPtr NativeFieldInfoPtr__NormalGuestVisual_k__BackingField;

			// Token: 0x04009300 RID: 37632
			private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestVisual_k__BackingField;

			// Token: 0x04009301 RID: 37633
			private static readonly IntPtr NativeFieldInfoPtr__DaySceneNormalGuestVisual_k__BackingField;

			// Token: 0x04009302 RID: 37634
			private static readonly IntPtr NativeFieldInfoPtr__NormalGuest_k__BackingField;

			// Token: 0x04009303 RID: 37635
			private static readonly IntPtr NativeFieldInfoPtr__SpecialGuest_k__BackingField;

			// Token: 0x04009304 RID: 37636
			private static readonly IntPtr NativeFieldInfoPtr__CharacterHasSpell_k__BackingField;

			// Token: 0x04009305 RID: 37637
			private static readonly IntPtr NativeFieldInfoPtr__PartnerInfo_k__BackingField;

			// Token: 0x04009306 RID: 37638
			private static readonly IntPtr NativeFieldInfoPtr__MappedSpecialGuest_k__BackingField;

			// Token: 0x04009307 RID: 37639
			private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestMappingRules_k__BackingField;

			// Token: 0x04009308 RID: 37640
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_Dictionary_2_Int32_GuestProfilePair_Dictionary_2_Int32_CharacterSpriteSetCompact_Dictionary_2_Int32_NormalGuest_Dictionary_2_Int32_SpecialGuest_Dictionary_2_Int32_PartnerInfoBase_Dictionary_2_Int32_MappedSpecialGuest_List_1_Il2CppStructArray_1_Int32_Dictionary_2_Int32_Boolean_0;

			// Token: 0x04009309 RID: 37641
			private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestVisual_Internal_get_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0;

			// Token: 0x0400930A RID: 37642
			private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuestVisual_Internal_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0;

			// Token: 0x0400930B RID: 37643
			private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestVisual_Internal_get_Dictionary_2_Int32_GuestProfilePair_0;

			// Token: 0x0400930C RID: 37644
			private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestVisual_Internal_set_Void_Dictionary_2_Int32_GuestProfilePair_0;

			// Token: 0x0400930D RID: 37645
			private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneNormalGuestVisual_Internal_get_Dictionary_2_Int32_CharacterSpriteSetCompact_0;

			// Token: 0x0400930E RID: 37646
			private static readonly IntPtr NativeMethodInfoPtr_set_DaySceneNormalGuestVisual_Internal_set_Void_Dictionary_2_Int32_CharacterSpriteSetCompact_0;

			// Token: 0x0400930F RID: 37647
			private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuest_Internal_get_Dictionary_2_Int32_NormalGuest_0;

			// Token: 0x04009310 RID: 37648
			private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuest_Internal_set_Void_Dictionary_2_Int32_NormalGuest_0;

			// Token: 0x04009311 RID: 37649
			private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuest_Internal_get_Dictionary_2_Int32_SpecialGuest_0;

			// Token: 0x04009312 RID: 37650
			private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuest_Internal_set_Void_Dictionary_2_Int32_SpecialGuest_0;

			// Token: 0x04009313 RID: 37651
			private static readonly IntPtr NativeMethodInfoPtr_get_CharacterHasSpell_Internal_get_Dictionary_2_Int32_Boolean_0;

			// Token: 0x04009314 RID: 37652
			private static readonly IntPtr NativeMethodInfoPtr_set_CharacterHasSpell_Internal_set_Void_Dictionary_2_Int32_Boolean_0;

			// Token: 0x04009315 RID: 37653
			private static readonly IntPtr NativeMethodInfoPtr_get_PartnerInfo_Internal_get_Dictionary_2_Int32_PartnerInfoBase_0;

			// Token: 0x04009316 RID: 37654
			private static readonly IntPtr NativeMethodInfoPtr_set_PartnerInfo_Internal_set_Void_Dictionary_2_Int32_PartnerInfoBase_0;

			// Token: 0x04009317 RID: 37655
			private static readonly IntPtr NativeMethodInfoPtr_get_MappedSpecialGuest_Internal_get_Dictionary_2_Int32_MappedSpecialGuest_0;

			// Token: 0x04009318 RID: 37656
			private static readonly IntPtr NativeMethodInfoPtr_set_MappedSpecialGuest_Internal_set_Void_Dictionary_2_Int32_MappedSpecialGuest_0;

			// Token: 0x04009319 RID: 37657
			private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestMappingRules_Internal_get_List_1_Il2CppStructArray_1_Int32_0;

			// Token: 0x0400931A RID: 37658
			private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestMappingRules_Internal_set_Void_List_1_Il2CppStructArray_1_Int32_0;
		}

		// Token: 0x02000C86 RID: 3206
		[ObfuscatedName("GameData.Core.Collections.CharacterUtility.DataBaseCharacter+<LoadActivePlayerSkinAsync>d__140")]
		public sealed class _LoadActivePlayerSkinAsync_d__140 : ValueType
		{
			// Token: 0x0600E64C RID: 58956 RVA: 0x00374574 File Offset: 0x00372774
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadActivePlayerSkinAsync_d__140()
			{
				Il2CppClassPointerStore<DataBaseCharacter._LoadActivePlayerSkinAsync_d__140>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<LoadActivePlayerSkinAsync>d__140");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter._LoadActivePlayerSkinAsync_d__140>.NativeClassPtr);
				DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter._LoadActivePlayerSkinAsync_d__140>.NativeClassPtr, "<>1__state");
				DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter._LoadActivePlayerSkinAsync_d__140>.NativeClassPtr, "<>t__builder");
				DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr_clothesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter._LoadActivePlayerSkinAsync_d__140>.NativeClassPtr, "clothesData");
				DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter._LoadActivePlayerSkinAsync_d__140>.NativeClassPtr, "<>u__1");
				DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter._LoadActivePlayerSkinAsync_d__140>.NativeClassPtr, "<>u__2");
				DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter._LoadActivePlayerSkinAsync_d__140>.NativeClassPtr, 100681183);
				DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter._LoadActivePlayerSkinAsync_d__140>.NativeClassPtr, 100681184);
			}

			// Token: 0x0600E64D RID: 58957 RVA: 0x0037462C File Offset: 0x0037282C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 216311, RefRangeEnd = 216314, XrefRangeStart = 216224, XrefRangeEnd = 216311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E64E RID: 58958 RVA: 0x00374664 File Offset: 0x00372864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E64F RID: 58959 RVA: 0x0007AF36 File Offset: 0x00079136
			public _LoadActivePlayerSkinAsync_d__140(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E650 RID: 58960 RVA: 0x0007AF3F File Offset: 0x0007913F
			public _LoadActivePlayerSkinAsync_d__140() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter._LoadActivePlayerSkinAsync_d__140>.NativeClassPtr))
			{
			}

			// Token: 0x17004AB1 RID: 19121
			// (get) Token: 0x0600E651 RID: 58961 RVA: 0x003746AC File Offset: 0x003728AC
			// (set) Token: 0x0600E652 RID: 58962 RVA: 0x0007AF51 File Offset: 0x00079151
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004AB2 RID: 19122
			// (get) Token: 0x0600E653 RID: 58963 RVA: 0x003746D4 File Offset: 0x003728D4
			// (set) Token: 0x0600E654 RID: 58964 RVA: 0x0007AF6C File Offset: 0x0007916C
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004AB3 RID: 19123
			// (get) Token: 0x0600E655 RID: 58965 RVA: 0x00374704 File Offset: 0x00372904
			// (set) Token: 0x0600E656 RID: 58966 RVA: 0x0007AF9A File Offset: 0x0007919A
			public unsafe ClothesProfile.Clothes clothesData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr_clothesData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothesProfile.Clothes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr_clothesData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AB4 RID: 19124
			// (get) Token: 0x0600E657 RID: 58967 RVA: 0x00374734 File Offset: 0x00372934
			// (set) Token: 0x0600E658 RID: 58968 RVA: 0x0007AFB9 File Offset: 0x000791B9
			public UniTask<IAssetHandle<Sprite>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<Sprite>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<Sprite>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<Sprite>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004AB5 RID: 19125
			// (get) Token: 0x0600E659 RID: 58969 RVA: 0x00374764 File Offset: 0x00372964
			// (set) Token: 0x0600E65A RID: 58970 RVA: 0x0007AFE7 File Offset: 0x000791E7
			public UniTask<IAssetHandleArray<Sprite>>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___u__2);
					return new UniTask<IAssetHandleArray<Sprite>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandleArray<Sprite>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter._LoadActivePlayerSkinAsync_d__140.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandleArray<Sprite>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400931B RID: 37659
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400931C RID: 37660
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400931D RID: 37661
			private static readonly IntPtr NativeFieldInfoPtr_clothesData;

			// Token: 0x0400931E RID: 37662
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400931F RID: 37663
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04009320 RID: 37664
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009321 RID: 37665
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000C87 RID: 3207
		[ObfuscatedName("GameData.Core.Collections.CharacterUtility.DataBaseCharacter+<>c__DisplayClass142_0")]
		public sealed class __c__DisplayClass142_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E65B RID: 58971 RVA: 0x00374794 File Offset: 0x00372994
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass142_0()
			{
				Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<>c__DisplayClass142_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0>.NativeClassPtr);
				DataBaseCharacter.__c__DisplayClass142_0.NativeFieldInfoPtr_imageComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0>.NativeClassPtr, "imageComponent");
				DataBaseCharacter.__c__DisplayClass142_0.NativeFieldInfoPtr_waitForSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0>.NativeClassPtr, "waitForSeconds");
				DataBaseCharacter.__c__DisplayClass142_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0>.NativeClassPtr, 100681185);
				DataBaseCharacter.__c__DisplayClass142_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0>.NativeClassPtr, 100681186);
			}

			// Token: 0x0600E65C RID: 58972 RVA: 0x00374810 File Offset: 0x00372A10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass142_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass142_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E65D RID: 58973 RVA: 0x0037484C File Offset: 0x00372A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216342, XrefRangeEnd = 216347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass142_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E65E RID: 58974 RVA: 0x0007B015 File Offset: 0x00079215
			public __c__DisplayClass142_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AB6 RID: 19126
			// (get) Token: 0x0600E65F RID: 58975 RVA: 0x0037488C File Offset: 0x00372A8C
			// (set) Token: 0x0600E660 RID: 58976 RVA: 0x0007B01E File Offset: 0x0007921E
			public unsafe Image imageComponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.NativeFieldInfoPtr_imageComponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.NativeFieldInfoPtr_imageComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AB7 RID: 19127
			// (get) Token: 0x0600E661 RID: 58977 RVA: 0x003748BC File Offset: 0x00372ABC
			// (set) Token: 0x0600E662 RID: 58978 RVA: 0x0007B03D File Offset: 0x0007923D
			public unsafe WaitForSecondsRealtime waitForSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.NativeFieldInfoPtr_waitForSeconds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSecondsRealtime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.NativeFieldInfoPtr_waitForSeconds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009322 RID: 37666
			private static readonly IntPtr NativeFieldInfoPtr_imageComponent;

			// Token: 0x04009323 RID: 37667
			private static readonly IntPtr NativeFieldInfoPtr_waitForSeconds;

			// Token: 0x04009324 RID: 37668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009325 RID: 37669
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200105C RID: 4188
			[ObfuscatedName("GameData.Core.Collections.CharacterUtility.DataBaseCharacter+<>c__DisplayClass142_0+<<SetupPortrayalVisual>g__AnimatorCoroutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011E59 RID: 73305 RVA: 0x00417C1C File Offset: 0x00415E1C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique()
				{
					Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0>.NativeClassPtr, "<<SetupPortrayalVisual>g__AnimatorCoroutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr);
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, "<>1__state");
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, "<>2__current");
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, "<>4__this");
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr__length_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, "<length>5__2");
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, "<i>5__3");
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, 100681187);
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, 100681188);
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, 100681189);
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, 100681190);
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, 100681191);
					DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr, 100681192);
				}

				// Token: 0x06011E5A RID: 73306 RVA: 0x00417D24 File Offset: 0x00415F24
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E5B RID: 73307 RVA: 0x00417D6C File Offset: 0x00415F6C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E5C RID: 73308 RVA: 0x00417DA0 File Offset: 0x00415FA0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216314, XrefRangeEnd = 216336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D4E RID: 23886
				// (get) Token: 0x06011E5D RID: 73309 RVA: 0x00417DDC File Offset: 0x00415FDC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E5E RID: 73310 RVA: 0x00417E1C File Offset: 0x0041601C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216336, XrefRangeEnd = 216342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D4F RID: 23887
				// (get) Token: 0x06011E5F RID: 73311 RVA: 0x00417E50 File Offset: 0x00416050
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E60 RID: 73312 RVA: 0x0009B812 File Offset: 0x00099A12
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D49 RID: 23881
				// (get) Token: 0x06011E61 RID: 73313 RVA: 0x00417E90 File Offset: 0x00416090
				// (set) Token: 0x06011E62 RID: 73314 RVA: 0x0009B81B File Offset: 0x00099A1B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D4A RID: 23882
				// (get) Token: 0x06011E63 RID: 73315 RVA: 0x00417EB8 File Offset: 0x004160B8
				// (set) Token: 0x06011E64 RID: 73316 RVA: 0x0009B836 File Offset: 0x00099A36
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D4B RID: 23883
				// (get) Token: 0x06011E65 RID: 73317 RVA: 0x00417EE8 File Offset: 0x004160E8
				// (set) Token: 0x06011E66 RID: 73318 RVA: 0x0009B855 File Offset: 0x00099A55
				public unsafe DataBaseCharacter.__c__DisplayClass142_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCharacter.__c__DisplayClass142_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D4C RID: 23884
				// (get) Token: 0x06011E67 RID: 73319 RVA: 0x00417F18 File Offset: 0x00416118
				// (set) Token: 0x06011E68 RID: 73320 RVA: 0x0009B874 File Offset: 0x00099A74
				public unsafe int _length_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr__length_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr__length_5__2)) = value;
					}
				}

				// Token: 0x17005D4D RID: 23885
				// (get) Token: 0x06011E69 RID: 73321 RVA: 0x00417F40 File Offset: 0x00416140
				// (set) Token: 0x06011E6A RID: 73322 RVA: 0x0009B88F File Offset: 0x00099A8F
				public unsafe int _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass142_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400B4E1 RID: 46305
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B4E2 RID: 46306
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B4E3 RID: 46307
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B4E4 RID: 46308
				private static readonly IntPtr NativeFieldInfoPtr__length_5__2;

				// Token: 0x0400B4E5 RID: 46309
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400B4E6 RID: 46310
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B4E7 RID: 46311
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4E8 RID: 46312
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B4E9 RID: 46313
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B4EA RID: 46314
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4EB RID: 46315
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C88 RID: 3208
		[ObfuscatedName("GameData.Core.Collections.CharacterUtility.DataBaseCharacter+<>c__DisplayClass143_0")]
		public sealed class __c__DisplayClass143_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E663 RID: 58979 RVA: 0x003748EC File Offset: 0x00372AEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass143_0()
			{
				Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass143_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<>c__DisplayClass143_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass143_0>.NativeClassPtr);
				DataBaseCharacter.__c__DisplayClass143_0.NativeFieldInfoPtr_reverseSpecialGuestMappingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass143_0>.NativeClassPtr, "reverseSpecialGuestMappingRules");
				DataBaseCharacter.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass143_0>.NativeClassPtr, 100681193);
				DataBaseCharacter.__c__DisplayClass143_0.NativeMethodInfoPtr__Initialize_b__15_Internal_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass143_0>.NativeClassPtr, 100681194);
			}

			// Token: 0x0600E664 RID: 58980 RVA: 0x00374954 File Offset: 0x00372B54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass143_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass143_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E665 RID: 58981 RVA: 0x00374990 File Offset: 0x00372B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216347, XrefRangeEnd = 216460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__15(Il2CppStructArray<int> guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass143_0.NativeMethodInfoPtr__Initialize_b__15_Internal_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E666 RID: 58982 RVA: 0x0007B05C File Offset: 0x0007925C
			public __c__DisplayClass143_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AB8 RID: 19128
			// (get) Token: 0x0600E667 RID: 58983 RVA: 0x003749D4 File Offset: 0x00372BD4
			// (set) Token: 0x0600E668 RID: 58984 RVA: 0x0007B065 File Offset: 0x00079265
			public unsafe List<int> reverseSpecialGuestMappingRules
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass143_0.NativeFieldInfoPtr_reverseSpecialGuestMappingRules);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass143_0.NativeFieldInfoPtr_reverseSpecialGuestMappingRules), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009326 RID: 37670
			private static readonly IntPtr NativeFieldInfoPtr_reverseSpecialGuestMappingRules;

			// Token: 0x04009327 RID: 37671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009328 RID: 37672
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__15_Internal_Void_Il2CppStructArray_1_Int32_0;
		}

		// Token: 0x02000C89 RID: 3209
		[ObfuscatedName("GameData.Core.Collections.CharacterUtility.DataBaseCharacter+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E669 RID: 58985 RVA: 0x00374A04 File Offset: 0x00372C04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr);
				DataBaseCharacter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_0");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_1");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_2");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_3");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_4");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_5");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_6");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_7");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_8");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_9");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_10");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_11");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_12");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_13");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_14");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_16");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_17");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_18");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_19");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_20");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_21");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__143_22");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__156_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__156_0");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__156_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__156_1");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__158_0");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__158_1");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__158_3");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__158_2");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__161_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__161_0");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__162_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__162_3");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__162_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__162_0");
				DataBaseCharacter.__c.NativeFieldInfoPtr___9__162_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, "<>9__162_2");
				DataBaseCharacter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681196);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_0_Internal_Character_KeyValuePair_2_Character_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681197);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_1_Internal_Il2CppStringArray_KeyValuePair_2_Character_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681198);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_2_Internal_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681199);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_3_Internal_Int32_KeyValuePair_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681200);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_4_Internal_Il2CppReferenceArray_1_CharacterSpriteSetCompact_KeyValuePair_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681201);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_5_Internal_Dictionary_2_Int32_GuestProfilePair_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681202);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_6_Internal_Int32_KeyValuePair_2_Int32_GuestProfilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681203);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_7_Internal_GuestProfilePair_KeyValuePair_2_Int32_GuestProfilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681204);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_8_Internal_Dictionary_2_Int32_CharacterSpriteSetCompact_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681205);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_9_Internal_Dictionary_2_Int32_NormalGuest_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681206);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_10_Internal_Dictionary_2_Int32_SpecialGuest_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681207);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_11_Internal_Dictionary_2_Int32_PartnerInfoBase_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681208);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_12_Internal_Dictionary_2_Int32_MappedSpecialGuest_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681209);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_13_Internal_Dictionary_2_Int32_Boolean_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681210);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_14_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681211);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_16_Internal_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681212);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_17_Internal_Dictionary_2_Int32_GuestProfilePair_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681213);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_18_Internal_Dictionary_2_Int32_CharacterSpriteSetCompact_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681214);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_19_Internal_Dictionary_2_Int32_NormalGuest_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681215);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_20_Internal_Dictionary_2_Int32_SpecialGuest_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681216);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_21_Internal_Dictionary_2_Int32_PartnerInfoBase_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681217);
				DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_22_Internal_Dictionary_2_Int32_MappedSpecialGuest_DataBaseCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681218);
				DataBaseCharacter.__c.NativeMethodInfoPtr__PreinitSpecialGuests_b__156_0_Internal_Int32_KeyValuePair_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681219);
				DataBaseCharacter.__c.NativeMethodInfoPtr__PreinitSpecialGuests_b__156_1_Internal_SpecialGuest_KeyValuePair_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681220);
				DataBaseCharacter.__c.NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_0_Internal_String_KeyValuePair_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681221);
				DataBaseCharacter.__c.NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_1_Internal_String_KeyValuePair_2_String_List_1_KeyValuePair_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681222);
				DataBaseCharacter.__c.NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_2_Internal_Il2CppReferenceArray_1_SpecialGuest_KeyValuePair_2_String_List_1_KeyValuePair_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681223);
				DataBaseCharacter.__c.NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_3_Internal_SpecialGuest_KeyValuePair_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681224);
				DataBaseCharacter.__c.NativeMethodInfoPtr__CheckIdIsBossPartner_b__161_0_Internal_Boolean_KeyValuePair_2_Int32_PartnerInfoBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681225);
				DataBaseCharacter.__c.NativeMethodInfoPtr__GetAllValidPartnerIndex_b__162_0_Internal_IEnumerable_1_Int32_PartnerInfoBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681226);
				DataBaseCharacter.__c.NativeMethodInfoPtr__GetAllValidPartnerIndex_b__162_3_Internal_Int32_CompanionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681227);
				DataBaseCharacter.__c.NativeMethodInfoPtr__GetAllValidPartnerIndex_b__162_2_Internal_Int32_KeyValuePair_2_Int32_PartnerInfoBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr, 100681228);
			}

			// Token: 0x0600E66A RID: 58986 RVA: 0x00374F58 File Offset: 0x00373158
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E66B RID: 58987 RVA: 0x00374F94 File Offset: 0x00373194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216460, XrefRangeEnd = 216461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SchedulerNode.Character _Initialize_b__143_0(KeyValuePair<SchedulerNode.Character, HashSet<string>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_0_Internal_Character_KeyValuePair_2_Character_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E66C RID: 58988 RVA: 0x00374FE8 File Offset: 0x003731E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216461, XrefRangeEnd = 216465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStringArray _Initialize_b__143_1(KeyValuePair<SchedulerNode.Character, HashSet<string>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_1_Internal_Il2CppStringArray_KeyValuePair_2_Character_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}

			// Token: 0x0600E66D RID: 58989 RVA: 0x00375040 File Offset: 0x00373240
			[CallerCount(0)]
			public unsafe Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>> _Initialize_b__143_2(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_2_Internal_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>>(intPtr3) : null;
			}

			// Token: 0x0600E66E RID: 58990 RVA: 0x00375090 File Offset: 0x00373290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216465, XrefRangeEnd = 216466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__143_3(KeyValuePair<int, Il2CppReferenceArray<CharacterSpriteSetCompact>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_3_Internal_Int32_KeyValuePair_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E66F RID: 58991 RVA: 0x003750E4 File Offset: 0x003732E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216466, XrefRangeEnd = 216479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<CharacterSpriteSetCompact> _Initialize_b__143_4(KeyValuePair<int, Il2CppReferenceArray<CharacterSpriteSetCompact>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_4_Internal_Il2CppReferenceArray_1_CharacterSpriteSetCompact_KeyValuePair_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterSpriteSetCompact>>(intPtr3) : null;
			}

			// Token: 0x0600E670 RID: 58992 RVA: 0x0037513C File Offset: 0x0037333C
			[CallerCount(0)]
			public unsafe Dictionary<int, GuestProfilePair> _Initialize_b__143_5(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_5_Internal_Dictionary_2_Int32_GuestProfilePair_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestProfilePair>>(intPtr3) : null;
			}

			// Token: 0x0600E671 RID: 58993 RVA: 0x0037518C File Offset: 0x0037338C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216479, XrefRangeEnd = 216480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__143_6(KeyValuePair<int, GuestProfilePair> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_6_Internal_Int32_KeyValuePair_2_Int32_GuestProfilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E672 RID: 58994 RVA: 0x003751E0 File Offset: 0x003733E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216480, XrefRangeEnd = 216487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestProfilePair _Initialize_b__143_7(KeyValuePair<int, GuestProfilePair> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_7_Internal_GuestProfilePair_KeyValuePair_2_Int32_GuestProfilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestProfilePair>(intPtr3) : null;
			}

			// Token: 0x0600E673 RID: 58995 RVA: 0x00375238 File Offset: 0x00373438
			[CallerCount(0)]
			public unsafe Dictionary<int, CharacterSpriteSetCompact> _Initialize_b__143_8(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_8_Internal_Dictionary_2_Int32_CharacterSpriteSetCompact_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, CharacterSpriteSetCompact>>(intPtr3) : null;
			}

			// Token: 0x0600E674 RID: 58996 RVA: 0x00375288 File Offset: 0x00373488
			[CallerCount(0)]
			public unsafe Dictionary<int, NormalGuest> _Initialize_b__143_9(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_9_Internal_Dictionary_2_Int32_NormalGuest_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, NormalGuest>>(intPtr3) : null;
			}

			// Token: 0x0600E675 RID: 58997 RVA: 0x003752D8 File Offset: 0x003734D8
			[CallerCount(0)]
			public unsafe Dictionary<int, SpecialGuest> _Initialize_b__143_10(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_10_Internal_Dictionary_2_Int32_SpecialGuest_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SpecialGuest>>(intPtr3) : null;
			}

			// Token: 0x0600E676 RID: 58998 RVA: 0x00375328 File Offset: 0x00373528
			[CallerCount(0)]
			public unsafe Dictionary<int, PartnerInfoBase> _Initialize_b__143_11(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_11_Internal_Dictionary_2_Int32_PartnerInfoBase_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PartnerInfoBase>>(intPtr3) : null;
			}

			// Token: 0x0600E677 RID: 58999 RVA: 0x00375378 File Offset: 0x00373578
			[CallerCount(0)]
			public unsafe Dictionary<int, MappedSpecialGuest> _Initialize_b__143_12(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_12_Internal_Dictionary_2_Int32_MappedSpecialGuest_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MappedSpecialGuest>>(intPtr3) : null;
			}

			// Token: 0x0600E678 RID: 59000 RVA: 0x003753C8 File Offset: 0x003735C8
			[CallerCount(0)]
			public unsafe Dictionary<int, bool> _Initialize_b__143_13(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_13_Internal_Dictionary_2_Int32_Boolean_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr3) : null;
			}

			// Token: 0x0600E679 RID: 59001 RVA: 0x00375418 File Offset: 0x00373618
			[CallerCount(0)]
			public unsafe IEnumerable<Il2CppStructArray<int>> _Initialize_b__143_14(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_14_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppStructArray<int>>>(intPtr3) : null;
			}

			// Token: 0x0600E67A RID: 59002 RVA: 0x00375468 File Offset: 0x00373668
			[CallerCount(0)]
			public unsafe Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>> _Initialize_b__143_16(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_16_Internal_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>>(intPtr3) : null;
			}

			// Token: 0x0600E67B RID: 59003 RVA: 0x003754B8 File Offset: 0x003736B8
			[CallerCount(0)]
			public unsafe Dictionary<int, GuestProfilePair> _Initialize_b__143_17(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_17_Internal_Dictionary_2_Int32_GuestProfilePair_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestProfilePair>>(intPtr3) : null;
			}

			// Token: 0x0600E67C RID: 59004 RVA: 0x00375508 File Offset: 0x00373708
			[CallerCount(0)]
			public unsafe Dictionary<int, CharacterSpriteSetCompact> _Initialize_b__143_18(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_18_Internal_Dictionary_2_Int32_CharacterSpriteSetCompact_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, CharacterSpriteSetCompact>>(intPtr3) : null;
			}

			// Token: 0x0600E67D RID: 59005 RVA: 0x00375558 File Offset: 0x00373758
			[CallerCount(0)]
			public unsafe Dictionary<int, NormalGuest> _Initialize_b__143_19(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_19_Internal_Dictionary_2_Int32_NormalGuest_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, NormalGuest>>(intPtr3) : null;
			}

			// Token: 0x0600E67E RID: 59006 RVA: 0x003755A8 File Offset: 0x003737A8
			[CallerCount(0)]
			public unsafe Dictionary<int, SpecialGuest> _Initialize_b__143_20(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_20_Internal_Dictionary_2_Int32_SpecialGuest_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SpecialGuest>>(intPtr3) : null;
			}

			// Token: 0x0600E67F RID: 59007 RVA: 0x003755F8 File Offset: 0x003737F8
			[CallerCount(0)]
			public unsafe Dictionary<int, PartnerInfoBase> _Initialize_b__143_21(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_21_Internal_Dictionary_2_Int32_PartnerInfoBase_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PartnerInfoBase>>(intPtr3) : null;
			}

			// Token: 0x0600E680 RID: 59008 RVA: 0x00375648 File Offset: 0x00373848
			[CallerCount(0)]
			public unsafe Dictionary<int, MappedSpecialGuest> _Initialize_b__143_22(DataBaseCharacter.DataBaseCharacterData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__Initialize_b__143_22_Internal_Dictionary_2_Int32_MappedSpecialGuest_DataBaseCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MappedSpecialGuest>>(intPtr3) : null;
			}

			// Token: 0x0600E681 RID: 59009 RVA: 0x00375698 File Offset: 0x00373898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216487, XrefRangeEnd = 216488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PreinitSpecialGuests_b__156_0(KeyValuePair<int, MappedSpecialGuest> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__PreinitSpecialGuests_b__156_0_Internal_Int32_KeyValuePair_2_Int32_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E682 RID: 59010 RVA: 0x003756EC File Offset: 0x003738EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216488, XrefRangeEnd = 216491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuest _PreinitSpecialGuests_b__156_1(KeyValuePair<int, MappedSpecialGuest> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__PreinitSpecialGuests_b__156_1_Internal_SpecialGuest_KeyValuePair_2_Int32_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
			}

			// Token: 0x0600E683 RID: 59011 RVA: 0x00375744 File Offset: 0x00373944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216491, XrefRangeEnd = 216503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetMappedSpecialGuests_b__158_0(KeyValuePair<int, MappedSpecialGuest> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_0_Internal_String_KeyValuePair_2_Int32_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E684 RID: 59012 RVA: 0x00375794 File Offset: 0x00373994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216503, XrefRangeEnd = 216504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetMappedSpecialGuests_b__158_1(KeyValuePair<string, List<KeyValuePair<int, MappedSpecialGuest>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_1_Internal_String_KeyValuePair_2_String_List_1_KeyValuePair_2_Int32_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E685 RID: 59013 RVA: 0x003757E4 File Offset: 0x003739E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216504, XrefRangeEnd = 216527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<SpecialGuest> _GetMappedSpecialGuests_b__158_2(KeyValuePair<string, List<KeyValuePair<int, MappedSpecialGuest>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_2_Internal_Il2CppReferenceArray_1_SpecialGuest_KeyValuePair_2_String_List_1_KeyValuePair_2_Int32_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest>>(intPtr3) : null;
			}

			// Token: 0x0600E686 RID: 59014 RVA: 0x0037583C File Offset: 0x00373A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216527, XrefRangeEnd = 216539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuest _GetMappedSpecialGuests_b__158_3(KeyValuePair<int, MappedSpecialGuest> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_3_Internal_SpecialGuest_KeyValuePair_2_Int32_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
			}

			// Token: 0x0600E687 RID: 59015 RVA: 0x00375894 File Offset: 0x00373A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216539, XrefRangeEnd = 216540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckIdIsBossPartner_b__161_0(KeyValuePair<int, PartnerInfoBase> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__CheckIdIsBossPartner_b__161_0_Internal_Boolean_KeyValuePair_2_Int32_PartnerInfoBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E688 RID: 59016 RVA: 0x003758E8 File Offset: 0x00373AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216540, XrefRangeEnd = 216560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _GetAllValidPartnerIndex_b__162_0(PartnerInfoBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__GetAllValidPartnerIndex_b__162_0_Internal_IEnumerable_1_Int32_PartnerInfoBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600E689 RID: 59017 RVA: 0x00375938 File Offset: 0x00373B38
			[CallerCount(0)]
			public unsafe int _GetAllValidPartnerIndex_b__162_3(PartnerInfoBase.CompanionProperty y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__GetAllValidPartnerIndex_b__162_3_Internal_Int32_CompanionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E68A RID: 59018 RVA: 0x00375984 File Offset: 0x00373B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216560, XrefRangeEnd = 216561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAllValidPartnerIndex_b__162_2(KeyValuePair<int, PartnerInfoBase> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c.NativeMethodInfoPtr__GetAllValidPartnerIndex_b__162_2_Internal_Int32_KeyValuePair_2_Int32_PartnerInfoBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E68B RID: 59019 RVA: 0x0007B084 File Offset: 0x00079284
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AB9 RID: 19129
			// (get) Token: 0x0600E68C RID: 59020 RVA: 0x003759D8 File Offset: 0x00373BD8
			// (set) Token: 0x0600E68D RID: 59021 RVA: 0x0007B08D File Offset: 0x0007928D
			public unsafe static DataBaseCharacter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCharacter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ABA RID: 19130
			// (get) Token: 0x0600E68E RID: 59022 RVA: 0x00375A00 File Offset: 0x00373C00
			// (set) Token: 0x0600E68F RID: 59023 RVA: 0x0007B09F File Offset: 0x0007929F
			public unsafe static Func<KeyValuePair<SchedulerNode.Character, HashSet<string>>, SchedulerNode.Character> __9__143_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<SchedulerNode.Character, HashSet<string>>, SchedulerNode.Character>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ABB RID: 19131
			// (get) Token: 0x0600E690 RID: 59024 RVA: 0x00375A28 File Offset: 0x00373C28
			// (set) Token: 0x0600E691 RID: 59025 RVA: 0x0007B0B1 File Offset: 0x000792B1
			public unsafe static Func<KeyValuePair<SchedulerNode.Character, HashSet<string>>, Il2CppStringArray> __9__143_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<SchedulerNode.Character, HashSet<string>>, Il2CppStringArray>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ABC RID: 19132
			// (get) Token: 0x0600E692 RID: 59026 RVA: 0x00375A50 File Offset: 0x00373C50
			// (set) Token: 0x0600E693 RID: 59027 RVA: 0x0007B0C3 File Offset: 0x000792C3
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>> __9__143_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ABD RID: 19133
			// (get) Token: 0x0600E694 RID: 59028 RVA: 0x00375A78 File Offset: 0x00373C78
			// (set) Token: 0x0600E695 RID: 59029 RVA: 0x0007B0D5 File Offset: 0x000792D5
			public unsafe static Func<KeyValuePair<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>, int> __9__143_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ABE RID: 19134
			// (get) Token: 0x0600E696 RID: 59030 RVA: 0x00375AA0 File Offset: 0x00373CA0
			// (set) Token: 0x0600E697 RID: 59031 RVA: 0x0007B0E7 File Offset: 0x000792E7
			public unsafe static Func<KeyValuePair<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>, Il2CppReferenceArray<CharacterSpriteSetCompact>> __9__143_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>, Il2CppReferenceArray<CharacterSpriteSetCompact>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ABF RID: 19135
			// (get) Token: 0x0600E698 RID: 59032 RVA: 0x00375AC8 File Offset: 0x00373CC8
			// (set) Token: 0x0600E699 RID: 59033 RVA: 0x0007B0F9 File Offset: 0x000792F9
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, GuestProfilePair>> __9__143_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, GuestProfilePair>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC0 RID: 19136
			// (get) Token: 0x0600E69A RID: 59034 RVA: 0x00375AF0 File Offset: 0x00373CF0
			// (set) Token: 0x0600E69B RID: 59035 RVA: 0x0007B10B File Offset: 0x0007930B
			public unsafe static Func<KeyValuePair<int, GuestProfilePair>, int> __9__143_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, GuestProfilePair>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC1 RID: 19137
			// (get) Token: 0x0600E69C RID: 59036 RVA: 0x00375B18 File Offset: 0x00373D18
			// (set) Token: 0x0600E69D RID: 59037 RVA: 0x0007B11D File Offset: 0x0007931D
			public unsafe static Func<KeyValuePair<int, GuestProfilePair>, GuestProfilePair> __9__143_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, GuestProfilePair>, GuestProfilePair>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC2 RID: 19138
			// (get) Token: 0x0600E69E RID: 59038 RVA: 0x00375B40 File Offset: 0x00373D40
			// (set) Token: 0x0600E69F RID: 59039 RVA: 0x0007B12F File Offset: 0x0007932F
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, CharacterSpriteSetCompact>> __9__143_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, CharacterSpriteSetCompact>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC3 RID: 19139
			// (get) Token: 0x0600E6A0 RID: 59040 RVA: 0x00375B68 File Offset: 0x00373D68
			// (set) Token: 0x0600E6A1 RID: 59041 RVA: 0x0007B141 File Offset: 0x00079341
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, NormalGuest>> __9__143_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, NormalGuest>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC4 RID: 19140
			// (get) Token: 0x0600E6A2 RID: 59042 RVA: 0x00375B90 File Offset: 0x00373D90
			// (set) Token: 0x0600E6A3 RID: 59043 RVA: 0x0007B153 File Offset: 0x00079353
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, SpecialGuest>> __9__143_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, SpecialGuest>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC5 RID: 19141
			// (get) Token: 0x0600E6A4 RID: 59044 RVA: 0x00375BB8 File Offset: 0x00373DB8
			// (set) Token: 0x0600E6A5 RID: 59045 RVA: 0x0007B165 File Offset: 0x00079365
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, PartnerInfoBase>> __9__143_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, PartnerInfoBase>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC6 RID: 19142
			// (get) Token: 0x0600E6A6 RID: 59046 RVA: 0x00375BE0 File Offset: 0x00373DE0
			// (set) Token: 0x0600E6A7 RID: 59047 RVA: 0x0007B177 File Offset: 0x00079377
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, MappedSpecialGuest>> __9__143_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, MappedSpecialGuest>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC7 RID: 19143
			// (get) Token: 0x0600E6A8 RID: 59048 RVA: 0x00375C08 File Offset: 0x00373E08
			// (set) Token: 0x0600E6A9 RID: 59049 RVA: 0x0007B189 File Offset: 0x00079389
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, bool>> __9__143_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, bool>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC8 RID: 19144
			// (get) Token: 0x0600E6AA RID: 59050 RVA: 0x00375C30 File Offset: 0x00373E30
			// (set) Token: 0x0600E6AB RID: 59051 RVA: 0x0007B19B File Offset: 0x0007939B
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, IEnumerable<Il2CppStructArray<int>>> __9__143_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, IEnumerable<Il2CppStructArray<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC9 RID: 19145
			// (get) Token: 0x0600E6AC RID: 59052 RVA: 0x00375C58 File Offset: 0x00373E58
			// (set) Token: 0x0600E6AD RID: 59053 RVA: 0x0007B1AD File Offset: 0x000793AD
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>> __9__143_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, Il2CppReferenceArray<CharacterSpriteSetCompact>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ACA RID: 19146
			// (get) Token: 0x0600E6AE RID: 59054 RVA: 0x00375C80 File Offset: 0x00373E80
			// (set) Token: 0x0600E6AF RID: 59055 RVA: 0x0007B1BF File Offset: 0x000793BF
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, GuestProfilePair>> __9__143_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, GuestProfilePair>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ACB RID: 19147
			// (get) Token: 0x0600E6B0 RID: 59056 RVA: 0x00375CA8 File Offset: 0x00373EA8
			// (set) Token: 0x0600E6B1 RID: 59057 RVA: 0x0007B1D1 File Offset: 0x000793D1
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, CharacterSpriteSetCompact>> __9__143_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, CharacterSpriteSetCompact>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ACC RID: 19148
			// (get) Token: 0x0600E6B2 RID: 59058 RVA: 0x00375CD0 File Offset: 0x00373ED0
			// (set) Token: 0x0600E6B3 RID: 59059 RVA: 0x0007B1E3 File Offset: 0x000793E3
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, NormalGuest>> __9__143_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, NormalGuest>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ACD RID: 19149
			// (get) Token: 0x0600E6B4 RID: 59060 RVA: 0x00375CF8 File Offset: 0x00373EF8
			// (set) Token: 0x0600E6B5 RID: 59061 RVA: 0x0007B1F5 File Offset: 0x000793F5
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, SpecialGuest>> __9__143_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, SpecialGuest>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ACE RID: 19150
			// (get) Token: 0x0600E6B6 RID: 59062 RVA: 0x00375D20 File Offset: 0x00373F20
			// (set) Token: 0x0600E6B7 RID: 59063 RVA: 0x0007B207 File Offset: 0x00079407
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, PartnerInfoBase>> __9__143_21
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_21, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, PartnerInfoBase>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_21, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ACF RID: 19151
			// (get) Token: 0x0600E6B8 RID: 59064 RVA: 0x00375D48 File Offset: 0x00373F48
			// (set) Token: 0x0600E6B9 RID: 59065 RVA: 0x0007B219 File Offset: 0x00079419
			public unsafe static Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, MappedSpecialGuest>> __9__143_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCharacter.DataBaseCharacterData, Dictionary<int, MappedSpecialGuest>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__143_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AD0 RID: 19152
			// (get) Token: 0x0600E6BA RID: 59066 RVA: 0x00375D70 File Offset: 0x00373F70
			// (set) Token: 0x0600E6BB RID: 59067 RVA: 0x0007B22B File Offset: 0x0007942B
			public unsafe static Func<KeyValuePair<int, MappedSpecialGuest>, int> __9__156_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__156_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, MappedSpecialGuest>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__156_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AD1 RID: 19153
			// (get) Token: 0x0600E6BC RID: 59068 RVA: 0x00375D98 File Offset: 0x00373F98
			// (set) Token: 0x0600E6BD RID: 59069 RVA: 0x0007B23D File Offset: 0x0007943D
			public unsafe static Func<KeyValuePair<int, MappedSpecialGuest>, SpecialGuest> __9__156_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__156_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, MappedSpecialGuest>, SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__156_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AD2 RID: 19154
			// (get) Token: 0x0600E6BE RID: 59070 RVA: 0x00375DC0 File Offset: 0x00373FC0
			// (set) Token: 0x0600E6BF RID: 59071 RVA: 0x0007B24F File Offset: 0x0007944F
			public unsafe static Func<KeyValuePair<int, MappedSpecialGuest>, string> __9__158_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, MappedSpecialGuest>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AD3 RID: 19155
			// (get) Token: 0x0600E6C0 RID: 59072 RVA: 0x00375DE8 File Offset: 0x00373FE8
			// (set) Token: 0x0600E6C1 RID: 59073 RVA: 0x0007B261 File Offset: 0x00079461
			public unsafe static Func<KeyValuePair<string, List<KeyValuePair<int, MappedSpecialGuest>>>, string> __9__158_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, List<KeyValuePair<int, MappedSpecialGuest>>>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AD4 RID: 19156
			// (get) Token: 0x0600E6C2 RID: 59074 RVA: 0x00375E10 File Offset: 0x00374010
			// (set) Token: 0x0600E6C3 RID: 59075 RVA: 0x0007B273 File Offset: 0x00079473
			public unsafe static Func<KeyValuePair<int, MappedSpecialGuest>, SpecialGuest> __9__158_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, MappedSpecialGuest>, SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AD5 RID: 19157
			// (get) Token: 0x0600E6C4 RID: 59076 RVA: 0x00375E38 File Offset: 0x00374038
			// (set) Token: 0x0600E6C5 RID: 59077 RVA: 0x0007B285 File Offset: 0x00079485
			public unsafe static Func<KeyValuePair<string, List<KeyValuePair<int, MappedSpecialGuest>>>, Il2CppReferenceArray<SpecialGuest>> __9__158_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, List<KeyValuePair<int, MappedSpecialGuest>>>, Il2CppReferenceArray<SpecialGuest>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__158_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AD6 RID: 19158
			// (get) Token: 0x0600E6C6 RID: 59078 RVA: 0x00375E60 File Offset: 0x00374060
			// (set) Token: 0x0600E6C7 RID: 59079 RVA: 0x0007B297 File Offset: 0x00079497
			public unsafe static Func<KeyValuePair<int, PartnerInfoBase>, bool> __9__161_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__161_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, PartnerInfoBase>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__161_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AD7 RID: 19159
			// (get) Token: 0x0600E6C8 RID: 59080 RVA: 0x00375E88 File Offset: 0x00374088
			// (set) Token: 0x0600E6C9 RID: 59081 RVA: 0x0007B2A9 File Offset: 0x000794A9
			public unsafe static Func<PartnerInfoBase.CompanionProperty, int> __9__162_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__162_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerInfoBase.CompanionProperty, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__162_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AD8 RID: 19160
			// (get) Token: 0x0600E6CA RID: 59082 RVA: 0x00375EB0 File Offset: 0x003740B0
			// (set) Token: 0x0600E6CB RID: 59083 RVA: 0x0007B2BB File Offset: 0x000794BB
			public unsafe static Func<PartnerInfoBase, IEnumerable<int>> __9__162_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__162_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerInfoBase, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__162_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AD9 RID: 19161
			// (get) Token: 0x0600E6CC RID: 59084 RVA: 0x00375ED8 File Offset: 0x003740D8
			// (set) Token: 0x0600E6CD RID: 59085 RVA: 0x0007B2CD File Offset: 0x000794CD
			public unsafe static Func<KeyValuePair<int, PartnerInfoBase>, int> __9__162_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__162_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, PartnerInfoBase>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCharacter.__c.NativeFieldInfoPtr___9__162_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009329 RID: 37673
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400932A RID: 37674
			private static readonly IntPtr NativeFieldInfoPtr___9__143_0;

			// Token: 0x0400932B RID: 37675
			private static readonly IntPtr NativeFieldInfoPtr___9__143_1;

			// Token: 0x0400932C RID: 37676
			private static readonly IntPtr NativeFieldInfoPtr___9__143_2;

			// Token: 0x0400932D RID: 37677
			private static readonly IntPtr NativeFieldInfoPtr___9__143_3;

			// Token: 0x0400932E RID: 37678
			private static readonly IntPtr NativeFieldInfoPtr___9__143_4;

			// Token: 0x0400932F RID: 37679
			private static readonly IntPtr NativeFieldInfoPtr___9__143_5;

			// Token: 0x04009330 RID: 37680
			private static readonly IntPtr NativeFieldInfoPtr___9__143_6;

			// Token: 0x04009331 RID: 37681
			private static readonly IntPtr NativeFieldInfoPtr___9__143_7;

			// Token: 0x04009332 RID: 37682
			private static readonly IntPtr NativeFieldInfoPtr___9__143_8;

			// Token: 0x04009333 RID: 37683
			private static readonly IntPtr NativeFieldInfoPtr___9__143_9;

			// Token: 0x04009334 RID: 37684
			private static readonly IntPtr NativeFieldInfoPtr___9__143_10;

			// Token: 0x04009335 RID: 37685
			private static readonly IntPtr NativeFieldInfoPtr___9__143_11;

			// Token: 0x04009336 RID: 37686
			private static readonly IntPtr NativeFieldInfoPtr___9__143_12;

			// Token: 0x04009337 RID: 37687
			private static readonly IntPtr NativeFieldInfoPtr___9__143_13;

			// Token: 0x04009338 RID: 37688
			private static readonly IntPtr NativeFieldInfoPtr___9__143_14;

			// Token: 0x04009339 RID: 37689
			private static readonly IntPtr NativeFieldInfoPtr___9__143_16;

			// Token: 0x0400933A RID: 37690
			private static readonly IntPtr NativeFieldInfoPtr___9__143_17;

			// Token: 0x0400933B RID: 37691
			private static readonly IntPtr NativeFieldInfoPtr___9__143_18;

			// Token: 0x0400933C RID: 37692
			private static readonly IntPtr NativeFieldInfoPtr___9__143_19;

			// Token: 0x0400933D RID: 37693
			private static readonly IntPtr NativeFieldInfoPtr___9__143_20;

			// Token: 0x0400933E RID: 37694
			private static readonly IntPtr NativeFieldInfoPtr___9__143_21;

			// Token: 0x0400933F RID: 37695
			private static readonly IntPtr NativeFieldInfoPtr___9__143_22;

			// Token: 0x04009340 RID: 37696
			private static readonly IntPtr NativeFieldInfoPtr___9__156_0;

			// Token: 0x04009341 RID: 37697
			private static readonly IntPtr NativeFieldInfoPtr___9__156_1;

			// Token: 0x04009342 RID: 37698
			private static readonly IntPtr NativeFieldInfoPtr___9__158_0;

			// Token: 0x04009343 RID: 37699
			private static readonly IntPtr NativeFieldInfoPtr___9__158_1;

			// Token: 0x04009344 RID: 37700
			private static readonly IntPtr NativeFieldInfoPtr___9__158_3;

			// Token: 0x04009345 RID: 37701
			private static readonly IntPtr NativeFieldInfoPtr___9__158_2;

			// Token: 0x04009346 RID: 37702
			private static readonly IntPtr NativeFieldInfoPtr___9__161_0;

			// Token: 0x04009347 RID: 37703
			private static readonly IntPtr NativeFieldInfoPtr___9__162_3;

			// Token: 0x04009348 RID: 37704
			private static readonly IntPtr NativeFieldInfoPtr___9__162_0;

			// Token: 0x04009349 RID: 37705
			private static readonly IntPtr NativeFieldInfoPtr___9__162_2;

			// Token: 0x0400934A RID: 37706
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400934B RID: 37707
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_0_Internal_Character_KeyValuePair_2_Character_HashSet_1_String_0;

			// Token: 0x0400934C RID: 37708
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_1_Internal_Il2CppStringArray_KeyValuePair_2_Character_HashSet_1_String_0;

			// Token: 0x0400934D RID: 37709
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_2_Internal_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_DataBaseCharacterData_0;

			// Token: 0x0400934E RID: 37710
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_3_Internal_Int32_KeyValuePair_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0;

			// Token: 0x0400934F RID: 37711
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_4_Internal_Il2CppReferenceArray_1_CharacterSpriteSetCompact_KeyValuePair_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0;

			// Token: 0x04009350 RID: 37712
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_5_Internal_Dictionary_2_Int32_GuestProfilePair_DataBaseCharacterData_0;

			// Token: 0x04009351 RID: 37713
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_6_Internal_Int32_KeyValuePair_2_Int32_GuestProfilePair_0;

			// Token: 0x04009352 RID: 37714
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_7_Internal_GuestProfilePair_KeyValuePair_2_Int32_GuestProfilePair_0;

			// Token: 0x04009353 RID: 37715
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_8_Internal_Dictionary_2_Int32_CharacterSpriteSetCompact_DataBaseCharacterData_0;

			// Token: 0x04009354 RID: 37716
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_9_Internal_Dictionary_2_Int32_NormalGuest_DataBaseCharacterData_0;

			// Token: 0x04009355 RID: 37717
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_10_Internal_Dictionary_2_Int32_SpecialGuest_DataBaseCharacterData_0;

			// Token: 0x04009356 RID: 37718
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_11_Internal_Dictionary_2_Int32_PartnerInfoBase_DataBaseCharacterData_0;

			// Token: 0x04009357 RID: 37719
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_12_Internal_Dictionary_2_Int32_MappedSpecialGuest_DataBaseCharacterData_0;

			// Token: 0x04009358 RID: 37720
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_13_Internal_Dictionary_2_Int32_Boolean_DataBaseCharacterData_0;

			// Token: 0x04009359 RID: 37721
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_14_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_DataBaseCharacterData_0;

			// Token: 0x0400935A RID: 37722
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_16_Internal_Dictionary_2_Int32_Il2CppReferenceArray_1_CharacterSpriteSetCompact_DataBaseCharacterData_0;

			// Token: 0x0400935B RID: 37723
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_17_Internal_Dictionary_2_Int32_GuestProfilePair_DataBaseCharacterData_0;

			// Token: 0x0400935C RID: 37724
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_18_Internal_Dictionary_2_Int32_CharacterSpriteSetCompact_DataBaseCharacterData_0;

			// Token: 0x0400935D RID: 37725
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_19_Internal_Dictionary_2_Int32_NormalGuest_DataBaseCharacterData_0;

			// Token: 0x0400935E RID: 37726
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_20_Internal_Dictionary_2_Int32_SpecialGuest_DataBaseCharacterData_0;

			// Token: 0x0400935F RID: 37727
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_21_Internal_Dictionary_2_Int32_PartnerInfoBase_DataBaseCharacterData_0;

			// Token: 0x04009360 RID: 37728
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__143_22_Internal_Dictionary_2_Int32_MappedSpecialGuest_DataBaseCharacterData_0;

			// Token: 0x04009361 RID: 37729
			private static readonly IntPtr NativeMethodInfoPtr__PreinitSpecialGuests_b__156_0_Internal_Int32_KeyValuePair_2_Int32_MappedSpecialGuest_0;

			// Token: 0x04009362 RID: 37730
			private static readonly IntPtr NativeMethodInfoPtr__PreinitSpecialGuests_b__156_1_Internal_SpecialGuest_KeyValuePair_2_Int32_MappedSpecialGuest_0;

			// Token: 0x04009363 RID: 37731
			private static readonly IntPtr NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_0_Internal_String_KeyValuePair_2_Int32_MappedSpecialGuest_0;

			// Token: 0x04009364 RID: 37732
			private static readonly IntPtr NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_1_Internal_String_KeyValuePair_2_String_List_1_KeyValuePair_2_Int32_MappedSpecialGuest_0;

			// Token: 0x04009365 RID: 37733
			private static readonly IntPtr NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_2_Internal_Il2CppReferenceArray_1_SpecialGuest_KeyValuePair_2_String_List_1_KeyValuePair_2_Int32_MappedSpecialGuest_0;

			// Token: 0x04009366 RID: 37734
			private static readonly IntPtr NativeMethodInfoPtr__GetMappedSpecialGuests_b__158_3_Internal_SpecialGuest_KeyValuePair_2_Int32_MappedSpecialGuest_0;

			// Token: 0x04009367 RID: 37735
			private static readonly IntPtr NativeMethodInfoPtr__CheckIdIsBossPartner_b__161_0_Internal_Boolean_KeyValuePair_2_Int32_PartnerInfoBase_0;

			// Token: 0x04009368 RID: 37736
			private static readonly IntPtr NativeMethodInfoPtr__GetAllValidPartnerIndex_b__162_0_Internal_IEnumerable_1_Int32_PartnerInfoBase_0;

			// Token: 0x04009369 RID: 37737
			private static readonly IntPtr NativeMethodInfoPtr__GetAllValidPartnerIndex_b__162_3_Internal_Int32_CompanionProperty_0;

			// Token: 0x0400936A RID: 37738
			private static readonly IntPtr NativeMethodInfoPtr__GetAllValidPartnerIndex_b__162_2_Internal_Int32_KeyValuePair_2_Int32_PartnerInfoBase_0;
		}

		// Token: 0x02000C8A RID: 3210
		[ObfuscatedName("GameData.Core.Collections.CharacterUtility.DataBaseCharacter+<>c__DisplayClass149_0")]
		public sealed class __c__DisplayClass149_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E6CE RID: 59086 RVA: 0x00375F00 File Offset: 0x00374100
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass149_0()
			{
				Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass149_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<>c__DisplayClass149_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass149_0>.NativeClassPtr);
				DataBaseCharacter.__c__DisplayClass149_0.NativeFieldInfoPtr_daySceneNPCid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass149_0>.NativeClassPtr, "daySceneNPCid");
				DataBaseCharacter.__c__DisplayClass149_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass149_0>.NativeClassPtr, 100681229);
				DataBaseCharacter.__c__DisplayClass149_0.NativeMethodInfoPtr__RefSGuest_b__0_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass149_0>.NativeClassPtr, 100681230);
				DataBaseCharacter.__c__DisplayClass149_0.NativeMethodInfoPtr__RefSGuest_b__1_Internal_Boolean_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass149_0>.NativeClassPtr, 100681231);
			}

			// Token: 0x0600E6CF RID: 59087 RVA: 0x00375F7C File Offset: 0x0037417C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass149_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass149_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass149_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6D0 RID: 59088 RVA: 0x00375FB8 File Offset: 0x003741B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefSGuest_b__0(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass149_0.NativeMethodInfoPtr__RefSGuest_b__0_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6D1 RID: 59089 RVA: 0x00376008 File Offset: 0x00374208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefSGuest_b__1(MappedSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass149_0.NativeMethodInfoPtr__RefSGuest_b__1_Internal_Boolean_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6D2 RID: 59090 RVA: 0x0007B2DF File Offset: 0x000794DF
			public __c__DisplayClass149_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004ADA RID: 19162
			// (get) Token: 0x0600E6D3 RID: 59091 RVA: 0x00376058 File Offset: 0x00374258
			// (set) Token: 0x0600E6D4 RID: 59092 RVA: 0x0007B2E8 File Offset: 0x000794E8
			public unsafe string daySceneNPCid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass149_0.NativeFieldInfoPtr_daySceneNPCid);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass149_0.NativeFieldInfoPtr_daySceneNPCid), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400936B RID: 37739
			private static readonly IntPtr NativeFieldInfoPtr_daySceneNPCid;

			// Token: 0x0400936C RID: 37740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400936D RID: 37741
			private static readonly IntPtr NativeMethodInfoPtr__RefSGuest_b__0_Internal_Boolean_SpecialGuest_0;

			// Token: 0x0400936E RID: 37742
			private static readonly IntPtr NativeMethodInfoPtr__RefSGuest_b__1_Internal_Boolean_MappedSpecialGuest_0;
		}

		// Token: 0x02000C8B RID: 3211
		[ObfuscatedName("GameData.Core.Collections.CharacterUtility.DataBaseCharacter+<>c__DisplayClass161_0")]
		public sealed class __c__DisplayClass161_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E6D5 RID: 59093 RVA: 0x00376080 File Offset: 0x00374280
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass161_0()
			{
				Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass161_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<>c__DisplayClass161_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass161_0>.NativeClassPtr);
				DataBaseCharacter.__c__DisplayClass161_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass161_0>.NativeClassPtr, "id");
				DataBaseCharacter.__c__DisplayClass161_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass161_0>.NativeClassPtr, 100681232);
				DataBaseCharacter.__c__DisplayClass161_0.NativeMethodInfoPtr__CheckIdIsBossPartner_b__1_Internal_Boolean_KeyValuePair_2_Int32_PartnerInfoBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass161_0>.NativeClassPtr, 100681233);
			}

			// Token: 0x0600E6D6 RID: 59094 RVA: 0x003760E8 File Offset: 0x003742E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass161_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass161_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass161_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6D7 RID: 59095 RVA: 0x00376124 File Offset: 0x00374324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216561, XrefRangeEnd = 216562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckIdIsBossPartner_b__1(KeyValuePair<int, PartnerInfoBase> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass161_0.NativeMethodInfoPtr__CheckIdIsBossPartner_b__1_Internal_Boolean_KeyValuePair_2_Int32_PartnerInfoBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6D8 RID: 59096 RVA: 0x0007B307 File Offset: 0x00079507
			public __c__DisplayClass161_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004ADB RID: 19163
			// (get) Token: 0x0600E6D9 RID: 59097 RVA: 0x00376178 File Offset: 0x00374378
			// (set) Token: 0x0600E6DA RID: 59098 RVA: 0x0007B310 File Offset: 0x00079510
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass161_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass161_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x0400936F RID: 37743
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04009370 RID: 37744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009371 RID: 37745
			private static readonly IntPtr NativeMethodInfoPtr__CheckIdIsBossPartner_b__1_Internal_Boolean_KeyValuePair_2_Int32_PartnerInfoBase_0;
		}

		// Token: 0x02000C8C RID: 3212
		[ObfuscatedName("GameData.Core.Collections.CharacterUtility.DataBaseCharacter+<>c__DisplayClass162_0")]
		public sealed class __c__DisplayClass162_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E6DB RID: 59099 RVA: 0x003761A0 File Offset: 0x003743A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass162_0()
			{
				Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass162_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<>c__DisplayClass162_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass162_0>.NativeClassPtr);
				DataBaseCharacter.__c__DisplayClass162_0.NativeFieldInfoPtr_allCompanionPartners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass162_0>.NativeClassPtr, "allCompanionPartners");
				DataBaseCharacter.__c__DisplayClass162_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass162_0>.NativeClassPtr, 100681234);
				DataBaseCharacter.__c__DisplayClass162_0.NativeMethodInfoPtr__GetAllValidPartnerIndex_b__1_Internal_Boolean_KeyValuePair_2_Int32_PartnerInfoBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass162_0>.NativeClassPtr, 100681235);
			}

			// Token: 0x0600E6DC RID: 59100 RVA: 0x00376208 File Offset: 0x00374408
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass162_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass162_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass162_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6DD RID: 59101 RVA: 0x00376244 File Offset: 0x00374444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216562, XrefRangeEnd = 216567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllValidPartnerIndex_b__1(KeyValuePair<int, PartnerInfoBase> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass162_0.NativeMethodInfoPtr__GetAllValidPartnerIndex_b__1_Internal_Boolean_KeyValuePair_2_Int32_PartnerInfoBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6DE RID: 59102 RVA: 0x0007B32B File Offset: 0x0007952B
			public __c__DisplayClass162_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004ADC RID: 19164
			// (get) Token: 0x0600E6DF RID: 59103 RVA: 0x00376298 File Offset: 0x00374498
			// (set) Token: 0x0600E6E0 RID: 59104 RVA: 0x0007B334 File Offset: 0x00079534
			public unsafe IEnumerable<int> allCompanionPartners
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass162_0.NativeFieldInfoPtr_allCompanionPartners);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass162_0.NativeFieldInfoPtr_allCompanionPartners), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009372 RID: 37746
			private static readonly IntPtr NativeFieldInfoPtr_allCompanionPartners;

			// Token: 0x04009373 RID: 37747
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009374 RID: 37748
			private static readonly IntPtr NativeMethodInfoPtr__GetAllValidPartnerIndex_b__1_Internal_Boolean_KeyValuePair_2_Int32_PartnerInfoBase_0;
		}

		// Token: 0x02000C8D RID: 3213
		[ObfuscatedName("GameData.Core.Collections.CharacterUtility.DataBaseCharacter+<>c__DisplayClass167_0")]
		public sealed class __c__DisplayClass167_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E6E1 RID: 59105 RVA: 0x003762C8 File Offset: 0x003744C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass167_0()
			{
				Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass167_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<>c__DisplayClass167_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass167_0>.NativeClassPtr);
				DataBaseCharacter.__c__DisplayClass167_0.NativeFieldInfoPtr_stringId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass167_0>.NativeClassPtr, "stringId");
				DataBaseCharacter.__c__DisplayClass167_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass167_0>.NativeClassPtr, 100681236);
				DataBaseCharacter.__c__DisplayClass167_0.NativeMethodInfoPtr__RefNPCIdentity_b__0_Internal_Boolean_KeyValuePair_2_Int32_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass167_0>.NativeClassPtr, 100681237);
				DataBaseCharacter.__c__DisplayClass167_0.NativeMethodInfoPtr__RefNPCIdentity_b__1_Internal_Boolean_KeyValuePair_2_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass167_0>.NativeClassPtr, 100681238);
			}

			// Token: 0x0600E6E2 RID: 59106 RVA: 0x00376344 File Offset: 0x00374544
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass167_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass167_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass167_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6E3 RID: 59107 RVA: 0x00376380 File Offset: 0x00374580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216567, XrefRangeEnd = 216570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefNPCIdentity_b__0(KeyValuePair<int, MappedSpecialGuest> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass167_0.NativeMethodInfoPtr__RefNPCIdentity_b__0_Internal_Boolean_KeyValuePair_2_Int32_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6E4 RID: 59108 RVA: 0x003763D4 File Offset: 0x003745D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216570, XrefRangeEnd = 216573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefNPCIdentity_b__1(KeyValuePair<int, SpecialGuest> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass167_0.NativeMethodInfoPtr__RefNPCIdentity_b__1_Internal_Boolean_KeyValuePair_2_Int32_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6E5 RID: 59109 RVA: 0x0007B353 File Offset: 0x00079553
			public __c__DisplayClass167_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004ADD RID: 19165
			// (get) Token: 0x0600E6E6 RID: 59110 RVA: 0x00376428 File Offset: 0x00374628
			// (set) Token: 0x0600E6E7 RID: 59111 RVA: 0x0007B35C File Offset: 0x0007955C
			public unsafe string stringId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass167_0.NativeFieldInfoPtr_stringId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass167_0.NativeFieldInfoPtr_stringId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009375 RID: 37749
			private static readonly IntPtr NativeFieldInfoPtr_stringId;

			// Token: 0x04009376 RID: 37750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009377 RID: 37751
			private static readonly IntPtr NativeMethodInfoPtr__RefNPCIdentity_b__0_Internal_Boolean_KeyValuePair_2_Int32_MappedSpecialGuest_0;

			// Token: 0x04009378 RID: 37752
			private static readonly IntPtr NativeMethodInfoPtr__RefNPCIdentity_b__1_Internal_Boolean_KeyValuePair_2_Int32_SpecialGuest_0;
		}

		// Token: 0x02000C8E RID: 3214
		[ObfuscatedName("GameData.Core.Collections.CharacterUtility.DataBaseCharacter+<>c__DisplayClass173_0")]
		public sealed class __c__DisplayClass173_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E6E8 RID: 59112 RVA: 0x00376450 File Offset: 0x00374650
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass173_0()
			{
				Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass173_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCharacter>.NativeClassPtr, "<>c__DisplayClass173_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass173_0>.NativeClassPtr);
				DataBaseCharacter.__c__DisplayClass173_0.NativeFieldInfoPtr_mappingGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass173_0>.NativeClassPtr, "mappingGuest");
				DataBaseCharacter.__c__DisplayClass173_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass173_0>.NativeClassPtr, 100681239);
				DataBaseCharacter.__c__DisplayClass173_0.NativeMethodInfoPtr__TryGetOriginalSGuestFromMapping_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass173_0>.NativeClassPtr, 100681240);
			}

			// Token: 0x0600E6E9 RID: 59113 RVA: 0x003764B8 File Offset: 0x003746B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass173_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCharacter.__c__DisplayClass173_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass173_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6EA RID: 59114 RVA: 0x003764F4 File Offset: 0x003746F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216573, XrefRangeEnd = 216574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetOriginalSGuestFromMapping_b__0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCharacter.__c__DisplayClass173_0.NativeMethodInfoPtr__TryGetOriginalSGuestFromMapping_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6EB RID: 59115 RVA: 0x0007B37B File Offset: 0x0007957B
			public __c__DisplayClass173_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004ADE RID: 19166
			// (get) Token: 0x0600E6EC RID: 59116 RVA: 0x00376548 File Offset: 0x00374748
			// (set) Token: 0x0600E6ED RID: 59117 RVA: 0x0007B384 File Offset: 0x00079584
			public unsafe int mappingGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass173_0.NativeFieldInfoPtr_mappingGuest);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCharacter.__c__DisplayClass173_0.NativeFieldInfoPtr_mappingGuest)) = value;
				}
			}

			// Token: 0x04009379 RID: 37753
			private static readonly IntPtr NativeFieldInfoPtr_mappingGuest;

			// Token: 0x0400937A RID: 37754
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400937B RID: 37755
			private static readonly IntPtr NativeMethodInfoPtr__TryGetOriginalSGuestFromMapping_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;
		}
	}
}
