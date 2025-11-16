using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace DayScene.UI
{
	// Token: 0x020000CF RID: 207
	public class ITimeIndicator : Il2CppObjectBase
	{
		// Token: 0x060018E0 RID: 6368 RVA: 0x0000F848 File Offset: 0x0000DA48
		// Note: this type is marked as 'beforefieldinit'.
		static ITimeIndicator()
		{
			Il2CppClassPointerStore<ITimeIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "ITimeIndicator");
			ITimeIndicator.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Nullable_1_TimeIndicatorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimeIndicator>.NativeClassPtr, 100667708);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000F1098 File Offset: 0x000EF298
		[CallerCount(0)]
		public unsafe virtual void SetValue(Nullable<TimeIndicatorContext> context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimeIndicator.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Nullable_1_TimeIndicatorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0000F877 File Offset: 0x0000DA77
		public ITimeIndicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Nullable_1_TimeIndicatorContext_0;
	}
}
