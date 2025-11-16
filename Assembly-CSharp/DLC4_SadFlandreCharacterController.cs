using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Night.BossBattle.DLC4_BossBattle;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class DLC4_SadFlandreCharacterController : DLC4_FlandreEnemyCharacterController
{
	// Token: 0x060000E1 RID: 225 RVA: 0x000A1CF0 File Offset: 0x0009FEF0
	// Note: this type is marked as 'beforefieldinit'.
	static DLC4_SadFlandreCharacterController()
	{
		Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DLC4_SadFlandreCharacterController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr);
		DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_END_TRIGGER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, "END_TRIGGER");
		DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_s_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, "s_End");
		DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, "m_ShieldHealth");
		DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, "m_ShieldVisual");
		DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, "m_ShieldSpriteRenderer");
		DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_HitEffectSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, "m_HitEffectSpriteRenderer");
		DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldMinAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, "m_ShieldMinAlpha");
		DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_HitShieldSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, "m_HitShieldSfx");
		DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldBrokenSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, "m_ShieldBrokenSfx");
		DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_currentShieldHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, "currentShieldHealth");
		DLC4_SadFlandreCharacterController.NativeMethodInfoPtr_get_CanBeFrozen_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, 100663398);
		DLC4_SadFlandreCharacterController.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, 100663399);
		DLC4_SadFlandreCharacterController.NativeMethodInfoPtr_ShowHitEffect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, 100663400);
		DLC4_SadFlandreCharacterController.NativeMethodInfoPtr_CalculateRemainingHealth_Protected_Virtual_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, 100663401);
		DLC4_SadFlandreCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, 100663402);
		DLC4_SadFlandreCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, 100663403);
		DLC4_SadFlandreCharacterController.NativeMethodInfoPtr__ShowHitEffect_b__13_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr, 100663405);
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060000E2 RID: 226 RVA: 0x000A1E74 File Offset: 0x000A0074
	public unsafe override bool CanBeFrozen
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_SadFlandreCharacterController.NativeMethodInfoPtr_get_CanBeFrozen_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x000A1EBC File Offset: 0x000A00BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3576, XrefRangeEnd = 3580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, Action afterAttackingFinishCallback, Action afterCompletelyDeadCallback, DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dlc4BossBattleManager);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAttackingFinishCallback);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCompletelyDeadCallback);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attackConditionCheck);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_SadFlandreCharacterController.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x000A1F40 File Offset: 0x000A0140
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3587, RefRangeEnd = 3589, XrefRangeStart = 3580, XrefRangeEnd = 3587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowHitEffect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_SadFlandreCharacterController.NativeMethodInfoPtr_ShowHitEffect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x000A1F74 File Offset: 0x000A0174
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3589, XrefRangeEnd = 3603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void CalculateRemainingHealth(int damage, bool showMercy = false, bool internalInjury = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref damage;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showMercy;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalInjury;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_SadFlandreCharacterController.NativeMethodInfoPtr_CalculateRemainingHealth_Protected_Virtual_Void_Int32_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x000A1FDC File Offset: 0x000A01DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3603, XrefRangeEnd = 3609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_SadFlandreCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x000A2018 File Offset: 0x000A0218
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLC4_SadFlandreCharacterController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_SadFlandreCharacterController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_SadFlandreCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x000A2054 File Offset: 0x000A0254
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3609, XrefRangeEnd = 3610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ShowHitEffect_b__13_0(float alpha)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref alpha;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_SadFlandreCharacterController.NativeMethodInfoPtr__ShowHitEffect_b__13_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x0000265A File Offset: 0x0000085A
	public DLC4_SadFlandreCharacterController(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060000EA RID: 234 RVA: 0x000A2094 File Offset: 0x000A0294
	// (set) Token: 0x060000EB RID: 235 RVA: 0x00002663 File Offset: 0x00000863
	public unsafe static string END_TRIGGER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_END_TRIGGER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_END_TRIGGER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060000EC RID: 236 RVA: 0x000A20B4 File Offset: 0x000A02B4
	// (set) Token: 0x060000ED RID: 237 RVA: 0x00002675 File Offset: 0x00000875
	public unsafe static int s_End
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_s_End, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_s_End, (void*)(&value));
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060000EE RID: 238 RVA: 0x000A20D0 File Offset: 0x000A02D0
	// (set) Token: 0x060000EF RID: 239 RVA: 0x00002683 File Offset: 0x00000883
	public unsafe int m_ShieldHealth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldHealth);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldHealth)) = value;
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060000F0 RID: 240 RVA: 0x000A20F8 File Offset: 0x000A02F8
	// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000269E File Offset: 0x0000089E
	public unsafe Animator m_ShieldVisual
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldVisual);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060000F2 RID: 242 RVA: 0x000A2128 File Offset: 0x000A0328
	// (set) Token: 0x060000F3 RID: 243 RVA: 0x000026BD File Offset: 0x000008BD
	public unsafe SpriteRenderer m_ShieldSpriteRenderer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldSpriteRenderer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x000A2158 File Offset: 0x000A0358
	// (set) Token: 0x060000F5 RID: 245 RVA: 0x000026DC File Offset: 0x000008DC
	public unsafe SpriteRenderer m_HitEffectSpriteRenderer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_HitEffectSpriteRenderer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_HitEffectSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x000A2188 File Offset: 0x000A0388
	// (set) Token: 0x060000F7 RID: 247 RVA: 0x000026FB File Offset: 0x000008FB
	public unsafe float m_ShieldMinAlpha
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldMinAlpha);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldMinAlpha)) = value;
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x000A21B0 File Offset: 0x000A03B0
	// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002716 File Offset: 0x00000916
	public unsafe AudioClip m_HitShieldSfx
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_HitShieldSfx);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_HitShieldSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060000FA RID: 250 RVA: 0x000A21E0 File Offset: 0x000A03E0
	// (set) Token: 0x060000FB RID: 251 RVA: 0x00002735 File Offset: 0x00000935
	public unsafe AudioClip m_ShieldBrokenSfx
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldBrokenSfx);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_m_ShieldBrokenSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060000FC RID: 252 RVA: 0x000A2210 File Offset: 0x000A0410
	// (set) Token: 0x060000FD RID: 253 RVA: 0x00002754 File Offset: 0x00000954
	public unsafe int currentShieldHealth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_currentShieldHealth);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_SadFlandreCharacterController.NativeFieldInfoPtr_currentShieldHealth)) = value;
		}
	}

	// Token: 0x04000090 RID: 144
	private static readonly IntPtr NativeFieldInfoPtr_END_TRIGGER;

	// Token: 0x04000091 RID: 145
	private static readonly IntPtr NativeFieldInfoPtr_s_End;

	// Token: 0x04000092 RID: 146
	private static readonly IntPtr NativeFieldInfoPtr_m_ShieldHealth;

	// Token: 0x04000093 RID: 147
	private static readonly IntPtr NativeFieldInfoPtr_m_ShieldVisual;

	// Token: 0x04000094 RID: 148
	private static readonly IntPtr NativeFieldInfoPtr_m_ShieldSpriteRenderer;

	// Token: 0x04000095 RID: 149
	private static readonly IntPtr NativeFieldInfoPtr_m_HitEffectSpriteRenderer;

	// Token: 0x04000096 RID: 150
	private static readonly IntPtr NativeFieldInfoPtr_m_ShieldMinAlpha;

	// Token: 0x04000097 RID: 151
	private static readonly IntPtr NativeFieldInfoPtr_m_HitShieldSfx;

	// Token: 0x04000098 RID: 152
	private static readonly IntPtr NativeFieldInfoPtr_m_ShieldBrokenSfx;

	// Token: 0x04000099 RID: 153
	private static readonly IntPtr NativeFieldInfoPtr_currentShieldHealth;

	// Token: 0x0400009A RID: 154
	private static readonly IntPtr NativeMethodInfoPtr_get_CanBeFrozen_Public_Virtual_get_Boolean_0;

	// Token: 0x0400009B RID: 155
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_DLC4_BossBattleManager_Action_Action_AttackConditionCheck_0;

	// Token: 0x0400009C RID: 156
	private static readonly IntPtr NativeMethodInfoPtr_ShowHitEffect_Private_Void_0;

	// Token: 0x0400009D RID: 157
	private static readonly IntPtr NativeMethodInfoPtr_CalculateRemainingHealth_Protected_Virtual_Void_Int32_Boolean_Boolean_0;

	// Token: 0x0400009E RID: 158
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x0400009F RID: 159
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040000A0 RID: 160
	private static readonly IntPtr NativeMethodInfoPtr__ShowHitEffect_b__13_0_Private_Void_Single_0;
}
