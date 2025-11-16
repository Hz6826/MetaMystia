using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200007D RID: 125
	public class DLC4_BulletMedicineGiantPoisonBottle : DLC4_BulletTeamParabolic
	{
		// Token: 0x06000D16 RID: 3350 RVA: 0x000CA20C File Offset: 0x000C840C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletMedicineGiantPoisonBottle()
		{
			Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletMedicineGiantPoisonBottle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr);
			DLC4_BulletMedicineGiantPoisonBottle.NativeFieldInfoPtr__AcidPoolBulletProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr, "<AcidPoolBulletProperty>k__BackingField");
			DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr_get_AcidPoolBulletProperty_Private_get_MedicinePoolBullet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr, 100665518);
			DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr_set_AcidPoolBulletProperty_Public_set_Void_MedicinePoolBullet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr, 100665519);
			DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr, 100665520);
			DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr, 100665521);
			DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr, 100665522);
			DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr, 100665523);
			DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr__OnDispose_b__5_0_Private_Void_DLC4_BulletMedicineAcidPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr, 100665524);
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x000CA2DC File Offset: 0x000C84DC
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x000CA314 File Offset: 0x000C8514
		public unsafe DLC4_GuardMedicine.MedicinePoolBullet AcidPoolBulletProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr_get_AcidPoolBulletProperty_Private_get_MedicinePoolBullet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC4_GuardMedicine.MedicinePoolBullet(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44037, XrefRangeEnd = 44038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr_set_AcidPoolBulletProperty_Public_set_Void_MedicinePoolBullet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000CA35C File Offset: 0x000C855C
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enemy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000CA3AC File Offset: 0x000C85AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44038, XrefRangeEnd = 44052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000CA3E8 File Offset: 0x000C85E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43868, RefRangeEnd = 43869, XrefRangeStart = 43868, XrefRangeEnd = 43869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x000CA424 File Offset: 0x000C8624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletMedicineGiantPoisonBottle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletMedicineGiantPoisonBottle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x000CA460 File Offset: 0x000C8660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44052, XrefRangeEnd = 44060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnDispose_b__5_0(DLC4_BulletMedicineAcidPool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletMedicineGiantPoisonBottle.NativeMethodInfoPtr__OnDispose_b__5_0_Private_Void_DLC4_BulletMedicineAcidPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00008D2A File Offset: 0x00006F2A
		public DLC4_BulletMedicineGiantPoisonBottle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x000CA4A4 File Offset: 0x000C86A4
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x00008D33 File Offset: 0x00006F33
		public DLC4_GuardMedicine.MedicinePoolBullet _AcidPoolBulletProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineGiantPoisonBottle.NativeFieldInfoPtr__AcidPoolBulletProperty_k__BackingField);
				return new DLC4_GuardMedicine.MedicinePoolBullet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicinePoolBullet>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletMedicineGiantPoisonBottle.NativeFieldInfoPtr__AcidPoolBulletProperty_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_GuardMedicine.MedicinePoolBullet>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr__AcidPoolBulletProperty_k__BackingField;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_get_AcidPoolBulletProperty_Private_get_MedicinePoolBullet_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_set_AcidPoolBulletProperty_Public_set_Void_MedicinePoolBullet_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Virtual_Void_DLC4_FlandreEnemyCharacterController_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr__OnDispose_b__5_0_Private_Void_DLC4_BulletMedicineAcidPool_0;
	}
}
