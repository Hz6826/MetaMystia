using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000095 RID: 149
	public class IdleState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000F8B RID: 3979 RVA: 0x000D2EB4 File Offset: 0x000D10B4
		// Note: this type is marked as 'beforefieldinit'.
		static IdleState()
		{
			Il2CppClassPointerStore<IdleState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "IdleState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleState>.NativeClassPtr);
			IdleState.NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleState>.NativeClassPtr, 100666018);
			IdleState.NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleState>.NativeClassPtr, 100666019);
			IdleState.NativeMethodInfoPtr_OnUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleState>.NativeClassPtr, 100666020);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000D2F20 File Offset: 0x000D1120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48315, RefRangeEnd = 48317, XrefRangeStart = 48315, XrefRangeEnd = 48317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IdleState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdleState>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enterCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveStateWhenEnter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdleState.NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000D2FA0 File Offset: 0x000D11A0
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IdleState.NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000D2FE8 File Offset: 0x000D11E8
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IdleState.NativeMethodInfoPtr_OnUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0000A058 File Offset: 0x00008258
		public IdleState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_Void_0;
	}
}
