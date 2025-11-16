using System;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.RunTime.DaySceneUtility.Collection
{
	// Token: 0x02000226 RID: 550
	[Serializable]
	public class TrackedNPC : Il2CppSystem.Object
	{
		// Token: 0x06004174 RID: 16756 RVA: 0x0017E7FC File Offset: 0x0017C9FC
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedNPC()
		{
			Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.DaySceneUtility.Collection", "TrackedNPC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr);
			TrackedNPC.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, "key");
			TrackedNPC.NativeFieldInfoPtr_openStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, "openStatus");
			TrackedNPC.NativeFieldInfoPtr_currentDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, "currentDestination");
			TrackedNPC.NativeFieldInfoPtr_stayedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, "stayedDays");
			TrackedNPC.NativeFieldInfoPtr_restDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, "restDays");
			TrackedNPC.NativeFieldInfoPtr_dialogPackagePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, "dialogPackagePool");
			TrackedNPC.NativeFieldInfoPtr_overridePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, "overridePosition");
			TrackedNPC.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675658);
			TrackedNPC.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675659);
			TrackedNPC.NativeMethodInfoPtr__ctor_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675660);
			TrackedNPC.NativeMethodInfoPtr_ToString_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675661);
			TrackedNPC.NativeMethodInfoPtr_GetVisual_Public_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675662);
			TrackedNPC.NativeMethodInfoPtr_UpdateTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675663);
			TrackedNPC.NativeMethodInfoPtr_InitializeDestination_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675664);
			TrackedNPC.NativeMethodInfoPtr_ShouldShown_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675665);
			TrackedNPC.NativeMethodInfoPtr_AddDialogPackage_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675666);
			TrackedNPC.NativeMethodInfoPtr_RemoveDialogPackage_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675667);
			TrackedNPC.NativeMethodInfoPtr_SetDialogPackage_Public_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, 100675668);
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x0017E994 File Offset: 0x0017CB94
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedNPC() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x0017E9D0 File Offset: 0x0017CBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161345, XrefRangeEnd = 161403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrackedNPC Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedNPC>(intPtr3) : null;
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x0017EA10 File Offset: 0x0017CC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161454, RefRangeEnd = 161455, XrefRangeStart = 161403, XrefRangeEnd = 161454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedNPC(NPC npcData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(npcData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr__ctor_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x0017EA60 File Offset: 0x0017CC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161558, RefRangeEnd = 161559, XrefRangeStart = 161455, XrefRangeEnd = 161558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(int remaindActions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref remaindActions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr_ToString_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x0017EAA4 File Offset: 0x0017CCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161559, XrefRangeEnd = 161567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSpriteSetCompact GetVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr_GetVisual_Public_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x0017EAE4 File Offset: 0x0017CCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161567, XrefRangeEnd = 161579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr_UpdateTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x0017EB18 File Offset: 0x0017CD18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161584, RefRangeEnd = 161587, XrefRangeStart = 161579, XrefRangeEnd = 161584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr_InitializeDestination_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x0017EB4C File Offset: 0x0017CD4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161600, RefRangeEnd = 161603, XrefRangeStart = 161587, XrefRangeEnd = 161600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldShown(int remainedActions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref remainedActions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr_ShouldShown_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x0017EB98 File Offset: 0x0017CD98
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 161622, RefRangeEnd = 161629, XrefRangeStart = 161603, XrefRangeEnd = 161622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDialogPackage(string destination, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(destination);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr_AddDialogPackage_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x0017EBEC File Offset: 0x0017CDEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 161667, RefRangeEnd = 161673, XrefRangeStart = 161629, XrefRangeEnd = 161667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDialogPackage(string destination, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(destination);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr_RemoveDialogPackage_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x0017EC40 File Offset: 0x0017CE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161673, XrefRangeEnd = 161682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDialogPackage(string destination, Il2CppStringArray keys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(destination);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keys);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.NativeMethodInfoPtr_SetDialogPackage_Public_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x00023776 File Offset: 0x00021976
		public TrackedNPC(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06004181 RID: 16769 RVA: 0x0017EC94 File Offset: 0x0017CE94
		// (set) Token: 0x06004182 RID: 16770 RVA: 0x0002377F File Offset: 0x0002197F
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06004183 RID: 16771 RVA: 0x0017ECBC File Offset: 0x0017CEBC
		// (set) Token: 0x06004184 RID: 16772 RVA: 0x0002379E File Offset: 0x0002199E
		public unsafe bool openStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_openStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_openStatus)) = value;
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06004185 RID: 16773 RVA: 0x0017ECE4 File Offset: 0x0017CEE4
		// (set) Token: 0x06004186 RID: 16774 RVA: 0x000237B9 File Offset: 0x000219B9
		public NPC.Destination currentDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_currentDestination);
				return new NPC.Destination(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_currentDestination), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NPC.Destination>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06004187 RID: 16775 RVA: 0x0017ED14 File Offset: 0x0017CF14
		// (set) Token: 0x06004188 RID: 16776 RVA: 0x000237E7 File Offset: 0x000219E7
		public unsafe int stayedDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_stayedDays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_stayedDays)) = value;
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06004189 RID: 16777 RVA: 0x0017ED3C File Offset: 0x0017CF3C
		// (set) Token: 0x0600418A RID: 16778 RVA: 0x00023802 File Offset: 0x00021A02
		public unsafe int restDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_restDays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_restDays)) = value;
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x0017ED64 File Offset: 0x0017CF64
		// (set) Token: 0x0600418C RID: 16780 RVA: 0x0002381D File Offset: 0x00021A1D
		public unsafe Dictionary<string, Tuple<string, Il2CppStringArray>> dialogPackagePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_dialogPackagePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Tuple<string, Il2CppStringArray>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_dialogPackagePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x0600418D RID: 16781 RVA: 0x0017ED94 File Offset: 0x0017CF94
		// (set) Token: 0x0600418E RID: 16782 RVA: 0x0002383C File Offset: 0x00021A3C
		public unsafe TrackedNPC.OverridePosition overridePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_overridePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedNPC.OverridePosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.NativeFieldInfoPtr_overridePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C18 RID: 11288
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04002C19 RID: 11289
		private static readonly IntPtr NativeFieldInfoPtr_openStatus;

		// Token: 0x04002C1A RID: 11290
		private static readonly IntPtr NativeFieldInfoPtr_currentDestination;

		// Token: 0x04002C1B RID: 11291
		private static readonly IntPtr NativeFieldInfoPtr_stayedDays;

		// Token: 0x04002C1C RID: 11292
		private static readonly IntPtr NativeFieldInfoPtr_restDays;

		// Token: 0x04002C1D RID: 11293
		private static readonly IntPtr NativeFieldInfoPtr_dialogPackagePool;

		// Token: 0x04002C1E RID: 11294
		private static readonly IntPtr NativeFieldInfoPtr_overridePosition;

		// Token: 0x04002C1F RID: 11295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C20 RID: 11296
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedNPC_0;

		// Token: 0x04002C21 RID: 11297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NPC_0;

		// Token: 0x04002C22 RID: 11298
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_Int32_0;

		// Token: 0x04002C23 RID: 11299
		private static readonly IntPtr NativeMethodInfoPtr_GetVisual_Public_CharacterSpriteSetCompact_0;

		// Token: 0x04002C24 RID: 11300
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTime_Public_Void_0;

		// Token: 0x04002C25 RID: 11301
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDestination_Public_Void_0;

		// Token: 0x04002C26 RID: 11302
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShown_Public_Boolean_Int32_0;

		// Token: 0x04002C27 RID: 11303
		private static readonly IntPtr NativeMethodInfoPtr_AddDialogPackage_Public_Void_String_String_0;

		// Token: 0x04002C28 RID: 11304
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDialogPackage_Public_Void_String_String_0;

		// Token: 0x04002C29 RID: 11305
		private static readonly IntPtr NativeMethodInfoPtr_SetDialogPackage_Public_Void_String_Il2CppStringArray_0;

		// Token: 0x020009F7 RID: 2551
		[Serializable]
		public class OverridePosition : Il2CppSystem.Object
		{
			// Token: 0x0600C329 RID: 49961 RVA: 0x00309874 File Offset: 0x00307A74
			// Note: this type is marked as 'beforefieldinit'.
			static OverridePosition()
			{
				Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, "OverridePosition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr);
				TrackedNPC.OverridePosition.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr, "mapLabel");
				TrackedNPC.OverridePosition.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr, "position");
				TrackedNPC.OverridePosition.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr, "rotation");
				TrackedNPC.OverridePosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr, 100675669);
				TrackedNPC.OverridePosition.NativeMethodInfoPtr__ctor_Public_Void_String_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr, 100675670);
				TrackedNPC.OverridePosition.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr, 100675671);
				TrackedNPC.OverridePosition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr, 100675672);
				TrackedNPC.OverridePosition.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_OverridePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr, 100675673);
			}

			// Token: 0x0600C32A RID: 49962 RVA: 0x00309940 File Offset: 0x00307B40
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OverridePosition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.OverridePosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C32B RID: 49963 RVA: 0x0030997C File Offset: 0x00307B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161211, XrefRangeEnd = 161216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OverridePosition(string mapLabel, Vector2 position, int rotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedNPC.OverridePosition>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.OverridePosition.NativeMethodInfoPtr__ctor_Public_Void_String_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F82 RID: 16258
			// (get) Token: 0x0600C32C RID: 49964 RVA: 0x003099E4 File Offset: 0x00307BE4
			public unsafe Vector2 Position
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 161218, RefRangeEnd = 161222, XrefRangeStart = 161216, XrefRangeEnd = 161218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.OverridePosition.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C32D RID: 49965 RVA: 0x00309A20 File Offset: 0x00307C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161222, XrefRangeEnd = 161231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedNPC.OverridePosition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C32E RID: 49966 RVA: 0x00309A64 File Offset: 0x00307C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161231, XrefRangeEnd = 161245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual TrackedNPC.OverridePosition Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.OverridePosition.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_OverridePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedNPC.OverridePosition>(intPtr3) : null;
			}

			// Token: 0x0600C32F RID: 49967 RVA: 0x000692DF File Offset: 0x000674DF
			public OverridePosition(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F7F RID: 16255
			// (get) Token: 0x0600C330 RID: 49968 RVA: 0x00309AA4 File Offset: 0x00307CA4
			// (set) Token: 0x0600C331 RID: 49969 RVA: 0x000692E8 File Offset: 0x000674E8
			public unsafe string mapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.OverridePosition.NativeFieldInfoPtr_mapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.OverridePosition.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F80 RID: 16256
			// (get) Token: 0x0600C332 RID: 49970 RVA: 0x00309ACC File Offset: 0x00307CCC
			// (set) Token: 0x0600C333 RID: 49971 RVA: 0x00069307 File Offset: 0x00067507
			public KeyValuePair<float, float> position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.OverridePosition.NativeFieldInfoPtr_position);
					return new KeyValuePair<float, float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<float, float>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.OverridePosition.NativeFieldInfoPtr_position), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<float, float>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003F81 RID: 16257
			// (get) Token: 0x0600C334 RID: 49972 RVA: 0x00309AFC File Offset: 0x00307CFC
			// (set) Token: 0x0600C335 RID: 49973 RVA: 0x00069335 File Offset: 0x00067535
			public unsafe int rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.OverridePosition.NativeFieldInfoPtr_rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedNPC.OverridePosition.NativeFieldInfoPtr_rotation)) = value;
				}
			}

			// Token: 0x04007D95 RID: 32149
			private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

			// Token: 0x04007D96 RID: 32150
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04007D97 RID: 32151
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x04007D98 RID: 32152
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D99 RID: 32153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector2_Int32_0;

			// Token: 0x04007D9A RID: 32154
			private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector2_0;

			// Token: 0x04007D9B RID: 32155
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04007D9C RID: 32156
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_OverridePosition_0;
		}

		// Token: 0x020009F8 RID: 2552
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.Collection.TrackedNPC+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C336 RID: 49974 RVA: 0x00309B24 File Offset: 0x00307D24
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackedNPC>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr);
				TrackedNPC.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr, "<>9");
				TrackedNPC.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr, "<>9__9_0");
				TrackedNPC.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr, "<>9__9_1");
				TrackedNPC.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr, "<>9__10_0");
				TrackedNPC.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr, "<>9__10_1");
				TrackedNPC.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr, 100675675);
				TrackedNPC.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_String_Destination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr, 100675676);
				TrackedNPC.__c.NativeMethodInfoPtr___ctor_b__9_1_Internal_Tuple_2_String_Il2CppStringArray_Destination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr, 100675677);
				TrackedNPC.__c.NativeMethodInfoPtr__ToString_b__10_0_Internal_String_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr, 100675678);
				TrackedNPC.__c.NativeMethodInfoPtr__ToString_b__10_1_Internal_String_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr, 100675679);
			}

			// Token: 0x0600C337 RID: 49975 RVA: 0x00309C18 File Offset: 0x00307E18
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedNPC.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C338 RID: 49976 RVA: 0x00309C54 File Offset: 0x00307E54
			[CallerCount(0)]
			public unsafe string __ctor_b__9_0(NPC.Destination x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_String_Destination_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C339 RID: 49977 RVA: 0x00309CA4 File Offset: 0x00307EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161245, XrefRangeEnd = 161253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Tuple<string, Il2CppStringArray> __ctor_b__9_1(NPC.Destination x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.__c.NativeMethodInfoPtr___ctor_b__9_1_Internal_Tuple_2_String_Il2CppStringArray_Destination_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<string, Il2CppStringArray>>(intPtr3) : null;
			}

			// Token: 0x0600C33A RID: 49978 RVA: 0x00309CFC File Offset: 0x00307EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161253, XrefRangeEnd = 161299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__10_0(KeyValuePair<string, Tuple<string, Il2CppStringArray>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.__c.NativeMethodInfoPtr__ToString_b__10_0_Internal_String_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C33B RID: 49979 RVA: 0x00309D4C File Offset: 0x00307F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161299, XrefRangeEnd = 161345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__10_1(KeyValuePair<string, Tuple<string, Il2CppStringArray>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedNPC.__c.NativeMethodInfoPtr__ToString_b__10_1_Internal_String_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C33C RID: 49980 RVA: 0x00069350 File Offset: 0x00067550
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F83 RID: 16259
			// (get) Token: 0x0600C33D RID: 49981 RVA: 0x00309D9C File Offset: 0x00307F9C
			// (set) Token: 0x0600C33E RID: 49982 RVA: 0x00069359 File Offset: 0x00067559
			public unsafe static TrackedNPC.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedNPC.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedNPC.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedNPC.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F84 RID: 16260
			// (get) Token: 0x0600C33F RID: 49983 RVA: 0x00309DC4 File Offset: 0x00307FC4
			// (set) Token: 0x0600C340 RID: 49984 RVA: 0x0006936B File Offset: 0x0006756B
			public unsafe static Func<NPC.Destination, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedNPC.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC.Destination, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedNPC.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F85 RID: 16261
			// (get) Token: 0x0600C341 RID: 49985 RVA: 0x00309DEC File Offset: 0x00307FEC
			// (set) Token: 0x0600C342 RID: 49986 RVA: 0x0006937D File Offset: 0x0006757D
			public unsafe static Func<NPC.Destination, Tuple<string, Il2CppStringArray>> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedNPC.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC.Destination, Tuple<string, Il2CppStringArray>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedNPC.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F86 RID: 16262
			// (get) Token: 0x0600C343 RID: 49987 RVA: 0x00309E14 File Offset: 0x00308014
			// (set) Token: 0x0600C344 RID: 49988 RVA: 0x0006938F File Offset: 0x0006758F
			public unsafe static Func<KeyValuePair<string, Tuple<string, Il2CppStringArray>>, string> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedNPC.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Tuple<string, Il2CppStringArray>>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedNPC.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F87 RID: 16263
			// (get) Token: 0x0600C345 RID: 49989 RVA: 0x00309E3C File Offset: 0x0030803C
			// (set) Token: 0x0600C346 RID: 49990 RVA: 0x000693A1 File Offset: 0x000675A1
			public unsafe static Func<KeyValuePair<string, Tuple<string, Il2CppStringArray>>, string> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedNPC.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Tuple<string, Il2CppStringArray>>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedNPC.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D9D RID: 32157
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007D9E RID: 32158
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04007D9F RID: 32159
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04007DA0 RID: 32160
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04007DA1 RID: 32161
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04007DA2 RID: 32162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DA3 RID: 32163
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_0_Internal_String_Destination_0;

			// Token: 0x04007DA4 RID: 32164
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_1_Internal_Tuple_2_String_Il2CppStringArray_Destination_0;

			// Token: 0x04007DA5 RID: 32165
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__10_0_Internal_String_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0;

			// Token: 0x04007DA6 RID: 32166
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__10_1_Internal_String_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0;
		}
	}
}
