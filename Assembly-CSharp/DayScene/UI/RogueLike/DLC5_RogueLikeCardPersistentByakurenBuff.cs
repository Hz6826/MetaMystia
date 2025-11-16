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
	// Token: 0x020000EF RID: 239
	public class DLC5_RogueLikeCardPersistentByakurenBuff : RogueLikeCardPersistent
	{
		// Token: 0x06001B0E RID: 6926 RVA: 0x000F8E28 File Offset: 0x000F7028
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentByakurenBuff()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardPersistentByakurenBuff");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentByakurenBuff.NativeFieldInfoPtr_baseResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, "baseResult");
			DLC5_RogueLikeCardPersistentByakurenBuff.NativeFieldInfoPtr_maxResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, "maxResult");
			DLC5_RogueLikeCardPersistentByakurenBuff.NativeFieldInfoPtr_m_NoAlcoholTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, "m_NoAlcoholTag");
			DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, 100668185);
			DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, 100668186);
			DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr_RemoveMikoBuff_Private_Void_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, 100668187);
			DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, 100668188);
			DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, 100668189);
			DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, 100668190);
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x000F8F0C File Offset: 0x000F710C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71464, XrefRangeEnd = 71466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x000F8F6C File Offset: 0x000F716C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71466, XrefRangeEnd = 71471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000F8FE8 File Offset: 0x000F71E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71528, RefRangeEnd = 71529, XrefRangeStart = 71471, XrefRangeEnd = 71528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveMikoBuff(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr_RemoveMikoBuff_Private_Void_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x000F902C File Offset: 0x000F722C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71529, XrefRangeEnd = 71567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x000F90AC File Offset: 0x000F72AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71567, XrefRangeEnd = 71580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000F9134 File Offset: 0x000F7334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71580, XrefRangeEnd = 71581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentByakurenBuff() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentByakurenBuff.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0001098E File Offset: 0x0000EB8E
		public DLC5_RogueLikeCardPersistentByakurenBuff(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x000F9170 File Offset: 0x000F7370
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x00010997 File Offset: 0x0000EB97
		public unsafe GuestGroupController.EvaluationResult baseResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.NativeFieldInfoPtr_baseResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.NativeFieldInfoPtr_baseResult)) = value;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x000F9198 File Offset: 0x000F7398
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x000109B2 File Offset: 0x0000EBB2
		public unsafe GuestGroupController.EvaluationResult maxResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.NativeFieldInfoPtr_maxResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.NativeFieldInfoPtr_maxResult)) = value;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x000F91C0 File Offset: 0x000F73C0
		// (set) Token: 0x06001B1B RID: 6939 RVA: 0x000109CD File Offset: 0x0000EBCD
		public unsafe int m_NoAlcoholTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.NativeFieldInfoPtr_m_NoAlcoholTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.NativeFieldInfoPtr_m_NoAlcoholTag)) = value;
			}
		}

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeFieldInfoPtr_baseResult;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeFieldInfoPtr_maxResult;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeFieldInfoPtr_m_NoAlcoholTag;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMikoBuff_Private_Void_RogueLikeRunTimeData_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006B2 RID: 1714
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentByakurenBuff+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060098B6 RID: 39094 RVA: 0x0028C990 File Offset: 0x0028AB90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentByakurenBuff.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardPersistentByakurenBuff.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c>.NativeClassPtr, "<>9__4_0");
				DLC5_RogueLikeCardPersistentByakurenBuff.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c>.NativeClassPtr, 100668192);
				DLC5_RogueLikeCardPersistentByakurenBuff.__c.NativeMethodInfoPtr__CheckExtraConditionToShow_b__4_0_Internal_Boolean_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c>.NativeClassPtr, 100668193);
			}

			// Token: 0x060098B7 RID: 39095 RVA: 0x0028CA0C File Offset: 0x0028AC0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentByakurenBuff.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098B8 RID: 39096 RVA: 0x0028CA48 File Offset: 0x0028AC48
			[CallerCount(0)]
			public unsafe bool _CheckExtraConditionToShow_b__4_0(RogueLikeCardInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentByakurenBuff.__c.NativeMethodInfoPtr__CheckExtraConditionToShow_b__4_0_Internal_Boolean_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060098B9 RID: 39097 RVA: 0x00052A8F File Offset: 0x00050C8F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032C0 RID: 12992
			// (get) Token: 0x060098BA RID: 39098 RVA: 0x0028CA98 File Offset: 0x0028AC98
			// (set) Token: 0x060098BB RID: 39099 RVA: 0x00052A98 File Offset: 0x00050C98
			public unsafe static DLC5_RogueLikeCardPersistentByakurenBuff.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentByakurenBuff.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentByakurenBuff.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentByakurenBuff.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032C1 RID: 12993
			// (get) Token: 0x060098BC RID: 39100 RVA: 0x0028CAC0 File Offset: 0x0028ACC0
			// (set) Token: 0x060098BD RID: 39101 RVA: 0x00052AAA File Offset: 0x00050CAA
			public unsafe static Func<RogueLikeCardInstance, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentByakurenBuff.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardInstance, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentByakurenBuff.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040062EA RID: 25322
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040062EB RID: 25323
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040062EC RID: 25324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040062ED RID: 25325
			private static readonly IntPtr NativeMethodInfoPtr__CheckExtraConditionToShow_b__4_0_Internal_Boolean_RogueLikeCardInstance_0;
		}

		// Token: 0x020006B3 RID: 1715
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentByakurenBuff+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060098BE RID: 39102 RVA: 0x0028CAE8 File Offset: 0x0028ACE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr, "modifier");
				DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr, 100668194);
				DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_Boolean_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr, 100668195);
				DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__3_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr, 100668196);
				DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr, 100668197);
				DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr, 100668198);
				DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr, 100668199);
			}

			// Token: 0x060098BF RID: 39103 RVA: 0x0028CBDC File Offset: 0x0028ADDC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098C0 RID: 39104 RVA: 0x0028CC18 File Offset: 0x0028AE18
			[CallerCount(0)]
			public unsafe bool _CardEffectBeforeWorking_b__0(GuestGroupController.EvaluationResult x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_Boolean_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060098C1 RID: 39105 RVA: 0x0028CC64 File Offset: 0x0028AE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71422, XrefRangeEnd = 71435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CardEffectBeforeWorking_b__3(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__3_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060098C2 RID: 39106 RVA: 0x0028CCAC File Offset: 0x0028AEAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71435, XrefRangeEnd = 71445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CardEffectBeforeWorking_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098C3 RID: 39107 RVA: 0x0028CCE0 File Offset: 0x0028AEE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71445, XrefRangeEnd = 71457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guestGroupController)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098C4 RID: 39108 RVA: 0x0028CD24 File Offset: 0x0028AF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71457, XrefRangeEnd = 71464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_1(GuestGroupController guestGroupController)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098C5 RID: 39109 RVA: 0x00052ABC File Offset: 0x00050CBC
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032C2 RID: 12994
			// (get) Token: 0x060098C6 RID: 39110 RVA: 0x0028CD68 File Offset: 0x0028AF68
			// (set) Token: 0x060098C7 RID: 39111 RVA: 0x00052AC5 File Offset: 0x00050CC5
			public unsafe DLC5_RogueLikeCardPersistentByakurenBuff __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentByakurenBuff>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032C3 RID: 12995
			// (get) Token: 0x060098C8 RID: 39112 RVA: 0x0028CD98 File Offset: 0x0028AF98
			// (set) Token: 0x060098C9 RID: 39113 RVA: 0x00052AE4 File Offset: 0x00050CE4
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032C4 RID: 12996
			// (get) Token: 0x060098CA RID: 39114 RVA: 0x0028CDC8 File Offset: 0x0028AFC8
			// (set) Token: 0x060098CB RID: 39115 RVA: 0x00052B03 File Offset: 0x00050D03
			public EventManager.EvalModifier modifier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr_modifier);
					return new EventManager.EvalModifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.EvalModifier>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr_modifier), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.EvalModifier>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170032C5 RID: 12997
			// (get) Token: 0x060098CC RID: 39116 RVA: 0x0028CDF8 File Offset: 0x0028AFF8
			// (set) Token: 0x060098CD RID: 39117 RVA: 0x00052B31 File Offset: 0x00050D31
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentByakurenBuff.__c__DisplayClass6_0.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040062EE RID: 25326
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040062EF RID: 25327
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040062F0 RID: 25328
			private static readonly IntPtr NativeFieldInfoPtr_modifier;

			// Token: 0x040062F1 RID: 25329
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040062F2 RID: 25330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040062F3 RID: 25331
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_Boolean_EvaluationResult_0;

			// Token: 0x040062F4 RID: 25332
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__3_Internal_String_String_0;

			// Token: 0x040062F5 RID: 25333
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_Internal_Void_0;

			// Token: 0x040062F6 RID: 25334
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x040062F7 RID: 25335
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1;
		}
	}
}
