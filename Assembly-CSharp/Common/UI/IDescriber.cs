using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Common.UI
{
	// Token: 0x0200035F RID: 863
	public class IDescriber : Il2CppObjectBase
	{
		// Token: 0x060065F0 RID: 26096 RVA: 0x0003710B File Offset: 0x0003530B
		// Note: this type is marked as 'beforefieldinit'.
		static IDescriber()
		{
			Il2CppClassPointerStore<IDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "IDescriber");
			IDescriber.NativeMethodInfoPtr_DescribeNull_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDescriber>.NativeClassPtr, 100684656);
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x001F2E64 File Offset: 0x001F1064
		[CallerCount(0)]
		public unsafe virtual void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDescriber.NativeMethodInfoPtr_DescribeNull_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x0003713A File Offset: 0x0003533A
		public IDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400439F RID: 17311
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Abstract_Virtual_New_Void_0;
	}
}
