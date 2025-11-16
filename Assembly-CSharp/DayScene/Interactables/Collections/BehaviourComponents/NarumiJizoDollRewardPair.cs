using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200018F RID: 399
	[Serializable]
	[StructLayout(2)]
	public struct NarumiJizoDollRewardPair
	{
		// Token: 0x06002B15 RID: 11029 RVA: 0x0012D9B0 File Offset: 0x0012BBB0
		// Note: this type is marked as 'beforefieldinit'.
		static NarumiJizoDollRewardPair()
		{
			Il2CppClassPointerStore<NarumiJizoDollRewardPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "NarumiJizoDollRewardPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NarumiJizoDollRewardPair>.NativeClassPtr);
			NarumiJizoDollRewardPair.NativeFieldInfoPtr_RewardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollRewardPair>.NativeClassPtr, "RewardType");
			NarumiJizoDollRewardPair.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollRewardPair>.NativeClassPtr, "Level");
			NarumiJizoDollRewardPair.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollRewardPair>.NativeClassPtr, "Probability");
			NarumiJizoDollRewardPair.NativeMethodInfoPtr__ctor_Public_Void_NarumiJizoDollRewardType_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollRewardPair>.NativeClassPtr, 100670780);
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x0012DA30 File Offset: 0x0012BC30
		[CallerCount(0)]
		public unsafe NarumiJizoDollRewardPair(NarumiJizoDollRewardType type, int level, float probability)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probability;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollRewardPair.NativeMethodInfoPtr__ctor_Public_Void_NarumiJizoDollRewardType_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x0001910D File Offset: 0x0001730D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NarumiJizoDollRewardPair>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeFieldInfoPtr_RewardType;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeFieldInfoPtr_Level;

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeFieldInfoPtr_Probability;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NarumiJizoDollRewardType_Int32_Single_0;

		// Token: 0x04001C83 RID: 7299
		[FieldOffset(0)]
		public NarumiJizoDollRewardType RewardType;

		// Token: 0x04001C84 RID: 7300
		[FieldOffset(4)]
		public int Level;

		// Token: 0x04001C85 RID: 7301
		[FieldOffset(8)]
		public float Probability;
	}
}
