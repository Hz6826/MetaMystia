using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Night.RogueLike;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000F3 RID: 243
	public class DLC5_RogueLikeCardPersistentMikoBuff : RogueLikeCardPersistent
	{
		// Token: 0x06001B37 RID: 6967 RVA: 0x000F9934 File Offset: 0x000F7B34
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentMikoBuff()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardPersistentMikoBuff");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_baseResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, "baseResult");
			DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_maxResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, "maxResult");
			DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_m_PremiumTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, "m_PremiumTag");
			DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_ROGUELIKE_MIKO_BUFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, "ROGUELIKE_MIKO_BUFF");
			DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, 100668218);
			DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, 100668219);
			DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr_RemoveByakurenBuff_Private_Void_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, 100668220);
			DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, 100668221);
			DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, 100668222);
			DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, 100668223);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000F9A2C File Offset: 0x000F7C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71952, XrefRangeEnd = 71953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000F9A8C File Offset: 0x000F7C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71953, XrefRangeEnd = 71971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000F9B08 File Offset: 0x000F7D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72028, RefRangeEnd = 72029, XrefRangeStart = 71971, XrefRangeEnd = 72028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveByakurenBuff(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr_RemoveByakurenBuff_Private_Void_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000F9B4C File Offset: 0x000F7D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72029, XrefRangeEnd = 72067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x000F9BCC File Offset: 0x000F7DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72067, XrefRangeEnd = 72080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000F9C54 File Offset: 0x000F7E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72080, XrefRangeEnd = 72081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentMikoBuff() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentMikoBuff.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00010A8A File Offset: 0x0000EC8A
		public DLC5_RogueLikeCardPersistentMikoBuff(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x000F9C90 File Offset: 0x000F7E90
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x00010A93 File Offset: 0x0000EC93
		public unsafe GuestGroupController.EvaluationResult baseResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_baseResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_baseResult)) = value;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x000F9CB8 File Offset: 0x000F7EB8
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x00010AAE File Offset: 0x0000ECAE
		public unsafe GuestGroupController.EvaluationResult maxResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_maxResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_maxResult)) = value;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x000F9CE0 File Offset: 0x000F7EE0
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x00010AC9 File Offset: 0x0000ECC9
		public unsafe int m_PremiumTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_m_PremiumTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_m_PremiumTag)) = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x000F9D08 File Offset: 0x000F7F08
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x00010AE4 File Offset: 0x0000ECE4
		public unsafe static string ROGUELIKE_MIKO_BUFF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_ROGUELIKE_MIKO_BUFF, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentMikoBuff.NativeFieldInfoPtr_ROGUELIKE_MIKO_BUFF, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeFieldInfoPtr_baseResult;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeFieldInfoPtr_maxResult;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeFieldInfoPtr_m_PremiumTag;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeFieldInfoPtr_ROGUELIKE_MIKO_BUFF;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_RemoveByakurenBuff_Private_Void_RogueLikeRunTimeData_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006B6 RID: 1718
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentMikoBuff+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060098E3 RID: 39139 RVA: 0x0028D204 File Offset: 0x0028B404
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentMikoBuff.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardPersistentMikoBuff.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c>.NativeClassPtr, "<>9__5_0");
				DLC5_RogueLikeCardPersistentMikoBuff.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c>.NativeClassPtr, 100668225);
				DLC5_RogueLikeCardPersistentMikoBuff.__c.NativeMethodInfoPtr__CheckExtraConditionToShow_b__5_0_Internal_Boolean_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c>.NativeClassPtr, 100668226);
			}

			// Token: 0x060098E4 RID: 39140 RVA: 0x0028D280 File Offset: 0x0028B480
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentMikoBuff.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098E5 RID: 39141 RVA: 0x0028D2BC File Offset: 0x0028B4BC
			[CallerCount(0)]
			public unsafe bool _CheckExtraConditionToShow_b__5_0(RogueLikeCardInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentMikoBuff.__c.NativeMethodInfoPtr__CheckExtraConditionToShow_b__5_0_Internal_Boolean_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060098E6 RID: 39142 RVA: 0x00052BFD File Offset: 0x00050DFD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032CB RID: 13003
			// (get) Token: 0x060098E7 RID: 39143 RVA: 0x0028D30C File Offset: 0x0028B50C
			// (set) Token: 0x060098E8 RID: 39144 RVA: 0x00052C06 File Offset: 0x00050E06
			public unsafe static DLC5_RogueLikeCardPersistentMikoBuff.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentMikoBuff.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentMikoBuff.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentMikoBuff.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032CC RID: 13004
			// (get) Token: 0x060098E9 RID: 39145 RVA: 0x0028D334 File Offset: 0x0028B534
			// (set) Token: 0x060098EA RID: 39146 RVA: 0x00052C18 File Offset: 0x00050E18
			public unsafe static Func<RogueLikeCardInstance, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentMikoBuff.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardInstance, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentMikoBuff.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006304 RID: 25348
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006305 RID: 25349
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04006306 RID: 25350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006307 RID: 25351
			private static readonly IntPtr NativeMethodInfoPtr__CheckExtraConditionToShow_b__5_0_Internal_Boolean_RogueLikeCardInstance_0;
		}

		// Token: 0x020006B7 RID: 1719
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentMikoBuff+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x060098EB RID: 39147 RVA: 0x0028D35C File Offset: 0x0028B55C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr, "modifier");
				DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr, 100668227);
				DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_Boolean_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr, 100668228);
				DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__3_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr, 100668229);
				DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr, 100668230);
				DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr, 100668231);
				DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr, 100668232);
			}

			// Token: 0x060098EC RID: 39148 RVA: 0x0028D450 File Offset: 0x0028B650
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098ED RID: 39149 RVA: 0x0028D48C File Offset: 0x0028B68C
			[CallerCount(0)]
			public unsafe bool _CardEffectBeforeWorking_b__0(GuestGroupController.EvaluationResult x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_Boolean_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060098EE RID: 39150 RVA: 0x0028D4D8 File Offset: 0x0028B6D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71910, XrefRangeEnd = 71923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CardEffectBeforeWorking_b__3(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__3_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060098EF RID: 39151 RVA: 0x0028D520 File Offset: 0x0028B720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71923, XrefRangeEnd = 71933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CardEffectBeforeWorking_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098F0 RID: 39152 RVA: 0x0028D554 File Offset: 0x0028B754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71933, XrefRangeEnd = 71945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guestGroupController)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098F1 RID: 39153 RVA: 0x0028D598 File Offset: 0x0028B798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71945, XrefRangeEnd = 71952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_1(GuestGroupController guestGroupController)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098F2 RID: 39154 RVA: 0x00052C2A File Offset: 0x00050E2A
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032CD RID: 13005
			// (get) Token: 0x060098F3 RID: 39155 RVA: 0x0028D5DC File Offset: 0x0028B7DC
			// (set) Token: 0x060098F4 RID: 39156 RVA: 0x00052C33 File Offset: 0x00050E33
			public unsafe DLC5_RogueLikeCardPersistentMikoBuff __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentMikoBuff>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032CE RID: 13006
			// (get) Token: 0x060098F5 RID: 39157 RVA: 0x0028D60C File Offset: 0x0028B80C
			// (set) Token: 0x060098F6 RID: 39158 RVA: 0x00052C52 File Offset: 0x00050E52
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032CF RID: 13007
			// (get) Token: 0x060098F7 RID: 39159 RVA: 0x0028D63C File Offset: 0x0028B83C
			// (set) Token: 0x060098F8 RID: 39160 RVA: 0x00052C71 File Offset: 0x00050E71
			public EventManager.EvalModifier modifier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr_modifier);
					return new EventManager.EvalModifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.EvalModifier>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr_modifier), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.EvalModifier>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170032D0 RID: 13008
			// (get) Token: 0x060098F9 RID: 39161 RVA: 0x0028D66C File Offset: 0x0028B86C
			// (set) Token: 0x060098FA RID: 39162 RVA: 0x00052C9F File Offset: 0x00050E9F
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentMikoBuff.__c__DisplayClass7_0.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006308 RID: 25352
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006309 RID: 25353
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x0400630A RID: 25354
			private static readonly IntPtr NativeFieldInfoPtr_modifier;

			// Token: 0x0400630B RID: 25355
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x0400630C RID: 25356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400630D RID: 25357
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_Boolean_EvaluationResult_0;

			// Token: 0x0400630E RID: 25358
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__3_Internal_String_String_0;

			// Token: 0x0400630F RID: 25359
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_Internal_Void_0;

			// Token: 0x04006310 RID: 25360
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x04006311 RID: 25361
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1;
		}
	}
}
