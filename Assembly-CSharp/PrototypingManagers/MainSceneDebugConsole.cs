using System;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace PrototypingManagers
{
	// Token: 0x0200004C RID: 76
	public class MainSceneDebugConsole : DebugConsoleBase
	{
		// Token: 0x06000935 RID: 2357 RVA: 0x000BAF6C File Offset: 0x000B916C
		// Note: this type is marked as 'beforefieldinit'.
		static MainSceneDebugConsole()
		{
			Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "MainSceneDebugConsole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr);
			MainSceneDebugConsole.NativeFieldInfoPtr_isIzakayaSkinSelectionExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "isIzakayaSkinSelectionExpanded");
			MainSceneDebugConsole.NativeFieldInfoPtr_isExpandedCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "isExpandedCharacter");
			MainSceneDebugConsole.NativeFieldInfoPtr_isExpandedJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "isExpandedJob");
			MainSceneDebugConsole.NativeFieldInfoPtr_selections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "selections");
			MainSceneDebugConsole.NativeFieldInfoPtr_availableIzakayaSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "availableIzakayaSelections");
			MainSceneDebugConsole.NativeFieldInfoPtr_availablePartnerSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "availablePartnerSelections");
			MainSceneDebugConsole.NativeFieldInfoPtr_availableskinSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "availableskinSelections");
			MainSceneDebugConsole.NativeFieldInfoPtr_currentLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "currentLanguage");
			MainSceneDebugConsole.NativeFieldInfoPtr_currentPannelScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "currentPannelScroll");
			MainSceneDebugConsole.NativeFieldInfoPtr_isIzakayaSelectionExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "isIzakayaSelectionExpanded");
			MainSceneDebugConsole.NativeFieldInfoPtr_isLanguageSetExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "isLanguageSetExpanded");
			MainSceneDebugConsole.NativeFieldInfoPtr_isNewGameModeExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "isNewGameModeExpanded");
			MainSceneDebugConsole.NativeFieldInfoPtr_isSkinExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "isSkinExpanded");
			MainSceneDebugConsole.NativeFieldInfoPtr_izakayaSkinSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "izakayaSkinSelection");
			MainSceneDebugConsole.NativeFieldInfoPtr_skinSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "skinSelection");
			MainSceneDebugConsole.NativeFieldInfoPtr_tempIzakayaSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "tempIzakayaSelection");
			MainSceneDebugConsole.NativeFieldInfoPtr_useAllDecorations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "useAllDecorations");
			MainSceneDebugConsole.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, 100664772);
			MainSceneDebugConsole.NativeMethodInfoPtr_GetIzakayaOptions_Public_Static_Il2CppStructArray_1_TempIzakayaSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, 100664773);
			MainSceneDebugConsole.NativeMethodInfoPtr_GetSkinOptions_Public_Static_Il2CppStructArray_1_SkinSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, 100664774);
			MainSceneDebugConsole.NativeMethodInfoPtr_GetPartnerSelections_Public_Static_Il2CppStructArray_1_PartnerCharacterSelections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, 100664775);
			MainSceneDebugConsole.NativeMethodInfoPtr_OnStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, 100664776);
			MainSceneDebugConsole.NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, 100664777);
			MainSceneDebugConsole.NativeMethodInfoPtr_GotoTestWorkScene_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, 100664778);
			MainSceneDebugConsole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, 100664779);
			MainSceneDebugConsole.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, 100664780);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000BB1A4 File Offset: 0x000B93A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37160, XrefRangeEnd = 37173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000BB1D8 File Offset: 0x000B93D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37280, RefRangeEnd = 37282, XrefRangeStart = 37173, XrefRangeEnd = 37280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<MainSceneDebugConsole.TempIzakayaSelection> GetIzakayaOptions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.NativeMethodInfoPtr_GetIzakayaOptions_Public_Static_Il2CppStructArray_1_TempIzakayaSelection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MainSceneDebugConsole.TempIzakayaSelection>>(intPtr3) : null;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000BB20C File Offset: 0x000B940C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37373, RefRangeEnd = 37375, XrefRangeStart = 37282, XrefRangeEnd = 37373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<MainSceneDebugConsole.SkinSelection> GetSkinOptions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.NativeMethodInfoPtr_GetSkinOptions_Public_Static_Il2CppStructArray_1_SkinSelection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MainSceneDebugConsole.SkinSelection>>(intPtr3) : null;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000BB240 File Offset: 0x000B9440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37452, RefRangeEnd = 37454, XrefRangeStart = 37375, XrefRangeEnd = 37452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<MainSceneDebugConsole.PartnerCharacterSelections> GetPartnerSelections()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.NativeMethodInfoPtr_GetPartnerSelections_Public_Static_Il2CppStructArray_1_PartnerCharacterSelections_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MainSceneDebugConsole.PartnerCharacterSelections>>(intPtr3) : null;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000BB274 File Offset: 0x000B9474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37454, XrefRangeEnd = 37581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainSceneDebugConsole.NativeMethodInfoPtr_OnStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000BB2B0 File Offset: 0x000B94B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37581, XrefRangeEnd = 37805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrawDebugConsole()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainSceneDebugConsole.NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000BB2EC File Offset: 0x000B94EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37805, XrefRangeEnd = 37885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GotoTestWorkScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.NativeMethodInfoPtr_GotoTestWorkScene_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000BB320 File Offset: 0x000B9520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37885, XrefRangeEnd = 37904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainSceneDebugConsole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000BB35C File Offset: 0x000B955C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37904, XrefRangeEnd = 38003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0000750D File Offset: 0x0000570D
		public MainSceneDebugConsole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x000BB390 File Offset: 0x000B9590
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x00007516 File Offset: 0x00005716
		public unsafe bool isIzakayaSkinSelectionExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isIzakayaSkinSelectionExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isIzakayaSkinSelectionExpanded)) = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x000BB3B8 File Offset: 0x000B95B8
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00007531 File Offset: 0x00005731
		public unsafe Il2CppStructArray<bool> isExpandedCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isExpandedCharacter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isExpandedCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x000BB3E8 File Offset: 0x000B95E8
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00007550 File Offset: 0x00005750
		public unsafe Il2CppStructArray<bool> isExpandedJob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isExpandedJob);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isExpandedJob), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x000BB418 File Offset: 0x000B9618
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x0000756F File Offset: 0x0000576F
		public unsafe Il2CppReferenceArray<ValueTuple<MainSceneDebugConsole.PartnerCharacterSelections, MainSceneDebugConsole.PartnerSelections>> selections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_selections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<MainSceneDebugConsole.PartnerCharacterSelections, MainSceneDebugConsole.PartnerSelections>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_selections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x000BB448 File Offset: 0x000B9648
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x0000758E File Offset: 0x0000578E
		public unsafe Dictionary<MainSceneDebugConsole.TempIzakayaSelection, string> availableIzakayaSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_availableIzakayaSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MainSceneDebugConsole.TempIzakayaSelection, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_availableIzakayaSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x000BB478 File Offset: 0x000B9678
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x000075AD File Offset: 0x000057AD
		public unsafe Dictionary<MainSceneDebugConsole.PartnerCharacterSelections, string> availablePartnerSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_availablePartnerSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MainSceneDebugConsole.PartnerCharacterSelections, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_availablePartnerSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x000BB4A8 File Offset: 0x000B96A8
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x000075CC File Offset: 0x000057CC
		public unsafe Dictionary<MainSceneDebugConsole.SkinSelection, string> availableskinSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_availableskinSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MainSceneDebugConsole.SkinSelection, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_availableskinSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x000BB4D8 File Offset: 0x000B96D8
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x000075EB File Offset: 0x000057EB
		public unsafe MultiLanguageTextMesh.LoadLanguageType currentLanguage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_currentLanguage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_currentLanguage)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x000BB500 File Offset: 0x000B9700
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00007606 File Offset: 0x00005806
		public unsafe Vector2 currentPannelScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_currentPannelScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_currentPannelScroll)) = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x000BB528 File Offset: 0x000B9728
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00007621 File Offset: 0x00005821
		public unsafe bool isIzakayaSelectionExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isIzakayaSelectionExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isIzakayaSelectionExpanded)) = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x000BB550 File Offset: 0x000B9750
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x0000763C File Offset: 0x0000583C
		public unsafe bool isLanguageSetExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isLanguageSetExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isLanguageSetExpanded)) = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x000BB578 File Offset: 0x000B9778
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00007657 File Offset: 0x00005857
		public unsafe bool isNewGameModeExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isNewGameModeExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isNewGameModeExpanded)) = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x000BB5A0 File Offset: 0x000B97A0
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x00007672 File Offset: 0x00005872
		public unsafe bool isSkinExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isSkinExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_isSkinExpanded)) = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x000BB5C8 File Offset: 0x000B97C8
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x0000768D File Offset: 0x0000588D
		public unsafe MainSceneDebugConsole.IzakayaSkinSelections izakayaSkinSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_izakayaSkinSelection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_izakayaSkinSelection)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x000BB5F0 File Offset: 0x000B97F0
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x000076A8 File Offset: 0x000058A8
		public unsafe MainSceneDebugConsole.SkinSelection skinSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_skinSelection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_skinSelection)) = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x000BB618 File Offset: 0x000B9818
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x000076C3 File Offset: 0x000058C3
		public unsafe MainSceneDebugConsole.TempIzakayaSelection tempIzakayaSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_tempIzakayaSelection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_tempIzakayaSelection)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x000BB640 File Offset: 0x000B9840
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x000076DE File Offset: 0x000058DE
		public unsafe bool useAllDecorations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_useAllDecorations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainSceneDebugConsole.NativeFieldInfoPtr_useAllDecorations)) = value;
			}
		}

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeFieldInfoPtr_isIzakayaSkinSelectionExpanded;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr_isExpandedCharacter;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr_isExpandedJob;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeFieldInfoPtr_selections;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_availableIzakayaSelections;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr_availablePartnerSelections;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr_availableskinSelections;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeFieldInfoPtr_currentLanguage;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeFieldInfoPtr_currentPannelScroll;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeFieldInfoPtr_isIzakayaSelectionExpanded;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_isLanguageSetExpanded;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_isNewGameModeExpanded;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_isSkinExpanded;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_izakayaSkinSelection;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_skinSelection;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_tempIzakayaSelection;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_useAllDecorations;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_GetIzakayaOptions_Public_Static_Il2CppStructArray_1_TempIzakayaSelection_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_GetSkinOptions_Public_Static_Il2CppStructArray_1_SkinSelection_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerSelections_Public_Static_Il2CppStructArray_1_PartnerCharacterSelections_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_OnStart_Protected_Virtual_Void_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Virtual_Void_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_GotoTestWorkScene_Private_Void_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x0200050A RID: 1290
		public enum IzakayaSkinSelections
		{
			// Token: 0x0400567C RID: 22140
			Constant = -1,
			// Token: 0x0400567D RID: 22141
			Constant = 54,
			// Token: 0x0400567E RID: 22142
			Constant = 59,
			// Token: 0x0400567F RID: 22143
			Constant = 57
		}

		// Token: 0x0200050B RID: 1291
		public enum PartnerCharacterSelections
		{
			// Token: 0x04005681 RID: 22145
			None,
			// Token: 0x04005682 RID: 22146
			Constant = 14,
			// Token: 0x04005683 RID: 22147
			Constant = 18,
			// Token: 0x04005684 RID: 22148
			Constant,
			// Token: 0x04005685 RID: 22149
			Constant,
			// Token: 0x04005686 RID: 22150
			Constant,
			// Token: 0x04005687 RID: 22151
			Constant = 39,
			// Token: 0x04005688 RID: 22152
			Constant = 1006,
			// Token: 0x04005689 RID: 22153
			Constant,
			// Token: 0x0400568A RID: 22154
			Constant = 2008,
			// Token: 0x0400568B RID: 22155
			Constant = 2007,
			// Token: 0x0400568C RID: 22156
			Constant = 3006,
			// Token: 0x0400568D RID: 22157
			Constant = 3008,
			// Token: 0x0400568E RID: 22158
			Constant = 4009,
			// Token: 0x0400568F RID: 22159
			Constant,
			// Token: 0x04005690 RID: 22160
			Constant = 5006,
			// Token: 0x04005691 RID: 22161
			Constant
		}

		// Token: 0x0200050C RID: 1292
		public enum PartnerSelections
		{
			// Token: 0x04005693 RID: 22163
			None,
			// Token: 0x04005694 RID: 22164
			Constant,
			// Token: 0x04005695 RID: 22165
			Constant,
			// Token: 0x04005696 RID: 22166
			Constant,
			// Token: 0x04005697 RID: 22167
			BOSS
		}

		// Token: 0x0200050D RID: 1293
		public enum SkinSelection
		{
			// Token: 0x04005699 RID: 22169
			Constant = -1,
			// Token: 0x0400569A RID: 22170
			Constant = -2,
			// Token: 0x0400569B RID: 22171
			Constant = 23,
			// Token: 0x0400569C RID: 22172
			Constant,
			// Token: 0x0400569D RID: 22173
			Constant,
			// Token: 0x0400569E RID: 22174
			Constant,
			// Token: 0x0400569F RID: 22175
			Constant,
			// Token: 0x040056A0 RID: 22176
			Constant = 31,
			// Token: 0x040056A1 RID: 22177
			Constant = 54,
			// Token: 0x040056A2 RID: 22178
			Constant = 56,
			// Token: 0x040056A3 RID: 22179
			Constant,
			// Token: 0x040056A4 RID: 22180
			Constant,
			// Token: 0x040056A5 RID: 22181
			Constant,
			// Token: 0x040056A6 RID: 22182
			Constant = 1001,
			// Token: 0x040056A7 RID: 22183
			Constant,
			// Token: 0x040056A8 RID: 22184
			Constant = 2001,
			// Token: 0x040056A9 RID: 22185
			Constant,
			// Token: 0x040056AA RID: 22186
			Constant = 2500
		}

		// Token: 0x0200050E RID: 1294
		public enum TempIzakayaSelection
		{
			// Token: 0x040056AC RID: 22188
			Constant,
			// Token: 0x040056AD RID: 22189
			Constant,
			// Token: 0x040056AE RID: 22190
			Constant,
			// Token: 0x040056AF RID: 22191
			Constant,
			// Token: 0x040056B0 RID: 22192
			Constant,
			// Token: 0x040056B1 RID: 22193
			Constant,
			// Token: 0x040056B2 RID: 22194
			Constant,
			// Token: 0x040056B3 RID: 22195
			Constant,
			// Token: 0x040056B4 RID: 22196
			Constant,
			// Token: 0x040056B5 RID: 22197
			Constant,
			// Token: 0x040056B6 RID: 22198
			Constant,
			// Token: 0x040056B7 RID: 22199
			Constant,
			// Token: 0x040056B8 RID: 22200
			Constant,
			// Token: 0x040056B9 RID: 22201
			Constant = 14,
			// Token: 0x040056BA RID: 22202
			Constant,
			// Token: 0x040056BB RID: 22203
			Constant,
			// Token: 0x040056BC RID: 22204
			Constant = 18,
			// Token: 0x040056BD RID: 22205
			Constant,
			// Token: 0x040056BE RID: 22206
			Constant = 13,
			// Token: 0x040056BF RID: 22207
			Constant = 17,
			// Token: 0x040056C0 RID: 22208
			Constant = 1000,
			// Token: 0x040056C1 RID: 22209
			Constant,
			// Token: 0x040056C2 RID: 22210
			Constant,
			// Token: 0x040056C3 RID: 22211
			Constant,
			// Token: 0x040056C4 RID: 22212
			Constant,
			// Token: 0x040056C5 RID: 22213
			Constant,
			// Token: 0x040056C6 RID: 22214
			Constant,
			// Token: 0x040056C7 RID: 22215
			Constant = 2000,
			// Token: 0x040056C8 RID: 22216
			Constant,
			// Token: 0x040056C9 RID: 22217
			Constant,
			// Token: 0x040056CA RID: 22218
			Constant,
			// Token: 0x040056CB RID: 22219
			Constant,
			// Token: 0x040056CC RID: 22220
			Constant,
			// Token: 0x040056CD RID: 22221
			Constant,
			// Token: 0x040056CE RID: 22222
			Constant = 3000,
			// Token: 0x040056CF RID: 22223
			Constant,
			// Token: 0x040056D0 RID: 22224
			Constant,
			// Token: 0x040056D1 RID: 22225
			Constant,
			// Token: 0x040056D2 RID: 22226
			Constant,
			// Token: 0x040056D3 RID: 22227
			Constant,
			// Token: 0x040056D4 RID: 22228
			Constant,
			// Token: 0x040056D5 RID: 22229
			Constant = 4000,
			// Token: 0x040056D6 RID: 22230
			Constant,
			// Token: 0x040056D7 RID: 22231
			Constant,
			// Token: 0x040056D8 RID: 22232
			Constant,
			// Token: 0x040056D9 RID: 22233
			Constant,
			// Token: 0x040056DA RID: 22234
			Constant
		}

		// Token: 0x0200050F RID: 1295
		[ObfuscatedName("PrototypingManagers.MainSceneDebugConsole+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008409 RID: 33801 RVA: 0x00250FF0 File Offset: 0x0024F1F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainSceneDebugConsole>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr);
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__24_0");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__26_0");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__26_1");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__26_2");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__26_3");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__26_4");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__26_5");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__28_0");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__28_5");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__28_2");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__28_3");
				MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, "<>9__28_4");
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664782);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__GetSkinOptions_b__24_0_Internal_SkinSelection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664783);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_0_Internal_TempIzakayaSelection_TempIzakayaSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664784);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_1_Internal_String_TempIzakayaSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664785);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_2_Internal_PartnerCharacterSelections_PartnerCharacterSelections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664786);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_3_Internal_String_PartnerCharacterSelections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664787);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_4_Internal_SkinSelection_SkinSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664788);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_5_Internal_String_SkinSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664789);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__28_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664790);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__28_2_Internal_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664791);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__28_5_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664792);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__28_3_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664793);
				MainSceneDebugConsole.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__28_4_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr, 100664794);
			}

			// Token: 0x0600840A RID: 33802 RVA: 0x00251224 File Offset: 0x0024F424
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainSceneDebugConsole.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600840B RID: 33803 RVA: 0x00251260 File Offset: 0x0024F460
			[CallerCount(0)]
			public unsafe MainSceneDebugConsole.SkinSelection _GetSkinOptions_b__24_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__GetSkinOptions_b__24_0_Internal_SkinSelection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600840C RID: 33804 RVA: 0x002512AC File Offset: 0x0024F4AC
			[CallerCount(0)]
			public unsafe MainSceneDebugConsole.TempIzakayaSelection _OnStart_b__26_0(MainSceneDebugConsole.TempIzakayaSelection x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_0_Internal_TempIzakayaSelection_TempIzakayaSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600840D RID: 33805 RVA: 0x002512F8 File Offset: 0x0024F4F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37098, XrefRangeEnd = 37111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnStart_b__26_1(MainSceneDebugConsole.TempIzakayaSelection x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_1_Internal_String_TempIzakayaSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600840E RID: 33806 RVA: 0x0025133C File Offset: 0x0024F53C
			[CallerCount(0)]
			public unsafe MainSceneDebugConsole.PartnerCharacterSelections _OnStart_b__26_2(MainSceneDebugConsole.PartnerCharacterSelections x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_2_Internal_PartnerCharacterSelections_PartnerCharacterSelections_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600840F RID: 33807 RVA: 0x00251388 File Offset: 0x0024F588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37111, XrefRangeEnd = 37124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnStart_b__26_3(MainSceneDebugConsole.PartnerCharacterSelections x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_3_Internal_String_PartnerCharacterSelections_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008410 RID: 33808 RVA: 0x002513CC File Offset: 0x0024F5CC
			[CallerCount(0)]
			public unsafe MainSceneDebugConsole.SkinSelection _OnStart_b__26_4(MainSceneDebugConsole.SkinSelection x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_4_Internal_SkinSelection_SkinSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008411 RID: 33809 RVA: 0x00251418 File Offset: 0x0024F618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37124, XrefRangeEnd = 37137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnStart_b__26_5(MainSceneDebugConsole.SkinSelection x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__OnStart_b__26_5_Internal_String_SkinSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008412 RID: 33810 RVA: 0x0025145C File Offset: 0x0024F65C
			[CallerCount(0)]
			public unsafe bool _GotoTestWorkScene_b__28_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__28_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008413 RID: 33811 RVA: 0x002514A8 File Offset: 0x0024F6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37137, XrefRangeEnd = 37160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _GotoTestWorkScene_b__28_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__28_2_Internal_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06008414 RID: 33812 RVA: 0x002514F4 File Offset: 0x0024F6F4
			[CallerCount(0)]
			public unsafe IEnumerable<int> _GotoTestWorkScene_b__28_5(Il2CppStructArray<int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__28_5_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06008415 RID: 33813 RVA: 0x00251544 File Offset: 0x0024F744
			[CallerCount(0)]
			public unsafe IEnumerable<int> _GotoTestWorkScene_b__28_3(IEnumerable<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__28_3_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06008416 RID: 33814 RVA: 0x00251594 File Offset: 0x0024F794
			[CallerCount(0)]
			public unsafe IEnumerable<int> _GotoTestWorkScene_b__28_4(IEnumerable<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugConsole.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__28_4_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06008417 RID: 33815 RVA: 0x0004728C File Offset: 0x0004548C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C5F RID: 11359
			// (get) Token: 0x06008418 RID: 33816 RVA: 0x002515E4 File Offset: 0x0024F7E4
			// (set) Token: 0x06008419 RID: 33817 RVA: 0x00047295 File Offset: 0x00045495
			public unsafe static MainSceneDebugConsole.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainSceneDebugConsole.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C60 RID: 11360
			// (get) Token: 0x0600841A RID: 33818 RVA: 0x0025160C File Offset: 0x0024F80C
			// (set) Token: 0x0600841B RID: 33819 RVA: 0x000472A7 File Offset: 0x000454A7
			public unsafe static Func<int, MainSceneDebugConsole.SkinSelection> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, MainSceneDebugConsole.SkinSelection>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C61 RID: 11361
			// (get) Token: 0x0600841C RID: 33820 RVA: 0x00251634 File Offset: 0x0024F834
			// (set) Token: 0x0600841D RID: 33821 RVA: 0x000472B9 File Offset: 0x000454B9
			public unsafe static Func<MainSceneDebugConsole.TempIzakayaSelection, MainSceneDebugConsole.TempIzakayaSelection> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.TempIzakayaSelection, MainSceneDebugConsole.TempIzakayaSelection>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C62 RID: 11362
			// (get) Token: 0x0600841E RID: 33822 RVA: 0x0025165C File Offset: 0x0024F85C
			// (set) Token: 0x0600841F RID: 33823 RVA: 0x000472CB File Offset: 0x000454CB
			public unsafe static Func<MainSceneDebugConsole.TempIzakayaSelection, string> __9__26_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.TempIzakayaSelection, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C63 RID: 11363
			// (get) Token: 0x06008420 RID: 33824 RVA: 0x00251684 File Offset: 0x0024F884
			// (set) Token: 0x06008421 RID: 33825 RVA: 0x000472DD File Offset: 0x000454DD
			public unsafe static Func<MainSceneDebugConsole.PartnerCharacterSelections, MainSceneDebugConsole.PartnerCharacterSelections> __9__26_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.PartnerCharacterSelections, MainSceneDebugConsole.PartnerCharacterSelections>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C64 RID: 11364
			// (get) Token: 0x06008422 RID: 33826 RVA: 0x002516AC File Offset: 0x0024F8AC
			// (set) Token: 0x06008423 RID: 33827 RVA: 0x000472EF File Offset: 0x000454EF
			public unsafe static Func<MainSceneDebugConsole.PartnerCharacterSelections, string> __9__26_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.PartnerCharacterSelections, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C65 RID: 11365
			// (get) Token: 0x06008424 RID: 33828 RVA: 0x002516D4 File Offset: 0x0024F8D4
			// (set) Token: 0x06008425 RID: 33829 RVA: 0x00047301 File Offset: 0x00045501
			public unsafe static Func<MainSceneDebugConsole.SkinSelection, MainSceneDebugConsole.SkinSelection> __9__26_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.SkinSelection, MainSceneDebugConsole.SkinSelection>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C66 RID: 11366
			// (get) Token: 0x06008426 RID: 33830 RVA: 0x002516FC File Offset: 0x0024F8FC
			// (set) Token: 0x06008427 RID: 33831 RVA: 0x00047313 File Offset: 0x00045513
			public unsafe static Func<MainSceneDebugConsole.SkinSelection, string> __9__26_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.SkinSelection, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__26_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C67 RID: 11367
			// (get) Token: 0x06008428 RID: 33832 RVA: 0x00251724 File Offset: 0x0024F924
			// (set) Token: 0x06008429 RID: 33833 RVA: 0x00047325 File Offset: 0x00045525
			public unsafe static Func<int, bool> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C68 RID: 11368
			// (get) Token: 0x0600842A RID: 33834 RVA: 0x0025174C File Offset: 0x0024F94C
			// (set) Token: 0x0600842B RID: 33835 RVA: 0x00047337 File Offset: 0x00045537
			public unsafe static Func<Il2CppStructArray<int>, IEnumerable<int>> __9__28_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C69 RID: 11369
			// (get) Token: 0x0600842C RID: 33836 RVA: 0x00251774 File Offset: 0x0024F974
			// (set) Token: 0x0600842D RID: 33837 RVA: 0x00047349 File Offset: 0x00045549
			public unsafe static Func<int, IEnumerable<int>> __9__28_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C6A RID: 11370
			// (get) Token: 0x0600842E RID: 33838 RVA: 0x0025179C File Offset: 0x0024F99C
			// (set) Token: 0x0600842F RID: 33839 RVA: 0x0004735B File Offset: 0x0004555B
			public unsafe static Func<IEnumerable<int>, IEnumerable<int>> __9__28_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C6B RID: 11371
			// (get) Token: 0x06008430 RID: 33840 RVA: 0x002517C4 File Offset: 0x0024F9C4
			// (set) Token: 0x06008431 RID: 33841 RVA: 0x0004736D File Offset: 0x0004556D
			public unsafe static Func<IEnumerable<int>, IEnumerable<int>> __9__28_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugConsole.__c.NativeFieldInfoPtr___9__28_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040056DB RID: 22235
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040056DC RID: 22236
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x040056DD RID: 22237
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x040056DE RID: 22238
			private static readonly IntPtr NativeFieldInfoPtr___9__26_1;

			// Token: 0x040056DF RID: 22239
			private static readonly IntPtr NativeFieldInfoPtr___9__26_2;

			// Token: 0x040056E0 RID: 22240
			private static readonly IntPtr NativeFieldInfoPtr___9__26_3;

			// Token: 0x040056E1 RID: 22241
			private static readonly IntPtr NativeFieldInfoPtr___9__26_4;

			// Token: 0x040056E2 RID: 22242
			private static readonly IntPtr NativeFieldInfoPtr___9__26_5;

			// Token: 0x040056E3 RID: 22243
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x040056E4 RID: 22244
			private static readonly IntPtr NativeFieldInfoPtr___9__28_5;

			// Token: 0x040056E5 RID: 22245
			private static readonly IntPtr NativeFieldInfoPtr___9__28_2;

			// Token: 0x040056E6 RID: 22246
			private static readonly IntPtr NativeFieldInfoPtr___9__28_3;

			// Token: 0x040056E7 RID: 22247
			private static readonly IntPtr NativeFieldInfoPtr___9__28_4;

			// Token: 0x040056E8 RID: 22248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040056E9 RID: 22249
			private static readonly IntPtr NativeMethodInfoPtr__GetSkinOptions_b__24_0_Internal_SkinSelection_Int32_0;

			// Token: 0x040056EA RID: 22250
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__26_0_Internal_TempIzakayaSelection_TempIzakayaSelection_0;

			// Token: 0x040056EB RID: 22251
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__26_1_Internal_String_TempIzakayaSelection_0;

			// Token: 0x040056EC RID: 22252
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__26_2_Internal_PartnerCharacterSelections_PartnerCharacterSelections_0;

			// Token: 0x040056ED RID: 22253
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__26_3_Internal_String_PartnerCharacterSelections_0;

			// Token: 0x040056EE RID: 22254
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__26_4_Internal_SkinSelection_SkinSelection_0;

			// Token: 0x040056EF RID: 22255
			private static readonly IntPtr NativeMethodInfoPtr__OnStart_b__26_5_Internal_String_SkinSelection_0;

			// Token: 0x040056F0 RID: 22256
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__28_0_Internal_Boolean_Int32_0;

			// Token: 0x040056F1 RID: 22257
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__28_2_Internal_IEnumerable_1_Int32_Int32_0;

			// Token: 0x040056F2 RID: 22258
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__28_5_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0;

			// Token: 0x040056F3 RID: 22259
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__28_3_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0;

			// Token: 0x040056F4 RID: 22260
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__28_4_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0;
		}
	}
}
