using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Common.UI.GlobalMap
{
	// Token: 0x020003D7 RID: 983
	[StructLayout(2)]
	public struct VoidType
	{
		// Token: 0x0600758C RID: 30092 RVA: 0x0003F9B4 File Offset: 0x0003DBB4
		// Note: this type is marked as 'beforefieldinit'.
		static VoidType()
		{
			Il2CppClassPointerStore<VoidType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.GlobalMap", "VoidType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoidType>.NativeClassPtr);
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x0003F9D9 File Offset: 0x0003DBD9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoidType>.NativeClassPtr, ref this));
		}
	}
}
