using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001C6 RID: 454
	[StructLayout(2)]
	public struct RechargeInfo
	{
		// Token: 0x06003898 RID: 14488 RVA: 0x001604C4 File Offset: 0x0015E6C4
		// Note: this type is marked as 'beforefieldinit'.
		static RechargeInfo()
		{
			Il2CppClassPointerStore<RechargeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "RechargeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RechargeInfo>.NativeClassPtr);
			RechargeInfo.NativeFieldInfoPtr_LetterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RechargeInfo>.NativeClassPtr, "LetterId");
			RechargeInfo.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RechargeInfo>.NativeClassPtr, "Progress");
			RechargeInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RechargeInfo>.NativeClassPtr, 100673963);
			RechargeInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RechargeInfo>.NativeClassPtr, 100673964);
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x00160544 File Offset: 0x0015E744
		[CallerCount(0)]
		public unsafe RechargeInfo(int letterId, float progress)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref letterId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RechargeInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x00160584 File Offset: 0x0015E784
		[CallerCount(0)]
		public unsafe void Deconstruct(out int letterId, out float progress)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &letterId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RechargeInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_Int32_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x0001F93E File Offset: 0x0001DB3E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RechargeInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04002627 RID: 9767
		private static readonly IntPtr NativeFieldInfoPtr_LetterId;

		// Token: 0x04002628 RID: 9768
		private static readonly IntPtr NativeFieldInfoPtr_Progress;

		// Token: 0x04002629 RID: 9769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;

		// Token: 0x0400262A RID: 9770
		private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_Int32_byref_Single_0;

		// Token: 0x0400262B RID: 9771
		[FieldOffset(0)]
		public readonly int LetterId;

		// Token: 0x0400262C RID: 9772
		[FieldOffset(4)]
		public readonly float Progress;
	}
}
