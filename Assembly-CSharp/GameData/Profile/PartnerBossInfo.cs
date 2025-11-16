using System;
using System.Runtime.InteropServices;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using NightScene.EventUtility;
using NightScene.PartnerUtility;

namespace GameData.Profile
{
	// Token: 0x0200031A RID: 794
	public class PartnerBossInfo : PartnerInfo
	{
		// Token: 0x06005E2E RID: 24110 RVA: 0x001D78C8 File Offset: 0x001D5AC8
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerBossInfo()
		{
			Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerBossInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr);
			PartnerBossInfo.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, "level");
			PartnerBossInfo.NativeFieldInfoPtr_preferCookerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, "preferCookerType");
			PartnerBossInfo.NativeFieldInfoPtr_preferTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, "preferTags");
			PartnerBossInfo.NativeFieldInfoPtr_normalGuestServeWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, "normalGuestServeWeight");
			PartnerBossInfo.NativeFieldInfoPtr_specGuestSatisfyWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, "specGuestSatisfyWeight");
			PartnerBossInfo.NativeMethodInfoPtr_get_DoNotShowRevenueCut_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682627);
			PartnerBossInfo.NativeMethodInfoPtr_get_PreferCookerType_Public_get_Il2CppStructArray_1_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682628);
			PartnerBossInfo.NativeMethodInfoPtr_get_PreferTags_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682629);
			PartnerBossInfo.NativeMethodInfoPtr_get_TipRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682630);
			PartnerBossInfo.NativeMethodInfoPtr_get_CookSpeedMultiplier_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682631);
			PartnerBossInfo.NativeMethodInfoPtr_get_MoveSpdMultiplier_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682632);
			PartnerBossInfo.NativeMethodInfoPtr_get_EvalConditions_Public_get_List_1_EvalCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682633);
			PartnerBossInfo.NativeMethodInfoPtr_get_NormalGuestServeWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682634);
			PartnerBossInfo.NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682635);
			PartnerBossInfo.NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682636);
			PartnerBossInfo.NativeMethodInfoPtr_PreProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682637);
			PartnerBossInfo.NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_New_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682638);
			PartnerBossInfo.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682639);
			PartnerBossInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, 100682640);
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x06005E2F RID: 24111 RVA: 0x001D7A74 File Offset: 0x001D5C74
		public unsafe override bool DoNotShowRevenueCut
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfo.NativeMethodInfoPtr_get_DoNotShowRevenueCut_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x06005E30 RID: 24112 RVA: 0x001D7ABC File Offset: 0x001D5CBC
		public unsafe Il2CppStructArray<Cooker.CookerType> PreferCookerType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 233888, RefRangeEnd = 233892, XrefRangeStart = 233885, XrefRangeEnd = 233888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfo.NativeMethodInfoPtr_get_PreferCookerType_Public_get_Il2CppStructArray_1_CookerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Cooker.CookerType>>(intPtr3) : null;
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06005E31 RID: 24113 RVA: 0x001D7AFC File Offset: 0x001D5CFC
		public unsafe Il2CppStructArray<int> PreferTags
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 233897, RefRangeEnd = 233901, XrefRangeStart = 233892, XrefRangeEnd = 233897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfo.NativeMethodInfoPtr_get_PreferTags_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06005E32 RID: 24114 RVA: 0x001D7B3C File Offset: 0x001D5D3C
		public unsafe float TipRate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 233903, RefRangeEnd = 233904, XrefRangeStart = 233901, XrefRangeEnd = 233903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfo.NativeMethodInfoPtr_get_TipRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06005E33 RID: 24115 RVA: 0x001D7B78 File Offset: 0x001D5D78
		public unsafe float CookSpeedMultiplier
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 233906, RefRangeEnd = 233908, XrefRangeStart = 233904, XrefRangeEnd = 233906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfo.NativeMethodInfoPtr_get_CookSpeedMultiplier_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06005E34 RID: 24116 RVA: 0x001D7BB4 File Offset: 0x001D5DB4
		public unsafe override float MoveSpdMultiplier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233908, XrefRangeEnd = 233910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfo.NativeMethodInfoPtr_get_MoveSpdMultiplier_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06005E35 RID: 24117 RVA: 0x001D7BFC File Offset: 0x001D5DFC
		public unsafe List<PartnerBossInfo.EvalCondition> EvalConditions
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 233930, RefRangeEnd = 233931, XrefRangeStart = 233910, XrefRangeEnd = 233930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfo.NativeMethodInfoPtr_get_EvalConditions_Public_get_List_1_EvalCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PartnerBossInfo.EvalCondition>>(intPtr3) : null;
			}
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06005E36 RID: 24118 RVA: 0x001D7C3C File Offset: 0x001D5E3C
		public unsafe float NormalGuestServeWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfo.NativeMethodInfoPtr_get_NormalGuestServeWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x001D7C78 File Offset: 0x001D5E78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PartnerInfoBase.PartnerType GetPartnerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfo.NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x001D7CC0 File Offset: 0x001D5EC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233933, RefRangeEnd = 233935, XrefRangeStart = 233931, XrefRangeEnd = 233933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetBossSpecialSkill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfo.NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x001D7D04 File Offset: 0x001D5F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233935, XrefRangeEnd = 233942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfo.NativeMethodInfoPtr_PreProcessInfo_Protected_Virtual_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x001D7D54 File Offset: 0x001D5F54
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BossSpecialAbilityPreLoad(PartnerBase currentPartner, EventManager eventManager, PartnerManager manager, Il2CppReferenceArray<Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPartner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfo.NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_New_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x001D7DD8 File Offset: 0x001D5FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233942, XrefRangeEnd = 233943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfo.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x001D7E5C File Offset: 0x001D605C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerBossInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x00033568 File Offset: 0x00031768
		public PartnerBossInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06005E3E RID: 24126 RVA: 0x001D7E98 File Offset: 0x001D6098
		// (set) Token: 0x06005E3F RID: 24127 RVA: 0x00033571 File Offset: 0x00031771
		public unsafe int level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfo.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfo.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x06005E40 RID: 24128 RVA: 0x001D7EC0 File Offset: 0x001D60C0
		// (set) Token: 0x06005E41 RID: 24129 RVA: 0x0003358C File Offset: 0x0003178C
		public unsafe Il2CppStructArray<Cooker.CookerType> preferCookerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfo.NativeFieldInfoPtr_preferCookerType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Cooker.CookerType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfo.NativeFieldInfoPtr_preferCookerType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x06005E42 RID: 24130 RVA: 0x001D7EF0 File Offset: 0x001D60F0
		// (set) Token: 0x06005E43 RID: 24131 RVA: 0x000335AB File Offset: 0x000317AB
		public unsafe Il2CppStructArray<int> preferTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfo.NativeFieldInfoPtr_preferTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfo.NativeFieldInfoPtr_preferTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x001D7F20 File Offset: 0x001D6120
		// (set) Token: 0x06005E45 RID: 24133 RVA: 0x000335CA File Offset: 0x000317CA
		public unsafe float normalGuestServeWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfo.NativeFieldInfoPtr_normalGuestServeWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfo.NativeFieldInfoPtr_normalGuestServeWeight)) = value;
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06005E46 RID: 24134 RVA: 0x001D7F48 File Offset: 0x001D6148
		// (set) Token: 0x06005E47 RID: 24135 RVA: 0x000335E5 File Offset: 0x000317E5
		public unsafe PartnerBossInfo.SpecGuestSatisfyWeight specGuestSatisfyWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfo.NativeFieldInfoPtr_specGuestSatisfyWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfo.NativeFieldInfoPtr_specGuestSatisfyWeight)) = value;
			}
		}

		// Token: 0x04003E50 RID: 15952
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003E51 RID: 15953
		private static readonly IntPtr NativeFieldInfoPtr_preferCookerType;

		// Token: 0x04003E52 RID: 15954
		private static readonly IntPtr NativeFieldInfoPtr_preferTags;

		// Token: 0x04003E53 RID: 15955
		private static readonly IntPtr NativeFieldInfoPtr_normalGuestServeWeight;

		// Token: 0x04003E54 RID: 15956
		private static readonly IntPtr NativeFieldInfoPtr_specGuestSatisfyWeight;

		// Token: 0x04003E55 RID: 15957
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotShowRevenueCut_Protected_Virtual_get_Boolean_0;

		// Token: 0x04003E56 RID: 15958
		private static readonly IntPtr NativeMethodInfoPtr_get_PreferCookerType_Public_get_Il2CppStructArray_1_CookerType_0;

		// Token: 0x04003E57 RID: 15959
		private static readonly IntPtr NativeMethodInfoPtr_get_PreferTags_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003E58 RID: 15960
		private static readonly IntPtr NativeMethodInfoPtr_get_TipRate_Public_get_Single_0;

		// Token: 0x04003E59 RID: 15961
		private static readonly IntPtr NativeMethodInfoPtr_get_CookSpeedMultiplier_Protected_get_Single_0;

		// Token: 0x04003E5A RID: 15962
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveSpdMultiplier_Public_Virtual_get_Single_0;

		// Token: 0x04003E5B RID: 15963
		private static readonly IntPtr NativeMethodInfoPtr_get_EvalConditions_Public_get_List_1_EvalCondition_0;

		// Token: 0x04003E5C RID: 15964
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestServeWeight_Public_get_Single_0;

		// Token: 0x04003E5D RID: 15965
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0;

		// Token: 0x04003E5E RID: 15966
		private static readonly IntPtr NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_New_String_0;

		// Token: 0x04003E5F RID: 15967
		private static readonly IntPtr NativeMethodInfoPtr_PreProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003E60 RID: 15968
		private static readonly IntPtr NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_New_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003E61 RID: 15969
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003E62 RID: 15970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D3A RID: 3386
		public enum EvalCondition
		{
			// Token: 0x04009B12 RID: 39698
			None,
			// Token: 0x04009B13 RID: 39699
			Normal,
			// Token: 0x04009B14 RID: 39700
			Good,
			// Token: 0x04009B15 RID: 39701
			ExGood
		}

		// Token: 0x02000D3B RID: 3387
		[Serializable]
		[StructLayout(2)]
		public struct SpecGuestSatisfyWeight
		{
			// Token: 0x0600F37C RID: 62332 RVA: 0x0039A2B4 File Offset: 0x003984B4
			// Note: this type is marked as 'beforefieldinit'.
			static SpecGuestSatisfyWeight()
			{
				Il2CppClassPointerStore<PartnerBossInfo.SpecGuestSatisfyWeight>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfo>.NativeClassPtr, "SpecGuestSatisfyWeight");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfo.SpecGuestSatisfyWeight>.NativeClassPtr);
				PartnerBossInfo.SpecGuestSatisfyWeight.NativeFieldInfoPtr_NormalEvalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfo.SpecGuestSatisfyWeight>.NativeClassPtr, "NormalEvalWeight");
				PartnerBossInfo.SpecGuestSatisfyWeight.NativeFieldInfoPtr_GoodEvalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfo.SpecGuestSatisfyWeight>.NativeClassPtr, "GoodEvalWeight");
				PartnerBossInfo.SpecGuestSatisfyWeight.NativeFieldInfoPtr_ExGoodEvalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfo.SpecGuestSatisfyWeight>.NativeClassPtr, "ExGoodEvalWeight");
				PartnerBossInfo.SpecGuestSatisfyWeight.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfo.SpecGuestSatisfyWeight>.NativeClassPtr, 100682641);
			}

			// Token: 0x0600F37D RID: 62333 RVA: 0x0039A330 File Offset: 0x00398530
			[CallerCount(0)]
			public unsafe SpecGuestSatisfyWeight(int normalEvalWeight, int goodEvalWeight, int exGoodEvalWeight)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref normalEvalWeight;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goodEvalWeight;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exGoodEvalWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfo.SpecGuestSatisfyWeight.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F37E RID: 62334 RVA: 0x00082B8A File Offset: 0x00080D8A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PartnerBossInfo.SpecGuestSatisfyWeight>.NativeClassPtr, ref this));
			}

			// Token: 0x04009B16 RID: 39702
			private static readonly IntPtr NativeFieldInfoPtr_NormalEvalWeight;

			// Token: 0x04009B17 RID: 39703
			private static readonly IntPtr NativeFieldInfoPtr_GoodEvalWeight;

			// Token: 0x04009B18 RID: 39704
			private static readonly IntPtr NativeFieldInfoPtr_ExGoodEvalWeight;

			// Token: 0x04009B19 RID: 39705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

			// Token: 0x04009B1A RID: 39706
			[FieldOffset(0)]
			public int NormalEvalWeight;

			// Token: 0x04009B1B RID: 39707
			[FieldOffset(4)]
			public int GoodEvalWeight;

			// Token: 0x04009B1C RID: 39708
			[FieldOffset(8)]
			public int ExGoodEvalWeight;
		}
	}
}
