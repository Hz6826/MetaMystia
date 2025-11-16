using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000F1 RID: 241
	public class DLC5_RogueLikeCardPersistentKhorne : RogueLikeCardPersistent
	{
		// Token: 0x06001B27 RID: 6951 RVA: 0x000F9520 File Offset: 0x000F7720
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentKhorne()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardPersistentKhorne");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentKhorne.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne>.NativeClassPtr, "multiplier");
			DLC5_RogueLikeCardPersistentKhorne.NativeFieldInfoPtr_debuffMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne>.NativeClassPtr, "debuffMultiplier");
			DLC5_RogueLikeCardPersistentKhorne.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne>.NativeClassPtr, 100668205);
			DLC5_RogueLikeCardPersistentKhorne.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne>.NativeClassPtr, 100668206);
			DLC5_RogueLikeCardPersistentKhorne.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne>.NativeClassPtr, 100668207);
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x000F95B4 File Offset: 0x000F77B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71867, XrefRangeEnd = 71897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentKhorne.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000F9634 File Offset: 0x000F7834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71897, XrefRangeEnd = 71902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentKhorne.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x000F96BC File Offset: 0x000F78BC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentKhorne() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentKhorne.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00010A27 File Offset: 0x0000EC27
		public DLC5_RogueLikeCardPersistentKhorne(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x000F96F8 File Offset: 0x000F78F8
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x00010A30 File Offset: 0x0000EC30
		public unsafe float multiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.NativeFieldInfoPtr_multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.NativeFieldInfoPtr_multiplier)) = value;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x000F9720 File Offset: 0x000F7920
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x00010A4B File Offset: 0x0000EC4B
		public unsafe float debuffMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.NativeFieldInfoPtr_debuffMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.NativeFieldInfoPtr_debuffMultiplier)) = value;
			}
		}

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeFieldInfoPtr_multiplier;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeFieldInfoPtr_debuffMultiplier;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006B4 RID: 1716
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentKhorne+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060098CE RID: 39118 RVA: 0x0028CE28 File Offset: 0x0028B028
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr_interruptThisBuffCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr, "interruptThisBuffCallback");
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr_interruptExtraFundCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr, "interruptExtraFundCallback");
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr, 100668208);
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr, 100668209);
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__3_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr, 100668210);
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr, 100668211);
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr, 100668212);
			}

			// Token: 0x060098CF RID: 39119 RVA: 0x0028CF08 File Offset: 0x0028B108
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098D0 RID: 39120 RVA: 0x0028CF44 File Offset: 0x0028B144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71828, XrefRangeEnd = 71848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098D1 RID: 39121 RVA: 0x0028CF78 File Offset: 0x0028B178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71848, XrefRangeEnd = 71853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CardEffectBeforeWorking_b__3(string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__3_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060098D2 RID: 39122 RVA: 0x0028CFC0 File Offset: 0x0028B1C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71853, XrefRangeEnd = 71858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CardEffectBeforeWorking_b__1(string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060098D3 RID: 39123 RVA: 0x0028D008 File Offset: 0x0028B208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71858, XrefRangeEnd = 71867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CardEffectBeforeWorking_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098D4 RID: 39124 RVA: 0x00052B50 File Offset: 0x00050D50
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032C6 RID: 12998
			// (get) Token: 0x060098D5 RID: 39125 RVA: 0x0028D03C File Offset: 0x0028B23C
			// (set) Token: 0x060098D6 RID: 39126 RVA: 0x00052B59 File Offset: 0x00050D59
			public unsafe Action interruptThisBuffCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr_interruptThisBuffCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr_interruptThisBuffCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032C7 RID: 12999
			// (get) Token: 0x060098D7 RID: 39127 RVA: 0x0028D06C File Offset: 0x0028B26C
			// (set) Token: 0x060098D8 RID: 39128 RVA: 0x00052B78 File Offset: 0x00050D78
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032C8 RID: 13000
			// (get) Token: 0x060098D9 RID: 39129 RVA: 0x0028D09C File Offset: 0x0028B29C
			// (set) Token: 0x060098DA RID: 39130 RVA: 0x00052B97 File Offset: 0x00050D97
			public unsafe DLC5_RogueLikeCardPersistentKhorne __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentKhorne>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032C9 RID: 13001
			// (get) Token: 0x060098DB RID: 39131 RVA: 0x0028D0CC File Offset: 0x0028B2CC
			// (set) Token: 0x060098DC RID: 39132 RVA: 0x00052BB6 File Offset: 0x00050DB6
			public unsafe Action interruptExtraFundCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr_interruptExtraFundCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_0.NativeFieldInfoPtr_interruptExtraFundCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040062F8 RID: 25336
			private static readonly IntPtr NativeFieldInfoPtr_interruptThisBuffCallback;

			// Token: 0x040062F9 RID: 25337
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040062FA RID: 25338
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040062FB RID: 25339
			private static readonly IntPtr NativeFieldInfoPtr_interruptExtraFundCallback;

			// Token: 0x040062FC RID: 25340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040062FD RID: 25341
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040062FE RID: 25342
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__3_Internal_String_String_0;

			// Token: 0x040062FF RID: 25343
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__1_Internal_String_String_0;

			// Token: 0x04006300 RID: 25344
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__2_Internal_Void_0;
		}

		// Token: 0x020006B5 RID: 1717
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentKhorne+<>c__DisplayClass2_1")]
		public sealed class __c__DisplayClass2_1 : Object
		{
			// Token: 0x060098DD RID: 39133 RVA: 0x0028D0FC File Offset: 0x0028B2FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne>.NativeClassPtr, "<>c__DisplayClass2_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1.NativeFieldInfoPtr_interruptDebuffCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1>.NativeClassPtr, "interruptDebuffCallback");
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1>.NativeClassPtr, 100668213);
				DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1.NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1>.NativeClassPtr, 100668214);
			}

			// Token: 0x060098DE RID: 39134 RVA: 0x0028D164 File Offset: 0x0028B364
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098DF RID: 39135 RVA: 0x0028D1A0 File Offset: 0x0028B3A0
			[CallerCount(0)]
			public unsafe void _CardEffectBeforeWorking_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1.NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060098E0 RID: 39136 RVA: 0x00052BD5 File Offset: 0x00050DD5
			public __c__DisplayClass2_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032CA RID: 13002
			// (get) Token: 0x060098E1 RID: 39137 RVA: 0x0028D1D4 File Offset: 0x0028B3D4
			// (set) Token: 0x060098E2 RID: 39138 RVA: 0x00052BDE File Offset: 0x00050DDE
			public unsafe Action interruptDebuffCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1.NativeFieldInfoPtr_interruptDebuffCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentKhorne.__c__DisplayClass2_1.NativeFieldInfoPtr_interruptDebuffCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006301 RID: 25345
			private static readonly IntPtr NativeFieldInfoPtr_interruptDebuffCallback;

			// Token: 0x04006302 RID: 25346
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006303 RID: 25347
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_Internal_Void_0;
		}
	}
}
