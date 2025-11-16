using System;
using DayScene.UI.RogueLike;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;
using NightScene.EventUtility;

namespace Night.BossBattle.DLC5_RogueLikeCard
{
	// Token: 0x02000071 RID: 113
	public class DLC5_RogueLikeCardCheapBev : RogueLikeCard
	{
		// Token: 0x06000C43 RID: 3139 RVA: 0x000C70A4 File Offset: 0x000C52A4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardCheapBev()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC5_RogueLikeCard", "DLC5_RogueLikeCardCheapBev");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr);
			DLC5_RogueLikeCardCheapBev.NativeFieldInfoPtr_BevPropertySets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr, "BevPropertySets");
			DLC5_RogueLikeCardCheapBev.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr, 100665365);
			DLC5_RogueLikeCardCheapBev.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr, 100665366);
			DLC5_RogueLikeCardCheapBev.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr, 100665367);
			DLC5_RogueLikeCardCheapBev.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr, 100665368);
			DLC5_RogueLikeCardCheapBev.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr, 100665369);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000C714C File Offset: 0x000C534C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43180, XrefRangeEnd = 43187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardCheapBev.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000C71CC File Offset: 0x000C53CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43187, XrefRangeEnd = 43206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardCheapBev.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000C7244 File Offset: 0x000C5444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43206, XrefRangeEnd = 43218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardCheapBev.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x000C72A8 File Offset: 0x000C54A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardCheapBev() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000C72E4 File Offset: 0x000C54E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000087DC File Offset: 0x000069DC
		public DLC5_RogueLikeCardCheapBev(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x000C735C File Offset: 0x000C555C
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x000087E5 File Offset: 0x000069E5
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeCardCheapBev.BevPropertySet> BevPropertySets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev.NativeFieldInfoPtr_BevPropertySets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeCardCheapBev.BevPropertySet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev.NativeFieldInfoPtr_BevPropertySets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr_BevPropertySets;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x0200053A RID: 1338
		[Serializable]
		public class BevPropertySet : RarityDataMapping
		{
			// Token: 0x06008690 RID: 34448 RVA: 0x00258768 File Offset: 0x00256968
			// Note: this type is marked as 'beforefieldinit'.
			static BevPropertySet()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.BevPropertySet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr, "BevPropertySet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.BevPropertySet>.NativeClassPtr);
				DLC5_RogueLikeCardCheapBev.BevPropertySet.NativeFieldInfoPtr_PriceLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.BevPropertySet>.NativeClassPtr, "PriceLine");
				DLC5_RogueLikeCardCheapBev.BevPropertySet.NativeFieldInfoPtr_Num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.BevPropertySet>.NativeClassPtr, "Num");
				DLC5_RogueLikeCardCheapBev.BevPropertySet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.BevPropertySet>.NativeClassPtr, 100665370);
			}

			// Token: 0x06008691 RID: 34449 RVA: 0x002587D0 File Offset: 0x002569D0
			[CallerCount(201)]
			[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42925, XrefRangeEnd = 42926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BevPropertySet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.BevPropertySet>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev.BevPropertySet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008692 RID: 34450 RVA: 0x00048653 File Offset: 0x00046853
			public BevPropertySet(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D23 RID: 11555
			// (get) Token: 0x06008693 RID: 34451 RVA: 0x0025880C File Offset: 0x00256A0C
			// (set) Token: 0x06008694 RID: 34452 RVA: 0x0004865C File Offset: 0x0004685C
			public unsafe int PriceLine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev.BevPropertySet.NativeFieldInfoPtr_PriceLine);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev.BevPropertySet.NativeFieldInfoPtr_PriceLine)) = value;
				}
			}

			// Token: 0x17002D24 RID: 11556
			// (get) Token: 0x06008695 RID: 34453 RVA: 0x00258834 File Offset: 0x00256A34
			// (set) Token: 0x06008696 RID: 34454 RVA: 0x00048677 File Offset: 0x00046877
			public unsafe int Num
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev.BevPropertySet.NativeFieldInfoPtr_Num);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev.BevPropertySet.NativeFieldInfoPtr_Num)) = value;
				}
			}

			// Token: 0x04005854 RID: 22612
			private static readonly IntPtr NativeFieldInfoPtr_PriceLine;

			// Token: 0x04005855 RID: 22613
			private static readonly IntPtr NativeFieldInfoPtr_Num;

			// Token: 0x04005856 RID: 22614
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200053B RID: 1339
		[ObfuscatedName("Night.BossBattle.DLC5_RogueLikeCard.DLC5_RogueLikeCardCheapBev+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06008697 RID: 34455 RVA: 0x0025885C File Offset: 0x00256A5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0>.NativeClassPtr);
				DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0>.NativeClassPtr, "data");
				DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0>.NativeClassPtr, 100665371);
				DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0.NativeMethodInfoPtr__UseCard_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0>.NativeClassPtr, 100665372);
			}

			// Token: 0x06008698 RID: 34456 RVA: 0x002588C4 File Offset: 0x00256AC4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008699 RID: 34457 RVA: 0x00258900 File Offset: 0x00256B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43127, XrefRangeEnd = 43128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UseCard_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0.NativeMethodInfoPtr__UseCard_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600869A RID: 34458 RVA: 0x00048692 File Offset: 0x00046892
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D25 RID: 11557
			// (get) Token: 0x0600869B RID: 34459 RVA: 0x0025894C File Offset: 0x00256B4C
			// (set) Token: 0x0600869C RID: 34460 RVA: 0x0004869B File Offset: 0x0004689B
			public unsafe DLC5_RogueLikeCardCheapBev.BevPropertySet data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardCheapBev.BevPropertySet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005857 RID: 22615
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04005858 RID: 22616
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005859 RID: 22617
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__0_Internal_Boolean_Int32_0;
		}

		// Token: 0x0200053C RID: 1340
		[ObfuscatedName("Night.BossBattle.DLC5_RogueLikeCard.DLC5_RogueLikeCardCheapBev+<UseCard>d__2")]
		public sealed class _UseCard_d__2 : Object
		{
			// Token: 0x0600869D RID: 34461 RVA: 0x0025897C File Offset: 0x00256B7C
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__2()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr, "<UseCard>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr);
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, "<>8__1");
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, 100665373);
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, 100665374);
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, 100665375);
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, 100665376);
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, 100665377);
				DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr, 100665378);
			}

			// Token: 0x0600869E RID: 34462 RVA: 0x00258AAC File Offset: 0x00256CAC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev._UseCard_d__2>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600869F RID: 34463 RVA: 0x00258AF4 File Offset: 0x00256CF4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060086A0 RID: 34464 RVA: 0x00258B28 File Offset: 0x00256D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43128, XrefRangeEnd = 43174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002D2D RID: 11565
			// (get) Token: 0x060086A1 RID: 34465 RVA: 0x00258B64 File Offset: 0x00256D64
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060086A2 RID: 34466 RVA: 0x00258BA4 File Offset: 0x00256DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43174, XrefRangeEnd = 43180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002D2E RID: 11566
			// (get) Token: 0x060086A3 RID: 34467 RVA: 0x00258BD8 File Offset: 0x00256DD8
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060086A4 RID: 34468 RVA: 0x000486BA File Offset: 0x000468BA
			public _UseCard_d__2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D26 RID: 11558
			// (get) Token: 0x060086A5 RID: 34469 RVA: 0x00258C18 File Offset: 0x00256E18
			// (set) Token: 0x060086A6 RID: 34470 RVA: 0x000486C3 File Offset: 0x000468C3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002D27 RID: 11559
			// (get) Token: 0x060086A7 RID: 34471 RVA: 0x00258C40 File Offset: 0x00256E40
			// (set) Token: 0x060086A8 RID: 34472 RVA: 0x000486DE File Offset: 0x000468DE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D28 RID: 11560
			// (get) Token: 0x060086A9 RID: 34473 RVA: 0x00258C70 File Offset: 0x00256E70
			// (set) Token: 0x060086AA RID: 34474 RVA: 0x000486FD File Offset: 0x000468FD
			public unsafe DLC5_RogueLikeCardCheapBev __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardCheapBev>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D29 RID: 11561
			// (get) Token: 0x060086AB RID: 34475 RVA: 0x00258CA0 File Offset: 0x00256EA0
			// (set) Token: 0x060086AC RID: 34476 RVA: 0x0004871C File Offset: 0x0004691C
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002D2A RID: 11562
			// (get) Token: 0x060086AD RID: 34477 RVA: 0x00258CD0 File Offset: 0x00256ED0
			// (set) Token: 0x060086AE RID: 34478 RVA: 0x0004874A File Offset: 0x0004694A
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x17002D2B RID: 11563
			// (get) Token: 0x060086AF RID: 34479 RVA: 0x00258CF8 File Offset: 0x00256EF8
			// (set) Token: 0x060086B0 RID: 34480 RVA: 0x00048765 File Offset: 0x00046965
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D2C RID: 11564
			// (get) Token: 0x060086B1 RID: 34481 RVA: 0x00258D28 File Offset: 0x00256F28
			// (set) Token: 0x060086B2 RID: 34482 RVA: 0x00048784 File Offset: 0x00046984
			public unsafe DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardCheapBev.__c__DisplayClass2_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev._UseCard_d__2.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400585A RID: 22618
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400585B RID: 22619
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400585C RID: 22620
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400585D RID: 22621
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x0400585E RID: 22622
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x0400585F RID: 22623
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x04005860 RID: 22624
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005861 RID: 22625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005862 RID: 22626
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005863 RID: 22627
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005864 RID: 22628
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005865 RID: 22629
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005866 RID: 22630
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200053D RID: 1341
		[ObfuscatedName("Night.BossBattle.DLC5_RogueLikeCard.DLC5_RogueLikeCardCheapBev+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060086B3 RID: 34483 RVA: 0x00258D58 File Offset: 0x00256F58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0>.NativeClassPtr);
				DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0>.NativeClassPtr, "data");
				DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0>.NativeClassPtr, 100665379);
				DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0.NativeMethodInfoPtr__CheckExtraConditionToShow_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0>.NativeClassPtr, 100665380);
			}

			// Token: 0x060086B4 RID: 34484 RVA: 0x00258DC0 File Offset: 0x00256FC0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060086B5 RID: 34485 RVA: 0x00258DFC File Offset: 0x00256FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckExtraConditionToShow_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0.NativeMethodInfoPtr__CheckExtraConditionToShow_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060086B6 RID: 34486 RVA: 0x000487A3 File Offset: 0x000469A3
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D2F RID: 11567
			// (get) Token: 0x060086B7 RID: 34487 RVA: 0x00258E48 File Offset: 0x00257048
			// (set) Token: 0x060086B8 RID: 34488 RVA: 0x000487AC File Offset: 0x000469AC
			public unsafe DLC5_RogueLikeCardCheapBev.BevPropertySet data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardCheapBev.BevPropertySet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardCheapBev.__c__DisplayClass3_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005867 RID: 22631
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04005868 RID: 22632
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005869 RID: 22633
			private static readonly IntPtr NativeMethodInfoPtr__CheckExtraConditionToShow_b__0_Internal_Boolean_Int32_0;
		}
	}
}
