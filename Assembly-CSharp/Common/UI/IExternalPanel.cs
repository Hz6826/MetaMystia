using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Common.UI
{
	// Token: 0x0200036A RID: 874
	public class IExternalPanel : Il2CppObjectBase
	{
		// Token: 0x060067C6 RID: 26566 RVA: 0x00038247 File Offset: 0x00036447
		// Note: this type is marked as 'beforefieldinit'.
		static IExternalPanel()
		{
			Il2CppClassPointerStore<IExternalPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "IExternalPanel");
			IExternalPanel.NativeMethodInfoPtr_CloseExternPanel_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExternalPanel>.NativeClassPtr, 100684940);
		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x001F89FC File Offset: 0x001F6BFC
		[CallerCount(0)]
		public unsafe virtual void CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExternalPanel.NativeMethodInfoPtr_CloseExternPanel_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067C8 RID: 26568 RVA: 0x00038276 File Offset: 0x00036476
		public IExternalPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040044CA RID: 17610
		private static readonly IntPtr NativeMethodInfoPtr_CloseExternPanel_Public_Abstract_Virtual_New_Void_0;
	}
}
