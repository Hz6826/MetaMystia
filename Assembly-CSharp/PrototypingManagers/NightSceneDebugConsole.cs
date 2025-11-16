using System;
using Common.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using NightScene.CookingUtility;
using UnityEngine;

namespace PrototypingManagers
{
	// Token: 0x02000044 RID: 68
	public class NightSceneDebugConsole : DebugConsoleBase
	{
		// Token: 0x060007B5 RID: 1973 RVA: 0x000B6828 File Offset: 0x000B4A28
		// Note: this type is marked as 'beforefieldinit'.
		static NightSceneDebugConsole()
		{
			Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "NightSceneDebugConsole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr);
			NightSceneDebugConsole.NativeFieldInfoPtr_currentPannelScrollViewPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "currentPannelScrollViewPosition");
			NightSceneDebugConsole.NativeFieldInfoPtr_isBtnSetShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isBtnSetShown");
			NightSceneDebugConsole.NativeFieldInfoPtr_isBuffSetShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isBuffSetShown");
			NightSceneDebugConsole.NativeFieldInfoPtr_isGuestSetShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isGuestSetShown");
			NightSceneDebugConsole.NativeFieldInfoPtr_isPartnerSetShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isPartnerSetShown");
			NightSceneDebugConsole.NativeFieldInfoPtr_largeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "largeMode");
			NightSceneDebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "shouldOnGUIBuffConsoleShown");
			NightSceneDebugConsole.NativeFieldInfoPtr_selectedSpecialGuestIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "selectedSpecialGuestIndex");
			NightSceneDebugConsole.NativeFieldInfoPtr_selectedNormalGuestIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "selectedNormalGuestIndex");
			NightSceneDebugConsole.NativeFieldInfoPtr_isSelectedSpecialGuestExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isSelectedSpecialGuestExpanded");
			NightSceneDebugConsole.NativeFieldInfoPtr_isSelectedNormalGuestExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isSelectedNormalGuestExpanded");
			NightSceneDebugConsole.NativeFieldInfoPtr_currentInDeskGuestPannelScrollViewPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "currentInDeskGuestPannelScrollViewPosition");
			NightSceneDebugConsole.NativeFieldInfoPtr_currentQueuedGuestPannelScrollViewPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "currentQueuedGuestPannelScrollViewPosition");
			NightSceneDebugConsole.NativeFieldInfoPtr_currentPartnerPannelScrollViewPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "currentPartnerPannelScrollViewPosition");
			NightSceneDebugConsole.NativeFieldInfoPtr_allPartners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "allPartners");
			NightSceneDebugConsole.NativeFieldInfoPtr_m_BuffMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "m_BuffMethods");
			NightSceneDebugConsole.NativeFieldInfoPtr_m_BuffValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "m_BuffValues");
			NightSceneDebugConsole.NativeFieldInfoPtr_m_BuffValueExpansions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "m_BuffValueExpansions");
			NightSceneDebugConsole.NativeFieldInfoPtr_isBuffAExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isBuffAExpaneded");
			NightSceneDebugConsole.NativeFieldInfoPtr_isMethodAExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isMethodAExpaneded");
			NightSceneDebugConsole.NativeFieldInfoPtr_selectedMethodA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "selectedMethodA");
			NightSceneDebugConsole.NativeFieldInfoPtr_isBuffBExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isBuffBExpaneded");
			NightSceneDebugConsole.NativeFieldInfoPtr_isMethodBExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isMethodBExpaneded");
			NightSceneDebugConsole.NativeFieldInfoPtr_selectedMethodB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "selectedMethodB");
			NightSceneDebugConsole.NativeFieldInfoPtr_isBuffCExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isBuffCExpaneded");
			NightSceneDebugConsole.NativeFieldInfoPtr_isMethodCExpaneded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "isMethodCExpaneded");
			NightSceneDebugConsole.NativeFieldInfoPtr_selectedMethodC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "selectedMethodC");
			NightSceneDebugConsole.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664513);
			NightSceneDebugConsole.NativeMethodInfoPtr_OnStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664514);
			NightSceneDebugConsole.NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664515);
			NightSceneDebugConsole.NativeMethodInfoPtr_DrawConsolePannelNew_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664516);
			NightSceneDebugConsole.NativeMethodInfoPtr_DrawBuffNew_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664517);
			NightSceneDebugConsole.NativeMethodInfoPtr_ToggleFoldOut_Private_Void_String_Action_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664518);
			NightSceneDebugConsole.NativeMethodInfoPtr_Buttons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664519);
			NightSceneDebugConsole.NativeMethodInfoPtr_Guests_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664520);
			NightSceneDebugConsole.NativeMethodInfoPtr_Partners_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664521);
			NightSceneDebugConsole.NativeMethodInfoPtr_InitPartners_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664522);
			NightSceneDebugConsole.NativeMethodInfoPtr_Buffs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664523);
			NightSceneDebugConsole.NativeMethodInfoPtr_InitBuffs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664524);
			NightSceneDebugConsole.NativeMethodInfoPtr_BuffPass_Private_Void_String_byref_MethodInfo_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664525);
			NightSceneDebugConsole.NativeMethodInfoPtr_DrawForTargetobject_Private_Void_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664526);
			NightSceneDebugConsole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, 100664527);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000B6BA0 File Offset: 0x000B4DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30686, XrefRangeEnd = 30687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000B6BD4 File Offset: 0x000B4DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30687, XrefRangeEnd = 30695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NightSceneDebugConsole.NativeMethodInfoPtr_OnStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000B6C10 File Offset: 0x000B4E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30695, XrefRangeEnd = 30696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrawDebugConsole()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NightSceneDebugConsole.NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000B6C4C File Offset: 0x000B4E4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30780, RefRangeEnd = 30781, XrefRangeStart = 30696, XrefRangeEnd = 30780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawConsolePannelNew()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_DrawConsolePannelNew_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000B6C80 File Offset: 0x000B4E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30781, XrefRangeEnd = 30814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawBuffNew()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_DrawBuffNew_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000B6CB4 File Offset: 0x000B4EB4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 30838, RefRangeEnd = 30846, XrefRangeStart = 30814, XrefRangeEnd = 30838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleFoldOut(string displayName, Action drawDataCallback, ref bool currentToggleState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drawDataCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentToggleState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_ToggleFoldOut_Private_Void_String_Action_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000B6D18 File Offset: 0x000B4F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30846, XrefRangeEnd = 30987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buttons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_Buttons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000B6D4C File Offset: 0x000B4F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30987, XrefRangeEnd = 31323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Guests()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_Guests_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000B6D80 File Offset: 0x000B4F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31323, XrefRangeEnd = 31473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Partners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_Partners_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000B6DB4 File Offset: 0x000B4FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31473, XrefRangeEnd = 31479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitPartners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_InitPartners_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000B6DE8 File Offset: 0x000B4FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31479, XrefRangeEnd = 31523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buffs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_Buffs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000B6E1C File Offset: 0x000B501C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31921, RefRangeEnd = 31922, XrefRangeStart = 31523, XrefRangeEnd = 31921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitBuffs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_InitBuffs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000B6E50 File Offset: 0x000B5050
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31969, RefRangeEnd = 31972, XrefRangeStart = 31922, XrefRangeEnd = 31969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuffPass(string title, ref MethodInfo selectedMethod, ref bool isBuffExpanded, ref bool isMethodExpanded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(selectedMethod);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isBuffExpanded;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isMethodExpanded;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_BuffPass_Private_Void_String_byref_MethodInfo_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			selectedMethod = ((intPtr4 == 0) ? null : new MethodInfo(intPtr4));
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x000B6ED8 File Offset: 0x000B50D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32131, RefRangeEnd = 32132, XrefRangeStart = 31972, XrefRangeEnd = 32131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawForTargetobject(MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr_DrawForTargetobject_Private_Void_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000B6F1C File Offset: 0x000B511C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32132, XrefRangeEnd = 32155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NightSceneDebugConsole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000068D6 File Offset: 0x00004AD6
		public NightSceneDebugConsole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x000B6F58 File Offset: 0x000B5158
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x000068DF File Offset: 0x00004ADF
		public unsafe Vector2 currentPannelScrollViewPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_currentPannelScrollViewPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_currentPannelScrollViewPosition)) = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x000B6F80 File Offset: 0x000B5180
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x000068FA File Offset: 0x00004AFA
		public unsafe bool isBtnSetShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isBtnSetShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isBtnSetShown)) = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x000B6FA8 File Offset: 0x000B51A8
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00006915 File Offset: 0x00004B15
		public unsafe bool isBuffSetShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isBuffSetShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isBuffSetShown)) = value;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x000B6FD0 File Offset: 0x000B51D0
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x00006930 File Offset: 0x00004B30
		public unsafe bool isGuestSetShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isGuestSetShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isGuestSetShown)) = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x000B6FF8 File Offset: 0x000B51F8
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x0000694B File Offset: 0x00004B4B
		public unsafe bool isPartnerSetShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isPartnerSetShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isPartnerSetShown)) = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x000B7020 File Offset: 0x000B5220
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00006966 File Offset: 0x00004B66
		public unsafe bool largeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_largeMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_largeMode)) = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x000B7048 File Offset: 0x000B5248
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00006981 File Offset: 0x00004B81
		public unsafe bool shouldOnGUIBuffConsoleShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown)) = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x000B7070 File Offset: 0x000B5270
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x0000699C File Offset: 0x00004B9C
		public unsafe int selectedSpecialGuestIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_selectedSpecialGuestIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_selectedSpecialGuestIndex)) = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x000B7098 File Offset: 0x000B5298
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x000069B7 File Offset: 0x00004BB7
		public unsafe int selectedNormalGuestIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_selectedNormalGuestIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_selectedNormalGuestIndex)) = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x000B70C0 File Offset: 0x000B52C0
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x000069D2 File Offset: 0x00004BD2
		public unsafe bool isSelectedSpecialGuestExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isSelectedSpecialGuestExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isSelectedSpecialGuestExpanded)) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x000B70E8 File Offset: 0x000B52E8
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x000069ED File Offset: 0x00004BED
		public unsafe bool isSelectedNormalGuestExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isSelectedNormalGuestExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isSelectedNormalGuestExpanded)) = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x000B7110 File Offset: 0x000B5310
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00006A08 File Offset: 0x00004C08
		public unsafe Vector2 currentInDeskGuestPannelScrollViewPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_currentInDeskGuestPannelScrollViewPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_currentInDeskGuestPannelScrollViewPosition)) = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x000B7138 File Offset: 0x000B5338
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x00006A23 File Offset: 0x00004C23
		public unsafe Vector2 currentQueuedGuestPannelScrollViewPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_currentQueuedGuestPannelScrollViewPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_currentQueuedGuestPannelScrollViewPosition)) = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x000B7160 File Offset: 0x000B5360
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00006A3E File Offset: 0x00004C3E
		public unsafe Vector2 currentPartnerPannelScrollViewPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_currentPartnerPannelScrollViewPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_currentPartnerPannelScrollViewPosition)) = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x000B7188 File Offset: 0x000B5388
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00006A59 File Offset: 0x00004C59
		public unsafe IEnumerable<KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>> allPartners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_allPartners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_allPartners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x000B71B8 File Offset: 0x000B53B8
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00006A78 File Offset: 0x00004C78
		public unsafe Dictionary<MethodInfo, string> m_BuffMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_m_BuffMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MethodInfo, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_m_BuffMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000B71E8 File Offset: 0x000B53E8
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00006A97 File Offset: 0x00004C97
		public unsafe Dictionary<string, Il2CppReferenceArray<Il2CppSystem.Object>> m_BuffValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_m_BuffValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppReferenceArray<Il2CppSystem.Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_m_BuffValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000B7218 File Offset: 0x000B5418
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00006AB6 File Offset: 0x00004CB6
		public unsafe Dictionary<string, Il2CppStructArray<bool>> m_BuffValueExpansions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_m_BuffValueExpansions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppStructArray<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_m_BuffValueExpansions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x000B7248 File Offset: 0x000B5448
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00006AD5 File Offset: 0x00004CD5
		public unsafe bool isBuffAExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isBuffAExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isBuffAExpaneded)) = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x000B7270 File Offset: 0x000B5470
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00006AF0 File Offset: 0x00004CF0
		public unsafe bool isMethodAExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isMethodAExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isMethodAExpaneded)) = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000B7298 File Offset: 0x000B5498
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00006B0B File Offset: 0x00004D0B
		public unsafe MethodInfo selectedMethodA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_selectedMethodA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_selectedMethodA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x000B72C8 File Offset: 0x000B54C8
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00006B2A File Offset: 0x00004D2A
		public unsafe bool isBuffBExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isBuffBExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isBuffBExpaneded)) = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000B72F0 File Offset: 0x000B54F0
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00006B45 File Offset: 0x00004D45
		public unsafe bool isMethodBExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isMethodBExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isMethodBExpaneded)) = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x000B7318 File Offset: 0x000B5518
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00006B60 File Offset: 0x00004D60
		public unsafe MethodInfo selectedMethodB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_selectedMethodB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_selectedMethodB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x000B7348 File Offset: 0x000B5548
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00006B7F File Offset: 0x00004D7F
		public unsafe bool isBuffCExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isBuffCExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isBuffCExpaneded)) = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000B7370 File Offset: 0x000B5570
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00006B9A File Offset: 0x00004D9A
		public unsafe bool isMethodCExpaneded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isMethodCExpaneded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_isMethodCExpaneded)) = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000B7398 File Offset: 0x000B5598
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00006BB5 File Offset: 0x00004DB5
		public unsafe MethodInfo selectedMethodC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_selectedMethodC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDebugConsole.NativeFieldInfoPtr_selectedMethodC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_currentPannelScrollViewPosition;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_isBtnSetShown;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_isBuffSetShown;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_isGuestSetShown;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_isPartnerSetShown;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_largeMode;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr_selectedSpecialGuestIndex;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr_selectedNormalGuestIndex;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr_isSelectedSpecialGuestExpanded;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr_isSelectedNormalGuestExpanded;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr_currentInDeskGuestPannelScrollViewPosition;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_currentQueuedGuestPannelScrollViewPosition;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_currentPartnerPannelScrollViewPosition;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr_allPartners;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeFieldInfoPtr_m_BuffMethods;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeFieldInfoPtr_m_BuffValues;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeFieldInfoPtr_m_BuffValueExpansions;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr_isBuffAExpaneded;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeFieldInfoPtr_isMethodAExpaneded;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr_selectedMethodA;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr_isBuffBExpaneded;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_isMethodBExpaneded;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr_selectedMethodB;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeFieldInfoPtr_isBuffCExpaneded;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_isMethodCExpaneded;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeFieldInfoPtr_selectedMethodC;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_OnStart_Protected_Virtual_Void_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Virtual_Void_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_DrawConsolePannelNew_Private_Void_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_DrawBuffNew_Private_Void_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_ToggleFoldOut_Private_Void_String_Action_byref_Boolean_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_Buttons_Private_Void_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_Guests_Private_Void_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_Partners_Private_Void_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_InitPartners_Private_Void_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_Buffs_Private_Void_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_InitBuffs_Private_Void_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_BuffPass_Private_Void_String_byref_MethodInfo_byref_Boolean_byref_Boolean_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_DrawForTargetobject_Private_Void_MethodInfo_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004F6 RID: 1270
		[ObfuscatedName("PrototypingManagers.NightSceneDebugConsole+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060082BF RID: 33471 RVA: 0x0024D090 File Offset: 0x0024B290
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDebugConsole>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr);
				NightSceneDebugConsole.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, "<>9");
				NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, "<>9__20_0");
				NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, "<>9__20_1");
				NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, "<>9__20_2");
				NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, "<>9__20_3");
				NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, "<>9__20_4");
				NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, "<>9__20_5");
				NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, "<>9__23_0");
				NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, "<>9__23_1");
				NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, "<>9__39_0");
				NightSceneDebugConsole.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, 100664529);
				NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_0_Internal_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, 100664530);
				NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_1_Internal_String_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, 100664531);
				NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_2_Internal_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, 100664532);
				NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_3_Internal_String_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, 100664533);
				NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_4_Internal_Boolean_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, 100664534);
				NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_5_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, 100664535);
				NightSceneDebugConsole.__c.NativeMethodInfoPtr__Partners_b__23_0_Internal_String_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, 100664536);
				NightSceneDebugConsole.__c.NativeMethodInfoPtr__Partners_b__23_1_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, 100664537);
				NightSceneDebugConsole.__c.NativeMethodInfoPtr__BuffPass_b__39_0_Internal_Boolean_MethodInfo_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr, 100664538);
			}

			// Token: 0x060082C0 RID: 33472 RVA: 0x0024D24C File Offset: 0x0024B44C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDebugConsole.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060082C1 RID: 33473 RVA: 0x0024D288 File Offset: 0x0024B488
			[CallerCount(0)]
			public unsafe int _Guests_b__20_0(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_0_Internal_Int32_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060082C2 RID: 33474 RVA: 0x0024D2D8 File Offset: 0x0024B4D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30666, XrefRangeEnd = 30668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Guests_b__20_1(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_1_Internal_String_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082C3 RID: 33475 RVA: 0x0024D320 File Offset: 0x0024B520
			[CallerCount(0)]
			public unsafe int _Guests_b__20_2(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_2_Internal_Int32_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060082C4 RID: 33476 RVA: 0x0024D370 File Offset: 0x0024B570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Guests_b__20_3(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_3_Internal_String_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082C5 RID: 33477 RVA: 0x0024D3B8 File Offset: 0x0024B5B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30668, XrefRangeEnd = 30669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Guests_b__20_4(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_4_Internal_Boolean_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060082C6 RID: 33478 RVA: 0x0024D408 File Offset: 0x0024B608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30669, XrefRangeEnd = 30670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Guests_b__20_5(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.__c.NativeMethodInfoPtr__Guests_b__20_5_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060082C7 RID: 33479 RVA: 0x0024D44C File Offset: 0x0024B64C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30670, XrefRangeEnd = 30673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Partners_b__23_0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.__c.NativeMethodInfoPtr__Partners_b__23_0_Internal_String_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082C8 RID: 33480 RVA: 0x0024D494 File Offset: 0x0024B694
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 30674, RefRangeEnd = 30684, XrefRangeStart = 30673, XrefRangeEnd = 30674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Partners_b__23_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.__c.NativeMethodInfoPtr__Partners_b__23_1_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060082C9 RID: 33481 RVA: 0x0024D4D8 File Offset: 0x0024B6D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30684, XrefRangeEnd = 30686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BuffPass_b__39_0(MethodInfo a, MethodInfo b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugConsole.__c.NativeMethodInfoPtr__BuffPass_b__39_0_Internal_Boolean_MethodInfo_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060082CA RID: 33482 RVA: 0x0004694C File Offset: 0x00044B4C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BFF RID: 11263
			// (get) Token: 0x060082CB RID: 33483 RVA: 0x0024D538 File Offset: 0x0024B738
			// (set) Token: 0x060082CC RID: 33484 RVA: 0x00046955 File Offset: 0x00044B55
			public unsafe static NightSceneDebugConsole.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneDebugConsole.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C00 RID: 11264
			// (get) Token: 0x060082CD RID: 33485 RVA: 0x0024D560 File Offset: 0x0024B760
			// (set) Token: 0x060082CE RID: 33486 RVA: 0x00046967 File Offset: 0x00044B67
			public unsafe static Func<NormalGuest, int> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C01 RID: 11265
			// (get) Token: 0x060082CF RID: 33487 RVA: 0x0024D588 File Offset: 0x0024B788
			// (set) Token: 0x060082D0 RID: 33488 RVA: 0x00046979 File Offset: 0x00044B79
			public unsafe static Func<NormalGuest, string> __9__20_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C02 RID: 11266
			// (get) Token: 0x060082D1 RID: 33489 RVA: 0x0024D5B0 File Offset: 0x0024B7B0
			// (set) Token: 0x060082D2 RID: 33490 RVA: 0x0004698B File Offset: 0x00044B8B
			public unsafe static Func<SpecialGuest, int> __9__20_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C03 RID: 11267
			// (get) Token: 0x060082D3 RID: 33491 RVA: 0x0024D5D8 File Offset: 0x0024B7D8
			// (set) Token: 0x060082D4 RID: 33492 RVA: 0x0004699D File Offset: 0x00044B9D
			public unsafe static Func<SpecialGuest, string> __9__20_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C04 RID: 11268
			// (get) Token: 0x060082D5 RID: 33493 RVA: 0x0024D600 File Offset: 0x0024B800
			// (set) Token: 0x060082D6 RID: 33494 RVA: 0x000469AF File Offset: 0x00044BAF
			public unsafe static Func<AStarInputGeneratorComponent, bool> __9__20_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AStarInputGeneratorComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C05 RID: 11269
			// (get) Token: 0x060082D7 RID: 33495 RVA: 0x0024D628 File Offset: 0x0024B828
			// (set) Token: 0x060082D8 RID: 33496 RVA: 0x000469C1 File Offset: 0x00044BC1
			public unsafe static Action<AStarInputGeneratorComponent> __9__20_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__20_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C06 RID: 11270
			// (get) Token: 0x060082D9 RID: 33497 RVA: 0x0024D650 File Offset: 0x0024B850
			// (set) Token: 0x060082DA RID: 33498 RVA: 0x000469D3 File Offset: 0x00044BD3
			public unsafe static Func<CookController, string> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C07 RID: 11271
			// (get) Token: 0x060082DB RID: 33499 RVA: 0x0024D678 File Offset: 0x0024B878
			// (set) Token: 0x060082DC RID: 33500 RVA: 0x000469E5 File Offset: 0x00044BE5
			public unsafe static Func<int, string> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C08 RID: 11272
			// (get) Token: 0x060082DD RID: 33501 RVA: 0x0024D6A0 File Offset: 0x0024B8A0
			// (set) Token: 0x060082DE RID: 33502 RVA: 0x000469F7 File Offset: 0x00044BF7
			public unsafe static Func<MethodInfo, MethodInfo, bool> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MethodInfo, MethodInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugConsole.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040055A5 RID: 21925
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040055A6 RID: 21926
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x040055A7 RID: 21927
			private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

			// Token: 0x040055A8 RID: 21928
			private static readonly IntPtr NativeFieldInfoPtr___9__20_2;

			// Token: 0x040055A9 RID: 21929
			private static readonly IntPtr NativeFieldInfoPtr___9__20_3;

			// Token: 0x040055AA RID: 21930
			private static readonly IntPtr NativeFieldInfoPtr___9__20_4;

			// Token: 0x040055AB RID: 21931
			private static readonly IntPtr NativeFieldInfoPtr___9__20_5;

			// Token: 0x040055AC RID: 21932
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x040055AD RID: 21933
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x040055AE RID: 21934
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040055AF RID: 21935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040055B0 RID: 21936
			private static readonly IntPtr NativeMethodInfoPtr__Guests_b__20_0_Internal_Int32_NormalGuest_0;

			// Token: 0x040055B1 RID: 21937
			private static readonly IntPtr NativeMethodInfoPtr__Guests_b__20_1_Internal_String_NormalGuest_0;

			// Token: 0x040055B2 RID: 21938
			private static readonly IntPtr NativeMethodInfoPtr__Guests_b__20_2_Internal_Int32_SpecialGuest_0;

			// Token: 0x040055B3 RID: 21939
			private static readonly IntPtr NativeMethodInfoPtr__Guests_b__20_3_Internal_String_SpecialGuest_0;

			// Token: 0x040055B4 RID: 21940
			private static readonly IntPtr NativeMethodInfoPtr__Guests_b__20_4_Internal_Boolean_AStarInputGeneratorComponent_0;

			// Token: 0x040055B5 RID: 21941
			private static readonly IntPtr NativeMethodInfoPtr__Guests_b__20_5_Internal_Void_AStarInputGeneratorComponent_0;

			// Token: 0x040055B6 RID: 21942
			private static readonly IntPtr NativeMethodInfoPtr__Partners_b__23_0_Internal_String_CookController_0;

			// Token: 0x040055B7 RID: 21943
			private static readonly IntPtr NativeMethodInfoPtr__Partners_b__23_1_Internal_String_Int32_0;

			// Token: 0x040055B8 RID: 21944
			private static readonly IntPtr NativeMethodInfoPtr__BuffPass_b__39_0_Internal_Boolean_MethodInfo_MethodInfo_0;
		}
	}
}
