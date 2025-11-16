using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000096 RID: 150
	public class MoveState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000F90 RID: 3984 RVA: 0x000D3024 File Offset: 0x000D1224
		// Note: this type is marked as 'beforefieldinit'.
		static MoveState()
		{
			Il2CppClassPointerStore<MoveState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "MoveState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveState>.NativeClassPtr);
			MoveState.NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveState>.NativeClassPtr, 100666021);
			MoveState.NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveState>.NativeClassPtr, 100666022);
			MoveState.NativeMethodInfoPtr_OnUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveState>.NativeClassPtr, 100666023);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000D3090 File Offset: 0x000D1290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48315, RefRangeEnd = 48317, XrefRangeStart = 48315, XrefRangeEnd = 48317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveState>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enterCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveStateWhenEnter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveState.NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000D3110 File Offset: 0x000D1310
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveState.NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000D3158 File Offset: 0x000D1358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48338, XrefRangeEnd = 48339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveState.NativeMethodInfoPtr_OnUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0000A061 File Offset: 0x00008261
		public MoveState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_Void_0;
	}
}
