using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Night.RogueLike;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000103 RID: 259
	public class IRogueLikeCardAssociatedRecord : Il2CppObjectBase
	{
		// Token: 0x06001CB5 RID: 7349 RVA: 0x0001178A File Offset: 0x0000F98A
		// Note: this type is marked as 'beforefieldinit'.
		static IRogueLikeCardAssociatedRecord()
		{
			Il2CppClassPointerStore<IRogueLikeCardAssociatedRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "IRogueLikeCardAssociatedRecord");
			IRogueLikeCardAssociatedRecord.NativeMethodInfoPtr_ModifyAssociatedRogueLikeCardInstances_Public_Abstract_Virtual_New_Void_List_1_RogueLikeCardInstance_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCardAssociatedRecord>.NativeClassPtr, 100668468);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000FE694 File Offset: 0x000FC894
		[CallerCount(0)]
		public unsafe virtual void ModifyAssociatedRogueLikeCardInstances(List<RogueLikeCardInstance> associatedRogueLikeCards, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(associatedRogueLikeCards);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCardAssociatedRecord.NativeMethodInfoPtr_ModifyAssociatedRogueLikeCardInstances_Public_Abstract_Virtual_New_Void_List_1_RogueLikeCardInstance_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000117B9 File Offset: 0x0000F9B9
		public IRogueLikeCardAssociatedRecord(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_ModifyAssociatedRogueLikeCardInstances_Public_Abstract_Virtual_New_Void_List_1_RogueLikeCardInstance_RogueLikeManager_0;
	}
}
