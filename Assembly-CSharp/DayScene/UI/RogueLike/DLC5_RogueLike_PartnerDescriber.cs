using System;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200012A RID: 298
	public class DLC5_RogueLike_PartnerDescriber : MonoBehaviour
	{
		// Token: 0x0600225F RID: 8799 RVA: 0x001103B0 File Offset: 0x0010E5B0
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLike_PartnerDescriber()
		{
			Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLike_PartnerDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr);
			DLC5_RogueLike_PartnerDescriber.NativeFieldInfoPtr_m_Portrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr, "m_Portrayal");
			DLC5_RogueLike_PartnerDescriber.NativeFieldInfoPtr_m_GuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr, "m_GuestName");
			DLC5_RogueLike_PartnerDescriber.NativeFieldInfoPtr_m_PartnerProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr, "m_PartnerProperties");
			DLC5_RogueLike_PartnerDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_SpecialGuest_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr, 100669422);
			DLC5_RogueLike_PartnerDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr, 100669423);
			DLC5_RogueLike_PartnerDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr, 100669424);
			DLC5_RogueLike_PartnerDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr, 100669425);
			DLC5_RogueLike_PartnerDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr, 100669426);
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00110480 File Offset: 0x0010E680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83489, XrefRangeEnd = 83508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(SpecialGuest detail, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_PartnerDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_SpecialGuest_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x001104DC File Offset: 0x0010E6DC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_PartnerDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00110510 File Offset: 0x0010E710
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 27675, RefRangeEnd = 27686, XrefRangeStart = 27675, XrefRangeEnd = 27686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_PartnerDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00110544 File Offset: 0x0010E744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLike_PartnerDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00110580 File Offset: 0x0010E780
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLike_PartnerDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLike_PartnerDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_PartnerDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00014E87 File Offset: 0x00013087
		public DLC5_RogueLike_PartnerDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x001105BC File Offset: 0x0010E7BC
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x00014E90 File Offset: 0x00013090
		public unsafe Image m_Portrayal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_PartnerDescriber.NativeFieldInfoPtr_m_Portrayal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_PartnerDescriber.NativeFieldInfoPtr_m_Portrayal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x001105EC File Offset: 0x0010E7EC
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x00014EAF File Offset: 0x000130AF
		public unsafe TextMeshProUGUI m_GuestName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_PartnerDescriber.NativeFieldInfoPtr_m_GuestName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_PartnerDescriber.NativeFieldInfoPtr_m_GuestName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x0011061C File Offset: 0x0010E81C
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x00014ECE File Offset: 0x000130CE
		public unsafe TextMeshProUGUI m_PartnerProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_PartnerDescriber.NativeFieldInfoPtr_m_PartnerProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_PartnerDescriber.NativeFieldInfoPtr_m_PartnerProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeFieldInfoPtr_m_Portrayal;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeFieldInfoPtr_m_GuestName;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerProperties;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_SpecialGuest_CancellationToken_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
