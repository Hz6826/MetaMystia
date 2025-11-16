using System;
using Common;
using GameData;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace PrototypingManagers
{
	// Token: 0x0200004D RID: 77
	public static class MainSceneDebugImpl : Object
	{
		// Token: 0x06000962 RID: 2402 RVA: 0x000BB668 File Offset: 0x000B9868
		// Note: this type is marked as 'beforefieldinit'.
		static MainSceneDebugImpl()
		{
			Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "MainSceneDebugImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr);
			MainSceneDebugImpl.NativeFieldInfoPtr_m_PartnerSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, "m_PartnerSelections");
			MainSceneDebugImpl.NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664795);
			MainSceneDebugImpl.NativeMethodInfoPtr_UnRegisterMethod_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664796);
			MainSceneDebugImpl.NativeMethodInfoPtr_SetNewGameMode_Public_Static_Void_NewGameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664797);
			MainSceneDebugImpl.NativeMethodInfoPtr_SetGameLanguage_Public_Static_Void_LoadLanguageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664798);
			MainSceneDebugImpl.NativeMethodInfoPtr_GotoTestWorkScene_Public_Static_Void_TempIzakayaSelection_SkinSelection_IzakayaSkinSelections_PartnerCharacterSelections_PartnerSelections_PartnerCharacterSelections_PartnerSelections_PartnerCharacterSelections_PartnerSelections_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664799);
			MainSceneDebugImpl.NativeMethodInfoPtr_GotoTestResultScene_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664800);
			MainSceneDebugImpl.NativeMethodInfoPtr_GotoStaffScene_Public_Static_Void_StaffScenePlayBackIndicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664801);
			MainSceneDebugImpl.NativeMethodInfoPtr_GetIzakayaOptionsMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664802);
			MainSceneDebugImpl.NativeMethodInfoPtr_GetPlayerSkinOptionsMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664803);
			MainSceneDebugImpl.NativeMethodInfoPtr_GetPartnerSelectionsMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664804);
			MainSceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, 100664806);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000BB788 File Offset: 0x000B9988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38233, XrefRangeEnd = 38243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000BB7B0 File Offset: 0x000B99B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38243, XrefRangeEnd = 38267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_UnRegisterMethod_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000BB7D8 File Offset: 0x000B99D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38267, XrefRangeEnd = 38271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewGameMode(SaveManagement.NewGameMode mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_SetNewGameMode_Public_Static_Void_NewGameMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000BB80C File Offset: 0x000B9A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38271, XrefRangeEnd = 38272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGameLanguage(MultiLanguageTextMesh.LoadLanguageType language)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref language;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_SetGameLanguage_Public_Static_Void_LoadLanguageType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000BB840 File Offset: 0x000B9A40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38272, XrefRangeEnd = 38372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoTestWorkScene(MainSceneDebugConsole.TempIzakayaSelection izakaya, MainSceneDebugConsole.SkinSelection playerSkin, MainSceneDebugConsole.IzakayaSkinSelections izakayaSkin, MainSceneDebugConsole.PartnerCharacterSelections partner0, MainSceneDebugConsole.PartnerSelections job0, MainSceneDebugConsole.PartnerCharacterSelections partner1, MainSceneDebugConsole.PartnerSelections job1, MainSceneDebugConsole.PartnerCharacterSelections partner2, MainSceneDebugConsole.PartnerSelections job2, bool useAllDecorations)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref izakaya;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerSkin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref izakayaSkin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partner0;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref job0;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partner1;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref job1;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partner2;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref job2;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAllDecorations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_GotoTestWorkScene_Public_Static_Void_TempIzakayaSelection_SkinSelection_IzakayaSkinSelections_PartnerCharacterSelections_PartnerSelections_PartnerCharacterSelections_PartnerSelections_PartnerCharacterSelections_PartnerSelections_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000BB8F4 File Offset: 0x000B9AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38373, XrefRangeEnd = 38406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoTestResultScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_GotoTestResultScene_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000BB91C File Offset: 0x000B9B1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 38449, RefRangeEnd = 38456, XrefRangeStart = 38406, XrefRangeEnd = 38449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoStaffScene(SceneDirector.StaffScenePlayBackIndicator mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_GotoStaffScene_Public_Static_Void_StaffScenePlayBackIndicator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000BB950 File Offset: 0x000B9B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38456, XrefRangeEnd = 38490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> GetIzakayaOptionsMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_GetIzakayaOptionsMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000BB984 File Offset: 0x000B9B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38490, XrefRangeEnd = 38524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> GetPlayerSkinOptionsMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_GetPlayerSkinOptionsMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000BB9B8 File Offset: 0x000B9BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38524, XrefRangeEnd = 38558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> GetPartnerSelectionsMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_GetPartnerSelectionsMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000BB9EC File Offset: 0x000B9BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38558, XrefRangeEnd = 38559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000076F9 File Offset: 0x000058F9
		public MainSceneDebugImpl(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x000BBA1C File Offset: 0x000B9C1C
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x00007702 File Offset: 0x00005902
		public unsafe static Il2CppReferenceArray<ValueTuple<MainSceneDebugConsole.PartnerCharacterSelections, MainSceneDebugConsole.PartnerSelections>> m_PartnerSelections
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.NativeFieldInfoPtr_m_PartnerSelections, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<MainSceneDebugConsole.PartnerCharacterSelections, MainSceneDebugConsole.PartnerSelections>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.NativeFieldInfoPtr_m_PartnerSelections, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerSelections;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterMethod_Public_Static_Void_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_SetNewGameMode_Public_Static_Void_NewGameMode_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_SetGameLanguage_Public_Static_Void_LoadLanguageType_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_GotoTestWorkScene_Public_Static_Void_TempIzakayaSelection_SkinSelection_IzakayaSkinSelections_PartnerCharacterSelections_PartnerSelections_PartnerCharacterSelections_PartnerSelections_PartnerCharacterSelections_PartnerSelections_Boolean_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_GotoTestResultScene_Public_Static_Void_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffScene_Public_Static_Void_StaffScenePlayBackIndicator_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_GetIzakayaOptionsMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerSkinOptionsMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerSelectionsMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_PDM_0;

		// Token: 0x02000510 RID: 1296
		[ObfuscatedName("PrototypingManagers.MainSceneDebugImpl+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06008432 RID: 33842 RVA: 0x002517EC File Offset: 0x0024F9EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainSceneDebugImpl>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr);
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__5_0");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__5_5");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__5_2");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__5_3");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__5_4");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__5_1");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__6_0");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__7_0");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__8_0");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__8_1");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__9_0");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__9_1");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__10_0");
				MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, "<>9__10_1");
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664808);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664809);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664810);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_2_Internal_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664811);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_5_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664812);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_3_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664813);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_4_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664814);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestResultScene_b__6_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664815);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoStaffScene_b__7_0_Internal_String_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664816);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetIzakayaOptionsMapping_b__8_0_Internal_String_TempIzakayaSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664817);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetIzakayaOptionsMapping_b__8_1_Internal_Object_TempIzakayaSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664818);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetPlayerSkinOptionsMapping_b__9_0_Internal_String_SkinSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664819);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetPlayerSkinOptionsMapping_b__9_1_Internal_Object_SkinSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664820);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetPartnerSelectionsMapping_b__10_0_Internal_String_PartnerCharacterSelections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664821);
				MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetPartnerSelectionsMapping_b__10_1_Internal_Object_PartnerCharacterSelections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr, 100664822);
			}

			// Token: 0x06008433 RID: 33843 RVA: 0x00251A70 File Offset: 0x0024FC70
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainSceneDebugImpl.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008434 RID: 33844 RVA: 0x00251AAC File Offset: 0x0024FCAC
			[CallerCount(0)]
			public unsafe bool _GotoTestWorkScene_b__5_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008435 RID: 33845 RVA: 0x00251AF8 File Offset: 0x0024FCF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38003, XrefRangeEnd = 38106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GotoTestWorkScene_b__5_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008436 RID: 33846 RVA: 0x00251B2C File Offset: 0x0024FD2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38106, XrefRangeEnd = 38129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _GotoTestWorkScene_b__5_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_2_Internal_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06008437 RID: 33847 RVA: 0x00251B78 File Offset: 0x0024FD78
			[CallerCount(0)]
			public unsafe IEnumerable<int> _GotoTestWorkScene_b__5_5(Il2CppStructArray<int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_5_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06008438 RID: 33848 RVA: 0x00251BC8 File Offset: 0x0024FDC8
			[CallerCount(0)]
			public unsafe IEnumerable<int> _GotoTestWorkScene_b__5_3(IEnumerable<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_3_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06008439 RID: 33849 RVA: 0x00251C18 File Offset: 0x0024FE18
			[CallerCount(0)]
			public unsafe IEnumerable<int> _GotoTestWorkScene_b__5_4(IEnumerable<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestWorkScene_b__5_4_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600843A RID: 33850 RVA: 0x00251C68 File Offset: 0x0024FE68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38129, XrefRangeEnd = 38185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GotoTestResultScene_b__6_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoTestResultScene_b__6_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600843B RID: 33851 RVA: 0x00251C9C File Offset: 0x0024FE9C
			[CallerCount(0)]
			public unsafe string _GotoStaffScene_b__7_0(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GotoStaffScene_b__7_0_Internal_String_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600843C RID: 33852 RVA: 0x00251CE4 File Offset: 0x0024FEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38185, XrefRangeEnd = 38198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetIzakayaOptionsMapping_b__8_0(MainSceneDebugConsole.TempIzakayaSelection x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetIzakayaOptionsMapping_b__8_0_Internal_String_TempIzakayaSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600843D RID: 33853 RVA: 0x00251D28 File Offset: 0x0024FF28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38198, XrefRangeEnd = 38201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _GetIzakayaOptionsMapping_b__8_1(MainSceneDebugConsole.TempIzakayaSelection x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetIzakayaOptionsMapping_b__8_1_Internal_Object_TempIzakayaSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x0600843E RID: 33854 RVA: 0x00251D74 File Offset: 0x0024FF74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38201, XrefRangeEnd = 38214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetPlayerSkinOptionsMapping_b__9_0(MainSceneDebugConsole.SkinSelection x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetPlayerSkinOptionsMapping_b__9_0_Internal_String_SkinSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600843F RID: 33855 RVA: 0x00251DB8 File Offset: 0x0024FFB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38214, XrefRangeEnd = 38217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _GetPlayerSkinOptionsMapping_b__9_1(MainSceneDebugConsole.SkinSelection x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetPlayerSkinOptionsMapping_b__9_1_Internal_Object_SkinSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06008440 RID: 33856 RVA: 0x00251E04 File Offset: 0x00250004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38217, XrefRangeEnd = 38230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetPartnerSelectionsMapping_b__10_0(MainSceneDebugConsole.PartnerCharacterSelections x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetPartnerSelectionsMapping_b__10_0_Internal_String_PartnerCharacterSelections_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008441 RID: 33857 RVA: 0x00251E48 File Offset: 0x00250048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38230, XrefRangeEnd = 38233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _GetPartnerSelectionsMapping_b__10_1(MainSceneDebugConsole.PartnerCharacterSelections x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainSceneDebugImpl.__c.NativeMethodInfoPtr__GetPartnerSelectionsMapping_b__10_1_Internal_Object_PartnerCharacterSelections_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06008442 RID: 33858 RVA: 0x0004737F File Offset: 0x0004557F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C6C RID: 11372
			// (get) Token: 0x06008443 RID: 33859 RVA: 0x00251E94 File Offset: 0x00250094
			// (set) Token: 0x06008444 RID: 33860 RVA: 0x00047388 File Offset: 0x00045588
			public unsafe static MainSceneDebugImpl.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainSceneDebugImpl.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C6D RID: 11373
			// (get) Token: 0x06008445 RID: 33861 RVA: 0x00251EBC File Offset: 0x002500BC
			// (set) Token: 0x06008446 RID: 33862 RVA: 0x0004739A File Offset: 0x0004559A
			public unsafe static Func<int, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C6E RID: 11374
			// (get) Token: 0x06008447 RID: 33863 RVA: 0x00251EE4 File Offset: 0x002500E4
			// (set) Token: 0x06008448 RID: 33864 RVA: 0x000473AC File Offset: 0x000455AC
			public unsafe static Func<Il2CppStructArray<int>, IEnumerable<int>> __9__5_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C6F RID: 11375
			// (get) Token: 0x06008449 RID: 33865 RVA: 0x00251F0C File Offset: 0x0025010C
			// (set) Token: 0x0600844A RID: 33866 RVA: 0x000473BE File Offset: 0x000455BE
			public unsafe static Func<int, IEnumerable<int>> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C70 RID: 11376
			// (get) Token: 0x0600844B RID: 33867 RVA: 0x00251F34 File Offset: 0x00250134
			// (set) Token: 0x0600844C RID: 33868 RVA: 0x000473D0 File Offset: 0x000455D0
			public unsafe static Func<IEnumerable<int>, IEnumerable<int>> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C71 RID: 11377
			// (get) Token: 0x0600844D RID: 33869 RVA: 0x00251F5C File Offset: 0x0025015C
			// (set) Token: 0x0600844E RID: 33870 RVA: 0x000473E2 File Offset: 0x000455E2
			public unsafe static Func<IEnumerable<int>, IEnumerable<int>> __9__5_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C72 RID: 11378
			// (get) Token: 0x0600844F RID: 33871 RVA: 0x00251F84 File Offset: 0x00250184
			// (set) Token: 0x06008450 RID: 33872 RVA: 0x000473F4 File Offset: 0x000455F4
			public unsafe static Action __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C73 RID: 11379
			// (get) Token: 0x06008451 RID: 33873 RVA: 0x00251FAC File Offset: 0x002501AC
			// (set) Token: 0x06008452 RID: 33874 RVA: 0x00047406 File Offset: 0x00045606
			public unsafe static Action __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C74 RID: 11380
			// (get) Token: 0x06008453 RID: 33875 RVA: 0x00251FD4 File Offset: 0x002501D4
			// (set) Token: 0x06008454 RID: 33876 RVA: 0x00047418 File Offset: 0x00045618
			public unsafe static Func<SpecialGuest, string> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C75 RID: 11381
			// (get) Token: 0x06008455 RID: 33877 RVA: 0x00251FFC File Offset: 0x002501FC
			// (set) Token: 0x06008456 RID: 33878 RVA: 0x0004742A File Offset: 0x0004562A
			public unsafe static Func<MainSceneDebugConsole.TempIzakayaSelection, string> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.TempIzakayaSelection, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C76 RID: 11382
			// (get) Token: 0x06008457 RID: 33879 RVA: 0x00252024 File Offset: 0x00250224
			// (set) Token: 0x06008458 RID: 33880 RVA: 0x0004743C File Offset: 0x0004563C
			public unsafe static Func<MainSceneDebugConsole.TempIzakayaSelection, Object> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.TempIzakayaSelection, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C77 RID: 11383
			// (get) Token: 0x06008459 RID: 33881 RVA: 0x0025204C File Offset: 0x0025024C
			// (set) Token: 0x0600845A RID: 33882 RVA: 0x0004744E File Offset: 0x0004564E
			public unsafe static Func<MainSceneDebugConsole.SkinSelection, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.SkinSelection, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C78 RID: 11384
			// (get) Token: 0x0600845B RID: 33883 RVA: 0x00252074 File Offset: 0x00250274
			// (set) Token: 0x0600845C RID: 33884 RVA: 0x00047460 File Offset: 0x00045660
			public unsafe static Func<MainSceneDebugConsole.SkinSelection, Object> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.SkinSelection, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C79 RID: 11385
			// (get) Token: 0x0600845D RID: 33885 RVA: 0x0025209C File Offset: 0x0025029C
			// (set) Token: 0x0600845E RID: 33886 RVA: 0x00047472 File Offset: 0x00045672
			public unsafe static Func<MainSceneDebugConsole.PartnerCharacterSelections, string> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.PartnerCharacterSelections, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C7A RID: 11386
			// (get) Token: 0x0600845F RID: 33887 RVA: 0x002520C4 File Offset: 0x002502C4
			// (set) Token: 0x06008460 RID: 33888 RVA: 0x00047484 File Offset: 0x00045684
			public unsafe static Func<MainSceneDebugConsole.PartnerCharacterSelections, Object> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MainSceneDebugConsole.PartnerCharacterSelections, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainSceneDebugImpl.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040056F5 RID: 22261
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040056F6 RID: 22262
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040056F7 RID: 22263
			private static readonly IntPtr NativeFieldInfoPtr___9__5_5;

			// Token: 0x040056F8 RID: 22264
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x040056F9 RID: 22265
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x040056FA RID: 22266
			private static readonly IntPtr NativeFieldInfoPtr___9__5_4;

			// Token: 0x040056FB RID: 22267
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x040056FC RID: 22268
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040056FD RID: 22269
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040056FE RID: 22270
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040056FF RID: 22271
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04005700 RID: 22272
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04005701 RID: 22273
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04005702 RID: 22274
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04005703 RID: 22275
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04005704 RID: 22276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005705 RID: 22277
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__5_0_Internal_Boolean_Int32_0;

			// Token: 0x04005706 RID: 22278
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__5_1_Internal_Void_0;

			// Token: 0x04005707 RID: 22279
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__5_2_Internal_IEnumerable_1_Int32_Int32_0;

			// Token: 0x04005708 RID: 22280
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__5_5_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0;

			// Token: 0x04005709 RID: 22281
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__5_3_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0;

			// Token: 0x0400570A RID: 22282
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestWorkScene_b__5_4_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0;

			// Token: 0x0400570B RID: 22283
			private static readonly IntPtr NativeMethodInfoPtr__GotoTestResultScene_b__6_0_Internal_Void_0;

			// Token: 0x0400570C RID: 22284
			private static readonly IntPtr NativeMethodInfoPtr__GotoStaffScene_b__7_0_Internal_String_SpecialGuest_0;

			// Token: 0x0400570D RID: 22285
			private static readonly IntPtr NativeMethodInfoPtr__GetIzakayaOptionsMapping_b__8_0_Internal_String_TempIzakayaSelection_0;

			// Token: 0x0400570E RID: 22286
			private static readonly IntPtr NativeMethodInfoPtr__GetIzakayaOptionsMapping_b__8_1_Internal_Object_TempIzakayaSelection_0;

			// Token: 0x0400570F RID: 22287
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerSkinOptionsMapping_b__9_0_Internal_String_SkinSelection_0;

			// Token: 0x04005710 RID: 22288
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerSkinOptionsMapping_b__9_1_Internal_Object_SkinSelection_0;

			// Token: 0x04005711 RID: 22289
			private static readonly IntPtr NativeMethodInfoPtr__GetPartnerSelectionsMapping_b__10_0_Internal_String_PartnerCharacterSelections_0;

			// Token: 0x04005712 RID: 22290
			private static readonly IntPtr NativeMethodInfoPtr__GetPartnerSelectionsMapping_b__10_1_Internal_Object_PartnerCharacterSelections_0;
		}
	}
}
