using System;
using Common.UI;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000129 RID: 297
	public class DLC5_RogueLike_InviteDescriber : MonoBehaviour
	{
		// Token: 0x06002256 RID: 8790 RVA: 0x0011019C File Offset: 0x0010E39C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLike_InviteDescriber()
		{
			Il2CppClassPointerStore<DLC5_RogueLike_InviteDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLike_InviteDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLike_InviteDescriber>.NativeClassPtr);
			DLC5_RogueLike_InviteDescriber.NativeFieldInfoPtr_m_SpecialGuestDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_InviteDescriber>.NativeClassPtr, "m_SpecialGuestDescriber");
			DLC5_RogueLike_InviteDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_SpecialGuest_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_InviteDescriber>.NativeClassPtr, 100669417);
			DLC5_RogueLike_InviteDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_InviteDescriber>.NativeClassPtr, 100669418);
			DLC5_RogueLike_InviteDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_InviteDescriber>.NativeClassPtr, 100669419);
			DLC5_RogueLike_InviteDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_InviteDescriber>.NativeClassPtr, 100669420);
			DLC5_RogueLike_InviteDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_InviteDescriber>.NativeClassPtr, 100669421);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00110244 File Offset: 0x0010E444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83485, XrefRangeEnd = 83487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(SpecialGuest detail, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_InviteDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_SpecialGuest_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x001102A0 File Offset: 0x0010E4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83487, XrefRangeEnd = 83489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_InviteDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x001102D4 File Offset: 0x0010E4D4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 27675, RefRangeEnd = 27686, XrefRangeStart = 27675, XrefRangeEnd = 27686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_InviteDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00110308 File Offset: 0x0010E508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72640, RefRangeEnd = 72641, XrefRangeStart = 72640, XrefRangeEnd = 72641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLike_InviteDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00110344 File Offset: 0x0010E544
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLike_InviteDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLike_InviteDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_InviteDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00014E5F File Offset: 0x0001305F
		public DLC5_RogueLike_InviteDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x00110380 File Offset: 0x0010E580
		// (set) Token: 0x0600225E RID: 8798 RVA: 0x00014E68 File Offset: 0x00013068
		public unsafe SpecialGuestDescriber m_SpecialGuestDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_InviteDescriber.NativeFieldInfoPtr_m_SpecialGuestDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_InviteDescriber.NativeFieldInfoPtr_m_SpecialGuestDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestDescriber;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_SpecialGuest_CancellationToken_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
