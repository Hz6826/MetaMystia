using System;
using DayScene.UI.RogueLike;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.EventUtility;

namespace Night.RogueLike
{
	// Token: 0x02000063 RID: 99
	public class DLC5_RogueLikeCardPersistentAddSpawnRate : RogueLikeCardPersistent
	{
		// Token: 0x06000B9F RID: 2975 RVA: 0x000C4570 File Offset: 0x000C2770
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentAddSpawnRate()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.RogueLike", "DLC5_RogueLikeCardPersistentAddSpawnRate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentAddSpawnRate.NativeFieldInfoPtr_extraSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate>.NativeClassPtr, "extraSpawnRate");
			DLC5_RogueLikeCardPersistentAddSpawnRate.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate>.NativeClassPtr, 100665224);
			DLC5_RogueLikeCardPersistentAddSpawnRate.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate>.NativeClassPtr, 100665225);
			DLC5_RogueLikeCardPersistentAddSpawnRate.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate>.NativeClassPtr, 100665226);
			DLC5_RogueLikeCardPersistentAddSpawnRate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate>.NativeClassPtr, 100665227);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000C4604 File Offset: 0x000C2804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41450, XrefRangeEnd = 41455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddSpawnRate.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000C468C File Offset: 0x000C288C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41455, XrefRangeEnd = 41468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddSpawnRate.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000C470C File Offset: 0x000C290C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddSpawnRate.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000C4780 File Offset: 0x000C2980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentAddSpawnRate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddSpawnRate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000083DD File Offset: 0x000065DD
		public DLC5_RogueLikeCardPersistentAddSpawnRate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x000C47BC File Offset: 0x000C29BC
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x000083E6 File Offset: 0x000065E6
		public unsafe float extraSpawnRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddSpawnRate.NativeFieldInfoPtr_extraSpawnRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddSpawnRate.NativeFieldInfoPtr_extraSpawnRate)) = value;
			}
		}

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_extraSpawnRate;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000529 RID: 1321
		[ObfuscatedName("Night.RogueLike.DLC5_RogueLikeCardPersistentAddSpawnRate+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600859D RID: 34205 RVA: 0x00255A98 File Offset: 0x00253C98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0.NativeFieldInfoPtr_cardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0>.NativeClassPtr, "cardNum");
				DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0>.NativeClassPtr, 100665228);
				DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0>.NativeClassPtr, 100665229);
			}

			// Token: 0x0600859E RID: 34206 RVA: 0x00255B14 File Offset: 0x00253D14
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600859F RID: 34207 RVA: 0x00255B50 File Offset: 0x00253D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41445, XrefRangeEnd = 41450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CardEffectBeforeWorking_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060085A0 RID: 34208 RVA: 0x00047EA8 File Offset: 0x000460A8
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CDC RID: 11484
			// (get) Token: 0x060085A1 RID: 34209 RVA: 0x00255B98 File Offset: 0x00253D98
			// (set) Token: 0x060085A2 RID: 34210 RVA: 0x00047EB1 File Offset: 0x000460B1
			public unsafe DLC5_RogueLikeCardPersistentAddSpawnRate __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentAddSpawnRate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CDD RID: 11485
			// (get) Token: 0x060085A3 RID: 34211 RVA: 0x00255BC8 File Offset: 0x00253DC8
			// (set) Token: 0x060085A4 RID: 34212 RVA: 0x00047ED0 File Offset: 0x000460D0
			public unsafe int cardNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0.NativeFieldInfoPtr_cardNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddSpawnRate.__c__DisplayClass2_0.NativeFieldInfoPtr_cardNum)) = value;
				}
			}

			// Token: 0x040057CB RID: 22475
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040057CC RID: 22476
			private static readonly IntPtr NativeFieldInfoPtr_cardNum;

			// Token: 0x040057CD RID: 22477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040057CE RID: 22478
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_String_String_0;
		}
	}
}
