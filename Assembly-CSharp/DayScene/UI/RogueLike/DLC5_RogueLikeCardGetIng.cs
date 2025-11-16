using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000DD RID: 221
	public class DLC5_RogueLikeCardGetIng : DLC5_RogueLikeCardGiveItem
	{
		// Token: 0x06001A78 RID: 6776 RVA: 0x000F6550 File Offset: 0x000F4750
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardGetIng()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardGetIng");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng>.NativeClassPtr);
			DLC5_RogueLikeCardGetIng.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng>.NativeClassPtr, 100668005);
			DLC5_RogueLikeCardGetIng.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng>.NativeClassPtr, 100668006);
			DLC5_RogueLikeCardGetIng.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng>.NativeClassPtr, 100668007);
			DLC5_RogueLikeCardGetIng.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng>.NativeClassPtr, 100668008);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x000F65D0 File Offset: 0x000F47D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70563, XrefRangeEnd = 70570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardGetIng.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000F6650 File Offset: 0x000F4850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70570, XrefRangeEnd = 70589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardGetIng.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000F66B4 File Offset: 0x000F48B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardGetIng() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGetIng.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x000F66F0 File Offset: 0x000F48F0
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGetIng.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x0001068C File Offset: 0x0000E88C
		public DLC5_RogueLikeCardGetIng(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x0200069B RID: 1691
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardGetIng+<UseCard>d__0")]
		public sealed class _UseCard_d__0 : Object
		{
			// Token: 0x06009747 RID: 38727 RVA: 0x002887D8 File Offset: 0x002869D8
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng>.NativeClassPtr, "<UseCard>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr);
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, 100668009);
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, 100668010);
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, 100668011);
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, 100668012);
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, 100668013);
				DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr, 100668014);
			}

			// Token: 0x06009748 RID: 38728 RVA: 0x002888F4 File Offset: 0x00286AF4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardGetIng._UseCard_d__0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009749 RID: 38729 RVA: 0x0028893C File Offset: 0x00286B3C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600974A RID: 38730 RVA: 0x00288970 File Offset: 0x00286B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70555, XrefRangeEnd = 70557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003243 RID: 12867
			// (get) Token: 0x0600974B RID: 38731 RVA: 0x002889AC File Offset: 0x00286BAC
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600974C RID: 38732 RVA: 0x002889EC File Offset: 0x00286BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70557, XrefRangeEnd = 70563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003244 RID: 12868
			// (get) Token: 0x0600974D RID: 38733 RVA: 0x00288A20 File Offset: 0x00286C20
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600974E RID: 38734 RVA: 0x00051CE3 File Offset: 0x0004FEE3
			public _UseCard_d__0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700323D RID: 12861
			// (get) Token: 0x0600974F RID: 38735 RVA: 0x00288A60 File Offset: 0x00286C60
			// (set) Token: 0x06009750 RID: 38736 RVA: 0x00051CEC File Offset: 0x0004FEEC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700323E RID: 12862
			// (get) Token: 0x06009751 RID: 38737 RVA: 0x00288A88 File Offset: 0x00286C88
			// (set) Token: 0x06009752 RID: 38738 RVA: 0x00051D07 File Offset: 0x0004FF07
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700323F RID: 12863
			// (get) Token: 0x06009753 RID: 38739 RVA: 0x00288AB8 File Offset: 0x00286CB8
			// (set) Token: 0x06009754 RID: 38740 RVA: 0x00051D26 File Offset: 0x0004FF26
			public unsafe DLC5_RogueLikeCardGetIng __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardGetIng>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003240 RID: 12864
			// (get) Token: 0x06009755 RID: 38741 RVA: 0x00288AE8 File Offset: 0x00286CE8
			// (set) Token: 0x06009756 RID: 38742 RVA: 0x00051D45 File Offset: 0x0004FF45
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003241 RID: 12865
			// (get) Token: 0x06009757 RID: 38743 RVA: 0x00288B18 File Offset: 0x00286D18
			// (set) Token: 0x06009758 RID: 38744 RVA: 0x00051D73 File Offset: 0x0004FF73
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x17003242 RID: 12866
			// (get) Token: 0x06009759 RID: 38745 RVA: 0x00288B40 File Offset: 0x00286D40
			// (set) Token: 0x0600975A RID: 38746 RVA: 0x00051D8E File Offset: 0x0004FF8E
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGetIng._UseCard_d__0.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006215 RID: 25109
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006216 RID: 25110
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006217 RID: 25111
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006218 RID: 25112
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x04006219 RID: 25113
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x0400621A RID: 25114
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x0400621B RID: 25115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400621C RID: 25116
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400621D RID: 25117
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400621E RID: 25118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400621F RID: 25119
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006220 RID: 25120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
