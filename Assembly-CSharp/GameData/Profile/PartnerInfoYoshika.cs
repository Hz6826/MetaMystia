using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x0200032C RID: 812
	public sealed class PartnerInfoYoshika : PartnerInfo
	{
		// Token: 0x06005F82 RID: 24450 RVA: 0x001DC6B4 File Offset: 0x001DA8B4
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoYoshika()
		{
			Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoYoshika");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr);
			PartnerInfoYoshika.NativeFieldInfoPtr_YOSHIKA_EAT_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, "YOSHIKA_EAT_NUM");
			PartnerInfoYoshika.NativeFieldInfoPtr_findFoodId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, "findFoodId");
			PartnerInfoYoshika.NativeFieldInfoPtr_eachFoodProvideSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, "eachFoodProvideSpeed");
			PartnerInfoYoshika.NativeFieldInfoPtr_eachFoodProvideWorkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, "eachFoodProvideWorkSpeed");
			PartnerInfoYoshika.NativeFieldInfoPtr_maxNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, "maxNum");
			PartnerInfoYoshika.NativeFieldInfoPtr_powerAscensionEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, "powerAscensionEffect");
			PartnerInfoYoshika.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, 100682919);
			PartnerInfoYoshika.NativeMethodInfoPtr_OnInventoryUpdate_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, 100682920);
			PartnerInfoYoshika.NativeMethodInfoPtr_MoveToFoodStorage_Private_IEnumerator_PartnerBase_EventManager_PartnerManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, 100682921);
			PartnerInfoYoshika.NativeMethodInfoPtr_Eat_Private_IEnumerator_PartnerBase_EventManager_PartnerManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, 100682922);
			PartnerInfoYoshika.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, 100682923);
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x001DC7C0 File Offset: 0x001DA9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235833, XrefRangeEnd = 235836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x001DC804 File Offset: 0x001DAA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235836, XrefRangeEnd = 235858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInventoryUpdate(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika.NativeMethodInfoPtr_OnInventoryUpdate_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x001DC86C File Offset: 0x001DAA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235858, XrefRangeEnd = 235866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MoveToFoodStorage(PartnerBase thisPartner, EventManager eventManager, PartnerManager partnerManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisPartner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika.NativeMethodInfoPtr_MoveToFoodStorage_Private_IEnumerator_PartnerBase_EventManager_PartnerManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x001DC8E0 File Offset: 0x001DAAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235866, XrefRangeEnd = 235874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Eat(PartnerBase thisPartner, EventManager eventManager, PartnerManager partnerManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisPartner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika.NativeMethodInfoPtr_Eat_Private_IEnumerator_PartnerBase_EventManager_PartnerManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x001DC954 File Offset: 0x001DAB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235874, XrefRangeEnd = 235875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoYoshika() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x00033FB3 File Offset: 0x000321B3
		public PartnerInfoYoshika(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x06005F89 RID: 24457 RVA: 0x001DC990 File Offset: 0x001DAB90
		// (set) Token: 0x06005F8A RID: 24458 RVA: 0x00033FBC File Offset: 0x000321BC
		public unsafe static string YOSHIKA_EAT_NUM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PartnerInfoYoshika.NativeFieldInfoPtr_YOSHIKA_EAT_NUM, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerInfoYoshika.NativeFieldInfoPtr_YOSHIKA_EAT_NUM, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x06005F8B RID: 24459 RVA: 0x001DC9B0 File Offset: 0x001DABB0
		// (set) Token: 0x06005F8C RID: 24460 RVA: 0x00033FCE File Offset: 0x000321CE
		public unsafe int findFoodId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.NativeFieldInfoPtr_findFoodId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.NativeFieldInfoPtr_findFoodId)) = value;
			}
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06005F8D RID: 24461 RVA: 0x001DC9D8 File Offset: 0x001DABD8
		// (set) Token: 0x06005F8E RID: 24462 RVA: 0x00033FE9 File Offset: 0x000321E9
		public unsafe float eachFoodProvideSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.NativeFieldInfoPtr_eachFoodProvideSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.NativeFieldInfoPtr_eachFoodProvideSpeed)) = value;
			}
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06005F8F RID: 24463 RVA: 0x001DCA00 File Offset: 0x001DAC00
		// (set) Token: 0x06005F90 RID: 24464 RVA: 0x00034004 File Offset: 0x00032204
		public unsafe float eachFoodProvideWorkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.NativeFieldInfoPtr_eachFoodProvideWorkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.NativeFieldInfoPtr_eachFoodProvideWorkSpeed)) = value;
			}
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06005F91 RID: 24465 RVA: 0x001DCA28 File Offset: 0x001DAC28
		// (set) Token: 0x06005F92 RID: 24466 RVA: 0x0003401F File Offset: 0x0003221F
		public unsafe int maxNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.NativeFieldInfoPtr_maxNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.NativeFieldInfoPtr_maxNum)) = value;
			}
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06005F93 RID: 24467 RVA: 0x001DCA50 File Offset: 0x001DAC50
		// (set) Token: 0x06005F94 RID: 24468 RVA: 0x0003403A File Offset: 0x0003223A
		public unsafe GameObject powerAscensionEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.NativeFieldInfoPtr_powerAscensionEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.NativeFieldInfoPtr_powerAscensionEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003F29 RID: 16169
		private static readonly IntPtr NativeFieldInfoPtr_YOSHIKA_EAT_NUM;

		// Token: 0x04003F2A RID: 16170
		private static readonly IntPtr NativeFieldInfoPtr_findFoodId;

		// Token: 0x04003F2B RID: 16171
		private static readonly IntPtr NativeFieldInfoPtr_eachFoodProvideSpeed;

		// Token: 0x04003F2C RID: 16172
		private static readonly IntPtr NativeFieldInfoPtr_eachFoodProvideWorkSpeed;

		// Token: 0x04003F2D RID: 16173
		private static readonly IntPtr NativeFieldInfoPtr_maxNum;

		// Token: 0x04003F2E RID: 16174
		private static readonly IntPtr NativeFieldInfoPtr_powerAscensionEffect;

		// Token: 0x04003F2F RID: 16175
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003F30 RID: 16176
		private static readonly IntPtr NativeMethodInfoPtr_OnInventoryUpdate_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_0;

		// Token: 0x04003F31 RID: 16177
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFoodStorage_Private_IEnumerator_PartnerBase_EventManager_PartnerManager_0;

		// Token: 0x04003F32 RID: 16178
		private static readonly IntPtr NativeMethodInfoPtr_Eat_Private_IEnumerator_PartnerBase_EventManager_PartnerManager_0;

		// Token: 0x04003F33 RID: 16179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D5E RID: 3422
		[ObfuscatedName("GameData.Profile.PartnerInfoYoshika+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F500 RID: 62720 RVA: 0x0039E5B0 File Offset: 0x0039C7B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<PartnerInfoYoshika.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYoshika.__c__DisplayClass8_0>.NativeClassPtr);
				PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr_thisPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika.__c__DisplayClass8_0>.NativeClassPtr, "thisPartner");
				PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika.__c__DisplayClass8_0>.NativeClassPtr, "partnerManager");
				PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika.__c__DisplayClass8_0>.NativeClassPtr, "eventManager");
				PartnerInfoYoshika.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika.__c__DisplayClass8_0>.NativeClassPtr, 100682924);
				PartnerInfoYoshika.__c__DisplayClass8_0.NativeMethodInfoPtr__MoveToFoodStorage_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika.__c__DisplayClass8_0>.NativeClassPtr, 100682925);
				PartnerInfoYoshika.__c__DisplayClass8_0.NativeMethodInfoPtr__MoveToFoodStorage_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika.__c__DisplayClass8_0>.NativeClassPtr, 100682926);
			}

			// Token: 0x0600F501 RID: 62721 RVA: 0x0039E668 File Offset: 0x0039C868
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYoshika.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F502 RID: 62722 RVA: 0x0039E6A4 File Offset: 0x0039C8A4
			[CallerCount(0)]
			public unsafe bool _MoveToFoodStorage_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika.__c__DisplayClass8_0.NativeMethodInfoPtr__MoveToFoodStorage_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F503 RID: 62723 RVA: 0x0039E6E0 File Offset: 0x0039C8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235729, XrefRangeEnd = 235742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MoveToFoodStorage_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika.__c__DisplayClass8_0.NativeMethodInfoPtr__MoveToFoodStorage_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F504 RID: 62724 RVA: 0x00083944 File Offset: 0x00081B44
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FA2 RID: 20386
			// (get) Token: 0x0600F505 RID: 62725 RVA: 0x0039E714 File Offset: 0x0039C914
			// (set) Token: 0x0600F506 RID: 62726 RVA: 0x0008394D File Offset: 0x00081B4D
			public unsafe PartnerBase thisPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr_thisPartner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr_thisPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FA3 RID: 20387
			// (get) Token: 0x0600F507 RID: 62727 RVA: 0x0039E744 File Offset: 0x0039C944
			// (set) Token: 0x0600F508 RID: 62728 RVA: 0x0008396C File Offset: 0x00081B6C
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FA4 RID: 20388
			// (get) Token: 0x0600F509 RID: 62729 RVA: 0x0039E774 File Offset: 0x0039C974
			// (set) Token: 0x0600F50A RID: 62730 RVA: 0x0008398B File Offset: 0x00081B8B
			public unsafe PartnerInfoYoshika __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoYoshika>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FA5 RID: 20389
			// (get) Token: 0x0600F50B RID: 62731 RVA: 0x0039E7A4 File Offset: 0x0039C9A4
			// (set) Token: 0x0600F50C RID: 62732 RVA: 0x000839AA File Offset: 0x00081BAA
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika.__c__DisplayClass8_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C09 RID: 39945
			private static readonly IntPtr NativeFieldInfoPtr_thisPartner;

			// Token: 0x04009C0A RID: 39946
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x04009C0B RID: 39947
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C0C RID: 39948
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009C0D RID: 39949
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C0E RID: 39950
			private static readonly IntPtr NativeMethodInfoPtr__MoveToFoodStorage_b__0_Internal_Boolean_0;

			// Token: 0x04009C0F RID: 39951
			private static readonly IntPtr NativeMethodInfoPtr__MoveToFoodStorage_b__1_Internal_Void_0;
		}

		// Token: 0x02000D5F RID: 3423
		[ObfuscatedName("GameData.Profile.PartnerInfoYoshika+<MoveToFoodStorage>d__8")]
		public sealed class _MoveToFoodStorage_d__8 : Il2CppSystem.Object
		{
			// Token: 0x0600F50D RID: 62733 RVA: 0x0039E7D4 File Offset: 0x0039C9D4
			// Note: this type is marked as 'beforefieldinit'.
			static _MoveToFoodStorage_d__8()
			{
				Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, "<MoveToFoodStorage>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr);
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, "<>1__state");
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, "<>2__current");
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr_thisPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, "thisPartner");
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, "partnerManager");
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, "<>4__this");
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, "eventManager");
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, "<>8__1");
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, 100682927);
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, 100682928);
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, 100682929);
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, 100682930);
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, 100682931);
				PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr, 100682932);
			}

			// Token: 0x0600F50E RID: 62734 RVA: 0x0039E904 File Offset: 0x0039CB04
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MoveToFoodStorage_d__8(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYoshika._MoveToFoodStorage_d__8>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F50F RID: 62735 RVA: 0x0039E94C File Offset: 0x0039CB4C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F510 RID: 62736 RVA: 0x0039E980 File Offset: 0x0039CB80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235742, XrefRangeEnd = 235780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004FAD RID: 20397
			// (get) Token: 0x0600F511 RID: 62737 RVA: 0x0039E9BC File Offset: 0x0039CBBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F512 RID: 62738 RVA: 0x0039E9FC File Offset: 0x0039CBFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235780, XrefRangeEnd = 235786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004FAE RID: 20398
			// (get) Token: 0x0600F513 RID: 62739 RVA: 0x0039EA30 File Offset: 0x0039CC30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F514 RID: 62740 RVA: 0x000839C9 File Offset: 0x00081BC9
			public _MoveToFoodStorage_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FA6 RID: 20390
			// (get) Token: 0x0600F515 RID: 62741 RVA: 0x0039EA70 File Offset: 0x0039CC70
			// (set) Token: 0x0600F516 RID: 62742 RVA: 0x000839D2 File Offset: 0x00081BD2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004FA7 RID: 20391
			// (get) Token: 0x0600F517 RID: 62743 RVA: 0x0039EA98 File Offset: 0x0039CC98
			// (set) Token: 0x0600F518 RID: 62744 RVA: 0x000839ED File Offset: 0x00081BED
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FA8 RID: 20392
			// (get) Token: 0x0600F519 RID: 62745 RVA: 0x0039EAC8 File Offset: 0x0039CCC8
			// (set) Token: 0x0600F51A RID: 62746 RVA: 0x00083A0C File Offset: 0x00081C0C
			public unsafe PartnerBase thisPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr_thisPartner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr_thisPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FA9 RID: 20393
			// (get) Token: 0x0600F51B RID: 62747 RVA: 0x0039EAF8 File Offset: 0x0039CCF8
			// (set) Token: 0x0600F51C RID: 62748 RVA: 0x00083A2B File Offset: 0x00081C2B
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FAA RID: 20394
			// (get) Token: 0x0600F51D RID: 62749 RVA: 0x0039EB28 File Offset: 0x0039CD28
			// (set) Token: 0x0600F51E RID: 62750 RVA: 0x00083A4A File Offset: 0x00081C4A
			public unsafe PartnerInfoYoshika __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoYoshika>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FAB RID: 20395
			// (get) Token: 0x0600F51F RID: 62751 RVA: 0x0039EB58 File Offset: 0x0039CD58
			// (set) Token: 0x0600F520 RID: 62752 RVA: 0x00083A69 File Offset: 0x00081C69
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FAC RID: 20396
			// (get) Token: 0x0600F521 RID: 62753 RVA: 0x0039EB88 File Offset: 0x0039CD88
			// (set) Token: 0x0600F522 RID: 62754 RVA: 0x00083A88 File Offset: 0x00081C88
			public unsafe PartnerInfoYoshika.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoYoshika.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._MoveToFoodStorage_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C10 RID: 39952
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009C11 RID: 39953
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009C12 RID: 39954
			private static readonly IntPtr NativeFieldInfoPtr_thisPartner;

			// Token: 0x04009C13 RID: 39955
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x04009C14 RID: 39956
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C15 RID: 39957
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009C16 RID: 39958
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04009C17 RID: 39959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009C18 RID: 39960
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C19 RID: 39961
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009C1A RID: 39962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009C1B RID: 39963
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C1C RID: 39964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D60 RID: 3424
		[ObfuscatedName("GameData.Profile.PartnerInfoYoshika+<Eat>d__9")]
		public sealed class _Eat_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600F523 RID: 62755 RVA: 0x0039EBB8 File Offset: 0x0039CDB8
			// Note: this type is marked as 'beforefieldinit'.
			static _Eat_d__9()
			{
				Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoYoshika>.NativeClassPtr, "<Eat>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr);
				PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, "<>1__state");
				PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, "<>2__current");
				PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, "eventManager");
				PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, "<>4__this");
				PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr_thisPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, "thisPartner");
				PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, "partnerManager");
				PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr__num_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, "<num>5__2");
				PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr__eatNumRecord_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, "<eatNumRecord>5__3");
				PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, 100682933);
				PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, 100682934);
				PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, 100682935);
				PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, 100682936);
				PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, 100682937);
				PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr, 100682938);
			}

			// Token: 0x0600F524 RID: 62756 RVA: 0x0039ECFC File Offset: 0x0039CEFC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Eat_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYoshika._Eat_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F525 RID: 62757 RVA: 0x0039ED44 File Offset: 0x0039CF44
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F526 RID: 62758 RVA: 0x0039ED78 File Offset: 0x0039CF78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235786, XrefRangeEnd = 235827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004FB7 RID: 20407
			// (get) Token: 0x0600F527 RID: 62759 RVA: 0x0039EDB4 File Offset: 0x0039CFB4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F528 RID: 62760 RVA: 0x0039EDF4 File Offset: 0x0039CFF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235827, XrefRangeEnd = 235833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004FB8 RID: 20408
			// (get) Token: 0x0600F529 RID: 62761 RVA: 0x0039EE28 File Offset: 0x0039D028
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoshika._Eat_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F52A RID: 62762 RVA: 0x00083AA7 File Offset: 0x00081CA7
			public _Eat_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FAF RID: 20399
			// (get) Token: 0x0600F52B RID: 62763 RVA: 0x0039EE68 File Offset: 0x0039D068
			// (set) Token: 0x0600F52C RID: 62764 RVA: 0x00083AB0 File Offset: 0x00081CB0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004FB0 RID: 20400
			// (get) Token: 0x0600F52D RID: 62765 RVA: 0x0039EE90 File Offset: 0x0039D090
			// (set) Token: 0x0600F52E RID: 62766 RVA: 0x00083ACB File Offset: 0x00081CCB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FB1 RID: 20401
			// (get) Token: 0x0600F52F RID: 62767 RVA: 0x0039EEC0 File Offset: 0x0039D0C0
			// (set) Token: 0x0600F530 RID: 62768 RVA: 0x00083AEA File Offset: 0x00081CEA
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FB2 RID: 20402
			// (get) Token: 0x0600F531 RID: 62769 RVA: 0x0039EEF0 File Offset: 0x0039D0F0
			// (set) Token: 0x0600F532 RID: 62770 RVA: 0x00083B09 File Offset: 0x00081D09
			public unsafe PartnerInfoYoshika __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoYoshika>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FB3 RID: 20403
			// (get) Token: 0x0600F533 RID: 62771 RVA: 0x0039EF20 File Offset: 0x0039D120
			// (set) Token: 0x0600F534 RID: 62772 RVA: 0x00083B28 File Offset: 0x00081D28
			public unsafe PartnerBase thisPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr_thisPartner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr_thisPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FB4 RID: 20404
			// (get) Token: 0x0600F535 RID: 62773 RVA: 0x0039EF50 File Offset: 0x0039D150
			// (set) Token: 0x0600F536 RID: 62774 RVA: 0x00083B47 File Offset: 0x00081D47
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FB5 RID: 20405
			// (get) Token: 0x0600F537 RID: 62775 RVA: 0x0039EF80 File Offset: 0x0039D180
			// (set) Token: 0x0600F538 RID: 62776 RVA: 0x00083B66 File Offset: 0x00081D66
			public unsafe int _num_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr__num_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr__num_5__2)) = value;
				}
			}

			// Token: 0x17004FB6 RID: 20406
			// (get) Token: 0x0600F539 RID: 62777 RVA: 0x0039EFA8 File Offset: 0x0039D1A8
			// (set) Token: 0x0600F53A RID: 62778 RVA: 0x00083B81 File Offset: 0x00081D81
			public unsafe int _eatNumRecord_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr__eatNumRecord_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoshika._Eat_d__9.NativeFieldInfoPtr__eatNumRecord_5__3)) = value;
				}
			}

			// Token: 0x04009C1D RID: 39965
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009C1E RID: 39966
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009C1F RID: 39967
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009C20 RID: 39968
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C21 RID: 39969
			private static readonly IntPtr NativeFieldInfoPtr_thisPartner;

			// Token: 0x04009C22 RID: 39970
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x04009C23 RID: 39971
			private static readonly IntPtr NativeFieldInfoPtr__num_5__2;

			// Token: 0x04009C24 RID: 39972
			private static readonly IntPtr NativeFieldInfoPtr__eatNumRecord_5__3;

			// Token: 0x04009C25 RID: 39973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009C26 RID: 39974
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C27 RID: 39975
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009C28 RID: 39976
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009C29 RID: 39977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C2A RID: 39978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
