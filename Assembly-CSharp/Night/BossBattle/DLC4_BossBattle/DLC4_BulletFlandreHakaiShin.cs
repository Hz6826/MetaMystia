using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200007A RID: 122
	public class DLC4_BulletFlandreHakaiShin : DLC4_BulletEnemy
	{
		// Token: 0x06000CDD RID: 3293 RVA: 0x000C9534 File Offset: 0x000C7734
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletFlandreHakaiShin()
		{
			Il2CppClassPointerStore<DLC4_BulletFlandreHakaiShin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletFlandreHakaiShin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletFlandreHakaiShin>.NativeClassPtr);
			DLC4_BulletFlandreHakaiShin.NativeFieldInfoPtr_moveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletFlandreHakaiShin>.NativeClassPtr, "moveDirection");
			DLC4_BulletFlandreHakaiShin.NativeFieldInfoPtr_targetDeskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletFlandreHakaiShin>.NativeClassPtr, "targetDeskCode");
			DLC4_BulletFlandreHakaiShin.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletFlandreHakaiShin>.NativeClassPtr, "targetPosition");
			DLC4_BulletFlandreHakaiShin.NativeMethodInfoPtr_AfterInitialize_Public_Void_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletFlandreHakaiShin>.NativeClassPtr, 100665480);
			DLC4_BulletFlandreHakaiShin.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletFlandreHakaiShin>.NativeClassPtr, 100665481);
			DLC4_BulletFlandreHakaiShin.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletFlandreHakaiShin>.NativeClassPtr, 100665482);
			DLC4_BulletFlandreHakaiShin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletFlandreHakaiShin>.NativeClassPtr, 100665483);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000C95F0 File Offset: 0x000C77F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43879, RefRangeEnd = 43880, XrefRangeStart = 43869, XrefRangeEnd = 43879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AfterInitialize(int targetDeskCode, Vector3Int targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetDeskCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletFlandreHakaiShin.NativeMethodInfoPtr_AfterInitialize_Public_Void_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000C963C File Offset: 0x000C783C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43880, XrefRangeEnd = 43900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletFlandreHakaiShin.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000C9678 File Offset: 0x000C7878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletFlandreHakaiShin.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000C96B4 File Offset: 0x000C78B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletFlandreHakaiShin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletFlandreHakaiShin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletFlandreHakaiShin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00008BDE File Offset: 0x00006DDE
		public DLC4_BulletFlandreHakaiShin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x000C96F0 File Offset: 0x000C78F0
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00008BE7 File Offset: 0x00006DE7
		public unsafe Vector3 moveDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletFlandreHakaiShin.NativeFieldInfoPtr_moveDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletFlandreHakaiShin.NativeFieldInfoPtr_moveDirection)) = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000C9718 File Offset: 0x000C7918
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00008C02 File Offset: 0x00006E02
		public unsafe int targetDeskCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletFlandreHakaiShin.NativeFieldInfoPtr_targetDeskCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletFlandreHakaiShin.NativeFieldInfoPtr_targetDeskCode)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x000C9740 File Offset: 0x000C7940
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00008C1D File Offset: 0x00006E1D
		public unsafe Vector3 targetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletFlandreHakaiShin.NativeFieldInfoPtr_targetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletFlandreHakaiShin.NativeFieldInfoPtr_targetPosition)) = value;
			}
		}

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeFieldInfoPtr_moveDirection;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeFieldInfoPtr_targetDeskCode;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_AfterInitialize_Public_Void_Int32_Vector3Int_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
