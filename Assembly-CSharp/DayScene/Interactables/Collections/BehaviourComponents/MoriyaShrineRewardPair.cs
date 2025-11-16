using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000188 RID: 392
	[Serializable]
	[StructLayout(2)]
	public struct MoriyaShrineRewardPair
	{
		// Token: 0x06002A9B RID: 10907 RVA: 0x0012C080 File Offset: 0x0012A280
		// Note: this type is marked as 'beforefieldinit'.
		static MoriyaShrineRewardPair()
		{
			Il2CppClassPointerStore<MoriyaShrineRewardPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "MoriyaShrineRewardPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoriyaShrineRewardPair>.NativeClassPtr);
			MoriyaShrineRewardPair.NativeFieldInfoPtr_RewardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineRewardPair>.NativeClassPtr, "RewardType");
			MoriyaShrineRewardPair.NativeFieldInfoPtr_RewardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineRewardPair>.NativeClassPtr, "RewardCount");
			MoriyaShrineRewardPair.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineRewardPair>.NativeClassPtr, "Probability");
			MoriyaShrineRewardPair.NativeMethodInfoPtr__ctor_Public_Void_MoriyaShrineRewardType_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineRewardPair>.NativeClassPtr, 100670704);
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x0012C100 File Offset: 0x0012A300
		[CallerCount(0)]
		public unsafe MoriyaShrineRewardPair(MoriyaShrineRewardType type, int rewardCount, float probability)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rewardCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probability;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineRewardPair.NativeMethodInfoPtr__ctor_Public_Void_MoriyaShrineRewardType_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x00018DF9 File Offset: 0x00016FF9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoriyaShrineRewardPair>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeFieldInfoPtr_RewardType;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeFieldInfoPtr_RewardCount;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeFieldInfoPtr_Probability;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MoriyaShrineRewardType_Int32_Single_0;

		// Token: 0x04001C29 RID: 7209
		[FieldOffset(0)]
		public MoriyaShrineRewardType RewardType;

		// Token: 0x04001C2A RID: 7210
		[FieldOffset(4)]
		public int RewardCount;

		// Token: 0x04001C2B RID: 7211
		[FieldOffset(8)]
		public float Probability;
	}
}
