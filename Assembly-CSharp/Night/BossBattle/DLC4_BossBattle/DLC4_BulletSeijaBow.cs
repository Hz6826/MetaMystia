using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200007E RID: 126
	public class DLC4_BulletSeijaBow : DLC4_BulletTeamLinear
	{
		// Token: 0x06000D21 RID: 3361 RVA: 0x000CA4D4 File Offset: 0x000C86D4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletSeijaBow()
		{
			Il2CppClassPointerStore<DLC4_BulletSeijaBow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletSeijaBow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletSeijaBow>.NativeClassPtr);
			DLC4_BulletSeijaBow.NativeFieldInfoPtr_canPenetration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletSeijaBow>.NativeClassPtr, "canPenetration");
			DLC4_BulletSeijaBow.NativeFieldInfoPtr_currentPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletSeijaBow>.NativeClassPtr, "currentPower");
			DLC4_BulletSeijaBow.NativeMethodInfoPtr_OnBulletEnable_Public_Void_DLC4_GuardSeija_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletSeijaBow>.NativeClassPtr, 100665525);
			DLC4_BulletSeijaBow.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletSeijaBow>.NativeClassPtr, 100665526);
			DLC4_BulletSeijaBow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletSeijaBow>.NativeClassPtr, 100665527);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x000CA568 File Offset: 0x000C8768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44065, RefRangeEnd = 44066, XrefRangeStart = 44060, XrefRangeEnd = 44065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBulletEnable(DLC4_GuardSeija seijaParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seijaParent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletSeijaBow.NativeMethodInfoPtr_OnBulletEnable_Public_Void_DLC4_GuardSeija_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x000CA5AC File Offset: 0x000C87AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletSeijaBow.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x000CA5E8 File Offset: 0x000C87E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletSeijaBow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletSeijaBow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletSeijaBow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00008D61 File Offset: 0x00006F61
		public DLC4_BulletSeijaBow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x000CA624 File Offset: 0x000C8824
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00008D6A File Offset: 0x00006F6A
		public unsafe bool canPenetration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletSeijaBow.NativeFieldInfoPtr_canPenetration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletSeijaBow.NativeFieldInfoPtr_canPenetration)) = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000CA64C File Offset: 0x000C884C
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00008D85 File Offset: 0x00006F85
		public unsafe float currentPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletSeijaBow.NativeFieldInfoPtr_currentPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletSeijaBow.NativeFieldInfoPtr_currentPower)) = value;
			}
		}

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeFieldInfoPtr_canPenetration;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeFieldInfoPtr_currentPower;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_OnBulletEnable_Public_Void_DLC4_GuardSeija_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
