using System;
using GameData.Core.Collections;
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
	// Token: 0x020000D7 RID: 215
	public class DLC5_RogueLikeCardEcho : RogueLikeCard
	{
		// Token: 0x06001A47 RID: 6727 RVA: 0x000F5780 File Offset: 0x000F3980
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardEcho()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardEcho");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr);
			DLC5_RogueLikeCardEcho.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, "datas");
			DLC5_RogueLikeCardEcho.NativeFieldInfoPtr_baseResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, "baseResult");
			DLC5_RogueLikeCardEcho.NativeFieldInfoPtr_giveNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, "giveNum");
			DLC5_RogueLikeCardEcho.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, 100667938);
			DLC5_RogueLikeCardEcho.NativeMethodInfoPtr_GetDataByRarity_Private_Int32_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, 100667939);
			DLC5_RogueLikeCardEcho.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, 100667940);
			DLC5_RogueLikeCardEcho.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, 100667941);
			DLC5_RogueLikeCardEcho.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, 100667942);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x000F5850 File Offset: 0x000F3A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70344, XrefRangeEnd = 70351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardEcho.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x000F58D0 File Offset: 0x000F3AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70351, XrefRangeEnd = 70354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataByRarity(RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.NativeMethodInfoPtr_GetDataByRarity_Private_Int32_Rarity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x000F591C File Offset: 0x000F3B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70354, XrefRangeEnd = 70369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardEcho.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x000F5980 File Offset: 0x000F3B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70369, XrefRangeEnd = 70370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardEcho() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x000F59BC File Offset: 0x000F3BBC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000105A4 File Offset: 0x0000E7A4
		public DLC5_RogueLikeCardEcho(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x000F5A34 File Offset: 0x000F3C34
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x000105AD File Offset: 0x0000E7AD
		public unsafe Il2CppReferenceArray<RarityDataMappingForDuration> datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.NativeFieldInfoPtr_datas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RarityDataMappingForDuration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.NativeFieldInfoPtr_datas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x000F5A64 File Offset: 0x000F3C64
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x000105CC File Offset: 0x0000E7CC
		public unsafe GuestGroupController.EvaluationResult baseResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.NativeFieldInfoPtr_baseResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.NativeFieldInfoPtr_baseResult)) = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x000F5A8C File Offset: 0x000F3C8C
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x000105E7 File Offset: 0x0000E7E7
		public unsafe int giveNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.NativeFieldInfoPtr_giveNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.NativeFieldInfoPtr_giveNum)) = value;
			}
		}

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeFieldInfoPtr_baseResult;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeFieldInfoPtr_giveNum;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_GetDataByRarity_Private_Int32_Rarity_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x02000691 RID: 1681
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardEcho+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060096BA RID: 38586 RVA: 0x00286E7C File Offset: 0x0028507C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr);
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, "<>9__3");
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, "<>9__6");
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, "<>9__4");
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, "<>9__5");
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, 100667943);
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, 100667944);
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__3_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, 100667945);
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, 100667946);
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__6_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, 100667947);
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__5_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, 100667948);
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, 100667949);
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr, 100667950);
			}

			// Token: 0x060096BB RID: 38587 RVA: 0x00286FC0 File Offset: 0x002851C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096BC RID: 38588 RVA: 0x00286FFC File Offset: 0x002851FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70189, XrefRangeEnd = 70224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096BD RID: 38589 RVA: 0x0028703C File Offset: 0x0028523C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70224, XrefRangeEnd = 70236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__3(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__3_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096BE RID: 38590 RVA: 0x00287080 File Offset: 0x00285280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70236, XrefRangeEnd = 70256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096BF RID: 38591 RVA: 0x002870B4 File Offset: 0x002852B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70256, XrefRangeEnd = 70268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__6(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__6_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096C0 RID: 38592 RVA: 0x002870F8 File Offset: 0x002852F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70268, XrefRangeEnd = 70280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UseCard_b__5(int duration, string old)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref duration;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(old);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr__UseCard_b__5_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060096C1 RID: 38593 RVA: 0x00287150 File Offset: 0x00285350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70280, XrefRangeEnd = 70292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guestGroupController)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096C2 RID: 38594 RVA: 0x00287194 File Offset: 0x00285394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70292, XrefRangeEnd = 70316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0(GuestGroupController.EvaluationResult result, GuestGroupController guestGroupController, bool _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096C3 RID: 38595 RVA: 0x00051799 File Offset: 0x0004F999
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700320D RID: 12813
			// (get) Token: 0x060096C4 RID: 38596 RVA: 0x002871F4 File Offset: 0x002853F4
			// (set) Token: 0x060096C5 RID: 38597 RVA: 0x000517A2 File Offset: 0x0004F9A2
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700320E RID: 12814
			// (get) Token: 0x060096C6 RID: 38598 RVA: 0x00287224 File Offset: 0x00285424
			// (set) Token: 0x060096C7 RID: 38599 RVA: 0x000517C1 File Offset: 0x0004F9C1
			public unsafe DLC5_RogueLikeCardEcho __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardEcho>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700320F RID: 12815
			// (get) Token: 0x060096C8 RID: 38600 RVA: 0x00287254 File Offset: 0x00285454
			// (set) Token: 0x060096C9 RID: 38601 RVA: 0x000517E0 File Offset: 0x0004F9E0
			public unsafe Action<GuestGroupController> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003210 RID: 12816
			// (get) Token: 0x060096CA RID: 38602 RVA: 0x00287284 File Offset: 0x00285484
			// (set) Token: 0x060096CB RID: 38603 RVA: 0x000517FF File Offset: 0x0004F9FF
			public unsafe Action<GuestGroupController> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003211 RID: 12817
			// (get) Token: 0x060096CC RID: 38604 RVA: 0x002872B4 File Offset: 0x002854B4
			// (set) Token: 0x060096CD RID: 38605 RVA: 0x0005181E File Offset: 0x0004FA1E
			public unsafe Action __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003212 RID: 12818
			// (get) Token: 0x060096CE RID: 38606 RVA: 0x002872E4 File Offset: 0x002854E4
			// (set) Token: 0x060096CF RID: 38607 RVA: 0x0005183D File Offset: 0x0004FA3D
			public unsafe Func<int, string, string> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040061C4 RID: 25028
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040061C5 RID: 25029
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040061C6 RID: 25030
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x040061C7 RID: 25031
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x040061C8 RID: 25032
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x040061C9 RID: 25033
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x040061CA RID: 25034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040061CB RID: 25035
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__0_Internal_Void_Int32_0;

			// Token: 0x040061CC RID: 25036
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__3_Internal_Void_GuestGroupController_0;

			// Token: 0x040061CD RID: 25037
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__4_Internal_Void_0;

			// Token: 0x040061CE RID: 25038
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__6_Internal_Void_GuestGroupController_0;

			// Token: 0x040061CF RID: 25039
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__5_Internal_String_Int32_String_0;

			// Token: 0x040061D0 RID: 25040
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x040061D1 RID: 25041
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0;
		}

		// Token: 0x02000692 RID: 1682
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardEcho+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x060096D0 RID: 38608 RVA: 0x00287314 File Offset: 0x00285514
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_1>.NativeClassPtr);
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_1.NativeFieldInfoPtr_orderBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_1>.NativeClassPtr, "orderBev");
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_1>.NativeClassPtr, 100667951);
				DLC5_RogueLikeCardEcho.__c__DisplayClass3_1.NativeMethodInfoPtr__UseCard_b__7_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_1>.NativeClassPtr, 100667952);
			}

			// Token: 0x060096D1 RID: 38609 RVA: 0x0028737C File Offset: 0x0028557C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096D2 RID: 38610 RVA: 0x002873B8 File Offset: 0x002855B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70316, XrefRangeEnd = 70317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UseCard_b__7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho.__c__DisplayClass3_1.NativeMethodInfoPtr__UseCard_b__7_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060096D3 RID: 38611 RVA: 0x0005185C File Offset: 0x0004FA5C
			public __c__DisplayClass3_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003213 RID: 12819
			// (get) Token: 0x060096D4 RID: 38612 RVA: 0x00287404 File Offset: 0x00285604
			// (set) Token: 0x060096D5 RID: 38613 RVA: 0x00051865 File Offset: 0x0004FA65
			public unsafe Sellable orderBev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_1.NativeFieldInfoPtr_orderBev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho.__c__DisplayClass3_1.NativeFieldInfoPtr_orderBev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040061D2 RID: 25042
			private static readonly IntPtr NativeFieldInfoPtr_orderBev;

			// Token: 0x040061D3 RID: 25043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040061D4 RID: 25044
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__7_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000693 RID: 1683
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardEcho+<UseCard>d__3")]
		public sealed class _UseCard_d__3 : Object
		{
			// Token: 0x060096D6 RID: 38614 RVA: 0x00287434 File Offset: 0x00285634
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__3()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho>.NativeClassPtr, "<UseCard>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr);
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, "<>8__1");
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, 100667953);
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, 100667954);
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, 100667955);
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, 100667956);
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, 100667957);
				DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr, 100667958);
			}

			// Token: 0x060096D7 RID: 38615 RVA: 0x00287564 File Offset: 0x00285764
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__3(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardEcho._UseCard_d__3>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096D8 RID: 38616 RVA: 0x002875AC File Offset: 0x002857AC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060096D9 RID: 38617 RVA: 0x002875E0 File Offset: 0x002857E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70317, XrefRangeEnd = 70338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700321B RID: 12827
			// (get) Token: 0x060096DA RID: 38618 RVA: 0x0028761C File Offset: 0x0028581C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060096DB RID: 38619 RVA: 0x0028765C File Offset: 0x0028585C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70338, XrefRangeEnd = 70344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700321C RID: 12828
			// (get) Token: 0x060096DC RID: 38620 RVA: 0x00287690 File Offset: 0x00285890
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060096DD RID: 38621 RVA: 0x00051884 File Offset: 0x0004FA84
			public _UseCard_d__3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003214 RID: 12820
			// (get) Token: 0x060096DE RID: 38622 RVA: 0x002876D0 File Offset: 0x002858D0
			// (set) Token: 0x060096DF RID: 38623 RVA: 0x0005188D File Offset: 0x0004FA8D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003215 RID: 12821
			// (get) Token: 0x060096E0 RID: 38624 RVA: 0x002876F8 File Offset: 0x002858F8
			// (set) Token: 0x060096E1 RID: 38625 RVA: 0x000518A8 File Offset: 0x0004FAA8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003216 RID: 12822
			// (get) Token: 0x060096E2 RID: 38626 RVA: 0x00287728 File Offset: 0x00285928
			// (set) Token: 0x060096E3 RID: 38627 RVA: 0x000518C7 File Offset: 0x0004FAC7
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003217 RID: 12823
			// (get) Token: 0x060096E4 RID: 38628 RVA: 0x00287758 File Offset: 0x00285958
			// (set) Token: 0x060096E5 RID: 38629 RVA: 0x000518E6 File Offset: 0x0004FAE6
			public unsafe DLC5_RogueLikeCardEcho __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardEcho>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003218 RID: 12824
			// (get) Token: 0x060096E6 RID: 38630 RVA: 0x00287788 File Offset: 0x00285988
			// (set) Token: 0x060096E7 RID: 38631 RVA: 0x00051905 File Offset: 0x0004FB05
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003219 RID: 12825
			// (get) Token: 0x060096E8 RID: 38632 RVA: 0x002877B8 File Offset: 0x002859B8
			// (set) Token: 0x060096E9 RID: 38633 RVA: 0x00051933 File Offset: 0x0004FB33
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x1700321A RID: 12826
			// (get) Token: 0x060096EA RID: 38634 RVA: 0x002877E0 File Offset: 0x002859E0
			// (set) Token: 0x060096EB RID: 38635 RVA: 0x0005194E File Offset: 0x0004FB4E
			public unsafe DLC5_RogueLikeCardEcho.__c__DisplayClass3_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardEcho.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardEcho._UseCard_d__3.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040061D5 RID: 25045
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040061D6 RID: 25046
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040061D7 RID: 25047
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040061D8 RID: 25048
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040061D9 RID: 25049
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x040061DA RID: 25050
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x040061DB RID: 25051
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040061DC RID: 25052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040061DD RID: 25053
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040061DE RID: 25054
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040061DF RID: 25055
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040061E0 RID: 25056
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040061E1 RID: 25057
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
