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
	// Token: 0x020000F6 RID: 246
	public class DLC5_RogueLikeCardPersistentScarletWeather : RogueLikeCardPersistent
	{
		// Token: 0x06001B5B RID: 7003 RVA: 0x000FA308 File Offset: 0x000F8508
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentScarletWeather()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardPersistentScarletWeather");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentScarletWeather.NativeFieldInfoPtr_addCardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr, "addCardNum");
			DLC5_RogueLikeCardPersistentScarletWeather.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr, 100668243);
			DLC5_RogueLikeCardPersistentScarletWeather.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr, 100668244);
			DLC5_RogueLikeCardPersistentScarletWeather.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr, 100668245);
			DLC5_RogueLikeCardPersistentScarletWeather.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr, 100668246);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x000FA39C File Offset: 0x000F859C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72223, XrefRangeEnd = 72285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentScarletWeather.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x000FA3FC File Offset: 0x000F85FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72285, XrefRangeEnd = 72300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentScarletWeather.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x000FA47C File Offset: 0x000F867C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72300, XrefRangeEnd = 72305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentScarletWeather.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x000FA504 File Offset: 0x000F8704
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentScarletWeather() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentScarletWeather.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00010B59 File Offset: 0x0000ED59
		public DLC5_RogueLikeCardPersistentScarletWeather(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x000FA540 File Offset: 0x000F8740
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x00010B62 File Offset: 0x0000ED62
		public unsafe int addCardNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentScarletWeather.NativeFieldInfoPtr_addCardNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentScarletWeather.NativeFieldInfoPtr_addCardNum)) = value;
			}
		}

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeFieldInfoPtr_addCardNum;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006B8 RID: 1720
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentScarletWeather+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x060098FB RID: 39163 RVA: 0x0028D69C File Offset: 0x0028B89C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0>.NativeClassPtr, "rogueLikeRunTimeData");
				DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0>.NativeClassPtr, 100668247);
				DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0.NativeMethodInfoPtr__AfterSelect_b__0_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0>.NativeClassPtr, 100668248);
			}

			// Token: 0x060098FC RID: 39164 RVA: 0x0028D704 File Offset: 0x0028B904
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098FD RID: 39165 RVA: 0x0028D740 File Offset: 0x0028B940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72145, XrefRangeEnd = 72150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AfterSelect_b__0(KeyValuePair<RogueLikePersistentCardInstance, int> card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(card));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0.NativeMethodInfoPtr__AfterSelect_b__0_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060098FE RID: 39166 RVA: 0x00052CBE File Offset: 0x00050EBE
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032D1 RID: 13009
			// (get) Token: 0x060098FF RID: 39167 RVA: 0x0028D794 File Offset: 0x0028B994
			// (set) Token: 0x06009900 RID: 39168 RVA: 0x00052CC7 File Offset: 0x00050EC7
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass1_0.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006312 RID: 25362
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x04006313 RID: 25363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006314 RID: 25364
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__0_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;
		}

		// Token: 0x020006B9 RID: 1721
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentScarletWeather+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06009901 RID: 39169 RVA: 0x0028D7C4 File Offset: 0x0028B9C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentScarletWeather.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardPersistentScarletWeather.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c>.NativeClassPtr, "<>9__1_1");
				DLC5_RogueLikeCardPersistentScarletWeather.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c>.NativeClassPtr, 100668250);
				DLC5_RogueLikeCardPersistentScarletWeather.__c.NativeMethodInfoPtr__AfterSelect_b__1_1_Internal_RogueLikePersistentCardInstance_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c>.NativeClassPtr, 100668251);
			}

			// Token: 0x06009902 RID: 39170 RVA: 0x0028D840 File Offset: 0x0028BA40
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentScarletWeather.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009903 RID: 39171 RVA: 0x0028D87C File Offset: 0x0028BA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72150, XrefRangeEnd = 72151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueLikePersistentCardInstance _AfterSelect_b__1_1(KeyValuePair<RogueLikePersistentCardInstance, int> card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(card));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentScarletWeather.__c.NativeMethodInfoPtr__AfterSelect_b__1_1_Internal_RogueLikePersistentCardInstance_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikePersistentCardInstance>(intPtr3) : null;
			}

			// Token: 0x06009904 RID: 39172 RVA: 0x00052CE6 File Offset: 0x00050EE6
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032D2 RID: 13010
			// (get) Token: 0x06009905 RID: 39173 RVA: 0x0028D8D4 File Offset: 0x0028BAD4
			// (set) Token: 0x06009906 RID: 39174 RVA: 0x00052CEF File Offset: 0x00050EEF
			public unsafe static DLC5_RogueLikeCardPersistentScarletWeather.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentScarletWeather.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentScarletWeather.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentScarletWeather.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032D3 RID: 13011
			// (get) Token: 0x06009907 RID: 39175 RVA: 0x0028D8FC File Offset: 0x0028BAFC
			// (set) Token: 0x06009908 RID: 39176 RVA: 0x00052D01 File Offset: 0x00050F01
			public unsafe static Func<KeyValuePair<RogueLikePersistentCardInstance, int>, RogueLikePersistentCardInstance> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentScarletWeather.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikePersistentCardInstance, int>, RogueLikePersistentCardInstance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentScarletWeather.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006315 RID: 25365
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006316 RID: 25366
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04006317 RID: 25367
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006318 RID: 25368
			private static readonly IntPtr NativeMethodInfoPtr__AfterSelect_b__1_1_Internal_RogueLikePersistentCardInstance_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;
		}

		// Token: 0x020006BA RID: 1722
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentScarletWeather+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06009909 RID: 39177 RVA: 0x0028D924 File Offset: 0x0028BB24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0.NativeFieldInfoPtr_rogueLikeCardInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0>.NativeClassPtr, "rogueLikeCardInstance");
				DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0>.NativeClassPtr, 100668252);
				DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0.NativeMethodInfoPtr_Method_Internal_Void_RogueLikeManager_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0>.NativeClassPtr, 100668253);
			}

			// Token: 0x0600990A RID: 39178 RVA: 0x0028D98C File Offset: 0x0028BB8C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600990B RID: 39179 RVA: 0x0028D9C8 File Offset: 0x0028BBC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72151, XrefRangeEnd = 72218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_RogueLikeManager_PDM_0(RogueLikeManager thisRogueLikeManager)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisRogueLikeManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0.NativeMethodInfoPtr_Method_Internal_Void_RogueLikeManager_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600990C RID: 39180 RVA: 0x00052D13 File Offset: 0x00050F13
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032D4 RID: 13012
			// (get) Token: 0x0600990D RID: 39181 RVA: 0x0028DA0C File Offset: 0x0028BC0C
			// (set) Token: 0x0600990E RID: 39182 RVA: 0x00052D1C File Offset: 0x00050F1C
			public unsafe RogueLikePersistentCardInstance rogueLikeCardInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0.NativeFieldInfoPtr_rogueLikeCardInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikePersistentCardInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_0.NativeFieldInfoPtr_rogueLikeCardInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006319 RID: 25369
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeCardInstance;

			// Token: 0x0400631A RID: 25370
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400631B RID: 25371
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_RogueLikeManager_PDM_0;
		}

		// Token: 0x020006BB RID: 1723
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentScarletWeather+<>c__DisplayClass2_1")]
		public sealed class __c__DisplayClass2_1 : Object
		{
			// Token: 0x0600990F RID: 39183 RVA: 0x0028DA3C File Offset: 0x0028BC3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather>.NativeClassPtr, "<>c__DisplayClass2_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1>.NativeClassPtr, "rogueLikeRunTimeData");
				DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1>.NativeClassPtr, 100668254);
				DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1.NativeMethodInfoPtr__CardEffectBeforeWorking_b__1_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1>.NativeClassPtr, 100668255);
			}

			// Token: 0x06009910 RID: 39184 RVA: 0x0028DAA4 File Offset: 0x0028BCA4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009911 RID: 39185 RVA: 0x0028DAE0 File Offset: 0x0028BCE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72218, XrefRangeEnd = 72223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CardEffectBeforeWorking_b__1(KeyValuePair<RogueLikePersistentCardInstance, int> card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(card));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1.NativeMethodInfoPtr__CardEffectBeforeWorking_b__1_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009912 RID: 39186 RVA: 0x00052D3B File Offset: 0x00050F3B
			public __c__DisplayClass2_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032D5 RID: 13013
			// (get) Token: 0x06009913 RID: 39187 RVA: 0x0028DB34 File Offset: 0x0028BD34
			// (set) Token: 0x06009914 RID: 39188 RVA: 0x00052D44 File Offset: 0x00050F44
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentScarletWeather.__c__DisplayClass2_1.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400631C RID: 25372
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x0400631D RID: 25373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400631E RID: 25374
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__1_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;
		}
	}
}
