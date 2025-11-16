using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000098 RID: 152
	public class StunState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000F9E RID: 3998 RVA: 0x000D33EC File Offset: 0x000D15EC
		// Note: this type is marked as 'beforefieldinit'.
		static StunState()
		{
			Il2CppClassPointerStore<StunState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "StunState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunState>.NativeClassPtr);
			StunState.NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunState>.NativeClassPtr, 100666035);
			StunState.NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunState>.NativeClassPtr, 100666036);
			StunState.NativeMethodInfoPtr_OnUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunState>.NativeClassPtr, 100666037);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000D3458 File Offset: 0x000D1658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48315, RefRangeEnd = 48317, XrefRangeStart = 48315, XrefRangeEnd = 48317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StunState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunState>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enterCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveStateWhenEnter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StunState.NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x000D34D8 File Offset: 0x000D16D8
		[CallerCount(0)]
		public unsafe override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StunState.NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x000D3520 File Offset: 0x000D1720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48361, XrefRangeEnd = 48362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StunState.NativeMethodInfoPtr_OnUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0000A092 File Offset: 0x00008292
		public StunState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_Void_0;
	}
}
