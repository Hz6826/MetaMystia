using System;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000376 RID: 886
	public class SelectedIzakayaDescriber : MonoBehaviour
	{
		// Token: 0x0600692C RID: 26924 RVA: 0x001FD748 File Offset: 0x001FB948
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedIzakayaDescriber()
		{
			Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "SelectedIzakayaDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr);
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_IzakayaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_IzakayaName");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_CookingDeskAmount1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_CookingDeskAmount1");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_CookingDeskAmount2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_CookingDeskAmount2");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_GuestTableAmount1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_GuestTableAmount1");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_GuestTableAmount2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_GuestTableAmount2");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_CharacterPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_CharacterPrefab");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_SpecialGuestModule");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_NormalGuestModule");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_NormalGuestField");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_SpecialGuestField");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestsMoreIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_NormalGuestsMoreIndicator");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestsMoreIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_SpecialGuestsMoreIndicator");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_allNormalCharacterInstancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "allNormalCharacterInstancePool");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_allSpecialCharacterInstancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "allSpecialCharacterInstancePool");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestPrintingCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_SpecialGuestPrintingCache");
			SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestPrintingCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "m_NormalGuestPrintingCache");
			SelectedIzakayaDescriber.NativeMethodInfoPtr_get_Max_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, 100685145);
			SelectedIzakayaDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, 100685146);
			SelectedIzakayaDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_New_Void_Izakaya_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, 100685147);
			SelectedIzakayaDescriber.NativeMethodInfoPtr_PrintImpl_Public_Static_Void_Izakaya_IReadOnlyList_1_ValueTuple_2_String_CharacterSpriteSetCompact_IReadOnlyList_1_ValueTuple_2_String_CharacterSpriteSetCompact_Boolean_Boolean_TextMeshProUGUI_TextMeshProUGUI_TextMeshProUGUI_TextMeshProUGUI_TextMeshProUGUI_GameObject_GameObject_GameObject_RectTransform_RectTransform_CanvasGroup_CanvasGroup_List_1_GameObject_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, 100685148);
			SelectedIzakayaDescriber.NativeMethodInfoPtr_MapNormalGuestPrintData_Public_Static_Void_Int32_IReadOnlyList_1_NormalGuestGroup_byref_Boolean_List_1_ValueTuple_2_String_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, 100685149);
			SelectedIzakayaDescriber.NativeMethodInfoPtr_MapSpecialGuestPrintData_Public_Static_Void_Int32_Izakaya_byref_IReadOnlyList_1_ValueTuple_2_String_CharacterSpriteSetCompact_byref_Boolean_List_1_ValueTuple_2_String_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, 100685150);
			SelectedIzakayaDescriber.NativeMethodInfoPtr_Process_Public_Static_Void_UIElementCluster_ValueTuple_2_String_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, 100685151);
			SelectedIzakayaDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, 100685152);
			SelectedIzakayaDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, 100685153);
			SelectedIzakayaDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, 100685154);
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x0600692D RID: 26925 RVA: 0x001FD980 File Offset: 0x001FBB80
		public unsafe virtual int Max
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48392, RefRangeEnd = 48393, XrefRangeStart = 48392, XrefRangeEnd = 48393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedIzakayaDescriber.NativeMethodInfoPtr_get_Max_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x001FD9C8 File Offset: 0x001FBBC8
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600692F RID: 26927 RVA: 0x001FD9FC File Offset: 0x001FBBFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268714, RefRangeEnd = 268715, XrefRangeStart = 268681, XrefRangeEnd = 268714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(Izakaya data, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedIzakayaDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_New_Void_Izakaya_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x001FDA60 File Offset: 0x001FBC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268746, RefRangeEnd = 268747, XrefRangeStart = 268715, XrefRangeEnd = 268746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrintImpl(Izakaya data, IReadOnlyList<ValueTuple<string, CharacterSpriteSetCompact>> specialGuestPrintInfo, IReadOnlyList<ValueTuple<string, CharacterSpriteSetCompact>> normalGuestPrintInfo, bool normalGuestLimiterApplies, bool specialGuestsLimiterApplies, TextMeshProUGUI m_IzakayaName, TextMeshProUGUI m_CookingDeskAmount1, TextMeshProUGUI m_CookingDeskAmount2, TextMeshProUGUI m_GuestTableAmount1, TextMeshProUGUI m_GuestTableAmount2, GameObject m_CharacterPrefab, GameObject m_NormalGuestContainer, GameObject m_SpecialGuestContainer, RectTransform m_NormalGuestField, RectTransform m_SpecialGuestField, CanvasGroup m_NormalGuestsMoreIndicator, CanvasGroup m_SpecialGuestsMoreIndicator, List<GameObject> allNormalCharacterInstancePool, List<GameObject> allSpecialCharacterInstancePool)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuestPrintInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalGuestPrintInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalGuestLimiterApplies;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specialGuestsLimiterApplies;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_IzakayaName);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_CookingDeskAmount1);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_CookingDeskAmount2);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_GuestTableAmount1);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_GuestTableAmount2);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_CharacterPrefab);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_NormalGuestContainer);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_SpecialGuestContainer);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_NormalGuestField);
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_SpecialGuestField);
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_NormalGuestsMoreIndicator);
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_SpecialGuestsMoreIndicator);
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allNormalCharacterInstancePool);
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allSpecialCharacterInstancePool);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.NativeMethodInfoPtr_PrintImpl_Public_Static_Void_Izakaya_IReadOnlyList_1_ValueTuple_2_String_CharacterSpriteSetCompact_IReadOnlyList_1_ValueTuple_2_String_CharacterSpriteSetCompact_Boolean_Boolean_TextMeshProUGUI_TextMeshProUGUI_TextMeshProUGUI_TextMeshProUGUI_TextMeshProUGUI_GameObject_GameObject_GameObject_RectTransform_RectTransform_CanvasGroup_CanvasGroup_List_1_GameObject_List_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x001FDBEC File Offset: 0x001FBDEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 268841, RefRangeEnd = 268843, XrefRangeStart = 268747, XrefRangeEnd = 268841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MapNormalGuestPrintData(int max, IReadOnlyList<Izakaya.NormalGuestGroup> normalGuestGroups, out bool limiterApplies, List<ValueTuple<string, CharacterSpriteSetCompact>> m_PrintingCache)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref max;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalGuestGroups);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &limiterApplies;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_PrintingCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.NativeMethodInfoPtr_MapNormalGuestPrintData_Public_Static_Void_Int32_IReadOnlyList_1_NormalGuestGroup_byref_Boolean_List_1_ValueTuple_2_String_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x001FDC50 File Offset: 0x001FBE50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268915, RefRangeEnd = 268916, XrefRangeStart = 268843, XrefRangeEnd = 268915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MapSpecialGuestPrintData(int max, Izakaya data, out IReadOnlyList<ValueTuple<string, CharacterSpriteSetCompact>> printInfo, out bool limiterApplies, List<ValueTuple<string, CharacterSpriteSetCompact>> m_PrintingCache)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref max;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &limiterApplies;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m_PrintingCache);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.NativeMethodInfoPtr_MapSpecialGuestPrintData_Public_Static_Void_Int32_Izakaya_byref_IReadOnlyList_1_ValueTuple_2_String_CharacterSpriteSetCompact_byref_Boolean_List_1_ValueTuple_2_String_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			printInfo = ((intPtr4 == 0) ? null : new IReadOnlyList<ValueTuple<string, CharacterSpriteSetCompact>>(intPtr4));
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x001FDCD8 File Offset: 0x001FBED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268953, RefRangeEnd = 268954, XrefRangeStart = 268916, XrefRangeEnd = 268953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(UIElementCluster visual, ValueTuple<string, CharacterSpriteSetCompact> data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.NativeMethodInfoPtr_Process_Public_Static_Void_UIElementCluster_ValueTuple_2_String_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x001FDD28 File Offset: 0x001FBF28
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x001FDD5C File Offset: 0x001FBF5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268976, RefRangeEnd = 268977, XrefRangeStart = 268954, XrefRangeEnd = 268976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedIzakayaDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x001FDD98 File Offset: 0x001FBF98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269003, RefRangeEnd = 269004, XrefRangeStart = 268977, XrefRangeEnd = 269003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedIzakayaDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x00038DDC File Offset: 0x00036FDC
		public SelectedIzakayaDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x06006938 RID: 26936 RVA: 0x001FDDD4 File Offset: 0x001FBFD4
		// (set) Token: 0x06006939 RID: 26937 RVA: 0x00038DE5 File Offset: 0x00036FE5
		public unsafe TextMeshProUGUI m_IzakayaName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_IzakayaName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_IzakayaName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600693A RID: 26938 RVA: 0x001FDE04 File Offset: 0x001FC004
		// (set) Token: 0x0600693B RID: 26939 RVA: 0x00038E04 File Offset: 0x00037004
		public unsafe TextMeshProUGUI m_CookingDeskAmount1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_CookingDeskAmount1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_CookingDeskAmount1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x0600693C RID: 26940 RVA: 0x001FDE34 File Offset: 0x001FC034
		// (set) Token: 0x0600693D RID: 26941 RVA: 0x00038E23 File Offset: 0x00037023
		public unsafe TextMeshProUGUI m_CookingDeskAmount2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_CookingDeskAmount2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_CookingDeskAmount2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x0600693E RID: 26942 RVA: 0x001FDE64 File Offset: 0x001FC064
		// (set) Token: 0x0600693F RID: 26943 RVA: 0x00038E42 File Offset: 0x00037042
		public unsafe TextMeshProUGUI m_GuestTableAmount1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_GuestTableAmount1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_GuestTableAmount1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x06006940 RID: 26944 RVA: 0x001FDE94 File Offset: 0x001FC094
		// (set) Token: 0x06006941 RID: 26945 RVA: 0x00038E61 File Offset: 0x00037061
		public unsafe TextMeshProUGUI m_GuestTableAmount2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_GuestTableAmount2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_GuestTableAmount2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x06006942 RID: 26946 RVA: 0x001FDEC4 File Offset: 0x001FC0C4
		// (set) Token: 0x06006943 RID: 26947 RVA: 0x00038E80 File Offset: 0x00037080
		public unsafe GameObject m_CharacterPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_CharacterPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_CharacterPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x06006944 RID: 26948 RVA: 0x001FDEF4 File Offset: 0x001FC0F4
		// (set) Token: 0x06006945 RID: 26949 RVA: 0x00038E9F File Offset: 0x0003709F
		public unsafe GameObject m_SpecialGuestModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x06006946 RID: 26950 RVA: 0x001FDF24 File Offset: 0x001FC124
		// (set) Token: 0x06006947 RID: 26951 RVA: 0x00038EBE File Offset: 0x000370BE
		public unsafe GameObject m_NormalGuestModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x06006948 RID: 26952 RVA: 0x001FDF54 File Offset: 0x001FC154
		// (set) Token: 0x06006949 RID: 26953 RVA: 0x00038EDD File Offset: 0x000370DD
		public unsafe RectTransform m_NormalGuestField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x0600694A RID: 26954 RVA: 0x001FDF84 File Offset: 0x001FC184
		// (set) Token: 0x0600694B RID: 26955 RVA: 0x00038EFC File Offset: 0x000370FC
		public unsafe RectTransform m_SpecialGuestField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x0600694C RID: 26956 RVA: 0x001FDFB4 File Offset: 0x001FC1B4
		// (set) Token: 0x0600694D RID: 26957 RVA: 0x00038F1B File Offset: 0x0003711B
		public unsafe CanvasGroup m_NormalGuestsMoreIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestsMoreIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestsMoreIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x0600694E RID: 26958 RVA: 0x001FDFE4 File Offset: 0x001FC1E4
		// (set) Token: 0x0600694F RID: 26959 RVA: 0x00038F3A File Offset: 0x0003713A
		public unsafe CanvasGroup m_SpecialGuestsMoreIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestsMoreIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestsMoreIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x06006950 RID: 26960 RVA: 0x001FE014 File Offset: 0x001FC214
		// (set) Token: 0x06006951 RID: 26961 RVA: 0x00038F59 File Offset: 0x00037159
		public unsafe List<GameObject> allNormalCharacterInstancePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_allNormalCharacterInstancePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_allNormalCharacterInstancePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x06006952 RID: 26962 RVA: 0x001FE044 File Offset: 0x001FC244
		// (set) Token: 0x06006953 RID: 26963 RVA: 0x00038F78 File Offset: 0x00037178
		public unsafe List<GameObject> allSpecialCharacterInstancePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_allSpecialCharacterInstancePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_allSpecialCharacterInstancePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x06006954 RID: 26964 RVA: 0x001FE074 File Offset: 0x001FC274
		// (set) Token: 0x06006955 RID: 26965 RVA: 0x00038F97 File Offset: 0x00037197
		public unsafe List<ValueTuple<string, CharacterSpriteSetCompact>> m_SpecialGuestPrintingCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestPrintingCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, CharacterSpriteSetCompact>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_SpecialGuestPrintingCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x06006956 RID: 26966 RVA: 0x001FE0A4 File Offset: 0x001FC2A4
		// (set) Token: 0x06006957 RID: 26967 RVA: 0x00038FB6 File Offset: 0x000371B6
		public unsafe List<ValueTuple<string, CharacterSpriteSetCompact>> m_NormalGuestPrintingCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestPrintingCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, CharacterSpriteSetCompact>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.NativeFieldInfoPtr_m_NormalGuestPrintingCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045C0 RID: 17856
		private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaName;

		// Token: 0x040045C1 RID: 17857
		private static readonly IntPtr NativeFieldInfoPtr_m_CookingDeskAmount1;

		// Token: 0x040045C2 RID: 17858
		private static readonly IntPtr NativeFieldInfoPtr_m_CookingDeskAmount2;

		// Token: 0x040045C3 RID: 17859
		private static readonly IntPtr NativeFieldInfoPtr_m_GuestTableAmount1;

		// Token: 0x040045C4 RID: 17860
		private static readonly IntPtr NativeFieldInfoPtr_m_GuestTableAmount2;

		// Token: 0x040045C5 RID: 17861
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterPrefab;

		// Token: 0x040045C6 RID: 17862
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestModule;

		// Token: 0x040045C7 RID: 17863
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuestModule;

		// Token: 0x040045C8 RID: 17864
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuestField;

		// Token: 0x040045C9 RID: 17865
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestField;

		// Token: 0x040045CA RID: 17866
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuestsMoreIndicator;

		// Token: 0x040045CB RID: 17867
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestsMoreIndicator;

		// Token: 0x040045CC RID: 17868
		private static readonly IntPtr NativeFieldInfoPtr_allNormalCharacterInstancePool;

		// Token: 0x040045CD RID: 17869
		private static readonly IntPtr NativeFieldInfoPtr_allSpecialCharacterInstancePool;

		// Token: 0x040045CE RID: 17870
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestPrintingCache;

		// Token: 0x040045CF RID: 17871
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuestPrintingCache;

		// Token: 0x040045D0 RID: 17872
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Protected_Virtual_New_get_Int32_0;

		// Token: 0x040045D1 RID: 17873
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040045D2 RID: 17874
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_New_Void_Izakaya_CancellationToken_0;

		// Token: 0x040045D3 RID: 17875
		private static readonly IntPtr NativeMethodInfoPtr_PrintImpl_Public_Static_Void_Izakaya_IReadOnlyList_1_ValueTuple_2_String_CharacterSpriteSetCompact_IReadOnlyList_1_ValueTuple_2_String_CharacterSpriteSetCompact_Boolean_Boolean_TextMeshProUGUI_TextMeshProUGUI_TextMeshProUGUI_TextMeshProUGUI_TextMeshProUGUI_GameObject_GameObject_GameObject_RectTransform_RectTransform_CanvasGroup_CanvasGroup_List_1_GameObject_List_1_GameObject_0;

		// Token: 0x040045D4 RID: 17876
		private static readonly IntPtr NativeMethodInfoPtr_MapNormalGuestPrintData_Public_Static_Void_Int32_IReadOnlyList_1_NormalGuestGroup_byref_Boolean_List_1_ValueTuple_2_String_CharacterSpriteSetCompact_0;

		// Token: 0x040045D5 RID: 17877
		private static readonly IntPtr NativeMethodInfoPtr_MapSpecialGuestPrintData_Public_Static_Void_Int32_Izakaya_byref_IReadOnlyList_1_ValueTuple_2_String_CharacterSpriteSetCompact_byref_Boolean_List_1_ValueTuple_2_String_CharacterSpriteSetCompact_0;

		// Token: 0x040045D6 RID: 17878
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Static_Void_UIElementCluster_ValueTuple_2_String_CharacterSpriteSetCompact_0;

		// Token: 0x040045D7 RID: 17879
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0;

		// Token: 0x040045D8 RID: 17880
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040045D9 RID: 17881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E84 RID: 3716
		[ObfuscatedName("Common.UI.SelectedIzakayaDescriber+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060107CD RID: 67533 RVA: 0x003D3180 File Offset: 0x003D1380
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SelectedIzakayaDescriber.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c>.NativeClassPtr);
				SelectedIzakayaDescriber.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c>.NativeClassPtr, "<>9");
				SelectedIzakayaDescriber.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c>.NativeClassPtr, "<>9__21_0");
				SelectedIzakayaDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c>.NativeClassPtr, 100685156);
				SelectedIzakayaDescriber.__c.NativeMethodInfoPtr__MapNormalGuestPrintData_b__21_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c>.NativeClassPtr, 100685157);
			}

			// Token: 0x060107CE RID: 67534 RVA: 0x003D31FC File Offset: 0x003D13FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107CF RID: 67535 RVA: 0x003D3238 File Offset: 0x003D1438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268680, XrefRangeEnd = 268681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MapNormalGuestPrintData_b__21_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.__c.NativeMethodInfoPtr__MapNormalGuestPrintData_b__21_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060107D0 RID: 67536 RVA: 0x0008FE45 File Offset: 0x0008E045
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005617 RID: 22039
			// (get) Token: 0x060107D1 RID: 67537 RVA: 0x003D328C File Offset: 0x003D148C
			// (set) Token: 0x060107D2 RID: 67538 RVA: 0x0008FE4E File Offset: 0x0008E04E
			public unsafe static SelectedIzakayaDescriber.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedIzakayaDescriber.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedIzakayaDescriber.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedIzakayaDescriber.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005618 RID: 22040
			// (get) Token: 0x060107D3 RID: 67539 RVA: 0x003D32B4 File Offset: 0x003D14B4
			// (set) Token: 0x060107D4 RID: 67540 RVA: 0x0008FE60 File Offset: 0x0008E060
			public unsafe static Func<KeyValuePair<int, int>, int> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedIzakayaDescriber.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedIzakayaDescriber.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6EB RID: 42731
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A6EC RID: 42732
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x0400A6ED RID: 42733
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6EE RID: 42734
			private static readonly IntPtr NativeMethodInfoPtr__MapNormalGuestPrintData_b__21_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x02000E85 RID: 3717
		[ObfuscatedName("Common.UI.SelectedIzakayaDescriber+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x060107D5 RID: 67541 RVA: 0x003D32DC File Offset: 0x003D14DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<SelectedIzakayaDescriber.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectedIzakayaDescriber>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c__DisplayClass23_0>.NativeClassPtr);
				SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c__DisplayClass23_0>.NativeClassPtr, "data");
				SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100685158);
				SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__Process_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100685159);
				SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__Process_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100685160);
				SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__Process_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100685161);
				SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__Process_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100685162);
				SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__Process_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c__DisplayClass23_0>.NativeClassPtr, 100685163);
			}

			// Token: 0x060107D6 RID: 67542 RVA: 0x003D3394 File Offset: 0x003D1594
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedIzakayaDescriber.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107D7 RID: 67543 RVA: 0x003D33D0 File Offset: 0x003D15D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Process_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__Process_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107D8 RID: 67544 RVA: 0x003D3414 File Offset: 0x003D1614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Process_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__Process_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107D9 RID: 67545 RVA: 0x003D3458 File Offset: 0x003D1658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Process_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__Process_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107DA RID: 67546 RVA: 0x003D349C File Offset: 0x003D169C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Process_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__Process_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107DB RID: 67547 RVA: 0x003D34E0 File Offset: 0x003D16E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Process_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeMethodInfoPtr__Process_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107DC RID: 67548 RVA: 0x0008FE72 File Offset: 0x0008E072
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005619 RID: 22041
			// (get) Token: 0x060107DD RID: 67549 RVA: 0x003D3524 File Offset: 0x003D1724
			// (set) Token: 0x060107DE RID: 67550 RVA: 0x0008FE7B File Offset: 0x0008E07B
			public ValueTuple<string, CharacterSpriteSetCompact> data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeFieldInfoPtr_data);
					return new ValueTuple<string, CharacterSpriteSetCompact>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, CharacterSpriteSetCompact>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedIzakayaDescriber.__c__DisplayClass23_0.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, CharacterSpriteSetCompact>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A6EF RID: 42735
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400A6F0 RID: 42736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6F1 RID: 42737
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__0_Internal_Void_Image_0;

			// Token: 0x0400A6F2 RID: 42738
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__1_Internal_Void_Image_0;

			// Token: 0x0400A6F3 RID: 42739
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__2_Internal_Void_Image_0;

			// Token: 0x0400A6F4 RID: 42740
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__3_Internal_Void_Image_0;

			// Token: 0x0400A6F5 RID: 42741
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__4_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
