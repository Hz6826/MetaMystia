using System;
using DEYU.Utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameData.CoreLanguage.Collections
{
	// Token: 0x0200021E RID: 542
	public static class NightSceneLanguage : Object
	{
		// Token: 0x06003FFF RID: 16383 RVA: 0x00178E2C File Offset: 0x0017702C
		// Note: this type is marked as 'beforefieldinit'.
		static NightSceneLanguage()
		{
			Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.CoreLanguage.Collections", "NightSceneLanguage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr);
			NightSceneLanguage.NativeFieldInfoPtr__SpecialEvaluation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, "<SpecialEvaluation>k__BackingField");
			NightSceneLanguage.NativeFieldInfoPtr__NormalEvaluation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, "<NormalEvaluation>k__BackingField");
			NightSceneLanguage.NativeFieldInfoPtr__SpecialConversation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, "<SpecialConversation>k__BackingField");
			NightSceneLanguage.NativeFieldInfoPtr__NormalConversation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, "<NormalConversation>k__BackingField");
			NightSceneLanguage.NativeMethodInfoPtr_get_SpecialEvaluation_Public_Static_get_Dictionary_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675329);
			NightSceneLanguage.NativeMethodInfoPtr_set_SpecialEvaluation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675330);
			NightSceneLanguage.NativeMethodInfoPtr_get_NormalEvaluation_Public_Static_get_Dictionary_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675331);
			NightSceneLanguage.NativeMethodInfoPtr_set_NormalEvaluation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675332);
			NightSceneLanguage.NativeMethodInfoPtr_get_SpecialConversation_Public_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675333);
			NightSceneLanguage.NativeMethodInfoPtr_set_SpecialConversation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675334);
			NightSceneLanguage.NativeMethodInfoPtr_get_NormalConversation_Public_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675335);
			NightSceneLanguage.NativeMethodInfoPtr_set_NormalConversation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675336);
			NightSceneLanguage.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_Int32_Il2CppStringArray_Dictionary_2_Int32_Il2CppStringArray_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675337);
			NightSceneLanguage.NativeMethodInfoPtr_GenerateNormalConv_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675338);
			NightSceneLanguage.NativeMethodInfoPtr_GenerateSpecialConv_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675339);
			NightSceneLanguage.NativeMethodInfoPtr_GenerateSpecialConv_Public_Static_String_Int32_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, 100675340);
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06004000 RID: 16384 RVA: 0x00178F9C File Offset: 0x0017719C
		// (set) Token: 0x06004001 RID: 16385 RVA: 0x00178FD0 File Offset: 0x001771D0
		public unsafe static Dictionary<int, Il2CppStringArray> SpecialEvaluation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157407, XrefRangeEnd = 157409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_get_SpecialEvaluation_Public_Static_get_Dictionary_2_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStringArray>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157409, XrefRangeEnd = 157413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_set_SpecialEvaluation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06004002 RID: 16386 RVA: 0x00179008 File Offset: 0x00177208
		// (set) Token: 0x06004003 RID: 16387 RVA: 0x0017903C File Offset: 0x0017723C
		public unsafe static Dictionary<int, Il2CppStringArray> NormalEvaluation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157413, XrefRangeEnd = 157415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_get_NormalEvaluation_Public_Static_get_Dictionary_2_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStringArray>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157415, XrefRangeEnd = 157419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_set_NormalEvaluation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x00179074 File Offset: 0x00177274
		// (set) Token: 0x06004005 RID: 16389 RVA: 0x001790A8 File Offset: 0x001772A8
		public unsafe static Dictionary<int, Il2CppReferenceArray<UnityEngineExtensionStatic.StructPtr<string>>> SpecialConversation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157419, XrefRangeEnd = 157421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_get_SpecialConversation_Public_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<UnityEngineExtensionStatic.StructPtr<string>>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157421, XrefRangeEnd = 157425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_set_SpecialConversation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06004006 RID: 16390 RVA: 0x001790E0 File Offset: 0x001772E0
		// (set) Token: 0x06004007 RID: 16391 RVA: 0x00179114 File Offset: 0x00177314
		public unsafe static Dictionary<int, Il2CppReferenceArray<UnityEngineExtensionStatic.StructPtr<string>>> NormalConversation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157425, XrefRangeEnd = 157427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_get_NormalConversation_Public_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<UnityEngineExtensionStatic.StructPtr<string>>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157427, XrefRangeEnd = 157431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_set_NormalConversation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x0017914C File Offset: 0x0017734C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157447, RefRangeEnd = 157448, XrefRangeStart = 157431, XrefRangeEnd = 157447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Dictionary<int, Il2CppStringArray> normalEvaluation, Dictionary<int, Il2CppStringArray> specialEvaluation, Dictionary<int, Il2CppReferenceArray<UnityEngineExtensionStatic.StructPtr<string>>> normalConversation, Dictionary<int, Il2CppReferenceArray<UnityEngineExtensionStatic.StructPtr<string>>> specialConversation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalEvaluation);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialEvaluation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalConversation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialConversation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_Int32_Il2CppStringArray_Dictionary_2_Int32_Il2CppStringArray_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x001791B8 File Offset: 0x001773B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157457, RefRangeEnd = 157458, XrefRangeStart = 157448, XrefRangeEnd = 157457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GenerateNormalConv(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_GenerateNormalConv_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x001791F0 File Offset: 0x001773F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157467, RefRangeEnd = 157468, XrefRangeStart = 157458, XrefRangeEnd = 157467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GenerateSpecialConv(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_GenerateSpecialConv_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x00179228 File Offset: 0x00177428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157481, RefRangeEnd = 157482, XrefRangeStart = 157468, XrefRangeEnd = 157481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GenerateSpecialConv(int id, List<string> extraConv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraConv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.NativeMethodInfoPtr_GenerateSpecialConv_Public_Static_String_Int32_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x000230CA File Offset: 0x000212CA
		public NightSceneLanguage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x0600400D RID: 16397 RVA: 0x00179274 File Offset: 0x00177474
		// (set) Token: 0x0600400E RID: 16398 RVA: 0x000230D3 File Offset: 0x000212D3
		public unsafe static Dictionary<int, Il2CppStringArray> _SpecialEvaluation_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NightSceneLanguage.NativeFieldInfoPtr__SpecialEvaluation_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneLanguage.NativeFieldInfoPtr__SpecialEvaluation_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x0600400F RID: 16399 RVA: 0x0017929C File Offset: 0x0017749C
		// (set) Token: 0x06004010 RID: 16400 RVA: 0x000230E5 File Offset: 0x000212E5
		public unsafe static Dictionary<int, Il2CppStringArray> _NormalEvaluation_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NightSceneLanguage.NativeFieldInfoPtr__NormalEvaluation_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneLanguage.NativeFieldInfoPtr__NormalEvaluation_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06004011 RID: 16401 RVA: 0x001792C4 File Offset: 0x001774C4
		// (set) Token: 0x06004012 RID: 16402 RVA: 0x000230F7 File Offset: 0x000212F7
		public unsafe static Dictionary<int, Il2CppReferenceArray<UnityEngineExtensionStatic.StructPtr<string>>> _SpecialConversation_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NightSceneLanguage.NativeFieldInfoPtr__SpecialConversation_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<UnityEngineExtensionStatic.StructPtr<string>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneLanguage.NativeFieldInfoPtr__SpecialConversation_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06004013 RID: 16403 RVA: 0x001792EC File Offset: 0x001774EC
		// (set) Token: 0x06004014 RID: 16404 RVA: 0x00023109 File Offset: 0x00021309
		public unsafe static Dictionary<int, Il2CppReferenceArray<UnityEngineExtensionStatic.StructPtr<string>>> _NormalConversation_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NightSceneLanguage.NativeFieldInfoPtr__NormalConversation_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<UnityEngineExtensionStatic.StructPtr<string>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneLanguage.NativeFieldInfoPtr__NormalConversation_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002AF9 RID: 11001
		private static readonly IntPtr NativeFieldInfoPtr__SpecialEvaluation_k__BackingField;

		// Token: 0x04002AFA RID: 11002
		private static readonly IntPtr NativeFieldInfoPtr__NormalEvaluation_k__BackingField;

		// Token: 0x04002AFB RID: 11003
		private static readonly IntPtr NativeFieldInfoPtr__SpecialConversation_k__BackingField;

		// Token: 0x04002AFC RID: 11004
		private static readonly IntPtr NativeFieldInfoPtr__NormalConversation_k__BackingField;

		// Token: 0x04002AFD RID: 11005
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialEvaluation_Public_Static_get_Dictionary_2_Int32_Il2CppStringArray_0;

		// Token: 0x04002AFE RID: 11006
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialEvaluation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppStringArray_0;

		// Token: 0x04002AFF RID: 11007
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalEvaluation_Public_Static_get_Dictionary_2_Int32_Il2CppStringArray_0;

		// Token: 0x04002B00 RID: 11008
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalEvaluation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppStringArray_0;

		// Token: 0x04002B01 RID: 11009
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialConversation_Public_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0;

		// Token: 0x04002B02 RID: 11010
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialConversation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0;

		// Token: 0x04002B03 RID: 11011
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalConversation_Public_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0;

		// Token: 0x04002B04 RID: 11012
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalConversation_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0;

		// Token: 0x04002B05 RID: 11013
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_Int32_Il2CppStringArray_Dictionary_2_Int32_Il2CppStringArray_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_Dictionary_2_Int32_Il2CppReferenceArray_1_StructPtr_1_String_0;

		// Token: 0x04002B06 RID: 11014
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNormalConv_Public_Static_String_Int32_0;

		// Token: 0x04002B07 RID: 11015
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSpecialConv_Public_Static_String_Int32_0;

		// Token: 0x04002B08 RID: 11016
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSpecialConv_Public_Static_String_Int32_List_1_String_0;

		// Token: 0x020009DD RID: 2525
		public sealed class GuestEvaluation : ValueType
		{
			// Token: 0x0600C1C7 RID: 49607 RVA: 0x003054F8 File Offset: 0x003036F8
			// Note: this type is marked as 'beforefieldinit'.
			static GuestEvaluation()
			{
				Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, "GuestEvaluation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr);
				NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_exbad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr, "exbad");
				NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_bad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr, "bad");
				NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr, "normal");
				NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_good = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr, "good");
				NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_exgood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr, "exgood");
				NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_warning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr, "warning");
				NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_overpay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr, "overpay");
				NightSceneLanguage.GuestEvaluation.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr, 100675341);
				NightSceneLanguage.GuestEvaluation.NativeMethodInfoPtr_Empty_Public_Static_GuestEvaluation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr, 100675342);
				NightSceneLanguage.GuestEvaluation.NativeMethodInfoPtr_GetEvaluation_Public_String_EvaluationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr, 100675343);
			}

			// Token: 0x0600C1C8 RID: 49608 RVA: 0x003055EC File Offset: 0x003037EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157347, XrefRangeEnd = 157354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestEvaluation(Il2CppStringArray exbad, Il2CppStringArray bad, Il2CppStringArray normal, Il2CppStringArray good, Il2CppStringArray exgood, Il2CppStringArray warning, Il2CppStringArray overpay) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exbad);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bad);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normal);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(good);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exgood);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(warning);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overpay);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.GuestEvaluation.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1C9 RID: 49609 RVA: 0x003056AC File Offset: 0x003038AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157354, XrefRangeEnd = 157405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static NightSceneLanguage.GuestEvaluation Empty()
			{
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.GuestEvaluation.NativeMethodInfoPtr_Empty_Public_Static_GuestEvaluation_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NightSceneLanguage.GuestEvaluation(pointer);
			}

			// Token: 0x0600C1CA RID: 49610 RVA: 0x003056D8 File Offset: 0x003038D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157405, XrefRangeEnd = 157407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetEvaluation(NightSceneLanguage.GuestEvaluation.EvaluationType type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.GuestEvaluation.NativeMethodInfoPtr_GetEvaluation_Public_String_EvaluationType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C1CB RID: 49611 RVA: 0x00068920 File Offset: 0x00066B20
			public GuestEvaluation(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C1CC RID: 49612 RVA: 0x00068929 File Offset: 0x00066B29
			public GuestEvaluation() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneLanguage.GuestEvaluation>.NativeClassPtr))
			{
			}

			// Token: 0x17003F1E RID: 16158
			// (get) Token: 0x0600C1CD RID: 49613 RVA: 0x00305724 File Offset: 0x00303924
			// (set) Token: 0x0600C1CE RID: 49614 RVA: 0x0006893B File Offset: 0x00066B3B
			public unsafe Il2CppStringArray exbad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_exbad);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_exbad), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F1F RID: 16159
			// (get) Token: 0x0600C1CF RID: 49615 RVA: 0x00305754 File Offset: 0x00303954
			// (set) Token: 0x0600C1D0 RID: 49616 RVA: 0x0006895A File Offset: 0x00066B5A
			public unsafe Il2CppStringArray bad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_bad);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_bad), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F20 RID: 16160
			// (get) Token: 0x0600C1D1 RID: 49617 RVA: 0x00305784 File Offset: 0x00303984
			// (set) Token: 0x0600C1D2 RID: 49618 RVA: 0x00068979 File Offset: 0x00066B79
			public unsafe Il2CppStringArray normal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_normal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_normal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F21 RID: 16161
			// (get) Token: 0x0600C1D3 RID: 49619 RVA: 0x003057B4 File Offset: 0x003039B4
			// (set) Token: 0x0600C1D4 RID: 49620 RVA: 0x00068998 File Offset: 0x00066B98
			public unsafe Il2CppStringArray good
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_good);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_good), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F22 RID: 16162
			// (get) Token: 0x0600C1D5 RID: 49621 RVA: 0x003057E4 File Offset: 0x003039E4
			// (set) Token: 0x0600C1D6 RID: 49622 RVA: 0x000689B7 File Offset: 0x00066BB7
			public unsafe Il2CppStringArray exgood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_exgood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_exgood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F23 RID: 16163
			// (get) Token: 0x0600C1D7 RID: 49623 RVA: 0x00305814 File Offset: 0x00303A14
			// (set) Token: 0x0600C1D8 RID: 49624 RVA: 0x000689D6 File Offset: 0x00066BD6
			public unsafe Il2CppStringArray warning
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_warning);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_warning), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F24 RID: 16164
			// (get) Token: 0x0600C1D9 RID: 49625 RVA: 0x00305844 File Offset: 0x00303A44
			// (set) Token: 0x0600C1DA RID: 49626 RVA: 0x000689F5 File Offset: 0x00066BF5
			public unsafe Il2CppStringArray overpay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_overpay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneLanguage.GuestEvaluation.NativeFieldInfoPtr_overpay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007CC9 RID: 31945
			private static readonly IntPtr NativeFieldInfoPtr_exbad;

			// Token: 0x04007CCA RID: 31946
			private static readonly IntPtr NativeFieldInfoPtr_bad;

			// Token: 0x04007CCB RID: 31947
			private static readonly IntPtr NativeFieldInfoPtr_normal;

			// Token: 0x04007CCC RID: 31948
			private static readonly IntPtr NativeFieldInfoPtr_good;

			// Token: 0x04007CCD RID: 31949
			private static readonly IntPtr NativeFieldInfoPtr_exgood;

			// Token: 0x04007CCE RID: 31950
			private static readonly IntPtr NativeFieldInfoPtr_warning;

			// Token: 0x04007CCF RID: 31951
			private static readonly IntPtr NativeFieldInfoPtr_overpay;

			// Token: 0x04007CD0 RID: 31952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0;

			// Token: 0x04007CD1 RID: 31953
			private static readonly IntPtr NativeMethodInfoPtr_Empty_Public_Static_GuestEvaluation_0;

			// Token: 0x04007CD2 RID: 31954
			private static readonly IntPtr NativeMethodInfoPtr_GetEvaluation_Public_String_EvaluationType_0;

			// Token: 0x02001002 RID: 4098
			public enum EvaluationType
			{
				// Token: 0x0400B169 RID: 45417
				Exbad,
				// Token: 0x0400B16A RID: 45418
				Bad,
				// Token: 0x0400B16B RID: 45419
				Normal,
				// Token: 0x0400B16C RID: 45420
				Good,
				// Token: 0x0400B16D RID: 45421
				ExGood,
				// Token: 0x0400B16E RID: 45422
				Warning,
				// Token: 0x0400B16F RID: 45423
				Overpay
			}
		}

		// Token: 0x020009DE RID: 2526
		[ObfuscatedName("GameData.CoreLanguage.Collections.NightSceneLanguage+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C1DB RID: 49627 RVA: 0x00305874 File Offset: 0x00303A74
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NightSceneLanguage.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneLanguage>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneLanguage.__c>.NativeClassPtr);
				NightSceneLanguage.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage.__c>.NativeClassPtr, "<>9");
				NightSceneLanguage.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneLanguage.__c>.NativeClassPtr, "<>9__19_0");
				NightSceneLanguage.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage.__c>.NativeClassPtr, 100675345);
				NightSceneLanguage.__c.NativeMethodInfoPtr__GenerateSpecialConv_b__19_0_Internal_String_StructPtr_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneLanguage.__c>.NativeClassPtr, 100675346);
			}

			// Token: 0x0600C1DC RID: 49628 RVA: 0x003058F0 File Offset: 0x00303AF0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneLanguage.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1DD RID: 49629 RVA: 0x0030592C File Offset: 0x00303B2C
			[CallerCount(0)]
			public unsafe string _GenerateSpecialConv_b__19_0(UnityEngineExtensionStatic.StructPtr<string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneLanguage.__c.NativeMethodInfoPtr__GenerateSpecialConv_b__19_0_Internal_String_StructPtr_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C1DE RID: 49630 RVA: 0x00068A14 File Offset: 0x00066C14
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F25 RID: 16165
			// (get) Token: 0x0600C1DF RID: 49631 RVA: 0x00305974 File Offset: 0x00303B74
			// (set) Token: 0x0600C1E0 RID: 49632 RVA: 0x00068A1D File Offset: 0x00066C1D
			public unsafe static NightSceneLanguage.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneLanguage.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneLanguage.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneLanguage.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F26 RID: 16166
			// (get) Token: 0x0600C1E1 RID: 49633 RVA: 0x0030599C File Offset: 0x00303B9C
			// (set) Token: 0x0600C1E2 RID: 49634 RVA: 0x00068A2F File Offset: 0x00066C2F
			public unsafe static Func<UnityEngineExtensionStatic.StructPtr<string>, string> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneLanguage.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UnityEngineExtensionStatic.StructPtr<string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneLanguage.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007CD3 RID: 31955
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007CD4 RID: 31956
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04007CD5 RID: 31957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007CD6 RID: 31958
			private static readonly IntPtr NativeMethodInfoPtr__GenerateSpecialConv_b__19_0_Internal_String_StructPtr_1_String_0;
		}
	}
}
