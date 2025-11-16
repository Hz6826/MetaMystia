using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000094 RID: 148
	public class DLC4_FlandreEnemyState : Object
	{
		// Token: 0x06000F7B RID: 3963 RVA: 0x000D2B54 File Offset: 0x000D0D54
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_FlandreEnemyState()
		{
			Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_FlandreEnemyState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr);
			DLC4_FlandreEnemyState.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr, "controller");
			DLC4_FlandreEnemyState.NativeFieldInfoPtr_enterCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr, "enterCallback");
			DLC4_FlandreEnemyState.NativeFieldInfoPtr_exitCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr, "exitCallback");
			DLC4_FlandreEnemyState.NativeFieldInfoPtr_moveStateWhenEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr, "moveStateWhenEnter");
			DLC4_FlandreEnemyState.NativeMethodInfoPtr__ctor_Protected_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr, 100666012);
			DLC4_FlandreEnemyState.NativeMethodInfoPtr_GetCharacterState_Public_Abstract_Virtual_New_CharacterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr, 100666013);
			DLC4_FlandreEnemyState.NativeMethodInfoPtr_OnEnterState_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr, 100666014);
			DLC4_FlandreEnemyState.NativeMethodInfoPtr_OnUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr, 100666015);
			DLC4_FlandreEnemyState.NativeMethodInfoPtr_OnExitState_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr, 100666016);
			DLC4_FlandreEnemyState.NativeMethodInfoPtr_TryMove_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr, 100666017);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000D2C4C File Offset: 0x000D0E4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48315, RefRangeEnd = 48317, XrefRangeStart = 48311, XrefRangeEnd = 48315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_FlandreEnemyState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreEnemyState>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enterCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveStateWhenEnter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyState.NativeMethodInfoPtr__ctor_Protected_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000D2CCC File Offset: 0x000D0ECC
		[CallerCount(0)]
		public unsafe virtual DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyState.NativeMethodInfoPtr_GetCharacterState_Public_Abstract_Virtual_New_CharacterState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000D2D14 File Offset: 0x000D0F14
		[CallerCount(0)]
		public unsafe virtual void OnEnterState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyState.NativeMethodInfoPtr_OnEnterState_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000D2D50 File Offset: 0x000D0F50
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyState.NativeMethodInfoPtr_OnUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x000D2D8C File Offset: 0x000D0F8C
		[CallerCount(0)]
		public unsafe virtual void OnExitState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreEnemyState.NativeMethodInfoPtr_OnExitState_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000D2DC8 File Offset: 0x000D0FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48337, RefRangeEnd = 48338, XrefRangeStart = 48317, XrefRangeEnd = 48337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreEnemyState.NativeMethodInfoPtr_TryMove_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00009FD7 File Offset: 0x000081D7
		public DLC4_FlandreEnemyState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x000D2DFC File Offset: 0x000D0FFC
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x00009FE0 File Offset: 0x000081E0
		public unsafe DLC4_FlandreEnemyCharacterController controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyState.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreEnemyCharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyState.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x000D2E2C File Offset: 0x000D102C
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x00009FFF File Offset: 0x000081FF
		public unsafe Action enterCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyState.NativeFieldInfoPtr_enterCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyState.NativeFieldInfoPtr_enterCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000D2E5C File Offset: 0x000D105C
		// (set) Token: 0x06000F88 RID: 3976 RVA: 0x0000A01E File Offset: 0x0000821E
		public unsafe Action exitCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyState.NativeFieldInfoPtr_exitCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyState.NativeFieldInfoPtr_exitCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x000D2E8C File Offset: 0x000D108C
		// (set) Token: 0x06000F8A RID: 3978 RVA: 0x0000A03D File Offset: 0x0000823D
		public unsafe bool moveStateWhenEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyState.NativeFieldInfoPtr_moveStateWhenEnter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreEnemyState.NativeFieldInfoPtr_moveStateWhenEnter)) = value;
			}
		}

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr_enterCallback;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_exitCallback;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_moveStateWhenEnter;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterState_Public_Abstract_Virtual_New_CharacterState_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterState_Public_Virtual_New_Void_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_OnExitState_Public_Virtual_New_Void_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_TryMove_Protected_Void_0;
	}
}
