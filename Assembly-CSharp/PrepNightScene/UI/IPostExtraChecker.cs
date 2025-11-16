using System;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace PrepNightScene.UI
{
	// Token: 0x0200003C RID: 60
	public class IPostExtraChecker : Il2CppObjectBase
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x000B3294 File Offset: 0x000B1494
		// Note: this type is marked as 'beforefieldinit'.
		static IPostExtraChecker()
		{
			Il2CppClassPointerStore<IPostExtraChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrepNightScene.UI", "IPostExtraChecker");
			IPostExtraChecker.NativeMethodInfoPtr_PostCheck_Public_Abstract_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostExtraChecker>.NativeClassPtr, 100664269);
			IPostExtraChecker.NativeMethodInfoPtr_OpenReminderAsync_Public_Abstract_Virtual_New_UniTask_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostExtraChecker>.NativeClassPtr, 100664270);
			IPostExtraChecker.NativeMethodInfoPtr_get_SubPannel_Public_Abstract_Virtual_New_get_UISubPanel_1_IzakayaConfigPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostExtraChecker>.NativeClassPtr, 100664271);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000B32F8 File Offset: 0x000B14F8
		[CallerCount(0)]
		public unsafe virtual bool PostCheck(out string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostExtraChecker.NativeMethodInfoPtr_PostCheck_Public_Abstract_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000B335C File Offset: 0x000B155C
		[CallerCount(0)]
		public unsafe virtual UniTask<bool> OpenReminderAsync(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostExtraChecker.NativeMethodInfoPtr_OpenReminderAsync_Public_Abstract_Virtual_New_UniTask_1_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<bool>(pointer);
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x000B33B0 File Offset: 0x000B15B0
		public unsafe virtual UISubPanel<IzakayaConfigPannel> SubPannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostExtraChecker.NativeMethodInfoPtr_get_SubPannel_Public_Abstract_Virtual_New_get_UISubPanel_1_IzakayaConfigPannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISubPanel<IzakayaConfigPannel>>(intPtr3) : null;
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00005D94 File Offset: 0x00003F94
		public IPostExtraChecker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_PostCheck_Public_Abstract_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_OpenReminderAsync_Public_Abstract_Virtual_New_UniTask_1_Boolean_String_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_get_SubPannel_Public_Abstract_Virtual_New_get_UISubPanel_1_IzakayaConfigPannel_0;
	}
}
