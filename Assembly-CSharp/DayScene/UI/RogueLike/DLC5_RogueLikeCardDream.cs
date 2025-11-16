using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Linq;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000D6 RID: 214
	public class DLC5_RogueLikeCardDream : RogueLikeCard
	{
		// Token: 0x06001A3E RID: 6718 RVA: 0x000F54A0 File Offset: 0x000F36A0
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardDream()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardDream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr);
			DLC5_RogueLikeCardDream.NativeFieldInfoPtr_proportion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr, "proportion");
			DLC5_RogueLikeCardDream.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr, 100667921);
			DLC5_RogueLikeCardDream.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr, 100667922);
			DLC5_RogueLikeCardDream.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr, 100667923);
			DLC5_RogueLikeCardDream.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr, 100667924);
			DLC5_RogueLikeCardDream.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr, 100667925);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000F5548 File Offset: 0x000F3748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70177, XrefRangeEnd = 70184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardDream.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000F55C8 File Offset: 0x000F37C8
		[CallerCount(0)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardDream.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000F5640 File Offset: 0x000F3840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70184, XrefRangeEnd = 70189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardDream.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000F56A4 File Offset: 0x000F38A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardDream() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x000F56E0 File Offset: 0x000F38E0
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00010580 File Offset: 0x0000E780
		public DLC5_RogueLikeCardDream(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x000F5758 File Offset: 0x000F3958
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x00010589 File Offset: 0x0000E789
		public unsafe float proportion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream.NativeFieldInfoPtr_proportion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream.NativeFieldInfoPtr_proportion)) = value;
			}
		}

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeFieldInfoPtr_proportion;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x0200068F RID: 1679
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardDream+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06009695 RID: 38549 RVA: 0x002867B4 File Offset: 0x002849B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr);
				DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr, "<>9__1_0");
				DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr, "<>9__1_1");
				DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr, "<>9__1_2");
				DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr, "<>9__1_3");
				DLC5_RogueLikeCardDream.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr, 100667927);
				DLC5_RogueLikeCardDream.__c.NativeMethodInfoPtr__UseCard_b__1_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr, 100667928);
				DLC5_RogueLikeCardDream.__c.NativeMethodInfoPtr__UseCard_b__1_1_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr, 100667929);
				DLC5_RogueLikeCardDream.__c.NativeMethodInfoPtr__UseCard_b__1_2_Internal_Boolean_IGrouping_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr, 100667930);
				DLC5_RogueLikeCardDream.__c.NativeMethodInfoPtr__UseCard_b__1_3_Internal_Int32_IGrouping_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr, 100667931);
			}

			// Token: 0x06009696 RID: 38550 RVA: 0x002868A8 File Offset: 0x00284AA8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardDream.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009697 RID: 38551 RVA: 0x002868E4 File Offset: 0x00284AE4
			[CallerCount(0)]
			public unsafe bool _UseCard_b__1_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream.__c.NativeMethodInfoPtr__UseCard_b__1_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009698 RID: 38552 RVA: 0x00286930 File Offset: 0x00284B30
			[CallerCount(0)]
			public unsafe int _UseCard_b__1_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream.__c.NativeMethodInfoPtr__UseCard_b__1_1_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009699 RID: 38553 RVA: 0x0028697C File Offset: 0x00284B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70067, XrefRangeEnd = 70070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UseCard_b__1_2(IGrouping<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream.__c.NativeMethodInfoPtr__UseCard_b__1_2_Internal_Boolean_IGrouping_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600969A RID: 38554 RVA: 0x002869CC File Offset: 0x00284BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70070, XrefRangeEnd = 70073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _UseCard_b__1_3(IGrouping<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream.__c.NativeMethodInfoPtr__UseCard_b__1_3_Internal_Int32_IGrouping_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600969B RID: 38555 RVA: 0x0005166C File Offset: 0x0004F86C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003200 RID: 12800
			// (get) Token: 0x0600969C RID: 38556 RVA: 0x00286A1C File Offset: 0x00284C1C
			// (set) Token: 0x0600969D RID: 38557 RVA: 0x00051675 File Offset: 0x0004F875
			public unsafe static DLC5_RogueLikeCardDream.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardDream.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003201 RID: 12801
			// (get) Token: 0x0600969E RID: 38558 RVA: 0x00286A44 File Offset: 0x00284C44
			// (set) Token: 0x0600969F RID: 38559 RVA: 0x00051687 File Offset: 0x0004F887
			public unsafe static Func<int, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003202 RID: 12802
			// (get) Token: 0x060096A0 RID: 38560 RVA: 0x00286A6C File Offset: 0x00284C6C
			// (set) Token: 0x060096A1 RID: 38561 RVA: 0x00051699 File Offset: 0x0004F899
			public unsafe static Func<int, int> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003203 RID: 12803
			// (get) Token: 0x060096A2 RID: 38562 RVA: 0x00286A94 File Offset: 0x00284C94
			// (set) Token: 0x060096A3 RID: 38563 RVA: 0x000516AB File Offset: 0x0004F8AB
			public unsafe static Func<IGrouping<int, int>, bool> __9__1_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003204 RID: 12804
			// (get) Token: 0x060096A4 RID: 38564 RVA: 0x00286ABC File Offset: 0x00284CBC
			// (set) Token: 0x060096A5 RID: 38565 RVA: 0x000516BD File Offset: 0x0004F8BD
			public unsafe static Func<IGrouping<int, int>, int> __9__1_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardDream.__c.NativeFieldInfoPtr___9__1_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040061AE RID: 25006
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040061AF RID: 25007
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040061B0 RID: 25008
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x040061B1 RID: 25009
			private static readonly IntPtr NativeFieldInfoPtr___9__1_2;

			// Token: 0x040061B2 RID: 25010
			private static readonly IntPtr NativeFieldInfoPtr___9__1_3;

			// Token: 0x040061B3 RID: 25011
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040061B4 RID: 25012
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__1_0_Internal_Boolean_Int32_0;

			// Token: 0x040061B5 RID: 25013
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__1_1_Internal_Int32_Int32_0;

			// Token: 0x040061B6 RID: 25014
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__1_2_Internal_Boolean_IGrouping_2_Int32_Int32_0;

			// Token: 0x040061B7 RID: 25015
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__1_3_Internal_Int32_IGrouping_2_Int32_Int32_0;
		}

		// Token: 0x02000690 RID: 1680
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardDream+<UseCard>d__1")]
		public sealed class _UseCard_d__1 : Object
		{
			// Token: 0x060096A6 RID: 38566 RVA: 0x00286AE4 File Offset: 0x00284CE4
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardDream>.NativeClassPtr, "<UseCard>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr);
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, 100667932);
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, 100667933);
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, 100667934);
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, 100667935);
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, 100667936);
				DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr, 100667937);
			}

			// Token: 0x060096A7 RID: 38567 RVA: 0x00286C00 File Offset: 0x00284E00
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardDream._UseCard_d__1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096A8 RID: 38568 RVA: 0x00286C48 File Offset: 0x00284E48
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096A9 RID: 38569 RVA: 0x00286C7C File Offset: 0x00284E7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70073, XrefRangeEnd = 70171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700320B RID: 12811
			// (get) Token: 0x060096AA RID: 38570 RVA: 0x00286CB8 File Offset: 0x00284EB8
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060096AB RID: 38571 RVA: 0x00286CF8 File Offset: 0x00284EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70171, XrefRangeEnd = 70177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700320C RID: 12812
			// (get) Token: 0x060096AC RID: 38572 RVA: 0x00286D2C File Offset: 0x00284F2C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardDream._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060096AD RID: 38573 RVA: 0x000516CF File Offset: 0x0004F8CF
			public _UseCard_d__1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003205 RID: 12805
			// (get) Token: 0x060096AE RID: 38574 RVA: 0x00286D6C File Offset: 0x00284F6C
			// (set) Token: 0x060096AF RID: 38575 RVA: 0x000516D8 File Offset: 0x0004F8D8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003206 RID: 12806
			// (get) Token: 0x060096B0 RID: 38576 RVA: 0x00286D94 File Offset: 0x00284F94
			// (set) Token: 0x060096B1 RID: 38577 RVA: 0x000516F3 File Offset: 0x0004F8F3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003207 RID: 12807
			// (get) Token: 0x060096B2 RID: 38578 RVA: 0x00286DC4 File Offset: 0x00284FC4
			// (set) Token: 0x060096B3 RID: 38579 RVA: 0x00051712 File Offset: 0x0004F912
			public unsafe DLC5_RogueLikeCardDream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardDream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003208 RID: 12808
			// (get) Token: 0x060096B4 RID: 38580 RVA: 0x00286DF4 File Offset: 0x00284FF4
			// (set) Token: 0x060096B5 RID: 38581 RVA: 0x00051731 File Offset: 0x0004F931
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003209 RID: 12809
			// (get) Token: 0x060096B6 RID: 38582 RVA: 0x00286E24 File Offset: 0x00285024
			// (set) Token: 0x060096B7 RID: 38583 RVA: 0x0005175F File Offset: 0x0004F95F
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x1700320A RID: 12810
			// (get) Token: 0x060096B8 RID: 38584 RVA: 0x00286E4C File Offset: 0x0028504C
			// (set) Token: 0x060096B9 RID: 38585 RVA: 0x0005177A File Offset: 0x0004F97A
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardDream._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040061B8 RID: 25016
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040061B9 RID: 25017
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040061BA RID: 25018
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040061BB RID: 25019
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x040061BC RID: 25020
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x040061BD RID: 25021
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040061BE RID: 25022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040061BF RID: 25023
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040061C0 RID: 25024
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040061C1 RID: 25025
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040061C2 RID: 25026
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040061C3 RID: 25027
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
