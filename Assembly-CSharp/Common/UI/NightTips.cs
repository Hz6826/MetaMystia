using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000353 RID: 851
	public class NightTips : MonoBehaviour
	{
		// Token: 0x06006483 RID: 25731 RVA: 0x001EDFFC File Offset: 0x001EC1FC
		// Note: this type is marked as 'beforefieldinit'.
		static NightTips()
		{
			Il2CppClassPointerStore<NightTips>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "NightTips");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightTips>.NativeClassPtr);
			NightTips.NativeFieldInfoPtr_youmuChallengeTips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightTips>.NativeClassPtr, "youmuChallengeTips");
			NightTips.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightTips>.NativeClassPtr, 100684373);
			NightTips.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightTips>.NativeClassPtr, 100684374);
			NightTips.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightTips>.NativeClassPtr, 100684375);
			NightTips.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightTips>.NativeClassPtr, 100684376);
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x001EE090 File Offset: 0x001EC290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258661, XrefRangeEnd = 258686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightTips.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x001EE0C4 File Offset: 0x001EC2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258686, XrefRangeEnd = 258689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightTips.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x001EE0F8 File Offset: 0x001EC2F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72640, RefRangeEnd = 72641, XrefRangeStart = 72640, XrefRangeEnd = 72641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NightTips.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x001EE134 File Offset: 0x001EC334
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NightTips() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightTips>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightTips.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x0003664C File Offset: 0x0003484C
		public NightTips(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x06006489 RID: 25737 RVA: 0x001EE170 File Offset: 0x001EC370
		// (set) Token: 0x0600648A RID: 25738 RVA: 0x00036655 File Offset: 0x00034855
		public unsafe TextMeshProUGUI youmuChallengeTips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightTips.NativeFieldInfoPtr_youmuChallengeTips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightTips.NativeFieldInfoPtr_youmuChallengeTips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042A0 RID: 17056
		private static readonly IntPtr NativeFieldInfoPtr_youmuChallengeTips;

		// Token: 0x040042A1 RID: 17057
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040042A2 RID: 17058
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040042A3 RID: 17059
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040042A4 RID: 17060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
