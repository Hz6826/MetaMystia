using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameData.CoreLanguage.Collections
{
	// Token: 0x0200021D RID: 541
	public static class DaySceneLanguage : Object
	{
		// Token: 0x06003FED RID: 16365 RVA: 0x00178A24 File Offset: 0x00176C24
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneLanguage()
		{
			Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.CoreLanguage.Collections", "DaySceneLanguage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr);
			DaySceneLanguage.NativeFieldInfoPtr__DaySceneNPCLanguage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, "<DaySceneNPCLanguage>k__BackingField");
			DaySceneLanguage.NativeFieldInfoPtr__DaySceneInteractableEntitiesLanguage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, "<DaySceneInteractableEntitiesLanguage>k__BackingField");
			DaySceneLanguage.NativeFieldInfoPtr__MapLanguageData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, "<MapLanguageData>k__BackingField");
			DaySceneLanguage.NativeMethodInfoPtr_get_DaySceneNPCLanguage_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, 100675319);
			DaySceneLanguage.NativeMethodInfoPtr_set_DaySceneNPCLanguage_Private_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, 100675320);
			DaySceneLanguage.NativeMethodInfoPtr_get_DaySceneInteractableEntitiesLanguage_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, 100675321);
			DaySceneLanguage.NativeMethodInfoPtr_set_DaySceneInteractableEntitiesLanguage_Private_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, 100675322);
			DaySceneLanguage.NativeMethodInfoPtr_get_MapLanguageData_Private_Static_get_Dictionary_2_String_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, 100675323);
			DaySceneLanguage.NativeMethodInfoPtr_set_MapLanguageData_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, 100675324);
			DaySceneLanguage.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_LanguageBase_Dictionary_2_String_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, 100675325);
			DaySceneLanguage.NativeMethodInfoPtr_RefDaySceneName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, 100675326);
			DaySceneLanguage.NativeMethodInfoPtr_RefInteractableEntitiesName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, 100675327);
			DaySceneLanguage.NativeMethodInfoPtr_GetMapLanguageData_Public_Static_LanguageBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneLanguage>.NativeClassPtr, 100675328);
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06003FEE RID: 16366 RVA: 0x00178B58 File Offset: 0x00176D58
		// (set) Token: 0x06003FEF RID: 16367 RVA: 0x00178B8C File Offset: 0x00176D8C
		public unsafe static Dictionary<string, string> DaySceneNPCLanguage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157227, XrefRangeEnd = 157229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneLanguage.NativeMethodInfoPtr_get_DaySceneNPCLanguage_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157229, XrefRangeEnd = 157233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneLanguage.NativeMethodInfoPtr_set_DaySceneNPCLanguage_Private_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06003FF0 RID: 16368 RVA: 0x00178BC4 File Offset: 0x00176DC4
		// (set) Token: 0x06003FF1 RID: 16369 RVA: 0x00178BF8 File Offset: 0x00176DF8
		public unsafe static Dictionary<string, string> DaySceneInteractableEntitiesLanguage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157233, XrefRangeEnd = 157235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneLanguage.NativeMethodInfoPtr_get_DaySceneInteractableEntitiesLanguage_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157235, XrefRangeEnd = 157239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneLanguage.NativeMethodInfoPtr_set_DaySceneInteractableEntitiesLanguage_Private_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x00178C30 File Offset: 0x00176E30
		// (set) Token: 0x06003FF3 RID: 16371 RVA: 0x00178C64 File Offset: 0x00176E64
		public unsafe static Dictionary<string, LanguageBase> MapLanguageData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157239, XrefRangeEnd = 157241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneLanguage.NativeMethodInfoPtr_get_MapLanguageData_Private_Static_get_Dictionary_2_String_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157241, XrefRangeEnd = 157245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneLanguage.NativeMethodInfoPtr_set_MapLanguageData_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x00178C9C File Offset: 0x00176E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157257, RefRangeEnd = 157258, XrefRangeStart = 157245, XrefRangeEnd = 157257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Dictionary<string, LanguageBase> mapLanguageData, Dictionary<string, string> normalNPC, Dictionary<string, string> daySceneInteractableEntitiesLanguageData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapLanguageData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalNPC);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(daySceneInteractableEntitiesLanguageData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneLanguage.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_LanguageBase_Dictionary_2_String_String_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00178CF8 File Offset: 0x00176EF8
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 157273, RefRangeEnd = 157292, XrefRangeStart = 157258, XrefRangeEnd = 157273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RefDaySceneName(this string npcId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneLanguage.NativeMethodInfoPtr_RefDaySceneName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x00178D34 File Offset: 0x00176F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157300, RefRangeEnd = 157301, XrefRangeStart = 157292, XrefRangeEnd = 157300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RefInteractableEntitiesName(this string interactableEnetityName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(interactableEnetityName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneLanguage.NativeMethodInfoPtr_RefInteractableEntitiesName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x00178D70 File Offset: 0x00176F70
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 157316, RefRangeEnd = 157347, XrefRangeStart = 157301, XrefRangeEnd = 157316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LanguageBase GetMapLanguageData(this string mapLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneLanguage.NativeMethodInfoPtr_GetMapLanguageData_Public_Static_LanguageBase_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x0002308B File Offset: 0x0002128B
		public DaySceneLanguage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06003FF9 RID: 16377 RVA: 0x00178DB4 File Offset: 0x00176FB4
		// (set) Token: 0x06003FFA RID: 16378 RVA: 0x00023094 File Offset: 0x00021294
		public unsafe static Dictionary<string, string> _DaySceneNPCLanguage_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneLanguage.NativeFieldInfoPtr__DaySceneNPCLanguage_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneLanguage.NativeFieldInfoPtr__DaySceneNPCLanguage_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06003FFB RID: 16379 RVA: 0x00178DDC File Offset: 0x00176FDC
		// (set) Token: 0x06003FFC RID: 16380 RVA: 0x000230A6 File Offset: 0x000212A6
		public unsafe static Dictionary<string, string> _DaySceneInteractableEntitiesLanguage_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneLanguage.NativeFieldInfoPtr__DaySceneInteractableEntitiesLanguage_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneLanguage.NativeFieldInfoPtr__DaySceneInteractableEntitiesLanguage_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06003FFD RID: 16381 RVA: 0x00178E04 File Offset: 0x00177004
		// (set) Token: 0x06003FFE RID: 16382 RVA: 0x000230B8 File Offset: 0x000212B8
		public unsafe static Dictionary<string, LanguageBase> _MapLanguageData_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneLanguage.NativeFieldInfoPtr__MapLanguageData_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneLanguage.NativeFieldInfoPtr__MapLanguageData_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002AEC RID: 10988
		private static readonly IntPtr NativeFieldInfoPtr__DaySceneNPCLanguage_k__BackingField;

		// Token: 0x04002AED RID: 10989
		private static readonly IntPtr NativeFieldInfoPtr__DaySceneInteractableEntitiesLanguage_k__BackingField;

		// Token: 0x04002AEE RID: 10990
		private static readonly IntPtr NativeFieldInfoPtr__MapLanguageData_k__BackingField;

		// Token: 0x04002AEF RID: 10991
		private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneNPCLanguage_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x04002AF0 RID: 10992
		private static readonly IntPtr NativeMethodInfoPtr_set_DaySceneNPCLanguage_Private_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x04002AF1 RID: 10993
		private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneInteractableEntitiesLanguage_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x04002AF2 RID: 10994
		private static readonly IntPtr NativeMethodInfoPtr_set_DaySceneInteractableEntitiesLanguage_Private_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x04002AF3 RID: 10995
		private static readonly IntPtr NativeMethodInfoPtr_get_MapLanguageData_Private_Static_get_Dictionary_2_String_LanguageBase_0;

		// Token: 0x04002AF4 RID: 10996
		private static readonly IntPtr NativeMethodInfoPtr_set_MapLanguageData_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0;

		// Token: 0x04002AF5 RID: 10997
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_LanguageBase_Dictionary_2_String_String_Dictionary_2_String_String_0;

		// Token: 0x04002AF6 RID: 10998
		private static readonly IntPtr NativeMethodInfoPtr_RefDaySceneName_Public_Static_String_String_0;

		// Token: 0x04002AF7 RID: 10999
		private static readonly IntPtr NativeMethodInfoPtr_RefInteractableEntitiesName_Public_Static_String_String_0;

		// Token: 0x04002AF8 RID: 11000
		private static readonly IntPtr NativeMethodInfoPtr_GetMapLanguageData_Public_Static_LanguageBase_String_0;
	}
}
