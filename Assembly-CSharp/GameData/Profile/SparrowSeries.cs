using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using NightScene.GuestManagementUtility;

namespace GameData.Profile
{
	// Token: 0x02000308 RID: 776
	public class SparrowSeries : CookerAssetBase
	{
		// Token: 0x06005CFD RID: 23805 RVA: 0x001D3D58 File Offset: 0x001D1F58
		// Note: this type is marked as 'beforefieldinit'.
		static SparrowSeries()
		{
			Il2CppClassPointerStore<SparrowSeries>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "SparrowSeries");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparrowSeries>.NativeClassPtr);
			SparrowSeries.NativeFieldInfoPtr_SPARROW_SERIES_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparrowSeries>.NativeClassPtr, "SPARROW_SERIES_TAG_ID");
			SparrowSeries.NativeMethodInfoPtr_OnFinishCook_Public_Virtual_Sellable_Sellable_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparrowSeries>.NativeClassPtr, 100682480);
			SparrowSeries.NativeMethodInfoPtr_OnEvaluate_Public_Virtual_Int32_Int32_GuestGroupController_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparrowSeries>.NativeClassPtr, 100682481);
			SparrowSeries.NativeMethodInfoPtr_ShouldShowThisCookerBG_Public_Virtual_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparrowSeries>.NativeClassPtr, 100682482);
			SparrowSeries.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparrowSeries>.NativeClassPtr, 100682483);
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x001D3DEC File Offset: 0x001D1FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232846, XrefRangeEnd = 232849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Sellable OnFinishCook(Sellable finishedFood, float qteScore, bool couldReturnIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(finishedFood);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qteScore;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref couldReturnIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SparrowSeries.NativeMethodInfoPtr_OnFinishCook_Public_Virtual_Sellable_Sellable_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x001D3E64 File Offset: 0x001D2064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232849, XrefRangeEnd = 232853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int OnEvaluate(int evaluationResult, GuestGroupController guestGroupController, Sellable serveFood)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evaluationResult;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serveFood);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SparrowSeries.NativeMethodInfoPtr_OnEvaluate_Public_Virtual_Int32_Int32_GuestGroupController_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005D00 RID: 23808 RVA: 0x001D3EDC File Offset: 0x001D20DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232853, XrefRangeEnd = 232857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldShowThisCookerBG(Sellable outputFood)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputFood);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SparrowSeries.NativeMethodInfoPtr_ShouldShowThisCookerBG_Public_Virtual_Boolean_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005D01 RID: 23809 RVA: 0x001D3F34 File Offset: 0x001D2134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparrowSeries() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparrowSeries>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparrowSeries.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D02 RID: 23810 RVA: 0x00032C2F File Offset: 0x00030E2F
		public SparrowSeries(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06005D03 RID: 23811 RVA: 0x001D3F70 File Offset: 0x001D2170
		// (set) Token: 0x06005D04 RID: 23812 RVA: 0x00032C38 File Offset: 0x00030E38
		public unsafe static int SPARROW_SERIES_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SparrowSeries.NativeFieldInfoPtr_SPARROW_SERIES_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SparrowSeries.NativeFieldInfoPtr_SPARROW_SERIES_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x04003D91 RID: 15761
		private static readonly IntPtr NativeFieldInfoPtr_SPARROW_SERIES_TAG_ID;

		// Token: 0x04003D92 RID: 15762
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishCook_Public_Virtual_Sellable_Sellable_Single_Boolean_0;

		// Token: 0x04003D93 RID: 15763
		private static readonly IntPtr NativeMethodInfoPtr_OnEvaluate_Public_Virtual_Int32_Int32_GuestGroupController_Sellable_0;

		// Token: 0x04003D94 RID: 15764
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowThisCookerBG_Public_Virtual_Boolean_Sellable_0;

		// Token: 0x04003D95 RID: 15765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
