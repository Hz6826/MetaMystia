using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Night.BossBattle.DLC4_BossBattle;

// Token: 0x0200000C RID: 12
public class DLC4_BulletMedicinePoisonBottle : DLC4_BulletTeamParabolic
{
	// Token: 0x0600009D RID: 157 RVA: 0x000A0F44 File Offset: 0x0009F144
	// Note: this type is marked as 'beforefieldinit'.
	static DLC4_BulletMedicinePoisonBottle()
	{
		Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DLC4_BulletMedicinePoisonBottle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr);
		DLC4_BulletMedicinePoisonBottle.NativeFieldInfoPtr__HasPoison_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, "<HasPoison>k__BackingField");
		DLC4_BulletMedicinePoisonBottle.NativeFieldInfoPtr__PoisonDamage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, "<PoisonDamage>k__BackingField");
		DLC4_BulletMedicinePoisonBottle.NativeFieldInfoPtr__PoisonDuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, "<PoisonDuration>k__BackingField");
		DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_get_HasPoison_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, 100663372);
		DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_set_HasPoison_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, 100663373);
		DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_get_PoisonDamage_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, 100663374);
		DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_set_PoisonDamage_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, 100663375);
		DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_get_PoisonDuration_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, 100663376);
		DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_set_PoisonDuration_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, 100663377);
		DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_OnBulletEnable_Public_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, 100663378);
		DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_AfterHitEnemy_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, 100663379);
		DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, 100663380);
		DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr, 100663381);
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x0600009E RID: 158 RVA: 0x000A1078 File Offset: 0x0009F278
	// (set) Token: 0x0600009F RID: 159 RVA: 0x000A10B4 File Offset: 0x0009F2B4
	public unsafe bool HasPoison
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_get_HasPoison_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_set_HasPoison_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000A0 RID: 160 RVA: 0x000A10F4 File Offset: 0x0009F2F4
	// (set) Token: 0x060000A1 RID: 161 RVA: 0x000A1130 File Offset: 0x0009F330
	public unsafe int PoisonDamage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_get_PoisonDamage_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_set_PoisonDamage_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000A2 RID: 162 RVA: 0x000A1170 File Offset: 0x0009F370
	// (set) Token: 0x060000A3 RID: 163 RVA: 0x000A11AC File Offset: 0x0009F3AC
	public unsafe int PoisonDuration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_get_PoisonDuration_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_set_PoisonDuration_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x000A11EC File Offset: 0x0009F3EC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3486, RefRangeEnd = 3487, XrefRangeStart = 3486, XrefRangeEnd = 3486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBulletEnable(bool hasPoison, int poisonDamage, int poisonDuration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref hasPoison;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poisonDamage;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poisonDuration;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_OnBulletEnable_Public_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x000A1248 File Offset: 0x0009F448
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3487, XrefRangeEnd = 3493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void AfterHitEnemy(DLC4_FlandreEnemyCharacterController enemy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_AfterHitEnemy_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000A1298 File Offset: 0x0009F498
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3493, XrefRangeEnd = 3494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000A12D4 File Offset: 0x0009F4D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3494, XrefRangeEnd = 3495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLC4_BulletMedicinePoisonBottle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletMedicinePoisonBottle>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicinePoisonBottle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002422 File Offset: 0x00000622
	public DLC4_BulletMedicinePoisonBottle(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000A9 RID: 169 RVA: 0x000A1310 File Offset: 0x0009F510
	// (set) Token: 0x060000AA RID: 170 RVA: 0x0000242B File Offset: 0x0000062B
	public unsafe bool _HasPoison_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicinePoisonBottle.NativeFieldInfoPtr__HasPoison_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicinePoisonBottle.NativeFieldInfoPtr__HasPoison_k__BackingField)) = value;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000AB RID: 171 RVA: 0x000A1338 File Offset: 0x0009F538
	// (set) Token: 0x060000AC RID: 172 RVA: 0x00002446 File Offset: 0x00000646
	public unsafe int _PoisonDamage_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicinePoisonBottle.NativeFieldInfoPtr__PoisonDamage_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicinePoisonBottle.NativeFieldInfoPtr__PoisonDamage_k__BackingField)) = value;
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000AD RID: 173 RVA: 0x000A1360 File Offset: 0x0009F560
	// (set) Token: 0x060000AE RID: 174 RVA: 0x00002461 File Offset: 0x00000661
	public unsafe int _PoisonDuration_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicinePoisonBottle.NativeFieldInfoPtr__PoisonDuration_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicinePoisonBottle.NativeFieldInfoPtr__PoisonDuration_k__BackingField)) = value;
		}
	}

	// Token: 0x04000064 RID: 100
	private static readonly IntPtr NativeFieldInfoPtr__HasPoison_k__BackingField;

	// Token: 0x04000065 RID: 101
	private static readonly IntPtr NativeFieldInfoPtr__PoisonDamage_k__BackingField;

	// Token: 0x04000066 RID: 102
	private static readonly IntPtr NativeFieldInfoPtr__PoisonDuration_k__BackingField;

	// Token: 0x04000067 RID: 103
	private static readonly IntPtr NativeMethodInfoPtr_get_HasPoison_Private_get_Boolean_0;

	// Token: 0x04000068 RID: 104
	private static readonly IntPtr NativeMethodInfoPtr_set_HasPoison_Private_set_Void_Boolean_0;

	// Token: 0x04000069 RID: 105
	private static readonly IntPtr NativeMethodInfoPtr_get_PoisonDamage_Private_get_Int32_0;

	// Token: 0x0400006A RID: 106
	private static readonly IntPtr NativeMethodInfoPtr_set_PoisonDamage_Private_set_Void_Int32_0;

	// Token: 0x0400006B RID: 107
	private static readonly IntPtr NativeMethodInfoPtr_get_PoisonDuration_Private_get_Int32_0;

	// Token: 0x0400006C RID: 108
	private static readonly IntPtr NativeMethodInfoPtr_set_PoisonDuration_Private_set_Void_Int32_0;

	// Token: 0x0400006D RID: 109
	private static readonly IntPtr NativeMethodInfoPtr_OnBulletEnable_Public_Void_Boolean_Int32_Int32_0;

	// Token: 0x0400006E RID: 110
	private static readonly IntPtr NativeMethodInfoPtr_AfterHitEnemy_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0;

	// Token: 0x0400006F RID: 111
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x04000070 RID: 112
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
