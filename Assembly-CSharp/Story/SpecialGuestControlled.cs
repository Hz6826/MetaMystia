using System;
using DEYU.Singletons;
using GameData.Core.Collections.NightSceneUtility;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Story
{
	// Token: 0x02000034 RID: 52
	public class SpecialGuestControlled : Singleton<SpecialGuestControlled>
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x000AF44C File Offset: 0x000AD64C
		// Note: this type is marked as 'beforefieldinit'.
		static SpecialGuestControlled()
		{
			Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Story", "SpecialGuestControlled");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr);
			SpecialGuestControlled.NativeFieldInfoPtr_m_SpecialGuestsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, "m_SpecialGuestsCache");
			SpecialGuestControlled.NativeFieldInfoPtr_m_ControlledSpecialGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, "m_ControlledSpecialGuests");
			SpecialGuestControlled.NativeFieldInfoPtr_m_MasterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, "m_MasterId");
			SpecialGuestControlled.NativeFieldInfoPtr_m_DisappearDayRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, "m_DisappearDayRange");
			SpecialGuestControlled.NativeFieldInfoPtr_m_DisappearNewsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, "m_DisappearNewsLabel");
			SpecialGuestControlled.NativeFieldInfoPtr_m_AppearNewsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, "m_AppearNewsLabel");
			SpecialGuestControlled.NativeFieldInfoPtr_m_DisappearReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, "m_DisappearReason");
			SpecialGuestControlled.NativeFieldInfoPtr_m_MapExclusions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, "m_MapExclusions");
			SpecialGuestControlled.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664017);
			SpecialGuestControlled.NativeMethodInfoPtr_Initialize_Public_Void_Int32_Vector2Int_String_String_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664018);
			SpecialGuestControlled.NativeMethodInfoPtr_GetMizuchiControlledGuest_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664019);
			SpecialGuestControlled.NativeMethodInfoPtr_ContainsDisappearSpecialGuests_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664020);
			SpecialGuestControlled.NativeMethodInfoPtr_ControlScheduled_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664021);
			SpecialGuestControlled.NativeMethodInfoPtr_CancelControl_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664022);
			SpecialGuestControlled.NativeMethodInfoPtr_ReleaseControl_Public_Void_String_Il2CppReferenceArray_1_ReplaceContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664023);
			SpecialGuestControlled.NativeMethodInfoPtr_TryConvertControllableSpecialGuest_Public_Boolean_SpecialGuest_byref_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664024);
			SpecialGuestControlled.NativeMethodInfoPtr_GenerateControllableSpecialGuest_Private_ControlledSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664025);
			SpecialGuestControlled.NativeMethodInfoPtr_CheckSpecialGuestUsability_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664026);
			SpecialGuestControlled.NativeMethodInfoPtr_PrintLog_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664027);
			SpecialGuestControlled.NativeMethodInfoPtr_PrintLogWarning_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664028);
			SpecialGuestControlled.NativeMethodInfoPtr_PrintLogError_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, 100664029);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x000AF620 File Offset: 0x000AD820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24160, XrefRangeEnd = 24222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuestControlled() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000AF65C File Offset: 0x000AD85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24287, RefRangeEnd = 24288, XrefRangeStart = 24222, XrefRangeEnd = 24287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int masterId, Vector2Int disappearDayRange, string disappearNewsLabel, string appearNewsLabel, Il2CppStringArray disappearReason, Il2CppStringArray mapExclusions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref masterId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disappearDayRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(disappearNewsLabel);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appearNewsLabel);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(disappearReason);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mapExclusions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_Initialize_Public_Void_Int32_Vector2Int_String_String_Il2CppStringArray_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000AF6F4 File Offset: 0x000AD8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24327, RefRangeEnd = 24328, XrefRangeStart = 24288, XrefRangeEnd = 24327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetMizuchiControlledGuest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_GetMizuchiControlledGuest_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000AF734 File Offset: 0x000AD934
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24338, RefRangeEnd = 24343, XrefRangeStart = 24328, XrefRangeEnd = 24338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsDisappearSpecialGuests(int specialGuestId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_ContainsDisappearSpecialGuests_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000AF780 File Offset: 0x000AD980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24343, XrefRangeEnd = 24360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControlScheduled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_ControlScheduled_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000AF7B4 File Offset: 0x000AD9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24360, XrefRangeEnd = 24382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_CancelControl_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000AF7E8 File Offset: 0x000AD9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24382, XrefRangeEnd = 24407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseControl(string newsLabel, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent> replaceContents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newsLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceContents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_ReleaseControl_Public_Void_String_Il2CppReferenceArray_1_ReplaceContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000AF83C File Offset: 0x000ADA3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24433, RefRangeEnd = 24434, XrefRangeStart = 24407, XrefRangeEnd = 24433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryConvertControllableSpecialGuest(SpecialGuest sourceSpecialGuest, out SpecialGuest destinationSpecialGuest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceSpecialGuest);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_TryConvertControllableSpecialGuest_Public_Boolean_SpecialGuest_byref_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			destinationSpecialGuest = ((intPtr4 == 0) ? null : new SpecialGuest(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000AF8AC File Offset: 0x000ADAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24434, XrefRangeEnd = 24458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlledSpecialGuest GenerateControllableSpecialGuest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_GenerateControllableSpecialGuest_Private_ControlledSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000AF8E8 File Offset: 0x000ADAE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24484, RefRangeEnd = 24486, XrefRangeStart = 24458, XrefRangeEnd = 24484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckSpecialGuestUsability(int specialGuestId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_CheckSpecialGuestUsability_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000AF934 File Offset: 0x000ADB34
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24493, RefRangeEnd = 24498, XrefRangeStart = 24486, XrefRangeEnd = 24493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrintLog(string log)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(log);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_PrintLog_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000AF96C File Offset: 0x000ADB6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24505, RefRangeEnd = 24506, XrefRangeStart = 24498, XrefRangeEnd = 24505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrintLogWarning(string log)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(log);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_PrintLogWarning_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000AF9A4 File Offset: 0x000ADBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24506, XrefRangeEnd = 24513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrintLogError(string log)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(log);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.NativeMethodInfoPtr_PrintLogError_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000050CA File Offset: 0x000032CA
		public SpecialGuestControlled(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x000AF9DC File Offset: 0x000ADBDC
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x000050D3 File Offset: 0x000032D3
		public unsafe List<SpecialGuest> m_SpecialGuestsCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_SpecialGuestsCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_SpecialGuestsCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x000AFA0C File Offset: 0x000ADC0C
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x000050F2 File Offset: 0x000032F2
		public unsafe List<ControlledSpecialGuest> m_ControlledSpecialGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_ControlledSpecialGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControlledSpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_ControlledSpecialGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x000AFA3C File Offset: 0x000ADC3C
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00005111 File Offset: 0x00003311
		public unsafe int m_MasterId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_MasterId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_MasterId)) = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x000AFA64 File Offset: 0x000ADC64
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0000512C File Offset: 0x0000332C
		public unsafe Vector2Int m_DisappearDayRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_DisappearDayRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_DisappearDayRange)) = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x000AFA8C File Offset: 0x000ADC8C
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00005147 File Offset: 0x00003347
		public unsafe string m_DisappearNewsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_DisappearNewsLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_DisappearNewsLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x000AFAB4 File Offset: 0x000ADCB4
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00005166 File Offset: 0x00003366
		public unsafe string m_AppearNewsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_AppearNewsLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_AppearNewsLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x000AFADC File Offset: 0x000ADCDC
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00005185 File Offset: 0x00003385
		public unsafe Il2CppStringArray m_DisappearReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_DisappearReason);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_DisappearReason), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x000AFB0C File Offset: 0x000ADD0C
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x000051A4 File Offset: 0x000033A4
		public unsafe Il2CppStringArray m_MapExclusions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_MapExclusions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestControlled.NativeFieldInfoPtr_m_MapExclusions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestsCache;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeFieldInfoPtr_m_ControlledSpecialGuests;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeFieldInfoPtr_m_MasterId;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr_m_DisappearDayRange;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr_m_DisappearNewsLabel;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_m_AppearNewsLabel;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeFieldInfoPtr_m_DisappearReason;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeFieldInfoPtr_m_MapExclusions;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_Vector2Int_String_String_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_GetMizuchiControlledGuest_Public_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_ContainsDisappearSpecialGuests_Public_Boolean_Int32_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_ControlScheduled_Public_Void_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_CancelControl_Public_Void_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseControl_Public_Void_String_Il2CppReferenceArray_1_ReplaceContent_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertControllableSpecialGuest_Public_Boolean_SpecialGuest_byref_SpecialGuest_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_GenerateControllableSpecialGuest_Private_ControlledSpecialGuest_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_CheckSpecialGuestUsability_Private_Boolean_Int32_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_PrintLog_Private_Static_Void_String_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_PrintLogWarning_Private_Static_Void_String_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_PrintLogError_Private_Static_Void_String_0;

		// Token: 0x020004AE RID: 1198
		public static class Callbacks : Il2CppSystem.Object
		{
			// Token: 0x06007ED8 RID: 32472 RVA: 0x00241C94 File Offset: 0x0023FE94
			// Note: this type is marked as 'beforefieldinit'.
			static Callbacks()
			{
				Il2CppClassPointerStore<SpecialGuestControlled.Callbacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, "Callbacks");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestControlled.Callbacks>.NativeClassPtr);
				SpecialGuestControlled.Callbacks.NativeMethodInfoPtr_OnBeforeIzakayaConfiguration_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled.Callbacks>.NativeClassPtr, 100664030);
				SpecialGuestControlled.Callbacks.NativeMethodInfoPtr_OnWorkEnd_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled.Callbacks>.NativeClassPtr, 100664031);
			}

			// Token: 0x06007ED9 RID: 32473 RVA: 0x00241CE8 File Offset: 0x0023FEE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24059, XrefRangeEnd = 24090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void OnBeforeIzakayaConfiguration()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.Callbacks.NativeMethodInfoPtr_OnBeforeIzakayaConfiguration_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EDA RID: 32474 RVA: 0x00241D10 File Offset: 0x0023FF10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24090, XrefRangeEnd = 24160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void OnWorkEnd()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.Callbacks.NativeMethodInfoPtr_OnWorkEnd_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EDB RID: 32475 RVA: 0x000443DC File Offset: 0x000425DC
			public Callbacks(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04005367 RID: 21351
			private static readonly IntPtr NativeMethodInfoPtr_OnBeforeIzakayaConfiguration_Public_Static_Void_0;

			// Token: 0x04005368 RID: 21352
			private static readonly IntPtr NativeMethodInfoPtr_OnWorkEnd_Public_Static_Void_0;
		}

		// Token: 0x020004AF RID: 1199
		[ObfuscatedName("Story.SpecialGuestControlled+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06007EDC RID: 32476 RVA: 0x00241D38 File Offset: 0x0023FF38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestControlled>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr);
				SpecialGuestControlled.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr, "<>9");
				SpecialGuestControlled.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr, "<>9__8_0");
				SpecialGuestControlled.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr, "<>9__10_0");
				SpecialGuestControlled.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr, "<>9__10_1");
				SpecialGuestControlled.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr, 100664033);
				SpecialGuestControlled.__c.NativeMethodInfoPtr___ctor_b__8_0_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr, 100664034);
				SpecialGuestControlled.__c.NativeMethodInfoPtr__GetMizuchiControlledGuest_b__10_0_Internal_Boolean_ControlledSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr, 100664035);
				SpecialGuestControlled.__c.NativeMethodInfoPtr__GetMizuchiControlledGuest_b__10_1_Internal_Int32_ControlledSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr, 100664036);
			}

			// Token: 0x06007EDD RID: 32477 RVA: 0x00241E04 File Offset: 0x00240004
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestControlled.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EDE RID: 32478 RVA: 0x00241E40 File Offset: 0x00240040
			[CallerCount(0)]
			public unsafe bool __ctor_b__8_0(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.__c.NativeMethodInfoPtr___ctor_b__8_0_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007EDF RID: 32479 RVA: 0x00241E90 File Offset: 0x00240090
			[CallerCount(0)]
			public unsafe bool _GetMizuchiControlledGuest_b__10_0(ControlledSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.__c.NativeMethodInfoPtr__GetMizuchiControlledGuest_b__10_0_Internal_Boolean_ControlledSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007EE0 RID: 32480 RVA: 0x00241EDC File Offset: 0x002400DC
			[CallerCount(0)]
			public unsafe int _GetMizuchiControlledGuest_b__10_1(ControlledSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestControlled.__c.NativeMethodInfoPtr__GetMizuchiControlledGuest_b__10_1_Internal_Int32_ControlledSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007EE1 RID: 32481 RVA: 0x000443E5 File Offset: 0x000425E5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AD1 RID: 10961
			// (get) Token: 0x06007EE2 RID: 32482 RVA: 0x00241F28 File Offset: 0x00240128
			// (set) Token: 0x06007EE3 RID: 32483 RVA: 0x000443EE File Offset: 0x000425EE
			public unsafe static SpecialGuestControlled.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestControlled.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestControlled.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestControlled.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AD2 RID: 10962
			// (get) Token: 0x06007EE4 RID: 32484 RVA: 0x00241F50 File Offset: 0x00240150
			// (set) Token: 0x06007EE5 RID: 32485 RVA: 0x00044400 File Offset: 0x00042600
			public unsafe static Func<SpecialGuest, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestControlled.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestControlled.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AD3 RID: 10963
			// (get) Token: 0x06007EE6 RID: 32486 RVA: 0x00241F78 File Offset: 0x00240178
			// (set) Token: 0x06007EE7 RID: 32487 RVA: 0x00044412 File Offset: 0x00042612
			public unsafe static Func<ControlledSpecialGuest, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestControlled.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ControlledSpecialGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestControlled.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AD4 RID: 10964
			// (get) Token: 0x06007EE8 RID: 32488 RVA: 0x00241FA0 File Offset: 0x002401A0
			// (set) Token: 0x06007EE9 RID: 32489 RVA: 0x00044424 File Offset: 0x00042624
			public unsafe static Func<ControlledSpecialGuest, int> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestControlled.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ControlledSpecialGuest, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestControlled.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005369 RID: 21353
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400536A RID: 21354
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400536B RID: 21355
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400536C RID: 21356
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x0400536D RID: 21357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400536E RID: 21358
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__8_0_Internal_Boolean_SpecialGuest_0;

			// Token: 0x0400536F RID: 21359
			private static readonly IntPtr NativeMethodInfoPtr__GetMizuchiControlledGuest_b__10_0_Internal_Boolean_ControlledSpecialGuest_0;

			// Token: 0x04005370 RID: 21360
			private static readonly IntPtr NativeMethodInfoPtr__GetMizuchiControlledGuest_b__10_1_Internal_Int32_ControlledSpecialGuest_0;
		}
	}
}
