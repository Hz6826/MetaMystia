using System;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI.CookingUtility;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace GameData.Core.Collections
{
	// Token: 0x02000246 RID: 582
	[Serializable]
	public class Cooker : NonTradableObjectBase
	{
		// Token: 0x0600487C RID: 18556 RVA: 0x00199D4C File Offset: 0x00197F4C
		// Note: this type is marked as 'beforefieldinit'.
		static Cooker()
		{
			Il2CppClassPointerStore<Cooker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "Cooker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cooker>.NativeClassPtr);
			Cooker.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooker>.NativeClassPtr, "type");
			Cooker.NativeFieldInfoPtr_cookerSeries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooker>.NativeClassPtr, "cookerSeries");
			Cooker.NativeFieldInfoPtr_cookerAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooker>.NativeClassPtr, "cookerAsset");
			Cooker.NativeFieldInfoPtr_idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooker>.NativeClassPtr, "idle");
			Cooker.NativeFieldInfoPtr_loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooker>.NativeClassPtr, "loaded");
			Cooker.NativeFieldInfoPtr_cooking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooker>.NativeClassPtr, "cooking");
			Cooker.NativeFieldInfoPtr_illuminationIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooker>.NativeClassPtr, "illuminationIntensity");
			Cooker.NativeFieldInfoPtr_startCookSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooker>.NativeClassPtr, "startCookSFX");
			Cooker.NativeFieldInfoPtr_openCookSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooker>.NativeClassPtr, "openCookSFX");
			Cooker.NativeFieldInfoPtr_EMPTY_DESK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cooker>.NativeClassPtr, "EMPTY_DESK");
			Cooker.NativeMethodInfoPtr__ctor_Public_Void_Int32_CookerType_CookerSeries_CookerAssetBase_AnimatedTile_AnimatedTile_AnimatedTile_Single_AudioClip_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677790);
			Cooker.NativeMethodInfoPtr_get_Type_Public_get_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677791);
			Cooker.NativeMethodInfoPtr_get_Series_Public_get_CookerSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677792);
			Cooker.NativeMethodInfoPtr_get_CanOpenByPartner_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677793);
			Cooker.NativeMethodInfoPtr_get_CookTimeMultiplierCanUseByPartner_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677794);
			Cooker.NativeMethodInfoPtr_get_CookTimeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677795);
			Cooker.NativeMethodInfoPtr_get_AdditiveNextOrderProb_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677796);
			Cooker.NativeMethodInfoPtr_get_Idle_Public_get_AnimatedTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677797);
			Cooker.NativeMethodInfoPtr_get_Loaded_Public_get_AnimatedTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677798);
			Cooker.NativeMethodInfoPtr_get_Cooking_Public_get_AnimatedTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677799);
			Cooker.NativeMethodInfoPtr_get_IlluminationIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677800);
			Cooker.NativeMethodInfoPtr_get_OpenCookSFX_Public_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677801);
			Cooker.NativeMethodInfoPtr_GetStartCookSFX_Public_AudioClip_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677802);
			Cooker.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677803);
			Cooker.NativeMethodInfoPtr_get_CanTriggerSpecialCookerSkill_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677804);
			Cooker.NativeMethodInfoPtr_OnGetNormalGuests_Public_IEnumerable_1_IEnumerable_1_NormalGuest_IEnumerable_1_IEnumerable_1_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677805);
			Cooker.NativeMethodInfoPtr_OnGetCookerOutput_Public_IEnumerable_1_MatchedCookCombo_IEnumerable_1_MatchedCookCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677806);
			Cooker.NativeMethodInfoPtr_GetExtraCookSpeedMultiplier_Public_Single_CookController_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677807);
			Cooker.NativeMethodInfoPtr_GetExtraAdditiveNextOrderProb_Public_Single_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677808);
			Cooker.NativeMethodInfoPtr_OnStartCook_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677809);
			Cooker.NativeMethodInfoPtr_OnFinishCook_Public_Sellable_Sellable_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677810);
			Cooker.NativeMethodInfoPtr_OnEvaluate_Public_Int32_Int32_GuestGroupController_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677811);
			Cooker.NativeMethodInfoPtr_ShouldShowThisCookerBG_Public_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677812);
			Cooker.NativeMethodInfoPtr_OnPlayerFinishExtract_Public_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677813);
			Cooker.NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677814);
			Cooker.NativeMethodInfoPtr_get_BGSprite_Public_Virtual_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677815);
			Cooker.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677816);
			Cooker.NativeMethodInfoPtr_get_AllAvailableCookerType_Public_get_IEnumerable_1_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677817);
			Cooker.NativeMethodInfoPtr_get_OverrideTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677818);
			Cooker.NativeMethodInfoPtr_OnCookerWorkTimeUpdate_Public_Void_CookController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cooker>.NativeClassPtr, 100677819);
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x0019A09C File Offset: 0x0019829C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190413, XrefRangeEnd = 190420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cooker(int id, Cooker.CookerType type, Cooker.CookerSeries cookerSeries, CookerAssetBase cookerAsset, AnimatedTile idle, AnimatedTile loaded, AnimatedTile cooking, float illuminationIntensity, AudioClip startCookSFX, AudioClip openCookSFX) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cooker>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookerSeries;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookerAsset);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idle);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loaded);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cooking);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref illuminationIntensity;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startCookSFX);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(openCookSFX);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr__ctor_Public_Void_Int32_CookerType_CookerSeries_CookerAssetBase_AnimatedTile_AnimatedTile_AnimatedTile_Single_AudioClip_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x0019A184 File Offset: 0x00198384
		public unsafe Cooker.CookerType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_Type_Public_get_CookerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x0019A1C0 File Offset: 0x001983C0
		public unsafe Cooker.CookerSeries Series
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_Series_Public_get_CookerSeries_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06004880 RID: 18560 RVA: 0x0019A1FC File Offset: 0x001983FC
		public unsafe bool CanOpenByPartner
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190420, RefRangeEnd = 190421, XrefRangeStart = 190420, XrefRangeEnd = 190420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_CanOpenByPartner_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x0019A238 File Offset: 0x00198438
		public unsafe bool CookTimeMultiplierCanUseByPartner
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190421, RefRangeEnd = 190422, XrefRangeStart = 190421, XrefRangeEnd = 190421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_CookTimeMultiplierCanUseByPartner_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x0019A274 File Offset: 0x00198474
		public unsafe float CookTimeMultiplier
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 190423, RefRangeEnd = 190425, XrefRangeStart = 190422, XrefRangeEnd = 190423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_CookTimeMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06004883 RID: 18563 RVA: 0x0019A2B0 File Offset: 0x001984B0
		public unsafe float AdditiveNextOrderProb
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190426, RefRangeEnd = 190427, XrefRangeStart = 190425, XrefRangeEnd = 190426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_AdditiveNextOrderProb_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x0019A2EC File Offset: 0x001984EC
		public unsafe AnimatedTile Idle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_Idle_Public_get_AnimatedTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr3) : null;
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06004885 RID: 18565 RVA: 0x0019A32C File Offset: 0x0019852C
		public unsafe AnimatedTile Loaded
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_Loaded_Public_get_AnimatedTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr3) : null;
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06004886 RID: 18566 RVA: 0x0019A36C File Offset: 0x0019856C
		public unsafe AnimatedTile Cooking
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_Cooking_Public_get_AnimatedTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr3) : null;
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06004887 RID: 18567 RVA: 0x0019A3AC File Offset: 0x001985AC
		public unsafe float IlluminationIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_IlluminationIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06004888 RID: 18568 RVA: 0x0019A3E8 File Offset: 0x001985E8
		public unsafe AudioClip OpenCookSFX
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_OpenCookSFX_Public_get_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
			}
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x0019A428 File Offset: 0x00198628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190427, RefRangeEnd = 190428, XrefRangeStart = 190427, XrefRangeEnd = 190427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetStartCookSFX(Cooker.CookerType cookerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cookerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_GetStartCookSFX_Public_AudioClip_CookerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x0019A474 File Offset: 0x00198674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190428, XrefRangeEnd = 190437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjectLanguageBase GetText(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cooker.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x0600488B RID: 18571 RVA: 0x0019A4CC File Offset: 0x001986CC
		public unsafe bool CanTriggerSpecialCookerSkill
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 190444, RefRangeEnd = 190456, XrefRangeStart = 190437, XrefRangeEnd = 190444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_CanTriggerSpecialCookerSkill_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x0019A508 File Offset: 0x00198708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190457, RefRangeEnd = 190458, XrefRangeStart = 190456, XrefRangeEnd = 190457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IEnumerable<NormalGuest>> OnGetNormalGuests(IEnumerable<IEnumerable<NormalGuest>> preFillteredGuests)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preFillteredGuests);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_OnGetNormalGuests_Public_IEnumerable_1_IEnumerable_1_NormalGuest_IEnumerable_1_IEnumerable_1_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<NormalGuest>>>(intPtr3) : null;
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x0019A558 File Offset: 0x00198758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190459, RefRangeEnd = 190460, XrefRangeStart = 190458, XrefRangeEnd = 190459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WorkSceneCookingSelectionPannel.MatchedCookCombo> OnGetCookerOutput(IEnumerable<WorkSceneCookingSelectionPannel.MatchedCookCombo> preFillteredRecipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preFillteredRecipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_OnGetCookerOutput_Public_IEnumerable_1_MatchedCookCombo_IEnumerable_1_MatchedCookCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WorkSceneCookingSelectionPannel.MatchedCookCombo>>(intPtr3) : null;
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x0019A5A8 File Offset: 0x001987A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190461, RefRangeEnd = 190463, XrefRangeStart = 190460, XrefRangeEnd = 190461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetExtraCookSpeedMultiplier(CookController targetCooker, Sellable sellable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_GetExtraCookSpeedMultiplier_Public_Single_CookController_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x0019A608 File Offset: 0x00198808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190464, RefRangeEnd = 190465, XrefRangeStart = 190463, XrefRangeEnd = 190464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetExtraAdditiveNextOrderProb(Sellable sellable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_GetExtraAdditiveNextOrderProb_Public_Single_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x0019A658 File Offset: 0x00198858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190466, RefRangeEnd = 190467, XrefRangeStart = 190465, XrefRangeEnd = 190466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStartCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_OnStartCook_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x0019A68C File Offset: 0x0019888C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190469, RefRangeEnd = 190470, XrefRangeStart = 190467, XrefRangeEnd = 190469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sellable OnFinishCook(Sellable finishedFood, float qteScore, bool couldReturnIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(finishedFood);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qteScore;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref couldReturnIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_OnFinishCook_Public_Sellable_Sellable_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x0019A6F8 File Offset: 0x001988F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190472, RefRangeEnd = 190473, XrefRangeStart = 190470, XrefRangeEnd = 190472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int OnEvaluate(int evaluationResult, GuestGroupController guestGroupController, Sellable serveFood)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evaluationResult;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serveFood);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_OnEvaluate_Public_Int32_Int32_GuestGroupController_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x0019A768 File Offset: 0x00198968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190474, RefRangeEnd = 190475, XrefRangeStart = 190473, XrefRangeEnd = 190474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldShowThisCookerBG(Sellable outputFood)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputFood);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_ShouldShowThisCookerBG_Public_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x0019A7B8 File Offset: 0x001989B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190476, RefRangeEnd = 190477, XrefRangeStart = 190475, XrefRangeEnd = 190476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlayerFinishExtract(CookController targetCooker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_OnPlayerFinishExtract_Public_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x0019A7FC File Offset: 0x001989FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190478, RefRangeEnd = 190480, XrefRangeStart = 190477, XrefRangeEnd = 190478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WhenPlayerTryExtractWithFullTray(CookController targetCooker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06004896 RID: 18582 RVA: 0x0019A840 File Offset: 0x00198A40
		public unsafe override Sprite BGSprite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190480, XrefRangeEnd = 190481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cooker.NativeMethodInfoPtr_get_BGSprite_Public_Virtual_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x0019A88C File Offset: 0x00198A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190481, XrefRangeEnd = 190491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppSystem.Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cooker.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x0019A8D8 File Offset: 0x00198AD8
		public unsafe IEnumerable<Cooker.CookerType> AllAvailableCookerType
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 190506, RefRangeEnd = 190522, XrefRangeStart = 190491, XrefRangeEnd = 190506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_AllAvailableCookerType_Public_get_IEnumerable_1_CookerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerType>>(intPtr3) : null;
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x0019A918 File Offset: 0x00198B18
		public unsafe string OverrideTypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190526, RefRangeEnd = 190527, XrefRangeStart = 190522, XrefRangeEnd = 190526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_get_OverrideTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x0019A950 File Offset: 0x00198B50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190528, RefRangeEnd = 190531, XrefRangeStart = 190527, XrefRangeEnd = 190528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCookerWorkTimeUpdate(CookController targetCooker, float oldWorkTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldWorkTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cooker.NativeMethodInfoPtr_OnCookerWorkTimeUpdate_Public_Void_CookController_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x000253B4 File Offset: 0x000235B4
		public Cooker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x0600489C RID: 18588 RVA: 0x0019A9A0 File Offset: 0x00198BA0
		// (set) Token: 0x0600489D RID: 18589 RVA: 0x000253BD File Offset: 0x000235BD
		public unsafe Cooker.CookerType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x0019A9C8 File Offset: 0x00198BC8
		// (set) Token: 0x0600489F RID: 18591 RVA: 0x000253D8 File Offset: 0x000235D8
		public unsafe Cooker.CookerSeries cookerSeries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_cookerSeries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_cookerSeries)) = value;
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x060048A0 RID: 18592 RVA: 0x0019A9F0 File Offset: 0x00198BF0
		// (set) Token: 0x060048A1 RID: 18593 RVA: 0x000253F3 File Offset: 0x000235F3
		public unsafe CookerAssetBase cookerAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_cookerAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookerAssetBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_cookerAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x0019AA20 File Offset: 0x00198C20
		// (set) Token: 0x060048A3 RID: 18595 RVA: 0x00025412 File Offset: 0x00023612
		public unsafe AnimatedTile idle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_idle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_idle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x060048A4 RID: 18596 RVA: 0x0019AA50 File Offset: 0x00198C50
		// (set) Token: 0x060048A5 RID: 18597 RVA: 0x00025431 File Offset: 0x00023631
		public unsafe AnimatedTile loaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_loaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_loaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x0019AA80 File Offset: 0x00198C80
		// (set) Token: 0x060048A7 RID: 18599 RVA: 0x00025450 File Offset: 0x00023650
		public unsafe AnimatedTile cooking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_cooking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_cooking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x0019AAB0 File Offset: 0x00198CB0
		// (set) Token: 0x060048A9 RID: 18601 RVA: 0x0002546F File Offset: 0x0002366F
		public unsafe float illuminationIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_illuminationIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_illuminationIntensity)) = value;
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x0019AAD8 File Offset: 0x00198CD8
		// (set) Token: 0x060048AB RID: 18603 RVA: 0x0002548A File Offset: 0x0002368A
		public unsafe AudioClip startCookSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_startCookSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_startCookSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x0019AB08 File Offset: 0x00198D08
		// (set) Token: 0x060048AD RID: 18605 RVA: 0x000254A9 File Offset: 0x000236A9
		public unsafe AudioClip openCookSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_openCookSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cooker.NativeFieldInfoPtr_openCookSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x060048AE RID: 18606 RVA: 0x0019AB38 File Offset: 0x00198D38
		// (set) Token: 0x060048AF RID: 18607 RVA: 0x000254C8 File Offset: 0x000236C8
		public unsafe static int EMPTY_DESK
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Cooker.NativeFieldInfoPtr_EMPTY_DESK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cooker.NativeFieldInfoPtr_EMPTY_DESK, (void*)(&value));
			}
		}

		// Token: 0x040031CC RID: 12748
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040031CD RID: 12749
		private static readonly IntPtr NativeFieldInfoPtr_cookerSeries;

		// Token: 0x040031CE RID: 12750
		private static readonly IntPtr NativeFieldInfoPtr_cookerAsset;

		// Token: 0x040031CF RID: 12751
		private static readonly IntPtr NativeFieldInfoPtr_idle;

		// Token: 0x040031D0 RID: 12752
		private static readonly IntPtr NativeFieldInfoPtr_loaded;

		// Token: 0x040031D1 RID: 12753
		private static readonly IntPtr NativeFieldInfoPtr_cooking;

		// Token: 0x040031D2 RID: 12754
		private static readonly IntPtr NativeFieldInfoPtr_illuminationIntensity;

		// Token: 0x040031D3 RID: 12755
		private static readonly IntPtr NativeFieldInfoPtr_startCookSFX;

		// Token: 0x040031D4 RID: 12756
		private static readonly IntPtr NativeFieldInfoPtr_openCookSFX;

		// Token: 0x040031D5 RID: 12757
		private static readonly IntPtr NativeFieldInfoPtr_EMPTY_DESK;

		// Token: 0x040031D6 RID: 12758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_CookerType_CookerSeries_CookerAssetBase_AnimatedTile_AnimatedTile_AnimatedTile_Single_AudioClip_AudioClip_0;

		// Token: 0x040031D7 RID: 12759
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_CookerType_0;

		// Token: 0x040031D8 RID: 12760
		private static readonly IntPtr NativeMethodInfoPtr_get_Series_Public_get_CookerSeries_0;

		// Token: 0x040031D9 RID: 12761
		private static readonly IntPtr NativeMethodInfoPtr_get_CanOpenByPartner_Public_get_Boolean_0;

		// Token: 0x040031DA RID: 12762
		private static readonly IntPtr NativeMethodInfoPtr_get_CookTimeMultiplierCanUseByPartner_Public_get_Boolean_0;

		// Token: 0x040031DB RID: 12763
		private static readonly IntPtr NativeMethodInfoPtr_get_CookTimeMultiplier_Public_get_Single_0;

		// Token: 0x040031DC RID: 12764
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveNextOrderProb_Public_get_Single_0;

		// Token: 0x040031DD RID: 12765
		private static readonly IntPtr NativeMethodInfoPtr_get_Idle_Public_get_AnimatedTile_0;

		// Token: 0x040031DE RID: 12766
		private static readonly IntPtr NativeMethodInfoPtr_get_Loaded_Public_get_AnimatedTile_0;

		// Token: 0x040031DF RID: 12767
		private static readonly IntPtr NativeMethodInfoPtr_get_Cooking_Public_get_AnimatedTile_0;

		// Token: 0x040031E0 RID: 12768
		private static readonly IntPtr NativeMethodInfoPtr_get_IlluminationIntensity_Public_get_Single_0;

		// Token: 0x040031E1 RID: 12769
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenCookSFX_Public_get_AudioClip_0;

		// Token: 0x040031E2 RID: 12770
		private static readonly IntPtr NativeMethodInfoPtr_GetStartCookSFX_Public_AudioClip_CookerType_0;

		// Token: 0x040031E3 RID: 12771
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0;

		// Token: 0x040031E4 RID: 12772
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTriggerSpecialCookerSkill_Private_get_Boolean_0;

		// Token: 0x040031E5 RID: 12773
		private static readonly IntPtr NativeMethodInfoPtr_OnGetNormalGuests_Public_IEnumerable_1_IEnumerable_1_NormalGuest_IEnumerable_1_IEnumerable_1_NormalGuest_0;

		// Token: 0x040031E6 RID: 12774
		private static readonly IntPtr NativeMethodInfoPtr_OnGetCookerOutput_Public_IEnumerable_1_MatchedCookCombo_IEnumerable_1_MatchedCookCombo_0;

		// Token: 0x040031E7 RID: 12775
		private static readonly IntPtr NativeMethodInfoPtr_GetExtraCookSpeedMultiplier_Public_Single_CookController_Sellable_0;

		// Token: 0x040031E8 RID: 12776
		private static readonly IntPtr NativeMethodInfoPtr_GetExtraAdditiveNextOrderProb_Public_Single_Sellable_0;

		// Token: 0x040031E9 RID: 12777
		private static readonly IntPtr NativeMethodInfoPtr_OnStartCook_Public_Void_0;

		// Token: 0x040031EA RID: 12778
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishCook_Public_Sellable_Sellable_Single_Boolean_0;

		// Token: 0x040031EB RID: 12779
		private static readonly IntPtr NativeMethodInfoPtr_OnEvaluate_Public_Int32_Int32_GuestGroupController_Sellable_0;

		// Token: 0x040031EC RID: 12780
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowThisCookerBG_Public_Boolean_Sellable_0;

		// Token: 0x040031ED RID: 12781
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerFinishExtract_Public_Void_CookController_0;

		// Token: 0x040031EE RID: 12782
		private static readonly IntPtr NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Void_CookController_0;

		// Token: 0x040031EF RID: 12783
		private static readonly IntPtr NativeMethodInfoPtr_get_BGSprite_Public_Virtual_get_Sprite_0;

		// Token: 0x040031F0 RID: 12784
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x040031F1 RID: 12785
		private static readonly IntPtr NativeMethodInfoPtr_get_AllAvailableCookerType_Public_get_IEnumerable_1_CookerType_0;

		// Token: 0x040031F2 RID: 12786
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideTypeName_Public_get_String_0;

		// Token: 0x040031F3 RID: 12787
		private static readonly IntPtr NativeMethodInfoPtr_OnCookerWorkTimeUpdate_Public_Void_CookController_Single_0;

		// Token: 0x02000AC3 RID: 2755
		public enum CookerSeries
		{
			// Token: 0x04008488 RID: 33928
			Base,
			// Token: 0x04008489 RID: 33929
			Sparrow,
			// Token: 0x0400848A RID: 33930
			Super,
			// Token: 0x0400848B RID: 33931
			Extreme,
			// Token: 0x0400848C RID: 33932
			Nuclear,
			// Token: 0x0400848D RID: 33933
			Suspicious,
			// Token: 0x0400848E RID: 33934
			Tsukimi,
			// Token: 0x0400848F RID: 33935
			StarMagicPot = 1000,
			// Token: 0x04008490 RID: 33936
			PureHellFryer = 2000,
			// Token: 0x04008491 RID: 33937
			SamadhiFire = 3000,
			// Token: 0x04008492 RID: 33938
			PeerlessWindGod = 4000,
			// Token: 0x04008493 RID: 33939
			ByakurenCuttingBoard = 5000,
			// Token: 0x04008494 RID: 33940
			Trinity
		}

		// Token: 0x02000AC4 RID: 2756
		public enum CookerType
		{
			// Token: 0x04008496 RID: 33942
			Empty,
			// Token: 0x04008497 RID: 33943
			Pot,
			// Token: 0x04008498 RID: 33944
			Grill,
			// Token: 0x04008499 RID: 33945
			Fryer,
			// Token: 0x0400849A RID: 33946
			Steamer,
			// Token: 0x0400849B RID: 33947
			CuttingBoard
		}
	}
}
