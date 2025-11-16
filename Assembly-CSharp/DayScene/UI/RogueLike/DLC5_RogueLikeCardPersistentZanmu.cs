using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000F9 RID: 249
	public class DLC5_RogueLikeCardPersistentZanmu : RogueLikeCardPersistent
	{
		// Token: 0x06001B70 RID: 7024 RVA: 0x000FA8A4 File Offset: 0x000F8AA4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentZanmu()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardPersistentZanmu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentZanmu.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, "multiplier");
			DLC5_RogueLikeCardPersistentZanmu.NativeFieldInfoPtr_addCardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, "addCardNum");
			DLC5_RogueLikeCardPersistentZanmu.NativeFieldInfoPtr_addBevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, "addBevNum");
			DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, 100668270);
			DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, 100668271);
			DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, 100668272);
			DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, 100668273);
			DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, 100668274);
			DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, 100668275);
			DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr__CheckExtraConditionToShow_b__7_0_Private_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, 100668276);
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000FA99C File Offset: 0x000F8B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72409, XrefRangeEnd = 72485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x000FA9FC File Offset: 0x000F8BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000FAA7C File Offset: 0x000F8C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72485, XrefRangeEnd = 72505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000FAB04 File Offset: 0x000F8D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72505, XrefRangeEnd = 72506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x000FAB78 File Offset: 0x000F8D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72506, XrefRangeEnd = 72516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x000FABF4 File Offset: 0x000F8DF4
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentZanmu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x000FAC30 File Offset: 0x000F8E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72516, XrefRangeEnd = 72517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CheckExtraConditionToShow_b__7_0(KeyValuePair<RogueLikePersistentCardInstance, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentZanmu.NativeMethodInfoPtr__CheckExtraConditionToShow_b__7_0_Private_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00010BC5 File Offset: 0x0000EDC5
		public DLC5_RogueLikeCardPersistentZanmu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x000FAC84 File Offset: 0x000F8E84
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x00010BCE File Offset: 0x0000EDCE
		public unsafe float multiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentZanmu.NativeFieldInfoPtr_multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentZanmu.NativeFieldInfoPtr_multiplier)) = value;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x000FACAC File Offset: 0x000F8EAC
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x00010BE9 File Offset: 0x0000EDE9
		public unsafe int addCardNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentZanmu.NativeFieldInfoPtr_addCardNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentZanmu.NativeFieldInfoPtr_addCardNum)) = value;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x000FACD4 File Offset: 0x000F8ED4
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x00010C04 File Offset: 0x0000EE04
		public unsafe int addBevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentZanmu.NativeFieldInfoPtr_addBevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentZanmu.NativeFieldInfoPtr_addBevNum)) = value;
			}
		}

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeFieldInfoPtr_multiplier;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeFieldInfoPtr_addCardNum;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeFieldInfoPtr_addBevNum;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr__CheckExtraConditionToShow_b__7_0_Private_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x020006BF RID: 1727
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentZanmu+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06009931 RID: 39217 RVA: 0x0028E054 File Offset: 0x0028C254
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0>.NativeClassPtr, "rogueLikeRunTimeData");
				DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0>.NativeClassPtr, 100668277);
				DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeMethodInfoPtr__AfterSelect_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0>.NativeClassPtr, 100668278);
				DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeMethodInfoPtr__AfterSelect_b__1_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0>.NativeClassPtr, 100668279);
			}

			// Token: 0x06009932 RID: 39218 RVA: 0x0028E0E4 File Offset: 0x0028C2E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009933 RID: 39219 RVA: 0x0028E120 File Offset: 0x0028C320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72398, XrefRangeEnd = 72403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AfterSelect_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeMethodInfoPtr__AfterSelect_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009934 RID: 39220 RVA: 0x0028E160 File Offset: 0x0028C360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72403, XrefRangeEnd = 72408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AfterSelect_b__1(KeyValuePair<RogueLikePersistentCardInstance, int> card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(card));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeMethodInfoPtr__AfterSelect_b__1_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009935 RID: 39221 RVA: 0x00052E3D File Offset: 0x0005103D
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032DD RID: 13021
			// (get) Token: 0x06009936 RID: 39222 RVA: 0x0028E1B4 File Offset: 0x0028C3B4
			// (set) Token: 0x06009937 RID: 39223 RVA: 0x00052E46 File Offset: 0x00051046
			public unsafe DLC5_RogueLikeCardPersistentZanmu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentZanmu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032DE RID: 13022
			// (get) Token: 0x06009938 RID: 39224 RVA: 0x0028E1E4 File Offset: 0x0028C3E4
			// (set) Token: 0x06009939 RID: 39225 RVA: 0x00052E65 File Offset: 0x00051065
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentZanmu.__c__DisplayClass3_0.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400632E RID: 25390
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400632F RID: 25391
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x04006330 RID: 25392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006331 RID: 25393
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__0_Internal_Void_Int32_0;

			// Token: 0x04006332 RID: 25394
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__1_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;
		}

		// Token: 0x020006C0 RID: 1728
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentZanmu+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600993A RID: 39226 RVA: 0x0028E214 File Offset: 0x0028C414
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentZanmu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardPersistentZanmu.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c>.NativeClassPtr, "<>9__3_2");
				DLC5_RogueLikeCardPersistentZanmu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c>.NativeClassPtr, 100668281);
				DLC5_RogueLikeCardPersistentZanmu.__c.NativeMethodInfoPtr__AfterSelect_b__3_2_Internal_RogueLikePersistentCardInstance_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c>.NativeClassPtr, 100668282);
			}

			// Token: 0x0600993B RID: 39227 RVA: 0x0028E290 File Offset: 0x0028C490
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentZanmu.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentZanmu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600993C RID: 39228 RVA: 0x0028E2CC File Offset: 0x0028C4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72408, XrefRangeEnd = 72409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueLikePersistentCardInstance _AfterSelect_b__3_2(KeyValuePair<RogueLikePersistentCardInstance, int> card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(card));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentZanmu.__c.NativeMethodInfoPtr__AfterSelect_b__3_2_Internal_RogueLikePersistentCardInstance_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikePersistentCardInstance>(intPtr3) : null;
			}

			// Token: 0x0600993D RID: 39229 RVA: 0x00052E84 File Offset: 0x00051084
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032DF RID: 13023
			// (get) Token: 0x0600993E RID: 39230 RVA: 0x0028E324 File Offset: 0x0028C524
			// (set) Token: 0x0600993F RID: 39231 RVA: 0x00052E8D File Offset: 0x0005108D
			public unsafe static DLC5_RogueLikeCardPersistentZanmu.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentZanmu.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentZanmu.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentZanmu.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032E0 RID: 13024
			// (get) Token: 0x06009940 RID: 39232 RVA: 0x0028E34C File Offset: 0x0028C54C
			// (set) Token: 0x06009941 RID: 39233 RVA: 0x00052E9F File Offset: 0x0005109F
			public unsafe static Func<KeyValuePair<RogueLikePersistentCardInstance, int>, RogueLikePersistentCardInstance> __9__3_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentZanmu.__c.NativeFieldInfoPtr___9__3_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikePersistentCardInstance, int>, RogueLikePersistentCardInstance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentZanmu.__c.NativeFieldInfoPtr___9__3_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006333 RID: 25395
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006334 RID: 25396
			private static readonly IntPtr NativeFieldInfoPtr___9__3_2;

			// Token: 0x04006335 RID: 25397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006336 RID: 25398
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__3_2_Internal_RogueLikePersistentCardInstance_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;
		}
	}
}
