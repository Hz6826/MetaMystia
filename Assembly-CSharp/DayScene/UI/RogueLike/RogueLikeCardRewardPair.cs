using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000101 RID: 257
	[Serializable]
	public sealed class RogueLikeCardRewardPair : ValueType
	{
		// Token: 0x06001CA8 RID: 7336 RVA: 0x000FE454 File Offset: 0x000FC654
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeCardRewardPair()
		{
			Il2CppClassPointerStore<RogueLikeCardRewardPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeCardRewardPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeCardRewardPair>.NativeClassPtr);
			RogueLikeCardRewardPair.NativeFieldInfoPtr_m_WholeCardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardRewardPair>.NativeClassPtr, "m_WholeCardNum");
			RogueLikeCardRewardPair.NativeFieldInfoPtr_m_CardRewardRates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardRewardPair>.NativeClassPtr, "m_CardRewardRates");
			RogueLikeCardRewardPair.NativeMethodInfoPtr_get_WholeCardNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardRewardPair>.NativeClassPtr, 100668464);
			RogueLikeCardRewardPair.NativeMethodInfoPtr_get_CardRewardRates_Public_get_Il2CppStructArray_1_RogueLikeCardRewardRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardRewardPair>.NativeClassPtr, 100668465);
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x000FE4D4 File Offset: 0x000FC6D4
		public unsafe int WholeCardNum
		{
			[CallerCount(140)]
			[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardRewardPair.NativeMethodInfoPtr_get_WholeCardNum_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x000FE518 File Offset: 0x000FC718
		public unsafe Il2CppStructArray<RogueLikeCardRewardRate> CardRewardRates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardRewardPair.NativeMethodInfoPtr_get_CardRewardRates_Public_get_Il2CppStructArray_1_RogueLikeCardRewardRate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RogueLikeCardRewardRate>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00011723 File Offset: 0x0000F923
		public RogueLikeCardRewardPair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0001172C File Offset: 0x0000F92C
		public RogueLikeCardRewardPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeCardRewardPair>.NativeClassPtr))
		{
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x000FE55C File Offset: 0x000FC75C
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x0001173E File Offset: 0x0000F93E
		public unsafe int m_WholeCardNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardRewardPair.NativeFieldInfoPtr_m_WholeCardNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardRewardPair.NativeFieldInfoPtr_m_WholeCardNum)) = value;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x000FE584 File Offset: 0x000FC784
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x00011759 File Offset: 0x0000F959
		public unsafe Il2CppStructArray<RogueLikeCardRewardRate> m_CardRewardRates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardRewardPair.NativeFieldInfoPtr_m_CardRewardRates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RogueLikeCardRewardRate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardRewardPair.NativeFieldInfoPtr_m_CardRewardRates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCardNum;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeFieldInfoPtr_m_CardRewardRates;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeCardNum_Public_get_Int32_0;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeMethodInfoPtr_get_CardRewardRates_Public_get_Il2CppStructArray_1_RogueLikeCardRewardRate_0;
	}
}
