using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000105 RID: 261
	[Serializable]
	public class RogueLikePersistentCardInstance : RogueLikeCardInstance
	{
		// Token: 0x06001CC0 RID: 7360 RVA: 0x000FE858 File Offset: 0x000FCA58
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikePersistentCardInstance()
		{
			Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikePersistentCardInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr);
			RogueLikePersistentCardInstance.NativeFieldInfoPtr_m_ExtraIdProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, "m_ExtraIdProperty");
			RogueLikePersistentCardInstance.NativeFieldInfoPtr_m_ExtraStringProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, "m_ExtraStringProperty");
			RogueLikePersistentCardInstance.NativeFieldInfoPtr_m_RemainingWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, "m_RemainingWave");
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_get_ExtraIdProperty_Public_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668471);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_get_ExtraStringProperty_Public_get_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668472);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_get_RemainingWave_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668473);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_set_RemainingWave_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668474);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr__ctor_Public_Void_CardType_Rarity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668475);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_ClearData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668476);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_GetCardProperty_Public_RogueLikeCardPersistent_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668477);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_OverrideBuffDescription_Public_String_RogueLikeRunTimeData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668478);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_BuffValueDescription_Public_String_RogueLikeRunTimeData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668479);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_AddToExtraIdProperty_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668480);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_AddToExtraStringProperty_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668481);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668482);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_Equal_Public_Boolean_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668483);
			RogueLikePersistentCardInstance.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr, 100668484);
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x000FE9DC File Offset: 0x000FCBDC
		public unsafe IReadOnlyList<int> ExtraIdProperty
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_get_ExtraIdProperty_Public_get_IReadOnlyList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x000FEA1C File Offset: 0x000FCC1C
		public unsafe IReadOnlyList<string> ExtraStringProperty
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_get_ExtraStringProperty_Public_get_IReadOnlyList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x000FEA5C File Offset: 0x000FCC5C
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x000FEA98 File Offset: 0x000FCC98
		public unsafe int RemainingWave
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49351, RefRangeEnd = 49352, XrefRangeStart = 49351, XrefRangeEnd = 49352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_get_RemainingWave_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_set_RemainingWave_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x000FEAD8 File Offset: 0x000FCCD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73538, RefRangeEnd = 73540, XrefRangeStart = 73523, XrefRangeEnd = 73538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikePersistentCardInstance(RogueLikeCardBase.CardType cardType, RogueLikeCardBase.Rarity rarity, int remainingWave) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikePersistentCardInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cardType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainingWave;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr__ctor_Public_Void_CardType_Rarity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x000FEB3C File Offset: 0x000FCD3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73543, RefRangeEnd = 73544, XrefRangeStart = 73540, XrefRangeEnd = 73543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_ClearData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x000FEB70 File Offset: 0x000FCD70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73548, RefRangeEnd = 73549, XrefRangeStart = 73544, XrefRangeEnd = 73548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeCardPersistent GetCardProperty(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_GetCardProperty_Public_RogueLikeCardPersistent_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeCardPersistent>(intPtr3) : null;
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x000FEBC0 File Offset: 0x000FCDC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73552, RefRangeEnd = 73553, XrefRangeStart = 73549, XrefRangeEnd = 73552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_OverrideBuffDescription_Public_String_RogueLikeRunTimeData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x000FEC18 File Offset: 0x000FCE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73556, RefRangeEnd = 73557, XrefRangeStart = 73553, XrefRangeEnd = 73556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_BuffValueDescription_Public_String_RogueLikeRunTimeData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x000FEC70 File Offset: 0x000FCE70
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 73559, RefRangeEnd = 73567, XrefRangeStart = 73557, XrefRangeEnd = 73559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToExtraIdProperty(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_AddToExtraIdProperty_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x000FECB0 File Offset: 0x000FCEB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73571, RefRangeEnd = 73572, XrefRangeStart = 73567, XrefRangeEnd = 73571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToExtraStringProperty(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_AddToExtraStringProperty_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x000FECF4 File Offset: 0x000FCEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73572, XrefRangeEnd = 73581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikePersistentCardInstance.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x000FED4C File Offset: 0x000FCF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73581, XrefRangeEnd = 73587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equal(RogueLikePersistentCardInstance rogueLikePersistentCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikePersistentCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikePersistentCardInstance.NativeMethodInfoPtr_Equal_Public_Boolean_RogueLikePersistentCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000FED9C File Offset: 0x000FCF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73587, XrefRangeEnd = 73624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RogueLikePersistentCardInstance.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00011801 File Offset: 0x0000FA01
		public RogueLikePersistentCardInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x000FEDE4 File Offset: 0x000FCFE4
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0001180A File Offset: 0x0000FA0A
		public unsafe List<int> m_ExtraIdProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikePersistentCardInstance.NativeFieldInfoPtr_m_ExtraIdProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikePersistentCardInstance.NativeFieldInfoPtr_m_ExtraIdProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x000FEE14 File Offset: 0x000FD014
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x00011829 File Offset: 0x0000FA29
		public unsafe List<string> m_ExtraStringProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikePersistentCardInstance.NativeFieldInfoPtr_m_ExtraStringProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikePersistentCardInstance.NativeFieldInfoPtr_m_ExtraStringProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x000FEE44 File Offset: 0x000FD044
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x00011848 File Offset: 0x0000FA48
		public unsafe int m_RemainingWave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikePersistentCardInstance.NativeFieldInfoPtr_m_RemainingWave);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikePersistentCardInstance.NativeFieldInfoPtr_m_RemainingWave)) = value;
			}
		}

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraIdProperty;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraStringProperty;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingWave;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraIdProperty_Public_get_IReadOnlyList_1_Int32_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraStringProperty_Public_get_IReadOnlyList_1_String_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingWave_Public_get_Int32_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_set_RemainingWave_Public_set_Void_Int32_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CardType_Rarity_Int32_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_ClearData_Public_Void_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_GetCardProperty_Public_RogueLikeCardPersistent_RogueLikeRunTimeData_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_OverrideBuffDescription_Public_String_RogueLikeRunTimeData_Int32_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_BuffValueDescription_Public_String_RogueLikeRunTimeData_Int32_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_AddToExtraIdProperty_Public_Void_Int32_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_AddToExtraStringProperty_Public_Void_String_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_Equal_Public_Boolean_RogueLikePersistentCardInstance_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
