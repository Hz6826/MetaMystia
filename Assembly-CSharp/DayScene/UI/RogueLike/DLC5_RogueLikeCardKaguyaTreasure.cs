using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000E3 RID: 227
	public class DLC5_RogueLikeCardKaguyaTreasure : RogueLikeCard
	{
		// Token: 0x06001AAB RID: 6827 RVA: 0x000F7358 File Offset: 0x000F5558
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardKaguyaTreasure()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardKaguyaTreasure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr);
			DLC5_RogueLikeCardKaguyaTreasure.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr, "datas");
			DLC5_RogueLikeCardKaguyaTreasure.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr, 100668072);
			DLC5_RogueLikeCardKaguyaTreasure.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr, 100668073);
			DLC5_RogueLikeCardKaguyaTreasure.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr, 100668074);
			DLC5_RogueLikeCardKaguyaTreasure.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr, 100668075);
			DLC5_RogueLikeCardKaguyaTreasure.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr, 100668076);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x000F7400 File Offset: 0x000F5600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70936, XrefRangeEnd = 70943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardKaguyaTreasure.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000F7480 File Offset: 0x000F5680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70943, XrefRangeEnd = 70948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardKaguyaTreasure.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000F74F8 File Offset: 0x000F56F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70948, XrefRangeEnd = 70956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardKaguyaTreasure.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x000F755C File Offset: 0x000F575C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardKaguyaTreasure() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x000F7598 File Offset: 0x000F5798
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000107A6 File Offset: 0x0000E9A6
		public DLC5_RogueLikeCardKaguyaTreasure(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x000F7610 File Offset: 0x000F5810
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x000107AF File Offset: 0x0000E9AF
		public unsafe Il2CppReferenceArray<RarityDataMappingForDuration> datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure.NativeFieldInfoPtr_datas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RarityDataMappingForDuration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure.NativeFieldInfoPtr_datas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x020006A4 RID: 1700
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardKaguyaTreasure+<UseCard>d__1")]
		public sealed class _UseCard_d__1 : Object
		{
			// Token: 0x060097DC RID: 38876 RVA: 0x0028A28C File Offset: 0x0028848C
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr, "<UseCard>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr);
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, 100668077);
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, 100668078);
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, 100668079);
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, 100668080);
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, 100668081);
				DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr, 100668082);
			}

			// Token: 0x060097DD RID: 38877 RVA: 0x0028A3A8 File Offset: 0x002885A8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060097DE RID: 38878 RVA: 0x0028A3F0 File Offset: 0x002885F0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060097DF RID: 38879 RVA: 0x0028A424 File Offset: 0x00288624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70927, XrefRangeEnd = 70930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003279 RID: 12921
			// (get) Token: 0x060097E0 RID: 38880 RVA: 0x0028A460 File Offset: 0x00288660
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060097E1 RID: 38881 RVA: 0x0028A4A0 File Offset: 0x002886A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70930, XrefRangeEnd = 70936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700327A RID: 12922
			// (get) Token: 0x060097E2 RID: 38882 RVA: 0x0028A4D4 File Offset: 0x002886D4
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060097E3 RID: 38883 RVA: 0x00052294 File Offset: 0x00050494
			public _UseCard_d__1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003273 RID: 12915
			// (get) Token: 0x060097E4 RID: 38884 RVA: 0x0028A514 File Offset: 0x00288714
			// (set) Token: 0x060097E5 RID: 38885 RVA: 0x0005229D File Offset: 0x0005049D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003274 RID: 12916
			// (get) Token: 0x060097E6 RID: 38886 RVA: 0x0028A53C File Offset: 0x0028873C
			// (set) Token: 0x060097E7 RID: 38887 RVA: 0x000522B8 File Offset: 0x000504B8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003275 RID: 12917
			// (get) Token: 0x060097E8 RID: 38888 RVA: 0x0028A56C File Offset: 0x0028876C
			// (set) Token: 0x060097E9 RID: 38889 RVA: 0x000522D7 File Offset: 0x000504D7
			public unsafe DLC5_RogueLikeCardKaguyaTreasure __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardKaguyaTreasure>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003276 RID: 12918
			// (get) Token: 0x060097EA RID: 38890 RVA: 0x0028A59C File Offset: 0x0028879C
			// (set) Token: 0x060097EB RID: 38891 RVA: 0x000522F6 File Offset: 0x000504F6
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003277 RID: 12919
			// (get) Token: 0x060097EC RID: 38892 RVA: 0x0028A5CC File Offset: 0x002887CC
			// (set) Token: 0x060097ED RID: 38893 RVA: 0x00052324 File Offset: 0x00050524
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x17003278 RID: 12920
			// (get) Token: 0x060097EE RID: 38894 RVA: 0x0028A5F4 File Offset: 0x002887F4
			// (set) Token: 0x060097EF RID: 38895 RVA: 0x0005233F File Offset: 0x0005053F
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKaguyaTreasure._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400626C RID: 25196
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400626D RID: 25197
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400626E RID: 25198
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400626F RID: 25199
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x04006270 RID: 25200
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x04006271 RID: 25201
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x04006272 RID: 25202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006273 RID: 25203
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006274 RID: 25204
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006275 RID: 25205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006276 RID: 25206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006277 RID: 25207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020006A5 RID: 1701
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardKaguyaTreasure+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060097F0 RID: 38896 RVA: 0x0028A624 File Offset: 0x00288824
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure.__c>.NativeClassPtr);
				DLC5_RogueLikeCardKaguyaTreasure.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardKaguyaTreasure.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure.__c>.NativeClassPtr, "<>9__2_0");
				DLC5_RogueLikeCardKaguyaTreasure.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure.__c>.NativeClassPtr, "<>9__2_1");
				DLC5_RogueLikeCardKaguyaTreasure.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure.__c>.NativeClassPtr, 100668084);
				DLC5_RogueLikeCardKaguyaTreasure.__c.NativeMethodInfoPtr__CheckExtraConditionToShow_b__2_0_Internal_Boolean_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure.__c>.NativeClassPtr, 100668085);
				DLC5_RogueLikeCardKaguyaTreasure.__c.NativeMethodInfoPtr__CheckExtraConditionToShow_b__2_1_Internal_Boolean_RogueLikeCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure.__c>.NativeClassPtr, 100668086);
			}

			// Token: 0x060097F1 RID: 38897 RVA: 0x0028A6C8 File Offset: 0x002888C8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardKaguyaTreasure.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060097F2 RID: 38898 RVA: 0x0028A704 File Offset: 0x00288904
			[CallerCount(0)]
			public unsafe bool _CheckExtraConditionToShow_b__2_0(RogueLikeCardInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure.__c.NativeMethodInfoPtr__CheckExtraConditionToShow_b__2_0_Internal_Boolean_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060097F3 RID: 38899 RVA: 0x0028A754 File Offset: 0x00288954
			[CallerCount(0)]
			public unsafe bool _CheckExtraConditionToShow_b__2_1(RogueLikeCardInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKaguyaTreasure.__c.NativeMethodInfoPtr__CheckExtraConditionToShow_b__2_1_Internal_Boolean_RogueLikeCardInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060097F4 RID: 38900 RVA: 0x0005235E File Offset: 0x0005055E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700327B RID: 12923
			// (get) Token: 0x060097F5 RID: 38901 RVA: 0x0028A7A4 File Offset: 0x002889A4
			// (set) Token: 0x060097F6 RID: 38902 RVA: 0x00052367 File Offset: 0x00050567
			public unsafe static DLC5_RogueLikeCardKaguyaTreasure.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardKaguyaTreasure.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardKaguyaTreasure.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardKaguyaTreasure.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700327C RID: 12924
			// (get) Token: 0x060097F7 RID: 38903 RVA: 0x0028A7CC File Offset: 0x002889CC
			// (set) Token: 0x060097F8 RID: 38904 RVA: 0x00052379 File Offset: 0x00050579
			public unsafe static Func<RogueLikeCardInstance, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardKaguyaTreasure.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardInstance, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardKaguyaTreasure.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700327D RID: 12925
			// (get) Token: 0x060097F9 RID: 38905 RVA: 0x0028A7F4 File Offset: 0x002889F4
			// (set) Token: 0x060097FA RID: 38906 RVA: 0x0005238B File Offset: 0x0005058B
			public unsafe static Func<RogueLikeCardInstance, bool> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardKaguyaTreasure.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardInstance, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardKaguyaTreasure.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006278 RID: 25208
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006279 RID: 25209
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400627A RID: 25210
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x0400627B RID: 25211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400627C RID: 25212
			private static readonly IntPtr NativeMethodInfoPtr__CheckExtraConditionToShow_b__2_0_Internal_Boolean_RogueLikeCardInstance_0;

			// Token: 0x0400627D RID: 25213
			private static readonly IntPtr NativeMethodInfoPtr__CheckExtraConditionToShow_b__2_1_Internal_Boolean_RogueLikeCardInstance_0;
		}
	}
}
