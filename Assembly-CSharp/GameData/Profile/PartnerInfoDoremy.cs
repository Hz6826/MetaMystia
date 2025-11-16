using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;

namespace GameData.Profile
{
	// Token: 0x02000320 RID: 800
	public class PartnerInfoDoremy : PartnerInfo
	{
		// Token: 0x06005EF3 RID: 24307 RVA: 0x001DA75C File Offset: 0x001D895C
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoDoremy()
		{
			Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoDoremy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr);
			PartnerInfoDoremy.NativeFieldInfoPtr_eachShallowDreamShardsDecreaseCookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, "eachShallowDreamShardsDecreaseCookTime");
			PartnerInfoDoremy.NativeFieldInfoPtr_eachShallowDreamShardsDecreaseCookTimeAfterSpring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, "eachShallowDreamShardsDecreaseCookTimeAfterSpring");
			PartnerInfoDoremy.NativeFieldInfoPtr_maxShallowDreamShardsNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, "maxShallowDreamShardsNum");
			PartnerInfoDoremy.NativeFieldInfoPtr_maxShallowDreamShardsNumAfterSpring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, "maxShallowDreamShardsNumAfterSpring");
			PartnerInfoDoremy.NativeFieldInfoPtr_eachPhantomDreamShardsExtraReturnIngRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, "eachPhantomDreamShardsExtraReturnIngRate");
			PartnerInfoDoremy.NativeFieldInfoPtr_eachPhantomDreamShardsExtraReturnIngRateAfterSpring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, "eachPhantomDreamShardsExtraReturnIngRateAfterSpring");
			PartnerInfoDoremy.NativeFieldInfoPtr_maxPhantomDreamShardsNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, "maxPhantomDreamShardsNum");
			PartnerInfoDoremy.NativeFieldInfoPtr_maxPhantomDreamShardsNumAfterSpring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, "maxPhantomDreamShardsNumAfterSpring");
			PartnerInfoDoremy.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, 100682817);
			PartnerInfoDoremy.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, 100682818);
			PartnerInfoDoremy.NativeMethodInfoPtr_GiveDreamShards_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, 100682819);
			PartnerInfoDoremy.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, 100682820);
			PartnerInfoDoremy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, 100682821);
			PartnerInfoDoremy.NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, 100682822);
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x001DA8A4 File Offset: 0x001D8AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235042, XrefRangeEnd = 235045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoDoremy.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x001DA8F4 File Offset: 0x001D8AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235045, XrefRangeEnd = 235055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoDoremy.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x001DA978 File Offset: 0x001D8B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235055, XrefRangeEnd = 235096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestGroupController.EvaluationResult GiveDreamShards(GuestGroupController.EvaluationResult result, GuestGroupController guestGroupController, bool oldComboProtect, out string newMessage, out bool comboProtect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PartnerInfoDoremy.NativeMethodInfoPtr_GiveDreamShards_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newMessage = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x001DAA0C File Offset: 0x001D8C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235096, XrefRangeEnd = 235110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &doNotCostIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoDoremy.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x001DAA94 File Offset: 0x001D8C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235110, XrefRangeEnd = 235111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoDoremy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoDoremy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x001DAAD0 File Offset: 0x001D8CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235111, XrefRangeEnd = 235122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_GuestGroupController_PDM_0(GuestGroupController guestGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoDoremy.NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x00033B88 File Offset: 0x00031D88
		public PartnerInfoDoremy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x06005EFB RID: 24315 RVA: 0x001DAB14 File Offset: 0x001D8D14
		// (set) Token: 0x06005EFC RID: 24316 RVA: 0x00033B91 File Offset: 0x00031D91
		public unsafe float eachShallowDreamShardsDecreaseCookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_eachShallowDreamShardsDecreaseCookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_eachShallowDreamShardsDecreaseCookTime)) = value;
			}
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x06005EFD RID: 24317 RVA: 0x001DAB3C File Offset: 0x001D8D3C
		// (set) Token: 0x06005EFE RID: 24318 RVA: 0x00033BAC File Offset: 0x00031DAC
		public unsafe float eachShallowDreamShardsDecreaseCookTimeAfterSpring
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_eachShallowDreamShardsDecreaseCookTimeAfterSpring);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_eachShallowDreamShardsDecreaseCookTimeAfterSpring)) = value;
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x06005EFF RID: 24319 RVA: 0x001DAB64 File Offset: 0x001D8D64
		// (set) Token: 0x06005F00 RID: 24320 RVA: 0x00033BC7 File Offset: 0x00031DC7
		public unsafe int maxShallowDreamShardsNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_maxShallowDreamShardsNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_maxShallowDreamShardsNum)) = value;
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x06005F01 RID: 24321 RVA: 0x001DAB8C File Offset: 0x001D8D8C
		// (set) Token: 0x06005F02 RID: 24322 RVA: 0x00033BE2 File Offset: 0x00031DE2
		public unsafe int maxShallowDreamShardsNumAfterSpring
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_maxShallowDreamShardsNumAfterSpring);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_maxShallowDreamShardsNumAfterSpring)) = value;
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x06005F03 RID: 24323 RVA: 0x001DABB4 File Offset: 0x001D8DB4
		// (set) Token: 0x06005F04 RID: 24324 RVA: 0x00033BFD File Offset: 0x00031DFD
		public unsafe float eachPhantomDreamShardsExtraReturnIngRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_eachPhantomDreamShardsExtraReturnIngRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_eachPhantomDreamShardsExtraReturnIngRate)) = value;
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x06005F05 RID: 24325 RVA: 0x001DABDC File Offset: 0x001D8DDC
		// (set) Token: 0x06005F06 RID: 24326 RVA: 0x00033C18 File Offset: 0x00031E18
		public unsafe float eachPhantomDreamShardsExtraReturnIngRateAfterSpring
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_eachPhantomDreamShardsExtraReturnIngRateAfterSpring);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_eachPhantomDreamShardsExtraReturnIngRateAfterSpring)) = value;
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x06005F07 RID: 24327 RVA: 0x001DAC04 File Offset: 0x001D8E04
		// (set) Token: 0x06005F08 RID: 24328 RVA: 0x00033C33 File Offset: 0x00031E33
		public unsafe int maxPhantomDreamShardsNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_maxPhantomDreamShardsNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_maxPhantomDreamShardsNum)) = value;
			}
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x06005F09 RID: 24329 RVA: 0x001DAC2C File Offset: 0x001D8E2C
		// (set) Token: 0x06005F0A RID: 24330 RVA: 0x00033C4E File Offset: 0x00031E4E
		public unsafe int maxPhantomDreamShardsNumAfterSpring
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_maxPhantomDreamShardsNumAfterSpring);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.NativeFieldInfoPtr_maxPhantomDreamShardsNumAfterSpring)) = value;
			}
		}

		// Token: 0x04003ED4 RID: 16084
		private static readonly IntPtr NativeFieldInfoPtr_eachShallowDreamShardsDecreaseCookTime;

		// Token: 0x04003ED5 RID: 16085
		private static readonly IntPtr NativeFieldInfoPtr_eachShallowDreamShardsDecreaseCookTimeAfterSpring;

		// Token: 0x04003ED6 RID: 16086
		private static readonly IntPtr NativeFieldInfoPtr_maxShallowDreamShardsNum;

		// Token: 0x04003ED7 RID: 16087
		private static readonly IntPtr NativeFieldInfoPtr_maxShallowDreamShardsNumAfterSpring;

		// Token: 0x04003ED8 RID: 16088
		private static readonly IntPtr NativeFieldInfoPtr_eachPhantomDreamShardsExtraReturnIngRate;

		// Token: 0x04003ED9 RID: 16089
		private static readonly IntPtr NativeFieldInfoPtr_eachPhantomDreamShardsExtraReturnIngRateAfterSpring;

		// Token: 0x04003EDA RID: 16090
		private static readonly IntPtr NativeFieldInfoPtr_maxPhantomDreamShardsNum;

		// Token: 0x04003EDB RID: 16091
		private static readonly IntPtr NativeFieldInfoPtr_maxPhantomDreamShardsNumAfterSpring;

		// Token: 0x04003EDC RID: 16092
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003EDD RID: 16093
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003EDE RID: 16094
		private static readonly IntPtr NativeMethodInfoPtr_GiveDreamShards_Private_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_0;

		// Token: 0x04003EDF RID: 16095
		private static readonly IntPtr NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0;

		// Token: 0x04003EE0 RID: 16096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003EE1 RID: 16097
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0;

		// Token: 0x02000D54 RID: 3412
		[ObfuscatedName("GameData.Profile.PartnerInfoDoremy+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600F470 RID: 62576 RVA: 0x0039CE30 File Offset: 0x0039B030
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<PartnerInfoDoremy.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoDoremy>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoDoremy.__c__DisplayClass10_0>.NativeClassPtr);
				PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr_enjoySpring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy.__c__DisplayClass10_0>.NativeClassPtr, "enjoySpring");
				PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy.__c__DisplayClass10_0>.NativeClassPtr, "<>9__0");
				PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoDoremy.__c__DisplayClass10_0>.NativeClassPtr, "<>9__1");
				PartnerInfoDoremy.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoDoremy.__c__DisplayClass10_0>.NativeClassPtr, 100682823);
				PartnerInfoDoremy.__c__DisplayClass10_0.NativeMethodInfoPtr__GiveDreamShards_b__0_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoDoremy.__c__DisplayClass10_0>.NativeClassPtr, 100682824);
				PartnerInfoDoremy.__c__DisplayClass10_0.NativeMethodInfoPtr__GiveDreamShards_b__1_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoDoremy.__c__DisplayClass10_0>.NativeClassPtr, 100682825);
			}

			// Token: 0x0600F471 RID: 62577 RVA: 0x0039CEE8 File Offset: 0x0039B0E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoDoremy.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoDoremy.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F472 RID: 62578 RVA: 0x0039CF24 File Offset: 0x0039B124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235018, XrefRangeEnd = 235030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GiveDreamShards_b__0(int num, string des)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref num;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(des);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoDoremy.__c__DisplayClass10_0.NativeMethodInfoPtr__GiveDreamShards_b__0_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F473 RID: 62579 RVA: 0x0039CF7C File Offset: 0x0039B17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235030, XrefRangeEnd = 235042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GiveDreamShards_b__1(int num, string des)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref num;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(des);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoDoremy.__c__DisplayClass10_0.NativeMethodInfoPtr__GiveDreamShards_b__1_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F474 RID: 62580 RVA: 0x000833C5 File Offset: 0x000815C5
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F74 RID: 20340
			// (get) Token: 0x0600F475 RID: 62581 RVA: 0x0039CFD4 File Offset: 0x0039B1D4
			// (set) Token: 0x0600F476 RID: 62582 RVA: 0x000833CE File Offset: 0x000815CE
			public unsafe bool enjoySpring
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr_enjoySpring);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr_enjoySpring)) = value;
				}
			}

			// Token: 0x17004F75 RID: 20341
			// (get) Token: 0x0600F477 RID: 62583 RVA: 0x0039CFFC File Offset: 0x0039B1FC
			// (set) Token: 0x0600F478 RID: 62584 RVA: 0x000833E9 File Offset: 0x000815E9
			public unsafe PartnerInfoDoremy __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoDoremy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F76 RID: 20342
			// (get) Token: 0x0600F479 RID: 62585 RVA: 0x0039D02C File Offset: 0x0039B22C
			// (set) Token: 0x0600F47A RID: 62586 RVA: 0x00083408 File Offset: 0x00081608
			public unsafe Func<int, string, string> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F77 RID: 20343
			// (get) Token: 0x0600F47B RID: 62587 RVA: 0x0039D05C File Offset: 0x0039B25C
			// (set) Token: 0x0600F47C RID: 62588 RVA: 0x00083427 File Offset: 0x00081627
			public unsafe Func<int, string, string> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoDoremy.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BBC RID: 39868
			private static readonly IntPtr NativeFieldInfoPtr_enjoySpring;

			// Token: 0x04009BBD RID: 39869
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BBE RID: 39870
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04009BBF RID: 39871
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04009BC0 RID: 39872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BC1 RID: 39873
			private static readonly IntPtr NativeMethodInfoPtr__GiveDreamShards_b__0_Internal_String_Int32_String_0;

			// Token: 0x04009BC2 RID: 39874
			private static readonly IntPtr NativeMethodInfoPtr__GiveDreamShards_b__1_Internal_String_Int32_String_0;
		}
	}
}
