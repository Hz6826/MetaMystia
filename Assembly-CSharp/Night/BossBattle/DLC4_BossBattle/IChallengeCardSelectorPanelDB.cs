using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000AA RID: 170
	public class IChallengeCardSelectorPanelDB : Il2CppObjectBase
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x000DBD94 File Offset: 0x000D9F94
		// Note: this type is marked as 'beforefieldinit'.
		static IChallengeCardSelectorPanelDB()
		{
			Il2CppClassPointerStore<IChallengeCardSelectorPanelDB>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "IChallengeCardSelectorPanelDB");
			IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_GetCards_Public_Abstract_Virtual_New_IEnumerable_1_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChallengeCardSelectorPanelDB>.NativeClassPtr, 100666480);
			IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_GetCardCoolDownProgress_Public_Abstract_Virtual_New_Single_byref_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChallengeCardSelectorPanelDB>.NativeClassPtr, 100666481);
			IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_CanBuyCard_Public_Abstract_Virtual_New_Boolean_byref_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChallengeCardSelectorPanelDB>.NativeClassPtr, 100666482);
			IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_IsCardOnField_Public_Abstract_Virtual_New_Boolean_byref_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChallengeCardSelectorPanelDB>.NativeClassPtr, 100666483);
			IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_IsCardBought_Public_Abstract_Virtual_New_Boolean_byref_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChallengeCardSelectorPanelDB>.NativeClassPtr, 100666484);
			IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_BuyCard_Public_Abstract_Virtual_New_Void_byref_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChallengeCardSelectorPanelDB>.NativeClassPtr, 100666485);
			IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_UseCard_Public_Abstract_Virtual_New_Void_byref_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChallengeCardSelectorPanelDB>.NativeClassPtr, 100666486);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x000DBE48 File Offset: 0x000DA048
		[CallerCount(0)]
		public unsafe virtual IEnumerable<GuestGuardMapping> GetCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_GetCards_Public_Abstract_Virtual_New_IEnumerable_1_GuestGuardMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<GuestGuardMapping>>(intPtr3) : null;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x000DBE94 File Offset: 0x000DA094
		[CallerCount(0)]
		public unsafe virtual float GetCardCoolDownProgress([In] ref GuestGuardMapping mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_GetCardCoolDownProgress_Public_Abstract_Virtual_New_Single_byref_GuestGuardMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x000DBEF0 File Offset: 0x000DA0F0
		[CallerCount(0)]
		public unsafe virtual bool CanBuyCard([In] ref GuestGuardMapping mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_CanBuyCard_Public_Abstract_Virtual_New_Boolean_byref_GuestGuardMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x000DBF4C File Offset: 0x000DA14C
		[CallerCount(0)]
		public unsafe virtual bool IsCardOnField([In] ref GuestGuardMapping mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_IsCardOnField_Public_Abstract_Virtual_New_Boolean_byref_GuestGuardMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x000DBFA8 File Offset: 0x000DA1A8
		[CallerCount(0)]
		public unsafe virtual bool IsCardBought([In] ref GuestGuardMapping mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_IsCardBought_Public_Abstract_Virtual_New_Boolean_byref_GuestGuardMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x000DC004 File Offset: 0x000DA204
		[CallerCount(0)]
		public unsafe virtual void BuyCard([In] ref GuestGuardMapping mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_BuyCard_Public_Abstract_Virtual_New_Void_byref_GuestGuardMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x000DC054 File Offset: 0x000DA254
		[CallerCount(0)]
		public unsafe virtual void UseCard([In] ref GuestGuardMapping mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChallengeCardSelectorPanelDB.NativeMethodInfoPtr_UseCard_Public_Abstract_Virtual_New_Void_byref_GuestGuardMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0000BAF5 File Offset: 0x00009CF5
		public IChallengeCardSelectorPanelDB(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_GetCards_Public_Abstract_Virtual_New_IEnumerable_1_GuestGuardMapping_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_GetCardCoolDownProgress_Public_Abstract_Virtual_New_Single_byref_GuestGuardMapping_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_CanBuyCard_Public_Abstract_Virtual_New_Boolean_byref_GuestGuardMapping_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_IsCardOnField_Public_Abstract_Virtual_New_Boolean_byref_GuestGuardMapping_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_IsCardBought_Public_Abstract_Virtual_New_Boolean_byref_GuestGuardMapping_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_BuyCard_Public_Abstract_Virtual_New_Void_byref_GuestGuardMapping_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Abstract_Virtual_New_Void_byref_GuestGuardMapping_0;
	}
}
