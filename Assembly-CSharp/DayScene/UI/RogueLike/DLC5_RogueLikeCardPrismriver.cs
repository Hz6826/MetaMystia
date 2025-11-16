using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;
using NightScene.GuestManagementUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000ED RID: 237
	public class DLC5_RogueLikeCardPrismriver : RogueLikeCard
	{
		// Token: 0x06001AF8 RID: 6904 RVA: 0x000F8814 File Offset: 0x000F6A14
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPrismriver()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardPrismriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr);
			DLC5_RogueLikeCardPrismriver.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr, "datas");
			DLC5_RogueLikeCardPrismriver.NativeFieldInfoPtr_baseResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr, "baseResult");
			DLC5_RogueLikeCardPrismriver.NativeFieldInfoPtr_addCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr, "addCombo");
			DLC5_RogueLikeCardPrismriver.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr, 100668152);
			DLC5_RogueLikeCardPrismriver.NativeMethodInfoPtr_GetDataByRarity_Private_Int32_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr, 100668153);
			DLC5_RogueLikeCardPrismriver.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr, 100668154);
			DLC5_RogueLikeCardPrismriver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr, 100668155);
			DLC5_RogueLikeCardPrismriver.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr, 100668156);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000F88E4 File Offset: 0x000F6AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71330, XrefRangeEnd = 71337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPrismriver.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000F8964 File Offset: 0x000F6B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71337, XrefRangeEnd = 71340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataByRarity(RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.NativeMethodInfoPtr_GetDataByRarity_Private_Int32_Rarity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000F89B0 File Offset: 0x000F6BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71340, XrefRangeEnd = 71355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPrismriver.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x000F8A14 File Offset: 0x000F6C14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPrismriver() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x000F8A50 File Offset: 0x000F6C50
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0001090C File Offset: 0x0000EB0C
		public DLC5_RogueLikeCardPrismriver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x000F8AC8 File Offset: 0x000F6CC8
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x00010915 File Offset: 0x0000EB15
		public unsafe Il2CppReferenceArray<RarityDataMappingForDuration> datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.NativeFieldInfoPtr_datas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RarityDataMappingForDuration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.NativeFieldInfoPtr_datas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x000F8AF8 File Offset: 0x000F6CF8
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x00010934 File Offset: 0x0000EB34
		public unsafe GuestGroupController.EvaluationResult baseResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.NativeFieldInfoPtr_baseResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.NativeFieldInfoPtr_baseResult)) = value;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x000F8B20 File Offset: 0x000F6D20
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0001094F File Offset: 0x0000EB4F
		public unsafe int addCombo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.NativeFieldInfoPtr_addCombo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.NativeFieldInfoPtr_addCombo)) = value;
			}
		}

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeFieldInfoPtr_baseResult;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeFieldInfoPtr_addCombo;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_GetDataByRarity_Private_Int32_Rarity_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x020006AE RID: 1710
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPrismriver+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600986E RID: 39022 RVA: 0x0028BC2C File Offset: 0x00289E2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr);
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, "<>9__3");
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, "<>9__6");
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, "<>9__4");
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, "<>9__5");
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, 100668157);
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, 100668158);
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__3_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, 100668159);
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, 100668160);
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__6_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, 100668161);
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__5_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, 100668162);
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, 100668163);
				DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr, 100668164);
			}

			// Token: 0x0600986F RID: 39023 RVA: 0x0028BD70 File Offset: 0x00289F70
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009870 RID: 39024 RVA: 0x0028BDAC File Offset: 0x00289FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71198, XrefRangeEnd = 71233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009871 RID: 39025 RVA: 0x0028BDEC File Offset: 0x00289FEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71233, XrefRangeEnd = 71245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__3(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__3_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009872 RID: 39026 RVA: 0x0028BE30 File Offset: 0x0028A030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71245, XrefRangeEnd = 71265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009873 RID: 39027 RVA: 0x0028BE64 File Offset: 0x0028A064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71265, XrefRangeEnd = 71277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__6(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__6_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009874 RID: 39028 RVA: 0x0028BEA8 File Offset: 0x0028A0A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71277, XrefRangeEnd = 71289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UseCard_b__5(int duration, string old)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref duration;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(old);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__5_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009875 RID: 39029 RVA: 0x0028BF00 File Offset: 0x0028A100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71289, XrefRangeEnd = 71301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guestGroupController)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009876 RID: 39030 RVA: 0x0028BF44 File Offset: 0x0028A144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71301, XrefRangeEnd = 71303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0(GuestGroupController.EvaluationResult result, GuestGroupController guestGroupController, bool _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009877 RID: 39031 RVA: 0x000527EC File Offset: 0x000509EC
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032A7 RID: 12967
			// (get) Token: 0x06009878 RID: 39032 RVA: 0x0028BFA4 File Offset: 0x0028A1A4
			// (set) Token: 0x06009879 RID: 39033 RVA: 0x000527F5 File Offset: 0x000509F5
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A8 RID: 12968
			// (get) Token: 0x0600987A RID: 39034 RVA: 0x0028BFD4 File Offset: 0x0028A1D4
			// (set) Token: 0x0600987B RID: 39035 RVA: 0x00052814 File Offset: 0x00050A14
			public unsafe DLC5_RogueLikeCardPrismriver __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPrismriver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A9 RID: 12969
			// (get) Token: 0x0600987C RID: 39036 RVA: 0x0028C004 File Offset: 0x0028A204
			// (set) Token: 0x0600987D RID: 39037 RVA: 0x00052833 File Offset: 0x00050A33
			public unsafe Action<GuestGroupController> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032AA RID: 12970
			// (get) Token: 0x0600987E RID: 39038 RVA: 0x0028C034 File Offset: 0x0028A234
			// (set) Token: 0x0600987F RID: 39039 RVA: 0x00052852 File Offset: 0x00050A52
			public unsafe Action<GuestGroupController> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032AB RID: 12971
			// (get) Token: 0x06009880 RID: 39040 RVA: 0x0028C064 File Offset: 0x0028A264
			// (set) Token: 0x06009881 RID: 39041 RVA: 0x00052871 File Offset: 0x00050A71
			public unsafe Action __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032AC RID: 12972
			// (get) Token: 0x06009882 RID: 39042 RVA: 0x0028C094 File Offset: 0x0028A294
			// (set) Token: 0x06009883 RID: 39043 RVA: 0x00052890 File Offset: 0x00050A90
			public unsafe Func<int, string, string> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040062BF RID: 25279
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040062C0 RID: 25280
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040062C1 RID: 25281
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x040062C2 RID: 25282
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x040062C3 RID: 25283
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x040062C4 RID: 25284
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x040062C5 RID: 25285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040062C6 RID: 25286
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__0_Internal_Void_Int32_0;

			// Token: 0x040062C7 RID: 25287
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__3_Internal_Void_GuestGroupController_0;

			// Token: 0x040062C8 RID: 25288
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__4_Internal_Void_0;

			// Token: 0x040062C9 RID: 25289
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__6_Internal_Void_GuestGroupController_0;

			// Token: 0x040062CA RID: 25290
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__5_Internal_String_Int32_String_0;

			// Token: 0x040062CB RID: 25291
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x040062CC RID: 25292
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0;
		}

		// Token: 0x020006AF RID: 1711
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPrismriver+<UseCard>d__3")]
		public sealed class _UseCard_d__3 : Object
		{
			// Token: 0x06009884 RID: 39044 RVA: 0x0028C0C4 File Offset: 0x0028A2C4
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__3()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver>.NativeClassPtr, "<UseCard>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr);
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, "<>8__1");
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, 100668165);
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, 100668166);
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, 100668167);
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, 100668168);
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, 100668169);
				DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr, 100668170);
			}

			// Token: 0x06009885 RID: 39045 RVA: 0x0028C1F4 File Offset: 0x0028A3F4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__3(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPrismriver._UseCard_d__3>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009886 RID: 39046 RVA: 0x0028C23C File Offset: 0x0028A43C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009887 RID: 39047 RVA: 0x0028C270 File Offset: 0x0028A470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71303, XrefRangeEnd = 71324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170032B4 RID: 12980
			// (get) Token: 0x06009888 RID: 39048 RVA: 0x0028C2AC File Offset: 0x0028A4AC
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009889 RID: 39049 RVA: 0x0028C2EC File Offset: 0x0028A4EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71324, XrefRangeEnd = 71330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170032B5 RID: 12981
			// (get) Token: 0x0600988A RID: 39050 RVA: 0x0028C320 File Offset: 0x0028A520
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600988B RID: 39051 RVA: 0x000528AF File Offset: 0x00050AAF
			public _UseCard_d__3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032AD RID: 12973
			// (get) Token: 0x0600988C RID: 39052 RVA: 0x0028C360 File Offset: 0x0028A560
			// (set) Token: 0x0600988D RID: 39053 RVA: 0x000528B8 File Offset: 0x00050AB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170032AE RID: 12974
			// (get) Token: 0x0600988E RID: 39054 RVA: 0x0028C388 File Offset: 0x0028A588
			// (set) Token: 0x0600988F RID: 39055 RVA: 0x000528D3 File Offset: 0x00050AD3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032AF RID: 12975
			// (get) Token: 0x06009890 RID: 39056 RVA: 0x0028C3B8 File Offset: 0x0028A5B8
			// (set) Token: 0x06009891 RID: 39057 RVA: 0x000528F2 File Offset: 0x00050AF2
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032B0 RID: 12976
			// (get) Token: 0x06009892 RID: 39058 RVA: 0x0028C3E8 File Offset: 0x0028A5E8
			// (set) Token: 0x06009893 RID: 39059 RVA: 0x00052911 File Offset: 0x00050B11
			public unsafe DLC5_RogueLikeCardPrismriver __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPrismriver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032B1 RID: 12977
			// (get) Token: 0x06009894 RID: 39060 RVA: 0x0028C418 File Offset: 0x0028A618
			// (set) Token: 0x06009895 RID: 39061 RVA: 0x00052930 File Offset: 0x00050B30
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170032B2 RID: 12978
			// (get) Token: 0x06009896 RID: 39062 RVA: 0x0028C448 File Offset: 0x0028A648
			// (set) Token: 0x06009897 RID: 39063 RVA: 0x0005295E File Offset: 0x00050B5E
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x170032B3 RID: 12979
			// (get) Token: 0x06009898 RID: 39064 RVA: 0x0028C470 File Offset: 0x0028A670
			// (set) Token: 0x06009899 RID: 39065 RVA: 0x00052979 File Offset: 0x00050B79
			public unsafe DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPrismriver.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPrismriver._UseCard_d__3.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040062CD RID: 25293
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040062CE RID: 25294
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040062CF RID: 25295
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040062D0 RID: 25296
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040062D1 RID: 25297
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x040062D2 RID: 25298
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x040062D3 RID: 25299
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040062D4 RID: 25300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040062D5 RID: 25301
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040062D6 RID: 25302
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040062D7 RID: 25303
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040062D8 RID: 25304
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040062D9 RID: 25305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
