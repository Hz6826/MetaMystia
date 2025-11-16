using System;
using Common.Audio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Night.BossBattle.DLC4_BossBattle;
using UnityEngine;

// Token: 0x0200000D RID: 13
public class DLC4_GladFlandreCharacterController : DLC4_FlandreEnemyCharacterController
{
	// Token: 0x060000AF RID: 175 RVA: 0x000A1388 File Offset: 0x0009F588
	// Note: this type is marked as 'beforefieldinit'.
	static DLC4_GladFlandreCharacterController()
	{
		Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DLC4_GladFlandreCharacterController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr);
		DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_PARAMETER_JUMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, "PARAMETER_JUMP");
		DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_JumpNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, "m_JumpNum");
		DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_BoxCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, "m_BoxCollider");
		DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_XOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, "m_XOffset");
		DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_JumpAudioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, "m_JumpAudioClip");
		DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_currentJumpNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, "currentJumpNum");
		DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_isJumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, "isJumping");
		DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_jumpManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, "jumpManager");
		DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, 100663382);
		DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_CanAttack_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, 100663383);
		DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_Jump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, 100663384);
		DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_PlayJumpAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, 100663385);
		DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_JumpDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, 100663386);
		DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_JumpUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, 100663387);
		DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, 100663388);
		DLC4_GladFlandreCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, 100663389);
		DLC4_GladFlandreCharacterController.NativeMethodInfoPtr__Initialize_b__8_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr, 100663390);
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x000A150C File Offset: 0x0009F70C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3495, XrefRangeEnd = 3516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, Action afterAttackingFinishCallback, Action afterCompletelyDeadCallback, DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dlc4BossBattleManager);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAttackingFinishCallback);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCompletelyDeadCallback);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attackConditionCheck);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x000A1590 File Offset: 0x0009F790
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3516, XrefRangeEnd = 3518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool CanAttack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_CanAttack_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x000A15D8 File Offset: 0x0009F7D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3518, XrefRangeEnd = 3522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Jump()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_Jump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x000A160C File Offset: 0x0009F80C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3522, XrefRangeEnd = 3526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayJumpAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_PlayJumpAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x000A1640 File Offset: 0x0009F840
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3526, XrefRangeEnd = 3530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JumpDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_JumpDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x000A1674 File Offset: 0x0009F874
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3530, XrefRangeEnd = 3532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JumpUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_JumpUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x000A16A8 File Offset: 0x0009F8A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3532, XrefRangeEnd = 3535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_GladFlandreCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x000A16E4 File Offset: 0x0009F8E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3535, XrefRangeEnd = 3536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLC4_GladFlandreCharacterController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_GladFlandreCharacterController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GladFlandreCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x000A1720 File Offset: 0x0009F920
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3536, XrefRangeEnd = 3547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__8_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_GladFlandreCharacterController.NativeMethodInfoPtr__Initialize_b__8_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0000247C File Offset: 0x0000067C
	public DLC4_GladFlandreCharacterController(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000BA RID: 186 RVA: 0x000A1754 File Offset: 0x0009F954
	// (set) Token: 0x060000BB RID: 187 RVA: 0x00002485 File Offset: 0x00000685
	public unsafe static string PARAMETER_JUMP
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_PARAMETER_JUMP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_PARAMETER_JUMP, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000BC RID: 188 RVA: 0x000A1774 File Offset: 0x0009F974
	// (set) Token: 0x060000BD RID: 189 RVA: 0x00002497 File Offset: 0x00000697
	public unsafe int m_JumpNum
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_JumpNum);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_JumpNum)) = value;
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000BE RID: 190 RVA: 0x000A179C File Offset: 0x0009F99C
	// (set) Token: 0x060000BF RID: 191 RVA: 0x000024B2 File Offset: 0x000006B2
	public unsafe BoxCollider2D m_BoxCollider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_BoxCollider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_BoxCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000C0 RID: 192 RVA: 0x000A17CC File Offset: 0x0009F9CC
	// (set) Token: 0x060000C1 RID: 193 RVA: 0x000024D1 File Offset: 0x000006D1
	public unsafe float m_XOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_XOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_XOffset)) = value;
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x000A17F4 File Offset: 0x0009F9F4
	// (set) Token: 0x060000C3 RID: 195 RVA: 0x000024EC File Offset: 0x000006EC
	public GlobalAudioManager.DelayAudioClip m_JumpAudioClip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_JumpAudioClip);
			return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_m_JumpAudioClip), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060000C4 RID: 196 RVA: 0x000A1824 File Offset: 0x0009FA24
	// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000251A File Offset: 0x0000071A
	public unsafe int currentJumpNum
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_currentJumpNum);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_currentJumpNum)) = value;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x000A184C File Offset: 0x0009FA4C
	// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002535 File Offset: 0x00000735
	public unsafe bool isJumping
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_isJumping);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_isJumping)) = value;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x000A1874 File Offset: 0x0009FA74
	// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002550 File Offset: 0x00000750
	public unsafe JumpState jumpManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_jumpManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<JumpState>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_GladFlandreCharacterController.NativeFieldInfoPtr_jumpManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000071 RID: 113
	private static readonly IntPtr NativeFieldInfoPtr_PARAMETER_JUMP;

	// Token: 0x04000072 RID: 114
	private static readonly IntPtr NativeFieldInfoPtr_m_JumpNum;

	// Token: 0x04000073 RID: 115
	private static readonly IntPtr NativeFieldInfoPtr_m_BoxCollider;

	// Token: 0x04000074 RID: 116
	private static readonly IntPtr NativeFieldInfoPtr_m_XOffset;

	// Token: 0x04000075 RID: 117
	private static readonly IntPtr NativeFieldInfoPtr_m_JumpAudioClip;

	// Token: 0x04000076 RID: 118
	private static readonly IntPtr NativeFieldInfoPtr_currentJumpNum;

	// Token: 0x04000077 RID: 119
	private static readonly IntPtr NativeFieldInfoPtr_isJumping;

	// Token: 0x04000078 RID: 120
	private static readonly IntPtr NativeFieldInfoPtr_jumpManager;

	// Token: 0x04000079 RID: 121
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0;

	// Token: 0x0400007A RID: 122
	private static readonly IntPtr NativeMethodInfoPtr_CanAttack_Public_Virtual_Boolean_0;

	// Token: 0x0400007B RID: 123
	private static readonly IntPtr NativeMethodInfoPtr_Jump_Private_Void_0;

	// Token: 0x0400007C RID: 124
	private static readonly IntPtr NativeMethodInfoPtr_PlayJumpAnimation_Private_Void_0;

	// Token: 0x0400007D RID: 125
	private static readonly IntPtr NativeMethodInfoPtr_JumpDown_Public_Void_0;

	// Token: 0x0400007E RID: 126
	private static readonly IntPtr NativeMethodInfoPtr_JumpUp_Public_Void_0;

	// Token: 0x0400007F RID: 127
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x04000080 RID: 128
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000081 RID: 129
	private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__8_0_Private_Void_0;
}
