using System;
using DayScene.UI.RogueLike;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.EventUtility;

namespace Night.RogueLike
{
	// Token: 0x02000065 RID: 101
	public class DLC5_RogueLikeCardPersistentAddWorkSpeed : RogueLikeCardPersistent
	{
		// Token: 0x06000BAF RID: 2991 RVA: 0x000C4A58 File Offset: 0x000C2C58
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentAddWorkSpeed()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.RogueLike", "DLC5_RogueLikeCardPersistentAddWorkSpeed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeFieldInfoPtr_extraMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed>.NativeClassPtr, "extraMoveSpeed");
			DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed>.NativeClassPtr, 100665236);
			DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed>.NativeClassPtr, 100665237);
			DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed>.NativeClassPtr, 100665238);
			DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed>.NativeClassPtr, 100665239);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x000C4AEC File Offset: 0x000C2CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41496, XrefRangeEnd = 41501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x000C4B74 File Offset: 0x000C2D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41501, XrefRangeEnd = 41522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x000C4BF4 File Offset: 0x000C2DF4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x000C4C68 File Offset: 0x000C2E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentAddWorkSpeed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00008425 File Offset: 0x00006625
		public DLC5_RogueLikeCardPersistentAddWorkSpeed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000C4CA4 File Offset: 0x000C2EA4
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x0000842E File Offset: 0x0000662E
		public unsafe float extraMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeFieldInfoPtr_extraMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddWorkSpeed.NativeFieldInfoPtr_extraMoveSpeed)) = value;
			}
		}

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeFieldInfoPtr_extraMoveSpeed;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200052B RID: 1323
		[ObfuscatedName("Night.RogueLike.DLC5_RogueLikeCardPersistentAddWorkSpeed+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060085AD RID: 34221 RVA: 0x00255D48 File Offset: 0x00253F48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeFieldInfoPtr_cardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0>.NativeClassPtr, "cardNum");
				DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0>.NativeClassPtr, 100665240);
				DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0>.NativeClassPtr, 100665241);
				DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0>.NativeClassPtr, 100665242);
			}

			// Token: 0x060085AE RID: 34222 RVA: 0x00255DEC File Offset: 0x00253FEC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060085AF RID: 34223 RVA: 0x00255E28 File Offset: 0x00254028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41490, XrefRangeEnd = 41495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CardEffectBeforeWorking_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060085B0 RID: 34224 RVA: 0x00255E70 File Offset: 0x00254070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41495, XrefRangeEnd = 41496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CardEffectBeforeWorking_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060085B1 RID: 34225 RVA: 0x00047F2E File Offset: 0x0004612E
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CE0 RID: 11488
			// (get) Token: 0x060085B2 RID: 34226 RVA: 0x00255EA4 File Offset: 0x002540A4
			// (set) Token: 0x060085B3 RID: 34227 RVA: 0x00047F37 File Offset: 0x00046137
			public unsafe DLC5_RogueLikeCardPersistentAddWorkSpeed __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentAddWorkSpeed>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CE1 RID: 11489
			// (get) Token: 0x060085B4 RID: 34228 RVA: 0x00255ED4 File Offset: 0x002540D4
			// (set) Token: 0x060085B5 RID: 34229 RVA: 0x00047F56 File Offset: 0x00046156
			public unsafe int cardNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeFieldInfoPtr_cardNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeFieldInfoPtr_cardNum)) = value;
				}
			}

			// Token: 0x17002CE2 RID: 11490
			// (get) Token: 0x060085B6 RID: 34230 RVA: 0x00255EFC File Offset: 0x002540FC
			// (set) Token: 0x060085B7 RID: 34231 RVA: 0x00047F71 File Offset: 0x00046171
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddWorkSpeed.__c__DisplayClass2_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057D3 RID: 22483
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040057D4 RID: 22484
			private static readonly IntPtr NativeFieldInfoPtr_cardNum;

			// Token: 0x040057D5 RID: 22485
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040057D6 RID: 22486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040057D7 RID: 22487
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_String_String_0;

			// Token: 0x040057D8 RID: 22488
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__1_Internal_Void_0;
		}
	}
}
