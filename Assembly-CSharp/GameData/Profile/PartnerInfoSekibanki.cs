using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x0200032A RID: 810
	public sealed class PartnerInfoSekibanki : PartnerInfo
	{
		// Token: 0x06005F6C RID: 24428 RVA: 0x001DC1B8 File Offset: 0x001DA3B8
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoSekibanki()
		{
			Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoSekibanki");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr);
			PartnerInfoSekibanki.NativeFieldInfoPtr_SEKIBANKI_FLY_HEAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, "SEKIBANKI_FLY_HEAD");
			PartnerInfoSekibanki.NativeFieldInfoPtr_extraMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, "extraMoveSpeed");
			PartnerInfoSekibanki.NativeFieldInfoPtr_extraWorkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, "extraWorkSpeed");
			PartnerInfoSekibanki.NativeFieldInfoPtr_headLinkVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, "headLinkVFX");
			PartnerInfoSekibanki.NativeMethodInfoPtr_GetCompanionPartnerType_Public_Virtual_Il2CppReferenceArray_1_ValueTuple_2_CompanionProperty_PartnerType_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, 100682894);
			PartnerInfoSekibanki.NativeMethodInfoPtr_CouldRestHeadNum_Private_Int32_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, 100682895);
			PartnerInfoSekibanki.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, 100682896);
			PartnerInfoSekibanki.NativeMethodInfoPtr_GetHeadIndex_Private_Int32_PartnerType_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, 100682897);
			PartnerInfoSekibanki.NativeMethodInfoPtr_GetMoveSpeedText_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, 100682898);
			PartnerInfoSekibanki.NativeMethodInfoPtr_GetWorkSpeedText_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, 100682899);
			PartnerInfoSekibanki.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, 100682900);
			PartnerInfoSekibanki.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, 100682901);
		}

		// Token: 0x06005F6D RID: 24429 RVA: 0x001DC2D8 File Offset: 0x001DA4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235683, XrefRangeEnd = 235690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ValueTuple<PartnerInfoBase.CompanionProperty, PartnerBase.PartnerType>> GetCompanionPartnerType(PartnerBase currentPartner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPartner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.NativeMethodInfoPtr_GetCompanionPartnerType_Public_Virtual_Il2CppReferenceArray_1_ValueTuple_2_CompanionProperty_PartnerType_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<PartnerInfoBase.CompanionProperty, PartnerBase.PartnerType>>>(intPtr3) : null;
		}

		// Token: 0x06005F6E RID: 24430 RVA: 0x001DC328 File Offset: 0x001DA528
		[CallerCount(0)]
		public unsafe int CouldRestHeadNum(PartnerBase currentPartner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPartner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.NativeMethodInfoPtr_CouldRestHeadNum_Private_Int32_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x001DC378 File Offset: 0x001DA578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235690, XrefRangeEnd = 235712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x001DC3F4 File Offset: 0x001DA5F4
		[CallerCount(0)]
		public unsafe int GetHeadIndex(PartnerBase.PartnerType thisPartnerType, PartnerBase.PartnerType companionPartnerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref thisPartnerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref companionPartnerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.NativeMethodInfoPtr_GetHeadIndex_Private_Int32_PartnerType_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x001DC44C File Offset: 0x001DA64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235712, XrefRangeEnd = 235717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetMoveSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.NativeMethodInfoPtr_GetMoveSpeedText_Protected_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x001DC484 File Offset: 0x001DA684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235717, XrefRangeEnd = 235722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetWorkSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.NativeMethodInfoPtr_GetWorkSpeedText_Protected_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x001DC4BC File Offset: 0x001DA6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235722, XrefRangeEnd = 235725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x001DC500 File Offset: 0x001DA700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235725, XrefRangeEnd = 235726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoSekibanki() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x00033F3A File Offset: 0x0003213A
		public PartnerInfoSekibanki(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06005F76 RID: 24438 RVA: 0x001DC53C File Offset: 0x001DA73C
		// (set) Token: 0x06005F77 RID: 24439 RVA: 0x00033F43 File Offset: 0x00032143
		public unsafe static string SEKIBANKI_FLY_HEAD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PartnerInfoSekibanki.NativeFieldInfoPtr_SEKIBANKI_FLY_HEAD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerInfoSekibanki.NativeFieldInfoPtr_SEKIBANKI_FLY_HEAD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06005F78 RID: 24440 RVA: 0x001DC55C File Offset: 0x001DA75C
		// (set) Token: 0x06005F79 RID: 24441 RVA: 0x00033F55 File Offset: 0x00032155
		public unsafe float extraMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.NativeFieldInfoPtr_extraMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.NativeFieldInfoPtr_extraMoveSpeed)) = value;
			}
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06005F7A RID: 24442 RVA: 0x001DC584 File Offset: 0x001DA784
		// (set) Token: 0x06005F7B RID: 24443 RVA: 0x00033F70 File Offset: 0x00032170
		public unsafe float extraWorkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.NativeFieldInfoPtr_extraWorkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.NativeFieldInfoPtr_extraWorkSpeed)) = value;
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06005F7C RID: 24444 RVA: 0x001DC5AC File Offset: 0x001DA7AC
		// (set) Token: 0x06005F7D RID: 24445 RVA: 0x00033F8B File Offset: 0x0003218B
		public unsafe GameObject headLinkVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.NativeFieldInfoPtr_headLinkVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.NativeFieldInfoPtr_headLinkVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003F1B RID: 16155
		private static readonly IntPtr NativeFieldInfoPtr_SEKIBANKI_FLY_HEAD;

		// Token: 0x04003F1C RID: 16156
		private static readonly IntPtr NativeFieldInfoPtr_extraMoveSpeed;

		// Token: 0x04003F1D RID: 16157
		private static readonly IntPtr NativeFieldInfoPtr_extraWorkSpeed;

		// Token: 0x04003F1E RID: 16158
		private static readonly IntPtr NativeFieldInfoPtr_headLinkVFX;

		// Token: 0x04003F1F RID: 16159
		private static readonly IntPtr NativeMethodInfoPtr_GetCompanionPartnerType_Public_Virtual_Il2CppReferenceArray_1_ValueTuple_2_CompanionProperty_PartnerType_PartnerBase_0;

		// Token: 0x04003F20 RID: 16160
		private static readonly IntPtr NativeMethodInfoPtr_CouldRestHeadNum_Private_Int32_PartnerBase_0;

		// Token: 0x04003F21 RID: 16161
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003F22 RID: 16162
		private static readonly IntPtr NativeMethodInfoPtr_GetHeadIndex_Private_Int32_PartnerType_PartnerType_0;

		// Token: 0x04003F23 RID: 16163
		private static readonly IntPtr NativeMethodInfoPtr_GetMoveSpeedText_Protected_Virtual_String_0;

		// Token: 0x04003F24 RID: 16164
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkSpeedText_Protected_Virtual_String_0;

		// Token: 0x04003F25 RID: 16165
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003F26 RID: 16166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D5B RID: 3419
		[ObfuscatedName("GameData.Profile.PartnerInfoSekibanki+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F4DF RID: 62687 RVA: 0x0039E008 File Offset: 0x0039C208
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr);
				PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr_partnerBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr, "partnerBase");
				PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr, "partnerManager");
				PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr, "eventManager");
				PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr, "<>9__1");
				PartnerInfoSekibanki.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr, 100682902);
				PartnerInfoSekibanki.__c__DisplayClass6_0.NativeMethodInfoPtr__OnPartnerLoad_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr, 100682903);
				PartnerInfoSekibanki.__c__DisplayClass6_0.NativeMethodInfoPtr__OnPartnerLoad_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr, 100682904);
			}

			// Token: 0x0600F4E0 RID: 62688 RVA: 0x0039E0D4 File Offset: 0x0039C2D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4E1 RID: 62689 RVA: 0x0039E110 File Offset: 0x0039C310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235573, XrefRangeEnd = 235584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeMethodInfoPtr__OnPartnerLoad_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4E2 RID: 62690 RVA: 0x0039E144 File Offset: 0x0039C344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235584, XrefRangeEnd = 235612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeMethodInfoPtr__OnPartnerLoad_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4E3 RID: 62691 RVA: 0x00083812 File Offset: 0x00081A12
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F99 RID: 20377
			// (get) Token: 0x0600F4E4 RID: 62692 RVA: 0x0039E184 File Offset: 0x0039C384
			// (set) Token: 0x0600F4E5 RID: 62693 RVA: 0x0008381B File Offset: 0x00081A1B
			public unsafe PartnerBase partnerBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr_partnerBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr_partnerBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F9A RID: 20378
			// (get) Token: 0x0600F4E6 RID: 62694 RVA: 0x0039E1B4 File Offset: 0x0039C3B4
			// (set) Token: 0x0600F4E7 RID: 62695 RVA: 0x0008383A File Offset: 0x00081A3A
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F9B RID: 20379
			// (get) Token: 0x0600F4E8 RID: 62696 RVA: 0x0039E1E4 File Offset: 0x0039C3E4
			// (set) Token: 0x0600F4E9 RID: 62697 RVA: 0x00083859 File Offset: 0x00081A59
			public unsafe PartnerInfoSekibanki __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoSekibanki>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F9C RID: 20380
			// (get) Token: 0x0600F4EA RID: 62698 RVA: 0x0039E214 File Offset: 0x0039C414
			// (set) Token: 0x0600F4EB RID: 62699 RVA: 0x00083878 File Offset: 0x00081A78
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F9D RID: 20381
			// (get) Token: 0x0600F4EC RID: 62700 RVA: 0x0039E244 File Offset: 0x0039C444
			// (set) Token: 0x0600F4ED RID: 62701 RVA: 0x00083897 File Offset: 0x00081A97
			public unsafe Action<int> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BF7 RID: 39927
			private static readonly IntPtr NativeFieldInfoPtr_partnerBase;

			// Token: 0x04009BF8 RID: 39928
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x04009BF9 RID: 39929
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BFA RID: 39930
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009BFB RID: 39931
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04009BFC RID: 39932
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BFD RID: 39933
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__0_Internal_Void_0;

			// Token: 0x04009BFE RID: 39934
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__1_Internal_Void_Int32_0;
		}

		// Token: 0x02000D5C RID: 3420
		[ObfuscatedName("GameData.Profile.PartnerInfoSekibanki+<>c__DisplayClass6_1")]
		public sealed class __c__DisplayClass6_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F4EE RID: 62702 RVA: 0x0039E274 File Offset: 0x0039C474
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_1()
			{
				Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, "<>c__DisplayClass6_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1>.NativeClassPtr);
				PartnerInfoSekibanki.__c__DisplayClass6_1.NativeFieldInfoPtr_companionPartnerBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1>.NativeClassPtr, "companionPartnerBase");
				PartnerInfoSekibanki.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1>.NativeClassPtr, "CS$<>8__locals1");
				PartnerInfoSekibanki.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1>.NativeClassPtr, 100682905);
				PartnerInfoSekibanki.__c__DisplayClass6_1.NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1>.NativeClassPtr, 100682906);
				PartnerInfoSekibanki.__c__DisplayClass6_1.NativeMethodInfoPtr__OnPartnerLoad_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1>.NativeClassPtr, 100682907);
				PartnerInfoSekibanki.__c__DisplayClass6_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1>.NativeClassPtr, 100682908);
			}

			// Token: 0x0600F4EF RID: 62703 RVA: 0x0039E318 File Offset: 0x0039C518
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4F0 RID: 62704 RVA: 0x0039E354 File Offset: 0x0039C554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235654, XrefRangeEnd = 235664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_1.NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4F1 RID: 62705 RVA: 0x0039E388 File Offset: 0x0039C588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235664, XrefRangeEnd = 235677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_1.NativeMethodInfoPtr__OnPartnerLoad_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4F2 RID: 62706 RVA: 0x0039E3BC File Offset: 0x0039C5BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235677, XrefRangeEnd = 235682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F4F3 RID: 62707 RVA: 0x000838B6 File Offset: 0x00081AB6
			public __c__DisplayClass6_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F9E RID: 20382
			// (get) Token: 0x0600F4F4 RID: 62708 RVA: 0x0039E3FC File Offset: 0x0039C5FC
			// (set) Token: 0x0600F4F5 RID: 62709 RVA: 0x000838BF File Offset: 0x00081ABF
			public unsafe PartnerBase companionPartnerBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.NativeFieldInfoPtr_companionPartnerBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.NativeFieldInfoPtr_companionPartnerBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F9F RID: 20383
			// (get) Token: 0x0600F4F6 RID: 62710 RVA: 0x0039E42C File Offset: 0x0039C62C
			// (set) Token: 0x0600F4F7 RID: 62711 RVA: 0x000838DE File Offset: 0x00081ADE
			public unsafe PartnerInfoSekibanki.__c__DisplayClass6_0 field_Public___c__DisplayClass6_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoSekibanki.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BFF RID: 39935
			private static readonly IntPtr NativeFieldInfoPtr_companionPartnerBase;

			// Token: 0x04009C00 RID: 39936
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0;

			// Token: 0x04009C01 RID: 39937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C02 RID: 39938
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_0;

			// Token: 0x04009C03 RID: 39939
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__3_Internal_Void_0;

			// Token: 0x04009C04 RID: 39940
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200109B RID: 4251
			[ObfuscatedName("GameData.Profile.PartnerInfoSekibanki+<>c__DisplayClass6_1+<<OnPartnerLoad>g__ResetHead|4>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060121B0 RID: 74160 RVA: 0x00421BEC File Offset: 0x0041FDEC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique()
				{
					Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1>.NativeClassPtr, "<<OnPartnerLoad>g__ResetHead|4>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr);
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>1__state");
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>2__current");
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>4__this");
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<>8__1");
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr__thisTransform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, "<thisTransform>5__2");
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100682909);
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100682910);
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100682911);
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100682912);
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100682913);
					PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr, 100682914);
				}

				// Token: 0x060121B1 RID: 74161 RVA: 0x00421CF4 File Offset: 0x0041FEF4
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121B2 RID: 74162 RVA: 0x00421D3C File Offset: 0x0041FF3C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121B3 RID: 74163 RVA: 0x00421D70 File Offset: 0x0041FF70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235612, XrefRangeEnd = 235648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E92 RID: 24210
				// (get) Token: 0x060121B4 RID: 74164 RVA: 0x00421DAC File Offset: 0x0041FFAC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060121B5 RID: 74165 RVA: 0x00421DEC File Offset: 0x0041FFEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235648, XrefRangeEnd = 235654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E93 RID: 24211
				// (get) Token: 0x060121B6 RID: 74166 RVA: 0x00421E20 File Offset: 0x00420020
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060121B7 RID: 74167 RVA: 0x0009D4FB File Offset: 0x0009B6FB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E8D RID: 24205
				// (get) Token: 0x060121B8 RID: 74168 RVA: 0x00421E60 File Offset: 0x00420060
				// (set) Token: 0x060121B9 RID: 74169 RVA: 0x0009D504 File Offset: 0x0009B704
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E8E RID: 24206
				// (get) Token: 0x060121BA RID: 74170 RVA: 0x00421E88 File Offset: 0x00420088
				// (set) Token: 0x060121BB RID: 74171 RVA: 0x0009D51F File Offset: 0x0009B71F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E8F RID: 24207
				// (get) Token: 0x060121BC RID: 74172 RVA: 0x00421EB8 File Offset: 0x004200B8
				// (set) Token: 0x060121BD RID: 74173 RVA: 0x0009D53E File Offset: 0x0009B73E
				public unsafe PartnerInfoSekibanki.__c__DisplayClass6_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoSekibanki.__c__DisplayClass6_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E90 RID: 24208
				// (get) Token: 0x060121BE RID: 74174 RVA: 0x00421EE8 File Offset: 0x004200E8
				// (set) Token: 0x060121BF RID: 74175 RVA: 0x0009D55D File Offset: 0x0009B75D
				public unsafe PartnerInfoSekibanki.__c__DisplayClass6_2 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoSekibanki.__c__DisplayClass6_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E91 RID: 24209
				// (get) Token: 0x060121C0 RID: 74176 RVA: 0x00421F18 File Offset: 0x00420118
				// (set) Token: 0x060121C1 RID: 74177 RVA: 0x0009D57C File Offset: 0x0009B77C
				public unsafe Transform _thisTransform_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr__thisTransform_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrObObUnique.NativeFieldInfoPtr__thisTransform_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B772 RID: 46962
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B773 RID: 46963
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B774 RID: 46964
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B775 RID: 46965
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B776 RID: 46966
				private static readonly IntPtr NativeFieldInfoPtr__thisTransform_5__2;

				// Token: 0x0400B777 RID: 46967
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B778 RID: 46968
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B779 RID: 46969
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B77A RID: 46970
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B77B RID: 46971
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B77C RID: 46972
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D5D RID: 3421
		[ObfuscatedName("GameData.Profile.PartnerInfoSekibanki+<>c__DisplayClass6_2")]
		public sealed class __c__DisplayClass6_2 : Il2CppSystem.Object
		{
			// Token: 0x0600F4F8 RID: 62712 RVA: 0x0039E45C File Offset: 0x0039C65C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_2()
			{
				Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoSekibanki>.NativeClassPtr, "<>c__DisplayClass6_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_2>.NativeClassPtr);
				PartnerInfoSekibanki.__c__DisplayClass6_2.NativeFieldInfoPtr_parentTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_2>.NativeClassPtr, "parentTransform");
				PartnerInfoSekibanki.__c__DisplayClass6_2.NativeFieldInfoPtr_field_Public___c__DisplayClass6_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_2>.NativeClassPtr, "CS$<>8__locals2");
				PartnerInfoSekibanki.__c__DisplayClass6_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_2>.NativeClassPtr, 100682915);
				PartnerInfoSekibanki.__c__DisplayClass6_2.NativeMethodInfoPtr__OnPartnerLoad_b__5_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_2>.NativeClassPtr, 100682916);
			}

			// Token: 0x0600F4F9 RID: 62713 RVA: 0x0039E4D8 File Offset: 0x0039C6D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSekibanki.__c__DisplayClass6_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4FA RID: 62714 RVA: 0x0039E514 File Offset: 0x0039C714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235682, XrefRangeEnd = 235683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnPartnerLoad_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSekibanki.__c__DisplayClass6_2.NativeMethodInfoPtr__OnPartnerLoad_b__5_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F4FB RID: 62715 RVA: 0x000838FD File Offset: 0x00081AFD
			public __c__DisplayClass6_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FA0 RID: 20384
			// (get) Token: 0x0600F4FC RID: 62716 RVA: 0x0039E550 File Offset: 0x0039C750
			// (set) Token: 0x0600F4FD RID: 62717 RVA: 0x00083906 File Offset: 0x00081B06
			public unsafe Transform parentTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_2.NativeFieldInfoPtr_parentTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_2.NativeFieldInfoPtr_parentTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FA1 RID: 20385
			// (get) Token: 0x0600F4FE RID: 62718 RVA: 0x0039E580 File Offset: 0x0039C780
			// (set) Token: 0x0600F4FF RID: 62719 RVA: 0x00083925 File Offset: 0x00081B25
			public unsafe PartnerInfoSekibanki.__c__DisplayClass6_1 field_Public___c__DisplayClass6_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_2.NativeFieldInfoPtr_field_Public___c__DisplayClass6_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoSekibanki.__c__DisplayClass6_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSekibanki.__c__DisplayClass6_2.NativeFieldInfoPtr_field_Public___c__DisplayClass6_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C05 RID: 39941
			private static readonly IntPtr NativeFieldInfoPtr_parentTransform;

			// Token: 0x04009C06 RID: 39942
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass6_1_0;

			// Token: 0x04009C07 RID: 39943
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C08 RID: 39944
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__5_Internal_Vector3_0;
		}
	}
}
