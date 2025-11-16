using System;
using Common.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000325 RID: 805
	public sealed class PartnerInfoLarva : PartnerInfo
	{
		// Token: 0x06005F39 RID: 24377 RVA: 0x001DB5F4 File Offset: 0x001D97F4
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoLarva()
		{
			Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoLarva");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr);
			PartnerInfoLarva.NativeFieldInfoPtr_EXPENSIVE_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, "EXPENSIVE_TAG");
			PartnerInfoLarva.NativeFieldInfoPtr_spellDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, "spellDuration");
			PartnerInfoLarva.NativeFieldInfoPtr_spellInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, "spellInterval");
			PartnerInfoLarva.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, 100682842);
			PartnerInfoLarva.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, 100682843);
			PartnerInfoLarva.NativeMethodInfoPtr_UnderSleepingTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, 100682844);
			PartnerInfoLarva.NativeMethodInfoPtr_LarvaSleepingOrderResult_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, 100682845);
			PartnerInfoLarva.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, 100682846);
			PartnerInfoLarva.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, 100682847);
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x001DB6D8 File Offset: 0x001D98D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235355, XrefRangeEnd = 235372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x001DB754 File Offset: 0x001D9954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235372, XrefRangeEnd = 235404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGuestSpawn(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x001DB798 File Offset: 0x001D9998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235404, XrefRangeEnd = 235413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> UnderSleepingTags(Il2CppStructArray<int> originalTags, GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalTags);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.NativeMethodInfoPtr_UnderSleepingTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06005F3D RID: 24381 RVA: 0x001DB7FC File Offset: 0x001D99FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235413, XrefRangeEnd = 235417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LarvaSleepingOrderResult(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.NativeMethodInfoPtr_LarvaSleepingOrderResult_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3E RID: 24382 RVA: 0x001DB840 File Offset: 0x001D9A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235417, XrefRangeEnd = 235420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3F RID: 24383 RVA: 0x001DB884 File Offset: 0x001D9A84
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoLarva() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F40 RID: 24384 RVA: 0x00033DE1 File Offset: 0x00031FE1
		public PartnerInfoLarva(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x06005F41 RID: 24385 RVA: 0x001DB8C0 File Offset: 0x001D9AC0
		// (set) Token: 0x06005F42 RID: 24386 RVA: 0x00033DEA File Offset: 0x00031FEA
		public unsafe static int EXPENSIVE_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PartnerInfoLarva.NativeFieldInfoPtr_EXPENSIVE_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerInfoLarva.NativeFieldInfoPtr_EXPENSIVE_TAG, (void*)(&value));
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x06005F43 RID: 24387 RVA: 0x001DB8DC File Offset: 0x001D9ADC
		// (set) Token: 0x06005F44 RID: 24388 RVA: 0x00033DF8 File Offset: 0x00031FF8
		public unsafe int spellDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.NativeFieldInfoPtr_spellDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.NativeFieldInfoPtr_spellDuration)) = value;
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x06005F45 RID: 24389 RVA: 0x001DB904 File Offset: 0x001D9B04
		// (set) Token: 0x06005F46 RID: 24390 RVA: 0x00033E13 File Offset: 0x00032013
		public unsafe int spellInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.NativeFieldInfoPtr_spellInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.NativeFieldInfoPtr_spellInterval)) = value;
			}
		}

		// Token: 0x04003EFD RID: 16125
		private static readonly IntPtr NativeFieldInfoPtr_EXPENSIVE_TAG;

		// Token: 0x04003EFE RID: 16126
		private static readonly IntPtr NativeFieldInfoPtr_spellDuration;

		// Token: 0x04003EFF RID: 16127
		private static readonly IntPtr NativeFieldInfoPtr_spellInterval;

		// Token: 0x04003F00 RID: 16128
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003F01 RID: 16129
		private static readonly IntPtr NativeMethodInfoPtr_OnGuestSpawn_Private_Void_GuestGroupController_0;

		// Token: 0x04003F02 RID: 16130
		private static readonly IntPtr NativeMethodInfoPtr_UnderSleepingTags_Private_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_GuestGroupController_0;

		// Token: 0x04003F03 RID: 16131
		private static readonly IntPtr NativeMethodInfoPtr_LarvaSleepingOrderResult_Private_Void_GuestGroupController_0;

		// Token: 0x04003F04 RID: 16132
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003F05 RID: 16133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D56 RID: 3414
		[ObfuscatedName("GameData.Profile.PartnerInfoLarva+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F492 RID: 62610 RVA: 0x0039D2F4 File Offset: 0x0039B4F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr);
				PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, "partnerManager");
				PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr_partnerBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, "partnerBase");
				PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, "eventManager");
				PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, "<>9__2");
				PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, "<>9__6");
				PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, 100682848);
				PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, 100682849);
				PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr__OnPartnerLoad_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, 100682850);
				PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, 100682851);
				PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, 100682852);
				PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr__OnPartnerLoad_b__6_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, 100682853);
			}

			// Token: 0x0600F493 RID: 62611 RVA: 0x0039D410 File Offset: 0x0039B610
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F494 RID: 62612 RVA: 0x0039D44C File Offset: 0x0039B64C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235230, XrefRangeEnd = 235235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F495 RID: 62613 RVA: 0x0039D48C File Offset: 0x0039B68C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235235, XrefRangeEnd = 235236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPartnerLoad_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr__OnPartnerLoad_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F496 RID: 62614 RVA: 0x0039D4C8 File Offset: 0x0039B6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235236, XrefRangeEnd = 235280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__2(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F497 RID: 62615 RVA: 0x0039D50C File Offset: 0x0039B70C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235280, XrefRangeEnd = 235301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F498 RID: 62616 RVA: 0x0039D540 File Offset: 0x0039B740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235301, XrefRangeEnd = 235345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__6(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.NativeMethodInfoPtr__OnPartnerLoad_b__6_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F499 RID: 62617 RVA: 0x00083564 File Offset: 0x00081764
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F81 RID: 20353
			// (get) Token: 0x0600F49A RID: 62618 RVA: 0x0039D584 File Offset: 0x0039B784
			// (set) Token: 0x0600F49B RID: 62619 RVA: 0x0008356D File Offset: 0x0008176D
			public unsafe PartnerInfoLarva __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoLarva>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F82 RID: 20354
			// (get) Token: 0x0600F49C RID: 62620 RVA: 0x0039D5B4 File Offset: 0x0039B7B4
			// (set) Token: 0x0600F49D RID: 62621 RVA: 0x0008358C File Offset: 0x0008178C
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F83 RID: 20355
			// (get) Token: 0x0600F49E RID: 62622 RVA: 0x0039D5E4 File Offset: 0x0039B7E4
			// (set) Token: 0x0600F49F RID: 62623 RVA: 0x000835AB File Offset: 0x000817AB
			public unsafe PartnerBase partnerBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr_partnerBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr_partnerBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F84 RID: 20356
			// (get) Token: 0x0600F4A0 RID: 62624 RVA: 0x0039D614 File Offset: 0x0039B814
			// (set) Token: 0x0600F4A1 RID: 62625 RVA: 0x000835CA File Offset: 0x000817CA
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F85 RID: 20357
			// (get) Token: 0x0600F4A2 RID: 62626 RVA: 0x0039D644 File Offset: 0x0039B844
			// (set) Token: 0x0600F4A3 RID: 62627 RVA: 0x000835E9 File Offset: 0x000817E9
			public unsafe Action<GuestGroupController> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F86 RID: 20358
			// (get) Token: 0x0600F4A4 RID: 62628 RVA: 0x0039D674 File Offset: 0x0039B874
			// (set) Token: 0x0600F4A5 RID: 62629 RVA: 0x00083608 File Offset: 0x00081808
			public unsafe Action<GuestGroupController> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BCC RID: 39884
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BCD RID: 39885
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x04009BCE RID: 39886
			private static readonly IntPtr NativeFieldInfoPtr_partnerBase;

			// Token: 0x04009BCF RID: 39887
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009BD0 RID: 39888
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04009BD1 RID: 39889
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x04009BD2 RID: 39890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BD3 RID: 39891
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009BD4 RID: 39892
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__1_Internal_Boolean_0;

			// Token: 0x04009BD5 RID: 39893
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_GuestGroupController_0;

			// Token: 0x04009BD6 RID: 39894
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04009BD7 RID: 39895
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__6_Internal_Void_GuestGroupController_0;

			// Token: 0x02001099 RID: 4249
			[ObfuscatedName("GameData.Profile.PartnerInfoLarva+<>c__DisplayClass3_0+<<OnPartnerLoad>g__LarvaSleepingPowder|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601218C RID: 74124 RVA: 0x00421544 File Offset: 0x0041F744
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique()
				{
					Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0>.NativeClassPtr, "<<OnPartnerLoad>g__LarvaSleepingPowder|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr);
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<>1__state");
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<>2__current");
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<>4__this");
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__wait_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<wait>5__2");
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__waitForStun_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, "<waitForStun>5__3");
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100682854);
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100682855);
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100682856);
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100682857);
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100682858);
					PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr, 100682859);
				}

				// Token: 0x0601218D RID: 74125 RVA: 0x0042164C File Offset: 0x0041F84C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601218E RID: 74126 RVA: 0x00421694 File Offset: 0x0041F894
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601218F RID: 74127 RVA: 0x004216C8 File Offset: 0x0041F8C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235174, XrefRangeEnd = 235224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E84 RID: 24196
				// (get) Token: 0x06012190 RID: 74128 RVA: 0x00421704 File Offset: 0x0041F904
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012191 RID: 74129 RVA: 0x00421744 File Offset: 0x0041F944
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235224, XrefRangeEnd = 235230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E85 RID: 24197
				// (get) Token: 0x06012192 RID: 74130 RVA: 0x00421778 File Offset: 0x0041F978
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012193 RID: 74131 RVA: 0x0009D3C3 File Offset: 0x0009B5C3
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E7F RID: 24191
				// (get) Token: 0x06012194 RID: 74132 RVA: 0x004217B8 File Offset: 0x0041F9B8
				// (set) Token: 0x06012195 RID: 74133 RVA: 0x0009D3CC File Offset: 0x0009B5CC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E80 RID: 24192
				// (get) Token: 0x06012196 RID: 74134 RVA: 0x004217E0 File Offset: 0x0041F9E0
				// (set) Token: 0x06012197 RID: 74135 RVA: 0x0009D3E7 File Offset: 0x0009B5E7
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E81 RID: 24193
				// (get) Token: 0x06012198 RID: 74136 RVA: 0x00421810 File Offset: 0x0041FA10
				// (set) Token: 0x06012199 RID: 74137 RVA: 0x0009D406 File Offset: 0x0009B606
				public unsafe PartnerInfoLarva.__c__DisplayClass3_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoLarva.__c__DisplayClass3_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E82 RID: 24194
				// (get) Token: 0x0601219A RID: 74138 RVA: 0x00421840 File Offset: 0x0041FA40
				// (set) Token: 0x0601219B RID: 74139 RVA: 0x0009D425 File Offset: 0x0009B625
				public unsafe WaitForSeconds _wait_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__wait_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__wait_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E83 RID: 24195
				// (get) Token: 0x0601219C RID: 74140 RVA: 0x00421870 File Offset: 0x0041FA70
				// (set) Token: 0x0601219D RID: 74141 RVA: 0x0009D444 File Offset: 0x0009B644
				public unsafe WaitUntil _waitForStun_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__waitForStun_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoLarva.__c__DisplayClass3_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaWaObObUnique.NativeFieldInfoPtr__waitForStun_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B75C RID: 46940
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B75D RID: 46941
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B75E RID: 46942
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B75F RID: 46943
				private static readonly IntPtr NativeFieldInfoPtr__wait_5__2;

				// Token: 0x0400B760 RID: 46944
				private static readonly IntPtr NativeFieldInfoPtr__waitForStun_5__3;

				// Token: 0x0400B761 RID: 46945
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B762 RID: 46946
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B763 RID: 46947
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B764 RID: 46948
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B765 RID: 46949
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B766 RID: 46950
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D57 RID: 3415
		[ObfuscatedName("GameData.Profile.PartnerInfoLarva+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F4A6 RID: 62630 RVA: 0x0039D6A4 File Offset: 0x0039B8A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoLarva>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr);
				PartnerInfoLarva.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr, "<>9");
				PartnerInfoLarva.__c.NativeFieldInfoPtr___9__3_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr, "<>9__3_4");
				PartnerInfoLarva.__c.NativeFieldInfoPtr___9__3_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr, "<>9__3_5");
				PartnerInfoLarva.__c.NativeFieldInfoPtr___9__3_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr, "<>9__3_7");
				PartnerInfoLarva.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr, "<>9__4_0");
				PartnerInfoLarva.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr, 100682861);
				PartnerInfoLarva.__c.NativeMethodInfoPtr__OnPartnerLoad_b__3_4_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr, 100682862);
				PartnerInfoLarva.__c.NativeMethodInfoPtr__OnPartnerLoad_b__3_5_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr, 100682863);
				PartnerInfoLarva.__c.NativeMethodInfoPtr__OnPartnerLoad_b__3_7_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr, 100682864);
				PartnerInfoLarva.__c.NativeMethodInfoPtr__OnGuestSpawn_b__4_0_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr, 100682865);
			}

			// Token: 0x0600F4A7 RID: 62631 RVA: 0x0039D798 File Offset: 0x0039B998
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoLarva.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4A8 RID: 62632 RVA: 0x0039D7D4 File Offset: 0x0039B9D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235345, XrefRangeEnd = 235347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__3_4(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c.NativeMethodInfoPtr__OnPartnerLoad_b__3_4_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4A9 RID: 62633 RVA: 0x0039D818 File Offset: 0x0039BA18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235347, XrefRangeEnd = 235355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnPartnerLoad_b__3_5(int currentTime, string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c.NativeMethodInfoPtr__OnPartnerLoad_b__3_5_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F4AA RID: 62634 RVA: 0x0039D870 File Offset: 0x0039BA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__3_7(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c.NativeMethodInfoPtr__OnPartnerLoad_b__3_7_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4AB RID: 62635 RVA: 0x0039D8B4 File Offset: 0x0039BAB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnGuestSpawn_b__4_0(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoLarva.__c.NativeMethodInfoPtr__OnGuestSpawn_b__4_0_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4AC RID: 62636 RVA: 0x00083627 File Offset: 0x00081827
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F87 RID: 20359
			// (get) Token: 0x0600F4AD RID: 62637 RVA: 0x0039D8F8 File Offset: 0x0039BAF8
			// (set) Token: 0x0600F4AE RID: 62638 RVA: 0x00083630 File Offset: 0x00081830
			public unsafe static PartnerInfoLarva.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerInfoLarva.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoLarva.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerInfoLarva.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F88 RID: 20360
			// (get) Token: 0x0600F4AF RID: 62639 RVA: 0x0039D920 File Offset: 0x0039BB20
			// (set) Token: 0x0600F4B0 RID: 62640 RVA: 0x00083642 File Offset: 0x00081842
			public unsafe static Action<AStarInputGeneratorComponent> __9__3_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerInfoLarva.__c.NativeFieldInfoPtr___9__3_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerInfoLarva.__c.NativeFieldInfoPtr___9__3_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F89 RID: 20361
			// (get) Token: 0x0600F4B1 RID: 62641 RVA: 0x0039D948 File Offset: 0x0039BB48
			// (set) Token: 0x0600F4B2 RID: 62642 RVA: 0x00083654 File Offset: 0x00081854
			public unsafe static Func<int, string, string> __9__3_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerInfoLarva.__c.NativeFieldInfoPtr___9__3_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerInfoLarva.__c.NativeFieldInfoPtr___9__3_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F8A RID: 20362
			// (get) Token: 0x0600F4B3 RID: 62643 RVA: 0x0039D970 File Offset: 0x0039BB70
			// (set) Token: 0x0600F4B4 RID: 62644 RVA: 0x00083666 File Offset: 0x00081866
			public unsafe static Action<AStarInputGeneratorComponent> __9__3_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerInfoLarva.__c.NativeFieldInfoPtr___9__3_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerInfoLarva.__c.NativeFieldInfoPtr___9__3_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F8B RID: 20363
			// (get) Token: 0x0600F4B5 RID: 62645 RVA: 0x0039D998 File Offset: 0x0039BB98
			// (set) Token: 0x0600F4B6 RID: 62646 RVA: 0x00083678 File Offset: 0x00081878
			public unsafe static Action<AStarInputGeneratorComponent> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerInfoLarva.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerInfoLarva.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BD8 RID: 39896
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009BD9 RID: 39897
			private static readonly IntPtr NativeFieldInfoPtr___9__3_4;

			// Token: 0x04009BDA RID: 39898
			private static readonly IntPtr NativeFieldInfoPtr___9__3_5;

			// Token: 0x04009BDB RID: 39899
			private static readonly IntPtr NativeFieldInfoPtr___9__3_7;

			// Token: 0x04009BDC RID: 39900
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04009BDD RID: 39901
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BDE RID: 39902
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__3_4_Internal_Void_AStarInputGeneratorComponent_0;

			// Token: 0x04009BDF RID: 39903
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__3_5_Internal_String_Int32_String_0;

			// Token: 0x04009BE0 RID: 39904
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__3_7_Internal_Void_AStarInputGeneratorComponent_0;

			// Token: 0x04009BE1 RID: 39905
			private static readonly IntPtr NativeMethodInfoPtr__OnGuestSpawn_b__4_0_Internal_Void_AStarInputGeneratorComponent_0;
		}
	}
}
