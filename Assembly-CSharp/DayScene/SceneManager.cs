using System;
using Cinemachine;
using Common.UI.NoteBookUtility;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.Input;
using DayScene.UI;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AssetHandleUtility;
using DEYU.Singletons;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.RunTime.Common;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene
{
	// Token: 0x020000B6 RID: 182
	public class SceneManager : MonoSingleton<SceneManager>
	{
		// Token: 0x06001389 RID: 5001 RVA: 0x000E0130 File Offset: 0x000DE330
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
			Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene", "SceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
			SceneManager.NativeFieldInfoPtr_TRAVEL_ACTION_COST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "TRAVEL_ACTION_COST");
			SceneManager.NativeFieldInfoPtr_KOURINDO_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "KOURINDO_KEY");
			SceneManager.NativeFieldInfoPtr_onDaySceneReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "onDaySceneReady");
			SceneManager.NativeFieldInfoPtr_defaultMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "defaultMap");
			SceneManager.NativeFieldInfoPtr_virtualCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "virtualCamera");
			SceneManager.NativeFieldInfoPtr_onDayOverDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "onDayOverDialog");
			SceneManager.NativeFieldInfoPtr_characterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "characterTransform");
			SceneManager.NativeFieldInfoPtr_ActivePannelRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "ActivePannelRoot");
			SceneManager.NativeFieldInfoPtr_releaseQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "releaseQueue");
			SceneManager.NativeFieldInfoPtr_scheduledActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "scheduledActions");
			SceneManager.NativeFieldInfoPtr_isExecutingScheduledActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "isExecutingScheduledActions");
			SceneManager.NativeFieldInfoPtr_m_RequireLoadDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_RequireLoadDependencies");
			SceneManager.NativeFieldInfoPtr__Character_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<Character>k__BackingField");
			SceneManager.NativeFieldInfoPtr__CurrentActiveMapLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<CurrentActiveMapLabel>k__BackingField");
			SceneManager.NativeFieldInfoPtr__TargetMapLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<TargetMapLabel>k__BackingField");
			SceneManager.NativeFieldInfoPtr__PlayerCollider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<PlayerCollider>k__BackingField");
			SceneManager.NativeFieldInfoPtr__CurrentActiveMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<CurrentActiveMap>k__BackingField");
			SceneManager.NativeFieldInfoPtr_m_HasTriggerOnEnterDaySceneEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_HasTriggerOnEnterDaySceneEvent");
			SceneManager.NativeFieldInfoPtr__IsMapSwapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<IsMapSwapping>k__BackingField");
			SceneManager.NativeFieldInfoPtr_roguelikeDataProfileAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "roguelikeDataProfileAsset");
			SceneManager.NativeFieldInfoPtr_roguelikeDataUnchangeableProfileAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "roguelikeDataUnchangeableProfileAsset");
			SceneManager.NativeFieldInfoPtr_m_MasterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_MasterId");
			SceneManager.NativeFieldInfoPtr_m_DisappearDayRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_DisappearDayRange");
			SceneManager.NativeFieldInfoPtr_m_DisappearNewsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_DisappearNewsLabel");
			SceneManager.NativeFieldInfoPtr_m_AppearNewsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_AppearNewsLabel");
			SceneManager.NativeFieldInfoPtr_m_DisappearReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_DisappearReason");
			SceneManager.NativeFieldInfoPtr_m_MapExclusions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_MapExclusions");
			SceneManager.NativeMethodInfoPtr_get_Character_Public_get_DayScenePlayerInputGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666682);
			SceneManager.NativeMethodInfoPtr_set_Character_Private_set_Void_DayScenePlayerInputGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666683);
			SceneManager.NativeMethodInfoPtr_get_CurrentActiveMapLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666684);
			SceneManager.NativeMethodInfoPtr_set_CurrentActiveMapLabel_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666685);
			SceneManager.NativeMethodInfoPtr_get_TargetMapLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666686);
			SceneManager.NativeMethodInfoPtr_set_TargetMapLabel_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666687);
			SceneManager.NativeMethodInfoPtr_get_PlayerCollider_Public_get_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666688);
			SceneManager.NativeMethodInfoPtr_set_PlayerCollider_Private_set_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666689);
			SceneManager.NativeMethodInfoPtr_get_CurrentActiveMap_Public_get_DaySceneMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666690);
			SceneManager.NativeMethodInfoPtr_set_CurrentActiveMap_Private_set_Void_DaySceneMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666691);
			SceneManager.NativeMethodInfoPtr_set_EnableMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666692);
			SceneManager.NativeMethodInfoPtr_get_IsMapSwapping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666693);
			SceneManager.NativeMethodInfoPtr_set_IsMapSwapping_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666694);
			SceneManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666695);
			SceneManager.NativeMethodInfoPtr_OnFirstEnterDaySceneFinish_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666696);
			SceneManager.NativeMethodInfoPtr_RefreshCurrentMapNPCs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666697);
			SceneManager.NativeMethodInfoPtr_Chat_Public_Void_String_Boolean_Action_1_Action_Action_Boolean_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666698);
			SceneManager.NativeMethodInfoPtr_NormalChat_Private_Void_NPC_Action_Boolean_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666699);
			SceneManager.NativeMethodInfoPtr_SpecialChat_Private_Void_NPC_Boolean_Action_1_Action_Action_Boolean_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666700);
			SceneManager.NativeMethodInfoPtr_TryOpenRelatedData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666701);
			SceneManager.NativeMethodInfoPtr_ExecuteScheduled_Public_Void_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666702);
			SceneManager.NativeMethodInfoPtr_ExecuteScheduledActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666703);
			SceneManager.NativeMethodInfoPtr_OnDayOver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666704);
			SceneManager.NativeMethodInfoPtr_InvokeDayOverEvents_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666705);
			SceneManager.NativeMethodInfoPtr_InvokeDayOverEventsAsync_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666706);
			SceneManager.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666707);
			SceneManager.NativeMethodInfoPtr_SwapMap_Public_Void_String_String_Int32_Boolean_Boolean_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666708);
			SceneManager.NativeMethodInfoPtr_SwapMapAsync_Public_UniTask_String_String_Int32_Boolean_Boolean_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666709);
			SceneManager.NativeMethodInfoPtr_get_RoguelikeDataProfileAsset_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666710);
			SceneManager.NativeMethodInfoPtr_get_RoguelikeDataUnchangeableProfileAsset_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666711);
			SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666712);
			SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666713);
			SceneManager.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666714);
			SceneManager.NativeMethodInfoPtr_Method_Private_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666715);
			SceneManager.NativeMethodInfoPtr_Method_Private_Void_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666716);
			SceneManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666717);
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x000E064C File Offset: 0x000DE84C
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x000E068C File Offset: 0x000DE88C
		public unsafe DayScenePlayerInputGenerator Character
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_Character_Public_get_DayScenePlayerInputGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DayScenePlayerInputGenerator>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43501, RefRangeEnd = 43502, XrefRangeStart = 43501, XrefRangeEnd = 43502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_Character_Private_set_Void_DayScenePlayerInputGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x000E06D0 File Offset: 0x000DE8D0
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x000E0708 File Offset: 0x000DE908
		public unsafe string CurrentActiveMapLabel
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 54348, RefRangeEnd = 54388, XrefRangeStart = 54348, XrefRangeEnd = 54348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_CurrentActiveMapLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_CurrentActiveMapLabel_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x000E074C File Offset: 0x000DE94C
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x000E0784 File Offset: 0x000DE984
		public unsafe string TargetMapLabel
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_TargetMapLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54388, XrefRangeEnd = 54389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_TargetMapLabel_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x000E07C8 File Offset: 0x000DE9C8
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x000E0808 File Offset: 0x000DEA08
		public unsafe Collider2D PlayerCollider
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54389, RefRangeEnd = 54396, XrefRangeStart = 54389, XrefRangeEnd = 54389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_PlayerCollider_Public_get_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54396, XrefRangeEnd = 54397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_PlayerCollider_Private_set_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x000E084C File Offset: 0x000DEA4C
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x000E088C File Offset: 0x000DEA8C
		public unsafe DaySceneMap CurrentActiveMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_CurrentActiveMap_Public_get_DaySceneMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DaySceneMap>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54397, XrefRangeEnd = 54398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_CurrentActiveMap_Private_set_Void_DaySceneMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000644 RID: 1604
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x000E08D0 File Offset: 0x000DEAD0
		public unsafe bool EnableMap
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 54404, RefRangeEnd = 54406, XrefRangeStart = 54398, XrefRangeEnd = 54404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_EnableMap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x000E0910 File Offset: 0x000DEB10
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x000E094C File Offset: 0x000DEB4C
		public unsafe bool IsMapSwapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_IsMapSwapping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_IsMapSwapping_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x000E098C File Offset: 0x000DEB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54406, XrefRangeEnd = 54490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x000E09C8 File Offset: 0x000DEBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54490, XrefRangeEnd = 54519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFirstEnterDaySceneFinish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_OnFirstEnterDaySceneFinish_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x000E09FC File Offset: 0x000DEBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54519, XrefRangeEnd = 54521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCurrentMapNPCs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_RefreshCurrentMapNPCs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x000E0A30 File Offset: 0x000DEC30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 54525, RefRangeEnd = 54530, XrefRangeStart = 54521, XrefRangeEnd = 54525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Chat(string characterLabel, bool isPostChat, Action<Action> onWillExecuteDayEndEventCallback = null, Action onChatFinished = null, bool shouldTriggerEvent = true, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.PreserveVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPostChat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onWillExecuteDayEndEventCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onChatFinished);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTriggerEvent;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Chat_Public_Void_String_Boolean_Action_1_Action_Action_Boolean_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x000E0AC4 File Offset: 0x000DECC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54628, RefRangeEnd = 54629, XrefRangeStart = 54530, XrefRangeEnd = 54628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NormalChat(NPC npcData, Action onChatFinished = null, bool shouldTriggerEvent = true, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.PreserveVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(npcData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onChatFinished);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTriggerEvent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_NormalChat_Private_Void_NPC_Action_Boolean_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x000E0B3C File Offset: 0x000DED3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54673, RefRangeEnd = 54674, XrefRangeStart = 54629, XrefRangeEnd = 54673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpecialChat(NPC npcData, bool isPostChat, Action<Action> onWillExecuteDayEndEventCallback, Action onChatFinished = null, bool shouldTriggerEvent = true, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.PreserveVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(npcData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPostChat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onWillExecuteDayEndEventCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onChatFinished);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTriggerEvent;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_SpecialChat_Private_Void_NPC_Boolean_Action_1_Action_Action_Boolean_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x000E0BD4 File Offset: 0x000DEDD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 54696, RefRangeEnd = 54699, XrefRangeStart = 54674, XrefRangeEnd = 54696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryOpenRelatedData(string characterLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_TryOpenRelatedData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x000E0C18 File Offset: 0x000DEE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54699, XrefRangeEnd = 54703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteScheduled(Func<IEnumerator> targetAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_ExecuteScheduled_Public_Void_Func_1_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x000E0C5C File Offset: 0x000DEE5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 54709, RefRangeEnd = 54712, XrefRangeStart = 54703, XrefRangeEnd = 54709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteScheduledActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_ExecuteScheduledActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x000E0C90 File Offset: 0x000DEE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54712, XrefRangeEnd = 54728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDayOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_OnDayOver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x000E0CC4 File Offset: 0x000DEEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54728, XrefRangeEnd = 54741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InvokeDayOverEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_InvokeDayOverEvents_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x000E0D04 File Offset: 0x000DEF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54741, XrefRangeEnd = 54747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask InvokeDayOverEventsAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_InvokeDayOverEventsAsync_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x000E0D3C File Offset: 0x000DEF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54747, XrefRangeEnd = 54805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x000E0D70 File Offset: 0x000DEF70
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 54826, RefRangeEnd = 54836, XrefRangeStart = 54805, XrefRangeEnd = 54826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapMap(string targetMapLabel, string targetMarkerName, int travelCount, bool shouldFadeIn = true, bool shouldFadeOut = true, bool triggerEnterMapEvent = true, Action onSwapFinish = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(targetMapLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetMarkerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref travelCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldFadeIn;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldFadeOut;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggerEnterMapEvent;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSwapFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_SwapMap_Public_Void_String_String_Int32_Boolean_Boolean_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x000E0E10 File Offset: 0x000DF010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54845, RefRangeEnd = 54846, XrefRangeStart = 54836, XrefRangeEnd = 54845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask SwapMapAsync(string targetMapLabel, string targetMarkerName, int travelCount, bool shouldFadeIn, bool shouldFadeOut, bool triggerEnterMapEvent, Action onSwapFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(targetMapLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetMarkerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref travelCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldFadeIn;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldFadeOut;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggerEnterMapEvent;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSwapFinish);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_SwapMapAsync_Public_UniTask_String_String_Int32_Boolean_Boolean_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x000E0EB8 File Offset: 0x000DF0B8
		public unsafe AssetReference RoguelikeDataProfileAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_RoguelikeDataProfileAsset_Public_get_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x000E0EF8 File Offset: 0x000DF0F8
		public unsafe AssetReference RoguelikeDataUnchangeableProfileAsset
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_RoguelikeDataUnchangeableProfileAsset_Public_get_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x000E0F38 File Offset: 0x000DF138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54853, XrefRangeEnd = 54875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x000E0F74 File Offset: 0x000DF174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54875, XrefRangeEnd = 54893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x000E0FB0 File Offset: 0x000DF1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54893, XrefRangeEnd = 54915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x000E0FE4 File Offset: 0x000DF1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54915, XrefRangeEnd = 54926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Method_Private_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x000E1018 File Offset: 0x000DF218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54926, XrefRangeEnd = 54945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Method_Private_Void_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x000E104C File Offset: 0x000DF24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54945, XrefRangeEnd = 54950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0000C4DD File Offset: 0x0000A6DD
		public SceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x000E108C File Offset: 0x000DF28C
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x0000C4E6 File Offset: 0x0000A6E6
		public unsafe static int TRAVEL_ACTION_COST
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_TRAVEL_ACTION_COST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_TRAVEL_ACTION_COST, (void*)(&value));
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x000E10A8 File Offset: 0x000DF2A8
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		public unsafe static string KOURINDO_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_KOURINDO_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_KOURINDO_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x000E10C8 File Offset: 0x000DF2C8
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x0000C506 File Offset: 0x0000A706
		public unsafe static Action<Action> onDaySceneReady
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_onDaySceneReady, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_onDaySceneReady, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x000E10F0 File Offset: 0x000DF2F0
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x0000C518 File Offset: 0x0000A718
		public unsafe string defaultMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_defaultMap);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_defaultMap), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x000E1118 File Offset: 0x000DF318
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x0000C537 File Offset: 0x0000A737
		public unsafe CinemachineVirtualCamera virtualCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_virtualCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CinemachineVirtualCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_virtualCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x000E1148 File Offset: 0x000DF348
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x0000C556 File Offset: 0x0000A756
		public unsafe DialogPackage onDayOverDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_onDayOverDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_onDayOverDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000E1178 File Offset: 0x000DF378
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x0000C575 File Offset: 0x0000A775
		public unsafe Transform characterTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_characterTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_characterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x000E11A8 File Offset: 0x000DF3A8
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x0000C594 File Offset: 0x0000A794
		public unsafe RectTransform ActivePannelRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_ActivePannelRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_ActivePannelRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x000E11D8 File Offset: 0x000DF3D8
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x0000C5B3 File Offset: 0x0000A7B3
		public unsafe Queue<AssetReference> releaseQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_releaseQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<AssetReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_releaseQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x000E1208 File Offset: 0x000DF408
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0000C5D2 File Offset: 0x0000A7D2
		public unsafe Queue<Func<IEnumerator>> scheduledActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_scheduledActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Func<IEnumerator>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_scheduledActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x000E1238 File Offset: 0x000DF438
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0000C5F1 File Offset: 0x0000A7F1
		public unsafe bool isExecutingScheduledActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_isExecutingScheduledActions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_isExecutingScheduledActions)) = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x000E1260 File Offset: 0x000DF460
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0000C60C File Offset: 0x0000A80C
		public unsafe bool m_RequireLoadDependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_RequireLoadDependencies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_RequireLoadDependencies)) = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x000E1288 File Offset: 0x000DF488
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x0000C627 File Offset: 0x0000A827
		public unsafe DayScenePlayerInputGenerator _Character_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__Character_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DayScenePlayerInputGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__Character_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x000E12B8 File Offset: 0x000DF4B8
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0000C646 File Offset: 0x0000A846
		public unsafe string _CurrentActiveMapLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__CurrentActiveMapLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__CurrentActiveMapLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x000E12E0 File Offset: 0x000DF4E0
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x0000C665 File Offset: 0x0000A865
		public unsafe string _TargetMapLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__TargetMapLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__TargetMapLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x000E1308 File Offset: 0x000DF508
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x0000C684 File Offset: 0x0000A884
		public unsafe Collider2D _PlayerCollider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__PlayerCollider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__PlayerCollider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x000E1338 File Offset: 0x000DF538
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x0000C6A3 File Offset: 0x0000A8A3
		public unsafe DaySceneMap _CurrentActiveMap_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__CurrentActiveMap_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__CurrentActiveMap_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x000E1368 File Offset: 0x000DF568
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0000C6C2 File Offset: 0x0000A8C2
		public unsafe bool m_HasTriggerOnEnterDaySceneEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_HasTriggerOnEnterDaySceneEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_HasTriggerOnEnterDaySceneEvent)) = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x000E1390 File Offset: 0x000DF590
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x0000C6DD File Offset: 0x0000A8DD
		public unsafe bool _IsMapSwapping_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__IsMapSwapping_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__IsMapSwapping_k__BackingField)) = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x000E13B8 File Offset: 0x000DF5B8
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x0000C6F8 File Offset: 0x0000A8F8
		public unsafe AssetReference roguelikeDataProfileAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_roguelikeDataProfileAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_roguelikeDataProfileAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x000E13E8 File Offset: 0x000DF5E8
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x0000C717 File Offset: 0x0000A917
		public unsafe AssetReference roguelikeDataUnchangeableProfileAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_roguelikeDataUnchangeableProfileAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_roguelikeDataUnchangeableProfileAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x000E1418 File Offset: 0x000DF618
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x0000C736 File Offset: 0x0000A936
		public unsafe int m_MasterId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_MasterId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_MasterId)) = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x000E1440 File Offset: 0x000DF640
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x0000C751 File Offset: 0x0000A951
		public unsafe Vector2Int m_DisappearDayRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_DisappearDayRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_DisappearDayRange)) = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x000E1468 File Offset: 0x000DF668
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x0000C76C File Offset: 0x0000A96C
		public unsafe string m_DisappearNewsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_DisappearNewsLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_DisappearNewsLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x000E1490 File Offset: 0x000DF690
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x0000C78B File Offset: 0x0000A98B
		public unsafe string m_AppearNewsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_AppearNewsLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_AppearNewsLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x000E14B8 File Offset: 0x000DF6B8
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x0000C7AA File Offset: 0x0000A9AA
		public unsafe Il2CppStringArray m_DisappearReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_DisappearReason);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_DisappearReason), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x000E14E8 File Offset: 0x000DF6E8
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x0000C7C9 File Offset: 0x0000A9C9
		public unsafe Il2CppStringArray m_MapExclusions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_MapExclusions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_MapExclusions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeFieldInfoPtr_TRAVEL_ACTION_COST;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeFieldInfoPtr_KOURINDO_KEY;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeFieldInfoPtr_onDaySceneReady;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeFieldInfoPtr_defaultMap;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeFieldInfoPtr_virtualCamera;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeFieldInfoPtr_onDayOverDialog;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeFieldInfoPtr_characterTransform;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeFieldInfoPtr_ActivePannelRoot;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeFieldInfoPtr_releaseQueue;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeFieldInfoPtr_scheduledActions;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeFieldInfoPtr_isExecutingScheduledActions;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeFieldInfoPtr_m_RequireLoadDependencies;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeFieldInfoPtr__Character_k__BackingField;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeFieldInfoPtr__CurrentActiveMapLabel_k__BackingField;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeFieldInfoPtr__TargetMapLabel_k__BackingField;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeFieldInfoPtr__PlayerCollider_k__BackingField;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeFieldInfoPtr__CurrentActiveMap_k__BackingField;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeFieldInfoPtr_m_HasTriggerOnEnterDaySceneEvent;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeFieldInfoPtr__IsMapSwapping_k__BackingField;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeFieldInfoPtr_roguelikeDataProfileAsset;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeFieldInfoPtr_roguelikeDataUnchangeableProfileAsset;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeFieldInfoPtr_m_MasterId;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeFieldInfoPtr_m_DisappearDayRange;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeFieldInfoPtr_m_DisappearNewsLabel;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeFieldInfoPtr_m_AppearNewsLabel;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeFieldInfoPtr_m_DisappearReason;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeFieldInfoPtr_m_MapExclusions;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_get_Character_Public_get_DayScenePlayerInputGenerator_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_set_Character_Private_set_Void_DayScenePlayerInputGenerator_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentActiveMapLabel_Public_get_String_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentActiveMapLabel_Private_set_Void_String_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetMapLabel_Public_get_String_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetMapLabel_Private_set_Void_String_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCollider_Public_get_Collider2D_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerCollider_Private_set_Void_Collider2D_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentActiveMap_Public_get_DaySceneMap_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentActiveMap_Private_set_Void_DaySceneMap_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableMap_Public_set_Void_Boolean_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMapSwapping_Public_get_Boolean_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMapSwapping_Private_set_Void_Boolean_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_OnFirstEnterDaySceneFinish_Private_Void_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCurrentMapNPCs_Private_Void_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_Chat_Public_Void_String_Boolean_Action_1_Action_Action_Boolean_PanelVisualMode_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_NormalChat_Private_Void_NPC_Action_Boolean_PanelVisualMode_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_SpecialChat_Private_Void_NPC_Boolean_Action_1_Action_Action_Boolean_PanelVisualMode_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_TryOpenRelatedData_Public_Void_String_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteScheduled_Public_Void_Func_1_IEnumerator_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteScheduledActions_Private_Void_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_OnDayOver_Private_Void_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDayOverEvents_Private_IEnumerator_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDayOverEventsAsync_Private_UniTask_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_SwapMap_Public_Void_String_String_Int32_Boolean_Boolean_Boolean_Action_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_SwapMapAsync_Public_UniTask_String_String_Int32_Boolean_Boolean_Boolean_Action_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_get_RoguelikeDataProfileAsset_Public_get_AssetReference_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_get_RoguelikeDataUnchangeableProfileAsset_Public_get_AssetReference_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_1;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_2;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020005D3 RID: 1491
		[ObfuscatedName("DayScene.SceneManager+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x06008D8F RID: 36239 RVA: 0x0026C7DC File Offset: 0x0026A9DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_onChatFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, "onChatFinished");
				SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, "previousPanelVisualMode");
				SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
				SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, "characterLabel");
				SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_merchant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, "merchant");
				SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, 100666718);
				SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, 100666719);
				SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr__NormalChat_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, 100666720);
				SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, 100666721);
				SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr__NormalChat_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, 100666722);
				SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr__NormalChat_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr, 100666723);
			}

			// Token: 0x06008D90 RID: 36240 RVA: 0x0026C8E4 File Offset: 0x0026AAE4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D91 RID: 36241 RVA: 0x0026C920 File Offset: 0x0026AB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53825, XrefRangeEnd = 53855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.NormalNPCInteractData normalNPCInteractData, out string title, out bool availability, out Action onInteract)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalNPCInteractData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x06008D92 RID: 36242 RVA: 0x0026C9B0 File Offset: 0x0026ABB0
			[CallerCount(0)]
			public unsafe void _NormalChat_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr__NormalChat_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D93 RID: 36243 RVA: 0x0026C9E4 File Offset: 0x0026ABE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53855, XrefRangeEnd = 53872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_1(DaySceneChatSelectionPannel.NormalNPCInteractData normalNPCInteractData, out string title, out bool availability, out Action onInteract)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalNPCInteractData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x06008D94 RID: 36244 RVA: 0x0026CA74 File Offset: 0x0026AC74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53872, XrefRangeEnd = 53877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NormalChat_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr__NormalChat_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D95 RID: 36245 RVA: 0x0026CAA8 File Offset: 0x0026ACA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53877, XrefRangeEnd = 53878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NormalChat_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_0.NativeMethodInfoPtr__NormalChat_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D96 RID: 36246 RVA: 0x0004C23C File Offset: 0x0004A43C
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F52 RID: 12114
			// (get) Token: 0x06008D97 RID: 36247 RVA: 0x0026CADC File Offset: 0x0026ACDC
			// (set) Token: 0x06008D98 RID: 36248 RVA: 0x0004C245 File Offset: 0x0004A445
			public unsafe Action onChatFinished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_onChatFinished);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_onChatFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F53 RID: 12115
			// (get) Token: 0x06008D99 RID: 36249 RVA: 0x0026CB0C File Offset: 0x0026AD0C
			// (set) Token: 0x06008D9A RID: 36250 RVA: 0x0004C264 File Offset: 0x0004A464
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x17002F54 RID: 12116
			// (get) Token: 0x06008D9B RID: 36251 RVA: 0x0026CB34 File Offset: 0x0026AD34
			// (set) Token: 0x06008D9C RID: 36252 RVA: 0x0004C27F File Offset: 0x0004A47F
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F55 RID: 12117
			// (get) Token: 0x06008D9D RID: 36253 RVA: 0x0026CB64 File Offset: 0x0026AD64
			// (set) Token: 0x06008D9E RID: 36254 RVA: 0x0004C29E File Offset: 0x0004A49E
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002F56 RID: 12118
			// (get) Token: 0x06008D9F RID: 36255 RVA: 0x0026CB8C File Offset: 0x0026AD8C
			// (set) Token: 0x06008DA0 RID: 36256 RVA: 0x0004C2BD File Offset: 0x0004A4BD
			public unsafe TrackedMerchant merchant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_merchant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_0.NativeFieldInfoPtr_merchant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C7C RID: 23676
			private static readonly IntPtr NativeFieldInfoPtr_onChatFinished;

			// Token: 0x04005C7D RID: 23677
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x04005C7E RID: 23678
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005C7F RID: 23679
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005C80 RID: 23680
			private static readonly IntPtr NativeFieldInfoPtr_merchant;

			// Token: 0x04005C81 RID: 23681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C82 RID: 23682
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;

			// Token: 0x04005C83 RID: 23683
			private static readonly IntPtr NativeMethodInfoPtr__NormalChat_b__5_Internal_Void_0;

			// Token: 0x04005C84 RID: 23684
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_NormalNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_1;

			// Token: 0x04005C85 RID: 23685
			private static readonly IntPtr NativeMethodInfoPtr__NormalChat_b__8_Internal_Void_0;

			// Token: 0x04005C86 RID: 23686
			private static readonly IntPtr NativeMethodInfoPtr__NormalChat_b__0_Internal_Void_0;
		}

		// Token: 0x020005D4 RID: 1492
		[ObfuscatedName("DayScene.SceneManager+<>c__DisplayClass43_1")]
		public sealed class __c__DisplayClass43_1 : Il2CppSystem.Object
		{
			// Token: 0x06008DA1 RID: 36257 RVA: 0x0026CBBC File Offset: 0x0026ADBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_1()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass43_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr);
				SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr_normalNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr, "normalNPCInteractData");
				SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr_merchantDataBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr, "merchantDataBase");
				SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr_field_Public___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr, "CS$<>8__locals1");
				SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr, "<>9__6");
				SceneManager.__c__DisplayClass43_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr, 100666724);
				SceneManager.__c__DisplayClass43_1.NativeMethodInfoPtr__NormalChat_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr, 100666725);
				SceneManager.__c__DisplayClass43_1.NativeMethodInfoPtr__NormalChat_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr, 100666726);
				SceneManager.__c__DisplayClass43_1.NativeMethodInfoPtr__NormalChat_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr, 100666727);
			}

			// Token: 0x06008DA2 RID: 36258 RVA: 0x0026CC88 File Offset: 0x0026AE88
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DA3 RID: 36259 RVA: 0x0026CCC4 File Offset: 0x0026AEC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53878, XrefRangeEnd = 53892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NormalChat_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_1.NativeMethodInfoPtr__NormalChat_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DA4 RID: 36260 RVA: 0x0026CCF8 File Offset: 0x0026AEF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53892, XrefRangeEnd = 53897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NormalChat_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_1.NativeMethodInfoPtr__NormalChat_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DA5 RID: 36261 RVA: 0x0026CD2C File Offset: 0x0026AF2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53897, XrefRangeEnd = 53904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NormalChat_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_1.NativeMethodInfoPtr__NormalChat_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DA6 RID: 36262 RVA: 0x0004C2DC File Offset: 0x0004A4DC
			public __c__DisplayClass43_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F57 RID: 12119
			// (get) Token: 0x06008DA7 RID: 36263 RVA: 0x0026CD60 File Offset: 0x0026AF60
			// (set) Token: 0x06008DA8 RID: 36264 RVA: 0x0004C2E5 File Offset: 0x0004A4E5
			public unsafe DaySceneChatSelectionPannel.NormalNPCInteractData normalNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr_normalNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.NormalNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr_normalNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F58 RID: 12120
			// (get) Token: 0x06008DA9 RID: 36265 RVA: 0x0026CD90 File Offset: 0x0026AF90
			// (set) Token: 0x06008DAA RID: 36266 RVA: 0x0004C304 File Offset: 0x0004A504
			public Merchant merchantDataBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr_merchantDataBase);
					return new Merchant(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Merchant>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr_merchantDataBase), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Merchant>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F59 RID: 12121
			// (get) Token: 0x06008DAB RID: 36267 RVA: 0x0026CDC0 File Offset: 0x0026AFC0
			// (set) Token: 0x06008DAC RID: 36268 RVA: 0x0004C332 File Offset: 0x0004A532
			public unsafe SceneManager.__c__DisplayClass43_0 field_Public___c__DisplayClass43_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr_field_Public___c__DisplayClass43_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c__DisplayClass43_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr_field_Public___c__DisplayClass43_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F5A RID: 12122
			// (get) Token: 0x06008DAD RID: 36269 RVA: 0x0026CDF0 File Offset: 0x0026AFF0
			// (set) Token: 0x06008DAE RID: 36270 RVA: 0x0004C351 File Offset: 0x0004A551
			public unsafe Action __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_1.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C87 RID: 23687
			private static readonly IntPtr NativeFieldInfoPtr_normalNPCInteractData;

			// Token: 0x04005C88 RID: 23688
			private static readonly IntPtr NativeFieldInfoPtr_merchantDataBase;

			// Token: 0x04005C89 RID: 23689
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass43_0_0;

			// Token: 0x04005C8A RID: 23690
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x04005C8B RID: 23691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C8C RID: 23692
			private static readonly IntPtr NativeMethodInfoPtr__NormalChat_b__3_Internal_Void_0;

			// Token: 0x04005C8D RID: 23693
			private static readonly IntPtr NativeMethodInfoPtr__NormalChat_b__6_Internal_Void_0;

			// Token: 0x04005C8E RID: 23694
			private static readonly IntPtr NativeMethodInfoPtr__NormalChat_b__4_Internal_Void_0;
		}

		// Token: 0x020005D5 RID: 1493
		[ObfuscatedName("DayScene.SceneManager+<>c__DisplayClass43_2")]
		public sealed class __c__DisplayClass43_2 : Il2CppSystem.Object
		{
			// Token: 0x06008DAF RID: 36271 RVA: 0x0026CE20 File Offset: 0x0026B020
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_2()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass43_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_2>.NativeClassPtr);
				SceneManager.__c__DisplayClass43_2.NativeFieldInfoPtr_normalNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_2>.NativeClassPtr, "normalNPCInteractData");
				SceneManager.__c__DisplayClass43_2.NativeFieldInfoPtr_field_Public___c__DisplayClass43_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_2>.NativeClassPtr, "CS$<>8__locals2");
				SceneManager.__c__DisplayClass43_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_2>.NativeClassPtr, 100666728);
				SceneManager.__c__DisplayClass43_2.NativeMethodInfoPtr__NormalChat_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_2>.NativeClassPtr, 100666729);
			}

			// Token: 0x06008DB0 RID: 36272 RVA: 0x0026CE9C File Offset: 0x0026B09C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass43_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DB1 RID: 36273 RVA: 0x0026CED8 File Offset: 0x0026B0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53904, XrefRangeEnd = 53906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NormalChat_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass43_2.NativeMethodInfoPtr__NormalChat_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DB2 RID: 36274 RVA: 0x0004C370 File Offset: 0x0004A570
			public __c__DisplayClass43_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F5B RID: 12123
			// (get) Token: 0x06008DB3 RID: 36275 RVA: 0x0026CF0C File Offset: 0x0026B10C
			// (set) Token: 0x06008DB4 RID: 36276 RVA: 0x0004C379 File Offset: 0x0004A579
			public unsafe DaySceneChatSelectionPannel.NormalNPCInteractData normalNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_2.NativeFieldInfoPtr_normalNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.NormalNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_2.NativeFieldInfoPtr_normalNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F5C RID: 12124
			// (get) Token: 0x06008DB5 RID: 36277 RVA: 0x0026CF3C File Offset: 0x0026B13C
			// (set) Token: 0x06008DB6 RID: 36278 RVA: 0x0004C398 File Offset: 0x0004A598
			public unsafe SceneManager.__c__DisplayClass43_0 field_Public___c__DisplayClass43_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_2.NativeFieldInfoPtr_field_Public___c__DisplayClass43_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c__DisplayClass43_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass43_2.NativeFieldInfoPtr_field_Public___c__DisplayClass43_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C8F RID: 23695
			private static readonly IntPtr NativeFieldInfoPtr_normalNPCInteractData;

			// Token: 0x04005C90 RID: 23696
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass43_0_0;

			// Token: 0x04005C91 RID: 23697
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C92 RID: 23698
			private static readonly IntPtr NativeMethodInfoPtr__NormalChat_b__7_Internal_Void_0;
		}

		// Token: 0x020005D6 RID: 1494
		[ObfuscatedName("DayScene.SceneManager+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x06008DB7 RID: 36279 RVA: 0x0026CF6C File Offset: 0x0026B16C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass44_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass44_0>.NativeClassPtr, "characterLabel");
				SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_onChatFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass44_0>.NativeClassPtr, "onChatFinished");
				SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass44_0>.NativeClassPtr, "onWillExecuteDayEndEventCallback");
				SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_shouldTriggerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass44_0>.NativeClassPtr, "shouldTriggerEvent");
				SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass44_0>.NativeClassPtr, "previousPanelVisualMode");
				SceneManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass44_0>.NativeClassPtr, 100666730);
				SceneManager.__c__DisplayClass44_0.NativeMethodInfoPtr__SpecialChat_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass44_0>.NativeClassPtr, 100666731);
			}

			// Token: 0x06008DB8 RID: 36280 RVA: 0x0026D024 File Offset: 0x0026B224
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DB9 RID: 36281 RVA: 0x0026D060 File Offset: 0x0026B260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53906, XrefRangeEnd = 53910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SpecialChat_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass44_0.NativeMethodInfoPtr__SpecialChat_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DBA RID: 36282 RVA: 0x0004C3B7 File Offset: 0x0004A5B7
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F5D RID: 12125
			// (get) Token: 0x06008DBB RID: 36283 RVA: 0x0026D094 File Offset: 0x0026B294
			// (set) Token: 0x06008DBC RID: 36284 RVA: 0x0004C3C0 File Offset: 0x0004A5C0
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002F5E RID: 12126
			// (get) Token: 0x06008DBD RID: 36285 RVA: 0x0026D0BC File Offset: 0x0026B2BC
			// (set) Token: 0x06008DBE RID: 36286 RVA: 0x0004C3DF File Offset: 0x0004A5DF
			public unsafe Action onChatFinished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_onChatFinished);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_onChatFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F5F RID: 12127
			// (get) Token: 0x06008DBF RID: 36287 RVA: 0x0026D0EC File Offset: 0x0026B2EC
			// (set) Token: 0x06008DC0 RID: 36288 RVA: 0x0004C3FE File Offset: 0x0004A5FE
			public unsafe Action<Action> onWillExecuteDayEndEventCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F60 RID: 12128
			// (get) Token: 0x06008DC1 RID: 36289 RVA: 0x0026D11C File Offset: 0x0026B31C
			// (set) Token: 0x06008DC2 RID: 36290 RVA: 0x0004C41D File Offset: 0x0004A61D
			public unsafe bool shouldTriggerEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_shouldTriggerEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_shouldTriggerEvent)) = value;
				}
			}

			// Token: 0x17002F61 RID: 12129
			// (get) Token: 0x06008DC3 RID: 36291 RVA: 0x0026D144 File Offset: 0x0026B344
			// (set) Token: 0x06008DC4 RID: 36292 RVA: 0x0004C438 File Offset: 0x0004A638
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass44_0.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x04005C93 RID: 23699
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005C94 RID: 23700
			private static readonly IntPtr NativeFieldInfoPtr_onChatFinished;

			// Token: 0x04005C95 RID: 23701
			private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteDayEndEventCallback;

			// Token: 0x04005C96 RID: 23702
			private static readonly IntPtr NativeFieldInfoPtr_shouldTriggerEvent;

			// Token: 0x04005C97 RID: 23703
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x04005C98 RID: 23704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C99 RID: 23705
			private static readonly IntPtr NativeMethodInfoPtr__SpecialChat_b__0_Internal_Void_0;
		}

		// Token: 0x020005D7 RID: 1495
		[ObfuscatedName("DayScene.SceneManager+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
		{
			// Token: 0x06008DC5 RID: 36293 RVA: 0x0026D16C File Offset: 0x0026B36C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass45_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass45_0.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass45_0>.NativeClassPtr, "characterLabel");
				SceneManager.__c__DisplayClass45_0.NativeFieldInfoPtr_selectedMissionRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass45_0>.NativeClassPtr, "selectedMissionRunTimeData");
				SceneManager.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass45_0>.NativeClassPtr, 100666732);
				SceneManager.__c__DisplayClass45_0.NativeMethodInfoPtr_Method_Internal_Void_UISubPanel_1_NoteBookMainPannel_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass45_0>.NativeClassPtr, 100666733);
			}

			// Token: 0x06008DC6 RID: 36294 RVA: 0x0026D1E8 File Offset: 0x0026B3E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DC7 RID: 36295 RVA: 0x0026D224 File Offset: 0x0026B424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53910, XrefRangeEnd = 53916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UISubPanel_1_NoteBookMainPannel_PDM_0(UISubPanel<NoteBookMainPannel> pannel)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pannel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass45_0.NativeMethodInfoPtr_Method_Internal_Void_UISubPanel_1_NoteBookMainPannel_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DC8 RID: 36296 RVA: 0x0004C453 File Offset: 0x0004A653
			public __c__DisplayClass45_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F62 RID: 12130
			// (get) Token: 0x06008DC9 RID: 36297 RVA: 0x0026D268 File Offset: 0x0026B468
			// (set) Token: 0x06008DCA RID: 36298 RVA: 0x0004C45C File Offset: 0x0004A65C
			public unsafe string characterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass45_0.NativeFieldInfoPtr_characterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass45_0.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002F63 RID: 12131
			// (get) Token: 0x06008DCB RID: 36299 RVA: 0x0026D290 File Offset: 0x0026B490
			// (set) Token: 0x06008DCC RID: 36300 RVA: 0x0004C47B File Offset: 0x0004A67B
			public unsafe RunTimeScheduler.TrackedMissionData selectedMissionRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass45_0.NativeFieldInfoPtr_selectedMissionRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeScheduler.TrackedMissionData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass45_0.NativeFieldInfoPtr_selectedMissionRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C9A RID: 23706
			private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

			// Token: 0x04005C9B RID: 23707
			private static readonly IntPtr NativeFieldInfoPtr_selectedMissionRunTimeData;

			// Token: 0x04005C9C RID: 23708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C9D RID: 23709
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UISubPanel_1_NoteBookMainPannel_PDM_0;
		}

		// Token: 0x020005D8 RID: 1496
		[ObfuscatedName("DayScene.SceneManager+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x06008DCD RID: 36301 RVA: 0x0026D2C0 File Offset: 0x0026B4C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass50_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass50_0.NativeFieldInfoPtr_selectedIzakayaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass50_0>.NativeClassPtr, "selectedIzakayaIndex");
				SceneManager.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass50_0>.NativeClassPtr, 100666734);
				SceneManager.__c__DisplayClass50_0.NativeMethodInfoPtr__InvokeDayOverEventsAsync_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass50_0>.NativeClassPtr, 100666735);
			}

			// Token: 0x06008DCE RID: 36302 RVA: 0x0026D328 File Offset: 0x0026B528
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DCF RID: 36303 RVA: 0x0026D364 File Offset: 0x0026B564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53916, XrefRangeEnd = 53926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InvokeDayOverEventsAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass50_0.NativeMethodInfoPtr__InvokeDayOverEventsAsync_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DD0 RID: 36304 RVA: 0x0004C49A File Offset: 0x0004A69A
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F64 RID: 12132
			// (get) Token: 0x06008DD1 RID: 36305 RVA: 0x0026D398 File Offset: 0x0026B598
			// (set) Token: 0x06008DD2 RID: 36306 RVA: 0x0004C4A3 File Offset: 0x0004A6A3
			public unsafe int selectedIzakayaIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass50_0.NativeFieldInfoPtr_selectedIzakayaIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass50_0.NativeFieldInfoPtr_selectedIzakayaIndex)) = value;
				}
			}

			// Token: 0x04005C9E RID: 23710
			private static readonly IntPtr NativeFieldInfoPtr_selectedIzakayaIndex;

			// Token: 0x04005C9F RID: 23711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CA0 RID: 23712
			private static readonly IntPtr NativeMethodInfoPtr__InvokeDayOverEventsAsync_b__0_Internal_Void_0;
		}

		// Token: 0x020005D9 RID: 1497
		[ObfuscatedName("DayScene.SceneManager+<InvokeDayOverEventsAsync>d__50")]
		public sealed class _InvokeDayOverEventsAsync_d__50 : ValueType
		{
			// Token: 0x06008DD3 RID: 36307 RVA: 0x0026D3C0 File Offset: 0x0026B5C0
			// Note: this type is marked as 'beforefieldinit'.
			static _InvokeDayOverEventsAsync_d__50()
			{
				Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<InvokeDayOverEventsAsync>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr);
				SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr, "<>1__state");
				SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr, "<>t__builder");
				SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr, "<>4__this");
				SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr, "<>8__1");
				SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr, "<>u__1");
				SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr, "<>u__2");
				SceneManager._InvokeDayOverEventsAsync_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr, 100666736);
				SceneManager._InvokeDayOverEventsAsync_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr, 100666737);
			}

			// Token: 0x06008DD4 RID: 36308 RVA: 0x0026D48C File Offset: 0x0026B68C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 54081, RefRangeEnd = 54084, XrefRangeStart = 53926, XrefRangeEnd = 54081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._InvokeDayOverEventsAsync_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DD5 RID: 36309 RVA: 0x0026D4C4 File Offset: 0x0026B6C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._InvokeDayOverEventsAsync_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DD6 RID: 36310 RVA: 0x0004C4BE File Offset: 0x0004A6BE
			public _InvokeDayOverEventsAsync_d__50(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008DD7 RID: 36311 RVA: 0x0004C4C7 File Offset: 0x0004A6C7
			public _InvokeDayOverEventsAsync_d__50() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._InvokeDayOverEventsAsync_d__50>.NativeClassPtr))
			{
			}

			// Token: 0x17002F65 RID: 12133
			// (get) Token: 0x06008DD8 RID: 36312 RVA: 0x0026D50C File Offset: 0x0026B70C
			// (set) Token: 0x06008DD9 RID: 36313 RVA: 0x0004C4D9 File Offset: 0x0004A6D9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002F66 RID: 12134
			// (get) Token: 0x06008DDA RID: 36314 RVA: 0x0026D534 File Offset: 0x0026B734
			// (set) Token: 0x06008DDB RID: 36315 RVA: 0x0004C4F4 File Offset: 0x0004A6F4
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F67 RID: 12135
			// (get) Token: 0x06008DDC RID: 36316 RVA: 0x0026D564 File Offset: 0x0026B764
			// (set) Token: 0x06008DDD RID: 36317 RVA: 0x0004C522 File Offset: 0x0004A722
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F68 RID: 12136
			// (get) Token: 0x06008DDE RID: 36318 RVA: 0x0026D594 File Offset: 0x0026B794
			// (set) Token: 0x06008DDF RID: 36319 RVA: 0x0004C541 File Offset: 0x0004A741
			public unsafe SceneManager.__c__DisplayClass50_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c__DisplayClass50_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F69 RID: 12137
			// (get) Token: 0x06008DE0 RID: 36320 RVA: 0x0026D5C4 File Offset: 0x0026B7C4
			// (set) Token: 0x06008DE1 RID: 36321 RVA: 0x0004C560 File Offset: 0x0004A760
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F6A RID: 12138
			// (get) Token: 0x06008DE2 RID: 36322 RVA: 0x0026D5F4 File Offset: 0x0026B7F4
			// (set) Token: 0x06008DE3 RID: 36323 RVA: 0x0004C58E File Offset: 0x0004A78E
			public UniTask<int>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___u__2);
					return new UniTask<int>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._InvokeDayOverEventsAsync_d__50.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005CA1 RID: 23713
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005CA2 RID: 23714
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005CA3 RID: 23715
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005CA4 RID: 23716
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005CA5 RID: 23717
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005CA6 RID: 23718
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005CA7 RID: 23719
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CA8 RID: 23720
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005DA RID: 1498
		[ObfuscatedName("DayScene.SceneManager+<SwapMapAsync>d__53")]
		public sealed class _SwapMapAsync_d__53 : ValueType
		{
			// Token: 0x06008DE4 RID: 36324 RVA: 0x0026D624 File Offset: 0x0026B824
			// Note: this type is marked as 'beforefieldinit'.
			static _SwapMapAsync_d__53()
			{
				Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<SwapMapAsync>d__53");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr);
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "<>1__state");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "<>t__builder");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "<>4__this");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_targetMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "targetMapLabel");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_shouldFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "shouldFadeIn");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_targetMarkerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "targetMarkerName");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_travelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "travelCount");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_onSwapFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "onSwapFinish");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_triggerEnterMapEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "triggerEnterMapEvent");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_shouldFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "shouldFadeOut");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr__reloadMap_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "<reloadMap>5__2");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr__startCanOpenNoteStorageEscape_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "<startCanOpenNoteStorageEscape>5__3");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "<>u__1");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr__lastMapReleaseHandle_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "<lastMapReleaseHandle>5__4");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "<>u__2");
				SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, "<>u__3");
				SceneManager._SwapMapAsync_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, 100666738);
				SceneManager._SwapMapAsync_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr, 100666739);
			}

			// Token: 0x06008DE5 RID: 36325 RVA: 0x0026D7B8 File Offset: 0x0026B9B8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 54334, RefRangeEnd = 54337, XrefRangeStart = 54084, XrefRangeEnd = 54334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._SwapMapAsync_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DE6 RID: 36326 RVA: 0x0026D7F0 File Offset: 0x0026B9F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._SwapMapAsync_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008DE7 RID: 36327 RVA: 0x0004C5BC File Offset: 0x0004A7BC
			public _SwapMapAsync_d__53(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008DE8 RID: 36328 RVA: 0x0004C5C5 File Offset: 0x0004A7C5
			public _SwapMapAsync_d__53() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._SwapMapAsync_d__53>.NativeClassPtr))
			{
			}

			// Token: 0x17002F6B RID: 12139
			// (get) Token: 0x06008DE9 RID: 36329 RVA: 0x0026D838 File Offset: 0x0026BA38
			// (set) Token: 0x06008DEA RID: 36330 RVA: 0x0004C5D7 File Offset: 0x0004A7D7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002F6C RID: 12140
			// (get) Token: 0x06008DEB RID: 36331 RVA: 0x0026D860 File Offset: 0x0026BA60
			// (set) Token: 0x06008DEC RID: 36332 RVA: 0x0004C5F2 File Offset: 0x0004A7F2
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F6D RID: 12141
			// (get) Token: 0x06008DED RID: 36333 RVA: 0x0026D890 File Offset: 0x0026BA90
			// (set) Token: 0x06008DEE RID: 36334 RVA: 0x0004C620 File Offset: 0x0004A820
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F6E RID: 12142
			// (get) Token: 0x06008DEF RID: 36335 RVA: 0x0026D8C0 File Offset: 0x0026BAC0
			// (set) Token: 0x06008DF0 RID: 36336 RVA: 0x0004C63F File Offset: 0x0004A83F
			public unsafe string targetMapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_targetMapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_targetMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002F6F RID: 12143
			// (get) Token: 0x06008DF1 RID: 36337 RVA: 0x0026D8E8 File Offset: 0x0026BAE8
			// (set) Token: 0x06008DF2 RID: 36338 RVA: 0x0004C65E File Offset: 0x0004A85E
			public unsafe bool shouldFadeIn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_shouldFadeIn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_shouldFadeIn)) = value;
				}
			}

			// Token: 0x17002F70 RID: 12144
			// (get) Token: 0x06008DF3 RID: 36339 RVA: 0x0026D910 File Offset: 0x0026BB10
			// (set) Token: 0x06008DF4 RID: 36340 RVA: 0x0004C679 File Offset: 0x0004A879
			public unsafe string targetMarkerName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_targetMarkerName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_targetMarkerName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002F71 RID: 12145
			// (get) Token: 0x06008DF5 RID: 36341 RVA: 0x0026D938 File Offset: 0x0026BB38
			// (set) Token: 0x06008DF6 RID: 36342 RVA: 0x0004C698 File Offset: 0x0004A898
			public unsafe int travelCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_travelCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_travelCount)) = value;
				}
			}

			// Token: 0x17002F72 RID: 12146
			// (get) Token: 0x06008DF7 RID: 36343 RVA: 0x0026D960 File Offset: 0x0026BB60
			// (set) Token: 0x06008DF8 RID: 36344 RVA: 0x0004C6B3 File Offset: 0x0004A8B3
			public unsafe Action onSwapFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_onSwapFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_onSwapFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F73 RID: 12147
			// (get) Token: 0x06008DF9 RID: 36345 RVA: 0x0026D990 File Offset: 0x0026BB90
			// (set) Token: 0x06008DFA RID: 36346 RVA: 0x0004C6D2 File Offset: 0x0004A8D2
			public unsafe bool triggerEnterMapEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_triggerEnterMapEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_triggerEnterMapEvent)) = value;
				}
			}

			// Token: 0x17002F74 RID: 12148
			// (get) Token: 0x06008DFB RID: 36347 RVA: 0x0026D9B8 File Offset: 0x0026BBB8
			// (set) Token: 0x06008DFC RID: 36348 RVA: 0x0004C6ED File Offset: 0x0004A8ED
			public unsafe bool shouldFadeOut
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_shouldFadeOut);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr_shouldFadeOut)) = value;
				}
			}

			// Token: 0x17002F75 RID: 12149
			// (get) Token: 0x06008DFD RID: 36349 RVA: 0x0026D9E0 File Offset: 0x0026BBE0
			// (set) Token: 0x06008DFE RID: 36350 RVA: 0x0004C708 File Offset: 0x0004A908
			public unsafe bool _reloadMap_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr__reloadMap_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr__reloadMap_5__2)) = value;
				}
			}

			// Token: 0x17002F76 RID: 12150
			// (get) Token: 0x06008DFF RID: 36351 RVA: 0x0026DA08 File Offset: 0x0026BC08
			// (set) Token: 0x06008E00 RID: 36352 RVA: 0x0004C723 File Offset: 0x0004A923
			public unsafe bool _startCanOpenNoteStorageEscape_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr__startCanOpenNoteStorageEscape_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr__startCanOpenNoteStorageEscape_5__3)) = value;
				}
			}

			// Token: 0x17002F77 RID: 12151
			// (get) Token: 0x06008E01 RID: 36353 RVA: 0x0026DA30 File Offset: 0x0026BC30
			// (set) Token: 0x06008E02 RID: 36354 RVA: 0x0004C73E File Offset: 0x0004A93E
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F78 RID: 12152
			// (get) Token: 0x06008E03 RID: 36355 RVA: 0x0026DA60 File Offset: 0x0026BC60
			// (set) Token: 0x06008E04 RID: 36356 RVA: 0x0004C76C File Offset: 0x0004A96C
			public unsafe IGameObjectAssetHandle<DaySceneMap> _lastMapReleaseHandle_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr__lastMapReleaseHandle_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<DaySceneMap>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr__lastMapReleaseHandle_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F79 RID: 12153
			// (get) Token: 0x06008E05 RID: 36357 RVA: 0x0026DA90 File Offset: 0x0026BC90
			// (set) Token: 0x06008E06 RID: 36358 RVA: 0x0004C78B File Offset: 0x0004A98B
			public UniTask<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___u__2);
					return new UniTask<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F7A RID: 12154
			// (get) Token: 0x06008E07 RID: 36359 RVA: 0x0026DAC0 File Offset: 0x0026BCC0
			// (set) Token: 0x06008E08 RID: 36360 RVA: 0x0004C7B9 File Offset: 0x0004A9B9
			public UnityAsyncExtensions.AsyncOperationAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___u__3);
					return new UnityAsyncExtensions.AsyncOperationAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityAsyncExtensions.AsyncOperationAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._SwapMapAsync_d__53.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnityAsyncExtensions.AsyncOperationAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005CA9 RID: 23721
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005CAA RID: 23722
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005CAB RID: 23723
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005CAC RID: 23724
			private static readonly IntPtr NativeFieldInfoPtr_targetMapLabel;

			// Token: 0x04005CAD RID: 23725
			private static readonly IntPtr NativeFieldInfoPtr_shouldFadeIn;

			// Token: 0x04005CAE RID: 23726
			private static readonly IntPtr NativeFieldInfoPtr_targetMarkerName;

			// Token: 0x04005CAF RID: 23727
			private static readonly IntPtr NativeFieldInfoPtr_travelCount;

			// Token: 0x04005CB0 RID: 23728
			private static readonly IntPtr NativeFieldInfoPtr_onSwapFinish;

			// Token: 0x04005CB1 RID: 23729
			private static readonly IntPtr NativeFieldInfoPtr_triggerEnterMapEvent;

			// Token: 0x04005CB2 RID: 23730
			private static readonly IntPtr NativeFieldInfoPtr_shouldFadeOut;

			// Token: 0x04005CB3 RID: 23731
			private static readonly IntPtr NativeFieldInfoPtr__reloadMap_5__2;

			// Token: 0x04005CB4 RID: 23732
			private static readonly IntPtr NativeFieldInfoPtr__startCanOpenNoteStorageEscape_5__3;

			// Token: 0x04005CB5 RID: 23733
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005CB6 RID: 23734
			private static readonly IntPtr NativeFieldInfoPtr__lastMapReleaseHandle_5__4;

			// Token: 0x04005CB7 RID: 23735
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005CB8 RID: 23736
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04005CB9 RID: 23737
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CBA RID: 23738
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005DB RID: 1499
		[ObfuscatedName("DayScene.SceneManager+<<ExecuteScheduledActions>g__ExecuteScheduledActions|47_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique : Il2CppSystem.Object
		{
			// Token: 0x06008E09 RID: 36361 RVA: 0x0026DAF0 File Offset: 0x0026BCF0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique()
			{
				Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<<ExecuteScheduledActions>g__ExecuteScheduledActions|47_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr, "<>1__state");
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr, "<>2__current");
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr, "<>4__this");
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr, 100666740);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr, 100666741);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr, 100666742);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr, 100666743);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr, 100666744);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr, 100666745);
			}

			// Token: 0x06008E0A RID: 36362 RVA: 0x0026DBD0 File Offset: 0x0026BDD0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E0B RID: 36363 RVA: 0x0026DC18 File Offset: 0x0026BE18
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E0C RID: 36364 RVA: 0x0026DC4C File Offset: 0x0026BE4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54337, XrefRangeEnd = 54342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002F7E RID: 12158
			// (get) Token: 0x06008E0D RID: 36365 RVA: 0x0026DC88 File Offset: 0x0026BE88
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008E0E RID: 36366 RVA: 0x0026DCC8 File Offset: 0x0026BEC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54342, XrefRangeEnd = 54348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002F7F RID: 12159
			// (get) Token: 0x06008E0F RID: 36367 RVA: 0x0026DCFC File Offset: 0x0026BEFC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008E10 RID: 36368 RVA: 0x0004C7E7 File Offset: 0x0004A9E7
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F7B RID: 12155
			// (get) Token: 0x06008E11 RID: 36369 RVA: 0x0026DD3C File Offset: 0x0026BF3C
			// (set) Token: 0x06008E12 RID: 36370 RVA: 0x0004C7F0 File Offset: 0x0004A9F0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002F7C RID: 12156
			// (get) Token: 0x06008E13 RID: 36371 RVA: 0x0026DD64 File Offset: 0x0026BF64
			// (set) Token: 0x06008E14 RID: 36372 RVA: 0x0004C80B File Offset: 0x0004AA0B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F7D RID: 12157
			// (get) Token: 0x06008E15 RID: 36373 RVA: 0x0026DD94 File Offset: 0x0026BF94
			// (set) Token: 0x06008E16 RID: 36374 RVA: 0x0004C82A File Offset: 0x0004AA2A
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005CBB RID: 23739
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005CBC RID: 23740
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005CBD RID: 23741
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005CBE RID: 23742
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005CBF RID: 23743
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CC0 RID: 23744
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005CC1 RID: 23745
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005CC2 RID: 23746
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CC3 RID: 23747
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
