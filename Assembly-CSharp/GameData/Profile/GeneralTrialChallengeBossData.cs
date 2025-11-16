using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.RunTime.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Runtime.CompilerServices;
using NightScene;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI;
using NightScene.UI.HUDUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002FC RID: 764
	public class GeneralTrialChallengeBossData : BossData
	{
		// Token: 0x06005C34 RID: 23604 RVA: 0x001D154C File Offset: 0x001CF74C
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralTrialChallengeBossData()
		{
			Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "GeneralTrialChallengeBossData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr);
			GeneralTrialChallengeBossData.NativeFieldInfoPtr_BASIC_SPELL_LANG_BEGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "BASIC_SPELL_LANG_BEGIN");
			GeneralTrialChallengeBossData.NativeFieldInfoPtr_ADVANCED_SPELL_LANG_BEGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "ADVANCED_SPELL_LANG_BEGIN");
			GeneralTrialChallengeBossData.NativeFieldInfoPtr_singleRoundDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "singleRoundDuration");
			GeneralTrialChallengeBossData.NativeFieldInfoPtr_roundConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "roundConfiguration");
			GeneralTrialChallengeBossData.NativeFieldInfoPtr_baseFundRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "baseFundRange");
			GeneralTrialChallengeBossData.NativeFieldInfoPtr_normalGuestInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "normalGuestInterval");
			GeneralTrialChallengeBossData.NativeFieldInfoPtr_specialGuestGachaInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "specialGuestGachaInterval");
			GeneralTrialChallengeBossData.NativeFieldInfoPtr_specialGuestSpellRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "specialGuestSpellRequirement");
			GeneralTrialChallengeBossData.NativeFieldInfoPtr_onChallengeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "onChallengeEnd");
			GeneralTrialChallengeBossData.NativeMethodInfoPtr_OnPreloadGeneralChallenge_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, 100682226);
			GeneralTrialChallengeBossData.NativeMethodInfoPtr_OnChallengeEnd_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, 100682227);
			GeneralTrialChallengeBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_Final_IEnumerator_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, 100682228);
			GeneralTrialChallengeBossData.NativeMethodInfoPtr_SetGlobalInput_Private_Void_UIManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, 100682229);
			GeneralTrialChallengeBossData.NativeMethodInfoPtr_MainChallengeLoopAsync_Private_UniTask_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, 100682230);
			GeneralTrialChallengeBossData.NativeMethodInfoPtr_ExecuteRoundAsync_Private_UniTask_1_Boolean_EventManager_UIManager_GuestsManager_IzakayaConfigure_CookSystemManager_SpecialGuest_Boolean_IncomeControllerChallenge_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, 100682231);
			GeneralTrialChallengeBossData.NativeMethodInfoPtr_HaveReachTargetRequirement_Private_Boolean_EventManager_Boolean_DataPair_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, 100682232);
			GeneralTrialChallengeBossData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, 100682233);
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x001D16D0 File Offset: 0x001CF8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230757, XrefRangeEnd = 230770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPreloadGeneralChallenge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralTrialChallengeBossData.NativeMethodInfoPtr_OnPreloadGeneralChallenge_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x001D170C File Offset: 0x001CF90C
		[CallerCount(0)]
		public unsafe virtual void OnChallengeEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralTrialChallengeBossData.NativeMethodInfoPtr_OnChallengeEnd_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x001D1748 File Offset: 0x001CF948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230770, XrefRangeEnd = 230776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_Final_IEnumerator_BossDataContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x001D17A0 File Offset: 0x001CF9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230776, XrefRangeEnd = 230782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalInput(UIManager uiManager, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.NativeMethodInfoPtr_SetGlobalInput_Private_Void_UIManager_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C39 RID: 23609 RVA: 0x001D17F0 File Offset: 0x001CF9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230801, RefRangeEnd = 230802, XrefRangeStart = 230782, XrefRangeEnd = 230801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask MainChallengeLoopAsync(BossData.BossDataContext bossDataContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.NativeMethodInfoPtr_MainChallengeLoopAsync_Private_UniTask_BossDataContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06005C3A RID: 23610 RVA: 0x001D1840 File Offset: 0x001CFA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230802, XrefRangeEnd = 230818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<bool> ExecuteRoundAsync(EventManager eventManager, UIManager uiManager, GuestsManager guestsManager, IzakayaConfigure izakayaConfigure, CookSystemManager cookSystemManagerInstance, SpecialGuest youm, bool includesSpecialGuest, IncomeControllerChallenge incomeControllerChallenge, int roundNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestsManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(izakayaConfigure);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookSystemManagerInstance);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(youm);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includesSpecialGuest;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(incomeControllerChallenge);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundNum;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.NativeMethodInfoPtr_ExecuteRoundAsync_Private_UniTask_1_Boolean_EventManager_UIManager_GuestsManager_IzakayaConfigure_CookSystemManager_SpecialGuest_Boolean_IncomeControllerChallenge_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<bool>(pointer);
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x001D1918 File Offset: 0x001CFB18
		[CallerCount(0)]
		public unsafe bool HaveReachTargetRequirement(EventManager eventManager, bool includesSpecialGuest, SceneManager.DataPair item, int gainedSpellCard, int currentRequiredSpellAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includesSpecialGuest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gainedSpellCard;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentRequiredSpellAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.NativeMethodInfoPtr_HaveReachTargetRequirement_Private_Boolean_EventManager_Boolean_DataPair_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x001D19A8 File Offset: 0x001CFBA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230343, RefRangeEnd = 230345, XrefRangeStart = 230343, XrefRangeEnd = 230345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralTrialChallengeBossData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x00032587 File Offset: 0x00030787
		public GeneralTrialChallengeBossData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06005C3E RID: 23614 RVA: 0x001D19E4 File Offset: 0x001CFBE4
		// (set) Token: 0x06005C3F RID: 23615 RVA: 0x00032590 File Offset: 0x00030790
		public unsafe static int BASIC_SPELL_LANG_BEGIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GeneralTrialChallengeBossData.NativeFieldInfoPtr_BASIC_SPELL_LANG_BEGIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GeneralTrialChallengeBossData.NativeFieldInfoPtr_BASIC_SPELL_LANG_BEGIN, (void*)(&value));
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06005C40 RID: 23616 RVA: 0x001D1A00 File Offset: 0x001CFC00
		// (set) Token: 0x06005C41 RID: 23617 RVA: 0x0003259E File Offset: 0x0003079E
		public unsafe static int ADVANCED_SPELL_LANG_BEGIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GeneralTrialChallengeBossData.NativeFieldInfoPtr_ADVANCED_SPELL_LANG_BEGIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GeneralTrialChallengeBossData.NativeFieldInfoPtr_ADVANCED_SPELL_LANG_BEGIN, (void*)(&value));
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06005C42 RID: 23618 RVA: 0x001D1A1C File Offset: 0x001CFC1C
		// (set) Token: 0x06005C43 RID: 23619 RVA: 0x000325AC File Offset: 0x000307AC
		public unsafe int singleRoundDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_singleRoundDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_singleRoundDuration)) = value;
			}
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06005C44 RID: 23620 RVA: 0x001D1A44 File Offset: 0x001CFC44
		// (set) Token: 0x06005C45 RID: 23621 RVA: 0x000325C7 File Offset: 0x000307C7
		public unsafe Il2CppReferenceArray<SceneManager.DataPair> roundConfiguration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_roundConfiguration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SceneManager.DataPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_roundConfiguration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06005C46 RID: 23622 RVA: 0x001D1A74 File Offset: 0x001CFC74
		// (set) Token: 0x06005C47 RID: 23623 RVA: 0x000325E6 File Offset: 0x000307E6
		public unsafe Vector2Int baseFundRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_baseFundRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_baseFundRange)) = value;
			}
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06005C48 RID: 23624 RVA: 0x001D1A9C File Offset: 0x001CFC9C
		// (set) Token: 0x06005C49 RID: 23625 RVA: 0x00032601 File Offset: 0x00030801
		public unsafe Vector2Int normalGuestInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_normalGuestInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_normalGuestInterval)) = value;
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06005C4A RID: 23626 RVA: 0x001D1AC4 File Offset: 0x001CFCC4
		// (set) Token: 0x06005C4B RID: 23627 RVA: 0x0003261C File Offset: 0x0003081C
		public unsafe float specialGuestGachaInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_specialGuestGachaInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_specialGuestGachaInterval)) = value;
			}
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x06005C4C RID: 23628 RVA: 0x001D1AEC File Offset: 0x001CFCEC
		// (set) Token: 0x06005C4D RID: 23629 RVA: 0x00032637 File Offset: 0x00030837
		public unsafe Il2CppStructArray<int> specialGuestSpellRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_specialGuestSpellRequirement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_specialGuestSpellRequirement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06005C4E RID: 23630 RVA: 0x001D1B1C File Offset: 0x001CFD1C
		// (set) Token: 0x06005C4F RID: 23631 RVA: 0x00032656 File Offset: 0x00030856
		public unsafe Action onChallengeEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_onChallengeEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.NativeFieldInfoPtr_onChallengeEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D1B RID: 15643
		private static readonly IntPtr NativeFieldInfoPtr_BASIC_SPELL_LANG_BEGIN;

		// Token: 0x04003D1C RID: 15644
		private static readonly IntPtr NativeFieldInfoPtr_ADVANCED_SPELL_LANG_BEGIN;

		// Token: 0x04003D1D RID: 15645
		private static readonly IntPtr NativeFieldInfoPtr_singleRoundDuration;

		// Token: 0x04003D1E RID: 15646
		private static readonly IntPtr NativeFieldInfoPtr_roundConfiguration;

		// Token: 0x04003D1F RID: 15647
		private static readonly IntPtr NativeFieldInfoPtr_baseFundRange;

		// Token: 0x04003D20 RID: 15648
		private static readonly IntPtr NativeFieldInfoPtr_normalGuestInterval;

		// Token: 0x04003D21 RID: 15649
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestGachaInterval;

		// Token: 0x04003D22 RID: 15650
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestSpellRequirement;

		// Token: 0x04003D23 RID: 15651
		private static readonly IntPtr NativeFieldInfoPtr_onChallengeEnd;

		// Token: 0x04003D24 RID: 15652
		private static readonly IntPtr NativeMethodInfoPtr_OnPreloadGeneralChallenge_Protected_Virtual_New_Void_0;

		// Token: 0x04003D25 RID: 15653
		private static readonly IntPtr NativeMethodInfoPtr_OnChallengeEnd_Protected_Virtual_New_Void_0;

		// Token: 0x04003D26 RID: 15654
		private static readonly IntPtr NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_Final_IEnumerator_BossDataContext_0;

		// Token: 0x04003D27 RID: 15655
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalInput_Private_Void_UIManager_Boolean_0;

		// Token: 0x04003D28 RID: 15656
		private static readonly IntPtr NativeMethodInfoPtr_MainChallengeLoopAsync_Private_UniTask_BossDataContext_0;

		// Token: 0x04003D29 RID: 15657
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteRoundAsync_Private_UniTask_1_Boolean_EventManager_UIManager_GuestsManager_IzakayaConfigure_CookSystemManager_SpecialGuest_Boolean_IncomeControllerChallenge_Int32_0;

		// Token: 0x04003D2A RID: 15658
		private static readonly IntPtr NativeMethodInfoPtr_HaveReachTargetRequirement_Private_Boolean_EventManager_Boolean_DataPair_Int32_Int32_0;

		// Token: 0x04003D2B RID: 15659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D16 RID: 3350
		[ObfuscatedName("GameData.Profile.GeneralTrialChallengeBossData+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F10A RID: 61706 RVA: 0x00393234 File Offset: 0x00391434
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass9_0>.NativeClassPtr);
				GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeFieldInfoPtr_foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass9_0>.NativeClassPtr, "foods");
				GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeFieldInfoPtr_bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass9_0>.NativeClassPtr, "bevs");
				GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeFieldInfoPtr_ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass9_0>.NativeClassPtr, "ings");
				GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass9_0>.NativeClassPtr, 100682234);
				GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass9_0>.NativeClassPtr, 100682235);
			}

			// Token: 0x0600F10B RID: 61707 RVA: 0x003932C4 File Offset: 0x003914C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F10C RID: 61708 RVA: 0x00393300 File Offset: 0x00391500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPreloadGeneralChallenge_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F10D RID: 61709 RVA: 0x000814E1 File Offset: 0x0007F6E1
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E62 RID: 20066
			// (get) Token: 0x0600F10E RID: 61710 RVA: 0x00393334 File Offset: 0x00391534
			// (set) Token: 0x0600F10F RID: 61711 RVA: 0x000814EA File Offset: 0x0007F6EA
			public unsafe IEnumerable<KeyValuePair<int, int>> foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeFieldInfoPtr_foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeFieldInfoPtr_foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E63 RID: 20067
			// (get) Token: 0x0600F110 RID: 61712 RVA: 0x00393364 File Offset: 0x00391564
			// (set) Token: 0x0600F111 RID: 61713 RVA: 0x00081509 File Offset: 0x0007F709
			public unsafe IEnumerable<KeyValuePair<int, int>> bevs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeFieldInfoPtr_bevs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeFieldInfoPtr_bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E64 RID: 20068
			// (get) Token: 0x0600F112 RID: 61714 RVA: 0x00393394 File Offset: 0x00391594
			// (set) Token: 0x0600F113 RID: 61715 RVA: 0x00081528 File Offset: 0x0007F728
			public unsafe IEnumerable<KeyValuePair<int, int>> ings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeFieldInfoPtr_ings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass9_0.NativeFieldInfoPtr_ings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099A7 RID: 39335
			private static readonly IntPtr NativeFieldInfoPtr_foods;

			// Token: 0x040099A8 RID: 39336
			private static readonly IntPtr NativeFieldInfoPtr_bevs;

			// Token: 0x040099A9 RID: 39337
			private static readonly IntPtr NativeFieldInfoPtr_ings;

			// Token: 0x040099AA RID: 39338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099AB RID: 39339
			private static readonly IntPtr NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0;
		}

		// Token: 0x02000D17 RID: 3351
		[ObfuscatedName("GameData.Profile.GeneralTrialChallengeBossData+<MainChallengeLoop>d__11")]
		public sealed class _MainChallengeLoop_d__11 : Il2CppSystem.Object
		{
			// Token: 0x0600F114 RID: 61716 RVA: 0x003933C4 File Offset: 0x003915C4
			// Note: this type is marked as 'beforefieldinit'.
			static _MainChallengeLoop_d__11()
			{
				Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "<MainChallengeLoop>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr);
				GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr, "<>1__state");
				GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr, "<>2__current");
				GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr, "<>4__this");
				GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr, "bossDataContext");
				GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr, 100682236);
				GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr, 100682237);
				GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr, 100682238);
				GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr, 100682239);
				GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr, 100682240);
				GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr, 100682241);
			}

			// Token: 0x0600F115 RID: 61717 RVA: 0x003934B8 File Offset: 0x003916B8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MainChallengeLoop_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoop_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F116 RID: 61718 RVA: 0x00393500 File Offset: 0x00391700
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F117 RID: 61719 RVA: 0x00393534 File Offset: 0x00391734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230345, XrefRangeEnd = 230348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004E69 RID: 20073
			// (get) Token: 0x0600F118 RID: 61720 RVA: 0x00393570 File Offset: 0x00391770
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F119 RID: 61721 RVA: 0x003935B0 File Offset: 0x003917B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230348, XrefRangeEnd = 230354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004E6A RID: 20074
			// (get) Token: 0x0600F11A RID: 61722 RVA: 0x003935E4 File Offset: 0x003917E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F11B RID: 61723 RVA: 0x00081547 File Offset: 0x0007F747
			public _MainChallengeLoop_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E65 RID: 20069
			// (get) Token: 0x0600F11C RID: 61724 RVA: 0x00393624 File Offset: 0x00391824
			// (set) Token: 0x0600F11D RID: 61725 RVA: 0x00081550 File Offset: 0x0007F750
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004E66 RID: 20070
			// (get) Token: 0x0600F11E RID: 61726 RVA: 0x0039364C File Offset: 0x0039184C
			// (set) Token: 0x0600F11F RID: 61727 RVA: 0x0008156B File Offset: 0x0007F76B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E67 RID: 20071
			// (get) Token: 0x0600F120 RID: 61728 RVA: 0x0039367C File Offset: 0x0039187C
			// (set) Token: 0x0600F121 RID: 61729 RVA: 0x0008158A File Offset: 0x0007F78A
			public unsafe GeneralTrialChallengeBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralTrialChallengeBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E68 RID: 20072
			// (get) Token: 0x0600F122 RID: 61730 RVA: 0x003936AC File Offset: 0x003918AC
			// (set) Token: 0x0600F123 RID: 61731 RVA: 0x000815A9 File Offset: 0x0007F7A9
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoop_d__11.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040099AC RID: 39340
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040099AD RID: 39341
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040099AE RID: 39342
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099AF RID: 39343
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x040099B0 RID: 39344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040099B1 RID: 39345
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099B2 RID: 39346
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040099B3 RID: 39347
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040099B4 RID: 39348
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099B5 RID: 39349
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D18 RID: 3352
		[ObfuscatedName("GameData.Profile.GeneralTrialChallengeBossData+<MainChallengeLoopAsync>d__13")]
		public sealed class _MainChallengeLoopAsync_d__13 : ValueType
		{
			// Token: 0x0600F124 RID: 61732 RVA: 0x003936DC File Offset: 0x003918DC
			// Note: this type is marked as 'beforefieldinit'.
			static _MainChallengeLoopAsync_d__13()
			{
				Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "<MainChallengeLoopAsync>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr);
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<>1__state");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<>t__builder");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<>4__this");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "bossDataContext");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__eventManager_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<eventManager>5__2");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__uiManager_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<uiManager>5__3");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__guestsManager_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<guestsManager>5__4");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__izakayaConfigure_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<izakayaConfigure>5__5");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__cookSystemManagerInstance_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<cookSystemManagerInstance>5__6");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__youm_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<youm>5__7");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__includesSpecialGuest_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<includesSpecialGuest>5__8");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__incomeControllerChallenge_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<incomeControllerChallenge>5__9");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__i_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<i>5__10");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, "<>u__1");
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, 100682242);
				GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr, 100682243);
			}

			// Token: 0x0600F125 RID: 61733 RVA: 0x00393848 File Offset: 0x00391A48
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 230437, RefRangeEnd = 230440, XrefRangeStart = 230354, XrefRangeEnd = 230437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F126 RID: 61734 RVA: 0x00393880 File Offset: 0x00391A80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F127 RID: 61735 RVA: 0x000815D7 File Offset: 0x0007F7D7
			public _MainChallengeLoopAsync_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600F128 RID: 61736 RVA: 0x000815E0 File Offset: 0x0007F7E0
			public _MainChallengeLoopAsync_d__13() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13>.NativeClassPtr))
			{
			}

			// Token: 0x17004E6B RID: 20075
			// (get) Token: 0x0600F129 RID: 61737 RVA: 0x003938C8 File Offset: 0x00391AC8
			// (set) Token: 0x0600F12A RID: 61738 RVA: 0x000815F2 File Offset: 0x0007F7F2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004E6C RID: 20076
			// (get) Token: 0x0600F12B RID: 61739 RVA: 0x003938F0 File Offset: 0x00391AF0
			// (set) Token: 0x0600F12C RID: 61740 RVA: 0x0008160D File Offset: 0x0007F80D
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004E6D RID: 20077
			// (get) Token: 0x0600F12D RID: 61741 RVA: 0x00393920 File Offset: 0x00391B20
			// (set) Token: 0x0600F12E RID: 61742 RVA: 0x0008163B File Offset: 0x0007F83B
			public unsafe GeneralTrialChallengeBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralTrialChallengeBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E6E RID: 20078
			// (get) Token: 0x0600F12F RID: 61743 RVA: 0x00393950 File Offset: 0x00391B50
			// (set) Token: 0x0600F130 RID: 61744 RVA: 0x0008165A File Offset: 0x0007F85A
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004E6F RID: 20079
			// (get) Token: 0x0600F131 RID: 61745 RVA: 0x00393980 File Offset: 0x00391B80
			// (set) Token: 0x0600F132 RID: 61746 RVA: 0x00081688 File Offset: 0x0007F888
			public unsafe EventManager _eventManager_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__eventManager_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__eventManager_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E70 RID: 20080
			// (get) Token: 0x0600F133 RID: 61747 RVA: 0x003939B0 File Offset: 0x00391BB0
			// (set) Token: 0x0600F134 RID: 61748 RVA: 0x000816A7 File Offset: 0x0007F8A7
			public unsafe UIManager _uiManager_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__uiManager_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__uiManager_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E71 RID: 20081
			// (get) Token: 0x0600F135 RID: 61749 RVA: 0x003939E0 File Offset: 0x00391BE0
			// (set) Token: 0x0600F136 RID: 61750 RVA: 0x000816C6 File Offset: 0x0007F8C6
			public unsafe GuestsManager _guestsManager_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__guestsManager_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__guestsManager_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E72 RID: 20082
			// (get) Token: 0x0600F137 RID: 61751 RVA: 0x00393A10 File Offset: 0x00391C10
			// (set) Token: 0x0600F138 RID: 61752 RVA: 0x000816E5 File Offset: 0x0007F8E5
			public unsafe IzakayaConfigure _izakayaConfigure_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__izakayaConfigure_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigure>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__izakayaConfigure_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E73 RID: 20083
			// (get) Token: 0x0600F139 RID: 61753 RVA: 0x00393A40 File Offset: 0x00391C40
			// (set) Token: 0x0600F13A RID: 61754 RVA: 0x00081704 File Offset: 0x0007F904
			public unsafe CookSystemManager _cookSystemManagerInstance_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__cookSystemManagerInstance_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookSystemManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__cookSystemManagerInstance_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E74 RID: 20084
			// (get) Token: 0x0600F13B RID: 61755 RVA: 0x00393A70 File Offset: 0x00391C70
			// (set) Token: 0x0600F13C RID: 61756 RVA: 0x00081723 File Offset: 0x0007F923
			public unsafe SpecialGuest _youm_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__youm_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__youm_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E75 RID: 20085
			// (get) Token: 0x0600F13D RID: 61757 RVA: 0x00393AA0 File Offset: 0x00391CA0
			// (set) Token: 0x0600F13E RID: 61758 RVA: 0x00081742 File Offset: 0x0007F942
			public unsafe bool _includesSpecialGuest_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__includesSpecialGuest_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__includesSpecialGuest_5__8)) = value;
				}
			}

			// Token: 0x17004E76 RID: 20086
			// (get) Token: 0x0600F13F RID: 61759 RVA: 0x00393AC8 File Offset: 0x00391CC8
			// (set) Token: 0x0600F140 RID: 61760 RVA: 0x0008175D File Offset: 0x0007F95D
			public unsafe IncomeControllerChallenge _incomeControllerChallenge_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__incomeControllerChallenge_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerChallenge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__incomeControllerChallenge_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E77 RID: 20087
			// (get) Token: 0x0600F141 RID: 61761 RVA: 0x00393AF8 File Offset: 0x00391CF8
			// (set) Token: 0x0600F142 RID: 61762 RVA: 0x0008177C File Offset: 0x0007F97C
			public unsafe int _i_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__i_5__10);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr__i_5__10)) = value;
				}
			}

			// Token: 0x17004E78 RID: 20088
			// (get) Token: 0x0600F143 RID: 61763 RVA: 0x00393B20 File Offset: 0x00391D20
			// (set) Token: 0x0600F144 RID: 61764 RVA: 0x00081797 File Offset: 0x0007F997
			public UniTask<bool>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___u__1);
					return new UniTask<bool>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._MainChallengeLoopAsync_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040099B6 RID: 39350
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040099B7 RID: 39351
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040099B8 RID: 39352
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099B9 RID: 39353
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x040099BA RID: 39354
			private static readonly IntPtr NativeFieldInfoPtr__eventManager_5__2;

			// Token: 0x040099BB RID: 39355
			private static readonly IntPtr NativeFieldInfoPtr__uiManager_5__3;

			// Token: 0x040099BC RID: 39356
			private static readonly IntPtr NativeFieldInfoPtr__guestsManager_5__4;

			// Token: 0x040099BD RID: 39357
			private static readonly IntPtr NativeFieldInfoPtr__izakayaConfigure_5__5;

			// Token: 0x040099BE RID: 39358
			private static readonly IntPtr NativeFieldInfoPtr__cookSystemManagerInstance_5__6;

			// Token: 0x040099BF RID: 39359
			private static readonly IntPtr NativeFieldInfoPtr__youm_5__7;

			// Token: 0x040099C0 RID: 39360
			private static readonly IntPtr NativeFieldInfoPtr__includesSpecialGuest_5__8;

			// Token: 0x040099C1 RID: 39361
			private static readonly IntPtr NativeFieldInfoPtr__incomeControllerChallenge_5__9;

			// Token: 0x040099C2 RID: 39362
			private static readonly IntPtr NativeFieldInfoPtr__i_5__10;

			// Token: 0x040099C3 RID: 39363
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040099C4 RID: 39364
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099C5 RID: 39365
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000D19 RID: 3353
		[ObfuscatedName("GameData.Profile.GeneralTrialChallengeBossData+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F145 RID: 61765 RVA: 0x00393B50 File Offset: 0x00391D50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr);
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_gainedSpellCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, "gainedSpellCard");
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_incomeControllerChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, "incomeControllerChallenge");
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_currentRequiredSpellAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, "currentRequiredSpellAmount");
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_guestsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, "guestsManager");
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, "<>9__7");
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, "<>9__8");
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, 100682244);
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialGuestsController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, 100682245);
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeMethodInfoPtr__ExecuteRoundAsync_b__5_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, 100682246);
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeMethodInfoPtr__ExecuteRoundAsync_b__7_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, 100682247);
				GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeMethodInfoPtr__ExecuteRoundAsync_b__8_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr, 100682248);
			}

			// Token: 0x0600F146 RID: 61766 RVA: 0x00393C6C File Offset: 0x00391E6C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F147 RID: 61767 RVA: 0x00393CA8 File Offset: 0x00391EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230440, XrefRangeEnd = 230442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialGuestsController_PDM_0(SpecialGuestsController _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialGuestsController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F148 RID: 61768 RVA: 0x00393CEC File Offset: 0x00391EEC
			[CallerCount(0)]
			public unsafe int _ExecuteRoundAsync_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeMethodInfoPtr__ExecuteRoundAsync_b__5_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F149 RID: 61769 RVA: 0x00393D28 File Offset: 0x00391F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230442, XrefRangeEnd = 230443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExecuteRoundAsync_b__7(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeMethodInfoPtr__ExecuteRoundAsync_b__7_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F14A RID: 61770 RVA: 0x00393D6C File Offset: 0x00391F6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230443, XrefRangeEnd = 230444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExecuteRoundAsync_b__8(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeMethodInfoPtr__ExecuteRoundAsync_b__8_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F14B RID: 61771 RVA: 0x000817C5 File Offset: 0x0007F9C5
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E79 RID: 20089
			// (get) Token: 0x0600F14C RID: 61772 RVA: 0x00393DB0 File Offset: 0x00391FB0
			// (set) Token: 0x0600F14D RID: 61773 RVA: 0x000817CE File Offset: 0x0007F9CE
			public unsafe int gainedSpellCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_gainedSpellCard);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_gainedSpellCard)) = value;
				}
			}

			// Token: 0x17004E7A RID: 20090
			// (get) Token: 0x0600F14E RID: 61774 RVA: 0x00393DD8 File Offset: 0x00391FD8
			// (set) Token: 0x0600F14F RID: 61775 RVA: 0x000817E9 File Offset: 0x0007F9E9
			public unsafe IncomeControllerChallenge incomeControllerChallenge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_incomeControllerChallenge);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerChallenge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_incomeControllerChallenge), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E7B RID: 20091
			// (get) Token: 0x0600F150 RID: 61776 RVA: 0x00393E08 File Offset: 0x00392008
			// (set) Token: 0x0600F151 RID: 61777 RVA: 0x00081808 File Offset: 0x0007FA08
			public unsafe int currentRequiredSpellAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_currentRequiredSpellAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_currentRequiredSpellAmount)) = value;
				}
			}

			// Token: 0x17004E7C RID: 20092
			// (get) Token: 0x0600F152 RID: 61778 RVA: 0x00393E30 File Offset: 0x00392030
			// (set) Token: 0x0600F153 RID: 61779 RVA: 0x00081823 File Offset: 0x0007FA23
			public unsafe GeneralTrialChallengeBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralTrialChallengeBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E7D RID: 20093
			// (get) Token: 0x0600F154 RID: 61780 RVA: 0x00393E60 File Offset: 0x00392060
			// (set) Token: 0x0600F155 RID: 61781 RVA: 0x00081842 File Offset: 0x0007FA42
			public unsafe GuestsManager guestsManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_guestsManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr_guestsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E7E RID: 20094
			// (get) Token: 0x0600F156 RID: 61782 RVA: 0x00393E90 File Offset: 0x00392090
			// (set) Token: 0x0600F157 RID: 61783 RVA: 0x00081861 File Offset: 0x0007FA61
			public unsafe Action<GuestGroupController> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E7F RID: 20095
			// (get) Token: 0x0600F158 RID: 61784 RVA: 0x00393EC0 File Offset: 0x003920C0
			// (set) Token: 0x0600F159 RID: 61785 RVA: 0x00081880 File Offset: 0x0007FA80
			public unsafe Action<GuestGroupController> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_0.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099C6 RID: 39366
			private static readonly IntPtr NativeFieldInfoPtr_gainedSpellCard;

			// Token: 0x040099C7 RID: 39367
			private static readonly IntPtr NativeFieldInfoPtr_incomeControllerChallenge;

			// Token: 0x040099C8 RID: 39368
			private static readonly IntPtr NativeFieldInfoPtr_currentRequiredSpellAmount;

			// Token: 0x040099C9 RID: 39369
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099CA RID: 39370
			private static readonly IntPtr NativeFieldInfoPtr_guestsManager;

			// Token: 0x040099CB RID: 39371
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x040099CC RID: 39372
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x040099CD RID: 39373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099CE RID: 39374
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialGuestsController_PDM_0;

			// Token: 0x040099CF RID: 39375
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteRoundAsync_b__5_Internal_Int32_0;

			// Token: 0x040099D0 RID: 39376
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteRoundAsync_b__7_Internal_Void_GuestGroupController_0;

			// Token: 0x040099D1 RID: 39377
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteRoundAsync_b__8_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000D1A RID: 3354
		[ObfuscatedName("GameData.Profile.GeneralTrialChallengeBossData+<>c__DisplayClass14_1")]
		public sealed class __c__DisplayClass14_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F15A RID: 61786 RVA: 0x00393EF0 File Offset: 0x003920F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_1()
			{
				Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "<>c__DisplayClass14_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_1>.NativeClassPtr);
				GeneralTrialChallengeBossData.__c__DisplayClass14_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_1>.NativeClassPtr, "x");
				GeneralTrialChallengeBossData.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_1>.NativeClassPtr, 100682249);
				GeneralTrialChallengeBossData.__c__DisplayClass14_1.NativeMethodInfoPtr__ExecuteRoundAsync_b__6_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_1>.NativeClassPtr, 100682250);
			}

			// Token: 0x0600F15B RID: 61787 RVA: 0x00393F58 File Offset: 0x00392158
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c__DisplayClass14_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F15C RID: 61788 RVA: 0x00393F94 File Offset: 0x00392194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230444, XrefRangeEnd = 230454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExecuteRoundAsync_b__6(Izakaya.SpecialGuestGroup y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c__DisplayClass14_1.NativeMethodInfoPtr__ExecuteRoundAsync_b__6_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F15D RID: 61789 RVA: 0x0008189F File Offset: 0x0007FA9F
			public __c__DisplayClass14_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E80 RID: 20096
			// (get) Token: 0x0600F15E RID: 61790 RVA: 0x00393FE4 File Offset: 0x003921E4
			// (set) Token: 0x0600F15F RID: 61791 RVA: 0x000818A8 File Offset: 0x0007FAA8
			public unsafe Izakaya x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_1.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData.__c__DisplayClass14_1.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099D2 RID: 39378
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x040099D3 RID: 39379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099D4 RID: 39380
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteRoundAsync_b__6_Internal_Boolean_SpecialGuestGroup_0;
		}

		// Token: 0x02000D1B RID: 3355
		[ObfuscatedName("GameData.Profile.GeneralTrialChallengeBossData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F160 RID: 61792 RVA: 0x00394014 File Offset: 0x00392214
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr);
				GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr, "<>9");
				GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr, "<>9__14_1");
				GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr, "<>9__14_2");
				GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr, "<>9__14_3");
				GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr, "<>9__14_4");
				GeneralTrialChallengeBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr, 100682252);
				GeneralTrialChallengeBossData.__c.NativeMethodInfoPtr__ExecuteRoundAsync_b__14_1_Internal_IEnumerable_1_SpecialGuestGroup_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr, 100682253);
				GeneralTrialChallengeBossData.__c.NativeMethodInfoPtr__ExecuteRoundAsync_b__14_2_Internal_Int32_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr, 100682254);
				GeneralTrialChallengeBossData.__c.NativeMethodInfoPtr__ExecuteRoundAsync_b__14_3_Internal_SpecialGuestGroup_IGrouping_2_Int32_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr, 100682255);
				GeneralTrialChallengeBossData.__c.NativeMethodInfoPtr__ExecuteRoundAsync_b__14_4_Internal_IEnumerable_1_NormalGuestGroup_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr, 100682256);
			}

			// Token: 0x0600F161 RID: 61793 RVA: 0x00394108 File Offset: 0x00392308
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralTrialChallengeBossData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F162 RID: 61794 RVA: 0x00394144 File Offset: 0x00392344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230454, XrefRangeEnd = 230469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Izakaya.SpecialGuestGroup> _ExecuteRoundAsync_b__14_1(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c.NativeMethodInfoPtr__ExecuteRoundAsync_b__14_1_Internal_IEnumerable_1_SpecialGuestGroup_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Izakaya.SpecialGuestGroup>>(intPtr3) : null;
			}

			// Token: 0x0600F163 RID: 61795 RVA: 0x00394194 File Offset: 0x00392394
			[CallerCount(0)]
			public unsafe int _ExecuteRoundAsync_b__14_2(Izakaya.SpecialGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c.NativeMethodInfoPtr__ExecuteRoundAsync_b__14_2_Internal_Int32_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F164 RID: 61796 RVA: 0x003941E4 File Offset: 0x003923E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230469, XrefRangeEnd = 230472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Izakaya.SpecialGuestGroup _ExecuteRoundAsync_b__14_3(IGrouping<int, Izakaya.SpecialGuestGroup> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c.NativeMethodInfoPtr__ExecuteRoundAsync_b__14_3_Internal_SpecialGuestGroup_IGrouping_2_Int32_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Izakaya.SpecialGuestGroup>(intPtr3) : null;
			}

			// Token: 0x0600F165 RID: 61797 RVA: 0x00394234 File Offset: 0x00392434
			[CallerCount(0)]
			public unsafe IEnumerable<Izakaya.NormalGuestGroup> _ExecuteRoundAsync_b__14_4(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData.__c.NativeMethodInfoPtr__ExecuteRoundAsync_b__14_4_Internal_IEnumerable_1_NormalGuestGroup_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Izakaya.NormalGuestGroup>>(intPtr3) : null;
			}

			// Token: 0x0600F166 RID: 61798 RVA: 0x000818C7 File Offset: 0x0007FAC7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E81 RID: 20097
			// (get) Token: 0x0600F167 RID: 61799 RVA: 0x00394284 File Offset: 0x00392484
			// (set) Token: 0x0600F168 RID: 61800 RVA: 0x000818D0 File Offset: 0x0007FAD0
			public unsafe static GeneralTrialChallengeBossData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralTrialChallengeBossData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E82 RID: 20098
			// (get) Token: 0x0600F169 RID: 61801 RVA: 0x003942AC File Offset: 0x003924AC
			// (set) Token: 0x0600F16A RID: 61802 RVA: 0x000818E2 File Offset: 0x0007FAE2
			public unsafe static Func<Izakaya, IEnumerable<Izakaya.SpecialGuestGroup>> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, IEnumerable<Izakaya.SpecialGuestGroup>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E83 RID: 20099
			// (get) Token: 0x0600F16B RID: 61803 RVA: 0x003942D4 File Offset: 0x003924D4
			// (set) Token: 0x0600F16C RID: 61804 RVA: 0x000818F4 File Offset: 0x0007FAF4
			public unsafe static Func<Izakaya.SpecialGuestGroup, int> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.SpecialGuestGroup, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E84 RID: 20100
			// (get) Token: 0x0600F16D RID: 61805 RVA: 0x003942FC File Offset: 0x003924FC
			// (set) Token: 0x0600F16E RID: 61806 RVA: 0x00081906 File Offset: 0x0007FB06
			public unsafe static Func<IGrouping<int, Izakaya.SpecialGuestGroup>, Izakaya.SpecialGuestGroup> __9__14_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, Izakaya.SpecialGuestGroup>, Izakaya.SpecialGuestGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E85 RID: 20101
			// (get) Token: 0x0600F16F RID: 61807 RVA: 0x00394324 File Offset: 0x00392524
			// (set) Token: 0x0600F170 RID: 61808 RVA: 0x00081918 File Offset: 0x0007FB18
			public unsafe static Func<Izakaya, IEnumerable<Izakaya.NormalGuestGroup>> __9__14_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, IEnumerable<Izakaya.NormalGuestGroup>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GeneralTrialChallengeBossData.__c.NativeFieldInfoPtr___9__14_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099D5 RID: 39381
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040099D6 RID: 39382
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x040099D7 RID: 39383
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x040099D8 RID: 39384
			private static readonly IntPtr NativeFieldInfoPtr___9__14_3;

			// Token: 0x040099D9 RID: 39385
			private static readonly IntPtr NativeFieldInfoPtr___9__14_4;

			// Token: 0x040099DA RID: 39386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099DB RID: 39387
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteRoundAsync_b__14_1_Internal_IEnumerable_1_SpecialGuestGroup_Izakaya_0;

			// Token: 0x040099DC RID: 39388
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteRoundAsync_b__14_2_Internal_Int32_SpecialGuestGroup_0;

			// Token: 0x040099DD RID: 39389
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteRoundAsync_b__14_3_Internal_SpecialGuestGroup_IGrouping_2_Int32_SpecialGuestGroup_0;

			// Token: 0x040099DE RID: 39390
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteRoundAsync_b__14_4_Internal_IEnumerable_1_NormalGuestGroup_Izakaya_0;
		}

		// Token: 0x02000D1C RID: 3356
		[ObfuscatedName("GameData.Profile.GeneralTrialChallengeBossData+<ExecuteRoundAsync>d__14")]
		public sealed class _ExecuteRoundAsync_d__14 : ValueType
		{
			// Token: 0x0600F171 RID: 61809 RVA: 0x0039434C File Offset: 0x0039254C
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteRoundAsync_d__14()
			{
				Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralTrialChallengeBossData>.NativeClassPtr, "<ExecuteRoundAsync>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr);
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "<>1__state");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "<>t__builder");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_incomeControllerChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "incomeControllerChallenge");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "<>4__this");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_guestsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "guestsManager");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_roundNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "roundNum");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_includesSpecialGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "includesSpecialGuest");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_izakayaConfigure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "izakayaConfigure");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_cookSystemManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "cookSystemManagerInstance");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "eventManager");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_youm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "youm");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "<>8__1");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_uiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "uiManager");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr__item_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "<item>5__2");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, "<>u__1");
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, 100682257);
				GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr, 100682258);
			}

			// Token: 0x0600F172 RID: 61810 RVA: 0x003944CC File Offset: 0x003926CC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 230751, RefRangeEnd = 230754, XrefRangeStart = 230472, XrefRangeEnd = 230751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F173 RID: 61811 RVA: 0x00394504 File Offset: 0x00392704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230754, XrefRangeEnd = 230757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F174 RID: 61812 RVA: 0x0008192A File Offset: 0x0007FB2A
			public _ExecuteRoundAsync_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600F175 RID: 61813 RVA: 0x00081933 File Offset: 0x0007FB33
			public _ExecuteRoundAsync_d__14() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14>.NativeClassPtr))
			{
			}

			// Token: 0x17004E86 RID: 20102
			// (get) Token: 0x0600F176 RID: 61814 RVA: 0x0039454C File Offset: 0x0039274C
			// (set) Token: 0x0600F177 RID: 61815 RVA: 0x00081945 File Offset: 0x0007FB45
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004E87 RID: 20103
			// (get) Token: 0x0600F178 RID: 61816 RVA: 0x00394574 File Offset: 0x00392774
			// (set) Token: 0x0600F179 RID: 61817 RVA: 0x00081960 File Offset: 0x0007FB60
			public AsyncUniTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004E88 RID: 20104
			// (get) Token: 0x0600F17A RID: 61818 RVA: 0x003945A4 File Offset: 0x003927A4
			// (set) Token: 0x0600F17B RID: 61819 RVA: 0x0008198E File Offset: 0x0007FB8E
			public unsafe IncomeControllerChallenge incomeControllerChallenge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_incomeControllerChallenge);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerChallenge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_incomeControllerChallenge), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E89 RID: 20105
			// (get) Token: 0x0600F17C RID: 61820 RVA: 0x003945D4 File Offset: 0x003927D4
			// (set) Token: 0x0600F17D RID: 61821 RVA: 0x000819AD File Offset: 0x0007FBAD
			public unsafe GeneralTrialChallengeBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralTrialChallengeBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E8A RID: 20106
			// (get) Token: 0x0600F17E RID: 61822 RVA: 0x00394604 File Offset: 0x00392804
			// (set) Token: 0x0600F17F RID: 61823 RVA: 0x000819CC File Offset: 0x0007FBCC
			public unsafe GuestsManager guestsManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_guestsManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_guestsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E8B RID: 20107
			// (get) Token: 0x0600F180 RID: 61824 RVA: 0x00394634 File Offset: 0x00392834
			// (set) Token: 0x0600F181 RID: 61825 RVA: 0x000819EB File Offset: 0x0007FBEB
			public unsafe int roundNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_roundNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_roundNum)) = value;
				}
			}

			// Token: 0x17004E8C RID: 20108
			// (get) Token: 0x0600F182 RID: 61826 RVA: 0x0039465C File Offset: 0x0039285C
			// (set) Token: 0x0600F183 RID: 61827 RVA: 0x00081A06 File Offset: 0x0007FC06
			public unsafe bool includesSpecialGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_includesSpecialGuest);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_includesSpecialGuest)) = value;
				}
			}

			// Token: 0x17004E8D RID: 20109
			// (get) Token: 0x0600F184 RID: 61828 RVA: 0x00394684 File Offset: 0x00392884
			// (set) Token: 0x0600F185 RID: 61829 RVA: 0x00081A21 File Offset: 0x0007FC21
			public unsafe IzakayaConfigure izakayaConfigure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_izakayaConfigure);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigure>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_izakayaConfigure), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E8E RID: 20110
			// (get) Token: 0x0600F186 RID: 61830 RVA: 0x003946B4 File Offset: 0x003928B4
			// (set) Token: 0x0600F187 RID: 61831 RVA: 0x00081A40 File Offset: 0x0007FC40
			public unsafe CookSystemManager cookSystemManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_cookSystemManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookSystemManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_cookSystemManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E8F RID: 20111
			// (get) Token: 0x0600F188 RID: 61832 RVA: 0x003946E4 File Offset: 0x003928E4
			// (set) Token: 0x0600F189 RID: 61833 RVA: 0x00081A5F File Offset: 0x0007FC5F
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E90 RID: 20112
			// (get) Token: 0x0600F18A RID: 61834 RVA: 0x00394714 File Offset: 0x00392914
			// (set) Token: 0x0600F18B RID: 61835 RVA: 0x00081A7E File Offset: 0x0007FC7E
			public unsafe SpecialGuest youm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_youm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_youm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E91 RID: 20113
			// (get) Token: 0x0600F18C RID: 61836 RVA: 0x00394744 File Offset: 0x00392944
			// (set) Token: 0x0600F18D RID: 61837 RVA: 0x00081A9D File Offset: 0x0007FC9D
			public unsafe GeneralTrialChallengeBossData.__c__DisplayClass14_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralTrialChallengeBossData.__c__DisplayClass14_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E92 RID: 20114
			// (get) Token: 0x0600F18E RID: 61838 RVA: 0x00394774 File Offset: 0x00392974
			// (set) Token: 0x0600F18F RID: 61839 RVA: 0x00081ABC File Offset: 0x0007FCBC
			public unsafe UIManager uiManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_uiManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr_uiManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E93 RID: 20115
			// (get) Token: 0x0600F190 RID: 61840 RVA: 0x003947A4 File Offset: 0x003929A4
			// (set) Token: 0x0600F191 RID: 61841 RVA: 0x00081ADB File Offset: 0x0007FCDB
			public SceneManager.DataPair _item_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr__item_5__2);
					return new SceneManager.DataPair(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneManager.DataPair>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr__item_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SceneManager.DataPair>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004E94 RID: 20116
			// (get) Token: 0x0600F192 RID: 61842 RVA: 0x003947D4 File Offset: 0x003929D4
			// (set) Token: 0x0600F193 RID: 61843 RVA: 0x00081B09 File Offset: 0x0007FD09
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralTrialChallengeBossData._ExecuteRoundAsync_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040099DF RID: 39391
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040099E0 RID: 39392
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040099E1 RID: 39393
			private static readonly IntPtr NativeFieldInfoPtr_incomeControllerChallenge;

			// Token: 0x040099E2 RID: 39394
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099E3 RID: 39395
			private static readonly IntPtr NativeFieldInfoPtr_guestsManager;

			// Token: 0x040099E4 RID: 39396
			private static readonly IntPtr NativeFieldInfoPtr_roundNum;

			// Token: 0x040099E5 RID: 39397
			private static readonly IntPtr NativeFieldInfoPtr_includesSpecialGuest;

			// Token: 0x040099E6 RID: 39398
			private static readonly IntPtr NativeFieldInfoPtr_izakayaConfigure;

			// Token: 0x040099E7 RID: 39399
			private static readonly IntPtr NativeFieldInfoPtr_cookSystemManagerInstance;

			// Token: 0x040099E8 RID: 39400
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040099E9 RID: 39401
			private static readonly IntPtr NativeFieldInfoPtr_youm;

			// Token: 0x040099EA RID: 39402
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040099EB RID: 39403
			private static readonly IntPtr NativeFieldInfoPtr_uiManager;

			// Token: 0x040099EC RID: 39404
			private static readonly IntPtr NativeFieldInfoPtr__item_5__2;

			// Token: 0x040099ED RID: 39405
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040099EE RID: 39406
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099EF RID: 39407
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
