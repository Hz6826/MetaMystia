using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;

namespace GameData.Profile
{
	// Token: 0x020002FE RID: 766
	public class ByakurenCuttingBoard : CookerAssetBase
	{
		// Token: 0x06005C75 RID: 23669 RVA: 0x001D2044 File Offset: 0x001D0244
		// Note: this type is marked as 'beforefieldinit'.
		static ByakurenCuttingBoard()
		{
			Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "ByakurenCuttingBoard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr);
			ByakurenCuttingBoard.NativeFieldInfoPtr_MEAT_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr, "MEAT_TAG");
			ByakurenCuttingBoard.NativeFieldInfoPtr_extraCookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr, "extraCookSpeed");
			ByakurenCuttingBoard.NativeFieldInfoPtr_extraCookSpeedWithMeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr, "extraCookSpeedWithMeat");
			ByakurenCuttingBoard.NativeFieldInfoPtr_BYAKURENCUTTINGBOARD_RECORDFOOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr, "BYAKURENCUTTINGBOARD_RECORDFOOD");
			ByakurenCuttingBoard.NativeFieldInfoPtr_BYAKURENCUTTINGBOARD_RECORDEVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr, "BYAKURENCUTTINGBOARD_RECORDEVAL");
			ByakurenCuttingBoard.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr, 100682409);
			ByakurenCuttingBoard.NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr, 100682410);
			ByakurenCuttingBoard.NativeMethodInfoPtr_OnEvaluate_Public_Virtual_Int32_Int32_GuestGroupController_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr, 100682411);
			ByakurenCuttingBoard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr, 100682412);
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x001D2128 File Offset: 0x001D0328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232316, XrefRangeEnd = 232332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByakurenCuttingBoard.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x001D217C File Offset: 0x001D037C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232332, XrefRangeEnd = 232335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ExtraCookTimeMultiplier(CookController thisCookController, Sellable food)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisCookController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByakurenCuttingBoard.NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C78 RID: 23672 RVA: 0x001D21E8 File Offset: 0x001D03E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232335, XrefRangeEnd = 232391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int OnEvaluate(int evaluationResult, GuestGroupController guestGroupController, Sellable serveFood)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evaluationResult;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serveFood);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByakurenCuttingBoard.NativeMethodInfoPtr_OnEvaluate_Public_Virtual_Int32_Int32_GuestGroupController_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C79 RID: 23673 RVA: 0x001D2260 File Offset: 0x001D0460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232391, XrefRangeEnd = 232392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByakurenCuttingBoard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByakurenCuttingBoard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x00032820 File Offset: 0x00030A20
		public ByakurenCuttingBoard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06005C7B RID: 23675 RVA: 0x001D229C File Offset: 0x001D049C
		// (set) Token: 0x06005C7C RID: 23676 RVA: 0x00032829 File Offset: 0x00030A29
		public unsafe static int MEAT_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ByakurenCuttingBoard.NativeFieldInfoPtr_MEAT_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ByakurenCuttingBoard.NativeFieldInfoPtr_MEAT_TAG, (void*)(&value));
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06005C7D RID: 23677 RVA: 0x001D22B8 File Offset: 0x001D04B8
		// (set) Token: 0x06005C7E RID: 23678 RVA: 0x00032837 File Offset: 0x00030A37
		public unsafe float extraCookSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByakurenCuttingBoard.NativeFieldInfoPtr_extraCookSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByakurenCuttingBoard.NativeFieldInfoPtr_extraCookSpeed)) = value;
			}
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06005C7F RID: 23679 RVA: 0x001D22E0 File Offset: 0x001D04E0
		// (set) Token: 0x06005C80 RID: 23680 RVA: 0x00032852 File Offset: 0x00030A52
		public unsafe float extraCookSpeedWithMeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByakurenCuttingBoard.NativeFieldInfoPtr_extraCookSpeedWithMeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByakurenCuttingBoard.NativeFieldInfoPtr_extraCookSpeedWithMeat)) = value;
			}
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06005C81 RID: 23681 RVA: 0x001D2308 File Offset: 0x001D0508
		// (set) Token: 0x06005C82 RID: 23682 RVA: 0x0003286D File Offset: 0x00030A6D
		public unsafe static string BYAKURENCUTTINGBOARD_RECORDFOOD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ByakurenCuttingBoard.NativeFieldInfoPtr_BYAKURENCUTTINGBOARD_RECORDFOOD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ByakurenCuttingBoard.NativeFieldInfoPtr_BYAKURENCUTTINGBOARD_RECORDFOOD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x06005C83 RID: 23683 RVA: 0x001D2328 File Offset: 0x001D0528
		// (set) Token: 0x06005C84 RID: 23684 RVA: 0x0003287F File Offset: 0x00030A7F
		public unsafe static string BYAKURENCUTTINGBOARD_RECORDEVAL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ByakurenCuttingBoard.NativeFieldInfoPtr_BYAKURENCUTTINGBOARD_RECORDEVAL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ByakurenCuttingBoard.NativeFieldInfoPtr_BYAKURENCUTTINGBOARD_RECORDEVAL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003D3F RID: 15679
		private static readonly IntPtr NativeFieldInfoPtr_MEAT_TAG;

		// Token: 0x04003D40 RID: 15680
		private static readonly IntPtr NativeFieldInfoPtr_extraCookSpeed;

		// Token: 0x04003D41 RID: 15681
		private static readonly IntPtr NativeFieldInfoPtr_extraCookSpeedWithMeat;

		// Token: 0x04003D42 RID: 15682
		private static readonly IntPtr NativeFieldInfoPtr_BYAKURENCUTTINGBOARD_RECORDFOOD;

		// Token: 0x04003D43 RID: 15683
		private static readonly IntPtr NativeFieldInfoPtr_BYAKURENCUTTINGBOARD_RECORDEVAL;

		// Token: 0x04003D44 RID: 15684
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0;

		// Token: 0x04003D45 RID: 15685
		private static readonly IntPtr NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0;

		// Token: 0x04003D46 RID: 15686
		private static readonly IntPtr NativeMethodInfoPtr_OnEvaluate_Public_Virtual_Int32_Int32_GuestGroupController_Sellable_0;

		// Token: 0x04003D47 RID: 15687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D28 RID: 3368
		[ObfuscatedName("GameData.Profile.ByakurenCuttingBoard+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600F2C0 RID: 62144 RVA: 0x003981B0 File Offset: 0x003963B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ByakurenCuttingBoard.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ByakurenCuttingBoard>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByakurenCuttingBoard.__c__DisplayClass7_0>.NativeClassPtr);
				ByakurenCuttingBoard.__c__DisplayClass7_0.NativeFieldInfoPtr_serveFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByakurenCuttingBoard.__c__DisplayClass7_0>.NativeClassPtr, "serveFood");
				ByakurenCuttingBoard.__c__DisplayClass7_0.NativeFieldInfoPtr_evaluationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByakurenCuttingBoard.__c__DisplayClass7_0>.NativeClassPtr, "evaluationResult");
				ByakurenCuttingBoard.__c__DisplayClass7_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByakurenCuttingBoard.__c__DisplayClass7_0>.NativeClassPtr, "eventManager");
				ByakurenCuttingBoard.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByakurenCuttingBoard.__c__DisplayClass7_0>.NativeClassPtr, 100682413);
				ByakurenCuttingBoard.__c__DisplayClass7_0.NativeMethodInfoPtr__OnEvaluate_b__0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByakurenCuttingBoard.__c__DisplayClass7_0>.NativeClassPtr, 100682414);
				ByakurenCuttingBoard.__c__DisplayClass7_0.NativeMethodInfoPtr__OnEvaluate_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByakurenCuttingBoard.__c__DisplayClass7_0>.NativeClassPtr, 100682415);
			}

			// Token: 0x0600F2C1 RID: 62145 RVA: 0x00398254 File Offset: 0x00396454
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByakurenCuttingBoard.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByakurenCuttingBoard.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2C2 RID: 62146 RVA: 0x00398290 File Offset: 0x00396490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232296, XrefRangeEnd = 232306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnEvaluate_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByakurenCuttingBoard.__c__DisplayClass7_0.NativeMethodInfoPtr__OnEvaluate_b__0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F2C3 RID: 62147 RVA: 0x003982D8 File Offset: 0x003964D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232306, XrefRangeEnd = 232316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEvaluate_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByakurenCuttingBoard.__c__DisplayClass7_0.NativeMethodInfoPtr__OnEvaluate_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2C4 RID: 62148 RVA: 0x00082598 File Offset: 0x00080798
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EF4 RID: 20212
			// (get) Token: 0x0600F2C5 RID: 62149 RVA: 0x0039830C File Offset: 0x0039650C
			// (set) Token: 0x0600F2C6 RID: 62150 RVA: 0x000825A1 File Offset: 0x000807A1
			public unsafe Sellable serveFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByakurenCuttingBoard.__c__DisplayClass7_0.NativeFieldInfoPtr_serveFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByakurenCuttingBoard.__c__DisplayClass7_0.NativeFieldInfoPtr_serveFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EF5 RID: 20213
			// (get) Token: 0x0600F2C7 RID: 62151 RVA: 0x0039833C File Offset: 0x0039653C
			// (set) Token: 0x0600F2C8 RID: 62152 RVA: 0x000825C0 File Offset: 0x000807C0
			public unsafe int evaluationResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByakurenCuttingBoard.__c__DisplayClass7_0.NativeFieldInfoPtr_evaluationResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByakurenCuttingBoard.__c__DisplayClass7_0.NativeFieldInfoPtr_evaluationResult)) = value;
				}
			}

			// Token: 0x17004EF6 RID: 20214
			// (get) Token: 0x0600F2C9 RID: 62153 RVA: 0x00398364 File Offset: 0x00396564
			// (set) Token: 0x0600F2CA RID: 62154 RVA: 0x000825DB File Offset: 0x000807DB
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByakurenCuttingBoard.__c__DisplayClass7_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByakurenCuttingBoard.__c__DisplayClass7_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AA9 RID: 39593
			private static readonly IntPtr NativeFieldInfoPtr_serveFood;

			// Token: 0x04009AAA RID: 39594
			private static readonly IntPtr NativeFieldInfoPtr_evaluationResult;

			// Token: 0x04009AAB RID: 39595
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009AAC RID: 39596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AAD RID: 39597
			private static readonly IntPtr NativeMethodInfoPtr__OnEvaluate_b__0_Internal_String_String_0;

			// Token: 0x04009AAE RID: 39598
			private static readonly IntPtr NativeMethodInfoPtr__OnEvaluate_b__1_Internal_Void_0;
		}
	}
}
