using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000102 RID: 258
	[Serializable]
	[StructLayout(2)]
	public struct RogueLikeCardRewardRate
	{
		// Token: 0x06001CB1 RID: 7345 RVA: 0x000FE5B4 File Offset: 0x000FC7B4
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeCardRewardRate()
		{
			Il2CppClassPointerStore<RogueLikeCardRewardRate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeCardRewardRate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeCardRewardRate>.NativeClassPtr);
			RogueLikeCardRewardRate.NativeFieldInfoPtr_m_Rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardRewardRate>.NativeClassPtr, "m_Rarity");
			RogueLikeCardRewardRate.NativeFieldInfoPtr_m_Rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardRewardRate>.NativeClassPtr, "m_Rate");
			RogueLikeCardRewardRate.NativeMethodInfoPtr_get_Rarity_Public_get_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardRewardRate>.NativeClassPtr, 100668466);
			RogueLikeCardRewardRate.NativeMethodInfoPtr_get_Rate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardRewardRate>.NativeClassPtr, 100668467);
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x000FE634 File Offset: 0x000FC834
		public unsafe RogueLikeCardBase.Rarity Rarity
		{
			[CallerCount(140)]
			[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardRewardRate.NativeMethodInfoPtr_get_Rarity_Public_get_Rarity_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x000FE664 File Offset: 0x000FC864
		public unsafe float Rate
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardRewardRate.NativeMethodInfoPtr_get_Rate_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00011778 File Offset: 0x0000F978
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RogueLikeCardRewardRate>.NativeClassPtr, ref this));
		}

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_m_Rarity;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr_m_Rate;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_get_Rarity_Public_get_Rarity_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_get_Rate_Public_get_Single_0;

		// Token: 0x04001321 RID: 4897
		[FieldOffset(0)]
		public RogueLikeCardBase.Rarity m_Rarity;

		// Token: 0x04001322 RID: 4898
		[FieldOffset(4)]
		public float m_Rate;
	}
}
