using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000197 RID: 407
	[Serializable]
	[StructLayout(2)]
	public struct NueRewardPair
	{
		// Token: 0x06002B8E RID: 11150 RVA: 0x0012F310 File Offset: 0x0012D510
		// Note: this type is marked as 'beforefieldinit'.
		static NueRewardPair()
		{
			Il2CppClassPointerStore<NueRewardPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "NueRewardPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NueRewardPair>.NativeClassPtr);
			NueRewardPair.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueRewardPair>.NativeClassPtr, "Level");
			NueRewardPair.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueRewardPair>.NativeClassPtr, "Probability");
			NueRewardPair.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueRewardPair>.NativeClassPtr, 100670912);
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x0012F37C File Offset: 0x0012D57C
		[CallerCount(0)]
		public unsafe NueRewardPair(int level, float probability)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probability;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueRewardPair.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x0001954C File Offset: 0x0001774C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NueRewardPair>.NativeClassPtr, ref this));
		}

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeFieldInfoPtr_Level;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeFieldInfoPtr_Probability;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;

		// Token: 0x04001CDB RID: 7387
		[FieldOffset(0)]
		public int Level;

		// Token: 0x04001CDC RID: 7388
		[FieldOffset(4)]
		public float Probability;
	}
}
