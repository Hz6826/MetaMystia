using System;
using DEYU.AssetHandleUtility;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace StaffScene
{
	// Token: 0x02000036 RID: 54
	public class SceneManager : MonoSingleton<SceneManager>
	{
		// Token: 0x0600056F RID: 1391 RVA: 0x000AFD18 File Offset: 0x000ADF18
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
			Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "StaffScene", "SceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
			SceneManager.NativeFieldInfoPtr_unlockedLevel5Guests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "unlockedLevel5Guests");
			SceneManager.NativeFieldInfoPtr__PlaybackInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<PlaybackInfo>k__BackingField");
			SceneManager.NativeFieldInfoPtr_edCG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "edCG");
			SceneManager.NativeFieldInfoPtr_endCGImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "endCGImage");
			SceneManager.NativeFieldInfoPtr_npcCGTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "npcCGTransform");
			SceneManager.NativeFieldInfoPtr_lyricsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "lyricsContainer");
			SceneManager.NativeFieldInfoPtr_lyricsVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "lyricsVisual");
			SceneManager.NativeFieldInfoPtr_edTransitionRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "edTransitionRatio");
			SceneManager.NativeFieldInfoPtr_npcCgDurationWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "npcCgDurationWeight");
			SceneManager.NativeFieldInfoPtr_pages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "pages");
			SceneManager.NativeFieldInfoPtr_nx_pages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "nx_pages");
			SceneManager.NativeFieldInfoPtr_musicPageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "musicPageIndex");
			SceneManager.NativeFieldInfoPtr_nxMusicPageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "nxMusicPageIndex");
			SceneManager.NativeFieldInfoPtr_m_PagesField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_PagesField");
			SceneManager.NativeFieldInfoPtr_bg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "bg");
			SceneManager.NativeFieldInfoPtr_bg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "bg2");
			SceneManager.NativeFieldInfoPtr_shade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "shade");
			SceneManager.NativeFieldInfoPtr_transitionRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "transitionRatio");
			SceneManager.NativeFieldInfoPtr_extraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "extraOffset");
			SceneManager.NativeFieldInfoPtr_m_NPCCG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_NPCCG");
			SceneManager.NativeFieldInfoPtr_m_LoopAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_LoopAudioSource");
			SceneManager.NativeFieldInfoPtr__NpcCGDB_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<NpcCGDB>k__BackingField");
			SceneManager.NativeFieldInfoPtr__staffPageInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "_staffPageInstances");
			SceneManager.NativeFieldInfoPtr_ResetAllNPCCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "ResetAllNPCCallback");
			SceneManager.NativeMethodInfoPtr_get_PlaybackInfo_Private_Static_get_Nullable_1_StaffScenePlaybackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664040);
			SceneManager.NativeMethodInfoPtr_set_PlaybackInfo_Public_Static_set_Void_Nullable_1_StaffScenePlaybackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664041);
			SceneManager.NativeMethodInfoPtr_get_NpcCGDB_Private_Static_get_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664042);
			SceneManager.NativeMethodInfoPtr_set_NpcCGDB_Public_Static_set_Void_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664043);
			SceneManager.NativeMethodInfoPtr_get_CurrentPlayBackTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664044);
			SceneManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664045);
			SceneManager.NativeMethodInfoPtr_add_ResetAllNPCCallback_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664046);
			SceneManager.NativeMethodInfoPtr_remove_ResetAllNPCCallback_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664047);
			SceneManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664048);
			SceneManager.NativeMethodInfoPtr_PlayLyrics_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664049);
			SceneManager.NativeMethodInfoPtr_PlayBGMDelayed_Private_IEnumerator_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664050);
			SceneManager.NativeMethodInfoPtr_OnDisplayingData_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664051);
			SceneManager.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664052);
			SceneManager.NativeMethodInfoPtr_GotoResultScene_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664053);
			SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664054);
			SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664055);
			SceneManager.NativeMethodInfoPtr_Method_Internal_Static_Void_CanvasGroup_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664056);
			SceneManager.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_CanvasGroup_Single_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664057);
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x000B0090 File Offset: 0x000AE290
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x000B00BC File Offset: 0x000AE2BC
		public unsafe static Nullable<SceneManager.StaffScenePlaybackInfo> PlaybackInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24871, XrefRangeEnd = 24873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_PlaybackInfo_Private_Static_get_Nullable_1_StaffScenePlaybackInfo_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<SceneManager.StaffScenePlaybackInfo>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24873, XrefRangeEnd = 24877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_PlaybackInfo_Public_Static_set_Void_Nullable_1_StaffScenePlaybackInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x000B00F8 File Offset: 0x000AE2F8
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x000B012C File Offset: 0x000AE32C
		public unsafe static Il2CppReferenceArray<GameObject> NpcCGDB
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24877, XrefRangeEnd = 24879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_NpcCGDB_Private_Static_get_Il2CppReferenceArray_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24879, XrefRangeEnd = 24883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_NpcCGDB_Public_Static_set_Void_Il2CppReferenceArray_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x000B0164 File Offset: 0x000AE364
		public unsafe float CurrentPlayBackTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 24888, RefRangeEnd = 24890, XrefRangeStart = 24883, XrefRangeEnd = 24888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_CurrentPlayBackTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000B01A0 File Offset: 0x000AE3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24890, XrefRangeEnd = 25005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000B01D4 File Offset: 0x000AE3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25012, RefRangeEnd = 25013, XrefRangeStart = 25005, XrefRangeEnd = 25012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_ResetAllNPCCallback(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_ResetAllNPCCallback_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000B020C File Offset: 0x000AE40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25013, XrefRangeEnd = 25020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_ResetAllNPCCallback(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_ResetAllNPCCallback_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000B0244 File Offset: 0x000AE444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25020, XrefRangeEnd = 25023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000B0280 File Offset: 0x000AE480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25023, XrefRangeEnd = 25028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlayLyrics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_PlayLyrics_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000B02C0 File Offset: 0x000AE4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25028, XrefRangeEnd = 25034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlayBGMDelayed(LoopedBGMPackage selectedBGMPackage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedBGMPackage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_PlayBGMDelayed_Private_IEnumerator_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000B0310 File Offset: 0x000AE510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25034, XrefRangeEnd = 25039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnDisplayingData(float selectedBGMLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectedBGMLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_OnDisplayingData_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000B035C File Offset: 0x000AE55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25039, XrefRangeEnd = 25044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000B0390 File Offset: 0x000AE590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25044, XrefRangeEnd = 25057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GotoResultScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GotoResultScene_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000B03C4 File Offset: 0x000AE5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25057, XrefRangeEnd = 25080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000B0400 File Offset: 0x000AE600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25080, XrefRangeEnd = 25091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000B043C File Offset: 0x000AE63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25091, XrefRangeEnd = 25093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_CanvasGroup_Single_PDM_0(CanvasGroup image, float alpha)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Method_Internal_Static_Void_CanvasGroup_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000B0480 File Offset: 0x000AE680
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25099, RefRangeEnd = 25101, XrefRangeStart = 25093, XrefRangeEnd = 25099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_CanvasGroup_Single_Single_Action_0(CanvasGroup canvasGroup, float transition, float display, Action onBeforeFadeCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref display;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBeforeFadeCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_CanvasGroup_Single_Single_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00005229 File Offset: 0x00003429
		public SceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x000B04F4 File Offset: 0x000AE6F4
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00005232 File Offset: 0x00003432
		public unsafe static Il2CppStringArray unlockedLevel5Guests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_unlockedLevel5Guests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_unlockedLevel5Guests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x000B051C File Offset: 0x000AE71C
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00005244 File Offset: 0x00003444
		public unsafe static Nullable<SceneManager.StaffScenePlaybackInfo> _PlaybackInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SceneManager.StaffScenePlaybackInfo>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr__PlaybackInfo_k__BackingField, intPtr);
				return new Nullable<SceneManager.StaffScenePlaybackInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SceneManager.StaffScenePlaybackInfo>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr__PlaybackInfo_k__BackingField, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x000B0558 File Offset: 0x000AE758
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x0000525B File Offset: 0x0000345B
		public unsafe CanvasGroup edCG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_edCG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_edCG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000B0588 File Offset: 0x000AE788
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0000527A File Offset: 0x0000347A
		public unsafe Image endCGImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_endCGImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_endCGImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x000B05B8 File Offset: 0x000AE7B8
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00005299 File Offset: 0x00003499
		public unsafe RectTransform npcCGTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_npcCGTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_npcCGTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x000B05E8 File Offset: 0x000AE7E8
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x000052B8 File Offset: 0x000034B8
		public unsafe GameObject lyricsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_lyricsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_lyricsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x000B0618 File Offset: 0x000AE818
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x000052D7 File Offset: 0x000034D7
		public unsafe TextMeshProUGUI lyricsVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_lyricsVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_lyricsVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x000B0648 File Offset: 0x000AE848
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x000052F6 File Offset: 0x000034F6
		public unsafe float edTransitionRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_edTransitionRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_edTransitionRatio)) = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x000B0670 File Offset: 0x000AE870
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00005311 File Offset: 0x00003511
		public unsafe float npcCgDurationWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_npcCgDurationWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_npcCgDurationWeight)) = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000B0698 File Offset: 0x000AE898
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0000532C File Offset: 0x0000352C
		public unsafe List<CanvasGroup> pages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_pages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_pages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x000B06C8 File Offset: 0x000AE8C8
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x0000534B File Offset: 0x0000354B
		public unsafe List<CanvasGroup> nx_pages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_nx_pages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_nx_pages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x000B06F8 File Offset: 0x000AE8F8
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x0000536A File Offset: 0x0000356A
		public unsafe int musicPageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_musicPageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_musicPageIndex)) = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x000B0720 File Offset: 0x000AE920
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00005385 File Offset: 0x00003585
		public unsafe int nxMusicPageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_nxMusicPageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_nxMusicPageIndex)) = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x000B0748 File Offset: 0x000AE948
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x000053A0 File Offset: 0x000035A0
		public unsafe RectTransform m_PagesField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_PagesField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_PagesField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x000B0778 File Offset: 0x000AE978
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x000053BF File Offset: 0x000035BF
		public unsafe CanvasGroup bg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_bg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_bg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x000B07A8 File Offset: 0x000AE9A8
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x000053DE File Offset: 0x000035DE
		public unsafe CanvasGroup bg2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_bg2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_bg2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000B07D8 File Offset: 0x000AE9D8
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x000053FD File Offset: 0x000035FD
		public unsafe CanvasGroup shade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_shade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_shade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x000B0808 File Offset: 0x000AEA08
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0000541C File Offset: 0x0000361C
		public unsafe float transitionRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_transitionRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_transitionRatio)) = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x000B0830 File Offset: 0x000AEA30
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00005437 File Offset: 0x00003637
		public unsafe float extraOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_extraOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_extraOffset)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000B0858 File Offset: 0x000AEA58
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00005452 File Offset: 0x00003652
		public unsafe List<FlexibleCGElement> m_NPCCG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_NPCCG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FlexibleCGElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_NPCCG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x000B0888 File Offset: 0x000AEA88
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00005471 File Offset: 0x00003671
		public unsafe AudioSource m_LoopAudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_LoopAudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_LoopAudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x000B08B8 File Offset: 0x000AEAB8
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00005490 File Offset: 0x00003690
		public unsafe static Il2CppReferenceArray<GameObject> _NpcCGDB_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr__NpcCGDB_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr__NpcCGDB_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x000B08E0 File Offset: 0x000AEAE0
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x000054A2 File Offset: 0x000036A2
		public unsafe Il2CppReferenceArray<CanvasGroup> _staffPageInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__staffPageInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__staffPageInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000B0910 File Offset: 0x000AEB10
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x000054C1 File Offset: 0x000036C1
		public unsafe static Action ResetAllNPCCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_ResetAllNPCCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_ResetAllNPCCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr_unlockedLevel5Guests;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr__PlaybackInfo_k__BackingField;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr_edCG;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr_endCGImage;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr_npcCGTransform;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeFieldInfoPtr_lyricsContainer;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeFieldInfoPtr_lyricsVisual;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_edTransitionRatio;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeFieldInfoPtr_npcCgDurationWeight;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr_pages;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr_nx_pages;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeFieldInfoPtr_musicPageIndex;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeFieldInfoPtr_nxMusicPageIndex;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_m_PagesField;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeFieldInfoPtr_bg;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_bg2;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_shade;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeFieldInfoPtr_transitionRatio;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr_extraOffset;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_m_NPCCG;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr_m_LoopAudioSource;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeFieldInfoPtr__NpcCGDB_k__BackingField;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr__staffPageInstances;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr_ResetAllNPCCallback;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_get_PlaybackInfo_Private_Static_get_Nullable_1_StaffScenePlaybackInfo_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_set_PlaybackInfo_Public_Static_set_Void_Nullable_1_StaffScenePlaybackInfo_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_get_NpcCGDB_Private_Static_get_Il2CppReferenceArray_1_GameObject_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_set_NpcCGDB_Public_Static_set_Void_Il2CppReferenceArray_1_GameObject_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayBackTime_Private_get_Single_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_add_ResetAllNPCCallback_Public_Static_add_Void_Action_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_remove_ResetAllNPCCallback_Public_Static_rem_Void_Action_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_PlayLyrics_Private_IEnumerator_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_PlayBGMDelayed_Private_IEnumerator_LoopedBGMPackage_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_OnDisplayingData_Private_IEnumerator_Single_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_GotoResultScene_Private_Void_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_CanvasGroup_Single_PDM_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_CanvasGroup_Single_Single_Action_0;

		// Token: 0x020004B1 RID: 1201
		public sealed class StaffScenePlaybackInfo : ValueType
		{
			// Token: 0x06007EF1 RID: 32497 RVA: 0x00242074 File Offset: 0x00240274
			// Note: this type is marked as 'beforefieldinit'.
			static StaffScenePlaybackInfo()
			{
				Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "StaffScenePlaybackInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr);
				SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_CG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr, "CG");
				SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_BGM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr, "BGM");
				SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_Lyrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr, "Lyrics");
				SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_EndCGDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr, "EndCGDuration");
				SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_ShowLyrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr, "ShowLyrics");
				SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_Page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr, "Page");
				SceneManager.StaffScenePlaybackInfo.NativeMethodInfoPtr__ctor_Public_Void_IAssetHandle_1_Sprite_IAssetHandle_1_LoopedBGMPackage_Il2CppReferenceArray_1_ValueTuple_2_Single_String_Single_Boolean_IGameObjectAssetHandle_1_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr, 100664058);
				SceneManager.StaffScenePlaybackInfo.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr, 100664059);
			}

			// Token: 0x06007EF2 RID: 32498 RVA: 0x00242140 File Offset: 0x00240340
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24520, RefRangeEnd = 24521, XrefRangeStart = 24516, XrefRangeEnd = 24520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StaffScenePlaybackInfo(IAssetHandle<Sprite> cg, IAssetHandle<LoopedBGMPackage> bgm, Il2CppReferenceArray<ValueTuple<float, string>> lyrics, float endCGDuration, bool showLyrics, IGameObjectAssetHandle<CanvasGroup> page) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cg);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bgm);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lyrics);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endCGDuration;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showLyrics;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(page);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.StaffScenePlaybackInfo.NativeMethodInfoPtr__ctor_Public_Void_IAssetHandle_1_Sprite_IAssetHandle_1_LoopedBGMPackage_Il2CppReferenceArray_1_ValueTuple_2_Single_String_Single_Boolean_IGameObjectAssetHandle_1_CanvasGroup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EF3 RID: 32499 RVA: 0x002421E4 File Offset: 0x002403E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24521, XrefRangeEnd = 24528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.StaffScenePlaybackInfo.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EF4 RID: 32500 RVA: 0x0004448F File Offset: 0x0004268F
			public StaffScenePlaybackInfo(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007EF5 RID: 32501 RVA: 0x00044498 File Offset: 0x00042698
			public StaffScenePlaybackInfo() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.StaffScenePlaybackInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17002AD7 RID: 10967
			// (get) Token: 0x06007EF6 RID: 32502 RVA: 0x0024221C File Offset: 0x0024041C
			// (set) Token: 0x06007EF7 RID: 32503 RVA: 0x000444AA File Offset: 0x000426AA
			public unsafe IAssetHandle<Sprite> CG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_CG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_CG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AD8 RID: 10968
			// (get) Token: 0x06007EF8 RID: 32504 RVA: 0x0024224C File Offset: 0x0024044C
			// (set) Token: 0x06007EF9 RID: 32505 RVA: 0x000444C9 File Offset: 0x000426C9
			public unsafe IAssetHandle<LoopedBGMPackage> BGM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_BGM);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<LoopedBGMPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_BGM), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AD9 RID: 10969
			// (get) Token: 0x06007EFA RID: 32506 RVA: 0x0024227C File Offset: 0x0024047C
			// (set) Token: 0x06007EFB RID: 32507 RVA: 0x000444E8 File Offset: 0x000426E8
			public unsafe Il2CppReferenceArray<ValueTuple<float, string>> Lyrics
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_Lyrics);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<float, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_Lyrics), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ADA RID: 10970
			// (get) Token: 0x06007EFC RID: 32508 RVA: 0x002422AC File Offset: 0x002404AC
			// (set) Token: 0x06007EFD RID: 32509 RVA: 0x00044507 File Offset: 0x00042707
			public unsafe float EndCGDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_EndCGDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_EndCGDuration)) = value;
				}
			}

			// Token: 0x17002ADB RID: 10971
			// (get) Token: 0x06007EFE RID: 32510 RVA: 0x002422D4 File Offset: 0x002404D4
			// (set) Token: 0x06007EFF RID: 32511 RVA: 0x00044522 File Offset: 0x00042722
			public unsafe bool ShowLyrics
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_ShowLyrics);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_ShowLyrics)) = value;
				}
			}

			// Token: 0x17002ADC RID: 10972
			// (get) Token: 0x06007F00 RID: 32512 RVA: 0x002422FC File Offset: 0x002404FC
			// (set) Token: 0x06007F01 RID: 32513 RVA: 0x0004453D File Offset: 0x0004273D
			public unsafe IGameObjectAssetHandle<CanvasGroup> Page
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_Page);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.StaffScenePlaybackInfo.NativeFieldInfoPtr_Page), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005373 RID: 21363
			private static readonly IntPtr NativeFieldInfoPtr_CG;

			// Token: 0x04005374 RID: 21364
			private static readonly IntPtr NativeFieldInfoPtr_BGM;

			// Token: 0x04005375 RID: 21365
			private static readonly IntPtr NativeFieldInfoPtr_Lyrics;

			// Token: 0x04005376 RID: 21366
			private static readonly IntPtr NativeFieldInfoPtr_EndCGDuration;

			// Token: 0x04005377 RID: 21367
			private static readonly IntPtr NativeFieldInfoPtr_ShowLyrics;

			// Token: 0x04005378 RID: 21368
			private static readonly IntPtr NativeFieldInfoPtr_Page;

			// Token: 0x04005379 RID: 21369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAssetHandle_1_Sprite_IAssetHandle_1_LoopedBGMPackage_Il2CppReferenceArray_1_ValueTuple_2_Single_String_Single_Boolean_IGameObjectAssetHandle_1_CanvasGroup_0;

			// Token: 0x0400537A RID: 21370
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020004B2 RID: 1202
		[ObfuscatedName("StaffScene.SceneManager+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x06007F02 RID: 32514 RVA: 0x0024232C File Offset: 0x0024052C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, "next");
				SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, 100664060);
				SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__PlayLyrics_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, 100664061);
				SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__PlayLyrics_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr, 100664062);
			}

			// Token: 0x06007F03 RID: 32515 RVA: 0x002423BC File Offset: 0x002405BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F04 RID: 32516 RVA: 0x002423F8 File Offset: 0x002405F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24528, XrefRangeEnd = 24529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayLyrics_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__PlayLyrics_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007F05 RID: 32517 RVA: 0x00242434 File Offset: 0x00240634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24529, XrefRangeEnd = 24530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayLyrics_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass37_0.NativeMethodInfoPtr__PlayLyrics_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007F06 RID: 32518 RVA: 0x0004455C File Offset: 0x0004275C
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002ADD RID: 10973
			// (get) Token: 0x06007F07 RID: 32519 RVA: 0x00242470 File Offset: 0x00240670
			// (set) Token: 0x06007F08 RID: 32520 RVA: 0x00044565 File Offset: 0x00042765
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ADE RID: 10974
			// (get) Token: 0x06007F09 RID: 32521 RVA: 0x002424A0 File Offset: 0x002406A0
			// (set) Token: 0x06007F0A RID: 32522 RVA: 0x00044584 File Offset: 0x00042784
			public ValueTuple<float, string> next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr_next);
					return new ValueTuple<float, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<float, string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass37_0.NativeFieldInfoPtr_next), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<float, string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400537B RID: 21371
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400537C RID: 21372
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x0400537D RID: 21373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400537E RID: 21374
			private static readonly IntPtr NativeMethodInfoPtr__PlayLyrics_b__0_Internal_Boolean_0;

			// Token: 0x0400537F RID: 21375
			private static readonly IntPtr NativeMethodInfoPtr__PlayLyrics_b__1_Internal_Boolean_0;
		}

		// Token: 0x020004B3 RID: 1203
		[ObfuscatedName("StaffScene.SceneManager+<PlayLyrics>d__37")]
		public sealed class _PlayLyrics_d__37 : Il2CppSystem.Object
		{
			// Token: 0x06007F0B RID: 32523 RVA: 0x002424D0 File Offset: 0x002406D0
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayLyrics_d__37()
			{
				Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<PlayLyrics>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr);
				SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, "<>1__state");
				SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, "<>2__current");
				SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, "<>4__this");
				SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, "<>8__1");
				SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr__lyricsData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, "<lyricsData>5__2");
				SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, 100664063);
				SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, 100664064);
				SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, 100664065);
				SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, 100664066);
				SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, 100664067);
				SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr, 100664068);
			}

			// Token: 0x06007F0C RID: 32524 RVA: 0x002425D8 File Offset: 0x002407D8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayLyrics_d__37(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._PlayLyrics_d__37>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F0D RID: 32525 RVA: 0x00242620 File Offset: 0x00240820
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F0E RID: 32526 RVA: 0x00242654 File Offset: 0x00240854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24530, XrefRangeEnd = 24553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002AE4 RID: 10980
			// (get) Token: 0x06007F0F RID: 32527 RVA: 0x00242690 File Offset: 0x00240890
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007F10 RID: 32528 RVA: 0x002426D0 File Offset: 0x002408D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24553, XrefRangeEnd = 24559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002AE5 RID: 10981
			// (get) Token: 0x06007F11 RID: 32529 RVA: 0x00242704 File Offset: 0x00240904
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayLyrics_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007F12 RID: 32530 RVA: 0x000445B2 File Offset: 0x000427B2
			public _PlayLyrics_d__37(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002ADF RID: 10975
			// (get) Token: 0x06007F13 RID: 32531 RVA: 0x00242744 File Offset: 0x00240944
			// (set) Token: 0x06007F14 RID: 32532 RVA: 0x000445BB File Offset: 0x000427BB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002AE0 RID: 10976
			// (get) Token: 0x06007F15 RID: 32533 RVA: 0x0024276C File Offset: 0x0024096C
			// (set) Token: 0x06007F16 RID: 32534 RVA: 0x000445D6 File Offset: 0x000427D6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE1 RID: 10977
			// (get) Token: 0x06007F17 RID: 32535 RVA: 0x0024279C File Offset: 0x0024099C
			// (set) Token: 0x06007F18 RID: 32536 RVA: 0x000445F5 File Offset: 0x000427F5
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE2 RID: 10978
			// (get) Token: 0x06007F19 RID: 32537 RVA: 0x002427CC File Offset: 0x002409CC
			// (set) Token: 0x06007F1A RID: 32538 RVA: 0x00044614 File Offset: 0x00042814
			public unsafe SceneManager.__c__DisplayClass37_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c__DisplayClass37_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE3 RID: 10979
			// (get) Token: 0x06007F1B RID: 32539 RVA: 0x002427FC File Offset: 0x002409FC
			// (set) Token: 0x06007F1C RID: 32540 RVA: 0x00044633 File Offset: 0x00042833
			public unsafe Queue<ValueTuple<float, string>> _lyricsData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr__lyricsData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ValueTuple<float, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayLyrics_d__37.NativeFieldInfoPtr__lyricsData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005380 RID: 21376
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005381 RID: 21377
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005382 RID: 21378
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005383 RID: 21379
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005384 RID: 21380
			private static readonly IntPtr NativeFieldInfoPtr__lyricsData_5__2;

			// Token: 0x04005385 RID: 21381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005386 RID: 21382
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005387 RID: 21383
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005388 RID: 21384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005389 RID: 21385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400538A RID: 21386
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020004B4 RID: 1204
		[ObfuscatedName("StaffScene.SceneManager+<PlayBGMDelayed>d__38")]
		public sealed class _PlayBGMDelayed_d__38 : Il2CppSystem.Object
		{
			// Token: 0x06007F1D RID: 32541 RVA: 0x0024282C File Offset: 0x00240A2C
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayBGMDelayed_d__38()
			{
				Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<PlayBGMDelayed>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr);
				SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr, "<>1__state");
				SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr, "<>2__current");
				SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr_selectedBGMPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr, "selectedBGMPackage");
				SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr, "<>4__this");
				SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr, 100664069);
				SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr, 100664070);
				SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr, 100664071);
				SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr, 100664072);
				SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr, 100664073);
				SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr, 100664074);
			}

			// Token: 0x06007F1E RID: 32542 RVA: 0x00242920 File Offset: 0x00240B20
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayBGMDelayed_d__38(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._PlayBGMDelayed_d__38>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F1F RID: 32543 RVA: 0x00242968 File Offset: 0x00240B68
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F20 RID: 32544 RVA: 0x0024299C File Offset: 0x00240B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24559, XrefRangeEnd = 24565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002AEA RID: 10986
			// (get) Token: 0x06007F21 RID: 32545 RVA: 0x002429D8 File Offset: 0x00240BD8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007F22 RID: 32546 RVA: 0x00242A18 File Offset: 0x00240C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24565, XrefRangeEnd = 24571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002AEB RID: 10987
			// (get) Token: 0x06007F23 RID: 32547 RVA: 0x00242A4C File Offset: 0x00240C4C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._PlayBGMDelayed_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007F24 RID: 32548 RVA: 0x00044652 File Offset: 0x00042852
			public _PlayBGMDelayed_d__38(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AE6 RID: 10982
			// (get) Token: 0x06007F25 RID: 32549 RVA: 0x00242A8C File Offset: 0x00240C8C
			// (set) Token: 0x06007F26 RID: 32550 RVA: 0x0004465B File Offset: 0x0004285B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002AE7 RID: 10983
			// (get) Token: 0x06007F27 RID: 32551 RVA: 0x00242AB4 File Offset: 0x00240CB4
			// (set) Token: 0x06007F28 RID: 32552 RVA: 0x00044676 File Offset: 0x00042876
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE8 RID: 10984
			// (get) Token: 0x06007F29 RID: 32553 RVA: 0x00242AE4 File Offset: 0x00240CE4
			// (set) Token: 0x06007F2A RID: 32554 RVA: 0x00044695 File Offset: 0x00042895
			public unsafe LoopedBGMPackage selectedBGMPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr_selectedBGMPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr_selectedBGMPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE9 RID: 10985
			// (get) Token: 0x06007F2B RID: 32555 RVA: 0x00242B14 File Offset: 0x00240D14
			// (set) Token: 0x06007F2C RID: 32556 RVA: 0x000446B4 File Offset: 0x000428B4
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._PlayBGMDelayed_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400538B RID: 21387
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400538C RID: 21388
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400538D RID: 21389
			private static readonly IntPtr NativeFieldInfoPtr_selectedBGMPackage;

			// Token: 0x0400538E RID: 21390
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400538F RID: 21391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005390 RID: 21392
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005391 RID: 21393
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005392 RID: 21394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005393 RID: 21395
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005394 RID: 21396
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020004B5 RID: 1205
		[ObfuscatedName("StaffScene.SceneManager+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x06007F2D RID: 32557 RVA: 0x00242B44 File Offset: 0x00240D44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, "canContinue");
				SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, 100664075);
				SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__OnDisplayingData_b__2_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, 100664076);
				SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__OnDisplayingData_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, 100664077);
				SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__OnDisplayingData_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, 100664078);
				SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__OnDisplayingData_b__5_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr, 100664079);
			}

			// Token: 0x06007F2E RID: 32558 RVA: 0x00242BFC File Offset: 0x00240DFC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F2F RID: 32559 RVA: 0x00242C38 File Offset: 0x00240E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24571, XrefRangeEnd = 24573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnDisplayingData_b__2(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__OnDisplayingData_b__2_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F30 RID: 32560 RVA: 0x00242C78 File Offset: 0x00240E78
			[CallerCount(0)]
			public unsafe void _OnDisplayingData_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__OnDisplayingData_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F31 RID: 32561 RVA: 0x00242CAC File Offset: 0x00240EAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24573, RefRangeEnd = 24574, XrefRangeStart = 24573, XrefRangeEnd = 24573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnDisplayingData_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__OnDisplayingData_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007F32 RID: 32562 RVA: 0x00242CE8 File Offset: 0x00240EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24574, XrefRangeEnd = 24576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnDisplayingData_b__5(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_0.NativeMethodInfoPtr__OnDisplayingData_b__5_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F33 RID: 32563 RVA: 0x000446D3 File Offset: 0x000428D3
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AEC RID: 10988
			// (get) Token: 0x06007F34 RID: 32564 RVA: 0x00242D28 File Offset: 0x00240F28
			// (set) Token: 0x06007F35 RID: 32565 RVA: 0x000446DC File Offset: 0x000428DC
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AED RID: 10989
			// (get) Token: 0x06007F36 RID: 32566 RVA: 0x00242D58 File Offset: 0x00240F58
			// (set) Token: 0x06007F37 RID: 32567 RVA: 0x000446FB File Offset: 0x000428FB
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x04005395 RID: 21397
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005396 RID: 21398
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x04005397 RID: 21399
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005398 RID: 21400
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingData_b__2_Internal_Void_Single_0;

			// Token: 0x04005399 RID: 21401
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingData_b__3_Internal_Void_0;

			// Token: 0x0400539A RID: 21402
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingData_b__4_Internal_Boolean_0;

			// Token: 0x0400539B RID: 21403
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingData_b__5_Internal_Void_Single_0;
		}

		// Token: 0x020004B6 RID: 1206
		[ObfuscatedName("StaffScene.SceneManager+<>c__DisplayClass39_1")]
		public sealed class __c__DisplayClass39_1 : Il2CppSystem.Object
		{
			// Token: 0x06007F38 RID: 32568 RVA: 0x00242D80 File Offset: 0x00240F80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_1()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass39_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr);
				SceneManager.__c__DisplayClass39_1.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr, "canvasGroup");
				SceneManager.__c__DisplayClass39_1.NativeFieldInfoPtr_continue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr, "continue");
				SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr, 100664080);
				SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__6_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr, 100664081);
				SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr, 100664082);
				SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__8_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr, 100664083);
				SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__9_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr, 100664084);
				SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__10_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr, 100664085);
				SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__11_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr, 100664086);
			}

			// Token: 0x06007F39 RID: 32569 RVA: 0x00242E60 File Offset: 0x00241060
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass39_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F3A RID: 32570 RVA: 0x00242E9C File Offset: 0x0024109C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24576, XrefRangeEnd = 24578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnDisplayingData_b__6(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__6_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F3B RID: 32571 RVA: 0x00242EDC File Offset: 0x002410DC
			[CallerCount(0)]
			public unsafe void _OnDisplayingData_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F3C RID: 32572 RVA: 0x00242F10 File Offset: 0x00241110
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24573, RefRangeEnd = 24574, XrefRangeStart = 24573, XrefRangeEnd = 24574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnDisplayingData_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__8_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007F3D RID: 32573 RVA: 0x00242F4C File Offset: 0x0024114C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnDisplayingData_b__9(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__9_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F3E RID: 32574 RVA: 0x00242F8C File Offset: 0x0024118C
			[CallerCount(0)]
			public unsafe void _OnDisplayingData_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__10_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F3F RID: 32575 RVA: 0x00242FC0 File Offset: 0x002411C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24573, RefRangeEnd = 24574, XrefRangeStart = 24573, XrefRangeEnd = 24574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnDisplayingData_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass39_1.NativeMethodInfoPtr__OnDisplayingData_b__11_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007F40 RID: 32576 RVA: 0x00044716 File Offset: 0x00042916
			public __c__DisplayClass39_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AEE RID: 10990
			// (get) Token: 0x06007F41 RID: 32577 RVA: 0x00242FFC File Offset: 0x002411FC
			// (set) Token: 0x06007F42 RID: 32578 RVA: 0x0004471F File Offset: 0x0004291F
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_1.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_1.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AEF RID: 10991
			// (get) Token: 0x06007F43 RID: 32579 RVA: 0x0024302C File Offset: 0x0024122C
			// (set) Token: 0x06007F44 RID: 32580 RVA: 0x0004473E File Offset: 0x0004293E
			public unsafe bool @continue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_1.NativeFieldInfoPtr_continue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass39_1.NativeFieldInfoPtr_continue)) = value;
				}
			}

			// Token: 0x0400539C RID: 21404
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x0400539D RID: 21405
			private static readonly IntPtr NativeFieldInfoPtr_continue;

			// Token: 0x0400539E RID: 21406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400539F RID: 21407
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingData_b__6_Internal_Void_Single_0;

			// Token: 0x040053A0 RID: 21408
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingData_b__7_Internal_Void_0;

			// Token: 0x040053A1 RID: 21409
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingData_b__8_Internal_Boolean_0;

			// Token: 0x040053A2 RID: 21410
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingData_b__9_Internal_Void_Single_0;

			// Token: 0x040053A3 RID: 21411
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingData_b__10_Internal_Void_0;

			// Token: 0x040053A4 RID: 21412
			private static readonly IntPtr NativeMethodInfoPtr__OnDisplayingData_b__11_Internal_Boolean_0;
		}

		// Token: 0x020004B7 RID: 1207
		[ObfuscatedName("StaffScene.SceneManager+<OnDisplayingData>d__39")]
		public sealed class _OnDisplayingData_d__39 : Il2CppSystem.Object
		{
			// Token: 0x06007F45 RID: 32581 RVA: 0x00243054 File Offset: 0x00241254
			// Note: this type is marked as 'beforefieldinit'.
			static _OnDisplayingData_d__39()
			{
				Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<OnDisplayingData>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr);
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<>1__state");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<>2__current");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<>4__this");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<>8__1");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr_selectedBGMLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "selectedBGMLength");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__allValidNPCCGPages_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<allValidNPCCGPages>5__2");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__edCGDuration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<edCGDuration>5__3");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__edCGTransitionDuration_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<edCGTransitionDuration>5__4");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__fadeDurationForOneNPCCG_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<fadeDurationForOneNPCCG>5__5");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__fadeDurationForOneStaffCG_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<fadeDurationForOneStaffCG>5__6");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__stayDurationForOneNPCCG_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<stayDurationForOneNPCCG>5__7");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__stayDurationForOneStaffCG_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<stayDurationForOneStaffCG>5__8");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<>7__wrap8");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<>7__wrap9");
				SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___7__wrap10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, "<>7__wrap10");
				SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, 100664087);
				SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, 100664088);
				SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, 100664089);
				SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, 100664090);
				SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, 100664091);
				SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, 100664092);
				SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr, 100664093);
			}

			// Token: 0x06007F46 RID: 32582 RVA: 0x00243238 File Offset: 0x00241438
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnDisplayingData_d__39(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._OnDisplayingData_d__39>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F47 RID: 32583 RVA: 0x00243280 File Offset: 0x00241480
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24583, RefRangeEnd = 24584, XrefRangeStart = 24578, XrefRangeEnd = 24583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F48 RID: 32584 RVA: 0x002432B4 File Offset: 0x002414B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24584, XrefRangeEnd = 24825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007F49 RID: 32585 RVA: 0x002432F0 File Offset: 0x002414F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24828, RefRangeEnd = 24829, XrefRangeStart = 24825, XrefRangeEnd = 24828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002AFF RID: 11007
			// (get) Token: 0x06007F4A RID: 32586 RVA: 0x00243324 File Offset: 0x00241524
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007F4B RID: 32587 RVA: 0x00243364 File Offset: 0x00241564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24829, XrefRangeEnd = 24835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B00 RID: 11008
			// (get) Token: 0x06007F4C RID: 32588 RVA: 0x00243398 File Offset: 0x00241598
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._OnDisplayingData_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007F4D RID: 32589 RVA: 0x00044759 File Offset: 0x00042959
			public _OnDisplayingData_d__39(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AF0 RID: 10992
			// (get) Token: 0x06007F4E RID: 32590 RVA: 0x002433D8 File Offset: 0x002415D8
			// (set) Token: 0x06007F4F RID: 32591 RVA: 0x00044762 File Offset: 0x00042962
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002AF1 RID: 10993
			// (get) Token: 0x06007F50 RID: 32592 RVA: 0x00243400 File Offset: 0x00241600
			// (set) Token: 0x06007F51 RID: 32593 RVA: 0x0004477D File Offset: 0x0004297D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AF2 RID: 10994
			// (get) Token: 0x06007F52 RID: 32594 RVA: 0x00243430 File Offset: 0x00241630
			// (set) Token: 0x06007F53 RID: 32595 RVA: 0x0004479C File Offset: 0x0004299C
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AF3 RID: 10995
			// (get) Token: 0x06007F54 RID: 32596 RVA: 0x00243460 File Offset: 0x00241660
			// (set) Token: 0x06007F55 RID: 32597 RVA: 0x000447BB File Offset: 0x000429BB
			public unsafe SceneManager.__c__DisplayClass39_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c__DisplayClass39_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AF4 RID: 10996
			// (get) Token: 0x06007F56 RID: 32598 RVA: 0x00243490 File Offset: 0x00241690
			// (set) Token: 0x06007F57 RID: 32599 RVA: 0x000447DA File Offset: 0x000429DA
			public unsafe float selectedBGMLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr_selectedBGMLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr_selectedBGMLength)) = value;
				}
			}

			// Token: 0x17002AF5 RID: 10997
			// (get) Token: 0x06007F58 RID: 32600 RVA: 0x002434B8 File Offset: 0x002416B8
			// (set) Token: 0x06007F59 RID: 32601 RVA: 0x000447F5 File Offset: 0x000429F5
			public unsafe List<CanvasGroup> _allValidNPCCGPages_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__allValidNPCCGPages_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__allValidNPCCGPages_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AF6 RID: 10998
			// (get) Token: 0x06007F5A RID: 32602 RVA: 0x002434E8 File Offset: 0x002416E8
			// (set) Token: 0x06007F5B RID: 32603 RVA: 0x00044814 File Offset: 0x00042A14
			public unsafe float _edCGDuration_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__edCGDuration_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__edCGDuration_5__3)) = value;
				}
			}

			// Token: 0x17002AF7 RID: 10999
			// (get) Token: 0x06007F5C RID: 32604 RVA: 0x00243510 File Offset: 0x00241710
			// (set) Token: 0x06007F5D RID: 32605 RVA: 0x0004482F File Offset: 0x00042A2F
			public unsafe float _edCGTransitionDuration_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__edCGTransitionDuration_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__edCGTransitionDuration_5__4)) = value;
				}
			}

			// Token: 0x17002AF8 RID: 11000
			// (get) Token: 0x06007F5E RID: 32606 RVA: 0x00243538 File Offset: 0x00241738
			// (set) Token: 0x06007F5F RID: 32607 RVA: 0x0004484A File Offset: 0x00042A4A
			public unsafe float _fadeDurationForOneNPCCG_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__fadeDurationForOneNPCCG_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__fadeDurationForOneNPCCG_5__5)) = value;
				}
			}

			// Token: 0x17002AF9 RID: 11001
			// (get) Token: 0x06007F60 RID: 32608 RVA: 0x00243560 File Offset: 0x00241760
			// (set) Token: 0x06007F61 RID: 32609 RVA: 0x00044865 File Offset: 0x00042A65
			public unsafe float _fadeDurationForOneStaffCG_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__fadeDurationForOneStaffCG_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__fadeDurationForOneStaffCG_5__6)) = value;
				}
			}

			// Token: 0x17002AFA RID: 11002
			// (get) Token: 0x06007F62 RID: 32610 RVA: 0x00243588 File Offset: 0x00241788
			// (set) Token: 0x06007F63 RID: 32611 RVA: 0x00044880 File Offset: 0x00042A80
			public unsafe float _stayDurationForOneNPCCG_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__stayDurationForOneNPCCG_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__stayDurationForOneNPCCG_5__7)) = value;
				}
			}

			// Token: 0x17002AFB RID: 11003
			// (get) Token: 0x06007F64 RID: 32612 RVA: 0x002435B0 File Offset: 0x002417B0
			// (set) Token: 0x06007F65 RID: 32613 RVA: 0x0004489B File Offset: 0x00042A9B
			public unsafe float _stayDurationForOneStaffCG_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__stayDurationForOneStaffCG_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr__stayDurationForOneStaffCG_5__8)) = value;
				}
			}

			// Token: 0x17002AFC RID: 11004
			// (get) Token: 0x06007F66 RID: 32614 RVA: 0x002435D8 File Offset: 0x002417D8
			// (set) Token: 0x06007F67 RID: 32615 RVA: 0x000448B6 File Offset: 0x00042AB6
			public List<CanvasGroup>.Enumerator __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___7__wrap8);
					return new List<CanvasGroup>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<CanvasGroup>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___7__wrap8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<CanvasGroup>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002AFD RID: 11005
			// (get) Token: 0x06007F68 RID: 32616 RVA: 0x00243608 File Offset: 0x00241808
			// (set) Token: 0x06007F69 RID: 32617 RVA: 0x000448E4 File Offset: 0x00042AE4
			public unsafe Il2CppReferenceArray<CanvasGroup> __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___7__wrap9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___7__wrap9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AFE RID: 11006
			// (get) Token: 0x06007F6A RID: 32618 RVA: 0x00243638 File Offset: 0x00241838
			// (set) Token: 0x06007F6B RID: 32619 RVA: 0x00044903 File Offset: 0x00042B03
			public unsafe int __7__wrap10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___7__wrap10);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._OnDisplayingData_d__39.NativeFieldInfoPtr___7__wrap10)) = value;
				}
			}

			// Token: 0x040053A5 RID: 21413
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040053A6 RID: 21414
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040053A7 RID: 21415
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040053A8 RID: 21416
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040053A9 RID: 21417
			private static readonly IntPtr NativeFieldInfoPtr_selectedBGMLength;

			// Token: 0x040053AA RID: 21418
			private static readonly IntPtr NativeFieldInfoPtr__allValidNPCCGPages_5__2;

			// Token: 0x040053AB RID: 21419
			private static readonly IntPtr NativeFieldInfoPtr__edCGDuration_5__3;

			// Token: 0x040053AC RID: 21420
			private static readonly IntPtr NativeFieldInfoPtr__edCGTransitionDuration_5__4;

			// Token: 0x040053AD RID: 21421
			private static readonly IntPtr NativeFieldInfoPtr__fadeDurationForOneNPCCG_5__5;

			// Token: 0x040053AE RID: 21422
			private static readonly IntPtr NativeFieldInfoPtr__fadeDurationForOneStaffCG_5__6;

			// Token: 0x040053AF RID: 21423
			private static readonly IntPtr NativeFieldInfoPtr__stayDurationForOneNPCCG_5__7;

			// Token: 0x040053B0 RID: 21424
			private static readonly IntPtr NativeFieldInfoPtr__stayDurationForOneStaffCG_5__8;

			// Token: 0x040053B1 RID: 21425
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x040053B2 RID: 21426
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x040053B3 RID: 21427
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap10;

			// Token: 0x040053B4 RID: 21428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040053B5 RID: 21429
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040053B6 RID: 21430
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040053B7 RID: 21431
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040053B8 RID: 21432
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040053B9 RID: 21433
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040053BA RID: 21434
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020004B8 RID: 1208
		[ObfuscatedName("StaffScene.SceneManager+<<OnDisplayingData>g__DisplayData|39_1>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique : Il2CppSystem.Object
		{
			// Token: 0x06007F6C RID: 32620 RVA: 0x00243660 File Offset: 0x00241860
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique()
			{
				Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<<OnDisplayingData>g__DisplayData|39_1>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, "<>1__state");
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, "<>2__current");
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, "canvasGroup");
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, "transition");
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, "display");
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, "<>8__1");
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_onBeforeFadeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, "onBeforeFadeCallback");
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, 100664094);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, 100664095);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, 100664096);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, 100664097);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, 100664098);
				SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr, 100664099);
			}

			// Token: 0x06007F6D RID: 32621 RVA: 0x00243790 File Offset: 0x00241990
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F6E RID: 32622 RVA: 0x002437D8 File Offset: 0x002419D8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F6F RID: 32623 RVA: 0x0024380C File Offset: 0x00241A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24835, XrefRangeEnd = 24865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002B08 RID: 11016
			// (get) Token: 0x06007F70 RID: 32624 RVA: 0x00243848 File Offset: 0x00241A48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007F71 RID: 32625 RVA: 0x00243888 File Offset: 0x00241A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24865, XrefRangeEnd = 24871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B09 RID: 11017
			// (get) Token: 0x06007F72 RID: 32626 RVA: 0x002438BC File Offset: 0x00241ABC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007F73 RID: 32627 RVA: 0x0004491E File Offset: 0x00042B1E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002B01 RID: 11009
			// (get) Token: 0x06007F74 RID: 32628 RVA: 0x002438FC File Offset: 0x00241AFC
			// (set) Token: 0x06007F75 RID: 32629 RVA: 0x00044927 File Offset: 0x00042B27
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B02 RID: 11010
			// (get) Token: 0x06007F76 RID: 32630 RVA: 0x00243924 File Offset: 0x00241B24
			// (set) Token: 0x06007F77 RID: 32631 RVA: 0x00044942 File Offset: 0x00042B42
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B03 RID: 11011
			// (get) Token: 0x06007F78 RID: 32632 RVA: 0x00243954 File Offset: 0x00241B54
			// (set) Token: 0x06007F79 RID: 32633 RVA: 0x00044961 File Offset: 0x00042B61
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B04 RID: 11012
			// (get) Token: 0x06007F7A RID: 32634 RVA: 0x00243984 File Offset: 0x00241B84
			// (set) Token: 0x06007F7B RID: 32635 RVA: 0x00044980 File Offset: 0x00042B80
			public unsafe float transition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_transition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_transition)) = value;
				}
			}

			// Token: 0x17002B05 RID: 11013
			// (get) Token: 0x06007F7C RID: 32636 RVA: 0x002439AC File Offset: 0x00241BAC
			// (set) Token: 0x06007F7D RID: 32637 RVA: 0x0004499B File Offset: 0x00042B9B
			public unsafe float display
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_display);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_display)) = value;
				}
			}

			// Token: 0x17002B06 RID: 11014
			// (get) Token: 0x06007F7E RID: 32638 RVA: 0x002439D4 File Offset: 0x00241BD4
			// (set) Token: 0x06007F7F RID: 32639 RVA: 0x000449B6 File Offset: 0x00042BB6
			public unsafe SceneManager.__c__DisplayClass39_1 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c__DisplayClass39_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B07 RID: 11015
			// (get) Token: 0x06007F80 RID: 32640 RVA: 0x00243A04 File Offset: 0x00241C04
			// (set) Token: 0x06007F81 RID: 32641 RVA: 0x000449D5 File Offset: 0x00042BD5
			public unsafe Action onBeforeFadeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_onBeforeFadeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCacaSitrdiSiAconUnique.NativeFieldInfoPtr_onBeforeFadeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040053BB RID: 21435
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040053BC RID: 21436
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040053BD RID: 21437
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x040053BE RID: 21438
			private static readonly IntPtr NativeFieldInfoPtr_transition;

			// Token: 0x040053BF RID: 21439
			private static readonly IntPtr NativeFieldInfoPtr_display;

			// Token: 0x040053C0 RID: 21440
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040053C1 RID: 21441
			private static readonly IntPtr NativeFieldInfoPtr_onBeforeFadeCallback;

			// Token: 0x040053C2 RID: 21442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040053C3 RID: 21443
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040053C4 RID: 21444
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040053C5 RID: 21445
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040053C6 RID: 21446
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040053C7 RID: 21447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
